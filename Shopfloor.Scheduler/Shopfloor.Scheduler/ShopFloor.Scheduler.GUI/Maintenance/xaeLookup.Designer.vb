<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeLookup
    Inherits UniSource.ShopFloor.Scheduler.GUI.xaegLookup

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
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UssSSLookupValuesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForUssSSLookupValues = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MachineChecklistsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForMachineChecklists = New DevExpress.XtraLayout.LayoutControlItem()
        Me.OperationChecklistsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForOperationChecklists = New DevExpress.XtraLayout.LayoutControlItem()
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
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UssSSLookupValuesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUssSSLookupValues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineChecklistsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMachineChecklists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationChecklistsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOperationChecklists, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(249, 95)
        Me.grpGroup.Text = ""
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(106, 114)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(187, 114)
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Lookup)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.UssSSLookupValuesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MachineChecklistsTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OperationChecklistsTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsLoadingCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsChangedCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ValidationErrorMessagesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PropertiesValidationErrorMessagesTextEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForUssSSLookupValues, Me.ItemForMachineChecklists, Me.ItemForOperationChecklists, Me.ItemForID, Me.ItemForIsLoading, Me.ItemForIsChanged, Me.ItemForValidationErrorMessages, Me.ItemForPropertiesValidationErrorMessages})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 22)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(245, 71)
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(245, 71)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(69, 12)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(164, 20)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.CodeTextEdit.TabIndex = 4
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(225, 24)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(225, 51)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(69, 36)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(164, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl1
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 24)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(225, 27)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(53, 13)
        '
        'UssSSLookupValuesTextEdit
        '
        Me.UssSSLookupValuesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UssSSLookupValues", True))
        Me.UssSSLookupValuesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UssSSLookupValuesTextEdit.Name = "UssSSLookupValuesTextEdit"
        Me.UssSSLookupValuesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UssSSLookupValuesTextEdit.StyleController = Me.DataLayoutControl1
        Me.UssSSLookupValuesTextEdit.TabIndex = 6
        '
        'ItemForUssSSLookupValues
        '
        Me.ItemForUssSSLookupValues.Control = Me.UssSSLookupValuesTextEdit
        Me.ItemForUssSSLookupValues.CustomizationFormText = "Uss SS Lookup Values"
        Me.ItemForUssSSLookupValues.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUssSSLookupValues.Name = "ItemForUssSSLookupValues"
        Me.ItemForUssSSLookupValues.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUssSSLookupValues.Text = "Uss SS Lookup Values"
        Me.ItemForUssSSLookupValues.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUssSSLookupValues.TextToControlDistance = 5
        '
        'MachineChecklistsTextEdit
        '
        Me.MachineChecklistsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "MachineChecklists", True))
        Me.MachineChecklistsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.MachineChecklistsTextEdit.Name = "MachineChecklistsTextEdit"
        Me.MachineChecklistsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.MachineChecklistsTextEdit.StyleController = Me.DataLayoutControl1
        Me.MachineChecklistsTextEdit.TabIndex = 7
        '
        'ItemForMachineChecklists
        '
        Me.ItemForMachineChecklists.Control = Me.MachineChecklistsTextEdit
        Me.ItemForMachineChecklists.CustomizationFormText = "Machine Checklists"
        Me.ItemForMachineChecklists.Location = New System.Drawing.Point(0, 0)
        Me.ItemForMachineChecklists.Name = "ItemForMachineChecklists"
        Me.ItemForMachineChecklists.Size = New System.Drawing.Size(0, 0)
        Me.ItemForMachineChecklists.Text = "Machine Checklists"
        Me.ItemForMachineChecklists.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForMachineChecklists.TextToControlDistance = 5
        '
        'OperationChecklistsTextEdit
        '
        Me.OperationChecklistsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OperationChecklists", True))
        Me.OperationChecklistsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.OperationChecklistsTextEdit.Name = "OperationChecklistsTextEdit"
        Me.OperationChecklistsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.OperationChecklistsTextEdit.StyleController = Me.DataLayoutControl1
        Me.OperationChecklistsTextEdit.TabIndex = 8
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
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IDTextEdit.StyleController = Me.DataLayoutControl1
        Me.IDTextEdit.TabIndex = 9
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
        Me.IsLoadingCheckEdit.TabIndex = 10
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
        Me.IsChangedCheckEdit.TabIndex = 11
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
        Me.ValidationErrorMessagesTextEdit.TabIndex = 12
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
        Me.PropertiesValidationErrorMessagesTextEdit.TabIndex = 13
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
        'xaeLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 174)
        Me.Name = "xaeLookup"
        Me.Text = "Lookup"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UssSSLookupValuesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUssSSLookupValues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineChecklistsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMachineChecklists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationChecklistsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOperationChecklists, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UssSSLookupValuesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MachineChecklistsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OperationChecklistsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsLoadingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsChangedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PropertiesValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForUssSSLookupValues As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMachineChecklists As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOperationChecklists As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsLoading As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsChanged As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPropertiesValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
End Class
