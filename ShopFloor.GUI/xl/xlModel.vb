Public Class xlModel
    Inherits xlgModel
End Class

Public Class xlgModel
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Model)

    Public Sub New()
        MyBase.New(xaeModel)
    End Sub

End Class