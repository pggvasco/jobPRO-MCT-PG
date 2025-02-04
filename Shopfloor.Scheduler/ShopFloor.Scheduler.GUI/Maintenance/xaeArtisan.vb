Public Class xaeArtisan
    Inherits xaegArtisan

    Private Sub xaeMachine_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                MachineBindingSource.DataSource = API.Machine.FindAll
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Machine list.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                CostCentreBindingSource.DataSource = API.CostCentre.FindAll
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Cost Centres.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                OperationBindingSource.DataSource = API.Operation.FindAll
            End Using

            For Each cl As API.Operation In OperationBindingSource.DataSource
                For Each cl2 As API.Operation In CType(Me.Record, API.Artisan).Operations
                    If cl = cl2 Then
                        clbcOperationChecklist.SetItemChecked(OperationBindingSource.IndexOf(cl), True)
                    End If
                Next
            Next
        Catch ex As Exception
            Setup.Log.logError("Error fetching Checklist.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                ForemanBindingSource.DataSource = GetForemanArtisans()
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Foreman Artisan list.", ex)
        End Try

    End Sub

    Private Sub clbcChecklist_ItemCheck(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbcOperationChecklist.ItemCheck
        If e.State = Windows.Forms.CheckState.Checked Then
            If Not CType(Me.Record, API.Artisan).Operations.Contains(clbcOperationChecklist.GetItem(e.Index)) Then
                CType(Me.Record, API.Artisan).Operations.Add(clbcOperationChecklist.GetItem(e.Index))
            End If
        Else
            If CType(Me.Record, API.Artisan).Operations.Contains(clbcOperationChecklist.GetItem(e.Index)) Then
                CType(Me.Record, API.Artisan).Operations.Remove(clbcOperationChecklist.GetItem(e.Index))
            End If
        End If

    End Sub

    Protected Overloads Sub ValidationError(ByVal errors As System.Collections.IDictionary)

        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "Code" Then
                CodeTextEdit.ErrorText = errors(prop)(0)
            ElseIf prop.Name = "Password" Then
                PasswordTextEdit.ErrorText = errors(prop)(0)
            Else
            End If
        Next
    End Sub

    Protected Overrides Sub SaveRecord()
        Try
            If Me.Record.Code = "" Then
                CodeTextEdit.ErrorText = "Code is a required field."
            End If
            If Me.Record.Password = "" Then
                PasswordTextEdit.ErrorText = "Password is a required field."
            End If
            MyBase.SaveRecord()
        Catch ex As Exception
            Setup.Log.logError("Error login details incorrect.", ex)
        End Try

    End Sub
    Public Function GetForemanArtisans() As IEnumerable(Of API.Artisan)
        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.Artisan)()
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("IsArtisanForeman", True), NHibernate.Criterion.Expression.IsNotNull("IsArtisanForeman")))
            Return API.Artisan.FindAll(crit)
        End Using
    End Function
    
End Class

Public Class xaegArtisan
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Artisan)
End Class
