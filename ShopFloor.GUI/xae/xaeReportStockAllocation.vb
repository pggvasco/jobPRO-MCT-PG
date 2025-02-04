Imports DevExpress.XtraReports.UI
Public Class xaeReportStockAllocation

    Private Sub btPreviewReport_Click(sender As System.Object, e As System.EventArgs) Handles btPreviewReport.Click

        Dim StockItemFrom As UniSource.Helper.ActiveRecord.Evolution.StockItem
        'Tawanda 
        Dim StockItemTo As UniSource.Helper.ActiveRecord.Evolution.StockItem

        Try
            StockItemFrom = StockItemLookUpEdit.EditValue
        Catch ex As Exception
            StockItemFrom = Nothing
        End Try

        Try
            StockItemTo = StockItemToLookUpEdit.EditValue
        Catch ex As Exception
            StockItemTo = Nothing
        End Try


        If StockItemLookUpEdit.EditValue Is Nothing OrElse StockItemFrom Is Nothing Then
            UniSource.Helper.GUI.Dialog.OKDialog("Please Select a From Stock Item")
            Return
        End If

        If StockItemToLookUpEdit.EditValue Is Nothing OrElse StockItemTo Is Nothing Then
            UniSource.Helper.GUI.Dialog.OKDialog("Please Select a To Stock Item")
            Return
        End If

        Dim stockAllocation As API.StockAllocation = New API.StockAllocation
        stockAllocation.StockItemForm = StockItemFrom
        stockAllocation.StockItemTo = StockItemTo

        API.Context.ExicuteSQLScript("Update t1 Set QuantityStockDrawn = (Select Sum(rl.Quantity) From ussSFRequisitionLine rl Where rl.JobLineID = id And rl.Quantity > 0) From ussSFJobLine t1 Where t1.QuantityStockDrawn <> (Select Sum(rl.Quantity) From ussSFRequisitionLine rl Where rl.JobLineID = t1.id And rl.Quantity > 0)")

        Dim jobLineCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobLine)()

        'jobLineCrit.Add(NHibernate.Criterion.Expression.Sql("Requisition_Number Is not Null And Requisition_Number <> '' AND JobID In (Select t1.id From ussSFJob t1 with(nolock) Where t1.IsApproved = 1 And t1.StateID = 0 And t1.IsProcured = 1) And (QuantityStock - QuantityStockDrawn) > 0  And InventoryItemID = " & StockItem.ID.ToString()))
        'jobLineCrit.Add(NHibernate.Criterion.Expression.Sql("Requisition_Number Is not Null And Requisition_Number <> '' AND JobID In (Select t1.id From ussSFJob t1 with(nolock) Where t1.IsApproved = 1 And t1.StateID = 0 And t1.IsProcured = 1) And (QuantityStock - QuantityStockDrawn) > 0  And InventoryItemID in (Select stockLink from stkitem where Code >= '" & StockItemFrom.Code & "' AND Code <= '" & StockItemTo.Code & "')"))
        jobLineCrit.Add(NHibernate.Criterion.Expression.Sql("Requisition_Number Is not Null And Requisition_Number <> '' AND Requisition_Number <> 'JCB4MAY2020' AND JobID In (Select t1.id From ussSFJob t1 with(nolock) Where t1.IsApproved = 1 And t1.StateID = 0 And t1.IsProcured = 1) And (QuantityStock - QuantityStockDrawn) > 0  And InventoryItemID in (Select stockLink from stkitem where Code >= '" & StockItemFrom.Code & "' AND Code <= '" & StockItemTo.Code & "')"))
        stockAllocation.JobLines = API.JobLine.FindAll(jobLineCrit).ToList()

        Dim xrPR As New ShopFloor.Report.xrStockAllocation
        xrPR.StockAllocationBindingSource.DataSource = stockAllocation
        xrPR.ExportOptions.GetOptionVisibility(DevExpress.XtraPrinting.ExportOptionKind.XlsxExportMode)
        xrPR.ShowPreviewDialog()

    End Sub

    Private Sub xaeReportStockAllocation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(StockItemLookUpEdit, AddressOf LoadStockItems)
            iibl.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        End Try
        Try
            Dim iiblTo As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(StockItemToLookUpEdit, AddressOf LoadStockItems)
            iiblTo.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        End Try
    End Sub

    Private Function LoadStockItems() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)

        Dim stockItemCrit = NHibernate.Criterion.DetachedCriteria.For(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)()
        stockItemCrit.Add(NHibernate.Criterion.Expression.Eq("ServiceItem", False))
        Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll(stockItemCrit).OrderBy(Function(x) x.Code)

    End Function

End Class