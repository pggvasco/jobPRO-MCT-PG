Public Class xaeViewJobActivity
    Inherits xaegJob

    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

    Public Property Job As API.Job
        Get
            If Me.BindingSource IsNot Nothing Then
                Return Me.BindingSource.Current
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.Job)
            BindingSource.Clear()
            If value.ID > 0 Then
                Try
                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                        BindingSource.DataSource = API.Job.Find(value.ID)
                    End Using
                Catch ex As Exception
                    UniSource.Logging.Log.Log.logError(ex.Message, ex)
                End Try
            Else
                BindingSource.Add(value)
            End If
        End Set
    End Property

    Protected Overridable Sub SaveJobActivity()

        If Job IsNot Nothing Then

            Try
                Using c As New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                    Job.SaveAndFlush()
                End Using
            Catch ex As Exception
                UniSource.Logging.Log.Log.logError(ex.Message, ex)
                Me.Conversation.Restart()
            End Try

        Else
            ValidationError(TryCast(Me.BindingSource.Current, API.Job))
            UniSource.Logging.Log.Log.logWarn(TryCast(Me.BindingSource.Current, API.Job))

        End If
    End Sub

    Public Sub BindCustomer()
        Try
            CustomerBindingSource.DataSource = API.Customer.FindAll
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Customer does not exist.", ex)
        End Try
    End Sub

    Public Sub BindOperation()
        Try
            OperationBindingSource.DataSource = API.Operation_.FindAll
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Customer does not exist.", ex)
        End Try
    End Sub


    Public Sub BindJobActivity()
        Try
            JobActivityBindingSource.DataSource = API.Job.FindAll
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Machine does not exist.", ex)
        End Try
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        SaveJobActivity()
    End Sub

    Private Sub xaeViewJobActivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindCustomer()
        BindOperation()
    End Sub

End Class

Public Class xaegViewJobActivity
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of JobCardDataCapturing.API.Job)
End Class