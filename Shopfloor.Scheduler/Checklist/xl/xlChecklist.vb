Public Class xlChecklist
    Inherits xlgChecklist

    Private Sub gcChecklist_Click(sender As System.Object, e As System.EventArgs) Handles gcChecklist.Click

    End Sub
End Class

Public Class xlgChecklist
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Checklist)

    Public Sub New()
        MyBase.New(GetType(xaeChecklist))
    End Sub

End Class