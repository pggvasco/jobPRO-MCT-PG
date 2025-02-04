<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeViewJobActivity
    Inherits GUI.xaegJob

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
        Me.gcJobActivity = New DevExpress.XtraGrid.GridControl()
        Me.JobActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvJobActivity = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArtisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperation_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilkpOperation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.OperationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EstimatedDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.ActualStartDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.E = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.EstimatedDuration = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ActualDuration = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.EstimatedActualDuration = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.luPart = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luOperation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luMachine = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luJob = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.txtValue = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtID = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.luCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.dtJobOpened = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.dtExpectedDelivery = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.txtLabourCost = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtMaterialCost = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtOrderPrice = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtProfitLeftOver = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtHours = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.OrderPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.dtStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.dtEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.UssActivitiesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsLoadingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsChangedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PropertiesValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ExpectedDevlieryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ProfitOrLeftOverTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabourCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MaterialCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForUssActivities = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsLoading = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsChanged = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPropertiesValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCustomer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForExpectedDevlieryDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForLabourCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForProfitOrLeftOver = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrderPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForMaterialCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.gcJobActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilkpOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualStartDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.E, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.E.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedActualDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtJobOpened, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtJobOpened.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtExpectedDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtExpectedDelivery.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLabourCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProfitLeftOver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UssActivitiesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedDevlieryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedDevlieryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfitOrLeftOverTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabourCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUssActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForExpectedDevlieryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForLabourCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForProfitOrLeftOver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMaterialCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(885, 396)
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(742, 415)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(823, 415)
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(JobCardDataCapturing.API.Job)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.gcJobActivity)
        Me.DataLayoutControl1.Controls.Add(Me.OrderPriceTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.dtStartDate)
        Me.DataLayoutControl1.Controls.Add(Me.dtEndDate)
        Me.DataLayoutControl1.Controls.Add(Me.UssActivitiesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsLoadingCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsChangedCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ValidationErrorMessagesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PropertiesValidationErrorMessagesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ExpectedDevlieryDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ProfitOrLeftOverTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.LabourCostTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MaterialCostTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CustomerLookUpEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForUssActivities, Me.ItemForIsLoading, Me.ItemForIsChanged, Me.ItemForValidationErrorMessages, Me.ItemForPropertiesValidationErrorMessages, Me.ItemForID})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 22)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(399, 245, 250, 350)
        Me.DataLayoutControl1.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(881, 372)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'gcJobActivity
        '
        Me.gcJobActivity.DataSource = Me.JobActivityBindingSource
        Me.gcJobActivity.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcJobActivity.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcJobActivity.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcJobActivity.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcJobActivity.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcJobActivity.Location = New System.Drawing.Point(5, 143)
        Me.gcJobActivity.MainView = Me.gvJobActivity
        Me.gcJobActivity.Name = "gcJobActivity"
        Me.gcJobActivity.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.EstimatedDate, Me.ActualStartDate, Me.E, Me.EstimatedDuration, Me.ActualDuration, Me.EstimatedActualDuration, Me.luPart, Me.luOperation, Me.luMachine, Me.luJob, Me.luArtisan, Me.txtValue, Me.txtID, Me.luCustomer, Me.txtDescription, Me.dtJobOpened, Me.dtExpectedDelivery, Me.txtLabourCost, Me.txtMaterialCost, Me.txtOrderPrice, Me.txtProfitLeftOver, Me.txtHours, Me.rilkpOperation})
        Me.gcJobActivity.Size = New System.Drawing.Size(871, 189)
        Me.gcJobActivity.TabIndex = 18
        Me.gcJobActivity.UseEmbeddedNavigator = True
        Me.gcJobActivity.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobActivity})
        '
        'JobActivityBindingSource
        '
        Me.JobActivityBindingSource.DataMember = "JobActivity"
        Me.JobActivityBindingSource.DataSource = Me.BindingSource
        '
        'gvJobActivity
        '
        Me.gvJobActivity.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEndDate, Me.colHours, Me.colStartDate, Me.colValue, Me.colArtisan, Me.colJob, Me.colMachine, Me.colOperation_, Me.colPart, Me.colID})
        Me.gvJobActivity.GridControl = Me.gcJobActivity
        Me.gvJobActivity.Name = "gvJobActivity"
        Me.gvJobActivity.OptionsBehavior.FocusLeaveOnTab = True
        Me.gvJobActivity.OptionsSelection.MultiSelect = True
        Me.gvJobActivity.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'colEndDate
        '
        Me.colEndDate.FieldName = "EndDate"
        Me.colEndDate.Name = "colEndDate"
        Me.colEndDate.Visible = True
        Me.colEndDate.VisibleIndex = 3
        '
        'colHours
        '
        Me.colHours.FieldName = "Hours"
        Me.colHours.Name = "colHours"
        Me.colHours.Visible = True
        Me.colHours.VisibleIndex = 1
        '
        'colStartDate
        '
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 2
        '
        'colValue
        '
        Me.colValue.DisplayFormat.FormatString = "c"
        Me.colValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValue.FieldName = "Value"
        Me.colValue.GroupFormat.FormatString = "c"
        Me.colValue.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValue.Name = "colValue"
        Me.colValue.Visible = True
        Me.colValue.VisibleIndex = 4
        '
        'colArtisan
        '
        Me.colArtisan.FieldName = "Artisan"
        Me.colArtisan.Name = "colArtisan"
        '
        'colJob
        '
        Me.colJob.FieldName = "Job"
        Me.colJob.Name = "colJob"
        '
        'colMachine
        '
        Me.colMachine.FieldName = "Machine"
        Me.colMachine.Name = "colMachine"
        '
        'colOperation_
        '
        Me.colOperation_.Caption = "Work Centre"
        Me.colOperation_.ColumnEdit = Me.rilkpOperation
        Me.colOperation_.FieldName = "Operation_"
        Me.colOperation_.Name = "colOperation_"
        Me.colOperation_.Visible = True
        Me.colOperation_.VisibleIndex = 0
        '
        'rilkpOperation
        '
        Me.rilkpOperation.AutoHeight = False
        Me.rilkpOperation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilkpOperation.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rate", "Rate", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsBuyOut", "Is Buy Out", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rilkpOperation.DataSource = Me.OperationBindingSource
        Me.rilkpOperation.DisplayMember = "Description"
        Me.rilkpOperation.Name = "rilkpOperation"
        '
        'OperationBindingSource
        '
        Me.OperationBindingSource.DataSource = GetType(JobCardDataCapturing.API.Operation_)
        '
        'colPart
        '
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'EstimatedDate
        '
        Me.EstimatedDate.AutoHeight = False
        Me.EstimatedDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EstimatedDate.Name = "EstimatedDate"
        Me.EstimatedDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'ActualStartDate
        '
        Me.ActualStartDate.AutoHeight = False
        Me.ActualStartDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActualStartDate.Name = "ActualStartDate"
        Me.ActualStartDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'E
        '
        Me.E.AutoHeight = False
        Me.E.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.E.Name = "E"
        Me.E.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'EstimatedDuration
        '
        Me.EstimatedDuration.AutoHeight = False
        Me.EstimatedDuration.Name = "EstimatedDuration"
        '
        'ActualDuration
        '
        Me.ActualDuration.AutoHeight = False
        Me.ActualDuration.Name = "ActualDuration"
        '
        'EstimatedActualDuration
        '
        Me.EstimatedActualDuration.AutoHeight = False
        Me.EstimatedActualDuration.Name = "EstimatedActualDuration"
        '
        'luPart
        '
        Me.luPart.AutoHeight = False
        Me.luPart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luPart.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luPart.DisplayMember = "Description"
        Me.luPart.Name = "luPart"
        '
        'luOperation
        '
        Me.luOperation.AutoHeight = False
        Me.luOperation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luOperation.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luOperation.DisplayMember = "Description"
        Me.luOperation.Name = "luOperation"
        '
        'luMachine
        '
        Me.luMachine.AutoHeight = False
        Me.luMachine.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luMachine.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luMachine.DisplayMember = "Description"
        Me.luMachine.Name = "luMachine"
        '
        'luJob
        '
        Me.luJob.AutoHeight = False
        Me.luJob.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luJob.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luJob.DisplayMember = "Description"
        Me.luJob.Name = "luJob"
        '
        'luArtisan
        '
        Me.luArtisan.AutoHeight = False
        Me.luArtisan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luArtisan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luArtisan.DisplayMember = "Description"
        Me.luArtisan.Name = "luArtisan"
        '
        'txtValue
        '
        Me.txtValue.AutoHeight = False
        Me.txtValue.Name = "txtValue"
        '
        'txtID
        '
        Me.txtID.AutoHeight = False
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        '
        'luCustomer
        '
        Me.luCustomer.AutoHeight = False
        Me.luCustomer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luCustomer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luCustomer.DataSource = Me.CustomerBindingSource
        Me.luCustomer.DisplayMember = "Description"
        Me.luCustomer.Name = "luCustomer"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(JobCardDataCapturing.API.Customer)
        '
        'txtDescription
        '
        Me.txtDescription.AutoHeight = False
        Me.txtDescription.Name = "txtDescription"
        '
        'dtJobOpened
        '
        Me.dtJobOpened.AutoHeight = False
        Me.dtJobOpened.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtJobOpened.Name = "dtJobOpened"
        Me.dtJobOpened.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'dtExpectedDelivery
        '
        Me.dtExpectedDelivery.AutoHeight = False
        Me.dtExpectedDelivery.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtExpectedDelivery.Name = "dtExpectedDelivery"
        Me.dtExpectedDelivery.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'txtLabourCost
        '
        Me.txtLabourCost.AutoHeight = False
        Me.txtLabourCost.DisplayFormat.FormatString = "{0:c2}"
        Me.txtLabourCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLabourCost.EditFormat.FormatString = "{0:c2}"
        Me.txtLabourCost.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLabourCost.Name = "txtLabourCost"
        '
        'txtMaterialCost
        '
        Me.txtMaterialCost.AutoHeight = False
        Me.txtMaterialCost.DisplayFormat.FormatString = "{0:c2}"
        Me.txtMaterialCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMaterialCost.EditFormat.FormatString = "{0:c2}"
        Me.txtMaterialCost.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMaterialCost.Name = "txtMaterialCost"
        '
        'txtOrderPrice
        '
        Me.txtOrderPrice.AutoHeight = False
        Me.txtOrderPrice.DisplayFormat.FormatString = "{0:c2}"
        Me.txtOrderPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOrderPrice.EditFormat.FormatString = "{0:c2}"
        Me.txtOrderPrice.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOrderPrice.Name = "txtOrderPrice"
        '
        'txtProfitLeftOver
        '
        Me.txtProfitLeftOver.AutoHeight = False
        Me.txtProfitLeftOver.DisplayFormat.FormatString = "{0:c2}"
        Me.txtProfitLeftOver.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtProfitLeftOver.EditFormat.FormatString = "{0:c2}"
        Me.txtProfitLeftOver.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtProfitLeftOver.Name = "txtProfitLeftOver"
        '
        'txtHours
        '
        Me.txtHours.AutoHeight = False
        Me.txtHours.Name = "txtHours"
        '
        'OrderPriceTextEdit
        '
        Me.OrderPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OrderPrice", True))
        Me.OrderPriceTextEdit.Location = New System.Drawing.Point(563, 5)
        Me.OrderPriceTextEdit.Name = "OrderPriceTextEdit"
        Me.OrderPriceTextEdit.Properties.DisplayFormat.FormatString = "{0:c2}"
        Me.OrderPriceTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OrderPriceTextEdit.Properties.EditFormat.FormatString = "{0:c2}"
        Me.OrderPriceTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OrderPriceTextEdit.Size = New System.Drawing.Size(313, 20)
        Me.OrderPriceTextEdit.StyleController = Me.DataLayoutControl1
        Me.OrderPriceTextEdit.TabIndex = 8
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(123, 5)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Properties.ReadOnly = True
        Me.IDTextEdit.Size = New System.Drawing.Size(307, 20)
        Me.IDTextEdit.StyleController = Me.DataLayoutControl1
        Me.IDTextEdit.TabIndex = 13
        '
        'dtStartDate
        '
        Me.dtStartDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "StartDate", True))
        Me.dtStartDate.EditValue = Nothing
        Me.dtStartDate.Location = New System.Drawing.Point(123, 35)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtStartDate.Properties.Mask.EditMask = ""
        Me.dtStartDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtStartDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtStartDate.Size = New System.Drawing.Size(312, 20)
        Me.dtStartDate.StyleController = Me.DataLayoutControl1
        Me.dtStartDate.TabIndex = 9
        '
        'dtEndDate
        '
        Me.dtEndDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EndDate", True))
        Me.dtEndDate.EditValue = Nothing
        Me.dtEndDate.Location = New System.Drawing.Point(123, 65)
        Me.dtEndDate.Name = "dtEndDate"
        Me.dtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEndDate.Properties.Mask.EditMask = ""
        Me.dtEndDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtEndDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtEndDate.Size = New System.Drawing.Size(312, 20)
        Me.dtEndDate.StyleController = Me.DataLayoutControl1
        Me.dtEndDate.TabIndex = 10
        '
        'UssActivitiesTextEdit
        '
        Me.UssActivitiesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UssActivities", True))
        Me.UssActivitiesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UssActivitiesTextEdit.Name = "UssActivitiesTextEdit"
        Me.UssActivitiesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UssActivitiesTextEdit.StyleController = Me.DataLayoutControl1
        Me.UssActivitiesTextEdit.TabIndex = 23
        '
        'IsLoadingCheckEdit
        '
        Me.IsLoadingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsLoading", True))
        Me.IsLoadingCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsLoadingCheckEdit.Name = "IsLoadingCheckEdit"
        Me.IsLoadingCheckEdit.Properties.Caption = "Is Loading"
        Me.IsLoadingCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsLoadingCheckEdit.StyleController = Me.DataLayoutControl1
        Me.IsLoadingCheckEdit.TabIndex = 25
        '
        'IsChangedCheckEdit
        '
        Me.IsChangedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsChanged", True))
        Me.IsChangedCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsChangedCheckEdit.Name = "IsChangedCheckEdit"
        Me.IsChangedCheckEdit.Properties.Caption = "Is Changed"
        Me.IsChangedCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsChangedCheckEdit.StyleController = Me.DataLayoutControl1
        Me.IsChangedCheckEdit.TabIndex = 26
        '
        'ValidationErrorMessagesTextEdit
        '
        Me.ValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidationErrorMessages", True))
        Me.ValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ValidationErrorMessagesTextEdit.Name = "ValidationErrorMessagesTextEdit"
        Me.ValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ValidationErrorMessagesTextEdit.StyleController = Me.DataLayoutControl1
        Me.ValidationErrorMessagesTextEdit.TabIndex = 27
        '
        'PropertiesValidationErrorMessagesTextEdit
        '
        Me.PropertiesValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PropertiesValidationErrorMessages", True))
        Me.PropertiesValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesValidationErrorMessagesTextEdit.Name = "PropertiesValidationErrorMessagesTextEdit"
        Me.PropertiesValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.PropertiesValidationErrorMessagesTextEdit.StyleController = Me.DataLayoutControl1
        Me.PropertiesValidationErrorMessagesTextEdit.TabIndex = 28
        '
        'ExpectedDevlieryDateDateEdit
        '
        Me.ExpectedDevlieryDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ExpectedDevlieryDate", True))
        Me.ExpectedDevlieryDateDateEdit.EditValue = Nothing
        Me.ExpectedDevlieryDateDateEdit.Location = New System.Drawing.Point(123, 95)
        Me.ExpectedDevlieryDateDateEdit.Name = "ExpectedDevlieryDateDateEdit"
        Me.ExpectedDevlieryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExpectedDevlieryDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ExpectedDevlieryDateDateEdit.Size = New System.Drawing.Size(312, 20)
        Me.ExpectedDevlieryDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.ExpectedDevlieryDateDateEdit.TabIndex = 29
        '
        'ProfitOrLeftOverTextEdit
        '
        Me.ProfitOrLeftOverTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ProfitOrLeftOver", True))
        Me.ProfitOrLeftOverTextEdit.Location = New System.Drawing.Point(563, 95)
        Me.ProfitOrLeftOverTextEdit.Name = "ProfitOrLeftOverTextEdit"
        Me.ProfitOrLeftOverTextEdit.Properties.DisplayFormat.FormatString = "{0:c2}"
        Me.ProfitOrLeftOverTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ProfitOrLeftOverTextEdit.Properties.EditFormat.FormatString = "{0:c2}"
        Me.ProfitOrLeftOverTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ProfitOrLeftOverTextEdit.Size = New System.Drawing.Size(313, 20)
        Me.ProfitOrLeftOverTextEdit.StyleController = Me.DataLayoutControl1
        Me.ProfitOrLeftOverTextEdit.TabIndex = 30
        '
        'LabourCostTextEdit
        '
        Me.LabourCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "LabourCost", True))
        Me.LabourCostTextEdit.Location = New System.Drawing.Point(563, 35)
        Me.LabourCostTextEdit.Name = "LabourCostTextEdit"
        Me.LabourCostTextEdit.Properties.DisplayFormat.FormatString = "{0:c2}"
        Me.LabourCostTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LabourCostTextEdit.Properties.EditFormat.FormatString = "{0:c2}"
        Me.LabourCostTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LabourCostTextEdit.Size = New System.Drawing.Size(313, 20)
        Me.LabourCostTextEdit.StyleController = Me.DataLayoutControl1
        Me.LabourCostTextEdit.TabIndex = 31
        '
        'MaterialCostTextEdit
        '
        Me.MaterialCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "MaterialCost", True))
        Me.MaterialCostTextEdit.Location = New System.Drawing.Point(563, 65)
        Me.MaterialCostTextEdit.Name = "MaterialCostTextEdit"
        Me.MaterialCostTextEdit.Properties.DisplayFormat.FormatString = "{0:c2}"
        Me.MaterialCostTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MaterialCostTextEdit.Properties.EditFormat.FormatString = "{0:c2}"
        Me.MaterialCostTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MaterialCostTextEdit.Size = New System.Drawing.Size(313, 20)
        Me.MaterialCostTextEdit.StyleController = Me.DataLayoutControl1
        Me.MaterialCostTextEdit.TabIndex = 32
        '
        'CustomerLookUpEdit
        '
        Me.CustomerLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Customer", True))
        Me.CustomerLookUpEdit.Location = New System.Drawing.Point(123, 5)
        Me.CustomerLookUpEdit.Name = "CustomerLookUpEdit"
        Me.CustomerLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustomerLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CustomerLookUpEdit.Properties.DataSource = Me.CustomerBindingSource
        Me.CustomerLookUpEdit.Properties.DisplayMember = "Description"
        Me.CustomerLookUpEdit.Size = New System.Drawing.Size(312, 20)
        Me.CustomerLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.CustomerLookUpEdit.TabIndex = 33
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
        'ItemForID
        '
        Me.ItemForID.Control = Me.IDTextEdit
        Me.ItemForID.CustomizationFormText = "ID"
        Me.ItemForID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForID.Name = "ItemForID"
        Me.ItemForID.Size = New System.Drawing.Size(435, 30)
        Me.ItemForID.Text = "ID"
        Me.ItemForID.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForID.TextToControlDistance = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(881, 372)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForStartDate, Me.LayoutControlItem1, Me.ItemForEndDate, Me.ItemForCustomer, Me.ItemForExpectedDevlieryDate, Me.ItemForLabourCost, Me.ItemForProfitOrLeftOver, Me.ItemForOrderPrice, Me.ItemForMaterialCost})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(881, 337)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForStartDate
        '
        Me.ItemForStartDate.Control = Me.dtStartDate
        Me.ItemForStartDate.CustomizationFormText = "Start Date"
        Me.ItemForStartDate.Location = New System.Drawing.Point(0, 30)
        Me.ItemForStartDate.Name = "ItemForStartDate"
        Me.ItemForStartDate.Size = New System.Drawing.Size(440, 30)
        Me.ItemForStartDate.Text = "Start Date"
        Me.ItemForStartDate.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForStartDate.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gcJobActivity
        Me.LayoutControlItem1.CustomizationFormText = "Job Details"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(881, 217)
        Me.LayoutControlItem1.Text = "Job Details"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(113, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'ItemForEndDate
        '
        Me.ItemForEndDate.Control = Me.dtEndDate
        Me.ItemForEndDate.CustomizationFormText = "End Date"
        Me.ItemForEndDate.Location = New System.Drawing.Point(0, 60)
        Me.ItemForEndDate.Name = "ItemForEndDate"
        Me.ItemForEndDate.Size = New System.Drawing.Size(440, 30)
        Me.ItemForEndDate.Text = "End Date"
        Me.ItemForEndDate.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForEndDate.TextToControlDistance = 5
        '
        'ItemForCustomer
        '
        Me.ItemForCustomer.Control = Me.CustomerLookUpEdit
        Me.ItemForCustomer.CustomizationFormText = "Customer"
        Me.ItemForCustomer.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCustomer.Name = "ItemForCustomer"
        Me.ItemForCustomer.Size = New System.Drawing.Size(440, 30)
        Me.ItemForCustomer.Text = "Customer"
        Me.ItemForCustomer.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForCustomer.TextToControlDistance = 5
        '
        'ItemForExpectedDevlieryDate
        '
        Me.ItemForExpectedDevlieryDate.Control = Me.ExpectedDevlieryDateDateEdit
        Me.ItemForExpectedDevlieryDate.CustomizationFormText = "Expected Devliery Date"
        Me.ItemForExpectedDevlieryDate.Location = New System.Drawing.Point(0, 90)
        Me.ItemForExpectedDevlieryDate.Name = "ItemForExpectedDevlieryDate"
        Me.ItemForExpectedDevlieryDate.Size = New System.Drawing.Size(440, 30)
        Me.ItemForExpectedDevlieryDate.Text = "Expected Devliery Date"
        Me.ItemForExpectedDevlieryDate.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForExpectedDevlieryDate.TextToControlDistance = 5
        '
        'ItemForLabourCost
        '
        Me.ItemForLabourCost.Control = Me.LabourCostTextEdit
        Me.ItemForLabourCost.CustomizationFormText = "Labour Cost"
        Me.ItemForLabourCost.Location = New System.Drawing.Point(440, 30)
        Me.ItemForLabourCost.Name = "ItemForLabourCost"
        Me.ItemForLabourCost.Size = New System.Drawing.Size(441, 30)
        Me.ItemForLabourCost.Text = "Labour Cost"
        Me.ItemForLabourCost.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForLabourCost.TextToControlDistance = 5
        '
        'ItemForProfitOrLeftOver
        '
        Me.ItemForProfitOrLeftOver.Control = Me.ProfitOrLeftOverTextEdit
        Me.ItemForProfitOrLeftOver.CustomizationFormText = "Profit Or Left Over"
        Me.ItemForProfitOrLeftOver.Location = New System.Drawing.Point(440, 90)
        Me.ItemForProfitOrLeftOver.Name = "ItemForProfitOrLeftOver"
        Me.ItemForProfitOrLeftOver.Size = New System.Drawing.Size(441, 30)
        Me.ItemForProfitOrLeftOver.Text = "Profit Or Left Over"
        Me.ItemForProfitOrLeftOver.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForProfitOrLeftOver.TextToControlDistance = 5
        '
        'ItemForOrderPrice
        '
        Me.ItemForOrderPrice.Control = Me.OrderPriceTextEdit
        Me.ItemForOrderPrice.CustomizationFormText = "Order Price"
        Me.ItemForOrderPrice.Location = New System.Drawing.Point(440, 0)
        Me.ItemForOrderPrice.Name = "ItemForOrderPrice"
        Me.ItemForOrderPrice.Size = New System.Drawing.Size(441, 30)
        Me.ItemForOrderPrice.Text = "Order Price"
        Me.ItemForOrderPrice.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForOrderPrice.TextToControlDistance = 5
        '
        'ItemForMaterialCost
        '
        Me.ItemForMaterialCost.Control = Me.MaterialCostTextEdit
        Me.ItemForMaterialCost.CustomizationFormText = "Material Cost"
        Me.ItemForMaterialCost.Location = New System.Drawing.Point(440, 60)
        Me.ItemForMaterialCost.Name = "ItemForMaterialCost"
        Me.ItemForMaterialCost.Size = New System.Drawing.Size(441, 30)
        Me.ItemForMaterialCost.Text = "Material Cost"
        Me.ItemForMaterialCost.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForMaterialCost.TextToControlDistance = 5
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AllowDrawBackground = False
        Me.LayoutControlGroup3.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 337)
        Me.LayoutControlGroup3.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup3.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(881, 35)
        Me.LayoutControlGroup3.Text = "autoGeneratedGroup0"
        '
        'xaeViewJobActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 450)
        Me.Name = "xaeViewJobActivity"
        Me.Text = "Job Activities"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.gcJobActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilkpOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualStartDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.E.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.E, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedActualDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtJobOpened.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtJobOpened, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtExpectedDelivery.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtExpectedDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLabourCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProfitLeftOver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UssActivitiesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedDevlieryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedDevlieryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfitOrLeftOverTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabourCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUssActivities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForExpectedDevlieryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForLabourCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForProfitOrLeftOver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMaterialCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents OrderPriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForOrderPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gcJobActivity As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobActivity As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtID As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtValue As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents luArtisan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luJob As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luMachine As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luOperation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luPart As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents EstimatedDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ActualStartDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents EstimatedDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ActualDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents EstimatedActualDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents E As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents luCustomer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents dtJobOpened As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtExpectedDelivery As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtLabourCost As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMaterialCost As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtOrderPrice As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtProfitLeftOver As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents UssActivitiesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsLoadingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsChangedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PropertiesValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForUssActivities As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCustomer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsLoading As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsChanged As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPropertiesValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForExpectedDevlieryDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ExpectedDevlieryDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ProfitOrLeftOverTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabourCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MaterialCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ItemForLabourCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForProfitOrLeftOver As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMaterialCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents JobActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtHours As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArtisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperation_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilkpOperation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OperationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
End Class
