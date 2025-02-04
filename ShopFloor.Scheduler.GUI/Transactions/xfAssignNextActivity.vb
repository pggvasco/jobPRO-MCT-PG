Imports UniSource.Helper.GUI

Public Class xfAssignNextActivity

    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Property CLU As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Property Criterion As NHibernate.Criterion.DetachedCriteria
    Public Property LookupType() As Type

    Private Sub SetIcons()
        bbiRefresh.Glyph = UniSource.Helper.GUI.My.Resources.arrow_refresh
    End Sub

    Public Sub SetCLU()
        CLU = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        CLU.Components.Add(gvAssignNextOperation)
    End Sub

    Private Sub xfAssignNextOperation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcons()

        Try
            SetCLU()
        Catch ex As Exception
            Setup.Log.logError("Error setting Component Layout Helper.", ex)
        End Try

        ReloadData()
    End Sub

    Public Sub ReloadData()

        Conversation.Restart()

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                ActivityBindingSource.DataSource = FindAllIsNextActivities()
            End Using

        Catch ex As Exception
            Setup.Log.logError("Error fetching Jobs.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                ArtisanBindingSource.DataSource = API.Artisan.FindAll
                ripbArtisanDuration.Maximum = (Aggregate art As API.Artisan In ArtisanBindingSource.List Into Max(art.EstimatedDuration))
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Artisans.", ex)
        End Try

    End Sub


    Public Function FindAllIsNextActivities() As IEnumerable(Of API.Activity)
        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.Activity)()
        crit.Add(NHibernate.Criterion.Expression.Eq("IsNextActivity", True))
        crit.CreateCriteria("ActivityLogs", NHibernate.SqlCommand.JoinType.LeftOuterJoin).Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.IsNull("CurrentState"), NHibernate.Criterion.Expression.In("CurrentState", New Object() {0, 2, 3})))

        Using New Castle.ActiveRecord.ConversationalScope(Conversation)
            Return API.Activity.FindAll(crit)
        End Using
    End Function

    Private Sub RefreshClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        ReloadData()
    End Sub

    Private Sub beiAutoRefreshRate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beiAutoRefreshRate.EditValueChanged
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

    Private Sub gvAssignNextOperation_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvAssignNextOperation.DoubleClick
        Dim frm As New xfAssignedArtisanOperations
        Dim artisan As New API.Artisan

        Try
            If artisan IsNot Nothing Then
                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    frm.Artisan = artisan
                End Using
                Try
                    frm.Show(Me)
                Catch ex As Exception
                    Setup.Log.logError("Error showing Assigned Artisan Operations form.", ex)
                End Try
            Else
                Setup.Log.logWarn("No Primary Artisan assigned on selected Job.")
            End If
        Catch ex As Exception
            Setup.Log.logError("Error determining Primary Artisan activities on selected Job.", ex)
            Exit Sub
        End Try
    End Sub

    Private Sub gvAssignNextOperation_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvAssignNextOperation.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        Beep()
    End Sub

    Private Sub gvAssignNextOperation_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvAssignNextOperation.ValidateRow
        Dim act As API.Activity = TryCast(e.Row, API.Activity)

        If act IsNot Nothing Then

            If act.Artisan Is Nothing Then
                e.Valid = False
                e.ErrorText = "Please select the Next Artisan."
                gvAssignNextOperation.SetColumnError(colArtisan, "Please select the Next Artisan.")
            End If

            If e.Valid Then
                Try
                    Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                        act.SaveAndFlush()
                    End Using
                Catch ex As Exception
                    Setup.Log.logError("Error assigning next artisan to job.", ex)
                End Try
            End If

        End If

    End Sub

    Private Sub xfAssignNextActivity_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        gvAssignNextOperation.CloseEditor()

        If gvAssignNextOperation.HasColumnErrors Then
            Setup.Log.logError("The grid contains errors, please correct before closing the Activity.")
            e.Cancel = True
            Exit Sub
        End If

    End Sub

  

    Private Sub gvAssignNextOperation_CustomRowCellEdit(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvAssignNextOperation.CustomRowCellEdit
        If e.Column Is colArtisan Then
            Dim act As API.Activity = TryCast(gvAssignNextOperation.GetRow(e.RowHandle), API.Activity)
            If act IsNot Nothing Then
                Dim riglkp As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit = riglkpArtisan.Clone
                riglkp.DataSource = (From art As API.Artisan In ArtisanBindingSource.List Where art.Operations.Contains(act.Operation)).ToList
                e.RepositoryItem = riglkp
            End If
        End If
    End Sub

    Private Sub bbiCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class