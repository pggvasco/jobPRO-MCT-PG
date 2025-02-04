<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlOperation
    Inherits UniSource.ShopFloor.Scheduler.GUI.xlgOperation

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
        Me.gcOperation = New DevExpress.XtraGrid.GridControl()
        Me.gvOperation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChecklist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsBuyOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServiceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrimary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Operation)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcOperation)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcOperation
        '
        Me.gcOperation.DataSource = Me.BindingSource
        Me.gcOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcOperation.Location = New System.Drawing.Point(0, 0)
        Me.gcOperation.MainView = Me.gvOperation
        Me.gcOperation.MenuManager = Me.barManager
        Me.gcOperation.Name = "gcOperation"
        Me.gcOperation.ShowOnlyPredefinedDetails = True
        Me.gcOperation.Size = New System.Drawing.Size(925, 506)
        Me.gcOperation.TabIndex = 0
        Me.gcOperation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvOperation})
        '
        'gvOperation
        '
        Me.gvOperation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChecklist, Me.colCode, Me.colDescription, Me.colRate, Me.colIsBuyOut, Me.colServiceCode, Me.colIsPrimary, Me.colCostCentre, Me.colID})
        Me.gvOperation.GridControl = Me.gcOperation
        Me.gvOperation.Name = "gvOperation"
        Me.gvOperation.OptionsBehavior.ReadOnly = True
        '
        'colChecklist
        '
        Me.colChecklist.FieldName = "Checklist"
        Me.colChecklist.Name = "colChecklist"
        Me.colChecklist.Visible = True
        Me.colChecklist.VisibleIndex = 2
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
        'colRate
        '
        Me.colRate.FieldName = "Rate"
        Me.colRate.Name = "colRate"
        Me.colRate.Visible = True
        Me.colRate.VisibleIndex = 3
        '
        'colIsBuyOut
        '
        Me.colIsBuyOut.FieldName = "IsBuyOut"
        Me.colIsBuyOut.Name = "colIsBuyOut"
        Me.colIsBuyOut.Visible = True
        Me.colIsBuyOut.VisibleIndex = 4
        '
        'colServiceCode
        '
        Me.colServiceCode.FieldName = "ServiceCode"
        Me.colServiceCode.Name = "colServiceCode"
        Me.colServiceCode.Visible = True
        Me.colServiceCode.VisibleIndex = 5
        '
        'colIsPrimary
        '
        Me.colIsPrimary.FieldName = "IsPrimary"
        Me.colIsPrimary.Name = "colIsPrimary"
        Me.colIsPrimary.Visible = True
        Me.colIsPrimary.VisibleIndex = 6
        '
        'colCostCentre
        '
        Me.colCostCentre.FieldName = "CostCentre"
        Me.colCostCentre.Name = "colCostCentre"
        Me.colCostCentre.Visible = True
        Me.colCostCentre.VisibleIndex = 7
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlOperation"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvOperation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcOperation As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvOperation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChecklist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsBuyOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrimary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
