<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlDrawing
    Inherits UniSource.ShopFloor.GUI.xlgDrawing

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
        Me.gcDrawings = New DevExpress.XtraGrid.GridControl()
        Me.gvDrawings = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingPath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDrawings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDrawings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.API.Drawing)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcDrawings)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcDrawings
        '
        Me.gcDrawings.DataSource = Me.BindingSource
        Me.gcDrawings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDrawings.Location = New System.Drawing.Point(0, 0)
        Me.gcDrawings.MainView = Me.gvDrawings
        Me.gcDrawings.MenuManager = Me.barManager
        Me.gcDrawings.Name = "gcDrawings"
        Me.gcDrawings.ShowOnlyPredefinedDetails = True
        Me.gcDrawings.Size = New System.Drawing.Size(925, 506)
        Me.gcDrawings.TabIndex = 0
        Me.gcDrawings.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDrawings})
        '
        'gvDrawings
        '
        Me.gvDrawings.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDrawingPath, Me.colID, Me.colDescription})
        Me.gvDrawings.GridControl = Me.gcDrawings
        Me.gvDrawings.Name = "gvDrawings"
        Me.gvDrawings.OptionsBehavior.Editable = False
        Me.gvDrawings.OptionsBehavior.ReadOnly = True
        Me.gvDrawings.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 98
        '
        'colDrawingPath
        '
        Me.colDrawingPath.FieldName = "DrawingPath"
        Me.colDrawingPath.Name = "colDrawingPath"
        Me.colDrawingPath.Visible = True
        Me.colDrawingPath.VisibleIndex = 2
        Me.colDrawingPath.Width = 623
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 186
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
        CType(Me.gcDrawings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDrawings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcDrawings As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDrawings As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn

End Class
