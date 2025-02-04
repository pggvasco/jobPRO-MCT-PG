Public Class xlLookup
    Inherits xlgLookup

    
End Class

Public Class xlgLookup
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Lookup)

    Public Sub New()
        MyBase.New(GetType(xaeLookup))
    End Sub

End Class