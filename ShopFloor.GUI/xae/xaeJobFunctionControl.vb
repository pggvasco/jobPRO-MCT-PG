Public Class xaeJobFunctionControl
    Inherits xaegJobFunctionControl

    Private Sub xaeJobStage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            LoadJobFunctions()
        Catch ex As Exception
            Setup.Log.logError("Error loading Job Functions.", ex)
        End Try
        
    End Sub

    Private Sub LoadJobFunctions()
        IDTextEdit.Properties.DataSource = [Enum].GetValues(GetType(API.JobFunction))
    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "Password" Then
                PasswordTextEdit.ErrorText = errors(prop)(0)
            Else
            End If
        Next
    End Sub

End Class

Public Class xaegJobFunctionControl
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.JobFunctionControl)
End Class