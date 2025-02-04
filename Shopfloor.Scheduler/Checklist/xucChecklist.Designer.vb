<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xucChecklist
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
        Me.lcChecklist = New DevExpress.XtraLayout.LayoutControl()
        Me.btOK = New DevExpress.XtraEditors.SimpleButton()
        Me.lcChecklistOptions = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lblChecklistDescription = New DevExpress.XtraEditors.LabelControl()
        Me.ChecklistBindingSource = New System.Windows.Forms.BindingSource()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CheckListTimer = New System.Windows.Forms.Timer()
        Me.ChecklistLogBindingSource = New System.Windows.Forms.BindingSource()
        CType(Me.lcChecklist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lcChecklist.SuspendLayout()
        CType(Me.lcChecklistOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecklistLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lcChecklist
        '
        Me.lcChecklist.Controls.Add(Me.btOK)
        Me.lcChecklist.Controls.Add(Me.lcChecklistOptions)
        Me.lcChecklist.Controls.Add(Me.lblChecklistDescription)
        Me.lcChecklist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lcChecklist.Location = New System.Drawing.Point(0, 0)
        Me.lcChecklist.Name = "lcChecklist"
        Me.lcChecklist.Root = Me.LayoutControlGroup1
        Me.lcChecklist.Size = New System.Drawing.Size(811, 605)
        Me.lcChecklist.TabIndex = 0
        Me.lcChecklist.Text = "Checklist"
        '
        'btOK
        '
        Me.btOK.Appearance.Font = New System.Drawing.Font("Tahoma", 12.375!)
        Me.btOK.Appearance.Options.UseFont = True
        Me.btOK.Location = New System.Drawing.Point(12, 567)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(787, 26)
        Me.btOK.StyleController = Me.lcChecklist
        Me.btOK.TabIndex = 6
        Me.btOK.Text = "Done!"
        '
        'lcChecklistOptions
        '
        Me.lcChecklistOptions.Location = New System.Drawing.Point(12, 43)
        Me.lcChecklistOptions.Name = "lcChecklistOptions"
        Me.lcChecklistOptions.Root = Me.Root
        Me.lcChecklistOptions.Size = New System.Drawing.Size(787, 520)
        Me.lcChecklistOptions.TabIndex = 4
        Me.lcChecklistOptions.Text = "Checklist Options"
        '
        'Root
        '
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(787, 520)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'lblChecklistDescription
        '
        Me.lblChecklistDescription.Appearance.Font = New System.Drawing.Font("Tahoma", 16.5!)
        Me.lblChecklistDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChecklistBindingSource, "Description", True))
        Me.lblChecklistDescription.Location = New System.Drawing.Point(12, 12)
        Me.lblChecklistDescription.Name = "lblChecklistDescription"
        Me.lblChecklistDescription.Size = New System.Drawing.Size(200, 27)
        Me.lblChecklistDescription.StyleController = Me.lcChecklist
        Me.lblChecklistDescription.TabIndex = 5
        Me.lblChecklistDescription.Text = "Checklist Description"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(811, 605)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.lblChecklistDescription
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(791, 31)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btOK
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 555)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(791, 30)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.lcChecklistOptions
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(791, 524)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'CheckListTimer
        '
        '
        'xucChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lcChecklist)
        Me.Name = "xucChecklist"
        Me.Size = New System.Drawing.Size(811, 605)
        CType(Me.lcChecklist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lcChecklist.ResumeLayout(False)
        CType(Me.lcChecklistOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecklistLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lcChecklist As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lcChecklistOptions As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lblChecklistDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ChecklistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChecklistLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckListTimer As System.Windows.Forms.Timer

End Class
