<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlJobNote
    Inherits UniSource.Shopfloor.GUI.xlgJobNote

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gcJobNote = New DevExpress.XtraGrid.GridControl()
        Me.gvJobNote = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJobNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStageDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContents = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJobNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcJobNote)
        '
        'gcJobNote
        '
        Me.gcJobNote.DataSource = Me.BindingSource
        Me.gcJobNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJobNote.Location = New System.Drawing.Point(0, 0)
        Me.gcJobNote.MainView = Me.gvJobNote
        Me.gcJobNote.MenuManager = Me.barManager
        Me.gcJobNote.Name = "gcJobNote"
        Me.gcJobNote.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRichTextEdit1})
        Me.gcJobNote.Size = New System.Drawing.Size(925, 506)
        Me.gcJobNote.TabIndex = 0
        Me.gcJobNote.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobNote})
        '
        'gvJobNote
        '
        Me.gvJobNote.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobNumber, Me.colStageDescription, Me.colContents, Me.colID, Me.colError})
        Me.gvJobNote.GridControl = Me.gcJobNote
        Me.gvJobNote.Name = "gvJobNote"
        Me.gvJobNote.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvJobNote.OptionsBehavior.Editable = False
        Me.gvJobNote.OptionsBehavior.ReadOnly = True
        '
        'colJobNumber
        '
        Me.colJobNumber.FieldName = "Job.JobNumber"
        Me.colJobNumber.Name = "colJobNumber"
        Me.colJobNumber.Visible = True
        Me.colJobNumber.VisibleIndex = 0
        '
        'colStageDescription
        '
        Me.colStageDescription.FieldName = "JobStage"
        Me.colStageDescription.Name = "colStageDescription"
        Me.colStageDescription.Visible = True
        Me.colStageDescription.VisibleIndex = 1
        '
        'colContents
        '
        Me.colContents.ColumnEdit = Me.RepositoryItemRichTextEdit1
        Me.colContents.FieldName = "Note"
        Me.colContents.Name = "colContents"
        Me.colContents.Visible = True
        Me.colContents.VisibleIndex = 2
        '
        'RepositoryItemRichTextEdit1
        '
        Me.RepositoryItemRichTextEdit1.Name = "RepositoryItemRichTextEdit1"
        Me.RepositoryItemRichTextEdit1.ShowCaretInReadOnly = False
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
        'xlJobNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlJobNote"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJobNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcJobNote As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobNote As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJobNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStageDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContents As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit

End Class
