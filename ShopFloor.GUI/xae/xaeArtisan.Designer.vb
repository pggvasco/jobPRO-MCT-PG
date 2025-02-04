<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeArtisan
    Inherits UniSource.ShopFloor.GUI.xaegArtisan

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
        Me.dlcArtisan = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ImagePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.CalendarIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LogonLogsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OperationArtisansTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ColourColorEdit = New DevExpress.XtraEditors.ColorEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsLoadingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsChangedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PropertiesValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsPrimaryTextEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForLogonLogs = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOperationArtisans = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsLoading = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsChanged = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPropertiesValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForImage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForColour = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCalendarID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsPrimary = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MachineLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForMachine = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dlcArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dlcArtisan.SuspendLayout()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogonLogsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationArtisansTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColourColorEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPrimaryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForLogonLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOperationArtisans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForColour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCalendarID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsPrimary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.dlcArtisan)
        Me.grpGroup.Size = New System.Drawing.Size(569, 205)
        Me.grpGroup.Text = "Artisan"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(426, 224)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(507, 224)
        '
        'dlcArtisan
        '
        Me.dlcArtisan.Controls.Add(Me.CodeTextEdit)
        Me.dlcArtisan.Controls.Add(Me.DescriptionTextEdit)
        Me.dlcArtisan.Controls.Add(Me.ImagePictureEdit)
        Me.dlcArtisan.Controls.Add(Me.CalendarIDTextEdit)
        Me.dlcArtisan.Controls.Add(Me.LogonLogsTextEdit)
        Me.dlcArtisan.Controls.Add(Me.OperationArtisansTextEdit)
        Me.dlcArtisan.Controls.Add(Me.ColourColorEdit)
        Me.dlcArtisan.Controls.Add(Me.IDTextEdit)
        Me.dlcArtisan.Controls.Add(Me.IsLoadingCheckEdit)
        Me.dlcArtisan.Controls.Add(Me.IsChangedCheckEdit)
        Me.dlcArtisan.Controls.Add(Me.ValidationErrorMessagesTextEdit)
        Me.dlcArtisan.Controls.Add(Me.PropertiesValidationErrorMessagesTextEdit)
        Me.dlcArtisan.Controls.Add(Me.IsPrimaryTextEdit)
        Me.dlcArtisan.DataSource = Me.BindingSource
        Me.dlcArtisan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dlcArtisan.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForLogonLogs, Me.ItemForOperationArtisans, Me.ItemForID, Me.ItemForIsLoading, Me.ItemForIsChanged, Me.ItemForValidationErrorMessages, Me.ItemForPropertiesValidationErrorMessages})
        Me.dlcArtisan.Location = New System.Drawing.Point(2, 21)
        Me.dlcArtisan.Name = "dlcArtisan"
        Me.dlcArtisan.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-1195, 221, 250, 350)
        Me.dlcArtisan.OptionsView.UseSkinIndents = False
        Me.dlcArtisan.Root = Me.LayoutControlGroup1
        Me.dlcArtisan.Size = New System.Drawing.Size(565, 182)
        Me.dlcArtisan.TabIndex = 0
        Me.dlcArtisan.Text = "DataLayoutControl1"
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(67, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(245, 20)
        Me.CodeTextEdit.StyleController = Me.dlcArtisan
        Me.CodeTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(67, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(245, 20)
        Me.DescriptionTextEdit.StyleController = Me.dlcArtisan
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'ImagePictureEdit
        '
        Me.ImagePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Image", True))
        Me.ImagePictureEdit.Location = New System.Drawing.Point(322, 5)
        Me.ImagePictureEdit.Name = "ImagePictureEdit"
        Me.ImagePictureEdit.Size = New System.Drawing.Size(238, 172)
        Me.ImagePictureEdit.StyleController = Me.dlcArtisan
        Me.ImagePictureEdit.TabIndex = 7
        '
        'CalendarIDTextEdit
        '
        Me.CalendarIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CalendarID", True))
        Me.CalendarIDTextEdit.Location = New System.Drawing.Point(67, 95)
        Me.CalendarIDTextEdit.Name = "CalendarIDTextEdit"
        Me.CalendarIDTextEdit.Size = New System.Drawing.Size(245, 20)
        Me.CalendarIDTextEdit.StyleController = Me.dlcArtisan
        Me.CalendarIDTextEdit.TabIndex = 9
        '
        'LogonLogsTextEdit
        '
        Me.LogonLogsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "LogonLogs", True))
        Me.LogonLogsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.LogonLogsTextEdit.Name = "LogonLogsTextEdit"
        Me.LogonLogsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.LogonLogsTextEdit.StyleController = Me.dlcArtisan
        Me.LogonLogsTextEdit.TabIndex = 17
        '
        'OperationArtisansTextEdit
        '
        Me.OperationArtisansTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OperationArtisans", True))
        Me.OperationArtisansTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.OperationArtisansTextEdit.Name = "OperationArtisansTextEdit"
        Me.OperationArtisansTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.OperationArtisansTextEdit.StyleController = Me.dlcArtisan
        Me.OperationArtisansTextEdit.TabIndex = 18
        '
        'ColourColorEdit
        '
        Me.ColourColorEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Colour", True))
        Me.ColourColorEdit.EditValue = System.Drawing.Color.Empty
        Me.ColourColorEdit.Location = New System.Drawing.Point(67, 65)
        Me.ColourColorEdit.Name = "ColourColorEdit"
        Me.ColourColorEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColourColorEdit.Properties.ShowColorDialog = False
        Me.ColourColorEdit.Properties.ShowCustomColors = False
        Me.ColourColorEdit.Properties.ShowSystemColors = False
        Me.ColourColorEdit.Size = New System.Drawing.Size(245, 20)
        Me.ColourColorEdit.StyleController = Me.dlcArtisan
        Me.ColourColorEdit.TabIndex = 6
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IDTextEdit.StyleController = Me.dlcArtisan
        Me.IDTextEdit.TabIndex = 20
        '
        'IsLoadingCheckEdit
        '
        Me.IsLoadingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsLoading", True))
        Me.IsLoadingCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsLoadingCheckEdit.Name = "IsLoadingCheckEdit"
        Me.IsLoadingCheckEdit.Properties.Caption = "Is Loading"
        Me.IsLoadingCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsLoadingCheckEdit.StyleController = Me.dlcArtisan
        Me.IsLoadingCheckEdit.TabIndex = 21
        '
        'IsChangedCheckEdit
        '
        Me.IsChangedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsChanged", True))
        Me.IsChangedCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsChangedCheckEdit.Name = "IsChangedCheckEdit"
        Me.IsChangedCheckEdit.Properties.Caption = "Is Changed"
        Me.IsChangedCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsChangedCheckEdit.StyleController = Me.dlcArtisan
        Me.IsChangedCheckEdit.TabIndex = 22
        '
        'ValidationErrorMessagesTextEdit
        '
        Me.ValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidationErrorMessages", True))
        Me.ValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ValidationErrorMessagesTextEdit.Name = "ValidationErrorMessagesTextEdit"
        Me.ValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ValidationErrorMessagesTextEdit.StyleController = Me.dlcArtisan
        Me.ValidationErrorMessagesTextEdit.TabIndex = 23
        '
        'PropertiesValidationErrorMessagesTextEdit
        '
        Me.PropertiesValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PropertiesValidationErrorMessages", True))
        Me.PropertiesValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesValidationErrorMessagesTextEdit.Name = "PropertiesValidationErrorMessagesTextEdit"
        Me.PropertiesValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.PropertiesValidationErrorMessagesTextEdit.StyleController = Me.dlcArtisan
        Me.PropertiesValidationErrorMessagesTextEdit.TabIndex = 24
        '
        'IsPrimaryTextEdit
        '
        Me.IsPrimaryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsPrimary", True))
        Me.IsPrimaryTextEdit.EditValue = Nothing
        Me.IsPrimaryTextEdit.Location = New System.Drawing.Point(5, 125)
        Me.IsPrimaryTextEdit.Name = "IsPrimaryTextEdit"
        Me.IsPrimaryTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsPrimaryTextEdit.Properties.Caption = "Is Primary"
        Me.IsPrimaryTextEdit.Size = New System.Drawing.Size(307, 19)
        Me.IsPrimaryTextEdit.StyleController = Me.dlcArtisan
        Me.IsPrimaryTextEdit.TabIndex = 13
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
        'ItemForOperationArtisans
        '
        Me.ItemForOperationArtisans.Control = Me.OperationArtisansTextEdit
        Me.ItemForOperationArtisans.CustomizationFormText = "Operation Artisans"
        Me.ItemForOperationArtisans.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOperationArtisans.Name = "ItemForOperationArtisans"
        Me.ItemForOperationArtisans.Size = New System.Drawing.Size(0, 0)
        Me.ItemForOperationArtisans.Text = "Operation Artisans"
        Me.ItemForOperationArtisans.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForOperationArtisans.TextToControlDistance = 5
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
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription, Me.ItemForImage, Me.ItemForColour, Me.ItemForCalendarID, Me.ItemForIsPrimary})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(565, 182)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(317, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(57, 13)
        Me.ItemForCode.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(317, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(57, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForImage
        '
        Me.ItemForImage.Control = Me.ImagePictureEdit
        Me.ItemForImage.CustomizationFormText = "Image"
        Me.ItemForImage.Location = New System.Drawing.Point(317, 0)
        Me.ItemForImage.Name = "ItemForImage"
        Me.ItemForImage.Size = New System.Drawing.Size(248, 182)
        Me.ItemForImage.Text = "Image"
        Me.ItemForImage.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForImage.TextToControlDistance = 0
        Me.ItemForImage.TextVisible = False
        '
        'ItemForColour
        '
        Me.ItemForColour.Control = Me.ColourColorEdit
        Me.ItemForColour.CustomizationFormText = "Colour"
        Me.ItemForColour.Location = New System.Drawing.Point(0, 60)
        Me.ItemForColour.Name = "ItemForColour"
        Me.ItemForColour.Size = New System.Drawing.Size(317, 30)
        Me.ItemForColour.Text = "Colour"
        Me.ItemForColour.TextSize = New System.Drawing.Size(57, 13)
        Me.ItemForColour.TextToControlDistance = 5
        '
        'ItemForCalendarID
        '
        Me.ItemForCalendarID.Control = Me.CalendarIDTextEdit
        Me.ItemForCalendarID.CustomizationFormText = "Calendar ID"
        Me.ItemForCalendarID.Location = New System.Drawing.Point(0, 90)
        Me.ItemForCalendarID.Name = "ItemForCalendarID"
        Me.ItemForCalendarID.Size = New System.Drawing.Size(317, 30)
        Me.ItemForCalendarID.Text = "Calendar ID"
        Me.ItemForCalendarID.TextSize = New System.Drawing.Size(57, 13)
        Me.ItemForCalendarID.TextToControlDistance = 5
        '
        'ItemForIsPrimary
        '
        Me.ItemForIsPrimary.Control = Me.IsPrimaryTextEdit
        Me.ItemForIsPrimary.CustomizationFormText = "Is Primary"
        Me.ItemForIsPrimary.Location = New System.Drawing.Point(0, 120)
        Me.ItemForIsPrimary.Name = "ItemForIsPrimary"
        Me.ItemForIsPrimary.Size = New System.Drawing.Size(317, 62)
        Me.ItemForIsPrimary.Text = "Is Primary"
        Me.ItemForIsPrimary.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsPrimary.TextToControlDistance = 0
        Me.ItemForIsPrimary.TextVisible = False
        '
        'MachineLookUpEdit
        '
        Me.MachineLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Machine", True))
        Me.MachineLookUpEdit.Location = New System.Drawing.Point(49, 5)
        Me.MachineLookUpEdit.Name = "MachineLookUpEdit"
        Me.MachineLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MachineLookUpEdit.Size = New System.Drawing.Size(511, 20)
        Me.MachineLookUpEdit.TabIndex = 25
        '
        'ItemForMachine
        '
        Me.ItemForMachine.Control = Me.MachineLookUpEdit
        Me.ItemForMachine.CustomizationFormText = "Machine"
        Me.ItemForMachine.Location = New System.Drawing.Point(0, 0)
        Me.ItemForMachine.Name = "ItemForMachine"
        Me.ItemForMachine.Size = New System.Drawing.Size(565, 209)
        Me.ItemForMachine.Text = "Machine"
        Me.ItemForMachine.TextSize = New System.Drawing.Size(81, 13)
        Me.ItemForMachine.TextToControlDistance = 5
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForMachine})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(565, 209)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'xaeArtisan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 259)
        Me.Name = "xaeArtisan"
        Me.Text = "Artisan"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dlcArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dlcArtisan.ResumeLayout(False)
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogonLogsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationArtisansTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColourColorEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPrimaryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForLogonLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOperationArtisans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForColour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCalendarID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsPrimary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dlcArtisan As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImagePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ColourColorEdit As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForColour As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForImage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IsPrimaryTextEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForIsPrimary As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CalendarIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LogonLogsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OperationArtisansTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsLoadingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsChangedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PropertiesValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForLogonLogs As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOperationArtisans As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsLoading As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsChanged As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPropertiesValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCalendarID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents MachineLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ItemForMachine As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
End Class
