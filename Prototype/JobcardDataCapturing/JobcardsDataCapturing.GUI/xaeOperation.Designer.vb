<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeOperation
    Inherits JobcardsDataCapturing.GUI.xaegOperation

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
        Me.RateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForRate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.IsBuyOutTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForIsBuyOut = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UssActivitiesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForUssActivities = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UssOperationArtisansTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForUssOperationArtisans = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UssOperationMachinesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForUssOperationMachines = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DepartmentTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForDepartment = New DevExpress.XtraLayout.LayoutControlItem()
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
        CType(Me.RateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsBuyOutTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsBuyOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UssActivitiesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUssActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UssOperationArtisansTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUssOperationArtisans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UssOperationMachinesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUssOperationMachines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grpGroup.Size = New System.Drawing.Size(321, 211)
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(178, 230)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(259, 230)
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(JobCardDataCapturing.API.Operation)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsBuyOutTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.UssActivitiesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.UssOperationArtisansTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.UssOperationMachinesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DepartmentTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsLoadingCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsChangedCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ValidationErrorMessagesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PropertiesValidationErrorMessagesTextEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForUssActivities, Me.ItemForUssOperationArtisans, Me.ItemForUssOperationMachines, Me.ItemForIsLoading, Me.ItemForIsChanged, Me.ItemForValidationErrorMessages, Me.ItemForPropertiesValidationErrorMessages})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 22)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(317, 187)
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(317, 187)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(73, 12)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(232, 20)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.CodeTextEdit.TabIndex = 4
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(297, 24)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(57, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription, Me.ItemForRate, Me.ItemForIsBuyOut, Me.ItemForDepartment, Me.ItemForID})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(297, 167)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(73, 36)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(232, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl1
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 24)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(297, 24)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(57, 13)
        '
        'RateTextEdit
        '
        Me.RateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Rate", True))
        Me.RateTextEdit.Location = New System.Drawing.Point(73, 60)
        Me.RateTextEdit.Name = "RateTextEdit"
        Me.RateTextEdit.Size = New System.Drawing.Size(232, 20)
        Me.RateTextEdit.StyleController = Me.DataLayoutControl1
        Me.RateTextEdit.TabIndex = 6
        '
        'ItemForRate
        '
        Me.ItemForRate.Control = Me.RateTextEdit
        Me.ItemForRate.CustomizationFormText = "Rate"
        Me.ItemForRate.Location = New System.Drawing.Point(0, 48)
        Me.ItemForRate.Name = "ItemForRate"
        Me.ItemForRate.Size = New System.Drawing.Size(297, 24)
        Me.ItemForRate.Text = "Rate"
        Me.ItemForRate.TextSize = New System.Drawing.Size(57, 13)
        '
        'IsBuyOutTextEdit
        '
        Me.IsBuyOutTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsBuyOut", True))
        Me.IsBuyOutTextEdit.Location = New System.Drawing.Point(73, 84)
        Me.IsBuyOutTextEdit.Name = "IsBuyOutTextEdit"
        Me.IsBuyOutTextEdit.Size = New System.Drawing.Size(232, 20)
        Me.IsBuyOutTextEdit.StyleController = Me.DataLayoutControl1
        Me.IsBuyOutTextEdit.TabIndex = 7
        '
        'ItemForIsBuyOut
        '
        Me.ItemForIsBuyOut.Control = Me.IsBuyOutTextEdit
        Me.ItemForIsBuyOut.CustomizationFormText = "Is Buy Out"
        Me.ItemForIsBuyOut.Location = New System.Drawing.Point(0, 72)
        Me.ItemForIsBuyOut.Name = "ItemForIsBuyOut"
        Me.ItemForIsBuyOut.Size = New System.Drawing.Size(297, 24)
        Me.ItemForIsBuyOut.Text = "Is Buy Out"
        Me.ItemForIsBuyOut.TextSize = New System.Drawing.Size(57, 13)
        '
        'UssActivitiesTextEdit
        '
        Me.UssActivitiesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UssActivities", True))
        Me.UssActivitiesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UssActivitiesTextEdit.Name = "UssActivitiesTextEdit"
        Me.UssActivitiesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UssActivitiesTextEdit.StyleController = Me.DataLayoutControl1
        Me.UssActivitiesTextEdit.TabIndex = 8
        '
        'ItemForUssActivities
        '
        Me.ItemForUssActivities.Control = Me.UssActivitiesTextEdit
        Me.ItemForUssActivities.CustomizationFormText = "Uss Activities"
        Me.ItemForUssActivities.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUssActivities.Name = "ItemForUssActivities"
        Me.ItemForUssActivities.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUssActivities.Text = "Uss Activities"
        Me.ItemForUssActivities.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUssActivities.TextToControlDistance = 5
        '
        'UssOperationArtisansTextEdit
        '
        Me.UssOperationArtisansTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UssOperationArtisans", True))
        Me.UssOperationArtisansTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UssOperationArtisansTextEdit.Name = "UssOperationArtisansTextEdit"
        Me.UssOperationArtisansTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UssOperationArtisansTextEdit.StyleController = Me.DataLayoutControl1
        Me.UssOperationArtisansTextEdit.TabIndex = 9
        '
        'ItemForUssOperationArtisans
        '
        Me.ItemForUssOperationArtisans.Control = Me.UssOperationArtisansTextEdit
        Me.ItemForUssOperationArtisans.CustomizationFormText = "Uss Operation Artisans"
        Me.ItemForUssOperationArtisans.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUssOperationArtisans.Name = "ItemForUssOperationArtisans"
        Me.ItemForUssOperationArtisans.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUssOperationArtisans.Text = "Uss Operation Artisans"
        Me.ItemForUssOperationArtisans.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUssOperationArtisans.TextToControlDistance = 5
        '
        'UssOperationMachinesTextEdit
        '
        Me.UssOperationMachinesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UssOperationMachines", True))
        Me.UssOperationMachinesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UssOperationMachinesTextEdit.Name = "UssOperationMachinesTextEdit"
        Me.UssOperationMachinesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UssOperationMachinesTextEdit.StyleController = Me.DataLayoutControl1
        Me.UssOperationMachinesTextEdit.TabIndex = 10
        '
        'ItemForUssOperationMachines
        '
        Me.ItemForUssOperationMachines.Control = Me.UssOperationMachinesTextEdit
        Me.ItemForUssOperationMachines.CustomizationFormText = "Uss Operation Machines"
        Me.ItemForUssOperationMachines.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUssOperationMachines.Name = "ItemForUssOperationMachines"
        Me.ItemForUssOperationMachines.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUssOperationMachines.Text = "Uss Operation Machines"
        Me.ItemForUssOperationMachines.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUssOperationMachines.TextToControlDistance = 5
        '
        'DepartmentTextEdit
        '
        Me.DepartmentTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Department", True))
        Me.DepartmentTextEdit.Location = New System.Drawing.Point(73, 108)
        Me.DepartmentTextEdit.Name = "DepartmentTextEdit"
        Me.DepartmentTextEdit.Size = New System.Drawing.Size(232, 20)
        Me.DepartmentTextEdit.StyleController = Me.DataLayoutControl1
        Me.DepartmentTextEdit.TabIndex = 11
        '
        'ItemForDepartment
        '
        Me.ItemForDepartment.Control = Me.DepartmentTextEdit
        Me.ItemForDepartment.CustomizationFormText = "Department"
        Me.ItemForDepartment.Location = New System.Drawing.Point(0, 96)
        Me.ItemForDepartment.Name = "ItemForDepartment"
        Me.ItemForDepartment.Size = New System.Drawing.Size(297, 24)
        Me.ItemForDepartment.Text = "Department"
        Me.ItemForDepartment.TextSize = New System.Drawing.Size(57, 13)
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(73, 132)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(232, 20)
        Me.IDTextEdit.StyleController = Me.DataLayoutControl1
        Me.IDTextEdit.TabIndex = 12
        '
        'ItemForID
        '
        Me.ItemForID.Control = Me.IDTextEdit
        Me.ItemForID.CustomizationFormText = "ID"
        Me.ItemForID.Location = New System.Drawing.Point(0, 120)
        Me.ItemForID.Name = "ItemForID"
        Me.ItemForID.Size = New System.Drawing.Size(297, 47)
        Me.ItemForID.Text = "ID"
        Me.ItemForID.TextSize = New System.Drawing.Size(57, 13)
        '
        'IsLoadingCheckEdit
        '
        Me.IsLoadingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsLoading", True))
        Me.IsLoadingCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsLoadingCheckEdit.Name = "IsLoadingCheckEdit"
        Me.IsLoadingCheckEdit.Properties.Caption = "Is Loading"
        Me.IsLoadingCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsLoadingCheckEdit.StyleController = Me.DataLayoutControl1
        Me.IsLoadingCheckEdit.TabIndex = 13
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
        Me.IsChangedCheckEdit.TabIndex = 14
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
        Me.ValidationErrorMessagesTextEdit.TabIndex = 15
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
        Me.PropertiesValidationErrorMessagesTextEdit.TabIndex = 16
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
        'xaeOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 265)
        Me.Name = "xaeOperation"
        Me.Text = "xaeOperation"
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
        CType(Me.RateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsBuyOutTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsBuyOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UssActivitiesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUssActivities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UssOperationArtisansTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUssOperationArtisans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UssOperationMachinesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUssOperationMachines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDepartment, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsBuyOutTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UssActivitiesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UssOperationArtisansTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UssOperationMachinesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DepartmentTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsLoadingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsChangedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PropertiesValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForUssActivities As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUssOperationArtisans As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUssOperationMachines As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsLoading As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsChanged As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPropertiesValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsBuyOut As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDepartment As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
End Class
