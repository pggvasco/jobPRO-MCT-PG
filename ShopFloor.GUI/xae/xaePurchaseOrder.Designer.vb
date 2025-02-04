<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaePurchaseOrder
    Inherits UniSource.ShopFloor.GUI.xaegPurchaseOrder

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
        Me.DataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.SupplierLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AgentNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gcPurchaseOrderLines = New DevExpress.XtraGrid.GridControl()
        Me.PurchaseOrderLineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvPurchaseOrderLines = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.RequisitionLinesGridBand = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colInventoryItem = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.riseQuantity = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colUnitCost = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colJobLine = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLineNote = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.PartLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartGroupLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PartGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplyScopeLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.SupplyScopeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkCentreLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.WorkCentreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkCentreCategoryLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.WorkCentreCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSupplyScope = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWorkCentre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPart = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPartGroup = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWorkCentreCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAgentName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForRequisitionLines = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSupplier = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJob = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNumber = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl.SuspendLayout()
        CType(Me.SupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPurchaseOrderLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderLineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPurchaseOrderLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartGroupLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyScopeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyScopeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSupplyScope, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWorkCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPartGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAgentName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRequisitionLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl)
        Me.grpGroup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpGroup.Size = New System.Drawing.Size(808, 627)
        Me.grpGroup.Text = "Requisition"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(665, 646)
        Me.btSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(746, 646)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        'DataLayoutControl
        '
        Me.DataLayoutControl.Controls.Add(Me.SupplierLookUpEdit)
        Me.DataLayoutControl.Controls.Add(Me.NumberTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.DateDateEdit)
        Me.DataLayoutControl.Controls.Add(Me.AgentNameTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.JobLookUpEdit)
        Me.DataLayoutControl.Controls.Add(Me.gcPurchaseOrderLines)
        Me.DataLayoutControl.Controls.Add(Me.PartLookUpEdit)
        Me.DataLayoutControl.Controls.Add(Me.PartGroupLookUpEdit)
        Me.DataLayoutControl.Controls.Add(Me.SupplyScopeLookUpEdit)
        Me.DataLayoutControl.Controls.Add(Me.WorkCentreLookUpEdit)
        Me.DataLayoutControl.Controls.Add(Me.WorkCentreCategoryLookUpEdit)
        Me.DataLayoutControl.Controls.Add(Me.IDSpinEdit)
        Me.DataLayoutControl.DataSource = Me.BindingSource
        Me.DataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForID, Me.ItemForSupplyScope, Me.ItemForWorkCentre, Me.ItemForPart, Me.ItemForPartGroup, Me.ItemForWorkCentreCategory, Me.ItemForAgentName})
        Me.DataLayoutControl.Location = New System.Drawing.Point(2, 21)
        Me.DataLayoutControl.Name = "DataLayoutControl"
        Me.DataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(616, 454, 250, 350)
        Me.DataLayoutControl.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl.Size = New System.Drawing.Size(804, 604)
        Me.DataLayoutControl.TabIndex = 0
        Me.DataLayoutControl.Text = "DataLayoutControl1"
        '
        'SupplierLookUpEdit
        '
        Me.SupplierLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Supplier", True))
        Me.SupplierLookUpEdit.Location = New System.Drawing.Point(477, 5)
        Me.SupplierLookUpEdit.Name = "SupplierLookUpEdit"
        Me.SupplierLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.SupplierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account", "Account", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SupplierLookUpEdit.Properties.DataSource = Me.VendorBindingSource
        Me.SupplierLookUpEdit.Properties.NullText = "(Select Supplier)"
        Me.SupplierLookUpEdit.Properties.ReadOnly = True
        Me.SupplierLookUpEdit.Size = New System.Drawing.Size(322, 20)
        Me.SupplierLookUpEdit.StyleController = Me.DataLayoutControl
        Me.SupplierLookUpEdit.TabIndex = 17
        '
        'VendorBindingSource
        '
        Me.VendorBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.Vendor)
        '
        'NumberTextEdit
        '
        Me.NumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OrderNumber", True))
        Me.NumberTextEdit.Location = New System.Drawing.Point(89, 35)
        Me.NumberTextEdit.Name = "NumberTextEdit"
        Me.NumberTextEdit.Properties.ReadOnly = True
        Me.NumberTextEdit.Size = New System.Drawing.Size(294, 20)
        Me.NumberTextEdit.StyleController = Me.DataLayoutControl
        Me.NumberTextEdit.TabIndex = 4
        '
        'DateDateEdit
        '
        Me.DateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OrderDate", True))
        Me.DateDateEdit.EditValue = Nothing
        Me.DateDateEdit.Location = New System.Drawing.Point(477, 35)
        Me.DateDateEdit.Name = "DateDateEdit"
        Me.DateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateDateEdit.Properties.ReadOnly = True
        Me.DateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateDateEdit.Size = New System.Drawing.Size(322, 20)
        Me.DateDateEdit.StyleController = Me.DataLayoutControl
        Me.DateDateEdit.TabIndex = 5
        '
        'AgentNameTextEdit
        '
        Me.AgentNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "AgentName", True))
        Me.AgentNameTextEdit.Location = New System.Drawing.Point(89, 65)
        Me.AgentNameTextEdit.Name = "AgentNameTextEdit"
        Me.AgentNameTextEdit.Properties.ReadOnly = True
        Me.AgentNameTextEdit.Size = New System.Drawing.Size(710, 20)
        Me.AgentNameTextEdit.StyleController = Me.DataLayoutControl
        Me.AgentNameTextEdit.TabIndex = 7
        '
        'JobLookUpEdit
        '
        Me.JobLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Job", True))
        Me.JobLookUpEdit.Location = New System.Drawing.Point(89, 5)
        Me.JobLookUpEdit.Name = "JobLookUpEdit"
        Me.JobLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.JobLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JobLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobNumber", "Job Number", 67, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuoteNumber", "Quote Number", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobDate", "Job Date", 53, DevExpress.Utils.FormatType.DateTime, "d", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuoteDate", "Quote Date", 66, DevExpress.Utils.FormatType.DateTime, "d", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.JobLookUpEdit.Properties.DataSource = Me.JobBindingSource
        Me.JobLookUpEdit.Properties.NullText = "(Select Job...)"
        Me.JobLookUpEdit.Size = New System.Drawing.Size(294, 20)
        Me.JobLookUpEdit.StyleController = Me.DataLayoutControl
        Me.JobLookUpEdit.TabIndex = 9
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Job)
        '
        'gcPurchaseOrderLines
        '
        Me.gcPurchaseOrderLines.DataSource = Me.PurchaseOrderLineListBindingSource
        Me.gcPurchaseOrderLines.Location = New System.Drawing.Point(5, 83)
        Me.gcPurchaseOrderLines.MainView = Me.gvPurchaseOrderLines
        Me.gcPurchaseOrderLines.Name = "gcPurchaseOrderLines"
        Me.gcPurchaseOrderLines.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riseQuantity})
        Me.gcPurchaseOrderLines.Size = New System.Drawing.Size(794, 516)
        Me.gcPurchaseOrderLines.TabIndex = 16
        Me.gcPurchaseOrderLines.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPurchaseOrderLines})
        '
        'PurchaseOrderLineListBindingSource
        '
        Me.PurchaseOrderLineListBindingSource.DataMember = "PurchaseOrderLineList"
        Me.PurchaseOrderLineListBindingSource.DataSource = Me.BindingSource
        '
        'gvPurchaseOrderLines
        '
        Me.gvPurchaseOrderLines.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.RequisitionLinesGridBand})
        Me.gvPurchaseOrderLines.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colInventoryItem, Me.colQuantity, Me.colUnitCost, Me.colTotalCost, Me.colLineNote, Me.colJobLine, Me.colID})
        Me.gvPurchaseOrderLines.GridControl = Me.gcPurchaseOrderLines
        Me.gvPurchaseOrderLines.Name = "gvPurchaseOrderLines"
        Me.gvPurchaseOrderLines.OptionsView.ShowBands = False
        Me.gvPurchaseOrderLines.OptionsView.ShowFooter = True
        Me.gvPurchaseOrderLines.OptionsView.ShowGroupPanel = False
        '
        'RequisitionLinesGridBand
        '
        Me.RequisitionLinesGridBand.Caption = "Requisition Lines"
        Me.RequisitionLinesGridBand.Columns.Add(Me.colInventoryItem)
        Me.RequisitionLinesGridBand.Columns.Add(Me.colQuantity)
        Me.RequisitionLinesGridBand.Columns.Add(Me.colUnitCost)
        Me.RequisitionLinesGridBand.Columns.Add(Me.colTotalCost)
        Me.RequisitionLinesGridBand.Columns.Add(Me.colJobLine)
        Me.RequisitionLinesGridBand.Columns.Add(Me.colID)
        Me.RequisitionLinesGridBand.Columns.Add(Me.colLineNote)
        Me.RequisitionLinesGridBand.Name = "RequisitionLinesGridBand"
        Me.RequisitionLinesGridBand.Width = 313
        '
        'colInventoryItem
        '
        Me.colInventoryItem.FieldName = "InventoryItem"
        Me.colInventoryItem.Name = "colInventoryItem"
        Me.colInventoryItem.OptionsColumn.ReadOnly = True
        Me.colInventoryItem.Visible = True
        Me.colInventoryItem.Width = 223
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
        Me.colQuantity.Width = 90
        '
        'riseQuantity
        '
        Me.riseQuantity.AutoHeight = False
        Me.riseQuantity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.riseQuantity.DisplayFormat.FormatString = "f"
        Me.riseQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.riseQuantity.EditFormat.FormatString = "f"
        Me.riseQuantity.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.riseQuantity.Name = "riseQuantity"
        '
        'colUnitCost
        '
        Me.colUnitCost.DisplayFormat.FormatString = "c"
        Me.colUnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitCost.FieldName = "UnitCost"
        Me.colUnitCost.GroupFormat.FormatString = "c"
        Me.colUnitCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitCost.Name = "colUnitCost"
        Me.colUnitCost.OptionsColumn.ReadOnly = True
        Me.colUnitCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitCost", "{0:c2}")})
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
        '
        'colJobLine
        '
        Me.colJobLine.Caption = "Job Line ID"
        Me.colJobLine.FieldName = "JobLine.ID"
        Me.colJobLine.Name = "colJobLine"
        Me.colJobLine.OptionsColumn.ReadOnly = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colLineNote
        '
        Me.colLineNote.FieldName = "LineNote"
        Me.colLineNote.Name = "colLineNote"
        Me.colLineNote.RowIndex = 1
        Me.colLineNote.Visible = True
        Me.colLineNote.Width = 313
        '
        'PartLookUpEdit
        '
        Me.PartLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Part", True))
        Me.PartLookUpEdit.Location = New System.Drawing.Point(119, 65)
        Me.PartLookUpEdit.Name = "PartLookUpEdit"
        Me.PartLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.PartLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.PartLookUpEdit.Properties.DataSource = Me.PartBindingSource
        Me.PartLookUpEdit.Properties.NullText = "(Select Part...)"
        Me.PartLookUpEdit.Size = New System.Drawing.Size(218, 20)
        Me.PartLookUpEdit.StyleController = Me.DataLayoutControl
        Me.PartLookUpEdit.TabIndex = 10
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Part)
        '
        'PartGroupLookUpEdit
        '
        Me.PartGroupLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PartGroup", True))
        Me.PartGroupLookUpEdit.Location = New System.Drawing.Point(119, 65)
        Me.PartGroupLookUpEdit.Name = "PartGroupLookUpEdit"
        Me.PartGroupLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.PartGroupLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartGroupLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.PartGroupLookUpEdit.Properties.DataSource = Me.PartGroupBindingSource
        Me.PartGroupLookUpEdit.Properties.NullText = "(Select Part Group...)"
        Me.PartGroupLookUpEdit.Size = New System.Drawing.Size(561, 20)
        Me.PartGroupLookUpEdit.StyleController = Me.DataLayoutControl
        Me.PartGroupLookUpEdit.TabIndex = 11
        '
        'PartGroupBindingSource
        '
        Me.PartGroupBindingSource.DataSource = GetType(UniSource.ShopFloor.API.PartGroup)
        '
        'SupplyScopeLookUpEdit
        '
        Me.SupplyScopeLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "SupplyScope", True))
        Me.SupplyScopeLookUpEdit.Location = New System.Drawing.Point(119, 95)
        Me.SupplyScopeLookUpEdit.Name = "SupplyScopeLookUpEdit"
        Me.SupplyScopeLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.SupplyScopeLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplyScopeLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SupplyScopeLookUpEdit.Properties.DataSource = Me.SupplyScopeBindingSource
        Me.SupplyScopeLookUpEdit.Properties.NullText = "(Select Supply Scope..)"
        Me.SupplyScopeLookUpEdit.Size = New System.Drawing.Size(561, 20)
        Me.SupplyScopeLookUpEdit.StyleController = Me.DataLayoutControl
        Me.SupplyScopeLookUpEdit.TabIndex = 12
        '
        'SupplyScopeBindingSource
        '
        Me.SupplyScopeBindingSource.DataSource = GetType(UniSource.ShopFloor.API.SupplyScope)
        '
        'WorkCentreLookUpEdit
        '
        Me.WorkCentreLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "WorkCentre", True))
        Me.WorkCentreLookUpEdit.Location = New System.Drawing.Point(119, 95)
        Me.WorkCentreLookUpEdit.Name = "WorkCentreLookUpEdit"
        Me.WorkCentreLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.WorkCentreLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WorkCentreLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.WorkCentreLookUpEdit.Properties.DataSource = Me.WorkCentreBindingSource
        Me.WorkCentreLookUpEdit.Properties.NullText = "(Select Work Centre...)"
        Me.WorkCentreLookUpEdit.Size = New System.Drawing.Size(218, 20)
        Me.WorkCentreLookUpEdit.StyleController = Me.DataLayoutControl
        Me.WorkCentreLookUpEdit.TabIndex = 13
        '
        'WorkCentreBindingSource
        '
        Me.WorkCentreBindingSource.DataSource = GetType(UniSource.ShopFloor.API.WorkCentre)
        '
        'WorkCentreCategoryLookUpEdit
        '
        Me.WorkCentreCategoryLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "WorkCentreCategory", True))
        Me.WorkCentreCategoryLookUpEdit.Location = New System.Drawing.Point(119, 65)
        Me.WorkCentreCategoryLookUpEdit.Name = "WorkCentreCategoryLookUpEdit"
        Me.WorkCentreCategoryLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.WorkCentreCategoryLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WorkCentreCategoryLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.WorkCentreCategoryLookUpEdit.Properties.DataSource = Me.WorkCentreCategoryBindingSource
        Me.WorkCentreCategoryLookUpEdit.Properties.NullText = "(Select Work Centre Category...)"
        Me.WorkCentreCategoryLookUpEdit.Size = New System.Drawing.Size(561, 20)
        Me.WorkCentreCategoryLookUpEdit.StyleController = Me.DataLayoutControl
        Me.WorkCentreCategoryLookUpEdit.TabIndex = 14
        '
        'WorkCentreCategoryBindingSource
        '
        Me.WorkCentreCategoryBindingSource.DataSource = GetType(UniSource.ShopFloor.API.WorkCentreCategory)
        '
        'IDSpinEdit
        '
        Me.IDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IDSpinEdit.Location = New System.Drawing.Point(119, 275)
        Me.IDSpinEdit.Name = "IDSpinEdit"
        Me.IDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.IDSpinEdit.Properties.ReadOnly = True
        Me.IDSpinEdit.Size = New System.Drawing.Size(561, 20)
        Me.IDSpinEdit.StyleController = Me.DataLayoutControl
        Me.IDSpinEdit.TabIndex = 15
        '
        'ItemForID
        '
        Me.ItemForID.Control = Me.IDSpinEdit
        Me.ItemForID.CustomizationFormText = "ID"
        Me.ItemForID.Location = New System.Drawing.Point(0, 270)
        Me.ItemForID.Name = "ItemForID"
        Me.ItemForID.Size = New System.Drawing.Size(685, 75)
        Me.ItemForID.Text = "ID"
        Me.ItemForID.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForID.TextToControlDistance = 5
        '
        'ItemForSupplyScope
        '
        Me.ItemForSupplyScope.Control = Me.SupplyScopeLookUpEdit
        Me.ItemForSupplyScope.CustomizationFormText = "Supply Scope"
        Me.ItemForSupplyScope.Location = New System.Drawing.Point(0, 90)
        Me.ItemForSupplyScope.Name = "ItemForSupplyScope"
        Me.ItemForSupplyScope.Size = New System.Drawing.Size(685, 30)
        Me.ItemForSupplyScope.Text = "Supply Scope"
        Me.ItemForSupplyScope.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForSupplyScope.TextToControlDistance = 5
        '
        'ItemForWorkCentre
        '
        Me.ItemForWorkCentre.Control = Me.WorkCentreLookUpEdit
        Me.ItemForWorkCentre.CustomizationFormText = "Work Centre"
        Me.ItemForWorkCentre.Location = New System.Drawing.Point(0, 90)
        Me.ItemForWorkCentre.Name = "ItemForWorkCentre"
        Me.ItemForWorkCentre.Size = New System.Drawing.Size(342, 255)
        Me.ItemForWorkCentre.Text = "Work Centre"
        Me.ItemForWorkCentre.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForWorkCentre.TextToControlDistance = 5
        '
        'ItemForPart
        '
        Me.ItemForPart.Control = Me.PartLookUpEdit
        Me.ItemForPart.CustomizationFormText = "Part"
        Me.ItemForPart.Location = New System.Drawing.Point(0, 60)
        Me.ItemForPart.Name = "ItemForPart"
        Me.ItemForPart.Size = New System.Drawing.Size(342, 30)
        Me.ItemForPart.Text = "Part"
        Me.ItemForPart.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForPart.TextToControlDistance = 5
        '
        'ItemForPartGroup
        '
        Me.ItemForPartGroup.Control = Me.PartGroupLookUpEdit
        Me.ItemForPartGroup.CustomizationFormText = "Part Group"
        Me.ItemForPartGroup.Location = New System.Drawing.Point(0, 60)
        Me.ItemForPartGroup.Name = "ItemForPartGroup"
        Me.ItemForPartGroup.Size = New System.Drawing.Size(685, 30)
        Me.ItemForPartGroup.Text = "Part Group"
        Me.ItemForPartGroup.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForPartGroup.TextToControlDistance = 5
        '
        'ItemForWorkCentreCategory
        '
        Me.ItemForWorkCentreCategory.Control = Me.WorkCentreCategoryLookUpEdit
        Me.ItemForWorkCentreCategory.CustomizationFormText = "Work Centre Category"
        Me.ItemForWorkCentreCategory.Location = New System.Drawing.Point(0, 60)
        Me.ItemForWorkCentreCategory.Name = "ItemForWorkCentreCategory"
        Me.ItemForWorkCentreCategory.Size = New System.Drawing.Size(685, 285)
        Me.ItemForWorkCentreCategory.Text = "Work Centre Category"
        Me.ItemForWorkCentreCategory.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForWorkCentreCategory.TextToControlDistance = 5
        '
        'ItemForAgentName
        '
        Me.ItemForAgentName.Control = Me.AgentNameTextEdit
        Me.ItemForAgentName.CustomizationFormText = "Agent Name"
        Me.ItemForAgentName.Location = New System.Drawing.Point(0, 60)
        Me.ItemForAgentName.Name = "ItemForAgentName"
        Me.ItemForAgentName.Size = New System.Drawing.Size(804, 30)
        Me.ItemForAgentName.Text = "Agent Name"
        Me.ItemForAgentName.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForAgentName.TextToControlDistance = 5
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(804, 604)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForRequisitionLines, Me.ItemForSupplier, Me.ItemForJob, Me.ItemForDate, Me.ItemForNumber})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(804, 604)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForRequisitionLines
        '
        Me.ItemForRequisitionLines.Control = Me.gcPurchaseOrderLines
        Me.ItemForRequisitionLines.CustomizationFormText = "Requisition Lines"
        Me.ItemForRequisitionLines.Location = New System.Drawing.Point(0, 60)
        Me.ItemForRequisitionLines.Name = "ItemForRequisitionLines"
        Me.ItemForRequisitionLines.Size = New System.Drawing.Size(804, 544)
        Me.ItemForRequisitionLines.Text = "Requisition Lines"
        Me.ItemForRequisitionLines.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForRequisitionLines.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForRequisitionLines.TextToControlDistance = 5
        '
        'ItemForSupplier
        '
        Me.ItemForSupplier.Control = Me.SupplierLookUpEdit
        Me.ItemForSupplier.CustomizationFormText = "Supplier"
        Me.ItemForSupplier.Location = New System.Drawing.Point(388, 0)
        Me.ItemForSupplier.Name = "ItemForSupplier"
        Me.ItemForSupplier.Size = New System.Drawing.Size(416, 30)
        Me.ItemForSupplier.Text = "Supplier"
        Me.ItemForSupplier.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForSupplier.TextToControlDistance = 5
        '
        'ItemForJob
        '
        Me.ItemForJob.Control = Me.JobLookUpEdit
        Me.ItemForJob.CustomizationFormText = "Job"
        Me.ItemForJob.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJob.Name = "ItemForJob"
        Me.ItemForJob.Size = New System.Drawing.Size(388, 30)
        Me.ItemForJob.Text = "Job"
        Me.ItemForJob.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForJob.TextToControlDistance = 5
        '
        'ItemForDate
        '
        Me.ItemForDate.Control = Me.DateDateEdit
        Me.ItemForDate.CustomizationFormText = "Date"
        Me.ItemForDate.Location = New System.Drawing.Point(388, 30)
        Me.ItemForDate.Name = "ItemForDate"
        Me.ItemForDate.Size = New System.Drawing.Size(416, 30)
        Me.ItemForDate.Text = "Date"
        Me.ItemForDate.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForDate.TextToControlDistance = 5
        '
        'ItemForNumber
        '
        Me.ItemForNumber.Control = Me.NumberTextEdit
        Me.ItemForNumber.CustomizationFormText = "Number"
        Me.ItemForNumber.Location = New System.Drawing.Point(0, 30)
        Me.ItemForNumber.Name = "ItemForNumber"
        Me.ItemForNumber.Size = New System.Drawing.Size(388, 30)
        Me.ItemForNumber.Text = "Number"
        Me.ItemForNumber.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForNumber.TextToControlDistance = 5
        '
        'xaePurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 681)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = True
        Me.Name = "xaePurchaseOrder"
        Me.Text = "Purchase Order"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl.ResumeLayout(False)
        CType(Me.SupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPurchaseOrderLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderLineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPurchaseOrderLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartGroupLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyScopeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyScopeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSupplyScope, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWorkCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPartGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAgentName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRequisitionLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents NumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AgentNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PartLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PartGroupLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SupplyScopeLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents WorkCentreLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents WorkCentreCategoryLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAgentName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJob As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPart As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPartGroup As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForSupplyScope As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWorkCentre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWorkCentreCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gcPurchaseOrderLines As DevExpress.XtraGrid.GridControl
    Friend WithEvents PurchaseOrderLineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplyScopeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkCentreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkCentreCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemForRequisitionLines As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gvPurchaseOrderLines As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents colInventoryItem As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnitCost As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colJobLine As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLineNote As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RequisitionLinesGridBand As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents riseQuantity As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SupplierLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents VendorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemForSupplier As DevExpress.XtraLayout.LayoutControlItem
End Class
