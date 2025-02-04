Public Class xlLookupValue
    Inherits xlgLookupValue
End Class

Public Class xlgLookupValue
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.LookupValue)

    Public Sub New()
        MyBase.New(GetType(xaeLookupValues))
    End Sub

End Class
