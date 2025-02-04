<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlChecklistType
    Inherits UniSource.Checklist.GUI.xlgChecklistType

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
        Me.gcChecklistType = New DevExpress.XtraGrid.GridControl()
        Me.gvChecklistType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcChecklistType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChecklistType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcChecklistType)
        '
        'gcChecklistType
        '
        Me.gcChecklistType.DataSource = Me.BindingSource
        Me.gcChecklistType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcChecklistType.Location = New System.Drawing.Point(0, 0)
        Me.gcChecklistType.MainView = Me.gvChecklistType
        Me.gcChecklistType.MenuManager = Me.barManager
        Me.gcChecklistType.Name = "gcChecklistType"
        Me.gcChecklistType.Size = New System.Drawing.Size(925, 506)
        Me.gcChecklistType.TabIndex = 0
        Me.gcChecklistType.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChecklistType})
        '
        'gvChecklistType
        '
        Me.gvChecklistType.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colID})
        Me.gvChecklistType.GridControl = Me.gcChecklistType
        Me.gvChecklistType.Name = "gvChecklistType"
        Me.gvChecklistType.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvChecklistType.OptionsBehavior.Editable = False
        Me.gvChecklistType.OptionsBehavior.ReadOnly = True
        Me.gvChecklistType.OptionsDetail.EnableMasterViewMode = False
        Me.gvChecklistType.OptionsView.ShowGroupPanel = False
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 158
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 749
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlChecklistType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlChecklistType"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcChecklistType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChecklistType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcChecklistType As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvChecklistType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
