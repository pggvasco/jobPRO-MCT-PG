<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfShopFloorTriggerRunner(Of T)
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
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.btOK = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ProgressPanel1.AppearanceCaption.Options.UseFont = True
        Me.ProgressPanel1.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ProgressPanel1.AppearanceDescription.Options.UseFont = True
        Me.ProgressPanel1.Location = New System.Drawing.Point(12, 12)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(449, 67)
        Me.ProgressPanel1.TabIndex = 0
        Me.ProgressPanel1.Text = "ProgressPanel1"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit1.Location = New System.Drawing.Point(13, 85)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(448, 376)
        Me.MemoEdit1.TabIndex = 1
        '
        'btOK
        '
        Me.btOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btOK.Enabled = False
        Me.btOK.Location = New System.Drawing.Point(387, 467)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(75, 23)
        Me.btOK.TabIndex = 2
        Me.btOK.Text = "OK"
        '
        'xfShopFloorTriggerRunner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 502)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.MemoEdit1)
        Me.Controls.Add(Me.ProgressPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "xfShopFloorTriggerRunner"
        Me.ShowIcon = False
        Me.Text = "xfTriggerRunner"
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btOK As DevExpress.XtraEditors.SimpleButton
End Class
