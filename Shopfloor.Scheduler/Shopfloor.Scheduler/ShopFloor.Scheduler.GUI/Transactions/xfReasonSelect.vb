Public Class xfReasonSelect
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Property CLU As New UniSource.Helper.GUI.ComponentLayoutHelper

    Public Property Job As API.ReasonCode
        Get
            Return ReasonCodeBindingSource.Current
        End Get
        Set(ByVal value As API.ReasonCode)
            ReasonCodeBindingSource.Clear()
            If value.ID > 0 Then
                Try
                    Conversation.Restart()
                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                        ReasonCodeBindingSource.DataSource = API.ReasonCode.Find(value.ID)
                    End Using
                Catch ex As Exception
                    Setup.Log.logError(ex.Message, ex)
                End Try
            Else
                ReasonCodeBindingSource.Add(value)
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
            UniSource.Logging.Log.Log.logWarn("No reason to save.")
        End If
    End Sub
    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        SaveJob()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    Private Sub xfReason_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReasonCodeBindingSource.DataSource = API.ReasonCode.FindAll

        luReason.Properties.DataSource = [Enum].GetValues(GetType(API.ReasonCode))
    End Sub
End Class