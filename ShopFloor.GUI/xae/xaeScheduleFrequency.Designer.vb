<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeScheduleFrequency
    Inherits UniSource.ShopFloor.GUI.xaegScheduleFrequency

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Me.TemplateIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.JobTemplateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequestTypeIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.RequestTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScheduleIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.TypeIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.RepeatAfterLookUpEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTemplateID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForScheduleID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRepeatAfter = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRequestTypeID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTypeID = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TemplateIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTemplateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestTypeIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepeatAfterLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTemplateID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForScheduleID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRepeatAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRequestTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(728, 190)
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(542, 232)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(635, 232)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TemplateIDLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RequestTypeIDLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ScheduleIDLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TypeIDLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RepeatAfterLookUpEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 24)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(724, 164)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(93, 12)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(266, 22)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.CodeTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(444, 12)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(268, 22)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl1
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'TemplateIDLookUpEdit
        '
        Me.TemplateIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "TemplateID", True))
        Me.TemplateIDLookUpEdit.Location = New System.Drawing.Point(93, 38)
        Me.TemplateIDLookUpEdit.Name = "TemplateIDLookUpEdit"
        Me.TemplateIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TemplateIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TemplateNumber", "Template Number", 113, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description1", "Description1", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description2", "Description2", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Make", "Make", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model", "Model", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.TemplateIDLookUpEdit.Properties.DataSource = Me.JobTemplateBindingSource
        Me.TemplateIDLookUpEdit.Properties.DisplayMember = "TemplateNumber"
        Me.TemplateIDLookUpEdit.Properties.NullText = "(Select Template Number...)"
        Me.TemplateIDLookUpEdit.Properties.ValueMember = "ID"
        Me.TemplateIDLookUpEdit.Size = New System.Drawing.Size(266, 22)
        Me.TemplateIDLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.TemplateIDLookUpEdit.TabIndex = 6
        '
        'JobTemplateBindingSource
        '
        Me.JobTemplateBindingSource.DataSource = GetType(UniSource.ShopFloor.API.JobTemplate)
        '
        'RequestTypeIDLookUpEdit
        '
        Me.RequestTypeIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "RequestTypeID", True))
        Me.RequestTypeIDLookUpEdit.Location = New System.Drawing.Point(444, 38)
        Me.RequestTypeIDLookUpEdit.Name = "RequestTypeIDLookUpEdit"
        Me.RequestTypeIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequestTypeIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Active", "Active", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RequestTypeIDLookUpEdit.Properties.DataSource = Me.RequestTypeBindingSource
        Me.RequestTypeIDLookUpEdit.Properties.DisplayMember = "Code"
        Me.RequestTypeIDLookUpEdit.Properties.NullText = "(Select Request Type...)"
        Me.RequestTypeIDLookUpEdit.Properties.ValueMember = "ID"
        Me.RequestTypeIDLookUpEdit.Size = New System.Drawing.Size(268, 22)
        Me.RequestTypeIDLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.RequestTypeIDLookUpEdit.TabIndex = 7
        '
        'RequestTypeBindingSource
        '
        Me.RequestTypeBindingSource.DataSource = GetType(UniSource.ShopFloor.API.RequestType)
        '
        'ScheduleIDLookUpEdit
        '
        Me.ScheduleIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ScheduleTypes", True))
        Me.ScheduleIDLookUpEdit.Location = New System.Drawing.Point(93, 64)
        Me.ScheduleIDLookUpEdit.Name = "ScheduleIDLookUpEdit"
        Me.ScheduleIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ScheduleIDLookUpEdit.Properties.NullText = ""
        Me.ScheduleIDLookUpEdit.Size = New System.Drawing.Size(619, 22)
        Me.ScheduleIDLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.ScheduleIDLookUpEdit.TabIndex = 8
        '
        'TypeIDLookUpEdit
        '
        Me.TypeIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ScheduleFrequencyType", True))
        Me.TypeIDLookUpEdit.Location = New System.Drawing.Point(444, 90)
        Me.TypeIDLookUpEdit.Name = "TypeIDLookUpEdit"
        Me.TypeIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TypeIDLookUpEdit.Properties.NullText = ""
        Me.TypeIDLookUpEdit.Size = New System.Drawing.Size(268, 22)
        Me.TypeIDLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.TypeIDLookUpEdit.TabIndex = 10
        '
        'RepeatAfterLookUpEdit
        '
        Me.RepeatAfterLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "RepeatAfter", True))
        Me.RepeatAfterLookUpEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RepeatAfterLookUpEdit.Location = New System.Drawing.Point(93, 90)
        Me.RepeatAfterLookUpEdit.Name = "RepeatAfterLookUpEdit"
        Me.RepeatAfterLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepeatAfterLookUpEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepeatAfterLookUpEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RepeatAfterLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.RepeatAfterLookUpEdit.Size = New System.Drawing.Size(266, 22)
        Me.RepeatAfterLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.RepeatAfterLookUpEdit.TabIndex = 9
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(724, 164)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForTemplateID, Me.ItemForScheduleID, Me.ItemForRepeatAfter, Me.ItemForDescription, Me.ItemForRequestTypeID, Me.ItemForTypeID})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(704, 144)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(351, 26)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(78, 16)
        '
        'ItemForTemplateID
        '
        Me.ItemForTemplateID.Control = Me.TemplateIDLookUpEdit
        Me.ItemForTemplateID.CustomizationFormText = "TemplateID"
        Me.ItemForTemplateID.Location = New System.Drawing.Point(0, 26)
        Me.ItemForTemplateID.Name = "ItemForTemplateID"
        Me.ItemForTemplateID.Size = New System.Drawing.Size(351, 26)
        Me.ItemForTemplateID.Text = "Template"
        Me.ItemForTemplateID.TextSize = New System.Drawing.Size(78, 16)
        '
        'ItemForScheduleID
        '
        Me.ItemForScheduleID.Control = Me.ScheduleIDLookUpEdit
        Me.ItemForScheduleID.CustomizationFormText = "Schedule ID"
        Me.ItemForScheduleID.Location = New System.Drawing.Point(0, 52)
        Me.ItemForScheduleID.Name = "ItemForScheduleID"
        Me.ItemForScheduleID.Size = New System.Drawing.Size(704, 26)
        Me.ItemForScheduleID.Text = "Schedule"
        Me.ItemForScheduleID.TextSize = New System.Drawing.Size(78, 16)
        '
        'ItemForRepeatAfter
        '
        Me.ItemForRepeatAfter.Control = Me.RepeatAfterLookUpEdit
        Me.ItemForRepeatAfter.CustomizationFormText = "Repeat After"
        Me.ItemForRepeatAfter.Location = New System.Drawing.Point(0, 78)
        Me.ItemForRepeatAfter.Name = "ItemForRepeatAfter"
        Me.ItemForRepeatAfter.Size = New System.Drawing.Size(351, 66)
        Me.ItemForRepeatAfter.Text = "Repeat After"
        Me.ItemForRepeatAfter.TextSize = New System.Drawing.Size(78, 16)
        Me.ItemForRepeatAfter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(351, 0)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(353, 26)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(78, 16)
        '
        'ItemForRequestTypeID
        '
        Me.ItemForRequestTypeID.Control = Me.RequestTypeIDLookUpEdit
        Me.ItemForRequestTypeID.CustomizationFormText = "Request Type ID"
        Me.ItemForRequestTypeID.Location = New System.Drawing.Point(351, 26)
        Me.ItemForRequestTypeID.Name = "ItemForRequestTypeID"
        Me.ItemForRequestTypeID.Size = New System.Drawing.Size(353, 26)
        Me.ItemForRequestTypeID.Text = "Request Type"
        Me.ItemForRequestTypeID.TextSize = New System.Drawing.Size(78, 16)
        '
        'ItemForTypeID
        '
        Me.ItemForTypeID.Control = Me.TypeIDLookUpEdit
        Me.ItemForTypeID.CustomizationFormText = "Type ID"
        Me.ItemForTypeID.Location = New System.Drawing.Point(351, 78)
        Me.ItemForTypeID.Name = "ItemForTypeID"
        Me.ItemForTypeID.Size = New System.Drawing.Size(353, 66)
        Me.ItemForTypeID.Text = "Type"
        Me.ItemForTypeID.TextSize = New System.Drawing.Size(78, 16)
        Me.ItemForTypeID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'xaeScheduleFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 273)
        Me.Name = "xaeScheduleFrequency"
        Me.Text = "Schedule Frequency"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TemplateIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTemplateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestTypeIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepeatAfterLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTemplateID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForScheduleID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRepeatAfter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRequestTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TemplateIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RequestTypeIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ScheduleIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TypeIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTemplateID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRequestTypeID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForScheduleID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRepeatAfter As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTypeID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobTemplateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequestTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepeatAfterLookUpEdit As DevExpress.XtraEditors.SpinEdit
End Class
