<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlQIR
    Inherits UniSource.ShopFloor.Scheduler.GUI.xlgQIR

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
        Me.gcQIR = New DevExpress.XtraGrid.GridControl()
        Me.gvQIR = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLogDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogAgentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogAgentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReasonCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcQIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQIR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.QIR)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcQIR)
        '
        'gcQIR
        '
        Me.gcQIR.DataSource = Me.BindingSource
        Me.gcQIR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcQIR.Location = New System.Drawing.Point(0, 0)
        Me.gcQIR.MainView = Me.gvQIR
        Me.gcQIR.MenuManager = Me.barManager
        Me.gcQIR.Name = "gcQIR"
        Me.gcQIR.ShowOnlyPredefinedDetails = True
        Me.gcQIR.Size = New System.Drawing.Size(925, 506)
        Me.gcQIR.TabIndex = 0
        Me.gcQIR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQIR})
        '
        'gvQIR
        '
        Me.gvQIR.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivity, Me.colReasonCode, Me.colLogDateTime, Me.colLogAgentName, Me.colLogAgentID, Me.colID})
        Me.gvQIR.GridControl = Me.gcQIR
        Me.gvQIR.Name = "gvQIR"
        Me.gvQIR.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvQIR.OptionsBehavior.Editable = False
        Me.gvQIR.OptionsBehavior.ReadOnly = True
        '
        'colLogDateTime
        '
        Me.colLogDateTime.FieldName = "LogDateTime"
        Me.colLogDateTime.Name = "colLogDateTime"
        Me.colLogDateTime.Visible = True
        Me.colLogDateTime.VisibleIndex = 2
        '
        'colLogAgentID
        '
        Me.colLogAgentID.FieldName = "LogAgentID"
        Me.colLogAgentID.Name = "colLogAgentID"
        '
        'colLogAgentName
        '
        Me.colLogAgentName.FieldName = "LogAgentName"
        Me.colLogAgentName.Name = "colLogAgentName"
        Me.colLogAgentName.Visible = True
        Me.colLogAgentName.VisibleIndex = 3
        '
        'colActivity
        '
        Me.colActivity.FieldName = "Activity"
        Me.colActivity.Name = "colActivity"
        Me.colActivity.Visible = True
        Me.colActivity.VisibleIndex = 0
        '
        'colReasonCode
        '
        Me.colReasonCode.FieldName = "ReasonCode"
        Me.colReasonCode.Name = "colReasonCode"
        Me.colReasonCode.Visible = True
        Me.colReasonCode.VisibleIndex = 1
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlQIR
        '
        Me.AllowAdd = False
        Me.AllowDelete = False
        Me.AllowEdit = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlQIR"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcQIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQIR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcQIR As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvQIR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReasonCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogAgentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogAgentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
