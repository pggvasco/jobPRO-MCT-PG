<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeReason
    Inherits UniSource.ShopFloor.Scheduler.GUI.xaegReason

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
        Me.dlcReason = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ActivityLogsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LogonLogsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsLoadingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsChangedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PropertiesValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsTriggerMessageCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForActivityLogs = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForLogonLogs = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsLoading = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsChanged = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPropertiesValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsTriggerMessage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.IsQIRCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForIsQIR = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UserFieldsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForUserFields = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dlcReason, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dlcReason.SuspendLayout()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityLogsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogonLogsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsTriggerMessageCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActivityLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForLogonLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsTriggerMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsQIRCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsQIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserFieldsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUserFields, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.dlcReason)
        Me.grpGroup.Location = New System.Drawing.Point(12, 12)
        Me.grpGroup.Size = New System.Drawing.Size(260, 118)
        Me.grpGroup.Text = ""
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(116, 137)
        Me.btSave.TabIndex = 4
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(197, 137)
        Me.btCancel.TabIndex = 5
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.ReasonCode)
        '
        'dlcReason
        '
        Me.dlcReason.Controls.Add(Me.CodeTextEdit)
        Me.dlcReason.Controls.Add(Me.DescriptionTextEdit)
        Me.dlcReason.Controls.Add(Me.ActivityLogsTextEdit)
        Me.dlcReason.Controls.Add(Me.LogonLogsTextEdit)
        Me.dlcReason.Controls.Add(Me.IDTextEdit)
        Me.dlcReason.Controls.Add(Me.IsLoadingCheckEdit)
        Me.dlcReason.Controls.Add(Me.IsChangedCheckEdit)
        Me.dlcReason.Controls.Add(Me.ValidationErrorMessagesTextEdit)
        Me.dlcReason.Controls.Add(Me.PropertiesValidationErrorMessagesTextEdit)
        Me.dlcReason.Controls.Add(Me.IsTriggerMessageCheckEdit)
        Me.dlcReason.Controls.Add(Me.IsQIRCheckEdit)
        Me.dlcReason.Controls.Add(Me.UserFieldsTextEdit)
        Me.dlcReason.DataSource = Me.BindingSource
        Me.dlcReason.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dlcReason.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForActivityLogs, Me.ItemForLogonLogs, Me.ItemForID, Me.ItemForIsLoading, Me.ItemForIsChanged, Me.ItemForValidationErrorMessages, Me.ItemForPropertiesValidationErrorMessages, Me.ItemForUserFields})
        Me.dlcReason.Location = New System.Drawing.Point(2, 22)
        Me.dlcReason.Name = "dlcReason"
        Me.dlcReason.OptionsView.UseSkinIndents = False
        Me.dlcReason.Root = Me.LayoutControlGroup1
        Me.dlcReason.Size = New System.Drawing.Size(256, 94)
        Me.dlcReason.TabIndex = 0
        Me.dlcReason.Text = "DataLayoutControl1"
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(63, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(188, 20)
        Me.CodeTextEdit.StyleController = Me.dlcReason
        Me.CodeTextEdit.TabIndex = 0
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(63, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(188, 20)
        Me.DescriptionTextEdit.StyleController = Me.dlcReason
        Me.DescriptionTextEdit.TabIndex = 1
        '
        'ActivityLogsTextEdit
        '
        Me.ActivityLogsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ActivityLogs", True))
        Me.ActivityLogsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ActivityLogsTextEdit.Name = "ActivityLogsTextEdit"
        Me.ActivityLogsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ActivityLogsTextEdit.StyleController = Me.dlcReason
        Me.ActivityLogsTextEdit.TabIndex = 7
        '
        'LogonLogsTextEdit
        '
        Me.LogonLogsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "LogonLogs", True))
        Me.LogonLogsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.LogonLogsTextEdit.Name = "LogonLogsTextEdit"
        Me.LogonLogsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.LogonLogsTextEdit.StyleController = Me.dlcReason
        Me.LogonLogsTextEdit.TabIndex = 8
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IDTextEdit.StyleController = Me.dlcReason
        Me.IDTextEdit.TabIndex = 9
        '
        'IsLoadingCheckEdit
        '
        Me.IsLoadingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsLoading", True))
        Me.IsLoadingCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsLoadingCheckEdit.Name = "IsLoadingCheckEdit"
        Me.IsLoadingCheckEdit.Properties.Caption = "Is Loading"
        Me.IsLoadingCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsLoadingCheckEdit.StyleController = Me.dlcReason
        Me.IsLoadingCheckEdit.TabIndex = 10
        '
        'IsChangedCheckEdit
        '
        Me.IsChangedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsChanged", True))
        Me.IsChangedCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsChangedCheckEdit.Name = "IsChangedCheckEdit"
        Me.IsChangedCheckEdit.Properties.Caption = "Is Changed"
        Me.IsChangedCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsChangedCheckEdit.StyleController = Me.dlcReason
        Me.IsChangedCheckEdit.TabIndex = 11
        '
        'ValidationErrorMessagesTextEdit
        '
        Me.ValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidationErrorMessages", True))
        Me.ValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ValidationErrorMessagesTextEdit.Name = "ValidationErrorMessagesTextEdit"
        Me.ValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ValidationErrorMessagesTextEdit.StyleController = Me.dlcReason
        Me.ValidationErrorMessagesTextEdit.TabIndex = 12
        '
        'PropertiesValidationErrorMessagesTextEdit
        '
        Me.PropertiesValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PropertiesValidationErrorMessages", True))
        Me.PropertiesValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesValidationErrorMessagesTextEdit.Name = "PropertiesValidationErrorMessagesTextEdit"
        Me.PropertiesValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.PropertiesValidationErrorMessagesTextEdit.StyleController = Me.dlcReason
        Me.PropertiesValidationErrorMessagesTextEdit.TabIndex = 13
        '
        'IsTriggerMessageCheckEdit
        '
        Me.IsTriggerMessageCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsTriggerMessage", True))
        Me.IsTriggerMessageCheckEdit.EditValue = Nothing
        Me.IsTriggerMessageCheckEdit.Location = New System.Drawing.Point(5, 65)
        Me.IsTriggerMessageCheckEdit.Name = "IsTriggerMessageCheckEdit"
        Me.IsTriggerMessageCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsTriggerMessageCheckEdit.Properties.Caption = "Trigger Message"
        Me.IsTriggerMessageCheckEdit.Size = New System.Drawing.Size(118, 19)
        Me.IsTriggerMessageCheckEdit.StyleController = Me.dlcReason
        Me.IsTriggerMessageCheckEdit.TabIndex = 2
        '
        'ItemForActivityLogs
        '
        Me.ItemForActivityLogs.Control = Me.ActivityLogsTextEdit
        Me.ItemForActivityLogs.CustomizationFormText = "Activity Logs"
        Me.ItemForActivityLogs.Location = New System.Drawing.Point(0, 0)
        Me.ItemForActivityLogs.Name = "ItemForActivityLogs"
        Me.ItemForActivityLogs.Size = New System.Drawing.Size(0, 0)
        Me.ItemForActivityLogs.Text = "Activity Logs"
        Me.ItemForActivityLogs.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForActivityLogs.TextToControlDistance = 5
        '
        'ItemForLogonLogs
        '
        Me.ItemForLogonLogs.Control = Me.LogonLogsTextEdit
        Me.ItemForLogonLogs.CustomizationFormText = "Logon Logs"
        Me.ItemForLogonLogs.Location = New System.Drawing.Point(0, 0)
        Me.ItemForLogonLogs.Name = "ItemForLogonLogs"
        Me.ItemForLogonLogs.Size = New System.Drawing.Size(0, 0)
        Me.ItemForLogonLogs.Text = "Logon Logs"
        Me.ItemForLogonLogs.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForLogonLogs.TextToControlDistance = 5
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
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.ItemForIsTriggerMessage, Me.ItemForIsQIR})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(256, 94)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(256, 60)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(256, 30)
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
        Me.ItemForDescription.Size = New System.Drawing.Size(256, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForIsTriggerMessage
        '
        Me.ItemForIsTriggerMessage.Control = Me.IsTriggerMessageCheckEdit
        Me.ItemForIsTriggerMessage.CustomizationFormText = "Is Trigger Message"
        Me.ItemForIsTriggerMessage.Location = New System.Drawing.Point(0, 60)
        Me.ItemForIsTriggerMessage.Name = "ItemForIsTriggerMessage"
        Me.ItemForIsTriggerMessage.Size = New System.Drawing.Size(128, 34)
        Me.ItemForIsTriggerMessage.Text = "Is Trigger Message"
        Me.ItemForIsTriggerMessage.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsTriggerMessage.TextToControlDistance = 0
        Me.ItemForIsTriggerMessage.TextVisible = False
        '
        'IsQIRCheckEdit
        '
        Me.IsQIRCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsQIR", True))
        Me.IsQIRCheckEdit.Location = New System.Drawing.Point(133, 65)
        Me.IsQIRCheckEdit.Name = "IsQIRCheckEdit"
        Me.IsQIRCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsQIRCheckEdit.Properties.Caption = "Is QIR"
        Me.IsQIRCheckEdit.Size = New System.Drawing.Size(118, 19)
        Me.IsQIRCheckEdit.StyleController = Me.dlcReason
        Me.IsQIRCheckEdit.TabIndex = 3
        '
        'ItemForIsQIR
        '
        Me.ItemForIsQIR.Control = Me.IsQIRCheckEdit
        Me.ItemForIsQIR.CustomizationFormText = "Is QIR"
        Me.ItemForIsQIR.Location = New System.Drawing.Point(128, 60)
        Me.ItemForIsQIR.Name = "ItemForIsQIR"
        Me.ItemForIsQIR.Size = New System.Drawing.Size(128, 34)
        Me.ItemForIsQIR.Text = "Is QIR"
        Me.ItemForIsQIR.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsQIR.TextToControlDistance = 0
        Me.ItemForIsQIR.TextVisible = False
        '
        'UserFieldsTextEdit
        '
        Me.UserFieldsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UserFields", True))
        Me.UserFieldsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UserFieldsTextEdit.Name = "UserFieldsTextEdit"
        Me.UserFieldsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UserFieldsTextEdit.StyleController = Me.dlcReason
        Me.UserFieldsTextEdit.TabIndex = 15
        '
        'ItemForUserFields
        '
        Me.ItemForUserFields.Control = Me.UserFieldsTextEdit
        Me.ItemForUserFields.CustomizationFormText = "User Fields"
        Me.ItemForUserFields.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUserFields.Name = "ItemForUserFields"
        Me.ItemForUserFields.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUserFields.Text = "User Fields"
        Me.ItemForUserFields.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUserFields.TextToControlDistance = 5
        '
        'xaeReason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 172)
        Me.Name = "xaeReason"
        Me.Text = "Reason"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dlcReason, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dlcReason.ResumeLayout(False)
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityLogsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogonLogsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsTriggerMessageCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActivityLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForLogonLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsTriggerMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsQIRCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsQIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserFieldsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUserFields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dlcReason As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ActivityLogsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LogonLogsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsLoadingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsChangedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PropertiesValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForIsTriggerMessage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActivityLogs As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForLogonLogs As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsLoading As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsChanged As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPropertiesValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IsTriggerMessageCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsQIRCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents UserFieldsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForUserFields As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsQIR As DevExpress.XtraLayout.LayoutControlItem
End Class
