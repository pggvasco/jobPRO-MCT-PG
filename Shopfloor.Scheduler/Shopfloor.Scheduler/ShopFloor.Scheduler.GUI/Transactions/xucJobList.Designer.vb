<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xucJobList
    Inherits UniSource.ShopFloor.Scheduler.GUI.xucgJobList

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
        Me.colJobCard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActivity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobCardID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsLoading = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsChanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidationErrorMessages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPropertiesValidationErrorMessages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcJobListGrid = New DevExpress.XtraGrid.GridControl()
        Me.gvJobListGrid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJobCard1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActivity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredDeliveryDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDeliveryDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedStartDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedEndDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualStartDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualEndDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobCardID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActivity2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActivity3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActivity4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActivity5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActivity6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActivity7 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.gcJobListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Job)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcJobListGrid)
        Me.GridPanel.Location = New System.Drawing.Point(0, 24)
        Me.GridPanel.Size = New System.Drawing.Size(1299, 535)
        '
        'colJobCard
        '
        Me.colJobCard.FieldName = "JobCard"
        Me.colJobCard.Name = "colJobCard"
        Me.colJobCard.OptionsColumn.ReadOnly = True
        Me.colJobCard.Visible = True
        Me.colJobCard.VisibleIndex = 0
        '
        'colLastActivity
        '
        Me.colLastActivity.FieldName = "LastActivity"
        Me.colLastActivity.Name = "colLastActivity"
        Me.colLastActivity.OptionsColumn.ReadOnly = True
        Me.colLastActivity.Visible = True
        Me.colLastActivity.VisibleIndex = 1
        '
        'colNumber
        '
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 2
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 3
        '
        'colJobDate
        '
        Me.colJobDate.FieldName = "JobDate"
        Me.colJobDate.Name = "colJobDate"
        Me.colJobDate.Visible = True
        Me.colJobDate.VisibleIndex = 4
        '
        'colRequiredDeliveryDate
        '
        Me.colRequiredDeliveryDate.FieldName = "RequiredDeliveryDate"
        Me.colRequiredDeliveryDate.Name = "colRequiredDeliveryDate"
        Me.colRequiredDeliveryDate.Visible = True
        Me.colRequiredDeliveryDate.VisibleIndex = 5
        '
        'colEstimatedDeliveryDate
        '
        Me.colEstimatedDeliveryDate.FieldName = "EstimatedDeliveryDate"
        Me.colEstimatedDeliveryDate.Name = "colEstimatedDeliveryDate"
        Me.colEstimatedDeliveryDate.Visible = True
        Me.colEstimatedDeliveryDate.VisibleIndex = 6
        '
        'colOrderPrice
        '
        Me.colOrderPrice.FieldName = "OrderPrice"
        Me.colOrderPrice.Name = "colOrderPrice"
        Me.colOrderPrice.Visible = True
        Me.colOrderPrice.VisibleIndex = 7
        '
        'colTotalCost
        '
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.Visible = True
        Me.colTotalCost.VisibleIndex = 8
        '
        'colEstimatedStartDate
        '
        Me.colEstimatedStartDate.FieldName = "EstimatedStartDate"
        Me.colEstimatedStartDate.Name = "colEstimatedStartDate"
        Me.colEstimatedStartDate.Visible = True
        Me.colEstimatedStartDate.VisibleIndex = 9
        '
        'colEstimatedEndDate
        '
        Me.colEstimatedEndDate.FieldName = "EstimatedEndDate"
        Me.colEstimatedEndDate.Name = "colEstimatedEndDate"
        Me.colEstimatedEndDate.Visible = True
        Me.colEstimatedEndDate.VisibleIndex = 10
        '
        'colActualStartDate
        '
        Me.colActualStartDate.FieldName = "ActualStartDate"
        Me.colActualStartDate.Name = "colActualStartDate"
        Me.colActualStartDate.Visible = True
        Me.colActualStartDate.VisibleIndex = 11
        '
        'colActualEndDate
        '
        Me.colActualEndDate.FieldName = "ActualEndDate"
        Me.colActualEndDate.Name = "colActualEndDate"
        Me.colActualEndDate.Visible = True
        Me.colActualEndDate.VisibleIndex = 12
        '
        'colJobCardID
        '
        Me.colJobCardID.FieldName = "JobCardID"
        Me.colJobCardID.Name = "colJobCardID"
        Me.colJobCardID.Visible = True
        Me.colJobCardID.VisibleIndex = 13
        '
        'colCustomer
        '
        Me.colCustomer.FieldName = "Customer"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 14
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 15
        '
        'colIsLoading
        '
        Me.colIsLoading.FieldName = "IsLoading"
        Me.colIsLoading.Name = "colIsLoading"
        Me.colIsLoading.OptionsColumn.ReadOnly = True
        Me.colIsLoading.Visible = True
        Me.colIsLoading.VisibleIndex = 16
        '
        'colIsChanged
        '
        Me.colIsChanged.FieldName = "IsChanged"
        Me.colIsChanged.Name = "colIsChanged"
        Me.colIsChanged.OptionsColumn.ReadOnly = True
        Me.colIsChanged.Visible = True
        Me.colIsChanged.VisibleIndex = 17
        '
        'colValidationErrorMessages
        '
        Me.colValidationErrorMessages.FieldName = "ValidationErrorMessages"
        Me.colValidationErrorMessages.Name = "colValidationErrorMessages"
        Me.colValidationErrorMessages.OptionsColumn.ReadOnly = True
        Me.colValidationErrorMessages.Visible = True
        Me.colValidationErrorMessages.VisibleIndex = 18
        '
        'colPropertiesValidationErrorMessages
        '
        Me.colPropertiesValidationErrorMessages.FieldName = "PropertiesValidationErrorMessages"
        Me.colPropertiesValidationErrorMessages.Name = "colPropertiesValidationErrorMessages"
        Me.colPropertiesValidationErrorMessages.OptionsColumn.ReadOnly = True
        Me.colPropertiesValidationErrorMessages.Visible = True
        Me.colPropertiesValidationErrorMessages.VisibleIndex = 19
        '
        'gcJobListGrid
        '
        Me.gcJobListGrid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.gcJobListGrid.DataSource = Me.BindingSource
        Me.gcJobListGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJobListGrid.Location = New System.Drawing.Point(2, 2)
        Me.gcJobListGrid.MainView = Me.gvJobListGrid
        Me.gcJobListGrid.MenuManager = Me.barManager
        Me.gcJobListGrid.Name = "gcJobListGrid"
        Me.gcJobListGrid.Size = New System.Drawing.Size(1295, 531)
        Me.gcJobListGrid.TabIndex = 0
        Me.gcJobListGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobListGrid})
        '
        'gvJobListGrid
        '
        Me.gvJobListGrid.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobCard1, Me.colLastActivity1, Me.colNumber1, Me.colDescription1, Me.colJobDate1, Me.colRequiredDeliveryDate1, Me.colEstimatedDeliveryDate1, Me.colOrderPrice1, Me.colTotalCost1, Me.colEstimatedStartDate1, Me.colEstimatedEndDate1, Me.colActualStartDate1, Me.colActualEndDate1, Me.colJobCardID1, Me.colCustomer1, Me.colLastActivity2, Me.colLastActivity3, Me.colLastActivity4, Me.colLastActivity5, Me.colLastActivity6, Me.colLastActivity7})
        Me.gvJobListGrid.GridControl = Me.gcJobListGrid
        Me.gvJobListGrid.Name = "gvJobListGrid"
        Me.gvJobListGrid.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvJobListGrid.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvJobListGrid.OptionsBehavior.Editable = False
        Me.gvJobListGrid.OptionsView.ColumnAutoWidth = False
        Me.gvJobListGrid.OptionsView.ShowFooter = True
        '
        'colJobCard1
        '
        Me.colJobCard1.FieldName = "JobCard"
        Me.colJobCard1.Name = "colJobCard1"
        Me.colJobCard1.OptionsColumn.ReadOnly = True
        '
        'colLastActivity1
        '
        Me.colLastActivity1.FieldName = "LastActivity"
        Me.colLastActivity1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colLastActivity1.Name = "colLastActivity1"
        Me.colLastActivity1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLastActivity1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLastActivity1.OptionsColumn.ReadOnly = True
        Me.colLastActivity1.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colLastActivity1.Visible = True
        Me.colLastActivity1.VisibleIndex = 4
        '
        'colNumber1
        '
        Me.colNumber1.FieldName = "Number"
        Me.colNumber1.Name = "colNumber1"
        Me.colNumber1.SummaryItem.DisplayFormat = "{0:f0}"
        Me.colNumber1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colNumber1.Visible = True
        Me.colNumber1.VisibleIndex = 0
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 2
        '
        'colJobDate1
        '
        Me.colJobDate1.DisplayFormat.FormatString = "g"
        Me.colJobDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colJobDate1.FieldName = "JobDate"
        Me.colJobDate1.GroupFormat.FormatString = "g"
        Me.colJobDate1.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colJobDate1.Name = "colJobDate1"
        Me.colJobDate1.Visible = True
        Me.colJobDate1.VisibleIndex = 1
        '
        'colRequiredDeliveryDate1
        '
        Me.colRequiredDeliveryDate1.DisplayFormat.FormatString = "d"
        Me.colRequiredDeliveryDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colRequiredDeliveryDate1.FieldName = "RequiredDeliveryDate"
        Me.colRequiredDeliveryDate1.GroupFormat.FormatString = "d"
        Me.colRequiredDeliveryDate1.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colRequiredDeliveryDate1.Name = "colRequiredDeliveryDate1"
        Me.colRequiredDeliveryDate1.Visible = True
        Me.colRequiredDeliveryDate1.VisibleIndex = 5
        '
        'colEstimatedDeliveryDate1
        '
        Me.colEstimatedDeliveryDate1.DisplayFormat.FormatString = "d"
        Me.colEstimatedDeliveryDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedDeliveryDate1.FieldName = "EstimatedDeliveryDate"
        Me.colEstimatedDeliveryDate1.GroupFormat.FormatString = "d"
        Me.colEstimatedDeliveryDate1.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedDeliveryDate1.Name = "colEstimatedDeliveryDate1"
        Me.colEstimatedDeliveryDate1.Visible = True
        Me.colEstimatedDeliveryDate1.VisibleIndex = 6
        Me.colEstimatedDeliveryDate1.Width = 116
        '
        'colOrderPrice1
        '
        Me.colOrderPrice1.DisplayFormat.FormatString = "c"
        Me.colOrderPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOrderPrice1.FieldName = "OrderPrice"
        Me.colOrderPrice1.GroupFormat.FormatString = "c"
        Me.colOrderPrice1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOrderPrice1.Name = "colOrderPrice1"
        Me.colOrderPrice1.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colOrderPrice1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colOrderPrice1.Visible = True
        Me.colOrderPrice1.VisibleIndex = 7
        '
        'colTotalCost1
        '
        Me.colTotalCost1.DisplayFormat.FormatString = "c"
        Me.colTotalCost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCost1.FieldName = "TotalCost"
        Me.colTotalCost1.GroupFormat.FormatString = "c"
        Me.colTotalCost1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCost1.Name = "colTotalCost1"
        Me.colTotalCost1.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colTotalCost1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotalCost1.Visible = True
        Me.colTotalCost1.VisibleIndex = 8
        '
        'colEstimatedStartDate1
        '
        Me.colEstimatedStartDate1.DisplayFormat.FormatString = "g"
        Me.colEstimatedStartDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedStartDate1.FieldName = "EstimatedStartDate"
        Me.colEstimatedStartDate1.GroupFormat.FormatString = "g"
        Me.colEstimatedStartDate1.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedStartDate1.Name = "colEstimatedStartDate1"
        Me.colEstimatedStartDate1.Visible = True
        Me.colEstimatedStartDate1.VisibleIndex = 9
        '
        'colEstimatedEndDate1
        '
        Me.colEstimatedEndDate1.DisplayFormat.FormatString = "g"
        Me.colEstimatedEndDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedEndDate1.FieldName = "EstimatedEndDate"
        Me.colEstimatedEndDate1.GroupFormat.FormatString = "g"
        Me.colEstimatedEndDate1.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEstimatedEndDate1.Name = "colEstimatedEndDate1"
        Me.colEstimatedEndDate1.Visible = True
        Me.colEstimatedEndDate1.VisibleIndex = 10
        '
        'colActualStartDate1
        '
        Me.colActualStartDate1.DisplayFormat.FormatString = "g"
        Me.colActualStartDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualStartDate1.FieldName = "ActualStartDate"
        Me.colActualStartDate1.GroupFormat.FormatString = "g"
        Me.colActualStartDate1.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualStartDate1.Name = "colActualStartDate1"
        Me.colActualStartDate1.Visible = True
        Me.colActualStartDate1.VisibleIndex = 11
        '
        'colActualEndDate1
        '
        Me.colActualEndDate1.DisplayFormat.FormatString = "g"
        Me.colActualEndDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualEndDate1.FieldName = "ActualEndDate"
        Me.colActualEndDate1.GroupFormat.FormatString = "g"
        Me.colActualEndDate1.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualEndDate1.Name = "colActualEndDate1"
        Me.colActualEndDate1.Visible = True
        Me.colActualEndDate1.VisibleIndex = 12
        '
        'colJobCardID1
        '
        Me.colJobCardID1.FieldName = "JobCardID"
        Me.colJobCardID1.Name = "colJobCardID1"
        '
        'colCustomer1
        '
        Me.colCustomer1.FieldName = "Customer"
        Me.colCustomer1.Name = "colCustomer1"
        Me.colCustomer1.Visible = True
        Me.colCustomer1.VisibleIndex = 3
        '
        'colLastActivity2
        '
        Me.colLastActivity2.Caption = "Last Operation"
        Me.colLastActivity2.FieldName = "LastActivity.Operation"
        Me.colLastActivity2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colLastActivity2.Name = "colLastActivity2"
        Me.colLastActivity2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLastActivity2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLastActivity2.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colLastActivity2.Visible = True
        Me.colLastActivity2.VisibleIndex = 13
        '
        'colLastActivity3
        '
        Me.colLastActivity3.Caption = "Last Artisan"
        Me.colLastActivity3.FieldName = "LastActivity.Artisan"
        Me.colLastActivity3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colLastActivity3.Name = "colLastActivity3"
        Me.colLastActivity3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLastActivity3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLastActivity3.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colLastActivity3.Visible = True
        Me.colLastActivity3.VisibleIndex = 14
        '
        'colLastActivity4
        '
        Me.colLastActivity4.Caption = "Last Machine"
        Me.colLastActivity4.FieldName = "LastActivity.Machine"
        Me.colLastActivity4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colLastActivity4.Name = "colLastActivity4"
        Me.colLastActivity4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLastActivity4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLastActivity4.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colLastActivity4.Visible = True
        Me.colLastActivity4.VisibleIndex = 15
        '
        'colLastActivity5
        '
        Me.colLastActivity5.Caption = "Last Part"
        Me.colLastActivity5.FieldName = "LastActivity.Part"
        Me.colLastActivity5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colLastActivity5.Name = "colLastActivity5"
        Me.colLastActivity5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLastActivity5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLastActivity5.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colLastActivity5.Visible = True
        Me.colLastActivity5.VisibleIndex = 16
        '
        'colLastActivity6
        '
        Me.colLastActivity6.Caption = "Start"
        Me.colLastActivity6.FieldName = "LastActivity.ActualStartDate"
        Me.colLastActivity6.Name = "colLastActivity6"
        Me.colLastActivity6.Visible = True
        Me.colLastActivity6.VisibleIndex = 17
        '
        'colLastActivity7
        '
        Me.colLastActivity7.Caption = "End"
        Me.colLastActivity7.FieldName = "LastActivity.ActualEndDate"
        Me.colLastActivity7.Name = "colLastActivity7"
        Me.colLastActivity7.Visible = True
        Me.colLastActivity7.VisibleIndex = 18
        '
        'xucJobList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xucJobList"
        Me.Size = New System.Drawing.Size(1299, 559)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.gcJobListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colJobCard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActivity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobCardID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsLoading As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsChanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidationErrorMessages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPropertiesValidationErrorMessages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcJobListGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobListGrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJobCard1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActivity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredDeliveryDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDeliveryDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedStartDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedEndDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStartDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualEndDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobCardID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActivity2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActivity3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActivity4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActivity5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActivity6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActivity7 As DevExpress.XtraGrid.Columns.GridColumn

End Class
