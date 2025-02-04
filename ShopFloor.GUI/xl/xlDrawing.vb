Public Class xlDrawing
    Inherits xlgDrawing
End Class

Public Class xlgDrawing
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.Drawing)

    Public Sub New()
        MyBase.New(xaeDrawing)
    End Sub

End Class
