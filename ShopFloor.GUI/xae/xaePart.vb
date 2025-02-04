Public Class xaePart
    Inherits xaegPart

    Private Sub xaePart_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            PartGroupBindingSource.DataSource = API.PartGroup.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error loading Part Groups.", ex)
        End Try

        Try
            SupplyScopeBindingSource.DataSource = API.SupplyScope.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error loading Supply Scopes.", ex)
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

Public Class xaegPart
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Part)
End Class