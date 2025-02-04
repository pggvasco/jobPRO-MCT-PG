Public Class xlRequestType
    Inherits xlgRequestType

End Class
Public Class xlgRequestType
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.RequestType)

    Public Sub New()
        MyBase.New(xaeRequestType)
    End Sub

End Class
