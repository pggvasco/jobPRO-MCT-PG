Public Class xlDrawing
    Inherits xlgDrawing
End Class

Public Class xlgDrawing
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Drawing)

    Public Sub New()
        MyBase.New(GetType(xaeDrawing))
    End Sub

End Class