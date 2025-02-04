Public Class xucChecklist
    Inherits xucgChecklist
End Class

Public Class xucgChecklist
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.Checklist)

    Public Sub New()
        MyBase.New(xaeChecklist)
    End Sub

End Class
