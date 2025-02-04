<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlLookup
    Inherits UniSource.ShopFloor.Scheduler.Checklist.GUI.xlgLookup

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
        Me.gcLookup = New DevExpress.XtraGrid.GridControl()
        Me.gvLookup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.Checklist.API.ChecklistType)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcLookup)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcLookup
        '
        Me.gcLookup.DataSource = Me.BindingSource
        Me.gcLookup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLookup.Location = New System.Drawing.Point(0, 0)
        Me.gcLookup.MainView = Me.gvLookup
        Me.gcLookup.MenuManager = Me.barManager
        Me.gcLookup.Name = "gcLookup"
        Me.gcLookup.Size = New System.Drawing.Size(925, 506)
        Me.gcLookup.TabIndex = 0
        Me.gcLookup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLookup})
        '
        'gvLookup
        '
        Me.gvLookup.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colID})
        Me.gvLookup.GridControl = Me.gcLookup
        Me.gvLookup.Name = "gvLookup"
        Me.gvLookup.OptionsBehavior.ReadOnly = True
        Me.gvLookup.OptionsView.ShowGroupPanel = False
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 168
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 739
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlLookup"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcLookup As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLookup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
