Public Class xaeMachine 
    Inherits xaegMachine

    Public Property Machine As API.Machine
        Get
            If Me.BindingSource IsNot Nothing Then
                Return Me.BindingSource.Current
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.Machine)
            BindingSource.Clear()
            If value.ID > 0 Then
                Try
                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                        BindingSource.DataSource = API.Machine.Find(value.ID)
                    End Using
                Catch ex As Exception
                    Setup.Log.logError(ex.Message, ex)
                End Try
            Else
                BindingSource.Add(value)
            End If
        End Set
    End Property

    Private Sub xaeMachine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CostCentreBindingSource.DataSource = API.CostCentre.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error fetching Cost Centres.", ex)
        End Try

        Try
            ChecklistBindingSource.DataSource = Checklist.API.Checklist.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error fetching Checklists.", ex)
        End Try
    End Sub

    Private Sub luChecklist_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luChecklist.EditValueChanged
        If ChecklistBindingSource IsNot Nothing AndAlso Machine IsNot Nothing AndAlso IIf(IsDBNull(luChecklist.EditValue), Nothing, luChecklist.EditValue) IsNot Nothing Then
            Machine.Checklist = CType(luChecklist.EditValue, Checklist.API.Checklist)
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                Machine.Checklist.SetChanged(True)
                'Machine.Checklist.Save()
            End Using

        End If
    End Sub

    Private Sub xaeMachine_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If ChecklistBindingSource IsNot Nothing Then
            If (IIf(IsDBNull(luChecklist.EditValue), Nothing, luChecklist.EditValue) IsNot Nothing) Then
                Machine.Checklist = CType(luChecklist.EditValue, Checklist.API.Checklist)
                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    Machine.Checklist.SaveAndFlush()
                End Using
            End If
        End If
    End Sub

    Private Sub ImagePictureEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagePictureEdit.EditValueChanged
        'MessageBox.Show(ImagePictureEdit.Image.)
    End Sub
End Class

Public Class xaegMachine
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Machine)
End Class
