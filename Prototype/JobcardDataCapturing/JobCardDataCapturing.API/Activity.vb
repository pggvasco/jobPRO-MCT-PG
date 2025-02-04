Public Class Activity

    Public Overridable Property EndDate As DateTime
        Get
            Try
                Return Me.StartDate.Value.AddHours(Me.Hours.Value)
            Catch ex As Exception
                Return Now
            End Try
        End Get
        Set(ByVal value As DateTime)

        End Set
    End Property

End Class
