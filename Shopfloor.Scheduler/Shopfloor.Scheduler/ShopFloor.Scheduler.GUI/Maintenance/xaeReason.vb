Public Class xaeReason 
    Inherits xaegReason

    Private Sub xaeReason_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class xaegReason
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.ReasonCode)
End Class