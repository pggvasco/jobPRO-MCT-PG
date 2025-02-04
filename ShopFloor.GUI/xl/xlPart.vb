Public Class xlPart
    Inherits xlgPart
End Class

Public Class xlgPart
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.Part)

    Public Sub New()
        MyBase.New(xaePart)
    End Sub

End Class