Public Class ActivityLog

    Public Overridable Property EndDate As DateTime
        Get
            If Me.StartDate.HasValue And Me.Duration.HasValue Then
                Return Me.StartDate.Value.AddMinutes(Me.Duration.Value)
            End If
            Return Nothing
        End Get
        Set(ByVal value As DateTime)
            Me.Duration = value.Subtract(Me.StartDate.Value).TotalMinutes
        End Set
    End Property

    Public Overrides Property Duration As Double?
        Get
            Return MyBase.Duration
        End Get
        Set(ByVal value As Double?)
            MyBase.Duration = value
            NotifyPropertyChanged("EndDate")
        End Set
    End Property

    Public Overridable Property CurrentState As API.ControlScan
        Get
            If MyBase.CurrentStateID Is Nothing Then
                MyBase.CurrentStateID = API.ControlScan.None
            End If
            Return MyBase.CurrentStateID
        End Get
        Set(ByVal value As API.ControlScan)
            MyBase.CurrentStateID = value
            NotifyPropertyChanged("CurrentState")
        End Set
    End Property

    Public Overridable ReadOnly Property Timespan As TimeSpan
        Get
            If Me.Duration.HasValue Then
                Return Timespan.FromMinutes(Me.Duration.Value)
            End If
            Return Nothing
        End Get
    End Property

    Private Property _agent As Pastel.Evolution.Agent
    Public Overridable ReadOnly Property Agent As Pastel.Evolution.Agent
        Get
            If MyBase.AgentID IsNot Nothing Then
                _agent = New Pastel.Evolution.Agent(CType(MyBase.AgentID, Integer))
            End If
            Return _agent
        End Get
    End Property

End Class
