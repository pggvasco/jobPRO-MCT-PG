<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xucChecklistOption
    Inherits DevExpress.XtraEditors.XtraUserControl

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
        Me.ChecklistOptionBindingSource = New System.Windows.Forms.BindingSource()
        Me.ChecklistOptionLogBindingSource = New System.Windows.Forms.BindingSource()
        CType(Me.ChecklistOptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistOptionLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChecklistOptionBindingSource
        '
        Me.ChecklistOptionBindingSource.DataSource = GetType(UniSource.Checklist.API.ChecklistOption)
        '
        'ChecklistOptionLogBindingSource
        '
        Me.ChecklistOptionLogBindingSource.DataSource = GetType(UniSource.Checklist.API.ChecklistOptionLog)
        '
        'xucChecklistOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.MaximumSize = New System.Drawing.Size(0, 20)
        Me.MinimumSize = New System.Drawing.Size(370, 40)
        Me.Name = "xucChecklistOption"
        Me.Size = New System.Drawing.Size(370, 40)
        CType(Me.ChecklistOptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistOptionLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChecklistOptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChecklistOptionLogBindingSource As System.Windows.Forms.BindingSource

End Class
