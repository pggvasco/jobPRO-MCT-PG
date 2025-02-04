Public Class ActivityLog

    Public Overridable Property EndDate As DateTime
        Get
            If Me.StartDate.HasValue And Me.Duration.HasValue Then
                Return Me.StartDate.Value.AddMinutes(Me.Duration.Value)
            End If
            Return Nothing
        End Get
        Set(value As DateTime)
            Me.Duration = value.Subtract(Me.StartDate.Value).TotalMinutes
        End Set
    End Property

End Class
