Public Class xlChecklistLog
    Inherits xlgChecklistLog
End Class

Public Class xlgChecklistLog
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.ChecklistLog)

    Public Sub New()
        MyBase.New()
    End Sub

End Class