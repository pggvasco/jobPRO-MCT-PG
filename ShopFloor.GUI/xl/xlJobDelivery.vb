Public Class xlJobDelivery
    Inherits xlgJobDelivery
End Class

Public Class xlgJobDelivery
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.JobDelivery)

    Public Sub New()
        MyBase.New(GetType(xaeJobDelivery))
    End Sub

End Class