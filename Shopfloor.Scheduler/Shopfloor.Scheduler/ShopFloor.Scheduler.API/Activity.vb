Public Class Activity

    Private _activitylogs As ComponentModel.BindingList(Of ActivityLog)
    Public Overridable Overloads ReadOnly Property ActivityLogList As ComponentModel.BindingList(Of ActivityLog)
        Get
            If _activitylogs Is Nothing Then
                _activitylogs = New ComponentModel.BindingList(Of ActivityLog)(MyBase.ActivityLogs)
            End If
            Return _activitylogs
        End Get
    End Property

    Public Overrides Property ActualStartDate As Date?
        Get
            If Me.ActivityLogs.Count > 0 Then
                MyBase.ActualStartDate = (Aggregate al As ActivityLog In ActivityLogs Into Min(al.StartDate))
            End If
            Return MyBase.ActualStartDate
        End Get
        Set(value As Date?)
            MyBase.ActualStartDate = value
        End Set
    End Property

    Public Overrides Property ActualDuration As Double?
        Get
            If Me.ActivityLogs.Count > 0 Then
                MyBase.ActualDuration = (Aggregate al As ActivityLog In ActivityLogs Into Sum(al.Duration))
            End If
            Return MyBase.ActualDuration
        End Get
        Set(value As Double?)
            MyBase.ActualDuration = value
        End Set
    End Property

    Public Overridable Property EstimatedEndDate As DateTime
        Get
            If Me.EstimatedStartDate.HasValue And Me.EstimatedDuration.HasValue Then
                Return Me.EstimatedStartDate.Value.AddMinutes(Me.EstimatedDuration.Value)
            End If
            Return Nothing
        End Get
        Set(value As DateTime)
            If Me.EstimatedStartDate.HasValue Then
                Me.EstimatedDuration = value.Subtract(Me.EstimatedStartDate.Value).TotalMinutes
            End If
        End Set
    End Property

    Public Overridable ReadOnly Property ActualEndDate As DateTime
        Get
            If Me.ActualStartDate.HasValue And Me.ActualDuration.HasValue Then
                Return Me.ActualStartDate.Value.AddMinutes(Me.ActualDuration.Value)
            End If
            Return Nothing
        End Get
    End Property

    Public Overrides Property ActualArtisanCost As Double?
        Get
            If Me.ActivityLogs.Count > 0 Then
                MyBase.ActualArtisanCost = (Aggregate al As ActivityLog In ActivityLogs Into Sum(al.ArtisanCost))
            End If
            Return MyBase.ActualArtisanCost
        End Get
        Set(value As Double?)
            MyBase.ActualArtisanCost = value
        End Set
    End Property

    Public Overrides Property ActualMachineCost As Double?
        Get
            If Me.ActivityLogs.Count > 0 Then
                MyBase.ActualMachineCost = (Aggregate al As ActivityLog In ActivityLogs Into Sum(al.MachineCost))
            End If
            Return MyBase.ActualMachineCost
        End Get
        Set(value As Double?)
            MyBase.ActualMachineCost = value
        End Set
    End Property

    Public Overrides Property ActualOperationCost As Double?
        Get
            If Me.ActivityLogs.Count > 0 Then
                MyBase.ActualOperationCost = (Aggregate al As ActivityLog In ActivityLogs Into Sum(al.OperationCost))
            End If
            Return MyBase.ActualOperationCost
        End Get
        Set(value As Double?)
            MyBase.ActualOperationCost = value
        End Set
    End Property

    Public ReadOnly Property CurrentState As ControlScan
        Get
            If Me.ActivityLogs.Count > 0 Then
                Return (From al As ActivityLog In ActivityLogs Order By al.StartDate Descending Select al).First.CurrentState
            End If
            Return ControlScan.None
        End Get
    End Property

    Public Sub ProcessActuals()
        If Job.JobCard Is Nothing Then
            Throw New Exception("ERP JobCard has not been created yet.")
        End If
        If Me.Operation Is Nothing Then
            Throw New Exception(String.Format("No Operation has been selected on Activity Sequence #{0} (ID #{1}).", Me.Sequence, Me.ID))
        End If
        If CBool(IIf(Me.IsActualsPosted.HasValue, Me.IsActualsPosted.Value, False)) Then
            Throw New Exception(String.Format("Actuals have already been posted for Activity Sequence #{1} (ID #{2}), Operation '{0}'.", Me.Operation.Code, Me.Sequence, Me.ID))
        End If
        If Not Me.ActualDuration.HasValue Then
            Throw New Exception(String.Format("No actuals captured for Activity Sequence #{1} (ID #{2}), Operation '{0}'.", Me.Operation.Code, Me.Sequence, Me.ID))
        End If

        Select Case Configuration.GetConfiguration.CostCentreMethod
            Case CostCentreMethod.ArtisanMachine
                Throw New NotImplementedException("Processing of actuals by Artisan and Machine is not currently supported.")
            Case CostCentreMethod.Operation
                Dim jd As New Pastel.Evolution.JobDetail
                jd.TransactionCode = Me.Operation.CostCentre.TransactionType
                jd.InventoryItem = Me.Operation.ServiceItem
                jd.Quantity = 1
                jd.BudgetUnitCostPrice = 0
                jd.BudgetUnitSellingPrice = 0
                jd.UnitCostPrice = Me.ActualOperationCost.Value
                jd.UnitSellingPrice = 0
                Job.JobCard.Detail.Add(jd)
                Job.JobCard.Save()
        End Select

    End Sub

    Public Overrides Function ToString() As String
        Dim str As String
        str = Me.Operation.Description
        If Me.Artisan IsNot Nothing Then
            str += " by {0}"
        End If
        If Me.Machine IsNot Nothing Then
            str += " on {1}"
        End If
        If Me.Part IsNot Nothing Then
            str += " with {1}"
        End If
        Return String.Format(str, Me.Artisan, Me.Machine, Me.Part)
    End Function

End Class
