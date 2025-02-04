<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlJobMemo
    Inherits UniSource.Shopfloor.GUI.xlgJobMemo

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
        Me.gcJobMemo = New DevExpress.XtraGrid.GridControl()
        Me.gvJobMemo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJobID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStageID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreateUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreateDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEditUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEditDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJobMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcJobMemo)
        '
        'gcJobMemo
        '
        Me.gcJobMemo.DataSource = Me.BindingSource
        Me.gcJobMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJobMemo.Location = New System.Drawing.Point(0, 0)
        Me.gcJobMemo.MainView = Me.gvJobMemo
        Me.gcJobMemo.MenuManager = Me.barManager
        Me.gcJobMemo.Name = "gcJobMemo"
        Me.gcJobMemo.Size = New System.Drawing.Size(925, 506)
        Me.gcJobMemo.TabIndex = 0
        Me.gcJobMemo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobMemo})
        '
        'gvJobMemo
        '
        Me.gvJobMemo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobID, Me.colStageID, Me.colMemo, Me.colCreateUserID, Me.colCreateDate, Me.colEditUserID, Me.colEditDate, Me.colID, Me.colError})
        Me.gvJobMemo.GridControl = Me.gcJobMemo
        Me.gvJobMemo.Name = "gvJobMemo"
        Me.gvJobMemo.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvJobMemo.OptionsBehavior.Editable = False
        Me.gvJobMemo.OptionsBehavior.ReadOnly = True
        '
        'colJobID
        '
        Me.colJobID.FieldName = "JobID"
        Me.colJobID.Name = "colJobID"
        Me.colJobID.Visible = True
        Me.colJobID.VisibleIndex = 0
        '
        'colStageID
        '
        Me.colStageID.FieldName = "StageID"
        Me.colStageID.Name = "colStageID"
        '
        'colMemo
        '
        Me.colMemo.FieldName = "Memo"
        Me.colMemo.Name = "colMemo"
        Me.colMemo.Visible = True
        Me.colMemo.VisibleIndex = 1
        '
        'colCreateUserID
        '
        Me.colCreateUserID.FieldName = "CreateUserID"
        Me.colCreateUserID.Name = "colCreateUserID"
        Me.colCreateUserID.Visible = True
        Me.colCreateUserID.VisibleIndex = 2
        '
        'colCreateDate
        '
        Me.colCreateDate.FieldName = "CreateDate"
        Me.colCreateDate.Name = "colCreateDate"
        Me.colCreateDate.Visible = True
        Me.colCreateDate.VisibleIndex = 3
        '
        'colEditUserID
        '
        Me.colEditUserID.FieldName = "EditUserID"
        Me.colEditUserID.Name = "colEditUserID"
        Me.colEditUserID.Visible = True
        Me.colEditUserID.VisibleIndex = 4
        '
        'colEditDate
        '
        Me.colEditDate.FieldName = "EditDate"
        Me.colEditDate.Name = "colEditDate"
        Me.colEditDate.Visible = True
        Me.colEditDate.VisibleIndex = 5
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
        'xlJobMemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlJobMemo"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJobMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobMemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcJobMemo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobMemo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJobID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStageID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEditUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn

End Class
