Public Class xlChecklistOption
    Inherits xlgChecklistOption
End Class

Public Class xlgChecklistOption
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.ChecklistOption)

    Public Sub New()
        MyBase.New(GetType(xaeCheckListOption))
    End Sub

End Class
