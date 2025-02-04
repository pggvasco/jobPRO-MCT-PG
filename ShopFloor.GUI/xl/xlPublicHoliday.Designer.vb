<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlPublicHoliday
    Inherits UniSource.ShopFloor.GUI.xlgPublicHoliday

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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gvPublicHoliday = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPublicHolidayDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PublicHolidayRepositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPublicHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublicHolidayRepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublicHolidayRepositoryItemDateEdit.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.GridControl1)
        Me.GridPanel.Location = New System.Drawing.Point(0, 84)
        Me.GridPanel.Size = New System.Drawing.Size(567, 177)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gvPublicHoliday
        Me.GridControl1.MenuManager = Me.barManager
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.PublicHolidayRepositoryItemDateEdit})
        Me.GridControl1.Size = New System.Drawing.Size(567, 177)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPublicHoliday})
        '
        'gvPublicHoliday
        '
        Me.gvPublicHoliday.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPublicHolidayDate, Me.colDescription, Me.colID, Me.colError})
        Me.gvPublicHoliday.GridControl = Me.GridControl1
        Me.gvPublicHoliday.Name = "gvPublicHoliday"
        '
        'colPublicHolidayDate
        '
        Me.colPublicHolidayDate.Caption = "Date"
        Me.colPublicHolidayDate.ColumnEdit = Me.PublicHolidayRepositoryItemDateEdit
        Me.colPublicHolidayDate.FieldName = "PublicHolidayDate"
        Me.colPublicHolidayDate.Name = "colPublicHolidayDate"
        Me.colPublicHolidayDate.Visible = True
        Me.colPublicHolidayDate.VisibleIndex = 0
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colError
        '
        Me.colError.FieldName = "Error"
        Me.colError.Name = "colError"
        Me.colError.OptionsColumn.ReadOnly = True
        '
        'PublicHolidayRepositoryItemDateEdit
        '
        Me.PublicHolidayRepositoryItemDateEdit.AutoHeight = False
        Me.PublicHolidayRepositoryItemDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PublicHolidayRepositoryItemDateEdit.Name = "PublicHolidayRepositoryItemDateEdit"
        Me.PublicHolidayRepositoryItemDateEdit.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'xlPublicHoliday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlPublicHoliday"
        Me.Size = New System.Drawing.Size(567, 261)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPublicHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublicHolidayRepositoryItemDateEdit.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublicHolidayRepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPublicHoliday As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPublicHolidayDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PublicHolidayRepositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
