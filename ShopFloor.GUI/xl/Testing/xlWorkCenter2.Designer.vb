<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlWorkCenter2
    Inherits UniSource.ShopFloor.GUI.xlgWorkCenter2

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Me.colFactor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCalculationType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsBuyOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCalculationTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHourlyRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFormula = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecoveryServiceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGLExpense = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAPExpense = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrimaryService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeasurement = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsageRequired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDefaultUsage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedUsage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobTemplateLines = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkCentreCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostCentre = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFactor, Me.colCode, Me.colCalculationType, Me.colIsBuyOut, Me.colDescription, Me.colCalculationTypeID, Me.colHourlyRate, Me.colFormula, Me.colRecoveryServiceCode, Me.colGLExpense, Me.colAPExpense, Me.colPrimaryService, Me.colMeasurement, Me.colUsageRequired, Me.colDefaultUsage, Me.colApprovedUsage, Me.colProjectID, Me.colJobTemplateLines, Me.colWorkCentreCategory, Me.colCostCentre})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'colFactor
        '
        Me.colFactor.FieldName = "Factor"
        Me.colFactor.Name = "colFactor"
        Me.colFactor.Visible = True
        Me.colFactor.VisibleIndex = 0
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 1
        '
        'colCalculationType
        '
        Me.colCalculationType.FieldName = "CalculationType"
        Me.colCalculationType.Name = "colCalculationType"
        Me.colCalculationType.Visible = True
        Me.colCalculationType.VisibleIndex = 2
        '
        'colIsBuyOut
        '
        Me.colIsBuyOut.FieldName = "IsBuyOut"
        Me.colIsBuyOut.Name = "colIsBuyOut"
        Me.colIsBuyOut.Visible = True
        Me.colIsBuyOut.VisibleIndex = 3
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 4
        '
        'colCalculationTypeID
        '
        Me.colCalculationTypeID.FieldName = "CalculationTypeID"
        Me.colCalculationTypeID.Name = "colCalculationTypeID"
        Me.colCalculationTypeID.Visible = True
        Me.colCalculationTypeID.VisibleIndex = 5
        '
        'colHourlyRate
        '
        Me.colHourlyRate.FieldName = "HourlyRate"
        Me.colHourlyRate.Name = "colHourlyRate"
        Me.colHourlyRate.Visible = True
        Me.colHourlyRate.VisibleIndex = 6
        '
        'colFormula
        '
        Me.colFormula.FieldName = "Formula"
        Me.colFormula.Name = "colFormula"
        Me.colFormula.Visible = True
        Me.colFormula.VisibleIndex = 7
        '
        'colRecoveryServiceCode
        '
        Me.colRecoveryServiceCode.FieldName = "RecoveryServiceCode"
        Me.colRecoveryServiceCode.Name = "colRecoveryServiceCode"
        Me.colRecoveryServiceCode.Visible = True
        Me.colRecoveryServiceCode.VisibleIndex = 8
        '
        'colGLExpense
        '
        Me.colGLExpense.FieldName = "GLExpense"
        Me.colGLExpense.Name = "colGLExpense"
        Me.colGLExpense.Visible = True
        Me.colGLExpense.VisibleIndex = 9
        '
        'colAPExpense
        '
        Me.colAPExpense.FieldName = "APExpense"
        Me.colAPExpense.Name = "colAPExpense"
        Me.colAPExpense.Visible = True
        Me.colAPExpense.VisibleIndex = 10
        '
        'colPrimaryService
        '
        Me.colPrimaryService.FieldName = "PrimaryService"
        Me.colPrimaryService.Name = "colPrimaryService"
        Me.colPrimaryService.Visible = True
        Me.colPrimaryService.VisibleIndex = 11
        '
        'colMeasurement
        '
        Me.colMeasurement.FieldName = "Measurement"
        Me.colMeasurement.Name = "colMeasurement"
        Me.colMeasurement.Visible = True
        Me.colMeasurement.VisibleIndex = 12
        '
        'colUsageRequired
        '
        Me.colUsageRequired.FieldName = "UsageRequired"
        Me.colUsageRequired.Name = "colUsageRequired"
        Me.colUsageRequired.Visible = True
        Me.colUsageRequired.VisibleIndex = 13
        '
        'colDefaultUsage
        '
        Me.colDefaultUsage.FieldName = "DefaultUsage"
        Me.colDefaultUsage.Name = "colDefaultUsage"
        Me.colDefaultUsage.Visible = True
        Me.colDefaultUsage.VisibleIndex = 14
        '
        'colApprovedUsage
        '
        Me.colApprovedUsage.FieldName = "ApprovedUsage"
        Me.colApprovedUsage.Name = "colApprovedUsage"
        Me.colApprovedUsage.Visible = True
        Me.colApprovedUsage.VisibleIndex = 15
        '
        'colProjectID
        '
        Me.colProjectID.FieldName = "ProjectID"
        Me.colProjectID.Name = "colProjectID"
        Me.colProjectID.Visible = True
        Me.colProjectID.VisibleIndex = 16
        '
        'colJobTemplateLines
        '
        Me.colJobTemplateLines.FieldName = "JobTemplateLines"
        Me.colJobTemplateLines.Name = "colJobTemplateLines"
        Me.colJobTemplateLines.Visible = True
        Me.colJobTemplateLines.VisibleIndex = 17
        '
        'colWorkCentreCategory
        '
        Me.colWorkCentreCategory.FieldName = "WorkCentreCategory"
        Me.colWorkCentreCategory.Name = "colWorkCentreCategory"
        Me.colWorkCentreCategory.Visible = True
        Me.colWorkCentreCategory.VisibleIndex = 18
        '
        'colCostCentre
        '
        Me.colCostCentre.FieldName = "CostCentre"
        Me.colCostCentre.Name = "colCostCentre"
        Me.colCostCentre.Visible = True
        Me.colCostCentre.VisibleIndex = 19
        '
        'xlWorkCenter2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlWorkCenter2"
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
    Friend WithEvents colFactor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalculationType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsBuyOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalculationTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHourlyRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecoveryServiceCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGLExpense As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPExpense As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimaryService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeasurement As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsageRequired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultUsage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedUsage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobTemplateLines As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentreCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostCentre As DevExpress.XtraGrid.Columns.GridColumn
End Class
