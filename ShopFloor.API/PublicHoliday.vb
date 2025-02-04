Public Class PublicHoliday
    Public Shared ReadOnly Property PublicHolidayList As List(Of PublicHoliday)
        Get
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.PublicHoliday)()
            crit.Add(NHibernate.Criterion.Expression.Ge("PublicHolidayDate", Now().AddYears(-2).ToString("dd MMMM yyyy")))
            Dim tmpPublicHolidayList As List(Of PublicHoliday) = API.PublicHoliday.FindAll().ToList()
            If tmpPublicHolidayList Is Nothing Then
                tmpPublicHolidayList = New List(Of PublicHoliday)
            End If
            Return tmpPublicHolidayList
        End Get
    End Property

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid
        If IsLoading = False Then
            If Me.PublicHolidayDate Is Nothing Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("PublicHolidayDate")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("PublicHolidayDate"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("PublicHolidayDate")).Add("PublicHolidayDate can not be Nothing")
                valid = False

            End If
            If Me.Description Is Nothing Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Description")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Description"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Description")).Add("Public Holiday Description Missing")
                valid = False

            End If

        End If

        Return valid
    End Function

    Public Shared Function IsHoliday(ByVal StartDate As DateTime) As Boolean
        'Dim publicholiday = API.PublicHoliday.FindAllByProperty("PublicHolidayDate", StartDate.Date).FirstOrDefault()
        'If publicholiday IsNot Nothing Then
        '    Return True
        'Else
        '    Return False
        'End If

        Dim publicholiday = From sPublicHoliday In API.Context.PublicHolidayList
     Where (sPublicHoliday.PublicHolidayDate = StartDate)

        If publicholiday IsNot Nothing AndAlso publicholiday.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Overrides Sub Save()
        If IsValid() Then
            'MyBase.SaveAndFlush()
            MyBase.Save()
        End If
    End Sub
End Class
