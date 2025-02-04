Public Class xlPart
    Inherits xlgPart
End Class

Public Class xlgPart
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Part)

    Public Sub New()
        MyBase.New(GetType(xaePart))
    End Sub

End Class