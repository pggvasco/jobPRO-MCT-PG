<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeOperation
    Inherits UniSource.ShopFloor.Scheduler.GUI.xaegOperation

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
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CostCentreLookupEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CostCentreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RateSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IsBuyOutTextEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCostCentre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsBuyOut = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCentreLookupEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCentreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsBuyOutTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCostCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsBuyOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(357, 145)
        Me.grpGroup.Text = "Operation"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(214, 164)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(295, 164)
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Operation)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CostCentreLookupEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RateSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsBuyOutTextEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 22)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(353, 121)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(68, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(280, 20)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.CodeTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(68, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(280, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl1
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'CostCentreLookupEdit
        '
        Me.CostCentreLookupEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CostCentre", True))
        Me.CostCentreLookupEdit.Location = New System.Drawing.Point(68, 95)
        Me.CostCentreLookupEdit.Name = "CostCentreLookupEdit"
        Me.CostCentreLookupEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.CostCentreLookupEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CostCentreLookupEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServiceCodeKey", "Service Code Key", 94, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CostCentreLookupEdit.Properties.DataSource = Me.CostCentreBindingSource
        Me.CostCentreLookupEdit.Properties.DisplayMember = "Description"
        Me.CostCentreLookupEdit.Properties.NullText = ""
        Me.CostCentreLookupEdit.Size = New System.Drawing.Size(280, 20)
        Me.CostCentreLookupEdit.StyleController = Me.DataLayoutControl1
        Me.CostCentreLookupEdit.TabIndex = 8
        '
        'CostCentreBindingSource
        '
        Me.CostCentreBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.CostCentre)
        '
        'RateSpinEdit
        '
        Me.RateSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Rate", True))
        Me.RateSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RateSpinEdit.Location = New System.Drawing.Point(68, 65)
        Me.RateSpinEdit.Name = "RateSpinEdit"
        Me.RateSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RateSpinEdit.Properties.DisplayFormat.FormatString = "c"
        Me.RateSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RateSpinEdit.Properties.EditFormat.FormatString = "c"
        Me.RateSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RateSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RateSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RateSpinEdit.Size = New System.Drawing.Size(183, 20)
        Me.RateSpinEdit.StyleController = Me.DataLayoutControl1
        Me.RateSpinEdit.TabIndex = 6
        '
        'IsBuyOutTextEdit
        '
        Me.IsBuyOutTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsBuyOut", True))
        Me.IsBuyOutTextEdit.EditValue = Nothing
        Me.IsBuyOutTextEdit.Location = New System.Drawing.Point(261, 65)
        Me.IsBuyOutTextEdit.Name = "IsBuyOutTextEdit"
        Me.IsBuyOutTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsBuyOutTextEdit.Properties.Caption = "Is BuyOut"
        Me.IsBuyOutTextEdit.Size = New System.Drawing.Size(87, 19)
        Me.IsBuyOutTextEdit.StyleController = Me.DataLayoutControl1
        Me.IsBuyOutTextEdit.TabIndex = 7
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(353, 121)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription, Me.ItemForRate, Me.ItemForCostCentre, Me.ItemForIsBuyOut})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(353, 121)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(353, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(58, 13)
        Me.ItemForCode.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(353, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(58, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForRate
        '
        Me.ItemForRate.Control = Me.RateSpinEdit
        Me.ItemForRate.CustomizationFormText = "Rate"
        Me.ItemForRate.Location = New System.Drawing.Point(0, 60)
        Me.ItemForRate.Name = "ItemForRate"
        Me.ItemForRate.Size = New System.Drawing.Size(256, 30)
        Me.ItemForRate.Text = "Rate"
        Me.ItemForRate.TextSize = New System.Drawing.Size(58, 13)
        Me.ItemForRate.TextToControlDistance = 5
        '
        'ItemForCostCentre
        '
        Me.ItemForCostCentre.Control = Me.CostCentreLookupEdit
        Me.ItemForCostCentre.CustomizationFormText = "Cost Centre"
        Me.ItemForCostCentre.Location = New System.Drawing.Point(0, 90)
        Me.ItemForCostCentre.Name = "ItemForCostCentre"
        Me.ItemForCostCentre.Size = New System.Drawing.Size(353, 31)
        Me.ItemForCostCentre.Text = "Cost Centre"
        Me.ItemForCostCentre.TextSize = New System.Drawing.Size(58, 13)
        Me.ItemForCostCentre.TextToControlDistance = 5
        '
        'ItemForIsBuyOut
        '
        Me.ItemForIsBuyOut.Control = Me.IsBuyOutTextEdit
        Me.ItemForIsBuyOut.CustomizationFormText = "Is Buy Out"
        Me.ItemForIsBuyOut.Location = New System.Drawing.Point(256, 60)
        Me.ItemForIsBuyOut.Name = "ItemForIsBuyOut"
        Me.ItemForIsBuyOut.Size = New System.Drawing.Size(97, 30)
        Me.ItemForIsBuyOut.Text = "Is Buy Out"
        Me.ItemForIsBuyOut.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsBuyOut.TextToControlDistance = 0
        Me.ItemForIsBuyOut.TextVisible = False
        '
        'xaeOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 199)
        Me.Name = "xaeOperation"
        Me.Text = "Operation"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCentreLookupEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCentreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsBuyOutTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCostCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsBuyOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CostCentreLookupEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CostCentreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RateSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IsBuyOutTextEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCostCentre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsBuyOut As DevExpress.XtraLayout.LayoutControlItem
End Class
