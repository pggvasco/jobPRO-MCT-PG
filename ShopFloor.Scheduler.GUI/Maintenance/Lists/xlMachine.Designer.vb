<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlMachine
    Inherits UniSource.ShopFloor.Scheduler.GUI.xlgMachine

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
        Me.gcMachine = New DevExpress.XtraGrid.GridControl()
        Me.gvMachine = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colColour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChecklist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCalendarID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServiceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostCentre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Machine)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcMachine)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcMachine
        '
        Me.gcMachine.DataSource = Me.BindingSource
        Me.gcMachine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMachine.Location = New System.Drawing.Point(0, 0)
        Me.gcMachine.MainView = Me.gvMachine
        Me.gcMachine.MenuManager = Me.barManager
        Me.gcMachine.Name = "gcMachine"
        Me.gcMachine.ShowOnlyPredefinedDetails = True
        Me.gcMachine.Size = New System.Drawing.Size(925, 506)
        Me.gcMachine.TabIndex = 0
        Me.gcMachine.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMachine})
        '
        'gvMachine
        '
        Me.gvMachine.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColour, Me.colChecklist, Me.colCode, Me.colDescription, Me.colImage, Me.colRate, Me.colCalendarID, Me.colServiceCode, Me.colCostCentre, Me.colID})
        Me.gvMachine.GridControl = Me.gcMachine
        Me.gvMachine.Name = "gvMachine"
        Me.gvMachine.OptionsBehavior.ReadOnly = True
        '
        'colColour
        '
        Me.colColour.FieldName = "Colour"
        Me.colColour.Name = "colColour"
        Me.colColour.Visible = True
        Me.colColour.VisibleIndex = 4
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
        'colImage
        '
        Me.colImage.FieldName = "Image"
        Me.colImage.Name = "colImage"
        Me.colImage.Visible = True
        Me.colImage.VisibleIndex = 3
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
        'xlMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlMachine"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMachine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcMachine As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMachine As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colColour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChecklist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalendarID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostCentre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
