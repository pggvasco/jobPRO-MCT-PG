<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlAsset
    Inherits UniSource.ShopFloor.GUI.xlgAsset

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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrimaryassetId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssetCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAsset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInternalAsset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocalAssets = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerialNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssetClass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServiceArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLifespan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFuelconsumptionApplicable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateAcquired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAverageConsumption = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnderWarranty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarrantyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarrantyStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarrantyEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridPanel.Location = New System.Drawing.Point(0, 57)
        Me.GridPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridPanel.Size = New System.Drawing.Size(1079, 631)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.MenuManager = Me.barManager
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1079, 631)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrimaryassetId, Me.colAssetCode, Me.colAsset, Me.colActive, Me.colInternalAsset, Me.colLocalAssets, Me.colSerialNo, Me.colAssetClass, Me.colLocation, Me.colServiceArea, Me.colUsage, Me.colLifespan, Me.colDescription, Me.colPurchaseCost, Me.colFuelconsumptionApplicable, Me.colDateAcquired, Me.colAverageConsumption, Me.colUnderWarranty, Me.colWarrantyCode, Me.colWarrantyStartDate, Me.colWarrantyEndDate})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'colPrimaryassetId
        '
        Me.colPrimaryassetId.FieldName = "PrimaryassetId"
        Me.colPrimaryassetId.Name = "colPrimaryassetId"
        Me.colPrimaryassetId.Visible = True
        Me.colPrimaryassetId.VisibleIndex = 0
        Me.colPrimaryassetId.Width = 53
        '
        'colAssetCode
        '
        Me.colAssetCode.FieldName = "AssetCode"
        Me.colAssetCode.Name = "colAssetCode"
        Me.colAssetCode.Visible = True
        Me.colAssetCode.VisibleIndex = 1
        Me.colAssetCode.Width = 53
        '
        'colAsset
        '
        Me.colAsset.FieldName = "Asset"
        Me.colAsset.Name = "colAsset"
        Me.colAsset.Visible = True
        Me.colAsset.VisibleIndex = 2
        Me.colAsset.Width = 53
        '
        'colActive
        '
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.Visible = True
        Me.colActive.VisibleIndex = 3
        Me.colActive.Width = 53
        '
        'colInternalAsset
        '
        Me.colInternalAsset.FieldName = "InternalAsset"
        Me.colInternalAsset.Name = "colInternalAsset"
        Me.colInternalAsset.Visible = True
        Me.colInternalAsset.VisibleIndex = 4
        Me.colInternalAsset.Width = 53
        '
        'colLocalAssets
        '
        Me.colLocalAssets.FieldName = "LocalAssets"
        Me.colLocalAssets.Name = "colLocalAssets"
        Me.colLocalAssets.Visible = True
        Me.colLocalAssets.VisibleIndex = 5
        Me.colLocalAssets.Width = 67
        '
        'colSerialNo
        '
        Me.colSerialNo.FieldName = "SerialNo"
        Me.colSerialNo.Name = "colSerialNo"
        Me.colSerialNo.Visible = True
        Me.colSerialNo.VisibleIndex = 6
        Me.colSerialNo.Width = 50
        '
        'colAssetClass
        '
        Me.colAssetClass.FieldName = "AssetClass"
        Me.colAssetClass.Name = "colAssetClass"
        Me.colAssetClass.Visible = True
        Me.colAssetClass.VisibleIndex = 7
        Me.colAssetClass.Width = 50
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 8
        Me.colLocation.Width = 50
        '
        'colServiceArea
        '
        Me.colServiceArea.FieldName = "ServiceArea"
        Me.colServiceArea.Name = "colServiceArea"
        Me.colServiceArea.Visible = True
        Me.colServiceArea.VisibleIndex = 9
        Me.colServiceArea.Width = 50
        '
        'colUsage
        '
        Me.colUsage.FieldName = "TotalUsage"
        Me.colUsage.Name = "colUsage"
        Me.colUsage.Visible = True
        Me.colUsage.VisibleIndex = 10
        Me.colUsage.Width = 50
        '
        'colLifespan
        '
        Me.colLifespan.FieldName = "Lifespan"
        Me.colLifespan.Name = "colLifespan"
        Me.colLifespan.Visible = True
        Me.colLifespan.VisibleIndex = 11
        Me.colLifespan.Width = 50
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 12
        Me.colDescription.Width = 50
        '
        'colPurchaseCost
        '
        Me.colPurchaseCost.FieldName = "PurchaseCost"
        Me.colPurchaseCost.Name = "colPurchaseCost"
        Me.colPurchaseCost.Visible = True
        Me.colPurchaseCost.VisibleIndex = 13
        Me.colPurchaseCost.Width = 50
        '
        'colFuelconsumptionApplicable
        '
        Me.colFuelconsumptionApplicable.FieldName = "FuelconsumptionApplicable"
        Me.colFuelconsumptionApplicable.Name = "colFuelconsumptionApplicable"
        Me.colFuelconsumptionApplicable.Visible = True
        Me.colFuelconsumptionApplicable.VisibleIndex = 14
        Me.colFuelconsumptionApplicable.Width = 50
        '
        'colDateAcquired
        '
        Me.colDateAcquired.FieldName = "DateAcquired"
        Me.colDateAcquired.Name = "colDateAcquired"
        Me.colDateAcquired.Visible = True
        Me.colDateAcquired.VisibleIndex = 15
        Me.colDateAcquired.Width = 50
        '
        'colAverageConsumption
        '
        Me.colAverageConsumption.FieldName = "AverageConsumption"
        Me.colAverageConsumption.Name = "colAverageConsumption"
        Me.colAverageConsumption.Visible = True
        Me.colAverageConsumption.VisibleIndex = 16
        '
        'colUnderWarranty
        '
        Me.colUnderWarranty.Caption = "Under Warranty"
        Me.colUnderWarranty.FieldName = "UnderWarranty"
        Me.colUnderWarranty.Name = "colUnderWarranty"
        Me.colUnderWarranty.Visible = True
        Me.colUnderWarranty.VisibleIndex = 17
        '
        'colWarrantyCode
        '
        Me.colWarrantyCode.Caption = "Warranty Code"
        Me.colWarrantyCode.FieldName = "WarrantyCode"
        Me.colWarrantyCode.Name = "colWarrantyCode"
        Me.colWarrantyCode.Visible = True
        Me.colWarrantyCode.VisibleIndex = 18
        '
        'colWarrantyStartDate
        '
        Me.colWarrantyStartDate.Caption = "Warranty Start Date"
        Me.colWarrantyStartDate.FieldName = "WarrantyStartDate"
        Me.colWarrantyStartDate.Name = "colWarrantyStartDate"
        Me.colWarrantyStartDate.Visible = True
        Me.colWarrantyStartDate.VisibleIndex = 19
        '
        'colWarrantyEndDate
        '
        Me.colWarrantyEndDate.Caption = "Warranty End Date"
        Me.colWarrantyEndDate.FieldName = "WarrantyEndDate"
        Me.colWarrantyEndDate.Name = "colWarrantyEndDate"
        Me.colWarrantyEndDate.Visible = True
        Me.colWarrantyEndDate.VisibleIndex = 20
        '
        'xlAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "xlAsset"
        Me.Size = New System.Drawing.Size(1079, 688)
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
    Friend WithEvents colPrimaryassetId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssetCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAsset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInternalAsset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerialNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssetClass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLifespan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFuelconsumptionApplicable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateAcquired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAverageConsumption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocalAssets As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnderWarranty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarrantyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarrantyStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarrantyEndDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
