<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlCustomerRatePrice
    Inherits UniSource.ShopFloor.GUI.xlgCustomerRateTime

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
        Me.colClient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcustomerRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colERPCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeekDayPriceList = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridPanel.Size = New System.Drawing.Size(989, 353)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.barManager
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(989, 353)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClient, Me.colcustomerRate, Me.colERPCustomerID, Me.colID, Me.colError, Me.colWeekDayPriceList, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
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
        Me.colcustomerRate.OptionsColumn.ReadOnly = True
        '
        'colERPCustomerID
        '
        Me.colERPCustomerID.FieldName = "ERPCustomerID"
        Me.colERPCustomerID.Name = "colERPCustomerID"
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
        'colWeekDayPriceList
        '
        Me.colWeekDayPriceList.Caption = "WeekDayPriceList"
        Me.colWeekDayPriceList.FieldName = "customerRate.WeekDayPriceList"
        Me.colWeekDayPriceList.Name = "colWeekDayPriceList"
        Me.colWeekDayPriceList.Visible = True
        Me.colWeekDayPriceList.VisibleIndex = 2
        Me.colWeekDayPriceList.Width = 118
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Code"
        Me.GridColumn1.FieldName = "Client.Code"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 97
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Name"
        Me.GridColumn2.FieldName = "Client.Description"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 97
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Week Night Price list"
        Me.GridColumn3.FieldName = "customerRate.WeekNightPriceList"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 144
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Saturday Day Price List"
        Me.GridColumn4.FieldName = "customerRate.SaturdayDayPriceList"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 108
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Saturday night Price list"
        Me.GridColumn5.FieldName = "customerRate.SaturdayNightPriceList"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 80
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Sunday Day Pricel List"
        Me.GridColumn6.FieldName = "customerRate.SundayDayPriceList"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 80
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Sunday Night Price List"
        Me.GridColumn7.FieldName = "customerRate.SundayNightPriceList"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 80
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Public Holiday Day Price List"
        Me.GridColumn8.FieldName = "customerRate.PublicHolidayDayPricelist"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 80
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Public Holiday Night Price List"
        Me.GridColumn9.FieldName = "customerRate.PublicHolidayNightPricelist"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 87
        '
        'xlCustomerRatePrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlCustomerRatePrice"
        Me.Size = New System.Drawing.Size(989, 406)
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
    Friend WithEvents colClient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomerRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colERPCustomerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeekDayPriceList As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
End Class
