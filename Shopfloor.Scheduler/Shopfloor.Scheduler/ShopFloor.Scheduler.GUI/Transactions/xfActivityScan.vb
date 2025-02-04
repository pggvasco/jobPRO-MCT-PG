Public Class xfActivityScan

    Private Property CLH As New UniSource.Helper.GUI.ComponentLayoutHelper
    Private Property FullScreen As Boolean = False

    Public Property Artisan As API.Artisan
        Get
            If ArtisanBindingSource.Current IsNot Nothing Then
                Return CType(ArtisanBindingSource.Current, API.Artisan)
            End If
            Return Nothing
        End Get
        Set(value As API.Artisan)
            ArtisanBindingSource.Clear()
            If value IsNot Nothing Then
                ArtisanBindingSource.DataSource = value
            End If
        End Set
    End Property

    Public Property Activity As API.Activity
        Get
            If ActivityBindingSource.Current IsNot Nothing Then
                Return CType(ActivityBindingSource.Current, API.Activity)
            End If
            Return Nothing
        End Get
        Set(value As API.Activity)
            ActivityBindingSource.Clear()
            JobBindingSource.Clear()
            If value IsNot Nothing Then
                If value IsNot Nothing Then
                    ActivityBindingSource.DataSource = value
                    JobBindingSource.DataSource = value.Job
                End If
            End If
        End Set
    End Property

    Public Property Log As API.LogActivity
        Get
            If LogActivityBindingSource.Current IsNot Nothing Then
                Return CType(LogActivityBindingSource.Current, API.LogActivity)
            End If
            Return Nothing
        End Get
        Set(value As API.LogActivity)
            LogActivityBindingSource.Clear()
            If value IsNot Nothing Then
                LogActivityBindingSource.DataSource = value
            End If
        End Set
    End Property

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FullScreenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullScreenButton.Click
        If Me.FullScreen Then
            SetWindow()
        Else
            SetFullScreen()
        End If
    End Sub

    Private Property ArtisanRecursive As Boolean = False

    Private Sub ArtisanTextEdit_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ArtisanTextEdit.Validating
        If ArtisanTextEdit.EditValue IsNot Nothing And ArtisanTextEdit.EditValue IsNot DBNull.Value And Not String.IsNullOrEmpty(ArtisanTextEdit.EditValue) Then
            If TypeOf ArtisanTextEdit.EditValue Is API.Artisan Then Exit Sub
            If ArtisanRecursive Then Exit Sub

            Dim artisan As API.Artisan
            Dim activeActivity As API.Activity

            Try
                artisan = (From art As API.Artisan In Castle.ActiveRecord.Framework.ActiveRecordLinq.AsQueryable(Of API.Artisan)() Where art.Code.Equals(ArtisanTextEdit.EditValue.ToString) Select art).FirstOrDefault
            Catch ex As Exception
                ArtisanTextEdit.EditValue = Nothing
                ArtisanTextEdit.Focus()
                ArtisanTextEdit.Enabled = True
                ActivityTextEdit.Enabled = False
                ControlScanTextEdit.Enabled = False
                Beep()
                Exit Sub
            End Try

            If artisan IsNot Nothing Then
                Me.Artisan = artisan
                Me.Log.Artisan = artisan
                e.Cancel = True

                Try
                    activeActivity = (From al As API.ActivityLog In Castle.ActiveRecord.Framework.ActiveRecordLinq.AsQueryable(Of API.ActivityLog)() Where CInt(al.Artisan.ID) = CInt(artisan.ID) AndAlso (CInt(al.CurrentState) = CInt(API.ControlScan.Start) OrElse CInt(al.CurrentState) = CInt(API.ControlScan.Pause)) Select al.Activity).FirstOrDefault
                Catch ex As Exception

                End Try

                If activeActivity IsNot Nothing Then
                    Me.Log.Activity = activeActivity
                    Me.Activity = activeActivity
                    JobNumberLabelCotrol.Text = Me.Activity.Job.Number
                    ArtisanTextEdit.Enabled = False
                    ActivityTextEdit.Enabled = False
                    ControlScanTextEdit.Enabled = True
                    ArtisanRecursive = True
                    ControlScanTextEdit.Focus()
                    ArtisanRecursive = False
                Else
                    ArtisanTextEdit.Enabled = False
                    ActivityTextEdit.Enabled = True
                    ControlScanTextEdit.Enabled = False
                    ArtisanRecursive = True
                    ActivityTextEdit.Focus()
                    ArtisanRecursive = False
                End If

            Else
                ArtisanTextEdit.EditValue = Nothing
                ArtisanTextEdit.Focus()
                ArtisanTextEdit.Enabled = True
                ActivityTextEdit.Enabled = False
                ControlScanTextEdit.Enabled = False
                Beep()
                Exit Sub
            End If

        End If
    End Sub

    Private Sub ActivityTextEdit_ParseEditValue(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ActivityTextEdit.Validating
        If ActivityTextEdit.EditValue IsNot Nothing And ActivityTextEdit.EditValue IsNot DBNull.Value And Not String.IsNullOrEmpty(ActivityTextEdit.EditValue) Then
            If TypeOf ActivityTextEdit.EditValue Is API.Activity Then Exit Sub

            Dim activity As API.Activity

            Try
                activity = (From act As API.Activity In Castle.ActiveRecord.Framework.ActiveRecordLinq.AsQueryable(Of API.Activity)() Where CInt(act.ID) = CInt(ActivityTextEdit.EditValue) Select act).FirstOrDefault
            Catch ex As Exception
                ActivityTextEdit.EditValue = Nothing
                ActivityTextEdit.Focus()
                ArtisanTextEdit.Enabled = True
                ActivityTextEdit.Enabled = False
                ControlScanTextEdit.Enabled = True
                Beep()
                Exit Sub
            End Try

            If activity IsNot Nothing Then
                Me.Log.Activity = activity
                Me.Activity = activity

                JobNumberLabelCotrol.Text = Me.Activity.Job.Number
                ArtisanTextEdit.Enabled = False
                ActivityTextEdit.Enabled = False
                ControlScanTextEdit.Enabled = True
                ControlScanTextEdit.Focus()
            Else
                ActivityTextEdit.EditValue = Nothing
                ArtisanTextEdit.Enabled = False
                ActivityTextEdit.Enabled = True
                ControlScanTextEdit.Enabled = False
                ActivityTextEdit.Focus()
                Beep()
                Exit Sub
            End If

        End If
    End Sub

    Private Sub xfActivityScan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt And e.Control And e.KeyCode = Windows.Forms.Keys.F11 Then
            If Me.FullScreen Then
                SetWindow()
            Else
                SetFullScreen()
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            ResetButton_Click(sender, e)
        End If
    End Sub

    Public Sub SetFullScreen()
        With Me
            .TopMost = True
            .FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
            .FullScreen = True
            .FullScreenButton.Visible = False
            .ExitButton.Visible = False
        End With
    End Sub

    Public Sub SetWindow()
        With Me
            .TopMost = False
            .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            .FullScreen = False
            .FullScreenButton.Visible = True
            .ExitButton.Visible = True
        End With
    End Sub

    Public Sub SetCLH()
        CLH.AddSaveEvent(Me, "FormClosing")
        CLH.Components.Add(LayoutControl)
        CLH.Components.Add(ArtisanDataLayoutControl)
        CLH.Components.Add(JobDataLayoutControl)
        CLH.Components.Add(JobDataLayoutControl)
        CLH.Components.Add(ArtisanAcitvityListGridControl)
        CLH.Components.Add(RecentActivityLogsGridControl)
    End Sub

    Private Sub xfActivityScan_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Log = New API.LogActivity
    End Sub

    Private Sub ControlScanTextEdit_EditValueChanged(sender As Object, e As System.EventArgs) Handles ControlScanTextEdit.Validated
        Try
            If CType(ControlScanTextEdit.EditValue, API.ControlScan) <> API.ControlScan.None Then
                Me.Log.Log()
                RecentActivityLogBindingSource.Add(Me.Log.ActivityLog)
                ActivityBindingSource.ResetBindings(False)
            End If
        Catch ex As Exception
            ControlScanTextEdit.EditValue = Nothing
            Beep()
            Exit Sub
        End Try

        Select Case Me.Log.ControlScan
            Case API.ControlScan.None
                If Me.Log.Artisan Is Nothing Then
                    Me.Artisan = Nothing
                    Me.Activity = Nothing
                    Me.Log = New API.LogActivity
                    ArtisanTextEdit.Enabled = True
                    ActivityTextEdit.Enabled = False
                    ControlScanTextEdit.Enabled = False
                    JobNumberLabelCotrol.Text = "Awaiting Scan..."
                    ArtisanTextEdit.Focus()
                    Timer.Stop()
                End If

            Case API.ControlScan.Pause, API.ControlScan.Stop
                Me.Activity = Nothing
                ActivityTextEdit.Focus()
                Me.Log = New API.LogActivity
                Me.Log.Artisan = Me.Artisan
                ArtisanTextEdit.Enabled = False
                ActivityTextEdit.Enabled = True
                ControlScanTextEdit.Enabled = False
                JobNumberLabelCotrol.Text = "Awaiting Scan..."
                Timer.Stop()

            Case API.ControlScan.Start
                Timer.Start()

        End Select
    End Sub

    Private Sub Timer_Tick(sender As Object, e As System.EventArgs) Handles Timer.Tick
        ResetButton_Click(sender, e)
    End Sub

    Private Sub ArtisanTextEdit_InvalidValue(sender As System.Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles ArtisanTextEdit.InvalidValue
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore
    End Sub

    Private Sub ActivityTextEdit_InvalidValue(sender As System.Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles ActivityTextEdit.InvalidValue
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore
    End Sub

    Private Sub ArtisanActivityListGridView_CustomDrawCell(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles ArtisanActivityListGridView.CustomDrawCell, RecentActivityLogsGridView.CustomDrawCell
        If e.Column Is colCurrentState1 Or e.Column Is colCurrentState Then
            Dim state As API.ControlScan = e.CellValue
            Select Case state
                Case API.ControlScan.None
                    e.Appearance.BackColor = Color.White
                Case API.ControlScan.Pause
                    e.Appearance.BackColor = Color.Yellow
                Case API.ControlScan.Start
                    e.Appearance.BackColor = Color.Green
                Case API.ControlScan.Stop
                    e.Appearance.BackColor = Color.Red
            End Select
        End If
    End Sub

    Private Sub ResetButton_Click(sender As System.Object, e As System.EventArgs) Handles ResetButton.Click
        Me.Artisan = Nothing
        Me.Activity = Nothing
        ArtisanTextEdit.Focus()
        Me.Log = New API.LogActivity
        ArtisanTextEdit.Enabled = True
        ActivityTextEdit.Enabled = False
        ControlScanTextEdit.Enabled = False
        JobNumberLabelCotrol.Text = "Awaiting Scan..."
        Timer.Stop()
    End Sub

End Class