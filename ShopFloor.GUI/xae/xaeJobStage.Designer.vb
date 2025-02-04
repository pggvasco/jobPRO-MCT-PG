Imports UniSource.ShopFloor.Scheduler

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobStage
    Inherits UniSource.ShopFloor.GUI.xaegJobStage

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
        Me.DataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.ValidateActiveJobsAssetCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.IsCustomerOnHoldCheckedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsZeroDiscountCheckedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FieldPromptsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FieldPromptsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FieldPromptsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFieldName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpJobProperties = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PropertyInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colIsRequired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDefaultValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromptBefore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromptAfter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcJobStageTriggers = New DevExpress.XtraGrid.GridControl()
        Me.TriggersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvJobStageTriggers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTriggerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpTrigger = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcChecklists = New DevExpress.XtraGrid.GridControl()
        Me.ChecklistsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvChecklists = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChecklist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpChecklist = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ChecklistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SequenceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.gcReports = New DevExpress.XtraGrid.GridControl()
        Me.ReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvReports = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReportID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpReport = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colIsAutomatic = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.richkIsAutomatic = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colIsReportOnEditScreen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.richkIsReportOnEditScreen = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colIsReportOnListScreen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.richkIsReportOnListScreen = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFunctions = New DevExpress.XtraGrid.GridControl()
        Me.FunctionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvFunctions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJobFunctionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpJobFunction = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsProcurementCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsActiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsRequiredCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.JobTypeStagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobStageReportsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobStageFunctionsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobStageChecklistsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobStageTriggersTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobStageFieldPromptsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobMemoesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ErrorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsInvoicingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForError = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobMemoes = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobTypeStages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobStageChecklists = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobStageFieldPrompts = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobStageTriggers = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobStageReports = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobStageFunctions = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.FunctionsLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForFunctions = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ReportsLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForReports = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ChecklistsLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForChecklists = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TriggersLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.JobStageTriggersLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.FieldPromptsLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.FieldPromptsLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsRequired = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsActive = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSequence = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsInvoicing = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsZeroDiscountChecked = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsCustomerOnHoldChecked = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl.SuspendLayout()
        CType(Me.ValidateActiveJobsAssetCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsCustomerOnHoldCheckedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsZeroDiscountCheckedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldPromptsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldPromptsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldPromptsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpJobProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJobStageTriggers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TriggersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobStageTriggers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpTrigger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcChecklists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChecklists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpChecklist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SequenceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.richkIsAutomatic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.richkIsReportOnEditScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.richkIsReportOnListScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcFunctions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FunctionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFunctions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpJobFunction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsProcurementCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsRequiredCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTypeStagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobStageReportsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobStageFunctionsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobStageChecklistsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobStageTriggersTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobStageFieldPromptsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobMemoesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsInvoicingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobMemoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobTypeStages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobStageChecklists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobStageFieldPrompts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobStageTriggers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobStageReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobStageFunctions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FunctionsLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFunctions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistsLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForChecklists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TriggersLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobStageTriggersLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldPromptsLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldPromptsLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsRequired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsActive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSequence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsInvoicing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsZeroDiscountChecked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsCustomerOnHoldChecked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl)
        Me.grpGroup.Size = New System.Drawing.Size(587, 364)
        Me.grpGroup.Text = "Job Stage"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(444, 383)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(525, 383)
        '
        'DataLayoutControl
        '
        Me.DataLayoutControl.Controls.Add(Me.ValidateActiveJobsAssetCheckEdit)
        Me.DataLayoutControl.Controls.Add(Me.CheckEdit1)
        Me.DataLayoutControl.Controls.Add(Me.IsCustomerOnHoldCheckedCheckEdit)
        Me.DataLayoutControl.Controls.Add(Me.IsZeroDiscountCheckedCheckEdit)
        Me.DataLayoutControl.Controls.Add(Me.FieldPromptsGridControl)
        Me.DataLayoutControl.Controls.Add(Me.gcJobStageTriggers)
        Me.DataLayoutControl.Controls.Add(Me.gcChecklists)
        Me.DataLayoutControl.Controls.Add(Me.SequenceSpinEdit)
        Me.DataLayoutControl.Controls.Add(Me.gcReports)
        Me.DataLayoutControl.Controls.Add(Me.gcFunctions)
        Me.DataLayoutControl.Controls.Add(Me.IsProcurementCheckEdit)
        Me.DataLayoutControl.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.IsActiveCheckEdit)
        Me.DataLayoutControl.Controls.Add(Me.IsRequiredCheckEdit)
        Me.DataLayoutControl.Controls.Add(Me.JobTypeStagesTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.JobStageReportsTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.JobStageFunctionsTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.JobStageChecklistsTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.JobStageTriggersTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.JobStageFieldPromptsTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.JobMemoesTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.IDTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.ErrorTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.IsInvoicingCheckEdit)
        Me.DataLayoutControl.DataSource = Me.BindingSource
        Me.DataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForID, Me.ItemForError, Me.ItemForJobMemoes, Me.ItemForJobTypeStages, Me.ItemForJobStageChecklists, Me.ItemForJobStageFieldPrompts, Me.ItemForJobStageTriggers, Me.ItemForJobStageReports, Me.ItemForJobStageFunctions})
        Me.DataLayoutControl.Location = New System.Drawing.Point(2, 21)
        Me.DataLayoutControl.Name = "DataLayoutControl"
        Me.DataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(452, 55, 502, 501)
        Me.DataLayoutControl.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl.Size = New System.Drawing.Size(583, 341)
        Me.DataLayoutControl.TabIndex = 0
        Me.DataLayoutControl.Text = "DataLayoutControl"
        '
        'ValidateActiveJobsAssetCheckEdit
        '
        Me.ValidateActiveJobsAssetCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidateActiveJobsAsset", True))
        Me.ValidateActiveJobsAssetCheckEdit.Location = New System.Drawing.Point(306, 65)
        Me.ValidateActiveJobsAssetCheckEdit.Name = "ValidateActiveJobsAssetCheckEdit"
        Me.ValidateActiveJobsAssetCheckEdit.Properties.Caption = "Validate Active Jobs Asset"
        Me.ValidateActiveJobsAssetCheckEdit.Size = New System.Drawing.Size(272, 19)
        Me.ValidateActiveJobsAssetCheckEdit.StyleController = Me.DataLayoutControl
        Me.ValidateActiveJobsAssetCheckEdit.TabIndex = 28
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UpdateAssetUsage", True))
        Me.CheckEdit1.Location = New System.Drawing.Point(457, 34)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Update Asset Usage"
        Me.CheckEdit1.Size = New System.Drawing.Size(121, 19)
        Me.CheckEdit1.StyleController = Me.DataLayoutControl
        Me.CheckEdit1.TabIndex = 27
        '
        'IsCustomerOnHoldCheckedCheckEdit
        '
        Me.IsCustomerOnHoldCheckedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsCustomerOnHoldChecked", True))
        Me.IsCustomerOnHoldCheckedCheckEdit.Location = New System.Drawing.Point(5, 65)
        Me.IsCustomerOnHoldCheckedCheckEdit.Name = "IsCustomerOnHoldCheckedCheckEdit"
        Me.IsCustomerOnHoldCheckedCheckEdit.Properties.Caption = "Is Customer On Hold Checked"
        Me.IsCustomerOnHoldCheckedCheckEdit.Size = New System.Drawing.Size(291, 19)
        Me.IsCustomerOnHoldCheckedCheckEdit.StyleController = Me.DataLayoutControl
        Me.IsCustomerOnHoldCheckedCheckEdit.TabIndex = 26
        '
        'IsZeroDiscountCheckedCheckEdit
        '
        Me.IsZeroDiscountCheckedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsZeroDiscountChecked", True))
        Me.IsZeroDiscountCheckedCheckEdit.Location = New System.Drawing.Point(151, 35)
        Me.IsZeroDiscountCheckedCheckEdit.Name = "IsZeroDiscountCheckedCheckEdit"
        Me.IsZeroDiscountCheckedCheckEdit.Properties.Caption = "Is Zero Discount Checked"
        Me.IsZeroDiscountCheckedCheckEdit.Size = New System.Drawing.Size(145, 19)
        Me.IsZeroDiscountCheckedCheckEdit.StyleController = Me.DataLayoutControl
        Me.IsZeroDiscountCheckedCheckEdit.TabIndex = 25
        '
        'FieldPromptsGridControl
        '
        Me.FieldPromptsGridControl.DataSource = Me.FieldPromptsBindingSource
        Me.FieldPromptsGridControl.Location = New System.Drawing.Point(7, 118)
        Me.FieldPromptsGridControl.MainView = Me.FieldPromptsGridView
        Me.FieldPromptsGridControl.Name = "FieldPromptsGridControl"
        Me.FieldPromptsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rilkpJobProperties})
        Me.FieldPromptsGridControl.Size = New System.Drawing.Size(565, 212)
        Me.FieldPromptsGridControl.TabIndex = 14
        Me.FieldPromptsGridControl.UseEmbeddedNavigator = True
        Me.FieldPromptsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.FieldPromptsGridView})
        '
        'FieldPromptsBindingSource
        '
        Me.FieldPromptsBindingSource.DataMember = "FieldPrompts"
        Me.FieldPromptsBindingSource.DataSource = Me.BindingSource
        '
        'FieldPromptsGridView
        '
        Me.FieldPromptsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFieldName, Me.colIsRequired, Me.colRequiredValue, Me.colDefaultValue, Me.colPromptBefore, Me.colPromptAfter, Me.colID4, Me.colError})
        Me.FieldPromptsGridView.GridControl = Me.FieldPromptsGridControl
        Me.FieldPromptsGridView.Name = "FieldPromptsGridView"
        Me.FieldPromptsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.FieldPromptsGridView.OptionsView.ShowGroupPanel = False
        '
        'colFieldName
        '
        Me.colFieldName.ColumnEdit = Me.rilkpJobProperties
        Me.colFieldName.FieldName = "FieldName"
        Me.colFieldName.Name = "colFieldName"
        Me.colFieldName.Visible = True
        Me.colFieldName.VisibleIndex = 0
        '
        'rilkpJobProperties
        '
        Me.rilkpJobProperties.AutoHeight = False
        Me.rilkpJobProperties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilkpJobProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpJobProperties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rilkpJobProperties.DataSource = Me.PropertyInfoBindingSource
        Me.rilkpJobProperties.DisplayMember = "Name"
        Me.rilkpJobProperties.Name = "rilkpJobProperties"
        Me.rilkpJobProperties.NullText = "(Select Field...)"
        Me.rilkpJobProperties.ValueMember = "Name"
        '
        'PropertyInfoBindingSource
        '
        Me.PropertyInfoBindingSource.DataSource = GetType(System.Reflection.PropertyInfo)
        '
        'colIsRequired
        '
        Me.colIsRequired.FieldName = "IsRequired"
        Me.colIsRequired.Name = "colIsRequired"
        Me.colIsRequired.Visible = True
        Me.colIsRequired.VisibleIndex = 1
        '
        'colRequiredValue
        '
        Me.colRequiredValue.FieldName = "RequiredValue"
        Me.colRequiredValue.Name = "colRequiredValue"
        Me.colRequiredValue.Visible = True
        Me.colRequiredValue.VisibleIndex = 2
        '
        'colDefaultValue
        '
        Me.colDefaultValue.FieldName = "DefaultValue"
        Me.colDefaultValue.Name = "colDefaultValue"
        Me.colDefaultValue.Visible = True
        Me.colDefaultValue.VisibleIndex = 3
        '
        'colPromptBefore
        '
        Me.colPromptBefore.FieldName = "PromptBefore"
        Me.colPromptBefore.Name = "colPromptBefore"
        Me.colPromptBefore.Visible = True
        Me.colPromptBefore.VisibleIndex = 4
        '
        'colPromptAfter
        '
        Me.colPromptAfter.FieldName = "PromptAfter"
        Me.colPromptAfter.Name = "colPromptAfter"
        Me.colPromptAfter.Visible = True
        Me.colPromptAfter.VisibleIndex = 5
        '
        'colID4
        '
        Me.colID4.FieldName = "ID"
        Me.colID4.Name = "colID4"
        Me.colID4.OptionsColumn.ReadOnly = True
        '
        'colError
        '
        Me.colError.FieldName = "Error"
        Me.colError.Name = "colError"
        Me.colError.OptionsColumn.ReadOnly = True
        '
        'gcJobStageTriggers
        '
        Me.gcJobStageTriggers.DataSource = Me.TriggersBindingSource
        Me.gcJobStageTriggers.Location = New System.Drawing.Point(7, 118)
        Me.gcJobStageTriggers.MainView = Me.gvJobStageTriggers
        Me.gcJobStageTriggers.Name = "gcJobStageTriggers"
        Me.gcJobStageTriggers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rilkpTrigger})
        Me.gcJobStageTriggers.Size = New System.Drawing.Size(565, 212)
        Me.gcJobStageTriggers.TabIndex = 13
        Me.gcJobStageTriggers.UseEmbeddedNavigator = True
        Me.gcJobStageTriggers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobStageTriggers})
        '
        'TriggersBindingSource
        '
        Me.TriggersBindingSource.DataMember = "Triggers"
        Me.TriggersBindingSource.DataSource = Me.BindingSource
        '
        'gvJobStageTriggers
        '
        Me.gvJobStageTriggers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTriggerID, Me.colID3})
        Me.gvJobStageTriggers.GridControl = Me.gcJobStageTriggers
        Me.gvJobStageTriggers.Name = "gvJobStageTriggers"
        Me.gvJobStageTriggers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvJobStageTriggers.OptionsView.ShowGroupPanel = False
        '
        'colTriggerID
        '
        Me.colTriggerID.Caption = "Trigger"
        Me.colTriggerID.ColumnEdit = Me.rilkpTrigger
        Me.colTriggerID.FieldName = "TriggerID"
        Me.colTriggerID.Name = "colTriggerID"
        Me.colTriggerID.Visible = True
        Me.colTriggerID.VisibleIndex = 0
        '
        'rilkpTrigger
        '
        Me.rilkpTrigger.AutoHeight = False
        Me.rilkpTrigger.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilkpTrigger.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpTrigger.Name = "rilkpTrigger"
        Me.rilkpTrigger.NullText = "(Select Trigger...)"
        '
        'colID3
        '
        Me.colID3.FieldName = "ID"
        Me.colID3.Name = "colID3"
        '
        'gcChecklists
        '
        Me.gcChecklists.DataSource = Me.ChecklistsBindingSource
        Me.gcChecklists.Location = New System.Drawing.Point(7, 118)
        Me.gcChecklists.MainView = Me.gvChecklists
        Me.gcChecklists.Name = "gcChecklists"
        Me.gcChecklists.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rilkpChecklist})
        Me.gcChecklists.Size = New System.Drawing.Size(565, 212)
        Me.gcChecklists.TabIndex = 12
        Me.gcChecklists.UseEmbeddedNavigator = True
        Me.gcChecklists.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChecklists})
        '
        'ChecklistsBindingSource
        '
        Me.ChecklistsBindingSource.DataMember = "Checklists"
        Me.ChecklistsBindingSource.DataSource = Me.BindingSource
        '
        'gvChecklists
        '
        Me.gvChecklists.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChecklist, Me.colID2})
        Me.gvChecklists.GridControl = Me.gcChecklists
        Me.gvChecklists.Name = "gvChecklists"
        Me.gvChecklists.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvChecklists.OptionsView.ShowGroupPanel = False
        '
        'colChecklist
        '
        Me.colChecklist.ColumnEdit = Me.rilkpChecklist
        Me.colChecklist.FieldName = "Checklist"
        Me.colChecklist.Name = "colChecklist"
        Me.colChecklist.Visible = True
        Me.colChecklist.VisibleIndex = 0
        '
        'rilkpChecklist
        '
        Me.rilkpChecklist.AutoHeight = False
        Me.rilkpChecklist.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilkpChecklist.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpChecklist.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rilkpChecklist.DataSource = Me.ChecklistBindingSource
        Me.rilkpChecklist.Name = "rilkpChecklist"
        Me.rilkpChecklist.NullText = "(Select Checklist...)"
        '
        'ChecklistBindingSource
        '
        Me.ChecklistBindingSource.DataSource = GetType(UniSource.Checklist.API.Checklist)
        '
        'colID2
        '
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        '
        'SequenceSpinEdit
        '
        Me.SequenceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Sequence", True))
        Me.SequenceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SequenceSpinEdit.Location = New System.Drawing.Point(209, 5)
        Me.SequenceSpinEdit.Name = "SequenceSpinEdit"
        Me.SequenceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SequenceSpinEdit.Size = New System.Drawing.Size(87, 20)
        Me.SequenceSpinEdit.StyleController = Me.DataLayoutControl
        Me.SequenceSpinEdit.TabIndex = 11
        '
        'gcReports
        '
        Me.gcReports.DataSource = Me.ReportsBindingSource
        Me.gcReports.Location = New System.Drawing.Point(7, 118)
        Me.gcReports.MainView = Me.gvReports
        Me.gcReports.Name = "gcReports"
        Me.gcReports.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.richkIsAutomatic, Me.rilkpReport, Me.richkIsReportOnEditScreen, Me.richkIsReportOnListScreen})
        Me.gcReports.Size = New System.Drawing.Size(565, 212)
        Me.gcReports.TabIndex = 10
        Me.gcReports.UseEmbeddedNavigator = True
        Me.gcReports.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvReports})
        '
        'ReportsBindingSource
        '
        Me.ReportsBindingSource.DataMember = "Reports"
        Me.ReportsBindingSource.DataSource = Me.BindingSource
        '
        'gvReports
        '
        Me.gvReports.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReportID, Me.colIsAutomatic, Me.colIsReportOnEditScreen, Me.colIsReportOnListScreen, Me.colID1})
        Me.gvReports.CustomizationFormBounds = New System.Drawing.Rectangle(427, 356, 216, 185)
        Me.gvReports.GridControl = Me.gcReports
        Me.gvReports.Name = "gvReports"
        Me.gvReports.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvReports.OptionsView.ShowGroupPanel = False
        '
        'colReportID
        '
        Me.colReportID.Caption = "Report"
        Me.colReportID.ColumnEdit = Me.rilkpReport
        Me.colReportID.FieldName = "Report"
        Me.colReportID.Name = "colReportID"
        Me.colReportID.Visible = True
        Me.colReportID.VisibleIndex = 0
        Me.colReportID.Width = 200
        '
        'rilkpReport
        '
        Me.rilkpReport.AutoHeight = False
        Me.rilkpReport.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilkpReport.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpReport.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReportName", "Report Name", 86, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rilkpReport.DataSource = Me.ReportBindingSource
        Me.rilkpReport.DisplayMember = "ReportName"
        Me.rilkpReport.Name = "rilkpReport"
        Me.rilkpReport.NullText = "(Select Report...)"
        '
        'colIsAutomatic
        '
        Me.colIsAutomatic.ColumnEdit = Me.richkIsAutomatic
        Me.colIsAutomatic.FieldName = "IsAutomatic"
        Me.colIsAutomatic.Name = "colIsAutomatic"
        Me.colIsAutomatic.Visible = True
        Me.colIsAutomatic.VisibleIndex = 1
        Me.colIsAutomatic.Width = 69
        '
        'richkIsAutomatic
        '
        Me.richkIsAutomatic.AutoHeight = False
        Me.richkIsAutomatic.Name = "richkIsAutomatic"
        '
        'colIsReportOnEditScreen
        '
        Me.colIsReportOnEditScreen.ColumnEdit = Me.richkIsReportOnEditScreen
        Me.colIsReportOnEditScreen.FieldName = "IsReportOnEditScreen"
        Me.colIsReportOnEditScreen.Name = "colIsReportOnEditScreen"
        Me.colIsReportOnEditScreen.Visible = True
        Me.colIsReportOnEditScreen.VisibleIndex = 2
        Me.colIsReportOnEditScreen.Width = 150
        '
        'richkIsReportOnEditScreen
        '
        Me.richkIsReportOnEditScreen.AutoHeight = False
        Me.richkIsReportOnEditScreen.Name = "richkIsReportOnEditScreen"
        '
        'colIsReportOnListScreen
        '
        Me.colIsReportOnListScreen.ColumnEdit = Me.richkIsReportOnListScreen
        Me.colIsReportOnListScreen.FieldName = "IsReportOnListScreen"
        Me.colIsReportOnListScreen.Name = "colIsReportOnListScreen"
        Me.colIsReportOnListScreen.Visible = True
        Me.colIsReportOnListScreen.VisibleIndex = 3
        Me.colIsReportOnListScreen.Width = 128
        '
        'richkIsReportOnListScreen
        '
        Me.richkIsReportOnListScreen.AutoHeight = False
        Me.richkIsReportOnListScreen.Name = "richkIsReportOnListScreen"
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        Me.colID1.OptionsColumn.ReadOnly = True
        '
        'gcFunctions
        '
        Me.gcFunctions.DataSource = Me.FunctionsBindingSource
        Me.gcFunctions.Location = New System.Drawing.Point(7, 118)
        Me.gcFunctions.MainView = Me.gvFunctions
        Me.gcFunctions.Name = "gcFunctions"
        Me.gcFunctions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rilkpJobFunction})
        Me.gcFunctions.Size = New System.Drawing.Size(565, 212)
        Me.gcFunctions.TabIndex = 9
        Me.gcFunctions.UseEmbeddedNavigator = True
        Me.gcFunctions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFunctions})
        '
        'FunctionsBindingSource
        '
        Me.FunctionsBindingSource.DataMember = "Functions"
        Me.FunctionsBindingSource.DataSource = Me.BindingSource
        '
        'gvFunctions
        '
        Me.gvFunctions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobFunctionID, Me.colID})
        Me.gvFunctions.GridControl = Me.gcFunctions
        Me.gvFunctions.Name = "gvFunctions"
        Me.gvFunctions.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvFunctions.OptionsView.ShowGroupPanel = False
        '
        'colJobFunctionID
        '
        Me.colJobFunctionID.Caption = "Function"
        Me.colJobFunctionID.ColumnEdit = Me.rilkpJobFunction
        Me.colJobFunctionID.FieldName = "JobFunction"
        Me.colJobFunctionID.Name = "colJobFunctionID"
        Me.colJobFunctionID.Visible = True
        Me.colJobFunctionID.VisibleIndex = 0
        '
        'rilkpJobFunction
        '
        Me.rilkpJobFunction.AutoHeight = False
        Me.rilkpJobFunction.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilkpJobFunction.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpJobFunction.Name = "rilkpJobFunction"
        Me.rilkpJobFunction.NullText = "(Select Job Function...)"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'IsProcurementCheckEdit
        '
        Me.IsProcurementCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsProcurement", True))
        Me.IsProcurementCheckEdit.Location = New System.Drawing.Point(394, 5)
        Me.IsProcurementCheckEdit.Name = "IsProcurementCheckEdit"
        Me.IsProcurementCheckEdit.Properties.Caption = "Procurement"
        Me.IsProcurementCheckEdit.Size = New System.Drawing.Size(184, 19)
        Me.IsProcurementCheckEdit.StyleController = Me.DataLayoutControl
        Me.IsProcurementCheckEdit.TabIndex = 8
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(63, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Properties.MaxLength = 50
        Me.CodeTextEdit.Size = New System.Drawing.Size(78, 20)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl
        Me.CodeTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(63, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Properties.MaxLength = 50
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(78, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'IsActiveCheckEdit
        '
        Me.IsActiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsActive", True))
        Me.IsActiveCheckEdit.EditValue = True
        Me.IsActiveCheckEdit.Location = New System.Drawing.Point(394, 34)
        Me.IsActiveCheckEdit.Name = "IsActiveCheckEdit"
        Me.IsActiveCheckEdit.Properties.Caption = "Active"
        Me.IsActiveCheckEdit.Size = New System.Drawing.Size(53, 19)
        Me.IsActiveCheckEdit.StyleController = Me.DataLayoutControl
        Me.IsActiveCheckEdit.TabIndex = 7
        '
        'IsRequiredCheckEdit
        '
        Me.IsRequiredCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsRequired", True))
        Me.IsRequiredCheckEdit.EditValue = True
        Me.IsRequiredCheckEdit.Location = New System.Drawing.Point(306, 5)
        Me.IsRequiredCheckEdit.Name = "IsRequiredCheckEdit"
        Me.IsRequiredCheckEdit.Properties.Caption = "Required"
        Me.IsRequiredCheckEdit.Size = New System.Drawing.Size(78, 19)
        Me.IsRequiredCheckEdit.StyleController = Me.DataLayoutControl
        Me.IsRequiredCheckEdit.TabIndex = 6
        '
        'JobTypeStagesTextEdit
        '
        Me.JobTypeStagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobTypeStages", True))
        Me.JobTypeStagesTextEdit.Location = New System.Drawing.Point(125, 316)
        Me.JobTypeStagesTextEdit.Name = "JobTypeStagesTextEdit"
        Me.JobTypeStagesTextEdit.Size = New System.Drawing.Size(453, 20)
        Me.JobTypeStagesTextEdit.StyleController = Me.DataLayoutControl
        Me.JobTypeStagesTextEdit.TabIndex = 16
        '
        'JobStageReportsTextEdit
        '
        Me.JobStageReportsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobStageReports", True))
        Me.JobStageReportsTextEdit.Location = New System.Drawing.Point(7, 190)
        Me.JobStageReportsTextEdit.Name = "JobStageReportsTextEdit"
        Me.JobStageReportsTextEdit.Size = New System.Drawing.Size(565, 20)
        Me.JobStageReportsTextEdit.StyleController = Me.DataLayoutControl
        Me.JobStageReportsTextEdit.TabIndex = 17
        '
        'JobStageFunctionsTextEdit
        '
        Me.JobStageFunctionsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobStageFunctions", True))
        Me.JobStageFunctionsTextEdit.Location = New System.Drawing.Point(109, 190)
        Me.JobStageFunctionsTextEdit.Name = "JobStageFunctionsTextEdit"
        Me.JobStageFunctionsTextEdit.Size = New System.Drawing.Size(463, 20)
        Me.JobStageFunctionsTextEdit.StyleController = Me.DataLayoutControl
        Me.JobStageFunctionsTextEdit.TabIndex = 18
        '
        'JobStageChecklistsTextEdit
        '
        Me.JobStageChecklistsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobStageChecklists", True))
        Me.JobStageChecklistsTextEdit.Location = New System.Drawing.Point(127, 190)
        Me.JobStageChecklistsTextEdit.Name = "JobStageChecklistsTextEdit"
        Me.JobStageChecklistsTextEdit.Size = New System.Drawing.Size(445, 20)
        Me.JobStageChecklistsTextEdit.StyleController = Me.DataLayoutControl
        Me.JobStageChecklistsTextEdit.TabIndex = 19
        '
        'JobStageTriggersTextEdit
        '
        Me.JobStageTriggersTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobStageTriggers", True))
        Me.JobStageTriggersTextEdit.Location = New System.Drawing.Point(109, 190)
        Me.JobStageTriggersTextEdit.Name = "JobStageTriggersTextEdit"
        Me.JobStageTriggersTextEdit.Size = New System.Drawing.Size(463, 20)
        Me.JobStageTriggersTextEdit.StyleController = Me.DataLayoutControl
        Me.JobStageTriggersTextEdit.TabIndex = 20
        '
        'JobStageFieldPromptsTextEdit
        '
        Me.JobStageFieldPromptsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobStageFieldPrompts", True))
        Me.JobStageFieldPromptsTextEdit.Location = New System.Drawing.Point(127, 190)
        Me.JobStageFieldPromptsTextEdit.Name = "JobStageFieldPromptsTextEdit"
        Me.JobStageFieldPromptsTextEdit.Size = New System.Drawing.Size(445, 20)
        Me.JobStageFieldPromptsTextEdit.StyleController = Me.DataLayoutControl
        Me.JobStageFieldPromptsTextEdit.TabIndex = 21
        '
        'JobMemoesTextEdit
        '
        Me.JobMemoesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobMemoes", True))
        Me.JobMemoesTextEdit.Location = New System.Drawing.Point(125, 316)
        Me.JobMemoesTextEdit.Name = "JobMemoesTextEdit"
        Me.JobMemoesTextEdit.Size = New System.Drawing.Size(453, 20)
        Me.JobMemoesTextEdit.StyleController = Me.DataLayoutControl
        Me.JobMemoesTextEdit.TabIndex = 22
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(125, 286)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(453, 20)
        Me.IDTextEdit.StyleController = Me.DataLayoutControl
        Me.IDTextEdit.TabIndex = 23
        '
        'ErrorTextEdit
        '
        Me.ErrorTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Error", True))
        Me.ErrorTextEdit.Location = New System.Drawing.Point(125, 316)
        Me.ErrorTextEdit.Name = "ErrorTextEdit"
        Me.ErrorTextEdit.Size = New System.Drawing.Size(453, 20)
        Me.ErrorTextEdit.StyleController = Me.DataLayoutControl
        Me.ErrorTextEdit.TabIndex = 24
        '
        'IsInvoicingCheckEdit
        '
        Me.IsInvoicingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsInvoicing", True))
        Me.IsInvoicingCheckEdit.Location = New System.Drawing.Point(306, 34)
        Me.IsInvoicingCheckEdit.Name = "IsInvoicingCheckEdit"
        Me.IsInvoicingCheckEdit.Properties.Caption = "Is Invoicing"
        Me.IsInvoicingCheckEdit.Size = New System.Drawing.Size(78, 19)
        Me.IsInvoicingCheckEdit.StyleController = Me.DataLayoutControl
        Me.IsInvoicingCheckEdit.TabIndex = 15
        '
        'ItemForID
        '
        Me.ItemForID.Control = Me.IDTextEdit
        Me.ItemForID.CustomizationFormText = "ID"
        Me.ItemForID.Location = New System.Drawing.Point(0, 60)
        Me.ItemForID.Name = "ItemForID"
        Me.ItemForID.Size = New System.Drawing.Size(583, 30)
        Me.ItemForID.Text = "ID"
        Me.ItemForID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForID.TextToControlDistance = 5
        '
        'ItemForError
        '
        Me.ItemForError.Control = Me.ErrorTextEdit
        Me.ItemForError.CustomizationFormText = "Error"
        Me.ItemForError.Location = New System.Drawing.Point(0, 60)
        Me.ItemForError.Name = "ItemForError"
        Me.ItemForError.Size = New System.Drawing.Size(583, 30)
        Me.ItemForError.Text = "Error"
        Me.ItemForError.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForError.TextToControlDistance = 5
        '
        'ItemForJobMemoes
        '
        Me.ItemForJobMemoes.Control = Me.JobMemoesTextEdit
        Me.ItemForJobMemoes.CustomizationFormText = "Job Memoes"
        Me.ItemForJobMemoes.Location = New System.Drawing.Point(0, 30)
        Me.ItemForJobMemoes.Name = "ItemForJobMemoes"
        Me.ItemForJobMemoes.Size = New System.Drawing.Size(583, 30)
        Me.ItemForJobMemoes.Text = "Job Memoes"
        Me.ItemForJobMemoes.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobMemoes.TextToControlDistance = 5
        '
        'ItemForJobTypeStages
        '
        Me.ItemForJobTypeStages.Control = Me.JobTypeStagesTextEdit
        Me.ItemForJobTypeStages.CustomizationFormText = "Job Type Stages"
        Me.ItemForJobTypeStages.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobTypeStages.Name = "ItemForJobTypeStages"
        Me.ItemForJobTypeStages.Size = New System.Drawing.Size(583, 30)
        Me.ItemForJobTypeStages.Text = "Job Type Stages"
        Me.ItemForJobTypeStages.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobTypeStages.TextToControlDistance = 5
        '
        'ItemForJobStageChecklists
        '
        Me.ItemForJobStageChecklists.Control = Me.JobStageChecklistsTextEdit
        Me.ItemForJobStageChecklists.CustomizationFormText = "Job Stage Checklists"
        Me.ItemForJobStageChecklists.Location = New System.Drawing.Point(0, 74)
        Me.ItemForJobStageChecklists.Name = "ItemForJobStageChecklists"
        Me.ItemForJobStageChecklists.Size = New System.Drawing.Size(575, 30)
        Me.ItemForJobStageChecklists.Text = "Job Stage Checklists"
        Me.ItemForJobStageChecklists.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobStageChecklists.TextToControlDistance = 5
        '
        'ItemForJobStageFieldPrompts
        '
        Me.ItemForJobStageFieldPrompts.Control = Me.JobStageFieldPromptsTextEdit
        Me.ItemForJobStageFieldPrompts.CustomizationFormText = "Job Stage Field Prompts"
        Me.ItemForJobStageFieldPrompts.Location = New System.Drawing.Point(0, 74)
        Me.ItemForJobStageFieldPrompts.Name = "ItemForJobStageFieldPrompts"
        Me.ItemForJobStageFieldPrompts.Size = New System.Drawing.Size(575, 30)
        Me.ItemForJobStageFieldPrompts.Text = "Job Stage Field Prompts"
        Me.ItemForJobStageFieldPrompts.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobStageFieldPrompts.TextToControlDistance = 5
        '
        'ItemForJobStageTriggers
        '
        Me.ItemForJobStageTriggers.Control = Me.JobStageTriggersTextEdit
        Me.ItemForJobStageTriggers.CustomizationFormText = "Job Stage Triggers"
        Me.ItemForJobStageTriggers.Location = New System.Drawing.Point(0, 74)
        Me.ItemForJobStageTriggers.Name = "ItemForJobStageTriggers"
        Me.ItemForJobStageTriggers.Size = New System.Drawing.Size(575, 30)
        Me.ItemForJobStageTriggers.Text = "Job Stage Triggers"
        Me.ItemForJobStageTriggers.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobStageTriggers.TextToControlDistance = 5
        '
        'ItemForJobStageReports
        '
        Me.ItemForJobStageReports.Control = Me.JobStageReportsTextEdit
        Me.ItemForJobStageReports.CustomizationFormText = "Job Stage Reports"
        Me.ItemForJobStageReports.Location = New System.Drawing.Point(0, 74)
        Me.ItemForJobStageReports.Name = "ItemForJobStageReports"
        Me.ItemForJobStageReports.Size = New System.Drawing.Size(575, 30)
        Me.ItemForJobStageReports.Text = "Job Stage Reports"
        Me.ItemForJobStageReports.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForJobStageReports.TextToControlDistance = 0
        Me.ItemForJobStageReports.TextVisible = False
        '
        'ItemForJobStageFunctions
        '
        Me.ItemForJobStageFunctions.Control = Me.JobStageFunctionsTextEdit
        Me.ItemForJobStageFunctions.CustomizationFormText = "Job Stage Functions"
        Me.ItemForJobStageFunctions.Location = New System.Drawing.Point(0, 74)
        Me.ItemForJobStageFunctions.Name = "ItemForJobStageFunctions"
        Me.ItemForJobStageFunctions.Size = New System.Drawing.Size(575, 30)
        Me.ItemForJobStageFunctions.Text = "Job Stage Functions"
        Me.ItemForJobStageFunctions.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobStageFunctions.TextToControlDistance = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(583, 341)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.TabbedControlGroup1, Me.ItemForIsRequired, Me.ItemForIsActive, Me.ItemForSequence, Me.LayoutControlItem1, Me.ItemForDescription, Me.ItemForIsInvoicing, Me.ItemForIsZeroDiscountChecked, Me.ItemForIsCustomerOnHoldChecked, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(583, 341)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(146, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForCode.TextToControlDistance = 5
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 89)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.FunctionsLayoutControlGroup
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(583, 252)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.FunctionsLayoutControlGroup, Me.ReportsLayoutControlGroup, Me.ChecklistsLayoutControlGroup, Me.TriggersLayoutControlGroup, Me.FieldPromptsLayoutControlGroup})
        Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
        '
        'FunctionsLayoutControlGroup
        '
        Me.FunctionsLayoutControlGroup.CustomizationFormText = "Functions"
        Me.FunctionsLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForFunctions})
        Me.FunctionsLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.FunctionsLayoutControlGroup.Name = "FunctionsLayoutControlGroup"
        Me.FunctionsLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.FunctionsLayoutControlGroup.Size = New System.Drawing.Size(575, 222)
        Me.FunctionsLayoutControlGroup.Text = "Functions"
        '
        'ItemForFunctions
        '
        Me.ItemForFunctions.Control = Me.gcFunctions
        Me.ItemForFunctions.CustomizationFormText = "Functions"
        Me.ItemForFunctions.Location = New System.Drawing.Point(0, 0)
        Me.ItemForFunctions.Name = "ItemForFunctions"
        Me.ItemForFunctions.Size = New System.Drawing.Size(575, 222)
        Me.ItemForFunctions.Text = "Functions"
        Me.ItemForFunctions.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForFunctions.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForFunctions.TextToControlDistance = 0
        Me.ItemForFunctions.TextVisible = False
        '
        'ReportsLayoutControlGroup
        '
        Me.ReportsLayoutControlGroup.CustomizationFormText = "Reports"
        Me.ReportsLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForReports})
        Me.ReportsLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.ReportsLayoutControlGroup.Name = "ReportsLayoutControlGroup"
        Me.ReportsLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.ReportsLayoutControlGroup.Size = New System.Drawing.Size(575, 222)
        Me.ReportsLayoutControlGroup.Text = "Reports"
        '
        'ItemForReports
        '
        Me.ItemForReports.Control = Me.gcReports
        Me.ItemForReports.CustomizationFormText = "Reports"
        Me.ItemForReports.Location = New System.Drawing.Point(0, 0)
        Me.ItemForReports.Name = "ItemForReports"
        Me.ItemForReports.Size = New System.Drawing.Size(575, 222)
        Me.ItemForReports.Text = "Reports"
        Me.ItemForReports.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForReports.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForReports.TextToControlDistance = 0
        Me.ItemForReports.TextVisible = False
        '
        'ChecklistsLayoutControlGroup
        '
        Me.ChecklistsLayoutControlGroup.CustomizationFormText = "Checklists"
        Me.ChecklistsLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForChecklists})
        Me.ChecklistsLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.ChecklistsLayoutControlGroup.Name = "ChecklistsLayoutControlGroup"
        Me.ChecklistsLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.ChecklistsLayoutControlGroup.Size = New System.Drawing.Size(575, 222)
        Me.ChecklistsLayoutControlGroup.Text = "Checklists"
        '
        'ItemForChecklists
        '
        Me.ItemForChecklists.Control = Me.gcChecklists
        Me.ItemForChecklists.CustomizationFormText = "Checklists"
        Me.ItemForChecklists.Location = New System.Drawing.Point(0, 0)
        Me.ItemForChecklists.Name = "ItemForChecklists"
        Me.ItemForChecklists.Size = New System.Drawing.Size(575, 222)
        Me.ItemForChecklists.Text = "Checklists"
        Me.ItemForChecklists.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForChecklists.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForChecklists.TextToControlDistance = 0
        Me.ItemForChecklists.TextVisible = False
        '
        'TriggersLayoutControlGroup
        '
        Me.TriggersLayoutControlGroup.CustomizationFormText = "Triggers"
        Me.TriggersLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.JobStageTriggersLayoutControlItem})
        Me.TriggersLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.TriggersLayoutControlGroup.Name = "TriggersLayoutControlGroup"
        Me.TriggersLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.TriggersLayoutControlGroup.Size = New System.Drawing.Size(575, 222)
        Me.TriggersLayoutControlGroup.Text = "Triggers"
        '
        'JobStageTriggersLayoutControlItem
        '
        Me.JobStageTriggersLayoutControlItem.Control = Me.gcJobStageTriggers
        Me.JobStageTriggersLayoutControlItem.CustomizationFormText = "Triggers"
        Me.JobStageTriggersLayoutControlItem.Location = New System.Drawing.Point(0, 0)
        Me.JobStageTriggersLayoutControlItem.Name = "JobStageTriggersLayoutControlItem"
        Me.JobStageTriggersLayoutControlItem.Size = New System.Drawing.Size(575, 222)
        Me.JobStageTriggersLayoutControlItem.Text = "Triggers"
        Me.JobStageTriggersLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top
        Me.JobStageTriggersLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
        Me.JobStageTriggersLayoutControlItem.TextToControlDistance = 0
        Me.JobStageTriggersLayoutControlItem.TextVisible = False
        '
        'FieldPromptsLayoutControlGroup
        '
        Me.FieldPromptsLayoutControlGroup.CustomizationFormText = "Field Prompts"
        Me.FieldPromptsLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.FieldPromptsLayoutControlItem})
        Me.FieldPromptsLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.FieldPromptsLayoutControlGroup.Name = "FieldPromptsLayoutControlGroup"
        Me.FieldPromptsLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.FieldPromptsLayoutControlGroup.Size = New System.Drawing.Size(575, 222)
        Me.FieldPromptsLayoutControlGroup.Text = "Field Prompts"
        '
        'FieldPromptsLayoutControlItem
        '
        Me.FieldPromptsLayoutControlItem.Control = Me.FieldPromptsGridControl
        Me.FieldPromptsLayoutControlItem.CustomizationFormText = "Field Prompts"
        Me.FieldPromptsLayoutControlItem.Location = New System.Drawing.Point(0, 0)
        Me.FieldPromptsLayoutControlItem.Name = "FieldPromptsLayoutControlItem"
        Me.FieldPromptsLayoutControlItem.Size = New System.Drawing.Size(575, 222)
        Me.FieldPromptsLayoutControlItem.Text = "Field Prompts"
        Me.FieldPromptsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top
        Me.FieldPromptsLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
        Me.FieldPromptsLayoutControlItem.TextToControlDistance = 0
        Me.FieldPromptsLayoutControlItem.TextVisible = False
        '
        'ItemForIsRequired
        '
        Me.ItemForIsRequired.Control = Me.IsRequiredCheckEdit
        Me.ItemForIsRequired.CustomizationFormText = "Is Required"
        Me.ItemForIsRequired.Location = New System.Drawing.Point(301, 0)
        Me.ItemForIsRequired.Name = "ItemForIsRequired"
        Me.ItemForIsRequired.Size = New System.Drawing.Size(88, 29)
        Me.ItemForIsRequired.Text = "Is Required"
        Me.ItemForIsRequired.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsRequired.TextToControlDistance = 0
        Me.ItemForIsRequired.TextVisible = False
        '
        'ItemForIsActive
        '
        Me.ItemForIsActive.Control = Me.IsActiveCheckEdit
        Me.ItemForIsActive.CustomizationFormText = "Is Active"
        Me.ItemForIsActive.Location = New System.Drawing.Point(389, 29)
        Me.ItemForIsActive.Name = "ItemForIsActive"
        Me.ItemForIsActive.Size = New System.Drawing.Size(63, 31)
        Me.ItemForIsActive.Text = "Is Active"
        Me.ItemForIsActive.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsActive.TextToControlDistance = 0
        Me.ItemForIsActive.TextVisible = False
        '
        'ItemForSequence
        '
        Me.ItemForSequence.Control = Me.SequenceSpinEdit
        Me.ItemForSequence.CustomizationFormText = "Sequence"
        Me.ItemForSequence.Location = New System.Drawing.Point(146, 0)
        Me.ItemForSequence.Name = "ItemForSequence"
        Me.ItemForSequence.Size = New System.Drawing.Size(155, 30)
        Me.ItemForSequence.Text = "Sequence"
        Me.ItemForSequence.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForSequence.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.IsProcurementCheckEdit
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(389, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(194, 29)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(146, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForIsInvoicing
        '
        Me.ItemForIsInvoicing.Control = Me.IsInvoicingCheckEdit
        Me.ItemForIsInvoicing.CustomizationFormText = "Is Invoicing"
        Me.ItemForIsInvoicing.Location = New System.Drawing.Point(301, 29)
        Me.ItemForIsInvoicing.Name = "ItemForIsInvoicing"
        Me.ItemForIsInvoicing.Size = New System.Drawing.Size(88, 31)
        Me.ItemForIsInvoicing.Text = "Is Invoicing"
        Me.ItemForIsInvoicing.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsInvoicing.TextToControlDistance = 0
        Me.ItemForIsInvoicing.TextVisible = False
        '
        'ItemForIsZeroDiscountChecked
        '
        Me.ItemForIsZeroDiscountChecked.Control = Me.IsZeroDiscountCheckedCheckEdit
        Me.ItemForIsZeroDiscountChecked.CustomizationFormText = "IsZeroDiscountChecked"
        Me.ItemForIsZeroDiscountChecked.Location = New System.Drawing.Point(146, 30)
        Me.ItemForIsZeroDiscountChecked.Name = "ItemForIsZeroDiscountChecked"
        Me.ItemForIsZeroDiscountChecked.Size = New System.Drawing.Size(155, 30)
        Me.ItemForIsZeroDiscountChecked.Text = "IsZeroDiscountChecked"
        Me.ItemForIsZeroDiscountChecked.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsZeroDiscountChecked.TextToControlDistance = 0
        Me.ItemForIsZeroDiscountChecked.TextVisible = False
        '
        'ItemForIsCustomerOnHoldChecked
        '
        Me.ItemForIsCustomerOnHoldChecked.Control = Me.IsCustomerOnHoldCheckedCheckEdit
        Me.ItemForIsCustomerOnHoldChecked.CustomizationFormText = "IsCustomerOnHoldChecked"
        Me.ItemForIsCustomerOnHoldChecked.Location = New System.Drawing.Point(0, 60)
        Me.ItemForIsCustomerOnHoldChecked.Name = "ItemForIsCustomerOnHoldChecked"
        Me.ItemForIsCustomerOnHoldChecked.Size = New System.Drawing.Size(301, 29)
        Me.ItemForIsCustomerOnHoldChecked.Text = "IsCustomerOnHoldChecked"
        Me.ItemForIsCustomerOnHoldChecked.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsCustomerOnHoldChecked.TextToControlDistance = 0
        Me.ItemForIsCustomerOnHoldChecked.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CheckEdit1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(452, 29)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(131, 31)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ValidateActiveJobsAssetCheckEdit
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(301, 60)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(282, 29)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'xaeJobStage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 418)
        Me.Name = "xaeJobStage"
        Me.Text = "Job Stage"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl.ResumeLayout(False)
        CType(Me.ValidateActiveJobsAssetCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsCustomerOnHoldCheckedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsZeroDiscountCheckedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldPromptsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldPromptsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldPromptsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpJobProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJobStageTriggers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TriggersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobStageTriggers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpTrigger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcChecklists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChecklists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpChecklist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SequenceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.richkIsAutomatic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.richkIsReportOnEditScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.richkIsReportOnListScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcFunctions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FunctionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFunctions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpJobFunction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsProcurementCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsRequiredCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTypeStagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobStageReportsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobStageFunctionsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobStageChecklistsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobStageTriggersTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobStageFieldPromptsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobMemoesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsInvoicingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobMemoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobTypeStages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobStageChecklists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobStageFieldPrompts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobStageTriggers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobStageReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobStageFunctions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FunctionsLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFunctions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistsLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForChecklists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TriggersLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobStageTriggersLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldPromptsLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldPromptsLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsRequired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsActive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSequence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsInvoicing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsZeroDiscountChecked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsCustomerOnHoldChecked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsRequiredCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsActiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsRequired As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsActive As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IsProcurementCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gcReports As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvReports As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcFunctions As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvFunctions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents ReportsLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForReports As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FunctionsLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForFunctions As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FunctionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colJobFunctionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colReportID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsAutomatic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilkpReport As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents richkIsAutomatic As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rilkpJobFunction As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SequenceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ItemForSequence As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ChecklistsLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents gcChecklists As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvChecklists As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemForChecklists As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ChecklistsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colChecklist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilkpChecklist As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ChecklistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gcJobStageTriggers As DevExpress.XtraGrid.GridControl
    Friend WithEvents TriggersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gvJobStageTriggers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTriggerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilkpTrigger As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TriggersLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents JobStageTriggersLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FieldPromptsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents FieldPromptsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FieldPromptsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFieldName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilkpJobProperties As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PropertyInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colIsRequired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FieldPromptsLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents FieldPromptsLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobTypeStagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobStageReportsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobStageFunctionsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobStageChecklistsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobStageTriggersTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobStageFieldPromptsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobMemoesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ErrorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsInvoicingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForError As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobMemoes As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobTypeStages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobStageChecklists As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobStageFieldPrompts As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobStageTriggers As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobStageReports As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobStageFunctions As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsInvoicing As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colPromptBefore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromptAfter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsReportOnEditScreen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents richkIsReportOnEditScreen As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colIsReportOnListScreen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents richkIsReportOnListScreen As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents IsZeroDiscountCheckedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForIsZeroDiscountChecked As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IsCustomerOnHoldCheckedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForIsCustomerOnHoldChecked As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ValidateActiveJobsAssetCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
