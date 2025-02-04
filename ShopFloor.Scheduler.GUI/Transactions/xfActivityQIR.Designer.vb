<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfActivityQIR
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
        Me.lcActivityQIR = New DevExpress.XtraLayout.LayoutControl()
        Me.gcActivityQIR = New DevExpress.XtraGrid.GridControl()
        Me.ActivityListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvActivityQIR = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOperation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ritOperation = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ritDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colActualDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.speDuration = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.txtJobNumber = New DevExpress.XtraEditors.TextEdit()
        Me.ActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPartNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciJobNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPartNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.lcActivityQIR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lcActivityQIR.SuspendLayout()
        CType(Me.gcActivityQIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvActivityQIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ritOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ritDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lcActivityQIR
        '
        Me.lcActivityQIR.Controls.Add(Me.gcActivityQIR)
        Me.lcActivityQIR.Controls.Add(Me.txtJobNumber)
        Me.lcActivityQIR.Controls.Add(Me.txtPartNumber)
        Me.lcActivityQIR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lcActivityQIR.Location = New System.Drawing.Point(0, 22)
        Me.lcActivityQIR.Name = "lcActivityQIR"
        Me.lcActivityQIR.OptionsView.UseSkinIndents = False
        Me.lcActivityQIR.Root = Me.LayoutControlGroup1
        Me.lcActivityQIR.Size = New System.Drawing.Size(831, 379)
        Me.lcActivityQIR.TabIndex = 0
        Me.lcActivityQIR.Text = "LayoutControl1"
        '
        'gcActivityQIR
        '
        Me.gcActivityQIR.DataSource = Me.ActivityListBindingSource
        Me.gcActivityQIR.Location = New System.Drawing.Point(5, 35)
        Me.gcActivityQIR.MainView = Me.gvActivityQIR
        Me.gcActivityQIR.Name = "gcActivityQIR"
        Me.gcActivityQIR.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.speDuration, Me.ritOperation, Me.ritDescription})
        Me.gcActivityQIR.ShowOnlyPredefinedDetails = True
        Me.gcActivityQIR.Size = New System.Drawing.Size(821, 339)
        Me.gcActivityQIR.TabIndex = 6
        Me.gcActivityQIR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvActivityQIR})
        '
        'ActivityListBindingSource
        '
        Me.ActivityListBindingSource.DataSource = Me.ActivityBindingSource
        '
        'gvActivityQIR
        '
        Me.gvActivityQIR.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOperation, Me.colDescription, Me.colActualDuration})
        Me.gvActivityQIR.GridControl = Me.gcActivityQIR
        Me.gvActivityQIR.Name = "gvActivityQIR"
        '
        'colOperation
        '
        Me.colOperation.Caption = "Operation"
        Me.colOperation.ColumnEdit = Me.ritOperation
        Me.colOperation.FieldName = "Operation"
        Me.colOperation.Name = "colOperation"
        Me.colOperation.Visible = True
        Me.colOperation.VisibleIndex = 0
        '
        'ritOperation
        '
        Me.ritOperation.AutoHeight = False
        Me.ritOperation.Name = "ritOperation"
        Me.ritOperation.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.ColumnEdit = Me.ritDescription
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        '
        'ritDescription
        '
        Me.ritDescription.AutoHeight = False
        Me.ritDescription.Name = "ritDescription"
        Me.ritDescription.ReadOnly = True
        '
        'colActualDuration
        '
        Me.colActualDuration.Caption = "Duration"
        Me.colActualDuration.ColumnEdit = Me.speDuration
        Me.colActualDuration.FieldName = "EstimatedDuration"
        Me.colActualDuration.Name = "colActualDuration"
        Me.colActualDuration.Visible = True
        Me.colActualDuration.VisibleIndex = 2
        '
        'speDuration
        '
        Me.speDuration.AutoHeight = False
        Me.speDuration.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.speDuration.Name = "speDuration"
        '
        'txtJobNumber
        '
        Me.txtJobNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "Job", True))
        Me.txtJobNumber.Location = New System.Drawing.Point(38, 5)
        Me.txtJobNumber.Name = "txtJobNumber"
        Me.txtJobNumber.Properties.ReadOnly = True
        Me.txtJobNumber.Size = New System.Drawing.Size(372, 20)
        Me.txtJobNumber.StyleController = Me.lcActivityQIR
        Me.txtJobNumber.TabIndex = 4
        '
        'ActivityBindingSource
        '
        Me.ActivityBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Activity)
        '
        'txtPartNumber
        '
        Me.txtPartNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "Part", True))
        Me.txtPartNumber.Location = New System.Drawing.Point(475, 5)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Properties.ReadOnly = True
        Me.txtPartNumber.Size = New System.Drawing.Size(351, 20)
        Me.txtPartNumber.StyleController = Me.lcActivityQIR
        Me.txtPartNumber.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciJobNumber, Me.lciPartNumber, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(831, 379)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lciJobNumber
        '
        Me.lciJobNumber.Control = Me.txtJobNumber
        Me.lciJobNumber.CustomizationFormText = "Job #"
        Me.lciJobNumber.Location = New System.Drawing.Point(0, 0)
        Me.lciJobNumber.Name = "lciJobNumber"
        Me.lciJobNumber.Size = New System.Drawing.Size(415, 30)
        Me.lciJobNumber.Text = "Job #"
        Me.lciJobNumber.TextSize = New System.Drawing.Size(28, 13)
        Me.lciJobNumber.TextToControlDistance = 5
        '
        'lciPartNumber
        '
        Me.lciPartNumber.Control = Me.txtPartNumber
        Me.lciPartNumber.CustomizationFormText = "Part #"
        Me.lciPartNumber.Location = New System.Drawing.Point(415, 0)
        Me.lciPartNumber.Name = "lciPartNumber"
        Me.lciPartNumber.Size = New System.Drawing.Size(416, 30)
        Me.lciPartNumber.Text = "Part #"
        Me.lciPartNumber.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciPartNumber.TextSize = New System.Drawing.Size(50, 20)
        Me.lciPartNumber.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gcActivityQIR
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(831, 349)
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiSave})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave)})
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
        Me.barDockControlTop.Size = New System.Drawing.Size(831, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 401)
        Me.barDockControlBottom.Size = New System.Drawing.Size(831, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 379)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(831, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 379)
        '
        'xfActivityQIR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 424)
        Me.Controls.Add(Me.lcActivityQIR)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfActivityQIR"
        Me.Text = "Activity QIR"
        CType(Me.lcActivityQIR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lcActivityQIR.ResumeLayout(False)
        CType(Me.gcActivityQIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvActivityQIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ritOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ritDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lcActivityQIR As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents gcActivityQIR As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvActivityQIR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOperation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ritOperation As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ritDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colActualDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents speDuration As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents txtJobNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPartNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciJobNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciPartNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ActivityListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivityBindingSource As System.Windows.Forms.BindingSource
End Class
