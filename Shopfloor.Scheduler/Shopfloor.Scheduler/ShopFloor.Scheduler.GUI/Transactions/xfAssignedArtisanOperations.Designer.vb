<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfAssignedArtisanOperations
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
        Me.gcAssignedArtisanOperation = New DevExpress.XtraGrid.GridControl()
        Me.ActivityListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvAssignedArtisanOperation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumber = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colArtisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luArtisan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ArtisanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colOperation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luOperation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.OperationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luPart = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colActualDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtActualDuration = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.gcAssignedArtisanOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAssignedArtisanOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcAssignedArtisanOperation
        '
        Me.gcAssignedArtisanOperation.DataSource = Me.ActivityListBindingSource
        Me.gcAssignedArtisanOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAssignedArtisanOperation.Location = New System.Drawing.Point(0, 22)
        Me.gcAssignedArtisanOperation.MainView = Me.gvAssignedArtisanOperation
        Me.gcAssignedArtisanOperation.Name = "gcAssignedArtisanOperation"
        Me.gcAssignedArtisanOperation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNumber, Me.txtDescription, Me.luArtisan, Me.luOperation, Me.luPart, Me.txtActualDuration})
        Me.gcAssignedArtisanOperation.Size = New System.Drawing.Size(692, 273)
        Me.gcAssignedArtisanOperation.TabIndex = 0
        Me.gcAssignedArtisanOperation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAssignedArtisanOperation})
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
        'gvAssignedArtisanOperation
        '
        Me.gvAssignedArtisanOperation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumber, Me.colDescription, Me.colArtisan, Me.colOperation, Me.colPart, Me.colActualDuration})
        Me.gvAssignedArtisanOperation.GridControl = Me.gcAssignedArtisanOperation
        Me.gvAssignedArtisanOperation.Name = "gvAssignedArtisanOperation"
        Me.gvAssignedArtisanOperation.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'colNumber
        '
        Me.colNumber.Caption = "Job #"
        Me.colNumber.ColumnEdit = Me.txtNumber
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 0
        '
        'txtNumber
        '
        Me.txtNumber.AutoHeight = False
        Me.txtNumber.Name = "txtNumber"
        '
        'colDescription
        '
        Me.colDescription.Caption = "Job Description"
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
        'colArtisan
        '
        Me.colArtisan.ColumnEdit = Me.luArtisan
        Me.colArtisan.FieldName = "Artisan"
        Me.colArtisan.Name = "colArtisan"
        Me.colArtisan.Visible = True
        Me.colArtisan.VisibleIndex = 2
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
        Me.luPart.NullText = "[Select Part]"
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Part)
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiAdd, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh})
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
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRefresh)})
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
        Me.barDockControlTop.Size = New System.Drawing.Size(692, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 295)
        Me.barDockControlBottom.Size = New System.Drawing.Size(692, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 273)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(692, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 273)
        '
        'xfAssignedArtisanOperations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 318)
        Me.Controls.Add(Me.gcAssignedArtisanOperation)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfAssignedArtisanOperations"
        Me.Text = "Assigned Artisan Operation"
        CType(Me.gcAssignedArtisanOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAssignedArtisanOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcAssignedArtisanOperation As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAssignedArtisanOperation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ActivityListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNumber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colArtisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luArtisan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ArtisanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luOperation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OperationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luPart As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents colActualDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActualDuration As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
