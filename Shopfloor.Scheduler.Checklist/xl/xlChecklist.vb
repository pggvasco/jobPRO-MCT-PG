Public Class xlChecklist
    Inherits xlgChecklist
End Class

Public Class xlgChecklist
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Checklist)

    Public Sub New()
        MyBase.New(GetType(xaeChecklist))
    End Sub

End Class