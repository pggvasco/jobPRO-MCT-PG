<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobDelivery
    Inherits UniSource.ShopFloor.GUI.xaegJobDelivery

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
        Me.JobDeliveryDataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.DeliveryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.DeliveryNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ResponsibleAgentIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.AgentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Information1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Information2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ReasonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForQuantity = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForInformation1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForInformation2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForReason = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJob = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForResponsibleAgentID = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDeliveryDataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JobDeliveryDataLayoutControl.SuspendLayout()
        CType(Me.DeliveryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResponsibleAgentIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Information1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Information2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForInformation1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForInformation2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForResponsibleAgentID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.JobDeliveryDataLayoutControl)
        Me.grpGroup.Size = New System.Drawing.Size(546, 210)
        Me.grpGroup.Text = "Job Delivery Note"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(403, 229)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(484, 229)
        '
        'JobDeliveryDataLayoutControl
        '
        Me.JobDeliveryDataLayoutControl.Controls.Add(Me.DeliveryDateDateEdit)
        Me.JobDeliveryDataLayoutControl.Controls.Add(Me.DeliveryNumberTextEdit)
        Me.JobDeliveryDataLayoutControl.Controls.Add(Me.QuantitySpinEdit)
        Me.JobDeliveryDataLayoutControl.Controls.Add(Me.ResponsibleAgentIDLookUpEdit)
        Me.JobDeliveryDataLayoutControl.Controls.Add(Me.Information1TextEdit)
        Me.JobDeliveryDataLayoutControl.Controls.Add(Me.Information2TextEdit)
        Me.JobDeliveryDataLayoutControl.Controls.Add(Me.ReasonTextEdit)
        Me.JobDeliveryDataLayoutControl.Controls.Add(Me.JobLookUpEdit)
        Me.JobDeliveryDataLayoutControl.DataSource = Me.BindingSource
        Me.JobDeliveryDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobDeliveryDataLayoutControl.Location = New System.Drawing.Point(2, 21)
        Me.JobDeliveryDataLayoutControl.Name = "JobDeliveryDataLayoutControl"
        Me.JobDeliveryDataLayoutControl.OptionsView.UseSkinIndents = False
        Me.JobDeliveryDataLayoutControl.Root = Me.LayoutControlGroup1
        Me.JobDeliveryDataLayoutControl.Size = New System.Drawing.Size(542, 187)
        Me.JobDeliveryDataLayoutControl.TabIndex = 0
        Me.JobDeliveryDataLayoutControl.Text = "Job Delivery"
        '
        'DeliveryDateDateEdit
        '
        Me.DeliveryDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DeliveryDate", True))
        Me.DeliveryDateDateEdit.EditValue = Nothing
        Me.DeliveryDateDateEdit.Location = New System.Drawing.Point(360, 35)
        Me.DeliveryDateDateEdit.Name = "DeliveryDateDateEdit"
        Me.DeliveryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeliveryDateDateEdit.Properties.ReadOnly = True
        Me.DeliveryDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DeliveryDateDateEdit.Size = New System.Drawing.Size(177, 20)
        Me.DeliveryDateDateEdit.StyleController = Me.JobDeliveryDataLayoutControl
        Me.DeliveryDateDateEdit.TabIndex = 4
        '
        'DeliveryNumberTextEdit
        '
        Me.DeliveryNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DeliveryNumber", True))
        Me.DeliveryNumberTextEdit.Location = New System.Drawing.Point(89, 35)
        Me.DeliveryNumberTextEdit.Name = "DeliveryNumberTextEdit"
        Me.DeliveryNumberTextEdit.Properties.ReadOnly = True
        Me.DeliveryNumberTextEdit.Size = New System.Drawing.Size(177, 20)
        Me.DeliveryNumberTextEdit.StyleController = Me.JobDeliveryDataLayoutControl
        Me.DeliveryNumberTextEdit.TabIndex = 5
        '
        'QuantitySpinEdit
        '
        Me.QuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Quantity", True))
        Me.QuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.QuantitySpinEdit.Location = New System.Drawing.Point(89, 65)
        Me.QuantitySpinEdit.Name = "QuantitySpinEdit"
        Me.QuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.QuantitySpinEdit.Properties.ReadOnly = True
        Me.QuantitySpinEdit.Size = New System.Drawing.Size(177, 20)
        Me.QuantitySpinEdit.StyleController = Me.JobDeliveryDataLayoutControl
        Me.QuantitySpinEdit.TabIndex = 6
        '
        'ResponsibleAgentIDLookUpEdit
        '
        Me.ResponsibleAgentIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ResponsibleAgentID", True))
        Me.ResponsibleAgentIDLookUpEdit.Location = New System.Drawing.Point(360, 65)
        Me.ResponsibleAgentIDLookUpEdit.Name = "ResponsibleAgentIDLookUpEdit"
        Me.ResponsibleAgentIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ResponsibleAgentIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Display Name", 74, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ResponsibleAgentIDLookUpEdit.Properties.DataSource = Me.AgentBindingSource
        Me.ResponsibleAgentIDLookUpEdit.Properties.DisplayMember = "Name"
        Me.ResponsibleAgentIDLookUpEdit.Properties.ReadOnly = True
        Me.ResponsibleAgentIDLookUpEdit.Properties.ValueMember = "ID"
        Me.ResponsibleAgentIDLookUpEdit.Size = New System.Drawing.Size(177, 20)
        Me.ResponsibleAgentIDLookUpEdit.StyleController = Me.JobDeliveryDataLayoutControl
        Me.ResponsibleAgentIDLookUpEdit.TabIndex = 8
        '
        'AgentBindingSource
        '
        Me.AgentBindingSource.DataSource = GetType(Pastel.Evolution.Agent)
        '
        'Information1TextEdit
        '
        Me.Information1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Information1", True))
        Me.Information1TextEdit.Location = New System.Drawing.Point(89, 95)
        Me.Information1TextEdit.Name = "Information1TextEdit"
        Me.Information1TextEdit.Properties.ReadOnly = True
        Me.Information1TextEdit.Size = New System.Drawing.Size(448, 20)
        Me.Information1TextEdit.StyleController = Me.JobDeliveryDataLayoutControl
        Me.Information1TextEdit.TabIndex = 9
        '
        'Information2TextEdit
        '
        Me.Information2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Information2", True))
        Me.Information2TextEdit.Location = New System.Drawing.Point(89, 125)
        Me.Information2TextEdit.Name = "Information2TextEdit"
        Me.Information2TextEdit.Properties.ReadOnly = True
        Me.Information2TextEdit.Size = New System.Drawing.Size(448, 20)
        Me.Information2TextEdit.StyleController = Me.JobDeliveryDataLayoutControl
        Me.Information2TextEdit.TabIndex = 10
        '
        'ReasonTextEdit
        '
        Me.ReasonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Reason", True))
        Me.ReasonTextEdit.Location = New System.Drawing.Point(89, 155)
        Me.ReasonTextEdit.Name = "ReasonTextEdit"
        Me.ReasonTextEdit.Properties.ReadOnly = True
        Me.ReasonTextEdit.Size = New System.Drawing.Size(448, 20)
        Me.ReasonTextEdit.StyleController = Me.JobDeliveryDataLayoutControl
        Me.ReasonTextEdit.TabIndex = 11
        '
        'JobLookUpEdit
        '
        Me.JobLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Job", True))
        Me.JobLookUpEdit.Location = New System.Drawing.Point(89, 5)
        Me.JobLookUpEdit.Name = "JobLookUpEdit"
        Me.JobLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.JobLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JobLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobNumber", "Job Number", 67, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuoteNumber", "Quote Number", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderNumber", "Order Number", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Customer", "Customer", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobDate", "Job Date", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuoteDate", "Quote Date", 66, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AcceptedDate", "Accepted Date", 81, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstimatedDeliveryDate", "Estimated Delivery Date", 125, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.JobLookUpEdit.Properties.DataSource = Me.JobBindingSource
        Me.JobLookUpEdit.Properties.NullText = "(Select Job...)"
        Me.JobLookUpEdit.Size = New System.Drawing.Size(448, 20)
        Me.JobLookUpEdit.StyleController = Me.JobDeliveryDataLayoutControl
        Me.JobLookUpEdit.TabIndex = 12
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Job)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(542, 187)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForQuantity, Me.ItemForInformation1, Me.ItemForInformation2, Me.ItemForReason, Me.ItemForJob, Me.ItemForDeliveryNumber, Me.ItemForDeliveryDate, Me.ItemForResponsibleAgentID})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(542, 187)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForQuantity
        '
        Me.ItemForQuantity.Control = Me.QuantitySpinEdit
        Me.ItemForQuantity.CustomizationFormText = "Quantity"
        Me.ItemForQuantity.Location = New System.Drawing.Point(0, 60)
        Me.ItemForQuantity.Name = "ItemForQuantity"
        Me.ItemForQuantity.Size = New System.Drawing.Size(271, 30)
        Me.ItemForQuantity.Text = "Quantity"
        Me.ItemForQuantity.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForQuantity.TextToControlDistance = 5
        '
        'ItemForInformation1
        '
        Me.ItemForInformation1.Control = Me.Information1TextEdit
        Me.ItemForInformation1.CustomizationFormText = "Information1"
        Me.ItemForInformation1.Location = New System.Drawing.Point(0, 90)
        Me.ItemForInformation1.Name = "ItemForInformation1"
        Me.ItemForInformation1.Size = New System.Drawing.Size(542, 30)
        Me.ItemForInformation1.Text = "Information1"
        Me.ItemForInformation1.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForInformation1.TextToControlDistance = 5
        '
        'ItemForInformation2
        '
        Me.ItemForInformation2.Control = Me.Information2TextEdit
        Me.ItemForInformation2.CustomizationFormText = "Information2"
        Me.ItemForInformation2.Location = New System.Drawing.Point(0, 120)
        Me.ItemForInformation2.Name = "ItemForInformation2"
        Me.ItemForInformation2.Size = New System.Drawing.Size(542, 30)
        Me.ItemForInformation2.Text = "Information2"
        Me.ItemForInformation2.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForInformation2.TextToControlDistance = 5
        '
        'ItemForReason
        '
        Me.ItemForReason.Control = Me.ReasonTextEdit
        Me.ItemForReason.CustomizationFormText = "Reason"
        Me.ItemForReason.Location = New System.Drawing.Point(0, 150)
        Me.ItemForReason.Name = "ItemForReason"
        Me.ItemForReason.Size = New System.Drawing.Size(542, 37)
        Me.ItemForReason.Text = "Reason"
        Me.ItemForReason.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForReason.TextToControlDistance = 5
        '
        'ItemForJob
        '
        Me.ItemForJob.Control = Me.JobLookUpEdit
        Me.ItemForJob.CustomizationFormText = "Job"
        Me.ItemForJob.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJob.Name = "ItemForJob"
        Me.ItemForJob.Size = New System.Drawing.Size(542, 30)
        Me.ItemForJob.Text = "Job"
        Me.ItemForJob.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForJob.TextToControlDistance = 5
        '
        'ItemForDeliveryNumber
        '
        Me.ItemForDeliveryNumber.Control = Me.DeliveryNumberTextEdit
        Me.ItemForDeliveryNumber.CustomizationFormText = "Delivery Number"
        Me.ItemForDeliveryNumber.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDeliveryNumber.Name = "ItemForDeliveryNumber"
        Me.ItemForDeliveryNumber.Size = New System.Drawing.Size(271, 30)
        Me.ItemForDeliveryNumber.Text = "Delivery Number"
        Me.ItemForDeliveryNumber.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForDeliveryNumber.TextToControlDistance = 5
        '
        'ItemForDeliveryDate
        '
        Me.ItemForDeliveryDate.Control = Me.DeliveryDateDateEdit
        Me.ItemForDeliveryDate.CustomizationFormText = "Delivery Date"
        Me.ItemForDeliveryDate.Location = New System.Drawing.Point(271, 30)
        Me.ItemForDeliveryDate.Name = "ItemForDeliveryDate"
        Me.ItemForDeliveryDate.Size = New System.Drawing.Size(271, 30)
        Me.ItemForDeliveryDate.Text = "Delivery Date"
        Me.ItemForDeliveryDate.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForDeliveryDate.TextToControlDistance = 5
        '
        'ItemForResponsibleAgentID
        '
        Me.ItemForResponsibleAgentID.Control = Me.ResponsibleAgentIDLookUpEdit
        Me.ItemForResponsibleAgentID.CustomizationFormText = "Responsible"
        Me.ItemForResponsibleAgentID.Location = New System.Drawing.Point(271, 60)
        Me.ItemForResponsibleAgentID.Name = "ItemForResponsibleAgentID"
        Me.ItemForResponsibleAgentID.Size = New System.Drawing.Size(271, 30)
        Me.ItemForResponsibleAgentID.Text = "Responsible"
        Me.ItemForResponsibleAgentID.TextSize = New System.Drawing.Size(79, 13)
        Me.ItemForResponsibleAgentID.TextToControlDistance = 5
        '
        'xaeJobDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 264)
        Me.Name = "xaeJobDelivery"
        Me.Text = "Job Delivery - "
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDeliveryDataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JobDeliveryDataLayoutControl.ResumeLayout(False)
        CType(Me.DeliveryDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResponsibleAgentIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Information1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Information2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForInformation1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForInformation2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForResponsibleAgentID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents JobDeliveryDataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents DeliveryDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DeliveryNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ResponsibleAgentIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Information1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Information2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ReasonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForDeliveryDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeliveryNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuantity As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForResponsibleAgentID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForInformation1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForInformation2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForReason As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJob As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgentBindingSource As System.Windows.Forms.BindingSource
End Class
