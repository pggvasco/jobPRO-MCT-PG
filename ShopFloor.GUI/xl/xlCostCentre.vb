Public Class xlCostCentre
    Inherits xlgCostCentre
End Class

Public Class xlgCostCentre
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.CostCentre)

    Public Sub New()
        MyBase.New(xaeCostCentre)
    End Sub

End Class