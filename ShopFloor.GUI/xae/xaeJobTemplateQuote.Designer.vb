<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobTemplateQuote
    Inherits UniSource.ShopFloor.GUI.xaegJobTemplateQuote

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
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rlkpPart = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colWorkCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rlkpWorkCentre = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.WorkCentreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCriteria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riseQuantity = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
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
        Me.rilkpSupplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colInventoryItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpInventoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.StockItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobLineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAddLine = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditLine = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiReports = New DevExpress.XtraBars.BarSubItem()
        Me.bbiRefreshPricess = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiResetFormDefaults = New DevExpress.XtraBars.BarButtonItem()
        Me.JobDataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.NumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.gcLobLines = New DevExpress.XtraGrid.GridControl()
        Me.gvJobLines = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPartGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkCentreCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rlkpWorkCentreCategory = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.WorkCentreCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colUnitCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riseCurrency = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPriceBeforeMarkup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.risePercent = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.ValidityDaysTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DeliveryDaysTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AdditionalFieldsLayoutControlInternal = New DevExpress.XtraLayout.LayoutControl()
        Me.AdditionalFieldsRoot = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Description2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GenerationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MakeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ModelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FunctionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DrawingTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobTypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobCategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkCentreCategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CostCentreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitCostTextEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.UnitPriceTextEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ItemForValidityDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.QuoteLinesLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.AdditionalFieldsLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcgDetails = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnitCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnitPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDrawing = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CategoryLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForGeneration = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForFunction = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWorkCentreCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCostCentre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForMake = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForModel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridPopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
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
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JobDataLayoutControl.SuspendLayout()
        CType(Me.NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcLobLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rlkpWorkCentreCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.risePercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidityDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdditionalFieldsLayoutControlInternal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdditionalFieldsRoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FunctionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCentreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidityDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteLinesLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdditionalFieldsLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForGeneration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFunction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCostCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grpGroup.Controls.Add(Me.JobDataLayoutControl)
        Me.grpGroup.Location = New System.Drawing.Point(0, 28)
        Me.grpGroup.ShowCaption = False
        Me.grpGroup.Size = New System.Drawing.Size(1210, 559)
        Me.grpGroup.Text = "Job"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(1042, 593)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(1123, 593)
        '
        'colPart
        '
        Me.colPart.ColumnEdit = Me.rlkpPart
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        Me.colPart.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPart.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPart.Visible = True
        Me.colPart.VisibleIndex = 1
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
        Me.colWorkCentre.Visible = True
        Me.colWorkCentre.VisibleIndex = 3
        Me.colWorkCentre.Width = 123
        '
        'rlkpWorkCentre
        '
        Me.rlkpWorkCentre.AutoHeight = False
        Me.rlkpWorkCentre.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rlkpWorkCentre.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rlkpWorkCentre.DataSource = Me.WorkCentreBindingSource
        Me.rlkpWorkCentre.DisplayMember = "Code"
        Me.rlkpWorkCentre.Name = "rlkpWorkCentre"
        Me.rlkpWorkCentre.NullText = "(Select Work Centre...)"
        '
        'WorkCentreBindingSource
        '
        Me.WorkCentreBindingSource.DataSource = GetType(UniSource.ShopFloor.API.WorkCentre)
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description1"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.colDescription1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 4
        Me.colDescription1.Width = 78
        '
        'colDescription2
        '
        Me.colDescription2.FieldName = "Description2"
        Me.colDescription2.Name = "colDescription2"
        Me.colDescription2.Visible = True
        Me.colDescription2.VisibleIndex = 5
        Me.colDescription2.Width = 78
        '
        'colQuoteDescription
        '
        Me.colQuoteDescription.FieldName = "QuoteDescription"
        Me.colQuoteDescription.Name = "colQuoteDescription"
        Me.colQuoteDescription.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colQuoteDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colQuoteDescription.Width = 95
        '
        'colCriteria
        '
        Me.colCriteria.FieldName = "Criteria"
        Me.colCriteria.Name = "colCriteria"
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
        Me.colQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:f2}")})
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 7
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
        'colEstimatedDuration
        '
        Me.colEstimatedDuration.ColumnEdit = Me.riseQuantity
        Me.colEstimatedDuration.DisplayFormat.FormatString = "f"
        Me.colEstimatedDuration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedDuration.FieldName = "EstimatedDuration"
        Me.colEstimatedDuration.GroupFormat.FormatString = "f"
        Me.colEstimatedDuration.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedDuration.Name = "colEstimatedDuration"
        Me.colEstimatedDuration.Visible = True
        Me.colEstimatedDuration.VisibleIndex = 11
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
        Me.colUnitPrice.VisibleIndex = 12
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
        Me.colTotalPrice.VisibleIndex = 13
        '
        'colMeasurement1
        '
        Me.colMeasurement1.FieldName = "Measurement1"
        Me.colMeasurement1.Name = "colMeasurement1"
        Me.colMeasurement1.Width = 80
        '
        'colMeasurement2
        '
        Me.colMeasurement2.FieldName = "Measurement2"
        Me.colMeasurement2.Name = "colMeasurement2"
        Me.colMeasurement2.Width = 80
        '
        'colMeasurement3
        '
        Me.colMeasurement3.FieldName = "Measurement3"
        Me.colMeasurement3.Name = "colMeasurement3"
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
        Me.colSupplyScope.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colSupplyScope.Visible = True
        Me.colSupplyScope.VisibleIndex = 9
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
        Me.colSupplierType.Visible = True
        Me.colSupplierType.VisibleIndex = 10
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
        'colInventoryItem
        '
        Me.colInventoryItem.Caption = "Inventory Item"
        Me.colInventoryItem.ColumnEdit = Me.rilkpInventoryItem
        Me.colInventoryItem.FieldName = "InventoryItem"
        Me.colInventoryItem.Name = "colInventoryItem"
        Me.colInventoryItem.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colInventoryItem.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colInventoryItem.Visible = True
        Me.colInventoryItem.VisibleIndex = 6
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
        Me.JobLineListBindingSource.DataMember = "JobTemplateLineList"
        Me.JobLineListBindingSource.DataSource = Me.BindingSource
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiSave, Me.bsiReports, Me.bbiCancel, Me.bbiExportGrid, Me.bbiResetFormDefaults, Me.bbiAddLine, Me.bbiEditLine, Me.bbiRefreshPricess})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 12
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAddLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiReports), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRefreshPricess)})
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
        Me.bbiEditLine.Enabled = False
        Me.bbiEditLine.Id = 10
        Me.bbiEditLine.Name = "bbiEditLine"
        Me.bbiEditLine.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'bbiRefreshPricess
        '
        Me.bbiRefreshPricess.Caption = "Refresh Pricess"
        Me.bbiRefreshPricess.Id = 11
        Me.bbiRefreshPricess.Name = "bbiRefreshPricess"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1210, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 628)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1210, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 606)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1210, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 606)
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
        Me.JobDataLayoutControl.Controls.Add(Me.NumberTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DescriptionTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.gcLobLines)
        Me.JobDataLayoutControl.Controls.Add(Me.ValidityDaysTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DeliveryDaysTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.AdditionalFieldsLayoutControlInternal)
        Me.JobDataLayoutControl.Controls.Add(Me.Description2TextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.GenerationTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.MakeTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.ModelTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.FunctionTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DrawingTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobTypeTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobCategoryTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.WorkCentreCategoryTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.CostCentreTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.UnitCostTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.UnitPriceTextEdit)
        Me.JobDataLayoutControl.DataSource = Me.BindingSource
        Me.JobDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobDataLayoutControl.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForValidityDays, Me.ItemForDeliveryDays})
        Me.JobDataLayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.JobDataLayoutControl.Name = "JobDataLayoutControl"
        Me.JobDataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(103, 463, 250, 350)
        Me.JobDataLayoutControl.OptionsView.UseSkinIndents = False
        Me.JobDataLayoutControl.Root = Me.LayoutControlGroup1
        Me.JobDataLayoutControl.Size = New System.Drawing.Size(1210, 559)
        Me.JobDataLayoutControl.TabIndex = 6
        Me.JobDataLayoutControl.Text = "DataLayoutControl1"
        '
        'NumberTextEdit
        '
        Me.NumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "TemplateNumber", True))
        Me.NumberTextEdit.Location = New System.Drawing.Point(121, 29)
        Me.NumberTextEdit.MenuManager = Me.BarManager1
        Me.NumberTextEdit.Name = "NumberTextEdit"
        Me.NumberTextEdit.Properties.ReadOnly = True
        Me.NumberTextEdit.Size = New System.Drawing.Size(478, 20)
        Me.NumberTextEdit.StyleController = Me.JobDataLayoutControl
        Me.NumberTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description1", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(121, 59)
        Me.DescriptionTextEdit.MenuManager = Me.BarManager1
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Properties.ReadOnly = True
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(478, 20)
        Me.DescriptionTextEdit.StyleController = Me.JobDataLayoutControl
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'gcLobLines
        '
        Me.gcLobLines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcLobLines.DataSource = Me.JobLineListBindingSource
        Me.gcLobLines.Location = New System.Drawing.Point(5, 155)
        Me.gcLobLines.MainView = Me.gvJobLines
        Me.gcLobLines.MenuManager = Me.BarManager1
        Me.gcLobLines.Name = "gcLobLines"
        Me.gcLobLines.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rlkpPart, Me.rlkpWorkCentre, Me.rilkpSupplyScope, Me.rilkpSupplier, Me.rilkpInventoryItem, Me.rilkpSupplierType, Me.riseQuantity, Me.rlkpWorkCentreCategory, Me.risePercent, Me.riseCurrency})
        Me.gcLobLines.Size = New System.Drawing.Size(1203, 382)
        Me.gcLobLines.TabIndex = 4
        Me.gcLobLines.UseEmbeddedNavigator = True
        Me.gcLobLines.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobLines})
        '
        'gvJobLines
        '
        Me.gvJobLines.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPartGroup, Me.colPart, Me.colWorkCentreCategory, Me.colWorkCentre, Me.colDescription1, Me.colDescription2, Me.colQuoteDescription, Me.colCriteria, Me.colQuantity, Me.colEstimatedDuration, Me.colMarkupFactor, Me.colUnitPrice, Me.colTotalPrice, Me.colMeasurement1, Me.colMeasurement2, Me.colMeasurement3, Me.colID, Me.colLineNumber, Me.colSupplyScope, Me.colSupplierType, Me.colInventoryItem, Me.colUnitCost, Me.colTotalCost, Me.colUnitSize, Me.colUnitPriceBeforeMarkup})
        Me.gvJobLines.CustomizationFormBounds = New System.Drawing.Rectangle(1150, 418, 216, 185)
        Me.gvJobLines.GridControl = Me.gcLobLines
        Me.gvJobLines.Name = "gvJobLines"
        Me.gvJobLines.OptionsView.ColumnAutoWidth = False
        Me.gvJobLines.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvJobLines.OptionsView.ShowFooter = True
        '
        'colPartGroup
        '
        Me.colPartGroup.Caption = "Part Group"
        Me.colPartGroup.FieldName = "Part.PartGroup"
        Me.colPartGroup.Name = "colPartGroup"
        Me.colPartGroup.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPartGroup.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPartGroup.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colPartGroup.Visible = True
        Me.colPartGroup.VisibleIndex = 16
        '
        'colWorkCentreCategory
        '
        Me.colWorkCentreCategory.ColumnEdit = Me.rlkpWorkCentreCategory
        Me.colWorkCentreCategory.FieldName = "WorkCentreCategory"
        Me.colWorkCentreCategory.Name = "colWorkCentreCategory"
        Me.colWorkCentreCategory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colWorkCentreCategory.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colWorkCentreCategory.Visible = True
        Me.colWorkCentreCategory.VisibleIndex = 2
        Me.colWorkCentreCategory.Width = 175
        '
        'rlkpWorkCentreCategory
        '
        Me.rlkpWorkCentreCategory.AutoHeight = False
        Me.rlkpWorkCentreCategory.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rlkpWorkCentreCategory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rlkpWorkCentreCategory.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rlkpWorkCentreCategory.DataSource = Me.WorkCentreCategoryBindingSource
        Me.rlkpWorkCentreCategory.DisplayMember = "Code"
        Me.rlkpWorkCentreCategory.Name = "rlkpWorkCentreCategory"
        Me.rlkpWorkCentreCategory.NullText = "(Select Work Centre Category...)"
        '
        'WorkCentreCategoryBindingSource
        '
        Me.WorkCentreCategoryBindingSource.DataSource = GetType(UniSource.ShopFloor.API.WorkCentreCategory)
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
        Me.colUnitCost.Visible = True
        Me.colUnitCost.VisibleIndex = 14
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
        Me.colTotalCost.VisibleIndex = 15
        '
        'colUnitSize
        '
        Me.colUnitSize.ColumnEdit = Me.riseQuantity
        Me.colUnitSize.FieldName = "UnitSize"
        Me.colUnitSize.Name = "colUnitSize"
        Me.colUnitSize.Visible = True
        Me.colUnitSize.VisibleIndex = 8
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
        'ValidityDaysTextEdit
        '
        Me.ValidityDaysTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidityDays", True))
        Me.ValidityDaysTextEdit.Location = New System.Drawing.Point(119, 487)
        Me.ValidityDaysTextEdit.MenuManager = Me.BarManager1
        Me.ValidityDaysTextEdit.Name = "ValidityDaysTextEdit"
        Me.ValidityDaysTextEdit.Properties.ReadOnly = True
        Me.ValidityDaysTextEdit.Size = New System.Drawing.Size(1089, 20)
        Me.ValidityDaysTextEdit.StyleController = Me.JobDataLayoutControl
        Me.ValidityDaysTextEdit.TabIndex = 19
        '
        'DeliveryDaysTextEdit
        '
        Me.DeliveryDaysTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DeliveryDays", True))
        Me.DeliveryDaysTextEdit.Location = New System.Drawing.Point(119, 517)
        Me.DeliveryDaysTextEdit.MenuManager = Me.BarManager1
        Me.DeliveryDaysTextEdit.Name = "DeliveryDaysTextEdit"
        Me.DeliveryDaysTextEdit.Properties.ReadOnly = True
        Me.DeliveryDaysTextEdit.Size = New System.Drawing.Size(1089, 20)
        Me.DeliveryDaysTextEdit.StyleController = Me.JobDataLayoutControl
        Me.DeliveryDaysTextEdit.TabIndex = 20
        '
        'AdditionalFieldsLayoutControlInternal
        '
        Me.AdditionalFieldsLayoutControlInternal.Location = New System.Drawing.Point(7, 29)
        Me.AdditionalFieldsLayoutControlInternal.MinimumSize = New System.Drawing.Size(1195, 51)
        Me.AdditionalFieldsLayoutControlInternal.Name = "AdditionalFieldsLayoutControlInternal"
        Me.AdditionalFieldsLayoutControlInternal.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(236, 252, 250, 350)
        Me.AdditionalFieldsLayoutControlInternal.OptionsView.UseSkinIndents = False
        Me.AdditionalFieldsLayoutControlInternal.Root = Me.AdditionalFieldsRoot
        Me.AdditionalFieldsLayoutControlInternal.Size = New System.Drawing.Size(1195, 110)
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
        Me.AdditionalFieldsRoot.Size = New System.Drawing.Size(1195, 110)
        Me.AdditionalFieldsRoot.Text = "AdditionalFieldsRoot"
        Me.AdditionalFieldsRoot.TextVisible = False
        '
        'Description2TextEdit
        '
        Me.Description2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description2", True))
        Me.Description2TextEdit.Location = New System.Drawing.Point(121, 89)
        Me.Description2TextEdit.MenuManager = Me.BarManager1
        Me.Description2TextEdit.Name = "Description2TextEdit"
        Me.Description2TextEdit.Properties.ReadOnly = True
        Me.Description2TextEdit.Size = New System.Drawing.Size(478, 20)
        Me.Description2TextEdit.StyleController = Me.JobDataLayoutControl
        Me.Description2TextEdit.TabIndex = 21
        '
        'GenerationTextEdit
        '
        Me.GenerationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Generation", True))
        Me.GenerationTextEdit.Location = New System.Drawing.Point(725, 119)
        Me.GenerationTextEdit.MenuManager = Me.BarManager1
        Me.GenerationTextEdit.Name = "GenerationTextEdit"
        Me.GenerationTextEdit.Properties.ReadOnly = True
        Me.GenerationTextEdit.Size = New System.Drawing.Size(477, 20)
        Me.GenerationTextEdit.StyleController = Me.JobDataLayoutControl
        Me.GenerationTextEdit.TabIndex = 23
        '
        'MakeTextEdit
        '
        Me.MakeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Make", True))
        Me.MakeTextEdit.Location = New System.Drawing.Point(725, 29)
        Me.MakeTextEdit.MenuManager = Me.BarManager1
        Me.MakeTextEdit.Name = "MakeTextEdit"
        Me.MakeTextEdit.Properties.ReadOnly = True
        Me.MakeTextEdit.Size = New System.Drawing.Size(477, 20)
        Me.MakeTextEdit.StyleController = Me.JobDataLayoutControl
        Me.MakeTextEdit.TabIndex = 24
        '
        'ModelTextEdit
        '
        Me.ModelTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Model", True))
        Me.ModelTextEdit.Location = New System.Drawing.Point(725, 59)
        Me.ModelTextEdit.MenuManager = Me.BarManager1
        Me.ModelTextEdit.Name = "ModelTextEdit"
        Me.ModelTextEdit.Properties.ReadOnly = True
        Me.ModelTextEdit.Size = New System.Drawing.Size(477, 20)
        Me.ModelTextEdit.StyleController = Me.JobDataLayoutControl
        Me.ModelTextEdit.TabIndex = 25
        '
        'FunctionTextEdit
        '
        Me.FunctionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Function", True))
        Me.FunctionTextEdit.Location = New System.Drawing.Point(725, 89)
        Me.FunctionTextEdit.MenuManager = Me.BarManager1
        Me.FunctionTextEdit.Name = "FunctionTextEdit"
        Me.FunctionTextEdit.Properties.ReadOnly = True
        Me.FunctionTextEdit.Size = New System.Drawing.Size(477, 20)
        Me.FunctionTextEdit.StyleController = Me.JobDataLayoutControl
        Me.FunctionTextEdit.TabIndex = 26
        '
        'DrawingTextEdit
        '
        Me.DrawingTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Drawing", True))
        Me.DrawingTextEdit.Location = New System.Drawing.Point(723, 89)
        Me.DrawingTextEdit.MenuManager = Me.BarManager1
        Me.DrawingTextEdit.Name = "DrawingTextEdit"
        Me.DrawingTextEdit.Properties.ReadOnly = True
        Me.DrawingTextEdit.Size = New System.Drawing.Size(479, 20)
        Me.DrawingTextEdit.StyleController = Me.JobDataLayoutControl
        Me.DrawingTextEdit.TabIndex = 27
        '
        'JobTypeTextEdit
        '
        Me.JobTypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobType", True))
        Me.JobTypeTextEdit.Location = New System.Drawing.Point(121, 29)
        Me.JobTypeTextEdit.MenuManager = Me.BarManager1
        Me.JobTypeTextEdit.Name = "JobTypeTextEdit"
        Me.JobTypeTextEdit.Properties.ReadOnly = True
        Me.JobTypeTextEdit.Size = New System.Drawing.Size(480, 20)
        Me.JobTypeTextEdit.StyleController = Me.JobDataLayoutControl
        Me.JobTypeTextEdit.TabIndex = 28
        '
        'JobCategoryTextEdit
        '
        Me.JobCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobCategory", True))
        Me.JobCategoryTextEdit.Location = New System.Drawing.Point(121, 89)
        Me.JobCategoryTextEdit.MenuManager = Me.BarManager1
        Me.JobCategoryTextEdit.Name = "JobCategoryTextEdit"
        Me.JobCategoryTextEdit.Properties.ReadOnly = True
        Me.JobCategoryTextEdit.Size = New System.Drawing.Size(480, 20)
        Me.JobCategoryTextEdit.StyleController = Me.JobDataLayoutControl
        Me.JobCategoryTextEdit.TabIndex = 29
        '
        'WorkCentreCategoryTextEdit
        '
        Me.WorkCentreCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "WorkCentreCategory", True))
        Me.WorkCentreCategoryTextEdit.Location = New System.Drawing.Point(121, 119)
        Me.WorkCentreCategoryTextEdit.MenuManager = Me.BarManager1
        Me.WorkCentreCategoryTextEdit.Name = "WorkCentreCategoryTextEdit"
        Me.WorkCentreCategoryTextEdit.Properties.ReadOnly = True
        Me.WorkCentreCategoryTextEdit.Size = New System.Drawing.Size(480, 20)
        Me.WorkCentreCategoryTextEdit.StyleController = Me.JobDataLayoutControl
        Me.WorkCentreCategoryTextEdit.TabIndex = 30
        '
        'CostCentreTextEdit
        '
        Me.CostCentreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CostCentre", True))
        Me.CostCentreTextEdit.Location = New System.Drawing.Point(121, 59)
        Me.CostCentreTextEdit.MenuManager = Me.BarManager1
        Me.CostCentreTextEdit.Name = "CostCentreTextEdit"
        Me.CostCentreTextEdit.Properties.ReadOnly = True
        Me.CostCentreTextEdit.Size = New System.Drawing.Size(480, 20)
        Me.CostCentreTextEdit.StyleController = Me.JobDataLayoutControl
        Me.CostCentreTextEdit.TabIndex = 31
        '
        'UnitCostTextEdit
        '
        Me.UnitCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UnitCost", True))
        Me.UnitCostTextEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UnitCostTextEdit.Location = New System.Drawing.Point(723, 29)
        Me.UnitCostTextEdit.MenuManager = Me.BarManager1
        Me.UnitCostTextEdit.Name = "UnitCostTextEdit"
        Me.UnitCostTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitCostTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.UnitCostTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitCostTextEdit.Properties.EditFormat.FormatString = "c"
        Me.UnitCostTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitCostTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.UnitCostTextEdit.Properties.ReadOnly = True
        Me.UnitCostTextEdit.Size = New System.Drawing.Size(479, 20)
        Me.UnitCostTextEdit.StyleController = Me.JobDataLayoutControl
        Me.UnitCostTextEdit.TabIndex = 17
        '
        'UnitPriceTextEdit
        '
        Me.UnitPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UnitPrice", True))
        Me.UnitPriceTextEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UnitPriceTextEdit.Location = New System.Drawing.Point(723, 59)
        Me.UnitPriceTextEdit.MenuManager = Me.BarManager1
        Me.UnitPriceTextEdit.Name = "UnitPriceTextEdit"
        Me.UnitPriceTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitPriceTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.UnitPriceTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitPriceTextEdit.Properties.EditFormat.FormatString = "c"
        Me.UnitPriceTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitPriceTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.UnitPriceTextEdit.Properties.ReadOnly = True
        Me.UnitPriceTextEdit.Size = New System.Drawing.Size(479, 20)
        Me.UnitPriceTextEdit.StyleController = Me.JobDataLayoutControl
        Me.UnitPriceTextEdit.TabIndex = 18
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
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1213, 542)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
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
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1213, 542)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'QuoteLinesLayoutControlItem
        '
        Me.QuoteLinesLayoutControlItem.Control = Me.gcLobLines
        Me.QuoteLinesLayoutControlItem.CustomizationFormText = "Quote Lines"
        Me.QuoteLinesLayoutControlItem.Location = New System.Drawing.Point(0, 150)
        Me.QuoteLinesLayoutControlItem.Name = "QuoteLinesLayoutControlItem"
        Me.QuoteLinesLayoutControlItem.Size = New System.Drawing.Size(1213, 392)
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
        Me.TabbedControlGroup1.SelectedTabPage = Me.AdditionalFieldsLayoutControlGroup
        Me.TabbedControlGroup1.SelectedTabPageIndex = 2
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1213, 150)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcgDetails, Me.CategoryLayoutControlGroup, Me.AdditionalFieldsLayoutControlGroup})
        Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
        '
        'AdditionalFieldsLayoutControlGroup
        '
        Me.AdditionalFieldsLayoutControlGroup.CustomizationFormText = "Additional Fields"
        Me.AdditionalFieldsLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.AdditionalFieldsLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.AdditionalFieldsLayoutControlGroup.Name = "AdditionalFieldsLayoutControlGroup"
        Me.AdditionalFieldsLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.AdditionalFieldsLayoutControlGroup.Size = New System.Drawing.Size(1205, 120)
        Me.AdditionalFieldsLayoutControlGroup.Text = "Additional Fields"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.AdditionalFieldsLayoutControlInternal
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1205, 120)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'lcgDetails
        '
        Me.lcgDetails.CustomizationFormText = "Details"
        Me.lcgDetails.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForDescription, Me.ItemForNumber, Me.ItemForDescription2, Me.ItemForUnitCost, Me.ItemForUnitPrice, Me.ItemForDrawing})
        Me.lcgDetails.Location = New System.Drawing.Point(0, 0)
        Me.lcgDetails.Name = "lcgDetails"
        Me.lcgDetails.OptionsItemText.TextToControlDistance = 5
        Me.lcgDetails.Size = New System.Drawing.Size(1205, 120)
        Me.lcgDetails.Text = "Details"
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(602, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForNumber
        '
        Me.ItemForNumber.Control = Me.NumberTextEdit
        Me.ItemForNumber.CustomizationFormText = "Number"
        Me.ItemForNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNumber.Name = "ItemForNumber"
        Me.ItemForNumber.Size = New System.Drawing.Size(602, 30)
        Me.ItemForNumber.Text = "Number"
        Me.ItemForNumber.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForNumber.TextToControlDistance = 5
        '
        'ItemForDescription2
        '
        Me.ItemForDescription2.Control = Me.Description2TextEdit
        Me.ItemForDescription2.CustomizationFormText = "Description2"
        Me.ItemForDescription2.Location = New System.Drawing.Point(0, 60)
        Me.ItemForDescription2.Name = "ItemForDescription2"
        Me.ItemForDescription2.Size = New System.Drawing.Size(602, 60)
        Me.ItemForDescription2.Text = "Description2"
        Me.ItemForDescription2.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForDescription2.TextToControlDistance = 5
        '
        'ItemForUnitCost
        '
        Me.ItemForUnitCost.Control = Me.UnitCostTextEdit
        Me.ItemForUnitCost.CustomizationFormText = "Unit Cost"
        Me.ItemForUnitCost.Location = New System.Drawing.Point(602, 0)
        Me.ItemForUnitCost.Name = "ItemForUnitCost"
        Me.ItemForUnitCost.Size = New System.Drawing.Size(603, 30)
        Me.ItemForUnitCost.Text = "Unit Cost"
        Me.ItemForUnitCost.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForUnitCost.TextToControlDistance = 5
        '
        'ItemForUnitPrice
        '
        Me.ItemForUnitPrice.Control = Me.UnitPriceTextEdit
        Me.ItemForUnitPrice.CustomizationFormText = "Unit Price"
        Me.ItemForUnitPrice.Location = New System.Drawing.Point(602, 30)
        Me.ItemForUnitPrice.Name = "ItemForUnitPrice"
        Me.ItemForUnitPrice.Size = New System.Drawing.Size(603, 30)
        Me.ItemForUnitPrice.Text = "Unit Price"
        Me.ItemForUnitPrice.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForUnitPrice.TextToControlDistance = 5
        '
        'ItemForDrawing
        '
        Me.ItemForDrawing.Control = Me.DrawingTextEdit
        Me.ItemForDrawing.CustomizationFormText = "Drawing"
        Me.ItemForDrawing.Location = New System.Drawing.Point(602, 60)
        Me.ItemForDrawing.Name = "ItemForDrawing"
        Me.ItemForDrawing.Size = New System.Drawing.Size(603, 60)
        Me.ItemForDrawing.Text = "Drawing"
        Me.ItemForDrawing.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForDrawing.TextToControlDistance = 5
        '
        'CategoryLayoutControlGroup
        '
        Me.CategoryLayoutControlGroup.CustomizationFormText = "Category"
        Me.CategoryLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForGeneration, Me.ItemForJobCategory, Me.ItemForJobType, Me.ItemForFunction, Me.ItemForWorkCentreCategory, Me.ItemForCostCentre, Me.ItemForMake, Me.ItemForModel})
        Me.CategoryLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.CategoryLayoutControlGroup.Name = "CategoryLayoutControlGroup"
        Me.CategoryLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.CategoryLayoutControlGroup.Size = New System.Drawing.Size(1205, 120)
        Me.CategoryLayoutControlGroup.Text = "Category"
        '
        'ItemForGeneration
        '
        Me.ItemForGeneration.Control = Me.GenerationTextEdit
        Me.ItemForGeneration.CustomizationFormText = "Generation"
        Me.ItemForGeneration.Location = New System.Drawing.Point(604, 90)
        Me.ItemForGeneration.Name = "ItemForGeneration"
        Me.ItemForGeneration.Size = New System.Drawing.Size(601, 30)
        Me.ItemForGeneration.Text = "Generation"
        Me.ItemForGeneration.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForGeneration.TextToControlDistance = 5
        '
        'ItemForJobCategory
        '
        Me.ItemForJobCategory.Control = Me.JobCategoryTextEdit
        Me.ItemForJobCategory.CustomizationFormText = "Job Category"
        Me.ItemForJobCategory.Location = New System.Drawing.Point(0, 60)
        Me.ItemForJobCategory.Name = "ItemForJobCategory"
        Me.ItemForJobCategory.Size = New System.Drawing.Size(604, 30)
        Me.ItemForJobCategory.Text = "Job Category"
        Me.ItemForJobCategory.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForJobCategory.TextToControlDistance = 5
        '
        'ItemForJobType
        '
        Me.ItemForJobType.Control = Me.JobTypeTextEdit
        Me.ItemForJobType.CustomizationFormText = "Job Type"
        Me.ItemForJobType.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobType.Name = "ItemForJobType"
        Me.ItemForJobType.Size = New System.Drawing.Size(604, 30)
        Me.ItemForJobType.Text = "Job Type"
        Me.ItemForJobType.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForJobType.TextToControlDistance = 5
        '
        'ItemForFunction
        '
        Me.ItemForFunction.Control = Me.FunctionTextEdit
        Me.ItemForFunction.CustomizationFormText = "Function"
        Me.ItemForFunction.Location = New System.Drawing.Point(604, 60)
        Me.ItemForFunction.Name = "ItemForFunction"
        Me.ItemForFunction.Size = New System.Drawing.Size(601, 30)
        Me.ItemForFunction.Text = "Function"
        Me.ItemForFunction.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForFunction.TextToControlDistance = 5
        '
        'ItemForWorkCentreCategory
        '
        Me.ItemForWorkCentreCategory.Control = Me.WorkCentreCategoryTextEdit
        Me.ItemForWorkCentreCategory.CustomizationFormText = "Work Centre Category"
        Me.ItemForWorkCentreCategory.Location = New System.Drawing.Point(0, 90)
        Me.ItemForWorkCentreCategory.Name = "ItemForWorkCentreCategory"
        Me.ItemForWorkCentreCategory.Size = New System.Drawing.Size(604, 30)
        Me.ItemForWorkCentreCategory.Text = "Work Centre Category"
        Me.ItemForWorkCentreCategory.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForWorkCentreCategory.TextToControlDistance = 5
        '
        'ItemForCostCentre
        '
        Me.ItemForCostCentre.Control = Me.CostCentreTextEdit
        Me.ItemForCostCentre.CustomizationFormText = "Cost Centre"
        Me.ItemForCostCentre.Location = New System.Drawing.Point(0, 30)
        Me.ItemForCostCentre.Name = "ItemForCostCentre"
        Me.ItemForCostCentre.Size = New System.Drawing.Size(604, 30)
        Me.ItemForCostCentre.Text = "Cost Centre"
        Me.ItemForCostCentre.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForCostCentre.TextToControlDistance = 5
        '
        'ItemForMake
        '
        Me.ItemForMake.Control = Me.MakeTextEdit
        Me.ItemForMake.CustomizationFormText = "Make"
        Me.ItemForMake.Location = New System.Drawing.Point(604, 0)
        Me.ItemForMake.Name = "ItemForMake"
        Me.ItemForMake.Size = New System.Drawing.Size(601, 30)
        Me.ItemForMake.Text = "Make"
        Me.ItemForMake.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForMake.TextToControlDistance = 5
        '
        'ItemForModel
        '
        Me.ItemForModel.Control = Me.ModelTextEdit
        Me.ItemForModel.CustomizationFormText = "Model"
        Me.ItemForModel.Location = New System.Drawing.Point(604, 30)
        Me.ItemForModel.Name = "ItemForModel"
        Me.ItemForModel.Size = New System.Drawing.Size(601, 30)
        Me.ItemForModel.Text = "Model"
        Me.ItemForModel.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForModel.TextToControlDistance = 5
        '
        'GridPopupMenu
        '
        Me.GridPopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAddLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCancel), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportGrid, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiResetFormDefaults, True)})
        Me.GridPopupMenu.Manager = Me.BarManager1
        Me.GridPopupMenu.Name = "GridPopupMenu"
        '
        'xaeJobTemplateQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 628)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = True
        Me.Name = "xaeJobTemplateQuote"
        Me.Text = "xaeJobTemplateQuote"
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
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JobDataLayoutControl.ResumeLayout(False)
        CType(Me.NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcLobLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rlkpWorkCentreCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.risePercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidityDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdditionalFieldsLayoutControlInternal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdditionalFieldsRoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FunctionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCentreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidityDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteLinesLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdditionalFieldsLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForGeneration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFunction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCostCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
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
    Friend WithEvents NumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcLobLines As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobLines As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCriteria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colInventoryItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents lcgDetails As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNumber As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents riseCurrency As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colUnitCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPriceBeforeMarkup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents risePercent As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents ValidityDaysTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliveryDaysTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Description2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GenerationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MakeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ModelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FunctionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DrawingTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobTypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobCategoryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkCentreCategoryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CostCentreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForValidityDays As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeliveryDays As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUnitCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUnitPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDrawing As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CategoryLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForGeneration As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFunction As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWorkCentreCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCostCentre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMake As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForModel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents UnitCostTextEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents UnitPriceTextEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents bbiRefreshPricess As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPartGroup As DevExpress.XtraGrid.Columns.GridColumn
End Class
