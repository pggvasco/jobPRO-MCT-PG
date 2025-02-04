<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlChecklist
    Inherits UniSource.ShopFloor.Scheduler.Checklist.GUI.xlgChecklist

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
        Me.gcChecklist = New DevExpress.XtraGrid.GridControl()
        Me.gvChecklist = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChecklistType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcChecklist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChecklist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(API.Checklist)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcChecklist)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcChecklist
        '
        Me.gcChecklist.DataSource = Me.BindingSource
        Me.gcChecklist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcChecklist.Location = New System.Drawing.Point(0, 0)
        Me.gcChecklist.MainView = Me.gvChecklist
        Me.gcChecklist.MenuManager = Me.barManager
        Me.gcChecklist.Name = "gcChecklist"
        Me.gcChecklist.ShowOnlyPredefinedDetails = True
        Me.gcChecklist.Size = New System.Drawing.Size(925, 506)
        Me.gcChecklist.TabIndex = 0
        Me.gcChecklist.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChecklist})
        '
        'gvChecklist
        '
        Me.gvChecklist.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colChecklistType, Me.colID})
        Me.gvChecklist.GridControl = Me.gcChecklist
        Me.gvChecklist.Name = "gvChecklist"
        Me.gvChecklist.OptionsBehavior.ReadOnly = True
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 145
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 380
        '
        'colChecklistType
        '
        Me.colChecklistType.FieldName = "ChecklistType"
        Me.colChecklistType.Name = "colChecklistType"
        Me.colChecklistType.Visible = True
        Me.colChecklistType.VisibleIndex = 2
        Me.colChecklistType.Width = 382
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlChecklist"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcChecklist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChecklist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcChecklist As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvChecklist As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChecklistType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
