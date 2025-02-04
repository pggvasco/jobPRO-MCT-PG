<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlJobAudit
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gcJobAudit = New DevExpress.XtraGrid.GridControl()
        Me.AuditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvJobAudit = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOldValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtJobNumber = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colJobLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.gcJobAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcJobAudit
        '
        Me.gcJobAudit.DataSource = Me.AuditBindingSource
        Me.gcJobAudit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJobAudit.Location = New System.Drawing.Point(0, 0)
        Me.gcJobAudit.MainView = Me.gvJobAudit
        Me.gcJobAudit.Name = "gcJobAudit"
        Me.gcJobAudit.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtJobNumber})
        Me.gcJobAudit.Size = New System.Drawing.Size(982, 499)
        Me.gcJobAudit.TabIndex = 0
        Me.gcJobAudit.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobAudit})
        '
        'AuditBindingSource
        '
        Me.AuditBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Audit)
        '
        'gvJobAudit
        '
        Me.gvJobAudit.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDate, Me.colAgent, Me.colDescription, Me.colType, Me.colOldValue, Me.colNewValue, Me.colJob, Me.colJobLine, Me.colID, Me.colError})
        Me.gvJobAudit.GridControl = Me.gcJobAudit
        Me.gvJobAudit.Name = "gvJobAudit"
        '
        'colDate
        '
        Me.colDate.DisplayFormat.FormatString = "f"
        Me.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDate.FieldName = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.OptionsColumn.ReadOnly = True
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 0
        '
        'colAgent
        '
        Me.colAgent.Caption = "Agent"
        Me.colAgent.FieldName = "Agent.DisplayName"
        Me.colAgent.Name = "colAgent"
        Me.colAgent.OptionsColumn.ReadOnly = True
        Me.colAgent.Visible = True
        Me.colAgent.VisibleIndex = 1
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.ReadOnly = True
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 3
        '
        'colType
        '
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.OptionsColumn.ReadOnly = True
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 4
        '
        'colOldValue
        '
        Me.colOldValue.FieldName = "OldValue"
        Me.colOldValue.Name = "colOldValue"
        Me.colOldValue.OptionsColumn.ReadOnly = True
        Me.colOldValue.Visible = True
        Me.colOldValue.VisibleIndex = 5
        '
        'colNewValue
        '
        Me.colNewValue.FieldName = "NewValue"
        Me.colNewValue.Name = "colNewValue"
        Me.colNewValue.OptionsColumn.ReadOnly = True
        Me.colNewValue.Visible = True
        Me.colNewValue.VisibleIndex = 6
        '
        'colJob
        '
        Me.colJob.Caption = "Job #"
        Me.colJob.ColumnEdit = Me.txtJobNumber
        Me.colJob.FieldName = "job.JobNumber"
        Me.colJob.Name = "colJob"
        Me.colJob.OptionsColumn.ReadOnly = True
        Me.colJob.Visible = True
        Me.colJob.VisibleIndex = 2
        '
        'txtJobNumber
        '
        Me.txtJobNumber.AutoHeight = False
        Me.txtJobNumber.Name = "txtJobNumber"
        '
        'colJobLine
        '
        Me.colJobLine.FieldName = "JobLine"
        Me.colJobLine.Name = "colJobLine"
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
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(UniSource.ShopFloor.API.Job)
        '
        'xlJobAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gcJobAudit)
        Me.Name = "xlJobAudit"
        Me.Size = New System.Drawing.Size(982, 499)
        CType(Me.gcJobAudit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobAudit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcJobAudit As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobAudit As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AuditBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOldValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtJobNumber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource

End Class
