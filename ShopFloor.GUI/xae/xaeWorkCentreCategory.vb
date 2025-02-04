Public Class xaeWorkCentreCategory
    Inherits xaegWorkCentreCategory

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

Public Class xaegWorkCentreCategory
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.WorkCentreCategory)
End Class