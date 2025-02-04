Public Class xlRequisition
    Inherits xlgRequisition

End Class

Public Class xlgRequisition
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.Requisition)

    Public Sub New()
        MyBase.New(xaeRequisition)
    End Sub

End Class
