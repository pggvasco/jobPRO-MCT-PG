<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfCancelJobStage
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.ItemForJobNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.JobNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.CancelComentTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CancelReasonCodeLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CancelReasonCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NextStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CurrentStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobCustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CancelButton = New DevExpress.XtraEditors.SimpleButton()
        Me.UserPasswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UserNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.TraceJobCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCancelButton = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSaveButton = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobCustomer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCurrentStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNextStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.ItemForJobNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.CancelComentTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelReasonCodeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelReasonCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraceJobCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSaveButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCurrentStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemForJobNumber
        '
        Me.ItemForJobNumber.Control = Me.JobNumberTextEdit
        Me.ItemForJobNumber.CustomizationFormText = "Job Number"
        Me.ItemForJobNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobNumber.Name = "ItemForJobNumber"
        Me.ItemForJobNumber.Size = New System.Drawing.Size(356, 30)
        Me.ItemForJobNumber.Text = "Job Number"
        Me.ItemForJobNumber.TextSize = New System.Drawing.Size(71, 13)
        Me.ItemForJobNumber.TextToControlDistance = 5
        '
        'JobNumberTextEdit
        '
        Me.JobNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "JobNumber", True))
        Me.JobNumberTextEdit.Location = New System.Drawing.Point(81, 5)
        Me.JobNumberTextEdit.Name = "JobNumberTextEdit"
        Me.JobNumberTextEdit.Properties.ReadOnly = True
        Me.JobNumberTextEdit.Size = New System.Drawing.Size(270, 20)
        Me.JobNumberTextEdit.StyleController = Me.LayoutControl
        Me.JobNumberTextEdit.TabIndex = 9
        Me.JobNumberTextEdit.TabStop = False
        '
        'LayoutControl
        '
        Me.LayoutControl.Controls.Add(Me.CancelComentTextEdit)
        Me.LayoutControl.Controls.Add(Me.CancelReasonCodeLookUpEdit)
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
        Me.LayoutControl.Size = New System.Drawing.Size(356, 328)
        Me.LayoutControl.TabIndex = 1
        Me.LayoutControl.Text = "Proceed Job"
        '
        'CancelComentTextEdit
        '
        Me.CancelComentTextEdit.Location = New System.Drawing.Point(81, 215)
        Me.CancelComentTextEdit.Name = "CancelComentTextEdit"
        Me.CancelComentTextEdit.Properties.ReadOnly = True
        Me.CancelComentTextEdit.Size = New System.Drawing.Size(270, 20)
        Me.CancelComentTextEdit.StyleController = Me.LayoutControl
        Me.CancelComentTextEdit.TabIndex = 14
        '
        'CancelReasonCodeLookUpEdit
        '
        Me.CancelReasonCodeLookUpEdit.Location = New System.Drawing.Point(81, 185)
        Me.CancelReasonCodeLookUpEdit.Name = "CancelReasonCodeLookUpEdit"
        Me.CancelReasonCodeLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CancelReasonCodeLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CancelReasonCodeLookUpEdit.Properties.DataSource = Me.CancelReasonCodeBindingSource
        Me.CancelReasonCodeLookUpEdit.Properties.DisplayMember = "Description"
        Me.CancelReasonCodeLookUpEdit.Size = New System.Drawing.Size(270, 20)
        Me.CancelReasonCodeLookUpEdit.StyleController = Me.LayoutControl
        Me.CancelReasonCodeLookUpEdit.TabIndex = 13
        '
        'CancelReasonCodeBindingSource
        '
        Me.CancelReasonCodeBindingSource.DataSource = GetType(UniSource.ShopFloor.API.CancelReasonCode)
        '
        'NextStageTextEdit
        '
        Me.NextStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobBindingSource, "CancelJobStage", True))
        Me.NextStageTextEdit.Location = New System.Drawing.Point(81, 95)
        Me.NextStageTextEdit.Name = "NextStageTextEdit"
        Me.NextStageTextEdit.Properties.ReadOnly = True
        Me.NextStageTextEdit.Size = New System.Drawing.Size(270, 20)
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
        Me.CurrentStageTextEdit.Size = New System.Drawing.Size(270, 20)
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
        Me.JobCustomerTextEdit.Size = New System.Drawing.Size(270, 20)
        Me.JobCustomerTextEdit.StyleController = Me.LayoutControl
        Me.JobCustomerTextEdit.TabIndex = 10
        Me.JobCustomerTextEdit.TabStop = False
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(180, 245)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(171, 22)
        Me.CancelButton.StyleController = Me.LayoutControl
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Cancel"
        '
        'UserPasswordTextEdit
        '
        Me.UserPasswordTextEdit.Location = New System.Drawing.Point(81, 155)
        Me.UserPasswordTextEdit.Name = "UserPasswordTextEdit"
        Me.UserPasswordTextEdit.Properties.UseSystemPasswordChar = True
        Me.UserPasswordTextEdit.Size = New System.Drawing.Size(270, 20)
        Me.UserPasswordTextEdit.StyleController = Me.LayoutControl
        Me.UserPasswordTextEdit.TabIndex = 1
        '
        'UserNameTextEdit
        '
        Me.UserNameTextEdit.Location = New System.Drawing.Point(81, 125)
        Me.UserNameTextEdit.Name = "UserNameTextEdit"
        Me.UserNameTextEdit.Size = New System.Drawing.Size(270, 20)
        Me.UserNameTextEdit.StyleController = Me.LayoutControl
        Me.UserNameTextEdit.TabIndex = 0
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(5, 245)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(165, 22)
        Me.SaveButton.StyleController = Me.LayoutControl
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Proceed"
        '
        'TraceJobCheckEdit
        '
        Me.TraceJobCheckEdit.EditValue = True
        Me.TraceJobCheckEdit.Location = New System.Drawing.Point(5, 277)
        Me.TraceJobCheckEdit.Name = "TraceJobCheckEdit"
        Me.TraceJobCheckEdit.Properties.Caption = "Trace Job"
        Me.TraceJobCheckEdit.Size = New System.Drawing.Size(346, 19)
        Me.TraceJobCheckEdit.StyleController = Me.LayoutControl
        Me.TraceJobCheckEdit.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.ItemForCancelButton, Me.ItemForSaveButton, Me.ItemForJobNumber, Me.ItemForJobCustomer, Me.LayoutControlItem2, Me.ItemForCurrentStage, Me.ItemForNextStage, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(356, 328)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.UserNameTextEdit
        Me.LayoutControlItem1.CustomizationFormText = "User Name"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(356, 30)
        Me.LayoutControlItem1.Text = "User Name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(71, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'ItemForCancelButton
        '
        Me.ItemForCancelButton.Control = Me.CancelButton
        Me.ItemForCancelButton.CustomizationFormText = "Cancel"
        Me.ItemForCancelButton.Location = New System.Drawing.Point(175, 240)
        Me.ItemForCancelButton.Name = "ItemForCancelButton"
        Me.ItemForCancelButton.Size = New System.Drawing.Size(181, 32)
        Me.ItemForCancelButton.Text = "Cancel"
        Me.ItemForCancelButton.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForCancelButton.TextToControlDistance = 0
        Me.ItemForCancelButton.TextVisible = False
        '
        'ItemForSaveButton
        '
        Me.ItemForSaveButton.Control = Me.SaveButton
        Me.ItemForSaveButton.CustomizationFormText = "Save"
        Me.ItemForSaveButton.Location = New System.Drawing.Point(0, 240)
        Me.ItemForSaveButton.Name = "ItemForSaveButton"
        Me.ItemForSaveButton.Size = New System.Drawing.Size(175, 32)
        Me.ItemForSaveButton.Text = "Save"
        Me.ItemForSaveButton.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForSaveButton.TextToControlDistance = 0
        Me.ItemForSaveButton.TextVisible = False
        '
        'ItemForJobCustomer
        '
        Me.ItemForJobCustomer.Control = Me.JobCustomerTextEdit
        Me.ItemForJobCustomer.CustomizationFormText = "Customer"
        Me.ItemForJobCustomer.Location = New System.Drawing.Point(0, 30)
        Me.ItemForJobCustomer.Name = "ItemForJobCustomer"
        Me.ItemForJobCustomer.Size = New System.Drawing.Size(356, 30)
        Me.ItemForJobCustomer.Text = "Customer"
        Me.ItemForJobCustomer.TextSize = New System.Drawing.Size(71, 13)
        Me.ItemForJobCustomer.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.UserPasswordTextEdit
        Me.LayoutControlItem2.CustomizationFormText = "User Password"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 150)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(356, 30)
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
        Me.ItemForCurrentStage.Size = New System.Drawing.Size(356, 30)
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
        Me.ItemForNextStage.Size = New System.Drawing.Size(356, 30)
        Me.ItemForNextStage.Text = "Next"
        Me.ItemForNextStage.TextSize = New System.Drawing.Size(71, 13)
        Me.ItemForNextStage.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TraceJobCheckEdit
        Me.LayoutControlItem3.CustomizationFormText = "Trace Job"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 272)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(356, 56)
        Me.LayoutControlItem3.Text = "Trace Job"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.CancelReasonCodeLookUpEdit
        Me.LayoutControlItem4.CustomizationFormText = "Cancel Reason"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 180)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(356, 30)
        Me.LayoutControlItem4.Text = "Cancel Reason"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(71, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CancelComentTextEdit
        Me.LayoutControlItem5.CustomizationFormText = "Comment"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(356, 30)
        Me.LayoutControlItem5.Text = "Comment"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(71, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'xfCancelJobStage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 328)
        Me.Controls.Add(Me.LayoutControl)
        Me.Name = "xfCancelJobStage"
        Me.Text = "Cancel Job"
        CType(Me.ItemForJobNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.CancelComentTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelReasonCodeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelReasonCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraceJobCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCancelButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSaveButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCurrentStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemForJobNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LayoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents NextStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CurrentStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobCustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CancelButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UserPasswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UserNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TraceJobCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCancelButton As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForSaveButton As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobCustomer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCurrentStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNextStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CancelComentTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CancelReasonCodeLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CancelReasonCodeBindingSource As System.Windows.Forms.BindingSource
End Class
