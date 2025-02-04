<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobQuoteTime
    Inherits UniSource.ShopFloor.GUI.xaegJobQuoteTime

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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiAddLine = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditLine = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbidelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCopyline = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.gcJobline = New DevExpress.XtraGrid.GridControl()
        Me.JobLineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvJoblines = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMarkupFactor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.QuantityRepositoryItemSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colMarkupPercent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineDiscountPercent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseDiscountPercent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsStockDrawn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantityStockDrawn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantitySupplierOrdered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InventoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.InventoryItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colInventoryItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescriptionRepositoryItemTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplier1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplier2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalActualCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPriceBeforeDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPriceBeforeMarkup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantityStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantitySupplier1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISPOGenerated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISRlGenerated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobLineDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGRVDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGRVNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCriteria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNormalWearAndTearReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsNormalWearAndTear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsProcured = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseOrder1ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseOrderLine1ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseOrder2ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseOrderLine2ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantitySupplier2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeasurement1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeasurement2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeasurement3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.linenumberRepositoryItemSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colUnitCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPurchasePrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colERPBudgetLineID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colERPRecoveryLineID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplier1ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplier2ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionLines = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseOrderLines = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WorkCentreItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.WorkCentreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colJob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplyScope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkCentreCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WorkCentreCategoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.WorkCentreCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StartDateRepositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEndDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EndDateRepositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEmployee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmployeeRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RateTypeRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InvoiceRunRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colPaymentAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentRun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PaymentRunRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colEmployeeRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmployeeRateRepositoryItemSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmployeeTotalRepositoryItemSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DeleteRecordRepositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.WorkCentreCategoryRepositoryItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.InvoiceRunRepositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.InvoiceWeekRepositoryItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.NotWorkedRepositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.DetailsLayoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.ImportReferenceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ImportDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SourceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.JobCategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobTypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.JobnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CustomerLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobstage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.JobTypeItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.JobCategoryItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CostCentreItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SourceItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ImportDateItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ImportReferenceItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gcJobline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJoblines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionRepositoryItemTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linenumberRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateRepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateRepositoryItemDateEdit.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateRepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateRepositoryItemDateEdit.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateTypeRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceRunRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentRunRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeRateRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeTotalRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeleteRecordRepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCentreCategoryRepositoryItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceRunRepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceWeekRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotWorkedRepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.DetailsLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsLayoutControl.SuspendLayout()
        CType(Me.ImportReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobstage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTypeItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCategoryItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCentreItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDateItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportReferenceItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.LayoutControl1)
        Me.grpGroup.Location = New System.Drawing.Point(0, 28)
        Me.grpGroup.Size = New System.Drawing.Size(1236, 653)
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(1034, 708)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(1154, 708)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiAddLine, Me.bbiEditLine, Me.bbiSave, Me.bbidelete, Me.bbiCopyline})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(912, 158)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAddLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbidelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCopyline)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'bbiAddLine
        '
        Me.bbiAddLine.Caption = "Add Line"
        Me.bbiAddLine.Id = 0
        Me.bbiAddLine.Name = "bbiAddLine"
        '
        'bbiEditLine
        '
        Me.bbiEditLine.Caption = "Edit Line"
        Me.bbiEditLine.Id = 1
        Me.bbiEditLine.Name = "bbiEditLine"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Id = 3
        Me.bbiSave.Name = "bbiSave"
        Me.bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbidelete
        '
        Me.bbidelete.Caption = "Delete"
        Me.bbidelete.Id = 4
        Me.bbidelete.Name = "bbidelete"
        '
        'bbiCopyline
        '
        Me.bbiCopyline.Caption = "Copy Line"
        Me.bbiCopyline.Id = 5
        Me.bbiCopyline.Name = "bbiCopyline"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 743)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1241, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 721)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1241, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 721)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl1.Controls.Add(Me.gcJobline)
        Me.LayoutControl1.Controls.Add(Me.XtraTabControl1)
        Me.LayoutControl1.Location = New System.Drawing.Point(5, 24)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(364, 281, 250, 350)
        Me.LayoutControl1.Root = Me.GroupLayoutControlGroup
        Me.LayoutControl1.Size = New System.Drawing.Size(1231, 622)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'gcJobline
        '
        Me.gcJobline.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcJobline.DataSource = Me.JobLineListBindingSource
        Me.gcJobline.Location = New System.Drawing.Point(12, 267)
        Me.gcJobline.MainView = Me.gvJoblines
        Me.gcJobline.MenuManager = Me.BarManager1
        Me.gcJobline.Name = "gcJobline"
        Me.gcJobline.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.WorkCentreCategoryRepositoryItemGridLookUpEdit, Me.WorkCentreCategoryItemLookUpEdit, Me.WorkCentreItemLookUpEdit, Me.InventoryItemLookUpEdit, Me.StartDateRepositoryItemDateEdit, Me.EndDateRepositoryItemDateEdit, Me.EmployeeRepositoryItemLookUpEdit, Me.RateTypeRepositoryItemLookUpEdit, Me.InvoiceRunRepositoryItemCheckEdit, Me.InvoiceWeekRepositoryItemComboBox, Me.RepositoryItemCheckEdit, Me.EmployeeRateRepositoryItemSpinEdit, Me.EmployeeTotalRepositoryItemSpinEdit, Me.NotWorkedRepositoryItemCheckEdit, Me.DeleteRecordRepositoryItemCheckEdit, Me.QuantityRepositoryItemSpinEdit, Me.DescriptionRepositoryItemTextEdit, Me.linenumberRepositoryItemSpinEdit, Me.InvoiceRunRepositoryItemLookUpEdit, Me.PaymentRunRepositoryItemLookUpEdit})
        Me.gcJobline.Size = New System.Drawing.Size(1207, 343)
        Me.gcJobline.TabIndex = 1
        Me.gcJobline.UseEmbeddedNavigator = True
        Me.gcJobline.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJoblines})
        '
        'JobLineListBindingSource
        '
        Me.JobLineListBindingSource.DataMember = "JobLineTimeList"
        Me.JobLineListBindingSource.DataSource = Me.BindingSource
        '
        'gvJoblines
        '
        Me.gvJoblines.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMarkupFactor, Me.colEstimatedDuration, Me.colUnitSize, Me.colQuantity, Me.colMarkupPercent, Me.colLineDiscountPercent, Me.colPurchaseDiscountPercent, Me.colIsStockDrawn, Me.colQuantityStockDrawn, Me.colQuantitySupplierOrdered, Me.colUnitPrice, Me.colInventoryItem, Me.colInventoryItemID, Me.colDescription1, Me.colSupplierType, Me.colSupplier1, Me.colSupplier2, Me.colActualCost, Me.colTotalActualCost, Me.colTotalPrice, Me.colUnitPriceBeforeDiscount, Me.colUnitPriceBeforeMarkup, Me.colQuantityStock, Me.colQuantitySupplier1, Me.colISPOGenerated, Me.colISRlGenerated, Me.colJobLineDate, Me.colOrderDate, Me.colRequiredDate, Me.colGRVDate, Me.colOrderNumber, Me.colGRVNumber, Me.colDescription2, Me.colQuoteDescription, Me.colCriteria, Me.colNormalWearAndTearReason, Me.colIsNormalWearAndTear, Me.colIsProcured, Me.colPurchaseOrder1ID, Me.colPurchaseOrderLine1ID, Me.colPurchaseOrder2ID, Me.colPurchaseOrderLine2ID, Me.colQuantitySupplier2, Me.colActualDuration, Me.colMeasurement1, Me.colMeasurement2, Me.colMeasurement3, Me.colLineNumber, Me.colUnitCost, Me.colTotalCost, Me.colNewPrice, Me.colUnitPurchasePrice, Me.colERPBudgetLineID, Me.colERPRecoveryLineID, Me.colSupplierTypeID, Me.colSupplier1ID, Me.colSupplier2ID, Me.colRequisitionLines, Me.colPurchaseOrderLines, Me.colWorkCentre, Me.colJob, Me.colPart, Me.colSupplyScope, Me.colWorkCentreCategory, Me.colID, Me.colError, Me.colStartDate, Me.colEndDateTime, Me.colEmployee, Me.GridColumn3, Me.GridColumn4, Me.colPaymentAmount, Me.colPaymentRun, Me.colEmployeeRate, Me.GridColumn7, Me.GridColumn8, Me.gvDeleted})
        Me.gvJoblines.GridControl = Me.gcJobline
        Me.gvJoblines.Name = "gvJoblines"
        Me.gvJoblines.OptionsView.ColumnAutoWidth = False
        Me.gvJoblines.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gvDeleted, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colMarkupFactor
        '
        Me.colMarkupFactor.FieldName = "MarkupFactor"
        Me.colMarkupFactor.Name = "colMarkupFactor"
        '
        'colEstimatedDuration
        '
        Me.colEstimatedDuration.FieldName = "EstimatedDuration"
        Me.colEstimatedDuration.Name = "colEstimatedDuration"
        '
        'colUnitSize
        '
        Me.colUnitSize.FieldName = "UnitSize"
        Me.colUnitSize.Name = "colUnitSize"
        Me.colUnitSize.Width = 33
        '
        'colQuantity
        '
        Me.colQuantity.ColumnEdit = Me.QuantityRepositoryItemSpinEdit
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 9
        Me.colQuantity.Width = 113
        '
        'QuantityRepositoryItemSpinEdit
        '
        Me.QuantityRepositoryItemSpinEdit.AutoHeight = False
        Me.QuantityRepositoryItemSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.QuantityRepositoryItemSpinEdit.Name = "QuantityRepositoryItemSpinEdit"
        '
        'colMarkupPercent
        '
        Me.colMarkupPercent.FieldName = "MarkupPercent"
        Me.colMarkupPercent.Name = "colMarkupPercent"
        Me.colMarkupPercent.Width = 20
        '
        'colLineDiscountPercent
        '
        Me.colLineDiscountPercent.FieldName = "LineDiscountPercent"
        Me.colLineDiscountPercent.Name = "colLineDiscountPercent"
        Me.colLineDiscountPercent.Width = 197
        '
        'colPurchaseDiscountPercent
        '
        Me.colPurchaseDiscountPercent.FieldName = "PurchaseDiscountPercent"
        Me.colPurchaseDiscountPercent.Name = "colPurchaseDiscountPercent"
        Me.colPurchaseDiscountPercent.Width = 20
        '
        'colIsStockDrawn
        '
        Me.colIsStockDrawn.FieldName = "IsStockDrawn"
        Me.colIsStockDrawn.Name = "colIsStockDrawn"
        Me.colIsStockDrawn.Width = 20
        '
        'colQuantityStockDrawn
        '
        Me.colQuantityStockDrawn.FieldName = "QuantityStockDrawn"
        Me.colQuantityStockDrawn.Name = "colQuantityStockDrawn"
        Me.colQuantityStockDrawn.Width = 20
        '
        'colQuantitySupplierOrdered
        '
        Me.colQuantitySupplierOrdered.FieldName = "QuantitySupplierOrdered"
        Me.colQuantitySupplierOrdered.Name = "colQuantitySupplierOrdered"
        Me.colQuantitySupplierOrdered.Width = 20
        '
        'colUnitPrice
        '
        Me.colUnitPrice.Caption = "Client Rate"
        Me.colUnitPrice.FieldName = "TimeUnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 10
        Me.colUnitPrice.Width = 124
        '
        'colInventoryItem
        '
        Me.colInventoryItem.ColumnEdit = Me.InventoryItemLookUpEdit
        Me.colInventoryItem.FieldName = "InventoryItem"
        Me.colInventoryItem.Name = "colInventoryItem"
        Me.colInventoryItem.Visible = True
        Me.colInventoryItem.VisibleIndex = 4
        Me.colInventoryItem.Width = 130
        '
        'InventoryItemLookUpEdit
        '
        Me.InventoryItemLookUpEdit.AutoHeight = False
        Me.InventoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.InventoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InventoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.InventoryItemLookUpEdit.DataSource = Me.InventoryItemBindingSource
        Me.InventoryItemLookUpEdit.DisplayMember = "Code"
        Me.InventoryItemLookUpEdit.Name = "InventoryItemLookUpEdit"
        Me.InventoryItemLookUpEdit.NullText = "(Select Inventory Item...)"
        Me.InventoryItemLookUpEdit.ReadOnly = True
        '
        'InventoryItemBindingSource
        '
        Me.InventoryItemBindingSource.DataSource = GetType(Pastel.Evolution.InventoryItem)
        '
        'colInventoryItemID
        '
        Me.colInventoryItemID.FieldName = "InventoryItemID"
        Me.colInventoryItemID.Name = "colInventoryItemID"
        Me.colInventoryItemID.Width = 20
        '
        'colDescription1
        '
        Me.colDescription1.ColumnEdit = Me.DescriptionRepositoryItemTextEdit
        Me.colDescription1.FieldName = "Description1"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.OptionsColumn.AllowEdit = False
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 5
        Me.colDescription1.Width = 111
        '
        'DescriptionRepositoryItemTextEdit
        '
        Me.DescriptionRepositoryItemTextEdit.AutoHeight = False
        Me.DescriptionRepositoryItemTextEdit.Name = "DescriptionRepositoryItemTextEdit"
        Me.DescriptionRepositoryItemTextEdit.ReadOnly = True
        '
        'colSupplierType
        '
        Me.colSupplierType.FieldName = "SupplierType"
        Me.colSupplierType.Name = "colSupplierType"
        Me.colSupplierType.Width = 20
        '
        'colSupplier1
        '
        Me.colSupplier1.FieldName = "Supplier1"
        Me.colSupplier1.Name = "colSupplier1"
        Me.colSupplier1.Width = 20
        '
        'colSupplier2
        '
        Me.colSupplier2.FieldName = "Supplier2"
        Me.colSupplier2.Name = "colSupplier2"
        Me.colSupplier2.Width = 20
        '
        'colActualCost
        '
        Me.colActualCost.FieldName = "ActualCost"
        Me.colActualCost.Name = "colActualCost"
        Me.colActualCost.OptionsColumn.ReadOnly = True
        Me.colActualCost.Width = 20
        '
        'colTotalActualCost
        '
        Me.colTotalActualCost.FieldName = "TotalActualCost"
        Me.colTotalActualCost.Name = "colTotalActualCost"
        Me.colTotalActualCost.OptionsColumn.ReadOnly = True
        Me.colTotalActualCost.Width = 20
        '
        'colTotalPrice
        '
        Me.colTotalPrice.FieldName = "TotalPrice"
        Me.colTotalPrice.Name = "colTotalPrice"
        Me.colTotalPrice.Visible = True
        Me.colTotalPrice.VisibleIndex = 11
        Me.colTotalPrice.Width = 69
        '
        'colUnitPriceBeforeDiscount
        '
        Me.colUnitPriceBeforeDiscount.FieldName = "UnitPriceBeforeDiscount"
        Me.colUnitPriceBeforeDiscount.Name = "colUnitPriceBeforeDiscount"
        Me.colUnitPriceBeforeDiscount.Width = 20
        '
        'colUnitPriceBeforeMarkup
        '
        Me.colUnitPriceBeforeMarkup.FieldName = "UnitPriceBeforeMarkup"
        Me.colUnitPriceBeforeMarkup.Name = "colUnitPriceBeforeMarkup"
        Me.colUnitPriceBeforeMarkup.Width = 20
        '
        'colQuantityStock
        '
        Me.colQuantityStock.FieldName = "QuantityStock"
        Me.colQuantityStock.Name = "colQuantityStock"
        Me.colQuantityStock.Width = 20
        '
        'colQuantitySupplier1
        '
        Me.colQuantitySupplier1.FieldName = "QuantitySupplier1"
        Me.colQuantitySupplier1.Name = "colQuantitySupplier1"
        Me.colQuantitySupplier1.Width = 20
        '
        'colISPOGenerated
        '
        Me.colISPOGenerated.FieldName = "ISPOGenerated"
        Me.colISPOGenerated.Name = "colISPOGenerated"
        Me.colISPOGenerated.OptionsColumn.ReadOnly = True
        Me.colISPOGenerated.Width = 20
        '
        'colISRlGenerated
        '
        Me.colISRlGenerated.FieldName = "ISRlGenerated"
        Me.colISRlGenerated.Name = "colISRlGenerated"
        Me.colISRlGenerated.OptionsColumn.ReadOnly = True
        Me.colISRlGenerated.Width = 20
        '
        'colJobLineDate
        '
        Me.colJobLineDate.FieldName = "JobLineDate"
        Me.colJobLineDate.Name = "colJobLineDate"
        Me.colJobLineDate.Width = 20
        '
        'colOrderDate
        '
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.Width = 20
        '
        'colRequiredDate
        '
        Me.colRequiredDate.FieldName = "RequiredDate"
        Me.colRequiredDate.Name = "colRequiredDate"
        Me.colRequiredDate.Width = 20
        '
        'colGRVDate
        '
        Me.colGRVDate.FieldName = "GRVDate"
        Me.colGRVDate.Name = "colGRVDate"
        Me.colGRVDate.Width = 20
        '
        'colOrderNumber
        '
        Me.colOrderNumber.FieldName = "OrderNumber"
        Me.colOrderNumber.Name = "colOrderNumber"
        Me.colOrderNumber.Width = 20
        '
        'colGRVNumber
        '
        Me.colGRVNumber.FieldName = "GRVNumber"
        Me.colGRVNumber.Name = "colGRVNumber"
        Me.colGRVNumber.Width = 20
        '
        'colDescription2
        '
        Me.colDescription2.FieldName = "Description2"
        Me.colDescription2.Name = "colDescription2"
        Me.colDescription2.Width = 130
        '
        'colQuoteDescription
        '
        Me.colQuoteDescription.FieldName = "QuoteDescription"
        Me.colQuoteDescription.Name = "colQuoteDescription"
        Me.colQuoteDescription.Width = 20
        '
        'colCriteria
        '
        Me.colCriteria.FieldName = "Criteria"
        Me.colCriteria.Name = "colCriteria"
        Me.colCriteria.Width = 20
        '
        'colNormalWearAndTearReason
        '
        Me.colNormalWearAndTearReason.FieldName = "NormalWearAndTearReason"
        Me.colNormalWearAndTearReason.Name = "colNormalWearAndTearReason"
        Me.colNormalWearAndTearReason.Width = 20
        '
        'colIsNormalWearAndTear
        '
        Me.colIsNormalWearAndTear.FieldName = "IsNormalWearAndTear"
        Me.colIsNormalWearAndTear.Name = "colIsNormalWearAndTear"
        Me.colIsNormalWearAndTear.Width = 20
        '
        'colIsProcured
        '
        Me.colIsProcured.FieldName = "IsProcured"
        Me.colIsProcured.Name = "colIsProcured"
        Me.colIsProcured.Width = 20
        '
        'colPurchaseOrder1ID
        '
        Me.colPurchaseOrder1ID.FieldName = "PurchaseOrder1ID"
        Me.colPurchaseOrder1ID.Name = "colPurchaseOrder1ID"
        Me.colPurchaseOrder1ID.Width = 20
        '
        'colPurchaseOrderLine1ID
        '
        Me.colPurchaseOrderLine1ID.FieldName = "PurchaseOrderLine1ID"
        Me.colPurchaseOrderLine1ID.Name = "colPurchaseOrderLine1ID"
        Me.colPurchaseOrderLine1ID.Width = 20
        '
        'colPurchaseOrder2ID
        '
        Me.colPurchaseOrder2ID.FieldName = "PurchaseOrder2ID"
        Me.colPurchaseOrder2ID.Name = "colPurchaseOrder2ID"
        Me.colPurchaseOrder2ID.Width = 20
        '
        'colPurchaseOrderLine2ID
        '
        Me.colPurchaseOrderLine2ID.FieldName = "PurchaseOrderLine2ID"
        Me.colPurchaseOrderLine2ID.Name = "colPurchaseOrderLine2ID"
        Me.colPurchaseOrderLine2ID.Width = 20
        '
        'colQuantitySupplier2
        '
        Me.colQuantitySupplier2.FieldName = "QuantitySupplier2"
        Me.colQuantitySupplier2.Name = "colQuantitySupplier2"
        Me.colQuantitySupplier2.Width = 20
        '
        'colActualDuration
        '
        Me.colActualDuration.FieldName = "ActualDuration"
        Me.colActualDuration.Name = "colActualDuration"
        Me.colActualDuration.Width = 20
        '
        'colMeasurement1
        '
        Me.colMeasurement1.FieldName = "Measurement1"
        Me.colMeasurement1.Name = "colMeasurement1"
        Me.colMeasurement1.Width = 20
        '
        'colMeasurement2
        '
        Me.colMeasurement2.FieldName = "Measurement2"
        Me.colMeasurement2.Name = "colMeasurement2"
        Me.colMeasurement2.Width = 20
        '
        'colMeasurement3
        '
        Me.colMeasurement3.FieldName = "Measurement3"
        Me.colMeasurement3.Name = "colMeasurement3"
        Me.colMeasurement3.Width = 20
        '
        'colLineNumber
        '
        Me.colLineNumber.ColumnEdit = Me.linenumberRepositoryItemSpinEdit
        Me.colLineNumber.FieldName = "LineNumber"
        Me.colLineNumber.Name = "colLineNumber"
        Me.colLineNumber.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colLineNumber.Visible = True
        Me.colLineNumber.VisibleIndex = 0
        Me.colLineNumber.Width = 118
        '
        'linenumberRepositoryItemSpinEdit
        '
        Me.linenumberRepositoryItemSpinEdit.AutoHeight = False
        Me.linenumberRepositoryItemSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.linenumberRepositoryItemSpinEdit.Name = "linenumberRepositoryItemSpinEdit"
        '
        'colUnitCost
        '
        Me.colUnitCost.FieldName = "UnitCost"
        Me.colUnitCost.Name = "colUnitCost"
        Me.colUnitCost.Width = 20
        '
        'colTotalCost
        '
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.Width = 20
        '
        'colNewPrice
        '
        Me.colNewPrice.FieldName = "NewPrice"
        Me.colNewPrice.Name = "colNewPrice"
        Me.colNewPrice.Width = 20
        '
        'colUnitPurchasePrice
        '
        Me.colUnitPurchasePrice.FieldName = "UnitPurchasePrice"
        Me.colUnitPurchasePrice.Name = "colUnitPurchasePrice"
        Me.colUnitPurchasePrice.Width = 20
        '
        'colERPBudgetLineID
        '
        Me.colERPBudgetLineID.FieldName = "ERPBudgetLineID"
        Me.colERPBudgetLineID.Name = "colERPBudgetLineID"
        Me.colERPBudgetLineID.Width = 20
        '
        'colERPRecoveryLineID
        '
        Me.colERPRecoveryLineID.FieldName = "ERPRecoveryLineID"
        Me.colERPRecoveryLineID.Name = "colERPRecoveryLineID"
        Me.colERPRecoveryLineID.Width = 20
        '
        'colSupplierTypeID
        '
        Me.colSupplierTypeID.FieldName = "SupplierTypeID"
        Me.colSupplierTypeID.Name = "colSupplierTypeID"
        Me.colSupplierTypeID.Width = 20
        '
        'colSupplier1ID
        '
        Me.colSupplier1ID.FieldName = "Supplier1ID"
        Me.colSupplier1ID.Name = "colSupplier1ID"
        Me.colSupplier1ID.Width = 20
        '
        'colSupplier2ID
        '
        Me.colSupplier2ID.FieldName = "Supplier2ID"
        Me.colSupplier2ID.Name = "colSupplier2ID"
        Me.colSupplier2ID.Width = 20
        '
        'colRequisitionLines
        '
        Me.colRequisitionLines.FieldName = "RequisitionLines"
        Me.colRequisitionLines.Name = "colRequisitionLines"
        Me.colRequisitionLines.Width = 20
        '
        'colPurchaseOrderLines
        '
        Me.colPurchaseOrderLines.FieldName = "PurchaseOrderLines"
        Me.colPurchaseOrderLines.Name = "colPurchaseOrderLines"
        Me.colPurchaseOrderLines.Width = 20
        '
        'colWorkCentre
        '
        Me.colWorkCentre.ColumnEdit = Me.WorkCentreItemLookUpEdit
        Me.colWorkCentre.FieldName = "CustomerJobClass"
        Me.colWorkCentre.Name = "colWorkCentre"
        Me.colWorkCentre.Visible = True
        Me.colWorkCentre.VisibleIndex = 3
        Me.colWorkCentre.Width = 95
        '
        'WorkCentreItemLookUpEdit
        '
        Me.WorkCentreItemLookUpEdit.AutoHeight = False
        Me.WorkCentreItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.WorkCentreItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WorkCentreItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.WorkCentreItemLookUpEdit.DataSource = Me.WorkCentreBindingSource
        Me.WorkCentreItemLookUpEdit.DisplayMember = "Code"
        Me.WorkCentreItemLookUpEdit.Name = "WorkCentreItemLookUpEdit"
        Me.WorkCentreItemLookUpEdit.NullText = "(Select Work Centre...)"
        '
        'WorkCentreBindingSource
        '
        Me.WorkCentreBindingSource.DataSource = GetType(UniSource.ShopFloor.API.CustomerJobClass)
        '
        'colJob
        '
        Me.colJob.FieldName = "Job"
        Me.colJob.Name = "colJob"
        Me.colJob.Width = 20
        '
        'colPart
        '
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        Me.colPart.Width = 20
        '
        'colSupplyScope
        '
        Me.colSupplyScope.FieldName = "SupplyScope"
        Me.colSupplyScope.Name = "colSupplyScope"
        Me.colSupplyScope.Width = 20
        '
        'colWorkCentreCategory
        '
        Me.colWorkCentreCategory.ColumnEdit = Me.WorkCentreCategoryItemLookUpEdit
        Me.colWorkCentreCategory.FieldName = "CustomerWorkCentreCategory"
        Me.colWorkCentreCategory.Name = "colWorkCentreCategory"
        Me.colWorkCentreCategory.Visible = True
        Me.colWorkCentreCategory.VisibleIndex = 2
        Me.colWorkCentreCategory.Width = 142
        '
        'WorkCentreCategoryItemLookUpEdit
        '
        Me.WorkCentreCategoryItemLookUpEdit.AutoHeight = False
        Me.WorkCentreCategoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.WorkCentreCategoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WorkCentreCategoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.WorkCentreCategoryItemLookUpEdit.DataSource = Me.WorkCentreCategoryBindingSource
        Me.WorkCentreCategoryItemLookUpEdit.DisplayMember = "Code"
        Me.WorkCentreCategoryItemLookUpEdit.Name = "WorkCentreCategoryItemLookUpEdit"
        Me.WorkCentreCategoryItemLookUpEdit.NullText = "(Select Work Centre Category...)"
        '
        'WorkCentreCategoryBindingSource
        '
        Me.WorkCentreCategoryBindingSource.DataSource = GetType(UniSource.ShopFloor.API.CustomerWorkCentreCategory)
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 20
        '
        'colError
        '
        Me.colError.FieldName = "Error"
        Me.colError.Name = "colError"
        Me.colError.OptionsColumn.ReadOnly = True
        Me.colError.Width = 20
        '
        'colStartDate
        '
        Me.colStartDate.Caption = "Start Date Time"
        Me.colStartDate.ColumnEdit = Me.StartDateRepositoryItemDateEdit
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 6
        Me.colStartDate.Width = 107
        '
        'StartDateRepositoryItemDateEdit
        '
        Me.StartDateRepositoryItemDateEdit.AutoHeight = False
        Me.StartDateRepositoryItemDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDateRepositoryItemDateEdit.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.StartDateRepositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDateRepositoryItemDateEdit.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.StartDateRepositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDateRepositoryItemDateEdit.Mask.EditMask = "dd/MM/yyyy HH:mm"
        Me.StartDateRepositoryItemDateEdit.Name = "StartDateRepositoryItemDateEdit"
        Me.StartDateRepositoryItemDateEdit.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colEndDateTime
        '
        Me.colEndDateTime.Caption = "End Date Time"
        Me.colEndDateTime.ColumnEdit = Me.EndDateRepositoryItemDateEdit
        Me.colEndDateTime.FieldName = "EndDate"
        Me.colEndDateTime.Name = "colEndDateTime"
        Me.colEndDateTime.Visible = True
        Me.colEndDateTime.VisibleIndex = 7
        Me.colEndDateTime.Width = 114
        '
        'EndDateRepositoryItemDateEdit
        '
        Me.EndDateRepositoryItemDateEdit.AutoHeight = False
        Me.EndDateRepositoryItemDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDateRepositoryItemDateEdit.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.EndDateRepositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EndDateRepositoryItemDateEdit.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.EndDateRepositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EndDateRepositoryItemDateEdit.Mask.EditMask = "dd/MM/yyyy HH:mm"
        Me.EndDateRepositoryItemDateEdit.Name = "EndDateRepositoryItemDateEdit"
        Me.EndDateRepositoryItemDateEdit.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colEmployee
        '
        Me.colEmployee.Caption = "Employee"
        Me.colEmployee.ColumnEdit = Me.EmployeeRepositoryItemLookUpEdit
        Me.colEmployee.FieldName = "EmployeeID"
        Me.colEmployee.Name = "colEmployee"
        Me.colEmployee.Visible = True
        Me.colEmployee.VisibleIndex = 1
        Me.colEmployee.Width = 132
        '
        'EmployeeRepositoryItemLookUpEdit
        '
        Me.EmployeeRepositoryItemLookUpEdit.AutoHeight = False
        Me.EmployeeRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmployeeRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "First Name", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "Last Name", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.EmployeeRepositoryItemLookUpEdit.DataSource = Me.PeopleBindingSource
        Me.EmployeeRepositoryItemLookUpEdit.DisplayMember = "DisplayName"
        Me.EmployeeRepositoryItemLookUpEdit.Name = "EmployeeRepositoryItemLookUpEdit"
        Me.EmployeeRepositoryItemLookUpEdit.NullText = "(Select Employee...)"
        Me.EmployeeRepositoryItemLookUpEdit.ValueMember = "IdPeople"
        '
        'PeopleBindingSource
        '
        Me.PeopleBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.People)
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Rate Type"
        Me.GridColumn3.ColumnEdit = Me.RateTypeRepositoryItemLookUpEdit
        Me.GridColumn3.FieldName = "RateType"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 8
        Me.GridColumn3.Width = 110
        '
        'RateTypeRepositoryItemLookUpEdit
        '
        Me.RateTypeRepositoryItemLookUpEdit.AutoHeight = False
        Me.RateTypeRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RateTypeRepositoryItemLookUpEdit.Name = "RateTypeRepositoryItemLookUpEdit"
        Me.RateTypeRepositoryItemLookUpEdit.NullText = "(Select  RateType......)"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Invoice Run"
        Me.GridColumn4.ColumnEdit = Me.InvoiceRunRepositoryItemLookUpEdit
        Me.GridColumn4.FieldName = "InvoiceRunOption"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 12
        Me.GridColumn4.Width = 76
        '
        'InvoiceRunRepositoryItemLookUpEdit
        '
        Me.InvoiceRunRepositoryItemLookUpEdit.AutoHeight = False
        Me.InvoiceRunRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceRunRepositoryItemLookUpEdit.Name = "InvoiceRunRepositoryItemLookUpEdit"
        Me.InvoiceRunRepositoryItemLookUpEdit.ReadOnly = True
        '
        'colPaymentAmount
        '
        Me.colPaymentAmount.Caption = "Payment Amount"
        Me.colPaymentAmount.FieldName = "PaymentAmount"
        Me.colPaymentAmount.Name = "colPaymentAmount"
        Me.colPaymentAmount.Visible = True
        Me.colPaymentAmount.VisibleIndex = 14
        Me.colPaymentAmount.Width = 84
        '
        'colPaymentRun
        '
        Me.colPaymentRun.Caption = "Payment Run"
        Me.colPaymentRun.ColumnEdit = Me.PaymentRunRepositoryItemLookUpEdit
        Me.colPaymentRun.FieldName = "PaymentRunOption"
        Me.colPaymentRun.Name = "colPaymentRun"
        Me.colPaymentRun.Visible = True
        Me.colPaymentRun.VisibleIndex = 13
        Me.colPaymentRun.Width = 109
        '
        'PaymentRunRepositoryItemLookUpEdit
        '
        Me.PaymentRunRepositoryItemLookUpEdit.AutoHeight = False
        Me.PaymentRunRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PaymentRunRepositoryItemLookUpEdit.Name = "PaymentRunRepositoryItemLookUpEdit"
        Me.PaymentRunRepositoryItemLookUpEdit.ReadOnly = True
        '
        'colEmployeeRate
        '
        Me.colEmployeeRate.Caption = "Pay Rate"
        Me.colEmployeeRate.ColumnEdit = Me.EmployeeRateRepositoryItemSpinEdit
        Me.colEmployeeRate.FieldName = "EmployeeRate"
        Me.colEmployeeRate.Name = "colEmployeeRate"
        Me.colEmployeeRate.Visible = True
        Me.colEmployeeRate.VisibleIndex = 15
        Me.colEmployeeRate.Width = 91
        '
        'EmployeeRateRepositoryItemSpinEdit
        '
        Me.EmployeeRateRepositoryItemSpinEdit.AutoHeight = False
        Me.EmployeeRateRepositoryItemSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EmployeeRateRepositoryItemSpinEdit.Name = "EmployeeRateRepositoryItemSpinEdit"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Shift Total"
        Me.GridColumn7.ColumnEdit = Me.EmployeeTotalRepositoryItemSpinEdit
        Me.GridColumn7.FieldName = "TotalPrice"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 16
        Me.GridColumn7.Width = 89
        '
        'EmployeeTotalRepositoryItemSpinEdit
        '
        Me.EmployeeTotalRepositoryItemSpinEdit.AutoHeight = False
        Me.EmployeeTotalRepositoryItemSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EmployeeTotalRepositoryItemSpinEdit.Name = "EmployeeTotalRepositoryItemSpinEdit"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Invoice Amount"
        Me.GridColumn8.FieldName = "InvoiceAmount"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 17
        Me.GridColumn8.Width = 77
        '
        'gvDeleted
        '
        Me.gvDeleted.Caption = "Delete Record"
        Me.gvDeleted.ColumnEdit = Me.DeleteRecordRepositoryItemCheckEdit
        Me.gvDeleted.FieldName = "Deleted"
        Me.gvDeleted.Name = "gvDeleted"
        Me.gvDeleted.Visible = True
        Me.gvDeleted.VisibleIndex = 18
        Me.gvDeleted.Width = 87
        '
        'DeleteRecordRepositoryItemCheckEdit
        '
        Me.DeleteRecordRepositoryItemCheckEdit.AutoHeight = False
        Me.DeleteRecordRepositoryItemCheckEdit.Name = "DeleteRecordRepositoryItemCheckEdit"
        '
        'WorkCentreCategoryRepositoryItemGridLookUpEdit
        '
        Me.WorkCentreCategoryRepositoryItemGridLookUpEdit.AutoHeight = False
        Me.WorkCentreCategoryRepositoryItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WorkCentreCategoryRepositoryItemGridLookUpEdit.Name = "WorkCentreCategoryRepositoryItemGridLookUpEdit"
        Me.WorkCentreCategoryRepositoryItemGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'InvoiceRunRepositoryItemCheckEdit
        '
        Me.InvoiceRunRepositoryItemCheckEdit.AutoHeight = False
        Me.InvoiceRunRepositoryItemCheckEdit.Name = "InvoiceRunRepositoryItemCheckEdit"
        '
        'InvoiceWeekRepositoryItemComboBox
        '
        Me.InvoiceWeekRepositoryItemComboBox.AutoHeight = False
        Me.InvoiceWeekRepositoryItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceWeekRepositoryItemComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53"})
        Me.InvoiceWeekRepositoryItemComboBox.Name = "InvoiceWeekRepositoryItemComboBox"
        '
        'RepositoryItemCheckEdit
        '
        Me.RepositoryItemCheckEdit.AutoHeight = False
        Me.RepositoryItemCheckEdit.Name = "RepositoryItemCheckEdit"
        '
        'NotWorkedRepositoryItemCheckEdit
        '
        Me.NotWorkedRepositoryItemCheckEdit.AutoHeight = False
        Me.NotWorkedRepositoryItemCheckEdit.Name = "NotWorkedRepositoryItemCheckEdit"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1207, 251)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.DetailsLayoutControl)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1201, 223)
        Me.XtraTabPage1.Text = "Details"
        '
        'DetailsLayoutControl
        '
        Me.DetailsLayoutControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailsLayoutControl.Controls.Add(Me.ImportReferenceTextEdit)
        Me.DetailsLayoutControl.Controls.Add(Me.ImportDateEdit)
        Me.DetailsLayoutControl.Controls.Add(Me.SourceTextEdit)
        Me.DetailsLayoutControl.Controls.Add(Me.TextEdit7)
        Me.DetailsLayoutControl.Controls.Add(Me.TextEdit6)
        Me.DetailsLayoutControl.Controls.Add(Me.JobCategoryTextEdit)
        Me.DetailsLayoutControl.Controls.Add(Me.JobTypeTextEdit)
        Me.DetailsLayoutControl.Controls.Add(Me.TextEdit5)
        Me.DetailsLayoutControl.Controls.Add(Me.TextEdit3)
        Me.DetailsLayoutControl.Controls.Add(Me.DateEdit1)
        Me.DetailsLayoutControl.Controls.Add(Me.TextEdit4)
        Me.DetailsLayoutControl.Controls.Add(Me.JobnumberTextEdit)
        Me.DetailsLayoutControl.Controls.Add(Me.CustomerTextEdit)
        Me.DetailsLayoutControl.Enabled = False
        Me.DetailsLayoutControl.Location = New System.Drawing.Point(3, 6)
        Me.DetailsLayoutControl.Name = "DetailsLayoutControl"
        Me.DetailsLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(185, 29, 250, 350)
        Me.DetailsLayoutControl.Root = Me.LayoutControlGroup1
        Me.DetailsLayoutControl.Size = New System.Drawing.Size(1181, 223)
        Me.DetailsLayoutControl.TabIndex = 0
        Me.DetailsLayoutControl.Text = "DetailsLayoutControl"
        '
        'ImportReferenceTextEdit
        '
        Me.ImportReferenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ImportReference", True))
        Me.ImportReferenceTextEdit.Location = New System.Drawing.Point(100, 108)
        Me.ImportReferenceTextEdit.MenuManager = Me.BarManager1
        Me.ImportReferenceTextEdit.Name = "ImportReferenceTextEdit"
        Me.ImportReferenceTextEdit.Size = New System.Drawing.Size(488, 20)
        Me.ImportReferenceTextEdit.StyleController = Me.DetailsLayoutControl
        Me.ImportReferenceTextEdit.TabIndex = 1
        '
        'ImportDateEdit
        '
        Me.ImportDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ImportDate", True))
        Me.ImportDateEdit.EditValue = Nothing
        Me.ImportDateEdit.Location = New System.Drawing.Point(970, 84)
        Me.ImportDateEdit.MenuManager = Me.BarManager1
        Me.ImportDateEdit.Name = "ImportDateEdit"
        Me.ImportDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ImportDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ImportDateEdit.Size = New System.Drawing.Size(199, 20)
        Me.ImportDateEdit.StyleController = Me.DetailsLayoutControl
        Me.ImportDateEdit.TabIndex = 1
        '
        'SourceTextEdit
        '
        Me.SourceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Jobsource", True))
        Me.SourceTextEdit.Location = New System.Drawing.Point(680, 84)
        Me.SourceTextEdit.MenuManager = Me.BarManager1
        Me.SourceTextEdit.Name = "SourceTextEdit"
        Me.SourceTextEdit.Size = New System.Drawing.Size(198, 20)
        Me.SourceTextEdit.StyleController = Me.DetailsLayoutControl
        Me.SourceTextEdit.TabIndex = 1
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CostCentre", True))
        Me.TextEdit7.Location = New System.Drawing.Point(970, 60)
        Me.TextEdit7.MenuManager = Me.BarManager1
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(199, 20)
        Me.TextEdit7.StyleController = Me.DetailsLayoutControl
        Me.TextEdit7.TabIndex = 1
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "RepresentativeCode", True))
        Me.TextEdit6.Location = New System.Drawing.Point(679, 60)
        Me.TextEdit6.MenuManager = Me.BarManager1
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(199, 20)
        Me.TextEdit6.StyleController = Me.DetailsLayoutControl
        Me.TextEdit6.TabIndex = 1
        '
        'JobCategoryTextEdit
        '
        Me.JobCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobCategory", True))
        Me.JobCategoryTextEdit.Location = New System.Drawing.Point(970, 36)
        Me.JobCategoryTextEdit.MenuManager = Me.BarManager1
        Me.JobCategoryTextEdit.Name = "JobCategoryTextEdit"
        Me.JobCategoryTextEdit.Size = New System.Drawing.Size(199, 20)
        Me.JobCategoryTextEdit.StyleController = Me.DetailsLayoutControl
        Me.JobCategoryTextEdit.TabIndex = 1
        '
        'JobTypeTextEdit
        '
        Me.JobTypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobType", True))
        Me.JobTypeTextEdit.Location = New System.Drawing.Point(679, 36)
        Me.JobTypeTextEdit.MenuManager = Me.BarManager1
        Me.JobTypeTextEdit.Name = "JobTypeTextEdit"
        Me.JobTypeTextEdit.Size = New System.Drawing.Size(199, 20)
        Me.JobTypeTextEdit.StyleController = Me.DetailsLayoutControl
        Me.JobTypeTextEdit.TabIndex = 1
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobStage", True))
        Me.TextEdit5.Enabled = False
        Me.TextEdit5.Location = New System.Drawing.Point(679, 12)
        Me.TextEdit5.MenuManager = Me.BarManager1
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(199, 20)
        Me.TextEdit5.StyleController = Me.DetailsLayoutControl
        Me.TextEdit5.TabIndex = 1
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description1", True))
        Me.TextEdit3.Location = New System.Drawing.Point(100, 36)
        Me.TextEdit3.MenuManager = Me.BarManager1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(487, 20)
        Me.TextEdit3.StyleController = Me.DetailsLayoutControl
        Me.TextEdit3.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobDate", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(970, 12)
        Me.DateEdit1.MenuManager = Me.BarManager1
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(199, 20)
        Me.DateEdit1.StyleController = Me.DetailsLayoutControl
        Me.DateEdit1.TabIndex = 7
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "AccountName", True))
        Me.TextEdit4.Location = New System.Drawing.Point(100, 84)
        Me.TextEdit4.MenuManager = Me.BarManager1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(488, 20)
        Me.TextEdit4.StyleController = Me.DetailsLayoutControl
        Me.TextEdit4.TabIndex = 6
        '
        'JobnumberTextEdit
        '
        Me.JobnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobNumber", True))
        Me.JobnumberTextEdit.Enabled = False
        Me.JobnumberTextEdit.Location = New System.Drawing.Point(100, 12)
        Me.JobnumberTextEdit.MenuManager = Me.BarManager1
        Me.JobnumberTextEdit.Name = "JobnumberTextEdit"
        Me.JobnumberTextEdit.Size = New System.Drawing.Size(487, 20)
        Me.JobnumberTextEdit.StyleController = Me.DetailsLayoutControl
        Me.JobnumberTextEdit.TabIndex = 5
        '
        'CustomerTextEdit
        '
        Me.CustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Customer", True))
        Me.CustomerTextEdit.Location = New System.Drawing.Point(100, 60)
        Me.CustomerTextEdit.MenuManager = Me.BarManager1
        Me.CustomerTextEdit.Name = "CustomerTextEdit"
        Me.CustomerTextEdit.Size = New System.Drawing.Size(487, 20)
        Me.CustomerTextEdit.StyleController = Me.DetailsLayoutControl
        Me.CustomerTextEdit.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.CustomerLayoutControlItem, Me.ItemForJobNumber, Me.LayoutControlItem3, Me.ItemForJobstage, Me.JobTypeItem, Me.JobCategoryItem, Me.LayoutControlItem6, Me.CostCentreItem, Me.SourceItem, Me.ImportDateItem, Me.ImportReferenceItem})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1181, 223)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextEdit4
        Me.LayoutControlItem4.CustomizationFormText = "Account Name"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(580, 24)
        Me.LayoutControlItem4.Text = "Account Name"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.DateEdit1
        Me.LayoutControlItem5.CustomizationFormText = "Job Date"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(870, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(291, 24)
        Me.LayoutControlItem5.Text = "Job Date"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(85, 13)
        '
        'CustomerLayoutControlItem
        '
        Me.CustomerLayoutControlItem.Control = Me.CustomerTextEdit
        Me.CustomerLayoutControlItem.CustomizationFormText = "Customer"
        Me.CustomerLayoutControlItem.Location = New System.Drawing.Point(0, 48)
        Me.CustomerLayoutControlItem.Name = "CustomerLayoutControlItem"
        Me.CustomerLayoutControlItem.Size = New System.Drawing.Size(579, 24)
        Me.CustomerLayoutControlItem.Text = "Customer"
        Me.CustomerLayoutControlItem.TextSize = New System.Drawing.Size(85, 13)
        '
        'ItemForJobNumber
        '
        Me.ItemForJobNumber.Control = Me.JobnumberTextEdit
        Me.ItemForJobNumber.CustomizationFormText = "Job Number"
        Me.ItemForJobNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobNumber.Name = "ItemForJobNumber"
        Me.ItemForJobNumber.Size = New System.Drawing.Size(579, 24)
        Me.ItemForJobNumber.Text = "Job Number"
        Me.ItemForJobNumber.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TextEdit3
        Me.LayoutControlItem3.CustomizationFormText = "Description"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(579, 24)
        Me.LayoutControlItem3.Text = "Description"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(85, 13)
        '
        'ItemForJobstage
        '
        Me.ItemForJobstage.Control = Me.TextEdit5
        Me.ItemForJobstage.CustomizationFormText = "Job Stage"
        Me.ItemForJobstage.Location = New System.Drawing.Point(579, 0)
        Me.ItemForJobstage.Name = "ItemForJobstage"
        Me.ItemForJobstage.Size = New System.Drawing.Size(291, 24)
        Me.ItemForJobstage.Text = "Job Stage"
        Me.ItemForJobstage.TextSize = New System.Drawing.Size(85, 13)
        '
        'JobTypeItem
        '
        Me.JobTypeItem.Control = Me.JobTypeTextEdit
        Me.JobTypeItem.CustomizationFormText = "JobType"
        Me.JobTypeItem.Location = New System.Drawing.Point(579, 24)
        Me.JobTypeItem.Name = "JobTypeItem"
        Me.JobTypeItem.Size = New System.Drawing.Size(291, 24)
        Me.JobTypeItem.Text = "JobType"
        Me.JobTypeItem.TextSize = New System.Drawing.Size(85, 13)
        '
        'JobCategoryItem
        '
        Me.JobCategoryItem.Control = Me.JobCategoryTextEdit
        Me.JobCategoryItem.CustomizationFormText = "Job Category"
        Me.JobCategoryItem.Location = New System.Drawing.Point(870, 24)
        Me.JobCategoryItem.Name = "JobCategoryItem"
        Me.JobCategoryItem.Size = New System.Drawing.Size(291, 24)
        Me.JobCategoryItem.Text = "Job Category"
        Me.JobCategoryItem.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TextEdit6
        Me.LayoutControlItem6.CustomizationFormText = "Representative"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(579, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(291, 24)
        Me.LayoutControlItem6.Text = "Representative"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(85, 13)
        '
        'CostCentreItem
        '
        Me.CostCentreItem.Control = Me.TextEdit7
        Me.CostCentreItem.CustomizationFormText = "Cost Centre"
        Me.CostCentreItem.Location = New System.Drawing.Point(870, 48)
        Me.CostCentreItem.Name = "CostCentreItem"
        Me.CostCentreItem.Size = New System.Drawing.Size(291, 24)
        Me.CostCentreItem.Text = "Cost Centre"
        Me.CostCentreItem.TextSize = New System.Drawing.Size(85, 13)
        '
        'SourceItem
        '
        Me.SourceItem.Control = Me.SourceTextEdit
        Me.SourceItem.CustomizationFormText = "Source"
        Me.SourceItem.Location = New System.Drawing.Point(580, 72)
        Me.SourceItem.Name = "SourceItem"
        Me.SourceItem.Size = New System.Drawing.Size(290, 131)
        Me.SourceItem.Text = "Source"
        Me.SourceItem.TextSize = New System.Drawing.Size(85, 13)
        '
        'ImportDateItem
        '
        Me.ImportDateItem.Control = Me.ImportDateEdit
        Me.ImportDateItem.CustomizationFormText = "Import Date"
        Me.ImportDateItem.Location = New System.Drawing.Point(870, 72)
        Me.ImportDateItem.Name = "ImportDateItem"
        Me.ImportDateItem.Size = New System.Drawing.Size(291, 131)
        Me.ImportDateItem.Text = "Import Date"
        Me.ImportDateItem.TextSize = New System.Drawing.Size(85, 13)
        '
        'ImportReferenceItem
        '
        Me.ImportReferenceItem.Control = Me.ImportReferenceTextEdit
        Me.ImportReferenceItem.CustomizationFormText = "Import Reference"
        Me.ImportReferenceItem.Location = New System.Drawing.Point(0, 96)
        Me.ImportReferenceItem.Name = "ImportReferenceItem"
        Me.ImportReferenceItem.Size = New System.Drawing.Size(580, 107)
        Me.ImportReferenceItem.Text = "Import Reference"
        Me.ImportReferenceItem.TextSize = New System.Drawing.Size(85, 13)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1201, 223)
        Me.XtraTabPage2.Text = "AdditionalFields"
        '
        'GroupLayoutControlGroup
        '
        Me.GroupLayoutControlGroup.CustomizationFormText = "GroupLayoutControlGroup"
        Me.GroupLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.GroupLayoutControlGroup.GroupBordersVisible = False
        Me.GroupLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedLayoutControlItem, Me.LayoutControlItem2})
        Me.GroupLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.GroupLayoutControlGroup.Name = "GroupLayoutControlGroup"
        Me.GroupLayoutControlGroup.Size = New System.Drawing.Size(1231, 622)
        Me.GroupLayoutControlGroup.Text = "GroupLayoutControlGroup"
        Me.GroupLayoutControlGroup.TextVisible = False
        '
        'TabbedLayoutControlItem
        '
        Me.TabbedLayoutControlItem.Control = Me.XtraTabControl1
        Me.TabbedLayoutControlItem.CustomizationFormText = "TabbedLayoutControlItem"
        Me.TabbedLayoutControlItem.Location = New System.Drawing.Point(0, 0)
        Me.TabbedLayoutControlItem.Name = "TabbedLayoutControlItem"
        Me.TabbedLayoutControlItem.Size = New System.Drawing.Size(1211, 255)
        Me.TabbedLayoutControlItem.Text = "TabbedLayoutControlItem"
        Me.TabbedLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
        Me.TabbedLayoutControlItem.TextToControlDistance = 0
        Me.TabbedLayoutControlItem.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.gcJobline
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 255)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1211, 347)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'xaeJobQuoteTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 743)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = True
        Me.Name = "xaeJobQuoteTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job Quote Time"
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
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gcJobline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJoblines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionRepositoryItemTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linenumberRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateRepositoryItemDateEdit.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateRepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateRepositoryItemDateEdit.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateRepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateTypeRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceRunRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentRunRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeRateRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeTotalRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeleteRecordRepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCentreCategoryRepositoryItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceRunRepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceWeekRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotWorkedRepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.DetailsLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsLayoutControl.ResumeLayout(False)
        CType(Me.ImportReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobstage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTypeItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCategoryItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCentreItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDateItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportReferenceItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiAddLine As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditLine As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DetailsLayoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CustomerLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImportReferenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImportDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SourceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobCategoryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobTypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobstage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobTypeItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobCategoryItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CostCentreItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SourceItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImportDateItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImportReferenceItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gcJobline As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJoblines As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colMarkupFactor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMarkupPercent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineDiscountPercent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseDiscountPercent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsStockDrawn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantityStockDrawn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantitySupplierOrdered As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplier1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplier2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalActualCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPriceBeforeDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPriceBeforeMarkup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantityStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantitySupplier1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISPOGenerated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISRlGenerated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobLineDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGRVDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGRVNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCriteria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNormalWearAndTearReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsNormalWearAndTear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsProcured As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseOrder1ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseOrderLine1ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseOrder2ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseOrderLine2ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantitySupplier2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeasurement1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeasurement2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeasurement3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPurchasePrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colERPBudgetLineID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colERPRecoveryLineID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplier1ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplier2ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionLines As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseOrderLines As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplyScope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentreCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InventoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents InventoryItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkCentreItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents WorkCentreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkCentreCategoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents WorkCentreCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkCentreCategoryRepositoryItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents JobLineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StartDateRepositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colEndDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EndDateRepositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colEmployee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmployeeRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RateTypeRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InvoiceRunRepositoryItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colPaymentAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InvoiceWeekRepositoryItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents QuantityRepositoryItemSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents DescriptionRepositoryItemTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colPaymentRun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colEmployeeRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmployeeRateRepositoryItemSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmployeeTotalRepositoryItemSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NotWorkedRepositoryItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gvDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeleteRecordRepositoryItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents bbidelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCopyline As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents linenumberRepositoryItemSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents InvoiceRunRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PaymentRunRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
