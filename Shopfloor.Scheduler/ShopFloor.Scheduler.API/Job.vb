Public Class Job

    Private _jobcard As Pastel.Evolution.JobCard

    Public Overridable Property JobCard As Pastel.Evolution.JobCard
        Get
            If _jobcard Is Nothing And JobCardID.HasValue Then
                Try
                    _jobcard = New Pastel.Evolution.JobCard(Me.JobCardID.Value)
                Catch ex As Exception
                    'Throw New Exception("Error creating ERP JobCard.", ex)
                End Try
            End If
            Return _jobcard
        End Get
        Protected Friend Set(ByVal value As Pastel.Evolution.JobCard)
            _jobcard = value
        End Set
    End Property

    Private WithEvents _activities As ComponentModel.BindingList(Of Activity)
    Private WithEvents _artisans As ComponentModel.BindingList(Of Artisan)
    Private WithEvents _operations As ComponentModel.BindingList(Of Operation)
    Private WithEvents _parts As ComponentModel.BindingList(Of Part)

    Public Overridable Overloads ReadOnly Property ActivityList As ComponentModel.BindingList(Of Activity)
        Get
            If _activities Is Nothing Then
                _activities = New ComponentModel.BindingList(Of Activity)(MyBase.Activities)
            End If
            Return _activities
        End Get
    End Property

    Private Property _lastActivity As Activity
    Public Overridable ReadOnly Property LastActivity As Activity
        Get
            If _lastActivity Is Nothing Then
                _lastActivity = (From act As Activity In Activities Order By act.ActualEndDate Descending Select act Where act.ActualEndDate.HasValue).FirstOrDefault
            End If
            Return _lastActivity
        End Get
    End Property

    Public Overrides Property TotalCost As Double?
        Get
            If _activities IsNot Nothing AndAlso _activities.Count > 0 Then
                MyBase.TotalCost = (Aggregate al As Activity In _activities Into Sum(al.ActualOperationCost))
            End If
            Return MyBase.TotalCost
        End Get
        Set(ByVal value As Double?)
            MyBase.TotalCost = value
        End Set
    End Property

    Public Overrides Property ActualEndDate As Date?
        Get
            If _activities IsNot Nothing AndAlso _activities.Count > 0 AndAlso _activities.All(Function(a) a.ActualEndDate.HasValue) Then
                MyBase.ActualEndDate = (Aggregate al As Activity In _activities Where al.ActualEndDate.HasValue Into Max(al.ActualEndDate))
            End If
            Return MyBase.ActualEndDate
        End Get
        Set(ByVal value As Date?)
            MyBase.ActualEndDate = value
        End Set
    End Property

    Public Overrides Property ActualStartDate As Date?
        Get
            If _activities IsNot Nothing AndAlso _activities.Count > 0 AndAlso _activities.All(Function(a) a.ActualStartDate.HasValue) Then
                MyBase.ActualStartDate = (Aggregate al As Activity In _activities Where al.ActualStartDate.HasValue Into Min(al.ActualStartDate))
            End If
            Return MyBase.ActualStartDate
        End Get
        Set(ByVal value As Date?)
            MyBase.ActualStartDate = value
        End Set
    End Property

    Public Overrides Property EstimatedEndDate As Date?
        Get
            If _activities IsNot Nothing AndAlso _activities.Count > 0 Then
                MyBase.EstimatedEndDate = (Aggregate al As Activity In _activities Into Max(al.EstimatedEndDate))
            End If

            Return MyBase.EstimatedEndDate
        End Get
        Set(ByVal value As Date?)
            MyBase.EstimatedEndDate = value
        End Set
    End Property

    Public Overrides Property EstimatedStartDate As Date?
        Get
            If _activities IsNot Nothing AndAlso _activities.Count > 0 Then
                MyBase.EstimatedStartDate = (Aggregate al As Activity In _activities Into Min(al.EstimatedStartDate))
            End If

            Return MyBase.EstimatedStartDate
        End Get
        Set(ByVal value As Date?)
            MyBase.EstimatedStartDate = value
        End Set
    End Property

    Public Overrides Property PrimaryArtisan As Artisan
        Get
            Return MyBase.PrimaryArtisan
        End Get
        Set(ByVal value As Artisan)
            If Not Me.IsLoading AndAlso value <> MyBase.PrimaryArtisan Then
                For Each act As API.Activity In (From a As API.Activity In Me.Activities Where a.Operation.IsPrimary And a.CurrentState <> ControlScan.Stop)
                    act.Artisan = value
                    If act.IsNextActivity Is Nothing Then
                        act.IsNextActivity = True
                    End If
                Next
            End If
            MyBase.PrimaryArtisan = value
        End Set
    End Property
   

    Public Overridable Sub CreateJobCard()
        If JobCard IsNot Nothing Then
            Throw New Exception("ERP JobCard has already been created.")
        End If
        Me.JobCard = New Pastel.Evolution.JobCard
        With Me.JobCard
            .Account = New Pastel.Evolution.Customer(Me.Customer.Code)
            .Code = Me.Number
            .Description = Me.Description
            .Save()
        End With
    End Sub

    Public Overridable Sub ProcessActuals()
        If JobCard Is Nothing Then
            Throw New Exception("ERP JobCard has not been created yet.")
        End If

        Dim errors As New List(Of Exception)

        For Each a As API.Activity In From ac In Me.Activities Where Not CBool(IIf(ac.IsActualsPosted.HasValue, ac.IsActualsPosted.Value, False)) Select ac
            Try
                a.ProcessActuals()
            Catch ex2 As Exception
                errors.Add(ex2)
            End Try
        Next

        If errors.Count > 0 Then
            Throw New AggregateException("The following errors occured when Processing Actuals.", errors)
        End If

    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("{0} - {1}", MyBase.Number, MyBase.Description)
        'Return MyBase.Number
    End Function

    Public Overridable ReadOnly Property PrimaryOperationHours As TimeSpan
        Get
            If Me.ActivityList.Count > 0 Then
                Dim duration As Double? = (Aggregate al As Activity In ActivityList Where CBool(IIf(al.Operation.IsPrimary.HasValue, al.Operation.IsPrimary, False)) Into Sum(al.EstimatedDuration))
                If duration.HasValue Then
                    Return TimeSpan.FromMinutes(duration.Value)
                End If
            End If
            Return Nothing
        End Get
    End Property

    Public Property JobState As API.JobState
        Get
            If Me.JobStateID Is Nothing Then
                Me.JobStateID = API.JobState.Active
            End If
            Return Me.JobStateID
        End Get
        Set(ByVal value As API.JobState)
            Me.JobStateID = value
        End Set
    End Property

    Public Overrides Property JobStateID As Integer?
        Get
            If MyBase.JobStateID Is Nothing Then
                MyBase.JobStateID = API.JobState.Active
            End If
            Return MyBase.JobStateID
        End Get
        Set(ByVal value As Integer?)
            If value Is Nothing Then
                value = API.JobState.Active
            End If
            MyBase.JobStateID = value
        End Set
    End Property

    'CvN - added "Copy Job" button
    Public Function GetJobCopy(ByRef selectedJob As API.Job) As Job
        Dim newJob As New Job
        
        'COPY
        newJob.Description = selectedJob.Description
        newJob.OrderPrice = selectedJob.OrderPrice
        'newJob.PrimaryArtisan = selectedJob.PrimaryArtisan

        'NEW
        newJob.JobDate = Now
        newJob.EstimatedStartDate = Now
        newJob.IsMaterialAvailable = False

        newJob.JobState = JobState.Active
        newJob.JobStateID = API.JobState.Active

        Return newJob
    End Function
    
End Class
