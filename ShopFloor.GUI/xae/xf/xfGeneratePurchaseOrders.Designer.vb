<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfGeneratePurchaseOrders
    Inherits UniSource.ShopFloor.GUI.xfgGeneratePurchaseOrders

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
        Me.gcPurchaseOrderLines = New DevExpress.XtraGrid.GridControl()
        Me.PurchaseOrderLineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvPurchaseOrderLines = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colInventoryItem = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colERPPurchaseOrderLineID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.riseQuantity = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colUnitPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colJobLine = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLineNote = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.SupplierTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ERPPurchaseOrderIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.OrderNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GRVNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrderDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RequiredDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.GRVDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AgentIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AgentNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PartTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PartGroupTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SupplyScopeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkCentreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkCentreCategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAgentID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForERPPurchaseOrderID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAgentName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJob = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPart = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPartGroup = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSupplyScope = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWorkCentre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForWorkCentreCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForSupplier = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrderNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForGRVNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForGRVDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrderDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRequiredDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForPurchaseOrderLines = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordsLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.gcPurchaseOrderLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderLineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPurchaseOrderLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERPPurchaseOrderIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRVNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequiredDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequiredDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRVDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRVDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartGroupTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyScopeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAgentID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForERPPurchaseOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAgentName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPartGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSupplyScope, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWorkCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForGRVNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForGRVDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRequiredDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPurchaseOrderLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(871, 600)
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(728, 645)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(809, 645)
        '
        'RecordsLookUpEdit
        '
        Me.RecordsLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Supplier", "Supplier", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderNumber", "Order Number", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderDate", "Order Date", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RecordsLookUpEdit.Properties.DisplayMember = "Supplier"
        Me.RecordsLookUpEdit.Size = New System.Drawing.Size(871, 20)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.gcPurchaseOrderLines)
        Me.DataLayoutControl1.Controls.Add(Me.SupplierTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ERPPurchaseOrderIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OrderNumberTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.GRVNumberTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OrderDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RequiredDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.GRVDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AgentIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AgentNameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JobTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PartTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PartGroupTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.SupplyScopeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.WorkCentreTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.WorkCentreCategoryTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForID, Me.ItemForAgentID, Me.ItemForERPPurchaseOrderID, Me.ItemForAgentName, Me.ItemForJob, Me.ItemForPart, Me.ItemForPartGroup, Me.ItemForSupplyScope, Me.ItemForWorkCentre, Me.ItemForWorkCentreCategory})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 21)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(867, 577)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'gcPurchaseOrderLines
        '
        Me.gcPurchaseOrderLines.DataSource = Me.PurchaseOrderLineListBindingSource
        Me.gcPurchaseOrderLines.Location = New System.Drawing.Point(5, 113)
        Me.gcPurchaseOrderLines.MainView = Me.gvPurchaseOrderLines
        Me.gcPurchaseOrderLines.Name = "gcPurchaseOrderLines"
        Me.gcPurchaseOrderLines.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riseQuantity})
        Me.gcPurchaseOrderLines.Size = New System.Drawing.Size(857, 459)
        Me.gcPurchaseOrderLines.TabIndex = 21
        Me.gcPurchaseOrderLines.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPurchaseOrderLines})
        '
        'PurchaseOrderLineListBindingSource
        '
        Me.PurchaseOrderLineListBindingSource.DataMember = "PurchaseOrderLineList"
        Me.PurchaseOrderLineListBindingSource.DataSource = Me.BindingSource
        '
        'gvPurchaseOrderLines
        '
        Me.gvPurchaseOrderLines.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.gvPurchaseOrderLines.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colTotalPrice, Me.colInventoryItem, Me.colDescription, Me.colERPPurchaseOrderLineID, Me.colQuantity, Me.colUnitPrice, Me.colLineNote, Me.colJobLine, Me.colID})
        Me.gvPurchaseOrderLines.CustomizationFormBounds = New System.Drawing.Rectangle(705, 507, 222, 221)
        Me.gvPurchaseOrderLines.GridControl = Me.gcPurchaseOrderLines
        Me.gvPurchaseOrderLines.Name = "gvPurchaseOrderLines"
        Me.gvPurchaseOrderLines.OptionsView.ShowBands = False
        Me.gvPurchaseOrderLines.OptionsView.ShowFooter = True
        Me.gvPurchaseOrderLines.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colInventoryItem)
        Me.GridBand1.Columns.Add(Me.colERPPurchaseOrderLineID)
        Me.GridBand1.Columns.Add(Me.colDescription)
        Me.GridBand1.Columns.Add(Me.colQuantity)
        Me.GridBand1.Columns.Add(Me.colUnitPrice)
        Me.GridBand1.Columns.Add(Me.colTotalPrice)
        Me.GridBand1.Columns.Add(Me.colJobLine)
        Me.GridBand1.Columns.Add(Me.colID)
        Me.GridBand1.Columns.Add(Me.colLineNote)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 608
        '
        'colInventoryItem
        '
        Me.colInventoryItem.FieldName = "InventoryItem"
        Me.colInventoryItem.Name = "colInventoryItem"
        Me.colInventoryItem.OptionsColumn.ReadOnly = True
        Me.colInventoryItem.Visible = True
        Me.colInventoryItem.Width = 192
        '
        'colERPPurchaseOrderLineID
        '
        Me.colERPPurchaseOrderLineID.FieldName = "ERPPurchaseOrderLineID"
        Me.colERPPurchaseOrderLineID.Name = "colERPPurchaseOrderLineID"
        Me.colERPPurchaseOrderLineID.OptionsColumn.ReadOnly = True
        Me.colERPPurchaseOrderLineID.Width = 142
        '
        'colDescription
        '
        Me.colDescription.Caption = "Description"
        Me.colDescription.FieldName = "JobLine.Description1"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.Width = 200
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
        Me.colQuantity.Width = 72
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
        Me.colTotalPrice.Width = 69
        '
        'colJobLine
        '
        Me.colJobLine.FieldName = "JobLine"
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
        Me.colLineNote.Width = 562
        '
        'SupplierTextEdit
        '
        Me.SupplierTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Supplier", True))
        Me.SupplierTextEdit.Location = New System.Drawing.Point(112, 5)
        Me.SupplierTextEdit.Name = "SupplierTextEdit"
        Me.SupplierTextEdit.Size = New System.Drawing.Size(316, 20)
        Me.SupplierTextEdit.StyleController = Me.DataLayoutControl1
        Me.SupplierTextEdit.TabIndex = 4
        '
        'ERPPurchaseOrderIDSpinEdit
        '
        Me.ERPPurchaseOrderIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ERPPurchaseOrderID", True))
        Me.ERPPurchaseOrderIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ERPPurchaseOrderIDSpinEdit.Location = New System.Drawing.Point(121, 35)
        Me.ERPPurchaseOrderIDSpinEdit.Name = "ERPPurchaseOrderIDSpinEdit"
        Me.ERPPurchaseOrderIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ERPPurchaseOrderIDSpinEdit.Properties.ReadOnly = True
        Me.ERPPurchaseOrderIDSpinEdit.Size = New System.Drawing.Size(741, 20)
        Me.ERPPurchaseOrderIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.ERPPurchaseOrderIDSpinEdit.TabIndex = 5
        '
        'OrderNumberTextEdit
        '
        Me.OrderNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OrderNumber", True))
        Me.OrderNumberTextEdit.Location = New System.Drawing.Point(112, 35)
        Me.OrderNumberTextEdit.Name = "OrderNumberTextEdit"
        Me.OrderNumberTextEdit.Size = New System.Drawing.Size(316, 20)
        Me.OrderNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.OrderNumberTextEdit.TabIndex = 6
        '
        'GRVNumberTextEdit
        '
        Me.GRVNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "GRVNumber", True))
        Me.GRVNumberTextEdit.Location = New System.Drawing.Point(112, 65)
        Me.GRVNumberTextEdit.Name = "GRVNumberTextEdit"
        Me.GRVNumberTextEdit.Properties.ReadOnly = True
        Me.GRVNumberTextEdit.Size = New System.Drawing.Size(316, 20)
        Me.GRVNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.GRVNumberTextEdit.TabIndex = 7
        '
        'OrderDateDateEdit
        '
        Me.OrderDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OrderDate", True))
        Me.OrderDateDateEdit.EditValue = Nothing
        Me.OrderDateDateEdit.Location = New System.Drawing.Point(545, 35)
        Me.OrderDateDateEdit.Name = "OrderDateDateEdit"
        Me.OrderDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderDateDateEdit.Size = New System.Drawing.Size(317, 20)
        Me.OrderDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.OrderDateDateEdit.TabIndex = 8
        '
        'RequiredDateDateEdit
        '
        Me.RequiredDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "RequiredDate", True))
        Me.RequiredDateDateEdit.EditValue = Nothing
        Me.RequiredDateDateEdit.Location = New System.Drawing.Point(545, 5)
        Me.RequiredDateDateEdit.Name = "RequiredDateDateEdit"
        Me.RequiredDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequiredDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RequiredDateDateEdit.Size = New System.Drawing.Size(317, 20)
        Me.RequiredDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.RequiredDateDateEdit.TabIndex = 9
        '
        'GRVDateDateEdit
        '
        Me.GRVDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "GRVDate", True))
        Me.GRVDateDateEdit.EditValue = Nothing
        Me.GRVDateDateEdit.Location = New System.Drawing.Point(545, 65)
        Me.GRVDateDateEdit.Name = "GRVDateDateEdit"
        Me.GRVDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GRVDateDateEdit.Properties.ReadOnly = True
        Me.GRVDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GRVDateDateEdit.Size = New System.Drawing.Size(317, 20)
        Me.GRVDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.GRVDateDateEdit.TabIndex = 10
        '
        'AgentIDSpinEdit
        '
        Me.AgentIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "AgentID", True))
        Me.AgentIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AgentIDSpinEdit.Location = New System.Drawing.Point(121, 215)
        Me.AgentIDSpinEdit.Name = "AgentIDSpinEdit"
        Me.AgentIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AgentIDSpinEdit.Properties.ReadOnly = True
        Me.AgentIDSpinEdit.Size = New System.Drawing.Size(741, 20)
        Me.AgentIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.AgentIDSpinEdit.TabIndex = 11
        '
        'AgentNameTextEdit
        '
        Me.AgentNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "AgentName", True))
        Me.AgentNameTextEdit.Location = New System.Drawing.Point(119, 95)
        Me.AgentNameTextEdit.Name = "AgentNameTextEdit"
        Me.AgentNameTextEdit.Properties.ReadOnly = True
        Me.AgentNameTextEdit.Size = New System.Drawing.Size(743, 20)
        Me.AgentNameTextEdit.StyleController = Me.DataLayoutControl1
        Me.AgentNameTextEdit.TabIndex = 12
        '
        'JobTextEdit
        '
        Me.JobTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Job", True))
        Me.JobTextEdit.Location = New System.Drawing.Point(119, 95)
        Me.JobTextEdit.Name = "JobTextEdit"
        Me.JobTextEdit.Properties.ReadOnly = True
        Me.JobTextEdit.Size = New System.Drawing.Size(743, 20)
        Me.JobTextEdit.StyleController = Me.DataLayoutControl1
        Me.JobTextEdit.TabIndex = 14
        '
        'PartTextEdit
        '
        Me.PartTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Part", True))
        Me.PartTextEdit.Location = New System.Drawing.Point(119, 95)
        Me.PartTextEdit.Name = "PartTextEdit"
        Me.PartTextEdit.Properties.ReadOnly = True
        Me.PartTextEdit.Size = New System.Drawing.Size(743, 20)
        Me.PartTextEdit.StyleController = Me.DataLayoutControl1
        Me.PartTextEdit.TabIndex = 15
        '
        'PartGroupTextEdit
        '
        Me.PartGroupTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PartGroup", True))
        Me.PartGroupTextEdit.Location = New System.Drawing.Point(119, 95)
        Me.PartGroupTextEdit.Name = "PartGroupTextEdit"
        Me.PartGroupTextEdit.Properties.ReadOnly = True
        Me.PartGroupTextEdit.Size = New System.Drawing.Size(743, 20)
        Me.PartGroupTextEdit.StyleController = Me.DataLayoutControl1
        Me.PartGroupTextEdit.TabIndex = 16
        '
        'SupplyScopeTextEdit
        '
        Me.SupplyScopeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "SupplyScope", True))
        Me.SupplyScopeTextEdit.Location = New System.Drawing.Point(119, 95)
        Me.SupplyScopeTextEdit.Name = "SupplyScopeTextEdit"
        Me.SupplyScopeTextEdit.Properties.ReadOnly = True
        Me.SupplyScopeTextEdit.Size = New System.Drawing.Size(743, 20)
        Me.SupplyScopeTextEdit.StyleController = Me.DataLayoutControl1
        Me.SupplyScopeTextEdit.TabIndex = 17
        '
        'WorkCentreTextEdit
        '
        Me.WorkCentreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "WorkCentre", True))
        Me.WorkCentreTextEdit.Location = New System.Drawing.Point(119, 95)
        Me.WorkCentreTextEdit.Name = "WorkCentreTextEdit"
        Me.WorkCentreTextEdit.Properties.ReadOnly = True
        Me.WorkCentreTextEdit.Size = New System.Drawing.Size(743, 20)
        Me.WorkCentreTextEdit.StyleController = Me.DataLayoutControl1
        Me.WorkCentreTextEdit.TabIndex = 18
        '
        'WorkCentreCategoryTextEdit
        '
        Me.WorkCentreCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "WorkCentreCategory", True))
        Me.WorkCentreCategoryTextEdit.Location = New System.Drawing.Point(119, 95)
        Me.WorkCentreCategoryTextEdit.Name = "WorkCentreCategoryTextEdit"
        Me.WorkCentreCategoryTextEdit.Properties.ReadOnly = True
        Me.WorkCentreCategoryTextEdit.Size = New System.Drawing.Size(743, 20)
        Me.WorkCentreCategoryTextEdit.StyleController = Me.DataLayoutControl1
        Me.WorkCentreCategoryTextEdit.TabIndex = 19
        '
        'IDSpinEdit
        '
        Me.IDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IDSpinEdit.Location = New System.Drawing.Point(121, 485)
        Me.IDSpinEdit.Name = "IDSpinEdit"
        Me.IDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.IDSpinEdit.Properties.ReadOnly = True
        Me.IDSpinEdit.Size = New System.Drawing.Size(741, 20)
        Me.IDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.IDSpinEdit.TabIndex = 20
        '
        'ItemForID
        '
        Me.ItemForID.Control = Me.IDSpinEdit
        Me.ItemForID.CustomizationFormText = "ID"
        Me.ItemForID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForID.Name = "ItemForID"
        Me.ItemForID.Size = New System.Drawing.Size(867, 97)
        Me.ItemForID.Text = "ID"
        Me.ItemForID.TextSize = New System.Drawing.Size(111, 13)
        Me.ItemForID.TextToControlDistance = 5
        '
        'ItemForAgentID
        '
        Me.ItemForAgentID.Control = Me.AgentIDSpinEdit
        Me.ItemForAgentID.CustomizationFormText = "Agent ID"
        Me.ItemForAgentID.Location = New System.Drawing.Point(0, 210)
        Me.ItemForAgentID.Name = "ItemForAgentID"
        Me.ItemForAgentID.Size = New System.Drawing.Size(867, 30)
        Me.ItemForAgentID.Text = "Agent ID"
        Me.ItemForAgentID.TextSize = New System.Drawing.Size(111, 13)
        Me.ItemForAgentID.TextToControlDistance = 5
        '
        'ItemForERPPurchaseOrderID
        '
        Me.ItemForERPPurchaseOrderID.Control = Me.ERPPurchaseOrderIDSpinEdit
        Me.ItemForERPPurchaseOrderID.CustomizationFormText = "ERP Purchase Order ID"
        Me.ItemForERPPurchaseOrderID.Location = New System.Drawing.Point(0, 30)
        Me.ItemForERPPurchaseOrderID.Name = "ItemForERPPurchaseOrderID"
        Me.ItemForERPPurchaseOrderID.Size = New System.Drawing.Size(867, 30)
        Me.ItemForERPPurchaseOrderID.Text = "ERP Purchase Order ID"
        Me.ItemForERPPurchaseOrderID.TextSize = New System.Drawing.Size(111, 13)
        Me.ItemForERPPurchaseOrderID.TextToControlDistance = 5
        '
        'ItemForAgentName
        '
        Me.ItemForAgentName.Control = Me.AgentNameTextEdit
        Me.ItemForAgentName.CustomizationFormText = "Agent Name"
        Me.ItemForAgentName.Location = New System.Drawing.Point(0, 90)
        Me.ItemForAgentName.Name = "ItemForAgentName"
        Me.ItemForAgentName.Size = New System.Drawing.Size(867, 30)
        Me.ItemForAgentName.Text = "Agent Name"
        Me.ItemForAgentName.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForAgentName.TextToControlDistance = 5
        '
        'ItemForJob
        '
        Me.ItemForJob.Control = Me.JobTextEdit
        Me.ItemForJob.CustomizationFormText = "Job"
        Me.ItemForJob.Location = New System.Drawing.Point(0, 90)
        Me.ItemForJob.Name = "ItemForJob"
        Me.ItemForJob.Size = New System.Drawing.Size(867, 30)
        Me.ItemForJob.Text = "Job"
        Me.ItemForJob.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForJob.TextToControlDistance = 5
        '
        'ItemForPart
        '
        Me.ItemForPart.Control = Me.PartTextEdit
        Me.ItemForPart.CustomizationFormText = "Part"
        Me.ItemForPart.Location = New System.Drawing.Point(0, 90)
        Me.ItemForPart.Name = "ItemForPart"
        Me.ItemForPart.Size = New System.Drawing.Size(867, 30)
        Me.ItemForPart.Text = "Part"
        Me.ItemForPart.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForPart.TextToControlDistance = 5
        '
        'ItemForPartGroup
        '
        Me.ItemForPartGroup.Control = Me.PartGroupTextEdit
        Me.ItemForPartGroup.CustomizationFormText = "Part Group"
        Me.ItemForPartGroup.Location = New System.Drawing.Point(0, 90)
        Me.ItemForPartGroup.Name = "ItemForPartGroup"
        Me.ItemForPartGroup.Size = New System.Drawing.Size(867, 30)
        Me.ItemForPartGroup.Text = "Part Group"
        Me.ItemForPartGroup.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForPartGroup.TextToControlDistance = 5
        '
        'ItemForSupplyScope
        '
        Me.ItemForSupplyScope.Control = Me.SupplyScopeTextEdit
        Me.ItemForSupplyScope.CustomizationFormText = "Supply Scope"
        Me.ItemForSupplyScope.Location = New System.Drawing.Point(0, 90)
        Me.ItemForSupplyScope.Name = "ItemForSupplyScope"
        Me.ItemForSupplyScope.Size = New System.Drawing.Size(867, 30)
        Me.ItemForSupplyScope.Text = "Supply Scope"
        Me.ItemForSupplyScope.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForSupplyScope.TextToControlDistance = 5
        '
        'ItemForWorkCentre
        '
        Me.ItemForWorkCentre.Control = Me.WorkCentreTextEdit
        Me.ItemForWorkCentre.CustomizationFormText = "Work Centre"
        Me.ItemForWorkCentre.Location = New System.Drawing.Point(0, 90)
        Me.ItemForWorkCentre.Name = "ItemForWorkCentre"
        Me.ItemForWorkCentre.Size = New System.Drawing.Size(867, 30)
        Me.ItemForWorkCentre.Text = "Work Centre"
        Me.ItemForWorkCentre.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForWorkCentre.TextToControlDistance = 5
        '
        'ItemForWorkCentreCategory
        '
        Me.ItemForWorkCentreCategory.Control = Me.WorkCentreCategoryTextEdit
        Me.ItemForWorkCentreCategory.CustomizationFormText = "Work Centre Category"
        Me.ItemForWorkCentreCategory.Location = New System.Drawing.Point(0, 90)
        Me.ItemForWorkCentreCategory.Name = "ItemForWorkCentreCategory"
        Me.ItemForWorkCentreCategory.Size = New System.Drawing.Size(867, 30)
        Me.ItemForWorkCentreCategory.Text = "Work Centre Category"
        Me.ItemForWorkCentreCategory.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForWorkCentreCategory.TextToControlDistance = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(867, 577)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForSupplier, Me.ItemForOrderNumber, Me.ItemForGRVNumber, Me.ItemForGRVDate, Me.ItemForOrderDate, Me.ItemForRequiredDate})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(867, 90)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForSupplier
        '
        Me.ItemForSupplier.Control = Me.SupplierTextEdit
        Me.ItemForSupplier.CustomizationFormText = "Supplier"
        Me.ItemForSupplier.Location = New System.Drawing.Point(0, 0)
        Me.ItemForSupplier.Name = "ItemForSupplier"
        Me.ItemForSupplier.Size = New System.Drawing.Size(433, 30)
        Me.ItemForSupplier.Text = "Supplier"
        Me.ItemForSupplier.TextSize = New System.Drawing.Size(102, 13)
        Me.ItemForSupplier.TextToControlDistance = 5
        '
        'ItemForOrderNumber
        '
        Me.ItemForOrderNumber.Control = Me.OrderNumberTextEdit
        Me.ItemForOrderNumber.CustomizationFormText = "Order Number"
        Me.ItemForOrderNumber.Location = New System.Drawing.Point(0, 30)
        Me.ItemForOrderNumber.Name = "ItemForOrderNumber"
        Me.ItemForOrderNumber.Size = New System.Drawing.Size(433, 30)
        Me.ItemForOrderNumber.Text = "Order Number"
        Me.ItemForOrderNumber.TextSize = New System.Drawing.Size(102, 13)
        Me.ItemForOrderNumber.TextToControlDistance = 5
        '
        'ItemForGRVNumber
        '
        Me.ItemForGRVNumber.Control = Me.GRVNumberTextEdit
        Me.ItemForGRVNumber.CustomizationFormText = "GRV Number"
        Me.ItemForGRVNumber.Location = New System.Drawing.Point(0, 60)
        Me.ItemForGRVNumber.Name = "ItemForGRVNumber"
        Me.ItemForGRVNumber.Size = New System.Drawing.Size(433, 30)
        Me.ItemForGRVNumber.Text = "GRV Number"
        Me.ItemForGRVNumber.TextSize = New System.Drawing.Size(102, 13)
        Me.ItemForGRVNumber.TextToControlDistance = 5
        '
        'ItemForGRVDate
        '
        Me.ItemForGRVDate.Control = Me.GRVDateDateEdit
        Me.ItemForGRVDate.CustomizationFormText = "GRV Date"
        Me.ItemForGRVDate.Location = New System.Drawing.Point(433, 60)
        Me.ItemForGRVDate.Name = "ItemForGRVDate"
        Me.ItemForGRVDate.Size = New System.Drawing.Size(434, 30)
        Me.ItemForGRVDate.Text = "GRV Date"
        Me.ItemForGRVDate.TextSize = New System.Drawing.Size(102, 13)
        Me.ItemForGRVDate.TextToControlDistance = 5
        '
        'ItemForOrderDate
        '
        Me.ItemForOrderDate.Control = Me.OrderDateDateEdit
        Me.ItemForOrderDate.CustomizationFormText = "Order Date"
        Me.ItemForOrderDate.Location = New System.Drawing.Point(433, 30)
        Me.ItemForOrderDate.Name = "ItemForOrderDate"
        Me.ItemForOrderDate.Size = New System.Drawing.Size(434, 30)
        Me.ItemForOrderDate.Text = "Order Date"
        Me.ItemForOrderDate.TextSize = New System.Drawing.Size(102, 13)
        Me.ItemForOrderDate.TextToControlDistance = 5
        '
        'ItemForRequiredDate
        '
        Me.ItemForRequiredDate.Control = Me.RequiredDateDateEdit
        Me.ItemForRequiredDate.CustomizationFormText = "Required Date"
        Me.ItemForRequiredDate.Location = New System.Drawing.Point(433, 0)
        Me.ItemForRequiredDate.Name = "ItemForRequiredDate"
        Me.ItemForRequiredDate.Size = New System.Drawing.Size(434, 30)
        Me.ItemForRequiredDate.Text = "Required Date"
        Me.ItemForRequiredDate.TextSize = New System.Drawing.Size(102, 13)
        Me.ItemForRequiredDate.TextToControlDistance = 5
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AllowDrawBackground = False
        Me.LayoutControlGroup3.CustomizationFormText = "autoGeneratedGroup1"
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForPurchaseOrderLines})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlGroup3.Name = "autoGeneratedGroup1"
        Me.LayoutControlGroup3.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(867, 487)
        Me.LayoutControlGroup3.Text = "autoGeneratedGroup1"
        '
        'ItemForPurchaseOrderLines
        '
        Me.ItemForPurchaseOrderLines.Control = Me.gcPurchaseOrderLines
        Me.ItemForPurchaseOrderLines.CustomizationFormText = "Purchase Order Lines"
        Me.ItemForPurchaseOrderLines.Location = New System.Drawing.Point(0, 0)
        Me.ItemForPurchaseOrderLines.Name = "ItemForPurchaseOrderLines"
        Me.ItemForPurchaseOrderLines.Size = New System.Drawing.Size(867, 487)
        Me.ItemForPurchaseOrderLines.Text = "Purchase Order Lines"
        Me.ItemForPurchaseOrderLines.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForPurchaseOrderLines.TextSize = New System.Drawing.Size(102, 13)
        Me.ItemForPurchaseOrderLines.TextToControlDistance = 5
        '
        'xfGeneratePurchaseOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 680)
        Me.Name = "xfGeneratePurchaseOrders"
        Me.Text = "Generate Purchase Orders"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordsLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.gcPurchaseOrderLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderLineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPurchaseOrderLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERPPurchaseOrderIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRVNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequiredDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequiredDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRVDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRVDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartGroupTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyScopeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAgentID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForERPPurchaseOrderID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAgentName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPartGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSupplyScope, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWorkCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForWorkCentreCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForGRVNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForGRVDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRequiredDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPurchaseOrderLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents SupplierTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ERPPurchaseOrderIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OrderNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GRVNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrderDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RequiredDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GRVDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AgentIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AgentNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PartTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PartGroupTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplyScopeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkCentreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkCentreCategoryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForSupplier As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForERPPurchaseOrderID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrderNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForGRVNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrderDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRequiredDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForGRVDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAgentID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAgentName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJob As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPart As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPartGroup As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForSupplyScope As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWorkCentre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForWorkCentreCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gcPurchaseOrderLines As DevExpress.XtraGrid.GridControl
    Friend WithEvents PurchaseOrderLineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gvPurchaseOrderLines As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colInventoryItem As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colERPPurchaseOrderLineID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colJobLine As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLineNote As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ItemForPurchaseOrderLines As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents riseQuantity As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
