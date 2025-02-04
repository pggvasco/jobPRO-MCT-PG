Imports Castle.ActiveRecord
Public Class RequestType


    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", MyBase.Code, MyBase.Description)
    End Function

End Class
