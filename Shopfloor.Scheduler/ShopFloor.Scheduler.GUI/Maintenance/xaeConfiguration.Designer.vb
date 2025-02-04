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
        Me.DrawingExtensionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DrawingTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TimerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LogOffIntervalTypeLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LogOffIntervalSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.RateMethodLookupEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CostCentreMethodLookupEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForRateMethod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCostCentreMethod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemDrawingPath = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.VersionNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.DrawingExtensionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogOffIntervalTypeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogOffIntervalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateMethodLookupEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCentreMethodLookupEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRateMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCostCentreMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDrawingPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VersionNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(386, 267)
        Me.grpGroup.Text = "Configuration"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(243, 286)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(324, 286)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.VersionNumberTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DrawingExtensionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DrawingTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TimerTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.LogOffIntervalTypeLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.LogOffIntervalSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RateMethodLookupEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CostCentreMethodLookupEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 21)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(382, 244)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'DrawingExtensionTextEdit
        '
        Me.DrawingExtensionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DrawingExtension", True))
        Me.DrawingExtensionTextEdit.Location = New System.Drawing.Point(114, 185)
        Me.DrawingExtensionTextEdit.Name = "DrawingExtensionTextEdit"
        Me.DrawingExtensionTextEdit.Size = New System.Drawing.Size(263, 20)
        Me.DrawingExtensionTextEdit.StyleController = Me.DataLayoutControl1
        Me.DrawingExtensionTextEdit.TabIndex = 10
        '
        'DrawingTextEdit
        '
        Me.DrawingTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DrawingPath", True))
        Me.DrawingTextEdit.Location = New System.Drawing.Point(114, 155)
        Me.DrawingTextEdit.Name = "DrawingTextEdit"
        Me.DrawingTextEdit.Size = New System.Drawing.Size(263, 20)
        Me.DrawingTextEdit.StyleController = Me.DataLayoutControl1
        Me.DrawingTextEdit.TabIndex = 9
        '
        'TimerTextEdit
        '
        Me.TimerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "TimerInterval", True))
        Me.TimerTextEdit.Location = New System.Drawing.Point(114, 125)
        Me.TimerTextEdit.Name = "TimerTextEdit"
        Me.TimerTextEdit.Properties.ReadOnly = True
        Me.TimerTextEdit.Size = New System.Drawing.Size(263, 20)
        Me.TimerTextEdit.StyleController = Me.DataLayoutControl1
        Me.TimerTextEdit.TabIndex = 8
        '
        'LogOffIntervalTypeLookUpEdit
        '
        Me.LogOffIntervalTypeLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "LogOffIntervalType", True))
        Me.LogOffIntervalTypeLookUpEdit.Location = New System.Drawing.Point(114, 95)
        Me.LogOffIntervalTypeLookUpEdit.Name = "LogOffIntervalTypeLookUpEdit"
        Me.LogOffIntervalTypeLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LogOffIntervalTypeLookUpEdit.Properties.NullText = "(Select Log Off Interval Type)"
        Me.LogOffIntervalTypeLookUpEdit.Size = New System.Drawing.Size(263, 20)
        Me.LogOffIntervalTypeLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.LogOffIntervalTypeLookUpEdit.TabIndex = 7
        '
        'LogOffIntervalSpinEdit
        '
        Me.LogOffIntervalSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "LogOffInterval", True))
        Me.LogOffIntervalSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.LogOffIntervalSpinEdit.Location = New System.Drawing.Point(114, 65)
        Me.LogOffIntervalSpinEdit.Name = "LogOffIntervalSpinEdit"
        Me.LogOffIntervalSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LogOffIntervalSpinEdit.Size = New System.Drawing.Size(263, 20)
        Me.LogOffIntervalSpinEdit.StyleController = Me.DataLayoutControl1
        Me.LogOffIntervalSpinEdit.TabIndex = 6
        '
        'RateMethodLookupEdit
        '
        Me.RateMethodLookupEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "RateMethod", True))
        Me.RateMethodLookupEdit.Location = New System.Drawing.Point(114, 5)
        Me.RateMethodLookupEdit.Name = "RateMethodLookupEdit"
        Me.RateMethodLookupEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RateMethodLookupEdit.Size = New System.Drawing.Size(263, 20)
        Me.RateMethodLookupEdit.StyleController = Me.DataLayoutControl1
        Me.RateMethodLookupEdit.TabIndex = 4
        '
        'CostCentreMethodLookupEdit
        '
        Me.CostCentreMethodLookupEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CostCentreMethod", True))
        Me.CostCentreMethodLookupEdit.Location = New System.Drawing.Point(114, 35)
        Me.CostCentreMethodLookupEdit.Name = "CostCentreMethodLookupEdit"
        Me.CostCentreMethodLookupEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CostCentreMethodLookupEdit.Size = New System.Drawing.Size(263, 20)
        Me.CostCentreMethodLookupEdit.StyleController = Me.DataLayoutControl1
        Me.CostCentreMethodLookupEdit.TabIndex = 5
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(382, 244)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForRateMethod, Me.ItemForCostCentreMethod, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.ItemDrawingPath, Me.LayoutControlItem5, Me.LayoutControlItem6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(382, 244)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForRateMethod
        '
        Me.ItemForRateMethod.Control = Me.RateMethodLookupEdit
        Me.ItemForRateMethod.CustomizationFormText = "Rate Method"
        Me.ItemForRateMethod.Location = New System.Drawing.Point(0, 0)
        Me.ItemForRateMethod.Name = "ItemForRateMethod"
        Me.ItemForRateMethod.Size = New System.Drawing.Size(382, 30)
        Me.ItemForRateMethod.Text = "Rate Method"
        Me.ItemForRateMethod.TextSize = New System.Drawing.Size(104, 13)
        Me.ItemForRateMethod.TextToControlDistance = 5
        '
        'ItemForCostCentreMethod
        '
        Me.ItemForCostCentreMethod.Control = Me.CostCentreMethodLookupEdit
        Me.ItemForCostCentreMethod.CustomizationFormText = "Cost Centre Method"
        Me.ItemForCostCentreMethod.Location = New System.Drawing.Point(0, 30)
        Me.ItemForCostCentreMethod.Name = "ItemForCostCentreMethod"
        Me.ItemForCostCentreMethod.Size = New System.Drawing.Size(382, 30)
        Me.ItemForCostCentreMethod.Text = "Cost Centre Method"
        Me.ItemForCostCentreMethod.TextSize = New System.Drawing.Size(104, 13)
        Me.ItemForCostCentreMethod.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.LogOffIntervalSpinEdit
        Me.LayoutControlItem1.CustomizationFormText = "Log Off Interval"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(382, 30)
        Me.LayoutControlItem1.Text = "Log Off Interval"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(104, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LogOffIntervalTypeLookUpEdit
        Me.LayoutControlItem2.CustomizationFormText = "Log Off Interval Type"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(382, 30)
        Me.LayoutControlItem2.Text = "Log Off Interval Type"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(104, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TimerTextEdit
        Me.LayoutControlItem3.CustomizationFormText = "Next Log Off Time"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(382, 30)
        Me.LayoutControlItem3.Text = "Next Log Off Time"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(104, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'ItemDrawingPath
        '
        Me.ItemDrawingPath.Control = Me.DrawingTextEdit
        Me.ItemDrawingPath.CustomizationFormText = "Drawing Path"
        Me.ItemDrawingPath.Location = New System.Drawing.Point(0, 150)
        Me.ItemDrawingPath.Name = "ItemDrawingPath"
        Me.ItemDrawingPath.Size = New System.Drawing.Size(382, 30)
        Me.ItemDrawingPath.Text = "Drawing Path"
        Me.ItemDrawingPath.TextSize = New System.Drawing.Size(104, 13)
        Me.ItemDrawingPath.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.DrawingExtensionTextEdit
        Me.LayoutControlItem5.CustomizationFormText = "Drawing Extension"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 180)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(382, 30)
        Me.LayoutControlItem5.Text = "Drawing Extension"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(104, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.DrawingExtensionTextEdit
        Me.LayoutControlItem4.CustomizationFormText = "Drawing Extension"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 180)
        Me.LayoutControlItem4.Name = "LayoutControlItem5"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(382, 95)
        Me.LayoutControlItem4.Text = "Drawing Extension"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(104, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'VersionNumberTextEdit
        '
        Me.VersionNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "VersionNumber", True))
        Me.VersionNumberTextEdit.Location = New System.Drawing.Point(114, 215)
        Me.VersionNumberTextEdit.Name = "VersionNumberTextEdit"
        Me.VersionNumberTextEdit.Size = New System.Drawing.Size(263, 20)
        Me.VersionNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.VersionNumberTextEdit.TabIndex = 11
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.VersionNumberTextEdit
        Me.LayoutControlItem6.CustomizationFormText = "Version Number"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(382, 34)
        Me.LayoutControlItem6.Text = "Version Number"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(104, 13)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'xaeConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 321)
        Me.Name = "xaeConfiguration"
        Me.Text = "Configuration"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.DrawingExtensionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogOffIntervalTypeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogOffIntervalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateMethodLookupEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCentreMethodLookupEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRateMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCostCentreMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDrawingPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VersionNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents RateMethodLookupEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CostCentreMethodLookupEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForRateMethod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCostCentreMethod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TimerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LogOffIntervalTypeLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LogOffIntervalSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DrawingExtensionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DrawingTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemDrawingPath As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VersionNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
