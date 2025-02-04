Public Class xlWorkCentreCategory
    Inherits xlgWorkCentreCategory
End Class

Public Class xlgWorkCentreCategory
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.WorkCentreCategory)

    Public Sub New()
        MyBase.New(xaeWorkCentreCategory)
    End Sub

End Class