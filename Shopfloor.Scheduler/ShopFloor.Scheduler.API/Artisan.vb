Imports Castle.ActiveRecord
Imports Castle.Components.Validator
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Public Class Artisan

    Private _activities As ComponentModel.BindingList(Of Activity)
    Public Overridable Overloads ReadOnly Property ActivityList As ComponentModel.BindingList(Of Activity)
        Get

            If _activities Is Nothing Then
                '_activities = New ComponentModel.BindingList(Of Activity)(MyBase.Activities)
            End If

            Return _activities

        End Get
    End Property

    Private _activeActivities As ComponentModel.BindingList(Of Activity)
    Public Overridable Overloads ReadOnly Property ActiveActivityList As ComponentModel.BindingList(Of Activity)
        Get
            'Only gets activities that are active
            If _activeActivities Is Nothing Then
                Dim activityCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Activity)()
                activityCrit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("CurrentStateID", CType(ControlScan.Delete, Integer))))
                activityCrit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("CurrentStateID", CType(ControlScan.Stop, Integer))))
                activityCrit.Add(NHibernate.Criterion.Expression.Eq("Artisan", Me))
                activityCrit.CreateAlias("Job", "Job")
                activityCrit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("Job.JobStateID", CType(JobState.Archive, Integer))))
                activityCrit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("Job.JobStateID", CType(JobState.Cancelled, Integer))))
                activityCrit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("Job.JobStateID", CType(JobState.Completed, Integer))))
                activityCrit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("Job.JobStateID", CType(JobState.Deleted, Integer))))
                activityCrit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("Job.JobStateID", CType(JobState.History, Integer))))
                Dim tmpActiveActivityList = API.Activity.FindAll(activityCrit)
                _activeActivities = New ComponentModel.BindingList(Of Activity)(tmpActiveActivityList)
            End If

            Return _activeActivities

        End Get
    End Property

    Public Overridable Sub RefreshActiveActivityList()
        _activeActivities = Nothing
    End Sub



    Public Overridable Property Colour As System.Drawing.Color
        Get
            If Not String.IsNullOrEmpty(MyBase.DBColour) Then
                Return System.Drawing.Color.FromName(MyBase.DBColour)
            End If
            Return Nothing
        End Get
        Set(ByVal value As System.Drawing.Color)
            MyBase.DBColour = value.Name
        End Set
    End Property

    Public Overrides Function ToString() As String
        'Return String.Format("{0} - {1}", MyBase.Code, MyBase.Description)
        Return MyBase.Code
    End Function
   

    Public Overridable Property _estimatedTimespam As TimeSpan
    Public Overridable ReadOnly Property EstimatedTimespam As TimeSpan
        Get
            If _estimatedTimespam.Minutes <> EstimatedDuration Then
                'If Me.ActivityList.Count > 0 Then
                '    Dim duration As Double? = (Aggregate al As Activity In ActivityList Where al.CurrentState <> ControlScan.Delete AndAlso al.CurrentState <> ControlScan.Stop AndAlso al.Job IsNot Nothing AndAlso al.Job.JobState = JobState.Active Into Sum(al.EstimatedDuration))
                '    If duration.HasValue Then
                '        _estimatedTimespam = TimeSpan.FromMinutes(duration.Value)
                '    End If
                'End If
                _estimatedTimespam = TimeSpan.FromMinutes(EstimatedDuration)
            End If
            Return _estimatedTimespam
        End Get
    End Property

    Private _estimatedDuration As Double
    Public Overridable ReadOnly Property EstimatedDuration As Double
        Get
            'Return 0
            'If _estimatedDuration = 0 Then
            '    Dim activityCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Activity)()
            '    'activityCrit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("CurrentState", CType(ControlScan.Delete, Integer))))
            '    'activityCrit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("CurrentState", CType(ControlScan.Stop, Integer))))
            '    'activityCrit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("CurrentState", CType(ControlScan.Delete, Integer))))
            '    activityCrit.Add(NHibernate.Criterion.Expression.Eq("Artisan", Me))
            '    activityCrit.CreateAlias("Job", "Job")
            '    activityCrit.Add(NHibernate.Criterion.Expression.Eq("Job.JobStateID", CType(JobState.Active, Integer)))
            '    Dim ActiveActivityList = API.Activity.FindAll(activityCrit)
            '    Dim duration As Double? = (Aggregate al As Activity In ActiveActivityList Where al.CurrentState <> ControlScan.Delete AndAlso al.CurrentState <> ControlScan.Stop AndAlso al.Job IsNot Nothing AndAlso al.Job.JobState = JobState.Active Into Sum(al.EstimatedDuration))
            '    If duration.HasValue AndAlso duration <> _estimatedDuration Then
            '        _estimatedDuration = duration.Value
            '    End If
            'End If

            If Me.ActiveActivityList.Count > 0 And _estimatedDuration = 0 Then
                Dim duration As Double? = (Aggregate al As Activity In ActiveActivityList Where al.CurrentState <> ControlScan.Delete AndAlso al.CurrentState <> ControlScan.Stop AndAlso al.Job IsNot Nothing AndAlso al.Job.JobState = JobState.Active Into Sum(al.EstimatedDuration))
                If duration.HasValue AndAlso duration <> _estimatedDuration Then
                    _estimatedDuration = duration.Value
                End If
            End If
            Return _estimatedDuration
        End Get
    End Property


    Public Shared Function FindByCodeAndPassword(ByVal code As String, ByVal password As String) As Artisan
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of Artisan)()
        crit.Add(NHibernate.Criterion.Expression.Eq("Code", code))
        crit.Add(NHibernate.Criterion.Expression.Eq("Password", password))
        crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Inactive", False), NHibernate.Criterion.Expression.IsNull("Inactive")))
        Dim result As Artisan = Artisan.FindOne(crit)

        Return result
    End Function

    Private _machines As IList(Of Machine) = New List(Of Machine)()
    <HasAndBelongsToMany(GetType(Machine), ColumnRef:="MachineID", ColumnKey:="ArtisanID", Lazy:=True, Table:="ussSSMachineArtisans")>
    Public Overridable Property Machines() As IList(Of Machine)
        Get
            Return Me._machines
        End Get
        Set(ByVal value As IList(Of Machine))
            Me._machines = value
            NotifyPropertyChanged("Machines")
        End Set
    End Property

    Public Overrides Property Inactive As Boolean?
        Get
            If MyBase.Inactive Is Nothing Then
                MyBase.Inactive = False
            End If
            Return MyBase.Inactive
        End Get
        Set(value As Boolean?)
            MyBase.Inactive = value
        End Set
    End Property
   
End Class
