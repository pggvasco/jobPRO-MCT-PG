<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlRequisition
    Inherits UniSource.ShopFloor.GUI.xlgRequisition

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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gvRequisitionLines = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInventoryItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRequisition = New DevExpress.XtraGrid.GridControl()
        Me.gvRequisition = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplyScope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkCentreCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRequisitionLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcRequisition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRequisition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcRequisition)
        '
        'gvRequisitionLines
        '
        Me.gvRequisitionLines.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInventoryItem, Me.colQuantity, Me.colUnitCost, Me.colTotalCost, Me.colLineNote, Me.colID1})
        Me.gvRequisitionLines.GridControl = Me.gcRequisition
        Me.gvRequisitionLines.Name = "gvRequisitionLines"
        Me.gvRequisitionLines.OptionsBehavior.ReadOnly = True
        '
        'colInventoryItem
        '
        Me.colInventoryItem.FieldName = "InventoryItem"
        Me.colInventoryItem.Name = "colInventoryItem"
        Me.colInventoryItem.Visible = True
        Me.colInventoryItem.VisibleIndex = 0
        '
        'colQuantity
        '
        Me.colQuantity.DisplayFormat.FormatString = "f"
        Me.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.GroupFormat.FormatString = "f"
        Me.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:f2}")})
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 1
        '
        'colUnitCost
        '
        Me.colUnitCost.DisplayFormat.FormatString = "c"
        Me.colUnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitCost.FieldName = "UnitCost"
        Me.colUnitCost.GroupFormat.FormatString = "c"
        Me.colUnitCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitCost.Name = "colUnitCost"
        Me.colUnitCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitCost", "{0:c2}")})
        Me.colUnitCost.Visible = True
        Me.colUnitCost.VisibleIndex = 2
        '
        'colTotalCost
        '
        Me.colTotalCost.DisplayFormat.FormatString = "c"
        Me.colTotalCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.GroupFormat.FormatString = "c"
        Me.colTotalCost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCost", "{0:c2}")})
        Me.colTotalCost.Visible = True
        Me.colTotalCost.VisibleIndex = 3
        '
        'colLineNote
        '
        Me.colLineNote.FieldName = "LineNote"
        Me.colLineNote.Name = "colLineNote"
        Me.colLineNote.Visible = True
        Me.colLineNote.VisibleIndex = 4
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'gcRequisition
        '
        Me.gcRequisition.DataSource = Me.BindingSource
        Me.gcRequisition.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvRequisitionLines
        GridLevelNode1.RelationName = "RequisitionLineList"
        Me.gcRequisition.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcRequisition.Location = New System.Drawing.Point(0, 0)
        Me.gcRequisition.MainView = Me.gvRequisition
        Me.gcRequisition.MenuManager = Me.barManager
        Me.gcRequisition.Name = "gcRequisition"
        Me.gcRequisition.ShowOnlyPredefinedDetails = True
        Me.gcRequisition.Size = New System.Drawing.Size(925, 506)
        Me.gcRequisition.TabIndex = 0
        Me.gcRequisition.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRequisition, Me.gvRequisitionLines})
        '
        'gvRequisition
        '
        Me.gvRequisition.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJob, Me.colNumber, Me.colDate, Me.colAgentID, Me.colAgentName, Me.colPart, Me.colPartGroup, Me.colSupplyScope, Me.colWorkCentre, Me.colWorkCentreCategory, Me.colID})
        Me.gvRequisition.GridControl = Me.gcRequisition
        Me.gvRequisition.Name = "gvRequisition"
        Me.gvRequisition.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvRequisition.OptionsBehavior.Editable = False
        Me.gvRequisition.OptionsBehavior.ReadOnly = True
        Me.gvRequisition.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        '
        'colJob
        '
        Me.colJob.FieldName = "Job"
        Me.colJob.Name = "colJob"
        Me.colJob.Visible = True
        Me.colJob.VisibleIndex = 0
        '
        'colNumber
        '
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 1
        '
        'colDate
        '
        Me.colDate.FieldName = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 2
        '
        'colAgentID
        '
        Me.colAgentID.FieldName = "AgentID"
        Me.colAgentID.Name = "colAgentID"
        '
        'colAgentName
        '
        Me.colAgentName.FieldName = "AgentName"
        Me.colAgentName.Name = "colAgentName"
        Me.colAgentName.Visible = True
        Me.colAgentName.VisibleIndex = 3
        '
        'colPart
        '
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        '
        'colPartGroup
        '
        Me.colPartGroup.FieldName = "PartGroup"
        Me.colPartGroup.Name = "colPartGroup"
        '
        'colSupplyScope
        '
        Me.colSupplyScope.FieldName = "SupplyScope"
        Me.colSupplyScope.Name = "colSupplyScope"
        '
        'colWorkCentre
        '
        Me.colWorkCentre.FieldName = "WorkCentre"
        Me.colWorkCentre.Name = "colWorkCentre"
        '
        'colWorkCentreCategory
        '
        Me.colWorkCentreCategory.FieldName = "WorkCentreCategory"
        Me.colWorkCentreCategory.Name = "colWorkCentreCategory"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlRequisition"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRequisitionLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcRequisition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRequisition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcRequisition As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRequisition As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gvRequisitionLines As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colInventoryItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplyScope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkCentreCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
