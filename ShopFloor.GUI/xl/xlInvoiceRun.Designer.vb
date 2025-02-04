<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlInvoiceRun
    Inherits UniSource.ShopFloor.GUI.xlgInvoiceRun

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
        Me.gvInvoiceRun = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInvoiceWeek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExcludeDummy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceRunLines = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvInvoiceRun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.GridControl1)
        Me.GridPanel.Size = New System.Drawing.Size(893, 293)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gvInvoiceRun
        Me.GridControl1.MenuManager = Me.barManager
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(893, 293)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInvoiceRun})
        '
        'gvInvoiceRun
        '
        Me.gvInvoiceRun.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvoiceWeek, Me.colInvoiceDate, Me.colStartDate, Me.colEndDate, Me.colExcludeDummy, Me.colInvoiceRunLines, Me.colID, Me.colError})
        Me.gvInvoiceRun.GridControl = Me.GridControl1
        Me.gvInvoiceRun.Name = "gvInvoiceRun"
        '
        'colInvoiceWeek
        '
        Me.colInvoiceWeek.FieldName = "InvoiceWeek"
        Me.colInvoiceWeek.Name = "colInvoiceWeek"
        Me.colInvoiceWeek.Visible = True
        Me.colInvoiceWeek.VisibleIndex = 0
        '
        'colInvoiceDate
        '
        Me.colInvoiceDate.FieldName = "InvoiceDate"
        Me.colInvoiceDate.Name = "colInvoiceDate"
        Me.colInvoiceDate.Visible = True
        Me.colInvoiceDate.VisibleIndex = 1
        '
        'colStartDate
        '
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 2
        '
        'colEndDate
        '
        Me.colEndDate.FieldName = "EndDate"
        Me.colEndDate.Name = "colEndDate"
        Me.colEndDate.Visible = True
        Me.colEndDate.VisibleIndex = 3
        '
        'colExcludeDummy
        '
        Me.colExcludeDummy.FieldName = "ExcludeDummy"
        Me.colExcludeDummy.Name = "colExcludeDummy"
        Me.colExcludeDummy.Visible = True
        Me.colExcludeDummy.VisibleIndex = 4
        '
        'colInvoiceRunLines
        '
        Me.colInvoiceRunLines.FieldName = "InvoiceRunLines"
        Me.colInvoiceRunLines.Name = "colInvoiceRunLines"
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
        'xlInvoiceRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlInvoiceRun"
        Me.Size = New System.Drawing.Size(893, 346)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvInvoiceRun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvInvoiceRun As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colInvoiceWeek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExcludeDummy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceRunLines As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
End Class
