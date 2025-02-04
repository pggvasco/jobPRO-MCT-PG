Public Class xlCustomer
    Inherits xlgCustomer
End Class

Public Class xlgCustomer
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Customer)

    Public Sub New()
        MyBase.New(GetType(xaeCustomer))
    End Sub

End Class