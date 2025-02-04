<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xucJobLines
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.gvActivityLogList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colArtisan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rileArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMachine1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rileMachine = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrentState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rileState = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colArtisanCost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineCost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperationCost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcActivities = New DevExpress.XtraGrid.GridControl()
        Me.JobLineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvActivities = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilePart = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colWorkCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpWorkCentre = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.WorkCentreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colJobLineDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGRVDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCriteria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNormalWearAndTearReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsNormalWearAndTear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsProcured = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsStockDrawn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colQuantityStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantitySupplier1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantitySupplier2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasePrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMarkupFactor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAddLine = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditLine = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiReports = New DevExpress.XtraBars.BarSubItem()
        Me.bbiResetFormDefaults = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.JobDataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.NumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.lcgDetails = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCustomer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDetails = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.gvActivityLogList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rileArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rileMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rileState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilePart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpWorkCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseLineNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpSupplyScope, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyScopeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpSupplierType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpInventoryItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JobDataLayoutControl.SuspendLayout()
        CType(Me.NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvActivityLogList
        '
        Me.gvActivityLogList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colArtisan1, Me.colMachine1, Me.colStartDate, Me.colEndDate, Me.colDuration, Me.colCurrentState, Me.colArtisanCost1, Me.colMachineCost1, Me.colOperationCost1, Me.colLogTime, Me.colID1})
        Me.gvActivityLogList.GridControl = Me.gcActivities
        Me.gvActivityLogList.Name = "gvActivityLogList"
        '
        'colArtisan1
        '
        Me.colArtisan1.ColumnEdit = Me.rileArtisan
        Me.colArtisan1.FieldName = "Artisan"
        Me.colArtisan1.Name = "colArtisan1"
        Me.colArtisan1.Visible = True
        Me.colArtisan1.VisibleIndex = 0
        '
        'rileArtisan
        '
        Me.rileArtisan.AutoHeight = False
        Me.rileArtisan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rileArtisan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rileArtisan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rate", "Rate", 33, DevExpress.Utils.FormatType.Numeric, "c", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rileArtisan.DisplayMember = "Code"
        Me.rileArtisan.Name = "rileArtisan"
        Me.rileArtisan.NullText = "(Select Artisan...)"
        '
        'colMachine1
        '
        Me.colMachine1.ColumnEdit = Me.rileMachine
        Me.colMachine1.FieldName = "Machine"
        Me.colMachine1.Name = "colMachine1"
        Me.colMachine1.Visible = True
        Me.colMachine1.VisibleIndex = 1
        '
        'rileMachine
        '
        Me.rileMachine.AutoHeight = False
        Me.rileMachine.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rileMachine.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rileMachine.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rate", "Rate", 33, DevExpress.Utils.FormatType.Numeric, "c", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rileMachine.DisplayMember = "Code"
        Me.rileMachine.Name = "rileMachine"
        Me.rileMachine.NullText = "(Select Machine...)"
        '
        'colStartDate
        '
        Me.colStartDate.DisplayFormat.FormatString = "g"
        Me.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.GroupFormat.FormatString = "g"
        Me.colStartDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 2
        '
        'colEndDate
        '
        Me.colEndDate.DisplayFormat.FormatString = "g"
        Me.colEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEndDate.FieldName = "EndDate"
        Me.colEndDate.GroupFormat.FormatString = "g"
        Me.colEndDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEndDate.Name = "colEndDate"
        Me.colEndDate.Visible = True
        Me.colEndDate.VisibleIndex = 3
        '
        'colDuration
        '
        Me.colDuration.DisplayFormat.FormatString = "f"
        Me.colDuration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDuration.FieldName = "Duration"
        Me.colDuration.GroupFormat.FormatString = "f"
        Me.colDuration.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDuration.Name = "colDuration"
        Me.colDuration.Visible = True
        Me.colDuration.VisibleIndex = 4
        '
        'colCurrentState
        '
        Me.colCurrentState.ColumnEdit = Me.rileState
        Me.colCurrentState.FieldName = "CurrentState"
        Me.colCurrentState.Name = "colCurrentState"
        Me.colCurrentState.Visible = True
        Me.colCurrentState.VisibleIndex = 5
        '
        'rileState
        '
        Me.rileState.AutoHeight = False
        Me.rileState.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rileState.Name = "rileState"
        Me.rileState.NullText = "(Select Current State...)"
        '
        'colArtisanCost1
        '
        Me.colArtisanCost1.DisplayFormat.FormatString = "c"
        Me.colArtisanCost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colArtisanCost1.FieldName = "ArtisanCost"
        Me.colArtisanCost1.GroupFormat.FormatString = "c"
        Me.colArtisanCost1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colArtisanCost1.Name = "colArtisanCost1"
        Me.colArtisanCost1.Visible = True
        Me.colArtisanCost1.VisibleIndex = 6
        '
        'colMachineCost1
        '
        Me.colMachineCost1.DisplayFormat.FormatString = "c"
        Me.colMachineCost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMachineCost1.FieldName = "MachineCost"
        Me.colMachineCost1.GroupFormat.FormatString = "c"
        Me.colMachineCost1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMachineCost1.Name = "colMachineCost1"
        Me.colMachineCost1.Visible = True
        Me.colMachineCost1.VisibleIndex = 7
        '
        'colOperationCost1
        '
        Me.colOperationCost1.DisplayFormat.FormatString = "c"
        Me.colOperationCost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOperationCost1.FieldName = "OperationCost"
        Me.colOperationCost1.GroupFormat.FormatString = "c"
        Me.colOperationCost1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOperationCost1.Name = "colOperationCost1"
        Me.colOperationCost1.Visible = True
        Me.colOperationCost1.VisibleIndex = 8
        '
        'colLogTime
        '
        Me.colLogTime.DisplayFormat.FormatString = "g"
        Me.colLogTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLogTime.FieldName = "LogTime"
        Me.colLogTime.GroupFormat.FormatString = "g"
        Me.colLogTime.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLogTime.Name = "colLogTime"
        Me.colLogTime.OptionsColumn.ReadOnly = True
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        Me.colID1.OptionsColumn.ReadOnly = True
        '
        'gcActivities
        '
        Me.gcActivities.DataSource = Me.JobLineListBindingSource
        Me.gcActivities.Location = New System.Drawing.Point(5, 112)
        Me.gcActivities.MainView = Me.gvActivities
        Me.gcActivities.MenuManager = Me.BarManager1
        Me.gcActivities.Name = "gcActivities"
        Me.gcActivities.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rileArtisan, Me.rileMachine, Me.rileState, Me.rilePart, Me.lkpWorkCentre, Me.rilkpSupplyScope, Me.rilkpSupplier, Me.rilkpInventoryItem, Me.rilkpSupplierType, Me.riseLineNumber, Me.RepositoryItemSpinEdit1})
        Me.gcActivities.Size = New System.Drawing.Size(1567, 510)
        Me.gcActivities.TabIndex = 4
        Me.gcActivities.UseEmbeddedNavigator = True
        Me.gcActivities.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvActivities, Me.gvActivityLogList})
        '
        'JobLineListBindingSource
        '
        Me.JobLineListBindingSource.DataMember = "JobLineList"
        Me.JobLineListBindingSource.DataSource = Me.JobBindingSource
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Job)
        '
        'gvActivities
        '
        Me.gvActivities.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPart, Me.colWorkCentre, Me.colJobLineDate, Me.colOrderDate, Me.colRequiredDate, Me.colGRVDate, Me.colDescription1, Me.colDescription2, Me.colQuoteDescription, Me.colCriteria, Me.colNormalWearAndTearReason, Me.colIsNormalWearAndTear, Me.colIsProcured, Me.colIsStockDrawn, Me.colQuantity, Me.colQuantityStock, Me.colQuantitySupplier1, Me.colQuantitySupplier2, Me.colEstimatedDuration, Me.colStockPrice, Me.colPurchasePrice, Me.colMarkupFactor, Me.colUnitPrice, Me.colTotal, Me.colMeasurement1, Me.colMeasurement2, Me.colMeasurement3, Me.colID, Me.colLineNumber, Me.colSupplyScope, Me.colSupplierType, Me.colSupplier1, Me.colSupplier2, Me.colInventoryItem})
        Me.gvActivities.CustomizationFormBounds = New System.Drawing.Rectangle(1403, 603, 216, 185)
        Me.gvActivities.GridControl = Me.gcActivities
        Me.gvActivities.Name = "gvActivities"
        Me.gvActivities.OptionsView.ColumnAutoWidth = False
        Me.gvActivities.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvActivities.OptionsView.ShowFooter = True
        Me.gvActivities.OptionsView.ShowGroupPanel = False
        '
        'colPart
        '
        Me.colPart.ColumnEdit = Me.rilePart
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        Me.colPart.Visible = True
        Me.colPart.VisibleIndex = 1
        Me.colPart.Width = 86
        '
        'rilePart
        '
        Me.rilePart.AutoHeight = False
        Me.rilePart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilePart.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rilePart.DataSource = Me.PartBindingSource
        Me.rilePart.DisplayMember = "Code"
        Me.rilePart.Name = "rilePart"
        Me.rilePart.NullText = "(Select Part...)"
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Part)
        '
        'colWorkCentre
        '
        Me.colWorkCentre.ColumnEdit = Me.lkpWorkCentre
        Me.colWorkCentre.FieldName = "WorkCentre"
        Me.colWorkCentre.Name = "colWorkCentre"
        Me.colWorkCentre.Visible = True
        Me.colWorkCentre.VisibleIndex = 2
        Me.colWorkCentre.Width = 123
        '
        'lkpWorkCentre
        '
        Me.lkpWorkCentre.AutoHeight = False
        Me.lkpWorkCentre.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpWorkCentre.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lkpWorkCentre.DataSource = Me.WorkCentreBindingSource
        Me.lkpWorkCentre.DisplayMember = "Code"
        Me.lkpWorkCentre.Name = "lkpWorkCentre"
        Me.lkpWorkCentre.NullText = "(Select Work Centre...)"
        '
        'WorkCentreBindingSource
        '
        Me.WorkCentreBindingSource.DataSource = GetType(UniSource.ShopFloor.API.WorkCentre)
        '
        'colJobLineDate
        '
        Me.colJobLineDate.FieldName = "JobLineDate"
        Me.colJobLineDate.Name = "colJobLineDate"
        '
        'colOrderDate
        '
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        '
        'colRequiredDate
        '
        Me.colRequiredDate.FieldName = "RequiredDate"
        Me.colRequiredDate.Name = "colRequiredDate"
        Me.colRequiredDate.Width = 78
        '
        'colGRVDate
        '
        Me.colGRVDate.FieldName = "GRVDate"
        Me.colGRVDate.Name = "colGRVDate"
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description1"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 3
        Me.colDescription1.Width = 78
        '
        'colDescription2
        '
        Me.colDescription2.FieldName = "Description2"
        Me.colDescription2.Name = "colDescription2"
        Me.colDescription2.Visible = True
        Me.colDescription2.VisibleIndex = 4
        Me.colDescription2.Width = 78
        '
        'colQuoteDescription
        '
        Me.colQuoteDescription.FieldName = "QuoteDescription"
        Me.colQuoteDescription.Name = "colQuoteDescription"
        Me.colQuoteDescription.Width = 95
        '
        'colCriteria
        '
        Me.colCriteria.FieldName = "Criteria"
        Me.colCriteria.Name = "colCriteria"
        '
        'colNormalWearAndTearReason
        '
        Me.colNormalWearAndTearReason.FieldName = "NormalWearAndTearReason"
        Me.colNormalWearAndTearReason.Name = "colNormalWearAndTearReason"
        Me.colNormalWearAndTearReason.Width = 157
        '
        'colIsNormalWearAndTear
        '
        Me.colIsNormalWearAndTear.FieldName = "IsNormalWearAndTear"
        Me.colIsNormalWearAndTear.Name = "colIsNormalWearAndTear"
        Me.colIsNormalWearAndTear.Width = 130
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
        Me.colQuantity.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colQuantity.DisplayFormat.FormatString = "f"
        Me.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.GroupFormat.FormatString = "f"
        Me.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.SummaryItem.DisplayFormat = "{0:f2}"
        Me.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 6
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "f"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "f"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "f"
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colQuantityStock
        '
        Me.colQuantityStock.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colQuantityStock.DisplayFormat.FormatString = "f"
        Me.colQuantityStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantityStock.FieldName = "QuantityStock"
        Me.colQuantityStock.GroupFormat.FormatString = "f"
        Me.colQuantityStock.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantityStock.Name = "colQuantityStock"
        Me.colQuantityStock.SummaryItem.DisplayFormat = "{0:f2}"
        Me.colQuantityStock.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQuantityStock.Visible = True
        Me.colQuantityStock.VisibleIndex = 10
        Me.colQuantityStock.Width = 90
        '
        'colQuantitySupplier1
        '
        Me.colQuantitySupplier1.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colQuantitySupplier1.DisplayFormat.FormatString = "f"
        Me.colQuantitySupplier1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantitySupplier1.FieldName = "QuantitySupplier1"
        Me.colQuantitySupplier1.GroupFormat.FormatString = "f"
        Me.colQuantitySupplier1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantitySupplier1.Name = "colQuantitySupplier1"
        Me.colQuantitySupplier1.SummaryItem.DisplayFormat = "{0:f2}"
        Me.colQuantitySupplier1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQuantitySupplier1.Visible = True
        Me.colQuantitySupplier1.VisibleIndex = 11
        Me.colQuantitySupplier1.Width = 108
        '
        'colQuantitySupplier2
        '
        Me.colQuantitySupplier2.FieldName = "QuantitySupplier2"
        Me.colQuantitySupplier2.Name = "colQuantitySupplier2"
        Me.colQuantitySupplier2.Width = 98
        '
        'colEstimatedDuration
        '
        Me.colEstimatedDuration.FieldName = "EstimatedDuration"
        Me.colEstimatedDuration.Name = "colEstimatedDuration"
        Me.colEstimatedDuration.Visible = True
        Me.colEstimatedDuration.VisibleIndex = 12
        Me.colEstimatedDuration.Width = 110
        '
        'colStockPrice
        '
        Me.colStockPrice.DisplayFormat.FormatString = "c"
        Me.colStockPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colStockPrice.FieldName = "StockPrice"
        Me.colStockPrice.GroupFormat.FormatString = "c"
        Me.colStockPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colStockPrice.Name = "colStockPrice"
        Me.colStockPrice.Visible = True
        Me.colStockPrice.VisibleIndex = 13
        '
        'colPurchasePrice
        '
        Me.colPurchasePrice.DisplayFormat.FormatString = "c"
        Me.colPurchasePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPurchasePrice.FieldName = "PurchasePrice"
        Me.colPurchasePrice.GroupFormat.FormatString = "c"
        Me.colPurchasePrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPurchasePrice.Name = "colPurchasePrice"
        Me.colPurchasePrice.Visible = True
        Me.colPurchasePrice.VisibleIndex = 14
        Me.colPurchasePrice.Width = 89
        '
        'colMarkupFactor
        '
        Me.colMarkupFactor.FieldName = "MarkupFactor"
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
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 15
        '
        'colTotal
        '
        Me.colTotal.DisplayFormat.FormatString = "c"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "TotalPrice"
        Me.colTotal.GroupFormat.FormatString = "c"
        Me.colTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 16
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
        Me.colLineNumber.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
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
        Me.colSupplyScope.Name = "colSupplyScope"
        Me.colSupplyScope.Visible = True
        Me.colSupplyScope.VisibleIndex = 7
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
        Me.colSupplierType.VisibleIndex = 8
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
        Me.colSupplier1.Visible = True
        Me.colSupplier1.VisibleIndex = 9
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
        '
        'colInventoryItem
        '
        Me.colInventoryItem.Caption = "Inventory Item"
        Me.colInventoryItem.ColumnEdit = Me.rilkpInventoryItem
        Me.colInventoryItem.FieldName = "InventoryItem"
        Me.colInventoryItem.Name = "colInventoryItem"
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiSave, Me.bsiReports, Me.bbiCancel, Me.bbiExportGrid, Me.bbiResetFormDefaults, Me.bbiAddLine, Me.bbiEditLine})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 11
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAddLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiReports), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiResetFormDefaults)})
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
        'bbiResetFormDefaults
        '
        Me.bbiResetFormDefaults.Caption = "Reset Form Defaults"
        Me.bbiResetFormDefaults.Id = 8
        Me.bbiResetFormDefaults.Name = "bbiResetFormDefaults"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1577, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 649)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1577, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 627)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1577, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 627)
        '
        'bbiCancel
        '
        Me.bbiCancel.Caption = "Cancel"
        Me.bbiCancel.Id = 3
        Me.bbiCancel.Name = "bbiCancel"
        Me.bbiCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'JobDataLayoutControl
        '
        Me.JobDataLayoutControl.Controls.Add(Me.NumberTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DescriptionTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.gcActivities)
        Me.JobDataLayoutControl.Controls.Add(Me.CustomerTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobDateDateEdit)
        Me.JobDataLayoutControl.DataSource = Me.JobBindingSource
        Me.JobDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobDataLayoutControl.Location = New System.Drawing.Point(0, 22)
        Me.JobDataLayoutControl.Name = "JobDataLayoutControl"
        Me.JobDataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(103, 463, 250, 350)
        Me.JobDataLayoutControl.OptionsView.UseSkinIndents = False
        Me.JobDataLayoutControl.Root = Me.LayoutControlGroup1
        Me.JobDataLayoutControl.Size = New System.Drawing.Size(1577, 627)
        Me.JobDataLayoutControl.TabIndex = 5
        Me.JobDataLayoutControl.Text = "DataLayoutControl1"
        '
        'NumberTextEdit
        '
        Me.NumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobNumber", True))
        Me.NumberTextEdit.Location = New System.Drawing.Point(849, 28)
        Me.NumberTextEdit.MenuManager = Me.BarManager1
        Me.NumberTextEdit.Name = "NumberTextEdit"
        Me.NumberTextEdit.Properties.ReadOnly = True
        Me.NumberTextEdit.Size = New System.Drawing.Size(717, 20)
        Me.NumberTextEdit.StyleController = Me.JobDataLayoutControl
        Me.NumberTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Description1", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(65, 58)
        Me.DescriptionTextEdit.MenuManager = Me.BarManager1
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(716, 20)
        Me.DescriptionTextEdit.StyleController = Me.JobDataLayoutControl
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'CustomerTextEdit
        '
        Me.CustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Customer", True))
        Me.CustomerTextEdit.Location = New System.Drawing.Point(65, 28)
        Me.CustomerTextEdit.MenuManager = Me.BarManager1
        Me.CustomerTextEdit.Name = "CustomerTextEdit"
        Me.CustomerTextEdit.Properties.ReadOnly = True
        Me.CustomerTextEdit.Size = New System.Drawing.Size(716, 20)
        Me.CustomerTextEdit.StyleController = Me.JobDataLayoutControl
        Me.CustomerTextEdit.TabIndex = 15
        '
        'JobDateDateEdit
        '
        Me.JobDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobDate", True))
        Me.JobDateDateEdit.EditValue = Nothing
        Me.JobDateDateEdit.Location = New System.Drawing.Point(849, 58)
        Me.JobDateDateEdit.MenuManager = Me.BarManager1
        Me.JobDateDateEdit.Name = "JobDateDateEdit"
        Me.JobDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JobDateDateEdit.Properties.Mask.EditMask = ""
        Me.JobDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.JobDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.JobDateDateEdit.Size = New System.Drawing.Size(717, 20)
        Me.JobDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.JobDateDateEdit.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.lciDetails})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1577, 627)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1577, 89)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.lcgDetails
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1577, 89)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcgDetails})
        Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
        '
        'lcgDetails
        '
        Me.lcgDetails.CustomizationFormText = "Details"
        Me.lcgDetails.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCustomer, Me.ItemForDescription, Me.ItemForNumber, Me.ItemForJobDate})
        Me.lcgDetails.Location = New System.Drawing.Point(0, 0)
        Me.lcgDetails.Name = "lcgDetails"
        Me.lcgDetails.OptionsItemText.TextToControlDistance = 5
        Me.lcgDetails.Size = New System.Drawing.Size(1569, 60)
        Me.lcgDetails.Text = "Details"
        '
        'ItemForCustomer
        '
        Me.ItemForCustomer.Control = Me.CustomerTextEdit
        Me.ItemForCustomer.CustomizationFormText = "Customer"
        Me.ItemForCustomer.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCustomer.Name = "ItemForCustomer"
        Me.ItemForCustomer.Size = New System.Drawing.Size(784, 30)
        Me.ItemForCustomer.Text = "Customer"
        Me.ItemForCustomer.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForCustomer.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(784, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForNumber
        '
        Me.ItemForNumber.Control = Me.NumberTextEdit
        Me.ItemForNumber.CustomizationFormText = "Number"
        Me.ItemForNumber.Location = New System.Drawing.Point(784, 0)
        Me.ItemForNumber.Name = "ItemForNumber"
        Me.ItemForNumber.Size = New System.Drawing.Size(785, 30)
        Me.ItemForNumber.Text = "Number"
        Me.ItemForNumber.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForNumber.TextToControlDistance = 5
        '
        'ItemForJobDate
        '
        Me.ItemForJobDate.Control = Me.JobDateDateEdit
        Me.ItemForJobDate.CustomizationFormText = "Job Date"
        Me.ItemForJobDate.Location = New System.Drawing.Point(784, 30)
        Me.ItemForJobDate.Name = "ItemForJobDate"
        Me.ItemForJobDate.Size = New System.Drawing.Size(785, 30)
        Me.ItemForJobDate.Text = "Job Date"
        Me.ItemForJobDate.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForJobDate.TextToControlDistance = 5
        '
        'lciDetails
        '
        Me.lciDetails.Control = Me.gcActivities
        Me.lciDetails.CustomizationFormText = "Details"
        Me.lciDetails.Location = New System.Drawing.Point(0, 89)
        Me.lciDetails.Name = "lciDetails"
        Me.lciDetails.Size = New System.Drawing.Size(1577, 538)
        Me.lciDetails.Text = "Details"
        Me.lciDetails.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciDetails.TextSize = New System.Drawing.Size(53, 13)
        Me.lciDetails.TextToControlDistance = 5
        '
        'xucJobLines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.JobDataLayoutControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xucJobLines"
        Me.Size = New System.Drawing.Size(1577, 649)
        CType(Me.gvActivityLogList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rileArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rileMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rileState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcActivities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvActivities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilePart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpWorkCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseLineNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpSupplyScope, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyScopeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpSupplierType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpInventoryItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JobDataLayoutControl.ResumeLayout(False)
        CType(Me.NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents JobDataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents NumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gcActivities As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvActivities As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents lcgDetails As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCustomer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciDetails As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiReports As DevExpress.XtraBars.BarSubItem
    Friend WithEvents rileArtisan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rileMachine As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bbiCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents JobDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gvActivityLogList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colArtisan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachine1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rileState As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colArtisanCost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineCost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperationCost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JobLineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colJobLineDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGRVDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCriteria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNormalWearAndTearReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsNormalWearAndTear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsProcured As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsStockDrawn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantityStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantitySupplier1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantitySupplier2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasePrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMarkupFactor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeasurement1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeasurement2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeasurement3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilePart As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lkpWorkCentre As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents WorkCentreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colLineNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplyScope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilkpSupplyScope As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SupplyScopeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplier1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilkpSupplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents VendorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colSupplier2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilkpInventoryItem As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents StockItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents riseLineNumber As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents rilkpSupplierType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents VendorClassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents bbiResetFormDefaults As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAddLine As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditLine As DevExpress.XtraBars.BarButtonItem

End Class
