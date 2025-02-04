Public Class xfAssignPrimaryQIRArtisan 


    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Property CLU As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Property Criterion As NHibernate.Criterion.DetachedCriteria
    Public Property LookupType() As Type

#Region "Load Events"

    Private Sub SetIcons()
        bbiRefresh.Glyph = UniSource.Helper.GUI.My.Resources.arrow_refresh
    End Sub

    Public Sub SetCLH()
        CLU = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        CLU.Components.Add(gvAssignQIR)
    End Sub

    Private Sub xfAssignPrimaryQIRArtisan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcons()

        Try
            SetCLH()
        Catch ex As Exception
            Setup.Log.logError("Error setting Component Layout Helper.", ex)
        End Try

        Try
            ReloadData()
        Catch ex As Exception
            Setup.Log.logError("Error loading Jobs.", ex)
        End Try

    End Sub

#End Region


    Public Sub ReloadData()

        Conversation.Restart()

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
                crit.CreateCriteria("Activities", NHibernate.SqlCommand.JoinType.LeftOuterJoin).CreateCriteria("ActivityLogs", NHibernate.SqlCommand.JoinType.LeftOuterJoin).Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.IsNull("CurrentState"), NHibernate.Criterion.Expression.In("CurrentState", New Object() {0, 2, 3})))
                crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("IsPrimary", True), NHibernate.Criterion.Expression.IsNotNull("IsPrimary")))
                crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("IsQualityImprovementReport", True), NHibernate.Criterion.Expression.IsNotNull("IsQualityImprovementReport")))
                crit.SetResultTransformer(NHibernate.Transform.Transformers.DistinctRootEntity)
                JobBindingSource.DataSource = API.Job.FindAll(crit)
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Jobs.", ex)
            Me.Conversation.Restart()
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                ArtisanBindingSource.DataSource = GetPrimaryArtisans()
                ' ripbArtisanEstimatedDuration.Maximum = (Aggregate art As API.Artisan In ArtisanBindingSource.List Into Max(art.EstimatedDuration))
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Primary Artisans.", ex)
        End Try

    End Sub

    Public Function GetPrimaryArtisans() As IEnumerable(Of API.Artisan)
        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.Artisan)()
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("IsPrimary", True), NHibernate.Criterion.Expression.IsNotNull("IsPrimary")))
            Return API.Artisan.FindAll(crit)
        End Using
    End Function

    Public Function GetSelectedPrimaryArtisan() As API.Artisan
        Dim job As API.Job
        Dim artisan As API.Artisan

        job = CType(gvAssignQIR.GetFocusedRow, API.Job)
        If job IsNot Nothing Then
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                artisan = job.PrimaryArtisan
                Return artisan
            End Using
        Else
            Return Nothing
        End If

    End Function

#Region "Grid Events and Validation"

    Private Sub gvAssignQIR_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim artisan As API.Artisan
        Dim frm As New xfAssignedArtisanOperations

        Dim m As MouseEventArgs = e
        Dim x As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = gvAssignQIR.CalcHitInfo(m.Location)

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                artisan = GetSelectedPrimaryArtisan()
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error determining Primary Artisan on selected Job.", ex)
            Exit Sub
        End Try

        If x.InRow Then
            If Not gvAssignQIR.IsGroupRow(x.RowHandle) Then
                Try
                    If artisan IsNot Nothing Then
                        Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                            frm.Artisan = artisan
                        End Using
                        Try
                            frm.Show(Me)
                        Catch ex As Exception
                            Setup.Log.logError("Error showing Assigned Artisan Operations.", ex)
                        End Try

                    Else
                        Setup.Log.logWarn("No Primary Artisan assigned on selected Job.")
                    End If
                Catch ex As Exception
                    Setup.Log.logError("Error determining Primary Artisan activities on selected Job.", ex)
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    Private Sub gvAssignJob_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs)
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        Beep()
    End Sub

    Private Sub gvAssignJob_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        Dim job As API.Job = TryCast(e.Row, API.Job)

        If job IsNot Nothing Then
            If job.PrimaryArtisan Is Nothing Then
                e.Valid = False
                e.ErrorText = "Please select the Primary Artisan."
                gvAssignQIR.SetColumnError(colArtisan, "Please select the Primary Artisan.")
            End If

            If job.RequiredDeliveryDate Is Nothing Then
                e.Valid = False
                e.ErrorText = "Please select the Required Delivery Date."
                gvAssignQIR.SetColumnError(colRequiredDeliveryDate, "Please select the Required Delivery Date.")
            End If

            If e.Valid Then
                Try
                    Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                        job.SaveAndFlush()
                    End Using
                Catch ex As Exception
                    Setup.Log.logError("Error assigning primary artisan to job.", ex)
                End Try
            End If

        End If

    End Sub

    Private Sub xfAssignPrimaryArtisan_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        gvAssignQIR.CloseEditor()

        If gvAssignQIR.HasColumnErrors Then
            Setup.Log.logError("The grid contains errors, please correct before closing the job.")
            e.Cancel = True
            Exit Sub
        End If

    End Sub

#End Region

#Region "Refresh Grid"

    Private Sub RefreshClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        ReloadData()
    End Sub

    Private Sub beiAutoRefreshRate_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If beiAutoRefreshRate.EditValue IsNot Nothing Then
            Dim arr As DateTime = CType(beiAutoRefreshRate.EditValue, DateTime)

            If arr.TimeOfDay.TotalMilliseconds = 0 Then
                tmRefresh.Stop()
                tmRefresh.Enabled = False
            Else
                tmRefresh.Stop()
                tmRefresh.Enabled = False
                tmRefresh.Interval = arr.TimeOfDay.TotalMilliseconds
                tmRefresh.Enabled = True
                tmRefresh.Start()
            End If
        Else

        End If
    End Sub

    Private Sub tmRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmRefresh.Tick
        ReloadData()
    End Sub

#End Region

    Private Sub btDrawing_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btDrawing.ButtonClick
        Dim job As API.Job = TryCast(gvAssignQIR.GetFocusedRow, API.Job)
        If job IsNot Nothing AndAlso job.Drawing IsNot Nothing AndAlso Not String.IsNullOrEmpty(job.Drawing.DrawingPath) Then
            Try
                Process.Start(job.Drawing.DrawingPath)
            Catch ex As Exception
                Setup.Log.logError(String.Format("Error opening drawing {0} at {1}.", job.Drawing.Code, job.Drawing.DrawingPath), ex)
            End Try
        End If
    End Sub

    Private Sub gvAssignJob_ShowingEditor(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gvAssignQIR.ShowingEditor
        If gvAssignQIR.FocusedColumn IsNot colDrawing Then Exit Sub
        Dim job As API.Job = TryCast(gvAssignQIR.GetFocusedRow, API.Job)
        If job IsNot Nothing AndAlso job.Drawing Is Nothing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub bbiCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class