<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobFunctionControl
    Inherits UniSource.ShopFloor.GUI.xaegJobFunctionControl

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
        Me.DataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.PasswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPassword = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl.SuspendLayout()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl)
        Me.grpGroup.Size = New System.Drawing.Size(283, 86)
        Me.grpGroup.Text = "Job Function Password"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(140, 105)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(221, 105)
        '
        'DataLayoutControl
        '
        Me.DataLayoutControl.Controls.Add(Me.PasswordTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.IDTextEdit)
        Me.DataLayoutControl.DataSource = Me.BindingSource
        Me.DataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl.Location = New System.Drawing.Point(2, 21)
        Me.DataLayoutControl.Name = "DataLayoutControl"
        Me.DataLayoutControl.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl.Root = Me.LayoutControlGroup
        Me.DataLayoutControl.Size = New System.Drawing.Size(279, 63)
        Me.DataLayoutControl.TabIndex = 0
        Me.DataLayoutControl.Text = "Job Function Control"
        '
        'PasswordTextEdit
        '
        Me.PasswordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Password", True))
        Me.PasswordTextEdit.Location = New System.Drawing.Point(56, 35)
        Me.PasswordTextEdit.Name = "PasswordTextEdit"
        Me.PasswordTextEdit.Size = New System.Drawing.Size(218, 20)
        Me.PasswordTextEdit.StyleController = Me.DataLayoutControl
        Me.PasswordTextEdit.TabIndex = 5
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobFunction", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(56, 5)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDTextEdit.Properties.NullText = ""
        Me.IDTextEdit.Size = New System.Drawing.Size(218, 20)
        Me.IDTextEdit.StyleController = Me.DataLayoutControl
        Me.IDTextEdit.TabIndex = 4
        '
        'LayoutControlGroup
        '
        Me.LayoutControlGroup.CustomizationFormText = "LayoutControlGroup"
        Me.LayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup.GroupBordersVisible = False
        Me.LayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup.Name = "LayoutControlGroup"
        Me.LayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup.Size = New System.Drawing.Size(279, 63)
        Me.LayoutControlGroup.Text = "LayoutControlGroup"
        Me.LayoutControlGroup.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForID, Me.ItemForPassword})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(279, 63)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForID
        '
        Me.ItemForID.Control = Me.IDTextEdit
        Me.ItemForID.CustomizationFormText = "Function"
        Me.ItemForID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForID.Name = "ItemForID"
        Me.ItemForID.Size = New System.Drawing.Size(279, 30)
        Me.ItemForID.Text = "Function"
        Me.ItemForID.TextSize = New System.Drawing.Size(46, 13)
        Me.ItemForID.TextToControlDistance = 5
        '
        'ItemForPassword
        '
        Me.ItemForPassword.Control = Me.PasswordTextEdit
        Me.ItemForPassword.CustomizationFormText = "Password"
        Me.ItemForPassword.Location = New System.Drawing.Point(0, 30)
        Me.ItemForPassword.Name = "ItemForPassword"
        Me.ItemForPassword.Size = New System.Drawing.Size(279, 33)
        Me.ItemForPassword.Text = "Password"
        Me.ItemForPassword.TextSize = New System.Drawing.Size(46, 13)
        Me.ItemForPassword.TextToControlDistance = 5
        '
        'xaeJobFunctionControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 140)
        Me.Name = "xaeJobFunctionControl"
        Me.Text = "Job Function Control"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl.ResumeLayout(False)
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents PasswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPassword As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.LookUpEdit
End Class
