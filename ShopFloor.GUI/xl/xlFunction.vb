Public Class xlFunction
    Inherits xlgFunction
End Class

Public Class xlgFunction
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Function)

    Public Sub New()
        MyBase.New(xaeFunction)
    End Sub

End Class