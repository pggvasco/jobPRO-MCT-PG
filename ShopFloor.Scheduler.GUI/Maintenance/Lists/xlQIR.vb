Public Class xlQIR
    Inherits xlgQIR

End Class

Public Class xlgQIR
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.QIR)

    Public Sub New()
        MyBase.New()
    End Sub

End Class