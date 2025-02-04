<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlCostCentre
    Inherits UniSource.ShopFloor.Scheduler.GUI.xlgCostCentre

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
        Me.gcCostCentre = New DevExpress.XtraGrid.GridControl()
        Me.gvCostCentre = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransactionCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCostCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCostCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.CostCentre)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcCostCentre)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcCostCentre
        '
        Me.gcCostCentre.DataSource = Me.BindingSource
        Me.gcCostCentre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCostCentre.Location = New System.Drawing.Point(0, 0)
        Me.gcCostCentre.MainView = Me.gvCostCentre
        Me.gcCostCentre.MenuManager = Me.barManager
        Me.gcCostCentre.Name = "gcCostCentre"
        Me.gcCostCentre.ShowOnlyPredefinedDetails = True
        Me.gcCostCentre.Size = New System.Drawing.Size(925, 506)
        Me.gcCostCentre.TabIndex = 0
        Me.gcCostCentre.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCostCentre})
        '
        'gvCostCentre
        '
        Me.gvCostCentre.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colTransactionCode, Me.colID})
        Me.gvCostCentre.GridControl = Me.gcCostCentre
        Me.gvCostCentre.Name = "gvCostCentre"
        Me.gvCostCentre.OptionsBehavior.ReadOnly = True
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
        'colTransactionCode
        '
        Me.colTransactionCode.FieldName = "TransactionCode"
        Me.colTransactionCode.Name = "colTransactionCode"
        Me.colTransactionCode.Visible = True
        Me.colTransactionCode.VisibleIndex = 2
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlCostCentre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlCostCentre"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCostCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCostCentre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcCostCentre As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCostCentre As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransactionCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
