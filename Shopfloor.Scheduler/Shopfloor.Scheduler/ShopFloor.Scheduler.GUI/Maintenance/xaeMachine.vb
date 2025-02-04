Public Class xaeMachine 
    Inherits xaegMachine

    Private Sub xaeMachine_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            CostCentreBindingSource.DataSource = API.CostCentre.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error fetching Cost Centres.", ex)
        End Try

    End Sub

End Class

Public Class xaegMachine
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Machine)
End Class
