<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfAssignNextOperation
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
        Me.gcAssignNextOperation = New DevExpress.XtraGrid.GridControl()
        Me.ActivityListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvAssignNextOperation = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.colArtisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ArtisanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colActualDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtActualDuration = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtDuration = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLayouts = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.gcAssignNextOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAssignNextOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcAssignNextOperation
        '
        Me.gcAssignNextOperation.DataSource = Me.ActivityListBindingSource
        Me.gcAssignNextOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAssignNextOperation.Location = New System.Drawing.Point(0, 22)
        Me.gcAssignNextOperation.MainView = Me.gvAssignNextOperation
        Me.gcAssignNextOperation.Name = "gcAssignNextOperation"
        Me.gcAssignNextOperation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtJobNumber, Me.txtDuration, Me.luMachine, Me.luOperation, Me.luPart, Me.luArtisan, Me.txtActualDuration})
        Me.gcAssignNextOperation.Size = New System.Drawing.Size(625, 217)
        Me.gcAssignNextOperation.TabIndex = 0
        Me.gcAssignNextOperation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAssignNextOperation})
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
        'gvAssignNextOperation
        '
        Me.gvAssignNextOperation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobNumber, Me.colMachine, Me.colOperation, Me.colPart, Me.colArtisan, Me.colActualDuration})
        Me.gvAssignNextOperation.GridControl = Me.gcAssignNextOperation
        Me.gvAssignNextOperation.Name = "gvAssignNextOperation"
        Me.gvAssignNextOperation.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'colJobNumber
        '
        Me.colJobNumber.Caption = "Job #"
        Me.colJobNumber.ColumnEdit = Me.txtJobNumber
        Me.colJobNumber.FieldName = "Job"
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
        Me.colMachine.VisibleIndex = 1
        '
        'luMachine
        '
        Me.luMachine.AutoHeight = False
        Me.luMachine.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luMachine.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luMachine.DataSource = Me.MachineBindingSource
        Me.luMachine.DisplayMember = "Description"
        Me.luMachine.Name = "luMachine"
        Me.luMachine.NullText = "[Select Machinel]"
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
        Me.colOperation.VisibleIndex = 2
        '
        'luOperation
        '
        Me.luOperation.AutoHeight = False
        Me.luOperation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luOperation.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rate", "Rate", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsBuyOut", "Is Buy Out", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luOperation.DataSource = Me.OperationBindingSource
        Me.luOperation.DisplayMember = "Code"
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
        Me.colPart.VisibleIndex = 3
        '
        'luPart
        '
        Me.luPart.AutoHeight = False
        Me.luPart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luPart.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luPart.DataSource = Me.PartBindingSource
        Me.luPart.DisplayMember = "Code"
        Me.luPart.Name = "luPart"
        Me.luPart.NullText = "[Select Part]"
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Part)
        '
        'colArtisan
        '
        Me.colArtisan.ColumnEdit = Me.luArtisan
        Me.colArtisan.FieldName = "Artisan"
        Me.colArtisan.Name = "colArtisan"
        Me.colArtisan.Visible = True
        Me.colArtisan.VisibleIndex = 4
        '
        'luArtisan
        '
        Me.luArtisan.AutoHeight = False
        Me.luArtisan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luArtisan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luArtisan.DataSource = Me.ArtisanBindingSource
        Me.luArtisan.DisplayMember = "Description"
        Me.luArtisan.Name = "luArtisan"
        Me.luArtisan.NullText = "[Select Artisanl]"
        '
        'ArtisanBindingSource
        '
        Me.ArtisanBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Artisan)
        '
        'colActualDuration
        '
        Me.colActualDuration.Caption = "Duration"
        Me.colActualDuration.ColumnEdit = Me.txtActualDuration
        Me.colActualDuration.FieldName = "ActualDuration"
        Me.colActualDuration.Name = "colActualDuration"
        Me.colActualDuration.Visible = True
        Me.colActualDuration.VisibleIndex = 5
        '
        'txtActualDuration
        '
        Me.txtActualDuration.AutoHeight = False
        Me.txtActualDuration.Name = "txtActualDuration"
        '
        'txtDuration
        '
        Me.txtDuration.AutoHeight = False
        Me.txtDuration.Name = "txtDuration"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiAdd, Me.bbiEdit, Me.bbiDelete, Me.bbiLayouts, Me.bbiExportGrid})
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
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiLayouts), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportGrid)})
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
        'bbiLayouts
        '
        Me.bbiLayouts.Caption = "Layouts"
        Me.bbiLayouts.Id = 3
        Me.bbiLayouts.Name = "bbiLayouts"
        '
        'bbiExportGrid
        '
        Me.bbiExportGrid.Caption = "Export Grid"
        Me.bbiExportGrid.Id = 4
        Me.bbiExportGrid.Name = "bbiExportGrid"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(625, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 239)
        Me.barDockControlBottom.Size = New System.Drawing.Size(625, 23)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(625, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 217)
        '
        'xfAssignNextOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 262)
        Me.Controls.Add(Me.gcAssignNextOperation)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfAssignNextOperation"
        Me.Text = "Assign Next Operation"
        CType(Me.gcAssignNextOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAssignNextOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcAssignNextOperation As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAssignNextOperation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLayouts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ActivityListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colJobNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtJobNumber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luMachine As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luOperation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OperationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luPart As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colArtisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luArtisan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ArtisanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colActualDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActualDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
