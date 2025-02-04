<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeOperationChecklist
    Inherits UniSource.ShopFloor.Scheduler.GUI.xaegOperationChecklist

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
        Me.ItemForSequence = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDataTypeID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsForceValue = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UssSSOperationChecklistLogsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForUssSSOperationChecklistLogs = New DevExpress.XtraLayout.LayoutControlItem()
        Me.OperationChecklistsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForOperationChecklists = New DevExpress.XtraLayout.LayoutControlItem()
        Me.OperationChecklistLookupsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForOperationChecklistLookups = New DevExpress.XtraLayout.LayoutControlItem()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.IsLoadingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForIsLoading = New DevExpress.XtraLayout.LayoutControlItem()
        Me.IsChangedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForIsChanged = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PropertiesValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForPropertiesValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.IsForceValueTextEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.DataTypeIDTextEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.SequenceTextEdit = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSequence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDataTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsForceValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UssSSOperationChecklistLogsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUssSSOperationChecklistLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationChecklistsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOperationChecklists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationChecklistLookupsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOperationChecklistLookups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsForceValueTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTypeIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SequenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(249, 147)
        Me.grpGroup.Text = ""
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(106, 166)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(187, 166)
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.OperationChecklist)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.UssSSOperationChecklistLogsTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OperationChecklistsTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OperationChecklistLookupsTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsLoadingCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsChangedCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ValidationErrorMessagesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PropertiesValidationErrorMessagesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsForceValueTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DataTypeIDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.SequenceTextEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForUssSSOperationChecklistLogs, Me.ItemForOperationChecklists, Me.ItemForOperationChecklistLookups, Me.ItemForID, Me.ItemForIsLoading, Me.ItemForIsChanged, Me.ItemForValidationErrorMessages, Me.ItemForPropertiesValidationErrorMessages})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 22)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(245, 123)
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(245, 123)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'ItemForSequence
        '
        Me.ItemForSequence.Control = Me.SequenceTextEdit
        Me.ItemForSequence.CustomizationFormText = "Sequence"
        Me.ItemForSequence.Location = New System.Drawing.Point(0, 0)
        Me.ItemForSequence.Name = "ItemForSequence"
        Me.ItemForSequence.Size = New System.Drawing.Size(225, 24)
        Me.ItemForSequence.Text = "Sequence"
        Me.ItemForSequence.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForSequence, Me.ItemForDescription, Me.ItemForDataTypeID, Me.ItemForIsForceValue})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(225, 103)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(80, 36)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl1
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 24)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(225, 24)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(64, 13)
        '
        'ItemForDataTypeID
        '
        Me.ItemForDataTypeID.Control = Me.DataTypeIDTextEdit
        Me.ItemForDataTypeID.CustomizationFormText = "Data Type ID"
        Me.ItemForDataTypeID.Location = New System.Drawing.Point(0, 48)
        Me.ItemForDataTypeID.Name = "ItemForDataTypeID"
        Me.ItemForDataTypeID.Size = New System.Drawing.Size(225, 24)
        Me.ItemForDataTypeID.Text = "Data Type ID"
        Me.ItemForDataTypeID.TextSize = New System.Drawing.Size(64, 13)
        '
        'ItemForIsForceValue
        '
        Me.ItemForIsForceValue.Control = Me.IsForceValueTextEdit
        Me.ItemForIsForceValue.CustomizationFormText = "Is Force Value"
        Me.ItemForIsForceValue.Location = New System.Drawing.Point(0, 72)
        Me.ItemForIsForceValue.Name = "ItemForIsForceValue"
        Me.ItemForIsForceValue.Size = New System.Drawing.Size(225, 31)
        Me.ItemForIsForceValue.Text = "Is Force Value"
        Me.ItemForIsForceValue.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsForceValue.TextToControlDistance = 0
        Me.ItemForIsForceValue.TextVisible = False
        '
        'UssSSOperationChecklistLogsTextEdit
        '
        Me.UssSSOperationChecklistLogsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UssSSOperationChecklistLogs", True))
        Me.UssSSOperationChecklistLogsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UssSSOperationChecklistLogsTextEdit.Name = "UssSSOperationChecklistLogsTextEdit"
        Me.UssSSOperationChecklistLogsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UssSSOperationChecklistLogsTextEdit.StyleController = Me.DataLayoutControl1
        Me.UssSSOperationChecklistLogsTextEdit.TabIndex = 8
        '
        'ItemForUssSSOperationChecklistLogs
        '
        Me.ItemForUssSSOperationChecklistLogs.Control = Me.UssSSOperationChecklistLogsTextEdit
        Me.ItemForUssSSOperationChecklistLogs.CustomizationFormText = "Uss SS Operation Checklist Logs"
        Me.ItemForUssSSOperationChecklistLogs.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUssSSOperationChecklistLogs.Name = "ItemForUssSSOperationChecklistLogs"
        Me.ItemForUssSSOperationChecklistLogs.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUssSSOperationChecklistLogs.Text = "Uss SS Operation Checklist Logs"
        Me.ItemForUssSSOperationChecklistLogs.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUssSSOperationChecklistLogs.TextToControlDistance = 5
        '
        'OperationChecklistsTextEdit
        '
        Me.OperationChecklistsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OperationChecklists", True))
        Me.OperationChecklistsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.OperationChecklistsTextEdit.Name = "OperationChecklistsTextEdit"
        Me.OperationChecklistsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.OperationChecklistsTextEdit.StyleController = Me.DataLayoutControl1
        Me.OperationChecklistsTextEdit.TabIndex = 9
        '
        'ItemForOperationChecklists
        '
        Me.ItemForOperationChecklists.Control = Me.OperationChecklistsTextEdit
        Me.ItemForOperationChecklists.CustomizationFormText = "Operation Checklists"
        Me.ItemForOperationChecklists.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOperationChecklists.Name = "ItemForOperationChecklists"
        Me.ItemForOperationChecklists.Size = New System.Drawing.Size(0, 0)
        Me.ItemForOperationChecklists.Text = "Operation Checklists"
        Me.ItemForOperationChecklists.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForOperationChecklists.TextToControlDistance = 5
        '
        'OperationChecklistLookupsTextEdit
        '
        Me.OperationChecklistLookupsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OperationChecklistLookups", True))
        Me.OperationChecklistLookupsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.OperationChecklistLookupsTextEdit.Name = "OperationChecklistLookupsTextEdit"
        Me.OperationChecklistLookupsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.OperationChecklistLookupsTextEdit.StyleController = Me.DataLayoutControl1
        Me.OperationChecklistLookupsTextEdit.TabIndex = 10
        '
        'ItemForOperationChecklistLookups
        '
        Me.ItemForOperationChecklistLookups.Control = Me.OperationChecklistLookupsTextEdit
        Me.ItemForOperationChecklistLookups.CustomizationFormText = "Operation Checklist Lookups"
        Me.ItemForOperationChecklistLookups.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOperationChecklistLookups.Name = "ItemForOperationChecklistLookups"
        Me.ItemForOperationChecklistLookups.Size = New System.Drawing.Size(0, 0)
        Me.ItemForOperationChecklistLookups.Text = "Operation Checklist Lookups"
        Me.ItemForOperationChecklistLookups.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForOperationChecklistLookups.TextToControlDistance = 5
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IDTextEdit.StyleController = Me.DataLayoutControl1
        Me.IDTextEdit.TabIndex = 11
        '
        'ItemForID
        '
        Me.ItemForID.Control = Me.IDTextEdit
        Me.ItemForID.CustomizationFormText = "ID"
        Me.ItemForID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForID.Name = "ItemForID"
        Me.ItemForID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForID.Text = "ID"
        Me.ItemForID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForID.TextToControlDistance = 5
        '
        'IsLoadingCheckEdit
        '
        Me.IsLoadingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsLoading", True))
        Me.IsLoadingCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsLoadingCheckEdit.Name = "IsLoadingCheckEdit"
        Me.IsLoadingCheckEdit.Properties.Caption = "Is Loading"
        Me.IsLoadingCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsLoadingCheckEdit.StyleController = Me.DataLayoutControl1
        Me.IsLoadingCheckEdit.TabIndex = 12
        '
        'ItemForIsLoading
        '
        Me.ItemForIsLoading.Control = Me.IsLoadingCheckEdit
        Me.ItemForIsLoading.CustomizationFormText = "Is Loading"
        Me.ItemForIsLoading.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsLoading.Name = "ItemForIsLoading"
        Me.ItemForIsLoading.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIsLoading.Text = "Is Loading"
        Me.ItemForIsLoading.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsLoading.TextToControlDistance = 0
        Me.ItemForIsLoading.TextVisible = False
        '
        'IsChangedCheckEdit
        '
        Me.IsChangedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsChanged", True))
        Me.IsChangedCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsChangedCheckEdit.Name = "IsChangedCheckEdit"
        Me.IsChangedCheckEdit.Properties.Caption = "Is Changed"
        Me.IsChangedCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsChangedCheckEdit.StyleController = Me.DataLayoutControl1
        Me.IsChangedCheckEdit.TabIndex = 13
        '
        'ItemForIsChanged
        '
        Me.ItemForIsChanged.Control = Me.IsChangedCheckEdit
        Me.ItemForIsChanged.CustomizationFormText = "Is Changed"
        Me.ItemForIsChanged.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsChanged.Name = "ItemForIsChanged"
        Me.ItemForIsChanged.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIsChanged.Text = "Is Changed"
        Me.ItemForIsChanged.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsChanged.TextToControlDistance = 0
        Me.ItemForIsChanged.TextVisible = False
        '
        'ValidationErrorMessagesTextEdit
        '
        Me.ValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidationErrorMessages", True))
        Me.ValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ValidationErrorMessagesTextEdit.Name = "ValidationErrorMessagesTextEdit"
        Me.ValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ValidationErrorMessagesTextEdit.StyleController = Me.DataLayoutControl1
        Me.ValidationErrorMessagesTextEdit.TabIndex = 14
        '
        'ItemForValidationErrorMessages
        '
        Me.ItemForValidationErrorMessages.Control = Me.ValidationErrorMessagesTextEdit
        Me.ItemForValidationErrorMessages.CustomizationFormText = "Validation Error Messages"
        Me.ItemForValidationErrorMessages.Location = New System.Drawing.Point(0, 0)
        Me.ItemForValidationErrorMessages.Name = "ItemForValidationErrorMessages"
        Me.ItemForValidationErrorMessages.Size = New System.Drawing.Size(0, 0)
        Me.ItemForValidationErrorMessages.Text = "Validation Error Messages"
        Me.ItemForValidationErrorMessages.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForValidationErrorMessages.TextToControlDistance = 5
        '
        'PropertiesValidationErrorMessagesTextEdit
        '
        Me.PropertiesValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PropertiesValidationErrorMessages", True))
        Me.PropertiesValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesValidationErrorMessagesTextEdit.Name = "PropertiesValidationErrorMessagesTextEdit"
        Me.PropertiesValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.PropertiesValidationErrorMessagesTextEdit.StyleController = Me.DataLayoutControl1
        Me.PropertiesValidationErrorMessagesTextEdit.TabIndex = 15
        '
        'ItemForPropertiesValidationErrorMessages
        '
        Me.ItemForPropertiesValidationErrorMessages.Control = Me.PropertiesValidationErrorMessagesTextEdit
        Me.ItemForPropertiesValidationErrorMessages.CustomizationFormText = "Properties Validation Error Messages"
        Me.ItemForPropertiesValidationErrorMessages.Location = New System.Drawing.Point(0, 0)
        Me.ItemForPropertiesValidationErrorMessages.Name = "ItemForPropertiesValidationErrorMessages"
        Me.ItemForPropertiesValidationErrorMessages.Size = New System.Drawing.Size(0, 0)
        Me.ItemForPropertiesValidationErrorMessages.Text = "Properties Validation Error Messages"
        Me.ItemForPropertiesValidationErrorMessages.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForPropertiesValidationErrorMessages.TextToControlDistance = 5
        '
        'IsForceValueTextEdit
        '
        Me.IsForceValueTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsForceValue", True))
        Me.IsForceValueTextEdit.EditValue = Nothing
        Me.IsForceValueTextEdit.Location = New System.Drawing.Point(12, 84)
        Me.IsForceValueTextEdit.Name = "IsForceValueTextEdit"
        Me.IsForceValueTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsForceValueTextEdit.Properties.Caption = "Is Force Value"
        Me.IsForceValueTextEdit.Size = New System.Drawing.Size(221, 19)
        Me.IsForceValueTextEdit.StyleController = Me.DataLayoutControl1
        Me.IsForceValueTextEdit.TabIndex = 7
        '
        'DataTypeIDTextEdit
        '
        Me.DataTypeIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DataTypeID", True))
        Me.DataTypeIDTextEdit.Location = New System.Drawing.Point(80, 60)
        Me.DataTypeIDTextEdit.Name = "DataTypeIDTextEdit"
        Me.DataTypeIDTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataTypeIDTextEdit.Properties.NullText = ""
        Me.DataTypeIDTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.DataTypeIDTextEdit.StyleController = Me.DataLayoutControl1
        Me.DataTypeIDTextEdit.TabIndex = 6
        '
        'SequenceTextEdit
        '
        Me.SequenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Sequence", True))
        Me.SequenceTextEdit.Location = New System.Drawing.Point(80, 12)
        Me.SequenceTextEdit.Name = "SequenceTextEdit"
        Me.SequenceTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SequenceTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.SequenceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.SequenceTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.SequenceTextEdit.StyleController = Me.DataLayoutControl1
        Me.SequenceTextEdit.TabIndex = 4
        '
        'xaeOperationChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 226)
        Me.Name = "xaeOperationChecklist"
        Me.Text = "Operation Checklist"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSequence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDataTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsForceValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UssSSOperationChecklistLogsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUssSSOperationChecklistLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationChecklistsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOperationChecklists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationChecklistLookupsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOperationChecklistLookups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsForceValueTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTypeIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SequenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UssSSOperationChecklistLogsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OperationChecklistsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OperationChecklistLookupsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsLoadingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsChangedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PropertiesValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsForceValueTextEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataTypeIDTextEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SequenceTextEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ItemForUssSSOperationChecklistLogs As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOperationChecklists As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOperationChecklistLookups As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsLoading As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsChanged As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPropertiesValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForSequence As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDataTypeID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsForceValue As DevExpress.XtraLayout.LayoutControlItem
End Class
