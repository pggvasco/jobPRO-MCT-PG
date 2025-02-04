Public Class xaeChecklist
    Inherits xaegChecklist

    Public Sub New()
        InitializeComponent()
        Try
            Dim clom As New UniSource.Helper.ActiveRecord.LookupMaintenance(Of API.ChecklistOption)(rilkpChecklistOption, GetType(xaeCheckListOption), AddressOf GetChecklistOptions, Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Checklist Options.", ex)
        End Try

        Try
            Dim cltm As New UniSource.Helper.ActiveRecord.LookupMaintenance(Of API.ChecklistType)(ChecklistTypeLookUpEdit, xaeChecklistType, AddressOf GetChecklistTypes, Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Checklist Options.", ex)
        End Try
    End Sub

    Private Function GetChecklistTypes() As IEnumerable(Of API.ChecklistType)
        Return API.ChecklistType.FindAll
    End Function

    Private Function GetChecklistOptions() As IEnumerable(Of API.ChecklistOption)
        Return API.ChecklistOption.FindAll
    End Function

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

Public Class xaegChecklist
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Checklist)
End Class


