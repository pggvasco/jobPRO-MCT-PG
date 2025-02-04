Public Class xaeGeneration 
    Inherits xaegGeneration
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

Public Class xaegGeneration
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.Generation)
End Class