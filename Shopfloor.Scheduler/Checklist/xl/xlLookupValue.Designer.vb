<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlLookupValue
    Inherits UniSource.Checklist.GUI.xlgLookupValue

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
        Me.gcLookupValue = New DevExpress.XtraGrid.GridControl()
        Me.gvLookupValue = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLookup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcLookupValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLookupValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcLookupValue)
        '
        'gcLookupValue
        '
        Me.gcLookupValue.DataSource = Me.BindingSource
        Me.gcLookupValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLookupValue.Location = New System.Drawing.Point(0, 0)
        Me.gcLookupValue.MainView = Me.gvLookupValue
        Me.gcLookupValue.MenuManager = Me.barManager
        Me.gcLookupValue.Name = "gcLookupValue"
        Me.gcLookupValue.Size = New System.Drawing.Size(925, 506)
        Me.gcLookupValue.TabIndex = 0
        Me.gcLookupValue.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLookupValue})
        '
        'gvLookupValue
        '
        Me.gvLookupValue.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colLookup, Me.colID})
        Me.gvLookupValue.GridControl = Me.gcLookupValue
        Me.gvLookupValue.Name = "gvLookupValue"
        Me.gvLookupValue.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvLookupValue.OptionsBehavior.Editable = False
        Me.gvLookupValue.OptionsBehavior.ReadOnly = True
        Me.gvLookupValue.OptionsDetail.EnableMasterViewMode = False
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 1
        Me.colCode.Width = 275
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        Me.colDescription.Width = 498
        '
        'colLookup
        '
        Me.colLookup.FieldName = "Lookup"
        Me.colLookup.Name = "colLookup"
        Me.colLookup.Visible = True
        Me.colLookup.VisibleIndex = 0
        Me.colLookup.Width = 134
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 258
        '
        'xlLookupValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlLookupValue"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcLookupValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLookupValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcLookupValue As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLookupValue As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLookup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
