<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfJobAttachment
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gcAttachments = New DevExpress.XtraGrid.GridControl()
        Me.lvAttachments = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colIcon = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.ripeIcon = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_colIcon = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colDescription = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.ripeBrowseAttachment = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.riteDescription = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.bbiSaveAttachment = New DevExpress.XtraBars.BarButtonItem()
        Me.pmAttachments = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbiAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiView = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ripeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ripeBrowseAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riteDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pmAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.API.JobAttachment)
        '
        'gcAttachments
        '
        Me.gcAttachments.DataSource = Me.BindingSource
        Me.gcAttachments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAttachments.Location = New System.Drawing.Point(0, 22)
        Me.gcAttachments.MainView = Me.lvAttachments
        Me.gcAttachments.Name = "gcAttachments"
        Me.gcAttachments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ripeBrowseAttachment, Me.ripeIcon, Me.riteDescription})
        Me.gcAttachments.Size = New System.Drawing.Size(777, 422)
        Me.gcAttachments.TabIndex = 9
        Me.gcAttachments.UseEmbeddedNavigator = True
        Me.gcAttachments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvAttachments})
        '
        'lvAttachments
        '
        Me.lvAttachments.CardMinSize = New System.Drawing.Size(178, 177)
        Me.lvAttachments.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colName, Me.colIcon, Me.colDescription})
        Me.lvAttachments.GridControl = Me.gcAttachments
        Me.lvAttachments.Name = "lvAttachments"
        Me.lvAttachments.OptionsView.ShowHeaderPanel = False
        Me.lvAttachments.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel
        Me.lvAttachments.TemplateCard = Me.LayoutViewCard1
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.LayoutViewField = Me.layoutViewField_colName
        Me.colName.Name = "colName"
        Me.colName.OptionsColumn.AllowEdit = False
        Me.colName.OptionsColumn.ReadOnly = True
        Me.colName.OptionsField.SortFilterButtonShowMode = DevExpress.XtraGrid.Views.Layout.SortFilterButtonShowMode.Nowhere
        Me.colName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'layoutViewField_colName
        '
        Me.layoutViewField_colName.EditorPreferredWidth = 154
        Me.layoutViewField_colName.Location = New System.Drawing.Point(0, 114)
        Me.layoutViewField_colName.Name = "layoutViewField_colName"
        Me.layoutViewField_colName.Size = New System.Drawing.Size(158, 24)
        Me.layoutViewField_colName.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colName.TextToControlDistance = 0
        Me.layoutViewField_colName.TextVisible = False
        '
        'colIcon
        '
        Me.colIcon.ColumnEdit = Me.ripeIcon
        Me.colIcon.FieldName = "Icon"
        Me.colIcon.LayoutViewField = Me.layoutViewField_colIcon
        Me.colIcon.Name = "colIcon"
        Me.colIcon.OptionsField.SortFilterButtonShowMode = DevExpress.XtraGrid.Views.Layout.SortFilterButtonShowMode.Nowhere
        '
        'ripeIcon
        '
        Me.ripeIcon.Name = "ripeIcon"
        Me.ripeIcon.NullText = " "
        Me.ripeIcon.ReadOnly = True
        Me.ripeIcon.ShowMenu = False
        '
        'layoutViewField_colIcon
        '
        Me.layoutViewField_colIcon.EditorPreferredWidth = 154
        Me.layoutViewField_colIcon.Location = New System.Drawing.Point(0, 24)
        Me.layoutViewField_colIcon.Name = "layoutViewField_colIcon"
        Me.layoutViewField_colIcon.Size = New System.Drawing.Size(158, 90)
        Me.layoutViewField_colIcon.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colIcon.TextToControlDistance = 0
        Me.layoutViewField_colIcon.TextVisible = False
        '
        'colDescription
        '
        Me.colDescription.Caption = "Description"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.colDescription.Name = "colDescription"
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 92
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(158, 24)
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(57, 13)
        Me.layoutViewField_LayoutViewColumn1.TextToControlDistance = 5
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colIcon, Me.layoutViewField_colName, Me.layoutViewField_LayoutViewColumn1})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'ripeBrowseAttachment
        '
        Me.ripeBrowseAttachment.AutoHeight = False
        Me.ripeBrowseAttachment.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ripeBrowseAttachment.Name = "ripeBrowseAttachment"
        '
        'riteDescription
        '
        Me.riteDescription.AutoHeight = False
        Me.riteDescription.Name = "riteDescription"
        '
        'bbiSaveAttachment
        '
        Me.bbiSaveAttachment.Caption = "Save Attachment"
        Me.bbiSaveAttachment.Id = 100
        Me.bbiSaveAttachment.Name = "bbiSaveAttachment"
        '
        'pmAttachments
        '
        Me.pmAttachments.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSaveAttachment)})
        Me.pmAttachments.Manager = Me.BarManager
        Me.pmAttachments.Name = "pmAttachments"
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiSaveAttachment, Me.bbiAdd, Me.bbiSaveClose, Me.bbiView})
        Me.BarManager.MainMenu = Me.Bar1
        Me.BarManager.MaxItemId = 3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 2"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSaveClose), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiView)})
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 2"
        '
        'bbiAdd
        '
        Me.bbiAdd.Caption = "&Add"
        Me.bbiAdd.Id = 0
        Me.bbiAdd.Name = "bbiAdd"
        Me.bbiAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiSaveClose
        '
        Me.bbiSaveClose.Caption = "&Save && Close"
        Me.bbiSaveClose.Id = 1
        Me.bbiSaveClose.Name = "bbiSaveClose"
        Me.bbiSaveClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiView
        '
        Me.bbiView.Caption = "&View"
        Me.bbiView.Id = 2
        Me.bbiView.Name = "bbiView"
        Me.bbiView.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(777, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 444)
        Me.barDockControlBottom.Size = New System.Drawing.Size(777, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 422)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(777, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 422)
        '
        'xfJobAttachment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 444)
        Me.Controls.Add(Me.gcAttachments)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfJobAttachment"
        Me.Text = "Attachments"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ripeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ripeBrowseAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riteDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pmAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents gcAttachments As DevExpress.XtraGrid.GridControl
    Friend WithEvents lvAttachments As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colIcon As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents ripeIcon As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents ripeBrowseAttachment As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents bbiSaveAttachment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pmAttachments As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents layoutViewField_colName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colIcon As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents riteDescription As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

End Class
