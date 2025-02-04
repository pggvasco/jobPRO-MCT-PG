<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfCancelLines
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.JobLineProcessedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWorkCentre1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryItem1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.gcJobLines = New DevExpress.XtraGrid.GridControl()
        Me.JobLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvJobLines = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWorkCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CancelledReasonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLineProcessedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJobLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelledReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.btOK)
        Me.LayoutControl1.Controls.Add(Me.btCancel)
        Me.LayoutControl1.Controls.Add(Me.gcJobLines)
        Me.LayoutControl1.Controls.Add(Me.CancelledReasonTextEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(829, 67, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(773, 507)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.JobLineProcessedBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 305)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(749, 164)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'JobLineProcessedBindingSource
        '
        Me.JobLineProcessedBindingSource.DataSource = GetType(UniSource.ShopFloor.API.JobLine)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWorkCentre1, Me.colInventoryItem1, Me.colDescription11, Me.colDescription21, Me.colQuantity1, Me.colUnitPrice1, Me.colTotalPrice1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsDetail.SmartDetailExpand = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colWorkCentre1
        '
        Me.colWorkCentre1.FieldName = "WorkCentre"
        Me.colWorkCentre1.Name = "colWorkCentre1"
        Me.colWorkCentre1.Visible = True
        Me.colWorkCentre1.VisibleIndex = 0
        '
        'colInventoryItem1
        '
        Me.colInventoryItem1.FieldName = "InventoryItem"
        Me.colInventoryItem1.Name = "colInventoryItem1"
        Me.colInventoryItem1.Visible = True
        Me.colInventoryItem1.VisibleIndex = 1
        '
        'colDescription11
        '
        Me.colDescription11.FieldName = "Description1"
        Me.colDescription11.Name = "colDescription11"
        Me.colDescription11.Visible = True
        Me.colDescription11.VisibleIndex = 2
        '
        'colDescription21
        '
        Me.colDescription21.FieldName = "Description2"
        Me.colDescription21.Name = "colDescription21"
        Me.colDescription21.Visible = True
        Me.colDescription21.VisibleIndex = 3
        '
        'colQuantity1
        '
        Me.colQuantity1.FieldName = "Quantity"
        Me.colQuantity1.Name = "colQuantity1"
        Me.colQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:n2}")})
        Me.colQuantity1.Visible = True
        Me.colQuantity1.VisibleIndex = 4
        '
        'colUnitPrice1
        '
        Me.colUnitPrice1.FieldName = "UnitPrice"
        Me.colUnitPrice1.Name = "colUnitPrice1"
        Me.colUnitPrice1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", "{0:c2}")})
        Me.colUnitPrice1.Visible = True
        Me.colUnitPrice1.VisibleIndex = 5
        '
        'colTotalPrice1
        '
        Me.colTotalPrice1.FieldName = "TotalPrice"
        Me.colTotalPrice1.Name = "colTotalPrice1"
        Me.colTotalPrice1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:c2}")})
        Me.colTotalPrice1.Tag = ""
        Me.colTotalPrice1.Visible = True
        Me.colTotalPrice1.VisibleIndex = 6
        '
        'btOK
        '
        Me.btOK.Location = New System.Drawing.Point(388, 473)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(184, 22)
        Me.btOK.StyleController = Me.LayoutControl1
        Me.btOK.TabIndex = 7
        Me.btOK.Text = "OK"
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(576, 473)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(185, 22)
        Me.btCancel.StyleController = Me.LayoutControl1
        Me.btCancel.TabIndex = 6
        Me.btCancel.Text = "Cancel"
        '
        'gcJobLines
        '
        Me.gcJobLines.DataSource = Me.JobLineBindingSource
        Me.gcJobLines.Location = New System.Drawing.Point(12, 52)
        Me.gcJobLines.MainView = Me.gvJobLines
        Me.gcJobLines.Name = "gcJobLines"
        Me.gcJobLines.Size = New System.Drawing.Size(749, 233)
        Me.gcJobLines.TabIndex = 5
        Me.gcJobLines.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobLines})
        '
        'JobLineBindingSource
        '
        Me.JobLineBindingSource.DataSource = GetType(UniSource.ShopFloor.API.JobLine)
        '
        'gvJobLines
        '
        Me.gvJobLines.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWorkCentre, Me.colInventoryItem, Me.colDescription1, Me.colDescription2, Me.colQuantity, Me.colUnitPrice, Me.colTotalPrice})
        Me.gvJobLines.GridControl = Me.gcJobLines
        Me.gvJobLines.Name = "gvJobLines"
        Me.gvJobLines.OptionsBehavior.ReadOnly = True
        Me.gvJobLines.OptionsDetail.EnableMasterViewMode = False
        Me.gvJobLines.OptionsDetail.ShowDetailTabs = False
        Me.gvJobLines.OptionsDetail.SmartDetailExpand = False
        Me.gvJobLines.OptionsView.ShowFooter = True
        '
        'colWorkCentre
        '
        Me.colWorkCentre.FieldName = "WorkCentre"
        Me.colWorkCentre.Name = "colWorkCentre"
        Me.colWorkCentre.Visible = True
        Me.colWorkCentre.VisibleIndex = 0
        '
        'colInventoryItem
        '
        Me.colInventoryItem.Caption = "Inventory Item"
        Me.colInventoryItem.FieldName = "InventoryItem"
        Me.colInventoryItem.Name = "colInventoryItem"
        Me.colInventoryItem.Visible = True
        Me.colInventoryItem.VisibleIndex = 1
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description1"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 2
        '
        'colDescription2
        '
        Me.colDescription2.FieldName = "Description2"
        Me.colDescription2.Name = "colDescription2"
        Me.colDescription2.Visible = True
        Me.colDescription2.VisibleIndex = 3
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:n2}")})
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 4
        '
        'colUnitPrice
        '
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", "{0:c2}")})
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 5
        '
        'colTotalPrice
        '
        Me.colTotalPrice.FieldName = "TotalPrice"
        Me.colTotalPrice.Name = "colTotalPrice"
        Me.colTotalPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:c2}")})
        Me.colTotalPrice.Visible = True
        Me.colTotalPrice.VisibleIndex = 6
        '
        'CancelledReasonTextEdit
        '
        Me.CancelledReasonTextEdit.Location = New System.Drawing.Point(221, 12)
        Me.CancelledReasonTextEdit.Name = "CancelledReasonTextEdit"
        Me.CancelledReasonTextEdit.Size = New System.Drawing.Size(540, 20)
        Me.CancelledReasonTextEdit.StyleController = Me.LayoutControl1
        Me.CancelledReasonTextEdit.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(773, 507)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CancelledReasonTextEdit
        Me.LayoutControlItem1.CustomizationFormText = "Cancel Reason"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(753, 24)
        Me.LayoutControlItem1.Text = "Cancel Reason"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(206, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.gcJobLines
        Me.LayoutControlItem2.CustomizationFormText = "Lines"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(753, 253)
        Me.LayoutControlItem2.Text = "Lines"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(206, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btCancel
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(564, 461)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(189, 26)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 461)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(376, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btOK
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(376, 461)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(188, 26)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridControl1
        Me.LayoutControlItem5.CustomizationFormText = "Can't be cancelled, already processed"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 277)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(753, 184)
        Me.LayoutControlItem5.Text = "Nao pode ser cancelada. Ja foi processada"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(206, 13)
        '
        'xfCancelLines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 507)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xfCancelLines"
        Me.Text = "Cancelar linhas"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLineProcessedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJobLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelledReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents CancelledReasonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcJobLines As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobLines As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWorkCentre1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryItem1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Public WithEvents JobLineProcessedBindingSource As System.Windows.Forms.BindingSource
End Class
