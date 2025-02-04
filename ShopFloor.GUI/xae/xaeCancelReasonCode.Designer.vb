<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeCancelReasonCode
    Inherits UniSource.ShopFloor.GUI.xaegCancelReasonCode

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
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsCommentAllowed = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsForceCommentValue = New DevExpress.XtraLayout.LayoutControlItem()
        Me.IsCommentAllowedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsForceCommentValueCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsCommentAllowed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsForceCommentValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsCommentAllowedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsForceCommentValueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(298, 147)
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(155, 166)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(236, 166)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsCommentAllowedCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsForceCommentValueCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 21)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(294, 124)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(294, 124)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(68, 12)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(214, 20)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.CodeTextEdit.TabIndex = 4
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(274, 24)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription, Me.ItemForIsCommentAllowed, Me.ItemForIsForceCommentValue})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(274, 104)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(68, 36)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(214, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl1
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 24)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(274, 24)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(53, 13)
        '
        'ItemForIsCommentAllowed
        '
        Me.ItemForIsCommentAllowed.Control = Me.IsCommentAllowedCheckEdit
        Me.ItemForIsCommentAllowed.CustomizationFormText = "Is Comment Allowed"
        Me.ItemForIsCommentAllowed.Location = New System.Drawing.Point(0, 48)
        Me.ItemForIsCommentAllowed.Name = "ItemForIsCommentAllowed"
        Me.ItemForIsCommentAllowed.Size = New System.Drawing.Size(274, 23)
        Me.ItemForIsCommentAllowed.Text = "Is Comment Allowed"
        Me.ItemForIsCommentAllowed.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsCommentAllowed.TextToControlDistance = 0
        Me.ItemForIsCommentAllowed.TextVisible = False
        '
        'ItemForIsForceCommentValue
        '
        Me.ItemForIsForceCommentValue.Control = Me.IsForceCommentValueCheckEdit
        Me.ItemForIsForceCommentValue.CustomizationFormText = "Is Force Comment Value"
        Me.ItemForIsForceCommentValue.Location = New System.Drawing.Point(0, 71)
        Me.ItemForIsForceCommentValue.Name = "ItemForIsForceCommentValue"
        Me.ItemForIsForceCommentValue.Size = New System.Drawing.Size(274, 33)
        Me.ItemForIsForceCommentValue.Text = "Is Force Comment Value"
        Me.ItemForIsForceCommentValue.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsForceCommentValue.TextToControlDistance = 0
        Me.ItemForIsForceCommentValue.TextVisible = False
        '
        'IsCommentAllowedCheckEdit
        '
        Me.IsCommentAllowedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsCommentAllowed", True))
        Me.IsCommentAllowedCheckEdit.EditValue = Nothing
        Me.IsCommentAllowedCheckEdit.Location = New System.Drawing.Point(12, 60)
        Me.IsCommentAllowedCheckEdit.Name = "IsCommentAllowedCheckEdit"
        Me.IsCommentAllowedCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsCommentAllowedCheckEdit.Properties.Caption = "Is Comment Allowed"
        Me.IsCommentAllowedCheckEdit.Size = New System.Drawing.Size(270, 19)
        Me.IsCommentAllowedCheckEdit.StyleController = Me.DataLayoutControl1
        Me.IsCommentAllowedCheckEdit.TabIndex = 6
        '
        'IsForceCommentValueCheckEdit
        '
        Me.IsForceCommentValueCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsForceCommentValue", True))
        Me.IsForceCommentValueCheckEdit.EditValue = Nothing
        Me.IsForceCommentValueCheckEdit.Location = New System.Drawing.Point(12, 83)
        Me.IsForceCommentValueCheckEdit.Name = "IsForceCommentValueCheckEdit"
        Me.IsForceCommentValueCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IsForceCommentValueCheckEdit.Properties.Caption = "Is Force Comment Value"
        Me.IsForceCommentValueCheckEdit.Size = New System.Drawing.Size(270, 19)
        Me.IsForceCommentValueCheckEdit.StyleController = Me.DataLayoutControl1
        Me.IsForceCommentValueCheckEdit.TabIndex = 7
        '
        'xaeCancelReasonCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 201)
        Me.Name = "xaeCancelReasonCode"
        Me.Text = "Cancel Reason Code"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsCommentAllowed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsForceCommentValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsCommentAllowedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsForceCommentValueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsCommentAllowedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsForceCommentValueCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsCommentAllowed As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsForceCommentValue As DevExpress.XtraLayout.LayoutControlItem
End Class
