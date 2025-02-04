<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlJobTemplate
    Inherits UniSource.ShopFloor.GUI.xlgJobTemplate

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
        Me.gcJobTemplate = New DevExpress.XtraGrid.GridControl()
        Me.gvJobTemplate = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCostCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTemplateNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidityDays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryDays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGeneration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMake = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFunction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkCentreCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJobTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcJobTemplate)
        '
        'gcJobTemplate
        '
        Me.gcJobTemplate.DataSource = Me.BindingSource
        Me.gcJobTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJobTemplate.Location = New System.Drawing.Point(0, 0)
        Me.gcJobTemplate.MainView = Me.gvJobTemplate
        Me.gcJobTemplate.MenuManager = Me.barManager
        Me.gcJobTemplate.Name = "gcJobTemplate"
        Me.gcJobTemplate.ShowOnlyPredefinedDetails = True
        Me.gcJobTemplate.Size = New System.Drawing.Size(925, 506)
        Me.gcJobTemplate.TabIndex = 0
        Me.gcJobTemplate.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobTemplate})
        '
        'gvJobTemplate
        '
        Me.gvJobTemplate.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCostCentre, Me.colTemplateNumber, Me.colValidityDays, Me.colDeliveryDays, Me.colDescription1, Me.colDescription2, Me.colUnitPrice, Me.colUnitCost, Me.colGeneration, Me.colMake, Me.colModel, Me.colFunction, Me.colDrawing, Me.colJobType, Me.colJobCategory, Me.colID, Me.colWorkCentreCategory})
        Me.gvJobTemplate.GridControl = Me.gcJobTemplate
        Me.gvJobTemplate.Name = "gvJobTemplate"
        Me.gvJobTemplate.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvJobTemplate.OptionsBehavior.Editable = False
        Me.gvJobTemplate.OptionsBehavior.ReadOnly = True
        Me.gvJobTemplate.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.gvJobTemplate.OptionsView.ColumnAutoWidth = False
        Me.gvJobTemplate.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colJobCategory, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colCostCentre
        '
        Me.colCostCentre.FieldName = "CostCentre"
        Me.colCostCentre.FieldNameSortGroup = "CostCentre.Description"
        Me.colCostCentre.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText
        Me.colCostCentre.Name = "colCostCentre"
        Me.colCostCentre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colCostCentre.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colCostCentre.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colCostCentre.Visible = True
        Me.colCostCentre.VisibleIndex = 4
        '
        'colTemplateNumber
        '
        Me.colTemplateNumber.FieldName = "TemplateNumber"
        Me.colTemplateNumber.Name = "colTemplateNumber"
        Me.colTemplateNumber.Visible = True
        Me.colTemplateNumber.VisibleIndex = 0
        '
        'colValidityDays
        '
        Me.colValidityDays.FieldName = "ValidityDays"
        Me.colValidityDays.Name = "colValidityDays"
        Me.colValidityDays.Visible = True
        Me.colValidityDays.VisibleIndex = 5
        '
        'colDeliveryDays
        '
        Me.colDeliveryDays.FieldName = "DeliveryDays"
        Me.colDeliveryDays.Name = "colDeliveryDays"
        Me.colDeliveryDays.Visible = True
        Me.colDeliveryDays.VisibleIndex = 6
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description1"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 2
        '
        'colDescription2
        '
        Me.colDescription2.FieldName = "Description2"
        Me.colDescription2.Name = "colDescription2"
        Me.colDescription2.Visible = True
        Me.colDescription2.VisibleIndex = 7
        '
        'colUnitPrice
        '
        Me.colUnitPrice.DisplayFormat.FormatString = "c"
        Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.GroupFormat.FormatString = "c"
        Me.colUnitPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 8
        '
        'colUnitCost
        '
        Me.colUnitCost.DisplayFormat.FormatString = "c"
        Me.colUnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitCost.FieldName = "UnitCost"
        Me.colUnitCost.GroupFormat.FormatString = "c"
        Me.colUnitCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitCost.Name = "colUnitCost"
        Me.colUnitCost.Visible = True
        Me.colUnitCost.VisibleIndex = 9
        '
        'colGeneration
        '
        Me.colGeneration.FieldName = "Generation"
        Me.colGeneration.FieldNameSortGroup = "Generation.Description"
        Me.colGeneration.Name = "colGeneration"
        Me.colGeneration.Visible = True
        Me.colGeneration.VisibleIndex = 10
        '
        'colMake
        '
        Me.colMake.FieldName = "Make"
        Me.colMake.FieldNameSortGroup = "Make.Description"
        Me.colMake.Name = "colMake"
        Me.colMake.Visible = True
        Me.colMake.VisibleIndex = 11
        '
        'colModel
        '
        Me.colModel.FieldName = "Model"
        Me.colModel.FieldNameSortGroup = "Model.Description"
        Me.colModel.Name = "colModel"
        Me.colModel.Visible = True
        Me.colModel.VisibleIndex = 1
        '
        'colFunction
        '
        Me.colFunction.FieldName = "Function"
        Me.colFunction.FieldNameSortGroup = "Function.Description"
        Me.colFunction.Name = "colFunction"
        Me.colFunction.Visible = True
        Me.colFunction.VisibleIndex = 12
        '
        'colDrawing
        '
        Me.colDrawing.FieldName = "Drawing"
        Me.colDrawing.FieldNameSortGroup = "Drawing.Description"
        Me.colDrawing.Name = "colDrawing"
        Me.colDrawing.Visible = True
        Me.colDrawing.VisibleIndex = 13
        '
        'colJobType
        '
        Me.colJobType.FieldName = "JobType"
        Me.colJobType.FieldNameSortGroup = "JobType.Description"
        Me.colJobType.Name = "colJobType"
        Me.colJobType.Visible = True
        Me.colJobType.VisibleIndex = 14
        '
        'colJobCategory
        '
        Me.colJobCategory.FieldName = "JobCategory"
        Me.colJobCategory.FieldNameSortGroup = "JobCategory.Description"
        Me.colJobCategory.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.colJobCategory.Name = "colJobCategory"
        Me.colJobCategory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colJobCategory.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colJobCategory.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colJobCategory.Visible = True
        Me.colJobCategory.VisibleIndex = 3
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colWorkCentreCategory
        '
        Me.colWorkCentreCategory.FieldName = "WorkCentreCategory"
        Me.colWorkCentreCategory.FieldNameSortGroup = "WorkCentreCategory.Description"
        Me.colWorkCentreCategory.Name = "colWorkCentreCategory"
        Me.colWorkCentreCategory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colWorkCentreCategory.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colWorkCentreCategory.Visible = True
        Me.colWorkCentreCategory.VisibleIndex = 15
        '
        'xlJobTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlJobTemplate"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJobTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcJobTemplate As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobTemplate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCostCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTemplateNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidityDays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryDays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGeneration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMake As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFunction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentreCategory As DevExpress.XtraGrid.Columns.GridColumn
End Class
