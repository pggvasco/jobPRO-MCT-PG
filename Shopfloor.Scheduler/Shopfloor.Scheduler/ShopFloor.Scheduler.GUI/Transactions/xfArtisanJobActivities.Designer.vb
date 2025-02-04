<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfArtisanJobActivities
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
        Me.bbiAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.gcArtisanJobActivity = New DevExpress.XtraGrid.GridControl()
        Me.ActivityListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvArtisanJobActivity = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJobNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtJobNumber = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colArtisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ArtisanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luMachine = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colOperation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luOperation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.OperationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luPart = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colJobCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luJobCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colJobRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtDueDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.luCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.dtRequiredDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.ActivityListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcArtisanJobActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArtisanJobActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luJobCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDueDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRequiredDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRequiredDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiAdd, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'bbiAdd
        '
        Me.bbiAdd.Caption = "Add"
        Me.bbiAdd.Id = 0
        Me.bbiAdd.Name = "bbiAdd"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Edit"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Delete"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Refresh"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Layouts"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(632, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 237)
        Me.barDockControlBottom.Size = New System.Drawing.Size(632, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 215)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(632, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 215)
        '
        'gcArtisanJobActivity
        '
        Me.gcArtisanJobActivity.DataSource = Me.ActivityListBindingSource1
        Me.gcArtisanJobActivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcArtisanJobActivity.Location = New System.Drawing.Point(0, 22)
        Me.gcArtisanJobActivity.MainView = Me.gvArtisanJobActivity
        Me.gcArtisanJobActivity.MenuManager = Me.BarManager1
        Me.gcArtisanJobActivity.Name = "gcArtisanJobActivity"
        Me.gcArtisanJobActivity.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtJobNumber, Me.luArtisan, Me.txtDescription, Me.luMachine, Me.luOperation, Me.luPart, Me.luCustomer, Me.dtRequiredDate, Me.luJobCustomer, Me.dtDueDate})
        Me.gcArtisanJobActivity.Size = New System.Drawing.Size(632, 215)
        Me.gcArtisanJobActivity.TabIndex = 4
        Me.gcArtisanJobActivity.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArtisanJobActivity})
        '
        'ActivityListBindingSource1
        '
        Me.ActivityListBindingSource1.DataMember = "ActivityList"
        Me.ActivityListBindingSource1.DataSource = Me.JobBindingSource
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Job)
        '
        'gvArtisanJobActivity
        '
        Me.gvArtisanJobActivity.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobNumber, Me.colArtisan, Me.colDescription, Me.colMachine, Me.colOperation, Me.colPart, Me.colJobCustomer, Me.colJobRequiredDate})
        Me.gvArtisanJobActivity.GridControl = Me.gcArtisanJobActivity
        Me.gvArtisanJobActivity.Name = "gvArtisanJobActivity"
        Me.gvArtisanJobActivity.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'colJobNumber
        '
        Me.colJobNumber.Caption = "Job #"
        Me.colJobNumber.ColumnEdit = Me.txtJobNumber
        Me.colJobNumber.FieldName = "Job.Number"
        Me.colJobNumber.Name = "colJobNumber"
        Me.colJobNumber.Visible = True
        Me.colJobNumber.VisibleIndex = 1
        '
        'txtJobNumber
        '
        Me.txtJobNumber.AutoHeight = False
        Me.txtJobNumber.Name = "txtJobNumber"
        '
        'colArtisan
        '
        Me.colArtisan.ColumnEdit = Me.luArtisan
        Me.colArtisan.FieldName = "Artisan"
        Me.colArtisan.Name = "colArtisan"
        Me.colArtisan.Visible = True
        Me.colArtisan.VisibleIndex = 0
        '
        'luArtisan
        '
        Me.luArtisan.AutoHeight = False
        Me.luArtisan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luArtisan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luArtisan.DataSource = Me.ArtisanBindingSource
        Me.luArtisan.DisplayMember = "Description"
        Me.luArtisan.Name = "luArtisan"
        Me.luArtisan.NullText = "[Select Artisan]"
        '
        'ArtisanBindingSource
        '
        Me.ArtisanBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Artisan)
        '
        'colDescription
        '
        Me.colDescription.ColumnEdit = Me.txtDescription
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.AutoHeight = False
        Me.txtDescription.Name = "txtDescription"
        '
        'colMachine
        '
        Me.colMachine.ColumnEdit = Me.luMachine
        Me.colMachine.FieldName = "Machine"
        Me.colMachine.Name = "colMachine"
        Me.colMachine.Visible = True
        Me.colMachine.VisibleIndex = 2
        '
        'luMachine
        '
        Me.luMachine.AutoHeight = False
        Me.luMachine.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luMachine.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luMachine.DataSource = Me.MachineBindingSource
        Me.luMachine.DisplayMember = "Description"
        Me.luMachine.Name = "luMachine"
        Me.luMachine.NullText = "[Select Machine]"
        '
        'MachineBindingSource
        '
        Me.MachineBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Machine)
        '
        'colOperation
        '
        Me.colOperation.ColumnEdit = Me.luOperation
        Me.colOperation.FieldName = "Operation"
        Me.colOperation.Name = "colOperation"
        Me.colOperation.Visible = True
        Me.colOperation.VisibleIndex = 3
        '
        'luOperation
        '
        Me.luOperation.AutoHeight = False
        Me.luOperation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luOperation.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rate", "Rate", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsBuyOut", "Is Buy Out", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luOperation.DataSource = Me.OperationBindingSource
        Me.luOperation.DisplayMember = "Description"
        Me.luOperation.Name = "luOperation"
        Me.luOperation.NullText = "[Select Operationl]"
        '
        'OperationBindingSource
        '
        Me.OperationBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Operation)
        '
        'colPart
        '
        Me.colPart.ColumnEdit = Me.luPart
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        Me.colPart.Visible = True
        Me.colPart.VisibleIndex = 4
        '
        'luPart
        '
        Me.luPart.AutoHeight = False
        Me.luPart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luPart.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luPart.DataSource = Me.PartBindingSource
        Me.luPart.DisplayMember = "Description"
        Me.luPart.Name = "luPart"
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Part)
        '
        'colJobCustomer
        '
        Me.colJobCustomer.Caption = "Customer"
        Me.colJobCustomer.ColumnEdit = Me.luJobCustomer
        Me.colJobCustomer.FieldName = "Job.Customer"
        Me.colJobCustomer.Name = "colJobCustomer"
        Me.colJobCustomer.Visible = True
        Me.colJobCustomer.VisibleIndex = 6
        '
        'luJobCustomer
        '
        Me.luJobCustomer.AutoHeight = False
        Me.luJobCustomer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luJobCustomer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luJobCustomer.DataSource = Me.CustomerBindingSource
        Me.luJobCustomer.DisplayMember = "Description"
        Me.luJobCustomer.Name = "luJobCustomer"
        Me.luJobCustomer.NullText = "[Select Customer]"
        Me.luJobCustomer.ValueMember = "ID"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Customer)
        '
        'colJobRequiredDate
        '
        Me.colJobRequiredDate.Caption = "Required Date"
        Me.colJobRequiredDate.ColumnEdit = Me.dtDueDate
        Me.colJobRequiredDate.FieldName = "Job.RequiredDeliveryDate"
        Me.colJobRequiredDate.Name = "colJobRequiredDate"
        Me.colJobRequiredDate.Visible = True
        Me.colJobRequiredDate.VisibleIndex = 7
        '
        'dtDueDate
        '
        Me.dtDueDate.AutoHeight = False
        Me.dtDueDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDueDate.Name = "dtDueDate"
        Me.dtDueDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'luCustomer
        '
        Me.luCustomer.AutoHeight = False
        Me.luCustomer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luCustomer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luCustomer.DataSource = Me.CustomerBindingSource
        Me.luCustomer.DisplayMember = "Description"
        Me.luCustomer.Name = "luCustomer"
        Me.luCustomer.NullText = "[Select Customerl]"
        '
        'dtRequiredDate
        '
        Me.dtRequiredDate.AutoHeight = False
        Me.dtRequiredDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRequiredDate.Name = "dtRequiredDate"
        Me.dtRequiredDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'ActivityListBindingSource
        '
        Me.ActivityListBindingSource.DataMember = "ActivityList"
        Me.ActivityListBindingSource.DataSource = Me.JobBindingSource
        '
        'xfArtisanJobActivities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 262)
        Me.Controls.Add(Me.gcArtisanJobActivity)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfArtisanJobActivities"
        Me.Text = "Artisan Job Activity"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcArtisanJobActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArtisanJobActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luJobCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDueDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRequiredDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRequiredDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcArtisanJobActivity As DevExpress.XtraGrid.GridControl
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gvArtisanJobActivity As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJobNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtJobNumber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colArtisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luArtisan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ArtisanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luMachine As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luOperation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OperationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luPart As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents luCustomer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivityListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtRequiredDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ActivityListBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents colJobCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luJobCustomer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colJobRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtDueDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
