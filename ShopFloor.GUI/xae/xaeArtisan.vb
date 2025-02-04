Public Class xaeArtisan
    Inherits xaegArtisan

    Protected Overloads Sub ValidationError(ByVal errors As System.Collections.IDictionary)

        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "Code" Then
                CodeTextEdit.ErrorText = errors(prop)(0)
            Else
            End If
        Next
    End Sub

    Protected Overrides Sub SaveRecord()
        Try
            If Me.Record.Code = "" Then
                CodeTextEdit.ErrorText = "Code is a required field."
            End If
            MyBase.SaveRecord()
        Catch ex As Exception
            Setup.Log.logError("Error login details incorrect.", ex)
        End Try

    End Sub
End Class

Public Class xaegArtisan
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Artisan)
End Class
