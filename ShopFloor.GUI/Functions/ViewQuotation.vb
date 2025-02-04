Namespace Functions

    Public Class ViewQuotation
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j In jobs
                Dim xaejq As New xaeJobQuote(j)
                xaejq.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaejq.AdditionalFieldsLayoutControlGroup.Enabled = False
                xaejq.gvJobLines.OptionsBehavior.AllowAddRows = False
                xaejq.gvJobLines.OptionsBehavior.AllowDeleteRows = False
                xaejq.gvJobLines.OptionsBehavior.Editable = False
                xaejq.bbiAddLine.Enabled = False
                xaejq.bbiCancelSelectedLines.Enabled = False
                xaejq.bbiEditLine.Enabled = False
                xaejq.bbiSave.Enabled = False
                xaejq.bbiImportTemplate.Enabled = False
                xaejq.bbiImportJob.Enabled = False
                xaejq.bbiImportQuote.Enabled = False
                xaejq.btSave.Visible = False
                xaejq.ShowDialog()

                xaejq.gvJobLines.Dispose()
                xaejq.BindingSource.Dispose()
                xaejq.StockItemBindingSource.Dispose()
                xaejq.WorkCentreBindingSource.Dispose()
                xaejq.WorkCentreCategoryBindingSource.Dispose()
                xaejq.VendorClassBindingSource.Dispose()
                xaejq.VendorBindingSource.Dispose()
                xaejq.SupplyScopeBindingSource.Dispose()
                xaejq.PartBindingSource.Dispose()
                xaejq.JobLineListBindingSource.Dispose()

                xaejq.gvJobLines = Nothing
                xaejq.BindingSource = Nothing
                xaejq.StockItemBindingSource = Nothing
                xaejq.WorkCentreBindingSource = Nothing
                xaejq.WorkCentreCategoryBindingSource = Nothing
                xaejq.VendorClassBindingSource = Nothing
                xaejq.VendorBindingSource = Nothing
                xaejq.SupplyScopeBindingSource = Nothing
                xaejq.PartBindingSource = Nothing
                xaejq.JobLineListBindingSource = Nothing

                xaejq.Close()
                xaejq = Nothing
            Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "View Quotation"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "View the Quotation in Read-Only mode."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.Quotation
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_white_paint
            End Get
        End Property

    End Class

End Namespace
