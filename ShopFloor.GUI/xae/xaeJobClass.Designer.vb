<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobClass
    Inherits UniSource.ShopFloor.GUI.xaegJobClass

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
        Me.gcJobClass = New DevExpress.XtraGrid.GridControl()
        Me.JobclassLineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvJobClass = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InventoryRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.StockItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCustomerWorkCentreCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.JobClassTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gcJobClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobclassLineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobClassTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.LayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(927, 376)
        Me.grpGroup.Text = "Customer JobClass"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(767, 404)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(865, 404)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl1.Controls.Add(Me.gcJobClass)
        Me.LayoutControl1.Controls.Add(Me.JobClassTextEdit)
        Me.LayoutControl1.Controls.Add(Me.CodeTextEdit)
        Me.LayoutControl1.Location = New System.Drawing.Point(10, 24)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(567, 15, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(912, 346)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'gcJobClass
        '
        Me.gcJobClass.DataSource = Me.JobclassLineListBindingSource
        Me.gcJobClass.Location = New System.Drawing.Point(12, 36)
        Me.gcJobClass.MainView = Me.gvJobClass
        Me.gcJobClass.Name = "gcJobClass"
        Me.gcJobClass.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.InventoryRepositoryItemLookUpEdit})
        Me.gcJobClass.Size = New System.Drawing.Size(888, 298)
        Me.gcJobClass.TabIndex = 7
        Me.gcJobClass.UseEmbeddedNavigator = True
        Me.gcJobClass.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobClass})
        '
        'JobclassLineListBindingSource
        '
        Me.JobclassLineListBindingSource.DataMember = "JobclassLineList"
        Me.JobclassLineListBindingSource.DataSource = Me.BindingSource
        '
        'gvJobClass
        '
        Me.gvJobClass.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colInventoryItemID, Me.colCustomerWorkCentreCategory, Me.colID, Me.colError})
        Me.gvJobClass.GridControl = Me.gcJobClass
        Me.gvJobClass.Name = "gvJobClass"
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
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        '
        'colInventoryItemID
        '
        Me.colInventoryItemID.Caption = "InventoryItem"
        Me.colInventoryItemID.ColumnEdit = Me.InventoryRepositoryItemLookUpEdit
        Me.colInventoryItemID.FieldName = "InventoryItemID"
        Me.colInventoryItemID.Name = "colInventoryItemID"
        Me.colInventoryItemID.Visible = True
        Me.colInventoryItemID.VisibleIndex = 2
        Me.colInventoryItemID.Width = 89
        '
        'InventoryRepositoryItemLookUpEdit
        '
        Me.InventoryRepositoryItemLookUpEdit.AutoHeight = False
        Me.InventoryRepositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.InventoryRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InventoryRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description1", "Description", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.InventoryRepositoryItemLookUpEdit.DataSource = Me.StockItemBindingSource
        Me.InventoryRepositoryItemLookUpEdit.DisplayMember = "Code"
        Me.InventoryRepositoryItemLookUpEdit.Name = "InventoryRepositoryItemLookUpEdit"
        Me.InventoryRepositoryItemLookUpEdit.NullText = "(Select InventoryItem...)"
        Me.InventoryRepositoryItemLookUpEdit.ValueMember = "StockLink"
        '
        'StockItemBindingSource
        '
        Me.StockItemBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.StockItem)
        '
        'colCustomerWorkCentreCategory
        '
        Me.colCustomerWorkCentreCategory.FieldName = "CustomerWorkCentreCategory"
        Me.colCustomerWorkCentreCategory.Name = "colCustomerWorkCentreCategory"
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
        'JobClassTextEdit
        '
        Me.JobClassTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.JobClassTextEdit.Enabled = False
        Me.JobClassTextEdit.Location = New System.Drawing.Point(513, 12)
        Me.JobClassTextEdit.Name = "JobClassTextEdit"
        Me.JobClassTextEdit.Size = New System.Drawing.Size(387, 20)
        Me.JobClassTextEdit.StyleController = Me.LayoutControl1
        Me.JobClassTextEdit.TabIndex = 5
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Enabled = False
        Me.CodeTextEdit.Location = New System.Drawing.Point(68, 12)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(385, 20)
        Me.CodeTextEdit.StyleController = Me.LayoutControl1
        Me.CodeTextEdit.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(912, 346)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CodeTextEdit
        Me.LayoutControlItem1.CustomizationFormText = "Code"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(445, 24)
        Me.LayoutControlItem1.Text = "Code"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.JobClassTextEdit
        Me.LayoutControlItem2.CustomizationFormText = "Description"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(445, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(447, 24)
        Me.LayoutControlItem2.Text = "Description"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.gcJobClass
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(892, 302)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'xaeJobClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 448)
        Me.Name = "xaeJobClass"
        Me.Text = " Customer JobClass"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gcJobClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobclassLineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobClassTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents StockItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobClassTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobclassLineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gcJobClass As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobClass As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerWorkCentreCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents InventoryRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
