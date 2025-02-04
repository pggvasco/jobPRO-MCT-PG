Public Class Configuration

    ''' <summary>
    ''' Gets the configuration.
    ''' </summary><returns></returns>
    Shared Function GetConfiguration() As Configuration
        Dim config As Configuration
        Try
            config = API.Configuration.FindFirst
        Catch ex As Exception
            config = New API.Configuration
        End Try
        If config Is Nothing Then
            config = New API.Configuration
        End If
        Return config
    End Function

End Class
