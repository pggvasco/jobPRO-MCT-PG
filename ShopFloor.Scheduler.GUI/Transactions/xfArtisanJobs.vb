Imports DevExpress.XtraLayout

Public Class xfArtisanJobs

    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Property CLU As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Overridable Property selectedJob As API.Job

    Public Property Artisan As API.Artisan
        Get
            If ArtisanBindingSource.Current IsNot Nothing Then
                Return CType(ArtisanBindingSource.Current, API.Artisan)
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.Artisan)
            ArtisanBindingSource.Clear()
            If value IsNot Nothing AndAlso value.ID > 0 Then
                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    ArtisanBindingSource.Add(API.Artisan.Find(value.ID))
                End Using
            Else
                ArtisanBindingSource.Add(value)
            End If
        End Set
    End Property

    Public Sub SetFullScreen()
        With Me
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
        End With
    End Sub

    Private Sub xfArtisanJobs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFullScreen()
        CLUhelper()
        LoadJobs()
    End Sub

    Public Sub CLUhelper()
        CLU = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
    End Sub

    Private Sub LoadJobs()
        Dim jobs As List(Of API.Job)
        LayoutControlGroup1.Clear()

        Try
            jobs = GetAllArtisanJobs()

            If jobs IsNot Nothing Then
                For Each job As API.Job In jobs
                    Dim jobButton As New DevExpress.XtraEditors.SimpleButton

                    UniSource.Helper.DoubleSize(jobButton, 1, 1, 1, 1)
                    jobButton.MinimumSize = jobButton.Size

                    jobButton.Text = job.Number & " - " & job.Description & " - " & job.RequiredDeliveryDate
                    jobButton.Size = New Drawing.Size(100, 250)
                    jobButton.Font = New Font(jobButton.Font.FontFamily, jobButton.Font.Size * 1.5)
                    jobButton.Tag = job

                    If Not IIf(job.IsMaterialAvailable.HasValue, job.IsMaterialAvailable, False) Then
                        jobButton.Appearance.ForeColor = Color.Red
                    End If

                    Dim lci As New LayoutControlItem(lcArtisanJobs, jobButton)
                    lci.TextVisible = False

                    AddHandler jobButton.Click, AddressOf ShowArtisanJobActivities
                Next
            Else
                UniSource.Logging.Log.Log.logInfo("There are no jobs for the artisan.")
            End If

        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error fetching Artisan's Jobs.", ex)
        End Try
    End Sub

    Public Function GetAllArtisanJobs() As List(Of API.Job)
        Using New Castle.ActiveRecord.ConversationalScope(Conversation)
            Return (From act As API.Activity In Artisan.ActivityList Where act.CurrentState <> API.ControlScan.Stop Order By act.Job.RequiredDeliveryDate Ascending Select act.Job Distinct).ToList
        End Using

    End Function

    Public Sub ShowArtisanJobActivities(ByVal sender As Object, ByVal e As EventArgs)
        Dim Job As API.Job = CType(sender, DevExpress.XtraEditors.SimpleButton).Tag
        selectedJob = Job
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub bbiLogout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLogout.ItemClick
        If UniSource.Helper.GUI.Dialog.YesNoDialog("Are you sure you want to logoff?", "Logoff") = Windows.Forms.DialogResult.Yes Then
            'Dim arts As New List(Of API.Artisan)
            'arts.Add(Me.Artisan)
            'Dim t As New Threading.Thread(New Threading.ThreadStart(Sub() Setup.ShowArtisanLogonForm(arts)))
            't.Start()
            Me.Close()
        End If
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
