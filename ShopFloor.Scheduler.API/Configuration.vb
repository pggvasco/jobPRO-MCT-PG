Public Class Configuration

    ''' <summary>
    ''' Gets the configuration.
    ''' </summary><returns></returns>
    Shared Function GetConfiguration() As Configuration
        Dim config As Configuration
        config = API.Configuration.FindFirst
        If config Is Nothing Then
            config = New API.Configuration
        End If
        Return config
    End Function

End Class
