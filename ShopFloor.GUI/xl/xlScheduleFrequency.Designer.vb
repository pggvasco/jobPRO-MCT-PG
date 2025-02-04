<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlScheduleFrequency
    Inherits UniSource.ShopFloor.GUI.xlgScheduleFrequency

    'Form overrides dispose to clean up the component list.
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTemplateID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colScheduleID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRepeatAfter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridPanel.Location = New System.Drawing.Point(0, 57)
        Me.GridPanel.Size = New System.Drawing.Size(1160, 661)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.barManager
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1160, 661)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colTemplateID, Me.colRequestTypeID, Me.colScheduleID, Me.colRepeatAfter, Me.colTypeID, Me.colID, Me.colError})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
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
        'colTemplateID
        '
        Me.colTemplateID.Caption = "Template"
        Me.colTemplateID.FieldName = "JobTemplate.TemplateNumber"
        Me.colTemplateID.Name = "colTemplateID"
        Me.colTemplateID.Visible = True
        Me.colTemplateID.VisibleIndex = 2
        '
        'colRequestTypeID
        '
        Me.colRequestTypeID.Caption = "Request Type"
        Me.colRequestTypeID.FieldName = "RequestType.Code"
        Me.colRequestTypeID.Name = "colRequestTypeID"
        Me.colRequestTypeID.Visible = True
        Me.colRequestTypeID.VisibleIndex = 3
        '
        'colScheduleID
        '
        Me.colScheduleID.Caption = "Schedule"
        Me.colScheduleID.FieldName = "ScheduleTypes"
        Me.colScheduleID.Name = "colScheduleID"
        Me.colScheduleID.Visible = True
        Me.colScheduleID.VisibleIndex = 4
        '
        'colRepeatAfter
        '
        Me.colRepeatAfter.FieldName = "RepeatAfter"
        Me.colRepeatAfter.Name = "colRepeatAfter"
        Me.colRepeatAfter.Visible = True
        Me.colRepeatAfter.VisibleIndex = 5
        '
        'colTypeID
        '
        Me.colTypeID.Caption = "Type"
        Me.colTypeID.FieldName = "ScheduleFrequencyType"
        Me.colTypeID.Name = "colTypeID"
        Me.colTypeID.Visible = True
        Me.colTypeID.VisibleIndex = 6
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
        'xlScheduleFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlScheduleFrequency"
        Me.Size = New System.Drawing.Size(1160, 718)
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
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTemplateID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colScheduleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRepeatAfter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
End Class
