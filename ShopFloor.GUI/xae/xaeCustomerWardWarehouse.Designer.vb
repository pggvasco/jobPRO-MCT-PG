<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeCustomerWardWarehouse
    Inherits UniSource.ShopFloor.GUI.xaegCustomerWardWarehouse

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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CustomerWorkCentreCategoryLineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvCustomerWards = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeekDayPriceList = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WeekDayPricelistRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PriceListNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colWeekNightPricelist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WeekNightPricelistRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSaturdayDayPricelist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaturdayDayPricelistRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSaturdayNightPricelist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaturdayNightPricelistRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSundayDayPricelist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SundayDayPricelistRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSundayNightPricelist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SundayNightPricelistRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colPublicHolidayDayPricelist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colPublicHolidayNightPricelist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.WorkCentreCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WarehouseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WarehouseMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.AddEditJobClass = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerWorkCentreCategoryLineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCustomerWards, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekDayPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceListNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekNightPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaturdayDayPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaturdayNightPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SundayDayPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SundayNightPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouseMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.LayoutControl1)
        Me.grpGroup.Location = New System.Drawing.Point(13, 28)
        Me.grpGroup.Size = New System.Drawing.Size(1150, 382)
        Me.grpGroup.Text = "Customer Ward Link"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(968, 435)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(1088, 435)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.AccountNameTextEdit)
        Me.LayoutControl1.Controls.Add(Me.TextEdit1)
        Me.LayoutControl1.Location = New System.Drawing.Point(5, 21)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(227, 141, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1139, 357)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CustomerWorkCentreCategoryLineListBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 36)
        Me.GridControl1.MainView = Me.gvCustomerWards
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.WeekDayPricelistRepositoryItemLookUpEdit, Me.WeekNightPricelistRepositoryItemLookUpEdit, Me.SaturdayDayPricelistRepositoryItemLookUpEdit, Me.SaturdayNightPricelistRepositoryItemLookUpEdit, Me.SundayDayPricelistRepositoryItemLookUpEdit, Me.SundayNightPricelistRepositoryItemLookUpEdit, Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit, Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit})
        Me.GridControl1.Size = New System.Drawing.Size(1115, 309)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCustomerWards})
        '
        'CustomerWorkCentreCategoryLineListBindingSource
        '
        Me.CustomerWorkCentreCategoryLineListBindingSource.DataMember = "CustomerWorkCentreCategoryLineList"
        Me.CustomerWorkCentreCategoryLineListBindingSource.DataSource = Me.BindingSource
        '
        'gvCustomerWards
        '
        Me.gvCustomerWards.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colWeekDayPriceList, Me.colWeekNightPricelist, Me.colSaturdayDayPricelist, Me.colSaturdayNightPricelist, Me.colSundayDayPricelist, Me.colSundayNightPricelist, Me.colPublicHolidayDayPricelist, Me.colPublicHolidayNightPricelist, Me.colCustomer, Me.colID, Me.colError})
        Me.gvCustomerWards.GridControl = Me.GridControl1
        Me.gvCustomerWards.Name = "gvCustomerWards"
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        '
        'colDescription
        '
        Me.colDescription.Caption = "Ward"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        '
        'colWeekDayPriceList
        '
        Me.colWeekDayPriceList.ColumnEdit = Me.WeekDayPricelistRepositoryItemLookUpEdit
        Me.colWeekDayPriceList.FieldName = "WeekDayPriceList"
        Me.colWeekDayPriceList.Name = "colWeekDayPriceList"
        Me.colWeekDayPriceList.Visible = True
        Me.colWeekDayPriceList.VisibleIndex = 2
        Me.colWeekDayPriceList.Width = 113
        '
        'WeekDayPricelistRepositoryItemLookUpEdit
        '
        Me.WeekDayPricelistRepositoryItemLookUpEdit.AutoHeight = False
        Me.WeekDayPricelistRepositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.WeekDayPricelistRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WeekDayPricelistRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CName", "Name", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDescription", "Description", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.WeekDayPricelistRepositoryItemLookUpEdit.DataSource = Me.PriceListNameBindingSource
        Me.WeekDayPricelistRepositoryItemLookUpEdit.DisplayMember = "CName"
        Me.WeekDayPricelistRepositoryItemLookUpEdit.Name = "WeekDayPricelistRepositoryItemLookUpEdit"
        Me.WeekDayPricelistRepositoryItemLookUpEdit.NullText = "(Select WeekDayPricelist...)"
        Me.WeekDayPricelistRepositoryItemLookUpEdit.ValueMember = "IDPriceListName"
        '
        'PriceListNameBindingSource
        '
        Me.PriceListNameBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.PriceListName)
        '
        'colWeekNightPricelist
        '
        Me.colWeekNightPricelist.ColumnEdit = Me.WeekNightPricelistRepositoryItemLookUpEdit
        Me.colWeekNightPricelist.FieldName = "WeekNightPricelist"
        Me.colWeekNightPricelist.Name = "colWeekNightPricelist"
        Me.colWeekNightPricelist.Visible = True
        Me.colWeekNightPricelist.VisibleIndex = 3
        Me.colWeekNightPricelist.Width = 113
        '
        'WeekNightPricelistRepositoryItemLookUpEdit
        '
        Me.WeekNightPricelistRepositoryItemLookUpEdit.AutoHeight = False
        Me.WeekNightPricelistRepositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.WeekNightPricelistRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WeekNightPricelistRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CName", "Name", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDescription", "Description", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.WeekNightPricelistRepositoryItemLookUpEdit.DataSource = Me.PriceListNameBindingSource
        Me.WeekNightPricelistRepositoryItemLookUpEdit.DisplayMember = "CName"
        Me.WeekNightPricelistRepositoryItemLookUpEdit.Name = "WeekNightPricelistRepositoryItemLookUpEdit"
        Me.WeekNightPricelistRepositoryItemLookUpEdit.NullText = "Select WeekNightPricelist...)"
        Me.WeekNightPricelistRepositoryItemLookUpEdit.ValueMember = "IDPriceListName"
        '
        'colSaturdayDayPricelist
        '
        Me.colSaturdayDayPricelist.ColumnEdit = Me.SaturdayDayPricelistRepositoryItemLookUpEdit
        Me.colSaturdayDayPricelist.FieldName = "SaturdayDayPricelist"
        Me.colSaturdayDayPricelist.Name = "colSaturdayDayPricelist"
        Me.colSaturdayDayPricelist.Visible = True
        Me.colSaturdayDayPricelist.VisibleIndex = 4
        Me.colSaturdayDayPricelist.Width = 124
        '
        'SaturdayDayPricelistRepositoryItemLookUpEdit
        '
        Me.SaturdayDayPricelistRepositoryItemLookUpEdit.AutoHeight = False
        Me.SaturdayDayPricelistRepositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.SaturdayDayPricelistRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SaturdayDayPricelistRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CName", "Name", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDescription", "Description", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SaturdayDayPricelistRepositoryItemLookUpEdit.DataSource = Me.PriceListNameBindingSource
        Me.SaturdayDayPricelistRepositoryItemLookUpEdit.DisplayMember = "CName"
        Me.SaturdayDayPricelistRepositoryItemLookUpEdit.Name = "SaturdayDayPricelistRepositoryItemLookUpEdit"
        Me.SaturdayDayPricelistRepositoryItemLookUpEdit.NullText = "(Select SaturdayDayPricelist...)"
        Me.SaturdayDayPricelistRepositoryItemLookUpEdit.ValueMember = "IDPriceListName"
        '
        'colSaturdayNightPricelist
        '
        Me.colSaturdayNightPricelist.ColumnEdit = Me.SaturdayNightPricelistRepositoryItemLookUpEdit
        Me.colSaturdayNightPricelist.FieldName = "SaturdayNightPricelist"
        Me.colSaturdayNightPricelist.Name = "colSaturdayNightPricelist"
        Me.colSaturdayNightPricelist.Visible = True
        Me.colSaturdayNightPricelist.VisibleIndex = 5
        Me.colSaturdayNightPricelist.Width = 130
        '
        'SaturdayNightPricelistRepositoryItemLookUpEdit
        '
        Me.SaturdayNightPricelistRepositoryItemLookUpEdit.AutoHeight = False
        Me.SaturdayNightPricelistRepositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.SaturdayNightPricelistRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SaturdayNightPricelistRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CName", "Name", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDescription", "Description", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SaturdayNightPricelistRepositoryItemLookUpEdit.DataSource = Me.PriceListNameBindingSource
        Me.SaturdayNightPricelistRepositoryItemLookUpEdit.DisplayMember = "CName"
        Me.SaturdayNightPricelistRepositoryItemLookUpEdit.Name = "SaturdayNightPricelistRepositoryItemLookUpEdit"
        Me.SaturdayNightPricelistRepositoryItemLookUpEdit.NullText = "(Select SaturdayNightPricelist...)"
        Me.SaturdayNightPricelistRepositoryItemLookUpEdit.ValueMember = "IDPriceListName"
        '
        'colSundayDayPricelist
        '
        Me.colSundayDayPricelist.ColumnEdit = Me.SundayDayPricelistRepositoryItemLookUpEdit
        Me.colSundayDayPricelist.FieldName = "SundayDayPricelist"
        Me.colSundayDayPricelist.Name = "colSundayDayPricelist"
        Me.colSundayDayPricelist.Visible = True
        Me.colSundayDayPricelist.VisibleIndex = 6
        Me.colSundayDayPricelist.Width = 116
        '
        'SundayDayPricelistRepositoryItemLookUpEdit
        '
        Me.SundayDayPricelistRepositoryItemLookUpEdit.AutoHeight = False
        Me.SundayDayPricelistRepositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.SundayDayPricelistRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SundayDayPricelistRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CName", "Name", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDescription", "Description", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SundayDayPricelistRepositoryItemLookUpEdit.DataSource = Me.PriceListNameBindingSource
        Me.SundayDayPricelistRepositoryItemLookUpEdit.DisplayMember = "CName"
        Me.SundayDayPricelistRepositoryItemLookUpEdit.Name = "SundayDayPricelistRepositoryItemLookUpEdit"
        Me.SundayDayPricelistRepositoryItemLookUpEdit.NullText = "(Select SundayDayPricelist...)"
        Me.SundayDayPricelistRepositoryItemLookUpEdit.ValueMember = "IDPriceListName"
        '
        'colSundayNightPricelist
        '
        Me.colSundayNightPricelist.ColumnEdit = Me.SundayNightPricelistRepositoryItemLookUpEdit
        Me.colSundayNightPricelist.FieldName = "SundayNightPricelist"
        Me.colSundayNightPricelist.Name = "colSundayNightPricelist"
        Me.colSundayNightPricelist.Visible = True
        Me.colSundayNightPricelist.VisibleIndex = 7
        Me.colSundayNightPricelist.Width = 122
        '
        'SundayNightPricelistRepositoryItemLookUpEdit
        '
        Me.SundayNightPricelistRepositoryItemLookUpEdit.AutoHeight = False
        Me.SundayNightPricelistRepositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.SundayNightPricelistRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SundayNightPricelistRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CName", "Name", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDescription", "Description", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SundayNightPricelistRepositoryItemLookUpEdit.DataSource = Me.PriceListNameBindingSource
        Me.SundayNightPricelistRepositoryItemLookUpEdit.DisplayMember = "CName"
        Me.SundayNightPricelistRepositoryItemLookUpEdit.Name = "SundayNightPricelistRepositoryItemLookUpEdit"
        Me.SundayNightPricelistRepositoryItemLookUpEdit.NullText = "Select SundayNightPricelist...)"
        Me.SundayNightPricelistRepositoryItemLookUpEdit.ValueMember = "IDPriceListName"
        '
        'colPublicHolidayDayPricelist
        '
        Me.colPublicHolidayDayPricelist.ColumnEdit = Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit
        Me.colPublicHolidayDayPricelist.FieldName = "PublicHolidayDayPricelist"
        Me.colPublicHolidayDayPricelist.Name = "colPublicHolidayDayPricelist"
        Me.colPublicHolidayDayPricelist.Visible = True
        Me.colPublicHolidayDayPricelist.VisibleIndex = 8
        Me.colPublicHolidayDayPricelist.Width = 145
        '
        'PublicHolidayDayPricelistRepositoryItemLookUpEdit
        '
        Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit.AutoHeight = False
        Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CName", "Name", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDescription", "Description", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit.DataSource = Me.PriceListNameBindingSource
        Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit.DisplayMember = "CName"
        Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit.Name = "PublicHolidayDayPricelistRepositoryItemLookUpEdit"
        Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit.NullText = "Select  PublicHolidayDayPricelist...)"
        Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit.ValueMember = "IDPriceListName"
        '
        'colPublicHolidayNightPricelist
        '
        Me.colPublicHolidayNightPricelist.ColumnEdit = Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit
        Me.colPublicHolidayNightPricelist.FieldName = "PublicHolidayNightPricelist"
        Me.colPublicHolidayNightPricelist.Name = "colPublicHolidayNightPricelist"
        Me.colPublicHolidayNightPricelist.Visible = True
        Me.colPublicHolidayNightPricelist.VisibleIndex = 9
        Me.colPublicHolidayNightPricelist.Width = 151
        '
        'PublicHolidayNightPricelistRepositoryItemLookUpEdit
        '
        Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit.AutoHeight = False
        Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CName", "Name", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDescription", "Description", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit.DataSource = Me.PriceListNameBindingSource
        Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit.DisplayMember = "CName"
        Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit.Name = "PublicHolidayNightPricelistRepositoryItemLookUpEdit"
        Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit.NullText = "(Select PublicHolidayNightPricelist...)"
        Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit.ValueMember = "IDPriceListName"
        '
        'colCustomer
        '
        Me.colCustomer.FieldName = "Customer"
        Me.colCustomer.Name = "colCustomer"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colError
        '
        Me.colError.FieldName = "Error"
        Me.colError.Name = "colError"
        Me.colError.OptionsColumn.ReadOnly = True
        '
        'AccountNameTextEdit
        '
        Me.AccountNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Client.Description", True))
        Me.AccountNameTextEdit.Enabled = False
        Me.AccountNameTextEdit.Location = New System.Drawing.Point(508, 12)
        Me.AccountNameTextEdit.Name = "AccountNameTextEdit"
        Me.AccountNameTextEdit.Size = New System.Drawing.Size(619, 20)
        Me.AccountNameTextEdit.StyleController = Me.LayoutControl1
        Me.AccountNameTextEdit.TabIndex = 5
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Client.Code", True))
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(42, 12)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(432, 20)
        Me.TextEdit1.StyleController = Me.LayoutControl1
        Me.TextEdit1.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1139, 357)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TextEdit1
        Me.LayoutControlItem1.CustomizationFormText = "Code"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(466, 24)
        Me.LayoutControlItem1.Text = "Code"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(27, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.AccountNameTextEdit
        Me.LayoutControlItem2.CustomizationFormText = "Name"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(466, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(653, 24)
        Me.LayoutControlItem2.Text = "Name"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(27, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1119, 313)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'WorkCentreCategoryBindingSource
        '
        Me.WorkCentreCategoryBindingSource.DataSource = GetType(UniSource.ShopFloor.API.WorkCentreCategory)
        '
        'WarehouseBindingSource
        '
        Me.WarehouseBindingSource.DataSource = GetType(Pastel.Evolution.Warehouse)
        '
        'WarehouseMasterBindingSource
        '
        Me.WarehouseMasterBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.AddEditJobClass})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.AddEditJobClass)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'AddEditJobClass
        '
        Me.AddEditJobClass.Caption = "AddEdit"
        Me.AddEditJobClass.Id = 0
        Me.AddEditJobClass.Name = "AddEditJobClass"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1175, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 447)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1175, 23)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(1175, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 425)
        '
        'xaeCustomerWardWarehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 470)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = True
        Me.Name = "xaeCustomerWardWarehouse"
        Me.Text = "Customer Ward Warehouse"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.btSave, 0)
        Me.Controls.SetChildIndex(Me.btCancel, 0)
        Me.Controls.SetChildIndex(Me.grpGroup, 0)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerWorkCentreCategoryLineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCustomerWards, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekDayPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceListNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekNightPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaturdayDayPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaturdayNightPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SundayDayPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SundayNightPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublicHolidayDayPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublicHolidayNightPricelistRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouseMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents AccountNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents WorkCentreCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WarehouseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WarehouseMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PriceListNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCustomerWards As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CustomerWorkCentreCategoryLineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeekDayPriceList As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WeekDayPricelistRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colWeekNightPricelist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturdayDayPricelist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturdayNightPricelist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSundayDayPricelist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSundayNightPricelist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPublicHolidayDayPricelist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPublicHolidayNightPricelist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WeekNightPricelistRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SaturdayDayPricelistRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SaturdayNightPricelistRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SundayDayPricelistRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SundayNightPricelistRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PublicHolidayDayPricelistRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PublicHolidayNightPricelistRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents AddEditJobClass As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
