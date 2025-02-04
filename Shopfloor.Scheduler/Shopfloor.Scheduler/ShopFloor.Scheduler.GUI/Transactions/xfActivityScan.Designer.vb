<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfActivityScan
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
        Dim IndicatorState1 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState2 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState3 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState4 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.ResetButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ArtisanAcitvityListGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ActivityListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtisanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtisanActivityListGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrentState1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ArtisanDataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.ImagePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForImage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LogActivityDataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.ArtisanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LogActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ControlScanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForArtisan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActivity = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForControlScan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.JobDataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.NumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RequiredDeliveryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.EstimatedDeliveryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.OrderPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TotalCostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.EstimatedStartDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.EstimatedEndDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ActualStartDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ActualEndDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ItemForOrderPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTotalCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActualStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActualEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedDeliveryDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRequiredDeliveryDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCustomer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RecentActivityLogsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.RecentActivityLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecentActivityLogsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArtisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachine1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrentState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StateGaugeControl = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.StateIndicatorGauge1 = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge()
        Me.StateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent()
        Me.ActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FullScreenButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ExitButton = New DevExpress.XtraEditors.SimpleButton()
        Me.JobNumberLabelCotrol = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LogActivityLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.JobLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StateLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ArtisanLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ArtisanActivityLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RecentActivityLogsLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.JobNumberLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.ArtisanAcitvityListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanActivityListGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanDataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArtisanDataLayoutControl.SuspendLayout()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogActivityDataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogActivityDataLayoutControl.SuspendLayout()
        CType(Me.ArtisanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlScanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForControlScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JobDataLayoutControl.SuspendLayout()
        CType(Me.NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequiredDeliveryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequiredDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedStartDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedStartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedEndDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedEndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualStartDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualStartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualEndDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualEndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActualStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActualEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRequiredDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecentActivityLogsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecentActivityLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecentActivityLogsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateIndicatorGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogActivityLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanActivityLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecentActivityLogsLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobNumberLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl
        '
        Me.LayoutControl.Controls.Add(Me.ResetButton)
        Me.LayoutControl.Controls.Add(Me.ArtisanAcitvityListGridControl)
        Me.LayoutControl.Controls.Add(Me.ArtisanDataLayoutControl)
        Me.LayoutControl.Controls.Add(Me.LogActivityDataLayoutControl)
        Me.LayoutControl.Controls.Add(Me.JobDataLayoutControl)
        Me.LayoutControl.Controls.Add(Me.RecentActivityLogsGridControl)
        Me.LayoutControl.Controls.Add(Me.StateGaugeControl)
        Me.LayoutControl.Controls.Add(Me.FullScreenButton)
        Me.LayoutControl.Controls.Add(Me.ExitButton)
        Me.LayoutControl.Controls.Add(Me.JobNumberLabelCotrol)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl"
        Me.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(616, 222, 250, 350)
        Me.LayoutControl.OptionsView.UseSkinIndents = False
        Me.LayoutControl.Root = Me.LayoutControlGroup1
        Me.LayoutControl.Size = New System.Drawing.Size(1064, 608)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(661, 581)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(77, 22)
        Me.ResetButton.StyleController = Me.LayoutControl
        Me.ResetButton.TabIndex = 21
        Me.ResetButton.Text = "Reset"
        '
        'ArtisanAcitvityListGridControl
        '
        Me.ArtisanAcitvityListGridControl.DataSource = Me.ActivityListBindingSource
        Me.ArtisanAcitvityListGridControl.Location = New System.Drawing.Point(5, 176)
        Me.ArtisanAcitvityListGridControl.MainView = Me.ArtisanActivityListGridView
        Me.ArtisanAcitvityListGridControl.Name = "ArtisanAcitvityListGridControl"
        Me.ArtisanAcitvityListGridControl.ShowOnlyPredefinedDetails = True
        Me.ArtisanAcitvityListGridControl.Size = New System.Drawing.Size(644, 325)
        Me.ArtisanAcitvityListGridControl.TabIndex = 17
        Me.ArtisanAcitvityListGridControl.TabStop = False
        Me.ArtisanAcitvityListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ArtisanActivityListGridView})
        '
        'ActivityListBindingSource
        '
        Me.ActivityListBindingSource.DataMember = "ActivityList"
        Me.ActivityListBindingSource.DataSource = Me.ArtisanBindingSource
        '
        'ArtisanBindingSource
        '
        Me.ArtisanBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Artisan)
        '
        'ArtisanActivityListGridView
        '
        Me.ArtisanActivityListGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJob, Me.colOperation, Me.colMachine, Me.colPart, Me.colEstimatedStartDate, Me.colEstimatedEndDate, Me.colEstimatedDuration, Me.colSequence, Me.colActualStartDate, Me.colActualEndDate, Me.colActualDuration, Me.colCurrentState1})
        Me.ArtisanActivityListGridView.GridControl = Me.ArtisanAcitvityListGridControl
        Me.ArtisanActivityListGridView.Name = "ArtisanActivityListGridView"
        Me.ArtisanActivityListGridView.OptionsView.ShowGroupPanel = False
        Me.ArtisanActivityListGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEstimatedStartDate, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colJob
        '
        Me.colJob.FieldName = "Job"
        Me.colJob.Name = "colJob"
        Me.colJob.OptionsColumn.ReadOnly = True
        Me.colJob.Visible = True
        Me.colJob.VisibleIndex = 0
        '
        'colOperation
        '
        Me.colOperation.FieldName = "Operation"
        Me.colOperation.Name = "colOperation"
        Me.colOperation.OptionsColumn.ReadOnly = True
        Me.colOperation.Visible = True
        Me.colOperation.VisibleIndex = 1
        '
        'colMachine
        '
        Me.colMachine.FieldName = "Machine"
        Me.colMachine.Name = "colMachine"
        Me.colMachine.OptionsColumn.ReadOnly = True
        Me.colMachine.Visible = True
        Me.colMachine.VisibleIndex = 2
        '
        'colPart
        '
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        Me.colPart.OptionsColumn.ReadOnly = True
        Me.colPart.Visible = True
        Me.colPart.VisibleIndex = 3
        '
        'colEstimatedStartDate
        '
        Me.colEstimatedStartDate.Caption = "Start"
        Me.colEstimatedStartDate.DisplayFormat.FormatString = "g"
        Me.colEstimatedStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedStartDate.FieldName = "EstimatedStartDate"
        Me.colEstimatedStartDate.Name = "colEstimatedStartDate"
        Me.colEstimatedStartDate.OptionsColumn.ReadOnly = True
        Me.colEstimatedStartDate.Visible = True
        Me.colEstimatedStartDate.VisibleIndex = 4
        '
        'colEstimatedEndDate
        '
        Me.colEstimatedEndDate.Caption = "End"
        Me.colEstimatedEndDate.DisplayFormat.FormatString = "g"
        Me.colEstimatedEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedEndDate.FieldName = "EstimatedEndDate"
        Me.colEstimatedEndDate.Name = "colEstimatedEndDate"
        Me.colEstimatedEndDate.OptionsColumn.ReadOnly = True
        Me.colEstimatedEndDate.Visible = True
        Me.colEstimatedEndDate.VisibleIndex = 5
        '
        'colEstimatedDuration
        '
        Me.colEstimatedDuration.Caption = "Minutes"
        Me.colEstimatedDuration.DisplayFormat.FormatString = "g"
        Me.colEstimatedDuration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedDuration.FieldName = "EstimatedDuration"
        Me.colEstimatedDuration.Name = "colEstimatedDuration"
        Me.colEstimatedDuration.OptionsColumn.ReadOnly = True
        Me.colEstimatedDuration.Visible = True
        Me.colEstimatedDuration.VisibleIndex = 6
        '
        'colSequence
        '
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        Me.colSequence.OptionsColumn.ReadOnly = True
        '
        'colActualStartDate
        '
        Me.colActualStartDate.FieldName = "ActualStartDate"
        Me.colActualStartDate.Name = "colActualStartDate"
        Me.colActualStartDate.OptionsColumn.ReadOnly = True
        '
        'colActualEndDate
        '
        Me.colActualEndDate.FieldName = "ActualEndDate"
        Me.colActualEndDate.Name = "colActualEndDate"
        Me.colActualEndDate.OptionsColumn.ReadOnly = True
        '
        'colActualDuration
        '
        Me.colActualDuration.FieldName = "ActualDuration"
        Me.colActualDuration.Name = "colActualDuration"
        Me.colActualDuration.OptionsColumn.ReadOnly = True
        '
        'colCurrentState1
        '
        Me.colCurrentState1.Caption = "State"
        Me.colCurrentState1.FieldName = "CurrentState"
        Me.colCurrentState1.Name = "colCurrentState1"
        Me.colCurrentState1.Visible = True
        Me.colCurrentState1.VisibleIndex = 7
        Me.colCurrentState1.Width = 60
        '
        'ArtisanDataLayoutControl
        '
        Me.ArtisanDataLayoutControl.Controls.Add(Me.CodeTextEdit)
        Me.ArtisanDataLayoutControl.Controls.Add(Me.TextEdit1)
        Me.ArtisanDataLayoutControl.Controls.Add(Me.ImagePictureEdit)
        Me.ArtisanDataLayoutControl.DataSource = Me.ArtisanBindingSource
        Me.ArtisanDataLayoutControl.Location = New System.Drawing.Point(5, 529)
        Me.ArtisanDataLayoutControl.Name = "ArtisanDataLayoutControl"
        Me.ArtisanDataLayoutControl.OptionsView.UseSkinIndents = False
        Me.ArtisanDataLayoutControl.Root = Me.LayoutControlGroup5
        Me.ArtisanDataLayoutControl.Size = New System.Drawing.Size(644, 74)
        Me.ArtisanDataLayoutControl.TabIndex = 7
        Me.ArtisanDataLayoutControl.Text = "Artisan"
        Me.ArtisanDataLayoutControl.Visible = False
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArtisanBindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(79, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Properties.ReadOnly = True
        Me.CodeTextEdit.Size = New System.Drawing.Size(560, 20)
        Me.CodeTextEdit.StyleController = Me.ArtisanDataLayoutControl
        Me.CodeTextEdit.TabIndex = 5
        Me.CodeTextEdit.TabStop = False
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArtisanBindingSource, "Description", True))
        Me.TextEdit1.Location = New System.Drawing.Point(79, 35)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(560, 20)
        Me.TextEdit1.StyleController = Me.ArtisanDataLayoutControl
        Me.TextEdit1.TabIndex = 6
        Me.TextEdit1.TabStop = False
        '
        'ImagePictureEdit
        '
        Me.ImagePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArtisanBindingSource, "Image", True))
        Me.ImagePictureEdit.Location = New System.Drawing.Point(5, 5)
        Me.ImagePictureEdit.MaximumSize = New System.Drawing.Size(128, 128)
        Me.ImagePictureEdit.MinimumSize = New System.Drawing.Size(64, 64)
        Me.ImagePictureEdit.Name = "ImagePictureEdit"
        Me.ImagePictureEdit.Properties.NullText = " "
        Me.ImagePictureEdit.Properties.ReadOnly = True
        Me.ImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.ImagePictureEdit.Size = New System.Drawing.Size(64, 64)
        Me.ImagePictureEdit.StyleController = Me.ArtisanDataLayoutControl
        Me.ImagePictureEdit.TabIndex = 7
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "LayoutControlGroup5"
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup6})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(644, 74)
        Me.LayoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup5.Text = "LayoutControlGroup5"
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.AllowDrawBackground = False
        Me.LayoutControlGroup6.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup6.GroupBordersVisible = False
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForImage, Me.ItemForCode, Me.LayoutControlItem4})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup6.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(644, 74)
        Me.LayoutControlGroup6.Text = "autoGeneratedGroup0"
        '
        'ItemForImage
        '
        Me.ItemForImage.Control = Me.ImagePictureEdit
        Me.ItemForImage.CustomizationFormText = "Image"
        Me.ItemForImage.Location = New System.Drawing.Point(0, 0)
        Me.ItemForImage.Name = "ItemForImage"
        Me.ItemForImage.Size = New System.Drawing.Size(74, 74)
        Me.ItemForImage.Text = "Image"
        Me.ItemForImage.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForImage.TextToControlDistance = 0
        Me.ItemForImage.TextVisible = False
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(74, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(570, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForCode.TextToControlDistance = 0
        Me.ItemForCode.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextEdit1
        Me.LayoutControlItem4.CustomizationFormText = "Description"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(74, 30)
        Me.LayoutControlItem4.Name = "ItemForDescription"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(570, 44)
        Me.LayoutControlItem4.Text = "Description"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LogActivityDataLayoutControl
        '
        Me.LogActivityDataLayoutControl.Controls.Add(Me.ArtisanTextEdit)
        Me.LogActivityDataLayoutControl.Controls.Add(Me.ActivityTextEdit)
        Me.LogActivityDataLayoutControl.Controls.Add(Me.ControlScanTextEdit)
        Me.LogActivityDataLayoutControl.DataSource = Me.LogActivityBindingSource
        Me.LogActivityDataLayoutControl.Location = New System.Drawing.Point(5, 40)
        Me.LogActivityDataLayoutControl.Name = "LogActivityDataLayoutControl"
        Me.LogActivityDataLayoutControl.OptionsView.UseSkinIndents = False
        Me.LogActivityDataLayoutControl.Root = Me.LayoutControlGroup3
        Me.LogActivityDataLayoutControl.Size = New System.Drawing.Size(644, 108)
        Me.LogActivityDataLayoutControl.TabIndex = 6
        Me.LogActivityDataLayoutControl.Text = "DataLayoutControl1"
        '
        'ArtisanTextEdit
        '
        Me.ArtisanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LogActivityBindingSource, "Artisan", True))
        Me.ArtisanTextEdit.Location = New System.Drawing.Point(62, 5)
        Me.ArtisanTextEdit.Name = "ArtisanTextEdit"
        Me.ArtisanTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ArtisanTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ArtisanTextEdit.Properties.ValidateOnEnterKey = True
        Me.ArtisanTextEdit.Size = New System.Drawing.Size(577, 26)
        Me.ArtisanTextEdit.StyleController = Me.LogActivityDataLayoutControl
        Me.ArtisanTextEdit.TabIndex = 1
        '
        'LogActivityBindingSource
        '
        Me.LogActivityBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.LogActivity)
        '
        'ActivityTextEdit
        '
        Me.ActivityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LogActivityBindingSource, "Activity", True))
        Me.ActivityTextEdit.Enabled = False
        Me.ActivityTextEdit.Location = New System.Drawing.Point(62, 41)
        Me.ActivityTextEdit.Name = "ActivityTextEdit"
        Me.ActivityTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ActivityTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ActivityTextEdit.Properties.ValidateOnEnterKey = True
        Me.ActivityTextEdit.Size = New System.Drawing.Size(577, 26)
        Me.ActivityTextEdit.StyleController = Me.LogActivityDataLayoutControl
        Me.ActivityTextEdit.TabIndex = 2
        '
        'ControlScanTextEdit
        '
        Me.ControlScanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LogActivityBindingSource, "ControlScan", True))
        Me.ControlScanTextEdit.Enabled = False
        Me.ControlScanTextEdit.Location = New System.Drawing.Point(62, 77)
        Me.ControlScanTextEdit.Name = "ControlScanTextEdit"
        Me.ControlScanTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ControlScanTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ControlScanTextEdit.Properties.ValidateOnEnterKey = True
        Me.ControlScanTextEdit.Size = New System.Drawing.Size(577, 26)
        Me.ControlScanTextEdit.StyleController = Me.LogActivityDataLayoutControl
        Me.ControlScanTextEdit.TabIndex = 3
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup4})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(644, 108)
        Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup3.Text = "LayoutControlGroup3"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AllowDrawBackground = False
        Me.LayoutControlGroup4.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForArtisan, Me.ItemForActivity, Me.ItemForControlScan})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup4.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(644, 108)
        Me.LayoutControlGroup4.Text = "autoGeneratedGroup0"
        '
        'ItemForArtisan
        '
        Me.ItemForArtisan.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ItemForArtisan.AppearanceItemCaption.Options.UseFont = True
        Me.ItemForArtisan.Control = Me.ArtisanTextEdit
        Me.ItemForArtisan.CustomizationFormText = "Artisan"
        Me.ItemForArtisan.Location = New System.Drawing.Point(0, 0)
        Me.ItemForArtisan.Name = "ItemForArtisan"
        Me.ItemForArtisan.Size = New System.Drawing.Size(644, 36)
        Me.ItemForArtisan.Text = "Artisan"
        Me.ItemForArtisan.TextSize = New System.Drawing.Size(52, 19)
        Me.ItemForArtisan.TextToControlDistance = 5
        '
        'ItemForActivity
        '
        Me.ItemForActivity.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ItemForActivity.AppearanceItemCaption.Options.UseFont = True
        Me.ItemForActivity.Control = Me.ActivityTextEdit
        Me.ItemForActivity.CustomizationFormText = "Activity"
        Me.ItemForActivity.Location = New System.Drawing.Point(0, 36)
        Me.ItemForActivity.Name = "ItemForActivity"
        Me.ItemForActivity.Size = New System.Drawing.Size(644, 36)
        Me.ItemForActivity.Text = "Activity"
        Me.ItemForActivity.TextSize = New System.Drawing.Size(52, 19)
        Me.ItemForActivity.TextToControlDistance = 5
        '
        'ItemForControlScan
        '
        Me.ItemForControlScan.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemForControlScan.AppearanceItemCaption.Options.UseFont = True
        Me.ItemForControlScan.Control = Me.ControlScanTextEdit
        Me.ItemForControlScan.CustomizationFormText = "Action"
        Me.ItemForControlScan.Location = New System.Drawing.Point(0, 72)
        Me.ItemForControlScan.Name = "ItemForControlScan"
        Me.ItemForControlScan.Size = New System.Drawing.Size(644, 36)
        Me.ItemForControlScan.Text = "Action"
        Me.ItemForControlScan.TextSize = New System.Drawing.Size(52, 19)
        Me.ItemForControlScan.TextToControlDistance = 5
        '
        'JobDataLayoutControl
        '
        Me.JobDataLayoutControl.Controls.Add(Me.NumberTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.DescriptionTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.CustomerTextEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.JobDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.RequiredDeliveryDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.EstimatedDeliveryDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.OrderPriceSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.TotalCostSpinEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.EstimatedStartDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.EstimatedEndDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.ActualStartDateDateEdit)
        Me.JobDataLayoutControl.Controls.Add(Me.ActualEndDateDateEdit)
        Me.JobDataLayoutControl.DataSource = Me.JobBindingSource
        Me.JobDataLayoutControl.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForOrderPrice, Me.ItemForTotalCost, Me.ItemForEstimatedStartDate, Me.ItemForEstimatedEndDate, Me.ItemForActualStartDate, Me.ItemForActualEndDate, Me.ItemForEstimatedDeliveryDate, Me.ItemForRequiredDeliveryDate, Me.ItemForJobDate})
        Me.JobDataLayoutControl.Location = New System.Drawing.Point(661, 208)
        Me.JobDataLayoutControl.Name = "JobDataLayoutControl"
        Me.JobDataLayoutControl.OptionsView.UseSkinIndents = False
        Me.JobDataLayoutControl.Root = Me.Root
        Me.JobDataLayoutControl.Size = New System.Drawing.Size(398, 90)
        Me.JobDataLayoutControl.TabIndex = 5
        Me.JobDataLayoutControl.Text = "DataLayoutControl1"
        Me.JobDataLayoutControl.Visible = False
        '
        'NumberTextEdit
        '
        Me.NumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Number", True))
        Me.NumberTextEdit.Location = New System.Drawing.Point(63, 5)
        Me.NumberTextEdit.Name = "NumberTextEdit"
        Me.NumberTextEdit.Properties.ReadOnly = True
        Me.NumberTextEdit.Size = New System.Drawing.Size(330, 20)
        Me.NumberTextEdit.StyleController = Me.JobDataLayoutControl
        Me.NumberTextEdit.TabIndex = 4
        Me.NumberTextEdit.TabStop = False
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Job)
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(63, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Properties.ReadOnly = True
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(330, 20)
        Me.DescriptionTextEdit.StyleController = Me.JobDataLayoutControl
        Me.DescriptionTextEdit.TabIndex = 5
        Me.DescriptionTextEdit.TabStop = False
        '
        'CustomerTextEdit
        '
        Me.CustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Customer", True))
        Me.CustomerTextEdit.Location = New System.Drawing.Point(63, 65)
        Me.CustomerTextEdit.Name = "CustomerTextEdit"
        Me.CustomerTextEdit.Properties.ReadOnly = True
        Me.CustomerTextEdit.Size = New System.Drawing.Size(330, 20)
        Me.CustomerTextEdit.StyleController = Me.JobDataLayoutControl
        Me.CustomerTextEdit.TabIndex = 15
        Me.CustomerTextEdit.TabStop = False
        '
        'JobDateDateEdit
        '
        Me.JobDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobDate", True))
        Me.JobDateDateEdit.EditValue = Nothing
        Me.JobDateDateEdit.Location = New System.Drawing.Point(63, 95)
        Me.JobDateDateEdit.Name = "JobDateDateEdit"
        Me.JobDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JobDateDateEdit.Properties.Mask.EditMask = ""
        Me.JobDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.JobDateDateEdit.Properties.ReadOnly = True
        Me.JobDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.JobDateDateEdit.Size = New System.Drawing.Size(371, 20)
        Me.JobDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.JobDateDateEdit.TabIndex = 6
        Me.JobDateDateEdit.TabStop = False
        '
        'RequiredDeliveryDateDateEdit
        '
        Me.RequiredDeliveryDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "RequiredDeliveryDate", True))
        Me.RequiredDeliveryDateDateEdit.EditValue = Nothing
        Me.RequiredDeliveryDateDateEdit.Location = New System.Drawing.Point(121, 125)
        Me.RequiredDeliveryDateDateEdit.Name = "RequiredDeliveryDateDateEdit"
        Me.RequiredDeliveryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequiredDeliveryDateDateEdit.Properties.Mask.EditMask = ""
        Me.RequiredDeliveryDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RequiredDeliveryDateDateEdit.Properties.ReadOnly = True
        Me.RequiredDeliveryDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RequiredDeliveryDateDateEdit.Size = New System.Drawing.Size(313, 20)
        Me.RequiredDeliveryDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.RequiredDeliveryDateDateEdit.TabIndex = 7
        Me.RequiredDeliveryDateDateEdit.TabStop = False
        '
        'EstimatedDeliveryDateDateEdit
        '
        Me.EstimatedDeliveryDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "EstimatedDeliveryDate", True))
        Me.EstimatedDeliveryDateDateEdit.EditValue = Nothing
        Me.EstimatedDeliveryDateDateEdit.Location = New System.Drawing.Point(125, 332)
        Me.EstimatedDeliveryDateDateEdit.Name = "EstimatedDeliveryDateDateEdit"
        Me.EstimatedDeliveryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EstimatedDeliveryDateDateEdit.Properties.Mask.EditMask = ""
        Me.EstimatedDeliveryDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.EstimatedDeliveryDateDateEdit.Properties.ReadOnly = True
        Me.EstimatedDeliveryDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EstimatedDeliveryDateDateEdit.Size = New System.Drawing.Size(219, 20)
        Me.EstimatedDeliveryDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.EstimatedDeliveryDateDateEdit.TabIndex = 8
        Me.EstimatedDeliveryDateDateEdit.TabStop = False
        '
        'OrderPriceSpinEdit
        '
        Me.OrderPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "OrderPrice", True))
        Me.OrderPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.OrderPriceSpinEdit.Location = New System.Drawing.Point(125, 282)
        Me.OrderPriceSpinEdit.Name = "OrderPriceSpinEdit"
        Me.OrderPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderPriceSpinEdit.Properties.DisplayFormat.FormatString = "c"
        Me.OrderPriceSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OrderPriceSpinEdit.Properties.EditFormat.FormatString = "c"
        Me.OrderPriceSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OrderPriceSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.OrderPriceSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.OrderPriceSpinEdit.Properties.ReadOnly = True
        Me.OrderPriceSpinEdit.Size = New System.Drawing.Size(219, 20)
        Me.OrderPriceSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.OrderPriceSpinEdit.TabIndex = 9
        Me.OrderPriceSpinEdit.TabStop = False
        '
        'TotalCostSpinEdit
        '
        Me.TotalCostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "TotalCost", True))
        Me.TotalCostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TotalCostSpinEdit.Location = New System.Drawing.Point(125, 312)
        Me.TotalCostSpinEdit.Name = "TotalCostSpinEdit"
        Me.TotalCostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TotalCostSpinEdit.Properties.DisplayFormat.FormatString = "c"
        Me.TotalCostSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalCostSpinEdit.Properties.EditFormat.FormatString = "c"
        Me.TotalCostSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalCostSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TotalCostSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TotalCostSpinEdit.Properties.ReadOnly = True
        Me.TotalCostSpinEdit.Size = New System.Drawing.Size(219, 20)
        Me.TotalCostSpinEdit.StyleController = Me.JobDataLayoutControl
        Me.TotalCostSpinEdit.TabIndex = 10
        Me.TotalCostSpinEdit.TabStop = False
        '
        'EstimatedStartDateDateEdit
        '
        Me.EstimatedStartDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "EstimatedStartDate", True))
        Me.EstimatedStartDateDateEdit.EditValue = Nothing
        Me.EstimatedStartDateDateEdit.Location = New System.Drawing.Point(125, 362)
        Me.EstimatedStartDateDateEdit.Name = "EstimatedStartDateDateEdit"
        Me.EstimatedStartDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EstimatedStartDateDateEdit.Properties.Mask.EditMask = ""
        Me.EstimatedStartDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.EstimatedStartDateDateEdit.Properties.ReadOnly = True
        Me.EstimatedStartDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EstimatedStartDateDateEdit.Size = New System.Drawing.Size(219, 20)
        Me.EstimatedStartDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.EstimatedStartDateDateEdit.TabIndex = 11
        Me.EstimatedStartDateDateEdit.TabStop = False
        '
        'EstimatedEndDateDateEdit
        '
        Me.EstimatedEndDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "EstimatedEndDate", True))
        Me.EstimatedEndDateDateEdit.EditValue = Nothing
        Me.EstimatedEndDateDateEdit.Location = New System.Drawing.Point(125, 362)
        Me.EstimatedEndDateDateEdit.Name = "EstimatedEndDateDateEdit"
        Me.EstimatedEndDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EstimatedEndDateDateEdit.Properties.Mask.EditMask = ""
        Me.EstimatedEndDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.EstimatedEndDateDateEdit.Properties.ReadOnly = True
        Me.EstimatedEndDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EstimatedEndDateDateEdit.Size = New System.Drawing.Size(219, 20)
        Me.EstimatedEndDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.EstimatedEndDateDateEdit.TabIndex = 12
        Me.EstimatedEndDateDateEdit.TabStop = False
        '
        'ActualStartDateDateEdit
        '
        Me.ActualStartDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ActualStartDate", True))
        Me.ActualStartDateDateEdit.EditValue = Nothing
        Me.ActualStartDateDateEdit.Location = New System.Drawing.Point(125, 362)
        Me.ActualStartDateDateEdit.Name = "ActualStartDateDateEdit"
        Me.ActualStartDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActualStartDateDateEdit.Properties.Mask.EditMask = ""
        Me.ActualStartDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ActualStartDateDateEdit.Properties.ReadOnly = True
        Me.ActualStartDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ActualStartDateDateEdit.Size = New System.Drawing.Size(219, 20)
        Me.ActualStartDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.ActualStartDateDateEdit.TabIndex = 13
        Me.ActualStartDateDateEdit.TabStop = False
        '
        'ActualEndDateDateEdit
        '
        Me.ActualEndDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "ActualEndDate", True))
        Me.ActualEndDateDateEdit.EditValue = Nothing
        Me.ActualEndDateDateEdit.Location = New System.Drawing.Point(125, 362)
        Me.ActualEndDateDateEdit.Name = "ActualEndDateDateEdit"
        Me.ActualEndDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActualEndDateDateEdit.Properties.Mask.EditMask = ""
        Me.ActualEndDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ActualEndDateDateEdit.Properties.ReadOnly = True
        Me.ActualEndDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ActualEndDateDateEdit.Size = New System.Drawing.Size(219, 20)
        Me.ActualEndDateDateEdit.StyleController = Me.JobDataLayoutControl
        Me.ActualEndDateDateEdit.TabIndex = 14
        Me.ActualEndDateDateEdit.TabStop = False
        '
        'ItemForOrderPrice
        '
        Me.ItemForOrderPrice.Control = Me.OrderPriceSpinEdit
        Me.ItemForOrderPrice.CustomizationFormText = "Order Price"
        Me.ItemForOrderPrice.Location = New System.Drawing.Point(0, 277)
        Me.ItemForOrderPrice.Name = "ItemForOrderPrice"
        Me.ItemForOrderPrice.Size = New System.Drawing.Size(349, 30)
        Me.ItemForOrderPrice.Text = "Order Price"
        Me.ItemForOrderPrice.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForOrderPrice.TextToControlDistance = 5
        '
        'ItemForTotalCost
        '
        Me.ItemForTotalCost.Control = Me.TotalCostSpinEdit
        Me.ItemForTotalCost.CustomizationFormText = "Total Cost"
        Me.ItemForTotalCost.Location = New System.Drawing.Point(0, 307)
        Me.ItemForTotalCost.Name = "ItemForTotalCost"
        Me.ItemForTotalCost.Size = New System.Drawing.Size(349, 30)
        Me.ItemForTotalCost.Text = "Total Cost"
        Me.ItemForTotalCost.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForTotalCost.TextToControlDistance = 5
        '
        'ItemForEstimatedStartDate
        '
        Me.ItemForEstimatedStartDate.Control = Me.EstimatedStartDateDateEdit
        Me.ItemForEstimatedStartDate.CustomizationFormText = "Estimated Start Date"
        Me.ItemForEstimatedStartDate.Location = New System.Drawing.Point(0, 357)
        Me.ItemForEstimatedStartDate.Name = "ItemForEstimatedStartDate"
        Me.ItemForEstimatedStartDate.Size = New System.Drawing.Size(349, 30)
        Me.ItemForEstimatedStartDate.Text = "Estimated Start Date"
        Me.ItemForEstimatedStartDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForEstimatedStartDate.TextToControlDistance = 5
        '
        'ItemForEstimatedEndDate
        '
        Me.ItemForEstimatedEndDate.Control = Me.EstimatedEndDateDateEdit
        Me.ItemForEstimatedEndDate.CustomizationFormText = "Estimated End Date"
        Me.ItemForEstimatedEndDate.Location = New System.Drawing.Point(0, 357)
        Me.ItemForEstimatedEndDate.Name = "ItemForEstimatedEndDate"
        Me.ItemForEstimatedEndDate.Size = New System.Drawing.Size(349, 30)
        Me.ItemForEstimatedEndDate.Text = "Estimated End Date"
        Me.ItemForEstimatedEndDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForEstimatedEndDate.TextToControlDistance = 5
        '
        'ItemForActualStartDate
        '
        Me.ItemForActualStartDate.Control = Me.ActualStartDateDateEdit
        Me.ItemForActualStartDate.CustomizationFormText = "Actual Start Date"
        Me.ItemForActualStartDate.Location = New System.Drawing.Point(0, 357)
        Me.ItemForActualStartDate.Name = "ItemForActualStartDate"
        Me.ItemForActualStartDate.Size = New System.Drawing.Size(349, 30)
        Me.ItemForActualStartDate.Text = "Actual Start Date"
        Me.ItemForActualStartDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForActualStartDate.TextToControlDistance = 5
        '
        'ItemForActualEndDate
        '
        Me.ItemForActualEndDate.Control = Me.ActualEndDateDateEdit
        Me.ItemForActualEndDate.CustomizationFormText = "Actual End Date"
        Me.ItemForActualEndDate.Location = New System.Drawing.Point(0, 357)
        Me.ItemForActualEndDate.Name = "ItemForActualEndDate"
        Me.ItemForActualEndDate.Size = New System.Drawing.Size(349, 30)
        Me.ItemForActualEndDate.Text = "Actual End Date"
        Me.ItemForActualEndDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForActualEndDate.TextToControlDistance = 5
        '
        'ItemForEstimatedDeliveryDate
        '
        Me.ItemForEstimatedDeliveryDate.Control = Me.EstimatedDeliveryDateDateEdit
        Me.ItemForEstimatedDeliveryDate.CustomizationFormText = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.Location = New System.Drawing.Point(0, 327)
        Me.ItemForEstimatedDeliveryDate.Name = "ItemForEstimatedDeliveryDate"
        Me.ItemForEstimatedDeliveryDate.Size = New System.Drawing.Size(349, 30)
        Me.ItemForEstimatedDeliveryDate.Text = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.TextSize = New System.Drawing.Size(115, 13)
        Me.ItemForEstimatedDeliveryDate.TextToControlDistance = 5
        '
        'ItemForRequiredDeliveryDate
        '
        Me.ItemForRequiredDeliveryDate.Control = Me.RequiredDeliveryDateDateEdit
        Me.ItemForRequiredDeliveryDate.CustomizationFormText = "Required Delivery Date"
        Me.ItemForRequiredDeliveryDate.Location = New System.Drawing.Point(0, 120)
        Me.ItemForRequiredDeliveryDate.Name = "ItemForRequiredDeliveryDate"
        Me.ItemForRequiredDeliveryDate.Size = New System.Drawing.Size(439, 30)
        Me.ItemForRequiredDeliveryDate.Text = "Required Delivery Date"
        Me.ItemForRequiredDeliveryDate.TextSize = New System.Drawing.Size(111, 13)
        Me.ItemForRequiredDeliveryDate.TextToControlDistance = 5
        '
        'ItemForJobDate
        '
        Me.ItemForJobDate.Control = Me.JobDateDateEdit
        Me.ItemForJobDate.CustomizationFormText = "Job Date"
        Me.ItemForJobDate.Location = New System.Drawing.Point(0, 90)
        Me.ItemForJobDate.Name = "ItemForJobDate"
        Me.ItemForJobDate.Size = New System.Drawing.Size(439, 30)
        Me.ItemForJobDate.Text = "Job Date"
        Me.ItemForJobDate.TextSize = New System.Drawing.Size(111, 13)
        Me.ItemForJobDate.TextToControlDistance = 5
        '
        'Root
        '
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.OptionsItemText.TextToControlDistance = 5
        Me.Root.Size = New System.Drawing.Size(398, 90)
        Me.Root.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForNumber, Me.ItemForDescription, Me.ItemForCustomer})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(398, 90)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForNumber
        '
        Me.ItemForNumber.Control = Me.NumberTextEdit
        Me.ItemForNumber.CustomizationFormText = "Number"
        Me.ItemForNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNumber.Name = "ItemForNumber"
        Me.ItemForNumber.Size = New System.Drawing.Size(398, 30)
        Me.ItemForNumber.Text = "Number"
        Me.ItemForNumber.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForNumber.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(398, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForCustomer
        '
        Me.ItemForCustomer.Control = Me.CustomerTextEdit
        Me.ItemForCustomer.CustomizationFormText = "Customer"
        Me.ItemForCustomer.Location = New System.Drawing.Point(0, 60)
        Me.ItemForCustomer.Name = "ItemForCustomer"
        Me.ItemForCustomer.Size = New System.Drawing.Size(398, 30)
        Me.ItemForCustomer.Text = "Customer"
        Me.ItemForCustomer.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForCustomer.TextToControlDistance = 5
        '
        'RecentActivityLogsGridControl
        '
        Me.RecentActivityLogsGridControl.DataSource = Me.RecentActivityLogBindingSource
        Me.RecentActivityLogsGridControl.Location = New System.Drawing.Point(661, 326)
        Me.RecentActivityLogsGridControl.MainView = Me.RecentActivityLogsGridView
        Me.RecentActivityLogsGridControl.Name = "RecentActivityLogsGridControl"
        Me.RecentActivityLogsGridControl.Size = New System.Drawing.Size(398, 245)
        Me.RecentActivityLogsGridControl.TabIndex = 20
        Me.RecentActivityLogsGridControl.TabStop = False
        Me.RecentActivityLogsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.RecentActivityLogsGridView})
        '
        'RecentActivityLogBindingSource
        '
        Me.RecentActivityLogBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.ActivityLog)
        '
        'RecentActivityLogsGridView
        '
        Me.RecentActivityLogsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivity, Me.colArtisan, Me.colMachine1, Me.colStartDate, Me.colEndDate, Me.colDuration, Me.colCurrentState, Me.colLogTime})
        Me.RecentActivityLogsGridView.GridControl = Me.RecentActivityLogsGridControl
        Me.RecentActivityLogsGridView.Name = "RecentActivityLogsGridView"
        Me.RecentActivityLogsGridView.OptionsBehavior.ReadOnly = True
        Me.RecentActivityLogsGridView.OptionsView.ShowGroupPanel = False
        Me.RecentActivityLogsGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colLogTime, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colActivity
        '
        Me.colActivity.FieldName = "Activity"
        Me.colActivity.Name = "colActivity"
        Me.colActivity.Visible = True
        Me.colActivity.VisibleIndex = 1
        Me.colActivity.Width = 152
        '
        'colArtisan
        '
        Me.colArtisan.FieldName = "Artisan"
        Me.colArtisan.Name = "colArtisan"
        Me.colArtisan.Visible = True
        Me.colArtisan.VisibleIndex = 2
        '
        'colMachine1
        '
        Me.colMachine1.FieldName = "Machine"
        Me.colMachine1.Name = "colMachine1"
        '
        'colStartDate
        '
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.Name = "colStartDate"
        '
        'colEndDate
        '
        Me.colEndDate.FieldName = "EndDate"
        Me.colEndDate.Name = "colEndDate"
        '
        'colDuration
        '
        Me.colDuration.Caption = "Minutes"
        Me.colDuration.FieldName = "Duration"
        Me.colDuration.Name = "colDuration"
        '
        'colCurrentState
        '
        Me.colCurrentState.Caption = "State"
        Me.colCurrentState.FieldName = "CurrentState"
        Me.colCurrentState.Name = "colCurrentState"
        Me.colCurrentState.Visible = True
        Me.colCurrentState.VisibleIndex = 3
        Me.colCurrentState.Width = 74
        '
        'colLogTime
        '
        Me.colLogTime.DisplayFormat.FormatString = "t"
        Me.colLogTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLogTime.FieldName = "LogTime"
        Me.colLogTime.Name = "colLogTime"
        Me.colLogTime.Visible = True
        Me.colLogTime.VisibleIndex = 0
        Me.colLogTime.Width = 79
        '
        'StateGaugeControl
        '
        Me.StateGaugeControl.BackColor = System.Drawing.Color.Transparent
        Me.StateGaugeControl.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.StateIndicatorGauge1})
        Me.StateGaugeControl.Location = New System.Drawing.Point(661, 40)
        Me.StateGaugeControl.MaximumSize = New System.Drawing.Size(400, 150)
        Me.StateGaugeControl.Name = "StateGaugeControl"
        Me.StateGaugeControl.Size = New System.Drawing.Size(398, 140)
        Me.StateGaugeControl.TabIndex = 16
        '
        'StateIndicatorGauge1
        '
        Me.StateIndicatorGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 386, 128)
        Me.StateIndicatorGauge1.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent() {Me.StateIndicatorComponent1})
        Me.StateIndicatorGauge1.Name = "StateIndicatorGauge1"
        '
        'StateIndicatorComponent1
        '
        Me.StateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(124.0!, 124.0!)
        Me.StateIndicatorComponent1.DataBindings.Add(New System.Windows.Forms.Binding("StateIndex", Me.ActivityBindingSource, "CurrentState", True))
        Me.StateIndicatorComponent1.Name = "stateIndicatorComponent1"
        Me.StateIndicatorComponent1.StateIndex = 3
        IndicatorState1.Name = "State1"
        IndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight1
        IndicatorState2.Name = "State2"
        IndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight2
        IndicatorState3.Name = "State3"
        IndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight3
        IndicatorState4.Name = "State4"
        IndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight4
        Me.StateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {IndicatorState1, IndicatorState2, IndicatorState3, IndicatorState4})
        '
        'ActivityBindingSource
        '
        Me.ActivityBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Activity)
        '
        'FullScreenButton
        '
        Me.FullScreenButton.Location = New System.Drawing.Point(748, 581)
        Me.FullScreenButton.Name = "FullScreenButton"
        Me.FullScreenButton.Size = New System.Drawing.Size(92, 22)
        Me.FullScreenButton.StyleController = Me.LayoutControl
        Me.FullScreenButton.TabIndex = 18
        Me.FullScreenButton.Text = "Full Screen"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(850, 581)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(209, 22)
        Me.ExitButton.StyleController = Me.LayoutControl
        Me.ExitButton.TabIndex = 19
        Me.ExitButton.Text = "Exit"
        '
        'JobNumberLabelCotrol
        '
        Me.JobNumberLabelCotrol.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.JobNumberLabelCotrol.Location = New System.Drawing.Point(456, 5)
        Me.JobNumberLabelCotrol.Name = "JobNumberLabelCotrol"
        Me.JobNumberLabelCotrol.Size = New System.Drawing.Size(151, 25)
        Me.JobNumberLabelCotrol.StyleController = Me.LayoutControl
        Me.JobNumberLabelCotrol.TabIndex = 4
        Me.JobNumberLabelCotrol.Text = "Awaiting Scan..."
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LogActivityLayoutControlItem, Me.JobLayoutControlItem, Me.StateLayoutControlItem, Me.ArtisanLayoutControlItem, Me.ArtisanActivityLayoutControlItem, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.RecentActivityLogsLayoutControlItem, Me.SimpleSeparator1, Me.JobNumberLayoutControlItem, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1064, 608)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LogActivityLayoutControlItem
        '
        Me.LogActivityLayoutControlItem.Control = Me.LogActivityDataLayoutControl
        Me.LogActivityLayoutControlItem.CustomizationFormText = "Scanning"
        Me.LogActivityLayoutControlItem.Location = New System.Drawing.Point(0, 35)
        Me.LogActivityLayoutControlItem.Name = "LogActivityLayoutControlItem"
        Me.LogActivityLayoutControlItem.Size = New System.Drawing.Size(654, 118)
        Me.LogActivityLayoutControlItem.Text = "Scanning"
        Me.LogActivityLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
        Me.LogActivityLayoutControlItem.TextToControlDistance = 0
        Me.LogActivityLayoutControlItem.TextVisible = False
        '
        'JobLayoutControlItem
        '
        Me.JobLayoutControlItem.Control = Me.JobDataLayoutControl
        Me.JobLayoutControlItem.CustomizationFormText = "Job Details"
        Me.JobLayoutControlItem.Location = New System.Drawing.Point(656, 185)
        Me.JobLayoutControlItem.Name = "JobLayoutControlItem"
        Me.JobLayoutControlItem.Size = New System.Drawing.Size(408, 118)
        Me.JobLayoutControlItem.Text = "Job Details"
        Me.JobLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top
        Me.JobLayoutControlItem.TextSize = New System.Drawing.Size(98, 13)
        Me.JobLayoutControlItem.TextToControlDistance = 5
        '
        'StateLayoutControlItem
        '
        Me.StateLayoutControlItem.Control = Me.StateGaugeControl
        Me.StateLayoutControlItem.CustomizationFormText = "Activity State"
        Me.StateLayoutControlItem.Location = New System.Drawing.Point(656, 35)
        Me.StateLayoutControlItem.Name = "StateLayoutControlItem"
        Me.StateLayoutControlItem.Size = New System.Drawing.Size(408, 150)
        Me.StateLayoutControlItem.Text = "Activity State"
        Me.StateLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
        Me.StateLayoutControlItem.TextToControlDistance = 0
        Me.StateLayoutControlItem.TextVisible = False
        '
        'ArtisanLayoutControlItem
        '
        Me.ArtisanLayoutControlItem.Control = Me.ArtisanDataLayoutControl
        Me.ArtisanLayoutControlItem.CustomizationFormText = "Artisan"
        Me.ArtisanLayoutControlItem.Location = New System.Drawing.Point(0, 506)
        Me.ArtisanLayoutControlItem.Name = "ArtisanLayoutControlItem"
        Me.ArtisanLayoutControlItem.Size = New System.Drawing.Size(654, 102)
        Me.ArtisanLayoutControlItem.Text = "Artisan"
        Me.ArtisanLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top
        Me.ArtisanLayoutControlItem.TextSize = New System.Drawing.Size(98, 13)
        Me.ArtisanLayoutControlItem.TextToControlDistance = 5
        '
        'ArtisanActivityLayoutControlItem
        '
        Me.ArtisanActivityLayoutControlItem.Control = Me.ArtisanAcitvityListGridControl
        Me.ArtisanActivityLayoutControlItem.CustomizationFormText = "Artisan Activity List"
        Me.ArtisanActivityLayoutControlItem.Location = New System.Drawing.Point(0, 153)
        Me.ArtisanActivityLayoutControlItem.Name = "ArtisanActivityLayoutControlItem"
        Me.ArtisanActivityLayoutControlItem.Size = New System.Drawing.Size(654, 353)
        Me.ArtisanActivityLayoutControlItem.Text = "Artisan Activity List"
        Me.ArtisanActivityLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top
        Me.ArtisanActivityLayoutControlItem.TextSize = New System.Drawing.Size(98, 13)
        Me.ArtisanActivityLayoutControlItem.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.FullScreenButton
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(743, 576)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(102, 32)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ExitButton
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(845, 576)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(219, 32)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'RecentActivityLogsLayoutControlItem
        '
        Me.RecentActivityLogsLayoutControlItem.Control = Me.RecentActivityLogsGridControl
        Me.RecentActivityLogsLayoutControlItem.CustomizationFormText = "Recent Activity Logs"
        Me.RecentActivityLogsLayoutControlItem.Location = New System.Drawing.Point(656, 303)
        Me.RecentActivityLogsLayoutControlItem.Name = "RecentActivityLogsLayoutControlItem"
        Me.RecentActivityLogsLayoutControlItem.Size = New System.Drawing.Size(408, 273)
        Me.RecentActivityLogsLayoutControlItem.Text = "Recent Activity Logs"
        Me.RecentActivityLogsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top
        Me.RecentActivityLogsLayoutControlItem.TextSize = New System.Drawing.Size(98, 13)
        Me.RecentActivityLogsLayoutControlItem.TextToControlDistance = 5
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(654, 35)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(2, 573)
        Me.SimpleSeparator1.Text = "SimpleSeparator1"
        '
        'JobNumberLayoutControlItem
        '
        Me.JobNumberLayoutControlItem.Control = Me.JobNumberLabelCotrol
        Me.JobNumberLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.JobNumberLayoutControlItem.CustomizationFormText = "Job Number"
        Me.JobNumberLayoutControlItem.Location = New System.Drawing.Point(0, 0)
        Me.JobNumberLayoutControlItem.Name = "JobNumberLayoutControlItem"
        Me.JobNumberLayoutControlItem.Size = New System.Drawing.Size(1064, 35)
        Me.JobNumberLayoutControlItem.Text = "Job Number"
        Me.JobNumberLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
        Me.JobNumberLayoutControlItem.TextToControlDistance = 0
        Me.JobNumberLayoutControlItem.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ResetButton
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(656, 576)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(87, 32)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'xfActivityScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 608)
        Me.Controls.Add(Me.LayoutControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "xfActivityScan"
        Me.Text = "Activity Scan"
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.ArtisanAcitvityListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanActivityListGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanDataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArtisanDataLayoutControl.ResumeLayout(False)
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogActivityDataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogActivityDataLayoutControl.ResumeLayout(False)
        CType(Me.ArtisanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlScanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForControlScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JobDataLayoutControl.ResumeLayout(False)
        CType(Me.NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequiredDeliveryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequiredDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedStartDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedStartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedEndDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedEndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualStartDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualStartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualEndDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualEndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActualStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActualEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRequiredDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecentActivityLogsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecentActivityLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecentActivityLogsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateIndicatorGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogActivityLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanActivityLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecentActivityLogsLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobNumberLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents JobDataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents NumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RequiredDeliveryDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EstimatedDeliveryDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents OrderPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TotalCostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EstimatedStartDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EstimatedEndDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ActualStartDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ActualEndDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRequiredDeliveryDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedDeliveryDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrderPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTotalCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActualStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActualEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCustomer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobNumberLabelCotrol As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents JobNumberLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LogActivityDataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents ArtisanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LogActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ControlScanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForArtisan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActivity As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForControlScan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents StateGaugeControl As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents StateIndicatorGauge1 As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge
    Private WithEvents StateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent
    Friend WithEvents LogActivityLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents ArtisanDataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ArtisanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImagePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForImage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ArtisanLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents StateLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ArtisanAcitvityListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ActivityListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArtisanActivityListGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ArtisanActivityLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ExitButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FullScreenButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecentActivityLogsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents RecentActivityLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecentActivityLogsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArtisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachine1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RecentActivityLogsLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colLogTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentState1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResetButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
