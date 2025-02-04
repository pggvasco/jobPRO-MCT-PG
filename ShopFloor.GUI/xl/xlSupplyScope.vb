Public Class xlSupplyScope
    Inherits xlgSupplyScope
End Class

Public Class xlgSupplyScope
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.SupplyScope)

    Public Sub New()
        MyBase.New(xaeSupplyScope)
    End Sub

End Class