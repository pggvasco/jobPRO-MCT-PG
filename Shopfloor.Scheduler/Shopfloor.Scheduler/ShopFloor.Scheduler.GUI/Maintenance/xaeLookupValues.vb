Public Class xaeLookupValues 
    Inherits xaegLookupValues

    Private Sub xaeLookupValues_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LookupBindingSource.DataSource = API.Lookup.FindAll
        luLookup.Properties.DataSource = [Enum].GetValues(GetType(API.Lookup))
    End Sub
End Class

Public Class xaegLookupValues
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.LookupValue)
End Class