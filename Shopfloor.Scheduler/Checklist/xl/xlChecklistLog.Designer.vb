<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlChecklistLog
    Inherits UniSource.Checklist.GUI.xlgChecklistLog

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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gvChecklistOptionLog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChecklistOption = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChecklist1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChecklistLog = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcChecklistLog = New DevExpress.XtraGrid.GridControl()
        Me.gvChecklistLog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAgentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChecklist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChecklistOptionLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcChecklistLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChecklistLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcChecklistLog)
        '
        'gvChecklistOptionLog
        '
        Me.gvChecklistOptionLog.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDocument, Me.colChecklistOption, Me.colValue, Me.colLogDateTime, Me.colChecklist1, Me.colChecklistLog, Me.colID1})
        Me.gvChecklistOptionLog.GridControl = Me.gcChecklistLog
        Me.gvChecklistOptionLog.Name = "gvChecklistOptionLog"
        Me.gvChecklistOptionLog.OptionsView.ShowGroupPanel = False
        '
        'colDocument
        '
        Me.colDocument.FieldName = "Document"
        Me.colDocument.Name = "colDocument"
        '
        'colChecklistOption
        '
        Me.colChecklistOption.FieldName = "ChecklistOption"
        Me.colChecklistOption.Name = "colChecklistOption"
        Me.colChecklistOption.Visible = True
        Me.colChecklistOption.VisibleIndex = 0
        '
        'colValue
        '
        Me.colValue.FieldName = "Value"
        Me.colValue.Name = "colValue"
        Me.colValue.Visible = True
        Me.colValue.VisibleIndex = 1
        '
        'colLogDateTime
        '
        Me.colLogDateTime.FieldName = "LogDateTime"
        Me.colLogDateTime.Name = "colLogDateTime"
        Me.colLogDateTime.Visible = True
        Me.colLogDateTime.VisibleIndex = 2
        '
        'colChecklist1
        '
        Me.colChecklist1.FieldName = "Checklist"
        Me.colChecklist1.Name = "colChecklist1"
        '
        'colChecklistLog
        '
        Me.colChecklistLog.FieldName = "ChecklistLog"
        Me.colChecklistLog.Name = "colChecklistLog"
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'gcChecklistLog
        '
        Me.gcChecklistLog.DataSource = Me.BindingSource
        Me.gcChecklistLog.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvChecklistOptionLog
        GridLevelNode1.RelationName = "ChecklistOptionLogList"
        Me.gcChecklistLog.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcChecklistLog.Location = New System.Drawing.Point(0, 0)
        Me.gcChecklistLog.MainView = Me.gvChecklistLog
        Me.gcChecklistLog.MenuManager = Me.barManager
        Me.gcChecklistLog.Name = "gcChecklistLog"
        Me.gcChecklistLog.Size = New System.Drawing.Size(925, 506)
        Me.gcChecklistLog.TabIndex = 0
        Me.gcChecklistLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChecklistLog, Me.gvChecklistOptionLog})
        '
        'gvChecklistLog
        '
        Me.gvChecklistLog.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAgentID, Me.colAgentName, Me.colStartDateTime, Me.colEndDateTime, Me.colRecordID, Me.colChecklist, Me.colID})
        Me.gvChecklistLog.GridControl = Me.gcChecklistLog
        Me.gvChecklistLog.Name = "gvChecklistLog"
        Me.gvChecklistLog.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvChecklistLog.OptionsBehavior.Editable = False
        Me.gvChecklistLog.OptionsBehavior.ReadOnly = True
        '
        'colAgentID
        '
        Me.colAgentID.FieldName = "AgentID"
        Me.colAgentID.Name = "colAgentID"
        '
        'colAgentName
        '
        Me.colAgentName.FieldName = "AgentName"
        Me.colAgentName.Name = "colAgentName"
        Me.colAgentName.Visible = True
        Me.colAgentName.VisibleIndex = 0
        '
        'colStartDateTime
        '
        Me.colStartDateTime.FieldName = "StartDateTime"
        Me.colStartDateTime.Name = "colStartDateTime"
        Me.colStartDateTime.Visible = True
        Me.colStartDateTime.VisibleIndex = 1
        '
        'colEndDateTime
        '
        Me.colEndDateTime.FieldName = "EndDateTime"
        Me.colEndDateTime.Name = "colEndDateTime"
        Me.colEndDateTime.Visible = True
        Me.colEndDateTime.VisibleIndex = 2
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.Name = "colRecordID"
        '
        'colChecklist
        '
        Me.colChecklist.FieldName = "Checklist"
        Me.colChecklist.Name = "colChecklist"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlChecklistLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlChecklistLog"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChecklistOptionLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcChecklistLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChecklistLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcChecklistLog As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvChecklistLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAgentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChecklist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvChecklistOptionLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChecklistOption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChecklist1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChecklistLog As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn

End Class
