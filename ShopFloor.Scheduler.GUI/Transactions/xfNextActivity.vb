Imports DevExpress.XtraLayout

Public Class xfNextActivity
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

    Public Property CurrentActivity As API.Activity
    Public Overridable Property NextActivity As API.Activity

    Public Property Job As API.Job
        Get
            If JobBindingSource.Current IsNot Nothing Then
                Return CType(JobBindingSource.Current, API.Job)
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.Job)
            JobBindingSource.Clear()
            If value IsNot Nothing And value.ID > 0 Then
                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    JobBindingSource.Add(API.Job.Find(value.ID))
                End Using
            Else
                JobBindingSource.Add(value)
            End If
        End Set
    End Property

    Public Sub SetFullScreen()
        With Me
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
        End With
    End Sub

    Private Sub xfNextActivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetFullScreen()

        Dim activities As List(Of API.Activity)

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                activities = GetAllUncompletedJobActivities()
            End Using

            If activities.Count > 0 Then
                For Each act As API.Activity In activities
                    Dim activityButton As New DevExpress.XtraEditors.SimpleButton

                    UniSource.Helper.DoubleSize(activityButton, 1, 1, 1, 1)
                    activityButton.MinimumSize = activityButton.Size

                    activityButton.Text = String.Format("({2}) {0} - {1}", act.Operation.Description, act.Description, act.Operation.Code)
                    activityButton.Size = New Drawing.Size((50), (50))
                    activityButton.Tag = act
                    activityButton.Font = New Font(activityButton.Font.FontFamily, activityButton.Font.Size * 1.5)

                    Dim lci As New LayoutControlItem(lcJobActivities, activityButton)
                    lci.TextVisible = False

                    AddHandler activityButton.Click, AddressOf ActivityClicked
                Next
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error fetching Artisan's Activities.", ex)
        End Try

    End Sub

    Public Function GetAllUncompletedJobActivities() As IEnumerable(Of API.Activity)
        Return (From act As API.Activity In Job.ActivityList Where act.CurrentState <> API.ControlScan.Stop And act.Part = CurrentActivity.Part And act <> CurrentActivity).ToList
    End Function

    Public Sub ActivityClicked(ByVal sender As Object, ByVal e As EventArgs)
        Me.NextActivity = CType(sender, DevExpress.XtraEditors.SimpleButton).Tag

        Using New Castle.ActiveRecord.ConversationalScope(Conversation)
            Me.NextActivity.IsNextActivity = True
            Me.NextActivity.SaveAndFlush()
        End Using

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bbiCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bbiManage_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiManage.ItemClick
        Try
            Setup.ManageJobs()
        Catch ex As Exception
            Setup.Log.logError("Error loading management screens.", ex)
        End Try
    End Sub

End Class
