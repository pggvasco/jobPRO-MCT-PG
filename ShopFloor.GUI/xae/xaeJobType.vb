Public Class xaeJobType
    Inherits xaegJobType

    'Public Property Defaults As API.Defaults

    Private Sub FormLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        JobStageBindingSource.DataSource = API.JobStage.FindAll

        'Try
        '    Defaults = API.Defaults.Defaults
        'Catch ex As Exception
        '    Setup.Log.logError("Error loading System Defaults.", ex)
        'End Try

        Try
            LoadEnums()
        Catch ex As Exception
            Setup.Log.logError("Error populating enums.", ex)
        End Try

        If API.Context.Defaults.RevenueMethod = API.RevenueMethod.JobTypeDefined Then
            RevenueMethodLookUpEdit.Properties.ReadOnly = False
        Else
            RevenueMethodLookUpEdit.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub LoadEnums()
        RevenueMethodLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.RevenueMethod))
    End Sub

    Private Sub RevenueMethodLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevenueMethodLookUpEdit.EditValueChanged
        If IsDBNull(RevenueMethodLookUpEdit.EditValue) OrElse RevenueMethodLookUpEdit.EditValue = API.RevenueMethod.JobTypeDefined Then
            RevenueMethodLookUpEdit.EditValue = API.RevenueMethod.None
        End If
    End Sub
End Class

Public Class xaegJobType
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.JobType)
End Class