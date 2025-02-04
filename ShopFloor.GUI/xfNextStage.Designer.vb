<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfNextStage
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
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.NextStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrentStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobCustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CancelButton = New DevExpress.XtraEditors.SimpleButton()
        Me.UserPasswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UserNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.TraceJobCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCancelButton = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSaveButton = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobCustomer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCurrentStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNextStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.FieldPromptsLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraceJobCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSaveButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCurrentStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldPromptsLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl
        '
        Me.LayoutControl.Controls.Add(Me.NextStageTextEdit)
        Me.LayoutControl.Controls.Add(Me.CurrentStageTextEdit)
        Me.LayoutControl.Controls.Add(Me.JobCustomerTextEdit)
        Me.LayoutControl.Controls.Add(Me.JobNumberTextEdit)
        Me.LayoutControl.Controls.Add(Me.CancelButton)
        Me.LayoutControl.Controls.Add(Me.UserPasswordTextEdit)
        Me.LayoutControl.Controls.Add(Me.UserNameTextEdit)
        Me.LayoutControl.Controls.Add(Me.SaveButton)
        Me.LayoutControl.Controls.Add(Me.TraceJobCheckEdit)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl"
        Me.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-1321, 191, 250, 350)
        Me.LayoutControl.OptionsView.UseSkinIndents = False
        Me.LayoutControl.Root = Me.LayoutControlGroup1
        Me.LayoutControl.Size = New System.Drawing.Size(367, 326)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "Proceed Job"
        '
        'NextStageTextEdit
        '
        Me.NextStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "NextStage", True))
        Me.NextStageTextEdit.Location = New System.Drawing.Point(81, 95)
        Me.NextStageTextEdit.Name = "NextStageTextEdit"
        Me.NextStageTextEdit.Properties.ReadOnly = True
        Me.NextStageTextEdit.Size = New System.Drawing.Size(281, 20)
        Me.NextStageTextEdit.StyleController = Me.LayoutControl
        Me.NextStageTextEdit.TabIndex = 12
        Me.NextStageTextEdit.TabStop = False
        '
        'CurrentStageTextEdit
        '
        Me.CurrentStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobStage", True))
        Me.CurrentStageTextEdit.Location = New System.Drawing.Point(81, 65)
        Me.CurrentStageTextEdit.Name = "CurrentStageTextEdit"
        Me.CurrentStageTextEdit.Properties.ReadOnly = True
        Me.CurrentStageTextEdit.Size = New System.Drawing.Size(281, 20)
        Me.CurrentStageTextEdit.StyleController = Me.LayoutControl
        Me.CurrentStageTextEdit.TabIndex = 11
        Me.CurrentStageTextEdit.TabStop = False
        '
        'JobCustomerTextEdit
        '
        Me.JobCustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "Customer", True))
        Me.JobCustomerTextEdit.Location = New System.Drawing.Point(81, 35)
        Me.JobCustomerTextEdit.Name = "JobCustomerTextEdit"
        Me.JobCustomerTextEdit.Properties.ReadOnly = True
        Me.JobCustomerTextEdit.Size = New System.Drawing.Size(281, 20)
        Me.JobCustomerTextEdit.StyleController = Me.LayoutControl
        Me.JobCustomerTextEdit.TabIndex = 10
        Me.JobCustomerTextEdit.TabStop = False
        '
        'JobNumberTextEdit
        '
        Me.JobNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobNumber", True))
        Me.JobNumberTextEdit.Location = New System.Drawing.Point(81, 5)
        Me.JobNumberTextEdit.Name = "JobNumberTextEdit"
        Me.JobNumberTextEdit.Properties.ReadOnly = True
        Me.JobNumberTextEdit.Size = New System.Drawing.Size(281, 20)
        Me.JobNumberTextEdit.StyleController = Me.LayoutControl
        Me.JobNumberTextEdit.TabIndex = 9
        Me.JobNumberTextEdit.TabStop = False
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(185, 270)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(177, 22)
        Me.CancelButton.StyleController = Me.LayoutControl
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Cancel"
        '
        'UserPasswordTextEdit
        '
        Me.UserPasswordTextEdit.Location = New System.Drawing.Point(81, 240)
        Me.UserPasswordTextEdit.Name = "UserPasswordTextEdit"
        Me.UserPasswordTextEdit.Properties.UseSystemPasswordChar = True
        Me.UserPasswordTextEdit.Size = New System.Drawing.Size(281, 20)
        Me.UserPasswordTextEdit.StyleController = Me.LayoutControl
        Me.UserPasswordTextEdit.TabIndex = 1
        '
        'UserNameTextEdit
        '
        Me.UserNameTextEdit.Location = New System.Drawing.Point(81, 210)
        Me.UserNameTextEdit.Name = "UserNameTextEdit"
        Me.UserNameTextEdit.Size = New System.Drawing.Size(281, 20)
        Me.UserNameTextEdit.StyleController = Me.LayoutControl
        Me.UserNameTextEdit.TabIndex = 0
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(5, 270)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(170, 22)
        Me.SaveButton.StyleController = Me.LayoutControl
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Proceed"
        '
        'TraceJobCheckEdit
        '
        Me.TraceJobCheckEdit.EditValue = True
        Me.TraceJobCheckEdit.Location = New System.Drawing.Point(5, 302)
        Me.TraceJobCheckEdit.Name = "TraceJobCheckEdit"
        Me.TraceJobCheckEdit.Properties.Caption = "Trace Job"
        Me.TraceJobCheckEdit.Size = New System.Drawing.Size(357, 19)
        Me.TraceJobCheckEdit.StyleController = Me.LayoutControl
        Me.TraceJobCheckEdit.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.ItemForCancelButton, Me.ItemForSaveButton, Me.ItemForJobNumber, Me.ItemForJobCustomer, Me.LayoutControlItem2, Me.ItemForCurrentStage, Me.ItemForNextStage, Me.LayoutControlItem3, Me.FieldPromptsLayoutControlGroup})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(367, 326)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.UserNameTextEdit
        Me.LayoutControlItem1.CustomizationFormText = "User Name"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 205)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(367, 30)
        Me.LayoutControlItem1.Text = "User Name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(71, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'ItemForCancelButton
        '
        Me.ItemForCancelButton.Control = Me.CancelButton
        Me.ItemForCancelButton.CustomizationFormText = "Cancel"
        Me.ItemForCancelButton.Location = New System.Drawing.Point(180, 265)
        Me.ItemForCancelButton.Name = "ItemForCancelButton"
        Me.ItemForCancelButton.Size = New System.Drawing.Size(187, 32)
        Me.ItemForCancelButton.Text = "Cancel"
        Me.ItemForCancelButton.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForCancelButton.TextToControlDistance = 0
        Me.ItemForCancelButton.TextVisible = False
        '
        'ItemForSaveButton
        '
        Me.ItemForSaveButton.Control = Me.SaveButton
        Me.ItemForSaveButton.CustomizationFormText = "Save"
        Me.ItemForSaveButton.Location = New System.Drawing.Point(0, 265)
        Me.ItemForSaveButton.Name = "ItemForSaveButton"
        Me.ItemForSaveButton.Size = New System.Drawing.Size(180, 32)
        Me.ItemForSaveButton.Text = "Save"
        Me.ItemForSaveButton.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForSaveButton.TextToControlDistance = 0
        Me.ItemForSaveButton.TextVisible = False
        '
        'ItemForJobNumber
        '
        Me.ItemForJobNumber.Control = Me.JobNumberTextEdit
        Me.ItemForJobNumber.CustomizationFormText = "Job Number"
        Me.ItemForJobNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobNumber.Name = "ItemForJobNumber"
        Me.ItemForJobNumber.Size = New System.Drawing.Size(367, 30)
        Me.ItemForJobNumber.Text = "Job Number"
        Me.ItemForJobNumber.TextSize = New System.Drawing.Size(71, 13)
        Me.ItemForJobNumber.TextToControlDistance = 5
        '
        'ItemForJobCustomer
        '
        Me.ItemForJobCustomer.Control = Me.JobCustomerTextEdit
        Me.ItemForJobCustomer.CustomizationFormText = "Customer"
        Me.ItemForJobCustomer.Location = New System.Drawing.Point(0, 30)
        Me.ItemForJobCustomer.Name = "ItemForJobCustomer"
        Me.ItemForJobCustomer.Size = New System.Drawing.Size(367, 30)
        Me.ItemForJobCustomer.Text = "Customer"
        Me.ItemForJobCustomer.TextSize = New System.Drawing.Size(71, 13)
        Me.ItemForJobCustomer.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.UserPasswordTextEdit
        Me.LayoutControlItem2.CustomizationFormText = "User Password"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 235)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(367, 30)
        Me.LayoutControlItem2.Text = "User Password"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(71, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'ItemForCurrentStage
        '
        Me.ItemForCurrentStage.Control = Me.CurrentStageTextEdit
        Me.ItemForCurrentStage.CustomizationFormText = "Current"
        Me.ItemForCurrentStage.Location = New System.Drawing.Point(0, 60)
        Me.ItemForCurrentStage.Name = "ItemForCurrentStage"
        Me.ItemForCurrentStage.Size = New System.Drawing.Size(367, 30)
        Me.ItemForCurrentStage.Text = "Current"
        Me.ItemForCurrentStage.TextSize = New System.Drawing.Size(71, 13)
        Me.ItemForCurrentStage.TextToControlDistance = 5
        '
        'ItemForNextStage
        '
        Me.ItemForNextStage.Control = Me.NextStageTextEdit
        Me.ItemForNextStage.CustomizationFormText = "Next"
        Me.ItemForNextStage.Location = New System.Drawing.Point(0, 90)
        Me.ItemForNextStage.Name = "ItemForNextStage"
        Me.ItemForNextStage.Size = New System.Drawing.Size(367, 30)
        Me.ItemForNextStage.Text = "Next"
        Me.ItemForNextStage.TextSize = New System.Drawing.Size(71, 13)
        Me.ItemForNextStage.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TraceJobCheckEdit
        Me.LayoutControlItem3.CustomizationFormText = "Trace Job"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 297)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(367, 29)
        Me.LayoutControlItem3.Text = "Trace Job"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'FieldPromptsLayoutControlGroup
        '
        Me.FieldPromptsLayoutControlGroup.CustomizationFormText = "Field Prompts"
        Me.FieldPromptsLayoutControlGroup.Location = New System.Drawing.Point(0, 120)
        Me.FieldPromptsLayoutControlGroup.Name = "FieldPromptsLayoutControlGroup"
        Me.FieldPromptsLayoutControlGroup.OptionsItemText.TextToControlDistance = 5
        Me.FieldPromptsLayoutControlGroup.Size = New System.Drawing.Size(367, 85)
        Me.FieldPromptsLayoutControlGroup.Text = "Field Prompts"
        '
        'xfNextStage
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 326)
        Me.Controls.Add(Me.LayoutControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "xfNextStage"
        Me.Text = "Proceed Job"
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraceJobCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCancelButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSaveButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCurrentStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldPromptsLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CancelButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UserPasswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UserNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TraceJobCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCancelButton As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForSaveButton As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents NextStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CurrentStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobCustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForJobNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobCustomer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCurrentStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNextStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FieldPromptsLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
End Class
