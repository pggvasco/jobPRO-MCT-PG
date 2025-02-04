<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xucChecklistOption
    Inherits UniSource.ShopFloor.Scheduler.Checklist.GUI.xucgChecklistOption

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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcChecklistOption = New DevExpress.XtraGrid.GridControl()
        Me.gvChecklistOption = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcChecklistOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChecklistOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcChecklistOption)
        Me.GridPanel.Size = New System.Drawing.Size(771, 364)
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(771, 364)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'gcChecklistOption
        '
        Me.gcChecklistOption.DataSource = Me.BindingSource
        Me.gcChecklistOption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcChecklistOption.Location = New System.Drawing.Point(0, 0)
        Me.gcChecklistOption.MainView = Me.gvChecklistOption
        Me.gcChecklistOption.MenuManager = Me.barManager
        Me.gcChecklistOption.Name = "gcChecklistOption"
        Me.gcChecklistOption.Size = New System.Drawing.Size(771, 364)
        Me.gcChecklistOption.TabIndex = 0
        Me.gcChecklistOption.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChecklistOption})
        '
        'gvChecklistOption
        '
        Me.gvChecklistOption.GridControl = Me.gcChecklistOption
        Me.gvChecklistOption.Name = "gvChecklistOption"
        '
        'xucChecklistOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "xucChecklistOption"
        Me.Size = New System.Drawing.Size(771, 388)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.GridPanel, 0)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcChecklistOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChecklistOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcChecklistOption As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvChecklistOption As DevExpress.XtraGrid.Views.Grid.GridView

End Class
