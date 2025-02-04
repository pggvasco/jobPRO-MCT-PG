<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xucChecklist
    Inherits UniSource.ShopFloor.Scheduler.Checklist.GUI.xucgChecklist

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
        Me.gcChecklist = New DevExpress.XtraGrid.GridControl()
        Me.gvChecklist = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcChecklist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChecklist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcChecklist)
        '
        'gcChecklist
        '
        Me.gcChecklist.DataSource = Me.BindingSource
        Me.gcChecklist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcChecklist.Location = New System.Drawing.Point(0, 0)
        Me.gcChecklist.MainView = Me.gvChecklist
        Me.gcChecklist.MenuManager = Me.barManager
        Me.gcChecklist.Name = "gcChecklist"
        Me.gcChecklist.Size = New System.Drawing.Size(925, 535)
        Me.gcChecklist.TabIndex = 0
        Me.gcChecklist.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChecklist})
        '
        'gvChecklist
        '
        Me.gvChecklist.GridControl = Me.gcChecklist
        Me.gvChecklist.Name = "gvChecklist"
        '
        'xucChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xucChecklist"
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

End Class
