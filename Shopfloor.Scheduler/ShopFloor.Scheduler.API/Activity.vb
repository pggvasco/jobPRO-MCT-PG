
Imports Castle.ActiveRecord
Imports Castle.Components.Validator
Imports UniSource
Imports NHibernate.Event
Imports System.Data.SqlClient
Public Class Activity
    Private _customer As API.Customer
    Private _job As API.Job
    Private _activitylogs As ComponentModel.BindingList(Of ActivityLog)
    ' Private WithEvents _activities As ComponentModel.BindingList(Of Activity)

    'Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)


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

            If Me.ActivityLogs IsNot Nothing AndAlso Me.ActivityLogs.Count > 0 Then
                Dim tmpActualStartDate = (Aggregate al As ActivityLog In ActivityLogs Into Min(al.StartDate))
                If MyBase.ActualStartDate Is Nothing OrElse MyBase.ActualStartDate.Value <> tmpActualStartDate.Value Then
                    MyBase.ActualStartDate = tmpActualStartDate
                End If
            End If
            Return MyBase.ActualStartDate
        End Get
        Set(value As Date?)
            MyBase.ActualStartDate = value
            NotifyPropertyChanged("CalculatedEndDate")
        End Set
    End Property

    Public Overridable ReadOnly Property CalculatedEndDate As DateTime
        Get
            If Me.ActualStartDate.HasValue And Me.EstimatedDuration.HasValue Then
                Return Me.ActualStartDate.Value.AddMinutes(Me.EstimatedDuration.Value)
            End If
            Return Nothing
        End Get
    End Property

    Public Overridable Property _actualDuration As Double?
    Public Overrides Property ActualDuration As Double?
        Get
            If _actualDuration Is Nothing Then
                If Me.ActivityLogs.Count > 0 Then
                    _actualDuration = (Aggregate al As ActivityLog In ActivityLogs Into Sum(al.Duration))
                    If MyBase.ActualDuration Is Nothing OrElse MyBase.ActualDuration.Value <> _actualDuration.Value Then
                        MyBase.ActualDuration = _actualDuration
                    End If
                End If
            End If
            Return MyBase.ActualDuration
        End Get
        Set(ByVal value As Double?)
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
        Set(ByVal value As DateTime)
            If Me.EstimatedStartDate.HasValue Then
                Me.EstimatedDuration = value.Subtract(Me.EstimatedStartDate.Value).TotalMinutes
            End If
        End Set
    End Property

    Public Overridable ReadOnly Property ActualEndDate As DateTime?
        Get
            If Me.ActualStartDate.HasValue And Me.ActualDuration.HasValue Then
                Return Me.ActualStartDate.Value.AddMinutes(Me.ActualDuration.Value)
            End If
            Return Nothing
        End Get
    End Property

    Public Overridable ReadOnly Property ActualTimespan As TimeSpan
        Get
            If Me.ActualDuration.HasValue Then
                Return TimeSpan.FromMinutes(Me.ActualDuration.Value)
            End If
            Return Nothing
        End Get
    End Property

    Public Overridable ReadOnly Property EstimatedTimespan As TimeSpan
        Get
            If Me.EstimatedDuration.HasValue Then
                Return TimeSpan.FromMinutes(Me.EstimatedDuration.Value)
            End If
            Return Nothing
        End Get
    End Property

    Private Property _actualArtisanCost As Double?
    Public Overrides Property ActualArtisanCost As Double?
        Get
            If _actualArtisanCost Is Nothing Then
                If Me.ActivityLogs.Count > 0 Then
                    _actualArtisanCost = (Aggregate al As ActivityLog In ActivityLogs Into Sum(al.ArtisanCost))
                    If MyBase.ActualArtisanCost Is Nothing OrElse MyBase.ActualArtisanCost.Value <> _actualArtisanCost.Value Then
                        MyBase.ActualArtisanCost = _actualArtisanCost
                    End If
                End If
            End If
            Return MyBase.ActualArtisanCost
        End Get
        Set(ByVal value As Double?)
            MyBase.ActualArtisanCost = value
        End Set
    End Property

    Private Property _actualMachineCost As Double?
    Public Overrides Property ActualMachineCost As Double?
        Get
            If _actualMachineCost Is Nothing Then
                If Me.ActivityLogs.Count > 0 Then
                    _actualMachineCost = (Aggregate al As ActivityLog In ActivityLogs Into Sum(al.MachineCost))
                    If MyBase.ActualMachineCost Is Nothing OrElse MyBase.ActualMachineCost.Value <> _actualMachineCost.Value Then
                        MyBase.ActualMachineCost = _actualMachineCost
                    End If
                End If
            End If
            Return MyBase.ActualMachineCost
        End Get
        Set(ByVal value As Double?)
            MyBase.ActualMachineCost = value
        End Set
    End Property




    Private Property _actualOperationCost As Double?
    Public Overrides Property ActualOperationCost As Double?
        Get
            If _actualOperationCost Is Nothing Then
                If ActivityLogs IsNot Nothing AndAlso Me.ActivityLogs.Count > 0 Then
                    _actualOperationCost = (Aggregate al As ActivityLog In ActivityLogs Into Sum(al.OperationCost))
                    If MyBase.ActualOperationCost Is Nothing OrElse MyBase.ActualOperationCost.Value <> _actualOperationCost.Value Then
                        MyBase.ActualOperationCost = _actualOperationCost
                    End If
                End If
            End If
            Return MyBase.ActualOperationCost
        End Get
        Set(ByVal value As Double?)
            MyBase.ActualOperationCost = value
        End Set
    End Property

    Private Property _currentState As ControlScan
    Public Overridable ReadOnly Property CurrentState As ControlScan
        Get
            ''''Dim activityLogCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.ActivityLog)()
            ''''activityLogCrit.AddOrder(NHibernate.Criterion.Order.Desc("StartDate"))
            ''''activityLogCrit.SetMaxResults(1)
            ''''activityLogCrit.SetFirstResult(1)
            ''''Dim LastActivityLog As ActivityLog = ActivityLog.FindAll(activityLogCrit).FirstOrDefault
            ''''If LastActivityLog Is Nothing OrElse _currentState <> LastActivityLog.CurrentState Then
            ''''    If LastActivityLog IsNot Nothing Then
            ''''        _currentState = LastActivityLog.CurrentState
            ''''    Else
            ''''        _currentState = ControlScan.None
            ''''    End If
            ''''End If

            ''''If Me.ActivityLogs.Count > 0 Then
            ''''    _currentState = (From al As ActivityLog In ActivityLogs Order By al.StartDate Descending Select al).First.CurrentState
            ''''    '_currentState = (From al As ActivityLog In ActivityLogs Order By al.StartDate Descending Select al).First.CurrentState
            ''''Else
            ''''    _currentState = ControlScan.None
            ''''End If
            ''''If CurrentStateID Is Nothing OrElse CurrentStateID <> _currentState Then
            ''''    CurrentStateID = _currentState
            ''''End If
            If Not CurrentStateID Is Nothing Then
                _currentState = CType(CurrentStateID, ControlScan)
            Else
                _currentState = ControlScan.None
            End If
            Return _currentState
        End Get
    End Property

    Public Overrides Property Operation As Operation
        Get
            Return MyBase.Operation
        End Get
        Set(ByVal value As Operation)
            Try
                If Not Me.IsLoading And value <> MyBase.Operation Then
                    'check if an activity is Primary and if its not already asigned an Artisan
                   SetPrimaryArtisanIfPrimaryActivity
                End If
            Catch ex As Exception
                ' UniSource.Logging.Log.Log.logError("Error Activating Job Activity", ex, True)
            End Try

            MyBase.Operation = value

        End Set

    End Property

    Private Sub SetPrimaryArtisanIfPrimaryActivity()
        Try
            If Me.Operation IsNot Nothing Then
                If Me.Operation.IsPrimary = True And Me.Operation IsNot Nothing AndAlso Me.Artisan Is Nothing Then
                    If Job.PrimaryArtisan IsNot Nothing Then
                        Dim artisanOperation = (From op As Operation In Job.PrimaryArtisan.Operations Where op.ID = Me.Operation.ID).FirstOrDefault
                        If artisanOperation IsNot Nothing Then
                            Me.Artisan = Job.PrimaryArtisan
                        End If

                    End If
                    NotifyPropertyChanged("Artisan")
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub


    Public Overrides Sub Save()
        Dim NewLine As Boolean = False
        If Job Is Nothing Then
            NewLine = True
        End If
        MyBase.Save()
        If NewLine Then
            SetPrimaryArtisanIfPrimaryActivity()
            MyBase.Save()
        End If
    End Sub



    Public Overridable Sub ProcessActuals()
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
            str += String.Format(" by {0}", Me.Artisan.Description)
        End If
        If Me.Machine IsNot Nothing Then
            str += String.Format(" on {0}", Me.Machine.Description)
        End If
        If Me.Part IsNot Nothing Then
            str += String.Format(" for {0}", Me.Part.Description)

        End If
        Return str
        Dim d As String = Me.Description
        If Me.IsQIR = True Then
            d += String.Format("{0} ({1})", Desc, "isQIR")

        End If
        Return d
    End Function

   

    Public Shared Function FindAllActivities() As List(Of Activity)
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of Activity)()

        crit.Add(New NHibernate.Criterion.OrExpression(NHibernate.Criterion.Expression.IsNull("IsNextActivity"), NHibernate.Criterion.Expression.Eq("IsNextActivity", False)))
        Dim result = Activity.FindAll(crit).ToList

        If result IsNot Nothing Then
            Return result
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function FindAllIsNextActivities() As List(Of Activity)
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of Activity)()

        crit.Add(New NHibernate.Criterion.OrExpression(NHibernate.Criterion.Expression.IsNull("IsNextActivity"), NHibernate.Criterion.Expression.Eq("IsNextActivity", True)))

        Dim result = Activity.FindAll(crit).ToList

        If result IsNot Nothing Then
            Return result
        Else
            Return Nothing
        End If
    End Function

    Public Overridable Function GetCopy(ByRef newJob As API.Job, ByRef newStartDate As Date, ByRef maxSequence As Int32) As Activity
        Dim newActivity As New Activity

        'newActivity.Job = newJob

        'COPY
        newActivity.Description = Me.Description
        newActivity.Comments = Me.Comments
        newActivity.Part = Me.Part
        newActivity.Operation = Me.Operation
        newActivity.EstimatedDuration = Me.EstimatedDuration
        newActivity.Machine = Me.Machine
        newActivity.EstimatedOperationCost = Me.EstimatedOperationCost
        newActivity.EstimatedArtisanCost = Me.EstimatedArtisanCost
        newActivity.EstimatedMachineCost = Me.EstimatedMachineCost
        'newActivity.Artisan = Me.Artisan
        newActivity.Quantity = Me.Quantity

        'NEW
        newActivity.IsMaterialAvailable = False
        newActivity.IsActualsPosted = False
        newActivity.IsQIR = False

        'Check if this is an activity import (and not job copy)
        If maxSequence > 0 Then
            newActivity.Sequence = Me.Sequence + maxSequence
        Else
            newActivity.Sequence = Me.Sequence
        End If
        If newActivity.Sequence Is Nothing Then
            newActivity.Sequence = maxSequence
        End If


        'Calculate the new start date based on previous activity estimated end date
        newActivity.EstimatedStartDate = newStartDate

        'If a primary operation, then it is the next (1st) activity
        If newActivity.Operation.IsPrimary = True Then
            newActivity.IsNextActivity = True

        Else
            newActivity.IsNextActivity = False
        End If

        'newActivity.EstimatedEndDate = Me.EstimatedEndDate 'calculated
        'newActivity.EstimatedElapsedDuration = Me.EstimatedElapsedDuration
        'newActivity.EstimatedTimespan = Me.EstimatedTimespan

        Return newActivity
    End Function


    Public Overrides Property Sequence As Integer?
        Get
            If MyBase.Sequence Is Nothing Then
                Return 0
            End If
            Return MyBase.Sequence
        End Get
        Set(value As Integer?)
            MyBase.Sequence = value
        End Set
    End Property


    Public Shared Function GetOrphanActivity() As List(Of Activity)
        Dim OrphanActivityList As New List(Of Activity)

        Dim SqlSelectStatement As String = "Select ussSSActivity.id,Max(cast(ISNULL(IsNextActivity,0)as int))  as IsNextActivity " +
                                           "From ussSSActivity,ussSSJob  " +
                                           "Where Not ussSSActivity.id in(Select ActivityID " +
                                           "			    From ussSSActivityLog " +
                                           "			    Where ID in (Select Max(ID) As ID " +
                                           "							 From ussSSActivityLog  " +
                                           "							 Group By ActivityID) " +
                                           "                And CurrentState = 1) " +
                                           "And ussSSActivity.JobID = ussSSJob.ID " +
                                           "And ussSSJob.JobStateID = 0 " +
                                           "And Not ussSSJob.PrimaryArtisanID is Null " +
                                           "Group By ussSSActivity.id " +
                                           "Having Max(cast(ISNULL(IsNextActivity,0)as int)) = 0 "


        Dim OrphanActivityDatable As DataTable = Pastel.Evolution.DatabaseContext.ExecuteCommandDataTable(SqlSelectStatement)
        For Each row As DataRow In OrphanActivityDatable.Rows
            Try
                Dim OrphanActivity As Activity = Activity.Find(row(0))
                OrphanActivityList.Add(OrphanActivity)
            Catch ex As Exception
            End Try
        Next

        Return OrphanActivityList
    End Function

End Class
