
Public Class xfControlScreen

    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Private Property CLH As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Dim Time As New DateTime
    Private Property FullScreen As Boolean = False

    Public ReadOnly Property Artisan As API.Artisan
        Get
            If ArtisanBindingSource.Current IsNot Nothing Then
                Return CType(ArtisanBindingSource.Current, API.Artisan)
            End If
            Return Nothing
        End Get
    End Property

    Public Property ActiveActivity As API.Activity
        Get
            If ActivityBindingSource.Current IsNot Nothing Then
                Return CType(ActivityBindingSource.Current, API.Activity)
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.Activity)
            ActivityBindingSource.Clear()
            JobBindingSource.Clear()
            ArtisanBindingSource.Clear()
            Try
                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    ActivityBindingSource.Add(API.Activity.Find(value.ID))
                    JobBindingSource.Add(ActiveActivity.Job)
                    ArtisanBindingSource.Add(ActiveActivity.Artisan)
                End Using
            Catch ex As Exception
                Setup.Log.logError(ex.Message, ex)
            End Try
        End Set
    End Property

    Public ReadOnly Property Job As API.Job
        Get
            If JobBindingSource.Current IsNot Nothing Then
                Return CType(JobBindingSource.Current, API.Job)
            End If
            Return Nothing
        End Get
    End Property

    Private Sub XtraForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetCLH()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError(ex.Message)
        End Try

        Try
            SetFullScreen()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError(ex.Message)
        End Try

        Try
            Reset()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError(ex.Message)
        End Try
    End Sub

    Private Sub Reset()
        Select Case Me.ActiveActivity.CurrentState
            Case API.ControlScan.None
                btStart.Enabled = True
                btPause.Enabled = False
                btComplete.Enabled = False
                btCancel.Enabled = True
            Case API.ControlScan.Start
                btStart.Enabled = True
                btPause.Enabled = False
                btComplete.Enabled = False
                btCancel.Enabled = False
            Case API.ControlScan.Pause
                btStart.Enabled = True
                btPause.Enabled = False
                btComplete.Enabled = True
                btCancel.Enabled = True
            Case API.ControlScan.Stop
                btStart.Enabled = False
                btPause.Enabled = False
                btComplete.Enabled = False
                btCancel.Enabled = True
        End Select
    End Sub

    Public Sub SetCLH()
        CLH = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        CLH.Components.Add(lcControls)
        CLH.Components.Add(lcTimeStamp)
        CLH.Components.Add(lcStatus)
        CLH.Components.Add(lcOperationDetails)
        CLH.Components.Add(lcArtisan)
    End Sub

    Public Sub SetFullScreen()
        With Me
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
            .FullScreen = True
        End With

        UniSource.Helper.DoubleSize(btFullScreen, 1, 0, 1, 0)
        UniSource.Helper.DoubleSize(btPause, 1, 0, 1, 0)
        UniSource.Helper.DoubleSize(btStart, 1, 0, 1, 0)
        UniSource.Helper.DoubleSize(btComplete, 1, 0, 1, 0)
        UniSource.Helper.DoubleSize(btViewDrawing, 1, 0, 1, 0)

        Dim timeLayout = New Drawing.Font(txtCurrentStartDate.Font.FontFamily, "16.5")
        txtCurrentStartDate.Font = timeLayout
        lblTime.Font = timeLayout
        lblTime.Top += 16.5 * 2.75
        lblJobOperationNumber.Font = timeLayout
        lblJobOperationNumber.Top += 16.5 * 2.75
        txtActualCurrentDuration.Font = timeLayout
        txtActualTotalDuration.Font = timeLayout
        txtEstimatedEndDate.Font = timeLayout
        CalculatedEndDateTextEdit.Font = timeLayout
        EstimatedTimeTextEdit.Font = timeLayout

        Dim artisanLayout = New Drawing.Font(txtCurrentStartDate.Font.FontFamily, "16.5")
        txtOperationMessage.Font = artisanLayout
        txtOperationDescription.Font = artisanLayout
        txtJobOperationDescription.Font = artisanLayout
        ieArtisan.Font = artisanLayout
        txtArtisanCode.Font = artisanLayout
        txtArtisanDescription.Font = artisanLayout
        dtRequiredDeliveryDate.Font = artisanLayout

        Dim activityDetailsLayout = New Drawing.Font(txtCurrentStartDate.Font.FontFamily, "16.5")
    End Sub

    Public Sub SetWindow()
        With Me
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            .FullScreen = False
        End With

        UniSource.Helper.HalfSize(btFullScreen, 1, 0, 1, 0)
        UniSource.Helper.HalfSize(btPause, 1, 0, 1, 0)
        UniSource.Helper.HalfSize(btStart, 1, 0, 1, 0)
        UniSource.Helper.HalfSize(btComplete, 1, 0, 1, 0)
        UniSource.Helper.HalfSize(btViewDrawing, 1, 0, 1, 0)

        Dim timeLayout = New Drawing.Font(txtCurrentStartDate.Font.FontFamily, "8.25")
        txtCurrentStartDate.Font = timeLayout
        lblTime.Font = timeLayout
        lblTime.Top -= 16.5 * 2.75
        lblJobOperationNumber.Font = timeLayout
        lblJobOperationNumber.Top -= 16.5 * 2.75
        txtActualCurrentDuration.Font = timeLayout
        txtActualTotalDuration.Font = timeLayout
        txtEstimatedEndDate.Font = timeLayout
        CalculatedEndDateTextEdit.Font = timeLayout
        EstimatedTimeTextEdit.Font = timeLayout

        Dim artisanLayout = New Drawing.Font(txtCurrentStartDate.Font.FontFamily, "8.25")
        txtOperationMessage.Font = artisanLayout
        txtJobOperationDescription.Font = artisanLayout
        txtOperationDescription.Font = artisanLayout
        txtArtisanDescription.Font = artisanLayout
        txtArtisanCode.Font = artisanLayout
        dtRequiredDeliveryDate.Font = artisanLayout

        Dim activityDetailsLayout = New Drawing.Font(txtCurrentStartDate.Font.FontFamily, "8.25")
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Dim CurrentDifference As TimeSpan = DateTime.Now.Subtract(Time)
        Dim TotalDifference As TimeSpan = DateTime.Now.Subtract(Time.Subtract(ActiveActivity.ActualTimespan))

        lblTime.Text = DateTime.Now.ToString

        txtActualCurrentDuration.Text = CurrentDifference.Days.ToString & ":" & CurrentDifference.Hours.ToString & ":" & CurrentDifference.Minutes.ToString & ":" & CurrentDifference.Seconds.ToString
        txtActualTotalDuration.Text = TotalDifference.Days.ToString & ":" & TotalDifference.Hours.ToString & ":" & TotalDifference.Minutes.ToString & ":" & TotalDifference.Seconds.ToString
    End Sub

    Public Sub Start()
        Dim log As API.LogActivity

        If ActiveActivity IsNot Nothing Then
            Try
                Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                    log = New API.LogActivity
                    log.Activity = ActiveActivity
                    log.Artisan = ActiveActivity.Artisan
                    log.ControlScan = API.ControlScan.Start
                    log.Log()
                End Using
                Me.ActiveActivity = Me.ActiveActivity
                StartOperation()
            Catch ex As Exception
                Setup.Log.logError("Error setting Logging Start Log.", ex)
            End Try
        End If
    End Sub

    Private Sub StartOperation()
        If Artisan.Operations IsNot Nothing Then
            lblJobOperationNumber.Text = Me.ActiveActivity.Job.Number
            btStart.Enabled = False
            btComplete.Enabled = True
            btPause.Enabled = True
            btCancel.Enabled = False
            If Timer.Enabled = True Then
                Timer.Stop()
            Else
                Time = DateTime.Now
                Timer.Start()
            End If
            txtCurrentStartDate.Text = Date.Now
            txtActualTotalDuration.Text = ActiveActivity.ActualTimespan.Days.ToString & ":" & ActiveActivity.ActualTimespan.Hours.ToString & ":" & ActiveActivity.ActualTimespan.Minutes.ToString & ":" & ActiveActivity.ActualTimespan.Seconds.ToString
        End If
    End Sub

    Public Sub Pause()
        Dim reason As API.ReasonCode
        Dim log As API.LogActivity

        Dim frm As New xfReasonSelect

        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            log = New API.LogActivity
            log.Artisan = ActiveActivity.Artisan
            log.Activity = ActiveActivity
        End Using

        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                reason = API.ReasonCode.Find(frm.Reason.ID)
            End Using
        Else
            Exit Sub
        End If

        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            log.ControlScan = API.ControlScan.Pause
            log.Log()
            If reason IsNot Nothing Then
                log.ActivityLog.ReasonCodeActivityLogs = API.ReasonCode.Find(frm.Reason.ID)
                log.ActivityLog.Save()
            End If
        End Using

        Timer.Stop()

        Me.ActiveActivity = Me.ActiveActivity

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Public Sub Complete()
        Dim log As API.LogActivity

        Dim frm As New xfNextActivity
        frm.Job = Me.Job
        frm.CurrentActivity = Me.ActiveActivity

        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            log = New API.LogActivity
            log.Artisan = ActiveActivity.Artisan
            log.Activity = ActiveActivity
        End Using

        If frm.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            log.ControlScan = API.ControlScan.Stop
            log.Log()
        End Using

        Me.ActiveActivity = Me.ActiveActivity

        Timer.Stop()

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStart.Click
        Try
            Start()
        Catch ex As Exception
            Setup.Log.logError("Error starting activity.", ex)
            Me.ActiveActivity = Me.ActiveActivity
            Reset()
        End Try
    End Sub

    Private Sub btPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPause.Click
        Try
            Pause()
        Catch ex As Exception
            Setup.Log.logError("Error pausing activity.", ex)
            Me.ActiveActivity = Me.ActiveActivity
        End Try
    End Sub

    Private Sub btComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btComplete.Click
        Try
            Complete()
        Catch ex As Exception
            Setup.Log.logError("Error completing activity.", ex)
            Me.ActiveActivity = Me.ActiveActivity
        End Try
    End Sub

    Private Sub btFullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFullScreen.Click
        If Me.FullScreen Then
            SetWindow()
        Else
            SetFullScreen()
        End If
    End Sub

    Private Sub btViewDrawing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewDrawing.Click
        Try
            ViewDrawing()
        Catch ex As Exception
            Setup.Log.logError("Error viewing drawing.", ex)
        End Try
    End Sub

    Private Sub ViewDrawing()
        Dim ofd As New OpenFileDialog
        ofd.AddExtension = True
        ofd.CheckPathExists = True
        ofd.Filter = "Drawing PDF|*.pdf"
        ofd.InitialDirectory = Job.Drawing.DrawingPath
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not String.IsNullOrEmpty(ofd.FileName) Then
                Process.Start(ofd.FileName)
            End If
        End If
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btManage_Click(sender As System.Object, e As System.EventArgs) Handles btManage.Click
        Try
            Setup.ManageJobs()
        Catch ex As Exception
            Setup.Log.logError("Error loading management screens.", ex)
        End Try
    End Sub

    Private Sub QIR()
        Dim qir As New API.QIR
        Dim reason As API.ReasonCode

        Dim xfQIRreason As New xfQIRReasonSelect

        If xfQIRreason.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                reason = API.ReasonCode.Find(xfQIRreason.Reason.ID)
            End Using
        Else
            Exit Sub
        End If

        Dim xfaq As New xfActivityQIR()
        xfaq.ActiveActivity = Me.ActiveActivity

        If xfaq.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                qir.Activity = Me.ActiveActivity
                qir.LogAgentID = Setup.Agent.ID
                qir.LogAgentName = Setup.Agent.Name
                qir.LogDateTime = Now
                qir.ReasonCode = reason
                qir.Save()
            End Using

            If Me.ActiveActivity.CurrentState = API.ControlScan.Start Or Me.ActiveActivity.CurrentState = API.ControlScan.Pause Then
                Try
                    Complete()
                Catch ex As Exception
                    Setup.Log.logError("Error completing activity.", ex)
                End Try
            End If

            Me.ActiveActivity = Me.ActiveActivity
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub btQIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQIR.Click
        Try
            QIR()
        Catch ex As Exception
            Setup.Log.logError("Error during QIR process.", ex)
            Me.ActiveActivity = Me.ActiveActivity
        End Try
    End Sub

End Class
