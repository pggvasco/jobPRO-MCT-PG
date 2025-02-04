<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobSupplierDeliveryNote
    Inherits UniSource.ShopFloor.GUI.xaegJobSupplierDeliveryNote

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
        Me.SupplierLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.QuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ItemForResponsibleAgentID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ResponsibleAgentIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.AgentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dnNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SpecialInstructions1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SpecialInstructions2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.attentionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.lOutstanding = New DevExpress.XtraEditors.LabelControl()
        Me.lDelivered = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForResponsibleAgentID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResponsibleAgentIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dnNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecialInstructions1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecialInstructions2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.attentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.lDelivered)
        Me.grpGroup.Controls.Add(Me.lOutstanding)
        Me.grpGroup.Controls.Add(Me.LabelControl6)
        Me.grpGroup.Controls.Add(Me.LabelControl5)
        Me.grpGroup.Controls.Add(Me.LabelControl1)
        Me.grpGroup.Controls.Add(Me.SupplierLookUpEdit)
        Me.grpGroup.Controls.Add(Me.dnNumberTextEdit)
        Me.grpGroup.Controls.Add(Me.LabelControl2)
        Me.grpGroup.Controls.Add(Me.ResponsibleAgentIDLookUpEdit)
        Me.grpGroup.Controls.Add(Me.LabelControl3)
        Me.grpGroup.Controls.Add(Me.QuantitySpinEdit)
        Me.grpGroup.Controls.Add(Me.LabelControl4)
        Me.grpGroup.Location = New System.Drawing.Point(12, 12)
        Me.grpGroup.Size = New System.Drawing.Size(286, 204)
        Me.grpGroup.TabIndex = 17
        Me.grpGroup.Text = "Job Supplier Delivery Note"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(141, 374)
        Me.btSave.TabIndex = 30
        Me.btSave.Text = "Print"
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(222, 374)
        Me.btCancel.TabIndex = 35
        '
        'SupplierLookUpEdit
        '
        Me.SupplierLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Vendor", True))
        Me.SupplierLookUpEdit.Location = New System.Drawing.Point(113, 24)
        Me.SupplierLookUpEdit.Name = "SupplierLookUpEdit"
        Me.SupplierLookUpEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SupplierLookUpEdit.Properties.Appearance.Options.UseForeColor = True
        Me.SupplierLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.SupplierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account", "Account", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SupplierLookUpEdit.Properties.DataSource = Me.VendorBindingSource
        Me.SupplierLookUpEdit.Properties.DisplayMember = "Name"
        Me.SupplierLookUpEdit.Properties.NullText = "(Select Supplier)"
        Me.SupplierLookUpEdit.Properties.ReadOnly = True
        Me.SupplierLookUpEdit.Size = New System.Drawing.Size(150, 20)
        Me.SupplierLookUpEdit.TabIndex = 18
        '
        'VendorBindingSource
        '
        Me.VendorBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.Vendor)
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.Vendor)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(69, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Supplier"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(53, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "DN Number"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(65, 82)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Quantity"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(18, 150)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Responsible Agent"
        '
        'QuantitySpinEdit
        '
        Me.QuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Quantity", True))
        Me.QuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.QuantitySpinEdit.Location = New System.Drawing.Point(113, 79)
        Me.QuantitySpinEdit.Name = "QuantitySpinEdit"
        Me.QuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.QuantitySpinEdit.Properties.MaxValue = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.QuantitySpinEdit.Properties.MinValue = New Decimal(New Integer() {10000000, 0, 0, -2147483648})
        Me.QuantitySpinEdit.Size = New System.Drawing.Size(150, 20)
        Me.QuantitySpinEdit.TabIndex = 23
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
        'ResponsibleAgentIDLookUpEdit
        '
        Me.ResponsibleAgentIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ResponsibleAgent", True))
        Me.ResponsibleAgentIDLookUpEdit.Location = New System.Drawing.Point(14, 169)
        Me.ResponsibleAgentIDLookUpEdit.Name = "ResponsibleAgentIDLookUpEdit"
        Me.ResponsibleAgentIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ResponsibleAgentIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Display Name", 74, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ResponsibleAgentIDLookUpEdit.Properties.DataSource = Me.AgentBindingSource
        Me.ResponsibleAgentIDLookUpEdit.Properties.DisplayMember = "Name"
        Me.ResponsibleAgentIDLookUpEdit.Properties.ValueMember = "ID"
        Me.ResponsibleAgentIDLookUpEdit.Size = New System.Drawing.Size(250, 20)
        Me.ResponsibleAgentIDLookUpEdit.TabIndex = 24
        '
        'AgentBindingSource
        '
        Me.AgentBindingSource.DataSource = GetType(Pastel.Evolution.Agent)
        '
        'dnNumberTextEdit
        '
        Me.dnNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DeliveryNumber", True))
        Me.dnNumberTextEdit.Location = New System.Drawing.Point(114, 52)
        Me.dnNumberTextEdit.Name = "dnNumberTextEdit"
        Me.dnNumberTextEdit.Size = New System.Drawing.Size(149, 20)
        Me.dnNumberTextEdit.TabIndex = 21
        '
        'SpecialInstructions1TextEdit
        '
        Me.SpecialInstructions1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "SpecialInstructions1", True))
        Me.SpecialInstructions1TextEdit.EditValue = "Enter Special Instructions..."
        Me.SpecialInstructions1TextEdit.Location = New System.Drawing.Point(14, 29)
        Me.SpecialInstructions1TextEdit.Name = "SpecialInstructions1TextEdit"
        Me.SpecialInstructions1TextEdit.Size = New System.Drawing.Size(250, 20)
        Me.SpecialInstructions1TextEdit.TabIndex = 26
        '
        'SpecialInstructions2TextEdit
        '
        Me.SpecialInstructions2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "SpecialInstructions2", True))
        Me.SpecialInstructions2TextEdit.EditValue = "Enter Special Instructions..."
        Me.SpecialInstructions2TextEdit.Location = New System.Drawing.Point(14, 55)
        Me.SpecialInstructions2TextEdit.Name = "SpecialInstructions2TextEdit"
        Me.SpecialInstructions2TextEdit.Size = New System.Drawing.Size(250, 20)
        Me.SpecialInstructions2TextEdit.TabIndex = 27
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Job)
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(113, 108)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "Delivered"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(113, 127)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl6.TabIndex = 29
        Me.LabelControl6.Text = "Outstanding"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SpecialInstructions1TextEdit)
        Me.GroupControl1.Controls.Add(Me.SpecialInstructions2TextEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 222)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(286, 85)
        Me.GroupControl1.TabIndex = 36
        Me.GroupControl1.Text = "Special Instructions"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.attentionTextEdit)
        Me.GroupControl2.Location = New System.Drawing.Point(13, 314)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(284, 51)
        Me.GroupControl2.TabIndex = 37
        Me.GroupControl2.Text = "Attention"
        '
        'attentionTextEdit
        '
        Me.attentionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Attention", True))
        Me.attentionTextEdit.EditValue = "Enter for whom's attention..."
        Me.attentionTextEdit.Location = New System.Drawing.Point(14, 25)
        Me.attentionTextEdit.Name = "attentionTextEdit"
        Me.attentionTextEdit.Size = New System.Drawing.Size(250, 20)
        Me.attentionTextEdit.TabIndex = 0
        '
        'lOutstanding
        '
        Me.lOutstanding.Location = New System.Drawing.Point(48, 127)
        Me.lOutstanding.Name = "lOutstanding"
        Me.lOutstanding.Size = New System.Drawing.Size(6, 13)
        Me.lOutstanding.TabIndex = 30
        Me.lOutstanding.Text = "0"
        '
        'lDelivered
        '
        Me.lDelivered.Location = New System.Drawing.Point(48, 108)
        Me.lDelivered.Name = "lDelivered"
        Me.lDelivered.Size = New System.Drawing.Size(6, 13)
        Me.lDelivered.TabIndex = 31
        Me.lDelivered.Text = "0"
        '
        'xaeJobSupplierDeliveryNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 403)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "xaeJobSupplierDeliveryNote"
        Me.Text = "Job Supplier Delivery Note"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.btSave, 0)
        Me.Controls.SetChildIndex(Me.btCancel, 0)
        Me.Controls.SetChildIndex(Me.grpGroup, 0)
        Me.Controls.SetChildIndex(Me.GroupControl2, 0)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        Me.grpGroup.PerformLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForResponsibleAgentID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResponsibleAgentIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dnNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecialInstructions1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecialInstructions2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.attentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SpecialInstructions2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpecialInstructions1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dnNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ResponsibleAgentIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents QuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ItemForResponsibleAgentID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents attentionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lDelivered As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lOutstanding As DevExpress.XtraEditors.LabelControl
End Class
