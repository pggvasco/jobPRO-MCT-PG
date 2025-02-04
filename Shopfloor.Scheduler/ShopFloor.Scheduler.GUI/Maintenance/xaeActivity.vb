Public Class xaeActivity 
    Inherits xaegActivity

    Private Sub xaeActivity_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                JobBindingSource.DataSource = API.Job.FindAll
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fething Jobs.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                OperationBindingSource.DataSource = API.Operation.FindAll
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fething Operations.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                ArtisanBindingSource.DataSource = API.Artisan.FindAll
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fething Artisans.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                MachineBindingSource.DataSource = API.Machine.FindAll
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fething Machines.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                PartBindingSource.DataSource = API.Part.FindAll
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fething Parts.", ex)
        End Try

    End Sub

End Class

Public Class xaegActivity
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Activity)
End Class
