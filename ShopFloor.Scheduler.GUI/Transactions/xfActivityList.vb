Imports DevExpress.XtraLayout

Public Class xfActivityList

    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

    Private _artisan As API.Artisan
    Public Overridable Property Artisan As API.Artisan
        Get
            Return _artisan
        End Get
        Set(value As API.Artisan)
            If value IsNot Nothing AndAlso value.ID > 0 Then
                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    _artisan = API.Artisan.Find(value.ID)
                End Using
            End If
        End Set
    End Property

    Public Overridable Property Job As API.Job
    Public Overridable Property Activity As API.Activity

    Public Sub SetFullScreen()
        With Me
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
        End With
    End Sub

    Private Sub xfActivityList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFullScreen()

        'JobNumberLabel.Text = Job.Number

        Try
            ShowActivityButtons()
        Catch ex As Exception
            Setup.Log.logError("Error displaying activities.", ex)
        End Try

    End Sub

    Private Sub ShowActivityButtons()
        For Each activity As API.Activity In GetActivities()

            Dim activityButton As New DevExpress.XtraEditors.SimpleButton
            If activity.Part IsNot Nothing Then
                activityButton.Text = String.Format("({2}) {0} - ({3}) {1}", activity.Part.Description, activity.Description, activity.Part.Code, activity.Operation.Code)
            Else
                activityButton.Text = String.Format("({0}) - {1}", activity.Operation.Code, activity.Description)
            End If
            UniSource.Helper.DoubleSize(activityButton, 1, 1, 1, 1)
            activityButton.MinimumSize = activityButton.Size

            If Not IIf(activity.IsMaterialAvailable.HasValue, activity.IsMaterialAvailable, False) Then
                activityButton.Appearance.ForeColor = Color.Red
            End If

            activityButton.Font = New Font(activityButton.Font.FontFamily, activityButton.Font.Size * 1.5)

            activityButton.Tag = activity

            Dim lci As New LayoutControlItem(lcActivityList, activityButton)
            lci.TextVisible = False

            AddHandler activityButton.Click, AddressOf ActivityClicked
        Next
    End Sub

    Public Function GetActivities() As List(Of API.Activity)
        Using New Castle.ActiveRecord.ConversationalScope(Conversation)
            Return (From act As API.Activity In Artisan.ActivityList Where act.CurrentState <> API.ControlScan.Stop And act.Job = Job).ToList
        End Using
    End Function

    Public Sub ActivityClicked(ByVal sender As Object, ByVal e As EventArgs)
        Me.Activity = CType(sender, DevExpress.XtraEditors.SimpleButton).Tag
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
