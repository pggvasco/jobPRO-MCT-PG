Public Class xaeModel 
    Inherits xaegModel

    Private Sub xaeModel_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Try
            MakeBindingSource.DataSource = API.Make.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error loading Makes.", ex)
        End Try

    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "Code" Then
                CodeTextEdit.ErrorText = errors(prop)(0)
            ElseIf prop.Name = "Description" Then
                DescriptionTextEdit.ErrorText = errors(prop)(0)
            Else
            End If
        Next
    End Sub

End Class

Public Class xaegModel
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.Model)
End Class