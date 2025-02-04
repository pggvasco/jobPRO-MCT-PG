<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlJob
    Inherits UniSource.ShopFloor.Scheduler.GUI.xlgJob

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
        Me.gcJob = New DevExpress.XtraGrid.GridControl()
        Me.gvJob = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLastActivity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrimaryArtisan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterials = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrimaryOperationHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobCardID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsMaterialAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Job)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcJob)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcJob
        '
        Me.gcJob.DataSource = Me.BindingSource
        Me.gcJob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJob.Location = New System.Drawing.Point(0, 0)
        Me.gcJob.MainView = Me.gvJob
        Me.gcJob.MenuManager = Me.barManager
        Me.gcJob.Name = "gcJob"
        Me.gcJob.ShowOnlyPredefinedDetails = True
        Me.gcJob.Size = New System.Drawing.Size(925, 506)
        Me.gcJob.TabIndex = 0
        Me.gcJob.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJob})
        '
        'gvJob
        '
        Me.gvJob.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLastActivity, Me.colTotalCost, Me.colActualEndDate, Me.colActualStartDate, Me.colEstimatedEndDate, Me.colEstimatedStartDate, Me.colPrimaryArtisan, Me.colMaterials, Me.colPrimaryOperationHours, Me.colNumber, Me.colDescription, Me.colJobDate, Me.colRequiredDeliveryDate, Me.colEstimatedDeliveryDate, Me.colOrderPrice, Me.colJobCardID, Me.colCustomer, Me.colDrawing, Me.colID, Me.colIsMaterialAvailable})
        Me.gvJob.GridControl = Me.gcJob
        Me.gvJob.Name = "gvJob"
        Me.gvJob.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvJob.OptionsBehavior.Editable = False
        Me.gvJob.OptionsBehavior.ReadOnly = True
        Me.gvJob.OptionsView.ColumnAutoWidth = False
        '
        'colLastActivity
        '
        Me.colLastActivity.FieldName = "LastActivity"
        Me.colLastActivity.Name = "colLastActivity"
        Me.colLastActivity.OptionsColumn.ReadOnly = True
        Me.colLastActivity.Visible = True
        Me.colLastActivity.VisibleIndex = 5
        Me.colLastActivity.Width = 78
        '
        'colTotalCost
        '
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.Visible = True
        Me.colTotalCost.VisibleIndex = 6
        '
        'colActualEndDate
        '
        Me.colActualEndDate.FieldName = "ActualEndDate"
        Me.colActualEndDate.Name = "colActualEndDate"
        Me.colActualEndDate.Visible = True
        Me.colActualEndDate.VisibleIndex = 7
        Me.colActualEndDate.Width = 96
        '
        'colActualStartDate
        '
        Me.colActualStartDate.FieldName = "ActualStartDate"
        Me.colActualStartDate.Name = "colActualStartDate"
        Me.colActualStartDate.Visible = True
        Me.colActualStartDate.VisibleIndex = 8
        Me.colActualStartDate.Width = 102
        '
        'colEstimatedEndDate
        '
        Me.colEstimatedEndDate.FieldName = "EstimatedEndDate"
        Me.colEstimatedEndDate.Name = "colEstimatedEndDate"
        Me.colEstimatedEndDate.Visible = True
        Me.colEstimatedEndDate.VisibleIndex = 9
        Me.colEstimatedEndDate.Width = 113
        '
        'colEstimatedStartDate
        '
        Me.colEstimatedStartDate.FieldName = "EstimatedStartDate"
        Me.colEstimatedStartDate.Name = "colEstimatedStartDate"
        Me.colEstimatedStartDate.Visible = True
        Me.colEstimatedStartDate.VisibleIndex = 10
        Me.colEstimatedStartDate.Width = 119
        '
        'colPrimaryArtisan
        '
        Me.colPrimaryArtisan.FieldName = "PrimaryArtisan"
        Me.colPrimaryArtisan.Name = "colPrimaryArtisan"
        Me.colPrimaryArtisan.Visible = True
        Me.colPrimaryArtisan.VisibleIndex = 11
        Me.colPrimaryArtisan.Width = 92
        '
        'colMaterials
        '
        Me.colMaterials.FieldName = "Materials"
        Me.colMaterials.Name = "colMaterials"
        Me.colMaterials.OptionsColumn.ReadOnly = True
        Me.colMaterials.Visible = True
        Me.colMaterials.VisibleIndex = 12
        '
        'colPrimaryOperationHours
        '
        Me.colPrimaryOperationHours.FieldName = "PrimaryOperationHours"
        Me.colPrimaryOperationHours.Name = "colPrimaryOperationHours"
        Me.colPrimaryOperationHours.OptionsColumn.ReadOnly = True
        Me.colPrimaryOperationHours.Visible = True
        Me.colPrimaryOperationHours.VisibleIndex = 13
        Me.colPrimaryOperationHours.Width = 137
        '
        'colNumber
        '
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 0
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        '
        'colJobDate
        '
        Me.colJobDate.FieldName = "JobDate"
        Me.colJobDate.Name = "colJobDate"
        Me.colJobDate.Visible = True
        Me.colJobDate.VisibleIndex = 3
        '
        'colRequiredDeliveryDate
        '
        Me.colRequiredDeliveryDate.FieldName = "RequiredDeliveryDate"
        Me.colRequiredDeliveryDate.Name = "colRequiredDeliveryDate"
        Me.colRequiredDeliveryDate.Visible = True
        Me.colRequiredDeliveryDate.VisibleIndex = 4
        Me.colRequiredDeliveryDate.Width = 130
        '
        'colEstimatedDeliveryDate
        '
        Me.colEstimatedDeliveryDate.FieldName = "EstimatedDeliveryDate"
        Me.colEstimatedDeliveryDate.Name = "colEstimatedDeliveryDate"
        Me.colEstimatedDeliveryDate.Visible = True
        Me.colEstimatedDeliveryDate.VisibleIndex = 14
        Me.colEstimatedDeliveryDate.Width = 134
        '
        'colOrderPrice
        '
        Me.colOrderPrice.FieldName = "OrderPrice"
        Me.colOrderPrice.Name = "colOrderPrice"
        Me.colOrderPrice.Visible = True
        Me.colOrderPrice.VisibleIndex = 15
        '
        'colJobCardID
        '
        Me.colJobCardID.FieldName = "JobCardID"
        Me.colJobCardID.Name = "colJobCardID"
        '
        'colCustomer
        '
        Me.colCustomer.FieldName = "Customer"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 2
        '
        'colDrawing
        '
        Me.colDrawing.FieldName = "Drawing"
        Me.colDrawing.Name = "colDrawing"
        Me.colDrawing.Visible = True
        Me.colDrawing.VisibleIndex = 16
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colIsMaterialAvailable
        '
        Me.colIsMaterialAvailable.FieldName = "IsMaterialAvailable"
        Me.colIsMaterialAvailable.Name = "colIsMaterialAvailable"
        Me.colIsMaterialAvailable.Visible = True
        Me.colIsMaterialAvailable.VisibleIndex = 17
        '
        'xlJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlJob"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcJob As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJob As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLastActivity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimaryArtisan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterials As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimaryOperationHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobCardID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMaterialAvailable As DevExpress.XtraGrid.Columns.GridColumn

End Class
