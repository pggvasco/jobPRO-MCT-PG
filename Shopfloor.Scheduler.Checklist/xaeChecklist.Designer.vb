<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeChecklist
    Inherits UniSource.ShopFloor.Scheduler.Checklist.GUI.xaegChecklist

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
        Me.DataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.gcChecklistOptions = New DevExpress.XtraGrid.GridControl()
        Me.ChecklistOptionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvChecklistOptions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChecklistOption = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpChecklistOption = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ChecklistOptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UssChecklistChecklistTasksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsLoadingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsChangedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PropertiesValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CheckListLogsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ChecklistTypeLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ChecklistTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemForUssChecklistChecklistTasks = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsLoading = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsChanged = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPropertiesValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCheckListLogs = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForChecklistType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForChecklistOptions = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl.SuspendLayout()
        CType(Me.gcChecklistOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistOptionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChecklistOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpChecklistOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistOptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UssChecklistChecklistTasksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckListLogsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistTypeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUssChecklistChecklistTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCheckListLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForChecklistType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForChecklistOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl)
        Me.grpGroup.Size = New System.Drawing.Size(752, 418)
        Me.grpGroup.Text = "Checklist"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(609, 437)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(690, 437)
        '
        'DataLayoutControl
        '
        Me.DataLayoutControl.Controls.Add(Me.gcChecklistOptions)
        Me.DataLayoutControl.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.UssChecklistChecklistTasksTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.IDTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.IsLoadingCheckEdit)
        Me.DataLayoutControl.Controls.Add(Me.IsChangedCheckEdit)
        Me.DataLayoutControl.Controls.Add(Me.ValidationErrorMessagesTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.PropertiesValidationErrorMessagesTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.CheckListLogsTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.ChecklistTypeLookUpEdit)
        Me.DataLayoutControl.DataSource = Me.BindingSource
        Me.DataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForUssChecklistChecklistTasks, Me.ItemForID, Me.ItemForIsLoading, Me.ItemForIsChanged, Me.ItemForValidationErrorMessages, Me.ItemForPropertiesValidationErrorMessages, Me.ItemForCheckListLogs})
        Me.DataLayoutControl.Location = New System.Drawing.Point(2, 21)
        Me.DataLayoutControl.Name = "DataLayoutControl"
        Me.DataLayoutControl.OptionsView.ItemBorderColor = System.Drawing.Color.Empty
        Me.DataLayoutControl.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl.Size = New System.Drawing.Size(748, 395)
        Me.DataLayoutControl.TabIndex = 0
        Me.DataLayoutControl.Text = "DataLayoutControl"
        '
        'gcChecklistOptions
        '
        Me.gcChecklistOptions.DataSource = Me.ChecklistOptionsBindingSource
        Me.gcChecklistOptions.Location = New System.Drawing.Point(5, 113)
        Me.gcChecklistOptions.MainView = Me.gvChecklistOptions
        Me.gcChecklistOptions.Name = "gcChecklistOptions"
        Me.gcChecklistOptions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rilkpChecklistOption})
        Me.gcChecklistOptions.Size = New System.Drawing.Size(738, 277)
        Me.gcChecklistOptions.TabIndex = 16
        Me.gcChecklistOptions.UseEmbeddedNavigator = True
        Me.gcChecklistOptions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChecklistOptions})
        '
        'ChecklistOptionsBindingSource
        '
        Me.ChecklistOptionsBindingSource.DataMember = "ChecklistOption"
        Me.ChecklistOptionsBindingSource.DataSource = Me.BindingSource
        '
        'gvChecklistOptions
        '
        Me.gvChecklistOptions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSequence, Me.colChecklistOption})
        Me.gvChecklistOptions.GridControl = Me.gcChecklistOptions
        Me.gvChecklistOptions.Name = "gvChecklistOptions"
        Me.gvChecklistOptions.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvChecklistOptions.OptionsView.ShowGroupPanel = False
        '
        'colSequence
        '
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        Me.colSequence.Visible = True
        Me.colSequence.VisibleIndex = 0
        Me.colSequence.Width = 114
        '
        'colChecklistOption
        '
        Me.colChecklistOption.ColumnEdit = Me.rilkpChecklistOption
        Me.colChecklistOption.FieldName = "ChecklistOption"
        Me.colChecklistOption.Name = "colChecklistOption"
        Me.colChecklistOption.Visible = True
        Me.colChecklistOption.VisibleIndex = 1
        Me.colChecklistOption.Width = 505
        '
        'rilkpChecklistOption
        '
        Me.rilkpChecklistOption.AutoHeight = False
        Me.rilkpChecklistOption.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilkpChecklistOption.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpChecklistOption.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsForceValue", "Force Value", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataTypeID", "Data Type", 74, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rilkpChecklistOption.DataSource = Me.ChecklistOptionBindingSource
        Me.rilkpChecklistOption.DisplayMember = "Description"
        Me.rilkpChecklistOption.Name = "rilkpChecklistOption"
        '
        'ChecklistOptionBindingSource
        '
        Me.ChecklistOptionBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.Checklist.API.ChecklistOption)
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(79, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(664, 20)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl
        Me.CodeTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(79, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(664, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'UssChecklistChecklistTasksTextEdit
        '
        Me.UssChecklistChecklistTasksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UssChecklistChecklistTasks", True))
        Me.UssChecklistChecklistTasksTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UssChecklistChecklistTasksTextEdit.Name = "UssChecklistChecklistTasksTextEdit"
        Me.UssChecklistChecklistTasksTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UssChecklistChecklistTasksTextEdit.StyleController = Me.DataLayoutControl
        Me.UssChecklistChecklistTasksTextEdit.TabIndex = 6
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IDTextEdit.StyleController = Me.DataLayoutControl
        Me.IDTextEdit.TabIndex = 8
        '
        'IsLoadingCheckEdit
        '
        Me.IsLoadingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsLoading", True))
        Me.IsLoadingCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsLoadingCheckEdit.Name = "IsLoadingCheckEdit"
        Me.IsLoadingCheckEdit.Properties.Caption = "Is Loading"
        Me.IsLoadingCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsLoadingCheckEdit.StyleController = Me.DataLayoutControl
        Me.IsLoadingCheckEdit.TabIndex = 9
        '
        'IsChangedCheckEdit
        '
        Me.IsChangedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsChanged", True))
        Me.IsChangedCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsChangedCheckEdit.Name = "IsChangedCheckEdit"
        Me.IsChangedCheckEdit.Properties.Caption = "Is Changed"
        Me.IsChangedCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsChangedCheckEdit.StyleController = Me.DataLayoutControl
        Me.IsChangedCheckEdit.TabIndex = 10
        '
        'ValidationErrorMessagesTextEdit
        '
        Me.ValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidationErrorMessages", True))
        Me.ValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ValidationErrorMessagesTextEdit.Name = "ValidationErrorMessagesTextEdit"
        Me.ValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ValidationErrorMessagesTextEdit.StyleController = Me.DataLayoutControl
        Me.ValidationErrorMessagesTextEdit.TabIndex = 11
        '
        'PropertiesValidationErrorMessagesTextEdit
        '
        Me.PropertiesValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PropertiesValidationErrorMessages", True))
        Me.PropertiesValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesValidationErrorMessagesTextEdit.Name = "PropertiesValidationErrorMessagesTextEdit"
        Me.PropertiesValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.PropertiesValidationErrorMessagesTextEdit.StyleController = Me.DataLayoutControl
        Me.PropertiesValidationErrorMessagesTextEdit.TabIndex = 12
        '
        'CheckListLogsTextEdit
        '
        Me.CheckListLogsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CheckListLogs", True))
        Me.CheckListLogsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.CheckListLogsTextEdit.Name = "CheckListLogsTextEdit"
        Me.CheckListLogsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.CheckListLogsTextEdit.StyleController = Me.DataLayoutControl
        Me.CheckListLogsTextEdit.TabIndex = 13
        '
        'ChecklistTypeLookUpEdit
        '
        Me.ChecklistTypeLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ChecklistType", True))
        Me.ChecklistTypeLookUpEdit.Location = New System.Drawing.Point(79, 65)
        Me.ChecklistTypeLookUpEdit.Name = "ChecklistTypeLookUpEdit"
        Me.ChecklistTypeLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChecklistTypeLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ChecklistTypeLookUpEdit.Properties.DataSource = Me.ChecklistTypeBindingSource
        Me.ChecklistTypeLookUpEdit.Properties.DisplayMember = "Description"
        Me.ChecklistTypeLookUpEdit.Properties.NullText = ""
        Me.ChecklistTypeLookUpEdit.Size = New System.Drawing.Size(664, 20)
        Me.ChecklistTypeLookUpEdit.StyleController = Me.DataLayoutControl
        Me.ChecklistTypeLookUpEdit.TabIndex = 15
        '
        'ChecklistTypeBindingSource
        '
        Me.ChecklistTypeBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.Checklist.API.ChecklistType)
        '
        'ItemForUssChecklistChecklistTasks
        '
        Me.ItemForUssChecklistChecklistTasks.Control = Me.UssChecklistChecklistTasksTextEdit
        Me.ItemForUssChecklistChecklistTasks.CustomizationFormText = "Uss Checklist Checklist Tasks"
        Me.ItemForUssChecklistChecklistTasks.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUssChecklistChecklistTasks.Name = "ItemForUssChecklistChecklistTasks"
        Me.ItemForUssChecklistChecklistTasks.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUssChecklistChecklistTasks.Text = "Uss Checklist Checklist Tasks"
        Me.ItemForUssChecklistChecklistTasks.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUssChecklistChecklistTasks.TextToControlDistance = 5
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
        'ItemForCheckListLogs
        '
        Me.ItemForCheckListLogs.Control = Me.CheckListLogsTextEdit
        Me.ItemForCheckListLogs.CustomizationFormText = "Check List Logs"
        Me.ItemForCheckListLogs.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCheckListLogs.Name = "ItemForCheckListLogs"
        Me.ItemForCheckListLogs.Size = New System.Drawing.Size(0, 0)
        Me.ItemForCheckListLogs.Text = "Check List Logs"
        Me.ItemForCheckListLogs.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCheckListLogs.TextToControlDistance = 5
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(748, 395)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription, Me.ItemForChecklistType, Me.ItemForChecklistOptions})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(748, 395)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(748, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(69, 13)
        Me.ItemForCode.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(748, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(69, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForChecklistType
        '
        Me.ItemForChecklistType.Control = Me.ChecklistTypeLookUpEdit
        Me.ItemForChecklistType.CustomizationFormText = "Checklist Type"
        Me.ItemForChecklistType.Location = New System.Drawing.Point(0, 60)
        Me.ItemForChecklistType.Name = "ItemForChecklistType"
        Me.ItemForChecklistType.Size = New System.Drawing.Size(748, 30)
        Me.ItemForChecklistType.Text = "Checklist Type"
        Me.ItemForChecklistType.TextSize = New System.Drawing.Size(69, 13)
        Me.ItemForChecklistType.TextToControlDistance = 5
        '
        'ItemForChecklistOptions
        '
        Me.ItemForChecklistOptions.Control = Me.gcChecklistOptions
        Me.ItemForChecklistOptions.CustomizationFormText = "Options"
        Me.ItemForChecklistOptions.Location = New System.Drawing.Point(0, 90)
        Me.ItemForChecklistOptions.Name = "ItemForChecklistOptions"
        Me.ItemForChecklistOptions.Size = New System.Drawing.Size(748, 305)
        Me.ItemForChecklistOptions.Text = "Options"
        Me.ItemForChecklistOptions.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForChecklistOptions.TextSize = New System.Drawing.Size(69, 13)
        Me.ItemForChecklistOptions.TextToControlDistance = 5
        '
        'xaeChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 472)
        Me.Name = "xaeChecklist"
        Me.Text = "Checklist"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl.ResumeLayout(False)
        CType(Me.gcChecklistOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistOptionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChecklistOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpChecklistOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistOptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UssChecklistChecklistTasksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckListLogsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistTypeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUssChecklistChecklistTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCheckListLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForChecklistType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForChecklistOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UssChecklistChecklistTasksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsLoadingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsChangedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PropertiesValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForUssChecklistChecklistTasks As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsLoading As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsChanged As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPropertiesValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckListLogsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChecklistTypeLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ItemForCheckListLogs As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForChecklistType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ChecklistTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gcChecklistOptions As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvChecklistOptions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemForChecklistOptions As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ChecklistOptionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colSequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChecklistOption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilkpChecklistOption As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ChecklistOptionBindingSource As System.Windows.Forms.BindingSource

End Class
