Public Class xaeLookupValues 
    Inherits xaegLookupValues

    Public Sub New()
        InitializeComponent()
        Try
            'Dim cltm As New UniSource.Helper.ActiveRecord.LookupMaintenance(Of API.Lookup)(LookupLookUpEdit, xaeLookup, AddressOf GetLookups, Conversation)
            LookupBindingSource.DataSource = GetLookups()
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Checklist Options.", ex)
        End Try
    End Sub

    Private Function GetLookups() As IEnumerable(Of API.Lookup)
        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            Return API.Lookup.FindAll
        End Using
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

    Private Sub xaeLookupValues_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class xaegLookupValues
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.LookupValue)
End Class