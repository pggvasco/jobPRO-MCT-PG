Public Class xlGeneration
    Inherits xlgGeneration
End Class

Public Class xlgGeneration
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Generation)

    Public Sub New()
        MyBase.New(xaeGeneration)
    End Sub

End Class