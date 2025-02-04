Public Class xlCancelReasonCode
    Inherits xlgCancelReasonCode

End Class

Public Class xlgCancelReasonCode
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.CancelReasonCode)

    Public Sub New()
        MyBase.New(GetType(xaeCancelReasonCode))
    End Sub

End Class