<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlCommonLetter
    Inherits UniSource.ShopFloor.GUI.xlgCommonLetter

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
        Me.gcCommonLetters = New DevExpress.XtraGrid.GridControl()
        Me.gvCommonLetters = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContents = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCommonLetters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCommonLetters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcCommonLetters)
        '
        'gcCommonLetters
        '
        Me.gcCommonLetters.DataSource = Me.BindingSource
        Me.gcCommonLetters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCommonLetters.Location = New System.Drawing.Point(0, 0)
        Me.gcCommonLetters.MainView = Me.gvCommonLetters
        Me.gcCommonLetters.MenuManager = Me.barManager
        Me.gcCommonLetters.Name = "gcCommonLetters"
        Me.gcCommonLetters.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRichTextEdit1})
        Me.gcCommonLetters.Size = New System.Drawing.Size(925, 506)
        Me.gcCommonLetters.TabIndex = 0
        Me.gcCommonLetters.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCommonLetters})
        '
        'gvCommonLetters
        '
        Me.gvCommonLetters.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colContents, Me.colID})
        Me.gvCommonLetters.GridControl = Me.gcCommonLetters
        Me.gvCommonLetters.Name = "gvCommonLetters"
        Me.gvCommonLetters.OptionsBehavior.ReadOnly = True
        Me.gvCommonLetters.OptionsView.ShowGroupPanel = False
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        '
        'colContents
        '
        Me.colContents.ColumnEdit = Me.RepositoryItemRichTextEdit1
        Me.colContents.FieldName = "Contents"
        Me.colContents.Name = "colContents"
        Me.colContents.Visible = True
        Me.colContents.VisibleIndex = 2
        '
        'RepositoryItemRichTextEdit1
        '
        Me.RepositoryItemRichTextEdit1.MaxHeight = 450
        Me.RepositoryItemRichTextEdit1.Name = "RepositoryItemRichTextEdit1"
        Me.RepositoryItemRichTextEdit1.ShowCaretInReadOnly = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlCommonLetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlCommonLetter"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCommonLetters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCommonLetters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcCommonLetters As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCommonLetters As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContents As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit

End Class
