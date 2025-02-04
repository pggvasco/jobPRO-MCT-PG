Public Class xaeJob
    Inherits xaegJob

    Private Sub xaeJob_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            CustomerBindingSource.DataSource = API.Customer.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error fetching Customers.", ex)
        End Try

    End Sub

End Class

Public Class xaegJob
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Job)
End Class
