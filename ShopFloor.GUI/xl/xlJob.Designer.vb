<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlJob
    Inherits UniSource.ShopFloor.GUI.xlgJob

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
        Me.gcJob = New DevExpress.XtraGrid.GridControl()
        Me.gvJob = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsBreakdown = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsApproved = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsProcured = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsStockDrawn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCancelReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobStage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobAgent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRepresentativeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRepresentativeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerialNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.JobAuditDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.JobEnquiryDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.dlcJobEnquiry = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.NextStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PreviousStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PrimaryArtisanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CostCentreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobTypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LastActivityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TotalCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TotalPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuantityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuantityDeliveredTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuoteNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DeliveryNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrderNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDateTextEdit = New DevExpress.XtraEditors.TextEdit()
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
        Me.JobStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DrawingTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GenerationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MakeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ModelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FunctionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobCategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkCentreCategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsBreakdownTextEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsApprovedTextEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsProcuredTextEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsStockDrawnTextEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.QuoteAgentTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobAgentTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RequisitionNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDeliveriesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobLinesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobTolerancesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RequisitionsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NotesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobMemoesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDrawingAnnotationsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AuditsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForNextStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPreviousStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedDeliveryDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActualStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActualEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsProcured = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsBreakdown = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsApproved = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsStockDrawn = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForValidityDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForInvoiceDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAcceptedDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCancelledDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuantityDelivered = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPrimaryArtisan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForLastActivity = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForState = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDrawing = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForGeneration = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEmail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWarranty = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCancelReason = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteComments = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNewPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnitCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnitPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTotalCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTotalPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuantity = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrderTotal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDiscountPercent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDiscountAmount = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRequisitionNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDeliveries = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobLines = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobTolerances = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRequisitions = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNotes = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobMemoes = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDrawingAnnotations = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAudits = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCostCentre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCustomer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAccountName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWorkCentreCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPricelistID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForContactName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForFax = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTelephone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForQuoteNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrderNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForMake = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForModel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForFunction = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForQuoteAgent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobAgent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.bsiReports = New DevExpress.XtraBars.BarButtonItem()
        Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JobAuditDockPanel.SuspendLayout()
        Me.JobEnquiryDockPanel.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.dlcJobEnquiry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dlcJobEnquiry.SuspendLayout()
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimaryArtisanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCentreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastActivityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityDeliveredTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.JobStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FunctionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsBreakdownTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsApprovedTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsProcuredTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsStockDrawnTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteAgentTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobAgentTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDeliveriesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLinesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTolerancesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobMemoesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDrawingAnnotationsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPreviousStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActualStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActualEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsProcured, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsBreakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsApproved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsStockDrawn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidityDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAcceptedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCancelledDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuantityDelivered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPrimaryArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForLastActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForGeneration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWarranty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCancelReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteComments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNewPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTotalPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDiscountPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDiscountAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRequisitionNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDeliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobTolerances, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRequisitions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobMemoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDrawingAnnotations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAudits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCostCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAccountName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPricelistID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForContactName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTelephone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFunction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcJob)
        Me.GridPanel.Location = New System.Drawing.Point(0, 57)
        Me.GridPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridPanel.Size = New System.Drawing.Size(1524, 925)
        '
        'gcJob
        '
        Me.gcJob.DataSource = Me.BindingSource
        Me.gcJob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJob.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcJob.Location = New System.Drawing.Point(0, 0)
        Me.gcJob.MainView = Me.gvJob
        Me.gcJob.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcJob.MenuManager = Me.barManager
        Me.gcJob.Name = "gcJob"
        Me.gcJob.ShowOnlyPredefinedDetails = True
        Me.gcJob.Size = New System.Drawing.Size(1524, 925)
        Me.gcJob.TabIndex = 0
        Me.gcJob.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJob})
        '
        'gvJob
        '
        Me.gvJob.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomer, Me.colJobType, Me.colTotalCost, Me.colTotalPrice, Me.colQuantity, Me.colJobNumber, Me.colQuoteNumber, Me.colDeliveryNumber, Me.colOrderNumber, Me.colJobDate, Me.colQuoteDate, Me.colIsBreakdown, Me.colIsApproved, Me.colIsProcured, Me.colIsStockDrawn, Me.colAccountName, Me.colContactName, Me.colDescription1, Me.colDescription2, Me.colOrderTotal, Me.colCancelReason, Me.colQuoteComments, Me.colJobStage, Me.colJobAgent, Me.colRepresentativeCode, Me.colRepresentativeName, Me.colSerialNo})
        Me.gvJob.GridControl = Me.gcJob
        Me.gvJob.Name = "gvJob"
        Me.gvJob.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvJob.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvJob.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvJob.OptionsBehavior.Editable = False
        Me.gvJob.OptionsBehavior.ReadOnly = True
        Me.gvJob.OptionsDetail.AllowZoomDetail = False
        Me.gvJob.OptionsDetail.EnableMasterViewMode = False
        Me.gvJob.OptionsDetail.ShowDetailTabs = False
        Me.gvJob.OptionsDetail.SmartDetailExpand = False
        Me.gvJob.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gvJob.OptionsView.ColumnAutoWidth = False
        Me.gvJob.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRepresentativeCode, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCustomer
        '
        Me.colCustomer.Caption = "Customer"
        Me.colCustomer.FieldName = "Customer.Account"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 5
        '
        'colJobType
        '
        Me.colJobType.Caption = "Job Type"
        Me.colJobType.FieldName = "JobType.Description"
        Me.colJobType.Name = "colJobType"
        Me.colJobType.Visible = True
        Me.colJobType.VisibleIndex = 12
        '
        'colTotalCost
        '
        Me.colTotalCost.DisplayFormat.FormatString = "c"
        Me.colTotalCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.GroupFormat.FormatString = "c"
        Me.colTotalCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCost", "{0:c2}")})
        '
        'colTotalPrice
        '
        Me.colTotalPrice.DisplayFormat.FormatString = "c"
        Me.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalPrice.FieldName = "TotalPrice"
        Me.colTotalPrice.GroupFormat.FormatString = "c"
        Me.colTotalPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalPrice.Name = "colTotalPrice"
        Me.colTotalPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:c2}")})
        Me.colTotalPrice.Visible = True
        Me.colTotalPrice.VisibleIndex = 11
        '
        'colQuantity
        '
        Me.colQuantity.DisplayFormat.FormatString = "f"
        Me.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.GroupFormat.FormatString = "f"
        Me.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:f2}")})
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 10
        '
        'colJobNumber
        '
        Me.colJobNumber.FieldName = "JobNumber"
        Me.colJobNumber.Name = "colJobNumber"
        Me.colJobNumber.Visible = True
        Me.colJobNumber.VisibleIndex = 0
        Me.colJobNumber.Width = 76
        '
        'colQuoteNumber
        '
        Me.colQuoteNumber.FieldName = "QuoteNumber"
        Me.colQuoteNumber.Name = "colQuoteNumber"
        Me.colQuoteNumber.Visible = True
        Me.colQuoteNumber.VisibleIndex = 3
        Me.colQuoteNumber.Width = 89
        '
        'colDeliveryNumber
        '
        Me.colDeliveryNumber.FieldName = "DeliveryNumber"
        Me.colDeliveryNumber.Name = "colDeliveryNumber"
        Me.colDeliveryNumber.Visible = True
        Me.colDeliveryNumber.VisibleIndex = 9
        Me.colDeliveryNumber.Width = 98
        '
        'colOrderNumber
        '
        Me.colOrderNumber.FieldName = "OrderNumber"
        Me.colOrderNumber.Name = "colOrderNumber"
        Me.colOrderNumber.Visible = True
        Me.colOrderNumber.VisibleIndex = 8
        Me.colOrderNumber.Width = 87
        '
        'colJobDate
        '
        Me.colJobDate.FieldName = "JobDate"
        Me.colJobDate.Name = "colJobDate"
        Me.colJobDate.Visible = True
        Me.colJobDate.VisibleIndex = 2
        '
        'colQuoteDate
        '
        Me.colQuoteDate.FieldName = "QuoteDate"
        Me.colQuoteDate.Name = "colQuoteDate"
        Me.colQuoteDate.Visible = True
        Me.colQuoteDate.VisibleIndex = 4
        '
        'colIsBreakdown
        '
        Me.colIsBreakdown.FieldName = "IsBreakdown"
        Me.colIsBreakdown.Name = "colIsBreakdown"
        '
        'colIsApproved
        '
        Me.colIsApproved.FieldName = "IsApproved"
        Me.colIsApproved.Name = "colIsApproved"
        '
        'colIsProcured
        '
        Me.colIsProcured.FieldName = "IsProcured"
        Me.colIsProcured.Name = "colIsProcured"
        '
        'colIsStockDrawn
        '
        Me.colIsStockDrawn.FieldName = "IsStockDrawn"
        Me.colIsStockDrawn.Name = "colIsStockDrawn"
        Me.colIsStockDrawn.Width = 81
        '
        'colAccountName
        '
        Me.colAccountName.FieldName = "AccountName"
        Me.colAccountName.Name = "colAccountName"
        Me.colAccountName.Visible = True
        Me.colAccountName.VisibleIndex = 6
        Me.colAccountName.Width = 88
        '
        'colContactName
        '
        Me.colContactName.FieldName = "ContactName"
        Me.colContactName.Name = "colContactName"
        Me.colContactName.Visible = True
        Me.colContactName.VisibleIndex = 13
        Me.colContactName.Width = 87
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description1"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 1
        Me.colDescription1.Width = 150
        '
        'colDescription2
        '
        Me.colDescription2.FieldName = "Description2"
        Me.colDescription2.Name = "colDescription2"
        Me.colDescription2.Visible = True
        Me.colDescription2.VisibleIndex = 14
        Me.colDescription2.Width = 78
        '
        'colOrderTotal
        '
        Me.colOrderTotal.DisplayFormat.FormatString = "c"
        Me.colOrderTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOrderTotal.FieldName = "OrderTotal"
        Me.colOrderTotal.GroupFormat.FormatString = "c"
        Me.colOrderTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOrderTotal.Name = "colOrderTotal"
        Me.colOrderTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderTotal", "{0:c2}")})
        Me.colOrderTotal.Visible = True
        Me.colOrderTotal.VisibleIndex = 15
        '
        'colCancelReason
        '
        Me.colCancelReason.FieldName = "CancelReason"
        Me.colCancelReason.Name = "colCancelReason"
        Me.colCancelReason.Visible = True
        Me.colCancelReason.VisibleIndex = 16
        Me.colCancelReason.Width = 90
        '
        'colQuoteComments
        '
        Me.colQuoteComments.FieldName = "QuoteComments"
        Me.colQuoteComments.Name = "colQuoteComments"
        Me.colQuoteComments.Width = 102
        '
        'colJobStage
        '
        Me.colJobStage.Caption = "Job Stage"
        Me.colJobStage.FieldName = "JobStage.Description"
        Me.colJobStage.Name = "colJobStage"
        Me.colJobStage.Visible = True
        Me.colJobStage.VisibleIndex = 17
        '
        'colJobAgent
        '
        Me.colJobAgent.Caption = "Job Agent"
        Me.colJobAgent.FieldName = "JobAgent.CDisplayName"
        Me.colJobAgent.Name = "colJobAgent"
        Me.colJobAgent.Visible = True
        Me.colJobAgent.VisibleIndex = 18
        '
        'colRepresentativeCode
        '
        Me.colRepresentativeCode.Caption = "Representative Code"
        Me.colRepresentativeCode.FieldName = "Representative.Code"
        Me.colRepresentativeCode.Name = "colRepresentativeCode"
        Me.colRepresentativeCode.Visible = True
        Me.colRepresentativeCode.VisibleIndex = 7
        '
        'colRepresentativeName
        '
        Me.colRepresentativeName.Caption = "Representative Name"
        Me.colRepresentativeName.FieldName = "Representative.Description"
        Me.colRepresentativeName.Name = "colRepresentativeName"
        '
        'colSerialNo
        '
        Me.colSerialNo.Caption = "Serial Number"
        Me.colSerialNo.FieldName = "SerialNumber"
        Me.colSerialNo.Name = "colSerialNo"
        Me.colSerialNo.Visible = True
        Me.colSerialNo.VisibleIndex = 19
        '
        'DockManager
        '
        Me.DockManager.Form = Me
        Me.DockManager.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.JobAuditDockPanel})
        Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.JobEnquiryDockPanel})
        Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'JobAuditDockPanel
        '
        Me.JobAuditDockPanel.Controls.Add(Me.ControlContainer1)
        Me.JobAuditDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.JobAuditDockPanel.ID = New System.Guid("c3822c22-b0e6-424e-b294-79bbeed2b38f")
        Me.JobAuditDockPanel.Location = New System.Drawing.Point(0, 0)
        Me.JobAuditDockPanel.Name = "JobAuditDockPanel"
        Me.JobAuditDockPanel.OriginalSize = New System.Drawing.Size(200, 200)
        Me.JobAuditDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.JobAuditDockPanel.SavedIndex = 0
        Me.JobAuditDockPanel.Size = New System.Drawing.Size(200, 745)
        Me.JobAuditDockPanel.Text = "Job Audit"
        Me.JobAuditDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'ControlContainer1
        '
        Me.ControlContainer1.Location = New System.Drawing.Point(4, 23)
        Me.ControlContainer1.Name = "ControlContainer1"
        Me.ControlContainer1.Size = New System.Drawing.Size(192, 718)
        Me.ControlContainer1.TabIndex = 0
        '
        'JobEnquiryDockPanel
        '
        Me.JobEnquiryDockPanel.Controls.Add(Me.DockPanel1_Container)
        Me.JobEnquiryDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.JobEnquiryDockPanel.FloatSize = New System.Drawing.Size(200, 476)
        Me.JobEnquiryDockPanel.ID = New System.Guid("ae66a01b-3a5a-41aa-8b1e-c75f33902c07")
        Me.JobEnquiryDockPanel.Location = New System.Drawing.Point(1524, 57)
        Me.JobEnquiryDockPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobEnquiryDockPanel.Name = "JobEnquiryDockPanel"
        Me.JobEnquiryDockPanel.OriginalSize = New System.Drawing.Size(400, 200)
        Me.JobEnquiryDockPanel.Size = New System.Drawing.Size(400, 925)
        Me.JobEnquiryDockPanel.Text = "Job Enquiry"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.dlcJobEnquiry)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 24)
        Me.DockPanel1_Container.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(392, 897)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'dlcJobEnquiry
        '
        Me.dlcJobEnquiry.Controls.Add(Me.NextStageTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.PreviousStageTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.PrimaryArtisanTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.CustomerTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.CostCentreTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobTypeTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.LastActivityTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.UnitCostTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.UnitPriceTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.TotalCostTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.TotalPriceTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.QuantityTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.QuantityDeliveredTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobNumberTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.QuoteNumberTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.DeliveryNumberTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.OrderNumberTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobDateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.QuoteDateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.InvoiceDateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.AcceptedDateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.EstimatedDeliveryDateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.CancelledDateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.EstimatedStartDateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.EstimatedEndDateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.ActualStartDateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.ActualEndDateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.ValidityDaysTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.DeliveryDaysTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.AccountNameTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.ContactNameTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.TelephoneTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.EmailTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.FaxTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.Description1TextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.Description2TextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.OrderTotalTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.DiscountPercentTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.DiscountAmountTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.NewPriceTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.WarrantyTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.CancelReasonTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.QuoteCommentsTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.PricelistIDTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.StateTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobStageTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.DrawingTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.GenerationTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.MakeTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.ModelTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.FunctionTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobCategoryTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.WorkCentreCategoryTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.IsBreakdownTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.IsApprovedTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.IsProcuredTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.IsStockDrawnTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.QuoteAgentTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobAgentTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.RequisitionNumberTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobDeliveriesTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobLinesTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobTolerancesTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.RequisitionsTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.NotesTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobMemoesTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.JobDrawingAnnotationsTextEdit)
        Me.dlcJobEnquiry.Controls.Add(Me.AuditsTextEdit)
        Me.dlcJobEnquiry.DataSource = Me.BindingSource
        Me.dlcJobEnquiry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dlcJobEnquiry.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForNextStage, Me.ItemForPreviousStage, Me.ItemForEstimatedDeliveryDate, Me.ItemForEstimatedStartDate, Me.ItemForEstimatedEndDate, Me.ItemForActualStartDate, Me.ItemForActualEndDate, Me.ItemForIsProcured, Me.ItemForIsBreakdown, Me.ItemForIsApproved, Me.ItemForIsStockDrawn, Me.ItemForValidityDays, Me.ItemForDeliveryDays, Me.ItemForInvoiceDate, Me.ItemForAcceptedDate, Me.ItemForCancelledDate, Me.ItemForQuoteDate, Me.ItemForQuantityDelivered, Me.ItemForPrimaryArtisan, Me.ItemForLastActivity, Me.ItemForState, Me.ItemForDrawing, Me.ItemForGeneration, Me.ItemForEmail, Me.ItemForJobCategory, Me.ItemForWarranty, Me.ItemForCancelReason, Me.ItemForQuoteComments, Me.ItemForNewPrice, Me.ItemForUnitCost, Me.ItemForUnitPrice, Me.ItemForTotalCost, Me.ItemForTotalPrice, Me.ItemForQuantity, Me.ItemForOrderTotal, Me.ItemForDiscountPercent, Me.ItemForDiscountAmount, Me.ItemForRequisitionNumber, Me.ItemForJobDeliveries, Me.ItemForJobLines, Me.ItemForJobTolerances, Me.ItemForRequisitions, Me.ItemForNotes, Me.ItemForJobMemoes, Me.ItemForJobDrawingAnnotations, Me.ItemForAudits})
        Me.dlcJobEnquiry.Location = New System.Drawing.Point(0, 0)
        Me.dlcJobEnquiry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dlcJobEnquiry.Name = "dlcJobEnquiry"
        Me.dlcJobEnquiry.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(636, 225, 250, 350)
        Me.dlcJobEnquiry.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.[True]
        Me.dlcJobEnquiry.OptionsView.UseSkinIndents = False
        Me.dlcJobEnquiry.Root = Me.LayoutControlGroup1
        Me.dlcJobEnquiry.Size = New System.Drawing.Size(392, 897)
        Me.dlcJobEnquiry.TabIndex = 0
        Me.dlcJobEnquiry.Text = "Job Enquiry"
        '
        'NextStageTextEdit
        '
        Me.NextStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "NextStage", True))
        Me.NextStageTextEdit.Location = New System.Drawing.Point(146, 80)
        Me.NextStageTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NextStageTextEdit.MenuManager = Me.barManager
        Me.NextStageTextEdit.Name = "NextStageTextEdit"
        Me.NextStageTextEdit.Properties.ReadOnly = True
        Me.NextStageTextEdit.Size = New System.Drawing.Size(307, 22)
        Me.NextStageTextEdit.StyleController = Me.dlcJobEnquiry
        Me.NextStageTextEdit.TabIndex = 4
        '
        'PreviousStageTextEdit
        '
        Me.PreviousStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PreviousStage", True))
        Me.PreviousStageTextEdit.Location = New System.Drawing.Point(146, 80)
        Me.PreviousStageTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PreviousStageTextEdit.MenuManager = Me.barManager
        Me.PreviousStageTextEdit.Name = "PreviousStageTextEdit"
        Me.PreviousStageTextEdit.Properties.ReadOnly = True
        Me.PreviousStageTextEdit.Size = New System.Drawing.Size(307, 22)
        Me.PreviousStageTextEdit.StyleController = Me.dlcJobEnquiry
        Me.PreviousStageTextEdit.TabIndex = 5
        '
        'PrimaryArtisanTextEdit
        '
        Me.PrimaryArtisanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PrimaryArtisan", True))
        Me.PrimaryArtisanTextEdit.Location = New System.Drawing.Point(139, 80)
        Me.PrimaryArtisanTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PrimaryArtisanTextEdit.MenuManager = Me.barManager
        Me.PrimaryArtisanTextEdit.Name = "PrimaryArtisanTextEdit"
        Me.PrimaryArtisanTextEdit.Properties.ReadOnly = True
        Me.PrimaryArtisanTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.PrimaryArtisanTextEdit.StyleController = Me.dlcJobEnquiry
        Me.PrimaryArtisanTextEdit.TabIndex = 6
        '
        'CustomerTextEdit
        '
        Me.CustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Customer", True))
        Me.CustomerTextEdit.Location = New System.Drawing.Point(137, 37)
        Me.CustomerTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CustomerTextEdit.MenuManager = Me.barManager
        Me.CustomerTextEdit.Name = "CustomerTextEdit"
        Me.CustomerTextEdit.Properties.ReadOnly = True
        Me.CustomerTextEdit.Size = New System.Drawing.Size(54, 22)
        Me.CustomerTextEdit.StyleController = Me.dlcJobEnquiry
        Me.CustomerTextEdit.TabIndex = 7
        '
        'CostCentreTextEdit
        '
        Me.CostCentreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CostCentre", True))
        Me.CostCentreTextEdit.Location = New System.Drawing.Point(137, 165)
        Me.CostCentreTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CostCentreTextEdit.MenuManager = Me.barManager
        Me.CostCentreTextEdit.Name = "CostCentreTextEdit"
        Me.CostCentreTextEdit.Properties.ReadOnly = True
        Me.CostCentreTextEdit.Size = New System.Drawing.Size(250, 22)
        Me.CostCentreTextEdit.StyleController = Me.dlcJobEnquiry
        Me.CostCentreTextEdit.TabIndex = 8
        '
        'JobTypeTextEdit
        '
        Me.JobTypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobType", True))
        Me.JobTypeTextEdit.Location = New System.Drawing.Point(137, 197)
        Me.JobTypeTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobTypeTextEdit.MenuManager = Me.barManager
        Me.JobTypeTextEdit.Name = "JobTypeTextEdit"
        Me.JobTypeTextEdit.Properties.ReadOnly = True
        Me.JobTypeTextEdit.Size = New System.Drawing.Size(250, 22)
        Me.JobTypeTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobTypeTextEdit.TabIndex = 9
        '
        'LastActivityTextEdit
        '
        Me.LastActivityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "LastActivity", True))
        Me.LastActivityTextEdit.Location = New System.Drawing.Point(139, 154)
        Me.LastActivityTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastActivityTextEdit.MenuManager = Me.barManager
        Me.LastActivityTextEdit.Name = "LastActivityTextEdit"
        Me.LastActivityTextEdit.Properties.ReadOnly = True
        Me.LastActivityTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.LastActivityTextEdit.StyleController = Me.dlcJobEnquiry
        Me.LastActivityTextEdit.TabIndex = 10
        '
        'UnitCostTextEdit
        '
        Me.UnitCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UnitCost", True))
        Me.UnitCostTextEdit.Location = New System.Drawing.Point(139, 265)
        Me.UnitCostTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UnitCostTextEdit.MenuManager = Me.barManager
        Me.UnitCostTextEdit.Name = "UnitCostTextEdit"
        Me.UnitCostTextEdit.Properties.ReadOnly = True
        Me.UnitCostTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.UnitCostTextEdit.StyleController = Me.dlcJobEnquiry
        Me.UnitCostTextEdit.TabIndex = 13
        '
        'UnitPriceTextEdit
        '
        Me.UnitPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UnitPrice", True))
        Me.UnitPriceTextEdit.Location = New System.Drawing.Point(139, 265)
        Me.UnitPriceTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UnitPriceTextEdit.MenuManager = Me.barManager
        Me.UnitPriceTextEdit.Name = "UnitPriceTextEdit"
        Me.UnitPriceTextEdit.Properties.ReadOnly = True
        Me.UnitPriceTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.UnitPriceTextEdit.StyleController = Me.dlcJobEnquiry
        Me.UnitPriceTextEdit.TabIndex = 14
        '
        'TotalCostTextEdit
        '
        Me.TotalCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "TotalCost", True))
        Me.TotalCostTextEdit.Location = New System.Drawing.Point(139, 265)
        Me.TotalCostTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TotalCostTextEdit.MenuManager = Me.barManager
        Me.TotalCostTextEdit.Name = "TotalCostTextEdit"
        Me.TotalCostTextEdit.Properties.ReadOnly = True
        Me.TotalCostTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.TotalCostTextEdit.StyleController = Me.dlcJobEnquiry
        Me.TotalCostTextEdit.TabIndex = 15
        '
        'TotalPriceTextEdit
        '
        Me.TotalPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "TotalPrice", True))
        Me.TotalPriceTextEdit.Location = New System.Drawing.Point(139, 265)
        Me.TotalPriceTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TotalPriceTextEdit.MenuManager = Me.barManager
        Me.TotalPriceTextEdit.Name = "TotalPriceTextEdit"
        Me.TotalPriceTextEdit.Properties.ReadOnly = True
        Me.TotalPriceTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.TotalPriceTextEdit.StyleController = Me.dlcJobEnquiry
        Me.TotalPriceTextEdit.TabIndex = 16
        '
        'QuantityTextEdit
        '
        Me.QuantityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Quantity", True))
        Me.QuantityTextEdit.Location = New System.Drawing.Point(139, 265)
        Me.QuantityTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuantityTextEdit.MenuManager = Me.barManager
        Me.QuantityTextEdit.Name = "QuantityTextEdit"
        Me.QuantityTextEdit.Properties.ReadOnly = True
        Me.QuantityTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.QuantityTextEdit.StyleController = Me.dlcJobEnquiry
        Me.QuantityTextEdit.TabIndex = 17
        '
        'QuantityDeliveredTextEdit
        '
        Me.QuantityDeliveredTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuantityDelivered", True))
        Me.QuantityDeliveredTextEdit.Location = New System.Drawing.Point(139, 124)
        Me.QuantityDeliveredTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuantityDeliveredTextEdit.MenuManager = Me.barManager
        Me.QuantityDeliveredTextEdit.Name = "QuantityDeliveredTextEdit"
        Me.QuantityDeliveredTextEdit.Properties.ReadOnly = True
        Me.QuantityDeliveredTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.QuantityDeliveredTextEdit.StyleController = Me.dlcJobEnquiry
        Me.QuantityDeliveredTextEdit.TabIndex = 18
        '
        'JobNumberTextEdit
        '
        Me.JobNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobNumber", True))
        Me.JobNumberTextEdit.Location = New System.Drawing.Point(333, 5)
        Me.JobNumberTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobNumberTextEdit.MenuManager = Me.barManager
        Me.JobNumberTextEdit.Name = "JobNumberTextEdit"
        Me.JobNumberTextEdit.Properties.ReadOnly = True
        Me.JobNumberTextEdit.Size = New System.Drawing.Size(54, 22)
        Me.JobNumberTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobNumberTextEdit.TabIndex = 19
        '
        'QuoteNumberTextEdit
        '
        Me.QuoteNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuoteNumber", True))
        Me.QuoteNumberTextEdit.Location = New System.Drawing.Point(137, 453)
        Me.QuoteNumberTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuoteNumberTextEdit.MenuManager = Me.barManager
        Me.QuoteNumberTextEdit.Name = "QuoteNumberTextEdit"
        Me.QuoteNumberTextEdit.Properties.ReadOnly = True
        Me.QuoteNumberTextEdit.Size = New System.Drawing.Size(250, 22)
        Me.QuoteNumberTextEdit.StyleController = Me.dlcJobEnquiry
        Me.QuoteNumberTextEdit.TabIndex = 20
        '
        'DeliveryNumberTextEdit
        '
        Me.DeliveryNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DeliveryNumber", True))
        Me.DeliveryNumberTextEdit.Location = New System.Drawing.Point(137, 485)
        Me.DeliveryNumberTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DeliveryNumberTextEdit.MenuManager = Me.barManager
        Me.DeliveryNumberTextEdit.Name = "DeliveryNumberTextEdit"
        Me.DeliveryNumberTextEdit.Properties.ReadOnly = True
        Me.DeliveryNumberTextEdit.Size = New System.Drawing.Size(54, 22)
        Me.DeliveryNumberTextEdit.StyleController = Me.dlcJobEnquiry
        Me.DeliveryNumberTextEdit.TabIndex = 21
        '
        'OrderNumberTextEdit
        '
        Me.OrderNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OrderNumber", True))
        Me.OrderNumberTextEdit.Location = New System.Drawing.Point(333, 485)
        Me.OrderNumberTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderNumberTextEdit.MenuManager = Me.barManager
        Me.OrderNumberTextEdit.Name = "OrderNumberTextEdit"
        Me.OrderNumberTextEdit.Properties.ReadOnly = True
        Me.OrderNumberTextEdit.Size = New System.Drawing.Size(54, 22)
        Me.OrderNumberTextEdit.StyleController = Me.dlcJobEnquiry
        Me.OrderNumberTextEdit.TabIndex = 22
        '
        'JobDateTextEdit
        '
        Me.JobDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobDate", True))
        Me.JobDateTextEdit.Location = New System.Drawing.Point(137, 5)
        Me.JobDateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobDateTextEdit.MenuManager = Me.barManager
        Me.JobDateTextEdit.Name = "JobDateTextEdit"
        Me.JobDateTextEdit.Properties.ReadOnly = True
        Me.JobDateTextEdit.Size = New System.Drawing.Size(54, 22)
        Me.JobDateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobDateTextEdit.TabIndex = 23
        '
        'QuoteDateTextEdit
        '
        Me.QuoteDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuoteDate", True))
        Me.QuoteDateTextEdit.Location = New System.Drawing.Point(139, 272)
        Me.QuoteDateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuoteDateTextEdit.MenuManager = Me.barManager
        Me.QuoteDateTextEdit.Name = "QuoteDateTextEdit"
        Me.QuoteDateTextEdit.Properties.ReadOnly = True
        Me.QuoteDateTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.QuoteDateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.QuoteDateTextEdit.TabIndex = 24
        '
        'InvoiceDateTextEdit
        '
        Me.InvoiceDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "InvoiceDate", True))
        Me.InvoiceDateTextEdit.Location = New System.Drawing.Point(139, 309)
        Me.InvoiceDateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InvoiceDateTextEdit.MenuManager = Me.barManager
        Me.InvoiceDateTextEdit.Name = "InvoiceDateTextEdit"
        Me.InvoiceDateTextEdit.Properties.ReadOnly = True
        Me.InvoiceDateTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.InvoiceDateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.InvoiceDateTextEdit.TabIndex = 25
        '
        'AcceptedDateTextEdit
        '
        Me.AcceptedDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "AcceptedDate", True))
        Me.AcceptedDateTextEdit.Location = New System.Drawing.Point(139, 309)
        Me.AcceptedDateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AcceptedDateTextEdit.MenuManager = Me.barManager
        Me.AcceptedDateTextEdit.Name = "AcceptedDateTextEdit"
        Me.AcceptedDateTextEdit.Properties.ReadOnly = True
        Me.AcceptedDateTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.AcceptedDateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.AcceptedDateTextEdit.TabIndex = 26
        '
        'EstimatedDeliveryDateTextEdit
        '
        Me.EstimatedDeliveryDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EstimatedDeliveryDate", True))
        Me.EstimatedDeliveryDateTextEdit.Location = New System.Drawing.Point(146, 671)
        Me.EstimatedDeliveryDateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EstimatedDeliveryDateTextEdit.MenuManager = Me.barManager
        Me.EstimatedDeliveryDateTextEdit.Name = "EstimatedDeliveryDateTextEdit"
        Me.EstimatedDeliveryDateTextEdit.Properties.ReadOnly = True
        Me.EstimatedDeliveryDateTextEdit.Size = New System.Drawing.Size(307, 22)
        Me.EstimatedDeliveryDateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.EstimatedDeliveryDateTextEdit.TabIndex = 27
        '
        'CancelledDateTextEdit
        '
        Me.CancelledDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CancelledDate", True))
        Me.CancelledDateTextEdit.Location = New System.Drawing.Point(139, 309)
        Me.CancelledDateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelledDateTextEdit.MenuManager = Me.barManager
        Me.CancelledDateTextEdit.Name = "CancelledDateTextEdit"
        Me.CancelledDateTextEdit.Properties.ReadOnly = True
        Me.CancelledDateTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.CancelledDateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.CancelledDateTextEdit.TabIndex = 28
        '
        'EstimatedStartDateTextEdit
        '
        Me.EstimatedStartDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EstimatedStartDate", True))
        Me.EstimatedStartDateTextEdit.Location = New System.Drawing.Point(139, 708)
        Me.EstimatedStartDateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EstimatedStartDateTextEdit.MenuManager = Me.barManager
        Me.EstimatedStartDateTextEdit.Name = "EstimatedStartDateTextEdit"
        Me.EstimatedStartDateTextEdit.Properties.ReadOnly = True
        Me.EstimatedStartDateTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.EstimatedStartDateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.EstimatedStartDateTextEdit.TabIndex = 29
        '
        'EstimatedEndDateTextEdit
        '
        Me.EstimatedEndDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EstimatedEndDate", True))
        Me.EstimatedEndDateTextEdit.Location = New System.Drawing.Point(139, 708)
        Me.EstimatedEndDateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EstimatedEndDateTextEdit.MenuManager = Me.barManager
        Me.EstimatedEndDateTextEdit.Name = "EstimatedEndDateTextEdit"
        Me.EstimatedEndDateTextEdit.Properties.ReadOnly = True
        Me.EstimatedEndDateTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.EstimatedEndDateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.EstimatedEndDateTextEdit.TabIndex = 30
        '
        'ActualStartDateTextEdit
        '
        Me.ActualStartDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ActualStartDate", True))
        Me.ActualStartDateTextEdit.Location = New System.Drawing.Point(139, 708)
        Me.ActualStartDateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ActualStartDateTextEdit.MenuManager = Me.barManager
        Me.ActualStartDateTextEdit.Name = "ActualStartDateTextEdit"
        Me.ActualStartDateTextEdit.Properties.ReadOnly = True
        Me.ActualStartDateTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.ActualStartDateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.ActualStartDateTextEdit.TabIndex = 31
        '
        'ActualEndDateTextEdit
        '
        Me.ActualEndDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ActualEndDate", True))
        Me.ActualEndDateTextEdit.Location = New System.Drawing.Point(139, 708)
        Me.ActualEndDateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ActualEndDateTextEdit.MenuManager = Me.barManager
        Me.ActualEndDateTextEdit.Name = "ActualEndDateTextEdit"
        Me.ActualEndDateTextEdit.Properties.ReadOnly = True
        Me.ActualEndDateTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.ActualEndDateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.ActualEndDateTextEdit.TabIndex = 32
        '
        'ValidityDaysTextEdit
        '
        Me.ValidityDaysTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidityDays", True))
        Me.ValidityDaysTextEdit.Location = New System.Drawing.Point(139, 87)
        Me.ValidityDaysTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ValidityDaysTextEdit.MenuManager = Me.barManager
        Me.ValidityDaysTextEdit.Name = "ValidityDaysTextEdit"
        Me.ValidityDaysTextEdit.Properties.ReadOnly = True
        Me.ValidityDaysTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.ValidityDaysTextEdit.StyleController = Me.dlcJobEnquiry
        Me.ValidityDaysTextEdit.TabIndex = 33
        '
        'DeliveryDaysTextEdit
        '
        Me.DeliveryDaysTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DeliveryDays", True))
        Me.DeliveryDaysTextEdit.Location = New System.Drawing.Point(139, 124)
        Me.DeliveryDaysTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DeliveryDaysTextEdit.MenuManager = Me.barManager
        Me.DeliveryDaysTextEdit.Name = "DeliveryDaysTextEdit"
        Me.DeliveryDaysTextEdit.Properties.ReadOnly = True
        Me.DeliveryDaysTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.DeliveryDaysTextEdit.StyleController = Me.dlcJobEnquiry
        Me.DeliveryDaysTextEdit.TabIndex = 34
        '
        'AccountNameTextEdit
        '
        Me.AccountNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "AccountName", True))
        Me.AccountNameTextEdit.Location = New System.Drawing.Point(137, 69)
        Me.AccountNameTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AccountNameTextEdit.MenuManager = Me.barManager
        Me.AccountNameTextEdit.Name = "AccountNameTextEdit"
        Me.AccountNameTextEdit.Properties.ReadOnly = True
        Me.AccountNameTextEdit.Size = New System.Drawing.Size(250, 22)
        Me.AccountNameTextEdit.StyleController = Me.dlcJobEnquiry
        Me.AccountNameTextEdit.TabIndex = 48
        '
        'ContactNameTextEdit
        '
        Me.ContactNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ContactName", True))
        Me.ContactNameTextEdit.Location = New System.Drawing.Point(137, 101)
        Me.ContactNameTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContactNameTextEdit.MenuManager = Me.barManager
        Me.ContactNameTextEdit.Name = "ContactNameTextEdit"
        Me.ContactNameTextEdit.Properties.ReadOnly = True
        Me.ContactNameTextEdit.Size = New System.Drawing.Size(250, 22)
        Me.ContactNameTextEdit.StyleController = Me.dlcJobEnquiry
        Me.ContactNameTextEdit.TabIndex = 49
        '
        'TelephoneTextEdit
        '
        Me.TelephoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Telephone", True))
        Me.TelephoneTextEdit.Location = New System.Drawing.Point(137, 133)
        Me.TelephoneTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TelephoneTextEdit.MenuManager = Me.barManager
        Me.TelephoneTextEdit.Name = "TelephoneTextEdit"
        Me.TelephoneTextEdit.Properties.ReadOnly = True
        Me.TelephoneTextEdit.Size = New System.Drawing.Size(54, 22)
        Me.TelephoneTextEdit.StyleController = Me.dlcJobEnquiry
        Me.TelephoneTextEdit.TabIndex = 50
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(139, 604)
        Me.EmailTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmailTextEdit.MenuManager = Me.barManager
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Properties.ReadOnly = True
        Me.EmailTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.EmailTextEdit.StyleController = Me.dlcJobEnquiry
        Me.EmailTextEdit.TabIndex = 51
        '
        'FaxTextEdit
        '
        Me.FaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Fax", True))
        Me.FaxTextEdit.Location = New System.Drawing.Point(333, 133)
        Me.FaxTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FaxTextEdit.MenuManager = Me.barManager
        Me.FaxTextEdit.Name = "FaxTextEdit"
        Me.FaxTextEdit.Properties.ReadOnly = True
        Me.FaxTextEdit.Size = New System.Drawing.Size(54, 22)
        Me.FaxTextEdit.StyleController = Me.dlcJobEnquiry
        Me.FaxTextEdit.TabIndex = 52
        '
        'Description1TextEdit
        '
        Me.Description1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description1", True))
        Me.Description1TextEdit.Location = New System.Drawing.Point(137, 293)
        Me.Description1TextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Description1TextEdit.MenuManager = Me.barManager
        Me.Description1TextEdit.Name = "Description1TextEdit"
        Me.Description1TextEdit.Properties.ReadOnly = True
        Me.Description1TextEdit.Size = New System.Drawing.Size(250, 22)
        Me.Description1TextEdit.StyleController = Me.dlcJobEnquiry
        Me.Description1TextEdit.TabIndex = 53
        '
        'Description2TextEdit
        '
        Me.Description2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description2", True))
        Me.Description2TextEdit.Location = New System.Drawing.Point(137, 325)
        Me.Description2TextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Description2TextEdit.MenuManager = Me.barManager
        Me.Description2TextEdit.Name = "Description2TextEdit"
        Me.Description2TextEdit.Properties.ReadOnly = True
        Me.Description2TextEdit.Size = New System.Drawing.Size(250, 22)
        Me.Description2TextEdit.StyleController = Me.dlcJobEnquiry
        Me.Description2TextEdit.TabIndex = 54
        '
        'OrderTotalTextEdit
        '
        Me.OrderTotalTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OrderTotal", True))
        Me.OrderTotalTextEdit.Location = New System.Drawing.Point(139, 486)
        Me.OrderTotalTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderTotalTextEdit.MenuManager = Me.barManager
        Me.OrderTotalTextEdit.Name = "OrderTotalTextEdit"
        Me.OrderTotalTextEdit.Properties.ReadOnly = True
        Me.OrderTotalTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.OrderTotalTextEdit.StyleController = Me.dlcJobEnquiry
        Me.OrderTotalTextEdit.TabIndex = 55
        '
        'DiscountPercentTextEdit
        '
        Me.DiscountPercentTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DiscountPercent", True))
        Me.DiscountPercentTextEdit.Location = New System.Drawing.Point(139, 486)
        Me.DiscountPercentTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DiscountPercentTextEdit.MenuManager = Me.barManager
        Me.DiscountPercentTextEdit.Name = "DiscountPercentTextEdit"
        Me.DiscountPercentTextEdit.Properties.ReadOnly = True
        Me.DiscountPercentTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.DiscountPercentTextEdit.StyleController = Me.dlcJobEnquiry
        Me.DiscountPercentTextEdit.TabIndex = 56
        '
        'DiscountAmountTextEdit
        '
        Me.DiscountAmountTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DiscountAmount", True))
        Me.DiscountAmountTextEdit.Location = New System.Drawing.Point(139, 486)
        Me.DiscountAmountTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DiscountAmountTextEdit.MenuManager = Me.barManager
        Me.DiscountAmountTextEdit.Name = "DiscountAmountTextEdit"
        Me.DiscountAmountTextEdit.Properties.ReadOnly = True
        Me.DiscountAmountTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.DiscountAmountTextEdit.StyleController = Me.dlcJobEnquiry
        Me.DiscountAmountTextEdit.TabIndex = 57
        '
        'NewPriceTextEdit
        '
        Me.NewPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "NewPrice", True))
        Me.NewPriceTextEdit.Location = New System.Drawing.Point(139, 782)
        Me.NewPriceTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NewPriceTextEdit.MenuManager = Me.barManager
        Me.NewPriceTextEdit.Name = "NewPriceTextEdit"
        Me.NewPriceTextEdit.Properties.ReadOnly = True
        Me.NewPriceTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.NewPriceTextEdit.StyleController = Me.dlcJobEnquiry
        Me.NewPriceTextEdit.TabIndex = 58
        '
        'WarrantyTextEdit
        '
        Me.WarrantyTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Warranty", True))
        Me.WarrantyTextEdit.Location = New System.Drawing.Point(139, 818)
        Me.WarrantyTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WarrantyTextEdit.MenuManager = Me.barManager
        Me.WarrantyTextEdit.Name = "WarrantyTextEdit"
        Me.WarrantyTextEdit.Properties.ReadOnly = True
        Me.WarrantyTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.WarrantyTextEdit.StyleController = Me.dlcJobEnquiry
        Me.WarrantyTextEdit.TabIndex = 59
        '
        'CancelReasonTextEdit
        '
        Me.CancelReasonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CancelReason", True))
        Me.CancelReasonTextEdit.Location = New System.Drawing.Point(139, 818)
        Me.CancelReasonTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelReasonTextEdit.MenuManager = Me.barManager
        Me.CancelReasonTextEdit.Name = "CancelReasonTextEdit"
        Me.CancelReasonTextEdit.Properties.ReadOnly = True
        Me.CancelReasonTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.CancelReasonTextEdit.StyleController = Me.dlcJobEnquiry
        Me.CancelReasonTextEdit.TabIndex = 60
        '
        'QuoteCommentsTextEdit
        '
        Me.QuoteCommentsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuoteComments", True))
        Me.QuoteCommentsTextEdit.Location = New System.Drawing.Point(139, 818)
        Me.QuoteCommentsTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuoteCommentsTextEdit.MenuManager = Me.barManager
        Me.QuoteCommentsTextEdit.Name = "QuoteCommentsTextEdit"
        Me.QuoteCommentsTextEdit.Properties.ReadOnly = True
        Me.QuoteCommentsTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.QuoteCommentsTextEdit.StyleController = Me.dlcJobEnquiry
        Me.QuoteCommentsTextEdit.TabIndex = 61
        '
        'PricelistIDTextEdit
        '
        Me.PricelistIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PricelistID", True))
        Me.PricelistIDTextEdit.Location = New System.Drawing.Point(137, 229)
        Me.PricelistIDTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PricelistIDTextEdit.MenuManager = Me.barManager
        Me.PricelistIDTextEdit.Name = "PricelistIDTextEdit"
        Me.PricelistIDTextEdit.Properties.ReadOnly = True
        Me.PricelistIDTextEdit.Size = New System.Drawing.Size(250, 22)
        Me.PricelistIDTextEdit.StyleController = Me.dlcJobEnquiry
        Me.PricelistIDTextEdit.TabIndex = 62
        '
        'StateTextEdit
        '
        Me.StateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "State", True))
        Me.StateTextEdit.Location = New System.Drawing.Point(139, 1003)
        Me.StateTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StateTextEdit.MenuManager = Me.barManager
        Me.StateTextEdit.Name = "StateTextEdit"
        Me.StateTextEdit.Properties.ReadOnly = True
        Me.StateTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.StateTextEdit.StyleController = Me.dlcJobEnquiry
        Me.StateTextEdit.TabIndex = 63
        '
        'JobStageTextEdit
        '
        Me.JobStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobStage", True))
        Me.JobStageTextEdit.Location = New System.Drawing.Point(333, 37)
        Me.JobStageTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobStageTextEdit.MenuManager = Me.barManager
        Me.JobStageTextEdit.Name = "JobStageTextEdit"
        Me.JobStageTextEdit.Properties.ReadOnly = True
        Me.JobStageTextEdit.Size = New System.Drawing.Size(54, 22)
        Me.JobStageTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobStageTextEdit.TabIndex = 66
        '
        'DrawingTextEdit
        '
        Me.DrawingTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Drawing", True))
        Me.DrawingTextEdit.Location = New System.Drawing.Point(139, 966)
        Me.DrawingTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DrawingTextEdit.MenuManager = Me.barManager
        Me.DrawingTextEdit.Name = "DrawingTextEdit"
        Me.DrawingTextEdit.Properties.ReadOnly = True
        Me.DrawingTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.DrawingTextEdit.StyleController = Me.dlcJobEnquiry
        Me.DrawingTextEdit.TabIndex = 67
        '
        'GenerationTextEdit
        '
        Me.GenerationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Generation", True))
        Me.GenerationTextEdit.Location = New System.Drawing.Point(139, 945)
        Me.GenerationTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GenerationTextEdit.MenuManager = Me.barManager
        Me.GenerationTextEdit.Name = "GenerationTextEdit"
        Me.GenerationTextEdit.Properties.ReadOnly = True
        Me.GenerationTextEdit.Size = New System.Drawing.Size(314, 22)
        Me.GenerationTextEdit.StyleController = Me.dlcJobEnquiry
        Me.GenerationTextEdit.TabIndex = 68
        '
        'MakeTextEdit
        '
        Me.MakeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Make", True))
        Me.MakeTextEdit.Location = New System.Drawing.Point(137, 357)
        Me.MakeTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MakeTextEdit.MenuManager = Me.barManager
        Me.MakeTextEdit.Name = "MakeTextEdit"
        Me.MakeTextEdit.Properties.ReadOnly = True
        Me.MakeTextEdit.Size = New System.Drawing.Size(250, 22)
        Me.MakeTextEdit.StyleController = Me.dlcJobEnquiry
        Me.MakeTextEdit.TabIndex = 69
        '
        'ModelTextEdit
        '
        Me.ModelTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Model", True))
        Me.ModelTextEdit.Location = New System.Drawing.Point(137, 389)
        Me.ModelTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ModelTextEdit.MenuManager = Me.barManager
        Me.ModelTextEdit.Name = "ModelTextEdit"
        Me.ModelTextEdit.Properties.ReadOnly = True
        Me.ModelTextEdit.Size = New System.Drawing.Size(250, 22)
        Me.ModelTextEdit.StyleController = Me.dlcJobEnquiry
        Me.ModelTextEdit.TabIndex = 70
        '
        'FunctionTextEdit
        '
        Me.FunctionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Function", True))
        Me.FunctionTextEdit.Location = New System.Drawing.Point(137, 421)
        Me.FunctionTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FunctionTextEdit.MenuManager = Me.barManager
        Me.FunctionTextEdit.Name = "FunctionTextEdit"
        Me.FunctionTextEdit.Properties.ReadOnly = True
        Me.FunctionTextEdit.Size = New System.Drawing.Size(250, 22)
        Me.FunctionTextEdit.StyleController = Me.dlcJobEnquiry
        Me.FunctionTextEdit.TabIndex = 71
        '
        'JobCategoryTextEdit
        '
        Me.JobCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobCategory", True))
        Me.JobCategoryTextEdit.Location = New System.Drawing.Point(139, 929)
        Me.JobCategoryTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobCategoryTextEdit.MenuManager = Me.barManager
        Me.JobCategoryTextEdit.Name = "JobCategoryTextEdit"
        Me.JobCategoryTextEdit.Properties.ReadOnly = True
        Me.JobCategoryTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.JobCategoryTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobCategoryTextEdit.TabIndex = 72
        '
        'WorkCentreCategoryTextEdit
        '
        Me.WorkCentreCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "WorkCentreCategory", True))
        Me.WorkCentreCategoryTextEdit.Location = New System.Drawing.Point(137, 261)
        Me.WorkCentreCategoryTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WorkCentreCategoryTextEdit.MenuManager = Me.barManager
        Me.WorkCentreCategoryTextEdit.Name = "WorkCentreCategoryTextEdit"
        Me.WorkCentreCategoryTextEdit.Properties.ReadOnly = True
        Me.WorkCentreCategoryTextEdit.Size = New System.Drawing.Size(250, 22)
        Me.WorkCentreCategoryTextEdit.StyleController = Me.dlcJobEnquiry
        Me.WorkCentreCategoryTextEdit.TabIndex = 73
        '
        'IsBreakdownTextEdit
        '
        Me.IsBreakdownTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsBreakdown", True))
        Me.IsBreakdownTextEdit.EditValue = Nothing
        Me.IsBreakdownTextEdit.Location = New System.Drawing.Point(6, 54)
        Me.IsBreakdownTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IsBreakdownTextEdit.MenuManager = Me.barManager
        Me.IsBreakdownTextEdit.Name = "IsBreakdownTextEdit"
        Me.IsBreakdownTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsBreakdownTextEdit.Properties.Caption = "Breakdown"
        Me.IsBreakdownTextEdit.Properties.ReadOnly = True
        Me.IsBreakdownTextEdit.Size = New System.Drawing.Size(447, 20)
        Me.IsBreakdownTextEdit.StyleController = Me.dlcJobEnquiry
        Me.IsBreakdownTextEdit.TabIndex = 36
        '
        'IsApprovedTextEdit
        '
        Me.IsApprovedTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsApproved", True))
        Me.IsApprovedTextEdit.EditValue = Nothing
        Me.IsApprovedTextEdit.Location = New System.Drawing.Point(6, 90)
        Me.IsApprovedTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IsApprovedTextEdit.MenuManager = Me.barManager
        Me.IsApprovedTextEdit.Name = "IsApprovedTextEdit"
        Me.IsApprovedTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsApprovedTextEdit.Properties.Caption = "Approved"
        Me.IsApprovedTextEdit.Properties.ReadOnly = True
        Me.IsApprovedTextEdit.Size = New System.Drawing.Size(447, 20)
        Me.IsApprovedTextEdit.StyleController = Me.dlcJobEnquiry
        Me.IsApprovedTextEdit.TabIndex = 37
        '
        'IsProcuredTextEdit
        '
        Me.IsProcuredTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsProcured", True))
        Me.IsProcuredTextEdit.EditValue = Nothing
        Me.IsProcuredTextEdit.Location = New System.Drawing.Point(6, 90)
        Me.IsProcuredTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IsProcuredTextEdit.MenuManager = Me.barManager
        Me.IsProcuredTextEdit.Name = "IsProcuredTextEdit"
        Me.IsProcuredTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsProcuredTextEdit.Properties.Caption = "Procured"
        Me.IsProcuredTextEdit.Properties.ReadOnly = True
        Me.IsProcuredTextEdit.Size = New System.Drawing.Size(447, 20)
        Me.IsProcuredTextEdit.StyleController = Me.dlcJobEnquiry
        Me.IsProcuredTextEdit.TabIndex = 38
        '
        'IsStockDrawnTextEdit
        '
        Me.IsStockDrawnTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsStockDrawn", True))
        Me.IsStockDrawnTextEdit.EditValue = Nothing
        Me.IsStockDrawnTextEdit.Location = New System.Drawing.Point(6, 126)
        Me.IsStockDrawnTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IsStockDrawnTextEdit.MenuManager = Me.barManager
        Me.IsStockDrawnTextEdit.Name = "IsStockDrawnTextEdit"
        Me.IsStockDrawnTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsStockDrawnTextEdit.Properties.Caption = "Requisitioned"
        Me.IsStockDrawnTextEdit.Properties.ReadOnly = True
        Me.IsStockDrawnTextEdit.Size = New System.Drawing.Size(447, 20)
        Me.IsStockDrawnTextEdit.StyleController = Me.dlcJobEnquiry
        Me.IsStockDrawnTextEdit.TabIndex = 39
        '
        'QuoteAgentTextEdit
        '
        Me.QuoteAgentTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuoteAgent", True))
        Me.QuoteAgentTextEdit.Location = New System.Drawing.Point(137, 517)
        Me.QuoteAgentTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuoteAgentTextEdit.MenuManager = Me.barManager
        Me.QuoteAgentTextEdit.Name = "QuoteAgentTextEdit"
        Me.QuoteAgentTextEdit.Properties.ReadOnly = True
        Me.QuoteAgentTextEdit.Size = New System.Drawing.Size(54, 22)
        Me.QuoteAgentTextEdit.StyleController = Me.dlcJobEnquiry
        Me.QuoteAgentTextEdit.TabIndex = 74
        '
        'JobAgentTextEdit
        '
        Me.JobAgentTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobAgent", True))
        Me.JobAgentTextEdit.Location = New System.Drawing.Point(333, 517)
        Me.JobAgentTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobAgentTextEdit.MenuManager = Me.barManager
        Me.JobAgentTextEdit.Name = "JobAgentTextEdit"
        Me.JobAgentTextEdit.Properties.ReadOnly = True
        Me.JobAgentTextEdit.Size = New System.Drawing.Size(54, 22)
        Me.JobAgentTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobAgentTextEdit.TabIndex = 75
        '
        'RequisitionNumberTextEdit
        '
        Me.RequisitionNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "RequisitionNumber", True))
        Me.RequisitionNumberTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.RequisitionNumberTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RequisitionNumberTextEdit.MenuManager = Me.barManager
        Me.RequisitionNumberTextEdit.Name = "RequisitionNumberTextEdit"
        Me.RequisitionNumberTextEdit.Size = New System.Drawing.Size(0, 22)
        Me.RequisitionNumberTextEdit.StyleController = Me.dlcJobEnquiry
        Me.RequisitionNumberTextEdit.TabIndex = 88
        '
        'JobDeliveriesTextEdit
        '
        Me.JobDeliveriesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobDeliveries", True))
        Me.JobDeliveriesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobDeliveriesTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobDeliveriesTextEdit.MenuManager = Me.barManager
        Me.JobDeliveriesTextEdit.Name = "JobDeliveriesTextEdit"
        Me.JobDeliveriesTextEdit.Size = New System.Drawing.Size(0, 22)
        Me.JobDeliveriesTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobDeliveriesTextEdit.TabIndex = 94
        '
        'JobLinesTextEdit
        '
        Me.JobLinesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobLines", True))
        Me.JobLinesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobLinesTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobLinesTextEdit.MenuManager = Me.barManager
        Me.JobLinesTextEdit.Name = "JobLinesTextEdit"
        Me.JobLinesTextEdit.Size = New System.Drawing.Size(0, 22)
        Me.JobLinesTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobLinesTextEdit.TabIndex = 95
        '
        'JobTolerancesTextEdit
        '
        Me.JobTolerancesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobTolerances", True))
        Me.JobTolerancesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobTolerancesTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobTolerancesTextEdit.MenuManager = Me.barManager
        Me.JobTolerancesTextEdit.Name = "JobTolerancesTextEdit"
        Me.JobTolerancesTextEdit.Size = New System.Drawing.Size(0, 22)
        Me.JobTolerancesTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobTolerancesTextEdit.TabIndex = 96
        '
        'RequisitionsTextEdit
        '
        Me.RequisitionsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Requisitions", True))
        Me.RequisitionsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.RequisitionsTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RequisitionsTextEdit.MenuManager = Me.barManager
        Me.RequisitionsTextEdit.Name = "RequisitionsTextEdit"
        Me.RequisitionsTextEdit.Size = New System.Drawing.Size(0, 22)
        Me.RequisitionsTextEdit.StyleController = Me.dlcJobEnquiry
        Me.RequisitionsTextEdit.TabIndex = 97
        '
        'NotesTextEdit
        '
        Me.NotesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Notes", True))
        Me.NotesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.NotesTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NotesTextEdit.MenuManager = Me.barManager
        Me.NotesTextEdit.Name = "NotesTextEdit"
        Me.NotesTextEdit.Size = New System.Drawing.Size(0, 22)
        Me.NotesTextEdit.StyleController = Me.dlcJobEnquiry
        Me.NotesTextEdit.TabIndex = 99
        '
        'JobMemoesTextEdit
        '
        Me.JobMemoesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobMemoes", True))
        Me.JobMemoesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobMemoesTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobMemoesTextEdit.MenuManager = Me.barManager
        Me.JobMemoesTextEdit.Name = "JobMemoesTextEdit"
        Me.JobMemoesTextEdit.Size = New System.Drawing.Size(0, 22)
        Me.JobMemoesTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobMemoesTextEdit.TabIndex = 100
        '
        'JobDrawingAnnotationsTextEdit
        '
        Me.JobDrawingAnnotationsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobDrawingAnnotations", True))
        Me.JobDrawingAnnotationsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobDrawingAnnotationsTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobDrawingAnnotationsTextEdit.MenuManager = Me.barManager
        Me.JobDrawingAnnotationsTextEdit.Name = "JobDrawingAnnotationsTextEdit"
        Me.JobDrawingAnnotationsTextEdit.Size = New System.Drawing.Size(0, 22)
        Me.JobDrawingAnnotationsTextEdit.StyleController = Me.dlcJobEnquiry
        Me.JobDrawingAnnotationsTextEdit.TabIndex = 101
        '
        'AuditsTextEdit
        '
        Me.AuditsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Audits", True))
        Me.AuditsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.AuditsTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AuditsTextEdit.MenuManager = Me.barManager
        Me.AuditsTextEdit.Name = "AuditsTextEdit"
        Me.AuditsTextEdit.Size = New System.Drawing.Size(0, 22)
        Me.AuditsTextEdit.StyleController = Me.dlcJobEnquiry
        Me.AuditsTextEdit.TabIndex = 102
        '
        'ItemForNextStage
        '
        Me.ItemForNextStage.Control = Me.NextStageTextEdit
        Me.ItemForNextStage.CustomizationFormText = "Next Stage"
        Me.ItemForNextStage.Location = New System.Drawing.Point(0, 60)
        Me.ItemForNextStage.Name = "ItemForNextStage"
        Me.ItemForNextStage.Size = New System.Drawing.Size(393, 30)
        Me.ItemForNextStage.Text = "Next Stage"
        Me.ItemForNextStage.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForNextStage.TextToControlDistance = 5
        '
        'ItemForPreviousStage
        '
        Me.ItemForPreviousStage.Control = Me.PreviousStageTextEdit
        Me.ItemForPreviousStage.CustomizationFormText = "Previous Stage"
        Me.ItemForPreviousStage.Location = New System.Drawing.Point(0, 60)
        Me.ItemForPreviousStage.Name = "ItemForPreviousStage"
        Me.ItemForPreviousStage.Size = New System.Drawing.Size(393, 30)
        Me.ItemForPreviousStage.Text = "Previous Stage"
        Me.ItemForPreviousStage.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForPreviousStage.TextToControlDistance = 5
        '
        'ItemForEstimatedDeliveryDate
        '
        Me.ItemForEstimatedDeliveryDate.Control = Me.EstimatedDeliveryDateTextEdit
        Me.ItemForEstimatedDeliveryDate.CustomizationFormText = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.Location = New System.Drawing.Point(0, 180)
        Me.ItemForEstimatedDeliveryDate.Name = "ItemForEstimatedDeliveryDate"
        Me.ItemForEstimatedDeliveryDate.Size = New System.Drawing.Size(393, 30)
        Me.ItemForEstimatedDeliveryDate.Text = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForEstimatedDeliveryDate.TextToControlDistance = 5
        '
        'ItemForEstimatedStartDate
        '
        Me.ItemForEstimatedStartDate.Control = Me.EstimatedStartDateTextEdit
        Me.ItemForEstimatedStartDate.CustomizationFormText = "Estimated Start Date"
        Me.ItemForEstimatedStartDate.Location = New System.Drawing.Point(0, 210)
        Me.ItemForEstimatedStartDate.Name = "ItemForEstimatedStartDate"
        Me.ItemForEstimatedStartDate.Size = New System.Drawing.Size(393, 30)
        Me.ItemForEstimatedStartDate.Text = "Estimated Start Date"
        Me.ItemForEstimatedStartDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForEstimatedStartDate.TextToControlDistance = 5
        '
        'ItemForEstimatedEndDate
        '
        Me.ItemForEstimatedEndDate.Control = Me.EstimatedEndDateTextEdit
        Me.ItemForEstimatedEndDate.CustomizationFormText = "Estimated End Date"
        Me.ItemForEstimatedEndDate.Location = New System.Drawing.Point(0, 210)
        Me.ItemForEstimatedEndDate.Name = "ItemForEstimatedEndDate"
        Me.ItemForEstimatedEndDate.Size = New System.Drawing.Size(393, 30)
        Me.ItemForEstimatedEndDate.Text = "Estimated End Date"
        Me.ItemForEstimatedEndDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForEstimatedEndDate.TextToControlDistance = 5
        '
        'ItemForActualStartDate
        '
        Me.ItemForActualStartDate.Control = Me.ActualStartDateTextEdit
        Me.ItemForActualStartDate.CustomizationFormText = "Actual Start Date"
        Me.ItemForActualStartDate.Location = New System.Drawing.Point(0, 210)
        Me.ItemForActualStartDate.Name = "ItemForActualStartDate"
        Me.ItemForActualStartDate.Size = New System.Drawing.Size(393, 30)
        Me.ItemForActualStartDate.Text = "Actual Start Date"
        Me.ItemForActualStartDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForActualStartDate.TextToControlDistance = 5
        '
        'ItemForActualEndDate
        '
        Me.ItemForActualEndDate.Control = Me.ActualEndDateTextEdit
        Me.ItemForActualEndDate.CustomizationFormText = "Actual End Date"
        Me.ItemForActualEndDate.Location = New System.Drawing.Point(0, 210)
        Me.ItemForActualEndDate.Name = "ItemForActualEndDate"
        Me.ItemForActualEndDate.Size = New System.Drawing.Size(393, 30)
        Me.ItemForActualEndDate.Text = "Actual End Date"
        Me.ItemForActualEndDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForActualEndDate.TextToControlDistance = 5
        '
        'ItemForIsProcured
        '
        Me.ItemForIsProcured.Control = Me.IsProcuredTextEdit
        Me.ItemForIsProcured.CustomizationFormText = "Is Procured"
        Me.ItemForIsProcured.Location = New System.Drawing.Point(0, 29)
        Me.ItemForIsProcured.Name = "ItemForIsProcured"
        Me.ItemForIsProcured.Size = New System.Drawing.Size(393, 29)
        Me.ItemForIsProcured.Text = "Is Procured"
        Me.ItemForIsProcured.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsProcured.TextToControlDistance = 0
        Me.ItemForIsProcured.TextVisible = False
        '
        'ItemForIsBreakdown
        '
        Me.ItemForIsBreakdown.Control = Me.IsBreakdownTextEdit
        Me.ItemForIsBreakdown.CustomizationFormText = "Is Breakdown"
        Me.ItemForIsBreakdown.Location = New System.Drawing.Point(0, 270)
        Me.ItemForIsBreakdown.Name = "ItemForIsBreakdown"
        Me.ItemForIsBreakdown.Size = New System.Drawing.Size(393, 29)
        Me.ItemForIsBreakdown.Text = "Is Breakdown"
        Me.ItemForIsBreakdown.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsBreakdown.TextToControlDistance = 0
        Me.ItemForIsBreakdown.TextVisible = False
        '
        'ItemForIsApproved
        '
        Me.ItemForIsApproved.Control = Me.IsApprovedTextEdit
        Me.ItemForIsApproved.CustomizationFormText = "Is Approved"
        Me.ItemForIsApproved.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsApproved.Name = "ItemForIsApproved"
        Me.ItemForIsApproved.Size = New System.Drawing.Size(393, 29)
        Me.ItemForIsApproved.Text = "Is Approved"
        Me.ItemForIsApproved.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsApproved.TextToControlDistance = 0
        Me.ItemForIsApproved.TextVisible = False
        '
        'ItemForIsStockDrawn
        '
        Me.ItemForIsStockDrawn.Control = Me.IsStockDrawnTextEdit
        Me.ItemForIsStockDrawn.CustomizationFormText = "Is Stock Drawn"
        Me.ItemForIsStockDrawn.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsStockDrawn.Name = "ItemForIsStockDrawn"
        Me.ItemForIsStockDrawn.Size = New System.Drawing.Size(393, 29)
        Me.ItemForIsStockDrawn.Text = "Is Stock Drawn"
        Me.ItemForIsStockDrawn.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsStockDrawn.TextToControlDistance = 0
        Me.ItemForIsStockDrawn.TextVisible = False
        '
        'ItemForValidityDays
        '
        Me.ItemForValidityDays.Control = Me.ValidityDaysTextEdit
        Me.ItemForValidityDays.CustomizationFormText = "Validity Days"
        Me.ItemForValidityDays.Location = New System.Drawing.Point(0, 210)
        Me.ItemForValidityDays.Name = "ItemForValidityDays"
        Me.ItemForValidityDays.Size = New System.Drawing.Size(393, 30)
        Me.ItemForValidityDays.Text = "Validity Days"
        Me.ItemForValidityDays.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForValidityDays.TextToControlDistance = 5
        '
        'ItemForDeliveryDays
        '
        Me.ItemForDeliveryDays.Control = Me.DeliveryDaysTextEdit
        Me.ItemForDeliveryDays.CustomizationFormText = "Delivery Days"
        Me.ItemForDeliveryDays.Location = New System.Drawing.Point(0, 210)
        Me.ItemForDeliveryDays.Name = "ItemForDeliveryDays"
        Me.ItemForDeliveryDays.Size = New System.Drawing.Size(393, 30)
        Me.ItemForDeliveryDays.Text = "Delivery Days"
        Me.ItemForDeliveryDays.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForDeliveryDays.TextToControlDistance = 5
        '
        'ItemForInvoiceDate
        '
        Me.ItemForInvoiceDate.Control = Me.InvoiceDateTextEdit
        Me.ItemForInvoiceDate.CustomizationFormText = "Invoice Date"
        Me.ItemForInvoiceDate.Location = New System.Drawing.Point(0, 120)
        Me.ItemForInvoiceDate.Name = "ItemForInvoiceDate"
        Me.ItemForInvoiceDate.Size = New System.Drawing.Size(393, 30)
        Me.ItemForInvoiceDate.Text = "Invoice Date"
        Me.ItemForInvoiceDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForInvoiceDate.TextToControlDistance = 5
        '
        'ItemForAcceptedDate
        '
        Me.ItemForAcceptedDate.Control = Me.AcceptedDateTextEdit
        Me.ItemForAcceptedDate.CustomizationFormText = "Accepted Date"
        Me.ItemForAcceptedDate.Location = New System.Drawing.Point(0, 120)
        Me.ItemForAcceptedDate.Name = "ItemForAcceptedDate"
        Me.ItemForAcceptedDate.Size = New System.Drawing.Size(393, 30)
        Me.ItemForAcceptedDate.Text = "Accepted Date"
        Me.ItemForAcceptedDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForAcceptedDate.TextToControlDistance = 5
        '
        'ItemForCancelledDate
        '
        Me.ItemForCancelledDate.Control = Me.CancelledDateTextEdit
        Me.ItemForCancelledDate.CustomizationFormText = "Cancelled Date"
        Me.ItemForCancelledDate.Location = New System.Drawing.Point(0, 120)
        Me.ItemForCancelledDate.Name = "ItemForCancelledDate"
        Me.ItemForCancelledDate.Size = New System.Drawing.Size(393, 30)
        Me.ItemForCancelledDate.Text = "Cancelled Date"
        Me.ItemForCancelledDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForCancelledDate.TextToControlDistance = 5
        '
        'ItemForQuoteDate
        '
        Me.ItemForQuoteDate.Control = Me.QuoteDateTextEdit
        Me.ItemForQuoteDate.CustomizationFormText = "Quote Date"
        Me.ItemForQuoteDate.Location = New System.Drawing.Point(0, 90)
        Me.ItemForQuoteDate.Name = "ItemForQuoteDate"
        Me.ItemForQuoteDate.Size = New System.Drawing.Size(393, 30)
        Me.ItemForQuoteDate.Text = "Quote Date"
        Me.ItemForQuoteDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForQuoteDate.TextToControlDistance = 5
        '
        'ItemForQuantityDelivered
        '
        Me.ItemForQuantityDelivered.Control = Me.QuantityDeliveredTextEdit
        Me.ItemForQuantityDelivered.CustomizationFormText = "Quantity Delivered"
        Me.ItemForQuantityDelivered.Location = New System.Drawing.Point(0, 330)
        Me.ItemForQuantityDelivered.Name = "ItemForQuantityDelivered"
        Me.ItemForQuantityDelivered.Size = New System.Drawing.Size(393, 30)
        Me.ItemForQuantityDelivered.Text = "Quantity Delivered"
        Me.ItemForQuantityDelivered.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForQuantityDelivered.TextToControlDistance = 5
        '
        'ItemForPrimaryArtisan
        '
        Me.ItemForPrimaryArtisan.Control = Me.PrimaryArtisanTextEdit
        Me.ItemForPrimaryArtisan.CustomizationFormText = "Primary Artisan"
        Me.ItemForPrimaryArtisan.Location = New System.Drawing.Point(0, 60)
        Me.ItemForPrimaryArtisan.Name = "ItemForPrimaryArtisan"
        Me.ItemForPrimaryArtisan.Size = New System.Drawing.Size(393, 30)
        Me.ItemForPrimaryArtisan.Text = "Primary Artisan"
        Me.ItemForPrimaryArtisan.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForPrimaryArtisan.TextToControlDistance = 5
        '
        'ItemForLastActivity
        '
        Me.ItemForLastActivity.Control = Me.LastActivityTextEdit
        Me.ItemForLastActivity.CustomizationFormText = "Last Activity"
        Me.ItemForLastActivity.Location = New System.Drawing.Point(0, 120)
        Me.ItemForLastActivity.Name = "ItemForLastActivity"
        Me.ItemForLastActivity.Size = New System.Drawing.Size(393, 30)
        Me.ItemForLastActivity.Text = "Last Activity"
        Me.ItemForLastActivity.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForLastActivity.TextToControlDistance = 5
        '
        'ItemForState
        '
        Me.ItemForState.Control = Me.StateTextEdit
        Me.ItemForState.CustomizationFormText = "State"
        Me.ItemForState.Location = New System.Drawing.Point(0, 270)
        Me.ItemForState.Name = "ItemForState"
        Me.ItemForState.Size = New System.Drawing.Size(393, 30)
        Me.ItemForState.Text = "State"
        Me.ItemForState.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForState.TextToControlDistance = 5
        '
        'ItemForDrawing
        '
        Me.ItemForDrawing.Control = Me.DrawingTextEdit
        Me.ItemForDrawing.CustomizationFormText = "Drawing"
        Me.ItemForDrawing.Location = New System.Drawing.Point(0, 270)
        Me.ItemForDrawing.Name = "ItemForDrawing"
        Me.ItemForDrawing.Size = New System.Drawing.Size(393, 30)
        Me.ItemForDrawing.Text = "Drawing"
        Me.ItemForDrawing.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForDrawing.TextToControlDistance = 5
        '
        'ItemForGeneration
        '
        Me.ItemForGeneration.Control = Me.GenerationTextEdit
        Me.ItemForGeneration.CustomizationFormText = "Generation"
        Me.ItemForGeneration.Location = New System.Drawing.Point(0, 270)
        Me.ItemForGeneration.Name = "ItemForGeneration"
        Me.ItemForGeneration.Size = New System.Drawing.Size(393, 30)
        Me.ItemForGeneration.Text = "Generation"
        Me.ItemForGeneration.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForGeneration.TextToControlDistance = 5
        '
        'ItemForEmail
        '
        Me.ItemForEmail.Control = Me.EmailTextEdit
        Me.ItemForEmail.CustomizationFormText = "Email"
        Me.ItemForEmail.Location = New System.Drawing.Point(0, 0)
        Me.ItemForEmail.Name = "ItemForEmail"
        Me.ItemForEmail.Size = New System.Drawing.Size(393, 30)
        Me.ItemForEmail.Text = "Email"
        Me.ItemForEmail.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForEmail.TextToControlDistance = 5
        '
        'ItemForJobCategory
        '
        Me.ItemForJobCategory.Control = Me.JobCategoryTextEdit
        Me.ItemForJobCategory.CustomizationFormText = "Job Category"
        Me.ItemForJobCategory.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobCategory.Name = "ItemForJobCategory"
        Me.ItemForJobCategory.Size = New System.Drawing.Size(410, 96)
        Me.ItemForJobCategory.Text = "Job Category"
        Me.ItemForJobCategory.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForJobCategory.TextToControlDistance = 5
        '
        'ItemForWarranty
        '
        Me.ItemForWarranty.Control = Me.WarrantyTextEdit
        Me.ItemForWarranty.CustomizationFormText = "Warranty"
        Me.ItemForWarranty.Location = New System.Drawing.Point(0, 120)
        Me.ItemForWarranty.Name = "ItemForWarranty"
        Me.ItemForWarranty.Size = New System.Drawing.Size(410, 30)
        Me.ItemForWarranty.Text = "Warranty"
        Me.ItemForWarranty.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForWarranty.TextToControlDistance = 5
        '
        'ItemForCancelReason
        '
        Me.ItemForCancelReason.Control = Me.CancelReasonTextEdit
        Me.ItemForCancelReason.CustomizationFormText = "Cancel Reason"
        Me.ItemForCancelReason.Location = New System.Drawing.Point(0, 120)
        Me.ItemForCancelReason.Name = "ItemForCancelReason"
        Me.ItemForCancelReason.Size = New System.Drawing.Size(410, 30)
        Me.ItemForCancelReason.Text = "Cancel Reason"
        Me.ItemForCancelReason.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForCancelReason.TextToControlDistance = 5
        '
        'ItemForQuoteComments
        '
        Me.ItemForQuoteComments.Control = Me.QuoteCommentsTextEdit
        Me.ItemForQuoteComments.CustomizationFormText = "Quote Comments"
        Me.ItemForQuoteComments.Location = New System.Drawing.Point(0, 120)
        Me.ItemForQuoteComments.Name = "ItemForQuoteComments"
        Me.ItemForQuoteComments.Size = New System.Drawing.Size(410, 30)
        Me.ItemForQuoteComments.Text = "Quote Comments"
        Me.ItemForQuoteComments.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForQuoteComments.TextToControlDistance = 5
        '
        'ItemForNewPrice
        '
        Me.ItemForNewPrice.Control = Me.NewPriceTextEdit
        Me.ItemForNewPrice.CustomizationFormText = "New Price"
        Me.ItemForNewPrice.Location = New System.Drawing.Point(0, 90)
        Me.ItemForNewPrice.Name = "ItemForNewPrice"
        Me.ItemForNewPrice.Size = New System.Drawing.Size(410, 30)
        Me.ItemForNewPrice.Text = "New Price"
        Me.ItemForNewPrice.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForNewPrice.TextToControlDistance = 5
        '
        'ItemForUnitCost
        '
        Me.ItemForUnitCost.Control = Me.UnitCostTextEdit
        Me.ItemForUnitCost.CustomizationFormText = "Unit Cost"
        Me.ItemForUnitCost.Location = New System.Drawing.Point(0, 210)
        Me.ItemForUnitCost.Name = "ItemForUnitCost"
        Me.ItemForUnitCost.Size = New System.Drawing.Size(410, 30)
        Me.ItemForUnitCost.Text = "Unit Cost"
        Me.ItemForUnitCost.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForUnitCost.TextToControlDistance = 5
        '
        'ItemForUnitPrice
        '
        Me.ItemForUnitPrice.Control = Me.UnitPriceTextEdit
        Me.ItemForUnitPrice.CustomizationFormText = "Unit Price"
        Me.ItemForUnitPrice.Location = New System.Drawing.Point(0, 210)
        Me.ItemForUnitPrice.Name = "ItemForUnitPrice"
        Me.ItemForUnitPrice.Size = New System.Drawing.Size(410, 30)
        Me.ItemForUnitPrice.Text = "Unit Price"
        Me.ItemForUnitPrice.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForUnitPrice.TextToControlDistance = 5
        '
        'ItemForTotalCost
        '
        Me.ItemForTotalCost.Control = Me.TotalCostTextEdit
        Me.ItemForTotalCost.CustomizationFormText = "Total Cost"
        Me.ItemForTotalCost.Location = New System.Drawing.Point(0, 210)
        Me.ItemForTotalCost.Name = "ItemForTotalCost"
        Me.ItemForTotalCost.Size = New System.Drawing.Size(410, 30)
        Me.ItemForTotalCost.Text = "Total Cost"
        Me.ItemForTotalCost.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForTotalCost.TextToControlDistance = 5
        '
        'ItemForTotalPrice
        '
        Me.ItemForTotalPrice.Control = Me.TotalPriceTextEdit
        Me.ItemForTotalPrice.CustomizationFormText = "Total Price"
        Me.ItemForTotalPrice.Location = New System.Drawing.Point(0, 210)
        Me.ItemForTotalPrice.Name = "ItemForTotalPrice"
        Me.ItemForTotalPrice.Size = New System.Drawing.Size(410, 30)
        Me.ItemForTotalPrice.Text = "Total Price"
        Me.ItemForTotalPrice.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForTotalPrice.TextToControlDistance = 5
        '
        'ItemForQuantity
        '
        Me.ItemForQuantity.Control = Me.QuantityTextEdit
        Me.ItemForQuantity.CustomizationFormText = "Quantity"
        Me.ItemForQuantity.Location = New System.Drawing.Point(0, 210)
        Me.ItemForQuantity.Name = "ItemForQuantity"
        Me.ItemForQuantity.Size = New System.Drawing.Size(410, 30)
        Me.ItemForQuantity.Text = "Quantity"
        Me.ItemForQuantity.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForQuantity.TextToControlDistance = 5
        '
        'ItemForOrderTotal
        '
        Me.ItemForOrderTotal.Control = Me.OrderTotalTextEdit
        Me.ItemForOrderTotal.CustomizationFormText = "Order Total"
        Me.ItemForOrderTotal.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOrderTotal.Name = "ItemForOrderTotal"
        Me.ItemForOrderTotal.Size = New System.Drawing.Size(410, 30)
        Me.ItemForOrderTotal.Text = "Order Total"
        Me.ItemForOrderTotal.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForOrderTotal.TextToControlDistance = 5
        '
        'ItemForDiscountPercent
        '
        Me.ItemForDiscountPercent.Control = Me.DiscountPercentTextEdit
        Me.ItemForDiscountPercent.CustomizationFormText = "Discount Percent"
        Me.ItemForDiscountPercent.Location = New System.Drawing.Point(0, 0)
        Me.ItemForDiscountPercent.Name = "ItemForDiscountPercent"
        Me.ItemForDiscountPercent.Size = New System.Drawing.Size(410, 30)
        Me.ItemForDiscountPercent.Text = "Discount Percent"
        Me.ItemForDiscountPercent.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForDiscountPercent.TextToControlDistance = 5
        '
        'ItemForDiscountAmount
        '
        Me.ItemForDiscountAmount.Control = Me.DiscountAmountTextEdit
        Me.ItemForDiscountAmount.CustomizationFormText = "Discount Amount"
        Me.ItemForDiscountAmount.Location = New System.Drawing.Point(0, 0)
        Me.ItemForDiscountAmount.Name = "ItemForDiscountAmount"
        Me.ItemForDiscountAmount.Size = New System.Drawing.Size(410, 30)
        Me.ItemForDiscountAmount.Text = "Discount Amount"
        Me.ItemForDiscountAmount.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForDiscountAmount.TextToControlDistance = 5
        '
        'ItemForRequisitionNumber
        '
        Me.ItemForRequisitionNumber.Control = Me.RequisitionNumberTextEdit
        Me.ItemForRequisitionNumber.CustomizationFormText = "Requisition Number"
        Me.ItemForRequisitionNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForRequisitionNumber.Name = "ItemForRequisitionNumber"
        Me.ItemForRequisitionNumber.Size = New System.Drawing.Size(0, 0)
        Me.ItemForRequisitionNumber.Text = "Requisition Number"
        Me.ItemForRequisitionNumber.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForRequisitionNumber.TextToControlDistance = 5
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
        'ItemForRequisitions
        '
        Me.ItemForRequisitions.Control = Me.RequisitionsTextEdit
        Me.ItemForRequisitions.CustomizationFormText = "Requisitions"
        Me.ItemForRequisitions.Location = New System.Drawing.Point(0, 0)
        Me.ItemForRequisitions.Name = "ItemForRequisitions"
        Me.ItemForRequisitions.Size = New System.Drawing.Size(0, 0)
        Me.ItemForRequisitions.Text = "Requisitions"
        Me.ItemForRequisitions.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForRequisitions.TextToControlDistance = 5
        '
        'ItemForNotes
        '
        Me.ItemForNotes.Control = Me.NotesTextEdit
        Me.ItemForNotes.CustomizationFormText = "Notes"
        Me.ItemForNotes.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNotes.Name = "ItemForNotes"
        Me.ItemForNotes.Size = New System.Drawing.Size(0, 0)
        Me.ItemForNotes.Text = "Notes"
        Me.ItemForNotes.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForNotes.TextToControlDistance = 5
        '
        'ItemForJobMemoes
        '
        Me.ItemForJobMemoes.Control = Me.JobMemoesTextEdit
        Me.ItemForJobMemoes.CustomizationFormText = "Job Memoes"
        Me.ItemForJobMemoes.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobMemoes.Name = "ItemForJobMemoes"
        Me.ItemForJobMemoes.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobMemoes.Text = "Job Memoes"
        Me.ItemForJobMemoes.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobMemoes.TextToControlDistance = 5
        '
        'ItemForJobDrawingAnnotations
        '
        Me.ItemForJobDrawingAnnotations.Control = Me.JobDrawingAnnotationsTextEdit
        Me.ItemForJobDrawingAnnotations.CustomizationFormText = "Job Drawing Annotations"
        Me.ItemForJobDrawingAnnotations.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobDrawingAnnotations.Name = "ItemForJobDrawingAnnotations"
        Me.ItemForJobDrawingAnnotations.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobDrawingAnnotations.Text = "Job Drawing Annotations"
        Me.ItemForJobDrawingAnnotations.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobDrawingAnnotations.TextToControlDistance = 5
        '
        'ItemForAudits
        '
        Me.ItemForAudits.Control = Me.AuditsTextEdit
        Me.ItemForAudits.CustomizationFormText = "Audits"
        Me.ItemForAudits.Location = New System.Drawing.Point(0, 0)
        Me.ItemForAudits.Name = "ItemForAudits"
        Me.ItemForAudits.Size = New System.Drawing.Size(0, 0)
        Me.ItemForAudits.Text = "Audits"
        Me.ItemForAudits.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForAudits.TextToControlDistance = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(392, 897)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCostCentre, Me.ItemForJobType, Me.ItemForJobDate, Me.ItemForJobNumber, Me.ItemForCustomer, Me.ItemForAccountName, Me.ItemForJobStage, Me.ItemForWorkCentreCategory, Me.ItemForPricelistID, Me.ItemForDescription1, Me.ItemForDescription2, Me.ItemForContactName, Me.ItemForFax, Me.ItemForTelephone})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(392, 352)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCostCentre
        '
        Me.ItemForCostCentre.Control = Me.CostCentreTextEdit
        Me.ItemForCostCentre.CustomizationFormText = "Cost Centre"
        Me.ItemForCostCentre.Location = New System.Drawing.Point(0, 160)
        Me.ItemForCostCentre.Name = "ItemForCostCentre"
        Me.ItemForCostCentre.Size = New System.Drawing.Size(392, 32)
        Me.ItemForCostCentre.Text = "Cost Centre"
        Me.ItemForCostCentre.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForCostCentre.TextToControlDistance = 5
        '
        'ItemForJobType
        '
        Me.ItemForJobType.Control = Me.JobTypeTextEdit
        Me.ItemForJobType.CustomizationFormText = "Job Type"
        Me.ItemForJobType.Location = New System.Drawing.Point(0, 192)
        Me.ItemForJobType.Name = "ItemForJobType"
        Me.ItemForJobType.Size = New System.Drawing.Size(392, 32)
        Me.ItemForJobType.Text = "Job Type"
        Me.ItemForJobType.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForJobType.TextToControlDistance = 5
        '
        'ItemForJobDate
        '
        Me.ItemForJobDate.Control = Me.JobDateTextEdit
        Me.ItemForJobDate.CustomizationFormText = "Job Date"
        Me.ItemForJobDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobDate.Name = "ItemForJobDate"
        Me.ItemForJobDate.Size = New System.Drawing.Size(196, 32)
        Me.ItemForJobDate.Text = "Job Date"
        Me.ItemForJobDate.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForJobDate.TextToControlDistance = 5
        '
        'ItemForJobNumber
        '
        Me.ItemForJobNumber.Control = Me.JobNumberTextEdit
        Me.ItemForJobNumber.CustomizationFormText = "Job Number"
        Me.ItemForJobNumber.Location = New System.Drawing.Point(196, 0)
        Me.ItemForJobNumber.Name = "ItemForJobNumber"
        Me.ItemForJobNumber.Size = New System.Drawing.Size(196, 32)
        Me.ItemForJobNumber.Text = "Job Number"
        Me.ItemForJobNumber.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForJobNumber.TextToControlDistance = 5
        '
        'ItemForCustomer
        '
        Me.ItemForCustomer.Control = Me.CustomerTextEdit
        Me.ItemForCustomer.CustomizationFormText = "Customer"
        Me.ItemForCustomer.Location = New System.Drawing.Point(0, 32)
        Me.ItemForCustomer.Name = "ItemForCustomer"
        Me.ItemForCustomer.Size = New System.Drawing.Size(196, 32)
        Me.ItemForCustomer.Text = "Customer"
        Me.ItemForCustomer.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForCustomer.TextToControlDistance = 5
        '
        'ItemForAccountName
        '
        Me.ItemForAccountName.Control = Me.AccountNameTextEdit
        Me.ItemForAccountName.CustomizationFormText = "Account Name"
        Me.ItemForAccountName.Location = New System.Drawing.Point(0, 64)
        Me.ItemForAccountName.Name = "ItemForAccountName"
        Me.ItemForAccountName.Size = New System.Drawing.Size(392, 32)
        Me.ItemForAccountName.Text = "Account Name"
        Me.ItemForAccountName.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForAccountName.TextToControlDistance = 5
        '
        'ItemForJobStage
        '
        Me.ItemForJobStage.Control = Me.JobStageTextEdit
        Me.ItemForJobStage.CustomizationFormText = "Job Stage"
        Me.ItemForJobStage.Location = New System.Drawing.Point(196, 32)
        Me.ItemForJobStage.Name = "ItemForJobStage"
        Me.ItemForJobStage.Size = New System.Drawing.Size(196, 32)
        Me.ItemForJobStage.Text = "Job Stage"
        Me.ItemForJobStage.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForJobStage.TextToControlDistance = 5
        '
        'ItemForWorkCentreCategory
        '
        Me.ItemForWorkCentreCategory.Control = Me.WorkCentreCategoryTextEdit
        Me.ItemForWorkCentreCategory.CustomizationFormText = "Work Centre Category"
        Me.ItemForWorkCentreCategory.Location = New System.Drawing.Point(0, 256)
        Me.ItemForWorkCentreCategory.Name = "ItemForWorkCentreCategory"
        Me.ItemForWorkCentreCategory.Size = New System.Drawing.Size(392, 32)
        Me.ItemForWorkCentreCategory.Text = "Work Centre Category"
        Me.ItemForWorkCentreCategory.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForWorkCentreCategory.TextToControlDistance = 5
        '
        'ItemForPricelistID
        '
        Me.ItemForPricelistID.Control = Me.PricelistIDTextEdit
        Me.ItemForPricelistID.CustomizationFormText = "Pricelist ID"
        Me.ItemForPricelistID.Location = New System.Drawing.Point(0, 224)
        Me.ItemForPricelistID.Name = "ItemForPricelistID"
        Me.ItemForPricelistID.Size = New System.Drawing.Size(392, 32)
        Me.ItemForPricelistID.Text = "Pricelist ID"
        Me.ItemForPricelistID.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForPricelistID.TextToControlDistance = 5
        '
        'ItemForDescription1
        '
        Me.ItemForDescription1.Control = Me.Description1TextEdit
        Me.ItemForDescription1.CustomizationFormText = "Description1"
        Me.ItemForDescription1.Location = New System.Drawing.Point(0, 288)
        Me.ItemForDescription1.Name = "ItemForDescription1"
        Me.ItemForDescription1.Size = New System.Drawing.Size(392, 32)
        Me.ItemForDescription1.Text = "Description1"
        Me.ItemForDescription1.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForDescription1.TextToControlDistance = 5
        '
        'ItemForDescription2
        '
        Me.ItemForDescription2.Control = Me.Description2TextEdit
        Me.ItemForDescription2.CustomizationFormText = "Description2"
        Me.ItemForDescription2.Location = New System.Drawing.Point(0, 320)
        Me.ItemForDescription2.Name = "ItemForDescription2"
        Me.ItemForDescription2.Size = New System.Drawing.Size(392, 32)
        Me.ItemForDescription2.Text = "Description2"
        Me.ItemForDescription2.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForDescription2.TextToControlDistance = 5
        '
        'ItemForContactName
        '
        Me.ItemForContactName.Control = Me.ContactNameTextEdit
        Me.ItemForContactName.CustomizationFormText = "Contact Name"
        Me.ItemForContactName.Location = New System.Drawing.Point(0, 96)
        Me.ItemForContactName.Name = "ItemForContactName"
        Me.ItemForContactName.Size = New System.Drawing.Size(392, 32)
        Me.ItemForContactName.Text = "Contact Name"
        Me.ItemForContactName.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForContactName.TextToControlDistance = 5
        '
        'ItemForFax
        '
        Me.ItemForFax.Control = Me.FaxTextEdit
        Me.ItemForFax.CustomizationFormText = "Fax"
        Me.ItemForFax.Location = New System.Drawing.Point(196, 128)
        Me.ItemForFax.Name = "ItemForFax"
        Me.ItemForFax.Size = New System.Drawing.Size(196, 32)
        Me.ItemForFax.Text = "Fax"
        Me.ItemForFax.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForFax.TextToControlDistance = 5
        '
        'ItemForTelephone
        '
        Me.ItemForTelephone.Control = Me.TelephoneTextEdit
        Me.ItemForTelephone.CustomizationFormText = "Telephone"
        Me.ItemForTelephone.Location = New System.Drawing.Point(0, 128)
        Me.ItemForTelephone.Name = "ItemForTelephone"
        Me.ItemForTelephone.Size = New System.Drawing.Size(196, 32)
        Me.ItemForTelephone.Text = "Telephone"
        Me.ItemForTelephone.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForTelephone.TextToControlDistance = 5
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AllowDrawBackground = False
        Me.LayoutControlGroup3.CustomizationFormText = "autoGeneratedGroup1"
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForQuoteNumber, Me.ItemForDeliveryNumber, Me.ItemForOrderNumber, Me.ItemForMake, Me.ItemForModel, Me.ItemForFunction})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 352)
        Me.LayoutControlGroup3.Name = "autoGeneratedGroup1"
        Me.LayoutControlGroup3.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(392, 160)
        Me.LayoutControlGroup3.Text = "autoGeneratedGroup1"
        '
        'ItemForQuoteNumber
        '
        Me.ItemForQuoteNumber.Control = Me.QuoteNumberTextEdit
        Me.ItemForQuoteNumber.CustomizationFormText = "Quote Number"
        Me.ItemForQuoteNumber.Location = New System.Drawing.Point(0, 96)
        Me.ItemForQuoteNumber.Name = "ItemForQuoteNumber"
        Me.ItemForQuoteNumber.Size = New System.Drawing.Size(392, 32)
        Me.ItemForQuoteNumber.Text = "Quote Number"
        Me.ItemForQuoteNumber.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForQuoteNumber.TextToControlDistance = 5
        '
        'ItemForDeliveryNumber
        '
        Me.ItemForDeliveryNumber.Control = Me.DeliveryNumberTextEdit
        Me.ItemForDeliveryNumber.CustomizationFormText = "Delivery Number"
        Me.ItemForDeliveryNumber.Location = New System.Drawing.Point(0, 128)
        Me.ItemForDeliveryNumber.Name = "ItemForDeliveryNumber"
        Me.ItemForDeliveryNumber.Size = New System.Drawing.Size(196, 32)
        Me.ItemForDeliveryNumber.Text = "Delivery Number"
        Me.ItemForDeliveryNumber.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForDeliveryNumber.TextToControlDistance = 5
        '
        'ItemForOrderNumber
        '
        Me.ItemForOrderNumber.Control = Me.OrderNumberTextEdit
        Me.ItemForOrderNumber.CustomizationFormText = "Order Number"
        Me.ItemForOrderNumber.Location = New System.Drawing.Point(196, 128)
        Me.ItemForOrderNumber.Name = "ItemForOrderNumber"
        Me.ItemForOrderNumber.Size = New System.Drawing.Size(196, 32)
        Me.ItemForOrderNumber.Text = "Order Number"
        Me.ItemForOrderNumber.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForOrderNumber.TextToControlDistance = 5
        '
        'ItemForMake
        '
        Me.ItemForMake.Control = Me.MakeTextEdit
        Me.ItemForMake.CustomizationFormText = "Make"
        Me.ItemForMake.Location = New System.Drawing.Point(0, 0)
        Me.ItemForMake.Name = "ItemForMake"
        Me.ItemForMake.Size = New System.Drawing.Size(392, 32)
        Me.ItemForMake.Text = "Make"
        Me.ItemForMake.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForMake.TextToControlDistance = 5
        '
        'ItemForModel
        '
        Me.ItemForModel.Control = Me.ModelTextEdit
        Me.ItemForModel.CustomizationFormText = "Model"
        Me.ItemForModel.Location = New System.Drawing.Point(0, 32)
        Me.ItemForModel.Name = "ItemForModel"
        Me.ItemForModel.Size = New System.Drawing.Size(392, 32)
        Me.ItemForModel.Text = "Model"
        Me.ItemForModel.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForModel.TextToControlDistance = 5
        '
        'ItemForFunction
        '
        Me.ItemForFunction.Control = Me.FunctionTextEdit
        Me.ItemForFunction.CustomizationFormText = "Function"
        Me.ItemForFunction.Location = New System.Drawing.Point(0, 64)
        Me.ItemForFunction.Name = "ItemForFunction"
        Me.ItemForFunction.Size = New System.Drawing.Size(392, 32)
        Me.ItemForFunction.Text = "Function"
        Me.ItemForFunction.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForFunction.TextToControlDistance = 5
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AllowDrawBackground = False
        Me.LayoutControlGroup4.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForQuoteAgent, Me.ItemForJobAgent})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 512)
        Me.LayoutControlGroup4.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup4.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(392, 32)
        Me.LayoutControlGroup4.Text = "autoGeneratedGroup0"
        '
        'ItemForQuoteAgent
        '
        Me.ItemForQuoteAgent.Control = Me.QuoteAgentTextEdit
        Me.ItemForQuoteAgent.CustomizationFormText = "Quote Agent"
        Me.ItemForQuoteAgent.Location = New System.Drawing.Point(0, 0)
        Me.ItemForQuoteAgent.Name = "ItemForQuoteAgent"
        Me.ItemForQuoteAgent.Size = New System.Drawing.Size(196, 32)
        Me.ItemForQuoteAgent.Text = "Quote Agent"
        Me.ItemForQuoteAgent.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForQuoteAgent.TextToControlDistance = 5
        '
        'ItemForJobAgent
        '
        Me.ItemForJobAgent.Control = Me.JobAgentTextEdit
        Me.ItemForJobAgent.CustomizationFormText = "Job Agent"
        Me.ItemForJobAgent.Location = New System.Drawing.Point(196, 0)
        Me.ItemForJobAgent.Name = "ItemForJobAgent"
        Me.ItemForJobAgent.Size = New System.Drawing.Size(196, 32)
        Me.ItemForJobAgent.Text = "Job Agent"
        Me.ItemForJobAgent.TextSize = New System.Drawing.Size(127, 16)
        Me.ItemForJobAgent.TextToControlDistance = 5
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.AllowDrawBackground = False
        Me.LayoutControlGroup5.CustomizationFormText = "autoGeneratedGroup1"
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 544)
        Me.LayoutControlGroup5.Name = "autoGeneratedGroup1"
        Me.LayoutControlGroup5.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(392, 353)
        Me.LayoutControlGroup5.Text = "autoGeneratedGroup1"
        '
        'bsiReports
        '
        Me.bsiReports.Caption = "Reports"
        Me.bsiReports.Id = 200
        Me.bsiReports.Name = "bsiReports"
        '
        'hideContainerLeft
        '
        Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.hideContainerLeft.Location = New System.Drawing.Point(0, 53)
        Me.hideContainerLeft.Name = "hideContainerLeft"
        Me.hideContainerLeft.Size = New System.Drawing.Size(19, 745)
        '
        'xlJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.JobEnquiryDockPanel)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "xlJob"
        Me.Size = New System.Drawing.Size(1924, 982)
        Me.Controls.SetChildIndex(Me.JobEnquiryDockPanel, 0)
        Me.Controls.SetChildIndex(Me.GridPanel, 0)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JobAuditDockPanel.ResumeLayout(False)
        Me.JobEnquiryDockPanel.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.dlcJobEnquiry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dlcJobEnquiry.ResumeLayout(False)
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimaryArtisanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCentreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastActivityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityDeliveredTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.JobStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FunctionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsBreakdownTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsApprovedTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsProcuredTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsStockDrawnTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteAgentTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobAgentTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDeliveriesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLinesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTolerancesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobMemoesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDrawingAnnotationsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPreviousStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActualStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActualEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsProcured, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsBreakdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsApproved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsStockDrawn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidityDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAcceptedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCancelledDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuantityDelivered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPrimaryArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForLastActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForGeneration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWarranty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCancelReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteComments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNewPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTotalPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDiscountPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDiscountAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRequisitionNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDeliveries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobTolerances, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRequisitions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobMemoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDrawingAnnotations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAudits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCostCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAccountName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPricelistID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForContactName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTelephone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFunction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteAgent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobAgent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcJob As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJob As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents JobEnquiryDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents dlcJobEnquiry As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents NextStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PreviousStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrimaryArtisanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CostCentreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobTypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LastActivityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitPriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalPriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuantityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuantityDeliveredTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoteNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliveryNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrderNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobDateTextEdit As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents JobStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DrawingTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GenerationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MakeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ModelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FunctionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobCategoryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkCentreCategoryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForNextStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPreviousStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPrimaryArtisan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCustomer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCostCentre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForLastActivity As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUnitCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUnitPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTotalCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTotalPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuantity As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuantityDelivered As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForQuoteNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeliveryNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrderNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDate As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents ItemForIsBreakdown As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsApproved As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsProcured As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsStockDrawn As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAccountName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForContactName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTelephone As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEmail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFax As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrderTotal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDiscountPercent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDiscountAmount As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNewPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWarranty As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCancelReason As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuoteComments As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPricelistID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForState As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDrawing As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForGeneration As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMake As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForModel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFunction As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWorkCentreCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IsBreakdownTextEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsApprovedTextEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsProcuredTextEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsStockDrawnTextEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsBreakdown As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsApproved As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsProcured As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsStockDrawn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCancelReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobStage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JobAuditDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer1 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents bsiReports As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colJobAgent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QuoteAgentTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobAgentTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RequisitionNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobDeliveriesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobLinesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobTolerancesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RequisitionsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NotesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobMemoesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobDrawingAnnotationsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AuditsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForRequisitionNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDeliveries As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobLines As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobTolerances As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRequisitions As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNotes As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobMemoes As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDrawingAnnotations As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAudits As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForQuoteAgent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobAgent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents colRepresentativeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRepresentativeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerialNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
