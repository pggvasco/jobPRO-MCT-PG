<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaePart
    Inherits UniSource.ShopFloor.GUI.xaegPart

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
        Me.PartGroupLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PartGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplyScopeLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.SupplyScopeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CriteriaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCriteria = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSupplyScope = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPartGroup = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl.SuspendLayout()
        CType(Me.PartGroupLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyScopeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyScopeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriteriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSupplyScope, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPartGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl)
        Me.grpGroup.Size = New System.Drawing.Size(381, 174)
        Me.grpGroup.Text = "Part"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(238, 193)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(319, 193)
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.API.Part)
        '
        'DataLayoutControl
        '
        Me.DataLayoutControl.Controls.Add(Me.PartGroupLookUpEdit)
        Me.DataLayoutControl.Controls.Add(Me.SupplyScopeLookUpEdit)
        Me.DataLayoutControl.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.CriteriaTextEdit)
        Me.DataLayoutControl.DataSource = Me.BindingSource
        Me.DataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl.Location = New System.Drawing.Point(2, 22)
        Me.DataLayoutControl.Name = "DataLayoutControl"
        Me.DataLayoutControl.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl.Size = New System.Drawing.Size(377, 150)
        Me.DataLayoutControl.TabIndex = 0
        Me.DataLayoutControl.Text = "DataLayoutControl"
        '
        'PartGroupLookUpEdit
        '
        Me.PartGroupLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PartGroup", True))
        Me.PartGroupLookUpEdit.Location = New System.Drawing.Point(63, 125)
        Me.PartGroupLookUpEdit.Name = "PartGroupLookUpEdit"
        Me.PartGroupLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.PartGroupLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartGroupLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.PartGroupLookUpEdit.Properties.DataSource = Me.PartGroupBindingSource
        Me.PartGroupLookUpEdit.Properties.DisplayMember = "Description"
        Me.PartGroupLookUpEdit.Properties.NullText = "(Select Group...)"
        Me.PartGroupLookUpEdit.Size = New System.Drawing.Size(309, 20)
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
        Me.SupplyScopeLookUpEdit.Location = New System.Drawing.Point(63, 95)
        Me.SupplyScopeLookUpEdit.Name = "SupplyScopeLookUpEdit"
        Me.SupplyScopeLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.SupplyScopeLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplyScopeLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SupplyScopeLookUpEdit.Properties.DataSource = Me.SupplyScopeBindingSource
        Me.SupplyScopeLookUpEdit.Properties.DisplayMember = "Description"
        Me.SupplyScopeLookUpEdit.Properties.NullText = "(Select Scope of Supply...)"
        Me.SupplyScopeLookUpEdit.Size = New System.Drawing.Size(309, 20)
        Me.SupplyScopeLookUpEdit.StyleController = Me.DataLayoutControl
        Me.SupplyScopeLookUpEdit.TabIndex = 10
        '
        'SupplyScopeBindingSource
        '
        Me.SupplyScopeBindingSource.DataSource = GetType(UniSource.ShopFloor.API.SupplyScope)
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(63, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Properties.MaxLength = 50
        Me.CodeTextEdit.Size = New System.Drawing.Size(309, 20)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl
        Me.CodeTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(63, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Properties.MaxLength = 255
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(309, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'CriteriaTextEdit
        '
        Me.CriteriaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Criteria", True))
        Me.CriteriaTextEdit.Location = New System.Drawing.Point(63, 65)
        Me.CriteriaTextEdit.Name = "CriteriaTextEdit"
        Me.CriteriaTextEdit.Properties.MaxLength = 255
        Me.CriteriaTextEdit.Size = New System.Drawing.Size(309, 20)
        Me.CriteriaTextEdit.StyleController = Me.DataLayoutControl
        Me.CriteriaTextEdit.TabIndex = 9
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(377, 150)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription, Me.ItemForCriteria, Me.ItemForSupplyScope, Me.ItemForPartGroup})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(377, 150)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(377, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForCode.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(377, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForCriteria
        '
        Me.ItemForCriteria.Control = Me.CriteriaTextEdit
        Me.ItemForCriteria.CustomizationFormText = "Criteria"
        Me.ItemForCriteria.Location = New System.Drawing.Point(0, 60)
        Me.ItemForCriteria.Name = "ItemForCriteria"
        Me.ItemForCriteria.Size = New System.Drawing.Size(377, 30)
        Me.ItemForCriteria.Text = "Criteria"
        Me.ItemForCriteria.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForCriteria.TextToControlDistance = 5
        '
        'ItemForSupplyScope
        '
        Me.ItemForSupplyScope.Control = Me.SupplyScopeLookUpEdit
        Me.ItemForSupplyScope.CustomizationFormText = "Scope"
        Me.ItemForSupplyScope.Location = New System.Drawing.Point(0, 90)
        Me.ItemForSupplyScope.Name = "ItemForSupplyScope"
        Me.ItemForSupplyScope.Size = New System.Drawing.Size(377, 30)
        Me.ItemForSupplyScope.Text = "Scope"
        Me.ItemForSupplyScope.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForSupplyScope.TextToControlDistance = 5
        '
        'ItemForPartGroup
        '
        Me.ItemForPartGroup.Control = Me.PartGroupLookUpEdit
        Me.ItemForPartGroup.CustomizationFormText = "Group"
        Me.ItemForPartGroup.Location = New System.Drawing.Point(0, 120)
        Me.ItemForPartGroup.Name = "ItemForPartGroup"
        Me.ItemForPartGroup.Size = New System.Drawing.Size(377, 30)
        Me.ItemForPartGroup.Text = "Group"
        Me.ItemForPartGroup.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForPartGroup.TextToControlDistance = 5
        '
        'xaePart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 228)
        Me.Name = "xaePart"
        Me.Text = "Part"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl.ResumeLayout(False)
        CType(Me.PartGroupLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyScopeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyScopeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriteriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCriteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSupplyScope, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPartGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CriteriaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCriteria As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PartGroupLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PartGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplyScopeLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SupplyScopeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemForSupplyScope As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPartGroup As DevExpress.XtraLayout.LayoutControlItem
End Class
