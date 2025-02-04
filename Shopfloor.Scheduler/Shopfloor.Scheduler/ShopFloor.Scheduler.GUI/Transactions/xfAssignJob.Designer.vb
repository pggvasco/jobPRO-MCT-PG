<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfAssignJob
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
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLayouts = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.gcAssignJob = New DevExpress.XtraGrid.GridControl()
        Me.ActivityListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvAssignJob = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJobNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtJobNumber = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luMachine = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colOperation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luOperation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.OperationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luPart = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colJobRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtRequiredDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colJobCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtJobDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAssignJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAssignJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRequiredDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRequiredDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobDescription, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiAdd, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh, Me.bbiLayouts})
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
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiLayouts)})
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
        'bbiEdit
        '
        Me.bbiEdit.Caption = "Edit"
        Me.bbiEdit.Id = 1
        Me.bbiEdit.Name = "bbiEdit"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "Delete"
        Me.bbiDelete.Id = 2
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "Refresh"
        Me.bbiRefresh.Id = 3
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'bbiLayouts
        '
        Me.bbiLayouts.Caption = "Layouts"
        Me.bbiLayouts.Id = 4
        Me.bbiLayouts.Name = "bbiLayouts"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(601, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 239)
        Me.barDockControlBottom.Size = New System.Drawing.Size(601, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 217)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(601, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 217)
        '
        'gcAssignJob
        '
        Me.gcAssignJob.DataSource = Me.ActivityListBindingSource
        Me.gcAssignJob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAssignJob.Location = New System.Drawing.Point(0, 22)
        Me.gcAssignJob.MainView = Me.gvAssignJob
        Me.gcAssignJob.MenuManager = Me.BarManager1
        Me.gcAssignJob.Name = "gcAssignJob"
        Me.gcAssignJob.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtJobNumber, Me.txtJobDescription, Me.dtRequiredDate, Me.luPart, Me.luOperation, Me.luMachine, Me.luCustomer, Me.txtDescription})
        Me.gcAssignJob.Size = New System.Drawing.Size(601, 217)
        Me.gcAssignJob.TabIndex = 4
        Me.gcAssignJob.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAssignJob})
        '
        'ActivityListBindingSource
        '
        Me.ActivityListBindingSource.DataMember = "ActivityList"
        Me.ActivityListBindingSource.DataSource = Me.JobBindingSource
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Job)
        '
        'gvAssignJob
        '
        Me.gvAssignJob.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobNumber, Me.colMachine, Me.colOperation, Me.colPart, Me.colJobRequiredDate, Me.colJobCustomer, Me.colDescription})
        Me.gvAssignJob.GridControl = Me.gcAssignJob
        Me.gvAssignJob.Name = "gvAssignJob"
        Me.gvAssignJob.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'colJobNumber
        '
        Me.colJobNumber.Caption = "Job #"
        Me.colJobNumber.ColumnEdit = Me.txtJobNumber
        Me.colJobNumber.FieldName = "Job.Number"
        Me.colJobNumber.Name = "colJobNumber"
        Me.colJobNumber.Visible = True
        Me.colJobNumber.VisibleIndex = 0
        '
        'txtJobNumber
        '
        Me.txtJobNumber.AutoHeight = False
        Me.txtJobNumber.Name = "txtJobNumber"
        '
        'colMachine
        '
        Me.colMachine.ColumnEdit = Me.luMachine
        Me.colMachine.FieldName = "Machine"
        Me.colMachine.Name = "colMachine"
        Me.colMachine.Visible = True
        Me.colMachine.VisibleIndex = 4
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
        Me.colOperation.VisibleIndex = 5
        '
        'luOperation
        '
        Me.luOperation.AutoHeight = False
        Me.luOperation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luOperation.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rate", "Rate", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luOperation.DataSource = Me.OperationBindingSource
        Me.luOperation.DisplayMember = "Description"
        Me.luOperation.Name = "luOperation"
        Me.luOperation.NullText = "[Select Operation]"
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
        Me.colPart.VisibleIndex = 6
        '
        'luPart
        '
        Me.luPart.AutoHeight = False
        Me.luPart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luPart.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luPart.DataSource = Me.PartBindingSource
        Me.luPart.DisplayMember = "Description"
        Me.luPart.Name = "luPart"
        Me.luPart.NullText = "[Select Partl]"
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Part)
        '
        'colJobRequiredDate
        '
        Me.colJobRequiredDate.Caption = "Required Date"
        Me.colJobRequiredDate.ColumnEdit = Me.dtRequiredDate
        Me.colJobRequiredDate.FieldName = "Job.RequiredDeliveryDate"
        Me.colJobRequiredDate.Name = "colJobRequiredDate"
        Me.colJobRequiredDate.Visible = True
        Me.colJobRequiredDate.VisibleIndex = 3
        '
        'dtRequiredDate
        '
        Me.dtRequiredDate.AutoHeight = False
        Me.dtRequiredDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRequiredDate.Name = "dtRequiredDate"
        Me.dtRequiredDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colJobCustomer
        '
        Me.colJobCustomer.Caption = "Customer"
        Me.colJobCustomer.ColumnEdit = Me.luCustomer
        Me.colJobCustomer.FieldName = "Job.Customer"
        Me.colJobCustomer.Name = "colJobCustomer"
        Me.colJobCustomer.Visible = True
        Me.colJobCustomer.VisibleIndex = 2
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
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Customer)
        '
        'colDescription
        '
        Me.colDescription.ColumnEdit = Me.txtDescription
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.AutoHeight = False
        Me.txtDescription.Name = "txtDescription"
        '
        'txtJobDescription
        '
        Me.txtJobDescription.AutoHeight = False
        Me.txtJobDescription.Name = "txtJobDescription"
        '
        'xfAssignJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 262)
        Me.Controls.Add(Me.gcAssignJob)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfAssignJob"
        Me.Text = "Assign Job"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAssignJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAssignJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRequiredDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRequiredDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobDescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLayouts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents gcAssignJob As DevExpress.XtraGrid.GridControl
    Friend WithEvents ActivityListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gvAssignJob As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJobNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtJobNumber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luMachine As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luOperation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OperationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luPart As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colJobRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtRequiredDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colJobCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luCustomer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtJobDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
