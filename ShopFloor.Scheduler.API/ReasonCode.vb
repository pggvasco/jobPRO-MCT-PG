Public Class ReasonCode

    Public Overrides Function ToString() As String
        Return String.Format("{0} - {1}", MyBase.Code, MyBase.Description)
        'Return MyBase.Code
    End Function


End Class
