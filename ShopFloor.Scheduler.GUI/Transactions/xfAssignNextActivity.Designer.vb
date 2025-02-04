<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfAssignNextActivity
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
        Me.ActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtisanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivityListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.gcAssignNextOperation = New DevExpress.XtraGrid.GridControl()
        Me.gvAssignNextOperation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtSequence = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colJobNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumber = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPartCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPartCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPartDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPartDescr = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colOperationCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtOperationCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colOperationDescr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtOperationDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colArtisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riglkpArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ripbArtisanDuration = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDuration1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedTimespam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobReqDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtRequiredDeliveryDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEstimatedDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtEstDuration = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colActualDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtActDuration = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMaterials = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkMaterials = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCurrentState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtState = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtActualStartDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEstimatedEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtEstimatedEndDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colActualEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtActualEndDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colActualArtisanCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtActualArtisanCost = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colActualMachineCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtActualMachineCost = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colActualOperationCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtActualOperationCost = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEstimatedStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtEstimatedStartDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEstimatedElapsedDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtEstimatedElapsedDuration = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colActualElapsedDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtActualElapsedDuration = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEstimatedArtisanCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtEstimatedArtisanCost = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEstimatedMachineCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtEstimatedMachineCost = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEstimatedOperationCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtEstimatedOperationCost = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colIsActualsPosted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtIsActualsPosted = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colIsNextActivity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkIsNextActivity = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMachineCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMachineCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMachineDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMachineDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.luArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colActualTimespan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedTimespan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsLoading = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsChanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidationErrorMessages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPropertiesValidationErrorMessages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ritAutoRefreshRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAssignNextOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAssignNextOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSequence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartDescr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperationCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperationDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riglkpArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ripbArtisanDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRequiredDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRequiredDeliveryDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtActualStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtActualStartDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstimatedEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstimatedEndDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtActualEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtActualEndDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualArtisanCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualMachineCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualOperationCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstimatedStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstimatedStartDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstimatedElapsedDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualElapsedDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstimatedArtisanCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstimatedMachineCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstimatedOperationCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIsActualsPosted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsNextActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMachineCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMachineDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActivityBindingSource
        '
        Me.ActivityBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Activity)
        '
        'OperationBindingSource
        '
        Me.OperationBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Operation)
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Part)
        '
        'ArtisanBindingSource
        '
        Me.ArtisanBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Artisan)
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Job)
        '
        'ActivityListBindingSource
        '
        Me.ActivityListBindingSource.DataMember = "ActivityList"
        Me.ActivityListBindingSource.DataSource = Me.JobBindingSource
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
        Me.bbiCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'gcAssignNextOperation
        '
        Me.gcAssignNextOperation.DataSource = Me.ActivityBindingSource
        Me.gcAssignNextOperation.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcAssignNextOperation.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcAssignNextOperation.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcAssignNextOperation.Location = New System.Drawing.Point(5, 5)
        Me.gcAssignNextOperation.MainView = Me.gvAssignNextOperation
        Me.gcAssignNextOperation.Name = "gcAssignNextOperation"
        Me.gcAssignNextOperation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.dtRequiredDeliveryDate, Me.txtNumber, Me.txtPartCode, Me.txtPartDescr, Me.txtDescription, Me.txtOperationCode, Me.txtOperationDescription, Me.luArtisan, Me.txtEstDuration, Me.txtActDuration, Me.chkMaterials, Me.txtState, Me.dtActualStartDate, Me.dtEstimatedEndDate, Me.dtActualEndDate, Me.txtActualArtisanCost, Me.txtActualMachineCost, Me.txtActualOperationCost, Me.dtEstimatedStartDate, Me.txtEstimatedElapsedDuration, Me.txtActualElapsedDuration, Me.txtSequence, Me.txtEstimatedArtisanCost, Me.txtEstimatedMachineCost, Me.txtEstimatedOperationCost, Me.txtIsActualsPosted, Me.chkIsNextActivity, Me.txtMachineCode, Me.txtMachineDescription, Me.riglkpArtisan})
        Me.gcAssignNextOperation.ShowOnlyPredefinedDetails = True
        Me.gcAssignNextOperation.Size = New System.Drawing.Size(1266, 592)
        Me.gcAssignNextOperation.TabIndex = 0
        Me.gcAssignNextOperation.UseEmbeddedNavigator = True
        Me.gcAssignNextOperation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAssignNextOperation})
        '
        'gvAssignNextOperation
        '
        Me.gvAssignNextOperation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSequence, Me.colJobNumber, Me.colDescription, Me.colPartCode, Me.colPartDescription, Me.colOperationCode, Me.colOperationDescr, Me.colArtisan, Me.colJobReqDate, Me.colEstimatedDuration, Me.colActualDuration, Me.colMaterials, Me.colCurrentState, Me.colComments, Me.colActualStartDate, Me.colEstimatedEndDate, Me.colActualEndDate, Me.colActualArtisanCost, Me.colActualMachineCost, Me.colActualOperationCost, Me.colEstimatedStartDate, Me.colEstimatedElapsedDuration, Me.colActualElapsedDuration, Me.colEstimatedArtisanCost, Me.colEstimatedMachineCost, Me.colEstimatedOperationCost, Me.colIsActualsPosted, Me.colIsNextActivity, Me.colMachineCode, Me.colMachineDescription})
        Me.gvAssignNextOperation.GridControl = Me.gcAssignNextOperation
        Me.gvAssignNextOperation.Name = "gvAssignNextOperation"
        '
        'colSequence
        '
        Me.colSequence.ColumnEdit = Me.txtSequence
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        '
        'txtSequence
        '
        Me.txtSequence.AutoHeight = False
        Me.txtSequence.Name = "txtSequence"
        Me.txtSequence.ReadOnly = True
        '
        'colJobNumber
        '
        Me.colJobNumber.Caption = "Job#"
        Me.colJobNumber.ColumnEdit = Me.txtNumber
        Me.colJobNumber.FieldName = "Job.Number"
        Me.colJobNumber.Name = "colJobNumber"
        Me.colJobNumber.Visible = True
        Me.colJobNumber.VisibleIndex = 0
        Me.colJobNumber.Width = 104
        '
        'txtNumber
        '
        Me.txtNumber.AutoHeight = False
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.ColumnEdit = Me.txtDescription
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 104
        '
        'txtDescription
        '
        Me.txtDescription.AutoHeight = False
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        '
        'colPartCode
        '
        Me.colPartCode.Caption = "Part Code"
        Me.colPartCode.ColumnEdit = Me.txtPartCode
        Me.colPartCode.FieldName = "Part.Code"
        Me.colPartCode.Name = "colPartCode"
        Me.colPartCode.Visible = True
        Me.colPartCode.VisibleIndex = 2
        Me.colPartCode.Width = 104
        '
        'txtPartCode
        '
        Me.txtPartCode.AutoHeight = False
        Me.txtPartCode.Name = "txtPartCode"
        Me.txtPartCode.ReadOnly = True
        '
        'colPartDescription
        '
        Me.colPartDescription.Caption = "Part Description"
        Me.colPartDescription.ColumnEdit = Me.txtPartDescr
        Me.colPartDescription.FieldName = "Part.Description"
        Me.colPartDescription.Name = "colPartDescription"
        Me.colPartDescription.Visible = True
        Me.colPartDescription.VisibleIndex = 6
        Me.colPartDescription.Width = 104
        '
        'txtPartDescr
        '
        Me.txtPartDescr.AutoHeight = False
        Me.txtPartDescr.Name = "txtPartDescr"
        Me.txtPartDescr.ReadOnly = True
        '
        'colOperationCode
        '
        Me.colOperationCode.Caption = "Operation Code"
        Me.colOperationCode.ColumnEdit = Me.txtOperationCode
        Me.colOperationCode.FieldName = "Operation.Code"
        Me.colOperationCode.Name = "colOperationCode"
        Me.colOperationCode.Visible = True
        Me.colOperationCode.VisibleIndex = 3
        Me.colOperationCode.Width = 104
        '
        'txtOperationCode
        '
        Me.txtOperationCode.AutoHeight = False
        Me.txtOperationCode.Name = "txtOperationCode"
        Me.txtOperationCode.ReadOnly = True
        '
        'colOperationDescr
        '
        Me.colOperationDescr.Caption = "Operation Description"
        Me.colOperationDescr.ColumnEdit = Me.txtOperationDescription
        Me.colOperationDescr.FieldName = "Operation.Description"
        Me.colOperationDescr.Name = "colOperationDescr"
        Me.colOperationDescr.Visible = True
        Me.colOperationDescr.VisibleIndex = 4
        Me.colOperationDescr.Width = 104
        '
        'txtOperationDescription
        '
        Me.txtOperationDescription.AutoHeight = False
        Me.txtOperationDescription.Name = "txtOperationDescription"
        Me.txtOperationDescription.ReadOnly = True
        '
        'colArtisan
        '
        Me.colArtisan.ColumnEdit = Me.riglkpArtisan
        Me.colArtisan.FieldName = "Artisan"
        Me.colArtisan.Name = "colArtisan"
        Me.colArtisan.Visible = True
        Me.colArtisan.VisibleIndex = 10
        Me.colArtisan.Width = 144
        '
        'riglkpArtisan
        '
        Me.riglkpArtisan.AutoHeight = False
        Me.riglkpArtisan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.riglkpArtisan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riglkpArtisan.DataSource = Me.ArtisanBindingSource
        Me.riglkpArtisan.DisplayMember = "Description"
        Me.riglkpArtisan.Name = "riglkpArtisan"
        Me.riglkpArtisan.NullText = "[No Artisan Selected]"
        Me.riglkpArtisan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ripbArtisanDuration})
        Me.riglkpArtisan.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'ripbArtisanDuration
        '
        Me.ripbArtisanDuration.Name = "ripbArtisanDuration"
        Me.ripbArtisanDuration.Step = 1
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription1, Me.colEstimatedDuration1, Me.colEstimatedTimespam})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 1
        '
        'colEstimatedDuration1
        '
        Me.colEstimatedDuration1.ColumnEdit = Me.ripbArtisanDuration
        Me.colEstimatedDuration1.FieldName = "EstimatedDuration"
        Me.colEstimatedDuration1.Name = "colEstimatedDuration1"
        Me.colEstimatedDuration1.Visible = True
        Me.colEstimatedDuration1.VisibleIndex = 2
        '
        'colEstimatedTimespam
        '
        Me.colEstimatedTimespam.FieldName = "EstimatedTimespam"
        Me.colEstimatedTimespam.Name = "colEstimatedTimespam"
        Me.colEstimatedTimespam.Visible = True
        Me.colEstimatedTimespam.VisibleIndex = 3
        '
        'colJobReqDate
        '
        Me.colJobReqDate.Caption = "Required Delivery Date"
        Me.colJobReqDate.ColumnEdit = Me.dtRequiredDeliveryDate
        Me.colJobReqDate.DisplayFormat.FormatString = "d"
        Me.colJobReqDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colJobReqDate.FieldName = "Job.RequiredDeliveryDate"
        Me.colJobReqDate.Name = "colJobReqDate"
        Me.colJobReqDate.Visible = True
        Me.colJobReqDate.VisibleIndex = 11
        Me.colJobReqDate.Width = 116
        '
        'dtRequiredDeliveryDate
        '
        Me.dtRequiredDeliveryDate.AutoHeight = False
        Me.dtRequiredDeliveryDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRequiredDeliveryDate.Name = "dtRequiredDeliveryDate"
        Me.dtRequiredDeliveryDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colEstimatedDuration
        '
        Me.colEstimatedDuration.ColumnEdit = Me.txtEstDuration
        Me.colEstimatedDuration.FieldName = "EstimatedDuration"
        Me.colEstimatedDuration.Name = "colEstimatedDuration"
        Me.colEstimatedDuration.Visible = True
        Me.colEstimatedDuration.VisibleIndex = 7
        Me.colEstimatedDuration.Width = 104
        '
        'txtEstDuration
        '
        Me.txtEstDuration.AutoHeight = False
        Me.txtEstDuration.Name = "txtEstDuration"
        Me.txtEstDuration.ReadOnly = True
        '
        'colActualDuration
        '
        Me.colActualDuration.ColumnEdit = Me.txtActDuration
        Me.colActualDuration.DisplayFormat.FormatString = "f"
        Me.colActualDuration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colActualDuration.FieldName = "ActualDuration"
        Me.colActualDuration.Name = "colActualDuration"
        Me.colActualDuration.Visible = True
        Me.colActualDuration.VisibleIndex = 5
        Me.colActualDuration.Width = 104
        '
        'txtActDuration
        '
        Me.txtActDuration.AutoHeight = False
        Me.txtActDuration.DisplayFormat.FormatString = "f"
        Me.txtActDuration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtActDuration.Name = "txtActDuration"
        Me.txtActDuration.ReadOnly = True
        '
        'colMaterials
        '
        Me.colMaterials.ColumnEdit = Me.chkMaterials
        Me.colMaterials.FieldName = "IsMaterialAvailable"
        Me.colMaterials.Name = "colMaterials"
        Me.colMaterials.OptionsColumn.ReadOnly = True
        Me.colMaterials.Visible = True
        Me.colMaterials.VisibleIndex = 9
        Me.colMaterials.Width = 52
        '
        'chkMaterials
        '
        Me.chkMaterials.AutoHeight = False
        Me.chkMaterials.Name = "chkMaterials"
        Me.chkMaterials.ReadOnly = True
        '
        'colCurrentState
        '
        Me.colCurrentState.ColumnEdit = Me.txtState
        Me.colCurrentState.FieldName = "CurrentState"
        Me.colCurrentState.Name = "colCurrentState"
        Me.colCurrentState.OptionsColumn.ReadOnly = True
        Me.colCurrentState.Visible = True
        Me.colCurrentState.VisibleIndex = 8
        Me.colCurrentState.Width = 104
        '
        'txtState
        '
        Me.txtState.AutoHeight = False
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        '
        'colActualStartDate
        '
        Me.colActualStartDate.ColumnEdit = Me.dtActualStartDate
        Me.colActualStartDate.DisplayFormat.FormatString = "g"
        Me.colActualStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualStartDate.FieldName = "ActualStartDate"
        Me.colActualStartDate.Name = "colActualStartDate"
        '
        'dtActualStartDate
        '
        Me.dtActualStartDate.AutoHeight = False
        Me.dtActualStartDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtActualStartDate.Name = "dtActualStartDate"
        Me.dtActualStartDate.ReadOnly = True
        Me.dtActualStartDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colEstimatedEndDate
        '
        Me.colEstimatedEndDate.ColumnEdit = Me.dtEstimatedEndDate
        Me.colEstimatedEndDate.DisplayFormat.FormatString = "g"
        Me.colEstimatedEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedEndDate.FieldName = "EstimatedEndDate"
        Me.colEstimatedEndDate.Name = "colEstimatedEndDate"
        '
        'dtEstimatedEndDate
        '
        Me.dtEstimatedEndDate.AutoHeight = False
        Me.dtEstimatedEndDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEstimatedEndDate.Name = "dtEstimatedEndDate"
        Me.dtEstimatedEndDate.ReadOnly = True
        Me.dtEstimatedEndDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colActualEndDate
        '
        Me.colActualEndDate.ColumnEdit = Me.dtActualEndDate
        Me.colActualEndDate.DisplayFormat.FormatString = "g"
        Me.colActualEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualEndDate.FieldName = "ActualEndDate"
        Me.colActualEndDate.Name = "colActualEndDate"
        Me.colActualEndDate.OptionsColumn.ReadOnly = True
        '
        'dtActualEndDate
        '
        Me.dtActualEndDate.AutoHeight = False
        Me.dtActualEndDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtActualEndDate.Name = "dtActualEndDate"
        Me.dtActualEndDate.ReadOnly = True
        Me.dtActualEndDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colActualArtisanCost
        '
        Me.colActualArtisanCost.ColumnEdit = Me.txtActualArtisanCost
        Me.colActualArtisanCost.FieldName = "ActualArtisanCost"
        Me.colActualArtisanCost.Name = "colActualArtisanCost"
        '
        'txtActualArtisanCost
        '
        Me.txtActualArtisanCost.AutoHeight = False
        Me.txtActualArtisanCost.Name = "txtActualArtisanCost"
        Me.txtActualArtisanCost.ReadOnly = True
        '
        'colActualMachineCost
        '
        Me.colActualMachineCost.ColumnEdit = Me.txtActualMachineCost
        Me.colActualMachineCost.FieldName = "ActualMachineCost"
        Me.colActualMachineCost.Name = "colActualMachineCost"
        '
        'txtActualMachineCost
        '
        Me.txtActualMachineCost.AutoHeight = False
        Me.txtActualMachineCost.Name = "txtActualMachineCost"
        Me.txtActualMachineCost.ReadOnly = True
        '
        'colActualOperationCost
        '
        Me.colActualOperationCost.ColumnEdit = Me.txtActualOperationCost
        Me.colActualOperationCost.FieldName = "ActualOperationCost"
        Me.colActualOperationCost.Name = "colActualOperationCost"
        '
        'txtActualOperationCost
        '
        Me.txtActualOperationCost.AutoHeight = False
        Me.txtActualOperationCost.Name = "txtActualOperationCost"
        Me.txtActualOperationCost.ReadOnly = True
        '
        'colEstimatedStartDate
        '
        Me.colEstimatedStartDate.ColumnEdit = Me.dtEstimatedStartDate
        Me.colEstimatedStartDate.DisplayFormat.FormatString = "g"
        Me.colEstimatedStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedStartDate.FieldName = "EstimatedStartDate"
        Me.colEstimatedStartDate.Name = "colEstimatedStartDate"
        '
        'dtEstimatedStartDate
        '
        Me.dtEstimatedStartDate.AutoHeight = False
        Me.dtEstimatedStartDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEstimatedStartDate.Name = "dtEstimatedStartDate"
        Me.dtEstimatedStartDate.ReadOnly = True
        Me.dtEstimatedStartDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colEstimatedElapsedDuration
        '
        Me.colEstimatedElapsedDuration.ColumnEdit = Me.txtEstimatedElapsedDuration
        Me.colEstimatedElapsedDuration.FieldName = "EstimatedElapsedDuration"
        Me.colEstimatedElapsedDuration.Name = "colEstimatedElapsedDuration"
        '
        'txtEstimatedElapsedDuration
        '
        Me.txtEstimatedElapsedDuration.AutoHeight = False
        Me.txtEstimatedElapsedDuration.Name = "txtEstimatedElapsedDuration"
        Me.txtEstimatedElapsedDuration.ReadOnly = True
        '
        'colActualElapsedDuration
        '
        Me.colActualElapsedDuration.ColumnEdit = Me.txtActualElapsedDuration
        Me.colActualElapsedDuration.FieldName = "ActualElapsedDuration"
        Me.colActualElapsedDuration.Name = "colActualElapsedDuration"
        '
        'txtActualElapsedDuration
        '
        Me.txtActualElapsedDuration.AutoHeight = False
        Me.txtActualElapsedDuration.Name = "txtActualElapsedDuration"
        Me.txtActualElapsedDuration.ReadOnly = True
        '
        'colEstimatedArtisanCost
        '
        Me.colEstimatedArtisanCost.ColumnEdit = Me.txtEstimatedArtisanCost
        Me.colEstimatedArtisanCost.FieldName = "EstimatedArtisanCost"
        Me.colEstimatedArtisanCost.Name = "colEstimatedArtisanCost"
        '
        'txtEstimatedArtisanCost
        '
        Me.txtEstimatedArtisanCost.AutoHeight = False
        Me.txtEstimatedArtisanCost.Name = "txtEstimatedArtisanCost"
        Me.txtEstimatedArtisanCost.ReadOnly = True
        '
        'colEstimatedMachineCost
        '
        Me.colEstimatedMachineCost.ColumnEdit = Me.txtEstimatedMachineCost
        Me.colEstimatedMachineCost.FieldName = "EstimatedMachineCost"
        Me.colEstimatedMachineCost.Name = "colEstimatedMachineCost"
        '
        'txtEstimatedMachineCost
        '
        Me.txtEstimatedMachineCost.AutoHeight = False
        Me.txtEstimatedMachineCost.Name = "txtEstimatedMachineCost"
        Me.txtEstimatedMachineCost.ReadOnly = True
        '
        'colEstimatedOperationCost
        '
        Me.colEstimatedOperationCost.ColumnEdit = Me.txtEstimatedOperationCost
        Me.colEstimatedOperationCost.FieldName = "EstimatedOperationCost"
        Me.colEstimatedOperationCost.Name = "colEstimatedOperationCost"
        '
        'txtEstimatedOperationCost
        '
        Me.txtEstimatedOperationCost.AutoHeight = False
        Me.txtEstimatedOperationCost.Name = "txtEstimatedOperationCost"
        Me.txtEstimatedOperationCost.ReadOnly = True
        '
        'colIsActualsPosted
        '
        Me.colIsActualsPosted.ColumnEdit = Me.txtIsActualsPosted
        Me.colIsActualsPosted.FieldName = "IsActualsPosted"
        Me.colIsActualsPosted.Name = "colIsActualsPosted"
        '
        'txtIsActualsPosted
        '
        Me.txtIsActualsPosted.AutoHeight = False
        Me.txtIsActualsPosted.Name = "txtIsActualsPosted"
        Me.txtIsActualsPosted.ReadOnly = True
        '
        'colIsNextActivity
        '
        Me.colIsNextActivity.ColumnEdit = Me.chkIsNextActivity
        Me.colIsNextActivity.FieldName = "IsNextActivity"
        Me.colIsNextActivity.Name = "colIsNextActivity"
        '
        'chkIsNextActivity
        '
        Me.chkIsNextActivity.AutoHeight = False
        Me.chkIsNextActivity.Name = "chkIsNextActivity"
        Me.chkIsNextActivity.ReadOnly = True
        '
        'colMachineCode
        '
        Me.colMachineCode.ColumnEdit = Me.txtMachineCode
        Me.colMachineCode.FieldName = "Machine.Code"
        Me.colMachineCode.Name = "colMachineCode"
        '
        'txtMachineCode
        '
        Me.txtMachineCode.AutoHeight = False
        Me.txtMachineCode.Name = "txtMachineCode"
        Me.txtMachineCode.ReadOnly = True
        '
        'colMachineDescription
        '
        Me.colMachineDescription.ColumnEdit = Me.txtMachineDescription
        Me.colMachineDescription.FieldName = "Machine.Description"
        Me.colMachineDescription.Name = "colMachineDescription"
        '
        'txtMachineDescription
        '
        Me.txtMachineDescription.AutoHeight = False
        Me.txtMachineDescription.Name = "txtMachineDescription"
        Me.txtMachineDescription.ReadOnly = True
        '
        'luArtisan
        '
        Me.luArtisan.AutoHeight = False
        Me.luArtisan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luArtisan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstimatedDuration", "Estimated Duration", 101, DevExpress.Utils.FormatType.Numeric, "f", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luArtisan.DataSource = Me.ArtisanBindingSource
        Me.luArtisan.DisplayMember = "Description"
        Me.luArtisan.Name = "luArtisan"
        Me.luArtisan.NullText = "[No Artisan Assigned]"
        '
        'colActualTimespan
        '
        Me.colActualTimespan.FieldName = "ActualTimespan"
        Me.colActualTimespan.Name = "colActualTimespan"
        Me.colActualTimespan.OptionsColumn.ReadOnly = True
        Me.colActualTimespan.Visible = True
        Me.colActualTimespan.VisibleIndex = 8
        '
        'colEstimatedTimespan
        '
        Me.colEstimatedTimespan.FieldName = "EstimatedTimespan"
        Me.colEstimatedTimespan.Name = "colEstimatedTimespan"
        Me.colEstimatedTimespan.OptionsColumn.ReadOnly = True
        Me.colEstimatedTimespan.Visible = True
        Me.colEstimatedTimespan.VisibleIndex = 9
        '
        'colJob
        '
        Me.colJob.FieldName = "Job"
        Me.colJob.Name = "colJob"
        Me.colJob.Visible = True
        Me.colJob.VisibleIndex = 10
        '
        'colMachine
        '
        Me.colMachine.FieldName = "Machine"
        Me.colMachine.Name = "colMachine"
        Me.colMachine.Visible = True
        Me.colMachine.VisibleIndex = 11
        '
        'colOperation
        '
        Me.colOperation.FieldName = "Operation"
        Me.colOperation.Name = "colOperation"
        Me.colOperation.Visible = True
        Me.colOperation.VisibleIndex = 12
        '
        'colPart
        '
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        Me.colPart.Visible = True
        Me.colPart.VisibleIndex = 13
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 14
        '
        'colIsLoading
        '
        Me.colIsLoading.FieldName = "IsLoading"
        Me.colIsLoading.Name = "colIsLoading"
        Me.colIsLoading.OptionsColumn.ReadOnly = True
        Me.colIsLoading.Visible = True
        Me.colIsLoading.VisibleIndex = 15
        '
        'colIsChanged
        '
        Me.colIsChanged.FieldName = "IsChanged"
        Me.colIsChanged.Name = "colIsChanged"
        Me.colIsChanged.OptionsColumn.ReadOnly = True
        Me.colIsChanged.Visible = True
        Me.colIsChanged.VisibleIndex = 16
        '
        'colValidationErrorMessages
        '
        Me.colValidationErrorMessages.FieldName = "ValidationErrorMessages"
        Me.colValidationErrorMessages.Name = "colValidationErrorMessages"
        Me.colValidationErrorMessages.OptionsColumn.ReadOnly = True
        Me.colValidationErrorMessages.Visible = True
        Me.colValidationErrorMessages.VisibleIndex = 17
        '
        'colPropertiesValidationErrorMessages
        '
        Me.colPropertiesValidationErrorMessages.FieldName = "PropertiesValidationErrorMessages"
        Me.colPropertiesValidationErrorMessages.Name = "colPropertiesValidationErrorMessages"
        Me.colPropertiesValidationErrorMessages.OptionsColumn.ReadOnly = True
        Me.colPropertiesValidationErrorMessages.Visible = True
        Me.colPropertiesValidationErrorMessages.VisibleIndex = 18
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.gcAssignNextOperation)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 22)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.UseSkinIndents = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1276, 602)
        Me.LayoutControl1.TabIndex = 16
        Me.LayoutControl1.Text = "LayoutControl1"
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
        Me.LayoutControlItem1.Control = Me.gcAssignNextOperation
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1276, 602)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'xfAssignNextActivity
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 647)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfAssignNextActivity"
        Me.ShowIcon = False
        Me.Text = "Assign Next Artisan"
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ritAutoRefreshRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAssignNextOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAssignNextOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSequence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartDescr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperationCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperationDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riglkpArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ripbArtisanDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRequiredDeliveryDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRequiredDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtActualStartDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtActualStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstimatedEndDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstimatedEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtActualEndDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtActualEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualArtisanCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualMachineCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualOperationCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstimatedStartDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstimatedStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstimatedElapsedDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualElapsedDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstimatedArtisanCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstimatedMachineCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstimatedOperationCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIsActualsPosted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsNextActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMachineCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMachineDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OperationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArtisanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivityListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents tmRefresh As System.Windows.Forms.Timer
    Friend WithEvents beiAutoRefreshRate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ritAutoRefreshRate As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents gcAssignNextOperation As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAssignNextOperation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSequence As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colJobNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNumber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colPartCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPartCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colPartDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPartDescr As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colOperationCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtOperationCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colOperationDescr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtOperationDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colArtisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luArtisan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colJobReqDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtRequiredDeliveryDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colEstimatedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEstDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colActualDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMaterials As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkMaterials As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCurrentState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtState As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtActualStartDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colEstimatedEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtEstimatedEndDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colActualEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtActualEndDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colActualArtisanCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActualArtisanCost As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colActualMachineCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActualMachineCost As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colActualOperationCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActualOperationCost As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colEstimatedStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtEstimatedStartDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colEstimatedElapsedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEstimatedElapsedDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colActualElapsedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActualElapsedDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colEstimatedArtisanCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEstimatedArtisanCost As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colEstimatedMachineCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEstimatedMachineCost As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colEstimatedOperationCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEstimatedOperationCost As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colIsActualsPosted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtIsActualsPosted As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colIsNextActivity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkIsNextActivity As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMachineCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMachineCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMachineDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMachineDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colActualTimespan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedTimespan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsLoading As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsChanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidationErrorMessages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPropertiesValidationErrorMessages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riglkpArtisan As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ripbArtisanDuration As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDuration1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedTimespam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiCancel As DevExpress.XtraBars.BarButtonItem
End Class
