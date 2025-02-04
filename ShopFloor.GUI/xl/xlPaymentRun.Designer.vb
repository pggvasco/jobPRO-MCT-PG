<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlPaymentRun
    Inherits UniSource.ShopFloor.GUI.xlgPaymentRun

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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentFrequency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.GridControl1)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.barManager
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(925, 506)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStartDate, Me.colEndDate, Me.colPaymentDate, Me.colPaymentFrequency, Me.colCompanyBranch})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colStartDate
        '
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 0
        '
        'colEndDate
        '
        Me.colEndDate.FieldName = "EndDate"
        Me.colEndDate.Name = "colEndDate"
        Me.colEndDate.Visible = True
        Me.colEndDate.VisibleIndex = 1
        '
        'colPaymentDate
        '
        Me.colPaymentDate.FieldName = "PaymentDate"
        Me.colPaymentDate.Name = "colPaymentDate"
        Me.colPaymentDate.Visible = True
        Me.colPaymentDate.VisibleIndex = 2
        '
        'colPaymentFrequency
        '
        Me.colPaymentFrequency.FieldName = "PaymentFrequency"
        Me.colPaymentFrequency.Name = "colPaymentFrequency"
        Me.colPaymentFrequency.Visible = True
        Me.colPaymentFrequency.VisibleIndex = 3
        '
        'colCompanyBranch
        '
        Me.colCompanyBranch.FieldName = "CompanyBranch"
        Me.colCompanyBranch.Name = "colCompanyBranch"
        Me.colCompanyBranch.Visible = True
        Me.colCompanyBranch.VisibleIndex = 4
        '
        'xlPaymentRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlPaymentRun"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentFrequency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyBranch As DevExpress.XtraGrid.Columns.GridColumn

End Class
