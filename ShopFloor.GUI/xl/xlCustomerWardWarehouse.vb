Public Class xlCustomerWardWarehouse 
    Inherits xlgCustomerWardWarehouse

    Public Overrides Sub PreLayout()
        MyBase.bbiAdd.Enabled = False
        Me.AllowDelete = False
        MyBase.PreLayout()
    End Sub
End Class

Public Class xlgCustomerWardWarehouse
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.SFCustomer)

    Public Sub New()
        MyBase.New(xaeCustomerWardWarehouse)
    End Sub

End Class