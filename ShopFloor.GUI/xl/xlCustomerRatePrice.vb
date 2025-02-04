Public Class xlCustomerRatePrice 
    Inherits xlgCustomerRateTime

End Class
Public Class xlgCustomerRateTime
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.SFCustomer)

    Public Sub New()
        MyBase.New(xaeCustomerRateTime)
    End Sub

End Class