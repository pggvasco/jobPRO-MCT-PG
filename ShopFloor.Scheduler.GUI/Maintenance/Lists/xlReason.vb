Public Class xlReason
    Inherits xlgReason
End Class

Public Class xlgReason
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.ReasonCode)

    Public Sub New()
        MyBase.New(GetType(xaeReason))
    End Sub

End Class