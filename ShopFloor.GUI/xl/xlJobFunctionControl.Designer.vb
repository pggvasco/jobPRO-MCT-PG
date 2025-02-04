<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlJobFunctionControl
    Inherits UniSource.ShopFloor.GUI.xlgJobFunctionControl

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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJobFunction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.colValidationErrorMessages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsChanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsLoading = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.GridControl1)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobFunction, Me.colPassword})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        '
        'colJobFunction
        '
        Me.colJobFunction.FieldName = "JobFunction"
        Me.colJobFunction.Name = "colJobFunction"
        Me.colJobFunction.Visible = True
        Me.colJobFunction.VisibleIndex = 0
        '
        'colPassword
        '
        Me.colPassword.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colPassword.FieldName = "Password"
        Me.colPassword.Name = "colPassword"
        Me.colPassword.Visible = True
        Me.colPassword.VisibleIndex = 1
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.barManager
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(925, 506)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'colValidationErrorMessages
        '
        Me.colValidationErrorMessages.FieldName = "ValidationErrorMessages"
        Me.colValidationErrorMessages.Name = "colValidationErrorMessages"
        Me.colValidationErrorMessages.OptionsColumn.ReadOnly = True
        Me.colValidationErrorMessages.Visible = True
        Me.colValidationErrorMessages.VisibleIndex = 8
        '
        'colIsChanged
        '
        Me.colIsChanged.FieldName = "IsChanged"
        Me.colIsChanged.Name = "colIsChanged"
        Me.colIsChanged.OptionsColumn.ReadOnly = True
        Me.colIsChanged.Visible = True
        Me.colIsChanged.VisibleIndex = 8
        '
        'colIsLoading
        '
        Me.colIsLoading.FieldName = "IsLoading"
        Me.colIsLoading.Name = "colIsLoading"
        Me.colIsLoading.OptionsColumn.ReadOnly = True
        Me.colIsLoading.Visible = True
        Me.colIsLoading.VisibleIndex = 8
        '
        'xlJobFunctionControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlJobFunctionControl"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colValidationErrorMessages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsChanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsLoading As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobFunction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

End Class
