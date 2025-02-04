<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeCostCentre
    Inherits xaegCostCentre

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
        Me.ColourColorEdit = New DevExpress.XtraEditors.ColorEdit()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTransactionCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForColour = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TransactionCodeLookupEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.JobTransactionCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.ColourColorEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTransactionCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForColour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionCodeLookupEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTransactionCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(397, 116)
        Me.grpGroup.Text = "Cost Centre"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(254, 135)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(335, 135)
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.API.CostCentre)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.ColourColorEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TransactionCodeLookupEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 22)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(393, 92)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'ColourColorEdit
        '
        Me.ColourColorEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Colour", True))
        Me.ColourColorEdit.EditValue = System.Drawing.Color.Empty
        Me.ColourColorEdit.Location = New System.Drawing.Point(94, 65)
        Me.ColourColorEdit.Name = "ColourColorEdit"
        Me.ColourColorEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColourColorEdit.Properties.ShowColorDialog = False
        Me.ColourColorEdit.Properties.ShowCustomColors = False
        Me.ColourColorEdit.Properties.ShowSystemColors = False
        Me.ColourColorEdit.Size = New System.Drawing.Size(294, 20)
        Me.ColourColorEdit.StyleController = Me.DataLayoutControl1
        Me.ColourColorEdit.TabIndex = 7
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(94, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(97, 20)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.CodeTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(94, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(294, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl1
        Me.DescriptionTextEdit.TabIndex = 5
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(393, 92)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription, Me.ItemForTransactionCode, Me.ItemForColour})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(393, 92)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(196, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(84, 13)
        Me.ItemForCode.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(393, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(84, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForTransactionCode
        '
        Me.ItemForTransactionCode.Control = Me.TransactionCodeLookupEdit
        Me.ItemForTransactionCode.CustomizationFormText = "Transaction Code"
        Me.ItemForTransactionCode.Location = New System.Drawing.Point(196, 0)
        Me.ItemForTransactionCode.Name = "ItemForTransactionCode"
        Me.ItemForTransactionCode.Size = New System.Drawing.Size(197, 30)
        Me.ItemForTransactionCode.Text = "Transaction Code"
        Me.ItemForTransactionCode.TextSize = New System.Drawing.Size(84, 13)
        Me.ItemForTransactionCode.TextToControlDistance = 5
        '
        'ItemForColour
        '
        Me.ItemForColour.Control = Me.ColourColorEdit
        Me.ItemForColour.CustomizationFormText = "Colour"
        Me.ItemForColour.Location = New System.Drawing.Point(0, 60)
        Me.ItemForColour.Name = "ItemForColour"
        Me.ItemForColour.Size = New System.Drawing.Size(393, 32)
        Me.ItemForColour.Text = "Colour"
        Me.ItemForColour.TextSize = New System.Drawing.Size(84, 13)
        Me.ItemForColour.TextToControlDistance = 5
        '
        'TransactionCodeLookupEdit
        '
        Me.TransactionCodeLookupEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "TransactionCode", True))
        Me.TransactionCodeLookupEdit.Location = New System.Drawing.Point(290, 5)
        Me.TransactionCodeLookupEdit.Name = "TransactionCodeLookupEdit"
        Me.TransactionCodeLookupEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.TransactionCodeLookupEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TransactionCodeLookupEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.TransactionCodeLookupEdit.Properties.DataSource = Me.JobTransactionCodeBindingSource
        Me.TransactionCodeLookupEdit.Properties.DisplayMember = "Code"
        Me.TransactionCodeLookupEdit.Properties.NullText = ""
        Me.TransactionCodeLookupEdit.Properties.ValueMember = "Code"
        Me.TransactionCodeLookupEdit.Size = New System.Drawing.Size(98, 20)
        Me.TransactionCodeLookupEdit.StyleController = Me.DataLayoutControl1
        Me.TransactionCodeLookupEdit.TabIndex = 6
        '
        'JobTransactionCodeBindingSource
        '
        Me.JobTransactionCodeBindingSource.DataSource = GetType(Pastel.Evolution.JobTransactionCode)
        '
        'xaeCostCentre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 170)
        Me.Name = "xaeCostCentre"
        Me.Text = "Cost Centre"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.ColourColorEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTransactionCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForColour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionCodeLookupEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTransactionCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTransactionCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColourColorEdit As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents ItemForColour As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TransactionCodeLookupEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents JobTransactionCodeBindingSource As System.Windows.Forms.BindingSource
End Class
