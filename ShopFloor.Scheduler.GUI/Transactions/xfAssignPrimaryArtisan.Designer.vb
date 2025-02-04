<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfAssignPrimaryArtisan
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtJobNumber = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.gvAssignJob = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCustomerCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCustomerDescr = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArtisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riglkpArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ArtisanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ripbArtisanEstimatedDuration = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colArtisanCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArtisanDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedTimespam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArtisanEstimatedDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterials = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkMaterials = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colEstimatedDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtEstDelDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEstimatedEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtEstEndDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEstimatedStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtEstStartDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colActualEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtActualEndDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colActualStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtActualStartDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colDrawing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btDrawing = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colJobCard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtJobCard = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colJobDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtJobDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colLastActivity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtLastActivity = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colOrderPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtOrderPrice = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTotalCost = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrimaryOperationHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAssignJob = New DevExpress.XtraGrid.GridControl()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.luArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ActivitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lcAssignJob = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.beiAutoRefreshRate = New DevExpress.XtraBars.BarEditItem()
        Me.ritAutoRefreshRate = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.tmRefresh = New System.Windows.Forms.Timer(Me.components)
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAssignJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerDescr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riglkpArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ripbArtisanEstimatedDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstDelDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstDelDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstEndDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstStartDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtActualEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtActualEndDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtActualStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtActualStartDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtJobDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtJobDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAssignJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcAssignJob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lcAssignJob.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ritAutoRefreshRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Customer)
        '
        'MachineBindingSource
        '
        Me.MachineBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Machine)
        '
        'OperationBindingSource
        '
        Me.OperationBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Operation)
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Part)
        '
        'txtJobNumber
        '
        Me.txtJobNumber.AutoHeight = False
        Me.txtJobNumber.Name = "txtJobNumber"
        Me.txtJobNumber.ReadOnly = True
        '
        'txtDescription
        '
        Me.txtDescription.AutoHeight = False
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        '
        'gvAssignJob
        '
        Me.gvAssignJob.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescription, Me.colCustomerCode, Me.colCustomer, Me.colNumber, Me.colRequiredDeliveryDate, Me.colArtisan, Me.colMaterials, Me.colEstimatedDeliveryDate, Me.colEstimatedEndDate, Me.colEstimatedStartDate, Me.colActualEndDate, Me.colActualStartDate, Me.colDrawing, Me.colJobCard, Me.colJobDate, Me.colLastActivity, Me.colOrderPrice, Me.colTotalCost, Me.colPrimaryOperationHours})
        Me.gvAssignJob.GridControl = Me.gcAssignJob
        Me.gvAssignJob.Name = "gvAssignJob"
        Me.gvAssignJob.OptionsView.ShowFooter = True
        '
        'colDescription
        '
        Me.colDescription.ColumnEdit = Me.txtDescription
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 117
        '
        'colCustomerCode
        '
        Me.colCustomerCode.Caption = "Customer Code"
        Me.colCustomerCode.ColumnEdit = Me.txtCustomerCode
        Me.colCustomerCode.FieldName = "Customer.Code"
        Me.colCustomerCode.Name = "colCustomerCode"
        Me.colCustomerCode.Visible = True
        Me.colCustomerCode.VisibleIndex = 2
        Me.colCustomerCode.Width = 159
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.AutoHeight = False
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.ReadOnly = True
        '
        'colCustomer
        '
        Me.colCustomer.Caption = "Customer"
        Me.colCustomer.ColumnEdit = Me.txtCustomerDescr
        Me.colCustomer.FieldName = "Customer.Description"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 3
        Me.colCustomer.Width = 100
        '
        'txtCustomerDescr
        '
        Me.txtCustomerDescr.AutoHeight = False
        Me.txtCustomerDescr.Name = "txtCustomerDescr"
        Me.txtCustomerDescr.ReadOnly = True
        '
        'colNumber
        '
        Me.colNumber.ColumnEdit = Me.txtJobNumber
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 0
        Me.colNumber.Width = 89
        '
        'colRequiredDeliveryDate
        '
        Me.colRequiredDeliveryDate.DisplayFormat.FormatString = "d"
        Me.colRequiredDeliveryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colRequiredDeliveryDate.FieldName = "RequiredDeliveryDate"
        Me.colRequiredDeliveryDate.Name = "colRequiredDeliveryDate"
        Me.colRequiredDeliveryDate.Visible = True
        Me.colRequiredDeliveryDate.VisibleIndex = 4
        Me.colRequiredDeliveryDate.Width = 139
        '
        'colArtisan
        '
        Me.colArtisan.Caption = "Primary Artisan"
        Me.colArtisan.ColumnEdit = Me.riglkpArtisan
        Me.colArtisan.FieldName = "PrimaryArtisan"
        Me.colArtisan.Name = "colArtisan"
        Me.colArtisan.Visible = True
        Me.colArtisan.VisibleIndex = 5
        Me.colArtisan.Width = 163
        '
        'riglkpArtisan
        '
        Me.riglkpArtisan.AutoHeight = False
        Me.riglkpArtisan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.riglkpArtisan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riglkpArtisan.DataSource = Me.ArtisanBindingSource
        Me.riglkpArtisan.DisplayMember = "Description"
        Me.riglkpArtisan.Name = "riglkpArtisan"
        Me.riglkpArtisan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ripbArtisanEstimatedDuration})
        Me.riglkpArtisan.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'ArtisanBindingSource
        '
        Me.ArtisanBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Artisan)
        '
        'ripbArtisanEstimatedDuration
        '
        Me.ripbArtisanEstimatedDuration.Name = "ripbArtisanEstimatedDuration"
        Me.ripbArtisanEstimatedDuration.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.ripbArtisanEstimatedDuration.Step = 1
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colArtisanCode, Me.colArtisanDescription, Me.colEstimatedTimespam, Me.colArtisanEstimatedDuration})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colArtisanCode
        '
        Me.colArtisanCode.FieldName = "Code"
        Me.colArtisanCode.Name = "colArtisanCode"
        Me.colArtisanCode.Visible = True
        Me.colArtisanCode.VisibleIndex = 0
        '
        'colArtisanDescription
        '
        Me.colArtisanDescription.FieldName = "Description"
        Me.colArtisanDescription.Name = "colArtisanDescription"
        Me.colArtisanDescription.Visible = True
        Me.colArtisanDescription.VisibleIndex = 1
        '
        'colEstimatedTimespam
        '
        Me.colEstimatedTimespam.FieldName = "EstimatedTimespam"
        Me.colEstimatedTimespam.Name = "colEstimatedTimespam"
        Me.colEstimatedTimespam.Visible = True
        Me.colEstimatedTimespam.VisibleIndex = 2
        '
        'colArtisanEstimatedDuration
        '
        Me.colArtisanEstimatedDuration.ColumnEdit = Me.ripbArtisanEstimatedDuration
        Me.colArtisanEstimatedDuration.FieldName = "EstimatedDuration"
        Me.colArtisanEstimatedDuration.Name = "colArtisanEstimatedDuration"
        Me.colArtisanEstimatedDuration.Visible = True
        Me.colArtisanEstimatedDuration.VisibleIndex = 3
        '
        'colMaterials
        '
        Me.colMaterials.ColumnEdit = Me.chkMaterials
        Me.colMaterials.FieldName = "IsMaterialAvailable"
        Me.colMaterials.Name = "colMaterials"
        Me.colMaterials.Visible = True
        Me.colMaterials.VisibleIndex = 7
        Me.colMaterials.Width = 141
        '
        'chkMaterials
        '
        Me.chkMaterials.AutoHeight = False
        Me.chkMaterials.Name = "chkMaterials"
        Me.chkMaterials.ReadOnly = True
        '
        'colEstimatedDeliveryDate
        '
        Me.colEstimatedDeliveryDate.ColumnEdit = Me.dtEstDelDate
        Me.colEstimatedDeliveryDate.DisplayFormat.FormatString = "g"
        Me.colEstimatedDeliveryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedDeliveryDate.FieldName = "EstimatedDeliveryDate"
        Me.colEstimatedDeliveryDate.Name = "colEstimatedDeliveryDate"
        Me.colEstimatedDeliveryDate.Width = 36
        '
        'dtEstDelDate
        '
        Me.dtEstDelDate.AutoHeight = False
        Me.dtEstDelDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEstDelDate.Name = "dtEstDelDate"
        Me.dtEstDelDate.ReadOnly = True
        Me.dtEstDelDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colEstimatedEndDate
        '
        Me.colEstimatedEndDate.ColumnEdit = Me.dtEstEndDate
        Me.colEstimatedEndDate.DisplayFormat.FormatString = "g"
        Me.colEstimatedEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedEndDate.FieldName = "EstimatedEndDate"
        Me.colEstimatedEndDate.Name = "colEstimatedEndDate"
        Me.colEstimatedEndDate.Width = 36
        '
        'dtEstEndDate
        '
        Me.dtEstEndDate.AutoHeight = False
        Me.dtEstEndDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEstEndDate.Name = "dtEstEndDate"
        Me.dtEstEndDate.ReadOnly = True
        Me.dtEstEndDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colEstimatedStartDate
        '
        Me.colEstimatedStartDate.ColumnEdit = Me.dtEstStartDate
        Me.colEstimatedStartDate.DisplayFormat.FormatString = "g"
        Me.colEstimatedStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedStartDate.FieldName = "EstimatedStartDate"
        Me.colEstimatedStartDate.Name = "colEstimatedStartDate"
        Me.colEstimatedStartDate.Visible = True
        Me.colEstimatedStartDate.VisibleIndex = 9
        Me.colEstimatedStartDate.Width = 67
        '
        'dtEstStartDate
        '
        Me.dtEstStartDate.AutoHeight = False
        Me.dtEstStartDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEstStartDate.Name = "dtEstStartDate"
        Me.dtEstStartDate.ReadOnly = True
        Me.dtEstStartDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colActualEndDate
        '
        Me.colActualEndDate.ColumnEdit = Me.dtActualEndDate
        Me.colActualEndDate.DisplayFormat.FormatString = "g"
        Me.colActualEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualEndDate.FieldName = "ActualEndDate"
        Me.colActualEndDate.Name = "colActualEndDate"
        Me.colActualEndDate.Width = 36
        '
        'dtActualEndDate
        '
        Me.dtActualEndDate.AutoHeight = False
        Me.dtActualEndDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtActualEndDate.Name = "dtActualEndDate"
        Me.dtActualEndDate.ReadOnly = True
        Me.dtActualEndDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colActualStartDate
        '
        Me.colActualStartDate.ColumnEdit = Me.dtActualStartDate
        Me.colActualStartDate.DisplayFormat.FormatString = "g"
        Me.colActualStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualStartDate.FieldName = "ActualStartDate"
        Me.colActualStartDate.Name = "colActualStartDate"
        Me.colActualStartDate.Visible = True
        Me.colActualStartDate.VisibleIndex = 8
        Me.colActualStartDate.Width = 67
        '
        'dtActualStartDate
        '
        Me.dtActualStartDate.AutoHeight = False
        Me.dtActualStartDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtActualStartDate.Name = "dtActualStartDate"
        Me.dtActualStartDate.ReadOnly = True
        Me.dtActualStartDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colDrawing
        '
        Me.colDrawing.ColumnEdit = Me.btDrawing
        Me.colDrawing.FieldName = "Drawing"
        Me.colDrawing.Name = "colDrawing"
        Me.colDrawing.Visible = True
        Me.colDrawing.VisibleIndex = 10
        Me.colDrawing.Width = 73
        '
        'btDrawing
        '
        Me.btDrawing.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btDrawing.Name = "btDrawing"
        Me.btDrawing.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colJobCard
        '
        Me.colJobCard.ColumnEdit = Me.txtJobCard
        Me.colJobCard.FieldName = "JobCard"
        Me.colJobCard.Name = "colJobCard"
        Me.colJobCard.Width = 36
        '
        'txtJobCard
        '
        Me.txtJobCard.AutoHeight = False
        Me.txtJobCard.Name = "txtJobCard"
        Me.txtJobCard.ReadOnly = True
        '
        'colJobDate
        '
        Me.colJobDate.ColumnEdit = Me.dtJobDate
        Me.colJobDate.DisplayFormat.FormatString = "g"
        Me.colJobDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colJobDate.FieldName = "JobDate"
        Me.colJobDate.Name = "colJobDate"
        Me.colJobDate.Width = 36
        '
        'dtJobDate
        '
        Me.dtJobDate.AutoHeight = False
        Me.dtJobDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtJobDate.Name = "dtJobDate"
        Me.dtJobDate.ReadOnly = True
        Me.dtJobDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colLastActivity
        '
        Me.colLastActivity.ColumnEdit = Me.txtLastActivity
        Me.colLastActivity.FieldName = "LastActivity"
        Me.colLastActivity.Name = "colLastActivity"
        Me.colLastActivity.Width = 36
        '
        'txtLastActivity
        '
        Me.txtLastActivity.AutoHeight = False
        Me.txtLastActivity.Name = "txtLastActivity"
        Me.txtLastActivity.ReadOnly = True
        '
        'colOrderPrice
        '
        Me.colOrderPrice.ColumnEdit = Me.txtOrderPrice
        Me.colOrderPrice.DisplayFormat.FormatString = "{0:c2}"
        Me.colOrderPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOrderPrice.FieldName = "OrderPrice"
        Me.colOrderPrice.Name = "colOrderPrice"
        Me.colOrderPrice.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colOrderPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colOrderPrice.Width = 36
        '
        'txtOrderPrice
        '
        Me.txtOrderPrice.AutoHeight = False
        Me.txtOrderPrice.Name = "txtOrderPrice"
        Me.txtOrderPrice.ReadOnly = True
        '
        'colTotalCost
        '
        Me.colTotalCost.ColumnEdit = Me.txtTotalCost
        Me.colTotalCost.DisplayFormat.FormatString = "{0:c2}"
        Me.colTotalCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colTotalCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotalCost.Width = 36
        '
        'txtTotalCost
        '
        Me.txtTotalCost.AutoHeight = False
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        '
        'colPrimaryOperationHours
        '
        Me.colPrimaryOperationHours.FieldName = "PrimaryOperationHours"
        Me.colPrimaryOperationHours.Name = "colPrimaryOperationHours"
        Me.colPrimaryOperationHours.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colPrimaryOperationHours.Visible = True
        Me.colPrimaryOperationHours.VisibleIndex = 6
        Me.colPrimaryOperationHours.Width = 133
        '
        'gcAssignJob
        '
        Me.gcAssignJob.DataSource = Me.JobBindingSource
        Me.gcAssignJob.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcAssignJob.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcAssignJob.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcAssignJob.Location = New System.Drawing.Point(5, 5)
        Me.gcAssignJob.MainView = Me.gvAssignJob
        Me.gcAssignJob.Name = "gcAssignJob"
        Me.gcAssignJob.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtJobNumber, Me.txtDescription, Me.luArtisan, Me.chkMaterials, Me.btDrawing, Me.txtCustomerCode, Me.txtCustomerDescr, Me.dtActualStartDate, Me.dtEstStartDate, Me.dtEstDelDate, Me.dtEstEndDate, Me.dtActualEndDate, Me.txtJobCard, Me.dtJobDate, Me.txtLastActivity, Me.txtOrderPrice, Me.txtTotalCost, Me.riglkpArtisan})
        Me.gcAssignJob.ShowOnlyPredefinedDetails = True
        Me.gcAssignJob.Size = New System.Drawing.Size(1266, 592)
        Me.gcAssignJob.TabIndex = 4
        Me.gcAssignJob.UseEmbeddedNavigator = True
        Me.gcAssignJob.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAssignJob})
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Job)
        '
        'luArtisan
        '
        Me.luArtisan.AutoHeight = False
        Me.luArtisan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luArtisan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstimatedDuration", "Estimated Duration", 101, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luArtisan.DataSource = Me.ArtisanBindingSource
        Me.luArtisan.DisplayMember = "Description"
        Me.luArtisan.Name = "luArtisan"
        Me.luArtisan.NullText = "[Select Artisanl]"
        '
        'ActivitiesBindingSource
        '
        Me.ActivitiesBindingSource.DataMember = "ActivityList"
        Me.ActivitiesBindingSource.DataSource = Me.JobBindingSource
        '
        'lcAssignJob
        '
        Me.lcAssignJob.Controls.Add(Me.gcAssignJob)
        Me.lcAssignJob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lcAssignJob.Location = New System.Drawing.Point(0, 22)
        Me.lcAssignJob.Name = "lcAssignJob"
        Me.lcAssignJob.OptionsView.UseSkinIndents = False
        Me.lcAssignJob.Root = Me.LayoutControlGroup1
        Me.lcAssignJob.Size = New System.Drawing.Size(1276, 602)
        Me.lcAssignJob.TabIndex = 9
        Me.lcAssignJob.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1276, 602)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gcAssignJob
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1276, 602)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.beiAutoRefreshRate, Me.bbiRefresh, Me.bbiCancel})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ritAutoRefreshRate})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(1860, 113)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCancel), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRefresh), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.beiAutoRefreshRate, DevExpress.XtraBars.BarItemPaintStyle.Standard)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'bbiCancel
        '
        Me.bbiCancel.Caption = "&Cancel"
        Me.bbiCancel.Id = 5
        Me.bbiCancel.Name = "bbiCancel"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "Refresh"
        Me.bbiRefresh.Id = 4
        Me.bbiRefresh.Name = "bbiRefresh"
        Me.bbiRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'beiAutoRefreshRate
        '
        Me.beiAutoRefreshRate.Caption = "Auto Re&fresh Rate"
        Me.beiAutoRefreshRate.Edit = Me.ritAutoRefreshRate
        Me.beiAutoRefreshRate.EditValue = "0"
        Me.beiAutoRefreshRate.Id = 3
        Me.beiAutoRefreshRate.Name = "beiAutoRefreshRate"
        Me.beiAutoRefreshRate.Width = 75
        '
        'ritAutoRefreshRate
        '
        Me.ritAutoRefreshRate.AutoHeight = False
        Me.ritAutoRefreshRate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ritAutoRefreshRate.Mask.EditMask = "HH:mm:ss"
        Me.ritAutoRefreshRate.Mask.UseMaskAsDisplayFormat = True
        Me.ritAutoRefreshRate.Name = "ritAutoRefreshRate"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1276, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 624)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1276, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 602)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1276, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 602)
        '
        'tmRefresh
        '
        '
        'xfAssignPrimaryArtisan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 647)
        Me.Controls.Add(Me.lcAssignJob)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfAssignPrimaryArtisan"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Primary Artisan"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAssignJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerDescr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riglkpArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ripbArtisanEstimatedDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstDelDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstDelDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstEndDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstStartDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtActualEndDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtActualEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtActualStartDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtActualStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtJobDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtJobDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAssignJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcAssignJob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lcAssignJob.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ritAutoRefreshRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcAssignJob As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAssignJob As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtJobNumber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents MachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lcAssignJob As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ArtisanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colArtisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luArtisan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colEstimatedDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobCard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActivity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterials As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkMaterials As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ActivitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btDrawing As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents tmRefresh As System.Windows.Forms.Timer
    Friend WithEvents txtCustomerCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCustomerDescr As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents dtEstDelDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtEstEndDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtEstStartDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtActualEndDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtActualStartDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtJobCard As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents dtJobDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtLastActivity As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtOrderPrice As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtTotalCost As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gvAssignNextOperation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEstDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colActualDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCurrentState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCurrentState As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtRequiredDeliveryDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtComments As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colActualArtisanCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualElapsedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualMachineCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualOperationCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedArtisanCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedElapsedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedMachineCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedOperationCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActualsPosted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActualDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents beiAutoRefreshRate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ritAutoRefreshRate As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPrimaryOperationHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riglkpArtisan As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ripbArtisanEstimatedDuration As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colArtisanCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArtisanDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArtisanEstimatedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedTimespam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiCancel As DevExpress.XtraBars.BarButtonItem
End Class
