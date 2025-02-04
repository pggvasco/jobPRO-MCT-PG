Public Class xlChecklistType
    Inherits xlgChecklistType
End Class

Public Class xlgChecklistType
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.ChecklistType)

    Public Sub New()
        MyBase.New(GetType(xaeChecklistType))
    End Sub

End Class
