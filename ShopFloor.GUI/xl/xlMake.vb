Public Class xlMake
    Inherits xlgMake
End Class

Public Class xlgMake
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Make)

    Public Sub New()
        MyBase.New(xaeMake)
    End Sub

End Class