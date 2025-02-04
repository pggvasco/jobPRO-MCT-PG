Public Class xaeLookupValues 
    Inherits xaegLookupValues

    Public Sub New()
        InitializeComponent()
        Try
            Dim cltm As New UniSource.Helper.ActiveRecord.LookupMaintenance(Of API.Lookup)(LookupLookUpEdit, xaeLookup, AddressOf GetLookups, Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Checklist Options.", ex)
        End Try
    End Sub

    Private Function GetLookups() As IEnumerable(Of API.Lookup)
        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            Return API.Lookup.FindAll
        End Using
    End Function

End Class

Public Class xaegLookupValues
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.LookupValue)
End Class