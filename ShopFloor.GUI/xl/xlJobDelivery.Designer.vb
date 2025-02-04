<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlJobDelivery
    Inherits UniSource.ShopFloor.GUI.xlgJobDelivery

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
        Me.gcJobDelivery = New DevExpress.XtraGrid.GridControl()
        Me.gvJobDelivery = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResponsibleAgentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInformation1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInformation2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJobDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.API.JobDelivery)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcJobDelivery)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcJobDelivery
        '
        Me.gcJobDelivery.DataSource = Me.BindingSource
        Me.gcJobDelivery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJobDelivery.Location = New System.Drawing.Point(0, 0)
        Me.gcJobDelivery.MainView = Me.gvJobDelivery
        Me.gcJobDelivery.MenuManager = Me.barManager
        Me.gcJobDelivery.Name = "gcJobDelivery"
        Me.gcJobDelivery.Size = New System.Drawing.Size(925, 506)
        Me.gcJobDelivery.TabIndex = 0
        Me.gcJobDelivery.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobDelivery})
        '
        'gvJobDelivery
        '
        Me.gvJobDelivery.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJob, Me.colDeliveryNumber, Me.colDeliveryDate, Me.colQuantity, Me.colAgentID, Me.colResponsibleAgentID, Me.colInformation1, Me.colInformation2, Me.colReason, Me.colID})
        Me.gvJobDelivery.GridControl = Me.gcJobDelivery
        Me.gvJobDelivery.Name = "gvJobDelivery"
        Me.gvJobDelivery.OptionsBehavior.ReadOnly = True
        '
        'colJob
        '
        Me.colJob.FieldName = "Job"
        Me.colJob.Name = "colJob"
        Me.colJob.Visible = True
        Me.colJob.VisibleIndex = 0
        '
        'colDeliveryNumber
        '
        Me.colDeliveryNumber.FieldName = "DeliveryNumber"
        Me.colDeliveryNumber.Name = "colDeliveryNumber"
        Me.colDeliveryNumber.Visible = True
        Me.colDeliveryNumber.VisibleIndex = 2
        '
        'colDeliveryDate
        '
        Me.colDeliveryDate.DisplayFormat.FormatString = "d"
        Me.colDeliveryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDeliveryDate.FieldName = "DeliveryDate"
        Me.colDeliveryDate.GroupFormat.FormatString = "d"
        Me.colDeliveryDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDeliveryDate.Name = "colDeliveryDate"
        Me.colDeliveryDate.Visible = True
        Me.colDeliveryDate.VisibleIndex = 1
        '
        'colQuantity
        '
        Me.colQuantity.DisplayFormat.FormatString = "f"
        Me.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.GroupFormat.FormatString = "f"
        Me.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 3
        '
        'colAgentID
        '
        Me.colAgentID.FieldName = "AgentID"
        Me.colAgentID.Name = "colAgentID"
        '
        'colResponsibleAgentID
        '
        Me.colResponsibleAgentID.FieldName = "ResponsibleAgentID"
        Me.colResponsibleAgentID.Name = "colResponsibleAgentID"
        '
        'colInformation1
        '
        Me.colInformation1.FieldName = "Information1"
        Me.colInformation1.Name = "colInformation1"
        Me.colInformation1.Visible = True
        Me.colInformation1.VisibleIndex = 4
        '
        'colInformation2
        '
        Me.colInformation2.FieldName = "Information2"
        Me.colInformation2.Name = "colInformation2"
        Me.colInformation2.Visible = True
        Me.colInformation2.VisibleIndex = 5
        '
        'colReason
        '
        Me.colReason.FieldName = "Reason"
        Me.colReason.Name = "colReason"
        Me.colReason.Visible = True
        Me.colReason.VisibleIndex = 6
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlJobDelivery
        '
        Me.AllowEdit = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlJobDelivery"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJobDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcJobDelivery As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobDelivery As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponsibleAgentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInformation1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInformation2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
