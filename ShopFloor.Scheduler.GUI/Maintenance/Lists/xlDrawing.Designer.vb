<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlDrawing
    Inherits UniSource.ShopFloor.Scheduler.GUI.xlgDrawing

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
        Me.gcDrawing = New DevExpress.XtraGrid.GridControl()
        Me.gvDrawing = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingPath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Drawing)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcDrawing)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcDrawing
        '
        Me.gcDrawing.DataSource = Me.BindingSource
        Me.gcDrawing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDrawing.Location = New System.Drawing.Point(0, 0)
        Me.gcDrawing.MainView = Me.gvDrawing
        Me.gcDrawing.MenuManager = Me.barManager
        Me.gcDrawing.Name = "gcDrawing"
        Me.gcDrawing.ShowOnlyPredefinedDetails = True
        Me.gcDrawing.Size = New System.Drawing.Size(925, 506)
        Me.gcDrawing.TabIndex = 0
        Me.gcDrawing.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDrawing})
        '
        'gvDrawing
        '
        Me.gvDrawing.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDrawing, Me.colDrawingPath, Me.colID})
        Me.gvDrawing.GridControl = Me.gcDrawing
        Me.gvDrawing.Name = "gvDrawing"
        Me.gvDrawing.OptionsBehavior.ReadOnly = True
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 129
        '
        'colDrawing
        '
        Me.colDrawing.FieldName = "Drawing"
        Me.colDrawing.Name = "colDrawing"
        '
        'colDrawingPath
        '
        Me.colDrawingPath.FieldName = "DrawingPath"
        Me.colDrawingPath.Name = "colDrawingPath"
        Me.colDrawingPath.Visible = True
        Me.colDrawingPath.VisibleIndex = 1
        Me.colDrawingPath.Width = 778
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlDrawing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlDrawing"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcDrawing As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDrawing As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
