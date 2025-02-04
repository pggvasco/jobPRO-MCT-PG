<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeEmployee
    Inherits UniSource.ShopFloor.GUI.xaegEmployee

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
        Me.Rates = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.QualificationLineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GvEmployeeQualification = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInventoryItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InventoryRepositoryItemSearchLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.StockItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyFree = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockLink = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPack = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReOrdLvl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReOrdQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMinLvl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaxLvl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAveUCst = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLatUCst = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLowUCst = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHigUCst = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdUCst = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyOnHand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLGrvCount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServiceItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReservedQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyOnPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyOnSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhseItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerialItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDuplicateSN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStrictSN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBomCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSMtrxCol = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCComponent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDDateReleased = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIBinLocationID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDStkitemTimeStamp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIInvSegValue1ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIInvSegValue2ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIInvSegValue3ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIInvSegValue4ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIInvSegValue5ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIInvSegValue6ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIInvSegValue7ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCExtDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCSimpleCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCommissionItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMFPQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBLotItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colILotStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBLotMustExpire = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIItemCostingMethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFItemLastGRVCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIEUCommodityID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIEUSupplementaryUnitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFNetMass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIUOMStockingUnitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIUOMDefPurchaseUnitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIUOMDefSellUnitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBinLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidationErrorMessages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPropertiesValidationErrorMessages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActiveRepositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colEmployee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InventoryRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FirstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Rates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Rates.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationLineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvEmployeeQualification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryRepositoryItemSearchLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveRepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.LayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(904, 422)
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(683, 473)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(802, 473)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl1.Controls.Add(Me.Rates)
        Me.LayoutControl1.Controls.Add(Me.TextEdit4)
        Me.LayoutControl1.Controls.Add(Me.TextEdit3)
        Me.LayoutControl1.Controls.Add(Me.TextEdit2)
        Me.LayoutControl1.Controls.Add(Me.TextEdit1)
        Me.LayoutControl1.Controls.Add(Me.LastNameTextEdit)
        Me.LayoutControl1.Controls.Add(Me.FirstNameTextEdit)
        Me.LayoutControl1.Location = New System.Drawing.Point(7, 36)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(438, 79, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(894, 365)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Rates
        '
        Me.Rates.Location = New System.Drawing.Point(12, 84)
        Me.Rates.Name = "Rates"
        Me.Rates.SelectedTabPage = Me.XtraTabPage2
        Me.Rates.Size = New System.Drawing.Size(870, 269)
        Me.Rates.TabIndex = 10
        Me.Rates.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LayoutControl3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(864, 241)
        Me.XtraTabPage2.Text = "Qualification"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.GridControl1)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(864, 241)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.QualificationLineListBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GvEmployeeQualification
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.InventoryRepositoryItemLookUpEdit, Me.ActiveRepositoryItemCheckEdit, Me.InventoryRepositoryItemSearchLookUpEdit})
        Me.GridControl1.Size = New System.Drawing.Size(840, 217)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvEmployeeQualification})
        '
        'QualificationLineListBindingSource
        '
        Me.QualificationLineListBindingSource.DataMember = "QualificationLineList"
        Me.QualificationLineListBindingSource.DataSource = Me.BindingSource
        '
        'GvEmployeeQualification
        '
        Me.GvEmployeeQualification.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInventoryItemID, Me.colActive, Me.colEmployee, Me.colID, Me.colError})
        Me.GvEmployeeQualification.GridControl = Me.GridControl1
        Me.GvEmployeeQualification.Name = "GvEmployeeQualification"
        '
        'colInventoryItemID
        '
        Me.colInventoryItemID.Caption = "Qualification"
        Me.colInventoryItemID.ColumnEdit = Me.InventoryRepositoryItemSearchLookUpEdit
        Me.colInventoryItemID.FieldName = "InventoryItemID"
        Me.colInventoryItemID.Name = "colInventoryItemID"
        Me.colInventoryItemID.Visible = True
        Me.colInventoryItemID.VisibleIndex = 0
        '
        'InventoryRepositoryItemSearchLookUpEdit
        '
        Me.InventoryRepositoryItemSearchLookUpEdit.AutoHeight = False
        Me.InventoryRepositoryItemSearchLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.InventoryRepositoryItemSearchLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InventoryRepositoryItemSearchLookUpEdit.DataSource = Me.StockItemBindingSource
        Me.InventoryRepositoryItemSearchLookUpEdit.DisplayMember = "Description1"
        Me.InventoryRepositoryItemSearchLookUpEdit.Name = "InventoryRepositoryItemSearchLookUpEdit"
        Me.InventoryRepositoryItemSearchLookUpEdit.NullText = "(Select  Qualification...)"
        Me.InventoryRepositoryItemSearchLookUpEdit.ValueMember = "StockLink"
        Me.InventoryRepositoryItemSearchLookUpEdit.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'StockItemBindingSource
        '
        Me.StockItemBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.StockItem)
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colQtyFree, Me.colStockLink, Me.colCode, Me.colDescription1, Me.colDescription2, Me.colDescription3, Me.colItemGroup, Me.colPack, Me.colTTI, Me.colTTC, Me.colTTG, Me.colTTR, Me.colBarCode, Me.colReOrdLvl, Me.colReOrdQty, Me.colMinLvl, Me.colMaxLvl, Me.colAveUCst, Me.colLatUCst, Me.colLowUCst, Me.colHigUCst, Me.colStdUCst, Me.colQtyOnHand, Me.colLGrvCount, Me.colServiceItem, Me.colItemActive, Me.colReservedQty, Me.colQtyOnPO, Me.colQtyOnSO, Me.colWhseItem, Me.colSerialItem, Me.colDuplicateSN, Me.colStrictSN, Me.colBomCode, Me.colSMtrxCol, Me.colB, Me.colJobQty, Me.colCModel, Me.colCRevision, Me.colCComponent, Me.colDDateReleased, Me.colIBinLocationID, Me.colDStkitemTimeStamp, Me.colIInvSegValue1ID, Me.colIInvSegValue2ID, Me.colIInvSegValue3ID, Me.colIInvSegValue4ID, Me.colIInvSegValue5ID, Me.colIInvSegValue6ID, Me.colIInvSegValue7ID, Me.colCExtDescription, Me.colCSimpleCode, Me.colBCommissionItem, Me.colMFPQty, Me.colBLotItem, Me.colILotStatus, Me.colBLotMustExpire, Me.colIItemCostingMethod, Me.colFItemLastGRVCost, Me.colIEUCommodityID, Me.colIEUSupplementaryUnitID, Me.colFNetMass, Me.colIUOMStockingUnitID, Me.colIUOMDefPurchaseUnitID, Me.colIUOMDefSellUnitID, Me.colBinLocation, Me.colValidationErrorMessages, Me.colPropertiesValidationErrorMessages})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.RepositoryItemSearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colLGrvCount, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colQtyFree
        '
        Me.colQtyFree.FieldName = "QtyFree"
        Me.colQtyFree.Name = "colQtyFree"
        Me.colQtyFree.OptionsColumn.ReadOnly = True
        '
        'colStockLink
        '
        Me.colStockLink.FieldName = "StockLink"
        Me.colStockLink.Name = "colStockLink"
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 53
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description1"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 1
        Me.colDescription1.Width = 53
        '
        'colDescription2
        '
        Me.colDescription2.FieldName = "Description2"
        Me.colDescription2.Name = "colDescription2"
        '
        'colDescription3
        '
        Me.colDescription3.FieldName = "Description3"
        Me.colDescription3.Name = "colDescription3"
        Me.colDescription3.Width = 53
        '
        'colItemGroup
        '
        Me.colItemGroup.FieldName = "ItemGroup"
        Me.colItemGroup.Name = "colItemGroup"
        Me.colItemGroup.Width = 53
        '
        'colPack
        '
        Me.colPack.FieldName = "Pack"
        Me.colPack.Name = "colPack"
        Me.colPack.Width = 53
        '
        'colTTI
        '
        Me.colTTI.FieldName = "TTI"
        Me.colTTI.Name = "colTTI"
        Me.colTTI.Width = 53
        '
        'colTTC
        '
        Me.colTTC.FieldName = "TTC"
        Me.colTTC.Name = "colTTC"
        '
        'colTTG
        '
        Me.colTTG.FieldName = "TTG"
        Me.colTTG.Name = "colTTG"
        Me.colTTG.Width = 53
        '
        'colTTR
        '
        Me.colTTR.FieldName = "TTR"
        Me.colTTR.Name = "colTTR"
        '
        'colBarCode
        '
        Me.colBarCode.FieldName = "BarCode"
        Me.colBarCode.Name = "colBarCode"
        Me.colBarCode.Width = 53
        '
        'colReOrdLvl
        '
        Me.colReOrdLvl.FieldName = "ReOrdLvl"
        Me.colReOrdLvl.Name = "colReOrdLvl"
        Me.colReOrdLvl.Width = 53
        '
        'colReOrdQty
        '
        Me.colReOrdQty.FieldName = "ReOrdQty"
        Me.colReOrdQty.Name = "colReOrdQty"
        Me.colReOrdQty.Width = 86
        '
        'colMinLvl
        '
        Me.colMinLvl.FieldName = "MinLvl"
        Me.colMinLvl.Name = "colMinLvl"
        '
        'colMaxLvl
        '
        Me.colMaxLvl.FieldName = "MaxLvl"
        Me.colMaxLvl.Name = "colMaxLvl"
        '
        'colAveUCst
        '
        Me.colAveUCst.FieldName = "AveUCst"
        Me.colAveUCst.Name = "colAveUCst"
        '
        'colLatUCst
        '
        Me.colLatUCst.FieldName = "LatUCst"
        Me.colLatUCst.Name = "colLatUCst"
        '
        'colLowUCst
        '
        Me.colLowUCst.FieldName = "LowUCst"
        Me.colLowUCst.Name = "colLowUCst"
        '
        'colHigUCst
        '
        Me.colHigUCst.FieldName = "HigUCst"
        Me.colHigUCst.Name = "colHigUCst"
        '
        'colStdUCst
        '
        Me.colStdUCst.FieldName = "StdUCst"
        Me.colStdUCst.Name = "colStdUCst"
        '
        'colQtyOnHand
        '
        Me.colQtyOnHand.FieldName = "QtyOnHand"
        Me.colQtyOnHand.Name = "colQtyOnHand"
        '
        'colLGrvCount
        '
        Me.colLGrvCount.FieldName = "LGrvCount"
        Me.colLGrvCount.Name = "colLGrvCount"
        '
        'colServiceItem
        '
        Me.colServiceItem.FieldName = "ServiceItem"
        Me.colServiceItem.Name = "colServiceItem"
        '
        'colItemActive
        '
        Me.colItemActive.FieldName = "ItemActive"
        Me.colItemActive.Name = "colItemActive"
        '
        'colReservedQty
        '
        Me.colReservedQty.FieldName = "ReservedQty"
        Me.colReservedQty.Name = "colReservedQty"
        '
        'colQtyOnPO
        '
        Me.colQtyOnPO.FieldName = "QtyOnPO"
        Me.colQtyOnPO.Name = "colQtyOnPO"
        '
        'colQtyOnSO
        '
        Me.colQtyOnSO.FieldName = "QtyOnSO"
        Me.colQtyOnSO.Name = "colQtyOnSO"
        '
        'colWhseItem
        '
        Me.colWhseItem.FieldName = "WhseItem"
        Me.colWhseItem.Name = "colWhseItem"
        '
        'colSerialItem
        '
        Me.colSerialItem.FieldName = "SerialItem"
        Me.colSerialItem.Name = "colSerialItem"
        '
        'colDuplicateSN
        '
        Me.colDuplicateSN.FieldName = "DuplicateSN"
        Me.colDuplicateSN.Name = "colDuplicateSN"
        '
        'colStrictSN
        '
        Me.colStrictSN.FieldName = "StrictSN"
        Me.colStrictSN.Name = "colStrictSN"
        '
        'colBomCode
        '
        Me.colBomCode.FieldName = "BomCode"
        Me.colBomCode.Name = "colBomCode"
        '
        'colSMtrxCol
        '
        Me.colSMtrxCol.FieldName = "SMtrxCol"
        Me.colSMtrxCol.Name = "colSMtrxCol"
        '
        'colB
        '
        Me.colB.FieldName = "B"
        Me.colB.Name = "colB"
        '
        'colJobQty
        '
        Me.colJobQty.FieldName = "JobQty"
        Me.colJobQty.Name = "colJobQty"
        '
        'colCModel
        '
        Me.colCModel.FieldName = "CModel"
        Me.colCModel.Name = "colCModel"
        '
        'colCRevision
        '
        Me.colCRevision.FieldName = "CRevision"
        Me.colCRevision.Name = "colCRevision"
        '
        'colCComponent
        '
        Me.colCComponent.FieldName = "CComponent"
        Me.colCComponent.Name = "colCComponent"
        '
        'colDDateReleased
        '
        Me.colDDateReleased.FieldName = "DDateReleased"
        Me.colDDateReleased.Name = "colDDateReleased"
        '
        'colIBinLocationID
        '
        Me.colIBinLocationID.FieldName = "IBinLocationID"
        Me.colIBinLocationID.Name = "colIBinLocationID"
        '
        'colDStkitemTimeStamp
        '
        Me.colDStkitemTimeStamp.FieldName = "DStkitemTimeStamp"
        Me.colDStkitemTimeStamp.Name = "colDStkitemTimeStamp"
        '
        'colIInvSegValue1ID
        '
        Me.colIInvSegValue1ID.FieldName = "IInvSegValue1ID"
        Me.colIInvSegValue1ID.Name = "colIInvSegValue1ID"
        '
        'colIInvSegValue2ID
        '
        Me.colIInvSegValue2ID.FieldName = "IInvSegValue2ID"
        Me.colIInvSegValue2ID.Name = "colIInvSegValue2ID"
        Me.colIInvSegValue2ID.Width = 50
        '
        'colIInvSegValue3ID
        '
        Me.colIInvSegValue3ID.FieldName = "IInvSegValue3ID"
        Me.colIInvSegValue3ID.Name = "colIInvSegValue3ID"
        Me.colIInvSegValue3ID.Width = 50
        '
        'colIInvSegValue4ID
        '
        Me.colIInvSegValue4ID.FieldName = "IInvSegValue4ID"
        Me.colIInvSegValue4ID.Name = "colIInvSegValue4ID"
        '
        'colIInvSegValue5ID
        '
        Me.colIInvSegValue5ID.FieldName = "IInvSegValue5ID"
        Me.colIInvSegValue5ID.Name = "colIInvSegValue5ID"
        '
        'colIInvSegValue6ID
        '
        Me.colIInvSegValue6ID.FieldName = "IInvSegValue6ID"
        Me.colIInvSegValue6ID.Name = "colIInvSegValue6ID"
        Me.colIInvSegValue6ID.Width = 50
        '
        'colIInvSegValue7ID
        '
        Me.colIInvSegValue7ID.FieldName = "IInvSegValue7ID"
        Me.colIInvSegValue7ID.Name = "colIInvSegValue7ID"
        Me.colIInvSegValue7ID.Width = 50
        '
        'colCExtDescription
        '
        Me.colCExtDescription.FieldName = "CExtDescription"
        Me.colCExtDescription.Name = "colCExtDescription"
        Me.colCExtDescription.Width = 50
        '
        'colCSimpleCode
        '
        Me.colCSimpleCode.FieldName = "CSimpleCode"
        Me.colCSimpleCode.Name = "colCSimpleCode"
        '
        'colBCommissionItem
        '
        Me.colBCommissionItem.FieldName = "BCommissionItem"
        Me.colBCommissionItem.Name = "colBCommissionItem"
        Me.colBCommissionItem.Width = 50
        '
        'colMFPQty
        '
        Me.colMFPQty.FieldName = "MFPQty"
        Me.colMFPQty.Name = "colMFPQty"
        '
        'colBLotItem
        '
        Me.colBLotItem.FieldName = "BLotItem"
        Me.colBLotItem.Name = "colBLotItem"
        Me.colBLotItem.Width = 50
        '
        'colILotStatus
        '
        Me.colILotStatus.FieldName = "ILotStatus"
        Me.colILotStatus.Name = "colILotStatus"
        Me.colILotStatus.Width = 50
        '
        'colBLotMustExpire
        '
        Me.colBLotMustExpire.FieldName = "BLotMustExpire"
        Me.colBLotMustExpire.Name = "colBLotMustExpire"
        Me.colBLotMustExpire.Width = 50
        '
        'colIItemCostingMethod
        '
        Me.colIItemCostingMethod.FieldName = "IItemCostingMethod"
        Me.colIItemCostingMethod.Name = "colIItemCostingMethod"
        Me.colIItemCostingMethod.Width = 50
        '
        'colFItemLastGRVCost
        '
        Me.colFItemLastGRVCost.FieldName = "FItemLastGRVCost"
        Me.colFItemLastGRVCost.Name = "colFItemLastGRVCost"
        Me.colFItemLastGRVCost.Width = 50
        '
        'colIEUCommodityID
        '
        Me.colIEUCommodityID.FieldName = "IEUCommodityID"
        Me.colIEUCommodityID.Name = "colIEUCommodityID"
        Me.colIEUCommodityID.Width = 67
        '
        'colIEUSupplementaryUnitID
        '
        Me.colIEUSupplementaryUnitID.FieldName = "IEUSupplementaryUnitID"
        Me.colIEUSupplementaryUnitID.Name = "colIEUSupplementaryUnitID"
        '
        'colFNetMass
        '
        Me.colFNetMass.FieldName = "FNetMass"
        Me.colFNetMass.Name = "colFNetMass"
        '
        'colIUOMStockingUnitID
        '
        Me.colIUOMStockingUnitID.FieldName = "IUOMStockingUnitID"
        Me.colIUOMStockingUnitID.Name = "colIUOMStockingUnitID"
        '
        'colIUOMDefPurchaseUnitID
        '
        Me.colIUOMDefPurchaseUnitID.FieldName = "IUOMDefPurchaseUnitID"
        Me.colIUOMDefPurchaseUnitID.Name = "colIUOMDefPurchaseUnitID"
        '
        'colIUOMDefSellUnitID
        '
        Me.colIUOMDefSellUnitID.FieldName = "IUOMDefSellUnitID"
        Me.colIUOMDefSellUnitID.Name = "colIUOMDefSellUnitID"
        '
        'colBinLocation
        '
        Me.colBinLocation.FieldName = "BinLocation"
        Me.colBinLocation.Name = "colBinLocation"
        '
        'colValidationErrorMessages
        '
        Me.colValidationErrorMessages.FieldName = "ValidationErrorMessages"
        Me.colValidationErrorMessages.Name = "colValidationErrorMessages"
        Me.colValidationErrorMessages.OptionsColumn.ReadOnly = True
        '
        'colPropertiesValidationErrorMessages
        '
        Me.colPropertiesValidationErrorMessages.FieldName = "PropertiesValidationErrorMessages"
        Me.colPropertiesValidationErrorMessages.Name = "colPropertiesValidationErrorMessages"
        Me.colPropertiesValidationErrorMessages.OptionsColumn.ReadOnly = True
        '
        'colActive
        '
        Me.colActive.ColumnEdit = Me.ActiveRepositoryItemCheckEdit
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.Visible = True
        Me.colActive.VisibleIndex = 1
        '
        'ActiveRepositoryItemCheckEdit
        '
        Me.ActiveRepositoryItemCheckEdit.AutoHeight = False
        Me.ActiveRepositoryItemCheckEdit.Name = "ActiveRepositoryItemCheckEdit"
        '
        'colEmployee
        '
        Me.colEmployee.FieldName = "Employee"
        Me.colEmployee.Name = "colEmployee"
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
        'InventoryRepositoryItemLookUpEdit
        '
        Me.InventoryRepositoryItemLookUpEdit.AutoHeight = False
        Me.InventoryRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InventoryRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description1", "Description", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description2", "Description", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.InventoryRepositoryItemLookUpEdit.DataSource = Me.StockItemBindingSource
        Me.InventoryRepositoryItemLookUpEdit.DisplayMember = "Code"
        Me.InventoryRepositoryItemLookUpEdit.Name = "InventoryRepositoryItemLookUpEdit"
        Me.InventoryRepositoryItemLookUpEdit.NullText = "(Select Inventory Item...)"
        Me.InventoryRepositoryItemLookUpEdit.ValueMember = "StockLink"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(864, 241)
        Me.LayoutControlGroup3.Text = "LayoutControlGroup3"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.GridControl1
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(844, 221)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EmployeeID", True))
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.Location = New System.Drawing.Point(537, 60)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(345, 20)
        Me.TextEdit4.StyleController = Me.LayoutControl1
        Me.TextEdit4.TabIndex = 9
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EmployeeNumber", True))
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.Location = New System.Drawing.Point(101, 60)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(343, 20)
        Me.TextEdit3.StyleController = Me.LayoutControl1
        Me.TextEdit3.TabIndex = 8
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Person.DisplayName", True))
        Me.TextEdit2.Enabled = False
        Me.TextEdit2.Location = New System.Drawing.Point(101, 36)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(781, 20)
        Me.TextEdit2.StyleController = Me.LayoutControl1
        Me.TextEdit2.TabIndex = 7
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Person.Initials", True))
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(474, 12)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(112, 20)
        Me.TextEdit1.StyleController = Me.LayoutControl1
        Me.TextEdit1.TabIndex = 6
        '
        'LastNameTextEdit
        '
        Me.LastNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Person.LastName", True))
        Me.LastNameTextEdit.Enabled = False
        Me.LastNameTextEdit.Location = New System.Drawing.Point(679, 12)
        Me.LastNameTextEdit.Name = "LastNameTextEdit"
        Me.LastNameTextEdit.Size = New System.Drawing.Size(203, 20)
        Me.LastNameTextEdit.StyleController = Me.LayoutControl1
        Me.LastNameTextEdit.TabIndex = 5
        '
        'FirstNameTextEdit
        '
        Me.FirstNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Person.FirstName", True))
        Me.FirstNameTextEdit.Enabled = False
        Me.FirstNameTextEdit.Location = New System.Drawing.Point(101, 12)
        Me.FirstNameTextEdit.Name = "FirstNameTextEdit"
        Me.FirstNameTextEdit.Size = New System.Drawing.Size(280, 20)
        Me.FirstNameTextEdit.StyleController = Me.LayoutControl1
        Me.FirstNameTextEdit.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(894, 365)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.FirstNameTextEdit
        Me.LayoutControlItem1.CustomizationFormText = "First Name"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(373, 24)
        Me.LayoutControlItem1.Text = "First Name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LastNameTextEdit
        Me.LayoutControlItem2.CustomizationFormText = "Last Name"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(578, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem2.Text = "Last Name"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TextEdit1
        Me.LayoutControlItem3.CustomizationFormText = "Initials"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(373, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(205, 24)
        Me.LayoutControlItem3.Text = "Initials"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextEdit2
        Me.LayoutControlItem4.CustomizationFormText = "Display Name"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(874, 24)
        Me.LayoutControlItem4.Text = "Display Name"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TextEdit3
        Me.LayoutControlItem5.CustomizationFormText = "Employee Number"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(436, 24)
        Me.LayoutControlItem5.Text = "Employee Number"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TextEdit4
        Me.LayoutControlItem6.CustomizationFormText = "ID Number"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(436, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(438, 24)
        Me.LayoutControlItem6.Text = "ID Number"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Rates
        Me.LayoutControlItem7.CustomizationFormText = "Rates"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(874, 273)
        Me.LayoutControlItem7.Text = "Rates"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'xaeEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 508)
        Me.Name = "xaeEmployee"
        Me.Text = "Employee"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Rates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Rates.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationLineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvEmployeeQualification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryRepositoryItemSearchLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveRepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LastNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FirstNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Rates As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvEmployeeQualification As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents QualificationLineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colInventoryItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InventoryRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents StockItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActiveRepositoryItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colEmployee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InventoryRepositoryItemSearchLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyFree As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockLink As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBarCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReOrdLvl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReOrdQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinLvl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaxLvl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAveUCst As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLatUCst As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLowUCst As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHigUCst As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdUCst As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyOnHand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLGrvCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReservedQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyOnPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyOnSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhseItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerialItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuplicateSN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStrictSN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBomCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMtrxCol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCComponent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDDateReleased As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIBinLocationID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDStkitemTimeStamp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIInvSegValue1ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIInvSegValue2ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIInvSegValue3ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIInvSegValue4ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIInvSegValue5ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIInvSegValue6ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIInvSegValue7ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCExtDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSimpleCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCommissionItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMFPQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBLotItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colILotStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBLotMustExpire As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIItemCostingMethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFItemLastGRVCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIEUCommodityID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIEUSupplementaryUnitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFNetMass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIUOMStockingUnitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIUOMDefPurchaseUnitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIUOMDefSellUnitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBinLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidationErrorMessages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPropertiesValidationErrorMessages As DevExpress.XtraGrid.Columns.GridColumn
End Class
