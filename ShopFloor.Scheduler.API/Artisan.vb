Public Class Artisan

    Private _activities As ComponentModel.BindingList(Of Activity)
    Public Overridable Overloads ReadOnly Property ActivityList As ComponentModel.BindingList(Of Activity)
        Get
            If _activities Is Nothing Then
                _activities = New ComponentModel.BindingList(Of Activity)(MyBase.Activities)
            End If
            Return _activities
        End Get
    End Property

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

    Public Overridable ReadOnly Property EstimatedTimespam As TimeSpan
        Get
            If Me.ActivityList.Count > 0 Then
                Dim duration As Double? = (Aggregate al As Activity In ActivityList Where al.CurrentState <> ControlScan.Stop Into Sum(al.EstimatedDuration))
                If duration.HasValue Then
                    Return TimeSpan.FromMinutes(duration.Value)
                End If
            End If
            Return Nothing
        End Get
    End Property

    Private _estimatedDuration As Double
    Public Overridable ReadOnly Property EstimatedDuration As Double
        Get
            If Me.ActivityList.Count > 0 Then
                Dim duration As Double? = (Aggregate al As Activity In ActivityList Where al.CurrentState <> ControlScan.Stop Into Sum(al.EstimatedDuration))
                If duration.HasValue Then
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

        Dim result As Artisan = Artisan.FindOne(crit)

        Return result
    End Function
End Class
