Public Class xlInvoiceRun
    Inherits xlgInvoiceRun

    Public Overrides ReadOnly Property GridView As DevExpress.XtraGrid.Views.Grid.GridView
        Get

            If _gridview Is Nothing Then
                If GridControl IsNot Nothing Then
                    _gridview = GridControl.MainView
                    If Not GridEditingIsSelfManaged Then
                        _gridview.OptionsBehavior.Editable = True
                        _gridview.OptionsBehavior.ReadOnly = False
                        _gridview.OptionsBehavior.AllowIncrementalSearch = False
                    End If
                End If
            End If
            Return _gridview
            Return MyBase.GridView
        End Get
    End Property

End Class


Public Class xlgInvoiceRun
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.InvoiceRun)
   
End Class