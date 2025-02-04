<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xucJobActivities
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gvActivityLogList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colArtisan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rileArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ArtisanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colMachine1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rileMachine = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrentState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rileState = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colArtisanCost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineCost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperationCost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcActivities = New DevExpress.XtraGrid.GridControl()
        Me.ActivitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvActivities = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOperation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rileOperation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.OperationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colArtisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilePart = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riseSequence = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colEstimatedStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEstimatedEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArtisanCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperationCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedArtisanCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedMachineCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedOperationCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperationDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArtisanDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCreateJobCard = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiProcessActuals = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiReports = New DevExpress.XtraBars.BarSubItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.JobDataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.EstimatedDeliveryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.NumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.OrderPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TotalCostTextEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.EstimatedEndDateTextEdit = New DevExpress.XtraEditors.DateEdit()
        Me.EstimatedStartDateTextEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ActualStartDateTextEdit = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.RequiredDeliveryDateTextEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.lcgDetails = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCustomer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcgValues = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForOrderPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTotalCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcgDates = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForEstimatedStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActualEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRequiredDeliveryDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedDeliveryDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActualStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciActivities = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.gvActivityLogList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rileArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rileMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rileState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rileOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilePart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseSequence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JobDataLayoutControl.SuspendLayout()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedEndDateTextEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedEndDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedStartDateTextEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualStartDateTextEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequiredDeliveryDateTextEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequiredDeliveryDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgValues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActualEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRequiredDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActualStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvActivityLogList
        '
        Me.gvActivityLogList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colArtisan1, Me.colMachine1, Me.colStartDate, Me.colEndDate, Me.colDuration, Me.colCurrentState, Me.colArtisanCost1, Me.colMachineCost1, Me.colOperationCost1, Me.colLogTime, Me.colID1})
        Me.gvActivityLogList.GridControl = Me.gcActivities
        Me.gvActivityLogList.Name = "gvActivityLogList"
        '
        'colArtisan1
        '
        Me.colArtisan1.ColumnEdit = Me.rileArtisan
        Me.colArtisan1.FieldName = "Artisan"
        Me.colArtisan1.Name = "colArtisan1"
        Me.colArtisan1.Visible = True
        Me.colArtisan1.VisibleIndex = 0
        '
        'rileArtisan
        '
        Me.rileArtisan.AutoHeight = False
        Me.rileArtisan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rileArtisan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rileArtisan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rate", "Rate", 33, DevExpress.Utils.FormatType.Numeric, "c", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rileArtisan.DataSource = Me.ArtisanBindingSource
        Me.rileArtisan.DisplayMember = "Code"
        Me.rileArtisan.Name = "rileArtisan"
        Me.rileArtisan.NullText = "(Select Artisan...)"
        '
        'ArtisanBindingSource
        '
        Me.ArtisanBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Artisan)
        '
        'colMachine1
        '
        Me.colMachine1.ColumnEdit = Me.rileMachine
        Me.colMachine1.FieldName = "Machine"
        Me.colMachine1.Name = "colMachine1"
        Me.colMachine1.Visible = True
        Me.colMachine1.VisibleIndex = 1
        '
        'rileMachine
        '
        Me.rileMachine.AutoHeight = False
        Me.rileMachine.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rileMachine.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rileMachine.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rate", "Rate", 33, DevExpress.Utils.FormatType.Numeric, "c", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rileMachine.DataSource = Me.MachineBindingSource
        Me.rileMachine.DisplayMember = "Code"
        Me.rileMachine.Name = "rileMachine"
        Me.rileMachine.NullText = "(Select Machine...)"
        '
        'MachineBindingSource
        '
        Me.MachineBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Machine)
        '
        'colStartDate
        '
        Me.colStartDate.DisplayFormat.FormatString = "g"
        Me.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.GroupFormat.FormatString = "g"
        Me.colStartDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 2
        '
        'colEndDate
        '
        Me.colEndDate.DisplayFormat.FormatString = "g"
        Me.colEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEndDate.FieldName = "EndDate"
        Me.colEndDate.GroupFormat.FormatString = "g"
        Me.colEndDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEndDate.Name = "colEndDate"
        Me.colEndDate.Visible = True
        Me.colEndDate.VisibleIndex = 3
        '
        'colDuration
        '
        Me.colDuration.DisplayFormat.FormatString = "f"
        Me.colDuration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDuration.FieldName = "Duration"
        Me.colDuration.GroupFormat.FormatString = "f"
        Me.colDuration.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDuration.Name = "colDuration"
        Me.colDuration.Visible = True
        Me.colDuration.VisibleIndex = 4
        '
        'colCurrentState
        '
        Me.colCurrentState.ColumnEdit = Me.rileState
        Me.colCurrentState.FieldName = "CurrentState"
        Me.colCurrentState.Name = "colCurrentState"
        Me.colCurrentState.Visible = True
        Me.colCurrentState.VisibleIndex = 5
        '
        'rileState
        '
        Me.rileState.AutoHeight = False
        Me.rileState.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rileState.Name = "rileState"
        Me.rileState.NullText = "(Select Current State...)"
        '
        'colArtisanCost1
        '
        Me.colArtisanCost1.DisplayFormat.FormatString = "c"
        Me.colArtisanCost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colArtisanCost1.FieldName = "ArtisanCost"
        Me.colArtisanCost1.GroupFormat.FormatString = "c"
        Me.colArtisanCost1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colArtisanCost1.Name = "colArtisanCost1"
        Me.colArtisanCost1.Visible = True
        Me.colArtisanCost1.VisibleIndex = 6
        '
        'colMachineCost1
        '
        Me.colMachineCost1.DisplayFormat.FormatString = "c"
        Me.colMachineCost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMachineCost1.FieldName = "MachineCost"
        Me.colMachineCost1.GroupFormat.FormatString = "c"
        Me.colMachineCost1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMachineCost1.Name = "colMachineCost1"
        Me.colMachineCost1.Visible = True
        Me.colMachineCost1.VisibleIndex = 7
        '
        'colOperationCost1
        '
        Me.colOperationCost1.DisplayFormat.FormatString = "c"
        Me.colOperationCost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOperationCost1.FieldName = "OperationCost"
        Me.colOperationCost1.GroupFormat.FormatString = "c"
        Me.colOperationCost1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOperationCost1.Name = "colOperationCost1"
        Me.colOperationCost1.Visible = True
        Me.colOperationCost1.VisibleIndex = 8
        '
        'colLogTime
        '
        Me.colLogTime.DisplayFormat.FormatString = "g"
        Me.colLogTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLogTime.FieldName = "LogTime"
        Me.colLogTime.GroupFormat.FormatString = "g"
        Me.colLogTime.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLogTime.Name = "colLogTime"
        Me.colLogTime.OptionsColumn.ReadOnly = True
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        Me.colID1.OptionsColumn.ReadOnly = True
        '
        'gcActivities
        '
        Me.gcActivities.DataSource = Me.ActivitiesBindingSource
        GridLevelNode1.LevelTemplate = Me.gvActivityLogList
        GridLevelNode1.RelationName = "ActivityLogList"
        Me.gcActivities.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcActivities.Location = New System.Drawing.Point(5, 112)
        Me.gcActivities.MainView = Me.gvActivities
        Me.gcActivities.MenuManager = Me.BarManager1
        Me.gcActivities.Name = "gcActivities"
        Me.gcActivities.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riseSequence, Me.rileOperation, Me.rileArtisan, Me.rileMachine, Me.rilePart, Me.RepositoryItemDateEdit1, Me.rileState})
        Me.gcActivities.Size = New System.Drawing.Size(1567, 510)
        Me.gcActivities.TabIndex = 4
        Me.gcActivities.UseEmbeddedNavigator = True
        Me.gcActivities.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvActivities, Me.gvActivityLogList})
        '
        'ActivitiesBindingSource
        '
        Me.ActivitiesBindingSource.DataMember = "ActivityList"
        Me.ActivitiesBindingSource.DataSource = Me.JobBindingSource
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Job)
        '
        'gvActivities
        '
        Me.gvActivities.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOperation, Me.colArtisan, Me.colMachine, Me.colPart, Me.colSequence, Me.colEstimatedStartDate, Me.colEstimatedEndDate, Me.colActualStartDate, Me.colActualEndDate, Me.colEstimatedDuration, Me.colActualDuration, Me.colArtisanCost, Me.colMachineCost, Me.colOperationCost, Me.colEstimatedArtisanCost, Me.colEstimatedMachineCost, Me.colEstimatedOperationCost, Me.colJob, Me.colID, Me.colMachineDescription, Me.colOperationDescription, Me.colPartDescription, Me.colArtisanDescription})
        Me.gvActivities.GridControl = Me.gcActivities
        Me.gvActivities.Name = "gvActivities"
        Me.gvActivities.OptionsView.ColumnAutoWidth = False
        Me.gvActivities.OptionsView.ShowFooter = True
        Me.gvActivities.OptionsView.ShowGroupPanel = False
        Me.gvActivities.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSequence, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colOperation
        '
        Me.colOperation.ColumnEdit = Me.rileOperation
        Me.colOperation.FieldName = "Operation"
        Me.colOperation.Name = "colOperation"
        Me.colOperation.Visible = True
        Me.colOperation.VisibleIndex = 1
        Me.colOperation.Width = 110
        '
        'rileOperation
        '
        Me.rileOperation.AutoHeight = False
        Me.rileOperation.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rileOperation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rileOperation.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rate", "Rate", 33, DevExpress.Utils.FormatType.Numeric, "c", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsBuyOut", "Is Buy Out", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CostCentre", "Cost Centre", 68, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rileOperation.DataSource = Me.OperationBindingSource
        Me.rileOperation.DisplayMember = "Code"
        Me.rileOperation.Name = "rileOperation"
        Me.rileOperation.NullText = "(Select Operation...)"
        '
        'OperationBindingSource
        '
        Me.OperationBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Operation)
        '
        'colArtisan
        '
        Me.colArtisan.ColumnEdit = Me.rileArtisan
        Me.colArtisan.FieldName = "Artisan"
        Me.colArtisan.Name = "colArtisan"
        Me.colArtisan.Visible = True
        Me.colArtisan.VisibleIndex = 2
        Me.colArtisan.Width = 110
        '
        'colMachine
        '
        Me.colMachine.ColumnEdit = Me.rileMachine
        Me.colMachine.FieldName = "Machine"
        Me.colMachine.Name = "colMachine"
        Me.colMachine.Visible = True
        Me.colMachine.VisibleIndex = 3
        Me.colMachine.Width = 110
        '
        'colPart
        '
        Me.colPart.ColumnEdit = Me.rilePart
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        Me.colPart.Visible = True
        Me.colPart.VisibleIndex = 4
        Me.colPart.Width = 110
        '
        'rilePart
        '
        Me.rilePart.AutoHeight = False
        Me.rilePart.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.rilePart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilePart.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.rilePart.DataSource = Me.PartBindingSource
        Me.rilePart.DisplayMember = "Code"
        Me.rilePart.Name = "rilePart"
        Me.rilePart.NullText = "(Select Part...)"
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Part)
        '
        'colSequence
        '
        Me.colSequence.ColumnEdit = Me.riseSequence
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        Me.colSequence.Visible = True
        Me.colSequence.VisibleIndex = 0
        Me.colSequence.Width = 79
        '
        'riseSequence
        '
        Me.riseSequence.AutoHeight = False
        Me.riseSequence.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.riseSequence.Name = "riseSequence"
        '
        'colEstimatedStartDate
        '
        Me.colEstimatedStartDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colEstimatedStartDate.DisplayFormat.FormatString = "g"
        Me.colEstimatedStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedStartDate.FieldName = "EstimatedStartDate"
        Me.colEstimatedStartDate.GroupFormat.FormatString = "g"
        Me.colEstimatedStartDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedStartDate.Name = "colEstimatedStartDate"
        Me.colEstimatedStartDate.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Min
        Me.colEstimatedStartDate.Visible = True
        Me.colEstimatedStartDate.VisibleIndex = 5
        Me.colEstimatedStartDate.Width = 119
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "g"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "g"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colEstimatedEndDate
        '
        Me.colEstimatedEndDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colEstimatedEndDate.DisplayFormat.FormatString = "g"
        Me.colEstimatedEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedEndDate.FieldName = "EstimatedEndDate"
        Me.colEstimatedEndDate.GroupFormat.FormatString = "g"
        Me.colEstimatedEndDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedEndDate.Name = "colEstimatedEndDate"
        Me.colEstimatedEndDate.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max
        Me.colEstimatedEndDate.Visible = True
        Me.colEstimatedEndDate.VisibleIndex = 6
        Me.colEstimatedEndDate.Width = 115
        '
        'colActualStartDate
        '
        Me.colActualStartDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colActualStartDate.DisplayFormat.FormatString = "g"
        Me.colActualStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualStartDate.FieldName = "ActualStartDate"
        Me.colActualStartDate.GroupFormat.FormatString = "g"
        Me.colActualStartDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualStartDate.Name = "colActualStartDate"
        Me.colActualStartDate.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Min
        Me.colActualStartDate.Visible = True
        Me.colActualStartDate.VisibleIndex = 7
        Me.colActualStartDate.Width = 115
        '
        'colActualEndDate
        '
        Me.colActualEndDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colActualEndDate.DisplayFormat.FormatString = "g"
        Me.colActualEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualEndDate.FieldName = "ActualEndDate"
        Me.colActualEndDate.GroupFormat.FormatString = "g"
        Me.colActualEndDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualEndDate.Name = "colActualEndDate"
        Me.colActualEndDate.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max
        Me.colActualEndDate.Visible = True
        Me.colActualEndDate.VisibleIndex = 8
        Me.colActualEndDate.Width = 115
        '
        'colEstimatedDuration
        '
        Me.colEstimatedDuration.DisplayFormat.FormatString = "f"
        Me.colEstimatedDuration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedDuration.FieldName = "EstimatedDuration"
        Me.colEstimatedDuration.GroupFormat.FormatString = "f"
        Me.colEstimatedDuration.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedDuration.Name = "colEstimatedDuration"
        Me.colEstimatedDuration.SummaryItem.DisplayFormat = "{0:f2}"
        Me.colEstimatedDuration.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colEstimatedDuration.Visible = True
        Me.colEstimatedDuration.VisibleIndex = 9
        Me.colEstimatedDuration.Width = 115
        '
        'colActualDuration
        '
        Me.colActualDuration.DisplayFormat.FormatString = "f"
        Me.colActualDuration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colActualDuration.FieldName = "ActualDuration"
        Me.colActualDuration.GroupFormat.FormatString = "f"
        Me.colActualDuration.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colActualDuration.Name = "colActualDuration"
        Me.colActualDuration.SummaryItem.DisplayFormat = "{0:f2}"
        Me.colActualDuration.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colActualDuration.Visible = True
        Me.colActualDuration.VisibleIndex = 10
        Me.colActualDuration.Width = 115
        '
        'colArtisanCost
        '
        Me.colArtisanCost.DisplayFormat.FormatString = "c"
        Me.colArtisanCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colArtisanCost.FieldName = "ActualArtisanCost"
        Me.colArtisanCost.GroupFormat.FormatString = "c"
        Me.colArtisanCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colArtisanCost.Name = "colArtisanCost"
        Me.colArtisanCost.OptionsColumn.ReadOnly = True
        Me.colArtisanCost.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colArtisanCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colArtisanCost.Visible = True
        Me.colArtisanCost.VisibleIndex = 11
        Me.colArtisanCost.Width = 115
        '
        'colMachineCost
        '
        Me.colMachineCost.DisplayFormat.FormatString = "c"
        Me.colMachineCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMachineCost.FieldName = "ActualMachineCost"
        Me.colMachineCost.GroupFormat.FormatString = "c"
        Me.colMachineCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMachineCost.Name = "colMachineCost"
        Me.colMachineCost.OptionsColumn.ReadOnly = True
        Me.colMachineCost.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colMachineCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMachineCost.Visible = True
        Me.colMachineCost.VisibleIndex = 12
        Me.colMachineCost.Width = 116
        '
        'colOperationCost
        '
        Me.colOperationCost.DisplayFormat.FormatString = "c"
        Me.colOperationCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOperationCost.FieldName = "ActualOperationCost"
        Me.colOperationCost.GroupFormat.FormatString = "c"
        Me.colOperationCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOperationCost.Name = "colOperationCost"
        Me.colOperationCost.OptionsColumn.ReadOnly = True
        Me.colOperationCost.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colOperationCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colOperationCost.Visible = True
        Me.colOperationCost.VisibleIndex = 13
        Me.colOperationCost.Width = 129
        '
        'colEstimatedArtisanCost
        '
        Me.colEstimatedArtisanCost.DisplayFormat.FormatString = "c"
        Me.colEstimatedArtisanCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedArtisanCost.FieldName = "EstimatedArtisanCost"
        Me.colEstimatedArtisanCost.GroupFormat.FormatString = "c"
        Me.colEstimatedArtisanCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedArtisanCost.Name = "colEstimatedArtisanCost"
        Me.colEstimatedArtisanCost.OptionsColumn.ReadOnly = True
        Me.colEstimatedArtisanCost.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colEstimatedArtisanCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colEstimatedArtisanCost.Visible = True
        Me.colEstimatedArtisanCost.VisibleIndex = 14
        Me.colEstimatedArtisanCost.Width = 128
        '
        'colEstimatedMachineCost
        '
        Me.colEstimatedMachineCost.DisplayFormat.FormatString = "c"
        Me.colEstimatedMachineCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedMachineCost.FieldName = "EstimatedMachineCost"
        Me.colEstimatedMachineCost.GroupFormat.FormatString = "c"
        Me.colEstimatedMachineCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedMachineCost.Name = "colEstimatedMachineCost"
        Me.colEstimatedMachineCost.OptionsColumn.ReadOnly = True
        Me.colEstimatedMachineCost.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colEstimatedMachineCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colEstimatedMachineCost.Visible = True
        Me.colEstimatedMachineCost.VisibleIndex = 15
        Me.colEstimatedMachineCost.Width = 133
        '
        'colEstimatedOperationCost
        '
        Me.colEstimatedOperationCost.DisplayFormat.FormatString = "c"
        Me.colEstimatedOperationCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedOperationCost.FieldName = "EstimatedOperationCost"
        Me.colEstimatedOperationCost.GroupFormat.FormatString = "c"
        Me.colEstimatedOperationCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedOperationCost.Name = "colEstimatedOperationCost"
        Me.colEstimatedOperationCost.OptionsColumn.ReadOnly = True
        Me.colEstimatedOperationCost.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colEstimatedOperationCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colEstimatedOperationCost.Visible = True
        Me.colEstimatedOperationCost.VisibleIndex = 16
        Me.colEstimatedOperationCost.Width = 142
        '
        'colJob
        '
        Me.colJob.FieldName = "Job"
        Me.colJob.Name = "colJob"
        Me.colJob.OptionsColumn.ReadOnly = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colMachineDescription
        '
        Me.colMachineDescription.FieldName = "Machine.Description"
        Me.colMachineDescription.Name = "colMachineDescription"
        Me.colMachineDescription.OptionsColumn.ReadOnly = True
        '
        'colOperationDescription
        '
        Me.colOperationDescription.FieldName = "Operation.Description"
        Me.colOperationDescription.Name = "colOperationDescription"
        Me.colOperationDescription.OptionsColumn.ReadOnly = True
        '
        'colPartDescription
        '
        Me.colPartDescription.FieldName = "Part.Description"
        Me.colPartDescription.Name = "colPartDescription"
        Me.colPartDescription.OptionsColumn.ReadOnly = True
        '
        'colArtisanDescription
        '
        Me.colArtisanDescription.FieldName = "Artisan.Description"
        Me.colArtisanDescription.Name = "colArtisanDescription"
        Me.colArtisanDescription.OptionsColumn.ReadOnly = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiSave, Me.bsiReports, Me.bbiCancel, Me.bbiProcessActuals, Me.bbiExportGrid, Me.bbiCreateJobCard})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 8
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCreateJobCard), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiProcessActuals), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiReports)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Id = 0
        Me.bbiSave.Name = "bbiSave"
        Me.bbiSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiExportGrid
        '
        Me.bbiExportGrid.Caption = "Export Grid"
        Me.bbiExportGrid.Id = 5
        Me.bbiExportGrid.Name = "bbiExportGrid"
        Me.bbiExportGrid.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiCreateJobCard
        '
        Me.bbiCreateJobCard.Caption = "Create JobCard"
        Me.bbiCreateJobCard.Id = 6
        Me.bbiCreateJobCard.Name = "bbiCreateJobCard"
        Me.bbiCreateJobCard.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiProcessActuals
        '
        Me.bbiProcessActuals.Caption = "Process Actuals"
        Me.bbiProcessActuals.Id = 4
        Me.bbiProcessActuals.Name = "bbiProcessActuals"
        Me.bbiProcessActuals.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bsiReports
        '
        Me.bsiReports.Caption = "Reports"
        Me.bsiReports.Id = 1
        Me.bsiReports.Name = "bsiReports"
        Me.bsiReports.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1577, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 649)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1577, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 627)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1577, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 627)
        '
        'bbiCancel
        '
        Me.bbiCancel.Caption = "Cancel"
        Me.bbiCancel.Id = 3
        Me.bbiCancel.Name = "bbiCancel"
        Me.bbiCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'JobDataLayoutControl
        '
        Me.JobDataLayoutControl.Controls.Add(Me.EstimatedDeliveryDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.NumberTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DescriptionTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.gcActivities)
        Me.JobDataLayoutControl.Controls.Add(Me.CustomerTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.OrderPriceSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.TotalCostTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.EstimatedEndDateTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.EstimatedStartDateTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.ActualStartDateTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DateEdit1)
        Me.JobDataLayoutControl.Controls.Add(Me.RequiredDeliveryDateTextEdit)
        Me.JobDataLayoutControl.DataSource = Me.JobBindingSource
        Me.JobDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobDataLayoutControl.Location = New System.Drawing.Point(0, 22)
        Me.JobDataLayoutControl.Name = "JobDataLayoutControl"
        Me.JobDataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(103, 463, 250, 350)
        Me.JobDataLayoutControl.OptionsView.UseSkinIndents = False
        Me.JobDataLayoutControl.Root = Me.LayoutControlGroup1
        Me.JobDataLayoutControl.Size = New System.Drawing.Size(1577, 627)
        Me.JobDataLayoutControl.TabIndex = 5
        Me.JobDataLayoutControl.Text = "DataLayoutControl1"
        '
        'EstimatedDeliveryDateDateEdit
        '
        Me.EstimatedDeliveryDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "EstimatedDeliveryDate", True))
        Me.EstimatedDeliveryDateDateEdit.EditValue = Nothing
        Me.EstimatedDeliveryDateDateEdit.Location = New System.Drawing.Point(127, 58)
        Me.EstimatedDeliveryDateDateEdit.MenuManager = Me.BarManager1
        Me.EstimatedDeliveryDateDateEdit.Name = "EstimatedDeliveryDateDateEdit"
        Me.EstimatedDeliveryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EstimatedDeliveryDateDateEdit.Properties.ReadOnly = True
        Me.EstimatedDeliveryDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EstimatedDeliveryDateDateEdit.Size = New System.Drawing.Size(353, 20)
        Me.EstimatedDeliveryDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.EstimatedDeliveryDateDateEdit.TabIndex = 17
        '
        'NumberTextEdit
        '
        Me.NumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Number", True))
        Me.NumberTextEdit.Location = New System.Drawing.Point(911, 28)
        Me.NumberTextEdit.MenuManager = Me.BarManager1
        Me.NumberTextEdit.Name = "NumberTextEdit"
        Me.NumberTextEdit.Properties.ReadOnly = True
        Me.NumberTextEdit.Size = New System.Drawing.Size(655, 20)
        Me.NumberTextEdit.StyleController = Me.JobDataLayoutControl
        Me.NumberTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(127, 58)
        Me.DescriptionTextEdit.MenuManager = Me.BarManager1
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(654, 20)
        Me.DescriptionTextEdit.StyleController = Me.JobDataLayoutControl
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'CustomerTextEdit
        '
        Me.CustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Customer", True))
        Me.CustomerTextEdit.Location = New System.Drawing.Point(127, 28)
        Me.CustomerTextEdit.MenuManager = Me.BarManager1
        Me.CustomerTextEdit.Name = "CustomerTextEdit"
        Me.CustomerTextEdit.Properties.ReadOnly = True
        Me.CustomerTextEdit.Size = New System.Drawing.Size(654, 20)
        Me.CustomerTextEdit.StyleController = Me.JobDataLayoutControl
        Me.CustomerTextEdit.TabIndex = 15
        '
        'JobDateDateEdit
        '
        Me.JobDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobDate", True))
        Me.JobDateDateEdit.EditValue = Nothing
        Me.JobDateDateEdit.Location = New System.Drawing.Point(911, 58)
        Me.JobDateDateEdit.MenuManager = Me.BarManager1
        Me.JobDateDateEdit.Name = "JobDateDateEdit"
        Me.JobDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JobDateDateEdit.Properties.Mask.EditMask = ""
        Me.JobDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.JobDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.JobDateDateEdit.Size = New System.Drawing.Size(655, 20)
        Me.JobDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.JobDateDateEdit.TabIndex = 6
        '
        'OrderPriceSpinEdit
        '
        Me.OrderPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "OrderPrice", True))
        Me.OrderPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.OrderPriceSpinEdit.Location = New System.Drawing.Point(127, 28)
        Me.OrderPriceSpinEdit.MenuManager = Me.BarManager1
        Me.OrderPriceSpinEdit.Name = "OrderPriceSpinEdit"
        Me.OrderPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderPriceSpinEdit.Properties.DisplayFormat.FormatString = "c"
        Me.OrderPriceSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OrderPriceSpinEdit.Properties.EditFormat.FormatString = "c"
        Me.OrderPriceSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OrderPriceSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.OrderPriceSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.OrderPriceSpinEdit.Size = New System.Drawing.Size(654, 20)
        Me.OrderPriceSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.OrderPriceSpinEdit.TabIndex = 9
        '
        'TotalCostTextEdit
        '
        Me.TotalCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "TotalCost", True))
        Me.TotalCostTextEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TotalCostTextEdit.Location = New System.Drawing.Point(911, 28)
        Me.TotalCostTextEdit.MenuManager = Me.BarManager1
        Me.TotalCostTextEdit.Name = "TotalCostTextEdit"
        Me.TotalCostTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TotalCostTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.TotalCostTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalCostTextEdit.Properties.EditFormat.FormatString = "c"
        Me.TotalCostTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalCostTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TotalCostTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TotalCostTextEdit.Properties.ReadOnly = True
        Me.TotalCostTextEdit.Size = New System.Drawing.Size(655, 20)
        Me.TotalCostTextEdit.StyleController = Me.JobDataLayoutControl
        Me.TotalCostTextEdit.TabIndex = 10
        '
        'EstimatedEndDateTextEdit
        '
        Me.EstimatedEndDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "EstimatedEndDate", True))
        Me.EstimatedEndDateTextEdit.EditValue = Nothing
        Me.EstimatedEndDateTextEdit.Location = New System.Drawing.Point(1176, 28)
        Me.EstimatedEndDateTextEdit.MenuManager = Me.BarManager1
        Me.EstimatedEndDateTextEdit.Name = "EstimatedEndDateTextEdit"
        Me.EstimatedEndDateTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EstimatedEndDateTextEdit.Properties.Mask.EditMask = ""
        Me.EstimatedEndDateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.EstimatedEndDateTextEdit.Properties.ReadOnly = True
        Me.EstimatedEndDateTextEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EstimatedEndDateTextEdit.Size = New System.Drawing.Size(390, 20)
        Me.EstimatedEndDateTextEdit.StyleController = Me.JobDataLayoutControl
        Me.EstimatedEndDateTextEdit.TabIndex = 12
        '
        'EstimatedStartDateTextEdit
        '
        Me.EstimatedStartDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "EstimatedStartDate", True))
        Me.EstimatedStartDateTextEdit.EditValue = Nothing
        Me.EstimatedStartDateTextEdit.Location = New System.Drawing.Point(610, 28)
        Me.EstimatedStartDateTextEdit.MenuManager = Me.BarManager1
        Me.EstimatedStartDateTextEdit.Name = "EstimatedStartDateTextEdit"
        Me.EstimatedStartDateTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EstimatedStartDateTextEdit.Properties.Mask.EditMask = ""
        Me.EstimatedStartDateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.EstimatedStartDateTextEdit.Properties.ReadOnly = True
        Me.EstimatedStartDateTextEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EstimatedStartDateTextEdit.Size = New System.Drawing.Size(436, 20)
        Me.EstimatedStartDateTextEdit.StyleController = Me.JobDataLayoutControl
        Me.EstimatedStartDateTextEdit.TabIndex = 11
        '
        'ActualStartDateTextEdit
        '
        Me.ActualStartDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ActualStartDate", True))
        Me.ActualStartDateTextEdit.EditValue = Nothing
        Me.ActualStartDateTextEdit.Location = New System.Drawing.Point(610, 58)
        Me.ActualStartDateTextEdit.MenuManager = Me.BarManager1
        Me.ActualStartDateTextEdit.Name = "ActualStartDateTextEdit"
        Me.ActualStartDateTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActualStartDateTextEdit.Properties.Mask.EditMask = ""
        Me.ActualStartDateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ActualStartDateTextEdit.Properties.ReadOnly = True
        Me.ActualStartDateTextEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ActualStartDateTextEdit.Size = New System.Drawing.Size(436, 20)
        Me.ActualStartDateTextEdit.StyleController = Me.JobDataLayoutControl
        Me.ActualStartDateTextEdit.TabIndex = 13
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ActualEndDate", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(1176, 58)
        Me.DateEdit1.MenuManager = Me.BarManager1
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.Mask.EditMask = ""
        Me.DateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.DateEdit1.Properties.ReadOnly = True
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(390, 20)
        Me.DateEdit1.StyleController = Me.JobDataLayoutControl
        Me.DateEdit1.TabIndex = 16
        '
        'RequiredDeliveryDateTextEdit
        '
        Me.RequiredDeliveryDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "RequiredDeliveryDate", True))
        Me.RequiredDeliveryDateTextEdit.EditValue = Nothing
        Me.RequiredDeliveryDateTextEdit.Location = New System.Drawing.Point(127, 28)
        Me.RequiredDeliveryDateTextEdit.MenuManager = Me.BarManager1
        Me.RequiredDeliveryDateTextEdit.Name = "RequiredDeliveryDateTextEdit"
        Me.RequiredDeliveryDateTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequiredDeliveryDateTextEdit.Properties.Mask.EditMask = ""
        Me.RequiredDeliveryDateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RequiredDeliveryDateTextEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RequiredDeliveryDateTextEdit.Size = New System.Drawing.Size(353, 20)
        Me.RequiredDeliveryDateTextEdit.StyleController = Me.JobDataLayoutControl
        Me.RequiredDeliveryDateTextEdit.TabIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.lciActivities})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1577, 627)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1577, 89)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.lcgDates
        Me.TabbedControlGroup1.SelectedTabPageIndex = 2
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1577, 89)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcgDetails, Me.lcgValues, Me.lcgDates})
        Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
        '
        'lcgDetails
        '
        Me.lcgDetails.CustomizationFormText = "Details"
        Me.lcgDetails.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCustomer, Me.ItemForDescription, Me.ItemForNumber, Me.ItemForJobDate})
        Me.lcgDetails.Location = New System.Drawing.Point(0, 0)
        Me.lcgDetails.Name = "lcgDetails"
        Me.lcgDetails.OptionsItemText.TextToControlDistance = 5
        Me.lcgDetails.Size = New System.Drawing.Size(1569, 60)
        Me.lcgDetails.Text = "Details"
        '
        'ItemForCustomer
        '
        Me.ItemForCustomer.Control = Me.CustomerTextEdit
        Me.ItemForCustomer.CustomizationFormText = "Customer"
        Me.ItemForCustomer.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCustomer.Name = "ItemForCustomer"
        Me.ItemForCustomer.Size = New System.Drawing.Size(784, 30)
        Me.ItemForCustomer.Text = "Customer"
        Me.ItemForCustomer.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForCustomer.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(784, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForNumber
        '
        Me.ItemForNumber.Control = Me.NumberTextEdit
        Me.ItemForNumber.CustomizationFormText = "Number"
        Me.ItemForNumber.Location = New System.Drawing.Point(784, 0)
        Me.ItemForNumber.Name = "ItemForNumber"
        Me.ItemForNumber.Size = New System.Drawing.Size(785, 30)
        Me.ItemForNumber.Text = "Number"
        Me.ItemForNumber.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForNumber.TextToControlDistance = 5
        '
        'ItemForJobDate
        '
        Me.ItemForJobDate.Control = Me.JobDateDateEdit
        Me.ItemForJobDate.CustomizationFormText = "Job Date"
        Me.ItemForJobDate.Location = New System.Drawing.Point(784, 30)
        Me.ItemForJobDate.Name = "ItemForJobDate"
        Me.ItemForJobDate.Size = New System.Drawing.Size(785, 30)
        Me.ItemForJobDate.Text = "Job Date"
        Me.ItemForJobDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForJobDate.TextToControlDistance = 5
        '
        'lcgValues
        '
        Me.lcgValues.CustomizationFormText = "Values"
        Me.lcgValues.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForOrderPrice, Me.ItemForTotalCost})
        Me.lcgValues.Location = New System.Drawing.Point(0, 0)
        Me.lcgValues.Name = "lcgValues"
        Me.lcgValues.OptionsItemText.TextToControlDistance = 5
        Me.lcgValues.Size = New System.Drawing.Size(1569, 60)
        Me.lcgValues.Text = "Values"
        '
        'ItemForOrderPrice
        '
        Me.ItemForOrderPrice.Control = Me.OrderPriceSpinEdit
        Me.ItemForOrderPrice.CustomizationFormText = "Order Price"
        Me.ItemForOrderPrice.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOrderPrice.Name = "ItemForOrderPrice"
        Me.ItemForOrderPrice.Size = New System.Drawing.Size(784, 60)
        Me.ItemForOrderPrice.Text = "Order Price"
        Me.ItemForOrderPrice.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForOrderPrice.TextToControlDistance = 5
        '
        'ItemForTotalCost
        '
        Me.ItemForTotalCost.Control = Me.TotalCostTextEdit
        Me.ItemForTotalCost.CustomizationFormText = "Total Cost"
        Me.ItemForTotalCost.Location = New System.Drawing.Point(784, 0)
        Me.ItemForTotalCost.Name = "ItemForTotalCost"
        Me.ItemForTotalCost.Size = New System.Drawing.Size(785, 60)
        Me.ItemForTotalCost.Text = "Total Cost"
        Me.ItemForTotalCost.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForTotalCost.TextToControlDistance = 5
        '
        'lcgDates
        '
        Me.lcgDates.CustomizationFormText = "Dates"
        Me.lcgDates.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForEstimatedStartDate, Me.ItemForActualEndDate, Me.ItemForEstimatedEndDate, Me.ItemForRequiredDeliveryDate, Me.ItemForEstimatedDeliveryDate, Me.ItemForActualStartDate})
        Me.lcgDates.Location = New System.Drawing.Point(0, 0)
        Me.lcgDates.Name = "lcgDates"
        Me.lcgDates.OptionsItemText.TextToControlDistance = 5
        Me.lcgDates.Size = New System.Drawing.Size(1569, 60)
        Me.lcgDates.Text = "Dates"
        '
        'ItemForEstimatedStartDate
        '
        Me.ItemForEstimatedStartDate.Control = Me.EstimatedStartDateTextEdit
        Me.ItemForEstimatedStartDate.CustomizationFormText = "Estimated Start Date"
        Me.ItemForEstimatedStartDate.Location = New System.Drawing.Point(483, 0)
        Me.ItemForEstimatedStartDate.Name = "ItemForEstimatedStartDate"
        Me.ItemForEstimatedStartDate.Size = New System.Drawing.Size(566, 30)
        Me.ItemForEstimatedStartDate.Text = "Estimated Start Date"
        Me.ItemForEstimatedStartDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForEstimatedStartDate.TextToControlDistance = 5
        '
        'ItemForActualEndDate
        '
        Me.ItemForActualEndDate.Control = Me.DateEdit1
        Me.ItemForActualEndDate.CustomizationFormText = "Actual End Date"
        Me.ItemForActualEndDate.Location = New System.Drawing.Point(1049, 30)
        Me.ItemForActualEndDate.Name = "ItemForActualEndDate"
        Me.ItemForActualEndDate.Size = New System.Drawing.Size(520, 30)
        Me.ItemForActualEndDate.Text = "Actual End Date"
        Me.ItemForActualEndDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForActualEndDate.TextToControlDistance = 5
        '
        'ItemForEstimatedEndDate
        '
        Me.ItemForEstimatedEndDate.Control = Me.EstimatedEndDateTextEdit
        Me.ItemForEstimatedEndDate.CustomizationFormText = "Estimated End Date"
        Me.ItemForEstimatedEndDate.Location = New System.Drawing.Point(1049, 0)
        Me.ItemForEstimatedEndDate.Name = "ItemForEstimatedEndDate"
        Me.ItemForEstimatedEndDate.Size = New System.Drawing.Size(520, 30)
        Me.ItemForEstimatedEndDate.Text = "Estimated End Date"
        Me.ItemForEstimatedEndDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForEstimatedEndDate.TextToControlDistance = 5
        '
        'ItemForRequiredDeliveryDate
        '
        Me.ItemForRequiredDeliveryDate.Control = Me.RequiredDeliveryDateTextEdit
        Me.ItemForRequiredDeliveryDate.CustomizationFormText = "Required Delivery Date"
        Me.ItemForRequiredDeliveryDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForRequiredDeliveryDate.Name = "ItemForRequiredDeliveryDate"
        Me.ItemForRequiredDeliveryDate.Size = New System.Drawing.Size(483, 30)
        Me.ItemForRequiredDeliveryDate.Text = "Required Delivery Date"
        Me.ItemForRequiredDeliveryDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForRequiredDeliveryDate.TextToControlDistance = 5
        '
        'ItemForEstimatedDeliveryDate
        '
        Me.ItemForEstimatedDeliveryDate.Control = Me.EstimatedDeliveryDateDateEdit
        Me.ItemForEstimatedDeliveryDate.CustomizationFormText = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.Location = New System.Drawing.Point(0, 30)
        Me.ItemForEstimatedDeliveryDate.Name = "ItemForEstimatedDeliveryDate"
        Me.ItemForEstimatedDeliveryDate.Size = New System.Drawing.Size(483, 30)
        Me.ItemForEstimatedDeliveryDate.Text = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForEstimatedDeliveryDate.TextToControlDistance = 5
        '
        'ItemForActualStartDate
        '
        Me.ItemForActualStartDate.Control = Me.ActualStartDateTextEdit
        Me.ItemForActualStartDate.CustomizationFormText = "Actual Start Date"
        Me.ItemForActualStartDate.Location = New System.Drawing.Point(483, 30)
        Me.ItemForActualStartDate.Name = "ItemForActualStartDate"
        Me.ItemForActualStartDate.Size = New System.Drawing.Size(566, 30)
        Me.ItemForActualStartDate.Text = "Actual Start Date"
        Me.ItemForActualStartDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForActualStartDate.TextToControlDistance = 5
        '
        'lciActivities
        '
        Me.lciActivities.Control = Me.gcActivities
        Me.lciActivities.CustomizationFormText = "Activities"
        Me.lciActivities.Location = New System.Drawing.Point(0, 89)
        Me.lciActivities.Name = "lciActivities"
        Me.lciActivities.Size = New System.Drawing.Size(1577, 538)
        Me.lciActivities.Text = "Activities"
        Me.lciActivities.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciActivities.TextSize = New System.Drawing.Size(115, 13)
        Me.lciActivities.TextToControlDistance = 5
        '
        'xucJobActivities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.JobDataLayoutControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xucJobActivities"
        Me.Size = New System.Drawing.Size(1577, 649)
        CType(Me.gvActivityLogList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rileArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rileMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rileState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcActivities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvActivities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rileOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilePart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseSequence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JobDataLayoutControl.ResumeLayout(False)
        CType(Me.EstimatedDeliveryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedEndDateTextEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedEndDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedStartDateTextEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualStartDateTextEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequiredDeliveryDateTextEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequiredDeliveryDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgValues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActualEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRequiredDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActualStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciActivities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents JobDataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents NumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gcActivities As DevExpress.XtraGrid.GridControl
    Friend WithEvents ActivitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gvActivities As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents lcgDetails As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCustomer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcgValues As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForOrderPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTotalCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcgDates As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForEstimatedStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActualStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActualEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciActivities As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiReports As DevExpress.XtraBars.BarSubItem
    Friend WithEvents colOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rileOperation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colArtisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rileArtisan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rileMachine As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilePart As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riseSequence As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colEstimatedStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArtisanCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperationCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OperationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArtisanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents bbiCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiProcessActuals As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCreateJobCard As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colEstimatedArtisanCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedMachineCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedOperationCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EstimatedDeliveryDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents JobDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents OrderPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TotalCostTextEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EstimatedEndDateTextEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EstimatedStartDateTextEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ActualStartDateTextEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RequiredDeliveryDateTextEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ItemForRequiredDeliveryDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedDeliveryDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colMachineDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperationDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArtisanDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvActivityLogList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colArtisan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachine1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rileState As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colArtisanCost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineCost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperationCost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn

End Class
