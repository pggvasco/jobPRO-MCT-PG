<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeReportStockAllocation
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
        Me.StockItemToLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.StockItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btPreviewReport = New DevExpress.XtraEditors.SimpleButton()
        Me.StockItemLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.StockItemToLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockItemLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.StockItemToLookUpEdit)
        Me.LayoutControl1.Controls.Add(Me.btPreviewReport)
        Me.LayoutControl1.Controls.Add(Me.StockItemLookUpEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(306, 171, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(436, 117)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'StockItemToLookUpEdit
        '
        Me.StockItemToLookUpEdit.Location = New System.Drawing.Point(49, 38)
        Me.StockItemToLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockItemToLookUpEdit.Name = "StockItemToLookUpEdit"
        Me.StockItemToLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StockItemToLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description1", "Description1", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.StockItemToLookUpEdit.Properties.DataSource = Me.StockItemBindingSource
        Me.StockItemToLookUpEdit.Properties.NullText = "[Selecione o item de estoque para]"
        Me.StockItemToLookUpEdit.Size = New System.Drawing.Size(375, 22)
        Me.StockItemToLookUpEdit.StyleController = Me.LayoutControl1
        Me.StockItemToLookUpEdit.TabIndex = 5
        '
        'StockItemBindingSource
        '
        Me.StockItemBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.StockItem)
        '
        'btPreviewReport
        '
        Me.btPreviewReport.Location = New System.Drawing.Point(323, 64)
        Me.btPreviewReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btPreviewReport.Name = "btPreviewReport"
        Me.btPreviewReport.Size = New System.Drawing.Size(101, 23)
        Me.btPreviewReport.StyleController = Me.LayoutControl1
        Me.btPreviewReport.TabIndex = 5
        Me.btPreviewReport.Text = "Preview Report"
        '
        'StockItemLookUpEdit
        '
        Me.StockItemLookUpEdit.Location = New System.Drawing.Point(49, 12)
        Me.StockItemLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockItemLookUpEdit.Name = "StockItemLookUpEdit"
        Me.StockItemLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StockItemLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description1", "Description1", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.StockItemLookUpEdit.Properties.DataSource = Me.StockItemBindingSource
        Me.StockItemLookUpEdit.Properties.NullText = "[Selecione o item de estoque de]"
        Me.StockItemLookUpEdit.Size = New System.Drawing.Size(375, 22)
        Me.StockItemLookUpEdit.StyleController = Me.LayoutControl1
        Me.StockItemLookUpEdit.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(436, 117)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.StockItemLookUpEdit
        Me.LayoutControlItem1.CustomizationFormText = "Artigo"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(416, 26)
        Me.LayoutControlItem1.Text = "Artigo"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(34, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btPreviewReport
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(311, 52)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(105, 45)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 52)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(311, 45)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.StockItemToLookUpEdit
        Me.LayoutControlItem3.CustomizationFormText = "Para"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(416, 26)
        Me.LayoutControlItem3.Text = "Para"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(34, 16)
        '
        'xaeReportStockAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 117)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(454, 164)
        Me.MinimumSize = New System.Drawing.Size(454, 164)
        Me.Name = "xaeReportStockAllocation"
        Me.Text = "Relatorio - alocação de estoque"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.StockItemToLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockItemLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents StockItemLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents StockItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btPreviewReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents StockItemToLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
