<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlWorkCentre
    Inherits UniSource.ShopFloor.GUI.xlgWorkCentre

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
        Me.gcWorkCentre = New DevExpress.XtraGrid.GridControl()
        Me.gvWorkCentre = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCalculationTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsBuyOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAPExpense = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGLExpense = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHourlyRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFactor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFormula = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkCentreCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecoveryServiceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcWorkCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWorkCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcWorkCentre)
        '
        'gcWorkCentre
        '
        Me.gcWorkCentre.DataSource = Me.BindingSource
        Me.gcWorkCentre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcWorkCentre.Location = New System.Drawing.Point(0, 0)
        Me.gcWorkCentre.MainView = Me.gvWorkCentre
        Me.gcWorkCentre.MenuManager = Me.barManager
        Me.gcWorkCentre.Name = "gcWorkCentre"
        Me.gcWorkCentre.ShowOnlyPredefinedDetails = True
        Me.gcWorkCentre.Size = New System.Drawing.Size(925, 506)
        Me.gcWorkCentre.TabIndex = 0
        Me.gcWorkCentre.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWorkCentre})
        '
        'gvWorkCentre
        '
        Me.gvWorkCentre.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colCalculationTypeID, Me.colIsBuyOut, Me.colAPExpense, Me.colGLExpense, Me.colHourlyRate, Me.colFactor, Me.colFormula, Me.colID, Me.colCostCentre, Me.colWorkCentreCategory, Me.colRecoveryServiceCode})
        Me.gvWorkCentre.GridControl = Me.gcWorkCentre
        Me.gvWorkCentre.Name = "gvWorkCentre"
        Me.gvWorkCentre.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvWorkCentre.OptionsBehavior.Editable = False
        Me.gvWorkCentre.OptionsBehavior.ReadOnly = True
        Me.gvWorkCentre.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.gvWorkCentre.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGLExpense, DevExpress.Data.ColumnSortOrder.Ascending)})
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
        'colCalculationTypeID
        '
        Me.colCalculationTypeID.FieldName = "CalculationType"
        Me.colCalculationTypeID.Name = "colCalculationTypeID"
        Me.colCalculationTypeID.Visible = True
        Me.colCalculationTypeID.VisibleIndex = 11
        '
        'colIsBuyOut
        '
        Me.colIsBuyOut.FieldName = "IsBuyOut"
        Me.colIsBuyOut.Name = "colIsBuyOut"
        Me.colIsBuyOut.Visible = True
        Me.colIsBuyOut.VisibleIndex = 2
        '
        'colAPExpense
        '
        Me.colAPExpense.FieldName = "APExpense"
        Me.colAPExpense.Name = "colAPExpense"
        Me.colAPExpense.Visible = True
        Me.colAPExpense.VisibleIndex = 3
        '
        'colGLExpense
        '
        Me.colGLExpense.FieldName = "GLExpense"
        Me.colGLExpense.Name = "colGLExpense"
        Me.colGLExpense.Visible = True
        Me.colGLExpense.VisibleIndex = 4
        '
        'colHourlyRate
        '
        Me.colHourlyRate.FieldName = "HourlyRate"
        Me.colHourlyRate.Name = "colHourlyRate"
        Me.colHourlyRate.Visible = True
        Me.colHourlyRate.VisibleIndex = 5
        '
        'colFactor
        '
        Me.colFactor.FieldName = "Factor"
        Me.colFactor.Name = "colFactor"
        Me.colFactor.Visible = True
        Me.colFactor.VisibleIndex = 6
        '
        'colFormula
        '
        Me.colFormula.FieldName = "Formula"
        Me.colFormula.Name = "colFormula"
        Me.colFormula.Visible = True
        Me.colFormula.VisibleIndex = 7
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colCostCentre
        '
        Me.colCostCentre.FieldName = "CostCentre"
        Me.colCostCentre.Name = "colCostCentre"
        Me.colCostCentre.Visible = True
        Me.colCostCentre.VisibleIndex = 8
        '
        'colWorkCentreCategory
        '
        Me.colWorkCentreCategory.FieldName = "WorkCentreCategory"
        Me.colWorkCentreCategory.Name = "colWorkCentreCategory"
        Me.colWorkCentreCategory.Visible = True
        Me.colWorkCentreCategory.VisibleIndex = 9
        '
        'colRecoveryServiceCode
        '
        Me.colRecoveryServiceCode.FieldName = "RecoveryServiceCode"
        Me.colRecoveryServiceCode.Name = "colRecoveryServiceCode"
        Me.colRecoveryServiceCode.Visible = True
        Me.colRecoveryServiceCode.VisibleIndex = 10
        '
        'xlWorkCentre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlWorkCentre"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcWorkCentre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWorkCentre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcWorkCentre As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvWorkCentre As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalculationTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsBuyOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHourlyRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFactor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentreCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecoveryServiceCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPExpense As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGLExpense As DevExpress.XtraGrid.Columns.GridColumn

End Class
