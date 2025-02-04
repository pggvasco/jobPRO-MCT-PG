<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfAssignPrimaryQIRArtisan
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.beiAutoRefreshRate = New DevExpress.XtraBars.BarEditItem()
        Me.ritAutoRefreshRate = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.gcAssignQIR = New DevExpress.XtraGrid.GridControl()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvAssignQIR = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCustomerCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCustomer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCustomerDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colRequiredDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArtisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luQIRPrimaryArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ArtisanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPrimaryOperationHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsMaterialAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btDrawing = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colActualEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobCard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActivity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtActivity = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtReason = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.QIRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tmRefresh = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ritAutoRefreshRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAssignQIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAssignQIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luQIRPrimaryArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QIRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiCancel, Me.bbiRefresh, Me.beiAutoRefreshRate})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ritAutoRefreshRate})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(156, 151)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCancel), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.beiAutoRefreshRate)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'bbiCancel
        '
        Me.bbiCancel.Caption = "Cancel"
        Me.bbiCancel.Id = 0
        Me.bbiCancel.Name = "bbiCancel"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "Refresh"
        Me.bbiRefresh.Id = 1
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'beiAutoRefreshRate
        '
        Me.beiAutoRefreshRate.Caption = "Auto Re&fresh Rate"
        Me.beiAutoRefreshRate.Edit = Me.ritAutoRefreshRate
        Me.beiAutoRefreshRate.EditValue = "0"
        Me.beiAutoRefreshRate.Id = 2
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1129, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 475)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1129, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 453)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1129, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 453)
        '
        'gcAssignQIR
        '
        Me.gcAssignQIR.DataSource = Me.JobBindingSource
        Me.gcAssignQIR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAssignQIR.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcAssignQIR.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcAssignQIR.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcAssignQIR.Location = New System.Drawing.Point(0, 22)
        Me.gcAssignQIR.MainView = Me.gvAssignQIR
        Me.gcAssignQIR.MenuManager = Me.BarManager1
        Me.gcAssignQIR.Name = "gcAssignQIR"
        Me.gcAssignQIR.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtActivity, Me.txtReason, Me.txtCustomerDescription, Me.txtCustomerCode, Me.btDrawing, Me.luQIRPrimaryArtisan})
        Me.gcAssignQIR.ShowOnlyPredefinedDetails = True
        Me.gcAssignQIR.Size = New System.Drawing.Size(1129, 453)
        Me.gcAssignQIR.TabIndex = 4
        Me.gcAssignQIR.UseEmbeddedNavigator = True
        Me.gcAssignQIR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAssignQIR})
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Job)
        '
        'gvAssignQIR
        '
        Me.gvAssignQIR.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumber, Me.colDescription, Me.colCustomer, Me.colCustomer1, Me.colRequiredDeliveryDate, Me.colArtisan, Me.colPrimaryOperationHours, Me.colIsMaterialAvailable, Me.colActualStartDate, Me.colEstimatedStartDate, Me.colDrawing, Me.colActualEndDate, Me.colEstimatedDeliveryDate, Me.colEstimatedEndDate, Me.colJobCard, Me.colJobDate, Me.colLastActivity, Me.colOrderPrice, Me.colTotalCost})
        Me.gvAssignQIR.GridControl = Me.gcAssignQIR
        Me.gvAssignQIR.Name = "gvAssignQIR"
        Me.gvAssignQIR.OptionsView.ShowFooter = True
        '
        'colNumber
        '
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 0
        Me.colNumber.Width = 101
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 101
        '
        'colCustomer
        '
        Me.colCustomer.Caption = "Customer Code"
        Me.colCustomer.ColumnEdit = Me.txtCustomerCode
        Me.colCustomer.FieldName = "Customer.Code"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 2
        Me.colCustomer.Width = 101
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.AutoHeight = False
        Me.txtCustomerCode.Name = "txtCustomerCode"
        '
        'colCustomer1
        '
        Me.colCustomer1.Caption = "Customer Description"
        Me.colCustomer1.ColumnEdit = Me.txtCustomerDescription
        Me.colCustomer1.FieldName = "Customer.Description"
        Me.colCustomer1.Name = "colCustomer1"
        Me.colCustomer1.Visible = True
        Me.colCustomer1.VisibleIndex = 3
        Me.colCustomer1.Width = 101
        '
        'txtCustomerDescription
        '
        Me.txtCustomerDescription.AutoHeight = False
        Me.txtCustomerDescription.Name = "txtCustomerDescription"
        '
        'colRequiredDeliveryDate
        '
        Me.colRequiredDeliveryDate.FieldName = "RequiredDeliveryDate"
        Me.colRequiredDeliveryDate.Name = "colRequiredDeliveryDate"
        Me.colRequiredDeliveryDate.Visible = True
        Me.colRequiredDeliveryDate.VisibleIndex = 4
        Me.colRequiredDeliveryDate.Width = 101
        '
        'colArtisan
        '
        Me.colArtisan.ColumnEdit = Me.luQIRPrimaryArtisan
        Me.colArtisan.FieldName = "PrimaryArtisan"
        Me.colArtisan.Name = "colArtisan"
        Me.colArtisan.Visible = True
        Me.colArtisan.VisibleIndex = 5
        Me.colArtisan.Width = 101
        '
        'luQIRPrimaryArtisan
        '
        Me.luQIRPrimaryArtisan.AutoHeight = False
        Me.luQIRPrimaryArtisan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luQIRPrimaryArtisan.DataSource = Me.ArtisanBindingSource
        Me.luQIRPrimaryArtisan.DisplayMember = "Description"
        Me.luQIRPrimaryArtisan.Name = "luQIRPrimaryArtisan"
        Me.luQIRPrimaryArtisan.NullText = "[Select Artisan]"
        '
        'ArtisanBindingSource
        '
        Me.ArtisanBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Artisan)
        '
        'colPrimaryOperationHours
        '
        Me.colPrimaryOperationHours.FieldName = "PrimaryOperationHours"
        Me.colPrimaryOperationHours.Name = "colPrimaryOperationHours"
        Me.colPrimaryOperationHours.Visible = True
        Me.colPrimaryOperationHours.VisibleIndex = 6
        Me.colPrimaryOperationHours.Width = 101
        '
        'colIsMaterialAvailable
        '
        Me.colIsMaterialAvailable.FieldName = "IsMaterialAvailable"
        Me.colIsMaterialAvailable.Name = "colIsMaterialAvailable"
        Me.colIsMaterialAvailable.Visible = True
        Me.colIsMaterialAvailable.VisibleIndex = 7
        Me.colIsMaterialAvailable.Width = 101
        '
        'colActualStartDate
        '
        Me.colActualStartDate.FieldName = "ActualStartDate"
        Me.colActualStartDate.Name = "colActualStartDate"
        Me.colActualStartDate.Visible = True
        Me.colActualStartDate.VisibleIndex = 8
        Me.colActualStartDate.Width = 101
        '
        'colEstimatedStartDate
        '
        Me.colEstimatedStartDate.FieldName = "EstimatedStartDate"
        Me.colEstimatedStartDate.Name = "colEstimatedStartDate"
        Me.colEstimatedStartDate.Visible = True
        Me.colEstimatedStartDate.VisibleIndex = 9
        Me.colEstimatedStartDate.Width = 101
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
        Me.btDrawing.AutoHeight = False
        Me.btDrawing.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btDrawing.Name = "btDrawing"
        Me.btDrawing.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colActualEndDate
        '
        Me.colActualEndDate.FieldName = "ActualEndDate"
        Me.colActualEndDate.Name = "colActualEndDate"
        '
        'colEstimatedDeliveryDate
        '
        Me.colEstimatedDeliveryDate.FieldName = "EstimatedDeliveryDate"
        Me.colEstimatedDeliveryDate.Name = "colEstimatedDeliveryDate"
        '
        'colEstimatedEndDate
        '
        Me.colEstimatedEndDate.FieldName = "EstimatedEndDate"
        Me.colEstimatedEndDate.Name = "colEstimatedEndDate"
        '
        'colJobCard
        '
        Me.colJobCard.FieldName = "JobCard"
        Me.colJobCard.Name = "colJobCard"
        '
        'colJobDate
        '
        Me.colJobDate.FieldName = "JobDate"
        Me.colJobDate.Name = "colJobDate"
        '
        'colLastActivity
        '
        Me.colLastActivity.FieldName = "LastActivity"
        Me.colLastActivity.Name = "colLastActivity"
        '
        'colOrderPrice
        '
        Me.colOrderPrice.FieldName = "OrderPrice"
        Me.colOrderPrice.Name = "colOrderPrice"
        '
        'colTotalCost
        '
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.Name = "colTotalCost"
        '
        'txtActivity
        '
        Me.txtActivity.AutoHeight = False
        Me.txtActivity.Name = "txtActivity"
        '
        'txtReason
        '
        Me.txtReason.AutoHeight = False
        Me.txtReason.Name = "txtReason"
        '
        'QIRBindingSource
        '
        Me.QIRBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.QIR)
        '
        'ActivityBindingSource
        '
        Me.ActivityBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Activity)
        '
        'ReasonBindingSource
        '
        Me.ReasonBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.ReasonCode)
        '
        'tmRefresh
        '
        '
        'xfAssignPrimaryQIRArtisan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 498)
        Me.Controls.Add(Me.gcAssignQIR)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfAssignPrimaryQIRArtisan"
        Me.Text = "Assign Primary QIR Artisan"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ritAutoRefreshRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAssignQIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAssignQIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luQIRPrimaryArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QIRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents beiAutoRefreshRate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ritAutoRefreshRate As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents gcAssignQIR As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAssignQIR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents QIRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtActivity As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtReason As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCustomerCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCustomer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCustomerDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colRequiredDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArtisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimaryOperationHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMaterialAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btDrawing As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents luQIRPrimaryArtisan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ArtisanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colActualEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobCard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActivity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tmRefresh As System.Windows.Forms.Timer
End Class
