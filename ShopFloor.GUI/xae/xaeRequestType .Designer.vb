<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeRequestType
    Inherits UniSource.ShopFloor.GUI.xaegRequestType

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
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ActiveTextEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActive = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(571, 119)
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(405, 143)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(498, 143)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ActiveTextEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 24)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(567, 93)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(78, 12)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(203, 22)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.CodeTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(351, 12)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(204, 22)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl1
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'ActiveTextEdit
        '
        Me.ActiveTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Active", True))
        Me.ActiveTextEdit.EditValue = Nothing
        Me.ActiveTextEdit.Location = New System.Drawing.Point(12, 38)
        Me.ActiveTextEdit.Name = "ActiveTextEdit"
        Me.ActiveTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ActiveTextEdit.Properties.Caption = "Active"
        Me.ActiveTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ActiveTextEdit.Size = New System.Drawing.Size(543, 20)
        Me.ActiveTextEdit.StyleController = Me.DataLayoutControl1
        Me.ActiveTextEdit.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(567, 93)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForActive, Me.ItemForDescription})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(547, 73)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(273, 26)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(63, 16)
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(273, 0)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(274, 26)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(63, 16)
        '
        'ItemForActive
        '
        Me.ItemForActive.Control = Me.ActiveTextEdit
        Me.ItemForActive.CustomizationFormText = "Active"
        Me.ItemForActive.Location = New System.Drawing.Point(0, 26)
        Me.ItemForActive.Name = "ItemForActive"
        Me.ItemForActive.Size = New System.Drawing.Size(547, 47)
        Me.ItemForActive.Text = "Active"
        Me.ItemForActive.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForActive.TextToControlDistance = 0
        Me.ItemForActive.TextVisible = False
        '
        'xaeRequestType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 202)
        Me.Name = "xaeRequestType"
        Me.Text = "Request Type"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActive As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ActiveTextEdit As DevExpress.XtraEditors.CheckEdit
End Class
