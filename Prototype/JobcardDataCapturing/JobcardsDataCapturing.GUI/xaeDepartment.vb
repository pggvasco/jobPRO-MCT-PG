Public Class xaeDepartment
    Inherits xaegDepartment

    Private Sub xaeDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class xaegDepartment
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of JobCardDataCapturing.API.Department)

End Class