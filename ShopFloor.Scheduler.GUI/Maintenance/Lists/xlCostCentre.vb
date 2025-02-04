Public Class xlCostCentre
    Inherits xlgCostCentre
End Class

Public Class xlgCostCentre
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.CostCentre)

    Public Sub New()
        MyBase.New(GetType(xaeCostCentre))
    End Sub

End Class