Public Class Job

    Private _jobcard As Pastel.Evolution.JobCard
    Public Property JobCard As Pastel.Evolution.JobCard
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
        Protected Friend Set(value As Pastel.Evolution.JobCard)
            _jobcard = value
        End Set
    End Property

    Private _activities As ComponentModel.BindingList(Of Activity)
    Public Overridable Overloads ReadOnly Property ActivityList As ComponentModel.BindingList(Of Activity)
        Get
            If _activities Is Nothing Then
                _activities = New ComponentModel.BindingList(Of Activity)(MyBase.Activities)
            End If
            Return _activities
        End Get
    End Property

    Public Overridable ReadOnly Property LastActivity As Activity
        Get
            Return (From act As Activity In Activities Order By act.ActualEndDate Descending Select act).FirstOrDefault
        End Get
    End Property

    Public Sub CreateJobCard()
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

    Public Sub ProcessActuals()
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
        'Return String.Format("{0} - {1}", MyBase.Number, MyBase.Description)
        Return MyBase.Number
    End Function

End Class
