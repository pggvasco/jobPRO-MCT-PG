<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfQuotation
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.chkIncNRInfo = New DevExpress.XtraEditors.CheckEdit()
        Me.chkInclDamageReport = New DevExpress.XtraEditors.CheckEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.chkIncludeCommonLetter = New DevExpress.XtraEditors.CheckEdit()
        Me.chkInclDrawing = New DevExpress.XtraEditors.CheckEdit()
        Me.chkInclPrices = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFooter = New DevExpress.XtraEditors.TextEdit()
        Me.txtHeader = New DevExpress.XtraEditors.TextEdit()
        Me.gcQuotation = New DevExpress.XtraGrid.GridControl()
        Me.JobLineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvQuotation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantityStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantitySupplier1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantitySupplier2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NextStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PreviousStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobTypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TotalCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TotalPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuantityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuoteNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DeliveryNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrderNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuoteDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.InvoiceDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AcceptedDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstimatedDeliveryDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CancelledDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstimatedStartDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstimatedEndDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ActualStartDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ActualEndDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ValidityDaysTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DeliveryDaysTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsTemplateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsBreakdownTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsApprovedTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsProcuredTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsStockDrawnTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContractIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RepresentativeIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobAgentIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApproveAgentIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BuyingAgentIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AssignedAgentIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuoteAgentIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobCardIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AccountNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContactNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelephoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Description1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Description2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrderTotalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DiscountPercentTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DiscountAmountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NewPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WarrantyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CancelReasonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuoteCommentsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PricelistIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.StateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDeliveriesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobLinesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobTolerancesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DrawingTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GenerationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MakeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ModelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FunctionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobCategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkCentreCategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobTemplateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CostCentreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuantityDeliveredTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForNextStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPreviousStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnitCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTotalCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForInvoiceDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAcceptedDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedDeliveryDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCancelledDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActualStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActualEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForValidityDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsTemplate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsBreakdown = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsApproved = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsProcured = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsStockDrawn = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForContractID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRepresentativeID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobAgentID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForApproveAgentID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForBuyingAgentID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAssignedAgentID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteAgentID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobCardID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAccountName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTelephone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEmail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForFax = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrderTotal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNewPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWarranty = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCancelReason = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteComments = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPricelistID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForState = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDeliveries = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobLines = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobTolerances = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDrawing = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForGeneration = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForMake = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForModel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForFunction = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWorkCentreCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobTemplate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCostCentre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuantityDelivered = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCustomer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrderNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuantity = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDiscountPercent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTotalPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnitPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForContactName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDiscountAmount = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.chkIncPictureInfo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCancel = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncNRInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInclDamageReport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncludeCommonLetter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInclDrawing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInclPrices.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcQuotation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQuotation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcceptedDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedDeliveryDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelledDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedEndDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualEndDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidityDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsTemplateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsBreakdownTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsApprovedTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsProcuredTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsStockDrawnTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepresentativeIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobAgentIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApproveAgentIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyingAgentIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignedAgentIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteAgentIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCardIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelephoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTotalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountPercentTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountAmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarrantyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteCommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PricelistIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDeliveriesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLinesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTolerancesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FunctionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTemplateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCentreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityDeliveredTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPreviousStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAcceptedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCancelledDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActualStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActualEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidityDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsBreakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsApproved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsProcured, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsStockDrawn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForContractID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRepresentativeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobAgentID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForApproveAgentID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForBuyingAgentID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAssignedAgentID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteAgentID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobCardID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAccountName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTelephone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNewPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWarranty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCancelReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteComments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPricelistID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDeliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobTolerances, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForGeneration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFunction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCostCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuantityDelivered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDiscountPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTotalPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForContactName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDiscountAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncPictureInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit5)
        Me.DataLayoutControl1.Controls.Add(Me.chkIncNRInfo)
        Me.DataLayoutControl1.Controls.Add(Me.chkInclDamageReport)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit4)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit3)
        Me.DataLayoutControl1.Controls.Add(Me.chkIncludeCommonLetter)
        Me.DataLayoutControl1.Controls.Add(Me.chkInclDrawing)
        Me.DataLayoutControl1.Controls.Add(Me.chkInclPrices)
        Me.DataLayoutControl1.Controls.Add(Me.txtFooter)
        Me.DataLayoutControl1.Controls.Add(Me.txtHeader)
        Me.DataLayoutControl1.Controls.Add(Me.gcQuotation)
        Me.DataLayoutControl1.Controls.Add(Me.NextStageTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PreviousStageTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CustomerTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobTypeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.UnitCostTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.UnitPriceTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TotalCostTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TotalPriceTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.QuantityTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobNumberTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.QuoteNumberTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DeliveryNumberTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OrderNumberTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.QuoteDateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.InvoiceDateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AcceptedDateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EstimatedDeliveryDateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CancelledDateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EstimatedStartDateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EstimatedEndDateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ActualStartDateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ActualEndDateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ValidityDaysTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DeliveryDaysTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsTemplateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsBreakdownTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsApprovedTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsProcuredTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsStockDrawnTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ContractIDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RepresentativeIDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobAgentIDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ApproveAgentIDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.BuyingAgentIDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AssignedAgentIDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.QuoteAgentIDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobCardIDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AccountNameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ContactNameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TelephoneTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EmailTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FaxTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.Description1TextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.Description2TextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OrderTotalTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DiscountPercentTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DiscountAmountTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NewPriceTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.WarrantyTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CancelReasonTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.QuoteCommentsTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PricelistIDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.StateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobDeliveriesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobLinesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobTolerancesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobStageTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DrawingTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.GenerationTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MakeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ModelTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FunctionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobCategoryTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.WorkCentreCategoryTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobTemplateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CostCentreTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.QuantityDeliveredTextEdit)
        Me.DataLayoutControl1.DataSource = Me.JobBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForNextStage, Me.ItemForPreviousStage, Me.ItemForUnitCost, Me.ItemForTotalCost, Me.ItemForQuoteNumber, Me.ItemForDeliveryNumber, Me.ItemForQuoteDate, Me.ItemForInvoiceDate, Me.ItemForAcceptedDate, Me.ItemForEstimatedDeliveryDate, Me.ItemForCancelledDate, Me.ItemForEstimatedStartDate, Me.ItemForEstimatedEndDate, Me.ItemForActualStartDate, Me.ItemForActualEndDate, Me.ItemForValidityDays, Me.ItemForDeliveryDays, Me.ItemForIsTemplate, Me.ItemForIsBreakdown, Me.ItemForIsApproved, Me.ItemForIsProcured, Me.ItemForIsStockDrawn, Me.ItemForContractID, Me.ItemForRepresentativeID, Me.ItemForJobAgentID, Me.ItemForApproveAgentID, Me.ItemForBuyingAgentID, Me.ItemForAssignedAgentID, Me.ItemForQuoteAgentID, Me.ItemForJobCardID, Me.ItemForAccountName, Me.ItemForTelephone, Me.ItemForEmail, Me.ItemForFax, Me.ItemForDescription2, Me.ItemForOrderTotal, Me.ItemForNewPrice, Me.ItemForWarranty, Me.ItemForCancelReason, Me.ItemForQuoteComments, Me.ItemForPricelistID, Me.ItemForState, Me.ItemForJobDeliveries, Me.ItemForJobLines, Me.ItemForJobTolerances, Me.ItemForJobStage, Me.ItemForDrawing, Me.ItemForGeneration, Me.ItemForMake, Me.ItemForModel, Me.ItemForFunction, Me.ItemForJobCategory, Me.ItemForWorkCentreCategory, Me.ItemForJobTemplate, Me.ItemForCostCentre, Me.ItemForID, Me.ItemForQuantityDelivered})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 22)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(798, 93, 250, 350)
        Me.DataLayoutControl1.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(969, 425)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(827, 214)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(137, 20)
        Me.TextEdit5.StyleController = Me.DataLayoutControl1
        Me.TextEdit5.TabIndex = 84
        '
        'chkIncNRInfo
        '
        Me.chkIncNRInfo.Location = New System.Drawing.Point(486, 214)
        Me.chkIncNRInfo.Name = "chkIncNRInfo"
        Me.chkIncNRInfo.Properties.Caption = "Include N/R Info"
        Me.chkIncNRInfo.Size = New System.Drawing.Size(232, 19)
        Me.chkIncNRInfo.StyleController = Me.DataLayoutControl1
        Me.chkIncNRInfo.TabIndex = 83
        '
        'chkInclDamageReport
        '
        Me.chkInclDamageReport.Location = New System.Drawing.Point(5, 214)
        Me.chkInclDamageReport.Name = "chkInclDamageReport"
        Me.chkInclDamageReport.Properties.Caption = "Include Damage Report"
        Me.chkInclDamageReport.Size = New System.Drawing.Size(471, 19)
        Me.chkInclDamageReport.StyleController = Me.DataLayoutControl1
        Me.chkInclDamageReport.TabIndex = 82
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(728, 184)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(236, 20)
        Me.TextEdit4.StyleController = Me.DataLayoutControl1
        Me.TextEdit4.TabIndex = 81
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(486, 184)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(232, 20)
        Me.TextEdit3.StyleController = Me.DataLayoutControl1
        Me.TextEdit3.TabIndex = 80
        '
        'chkIncludeCommonLetter
        '
        Me.chkIncludeCommonLetter.Location = New System.Drawing.Point(5, 184)
        Me.chkIncludeCommonLetter.Name = "chkIncludeCommonLetter"
        Me.chkIncludeCommonLetter.Properties.Caption = "Include Common Letter"
        Me.chkIncludeCommonLetter.Size = New System.Drawing.Size(471, 19)
        Me.chkIncludeCommonLetter.StyleController = Me.DataLayoutControl1
        Me.chkIncludeCommonLetter.TabIndex = 79
        '
        'chkInclDrawing
        '
        Me.chkInclDrawing.Location = New System.Drawing.Point(486, 155)
        Me.chkInclDrawing.Name = "chkInclDrawing"
        Me.chkInclDrawing.Properties.Caption = "Include Drawing"
        Me.chkInclDrawing.Size = New System.Drawing.Size(478, 19)
        Me.chkInclDrawing.StyleController = Me.DataLayoutControl1
        Me.chkInclDrawing.TabIndex = 78
        '
        'chkInclPrices
        '
        Me.chkInclPrices.Location = New System.Drawing.Point(5, 155)
        Me.chkInclPrices.Name = "chkInclPrices"
        Me.chkInclPrices.Properties.Caption = "Include Prices"
        Me.chkInclPrices.Size = New System.Drawing.Size(471, 19)
        Me.chkInclPrices.StyleController = Me.DataLayoutControl1
        Me.chkInclPrices.TabIndex = 77
        '
        'txtFooter
        '
        Me.txtFooter.Location = New System.Drawing.Point(585, 125)
        Me.txtFooter.Name = "txtFooter"
        Me.txtFooter.Size = New System.Drawing.Size(379, 20)
        Me.txtFooter.StyleController = Me.DataLayoutControl1
        Me.txtFooter.TabIndex = 76
        '
        'txtHeader
        '
        Me.txtHeader.Location = New System.Drawing.Point(104, 125)
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(372, 20)
        Me.txtHeader.StyleController = Me.DataLayoutControl1
        Me.txtHeader.TabIndex = 75
        '
        'gcQuotation
        '
        Me.gcQuotation.DataSource = Me.JobLineListBindingSource
        Me.gcQuotation.Location = New System.Drawing.Point(5, 244)
        Me.gcQuotation.MainView = Me.gvQuotation
        Me.gcQuotation.Name = "gcQuotation"
        Me.gcQuotation.Size = New System.Drawing.Size(959, 176)
        Me.gcQuotation.TabIndex = 74
        Me.gcQuotation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQuotation})
        '
        'JobLineListBindingSource
        '
        Me.JobLineListBindingSource.DataMember = "JobLineList"
        Me.JobLineListBindingSource.DataSource = Me.JobBindingSource
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(API.Job)
        '
        'gvQuotation
        '
        Me.gvQuotation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQuantity, Me.colInventoryItem, Me.colSupplierType, Me.colRequiredDate, Me.colQuoteDescription, Me.colQuantityStock, Me.colQuantitySupplier1, Me.colQuantitySupplier2, Me.colUnitPrice, Me.colTotalPrice, Me.colLineNumber, Me.colTotalCost, Me.colJob, Me.colPart})
        Me.gvQuotation.GridControl = Me.gcQuotation
        Me.gvQuotation.Name = "gvQuotation"
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 1
        '
        'colInventoryItem
        '
        Me.colInventoryItem.FieldName = "InventoryItem"
        Me.colInventoryItem.Name = "colInventoryItem"
        Me.colInventoryItem.Visible = True
        Me.colInventoryItem.VisibleIndex = 2
        '
        'colSupplierType
        '
        Me.colSupplierType.FieldName = "SupplierType"
        Me.colSupplierType.Name = "colSupplierType"
        Me.colSupplierType.Visible = True
        Me.colSupplierType.VisibleIndex = 3
        '
        'colRequiredDate
        '
        Me.colRequiredDate.FieldName = "RequiredDate"
        Me.colRequiredDate.Name = "colRequiredDate"
        Me.colRequiredDate.Visible = True
        Me.colRequiredDate.VisibleIndex = 4
        '
        'colQuoteDescription
        '
        Me.colQuoteDescription.FieldName = "QuoteDescription"
        Me.colQuoteDescription.Name = "colQuoteDescription"
        Me.colQuoteDescription.Visible = True
        Me.colQuoteDescription.VisibleIndex = 5
        '
        'colQuantityStock
        '
        Me.colQuantityStock.FieldName = "QuantityStock"
        Me.colQuantityStock.Name = "colQuantityStock"
        Me.colQuantityStock.Visible = True
        Me.colQuantityStock.VisibleIndex = 6
        '
        'colQuantitySupplier1
        '
        Me.colQuantitySupplier1.FieldName = "QuantitySupplier1"
        Me.colQuantitySupplier1.Name = "colQuantitySupplier1"
        Me.colQuantitySupplier1.Visible = True
        Me.colQuantitySupplier1.VisibleIndex = 7
        '
        'colQuantitySupplier2
        '
        Me.colQuantitySupplier2.FieldName = "QuantitySupplier2"
        Me.colQuantitySupplier2.Name = "colQuantitySupplier2"
        Me.colQuantitySupplier2.Visible = True
        Me.colQuantitySupplier2.VisibleIndex = 8
        '
        'colUnitPrice
        '
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 9
        '
        'colTotalPrice
        '
        Me.colTotalPrice.FieldName = "TotalPrice"
        Me.colTotalPrice.Name = "colTotalPrice"
        Me.colTotalPrice.Visible = True
        Me.colTotalPrice.VisibleIndex = 10
        '
        'colLineNumber
        '
        Me.colLineNumber.FieldName = "LineNumber"
        Me.colLineNumber.Name = "colLineNumber"
        Me.colLineNumber.Visible = True
        Me.colLineNumber.VisibleIndex = 0
        '
        'colTotalCost
        '
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.Visible = True
        Me.colTotalCost.VisibleIndex = 11
        '
        'colJob
        '
        Me.colJob.FieldName = "Job"
        Me.colJob.Name = "colJob"
        Me.colJob.Visible = True
        Me.colJob.VisibleIndex = 12
        '
        'colPart
        '
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        Me.colPart.Visible = True
        Me.colPart.VisibleIndex = 13
        '
        'NextStageTextEdit
        '
        Me.NextStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "NextStage", True))
        Me.NextStageTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.NextStageTextEdit.Name = "NextStageTextEdit"
        Me.NextStageTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.NextStageTextEdit.StyleController = Me.DataLayoutControl1
        Me.NextStageTextEdit.TabIndex = 4
        '
        'PreviousStageTextEdit
        '
        Me.PreviousStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "PreviousStage", True))
        Me.PreviousStageTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.PreviousStageTextEdit.Name = "PreviousStageTextEdit"
        Me.PreviousStageTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.PreviousStageTextEdit.StyleController = Me.DataLayoutControl1
        Me.PreviousStageTextEdit.TabIndex = 5
        '
        'CustomerTextEdit
        '
        Me.CustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Customer", True))
        Me.CustomerTextEdit.Location = New System.Drawing.Point(104, 5)
        Me.CustomerTextEdit.Name = "CustomerTextEdit"
        Me.CustomerTextEdit.Size = New System.Drawing.Size(375, 20)
        Me.CustomerTextEdit.StyleController = Me.DataLayoutControl1
        Me.CustomerTextEdit.TabIndex = 6
        '
        'JobTypeTextEdit
        '
        Me.JobTypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobType", True))
        Me.JobTypeTextEdit.Location = New System.Drawing.Point(104, 35)
        Me.JobTypeTextEdit.Name = "JobTypeTextEdit"
        Me.JobTypeTextEdit.Size = New System.Drawing.Size(133, 20)
        Me.JobTypeTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobTypeTextEdit.TabIndex = 7
        '
        'UnitCostTextEdit
        '
        Me.UnitCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "UnitCost", True))
        Me.UnitCostTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UnitCostTextEdit.Name = "UnitCostTextEdit"
        Me.UnitCostTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UnitCostTextEdit.StyleController = Me.DataLayoutControl1
        Me.UnitCostTextEdit.TabIndex = 8
        '
        'UnitPriceTextEdit
        '
        Me.UnitPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "UnitPrice", True))
        Me.UnitPriceTextEdit.Location = New System.Drawing.Point(830, 65)
        Me.UnitPriceTextEdit.Name = "UnitPriceTextEdit"
        Me.UnitPriceTextEdit.Size = New System.Drawing.Size(134, 20)
        Me.UnitPriceTextEdit.StyleController = Me.DataLayoutControl1
        Me.UnitPriceTextEdit.TabIndex = 9
        '
        'TotalCostTextEdit
        '
        Me.TotalCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "TotalCost", True))
        Me.TotalCostTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.TotalCostTextEdit.Name = "TotalCostTextEdit"
        Me.TotalCostTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.TotalCostTextEdit.StyleController = Me.DataLayoutControl1
        Me.TotalCostTextEdit.TabIndex = 10
        '
        'TotalPriceTextEdit
        '
        Me.TotalPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "TotalPrice", True))
        Me.TotalPriceTextEdit.Location = New System.Drawing.Point(831, 95)
        Me.TotalPriceTextEdit.Name = "TotalPriceTextEdit"
        Me.TotalPriceTextEdit.Size = New System.Drawing.Size(133, 20)
        Me.TotalPriceTextEdit.StyleController = Me.DataLayoutControl1
        Me.TotalPriceTextEdit.TabIndex = 11
        '
        'QuantityTextEdit
        '
        Me.QuantityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Quantity", True))
        Me.QuantityTextEdit.Location = New System.Drawing.Point(346, 35)
        Me.QuantityTextEdit.Name = "QuantityTextEdit"
        Me.QuantityTextEdit.Size = New System.Drawing.Size(134, 20)
        Me.QuantityTextEdit.StyleController = Me.DataLayoutControl1
        Me.QuantityTextEdit.TabIndex = 12
        '
        'JobNumberTextEdit
        '
        Me.JobNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobNumber", True))
        Me.JobNumberTextEdit.Location = New System.Drawing.Point(588, 5)
        Me.JobNumberTextEdit.Name = "JobNumberTextEdit"
        Me.JobNumberTextEdit.Size = New System.Drawing.Size(376, 20)
        Me.JobNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobNumberTextEdit.TabIndex = 14
        '
        'QuoteNumberTextEdit
        '
        Me.QuoteNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "QuoteNumber", True))
        Me.QuoteNumberTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.QuoteNumberTextEdit.Name = "QuoteNumberTextEdit"
        Me.QuoteNumberTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.QuoteNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.QuoteNumberTextEdit.TabIndex = 15
        '
        'DeliveryNumberTextEdit
        '
        Me.DeliveryNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "DeliveryNumber", True))
        Me.DeliveryNumberTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.DeliveryNumberTextEdit.Name = "DeliveryNumberTextEdit"
        Me.DeliveryNumberTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.DeliveryNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.DeliveryNumberTextEdit.TabIndex = 16
        '
        'OrderNumberTextEdit
        '
        Me.OrderNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "OrderNumber", True))
        Me.OrderNumberTextEdit.Location = New System.Drawing.Point(589, 35)
        Me.OrderNumberTextEdit.Name = "OrderNumberTextEdit"
        Me.OrderNumberTextEdit.Size = New System.Drawing.Size(375, 20)
        Me.OrderNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.OrderNumberTextEdit.TabIndex = 17
        '
        'QuoteDateTextEdit
        '
        Me.QuoteDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "QuoteDate", True))
        Me.QuoteDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.QuoteDateTextEdit.Name = "QuoteDateTextEdit"
        Me.QuoteDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.QuoteDateTextEdit.StyleController = Me.DataLayoutControl1
        Me.QuoteDateTextEdit.TabIndex = 19
        '
        'InvoiceDateTextEdit
        '
        Me.InvoiceDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "InvoiceDate", True))
        Me.InvoiceDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.InvoiceDateTextEdit.Name = "InvoiceDateTextEdit"
        Me.InvoiceDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.InvoiceDateTextEdit.StyleController = Me.DataLayoutControl1
        Me.InvoiceDateTextEdit.TabIndex = 20
        '
        'AcceptedDateTextEdit
        '
        Me.AcceptedDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "AcceptedDate", True))
        Me.AcceptedDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.AcceptedDateTextEdit.Name = "AcceptedDateTextEdit"
        Me.AcceptedDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.AcceptedDateTextEdit.StyleController = Me.DataLayoutControl1
        Me.AcceptedDateTextEdit.TabIndex = 21
        '
        'EstimatedDeliveryDateTextEdit
        '
        Me.EstimatedDeliveryDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "EstimatedDeliveryDate", True))
        Me.EstimatedDeliveryDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.EstimatedDeliveryDateTextEdit.Name = "EstimatedDeliveryDateTextEdit"
        Me.EstimatedDeliveryDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.EstimatedDeliveryDateTextEdit.StyleController = Me.DataLayoutControl1
        Me.EstimatedDeliveryDateTextEdit.TabIndex = 22
        '
        'CancelledDateTextEdit
        '
        Me.CancelledDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "CancelledDate", True))
        Me.CancelledDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.CancelledDateTextEdit.Name = "CancelledDateTextEdit"
        Me.CancelledDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.CancelledDateTextEdit.StyleController = Me.DataLayoutControl1
        Me.CancelledDateTextEdit.TabIndex = 23
        '
        'EstimatedStartDateTextEdit
        '
        Me.EstimatedStartDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "EstimatedStartDate", True))
        Me.EstimatedStartDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.EstimatedStartDateTextEdit.Name = "EstimatedStartDateTextEdit"
        Me.EstimatedStartDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.EstimatedStartDateTextEdit.StyleController = Me.DataLayoutControl1
        Me.EstimatedStartDateTextEdit.TabIndex = 24
        '
        'EstimatedEndDateTextEdit
        '
        Me.EstimatedEndDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "EstimatedEndDate", True))
        Me.EstimatedEndDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.EstimatedEndDateTextEdit.Name = "EstimatedEndDateTextEdit"
        Me.EstimatedEndDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.EstimatedEndDateTextEdit.StyleController = Me.DataLayoutControl1
        Me.EstimatedEndDateTextEdit.TabIndex = 25
        '
        'ActualStartDateTextEdit
        '
        Me.ActualStartDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ActualStartDate", True))
        Me.ActualStartDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ActualStartDateTextEdit.Name = "ActualStartDateTextEdit"
        Me.ActualStartDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ActualStartDateTextEdit.StyleController = Me.DataLayoutControl1
        Me.ActualStartDateTextEdit.TabIndex = 26
        '
        'ActualEndDateTextEdit
        '
        Me.ActualEndDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ActualEndDate", True))
        Me.ActualEndDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ActualEndDateTextEdit.Name = "ActualEndDateTextEdit"
        Me.ActualEndDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ActualEndDateTextEdit.StyleController = Me.DataLayoutControl1
        Me.ActualEndDateTextEdit.TabIndex = 27
        '
        'ValidityDaysTextEdit
        '
        Me.ValidityDaysTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ValidityDays", True))
        Me.ValidityDaysTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ValidityDaysTextEdit.Name = "ValidityDaysTextEdit"
        Me.ValidityDaysTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ValidityDaysTextEdit.StyleController = Me.DataLayoutControl1
        Me.ValidityDaysTextEdit.TabIndex = 28
        '
        'DeliveryDaysTextEdit
        '
        Me.DeliveryDaysTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "DeliveryDays", True))
        Me.DeliveryDaysTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.DeliveryDaysTextEdit.Name = "DeliveryDaysTextEdit"
        Me.DeliveryDaysTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.DeliveryDaysTextEdit.StyleController = Me.DataLayoutControl1
        Me.DeliveryDaysTextEdit.TabIndex = 29
        '
        'IsTemplateTextEdit
        '
        Me.IsTemplateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "IsTemplate", True))
        Me.IsTemplateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsTemplateTextEdit.Name = "IsTemplateTextEdit"
        Me.IsTemplateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IsTemplateTextEdit.StyleController = Me.DataLayoutControl1
        Me.IsTemplateTextEdit.TabIndex = 30
        '
        'IsBreakdownTextEdit
        '
        Me.IsBreakdownTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "IsBreakdown", True))
        Me.IsBreakdownTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsBreakdownTextEdit.Name = "IsBreakdownTextEdit"
        Me.IsBreakdownTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IsBreakdownTextEdit.StyleController = Me.DataLayoutControl1
        Me.IsBreakdownTextEdit.TabIndex = 31
        '
        'IsApprovedTextEdit
        '
        Me.IsApprovedTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "IsApproved", True))
        Me.IsApprovedTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsApprovedTextEdit.Name = "IsApprovedTextEdit"
        Me.IsApprovedTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IsApprovedTextEdit.StyleController = Me.DataLayoutControl1
        Me.IsApprovedTextEdit.TabIndex = 32
        '
        'IsProcuredTextEdit
        '
        Me.IsProcuredTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "IsProcured", True))
        Me.IsProcuredTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsProcuredTextEdit.Name = "IsProcuredTextEdit"
        Me.IsProcuredTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IsProcuredTextEdit.StyleController = Me.DataLayoutControl1
        Me.IsProcuredTextEdit.TabIndex = 33
        '
        'IsStockDrawnTextEdit
        '
        Me.IsStockDrawnTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "IsStockDrawn", True))
        Me.IsStockDrawnTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsStockDrawnTextEdit.Name = "IsStockDrawnTextEdit"
        Me.IsStockDrawnTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IsStockDrawnTextEdit.StyleController = Me.DataLayoutControl1
        Me.IsStockDrawnTextEdit.TabIndex = 34
        '
        'ContractIDTextEdit
        '
        Me.ContractIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ContractID", True))
        Me.ContractIDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ContractIDTextEdit.Name = "ContractIDTextEdit"
        Me.ContractIDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ContractIDTextEdit.StyleController = Me.DataLayoutControl1
        Me.ContractIDTextEdit.TabIndex = 35
        '
        'RepresentativeIDTextEdit
        '
        Me.RepresentativeIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "RepresentativeID", True))
        Me.RepresentativeIDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.RepresentativeIDTextEdit.Name = "RepresentativeIDTextEdit"
        Me.RepresentativeIDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.RepresentativeIDTextEdit.StyleController = Me.DataLayoutControl1
        Me.RepresentativeIDTextEdit.TabIndex = 36
        '
        'JobAgentIDTextEdit
        '
        Me.JobAgentIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobAgentID", True))
        Me.JobAgentIDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobAgentIDTextEdit.Name = "JobAgentIDTextEdit"
        Me.JobAgentIDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobAgentIDTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobAgentIDTextEdit.TabIndex = 37
        '
        'ApproveAgentIDTextEdit
        '
        Me.ApproveAgentIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ApproveAgentID", True))
        Me.ApproveAgentIDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ApproveAgentIDTextEdit.Name = "ApproveAgentIDTextEdit"
        Me.ApproveAgentIDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ApproveAgentIDTextEdit.StyleController = Me.DataLayoutControl1
        Me.ApproveAgentIDTextEdit.TabIndex = 38
        '
        'BuyingAgentIDTextEdit
        '
        Me.BuyingAgentIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "BuyingAgentID", True))
        Me.BuyingAgentIDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.BuyingAgentIDTextEdit.Name = "BuyingAgentIDTextEdit"
        Me.BuyingAgentIDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.BuyingAgentIDTextEdit.StyleController = Me.DataLayoutControl1
        Me.BuyingAgentIDTextEdit.TabIndex = 39
        '
        'AssignedAgentIDTextEdit
        '
        Me.AssignedAgentIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "AssignedAgentID", True))
        Me.AssignedAgentIDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.AssignedAgentIDTextEdit.Name = "AssignedAgentIDTextEdit"
        Me.AssignedAgentIDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.AssignedAgentIDTextEdit.StyleController = Me.DataLayoutControl1
        Me.AssignedAgentIDTextEdit.TabIndex = 40
        '
        'QuoteAgentIDTextEdit
        '
        Me.QuoteAgentIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "QuoteAgentID", True))
        Me.QuoteAgentIDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.QuoteAgentIDTextEdit.Name = "QuoteAgentIDTextEdit"
        Me.QuoteAgentIDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.QuoteAgentIDTextEdit.StyleController = Me.DataLayoutControl1
        Me.QuoteAgentIDTextEdit.TabIndex = 41
        '
        'JobCardIDTextEdit
        '
        Me.JobCardIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobCardID", True))
        Me.JobCardIDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobCardIDTextEdit.Name = "JobCardIDTextEdit"
        Me.JobCardIDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobCardIDTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobCardIDTextEdit.TabIndex = 42
        '
        'AccountNameTextEdit
        '
        Me.AccountNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "AccountName", True))
        Me.AccountNameTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.AccountNameTextEdit.Name = "AccountNameTextEdit"
        Me.AccountNameTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.AccountNameTextEdit.StyleController = Me.DataLayoutControl1
        Me.AccountNameTextEdit.TabIndex = 43
        '
        'ContactNameTextEdit
        '
        Me.ContactNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ContactName", True))
        Me.ContactNameTextEdit.Location = New System.Drawing.Point(104, 95)
        Me.ContactNameTextEdit.Name = "ContactNameTextEdit"
        Me.ContactNameTextEdit.Size = New System.Drawing.Size(374, 20)
        Me.ContactNameTextEdit.StyleController = Me.DataLayoutControl1
        Me.ContactNameTextEdit.TabIndex = 44
        '
        'TelephoneTextEdit
        '
        Me.TelephoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Telephone", True))
        Me.TelephoneTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.TelephoneTextEdit.Name = "TelephoneTextEdit"
        Me.TelephoneTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.TelephoneTextEdit.StyleController = Me.DataLayoutControl1
        Me.TelephoneTextEdit.TabIndex = 45
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.EmailTextEdit.StyleController = Me.DataLayoutControl1
        Me.EmailTextEdit.TabIndex = 46
        '
        'FaxTextEdit
        '
        Me.FaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Fax", True))
        Me.FaxTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.FaxTextEdit.Name = "FaxTextEdit"
        Me.FaxTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.FaxTextEdit.StyleController = Me.DataLayoutControl1
        Me.FaxTextEdit.TabIndex = 47
        '
        'Description1TextEdit
        '
        Me.Description1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Description1", True))
        Me.Description1TextEdit.Location = New System.Drawing.Point(104, 65)
        Me.Description1TextEdit.Name = "Description1TextEdit"
        Me.Description1TextEdit.Size = New System.Drawing.Size(375, 20)
        Me.Description1TextEdit.StyleController = Me.DataLayoutControl1
        Me.Description1TextEdit.TabIndex = 48
        '
        'Description2TextEdit
        '
        Me.Description2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Description2", True))
        Me.Description2TextEdit.Location = New System.Drawing.Point(0, 0)
        Me.Description2TextEdit.Name = "Description2TextEdit"
        Me.Description2TextEdit.Size = New System.Drawing.Size(0, 20)
        Me.Description2TextEdit.StyleController = Me.DataLayoutControl1
        Me.Description2TextEdit.TabIndex = 49
        '
        'OrderTotalTextEdit
        '
        Me.OrderTotalTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "OrderTotal", True))
        Me.OrderTotalTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.OrderTotalTextEdit.Name = "OrderTotalTextEdit"
        Me.OrderTotalTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.OrderTotalTextEdit.StyleController = Me.DataLayoutControl1
        Me.OrderTotalTextEdit.TabIndex = 50
        '
        'DiscountPercentTextEdit
        '
        Me.DiscountPercentTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "DiscountPercent", True))
        Me.DiscountPercentTextEdit.Location = New System.Drawing.Point(588, 65)
        Me.DiscountPercentTextEdit.Name = "DiscountPercentTextEdit"
        Me.DiscountPercentTextEdit.Size = New System.Drawing.Size(133, 20)
        Me.DiscountPercentTextEdit.StyleController = Me.DataLayoutControl1
        Me.DiscountPercentTextEdit.TabIndex = 51
        '
        'DiscountAmountTextEdit
        '
        Me.DiscountAmountTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "DiscountAmount", True))
        Me.DiscountAmountTextEdit.Location = New System.Drawing.Point(587, 95)
        Me.DiscountAmountTextEdit.Name = "DiscountAmountTextEdit"
        Me.DiscountAmountTextEdit.Size = New System.Drawing.Size(135, 20)
        Me.DiscountAmountTextEdit.StyleController = Me.DataLayoutControl1
        Me.DiscountAmountTextEdit.TabIndex = 52
        '
        'NewPriceTextEdit
        '
        Me.NewPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "NewPrice", True))
        Me.NewPriceTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.NewPriceTextEdit.Name = "NewPriceTextEdit"
        Me.NewPriceTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.NewPriceTextEdit.StyleController = Me.DataLayoutControl1
        Me.NewPriceTextEdit.TabIndex = 53
        '
        'WarrantyTextEdit
        '
        Me.WarrantyTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Warranty", True))
        Me.WarrantyTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.WarrantyTextEdit.Name = "WarrantyTextEdit"
        Me.WarrantyTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.WarrantyTextEdit.StyleController = Me.DataLayoutControl1
        Me.WarrantyTextEdit.TabIndex = 54
        '
        'CancelReasonTextEdit
        '
        Me.CancelReasonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "CancelReason", True))
        Me.CancelReasonTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.CancelReasonTextEdit.Name = "CancelReasonTextEdit"
        Me.CancelReasonTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.CancelReasonTextEdit.StyleController = Me.DataLayoutControl1
        Me.CancelReasonTextEdit.TabIndex = 55
        '
        'QuoteCommentsTextEdit
        '
        Me.QuoteCommentsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "QuoteComments", True))
        Me.QuoteCommentsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.QuoteCommentsTextEdit.Name = "QuoteCommentsTextEdit"
        Me.QuoteCommentsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.QuoteCommentsTextEdit.StyleController = Me.DataLayoutControl1
        Me.QuoteCommentsTextEdit.TabIndex = 56
        '
        'PricelistIDTextEdit
        '
        Me.PricelistIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "PricelistID", True))
        Me.PricelistIDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.PricelistIDTextEdit.Name = "PricelistIDTextEdit"
        Me.PricelistIDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.PricelistIDTextEdit.StyleController = Me.DataLayoutControl1
        Me.PricelistIDTextEdit.TabIndex = 57
        '
        'StateTextEdit
        '
        Me.StateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "State", True))
        Me.StateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.StateTextEdit.Name = "StateTextEdit"
        Me.StateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.StateTextEdit.StyleController = Me.DataLayoutControl1
        Me.StateTextEdit.TabIndex = 58
        '
        'JobDeliveriesTextEdit
        '
        Me.JobDeliveriesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobDeliveries", True))
        Me.JobDeliveriesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobDeliveriesTextEdit.Name = "JobDeliveriesTextEdit"
        Me.JobDeliveriesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobDeliveriesTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobDeliveriesTextEdit.TabIndex = 59
        '
        'JobLinesTextEdit
        '
        Me.JobLinesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobLines", True))
        Me.JobLinesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobLinesTextEdit.Name = "JobLinesTextEdit"
        Me.JobLinesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobLinesTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobLinesTextEdit.TabIndex = 60
        '
        'JobTolerancesTextEdit
        '
        Me.JobTolerancesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobTolerances", True))
        Me.JobTolerancesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobTolerancesTextEdit.Name = "JobTolerancesTextEdit"
        Me.JobTolerancesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobTolerancesTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobTolerancesTextEdit.TabIndex = 61
        '
        'JobStageTextEdit
        '
        Me.JobStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobStage", True))
        Me.JobStageTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobStageTextEdit.Name = "JobStageTextEdit"
        Me.JobStageTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobStageTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobStageTextEdit.TabIndex = 62
        '
        'DrawingTextEdit
        '
        Me.DrawingTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Drawing", True))
        Me.DrawingTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.DrawingTextEdit.Name = "DrawingTextEdit"
        Me.DrawingTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.DrawingTextEdit.StyleController = Me.DataLayoutControl1
        Me.DrawingTextEdit.TabIndex = 63
        '
        'GenerationTextEdit
        '
        Me.GenerationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Generation", True))
        Me.GenerationTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.GenerationTextEdit.Name = "GenerationTextEdit"
        Me.GenerationTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.GenerationTextEdit.StyleController = Me.DataLayoutControl1
        Me.GenerationTextEdit.TabIndex = 64
        '
        'MakeTextEdit
        '
        Me.MakeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Make", True))
        Me.MakeTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.MakeTextEdit.Name = "MakeTextEdit"
        Me.MakeTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.MakeTextEdit.StyleController = Me.DataLayoutControl1
        Me.MakeTextEdit.TabIndex = 65
        '
        'ModelTextEdit
        '
        Me.ModelTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Model", True))
        Me.ModelTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ModelTextEdit.Name = "ModelTextEdit"
        Me.ModelTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ModelTextEdit.StyleController = Me.DataLayoutControl1
        Me.ModelTextEdit.TabIndex = 66
        '
        'FunctionTextEdit
        '
        Me.FunctionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Function", True))
        Me.FunctionTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.FunctionTextEdit.Name = "FunctionTextEdit"
        Me.FunctionTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.FunctionTextEdit.StyleController = Me.DataLayoutControl1
        Me.FunctionTextEdit.TabIndex = 67
        '
        'JobCategoryTextEdit
        '
        Me.JobCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobCategory", True))
        Me.JobCategoryTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobCategoryTextEdit.Name = "JobCategoryTextEdit"
        Me.JobCategoryTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobCategoryTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobCategoryTextEdit.TabIndex = 68
        '
        'WorkCentreCategoryTextEdit
        '
        Me.WorkCentreCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "WorkCentreCategory", True))
        Me.WorkCentreCategoryTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.WorkCentreCategoryTextEdit.Name = "WorkCentreCategoryTextEdit"
        Me.WorkCentreCategoryTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.WorkCentreCategoryTextEdit.StyleController = Me.DataLayoutControl1
        Me.WorkCentreCategoryTextEdit.TabIndex = 69
        '
        'JobTemplateTextEdit
        '
        Me.JobTemplateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobTemplate", True))
        Me.JobTemplateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobTemplateTextEdit.Name = "JobTemplateTextEdit"
        Me.JobTemplateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobTemplateTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobTemplateTextEdit.TabIndex = 70
        '
        'CostCentreTextEdit
        '
        Me.CostCentreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "CostCentre", True))
        Me.CostCentreTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.CostCentreTextEdit.Name = "CostCentreTextEdit"
        Me.CostCentreTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.CostCentreTextEdit.StyleController = Me.DataLayoutControl1
        Me.CostCentreTextEdit.TabIndex = 71
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IDTextEdit.StyleController = Me.DataLayoutControl1
        Me.IDTextEdit.TabIndex = 72
        '
        'QuantityDeliveredTextEdit
        '
        Me.QuantityDeliveredTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "QuantityDelivered", True))
        Me.QuantityDeliveredTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.QuantityDeliveredTextEdit.Name = "QuantityDeliveredTextEdit"
        Me.QuantityDeliveredTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.QuantityDeliveredTextEdit.StyleController = Me.DataLayoutControl1
        Me.QuantityDeliveredTextEdit.TabIndex = 73
        '
        'ItemForNextStage
        '
        Me.ItemForNextStage.Control = Me.NextStageTextEdit
        Me.ItemForNextStage.CustomizationFormText = "Next Stage"
        Me.ItemForNextStage.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNextStage.Name = "ItemForNextStage"
        Me.ItemForNextStage.Size = New System.Drawing.Size(0, 0)
        Me.ItemForNextStage.Text = "Next Stage"
        Me.ItemForNextStage.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForNextStage.TextToControlDistance = 5
        '
        'ItemForPreviousStage
        '
        Me.ItemForPreviousStage.Control = Me.PreviousStageTextEdit
        Me.ItemForPreviousStage.CustomizationFormText = "Previous Stage"
        Me.ItemForPreviousStage.Location = New System.Drawing.Point(0, 0)
        Me.ItemForPreviousStage.Name = "ItemForPreviousStage"
        Me.ItemForPreviousStage.Size = New System.Drawing.Size(0, 0)
        Me.ItemForPreviousStage.Text = "Previous Stage"
        Me.ItemForPreviousStage.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForPreviousStage.TextToControlDistance = 5
        '
        'ItemForUnitCost
        '
        Me.ItemForUnitCost.Control = Me.UnitCostTextEdit
        Me.ItemForUnitCost.CustomizationFormText = "Unit Cost"
        Me.ItemForUnitCost.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUnitCost.Name = "ItemForUnitCost"
        Me.ItemForUnitCost.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUnitCost.Text = "Unit Cost"
        Me.ItemForUnitCost.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUnitCost.TextToControlDistance = 5
        '
        'ItemForTotalCost
        '
        Me.ItemForTotalCost.Control = Me.TotalCostTextEdit
        Me.ItemForTotalCost.CustomizationFormText = "Total Cost"
        Me.ItemForTotalCost.Location = New System.Drawing.Point(0, 0)
        Me.ItemForTotalCost.Name = "ItemForTotalCost"
        Me.ItemForTotalCost.Size = New System.Drawing.Size(0, 0)
        Me.ItemForTotalCost.Text = "Total Cost"
        Me.ItemForTotalCost.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForTotalCost.TextToControlDistance = 5
        '
        'ItemForQuoteNumber
        '
        Me.ItemForQuoteNumber.Control = Me.QuoteNumberTextEdit
        Me.ItemForQuoteNumber.CustomizationFormText = "Quote Number"
        Me.ItemForQuoteNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForQuoteNumber.Name = "ItemForQuoteNumber"
        Me.ItemForQuoteNumber.Size = New System.Drawing.Size(0, 0)
        Me.ItemForQuoteNumber.Text = "Quote Number"
        Me.ItemForQuoteNumber.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForQuoteNumber.TextToControlDistance = 5
        '
        'ItemForDeliveryNumber
        '
        Me.ItemForDeliveryNumber.Control = Me.DeliveryNumberTextEdit
        Me.ItemForDeliveryNumber.CustomizationFormText = "Delivery Number"
        Me.ItemForDeliveryNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForDeliveryNumber.Name = "ItemForDeliveryNumber"
        Me.ItemForDeliveryNumber.Size = New System.Drawing.Size(0, 0)
        Me.ItemForDeliveryNumber.Text = "Delivery Number"
        Me.ItemForDeliveryNumber.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForDeliveryNumber.TextToControlDistance = 5
        '
        'ItemForQuoteDate
        '
        Me.ItemForQuoteDate.Control = Me.QuoteDateTextEdit
        Me.ItemForQuoteDate.CustomizationFormText = "Quote Date"
        Me.ItemForQuoteDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForQuoteDate.Name = "ItemForQuoteDate"
        Me.ItemForQuoteDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForQuoteDate.Text = "Quote Date"
        Me.ItemForQuoteDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForQuoteDate.TextToControlDistance = 5
        '
        'ItemForInvoiceDate
        '
        Me.ItemForInvoiceDate.Control = Me.InvoiceDateTextEdit
        Me.ItemForInvoiceDate.CustomizationFormText = "Invoice Date"
        Me.ItemForInvoiceDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForInvoiceDate.Name = "ItemForInvoiceDate"
        Me.ItemForInvoiceDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForInvoiceDate.Text = "Invoice Date"
        Me.ItemForInvoiceDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForInvoiceDate.TextToControlDistance = 5
        '
        'ItemForAcceptedDate
        '
        Me.ItemForAcceptedDate.Control = Me.AcceptedDateTextEdit
        Me.ItemForAcceptedDate.CustomizationFormText = "Accepted Date"
        Me.ItemForAcceptedDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForAcceptedDate.Name = "ItemForAcceptedDate"
        Me.ItemForAcceptedDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForAcceptedDate.Text = "Accepted Date"
        Me.ItemForAcceptedDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForAcceptedDate.TextToControlDistance = 5
        '
        'ItemForEstimatedDeliveryDate
        '
        Me.ItemForEstimatedDeliveryDate.Control = Me.EstimatedDeliveryDateTextEdit
        Me.ItemForEstimatedDeliveryDate.CustomizationFormText = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForEstimatedDeliveryDate.Name = "ItemForEstimatedDeliveryDate"
        Me.ItemForEstimatedDeliveryDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForEstimatedDeliveryDate.Text = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForEstimatedDeliveryDate.TextToControlDistance = 5
        '
        'ItemForCancelledDate
        '
        Me.ItemForCancelledDate.Control = Me.CancelledDateTextEdit
        Me.ItemForCancelledDate.CustomizationFormText = "Cancelled Date"
        Me.ItemForCancelledDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCancelledDate.Name = "ItemForCancelledDate"
        Me.ItemForCancelledDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForCancelledDate.Text = "Cancelled Date"
        Me.ItemForCancelledDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCancelledDate.TextToControlDistance = 5
        '
        'ItemForEstimatedStartDate
        '
        Me.ItemForEstimatedStartDate.Control = Me.EstimatedStartDateTextEdit
        Me.ItemForEstimatedStartDate.CustomizationFormText = "Estimated Start Date"
        Me.ItemForEstimatedStartDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForEstimatedStartDate.Name = "ItemForEstimatedStartDate"
        Me.ItemForEstimatedStartDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForEstimatedStartDate.Text = "Estimated Start Date"
        Me.ItemForEstimatedStartDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForEstimatedStartDate.TextToControlDistance = 5
        '
        'ItemForEstimatedEndDate
        '
        Me.ItemForEstimatedEndDate.Control = Me.EstimatedEndDateTextEdit
        Me.ItemForEstimatedEndDate.CustomizationFormText = "Estimated End Date"
        Me.ItemForEstimatedEndDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForEstimatedEndDate.Name = "ItemForEstimatedEndDate"
        Me.ItemForEstimatedEndDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForEstimatedEndDate.Text = "Estimated End Date"
        Me.ItemForEstimatedEndDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForEstimatedEndDate.TextToControlDistance = 5
        '
        'ItemForActualStartDate
        '
        Me.ItemForActualStartDate.Control = Me.ActualStartDateTextEdit
        Me.ItemForActualStartDate.CustomizationFormText = "Actual Start Date"
        Me.ItemForActualStartDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForActualStartDate.Name = "ItemForActualStartDate"
        Me.ItemForActualStartDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForActualStartDate.Text = "Actual Start Date"
        Me.ItemForActualStartDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForActualStartDate.TextToControlDistance = 5
        '
        'ItemForActualEndDate
        '
        Me.ItemForActualEndDate.Control = Me.ActualEndDateTextEdit
        Me.ItemForActualEndDate.CustomizationFormText = "Actual End Date"
        Me.ItemForActualEndDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForActualEndDate.Name = "ItemForActualEndDate"
        Me.ItemForActualEndDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForActualEndDate.Text = "Actual End Date"
        Me.ItemForActualEndDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForActualEndDate.TextToControlDistance = 5
        '
        'ItemForValidityDays
        '
        Me.ItemForValidityDays.Control = Me.ValidityDaysTextEdit
        Me.ItemForValidityDays.CustomizationFormText = "Validity Days"
        Me.ItemForValidityDays.Location = New System.Drawing.Point(0, 0)
        Me.ItemForValidityDays.Name = "ItemForValidityDays"
        Me.ItemForValidityDays.Size = New System.Drawing.Size(0, 0)
        Me.ItemForValidityDays.Text = "Validity Days"
        Me.ItemForValidityDays.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForValidityDays.TextToControlDistance = 5
        '
        'ItemForDeliveryDays
        '
        Me.ItemForDeliveryDays.Control = Me.DeliveryDaysTextEdit
        Me.ItemForDeliveryDays.CustomizationFormText = "Delivery Days"
        Me.ItemForDeliveryDays.Location = New System.Drawing.Point(0, 0)
        Me.ItemForDeliveryDays.Name = "ItemForDeliveryDays"
        Me.ItemForDeliveryDays.Size = New System.Drawing.Size(0, 0)
        Me.ItemForDeliveryDays.Text = "Delivery Days"
        Me.ItemForDeliveryDays.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForDeliveryDays.TextToControlDistance = 5
        '
        'ItemForIsTemplate
        '
        Me.ItemForIsTemplate.Control = Me.IsTemplateTextEdit
        Me.ItemForIsTemplate.CustomizationFormText = "Is Template"
        Me.ItemForIsTemplate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsTemplate.Name = "ItemForIsTemplate"
        Me.ItemForIsTemplate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIsTemplate.Text = "Is Template"
        Me.ItemForIsTemplate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForIsTemplate.TextToControlDistance = 5
        '
        'ItemForIsBreakdown
        '
        Me.ItemForIsBreakdown.Control = Me.IsBreakdownTextEdit
        Me.ItemForIsBreakdown.CustomizationFormText = "Is Breakdown"
        Me.ItemForIsBreakdown.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsBreakdown.Name = "ItemForIsBreakdown"
        Me.ItemForIsBreakdown.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIsBreakdown.Text = "Is Breakdown"
        Me.ItemForIsBreakdown.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForIsBreakdown.TextToControlDistance = 5
        '
        'ItemForIsApproved
        '
        Me.ItemForIsApproved.Control = Me.IsApprovedTextEdit
        Me.ItemForIsApproved.CustomizationFormText = "Is Approved"
        Me.ItemForIsApproved.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsApproved.Name = "ItemForIsApproved"
        Me.ItemForIsApproved.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIsApproved.Text = "Is Approved"
        Me.ItemForIsApproved.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForIsApproved.TextToControlDistance = 5
        '
        'ItemForIsProcured
        '
        Me.ItemForIsProcured.Control = Me.IsProcuredTextEdit
        Me.ItemForIsProcured.CustomizationFormText = "Is Procured"
        Me.ItemForIsProcured.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsProcured.Name = "ItemForIsProcured"
        Me.ItemForIsProcured.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIsProcured.Text = "Is Procured"
        Me.ItemForIsProcured.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForIsProcured.TextToControlDistance = 5
        '
        'ItemForIsStockDrawn
        '
        Me.ItemForIsStockDrawn.Control = Me.IsStockDrawnTextEdit
        Me.ItemForIsStockDrawn.CustomizationFormText = "Is Stock Drawn"
        Me.ItemForIsStockDrawn.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsStockDrawn.Name = "ItemForIsStockDrawn"
        Me.ItemForIsStockDrawn.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIsStockDrawn.Text = "Is Stock Drawn"
        Me.ItemForIsStockDrawn.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForIsStockDrawn.TextToControlDistance = 5
        '
        'ItemForContractID
        '
        Me.ItemForContractID.Control = Me.ContractIDTextEdit
        Me.ItemForContractID.CustomizationFormText = "Contract ID"
        Me.ItemForContractID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForContractID.Name = "ItemForContractID"
        Me.ItemForContractID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForContractID.Text = "Contract ID"
        Me.ItemForContractID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForContractID.TextToControlDistance = 5
        '
        'ItemForRepresentativeID
        '
        Me.ItemForRepresentativeID.Control = Me.RepresentativeIDTextEdit
        Me.ItemForRepresentativeID.CustomizationFormText = "Representative ID"
        Me.ItemForRepresentativeID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForRepresentativeID.Name = "ItemForRepresentativeID"
        Me.ItemForRepresentativeID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForRepresentativeID.Text = "Representative ID"
        Me.ItemForRepresentativeID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForRepresentativeID.TextToControlDistance = 5
        '
        'ItemForJobAgentID
        '
        Me.ItemForJobAgentID.Control = Me.JobAgentIDTextEdit
        Me.ItemForJobAgentID.CustomizationFormText = "Job Agent ID"
        Me.ItemForJobAgentID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobAgentID.Name = "ItemForJobAgentID"
        Me.ItemForJobAgentID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobAgentID.Text = "Job Agent ID"
        Me.ItemForJobAgentID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobAgentID.TextToControlDistance = 5
        '
        'ItemForApproveAgentID
        '
        Me.ItemForApproveAgentID.Control = Me.ApproveAgentIDTextEdit
        Me.ItemForApproveAgentID.CustomizationFormText = "Approve Agent ID"
        Me.ItemForApproveAgentID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForApproveAgentID.Name = "ItemForApproveAgentID"
        Me.ItemForApproveAgentID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForApproveAgentID.Text = "Approve Agent ID"
        Me.ItemForApproveAgentID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForApproveAgentID.TextToControlDistance = 5
        '
        'ItemForBuyingAgentID
        '
        Me.ItemForBuyingAgentID.Control = Me.BuyingAgentIDTextEdit
        Me.ItemForBuyingAgentID.CustomizationFormText = "Buying Agent ID"
        Me.ItemForBuyingAgentID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForBuyingAgentID.Name = "ItemForBuyingAgentID"
        Me.ItemForBuyingAgentID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForBuyingAgentID.Text = "Buying Agent ID"
        Me.ItemForBuyingAgentID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForBuyingAgentID.TextToControlDistance = 5
        '
        'ItemForAssignedAgentID
        '
        Me.ItemForAssignedAgentID.Control = Me.AssignedAgentIDTextEdit
        Me.ItemForAssignedAgentID.CustomizationFormText = "Assigned Agent ID"
        Me.ItemForAssignedAgentID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForAssignedAgentID.Name = "ItemForAssignedAgentID"
        Me.ItemForAssignedAgentID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForAssignedAgentID.Text = "Assigned Agent ID"
        Me.ItemForAssignedAgentID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForAssignedAgentID.TextToControlDistance = 5
        '
        'ItemForQuoteAgentID
        '
        Me.ItemForQuoteAgentID.Control = Me.QuoteAgentIDTextEdit
        Me.ItemForQuoteAgentID.CustomizationFormText = "Quote Agent ID"
        Me.ItemForQuoteAgentID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForQuoteAgentID.Name = "ItemForQuoteAgentID"
        Me.ItemForQuoteAgentID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForQuoteAgentID.Text = "Quote Agent ID"
        Me.ItemForQuoteAgentID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForQuoteAgentID.TextToControlDistance = 5
        '
        'ItemForJobCardID
        '
        Me.ItemForJobCardID.Control = Me.JobCardIDTextEdit
        Me.ItemForJobCardID.CustomizationFormText = "Job Card ID"
        Me.ItemForJobCardID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobCardID.Name = "ItemForJobCardID"
        Me.ItemForJobCardID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobCardID.Text = "Job Card ID"
        Me.ItemForJobCardID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobCardID.TextToControlDistance = 5
        '
        'ItemForAccountName
        '
        Me.ItemForAccountName.Control = Me.AccountNameTextEdit
        Me.ItemForAccountName.CustomizationFormText = "Account Name"
        Me.ItemForAccountName.Location = New System.Drawing.Point(0, 0)
        Me.ItemForAccountName.Name = "ItemForAccountName"
        Me.ItemForAccountName.Size = New System.Drawing.Size(0, 0)
        Me.ItemForAccountName.Text = "Account Name"
        Me.ItemForAccountName.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForAccountName.TextToControlDistance = 5
        '
        'ItemForTelephone
        '
        Me.ItemForTelephone.Control = Me.TelephoneTextEdit
        Me.ItemForTelephone.CustomizationFormText = "Telephone"
        Me.ItemForTelephone.Location = New System.Drawing.Point(0, 0)
        Me.ItemForTelephone.Name = "ItemForTelephone"
        Me.ItemForTelephone.Size = New System.Drawing.Size(0, 0)
        Me.ItemForTelephone.Text = "Telephone"
        Me.ItemForTelephone.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForTelephone.TextToControlDistance = 5
        '
        'ItemForEmail
        '
        Me.ItemForEmail.Control = Me.EmailTextEdit
        Me.ItemForEmail.CustomizationFormText = "Email"
        Me.ItemForEmail.Location = New System.Drawing.Point(0, 0)
        Me.ItemForEmail.Name = "ItemForEmail"
        Me.ItemForEmail.Size = New System.Drawing.Size(0, 0)
        Me.ItemForEmail.Text = "Email"
        Me.ItemForEmail.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForEmail.TextToControlDistance = 5
        '
        'ItemForFax
        '
        Me.ItemForFax.Control = Me.FaxTextEdit
        Me.ItemForFax.CustomizationFormText = "Fax"
        Me.ItemForFax.Location = New System.Drawing.Point(0, 0)
        Me.ItemForFax.Name = "ItemForFax"
        Me.ItemForFax.Size = New System.Drawing.Size(0, 0)
        Me.ItemForFax.Text = "Fax"
        Me.ItemForFax.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForFax.TextToControlDistance = 5
        '
        'ItemForDescription2
        '
        Me.ItemForDescription2.Control = Me.Description2TextEdit
        Me.ItemForDescription2.CustomizationFormText = "Description2"
        Me.ItemForDescription2.Location = New System.Drawing.Point(0, 0)
        Me.ItemForDescription2.Name = "ItemForDescription2"
        Me.ItemForDescription2.Size = New System.Drawing.Size(0, 0)
        Me.ItemForDescription2.Text = "Description2"
        Me.ItemForDescription2.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForDescription2.TextToControlDistance = 5
        '
        'ItemForOrderTotal
        '
        Me.ItemForOrderTotal.Control = Me.OrderTotalTextEdit
        Me.ItemForOrderTotal.CustomizationFormText = "Order Total"
        Me.ItemForOrderTotal.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOrderTotal.Name = "ItemForOrderTotal"
        Me.ItemForOrderTotal.Size = New System.Drawing.Size(0, 0)
        Me.ItemForOrderTotal.Text = "Order Total"
        Me.ItemForOrderTotal.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForOrderTotal.TextToControlDistance = 5
        '
        'ItemForNewPrice
        '
        Me.ItemForNewPrice.Control = Me.NewPriceTextEdit
        Me.ItemForNewPrice.CustomizationFormText = "New Price"
        Me.ItemForNewPrice.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNewPrice.Name = "ItemForNewPrice"
        Me.ItemForNewPrice.Size = New System.Drawing.Size(0, 0)
        Me.ItemForNewPrice.Text = "New Price"
        Me.ItemForNewPrice.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForNewPrice.TextToControlDistance = 5
        '
        'ItemForWarranty
        '
        Me.ItemForWarranty.Control = Me.WarrantyTextEdit
        Me.ItemForWarranty.CustomizationFormText = "Warranty"
        Me.ItemForWarranty.Location = New System.Drawing.Point(0, 0)
        Me.ItemForWarranty.Name = "ItemForWarranty"
        Me.ItemForWarranty.Size = New System.Drawing.Size(0, 0)
        Me.ItemForWarranty.Text = "Warranty"
        Me.ItemForWarranty.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForWarranty.TextToControlDistance = 5
        '
        'ItemForCancelReason
        '
        Me.ItemForCancelReason.Control = Me.CancelReasonTextEdit
        Me.ItemForCancelReason.CustomizationFormText = "Cancel Reason"
        Me.ItemForCancelReason.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCancelReason.Name = "ItemForCancelReason"
        Me.ItemForCancelReason.Size = New System.Drawing.Size(0, 0)
        Me.ItemForCancelReason.Text = "Cancel Reason"
        Me.ItemForCancelReason.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCancelReason.TextToControlDistance = 5
        '
        'ItemForQuoteComments
        '
        Me.ItemForQuoteComments.Control = Me.QuoteCommentsTextEdit
        Me.ItemForQuoteComments.CustomizationFormText = "Quote Comments"
        Me.ItemForQuoteComments.Location = New System.Drawing.Point(0, 0)
        Me.ItemForQuoteComments.Name = "ItemForQuoteComments"
        Me.ItemForQuoteComments.Size = New System.Drawing.Size(0, 0)
        Me.ItemForQuoteComments.Text = "Quote Comments"
        Me.ItemForQuoteComments.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForQuoteComments.TextToControlDistance = 5
        '
        'ItemForPricelistID
        '
        Me.ItemForPricelistID.Control = Me.PricelistIDTextEdit
        Me.ItemForPricelistID.CustomizationFormText = "Pricelist ID"
        Me.ItemForPricelistID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForPricelistID.Name = "ItemForPricelistID"
        Me.ItemForPricelistID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForPricelistID.Text = "Pricelist ID"
        Me.ItemForPricelistID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForPricelistID.TextToControlDistance = 5
        '
        'ItemForState
        '
        Me.ItemForState.Control = Me.StateTextEdit
        Me.ItemForState.CustomizationFormText = "State"
        Me.ItemForState.Location = New System.Drawing.Point(0, 0)
        Me.ItemForState.Name = "ItemForState"
        Me.ItemForState.Size = New System.Drawing.Size(0, 0)
        Me.ItemForState.Text = "State"
        Me.ItemForState.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForState.TextToControlDistance = 5
        '
        'ItemForJobDeliveries
        '
        Me.ItemForJobDeliveries.Control = Me.JobDeliveriesTextEdit
        Me.ItemForJobDeliveries.CustomizationFormText = "Job Deliveries"
        Me.ItemForJobDeliveries.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobDeliveries.Name = "ItemForJobDeliveries"
        Me.ItemForJobDeliveries.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobDeliveries.Text = "Job Deliveries"
        Me.ItemForJobDeliveries.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobDeliveries.TextToControlDistance = 5
        '
        'ItemForJobLines
        '
        Me.ItemForJobLines.Control = Me.JobLinesTextEdit
        Me.ItemForJobLines.CustomizationFormText = "Job Lines"
        Me.ItemForJobLines.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobLines.Name = "ItemForJobLines"
        Me.ItemForJobLines.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobLines.Text = "Job Lines"
        Me.ItemForJobLines.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobLines.TextToControlDistance = 5
        '
        'ItemForJobTolerances
        '
        Me.ItemForJobTolerances.Control = Me.JobTolerancesTextEdit
        Me.ItemForJobTolerances.CustomizationFormText = "Job Tolerances"
        Me.ItemForJobTolerances.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobTolerances.Name = "ItemForJobTolerances"
        Me.ItemForJobTolerances.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobTolerances.Text = "Job Tolerances"
        Me.ItemForJobTolerances.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobTolerances.TextToControlDistance = 5
        '
        'ItemForJobStage
        '
        Me.ItemForJobStage.Control = Me.JobStageTextEdit
        Me.ItemForJobStage.CustomizationFormText = "Job Stage"
        Me.ItemForJobStage.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobStage.Name = "ItemForJobStage"
        Me.ItemForJobStage.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobStage.Text = "Job Stage"
        Me.ItemForJobStage.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobStage.TextToControlDistance = 5
        '
        'ItemForDrawing
        '
        Me.ItemForDrawing.Control = Me.DrawingTextEdit
        Me.ItemForDrawing.CustomizationFormText = "Drawing"
        Me.ItemForDrawing.Location = New System.Drawing.Point(0, 0)
        Me.ItemForDrawing.Name = "ItemForDrawing"
        Me.ItemForDrawing.Size = New System.Drawing.Size(0, 0)
        Me.ItemForDrawing.Text = "Drawing"
        Me.ItemForDrawing.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForDrawing.TextToControlDistance = 5
        '
        'ItemForGeneration
        '
        Me.ItemForGeneration.Control = Me.GenerationTextEdit
        Me.ItemForGeneration.CustomizationFormText = "Generation"
        Me.ItemForGeneration.Location = New System.Drawing.Point(0, 0)
        Me.ItemForGeneration.Name = "ItemForGeneration"
        Me.ItemForGeneration.Size = New System.Drawing.Size(0, 0)
        Me.ItemForGeneration.Text = "Generation"
        Me.ItemForGeneration.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForGeneration.TextToControlDistance = 5
        '
        'ItemForMake
        '
        Me.ItemForMake.Control = Me.MakeTextEdit
        Me.ItemForMake.CustomizationFormText = "Make"
        Me.ItemForMake.Location = New System.Drawing.Point(0, 0)
        Me.ItemForMake.Name = "ItemForMake"
        Me.ItemForMake.Size = New System.Drawing.Size(0, 0)
        Me.ItemForMake.Text = "Make"
        Me.ItemForMake.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForMake.TextToControlDistance = 5
        '
        'ItemForModel
        '
        Me.ItemForModel.Control = Me.ModelTextEdit
        Me.ItemForModel.CustomizationFormText = "Model"
        Me.ItemForModel.Location = New System.Drawing.Point(0, 0)
        Me.ItemForModel.Name = "ItemForModel"
        Me.ItemForModel.Size = New System.Drawing.Size(0, 0)
        Me.ItemForModel.Text = "Model"
        Me.ItemForModel.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForModel.TextToControlDistance = 5
        '
        'ItemForFunction
        '
        Me.ItemForFunction.Control = Me.FunctionTextEdit
        Me.ItemForFunction.CustomizationFormText = "Function"
        Me.ItemForFunction.Location = New System.Drawing.Point(0, 0)
        Me.ItemForFunction.Name = "ItemForFunction"
        Me.ItemForFunction.Size = New System.Drawing.Size(0, 0)
        Me.ItemForFunction.Text = "Function"
        Me.ItemForFunction.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForFunction.TextToControlDistance = 5
        '
        'ItemForJobCategory
        '
        Me.ItemForJobCategory.Control = Me.JobCategoryTextEdit
        Me.ItemForJobCategory.CustomizationFormText = "Job Category"
        Me.ItemForJobCategory.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobCategory.Name = "ItemForJobCategory"
        Me.ItemForJobCategory.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobCategory.Text = "Job Category"
        Me.ItemForJobCategory.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobCategory.TextToControlDistance = 5
        '
        'ItemForWorkCentreCategory
        '
        Me.ItemForWorkCentreCategory.Control = Me.WorkCentreCategoryTextEdit
        Me.ItemForWorkCentreCategory.CustomizationFormText = "Work Centre Category"
        Me.ItemForWorkCentreCategory.Location = New System.Drawing.Point(0, 0)
        Me.ItemForWorkCentreCategory.Name = "ItemForWorkCentreCategory"
        Me.ItemForWorkCentreCategory.Size = New System.Drawing.Size(0, 0)
        Me.ItemForWorkCentreCategory.Text = "Work Centre Category"
        Me.ItemForWorkCentreCategory.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForWorkCentreCategory.TextToControlDistance = 5
        '
        'ItemForJobTemplate
        '
        Me.ItemForJobTemplate.Control = Me.JobTemplateTextEdit
        Me.ItemForJobTemplate.CustomizationFormText = "Job Template"
        Me.ItemForJobTemplate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobTemplate.Name = "ItemForJobTemplate"
        Me.ItemForJobTemplate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobTemplate.Text = "Job Template"
        Me.ItemForJobTemplate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobTemplate.TextToControlDistance = 5
        '
        'ItemForCostCentre
        '
        Me.ItemForCostCentre.Control = Me.CostCentreTextEdit
        Me.ItemForCostCentre.CustomizationFormText = "Cost Centre"
        Me.ItemForCostCentre.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCostCentre.Name = "ItemForCostCentre"
        Me.ItemForCostCentre.Size = New System.Drawing.Size(0, 0)
        Me.ItemForCostCentre.Text = "Cost Centre"
        Me.ItemForCostCentre.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCostCentre.TextToControlDistance = 5
        '
        'ItemForID
        '
        Me.ItemForID.Control = Me.IDTextEdit
        Me.ItemForID.CustomizationFormText = "ID"
        Me.ItemForID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForID.Name = "ItemForID"
        Me.ItemForID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForID.Text = "ID"
        Me.ItemForID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForID.TextToControlDistance = 5
        '
        'ItemForQuantityDelivered
        '
        Me.ItemForQuantityDelivered.Control = Me.QuantityDeliveredTextEdit
        Me.ItemForQuantityDelivered.CustomizationFormText = "Quantity Delivered"
        Me.ItemForQuantityDelivered.Location = New System.Drawing.Point(0, 0)
        Me.ItemForQuantityDelivered.Name = "ItemForQuantityDelivered"
        Me.ItemForQuantityDelivered.Size = New System.Drawing.Size(0, 0)
        Me.ItemForQuantityDelivered.Text = "Quantity Delivered"
        Me.ItemForQuantityDelivered.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForQuantityDelivered.TextToControlDistance = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(969, 425)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCustomer, Me.ItemForJobType, Me.ItemForDescription1, Me.ItemForJobNumber, Me.ItemForOrderNumber, Me.ItemForQuantity, Me.ItemForDiscountPercent, Me.ItemForTotalPrice, Me.ItemForUnitPrice, Me.ItemForContactName, Me.ItemForDiscountAmount, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.chkIncPictureInfo})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(969, 425)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCustomer
        '
        Me.ItemForCustomer.Control = Me.CustomerTextEdit
        Me.ItemForCustomer.CustomizationFormText = "Customer"
        Me.ItemForCustomer.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCustomer.Name = "ItemForCustomer"
        Me.ItemForCustomer.Size = New System.Drawing.Size(484, 30)
        Me.ItemForCustomer.Text = "Customer"
        Me.ItemForCustomer.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForCustomer.TextToControlDistance = 5
        '
        'ItemForJobType
        '
        Me.ItemForJobType.Control = Me.JobTypeTextEdit
        Me.ItemForJobType.CustomizationFormText = "Job Type"
        Me.ItemForJobType.Location = New System.Drawing.Point(0, 30)
        Me.ItemForJobType.Name = "ItemForJobType"
        Me.ItemForJobType.Size = New System.Drawing.Size(242, 30)
        Me.ItemForJobType.Text = "Job Type"
        Me.ItemForJobType.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForJobType.TextToControlDistance = 5
        '
        'ItemForDescription1
        '
        Me.ItemForDescription1.Control = Me.Description1TextEdit
        Me.ItemForDescription1.CustomizationFormText = "Description1"
        Me.ItemForDescription1.Location = New System.Drawing.Point(0, 60)
        Me.ItemForDescription1.Name = "ItemForDescription1"
        Me.ItemForDescription1.Size = New System.Drawing.Size(484, 30)
        Me.ItemForDescription1.Text = "Description"
        Me.ItemForDescription1.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForDescription1.TextToControlDistance = 5
        '
        'ItemForJobNumber
        '
        Me.ItemForJobNumber.Control = Me.JobNumberTextEdit
        Me.ItemForJobNumber.CustomizationFormText = "Job Number"
        Me.ItemForJobNumber.Location = New System.Drawing.Point(484, 0)
        Me.ItemForJobNumber.Name = "ItemForJobNumber"
        Me.ItemForJobNumber.Size = New System.Drawing.Size(485, 30)
        Me.ItemForJobNumber.Text = "Job Number"
        Me.ItemForJobNumber.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForJobNumber.TextToControlDistance = 5
        '
        'ItemForOrderNumber
        '
        Me.ItemForOrderNumber.Control = Me.OrderNumberTextEdit
        Me.ItemForOrderNumber.CustomizationFormText = "Order Number"
        Me.ItemForOrderNumber.Location = New System.Drawing.Point(485, 30)
        Me.ItemForOrderNumber.Name = "ItemForOrderNumber"
        Me.ItemForOrderNumber.Size = New System.Drawing.Size(484, 30)
        Me.ItemForOrderNumber.Text = "Order Number"
        Me.ItemForOrderNumber.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForOrderNumber.TextToControlDistance = 5
        '
        'ItemForQuantity
        '
        Me.ItemForQuantity.Control = Me.QuantityTextEdit
        Me.ItemForQuantity.CustomizationFormText = "Qty"
        Me.ItemForQuantity.Location = New System.Drawing.Point(242, 30)
        Me.ItemForQuantity.Name = "ItemForQuantity"
        Me.ItemForQuantity.Size = New System.Drawing.Size(243, 30)
        Me.ItemForQuantity.Text = "Qty"
        Me.ItemForQuantity.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForQuantity.TextToControlDistance = 5
        '
        'ItemForDiscountPercent
        '
        Me.ItemForDiscountPercent.Control = Me.DiscountPercentTextEdit
        Me.ItemForDiscountPercent.CustomizationFormText = "Discount %"
        Me.ItemForDiscountPercent.Location = New System.Drawing.Point(484, 60)
        Me.ItemForDiscountPercent.Name = "ItemForDiscountPercent"
        Me.ItemForDiscountPercent.Size = New System.Drawing.Size(242, 30)
        Me.ItemForDiscountPercent.Text = "Discount %"
        Me.ItemForDiscountPercent.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForDiscountPercent.TextToControlDistance = 5
        '
        'ItemForTotalPrice
        '
        Me.ItemForTotalPrice.Control = Me.TotalPriceTextEdit
        Me.ItemForTotalPrice.CustomizationFormText = "Total "
        Me.ItemForTotalPrice.Location = New System.Drawing.Point(727, 90)
        Me.ItemForTotalPrice.Name = "ItemForTotalPrice"
        Me.ItemForTotalPrice.Size = New System.Drawing.Size(242, 30)
        Me.ItemForTotalPrice.Text = "Total "
        Me.ItemForTotalPrice.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForTotalPrice.TextToControlDistance = 5
        '
        'ItemForUnitPrice
        '
        Me.ItemForUnitPrice.Control = Me.UnitPriceTextEdit
        Me.ItemForUnitPrice.CustomizationFormText = "Price"
        Me.ItemForUnitPrice.Location = New System.Drawing.Point(726, 60)
        Me.ItemForUnitPrice.Name = "ItemForUnitPrice"
        Me.ItemForUnitPrice.Size = New System.Drawing.Size(243, 30)
        Me.ItemForUnitPrice.Text = "Price"
        Me.ItemForUnitPrice.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForUnitPrice.TextToControlDistance = 5
        '
        'ItemForContactName
        '
        Me.ItemForContactName.Control = Me.ContactNameTextEdit
        Me.ItemForContactName.CustomizationFormText = "Contact "
        Me.ItemForContactName.Location = New System.Drawing.Point(0, 90)
        Me.ItemForContactName.Name = "ItemForContactName"
        Me.ItemForContactName.Size = New System.Drawing.Size(483, 30)
        Me.ItemForContactName.Text = "Contact "
        Me.ItemForContactName.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForContactName.TextToControlDistance = 5
        '
        'ItemForDiscountAmount
        '
        Me.ItemForDiscountAmount.Control = Me.DiscountAmountTextEdit
        Me.ItemForDiscountAmount.CustomizationFormText = "Discount "
        Me.ItemForDiscountAmount.Location = New System.Drawing.Point(483, 90)
        Me.ItemForDiscountAmount.Name = "ItemForDiscountAmount"
        Me.ItemForDiscountAmount.Size = New System.Drawing.Size(244, 30)
        Me.ItemForDiscountAmount.Text = "Discount "
        Me.ItemForDiscountAmount.TextSize = New System.Drawing.Size(94, 13)
        Me.ItemForDiscountAmount.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gcQuotation
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 239)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(969, 186)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtHeader
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(481, 30)
        Me.LayoutControlItem2.Text = "Header"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(94, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtFooter
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(481, 120)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(488, 30)
        Me.LayoutControlItem3.Text = "Footer"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(94, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.chkInclPrices
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 150)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(481, 29)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chkInclDrawing
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(481, 150)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(488, 29)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.chkIncludeCommonLetter
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 179)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(481, 30)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TextEdit3
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(481, 179)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(242, 30)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.TextEdit4
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(723, 179)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(246, 30)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.chkInclDamageReport
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 209)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(481, 30)
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.chkIncNRInfo
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(481, 209)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(242, 30)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'chkIncPictureInfo
        '
        Me.chkIncPictureInfo.Control = Me.TextEdit5
        Me.chkIncPictureInfo.CustomizationFormText = "LayoutControlItem11"
        Me.chkIncPictureInfo.Location = New System.Drawing.Point(723, 209)
        Me.chkIncPictureInfo.Name = "chkIncPictureInfo"
        Me.chkIncPictureInfo.Size = New System.Drawing.Size(246, 30)
        Me.chkIncPictureInfo.Text = "Include Picture Info"
        Me.chkIncPictureInfo.TextSize = New System.Drawing.Size(94, 13)
        Me.chkIncPictureInfo.TextToControlDistance = 5
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiSave, Me.bbiCancel})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(969, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 447)
        Me.barDockControlBottom.Size = New System.Drawing.Size(969, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 425)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(969, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 425)
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCancel, True)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "&Save"
        Me.bbiSave.Id = 0
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiCancel
        '
        Me.bbiCancel.Caption = "&Cancel"
        Me.bbiCancel.Id = 1
        Me.bbiCancel.Name = "bbiCancel"
        '
        'xfQuotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 470)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfQuotation"
        Me.Text = "Quotation"
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncNRInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInclDamageReport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncludeCommonLetter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInclDrawing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInclPrices.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcQuotation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQuotation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcceptedDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedDeliveryDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelledDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedEndDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualEndDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidityDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsTemplateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsBreakdownTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsApprovedTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsProcuredTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsStockDrawnTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepresentativeIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobAgentIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApproveAgentIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyingAgentIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignedAgentIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteAgentIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCardIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelephoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTotalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountPercentTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountAmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarrantyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteCommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PricelistIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDeliveriesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLinesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTolerancesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FunctionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTemplateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCentreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityDeliveredTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPreviousStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAcceptedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCancelledDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActualStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActualEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidityDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsBreakdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsApproved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsProcured, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsStockDrawn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForContractID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRepresentativeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobAgentID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForApproveAgentID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForBuyingAgentID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAssignedAgentID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteAgentID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobCardID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAccountName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTelephone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNewPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWarranty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCancelReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteComments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPricelistID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDeliveries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobTolerances, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForGeneration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFunction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCostCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuantityDelivered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDiscountPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTotalPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForContactName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDiscountAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncPictureInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkIncNRInfo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInclDamageReport As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkIncludeCommonLetter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInclDrawing As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInclPrices As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFooter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHeader As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcQuotation As DevExpress.XtraGrid.GridControl
    Friend WithEvents JobLineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gvQuotation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantityStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantitySupplier1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantitySupplier2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NextStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PreviousStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobTypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitPriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalPriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuantityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoteNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliveryNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrderNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoteDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InvoiceDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AcceptedDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EstimatedDeliveryDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CancelledDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EstimatedStartDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EstimatedEndDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ActualStartDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ActualEndDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ValidityDaysTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliveryDaysTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsTemplateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsBreakdownTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsApprovedTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsProcuredTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsStockDrawnTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContractIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepresentativeIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobAgentIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApproveAgentIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BuyingAgentIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AssignedAgentIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoteAgentIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobCardIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AccountNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContactNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelephoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Description1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Description2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrderTotalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DiscountPercentTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DiscountAmountTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NewPriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WarrantyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CancelReasonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoteCommentsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PricelistIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobDeliveriesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobLinesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobTolerancesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DrawingTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GenerationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MakeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ModelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FunctionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobCategoryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkCentreCategoryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobTemplateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CostCentreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuantityDeliveredTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForNextStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPreviousStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUnitCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTotalCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuoteNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeliveryNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuoteDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForInvoiceDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAcceptedDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedDeliveryDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCancelledDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActualStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActualEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidityDays As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeliveryDays As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsTemplate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsBreakdown As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsApproved As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsProcured As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsStockDrawn As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForContractID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRepresentativeID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobAgentID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForApproveAgentID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForBuyingAgentID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAssignedAgentID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuoteAgentID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobCardID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAccountName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTelephone As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEmail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFax As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrderTotal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNewPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWarranty As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCancelReason As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuoteComments As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPricelistID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForState As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDeliveries As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobLines As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobTolerances As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDrawing As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForGeneration As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMake As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForModel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFunction As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWorkCentreCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobTemplate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCostCentre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuantityDelivered As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCustomer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrderNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuantity As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDiscountPercent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTotalPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUnitPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForContactName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDiscountAmount As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkIncPictureInfo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
