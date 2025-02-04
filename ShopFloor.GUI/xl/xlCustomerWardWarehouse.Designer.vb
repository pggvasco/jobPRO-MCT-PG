<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlCustomerWardWarehouse
    Inherits UniSource.ShopFloor.GUI.xlgCustomerWardWarehouse

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
        Me.gvCustomerWard = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colClient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcustomerRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colERPCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerWorkCentreCategoryWarehouses = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCustomerWard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.GridControl1)
        Me.GridPanel.Location = New System.Drawing.Point(0, 24)
        Me.GridPanel.Size = New System.Drawing.Size(952, 364)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gvCustomerWard
        Me.GridControl1.MenuManager = Me.barManager
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(952, 364)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCustomerWard})
        '
        'gvCustomerWard
        '
        Me.gvCustomerWard.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClient, Me.colcustomerRate, Me.colERPCustomerID, Me.colCustomerWorkCentreCategoryWarehouses, Me.colID, Me.colError, Me.colCode, Me.colName})
        Me.gvCustomerWard.GridControl = Me.GridControl1
        Me.gvCustomerWard.Name = "gvCustomerWard"
        Me.gvCustomerWard.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvCustomerWard.OptionsBehavior.Editable = False
        Me.gvCustomerWard.OptionsBehavior.ReadOnly = True
        '
        'colClient
        '
        Me.colClient.FieldName = "Client"
        Me.colClient.Name = "colClient"
        Me.colClient.OptionsColumn.ReadOnly = True
        '
        'colcustomerRate
        '
        Me.colcustomerRate.FieldName = "customerRate"
        Me.colcustomerRate.Name = "colcustomerRate"
        '
        'colERPCustomerID
        '
        Me.colERPCustomerID.FieldName = "ERPCustomerID"
        Me.colERPCustomerID.Name = "colERPCustomerID"
        '
        'colCustomerWorkCentreCategoryWarehouses
        '
        Me.colCustomerWorkCentreCategoryWarehouses.FieldName = "CustomerWorkCentreCategoryWarehouses"
        Me.colCustomerWorkCentreCategoryWarehouses.Name = "colCustomerWorkCentreCategoryWarehouses"
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
        'colCode
        '
        Me.colCode.Caption = "Code"
        Me.colCode.FieldName = "Client.Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        '
        'colName
        '
        Me.colName.Caption = "Name"
        Me.colName.FieldName = "Client.Description"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        '
        'xlCustomerWardWarehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlCustomerWardWarehouse"
        Me.Size = New System.Drawing.Size(952, 388)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCustomerWard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCustomerWard As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colClient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomerRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colERPCustomerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerWorkCentreCategoryWarehouses As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
End Class
