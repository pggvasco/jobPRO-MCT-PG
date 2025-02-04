<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlPart
    Inherits UniSource.ShopFloor.Scheduler.GUI.xlgPart

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
        Me.gcPart = New DevExpress.XtraGrid.GridControl()
        Me.gvPart = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colColour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Part)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcPart)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcPart
        '
        Me.gcPart.DataSource = Me.BindingSource
        Me.gcPart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPart.Location = New System.Drawing.Point(0, 0)
        Me.gcPart.MainView = Me.gvPart
        Me.gcPart.MenuManager = Me.barManager
        Me.gcPart.Name = "gcPart"
        Me.gcPart.ShowOnlyPredefinedDetails = True
        Me.gcPart.Size = New System.Drawing.Size(925, 506)
        Me.gcPart.TabIndex = 0
        Me.gcPart.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPart})
        '
        'gvPart
        '
        Me.gvPart.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColour, Me.colCode, Me.colDescription, Me.colImage, Me.colID})
        Me.gvPart.GridControl = Me.gcPart
        Me.gvPart.Name = "gvPart"
        Me.gvPart.OptionsBehavior.ReadOnly = True
        '
        'colColour
        '
        Me.colColour.FieldName = "Colour"
        Me.colColour.Name = "colColour"
        Me.colColour.Visible = True
        Me.colColour.VisibleIndex = 2
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
        'colImage
        '
        Me.colImage.FieldName = "Image"
        Me.colImage.Name = "colImage"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlPart"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcPart As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPart As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colColour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
