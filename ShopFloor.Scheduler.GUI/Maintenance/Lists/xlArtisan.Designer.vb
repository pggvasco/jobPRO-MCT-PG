<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlArtisan
    Inherits UniSource.ShopFloor.Scheduler.GUI.xlgArtisan

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
        Me.gcArtisan = New DevExpress.XtraGrid.GridControl()
        Me.gvArtisan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colColour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedTimespam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCalendarID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServiceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrimary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Artisan)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcArtisan)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcArtisan
        '
        Me.gcArtisan.DataSource = Me.BindingSource
        Me.gcArtisan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcArtisan.Location = New System.Drawing.Point(0, 0)
        Me.gcArtisan.MainView = Me.gvArtisan
        Me.gcArtisan.MenuManager = Me.barManager
        Me.gcArtisan.Name = "gcArtisan"
        Me.gcArtisan.ShowOnlyPredefinedDetails = True
        Me.gcArtisan.Size = New System.Drawing.Size(925, 506)
        Me.gcArtisan.TabIndex = 0
        Me.gcArtisan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArtisan})
        '
        'gvArtisan
        '
        Me.gvArtisan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColour, Me.colEstimatedTimespam, Me.colEstimatedDuration, Me.colCode, Me.colDescription, Me.colImage, Me.colRate, Me.colCalendarID, Me.colServiceCode, Me.colIsPrimary, Me.colPassword, Me.colCostCentre, Me.colMachine, Me.colID})
        Me.gvArtisan.GridControl = Me.gcArtisan
        Me.gvArtisan.Name = "gvArtisan"
        '
        'colColour
        '
        Me.colColour.FieldName = "Colour"
        Me.colColour.Name = "colColour"
        Me.colColour.Visible = True
        Me.colColour.VisibleIndex = 4
        '
        'colEstimatedTimespam
        '
        Me.colEstimatedTimespam.FieldName = "EstimatedTimespam"
        Me.colEstimatedTimespam.Name = "colEstimatedTimespam"
        Me.colEstimatedTimespam.OptionsColumn.ReadOnly = True
        Me.colEstimatedTimespam.Visible = True
        Me.colEstimatedTimespam.VisibleIndex = 3
        '
        'colEstimatedDuration
        '
        Me.colEstimatedDuration.FieldName = "EstimatedDuration"
        Me.colEstimatedDuration.Name = "colEstimatedDuration"
        Me.colEstimatedDuration.OptionsColumn.ReadOnly = True
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
        Me.colDescription.VisibleIndex = 2
        '
        'colImage
        '
        Me.colImage.FieldName = "Image"
        Me.colImage.Name = "colImage"
        '
        'colRate
        '
        Me.colRate.FieldName = "Rate"
        Me.colRate.Name = "colRate"
        Me.colRate.Visible = True
        Me.colRate.VisibleIndex = 5
        '
        'colCalendarID
        '
        Me.colCalendarID.FieldName = "CalendarID"
        Me.colCalendarID.Name = "colCalendarID"
        '
        'colServiceCode
        '
        Me.colServiceCode.FieldName = "ServiceCode"
        Me.colServiceCode.Name = "colServiceCode"
        Me.colServiceCode.Visible = True
        Me.colServiceCode.VisibleIndex = 6
        '
        'colIsPrimary
        '
        Me.colIsPrimary.FieldName = "IsPrimary"
        Me.colIsPrimary.Name = "colIsPrimary"
        Me.colIsPrimary.Visible = True
        Me.colIsPrimary.VisibleIndex = 7
        '
        'colPassword
        '
        Me.colPassword.FieldName = "Password"
        Me.colPassword.Name = "colPassword"
        Me.colPassword.Visible = True
        Me.colPassword.VisibleIndex = 1
        '
        'colCostCentre
        '
        Me.colCostCentre.FieldName = "CostCentre"
        Me.colCostCentre.Name = "colCostCentre"
        Me.colCostCentre.Visible = True
        Me.colCostCentre.VisibleIndex = 8
        '
        'colMachine
        '
        Me.colMachine.FieldName = "Machine"
        Me.colMachine.Name = "colMachine"
        Me.colMachine.Visible = True
        Me.colMachine.VisibleIndex = 9
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlArtisan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlArtisan"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcArtisan As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvArtisan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colColour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedTimespam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalendarID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrimary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
