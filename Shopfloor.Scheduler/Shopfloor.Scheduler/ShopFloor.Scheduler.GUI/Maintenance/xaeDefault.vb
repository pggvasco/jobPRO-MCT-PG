Public Class xaeDefault 
    Inherits xaegDefault

    Private Sub xaeDefault_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Record = API.Configuration.GetConfiguration
        Catch ex As Exception
            Setup.Log.logError("Error fetching Defaults.", ex)
        End Try

        luCostCentreMethod.Properties.DataSource = [Enum].GetValues(GetType(API.CostCentreMethod))
        luRateMethod.Properties.DataSource = [Enum].GetValues(GetType(API.RateMethod))
    End Sub
End Class

Public Class xaegDefault
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Configuration)
End Class