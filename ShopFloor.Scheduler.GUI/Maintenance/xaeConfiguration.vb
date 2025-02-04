Public Class xaeConfiguration
    Inherits xaegConfiguration

    Private Sub xaeConfiguration_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Me.Record = API.Configuration.GetConfiguration
        Catch ex As Exception
            Setup.Log.logError("Error fetching Configuration.", ex)
        End Try
        CostCentreMethodLookupEdit.Properties.DataSource = [Enum].GetValues(GetType(API.CostCentreMethod))
        RateMethodLookupEdit.Properties.DataSource = [Enum].GetValues(GetType(API.RateMethod))
    End Sub

End Class

Public Class xaegConfiguration
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Configuration)
End Class
