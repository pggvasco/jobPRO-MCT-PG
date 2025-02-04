<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobQuote
    Inherits UniSource.ShopFloor.GUI.xaegJobQuote

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
    '<System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rlkpPart = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colWorkCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rlkpWorkCentre = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.WorkCentreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colJobLineDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGRVDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCriteria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsProcured = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsStockDrawn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riseQuantity = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colQuantityStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantitySupplier1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantitySupplier2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMarkupFactor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeasurement1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeasurement2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeasurement3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riseLineNumber = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colSupplyScope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpSupplyScope = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SupplyScopeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpSupplierType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VendorClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSupplier1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpSupplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSupplier2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpInventoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.StockItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobLineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAddLine = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditLine = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiImport = New DevExpress.XtraBars.BarSubItem()
        Me.bbiImportJob = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImportTemplate = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImportQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiUpdateLinesDiscount = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiReports = New DevExpress.XtraBars.BarSubItem()
        Me.btnCreateRequisition = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRePrintRequisition = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCancelSelectedLines = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiResetFormDefaults = New DevExpress.XtraBars.BarButtonItem()
        Me.JobDataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.defaultDiscountSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ExpectedGPSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CurrentGPSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TotalPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.UnitPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.QuoteDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.QuoteNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.gcLobLines = New DevExpress.XtraGrid.GridControl()
        Me.gvJobLines = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWorkCentreCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rlkpWorkCentreCategory = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.WorkCentreCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colQtyOH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMarkupPercent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.risePercent = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colPartGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riseCurrency = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colUnitCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPurchasePrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPriceBeforeDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPriceBeforeMarkup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineDiscountPercent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseDiscountPercent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalActualCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsRequisitionedGenerated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ritePartGroup = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.riceSelected = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CancelledDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ValidityDaysTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DeliveryDaysTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NewPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.WarrantyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CancelReasonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuoteCommentsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DrawingTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobTemplateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuoteAgentTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDeliveriesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PurchaseOrdersTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NextStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PreviousStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobTypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.QuantityDeliveredSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DeliveryNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrderNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.InvoiceDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AcceptedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.EstimatedDeliveryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.IsBreakdownCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsApprovedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsStockDrawnCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AccountNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContactNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelephoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsProcuredCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Description2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DiscountPercentSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DiscountAmountSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.StateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GenerationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MakeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ModelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FunctionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobCategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkCentreCategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CostCentreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitCostTextEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TotalCostTextEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.OrderTotalTextEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AdditionalFieldsLayoutControlInternal = New DevExpress.XtraLayout.LayoutControl()
        Me.AdditionalFieldsRoot = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SubContractorReferenceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SubContractorQuotedPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SubContractorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForValidityDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNewPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCancelledDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWarranty = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteComments = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCancelReason = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDrawing = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobTemplate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteAgent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPurchaseOrders = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDeliveries = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.QuoteLinesLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.ValuesLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForTotalPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnitPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnitCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTotalCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuantity = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuantityDelivered = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDiscountPercent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDiscountAmount = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCurrentGP = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForExpectedGP = New DevExpress.XtraLayout.LayoutControlItem()
        Me.defaultdiscountPercLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcgDetails = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCustomer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrderNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAcceptedDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForInvoiceDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedDeliveryDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrderTotal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ContactLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForAccountName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForContactName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTelephone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEmail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForFax = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StatusLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForNextStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsBreakdown = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsApproved = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForState = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsProcured = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsStockDrawn = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPreviousStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CategoryLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForMake = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForFunction = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCostCentre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWorkCentreCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForGeneration = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForModel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForSubContractorQuotedPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.ItemForSubContractorReference = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSubContractor = New DevExpress.XtraLayout.LayoutControlItem()
        Me.AdditionalFieldsLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridPopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rlkpPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rlkpWorkCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseLineNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpSupplyScope, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyScopeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpSupplierType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpInventoryItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JobDataLayoutControl.SuspendLayout()
        CType(Me.defaultDiscountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedGPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentGPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcLobLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rlkpWorkCentreCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.risePercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ritePartGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riceSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelledDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelledDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidityDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarrantyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteCommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTemplateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteAgentTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDeliveriesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrdersTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityDeliveredSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcceptedDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcceptedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsBreakdownCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsApprovedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsStockDrawnCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelephoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsProcuredCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountPercentSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountAmountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FunctionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCentreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTotalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdditionalFieldsLayoutControlInternal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdditionalFieldsRoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubContractorReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubContractorQuotedPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubContractorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidityDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNewPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCancelledDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWarranty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteComments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCancelReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDeliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteLinesLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValuesLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTotalPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuantityDelivered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDiscountPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDiscountAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCurrentGP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForExpectedGP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.defaultdiscountPercLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAcceptedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAccountName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForContactName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTelephone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsBreakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsApproved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsProcured, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsStockDrawn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPreviousStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFunction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCostCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForGeneration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSubContractorQuotedPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSubContractorReference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSubContractor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdditionalFieldsLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grpGroup.Controls.Add(Me.JobDataLayoutControl)
        Me.grpGroup.Location = New System.Drawing.Point(0, 28)
        Me.grpGroup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpGroup.ShowCaption = False
        Me.grpGroup.Size = New System.Drawing.Size(1241, 636)
        Me.grpGroup.Text = "Job"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(1073, 670)
        Me.btSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(1154, 670)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        'colPart
        '
        Me.colPart.ColumnEdit = Me.rlkpPart
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        Me.colPart.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPart.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPart.OptionsColumn.ReadOnly = True
        Me.colPart.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colPart.Visible = True
        Me.colPart.VisibleIndex = 2
        Me.colPart.Width = 86
        '
        'rlkpPart
        '
        Me.rlkpPart.AutoHeight = False
        Me.rlkpPart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rlkpPart.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rlkpPart.DataSource = Me.PartBindingSource
        Me.rlkpPart.DisplayMember = "Code"
        Me.rlkpPart.Name = "rlkpPart"
        Me.rlkpPart.NullText = "(Select Part...)"
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Part)
        '
        'colWorkCentre
        '
        Me.colWorkCentre.ColumnEdit = Me.rlkpWorkCentre
        Me.colWorkCentre.FieldName = "WorkCentre"
        Me.colWorkCentre.Name = "colWorkCentre"
        Me.colWorkCentre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colWorkCentre.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colWorkCentre.OptionsColumn.ReadOnly = True
        Me.colWorkCentre.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colWorkCentre.Visible = True
        Me.colWorkCentre.VisibleIndex = 4
        Me.colWorkCentre.Width = 123
        '
        'rlkpWorkCentre
        '
        Me.rlkpWorkCentre.AutoHeight = False
        Me.rlkpWorkCentre.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rlkpWorkCentre.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rlkpWorkCentre.DataSource = Me.WorkCentreBindingSource
        Me.rlkpWorkCentre.Name = "rlkpWorkCentre"
        Me.rlkpWorkCentre.NullText = "(Select Work Centre...)"
        '
        'WorkCentreBindingSource
        '
        Me.WorkCentreBindingSource.DataSource = GetType(UniSource.ShopFloor.API.WorkCentre)
        '
        'colJobLineDate
        '
        Me.colJobLineDate.DisplayFormat.FormatString = "d"
        Me.colJobLineDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colJobLineDate.FieldName = "JobLineDate"
        Me.colJobLineDate.GroupFormat.FormatString = "d"
        Me.colJobLineDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colJobLineDate.Name = "colJobLineDate"
        Me.colJobLineDate.OptionsColumn.ReadOnly = True
        '
        'colOrderDate
        '
        Me.colOrderDate.DisplayFormat.FormatString = "d"
        Me.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.GroupFormat.FormatString = "d"
        Me.colOrderDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.OptionsColumn.ReadOnly = True
        '
        'colRequiredDate
        '
        Me.colRequiredDate.DisplayFormat.FormatString = "d"
        Me.colRequiredDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colRequiredDate.FieldName = "RequiredDate"
        Me.colRequiredDate.GroupFormat.FormatString = "d"
        Me.colRequiredDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colRequiredDate.Name = "colRequiredDate"
        Me.colRequiredDate.OptionsColumn.ReadOnly = True
        Me.colRequiredDate.Width = 78
        '
        'colGRVDate
        '
        Me.colGRVDate.DisplayFormat.FormatString = "d"
        Me.colGRVDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGRVDate.FieldName = "GRVDate"
        Me.colGRVDate.GroupFormat.FormatString = "d"
        Me.colGRVDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGRVDate.Name = "colGRVDate"
        Me.colGRVDate.OptionsColumn.ReadOnly = True
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description1"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colDescription1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colDescription1.OptionsColumn.ReadOnly = True
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 6
        Me.colDescription1.Width = 200
        '
        'colDescription2
        '
        Me.colDescription2.FieldName = "Description2"
        Me.colDescription2.Name = "colDescription2"
        Me.colDescription2.OptionsColumn.ReadOnly = True
        Me.colDescription2.Visible = True
        Me.colDescription2.VisibleIndex = 7
        Me.colDescription2.Width = 78
        '
        'colQuoteDescription
        '
        Me.colQuoteDescription.FieldName = "QuoteDescription"
        Me.colQuoteDescription.Name = "colQuoteDescription"
        Me.colQuoteDescription.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colQuoteDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colQuoteDescription.OptionsColumn.ReadOnly = True
        Me.colQuoteDescription.Width = 95
        '
        'colCriteria
        '
        Me.colCriteria.FieldName = "Criteria"
        Me.colCriteria.Name = "colCriteria"
        Me.colCriteria.OptionsColumn.ReadOnly = True
        '
        'colIsProcured
        '
        Me.colIsProcured.FieldName = "IsProcured"
        Me.colIsProcured.Name = "colIsProcured"
        Me.colIsProcured.OptionsColumn.ReadOnly = True
        '
        'colIsStockDrawn
        '
        Me.colIsStockDrawn.FieldName = "IsStockDrawn"
        Me.colIsStockDrawn.Name = "colIsStockDrawn"
        Me.colIsStockDrawn.OptionsColumn.ReadOnly = True
        Me.colIsStockDrawn.Width = 81
        '
        'colQuantity
        '
        Me.colQuantity.ColumnEdit = Me.riseQuantity
        Me.colQuantity.DisplayFormat.FormatString = "f"
        Me.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.GroupFormat.FormatString = "f"
        Me.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.OptionsColumn.ReadOnly = True
        Me.colQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:f2}")})
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 8
        '
        'riseQuantity
        '
        Me.riseQuantity.AutoHeight = False
        Me.riseQuantity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.riseQuantity.DisplayFormat.FormatString = "f"
        Me.riseQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.riseQuantity.EditFormat.FormatString = "f"
        Me.riseQuantity.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.riseQuantity.Mask.EditMask = "f"
        Me.riseQuantity.Name = "riseQuantity"
        '
        'colQuantityStock
        '
        Me.colQuantityStock.ColumnEdit = Me.riseQuantity
        Me.colQuantityStock.DisplayFormat.FormatString = "f"
        Me.colQuantityStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantityStock.FieldName = "QuantityStock"
        Me.colQuantityStock.GroupFormat.FormatString = "f"
        Me.colQuantityStock.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantityStock.Name = "colQuantityStock"
        Me.colQuantityStock.OptionsColumn.ReadOnly = True
        Me.colQuantityStock.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityStock", "{0:f2}")})
        Me.colQuantityStock.Visible = True
        Me.colQuantityStock.VisibleIndex = 13
        Me.colQuantityStock.Width = 90
        '
        'colQuantitySupplier1
        '
        Me.colQuantitySupplier1.ColumnEdit = Me.riseQuantity
        Me.colQuantitySupplier1.DisplayFormat.FormatString = "f"
        Me.colQuantitySupplier1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantitySupplier1.FieldName = "QuantitySupplier1"
        Me.colQuantitySupplier1.GroupFormat.FormatString = "f"
        Me.colQuantitySupplier1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantitySupplier1.Name = "colQuantitySupplier1"
        Me.colQuantitySupplier1.OptionsColumn.ReadOnly = True
        Me.colQuantitySupplier1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantitySupplier1", "{0:f2}")})
        Me.colQuantitySupplier1.Visible = True
        Me.colQuantitySupplier1.VisibleIndex = 14
        Me.colQuantitySupplier1.Width = 108
        '
        'colQuantitySupplier2
        '
        Me.colQuantitySupplier2.ColumnEdit = Me.riseQuantity
        Me.colQuantitySupplier2.DisplayFormat.FormatString = "f"
        Me.colQuantitySupplier2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantitySupplier2.FieldName = "QuantitySupplier2"
        Me.colQuantitySupplier2.GroupFormat.FormatString = "f"
        Me.colQuantitySupplier2.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantitySupplier2.Name = "colQuantitySupplier2"
        Me.colQuantitySupplier2.OptionsColumn.ReadOnly = True
        Me.colQuantitySupplier2.Width = 98
        '
        'colEstimatedDuration
        '
        Me.colEstimatedDuration.ColumnEdit = Me.riseQuantity
        Me.colEstimatedDuration.DisplayFormat.FormatString = "f"
        Me.colEstimatedDuration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedDuration.FieldName = "EstimatedDuration"
        Me.colEstimatedDuration.GroupFormat.FormatString = "f"
        Me.colEstimatedDuration.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedDuration.Name = "colEstimatedDuration"
        Me.colEstimatedDuration.OptionsColumn.ReadOnly = True
        Me.colEstimatedDuration.Visible = True
        Me.colEstimatedDuration.VisibleIndex = 15
        Me.colEstimatedDuration.Width = 110
        '
        'colMarkupFactor
        '
        Me.colMarkupFactor.ColumnEdit = Me.riseQuantity
        Me.colMarkupFactor.DisplayFormat.FormatString = "f"
        Me.colMarkupFactor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMarkupFactor.FieldName = "MarkupFactor"
        Me.colMarkupFactor.GroupFormat.FormatString = "f"
        Me.colMarkupFactor.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMarkupFactor.Name = "colMarkupFactor"
        Me.colMarkupFactor.OptionsColumn.ReadOnly = True
        Me.colMarkupFactor.Width = 78
        '
        'colUnitPrice
        '
        Me.colUnitPrice.DisplayFormat.FormatString = "c"
        Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.GroupFormat.FormatString = "c"
        Me.colUnitPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.OptionsColumn.ReadOnly = True
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 16
        '
        'colTotalPrice
        '
        Me.colTotalPrice.DisplayFormat.FormatString = "c"
        Me.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalPrice.FieldName = "TotalPrice"
        Me.colTotalPrice.GroupFormat.FormatString = "c"
        Me.colTotalPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalPrice.Name = "colTotalPrice"
        Me.colTotalPrice.OptionsColumn.ReadOnly = True
        Me.colTotalPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:c2}")})
        Me.colTotalPrice.Visible = True
        Me.colTotalPrice.VisibleIndex = 18
        '
        'colMeasurement1
        '
        Me.colMeasurement1.FieldName = "Measurement1"
        Me.colMeasurement1.Name = "colMeasurement1"
        Me.colMeasurement1.OptionsColumn.ReadOnly = True
        Me.colMeasurement1.Width = 80
        '
        'colMeasurement2
        '
        Me.colMeasurement2.FieldName = "Measurement2"
        Me.colMeasurement2.Name = "colMeasurement2"
        Me.colMeasurement2.OptionsColumn.ReadOnly = True
        Me.colMeasurement2.Width = 80
        '
        'colMeasurement3
        '
        Me.colMeasurement3.FieldName = "Measurement3"
        Me.colMeasurement3.Name = "colMeasurement3"
        Me.colMeasurement3.OptionsColumn.ReadOnly = True
        Me.colMeasurement3.Width = 80
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colLineNumber
        '
        Me.colLineNumber.ColumnEdit = Me.riseLineNumber
        Me.colLineNumber.FieldName = "LineNumber"
        Me.colLineNumber.Name = "colLineNumber"
        Me.colLineNumber.OptionsColumn.ReadOnly = True
        Me.colLineNumber.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colLineNumber.Visible = True
        Me.colLineNumber.VisibleIndex = 0
        Me.colLineNumber.Width = 78
        '
        'riseLineNumber
        '
        Me.riseLineNumber.AutoHeight = False
        Me.riseLineNumber.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.riseLineNumber.Name = "riseLineNumber"
        '
        'colSupplyScope
        '
        Me.colSupplyScope.ColumnEdit = Me.rilkpSupplyScope
        Me.colSupplyScope.FieldName = "SupplyScope"
        Me.colSupplyScope.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText
        Me.colSupplyScope.Name = "colSupplyScope"
        Me.colSupplyScope.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colSupplyScope.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colSupplyScope.OptionsColumn.ReadOnly = True
        Me.colSupplyScope.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colSupplyScope.Visible = True
        Me.colSupplyScope.VisibleIndex = 10
        Me.colSupplyScope.Width = 83
        '
        'rilkpSupplyScope
        '
        Me.rilkpSupplyScope.AutoHeight = False
        Me.rilkpSupplyScope.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilkpSupplyScope.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpSupplyScope.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rilkpSupplyScope.DataSource = Me.SupplyScopeBindingSource
        Me.rilkpSupplyScope.Name = "rilkpSupplyScope"
        Me.rilkpSupplyScope.NullText = "(Select Supply Scope...)"
        '
        'SupplyScopeBindingSource
        '
        Me.SupplyScopeBindingSource.DataSource = GetType(UniSource.ShopFloor.API.SupplyScope)
        '
        'colSupplierType
        '
        Me.colSupplierType.Caption = "Supplier Type"
        Me.colSupplierType.ColumnEdit = Me.rilkpSupplierType
        Me.colSupplierType.FieldName = "SupplierType"
        Me.colSupplierType.Name = "colSupplierType"
        Me.colSupplierType.OptionsColumn.ReadOnly = True
        Me.colSupplierType.Visible = True
        Me.colSupplierType.VisibleIndex = 11
        Me.colSupplierType.Width = 84
        '
        'rilkpSupplierType
        '
        Me.rilkpSupplierType.AutoHeight = False
        Me.rilkpSupplierType.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilkpSupplierType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpSupplierType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rilkpSupplierType.DataSource = Me.VendorClassBindingSource
        Me.rilkpSupplierType.DisplayMember = "Code"
        Me.rilkpSupplierType.Name = "rilkpSupplierType"
        Me.rilkpSupplierType.NullText = "(Select Supplier Type...)"
        '
        'VendorClassBindingSource
        '
        Me.VendorClassBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.VendorClass)
        '
        'colSupplier1
        '
        Me.colSupplier1.Caption = "Supplier 1"
        Me.colSupplier1.ColumnEdit = Me.rilkpSupplier
        Me.colSupplier1.FieldName = "Supplier1"
        Me.colSupplier1.Name = "colSupplier1"
        Me.colSupplier1.OptionsColumn.ReadOnly = True
        Me.colSupplier1.Visible = True
        Me.colSupplier1.VisibleIndex = 12
        '
        'rilkpSupplier
        '
        Me.rilkpSupplier.AutoHeight = False
        Me.rilkpSupplier.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilkpSupplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpSupplier.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account", "Account", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rilkpSupplier.DataSource = Me.VendorBindingSource
        Me.rilkpSupplier.DisplayMember = "Account"
        Me.rilkpSupplier.Name = "rilkpSupplier"
        Me.rilkpSupplier.NullText = "(Select Supplier...)"
        '
        'VendorBindingSource
        '
        Me.VendorBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.Vendor)
        '
        'colSupplier2
        '
        Me.colSupplier2.Caption = "Supplier 2"
        Me.colSupplier2.ColumnEdit = Me.rilkpSupplier
        Me.colSupplier2.FieldName = "Supplier2"
        Me.colSupplier2.Name = "colSupplier2"
        Me.colSupplier2.OptionsColumn.ReadOnly = True
        '
        'colInventoryItem
        '
        Me.colInventoryItem.Caption = "Inventory Item"
        Me.colInventoryItem.ColumnEdit = Me.rilkpInventoryItem
        Me.colInventoryItem.FieldName = "InventoryItem"
        Me.colInventoryItem.Name = "colInventoryItem"
        Me.colInventoryItem.OptionsColumn.ReadOnly = True
        Me.colInventoryItem.Visible = True
        Me.colInventoryItem.VisibleIndex = 5
        Me.colInventoryItem.Width = 92
        '
        'rilkpInventoryItem
        '
        Me.rilkpInventoryItem.AutoHeight = False
        Me.rilkpInventoryItem.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilkpInventoryItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpInventoryItem.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description1", "Description1", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QtyOnHand", "Available")})
        Me.rilkpInventoryItem.DataSource = Me.StockItemBindingSource
        Me.rilkpInventoryItem.DisplayMember = "Code"
        Me.rilkpInventoryItem.Name = "rilkpInventoryItem"
        Me.rilkpInventoryItem.NullText = "(Select Inventory Item...)"
        '
        'StockItemBindingSource
        '
        Me.StockItemBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.StockItem)
        '
        'JobLineListBindingSource
        '
        Me.JobLineListBindingSource.DataMember = "JobLineList"
        Me.JobLineListBindingSource.DataSource = Me.BindingSource
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiSave, Me.bsiReports, Me.bbiCancel, Me.bbiExportGrid, Me.bbiResetFormDefaults, Me.bbiAddLine, Me.bbiEditLine, Me.bsiImport, Me.bbiImportJob, Me.bbiImportTemplate, Me.bbiImportQuote, Me.bbiUpdateLinesDiscount, Me.btnCreateRequisition, Me.btnRePrintRequisition, Me.bbiCancelSelectedLines})
        Me.BarManager.MainMenu = Me.Bar2
        Me.BarManager.MaxItemId = 20
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAddLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiImport), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiUpdateLinesDiscount), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiReports), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCreateRequisition), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRePrintRequisition), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCancelSelectedLines)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Id = 0
        Me.bbiSave.Name = "bbiSave"
        Me.bbiSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiAddLine
        '
        Me.bbiAddLine.Caption = "Add Line"
        Me.bbiAddLine.Id = 9
        Me.bbiAddLine.Name = "bbiAddLine"
        Me.bbiAddLine.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiEditLine
        '
        Me.bbiEditLine.Caption = "Edit Line"
        Me.bbiEditLine.Id = 10
        Me.bbiEditLine.Name = "bbiEditLine"
        Me.bbiEditLine.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bsiImport
        '
        Me.bsiImport.Caption = "Import"
        Me.bsiImport.Id = 12
        Me.bsiImport.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImportJob), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImportTemplate), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImportQuote)})
        Me.bsiImport.Name = "bsiImport"
        Me.bsiImport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiImportJob
        '
        Me.bbiImportJob.Caption = "Job"
        Me.bbiImportJob.Id = 13
        Me.bbiImportJob.Name = "bbiImportJob"
        Me.bbiImportJob.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiImportTemplate
        '
        Me.bbiImportTemplate.Caption = "Template"
        Me.bbiImportTemplate.Id = 14
        Me.bbiImportTemplate.Name = "bbiImportTemplate"
        Me.bbiImportTemplate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiImportQuote
        '
        Me.bbiImportQuote.Caption = "Quote"
        Me.bbiImportQuote.Id = 15
        Me.bbiImportQuote.Name = "bbiImportQuote"
        '
        'bbiUpdateLinesDiscount
        '
        Me.bbiUpdateLinesDiscount.Caption = "Update All Lines Discount"
        Me.bbiUpdateLinesDiscount.Id = 16
        Me.bbiUpdateLinesDiscount.Name = "bbiUpdateLinesDiscount"
        '
        'bbiExportGrid
        '
        Me.bbiExportGrid.Caption = "Export Grid"
        Me.bbiExportGrid.Id = 5
        Me.bbiExportGrid.Name = "bbiExportGrid"
        Me.bbiExportGrid.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bsiReports
        '
        Me.bsiReports.Caption = "Reports"
        Me.bsiReports.Id = 1
        Me.bsiReports.Name = "bsiReports"
        Me.bsiReports.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnCreateRequisition
        '
        Me.btnCreateRequisition.Caption = "Create Requisition"
        Me.btnCreateRequisition.Id = 17
        Me.btnCreateRequisition.Name = "btnCreateRequisition"
        Me.btnCreateRequisition.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnRePrintRequisition
        '
        Me.btnRePrintRequisition.Caption = "Re-Print Requisition"
        Me.btnRePrintRequisition.Id = 18
        Me.btnRePrintRequisition.Name = "btnRePrintRequisition"
        Me.btnRePrintRequisition.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiCancelSelectedLines
        '
        Me.bbiCancelSelectedLines.Caption = "Cancel Selected Lines"
        Me.bbiCancelSelectedLines.Id = 19
        Me.bbiCancelSelectedLines.Name = "bbiCancelSelectedLines"
        Me.bbiCancelSelectedLines.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1241, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 705)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1241, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 683)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1241, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 683)
        '
        'bbiCancel
        '
        Me.bbiCancel.Caption = "Cancel"
        Me.bbiCancel.Id = 3
        Me.bbiCancel.Name = "bbiCancel"
        Me.bbiCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiResetFormDefaults
        '
        Me.bbiResetFormDefaults.Caption = "Reset Form Defaults"
        Me.bbiResetFormDefaults.Id = 8
        Me.bbiResetFormDefaults.Name = "bbiResetFormDefaults"
        '
        'JobDataLayoutControl
        '
        Me.JobDataLayoutControl.Controls.Add(Me.defaultDiscountSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.ExpectedGPSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.CurrentGPSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.TotalPriceSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.UnitPriceSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.QuoteDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.QuoteNumberTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobNumberTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DescriptionTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.gcLobLines)
        Me.JobDataLayoutControl.Controls.Add(Me.CancelledDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.ValidityDaysTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DeliveryDaysTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.NewPriceSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.WarrantyTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.CancelReasonTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.QuoteCommentsTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DrawingTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobTemplateTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.QuoteAgentTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobDeliveriesTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.PurchaseOrdersTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.CustomerTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.NextStageTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.PreviousStageTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobTypeTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.QuantitySpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.QuantityDeliveredSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DeliveryNumberTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.OrderNumberTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.InvoiceDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.AcceptedDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.EstimatedDeliveryDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.IsBreakdownCheckEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.IsApprovedCheckEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.IsStockDrawnCheckEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.AccountNameTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.ContactNameTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.TelephoneTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.IsProcuredCheckEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.EmailTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.FaxTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.Description2TextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DiscountPercentSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DiscountAmountSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.StateTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobStageTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.GenerationTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.MakeTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.ModelTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.FunctionTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobCategoryTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.WorkCentreCategoryTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.CostCentreTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.UnitCostTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.TotalCostTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.OrderTotalTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.AdditionalFieldsLayoutControlInternal)
        Me.JobDataLayoutControl.Controls.Add(Me.SubContractorReferenceTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.SubContractorQuotedPriceSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.SubContractorTextEdit)
        Me.JobDataLayoutControl.DataMember = Nothing
        Me.JobDataLayoutControl.DataSource = Me.BindingSource
        Me.JobDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobDataLayoutControl.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForValidityDays, Me.ItemForDeliveryDays, Me.ItemForNewPrice, Me.ItemForCancelledDate, Me.ItemForWarranty, Me.ItemForQuoteComments, Me.ItemForCancelReason, Me.ItemForDrawing, Me.ItemForJobTemplate, Me.ItemForQuoteAgent, Me.ItemForPurchaseOrders, Me.ItemForJobDeliveries})
        Me.JobDataLayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.JobDataLayoutControl.Name = "JobDataLayoutControl"
        Me.JobDataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(125, 56, 256, 360)
        Me.JobDataLayoutControl.OptionsView.UseSkinIndents = False
        Me.JobDataLayoutControl.Root = Me.LayoutControlGroup1
        Me.JobDataLayoutControl.Size = New System.Drawing.Size(1241, 636)
        Me.JobDataLayoutControl.TabIndex = 6
        Me.JobDataLayoutControl.Text = "DataLayoutControl1"
        '
        'defaultDiscountSpinEdit
        '
        Me.defaultDiscountSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DefaultDiscountPercent", True))
        Me.defaultDiscountSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.defaultDiscountSpinEdit.Location = New System.Drawing.Point(150, 149)
        Me.defaultDiscountSpinEdit.MenuManager = Me.BarManager
        Me.defaultDiscountSpinEdit.Name = "defaultDiscountSpinEdit"
        Me.defaultDiscountSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.defaultDiscountSpinEdit.Size = New System.Drawing.Size(155, 20)
        Me.defaultDiscountSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.defaultDiscountSpinEdit.TabIndex = 107
        '
        'ExpectedGPSpinEdit
        '
        Me.ExpectedGPSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ExpectedGP", True))
        Me.ExpectedGPSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ExpectedGPSpinEdit.Location = New System.Drawing.Point(766, 119)
        Me.ExpectedGPSpinEdit.MenuManager = Me.BarManager
        Me.ExpectedGPSpinEdit.Name = "ExpectedGPSpinEdit"
        Me.ExpectedGPSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ExpectedGPSpinEdit.Properties.DisplayFormat.FormatString = "p"
        Me.ExpectedGPSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ExpectedGPSpinEdit.Properties.EditFormat.FormatString = "p"
        Me.ExpectedGPSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ExpectedGPSpinEdit.Properties.ReadOnly = True
        Me.ExpectedGPSpinEdit.Size = New System.Drawing.Size(464, 20)
        Me.ExpectedGPSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.ExpectedGPSpinEdit.TabIndex = 106
        '
        'CurrentGPSpinEdit
        '
        Me.CurrentGPSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CurrentGP", True))
        Me.CurrentGPSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CurrentGPSpinEdit.Location = New System.Drawing.Point(766, 89)
        Me.CurrentGPSpinEdit.MenuManager = Me.BarManager
        Me.CurrentGPSpinEdit.Name = "CurrentGPSpinEdit"
        Me.CurrentGPSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CurrentGPSpinEdit.Properties.DisplayFormat.FormatString = "p"
        Me.CurrentGPSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CurrentGPSpinEdit.Properties.EditFormat.FormatString = "p"
        Me.CurrentGPSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CurrentGPSpinEdit.Properties.ReadOnly = True
        Me.CurrentGPSpinEdit.Size = New System.Drawing.Size(464, 20)
        Me.CurrentGPSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.CurrentGPSpinEdit.TabIndex = 105
        '
        'TotalPriceSpinEdit
        '
        Me.TotalPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "TotalPrice", True))
        Me.TotalPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TotalPriceSpinEdit.Location = New System.Drawing.Point(150, 59)
        Me.TotalPriceSpinEdit.MenuManager = Me.BarManager
        Me.TotalPriceSpinEdit.Name = "TotalPriceSpinEdit"
        Me.TotalPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TotalPriceSpinEdit.Properties.DisplayFormat.FormatString = "c"
        Me.TotalPriceSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalPriceSpinEdit.Properties.EditFormat.FormatString = "c"
        Me.TotalPriceSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalPriceSpinEdit.Properties.ReadOnly = True
        Me.TotalPriceSpinEdit.Size = New System.Drawing.Size(463, 20)
        Me.TotalPriceSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.TotalPriceSpinEdit.TabIndex = 20
        '
        'UnitPriceSpinEdit
        '
        Me.UnitPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UnitPrice", True))
        Me.UnitPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UnitPriceSpinEdit.Location = New System.Drawing.Point(150, 29)
        Me.UnitPriceSpinEdit.MenuManager = Me.BarManager
        Me.UnitPriceSpinEdit.Name = "UnitPriceSpinEdit"
        Me.UnitPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitPriceSpinEdit.Properties.DisplayFormat.FormatString = "c"
        Me.UnitPriceSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitPriceSpinEdit.Properties.EditFormat.FormatString = "c"
        Me.UnitPriceSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitPriceSpinEdit.Properties.ReadOnly = True
        Me.UnitPriceSpinEdit.Size = New System.Drawing.Size(463, 20)
        Me.UnitPriceSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.UnitPriceSpinEdit.TabIndex = 19
        '
        'QuoteDateDateEdit
        '
        Me.QuoteDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuoteDate", True))
        Me.QuoteDateDateEdit.EditValue = Nothing
        Me.QuoteDateDateEdit.Location = New System.Drawing.Point(1075, 59)
        Me.QuoteDateDateEdit.MenuManager = Me.BarManager
        Me.QuoteDateDateEdit.Name = "QuoteDateDateEdit"
        Me.QuoteDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QuoteDateDateEdit.Properties.ReadOnly = True
        Me.QuoteDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.QuoteDateDateEdit.Size = New System.Drawing.Size(155, 20)
        Me.QuoteDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.QuoteDateDateEdit.TabIndex = 18
        '
        'QuoteNumberTextEdit
        '
        Me.QuoteNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuoteNumber", True))
        Me.QuoteNumberTextEdit.Location = New System.Drawing.Point(1075, 29)
        Me.QuoteNumberTextEdit.MenuManager = Me.BarManager
        Me.QuoteNumberTextEdit.Name = "QuoteNumberTextEdit"
        Me.QuoteNumberTextEdit.Properties.ReadOnly = True
        Me.QuoteNumberTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.QuoteNumberTextEdit.StyleController = Me.JobDataLayoutControl
        Me.QuoteNumberTextEdit.TabIndex = 17
        '
        'JobNumberTextEdit
        '
        Me.JobNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobNumber", True))
        Me.JobNumberTextEdit.Location = New System.Drawing.Point(769, 29)
        Me.JobNumberTextEdit.MenuManager = Me.BarManager
        Me.JobNumberTextEdit.Name = "JobNumberTextEdit"
        Me.JobNumberTextEdit.Properties.ReadOnly = True
        Me.JobNumberTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.JobNumberTextEdit.StyleController = Me.JobDataLayoutControl
        Me.JobNumberTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description1", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(150, 59)
        Me.DescriptionTextEdit.MenuManager = Me.BarManager
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Properties.ReadOnly = True
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(466, 20)
        Me.DescriptionTextEdit.StyleController = Me.JobDataLayoutControl
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'gcLobLines
        '
        Me.gcLobLines.DataSource = Me.JobLineListBindingSource
        GridLevelNode1.RelationName = "Level1"
        Me.gcLobLines.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcLobLines.Location = New System.Drawing.Point(5, 185)
        Me.gcLobLines.MainView = Me.gvJobLines
        Me.gcLobLines.MenuManager = Me.BarManager
        Me.gcLobLines.Name = "gcLobLines"
        Me.gcLobLines.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rlkpPart, Me.rlkpWorkCentre, Me.rilkpSupplyScope, Me.rilkpSupplier, Me.rilkpInventoryItem, Me.rilkpSupplierType, Me.riseQuantity, Me.rlkpWorkCentreCategory, Me.risePercent, Me.riseCurrency, Me.RepositoryItemLookUpEdit1, Me.ritePartGroup, Me.riceSelected})
        Me.gcLobLines.Size = New System.Drawing.Size(1231, 446)
        Me.gcLobLines.TabIndex = 4
        Me.gcLobLines.UseEmbeddedNavigator = True
        Me.gcLobLines.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobLines})
        '
        'gvJobLines
        '
        Me.gvJobLines.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWorkCentreCategory, Me.colWorkCentre, Me.colJobLineDate, Me.colOrderDate, Me.colRequiredDate, Me.colGRVDate, Me.colDescription1, Me.colDescription2, Me.colQuoteDescription, Me.colCriteria, Me.colIsProcured, Me.colIsStockDrawn, Me.colQuantity, Me.colQtyOH, Me.colQuantityStock, Me.colQuantitySupplier1, Me.colQuantitySupplier2, Me.colEstimatedDuration, Me.colMarkupPercent, Me.colMarkupFactor, Me.colUnitPrice, Me.colTotalPrice, Me.colMeasurement1, Me.colMeasurement2, Me.colMeasurement3, Me.colID, Me.colLineNumber, Me.colPartGroup, Me.colPart, Me.colSupplyScope, Me.colSupplierType, Me.colSupplier1, Me.colSupplier2, Me.colInventoryItem, Me.colNewPrice, Me.colUnitCost, Me.colTotalCost, Me.colUnitSize, Me.colUnitPurchasePrice, Me.colUnitPriceBeforeDiscount, Me.colUnitPriceBeforeMarkup, Me.colLineDiscountPercent, Me.colPurchaseDiscountPercent, Me.colTotalActualCost, Me.colIsRequisitionedGenerated})
        Me.gvJobLines.CustomizationFormBounds = New System.Drawing.Rectangle(808, 418, 216, 185)
        Me.gvJobLines.GridControl = Me.gcLobLines
        Me.gvJobLines.Name = "gvJobLines"
        Me.gvJobLines.OptionsDetail.EnableMasterViewMode = False
        Me.gvJobLines.OptionsDetail.ShowDetailTabs = False
        Me.gvJobLines.OptionsDetail.SmartDetailExpand = False
        Me.gvJobLines.OptionsSelection.MultiSelect = True
        Me.gvJobLines.OptionsView.ColumnAutoWidth = False
        Me.gvJobLines.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvJobLines.OptionsView.ShowFooter = True
        '
        'colWorkCentreCategory
        '
        Me.colWorkCentreCategory.ColumnEdit = Me.rlkpWorkCentreCategory
        Me.colWorkCentreCategory.FieldName = "WorkCentreCategory"
        Me.colWorkCentreCategory.Name = "colWorkCentreCategory"
        Me.colWorkCentreCategory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colWorkCentreCategory.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colWorkCentreCategory.OptionsColumn.ReadOnly = True
        Me.colWorkCentreCategory.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colWorkCentreCategory.Visible = True
        Me.colWorkCentreCategory.VisibleIndex = 3
        Me.colWorkCentreCategory.Width = 175
        '
        'rlkpWorkCentreCategory
        '
        Me.rlkpWorkCentreCategory.AutoHeight = False
        Me.rlkpWorkCentreCategory.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rlkpWorkCentreCategory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rlkpWorkCentreCategory.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rlkpWorkCentreCategory.DataSource = Me.WorkCentreCategoryBindingSource
        Me.rlkpWorkCentreCategory.Name = "rlkpWorkCentreCategory"
        Me.rlkpWorkCentreCategory.NullText = "(Select Work Centre Category...)"
        '
        'WorkCentreCategoryBindingSource
        '
        Me.WorkCentreCategoryBindingSource.DataSource = GetType(UniSource.ShopFloor.API.WorkCentreCategory)
        '
        'colQtyOH
        '
        Me.colQtyOH.Caption = "Qty OH"
        Me.colQtyOH.FieldName = "InventoryItem.QtyFree"
        Me.colQtyOH.Name = "colQtyOH"
        Me.colQtyOH.OptionsColumn.ReadOnly = True
        Me.colQtyOH.Visible = True
        Me.colQtyOH.VisibleIndex = 25
        '
        'colMarkupPercent
        '
        Me.colMarkupPercent.ColumnEdit = Me.risePercent
        Me.colMarkupPercent.DisplayFormat.FormatString = "p"
        Me.colMarkupPercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMarkupPercent.FieldName = "MarkupPercent"
        Me.colMarkupPercent.GroupFormat.FormatString = "p"
        Me.colMarkupPercent.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMarkupPercent.Name = "colMarkupPercent"
        Me.colMarkupPercent.OptionsColumn.ReadOnly = True
        Me.colMarkupPercent.Visible = True
        Me.colMarkupPercent.VisibleIndex = 24
        '
        'risePercent
        '
        Me.risePercent.AutoHeight = False
        Me.risePercent.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.risePercent.DisplayFormat.FormatString = "p"
        Me.risePercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.risePercent.EditFormat.FormatString = "p"
        Me.risePercent.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.risePercent.Mask.EditMask = "p"
        Me.risePercent.Name = "risePercent"
        '
        'colPartGroup
        '
        Me.colPartGroup.Caption = "Part Group"
        Me.colPartGroup.FieldName = "Part.PartGroup"
        Me.colPartGroup.Name = "colPartGroup"
        Me.colPartGroup.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPartGroup.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPartGroup.OptionsColumn.ReadOnly = True
        Me.colPartGroup.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colPartGroup.Visible = True
        Me.colPartGroup.VisibleIndex = 27
        '
        'colNewPrice
        '
        Me.colNewPrice.ColumnEdit = Me.riseCurrency
        Me.colNewPrice.DisplayFormat.FormatString = "c"
        Me.colNewPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNewPrice.FieldName = "NewPrice"
        Me.colNewPrice.GroupFormat.FormatString = "c"
        Me.colNewPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNewPrice.Name = "colNewPrice"
        Me.colNewPrice.OptionsColumn.ReadOnly = True
        Me.colNewPrice.Visible = True
        Me.colNewPrice.VisibleIndex = 19
        '
        'riseCurrency
        '
        Me.riseCurrency.AutoHeight = False
        Me.riseCurrency.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.riseCurrency.DisplayFormat.FormatString = "c"
        Me.riseCurrency.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.riseCurrency.EditFormat.FormatString = "c"
        Me.riseCurrency.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.riseCurrency.Mask.EditMask = "c"
        Me.riseCurrency.Name = "riseCurrency"
        '
        'colUnitCost
        '
        Me.colUnitCost.ColumnEdit = Me.riseCurrency
        Me.colUnitCost.DisplayFormat.FormatString = "c"
        Me.colUnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitCost.FieldName = "UnitCost"
        Me.colUnitCost.GroupFormat.FormatString = "c"
        Me.colUnitCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitCost.Name = "colUnitCost"
        Me.colUnitCost.OptionsColumn.ReadOnly = True
        Me.colUnitCost.Visible = True
        Me.colUnitCost.VisibleIndex = 20
        '
        'colTotalCost
        '
        Me.colTotalCost.DisplayFormat.FormatString = "c"
        Me.colTotalCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.GroupFormat.FormatString = "c"
        Me.colTotalCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.OptionsColumn.ReadOnly = True
        Me.colTotalCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCost", "{0:c2}")})
        Me.colTotalCost.Visible = True
        Me.colTotalCost.VisibleIndex = 23
        '
        'colUnitSize
        '
        Me.colUnitSize.ColumnEdit = Me.riseQuantity
        Me.colUnitSize.FieldName = "UnitSize"
        Me.colUnitSize.Name = "colUnitSize"
        Me.colUnitSize.OptionsColumn.ReadOnly = True
        Me.colUnitSize.Visible = True
        Me.colUnitSize.VisibleIndex = 9
        '
        'colUnitPurchasePrice
        '
        Me.colUnitPurchasePrice.DisplayFormat.FormatString = "c"
        Me.colUnitPurchasePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPurchasePrice.FieldName = "UnitPurchasePrice"
        Me.colUnitPurchasePrice.GroupFormat.FormatString = "c"
        Me.colUnitPurchasePrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPurchasePrice.Name = "colUnitPurchasePrice"
        Me.colUnitPurchasePrice.OptionsColumn.ReadOnly = True
        Me.colUnitPurchasePrice.Visible = True
        Me.colUnitPurchasePrice.VisibleIndex = 22
        '
        'colUnitPriceBeforeDiscount
        '
        Me.colUnitPriceBeforeDiscount.DisplayFormat.FormatString = "c"
        Me.colUnitPriceBeforeDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPriceBeforeDiscount.FieldName = "UnitPriceBeforeDiscount"
        Me.colUnitPriceBeforeDiscount.GroupFormat.FormatString = "c"
        Me.colUnitPriceBeforeDiscount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPriceBeforeDiscount.Name = "colUnitPriceBeforeDiscount"
        Me.colUnitPriceBeforeDiscount.OptionsColumn.ReadOnly = True
        '
        'colUnitPriceBeforeMarkup
        '
        Me.colUnitPriceBeforeMarkup.DisplayFormat.FormatString = "c"
        Me.colUnitPriceBeforeMarkup.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPriceBeforeMarkup.FieldName = "UnitPriceBeforeMarkup"
        Me.colUnitPriceBeforeMarkup.GroupFormat.FormatString = "c"
        Me.colUnitPriceBeforeMarkup.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPriceBeforeMarkup.Name = "colUnitPriceBeforeMarkup"
        Me.colUnitPriceBeforeMarkup.OptionsColumn.ReadOnly = True
        Me.colUnitPriceBeforeMarkup.Width = 137
        '
        'colLineDiscountPercent
        '
        Me.colLineDiscountPercent.ColumnEdit = Me.risePercent
        Me.colLineDiscountPercent.FieldName = "LineDiscountPercent"
        Me.colLineDiscountPercent.Name = "colLineDiscountPercent"
        Me.colLineDiscountPercent.OptionsColumn.ReadOnly = True
        Me.colLineDiscountPercent.Visible = True
        Me.colLineDiscountPercent.VisibleIndex = 17
        '
        'colPurchaseDiscountPercent
        '
        Me.colPurchaseDiscountPercent.ColumnEdit = Me.risePercent
        Me.colPurchaseDiscountPercent.FieldName = "PurchaseDiscountPercent"
        Me.colPurchaseDiscountPercent.Name = "colPurchaseDiscountPercent"
        Me.colPurchaseDiscountPercent.OptionsColumn.ReadOnly = True
        Me.colPurchaseDiscountPercent.Visible = True
        Me.colPurchaseDiscountPercent.VisibleIndex = 21
        '
        'colTotalActualCost
        '
        Me.colTotalActualCost.Caption = "Total Actual Cost"
        Me.colTotalActualCost.DisplayFormat.FormatString = "c"
        Me.colTotalActualCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalActualCost.FieldName = "TotalActualCost"
        Me.colTotalActualCost.GroupFormat.FormatString = "c"
        Me.colTotalActualCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalActualCost.Name = "colTotalActualCost"
        Me.colTotalActualCost.OptionsColumn.ReadOnly = True
        Me.colTotalActualCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalActualCost", "{0:c2}")})
        Me.colTotalActualCost.Visible = True
        Me.colTotalActualCost.VisibleIndex = 26
        '
        'colIsRequisitionedGenerated
        '
        Me.colIsRequisitionedGenerated.Caption = "Printed Requisition"
        Me.colIsRequisitionedGenerated.FieldName = "IsRequisitionedGenerated"
        Me.colIsRequisitionedGenerated.Name = "colIsRequisitionedGenerated"
        Me.colIsRequisitionedGenerated.OptionsColumn.ReadOnly = True
        Me.colIsRequisitionedGenerated.Visible = True
        Me.colIsRequisitionedGenerated.VisibleIndex = 1
        Me.colIsRequisitionedGenerated.Width = 123
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'ritePartGroup
        '
        Me.ritePartGroup.AutoHeight = False
        Me.ritePartGroup.Name = "ritePartGroup"
        '
        'riceSelected
        '
        Me.riceSelected.AutoHeight = False
        Me.riceSelected.Name = "riceSelected"
        Me.riceSelected.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'CancelledDateDateEdit
        '
        Me.CancelledDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CancelledDate", True))
        Me.CancelledDateDateEdit.EditValue = Nothing
        Me.CancelledDateDateEdit.Location = New System.Drawing.Point(125, 444)
        Me.CancelledDateDateEdit.MenuManager = Me.BarManager
        Me.CancelledDateDateEdit.Name = "CancelledDateDateEdit"
        Me.CancelledDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CancelledDateDateEdit.Properties.ReadOnly = True
        Me.CancelledDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CancelledDateDateEdit.Size = New System.Drawing.Size(1083, 20)
        Me.CancelledDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.CancelledDateDateEdit.TabIndex = 33
        '
        'ValidityDaysTextEdit
        '
        Me.ValidityDaysTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidityDays", True))
        Me.ValidityDaysTextEdit.Location = New System.Drawing.Point(125, 484)
        Me.ValidityDaysTextEdit.MenuManager = Me.BarManager
        Me.ValidityDaysTextEdit.Name = "ValidityDaysTextEdit"
        Me.ValidityDaysTextEdit.Properties.ReadOnly = True
        Me.ValidityDaysTextEdit.Size = New System.Drawing.Size(1083, 20)
        Me.ValidityDaysTextEdit.StyleController = Me.JobDataLayoutControl
        Me.ValidityDaysTextEdit.TabIndex = 38
        '
        'DeliveryDaysTextEdit
        '
        Me.DeliveryDaysTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DeliveryDays", True))
        Me.DeliveryDaysTextEdit.Location = New System.Drawing.Point(125, 484)
        Me.DeliveryDaysTextEdit.MenuManager = Me.BarManager
        Me.DeliveryDaysTextEdit.Name = "DeliveryDaysTextEdit"
        Me.DeliveryDaysTextEdit.Properties.ReadOnly = True
        Me.DeliveryDaysTextEdit.Size = New System.Drawing.Size(1083, 20)
        Me.DeliveryDaysTextEdit.StyleController = Me.JobDataLayoutControl
        Me.DeliveryDaysTextEdit.TabIndex = 39
        '
        'NewPriceSpinEdit
        '
        Me.NewPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "NewPrice", True))
        Me.NewPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NewPriceSpinEdit.Location = New System.Drawing.Point(125, 444)
        Me.NewPriceSpinEdit.MenuManager = Me.BarManager
        Me.NewPriceSpinEdit.Name = "NewPriceSpinEdit"
        Me.NewPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.NewPriceSpinEdit.Properties.ReadOnly = True
        Me.NewPriceSpinEdit.Size = New System.Drawing.Size(1083, 20)
        Me.NewPriceSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.NewPriceSpinEdit.TabIndex = 62
        '
        'WarrantyTextEdit
        '
        Me.WarrantyTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Warranty", True))
        Me.WarrantyTextEdit.Location = New System.Drawing.Point(125, 474)
        Me.WarrantyTextEdit.MenuManager = Me.BarManager
        Me.WarrantyTextEdit.Name = "WarrantyTextEdit"
        Me.WarrantyTextEdit.Properties.ReadOnly = True
        Me.WarrantyTextEdit.Size = New System.Drawing.Size(1083, 20)
        Me.WarrantyTextEdit.StyleController = Me.JobDataLayoutControl
        Me.WarrantyTextEdit.TabIndex = 63
        '
        'CancelReasonTextEdit
        '
        Me.CancelReasonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CancelReason", True))
        Me.CancelReasonTextEdit.Location = New System.Drawing.Point(125, 534)
        Me.CancelReasonTextEdit.MenuManager = Me.BarManager
        Me.CancelReasonTextEdit.Name = "CancelReasonTextEdit"
        Me.CancelReasonTextEdit.Properties.ReadOnly = True
        Me.CancelReasonTextEdit.Size = New System.Drawing.Size(1083, 20)
        Me.CancelReasonTextEdit.StyleController = Me.JobDataLayoutControl
        Me.CancelReasonTextEdit.TabIndex = 64
        '
        'QuoteCommentsTextEdit
        '
        Me.QuoteCommentsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuoteComments", True))
        Me.QuoteCommentsTextEdit.Location = New System.Drawing.Point(125, 534)
        Me.QuoteCommentsTextEdit.MenuManager = Me.BarManager
        Me.QuoteCommentsTextEdit.Name = "QuoteCommentsTextEdit"
        Me.QuoteCommentsTextEdit.Properties.ReadOnly = True
        Me.QuoteCommentsTextEdit.Size = New System.Drawing.Size(1083, 20)
        Me.QuoteCommentsTextEdit.StyleController = Me.JobDataLayoutControl
        Me.QuoteCommentsTextEdit.TabIndex = 65
        '
        'DrawingTextEdit
        '
        Me.DrawingTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Drawing", True))
        Me.DrawingTextEdit.Location = New System.Drawing.Point(125, 564)
        Me.DrawingTextEdit.MenuManager = Me.BarManager
        Me.DrawingTextEdit.Name = "DrawingTextEdit"
        Me.DrawingTextEdit.Properties.ReadOnly = True
        Me.DrawingTextEdit.Size = New System.Drawing.Size(1083, 20)
        Me.DrawingTextEdit.StyleController = Me.JobDataLayoutControl
        Me.DrawingTextEdit.TabIndex = 72
        '
        'JobTemplateTextEdit
        '
        Me.JobTemplateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobTemplate", True))
        Me.JobTemplateTextEdit.Location = New System.Drawing.Point(125, 594)
        Me.JobTemplateTextEdit.MenuManager = Me.BarManager
        Me.JobTemplateTextEdit.Name = "JobTemplateTextEdit"
        Me.JobTemplateTextEdit.Properties.ReadOnly = True
        Me.JobTemplateTextEdit.Size = New System.Drawing.Size(1083, 20)
        Me.JobTemplateTextEdit.StyleController = Me.JobDataLayoutControl
        Me.JobTemplateTextEdit.TabIndex = 79
        '
        'QuoteAgentTextEdit
        '
        Me.QuoteAgentTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuoteAgent", True))
        Me.QuoteAgentTextEdit.Location = New System.Drawing.Point(148, 185)
        Me.QuoteAgentTextEdit.MenuManager = Me.BarManager
        Me.QuoteAgentTextEdit.Name = "QuoteAgentTextEdit"
        Me.QuoteAgentTextEdit.Size = New System.Drawing.Size(1071, 20)
        Me.QuoteAgentTextEdit.StyleController = Me.JobDataLayoutControl
        Me.QuoteAgentTextEdit.TabIndex = 81
        '
        'JobDeliveriesTextEdit
        '
        Me.JobDeliveriesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobDeliveries", True))
        Me.JobDeliveriesTextEdit.Location = New System.Drawing.Point(148, 616)
        Me.JobDeliveriesTextEdit.MenuManager = Me.BarManager
        Me.JobDeliveriesTextEdit.Name = "JobDeliveriesTextEdit"
        Me.JobDeliveriesTextEdit.Size = New System.Drawing.Size(1071, 20)
        Me.JobDeliveriesTextEdit.StyleController = Me.JobDataLayoutControl
        Me.JobDeliveriesTextEdit.TabIndex = 100
        '
        'PurchaseOrdersTextEdit
        '
        Me.PurchaseOrdersTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PurchaseOrders", True))
        Me.PurchaseOrdersTextEdit.Location = New System.Drawing.Point(148, 576)
        Me.PurchaseOrdersTextEdit.MenuManager = Me.BarManager
        Me.PurchaseOrdersTextEdit.Name = "PurchaseOrdersTextEdit"
        Me.PurchaseOrdersTextEdit.Size = New System.Drawing.Size(1071, 20)
        Me.PurchaseOrdersTextEdit.StyleController = Me.JobDataLayoutControl
        Me.PurchaseOrdersTextEdit.TabIndex = 104
        '
        'JobDateDateEdit
        '
        Me.JobDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobDate", True))
        Me.JobDateDateEdit.EditValue = Nothing
        Me.JobDateDateEdit.Location = New System.Drawing.Point(769, 59)
        Me.JobDateDateEdit.MenuManager = Me.BarManager
        Me.JobDateDateEdit.Name = "JobDateDateEdit"
        Me.JobDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JobDateDateEdit.Properties.Mask.EditMask = ""
        Me.JobDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.JobDateDateEdit.Properties.ReadOnly = True
        Me.JobDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.JobDateDateEdit.Size = New System.Drawing.Size(153, 20)
        Me.JobDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.JobDateDateEdit.TabIndex = 6
        '
        'CustomerTextEdit
        '
        Me.CustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Customer", True))
        Me.CustomerTextEdit.Location = New System.Drawing.Point(150, 29)
        Me.CustomerTextEdit.MenuManager = Me.BarManager
        Me.CustomerTextEdit.Name = "CustomerTextEdit"
        Me.CustomerTextEdit.Properties.ReadOnly = True
        Me.CustomerTextEdit.Size = New System.Drawing.Size(466, 20)
        Me.CustomerTextEdit.StyleController = Me.JobDataLayoutControl
        Me.CustomerTextEdit.TabIndex = 15
        '
        'NextStageTextEdit
        '
        Me.NextStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "NextStage", True))
        Me.NextStageTextEdit.Location = New System.Drawing.Point(150, 89)
        Me.NextStageTextEdit.MenuManager = Me.BarManager
        Me.NextStageTextEdit.Name = "NextStageTextEdit"
        Me.NextStageTextEdit.Properties.ReadOnly = True
        Me.NextStageTextEdit.Size = New System.Drawing.Size(461, 20)
        Me.NextStageTextEdit.StyleController = Me.JobDataLayoutControl
        Me.NextStageTextEdit.TabIndex = 21
        '
        'PreviousStageTextEdit
        '
        Me.PreviousStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PreviousStage", True))
        Me.PreviousStageTextEdit.Location = New System.Drawing.Point(150, 119)
        Me.PreviousStageTextEdit.MenuManager = Me.BarManager
        Me.PreviousStageTextEdit.Name = "PreviousStageTextEdit"
        Me.PreviousStageTextEdit.Properties.ReadOnly = True
        Me.PreviousStageTextEdit.Size = New System.Drawing.Size(461, 20)
        Me.PreviousStageTextEdit.StyleController = Me.JobDataLayoutControl
        Me.PreviousStageTextEdit.TabIndex = 22
        '
        'JobTypeTextEdit
        '
        Me.JobTypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobType", True))
        Me.JobTypeTextEdit.Location = New System.Drawing.Point(150, 29)
        Me.JobTypeTextEdit.MenuManager = Me.BarManager
        Me.JobTypeTextEdit.Name = "JobTypeTextEdit"
        Me.JobTypeTextEdit.Properties.ReadOnly = True
        Me.JobTypeTextEdit.Size = New System.Drawing.Size(463, 20)
        Me.JobTypeTextEdit.StyleController = Me.JobDataLayoutControl
        Me.JobTypeTextEdit.TabIndex = 23
        '
        'QuantitySpinEdit
        '
        Me.QuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Quantity", True))
        Me.QuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.QuantitySpinEdit.Location = New System.Drawing.Point(150, 89)
        Me.QuantitySpinEdit.MenuManager = Me.BarManager
        Me.QuantitySpinEdit.Name = "QuantitySpinEdit"
        Me.QuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.QuantitySpinEdit.Properties.ReadOnly = True
        Me.QuantitySpinEdit.Size = New System.Drawing.Size(155, 20)
        Me.QuantitySpinEdit.StyleController = Me.JobDataLayoutControl
        Me.QuantitySpinEdit.TabIndex = 26
        '
        'QuantityDeliveredSpinEdit
        '
        Me.QuantityDeliveredSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuantityDelivered", True))
        Me.QuantityDeliveredSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.QuantityDeliveredSpinEdit.Location = New System.Drawing.Point(458, 89)
        Me.QuantityDeliveredSpinEdit.MenuManager = Me.BarManager
        Me.QuantityDeliveredSpinEdit.Name = "QuantityDeliveredSpinEdit"
        Me.QuantityDeliveredSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.QuantityDeliveredSpinEdit.Properties.ReadOnly = True
        Me.QuantityDeliveredSpinEdit.Size = New System.Drawing.Size(155, 20)
        Me.QuantityDeliveredSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.QuantityDeliveredSpinEdit.TabIndex = 27
        '
        'DeliveryNumberTextEdit
        '
        Me.DeliveryNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DeliveryNumber", True))
        Me.DeliveryNumberTextEdit.Location = New System.Drawing.Point(1075, 89)
        Me.DeliveryNumberTextEdit.MenuManager = Me.BarManager
        Me.DeliveryNumberTextEdit.Name = "DeliveryNumberTextEdit"
        Me.DeliveryNumberTextEdit.Properties.ReadOnly = True
        Me.DeliveryNumberTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.DeliveryNumberTextEdit.StyleController = Me.JobDataLayoutControl
        Me.DeliveryNumberTextEdit.TabIndex = 28
        '
        'OrderNumberTextEdit
        '
        Me.OrderNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OrderNumber", True))
        Me.OrderNumberTextEdit.Location = New System.Drawing.Point(769, 89)
        Me.OrderNumberTextEdit.MenuManager = Me.BarManager
        Me.OrderNumberTextEdit.Name = "OrderNumberTextEdit"
        Me.OrderNumberTextEdit.Properties.ReadOnly = True
        Me.OrderNumberTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.OrderNumberTextEdit.StyleController = Me.JobDataLayoutControl
        Me.OrderNumberTextEdit.TabIndex = 29
        '
        'InvoiceDateDateEdit
        '
        Me.InvoiceDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "InvoiceDate", True))
        Me.InvoiceDateDateEdit.EditValue = Nothing
        Me.InvoiceDateDateEdit.Location = New System.Drawing.Point(1075, 119)
        Me.InvoiceDateDateEdit.MenuManager = Me.BarManager
        Me.InvoiceDateDateEdit.Name = "InvoiceDateDateEdit"
        Me.InvoiceDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceDateDateEdit.Properties.ReadOnly = True
        Me.InvoiceDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.InvoiceDateDateEdit.Size = New System.Drawing.Size(155, 20)
        Me.InvoiceDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.InvoiceDateDateEdit.TabIndex = 30
        '
        'AcceptedDateDateEdit
        '
        Me.AcceptedDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "AcceptedDate", True))
        Me.AcceptedDateDateEdit.EditValue = Nothing
        Me.AcceptedDateDateEdit.Location = New System.Drawing.Point(769, 119)
        Me.AcceptedDateDateEdit.MenuManager = Me.BarManager
        Me.AcceptedDateDateEdit.Name = "AcceptedDateDateEdit"
        Me.AcceptedDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AcceptedDateDateEdit.Properties.ReadOnly = True
        Me.AcceptedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AcceptedDateDateEdit.Size = New System.Drawing.Size(153, 20)
        Me.AcceptedDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.AcceptedDateDateEdit.TabIndex = 31
        '
        'EstimatedDeliveryDateDateEdit
        '
        Me.EstimatedDeliveryDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EstimatedDeliveryDate", True))
        Me.EstimatedDeliveryDateDateEdit.EditValue = Nothing
        Me.EstimatedDeliveryDateDateEdit.Location = New System.Drawing.Point(150, 119)
        Me.EstimatedDeliveryDateDateEdit.MenuManager = Me.BarManager
        Me.EstimatedDeliveryDateDateEdit.Name = "EstimatedDeliveryDateDateEdit"
        Me.EstimatedDeliveryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EstimatedDeliveryDateDateEdit.Properties.ReadOnly = True
        Me.EstimatedDeliveryDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EstimatedDeliveryDateDateEdit.Size = New System.Drawing.Size(157, 20)
        Me.EstimatedDeliveryDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.EstimatedDeliveryDateDateEdit.TabIndex = 32
        '
        'IsBreakdownCheckEdit
        '
        Me.IsBreakdownCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsBreakdown", True))
        Me.IsBreakdownCheckEdit.Location = New System.Drawing.Point(621, 29)
        Me.IsBreakdownCheckEdit.MenuManager = Me.BarManager
        Me.IsBreakdownCheckEdit.Name = "IsBreakdownCheckEdit"
        Me.IsBreakdownCheckEdit.Properties.Caption = "Is Breakdown"
        Me.IsBreakdownCheckEdit.Properties.ReadOnly = True
        Me.IsBreakdownCheckEdit.Size = New System.Drawing.Size(145, 19)
        Me.IsBreakdownCheckEdit.StyleController = Me.JobDataLayoutControl
        Me.IsBreakdownCheckEdit.TabIndex = 41
        '
        'IsApprovedCheckEdit
        '
        Me.IsApprovedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsApproved", True))
        Me.IsApprovedCheckEdit.Location = New System.Drawing.Point(930, 29)
        Me.IsApprovedCheckEdit.MenuManager = Me.BarManager
        Me.IsApprovedCheckEdit.Name = "IsApprovedCheckEdit"
        Me.IsApprovedCheckEdit.Properties.Caption = "Is Approved"
        Me.IsApprovedCheckEdit.Properties.ReadOnly = True
        Me.IsApprovedCheckEdit.Size = New System.Drawing.Size(145, 19)
        Me.IsApprovedCheckEdit.StyleController = Me.JobDataLayoutControl
        Me.IsApprovedCheckEdit.TabIndex = 42
        '
        'IsStockDrawnCheckEdit
        '
        Me.IsStockDrawnCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsStockDrawn", True))
        Me.IsStockDrawnCheckEdit.Location = New System.Drawing.Point(1085, 29)
        Me.IsStockDrawnCheckEdit.MenuManager = Me.BarManager
        Me.IsStockDrawnCheckEdit.Name = "IsStockDrawnCheckEdit"
        Me.IsStockDrawnCheckEdit.Properties.Caption = "Is Stock Drawn"
        Me.IsStockDrawnCheckEdit.Properties.ReadOnly = True
        Me.IsStockDrawnCheckEdit.Size = New System.Drawing.Size(145, 19)
        Me.IsStockDrawnCheckEdit.StyleController = Me.JobDataLayoutControl
        Me.IsStockDrawnCheckEdit.TabIndex = 44
        '
        'AccountNameTextEdit
        '
        Me.AccountNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "AccountName", True))
        Me.AccountNameTextEdit.Location = New System.Drawing.Point(150, 29)
        Me.AccountNameTextEdit.MenuManager = Me.BarManager
        Me.AccountNameTextEdit.Name = "AccountNameTextEdit"
        Me.AccountNameTextEdit.Properties.ReadOnly = True
        Me.AccountNameTextEdit.Size = New System.Drawing.Size(1080, 20)
        Me.AccountNameTextEdit.StyleController = Me.JobDataLayoutControl
        Me.AccountNameTextEdit.TabIndex = 53
        '
        'ContactNameTextEdit
        '
        Me.ContactNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ContactName", True))
        Me.ContactNameTextEdit.Location = New System.Drawing.Point(150, 59)
        Me.ContactNameTextEdit.MenuManager = Me.BarManager
        Me.ContactNameTextEdit.Name = "ContactNameTextEdit"
        Me.ContactNameTextEdit.Properties.ReadOnly = True
        Me.ContactNameTextEdit.Size = New System.Drawing.Size(463, 20)
        Me.ContactNameTextEdit.StyleController = Me.JobDataLayoutControl
        Me.ContactNameTextEdit.TabIndex = 54
        '
        'TelephoneTextEdit
        '
        Me.TelephoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Telephone", True))
        Me.TelephoneTextEdit.Location = New System.Drawing.Point(150, 89)
        Me.TelephoneTextEdit.MenuManager = Me.BarManager
        Me.TelephoneTextEdit.Name = "TelephoneTextEdit"
        Me.TelephoneTextEdit.Properties.ReadOnly = True
        Me.TelephoneTextEdit.Size = New System.Drawing.Size(463, 20)
        Me.TelephoneTextEdit.StyleController = Me.JobDataLayoutControl
        Me.TelephoneTextEdit.TabIndex = 55
        '
        'IsProcuredCheckEdit
        '
        Me.IsProcuredCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsProcured", True))
        Me.IsProcuredCheckEdit.Location = New System.Drawing.Point(776, 29)
        Me.IsProcuredCheckEdit.MenuManager = Me.BarManager
        Me.IsProcuredCheckEdit.Name = "IsProcuredCheckEdit"
        Me.IsProcuredCheckEdit.Properties.Caption = "Is Procured"
        Me.IsProcuredCheckEdit.Properties.ReadOnly = True
        Me.IsProcuredCheckEdit.Size = New System.Drawing.Size(144, 19)
        Me.IsProcuredCheckEdit.StyleController = Me.JobDataLayoutControl
        Me.IsProcuredCheckEdit.TabIndex = 43
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(766, 59)
        Me.EmailTextEdit.MenuManager = Me.BarManager
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Properties.ReadOnly = True
        Me.EmailTextEdit.Size = New System.Drawing.Size(464, 20)
        Me.EmailTextEdit.StyleController = Me.JobDataLayoutControl
        Me.EmailTextEdit.TabIndex = 56
        '
        'FaxTextEdit
        '
        Me.FaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Fax", True))
        Me.FaxTextEdit.Location = New System.Drawing.Point(766, 89)
        Me.FaxTextEdit.MenuManager = Me.BarManager
        Me.FaxTextEdit.Name = "FaxTextEdit"
        Me.FaxTextEdit.Properties.ReadOnly = True
        Me.FaxTextEdit.Size = New System.Drawing.Size(464, 20)
        Me.FaxTextEdit.StyleController = Me.JobDataLayoutControl
        Me.FaxTextEdit.TabIndex = 57
        '
        'Description2TextEdit
        '
        Me.Description2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description2", True))
        Me.Description2TextEdit.Location = New System.Drawing.Point(150, 89)
        Me.Description2TextEdit.MenuManager = Me.BarManager
        Me.Description2TextEdit.Name = "Description2TextEdit"
        Me.Description2TextEdit.Properties.ReadOnly = True
        Me.Description2TextEdit.Size = New System.Drawing.Size(466, 20)
        Me.Description2TextEdit.StyleController = Me.JobDataLayoutControl
        Me.Description2TextEdit.TabIndex = 58
        '
        'DiscountPercentSpinEdit
        '
        Me.DiscountPercentSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DiscountPercent", True))
        Me.DiscountPercentSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DiscountPercentSpinEdit.Location = New System.Drawing.Point(150, 119)
        Me.DiscountPercentSpinEdit.MenuManager = Me.BarManager
        Me.DiscountPercentSpinEdit.Name = "DiscountPercentSpinEdit"
        Me.DiscountPercentSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DiscountPercentSpinEdit.Properties.ReadOnly = True
        Me.DiscountPercentSpinEdit.Size = New System.Drawing.Size(155, 20)
        Me.DiscountPercentSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.DiscountPercentSpinEdit.TabIndex = 60
        '
        'DiscountAmountSpinEdit
        '
        Me.DiscountAmountSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DiscountAmount", True))
        Me.DiscountAmountSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DiscountAmountSpinEdit.Location = New System.Drawing.Point(458, 119)
        Me.DiscountAmountSpinEdit.MenuManager = Me.BarManager
        Me.DiscountAmountSpinEdit.Name = "DiscountAmountSpinEdit"
        Me.DiscountAmountSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DiscountAmountSpinEdit.Properties.ReadOnly = True
        Me.DiscountAmountSpinEdit.Size = New System.Drawing.Size(155, 20)
        Me.DiscountAmountSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.DiscountAmountSpinEdit.TabIndex = 61
        '
        'StateTextEdit
        '
        Me.StateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "State", True))
        Me.StateTextEdit.Location = New System.Drawing.Point(150, 29)
        Me.StateTextEdit.MenuManager = Me.BarManager
        Me.StateTextEdit.Name = "StateTextEdit"
        Me.StateTextEdit.Properties.ReadOnly = True
        Me.StateTextEdit.Size = New System.Drawing.Size(461, 20)
        Me.StateTextEdit.StyleController = Me.JobDataLayoutControl
        Me.StateTextEdit.TabIndex = 67
        '
        'JobStageTextEdit
        '
        Me.JobStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobStage", True))
        Me.JobStageTextEdit.Location = New System.Drawing.Point(150, 59)
        Me.JobStageTextEdit.MenuManager = Me.BarManager
        Me.JobStageTextEdit.Name = "JobStageTextEdit"
        Me.JobStageTextEdit.Properties.ReadOnly = True
        Me.JobStageTextEdit.Size = New System.Drawing.Size(461, 20)
        Me.JobStageTextEdit.StyleController = Me.JobDataLayoutControl
        Me.JobStageTextEdit.TabIndex = 71
        '
        'GenerationTextEdit
        '
        Me.GenerationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Generation", True))
        Me.GenerationTextEdit.Location = New System.Drawing.Point(766, 119)
        Me.GenerationTextEdit.MenuManager = Me.BarManager
        Me.GenerationTextEdit.Name = "GenerationTextEdit"
        Me.GenerationTextEdit.Properties.ReadOnly = True
        Me.GenerationTextEdit.Size = New System.Drawing.Size(464, 20)
        Me.GenerationTextEdit.StyleController = Me.JobDataLayoutControl
        Me.GenerationTextEdit.TabIndex = 73
        '
        'MakeTextEdit
        '
        Me.MakeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Make", True))
        Me.MakeTextEdit.Location = New System.Drawing.Point(766, 29)
        Me.MakeTextEdit.MenuManager = Me.BarManager
        Me.MakeTextEdit.Name = "MakeTextEdit"
        Me.MakeTextEdit.Properties.ReadOnly = True
        Me.MakeTextEdit.Size = New System.Drawing.Size(464, 20)
        Me.MakeTextEdit.StyleController = Me.JobDataLayoutControl
        Me.MakeTextEdit.TabIndex = 74
        '
        'ModelTextEdit
        '
        Me.ModelTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Model", True))
        Me.ModelTextEdit.Location = New System.Drawing.Point(766, 59)
        Me.ModelTextEdit.MenuManager = Me.BarManager
        Me.ModelTextEdit.Name = "ModelTextEdit"
        Me.ModelTextEdit.Properties.ReadOnly = True
        Me.ModelTextEdit.Size = New System.Drawing.Size(464, 20)
        Me.ModelTextEdit.StyleController = Me.JobDataLayoutControl
        Me.ModelTextEdit.TabIndex = 75
        '
        'FunctionTextEdit
        '
        Me.FunctionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Function", True))
        Me.FunctionTextEdit.Location = New System.Drawing.Point(766, 89)
        Me.FunctionTextEdit.MenuManager = Me.BarManager
        Me.FunctionTextEdit.Name = "FunctionTextEdit"
        Me.FunctionTextEdit.Properties.ReadOnly = True
        Me.FunctionTextEdit.Size = New System.Drawing.Size(464, 20)
        Me.FunctionTextEdit.StyleController = Me.JobDataLayoutControl
        Me.FunctionTextEdit.TabIndex = 76
        '
        'JobCategoryTextEdit
        '
        Me.JobCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobCategory", True))
        Me.JobCategoryTextEdit.Location = New System.Drawing.Point(150, 59)
        Me.JobCategoryTextEdit.MenuManager = Me.BarManager
        Me.JobCategoryTextEdit.Name = "JobCategoryTextEdit"
        Me.JobCategoryTextEdit.Properties.ReadOnly = True
        Me.JobCategoryTextEdit.Size = New System.Drawing.Size(463, 20)
        Me.JobCategoryTextEdit.StyleController = Me.JobDataLayoutControl
        Me.JobCategoryTextEdit.TabIndex = 77
        '
        'WorkCentreCategoryTextEdit
        '
        Me.WorkCentreCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "WorkCentreCategory", True))
        Me.WorkCentreCategoryTextEdit.Location = New System.Drawing.Point(150, 119)
        Me.WorkCentreCategoryTextEdit.MenuManager = Me.BarManager
        Me.WorkCentreCategoryTextEdit.Name = "WorkCentreCategoryTextEdit"
        Me.WorkCentreCategoryTextEdit.Properties.ReadOnly = True
        Me.WorkCentreCategoryTextEdit.Size = New System.Drawing.Size(463, 20)
        Me.WorkCentreCategoryTextEdit.StyleController = Me.JobDataLayoutControl
        Me.WorkCentreCategoryTextEdit.TabIndex = 78
        '
        'CostCentreTextEdit
        '
        Me.CostCentreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CostCentre", True))
        Me.CostCentreTextEdit.Location = New System.Drawing.Point(150, 89)
        Me.CostCentreTextEdit.MenuManager = Me.BarManager
        Me.CostCentreTextEdit.Name = "CostCentreTextEdit"
        Me.CostCentreTextEdit.Properties.ReadOnly = True
        Me.CostCentreTextEdit.Size = New System.Drawing.Size(463, 20)
        Me.CostCentreTextEdit.StyleController = Me.JobDataLayoutControl
        Me.CostCentreTextEdit.TabIndex = 80
        '
        'UnitCostTextEdit
        '
        Me.UnitCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UnitCost", True))
        Me.UnitCostTextEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UnitCostTextEdit.Location = New System.Drawing.Point(766, 29)
        Me.UnitCostTextEdit.MenuManager = Me.BarManager
        Me.UnitCostTextEdit.Name = "UnitCostTextEdit"
        Me.UnitCostTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitCostTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.UnitCostTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitCostTextEdit.Properties.EditFormat.FormatString = "c"
        Me.UnitCostTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitCostTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.UnitCostTextEdit.Properties.ReadOnly = True
        Me.UnitCostTextEdit.Size = New System.Drawing.Size(464, 20)
        Me.UnitCostTextEdit.StyleController = Me.JobDataLayoutControl
        Me.UnitCostTextEdit.TabIndex = 24
        '
        'TotalCostTextEdit
        '
        Me.TotalCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "TotalCost", True))
        Me.TotalCostTextEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TotalCostTextEdit.Location = New System.Drawing.Point(766, 59)
        Me.TotalCostTextEdit.MenuManager = Me.BarManager
        Me.TotalCostTextEdit.Name = "TotalCostTextEdit"
        Me.TotalCostTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TotalCostTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.TotalCostTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalCostTextEdit.Properties.EditFormat.FormatString = "c"
        Me.TotalCostTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalCostTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TotalCostTextEdit.Properties.ReadOnly = True
        Me.TotalCostTextEdit.Size = New System.Drawing.Size(464, 20)
        Me.TotalCostTextEdit.StyleController = Me.JobDataLayoutControl
        Me.TotalCostTextEdit.TabIndex = 25
        '
        'OrderTotalTextEdit
        '
        Me.OrderTotalTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OrderTotal", True))
        Me.OrderTotalTextEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.OrderTotalTextEdit.Location = New System.Drawing.Point(460, 119)
        Me.OrderTotalTextEdit.MenuManager = Me.BarManager
        Me.OrderTotalTextEdit.Name = "OrderTotalTextEdit"
        Me.OrderTotalTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderTotalTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.OrderTotalTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OrderTotalTextEdit.Properties.EditFormat.FormatString = "c"
        Me.OrderTotalTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OrderTotalTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.OrderTotalTextEdit.Properties.ReadOnly = True
        Me.OrderTotalTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.OrderTotalTextEdit.StyleController = Me.JobDataLayoutControl
        Me.OrderTotalTextEdit.TabIndex = 59
        '
        'AdditionalFieldsLayoutControlInternal
        '
        Me.AdditionalFieldsLayoutControlInternal.Location = New System.Drawing.Point(7, 29)
        Me.AdditionalFieldsLayoutControlInternal.MinimumSize = New System.Drawing.Size(1195, 51)
        Me.AdditionalFieldsLayoutControlInternal.Name = "AdditionalFieldsLayoutControlInternal"
        Me.AdditionalFieldsLayoutControlInternal.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(0, 277, 250, 350)
        Me.AdditionalFieldsLayoutControlInternal.OptionsView.UseSkinIndents = False
        Me.AdditionalFieldsLayoutControlInternal.Root = Me.AdditionalFieldsRoot
        Me.AdditionalFieldsLayoutControlInternal.Size = New System.Drawing.Size(1223, 140)
        Me.AdditionalFieldsLayoutControlInternal.TabIndex = 16
        Me.AdditionalFieldsLayoutControlInternal.Text = "Additional Fields"
        '
        'AdditionalFieldsRoot
        '
        Me.AdditionalFieldsRoot.CustomizationFormText = "AdditionalFieldsRoot"
        Me.AdditionalFieldsRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.AdditionalFieldsRoot.GroupBordersVisible = False
        Me.AdditionalFieldsRoot.Location = New System.Drawing.Point(0, 0)
        Me.AdditionalFieldsRoot.Name = "AdditionalFieldsRoot"
        Me.AdditionalFieldsRoot.OptionsItemText.TextToControlDistance = 5
        Me.AdditionalFieldsRoot.Size = New System.Drawing.Size(1223, 140)
        Me.AdditionalFieldsRoot.Text = "AdditionalFieldsRoot"
        Me.AdditionalFieldsRoot.TextVisible = False
        '
        'SubContractorReferenceTextEdit
        '
        Me.SubContractorReferenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "SubContractorReference", True))
        Me.SubContractorReferenceTextEdit.Location = New System.Drawing.Point(150, 59)
        Me.SubContractorReferenceTextEdit.MenuManager = Me.BarManager
        Me.SubContractorReferenceTextEdit.Name = "SubContractorReferenceTextEdit"
        Me.SubContractorReferenceTextEdit.Properties.ReadOnly = True
        Me.SubContractorReferenceTextEdit.Size = New System.Drawing.Size(204, 20)
        Me.SubContractorReferenceTextEdit.StyleController = Me.JobDataLayoutControl
        Me.SubContractorReferenceTextEdit.TabIndex = 97
        '
        'SubContractorQuotedPriceSpinEdit
        '
        Me.SubContractorQuotedPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "SubContractorQuotedPrice", True))
        Me.SubContractorQuotedPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SubContractorQuotedPriceSpinEdit.Location = New System.Drawing.Point(150, 89)
        Me.SubContractorQuotedPriceSpinEdit.MenuManager = Me.BarManager
        Me.SubContractorQuotedPriceSpinEdit.Name = "SubContractorQuotedPriceSpinEdit"
        Me.SubContractorQuotedPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SubContractorQuotedPriceSpinEdit.Properties.DisplayFormat.FormatString = "c"
        Me.SubContractorQuotedPriceSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SubContractorQuotedPriceSpinEdit.Properties.EditFormat.FormatString = "c"
        Me.SubContractorQuotedPriceSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SubContractorQuotedPriceSpinEdit.Properties.ReadOnly = True
        Me.SubContractorQuotedPriceSpinEdit.Size = New System.Drawing.Size(204, 20)
        Me.SubContractorQuotedPriceSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.SubContractorQuotedPriceSpinEdit.TabIndex = 98
        '
        'SubContractorTextEdit
        '
        Me.SubContractorTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "SubContractor", True))
        Me.SubContractorTextEdit.Location = New System.Drawing.Point(150, 29)
        Me.SubContractorTextEdit.MenuManager = Me.BarManager
        Me.SubContractorTextEdit.Name = "SubContractorTextEdit"
        Me.SubContractorTextEdit.Properties.ReadOnly = True
        Me.SubContractorTextEdit.Size = New System.Drawing.Size(204, 20)
        Me.SubContractorTextEdit.StyleController = Me.JobDataLayoutControl
        Me.SubContractorTextEdit.TabIndex = 99
        '
        'ItemForValidityDays
        '
        Me.ItemForValidityDays.Control = Me.ValidityDaysTextEdit
        Me.ItemForValidityDays.CustomizationFormText = "Validity Days"
        Me.ItemForValidityDays.Location = New System.Drawing.Point(0, 0)
        Me.ItemForValidityDays.Name = "ItemForValidityDays"
        Me.ItemForValidityDays.Size = New System.Drawing.Size(1213, 30)
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
        Me.ItemForDeliveryDays.Size = New System.Drawing.Size(1213, 30)
        Me.ItemForDeliveryDays.Text = "Delivery Days"
        Me.ItemForDeliveryDays.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForDeliveryDays.TextToControlDistance = 5
        '
        'ItemForNewPrice
        '
        Me.ItemForNewPrice.Control = Me.NewPriceSpinEdit
        Me.ItemForNewPrice.CustomizationFormText = "New Price"
        Me.ItemForNewPrice.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNewPrice.Name = "ItemForNewPrice"
        Me.ItemForNewPrice.Size = New System.Drawing.Size(1213, 30)
        Me.ItemForNewPrice.Text = "New Price"
        Me.ItemForNewPrice.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForNewPrice.TextToControlDistance = 5
        '
        'ItemForCancelledDate
        '
        Me.ItemForCancelledDate.Control = Me.CancelledDateDateEdit
        Me.ItemForCancelledDate.CustomizationFormText = "Cancelled Date"
        Me.ItemForCancelledDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCancelledDate.Name = "ItemForCancelledDate"
        Me.ItemForCancelledDate.Size = New System.Drawing.Size(1213, 30)
        Me.ItemForCancelledDate.Text = "Cancelled Date"
        Me.ItemForCancelledDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCancelledDate.TextToControlDistance = 5
        '
        'ItemForWarranty
        '
        Me.ItemForWarranty.Control = Me.WarrantyTextEdit
        Me.ItemForWarranty.CustomizationFormText = "Warranty"
        Me.ItemForWarranty.Location = New System.Drawing.Point(0, 0)
        Me.ItemForWarranty.Name = "ItemForWarranty"
        Me.ItemForWarranty.Size = New System.Drawing.Size(1213, 30)
        Me.ItemForWarranty.Text = "Warranty"
        Me.ItemForWarranty.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForWarranty.TextToControlDistance = 5
        '
        'ItemForQuoteComments
        '
        Me.ItemForQuoteComments.Control = Me.QuoteCommentsTextEdit
        Me.ItemForQuoteComments.CustomizationFormText = "Quote Comments"
        Me.ItemForQuoteComments.Location = New System.Drawing.Point(0, 30)
        Me.ItemForQuoteComments.Name = "ItemForQuoteComments"
        Me.ItemForQuoteComments.Size = New System.Drawing.Size(1213, 30)
        Me.ItemForQuoteComments.Text = "Quote Comments"
        Me.ItemForQuoteComments.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForQuoteComments.TextToControlDistance = 5
        '
        'ItemForCancelReason
        '
        Me.ItemForCancelReason.Control = Me.CancelReasonTextEdit
        Me.ItemForCancelReason.CustomizationFormText = "Cancel Reason"
        Me.ItemForCancelReason.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCancelReason.Name = "ItemForCancelReason"
        Me.ItemForCancelReason.Size = New System.Drawing.Size(1213, 30)
        Me.ItemForCancelReason.Text = "Cancel Reason"
        Me.ItemForCancelReason.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCancelReason.TextToControlDistance = 5
        '
        'ItemForDrawing
        '
        Me.ItemForDrawing.Control = Me.DrawingTextEdit
        Me.ItemForDrawing.CustomizationFormText = "Drawing"
        Me.ItemForDrawing.Location = New System.Drawing.Point(0, 0)
        Me.ItemForDrawing.Name = "ItemForDrawing"
        Me.ItemForDrawing.Size = New System.Drawing.Size(1213, 30)
        Me.ItemForDrawing.Text = "Drawing"
        Me.ItemForDrawing.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForDrawing.TextToControlDistance = 5
        '
        'ItemForJobTemplate
        '
        Me.ItemForJobTemplate.Control = Me.JobTemplateTextEdit
        Me.ItemForJobTemplate.CustomizationFormText = "Job Template"
        Me.ItemForJobTemplate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobTemplate.Name = "ItemForJobTemplate"
        Me.ItemForJobTemplate.Size = New System.Drawing.Size(1213, 30)
        Me.ItemForJobTemplate.Text = "Job Template"
        Me.ItemForJobTemplate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobTemplate.TextToControlDistance = 5
        '
        'ItemForQuoteAgent
        '
        Me.ItemForQuoteAgent.Control = Me.QuoteAgentTextEdit
        Me.ItemForQuoteAgent.CustomizationFormText = "Quote Agent"
        Me.ItemForQuoteAgent.Location = New System.Drawing.Point(0, 0)
        Me.ItemForQuoteAgent.Name = "ItemForQuoteAgent"
        Me.ItemForQuoteAgent.Size = New System.Drawing.Size(1224, 30)
        Me.ItemForQuoteAgent.Text = "Quote Agent"
        Me.ItemForQuoteAgent.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForQuoteAgent.TextToControlDistance = 5
        '
        'ItemForPurchaseOrders
        '
        Me.ItemForPurchaseOrders.Control = Me.PurchaseOrdersTextEdit
        Me.ItemForPurchaseOrders.CustomizationFormText = "Purchase Orders"
        Me.ItemForPurchaseOrders.Location = New System.Drawing.Point(0, 120)
        Me.ItemForPurchaseOrders.Name = "ItemForPurchaseOrders"
        Me.ItemForPurchaseOrders.Size = New System.Drawing.Size(1224, 30)
        Me.ItemForPurchaseOrders.Text = "Purchase Orders"
        Me.ItemForPurchaseOrders.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForPurchaseOrders.TextToControlDistance = 5
        '
        'ItemForJobDeliveries
        '
        Me.ItemForJobDeliveries.Control = Me.JobDeliveriesTextEdit
        Me.ItemForJobDeliveries.CustomizationFormText = "Job Deliveries"
        Me.ItemForJobDeliveries.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobDeliveries.Name = "ItemForJobDeliveries"
        Me.ItemForJobDeliveries.Size = New System.Drawing.Size(1224, 30)
        Me.ItemForJobDeliveries.Text = "Job Deliveries"
        Me.ItemForJobDeliveries.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobDeliveries.TextToControlDistance = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1241, 636)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.QuoteLinesLayoutControlItem, Me.TabbedControlGroup1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1241, 636)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'QuoteLinesLayoutControlItem
        '
        Me.QuoteLinesLayoutControlItem.Control = Me.gcLobLines
        Me.QuoteLinesLayoutControlItem.CustomizationFormText = "Quote Lines"
        Me.QuoteLinesLayoutControlItem.Location = New System.Drawing.Point(0, 180)
        Me.QuoteLinesLayoutControlItem.Name = "QuoteLinesLayoutControlItem"
        Me.QuoteLinesLayoutControlItem.Size = New System.Drawing.Size(1241, 456)
        Me.QuoteLinesLayoutControlItem.Text = "Quote Lines"
        Me.QuoteLinesLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top
        Me.QuoteLinesLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
        Me.QuoteLinesLayoutControlItem.TextToControlDistance = 0
        Me.QuoteLinesLayoutControlItem.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.ValuesLayoutControlGroup
        Me.TabbedControlGroup1.SelectedTabPageIndex = 1
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1241, 180)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcgDetails, Me.ValuesLayoutControlGroup, Me.ContactLayoutControlGroup, Me.StatusLayoutControlGroup, Me.CategoryLayoutControlGroup, Me.LayoutControlGroup3, Me.AdditionalFieldsLayoutControlGroup})
        Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
        '
        'ValuesLayoutControlGroup
        '
        Me.ValuesLayoutControlGroup.CustomizationFormText = "Values"
        Me.ValuesLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForTotalPrice, Me.ItemForUnitPrice, Me.ItemForUnitCost, Me.ItemForTotalCost, Me.ItemForQuantity, Me.ItemForQuantityDelivered, Me.ItemForDiscountPercent, Me.ItemForDiscountAmount, Me.ItemForCurrentGP, Me.ItemForExpectedGP, Me.defaultdiscountPercLayoutControlItem})
        Me.ValuesLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.ValuesLayoutControlGroup.Name = "ValuesLayoutControlGroup"
        Me.ValuesLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.ValuesLayoutControlGroup.Size = New System.Drawing.Size(1233, 150)
        Me.ValuesLayoutControlGroup.Text = "Values"
        '
        'ItemForTotalPrice
        '
        Me.ItemForTotalPrice.Control = Me.TotalPriceSpinEdit
        Me.ItemForTotalPrice.CustomizationFormText = "Total Price"
        Me.ItemForTotalPrice.Location = New System.Drawing.Point(0, 30)
        Me.ItemForTotalPrice.Name = "ItemForTotalPrice"
        Me.ItemForTotalPrice.Size = New System.Drawing.Size(616, 30)
        Me.ItemForTotalPrice.Text = "Total Price"
        Me.ItemForTotalPrice.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForTotalPrice.TextToControlDistance = 5
        '
        'ItemForUnitPrice
        '
        Me.ItemForUnitPrice.Control = Me.UnitPriceSpinEdit
        Me.ItemForUnitPrice.CustomizationFormText = "Unit Price"
        Me.ItemForUnitPrice.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUnitPrice.Name = "ItemForUnitPrice"
        Me.ItemForUnitPrice.Size = New System.Drawing.Size(616, 30)
        Me.ItemForUnitPrice.Text = "Unit Price"
        Me.ItemForUnitPrice.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForUnitPrice.TextToControlDistance = 5
        '
        'ItemForUnitCost
        '
        Me.ItemForUnitCost.Control = Me.UnitCostTextEdit
        Me.ItemForUnitCost.CustomizationFormText = "Unit Cost"
        Me.ItemForUnitCost.Location = New System.Drawing.Point(616, 0)
        Me.ItemForUnitCost.Name = "ItemForUnitCost"
        Me.ItemForUnitCost.Size = New System.Drawing.Size(617, 30)
        Me.ItemForUnitCost.Text = "Unit Cost"
        Me.ItemForUnitCost.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForUnitCost.TextToControlDistance = 5
        '
        'ItemForTotalCost
        '
        Me.ItemForTotalCost.Control = Me.TotalCostTextEdit
        Me.ItemForTotalCost.CustomizationFormText = "Total Cost"
        Me.ItemForTotalCost.Location = New System.Drawing.Point(616, 30)
        Me.ItemForTotalCost.Name = "ItemForTotalCost"
        Me.ItemForTotalCost.Size = New System.Drawing.Size(617, 30)
        Me.ItemForTotalCost.Text = "Total Cost"
        Me.ItemForTotalCost.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForTotalCost.TextToControlDistance = 5
        '
        'ItemForQuantity
        '
        Me.ItemForQuantity.Control = Me.QuantitySpinEdit
        Me.ItemForQuantity.CustomizationFormText = "Quantity"
        Me.ItemForQuantity.Location = New System.Drawing.Point(0, 60)
        Me.ItemForQuantity.Name = "ItemForQuantity"
        Me.ItemForQuantity.Size = New System.Drawing.Size(308, 30)
        Me.ItemForQuantity.Text = "Quantity"
        Me.ItemForQuantity.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForQuantity.TextToControlDistance = 5
        '
        'ItemForQuantityDelivered
        '
        Me.ItemForQuantityDelivered.Control = Me.QuantityDeliveredSpinEdit
        Me.ItemForQuantityDelivered.CustomizationFormText = "Quantity Delivered"
        Me.ItemForQuantityDelivered.Location = New System.Drawing.Point(308, 60)
        Me.ItemForQuantityDelivered.Name = "ItemForQuantityDelivered"
        Me.ItemForQuantityDelivered.Size = New System.Drawing.Size(308, 30)
        Me.ItemForQuantityDelivered.Text = "Quantity Delivered"
        Me.ItemForQuantityDelivered.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForQuantityDelivered.TextToControlDistance = 5
        '
        'ItemForDiscountPercent
        '
        Me.ItemForDiscountPercent.Control = Me.DiscountPercentSpinEdit
        Me.ItemForDiscountPercent.CustomizationFormText = "Discount Percent"
        Me.ItemForDiscountPercent.Location = New System.Drawing.Point(0, 90)
        Me.ItemForDiscountPercent.Name = "ItemForDiscountPercent"
        Me.ItemForDiscountPercent.Size = New System.Drawing.Size(308, 30)
        Me.ItemForDiscountPercent.Text = "Discount Percent"
        Me.ItemForDiscountPercent.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForDiscountPercent.TextToControlDistance = 5
        '
        'ItemForDiscountAmount
        '
        Me.ItemForDiscountAmount.Control = Me.DiscountAmountSpinEdit
        Me.ItemForDiscountAmount.CustomizationFormText = "Discount Amount"
        Me.ItemForDiscountAmount.Location = New System.Drawing.Point(308, 90)
        Me.ItemForDiscountAmount.Name = "ItemForDiscountAmount"
        Me.ItemForDiscountAmount.Size = New System.Drawing.Size(308, 60)
        Me.ItemForDiscountAmount.Text = "Discount Amount"
        Me.ItemForDiscountAmount.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForDiscountAmount.TextToControlDistance = 5
        '
        'ItemForCurrentGP
        '
        Me.ItemForCurrentGP.Control = Me.CurrentGPSpinEdit
        Me.ItemForCurrentGP.CustomizationFormText = "Current GP"
        Me.ItemForCurrentGP.Location = New System.Drawing.Point(616, 60)
        Me.ItemForCurrentGP.Name = "ItemForCurrentGP"
        Me.ItemForCurrentGP.Size = New System.Drawing.Size(617, 30)
        Me.ItemForCurrentGP.Text = "Current GP"
        Me.ItemForCurrentGP.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForCurrentGP.TextToControlDistance = 5
        '
        'ItemForExpectedGP
        '
        Me.ItemForExpectedGP.Control = Me.ExpectedGPSpinEdit
        Me.ItemForExpectedGP.CustomizationFormText = "Expected GP"
        Me.ItemForExpectedGP.Location = New System.Drawing.Point(616, 90)
        Me.ItemForExpectedGP.Name = "ItemForExpectedGP"
        Me.ItemForExpectedGP.Size = New System.Drawing.Size(617, 60)
        Me.ItemForExpectedGP.Text = "Expected GP"
        Me.ItemForExpectedGP.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForExpectedGP.TextToControlDistance = 5
        '
        'defaultdiscountPercLayoutControlItem
        '
        Me.defaultdiscountPercLayoutControlItem.Control = Me.defaultDiscountSpinEdit
        Me.defaultdiscountPercLayoutControlItem.CustomizationFormText = "Default Discount %"
        Me.defaultdiscountPercLayoutControlItem.Location = New System.Drawing.Point(0, 120)
        Me.defaultdiscountPercLayoutControlItem.Name = "defaultdiscountPercLayoutControlItem"
        Me.defaultdiscountPercLayoutControlItem.Size = New System.Drawing.Size(308, 30)
        Me.defaultdiscountPercLayoutControlItem.Text = "Default Discount %"
        Me.defaultdiscountPercLayoutControlItem.TextSize = New System.Drawing.Size(138, 13)
        Me.defaultdiscountPercLayoutControlItem.TextToControlDistance = 5
        '
        'lcgDetails
        '
        Me.lcgDetails.CustomizationFormText = "Details"
        Me.lcgDetails.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCustomer, Me.ItemForDescription, Me.ItemForNumber, Me.ItemForJobDate, Me.ItemForQuoteNumber, Me.ItemForQuoteDate, Me.ItemForDescription2, Me.ItemForOrderNumber, Me.ItemForAcceptedDate, Me.ItemForDeliveryNumber, Me.ItemForInvoiceDate, Me.ItemForEstimatedDeliveryDate, Me.ItemForOrderTotal})
        Me.lcgDetails.Location = New System.Drawing.Point(0, 0)
        Me.lcgDetails.Name = "lcgDetails"
        Me.lcgDetails.OptionsItemText.TextToControlDistance = 5
        Me.lcgDetails.Size = New System.Drawing.Size(1233, 150)
        Me.lcgDetails.Text = "Details"
        '
        'ItemForCustomer
        '
        Me.ItemForCustomer.Control = Me.CustomerTextEdit
        Me.ItemForCustomer.CustomizationFormText = "Customer"
        Me.ItemForCustomer.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCustomer.Name = "ItemForCustomer"
        Me.ItemForCustomer.Size = New System.Drawing.Size(619, 30)
        Me.ItemForCustomer.Text = "Customer"
        Me.ItemForCustomer.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForCustomer.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(619, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForNumber
        '
        Me.ItemForNumber.Control = Me.JobNumberTextEdit
        Me.ItemForNumber.CustomizationFormText = "Job Number"
        Me.ItemForNumber.Location = New System.Drawing.Point(619, 0)
        Me.ItemForNumber.Name = "ItemForNumber"
        Me.ItemForNumber.Size = New System.Drawing.Size(306, 30)
        Me.ItemForNumber.Text = "Job Number"
        Me.ItemForNumber.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForNumber.TextToControlDistance = 5
        '
        'ItemForJobDate
        '
        Me.ItemForJobDate.Control = Me.JobDateDateEdit
        Me.ItemForJobDate.CustomizationFormText = "Job Date"
        Me.ItemForJobDate.Location = New System.Drawing.Point(619, 30)
        Me.ItemForJobDate.Name = "ItemForJobDate"
        Me.ItemForJobDate.Size = New System.Drawing.Size(306, 30)
        Me.ItemForJobDate.Text = "Job Date"
        Me.ItemForJobDate.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForJobDate.TextToControlDistance = 5
        '
        'ItemForQuoteNumber
        '
        Me.ItemForQuoteNumber.Control = Me.QuoteNumberTextEdit
        Me.ItemForQuoteNumber.CustomizationFormText = "Quote Number"
        Me.ItemForQuoteNumber.Location = New System.Drawing.Point(925, 0)
        Me.ItemForQuoteNumber.Name = "ItemForQuoteNumber"
        Me.ItemForQuoteNumber.Size = New System.Drawing.Size(308, 30)
        Me.ItemForQuoteNumber.Text = "Quote Number"
        Me.ItemForQuoteNumber.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForQuoteNumber.TextToControlDistance = 5
        '
        'ItemForQuoteDate
        '
        Me.ItemForQuoteDate.Control = Me.QuoteDateDateEdit
        Me.ItemForQuoteDate.CustomizationFormText = "Quote Date"
        Me.ItemForQuoteDate.Location = New System.Drawing.Point(925, 30)
        Me.ItemForQuoteDate.Name = "ItemForQuoteDate"
        Me.ItemForQuoteDate.Size = New System.Drawing.Size(308, 30)
        Me.ItemForQuoteDate.Text = "Quote Date"
        Me.ItemForQuoteDate.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForQuoteDate.TextToControlDistance = 5
        '
        'ItemForDescription2
        '
        Me.ItemForDescription2.Control = Me.Description2TextEdit
        Me.ItemForDescription2.CustomizationFormText = "Description2"
        Me.ItemForDescription2.Location = New System.Drawing.Point(0, 60)
        Me.ItemForDescription2.Name = "ItemForDescription2"
        Me.ItemForDescription2.Size = New System.Drawing.Size(619, 30)
        Me.ItemForDescription2.Text = "Description2"
        Me.ItemForDescription2.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForDescription2.TextToControlDistance = 5
        '
        'ItemForOrderNumber
        '
        Me.ItemForOrderNumber.Control = Me.OrderNumberTextEdit
        Me.ItemForOrderNumber.CustomizationFormText = "Order Number"
        Me.ItemForOrderNumber.Location = New System.Drawing.Point(619, 60)
        Me.ItemForOrderNumber.Name = "ItemForOrderNumber"
        Me.ItemForOrderNumber.Size = New System.Drawing.Size(306, 30)
        Me.ItemForOrderNumber.Text = "Order Number"
        Me.ItemForOrderNumber.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForOrderNumber.TextToControlDistance = 5
        '
        'ItemForAcceptedDate
        '
        Me.ItemForAcceptedDate.Control = Me.AcceptedDateDateEdit
        Me.ItemForAcceptedDate.CustomizationFormText = "Accepted Date"
        Me.ItemForAcceptedDate.Location = New System.Drawing.Point(619, 90)
        Me.ItemForAcceptedDate.Name = "ItemForAcceptedDate"
        Me.ItemForAcceptedDate.Size = New System.Drawing.Size(306, 60)
        Me.ItemForAcceptedDate.Text = "Accepted Date"
        Me.ItemForAcceptedDate.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForAcceptedDate.TextToControlDistance = 5
        '
        'ItemForDeliveryNumber
        '
        Me.ItemForDeliveryNumber.Control = Me.DeliveryNumberTextEdit
        Me.ItemForDeliveryNumber.CustomizationFormText = "Delivery Number"
        Me.ItemForDeliveryNumber.Location = New System.Drawing.Point(925, 60)
        Me.ItemForDeliveryNumber.Name = "ItemForDeliveryNumber"
        Me.ItemForDeliveryNumber.Size = New System.Drawing.Size(308, 30)
        Me.ItemForDeliveryNumber.Text = "Delivery Number"
        Me.ItemForDeliveryNumber.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForDeliveryNumber.TextToControlDistance = 5
        '
        'ItemForInvoiceDate
        '
        Me.ItemForInvoiceDate.Control = Me.InvoiceDateDateEdit
        Me.ItemForInvoiceDate.CustomizationFormText = "Invoice Date"
        Me.ItemForInvoiceDate.Location = New System.Drawing.Point(925, 90)
        Me.ItemForInvoiceDate.Name = "ItemForInvoiceDate"
        Me.ItemForInvoiceDate.Size = New System.Drawing.Size(308, 60)
        Me.ItemForInvoiceDate.Text = "Invoice Date"
        Me.ItemForInvoiceDate.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForInvoiceDate.TextToControlDistance = 5
        '
        'ItemForEstimatedDeliveryDate
        '
        Me.ItemForEstimatedDeliveryDate.Control = Me.EstimatedDeliveryDateDateEdit
        Me.ItemForEstimatedDeliveryDate.CustomizationFormText = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.Location = New System.Drawing.Point(0, 90)
        Me.ItemForEstimatedDeliveryDate.Name = "ItemForEstimatedDeliveryDate"
        Me.ItemForEstimatedDeliveryDate.Size = New System.Drawing.Size(310, 60)
        Me.ItemForEstimatedDeliveryDate.Text = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForEstimatedDeliveryDate.TextToControlDistance = 5
        '
        'ItemForOrderTotal
        '
        Me.ItemForOrderTotal.Control = Me.OrderTotalTextEdit
        Me.ItemForOrderTotal.CustomizationFormText = "Order Total"
        Me.ItemForOrderTotal.Location = New System.Drawing.Point(310, 90)
        Me.ItemForOrderTotal.Name = "ItemForOrderTotal"
        Me.ItemForOrderTotal.Size = New System.Drawing.Size(309, 60)
        Me.ItemForOrderTotal.Text = "Order Total"
        Me.ItemForOrderTotal.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForOrderTotal.TextToControlDistance = 5
        '
        'ContactLayoutControlGroup
        '
        Me.ContactLayoutControlGroup.CustomizationFormText = "Contact"
        Me.ContactLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForAccountName, Me.ItemForContactName, Me.ItemForTelephone, Me.ItemForEmail, Me.ItemForFax})
        Me.ContactLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.ContactLayoutControlGroup.Name = "ContactLayoutControlGroup"
        Me.ContactLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.ContactLayoutControlGroup.Size = New System.Drawing.Size(1233, 150)
        Me.ContactLayoutControlGroup.Text = "Contact"
        '
        'ItemForAccountName
        '
        Me.ItemForAccountName.Control = Me.AccountNameTextEdit
        Me.ItemForAccountName.CustomizationFormText = "Account Name"
        Me.ItemForAccountName.Location = New System.Drawing.Point(0, 0)
        Me.ItemForAccountName.Name = "ItemForAccountName"
        Me.ItemForAccountName.Size = New System.Drawing.Size(1233, 30)
        Me.ItemForAccountName.Text = "Account Name"
        Me.ItemForAccountName.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForAccountName.TextToControlDistance = 5
        '
        'ItemForContactName
        '
        Me.ItemForContactName.Control = Me.ContactNameTextEdit
        Me.ItemForContactName.CustomizationFormText = "Contact Name"
        Me.ItemForContactName.Location = New System.Drawing.Point(0, 30)
        Me.ItemForContactName.Name = "ItemForContactName"
        Me.ItemForContactName.Size = New System.Drawing.Size(616, 30)
        Me.ItemForContactName.Text = "Contact Name"
        Me.ItemForContactName.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForContactName.TextToControlDistance = 5
        '
        'ItemForTelephone
        '
        Me.ItemForTelephone.Control = Me.TelephoneTextEdit
        Me.ItemForTelephone.CustomizationFormText = "Telephone"
        Me.ItemForTelephone.Location = New System.Drawing.Point(0, 60)
        Me.ItemForTelephone.Name = "ItemForTelephone"
        Me.ItemForTelephone.Size = New System.Drawing.Size(616, 90)
        Me.ItemForTelephone.Text = "Telephone"
        Me.ItemForTelephone.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForTelephone.TextToControlDistance = 5
        '
        'ItemForEmail
        '
        Me.ItemForEmail.Control = Me.EmailTextEdit
        Me.ItemForEmail.CustomizationFormText = "Email"
        Me.ItemForEmail.Location = New System.Drawing.Point(616, 30)
        Me.ItemForEmail.Name = "ItemForEmail"
        Me.ItemForEmail.Size = New System.Drawing.Size(617, 30)
        Me.ItemForEmail.Text = "Email"
        Me.ItemForEmail.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForEmail.TextToControlDistance = 5
        '
        'ItemForFax
        '
        Me.ItemForFax.Control = Me.FaxTextEdit
        Me.ItemForFax.CustomizationFormText = "Fax"
        Me.ItemForFax.Location = New System.Drawing.Point(616, 60)
        Me.ItemForFax.Name = "ItemForFax"
        Me.ItemForFax.Size = New System.Drawing.Size(617, 90)
        Me.ItemForFax.Text = "Fax"
        Me.ItemForFax.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForFax.TextToControlDistance = 5
        '
        'StatusLayoutControlGroup
        '
        Me.StatusLayoutControlGroup.CustomizationFormText = "Status"
        Me.StatusLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForNextStage, Me.ItemForIsBreakdown, Me.ItemForIsApproved, Me.ItemForState, Me.ItemForJobStage, Me.ItemForIsProcured, Me.ItemForIsStockDrawn, Me.ItemForPreviousStage})
        Me.StatusLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.StatusLayoutControlGroup.Name = "StatusLayoutControlGroup"
        Me.StatusLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.StatusLayoutControlGroup.Size = New System.Drawing.Size(1233, 150)
        Me.StatusLayoutControlGroup.Text = "Status"
        '
        'ItemForNextStage
        '
        Me.ItemForNextStage.Control = Me.NextStageTextEdit
        Me.ItemForNextStage.CustomizationFormText = "Next Stage"
        Me.ItemForNextStage.Location = New System.Drawing.Point(0, 60)
        Me.ItemForNextStage.Name = "ItemForNextStage"
        Me.ItemForNextStage.Size = New System.Drawing.Size(614, 30)
        Me.ItemForNextStage.Text = "Next Stage"
        Me.ItemForNextStage.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForNextStage.TextToControlDistance = 5
        '
        'ItemForIsBreakdown
        '
        Me.ItemForIsBreakdown.Control = Me.IsBreakdownCheckEdit
        Me.ItemForIsBreakdown.CustomizationFormText = "Is Breakdown"
        Me.ItemForIsBreakdown.Location = New System.Drawing.Point(614, 0)
        Me.ItemForIsBreakdown.Name = "ItemForIsBreakdown"
        Me.ItemForIsBreakdown.Size = New System.Drawing.Size(155, 150)
        Me.ItemForIsBreakdown.Text = "Is Breakdown"
        Me.ItemForIsBreakdown.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsBreakdown.TextToControlDistance = 0
        Me.ItemForIsBreakdown.TextVisible = False
        '
        'ItemForIsApproved
        '
        Me.ItemForIsApproved.Control = Me.IsApprovedCheckEdit
        Me.ItemForIsApproved.CustomizationFormText = "Is Approved"
        Me.ItemForIsApproved.Location = New System.Drawing.Point(923, 0)
        Me.ItemForIsApproved.Name = "ItemForIsApproved"
        Me.ItemForIsApproved.Size = New System.Drawing.Size(155, 150)
        Me.ItemForIsApproved.Text = "Is Approved"
        Me.ItemForIsApproved.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsApproved.TextToControlDistance = 0
        Me.ItemForIsApproved.TextVisible = False
        '
        'ItemForState
        '
        Me.ItemForState.Control = Me.StateTextEdit
        Me.ItemForState.CustomizationFormText = "State"
        Me.ItemForState.Location = New System.Drawing.Point(0, 0)
        Me.ItemForState.Name = "ItemForState"
        Me.ItemForState.Size = New System.Drawing.Size(614, 30)
        Me.ItemForState.Text = "State"
        Me.ItemForState.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForState.TextToControlDistance = 5
        '
        'ItemForJobStage
        '
        Me.ItemForJobStage.Control = Me.JobStageTextEdit
        Me.ItemForJobStage.CustomizationFormText = "Job Stage"
        Me.ItemForJobStage.Location = New System.Drawing.Point(0, 30)
        Me.ItemForJobStage.Name = "ItemForJobStage"
        Me.ItemForJobStage.Size = New System.Drawing.Size(614, 30)
        Me.ItemForJobStage.Text = "Job Stage"
        Me.ItemForJobStage.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForJobStage.TextToControlDistance = 5
        '
        'ItemForIsProcured
        '
        Me.ItemForIsProcured.Control = Me.IsProcuredCheckEdit
        Me.ItemForIsProcured.CustomizationFormText = "Is Procured"
        Me.ItemForIsProcured.Location = New System.Drawing.Point(769, 0)
        Me.ItemForIsProcured.Name = "ItemForIsProcured"
        Me.ItemForIsProcured.Size = New System.Drawing.Size(154, 150)
        Me.ItemForIsProcured.Text = "Is Procured"
        Me.ItemForIsProcured.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsProcured.TextToControlDistance = 0
        Me.ItemForIsProcured.TextVisible = False
        '
        'ItemForIsStockDrawn
        '
        Me.ItemForIsStockDrawn.Control = Me.IsStockDrawnCheckEdit
        Me.ItemForIsStockDrawn.CustomizationFormText = "Is Stock Drawn"
        Me.ItemForIsStockDrawn.Location = New System.Drawing.Point(1078, 0)
        Me.ItemForIsStockDrawn.Name = "ItemForIsStockDrawn"
        Me.ItemForIsStockDrawn.Size = New System.Drawing.Size(155, 150)
        Me.ItemForIsStockDrawn.Text = "Is Stock Drawn"
        Me.ItemForIsStockDrawn.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsStockDrawn.TextToControlDistance = 0
        Me.ItemForIsStockDrawn.TextVisible = False
        '
        'ItemForPreviousStage
        '
        Me.ItemForPreviousStage.Control = Me.PreviousStageTextEdit
        Me.ItemForPreviousStage.CustomizationFormText = "Previous Stage"
        Me.ItemForPreviousStage.Location = New System.Drawing.Point(0, 90)
        Me.ItemForPreviousStage.Name = "ItemForPreviousStage"
        Me.ItemForPreviousStage.Size = New System.Drawing.Size(614, 60)
        Me.ItemForPreviousStage.Text = "Previous Stage"
        Me.ItemForPreviousStage.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForPreviousStage.TextToControlDistance = 5
        '
        'CategoryLayoutControlGroup
        '
        Me.CategoryLayoutControlGroup.CustomizationFormText = "Category"
        Me.CategoryLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForMake, Me.ItemForFunction, Me.ItemForCostCentre, Me.ItemForWorkCentreCategory, Me.ItemForGeneration, Me.ItemForJobType, Me.ItemForJobCategory, Me.ItemForModel})
        Me.CategoryLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.CategoryLayoutControlGroup.Name = "CategoryLayoutControlGroup"
        Me.CategoryLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.CategoryLayoutControlGroup.Size = New System.Drawing.Size(1233, 150)
        Me.CategoryLayoutControlGroup.Text = "Category"
        '
        'ItemForMake
        '
        Me.ItemForMake.Control = Me.MakeTextEdit
        Me.ItemForMake.CustomizationFormText = "Make"
        Me.ItemForMake.Location = New System.Drawing.Point(616, 0)
        Me.ItemForMake.Name = "ItemForMake"
        Me.ItemForMake.Size = New System.Drawing.Size(617, 30)
        Me.ItemForMake.Text = "Make"
        Me.ItemForMake.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForMake.TextToControlDistance = 5
        '
        'ItemForFunction
        '
        Me.ItemForFunction.Control = Me.FunctionTextEdit
        Me.ItemForFunction.CustomizationFormText = "Function"
        Me.ItemForFunction.Location = New System.Drawing.Point(616, 60)
        Me.ItemForFunction.Name = "ItemForFunction"
        Me.ItemForFunction.Size = New System.Drawing.Size(617, 30)
        Me.ItemForFunction.Text = "Function"
        Me.ItemForFunction.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForFunction.TextToControlDistance = 5
        '
        'ItemForCostCentre
        '
        Me.ItemForCostCentre.Control = Me.CostCentreTextEdit
        Me.ItemForCostCentre.CustomizationFormText = "Cost Centre"
        Me.ItemForCostCentre.Location = New System.Drawing.Point(0, 60)
        Me.ItemForCostCentre.Name = "ItemForCostCentre"
        Me.ItemForCostCentre.Size = New System.Drawing.Size(616, 30)
        Me.ItemForCostCentre.Text = "Cost Centre"
        Me.ItemForCostCentre.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForCostCentre.TextToControlDistance = 5
        '
        'ItemForWorkCentreCategory
        '
        Me.ItemForWorkCentreCategory.Control = Me.WorkCentreCategoryTextEdit
        Me.ItemForWorkCentreCategory.CustomizationFormText = "Work Centre Category"
        Me.ItemForWorkCentreCategory.Location = New System.Drawing.Point(0, 90)
        Me.ItemForWorkCentreCategory.Name = "ItemForWorkCentreCategory"
        Me.ItemForWorkCentreCategory.Size = New System.Drawing.Size(616, 60)
        Me.ItemForWorkCentreCategory.Text = "Work Centre Category"
        Me.ItemForWorkCentreCategory.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForWorkCentreCategory.TextToControlDistance = 5
        '
        'ItemForGeneration
        '
        Me.ItemForGeneration.Control = Me.GenerationTextEdit
        Me.ItemForGeneration.CustomizationFormText = "Generation"
        Me.ItemForGeneration.Location = New System.Drawing.Point(616, 90)
        Me.ItemForGeneration.Name = "ItemForGeneration"
        Me.ItemForGeneration.Size = New System.Drawing.Size(617, 60)
        Me.ItemForGeneration.Text = "Generation"
        Me.ItemForGeneration.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForGeneration.TextToControlDistance = 5
        '
        'ItemForJobType
        '
        Me.ItemForJobType.Control = Me.JobTypeTextEdit
        Me.ItemForJobType.CustomizationFormText = "Job Type"
        Me.ItemForJobType.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobType.Name = "ItemForJobType"
        Me.ItemForJobType.Size = New System.Drawing.Size(616, 30)
        Me.ItemForJobType.Text = "Job Type"
        Me.ItemForJobType.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForJobType.TextToControlDistance = 5
        '
        'ItemForJobCategory
        '
        Me.ItemForJobCategory.Control = Me.JobCategoryTextEdit
        Me.ItemForJobCategory.CustomizationFormText = "Job Category"
        Me.ItemForJobCategory.Location = New System.Drawing.Point(0, 30)
        Me.ItemForJobCategory.Name = "ItemForJobCategory"
        Me.ItemForJobCategory.Size = New System.Drawing.Size(616, 30)
        Me.ItemForJobCategory.Text = "Job Category"
        Me.ItemForJobCategory.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForJobCategory.TextToControlDistance = 5
        '
        'ItemForModel
        '
        Me.ItemForModel.Control = Me.ModelTextEdit
        Me.ItemForModel.CustomizationFormText = "Model"
        Me.ItemForModel.Location = New System.Drawing.Point(616, 30)
        Me.ItemForModel.Name = "ItemForModel"
        Me.ItemForModel.Size = New System.Drawing.Size(617, 30)
        Me.ItemForModel.Text = "Model"
        Me.ItemForModel.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForModel.TextToControlDistance = 5
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Sub-Contractor"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForSubContractorQuotedPrice, Me.SimpleSeparator1, Me.ItemForSubContractorReference, Me.ItemForSubContractor})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1233, 150)
        Me.LayoutControlGroup3.Text = "Sub-Contractor"
        '
        'ItemForSubContractorQuotedPrice
        '
        Me.ItemForSubContractorQuotedPrice.Control = Me.SubContractorQuotedPriceSpinEdit
        Me.ItemForSubContractorQuotedPrice.CustomizationFormText = "Sub Contractor Quoted Price"
        Me.ItemForSubContractorQuotedPrice.Location = New System.Drawing.Point(0, 60)
        Me.ItemForSubContractorQuotedPrice.Name = "ItemForSubContractorQuotedPrice"
        Me.ItemForSubContractorQuotedPrice.Size = New System.Drawing.Size(357, 90)
        Me.ItemForSubContractorQuotedPrice.Text = "Sub Contractor Quoted Price"
        Me.ItemForSubContractorQuotedPrice.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForSubContractorQuotedPrice.TextToControlDistance = 5
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(357, 0)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(876, 150)
        Me.SimpleSeparator1.Text = "SimpleSeparator1"
        '
        'ItemForSubContractorReference
        '
        Me.ItemForSubContractorReference.Control = Me.SubContractorReferenceTextEdit
        Me.ItemForSubContractorReference.CustomizationFormText = "Sub Contractor Reference"
        Me.ItemForSubContractorReference.Location = New System.Drawing.Point(0, 30)
        Me.ItemForSubContractorReference.Name = "ItemForSubContractorReference"
        Me.ItemForSubContractorReference.Size = New System.Drawing.Size(357, 30)
        Me.ItemForSubContractorReference.Text = "Sub Contractor Reference"
        Me.ItemForSubContractorReference.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForSubContractorReference.TextToControlDistance = 5
        '
        'ItemForSubContractor
        '
        Me.ItemForSubContractor.Control = Me.SubContractorTextEdit
        Me.ItemForSubContractor.CustomizationFormText = "Sub Contractor"
        Me.ItemForSubContractor.Location = New System.Drawing.Point(0, 0)
        Me.ItemForSubContractor.Name = "ItemForSubContractor"
        Me.ItemForSubContractor.Size = New System.Drawing.Size(357, 30)
        Me.ItemForSubContractor.Text = "Sub Contractor"
        Me.ItemForSubContractor.TextSize = New System.Drawing.Size(138, 13)
        Me.ItemForSubContractor.TextToControlDistance = 5
        '
        'AdditionalFieldsLayoutControlGroup
        '
        Me.AdditionalFieldsLayoutControlGroup.CustomizationFormText = "Additional Fields"
        Me.AdditionalFieldsLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.AdditionalFieldsLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.AdditionalFieldsLayoutControlGroup.Name = "AdditionalFieldsLayoutControlGroup"
        Me.AdditionalFieldsLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.AdditionalFieldsLayoutControlGroup.Size = New System.Drawing.Size(1233, 150)
        Me.AdditionalFieldsLayoutControlGroup.Text = "Additional Fields"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.AdditionalFieldsLayoutControlInternal
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1233, 150)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'GridPopupMenu
        '
        Me.GridPopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAddLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCancel), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportGrid, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiResetFormDefaults, True)})
        Me.GridPopupMenu.Manager = Me.BarManager
        Me.GridPopupMenu.Name = "GridPopupMenu"
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Job)
        '
        'xaeJobQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 705)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = True
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "xaeJobQuote"
        Me.Text = "xaeJobQuote"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.grpGroup, 0)
        Me.Controls.SetChildIndex(Me.btSave, 0)
        Me.Controls.SetChildIndex(Me.btCancel, 0)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rlkpPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rlkpWorkCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseLineNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpSupplyScope, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyScopeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpSupplierType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpInventoryItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JobDataLayoutControl.ResumeLayout(False)
        CType(Me.defaultDiscountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedGPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentGPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcLobLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rlkpWorkCentreCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.risePercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ritePartGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riceSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelledDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelledDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidityDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarrantyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteCommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTemplateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteAgentTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDeliveriesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrdersTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityDeliveredSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcceptedDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcceptedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsBreakdownCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsApprovedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsStockDrawnCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelephoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsProcuredCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountPercentSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountAmountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FunctionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCentreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTotalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdditionalFieldsLayoutControlInternal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdditionalFieldsRoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubContractorReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubContractorQuotedPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubContractorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidityDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNewPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCancelledDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWarranty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteComments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCancelReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteAgent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDeliveries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteLinesLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValuesLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTotalPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuantityDelivered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDiscountPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDiscountAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCurrentGP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForExpectedGP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.defaultdiscountPercLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAcceptedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAccountName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForContactName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTelephone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsBreakdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsApproved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsProcured, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsStockDrawn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPreviousStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFunction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCostCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForGeneration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSubContractorQuotedPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSubContractorReference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSubContractor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdditionalFieldsLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rlkpPart As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rlkpWorkCentre As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents riseQuantity As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents rilkpSupplyScope As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rilkpSupplierType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rilkpSupplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rilkpInventoryItem As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents JobLineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkCentreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplyScopeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendorClassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAddLine As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditLine As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiReports As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiResetFormDefaults As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents JobDataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents JobNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcLobLines As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobLines As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobLineDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGRVDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCriteria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsProcured As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsStockDrawn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantityStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantitySupplier1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantitySupplier2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMarkupFactor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeasurement1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeasurement2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeasurement3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplyScope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplier1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplier2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents lcgDetails As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCustomer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AdditionalFieldsLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents AdditionalFieldsLayoutControlInternal As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents AdditionalFieldsRoot As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridPopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents riseLineNumber As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents QuoteLinesLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colWorkCentreCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rlkpWorkCentreCategory As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents WorkCentreCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colNewPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riseCurrency As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colUnitCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPurchasePrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPriceBeforeDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPriceBeforeMarkup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineDiscountPercent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents risePercent As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colPurchaseDiscountPercent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsiImport As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiImportJob As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImportTemplate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents QuoteDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents QuoteNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForQuoteNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuoteDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TotalPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents UnitPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ItemForUnitPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTotalPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents NextStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PreviousStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobTypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents QuantityDeliveredSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DeliveryNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrderNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InvoiceDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AcceptedDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EstimatedDeliveryDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CancelledDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ValidityDaysTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliveryDaysTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsBreakdownCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsApprovedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsStockDrawnCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AccountNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContactNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelephoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsProcuredCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Description2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DiscountPercentSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DiscountAmountSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NewPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WarrantyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CancelReasonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoteCommentsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StateTextEdit As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents UnitCostTextEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TotalCostTextEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OrderTotalTextEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ItemForValidityDays As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeliveryDays As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNewPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCancelledDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWarranty As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuoteComments As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCancelReason As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDrawing As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobTemplate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CategoryLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForMake As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFunction As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCostCentre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWorkCentreCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForGeneration As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForModel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrderNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAcceptedDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeliveryNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForInvoiceDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedDeliveryDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrderTotal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ValuesLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForUnitCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTotalCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuantity As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuantityDelivered As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDiscountPercent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDiscountAmount As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ContactLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForAccountName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForContactName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTelephone As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEmail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFax As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents StatusLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForNextStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsBreakdown As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsApproved As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForState As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsProcured As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsStockDrawn As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPreviousStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colMarkupPercent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QuoteAgentTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SubContractorReferenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SubContractorQuotedPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SubContractorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobDeliveriesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PurchaseOrdersTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForQuoteAgent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPurchaseOrders As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDeliveries As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForSubContractorQuotedPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents ItemForSubContractor As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForSubContractorReference As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colQtyOH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiImportQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colTotalActualCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExpectedGPSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CurrentGPSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ItemForCurrentGP As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForExpectedGP As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ritePartGroup As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPartGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents defaultDiscountSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents defaultdiscountPercLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bbiUpdateLinesDiscount As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnCreateRequisition As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colIsRequisitionedGenerated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRePrintRequisition As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents riceSelected As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Public WithEvents bbiCancelSelectedLines As DevExpress.XtraBars.BarButtonItem
End Class
