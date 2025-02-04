Public Class xaeAssetClass
    Inherits xaegAssetClass

End Class

Public Class xaegAssetClass
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.AssetClass)

    Public Sub New()
        MyBase.New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

End Class