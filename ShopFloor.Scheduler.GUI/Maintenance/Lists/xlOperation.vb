Public Class xlOperation
    Inherits xlgOperation

End Class

Public Class xlgOperation
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Operation)

    Public Sub New()
        MyBase.New(GetType(xaeOperation))
    End Sub

End Class