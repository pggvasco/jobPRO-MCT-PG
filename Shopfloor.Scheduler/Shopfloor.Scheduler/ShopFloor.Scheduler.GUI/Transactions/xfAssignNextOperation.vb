Public Class xfAssignNextOperation 
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Property CLU As New UniSource.Helper.GUI.ComponentLayoutHelper

    Public Property Job As API.Job
        Get
            If Me.JobBindingSource IsNot Nothing Then
                Return Me.JobBindingSource.Current
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.Job)
            JobBindingSource.Clear()
            If value.ID > 0 Then
                Try
                    Conversation.Restart()
                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                        JobBindingSource.DataSource = API.Job.Find(value.ID)
                    End Using
                Catch ex As Exception
                    Setup.Log.logError(ex.Message, ex)
                End Try
            Else
                JobBindingSource.Add(value)
            End If
        End Set
    End Property

    Protected Overridable Sub SaveJob()
        If Job IsNot Nothing Then
            Try
                Using c As New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                    Job.SaveAndFlush()
                End Using
            Catch ex As Exception
                UniSource.Logging.Log.Log.logError(ex.Message, ex)
                Me.Conversation.Restart()
                Exit Sub
            End Try
            Try
                Me.Conversation.Flush()
                Me.Conversation.Dispose()
            Catch ex As Exception
                UniSource.Logging.Log.Log.logError(ex.Message, ex)
            End Try
        Else
            UniSource.Logging.Log.Log.logWarn("No job to save.")
        End If
    End Sub
    Private Sub gvAssignNextOperation_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvAssignNextOperation.DoubleClick
        Dim form As New xfAssignedArtisanOperations

        form.ShowDialog()
    End Sub

    Private Sub xfAssignNextOperation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArtisanBindingSource.DataSource = API.Customer.FindAll
        MachineBindingSource.DataSource = API.Machine.FindAll
        PartBindingSource.DataSource = API.Part.FindAll
        OperationBindingSource.DataSource = API.Operation.FindAll
    End Sub

    Private Sub bbiAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd.ItemClick
        SaveJob()
    End Sub
End Class