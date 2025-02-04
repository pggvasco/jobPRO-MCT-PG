Public Module Context

    Public Property Agent As Pastel.Evolution.Agent
    Public Property ArtisanLogOut As Boolean = False
    Private Property _configuration As Configuration
    Public Property Configuration As Configuration
        Get
            If Agent IsNot Nothing AndAlso _configuration Is Nothing Then
                _configuration = Configuration.GetConfiguration()
            End If
            Return _configuration
        End Get
        Set(value As Configuration)
            _configuration = value
        End Set
    End Property

End Module