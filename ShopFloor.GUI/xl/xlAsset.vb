Public Class xlAsset 
    Inherits xlgAsset
End Class

Public Class xlgAsset
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.Asset)

    Public Sub New()
        MyBase.New(GetType(xaeAssets))
    End Sub

End Class

