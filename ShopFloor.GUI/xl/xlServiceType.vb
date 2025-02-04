Public Class xlServiceType
    Inherits xlgServiceType

End Class

Public Class xlgServiceType
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.ServiceType)

    Public Sub New()
        MyBase.New(GetType(xaeServiceType))
    End Sub

End Class

