Public Class LogActivity
    Implements ComponentModel.INotifyPropertyChanged

    Private _artisan As API.Artisan
    Public Overridable Property Artisan As Artisan
        Get
            Return _artisan
        End Get
        Set(value As Artisan)
            _artisan = value
            RaiseEvent PropertyChanged(Me, New ComponentModel.PropertyChangedEventArgs("Artisan"))
        End Set
    End Property

    Private _activity As Activity
    Public Overridable Property Activity As Activity
        Get
            Return _activity
        End Get
        Set(value As Activity)
            _activity = value
            RaiseEvent PropertyChanged(Me, New ComponentModel.PropertyChangedEventArgs("Activity"))
        End Set
    End Property

    Private _controlscan As ControlScan
    Public Overridable Property ControlScan As ControlScan
        Get
            Return _controlscan
        End Get
        Set(value As ControlScan)
            _controlscan = value
            RaiseEvent PropertyChanged(Me, New ComponentModel.PropertyChangedEventArgs("ControlScan"))
        End Set
    End Property

    Public Overridable Property ActivityLog As ActivityLog

    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Public Overridable ReadOnly Property Job As Job
        Get
            If Activity IsNot Nothing Then
                Return Activity.Job
            End If
            Return Nothing
        End Get
    End Property

    Public Sub New()

    End Sub

    Public Sub Log()
        If Artisan Is Nothing Then Throw New ArgumentNullException("Artisan", "No Artisan has been set on the LogActivity.")
        If Activity Is Nothing Then Throw New ArgumentNullException("Activity", "No Activity has been set on the LogActivity.")
        If ControlScan = API.ControlScan.None Then Throw New ArgumentNullException("ControlScan", "No ControlScan has been set on the LogActivity.")

        '' Is there an active ActivityLog for this Activity?
        ActivityLog = (From al As ActivityLog In Activity.ActivityLogs Where al.Activity = Me.Activity And al.Artisan = Me.Artisan And (al.CurrentState = API.ControlScan.Start Or al.CurrentState = API.ControlScan.Pause)).FirstOrDefault

        If ActivityLog IsNot Nothing Then
            Select Case ActivityLog.CurrentState
                Case API.ControlScan.Start
                    '' Only allowed to stop or pause.
                    If Me.ControlScan = API.ControlScan.Start Then Throw New Exception("Activity is already in progress.")
                    ActivityLog.CurrentState = Me.ControlScan
                    ActivityLog.EndDate = Now
                    ActivityLog.LogTime = Now
                    ActivityLog.Save()
                Case API.ControlScan.Pause
                    '' Only allowed to start or stop.
                    If Me.ControlScan = API.ControlScan.Pause Then Throw New Exception("Activity is already paused.")
                    ActivityLog.CurrentState = Me.ControlScan
                    Select Case Me.ControlScan
                        Case API.ControlScan.Start
                            ActivityLog.CurrentState = API.ControlScan.Stop
                            ActivityLog.Save()
                            ActivityLog = New ActivityLog
                            With ActivityLog
                                .CurrentState = Me.ControlScan
                                .Activity = Me.Activity
                                .Artisan = Me.Artisan
                                .StartDate = Now
                                .LogTime = Now
                                .Save()
                            End With
                        Case API.ControlScan.Stop
                            ActivityLog.EndDate = Now
                            ActivityLog.LogTime = Now
                            ActivityLog.Save()
                    End Select
            End Select
        Else
            '' Only allowed to start.
            If Me.ControlScan <> API.ControlScan.Start Then Throw New Exception("Activity has not been started.")
            ActivityLog = New ActivityLog
            With ActivityLog
                .CurrentState = Me.ControlScan
                .Activity = Me.Activity
                .Artisan = Me.Artisan
                .StartDate = Now
                .LogTime = Now
                .Save()
            End With
        End If

    End Sub

End Class
