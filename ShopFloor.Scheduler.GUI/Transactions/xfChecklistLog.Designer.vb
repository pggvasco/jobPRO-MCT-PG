<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfChecklistLog
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container()
        Me.gcChecklistLog = New DevExpress.XtraGrid.GridControl()
        Me.ChecklistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvChecklistLog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gcChecklistLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChecklistLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcChecklistLog
        '
        Me.gcChecklistLog.DataSource = Me.ChecklistBindingSource
        Me.gcChecklistLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcChecklistLog.Location = New System.Drawing.Point(0, 0)
        Me.gcChecklistLog.MainView = Me.gvChecklistLog
        Me.gcChecklistLog.Name = "gcChecklistLog"
        Me.gcChecklistLog.Size = New System.Drawing.Size(747, 404)
        Me.gcChecklistLog.TabIndex = 0
        Me.gcChecklistLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChecklistLog})
        '
        'ChecklistBindingSource
        '
        Me.ChecklistBindingSource.DataSource = GetType(UniSource.Checklist.API.Checklist)
        '
        'gvChecklistLog
        '
        Me.gvChecklistLog.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription})
        Me.gvChecklistLog.GridControl = Me.gcChecklistLog
        Me.gvChecklistLog.Name = "gvChecklistLog"
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
        'xfChecklistLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 404)
        Me.Controls.Add(Me.gcChecklistLog)
        Me.Name = "xfChecklistLog"
        Me.Text = "Checklist Log"
        CType(Me.gcChecklistLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChecklistLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcChecklistLog As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvChecklistLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChecklistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
End Class
