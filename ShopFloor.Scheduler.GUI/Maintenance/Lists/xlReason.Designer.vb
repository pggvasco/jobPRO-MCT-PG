<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlReason
    Inherits UniSource.ShopFloor.Scheduler.GUI.xlgReason

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
        Me.gcReasonCode = New DevExpress.XtraGrid.GridControl()
        Me.gvReasonCode = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsTriggerMessage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcReasonCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReasonCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.ReasonCode)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcReasonCode)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcReasonCode
        '
        Me.gcReasonCode.DataSource = Me.BindingSource
        Me.gcReasonCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcReasonCode.Location = New System.Drawing.Point(0, 0)
        Me.gcReasonCode.MainView = Me.gvReasonCode
        Me.gcReasonCode.MenuManager = Me.barManager
        Me.gcReasonCode.Name = "gcReasonCode"
        Me.gcReasonCode.ShowOnlyPredefinedDetails = True
        Me.gcReasonCode.Size = New System.Drawing.Size(925, 506)
        Me.gcReasonCode.TabIndex = 0
        Me.gcReasonCode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvReasonCode})
        '
        'gvReasonCode
        '
        Me.gvReasonCode.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colIsTriggerMessage, Me.colID})
        Me.gvReasonCode.GridControl = Me.gcReasonCode
        Me.gvReasonCode.Name = "gvReasonCode"
        Me.gvReasonCode.OptionsBehavior.ReadOnly = True
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
        'colIsTriggerMessage
        '
        Me.colIsTriggerMessage.FieldName = "IsTriggerMessage"
        Me.colIsTriggerMessage.Name = "colIsTriggerMessage"
        Me.colIsTriggerMessage.Visible = True
        Me.colIsTriggerMessage.VisibleIndex = 2
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlReason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlReason"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcReasonCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReasonCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcReasonCode As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvReasonCode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsTriggerMessage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
