Public Class xaeActivity 
    Inherits xaegActivity

    Private Sub xaeActivity_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            JobBindingSource.DataSource = API.Job.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error fething Jobs.", ex)
        End Try

        Try
            OperationBindingSource.DataSource = API.Operation.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error fething Operations.", ex)
        End Try

        Try
            ArtisanBindingSource.DataSource = API.Artisan.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error fething Artisans.", ex)
        End Try

        Try
            MachineBindingSource.DataSource = API.Machine.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error fething Machines.", ex)
        End Try

        Try
            PartBindingSource.DataSource = API.Part.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error fething Parts.", ex)
        End Try

    End Sub

End Class

Public Class xaegActivity
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Activity)
End Class
