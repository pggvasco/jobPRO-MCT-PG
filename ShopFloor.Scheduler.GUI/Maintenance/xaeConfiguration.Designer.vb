<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeConfiguration
    Inherits UniSource.ShopFloor.Scheduler.GUI.xaegConfiguration

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
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForRateMethod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCostCentreMethod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RateMethodLookupEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CostCentreMethodLookupEdit = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRateMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCostCentreMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateMethodLookupEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCentreMethodLookupEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(386, 85)
        Me.grpGroup.Text = "Configuration"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(243, 104)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(324, 104)
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Configuration)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.RateMethodLookupEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CostCentreMethodLookupEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 22)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(382, 61)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(382, 61)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'ItemForRateMethod
        '
        Me.ItemForRateMethod.Control = Me.RateMethodLookupEdit
        Me.ItemForRateMethod.CustomizationFormText = "Rate Method"
        Me.ItemForRateMethod.Location = New System.Drawing.Point(0, 0)
        Me.ItemForRateMethod.Name = "ItemForRateMethod"
        Me.ItemForRateMethod.Size = New System.Drawing.Size(382, 30)
        Me.ItemForRateMethod.Text = "Rate Method"
        Me.ItemForRateMethod.TextSize = New System.Drawing.Size(97, 13)
        Me.ItemForRateMethod.TextToControlDistance = 5
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForRateMethod, Me.ItemForCostCentreMethod})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(382, 61)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCostCentreMethod
        '
        Me.ItemForCostCentreMethod.Control = Me.CostCentreMethodLookupEdit
        Me.ItemForCostCentreMethod.CustomizationFormText = "Cost Centre Method"
        Me.ItemForCostCentreMethod.Location = New System.Drawing.Point(0, 30)
        Me.ItemForCostCentreMethod.Name = "ItemForCostCentreMethod"
        Me.ItemForCostCentreMethod.Size = New System.Drawing.Size(382, 31)
        Me.ItemForCostCentreMethod.Text = "Cost Centre Method"
        Me.ItemForCostCentreMethod.TextSize = New System.Drawing.Size(97, 13)
        Me.ItemForCostCentreMethod.TextToControlDistance = 5
        '
        'RateMethodLookupEdit
        '
        Me.RateMethodLookupEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "RateMethod", True))
        Me.RateMethodLookupEdit.Location = New System.Drawing.Point(107, 5)
        Me.RateMethodLookupEdit.Name = "RateMethodLookupEdit"
        Me.RateMethodLookupEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RateMethodLookupEdit.Properties.NullText = ""
        Me.RateMethodLookupEdit.Size = New System.Drawing.Size(270, 20)
        Me.RateMethodLookupEdit.StyleController = Me.DataLayoutControl1
        Me.RateMethodLookupEdit.TabIndex = 4
        '
        'CostCentreMethodLookupEdit
        '
        Me.CostCentreMethodLookupEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CostCentreMethod", True))
        Me.CostCentreMethodLookupEdit.Location = New System.Drawing.Point(107, 35)
        Me.CostCentreMethodLookupEdit.Name = "CostCentreMethodLookupEdit"
        Me.CostCentreMethodLookupEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CostCentreMethodLookupEdit.Properties.NullText = ""
        Me.CostCentreMethodLookupEdit.Size = New System.Drawing.Size(270, 20)
        Me.CostCentreMethodLookupEdit.StyleController = Me.DataLayoutControl1
        Me.CostCentreMethodLookupEdit.TabIndex = 5
        '
        'xaeConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 139)
        Me.Name = "xaeConfiguration"
        Me.Text = "Configuration"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRateMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCostCentreMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateMethodLookupEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCentreMethodLookupEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents RateMethodLookupEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CostCentreMethodLookupEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForRateMethod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCostCentreMethod As DevExpress.XtraLayout.LayoutControlItem
End Class
