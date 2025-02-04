<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeGeneratePayment
    Inherits UniSource.ShopFloor.GUI.xaegGeneratePayment

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
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.PayRunLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PayRunBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentFrequencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyBranchLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CompanyBranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentFrequencyLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.StartDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.EndDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPaymentFrequency = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCompanyBranch = New DevExpress.XtraLayout.LayoutControlItem()
        Me.itemForPayRun = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.PayRunLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayRunBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentFrequencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBranchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentFrequencyLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPaymentFrequency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCompanyBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemForPayRun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.ShowCaption = False
        Me.grpGroup.Size = New System.Drawing.Size(472, 216)
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(329, 235)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(410, 235)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.PayRunLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CompanyBranchLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PaymentFrequencyLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.StartDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EndDateDateEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 2)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(468, 212)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'PayRunLookUpEdit
        '
        Me.PayRunLookUpEdit.Location = New System.Drawing.Point(111, 84)
        Me.PayRunLookUpEdit.Name = "PayRunLookUpEdit"
        Me.PayRunLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PayRunLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.PayRunLookUpEdit.Properties.DataSource = Me.PayRunBindingSource
        Me.PayRunLookUpEdit.Properties.DisplayMember = "Code"
        Me.PayRunLookUpEdit.Size = New System.Drawing.Size(345, 20)
        Me.PayRunLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.PayRunLookUpEdit.TabIndex = 9
        '
        'PayRunBindingSource
        '
        Me.PayRunBindingSource.DataMember = "PaymentFrequencyTypeList"
        Me.PayRunBindingSource.DataSource = Me.PaymentFrequencyBindingSource
        '
        'PaymentFrequencyBindingSource
        '
        Me.PaymentFrequencyBindingSource.DataSource = GetType(UniSource.ShopFloor.API.PaymentFrequency)
        '
        'CompanyBranchLookUpEdit
        '
        Me.CompanyBranchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CompanyBranch", True))
        Me.CompanyBranchLookUpEdit.Location = New System.Drawing.Point(111, 108)
        Me.CompanyBranchLookUpEdit.Name = "CompanyBranchLookUpEdit"
        Me.CompanyBranchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyBranchLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CompanyBranchLookUpEdit.Properties.DataSource = Me.CompanyBranchBindingSource
        Me.CompanyBranchLookUpEdit.Properties.DisplayMember = "Description"
        Me.CompanyBranchLookUpEdit.Size = New System.Drawing.Size(345, 20)
        Me.CompanyBranchLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.CompanyBranchLookUpEdit.TabIndex = 8
        '
        'CompanyBranchBindingSource
        '
        Me.CompanyBranchBindingSource.DataSource = GetType(UniSource.ShopFloor.API.PaymentRunTypes)
        '
        'PaymentFrequencyLookUpEdit
        '
        Me.PaymentFrequencyLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PaymentFrequency", True))
        Me.PaymentFrequencyLookUpEdit.Location = New System.Drawing.Point(111, 60)
        Me.PaymentFrequencyLookUpEdit.Name = "PaymentFrequencyLookUpEdit"
        Me.PaymentFrequencyLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PaymentFrequencyLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")})
        Me.PaymentFrequencyLookUpEdit.Properties.DataSource = Me.PaymentFrequencyBindingSource
        Me.PaymentFrequencyLookUpEdit.Properties.DisplayMember = "Description"
        Me.PaymentFrequencyLookUpEdit.Size = New System.Drawing.Size(345, 20)
        Me.PaymentFrequencyLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.PaymentFrequencyLookUpEdit.TabIndex = 7
        '
        'StartDateDateEdit
        '
        Me.StartDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "StartDate", True))
        Me.StartDateDateEdit.EditValue = Nothing
        Me.StartDateDateEdit.Location = New System.Drawing.Point(111, 12)
        Me.StartDateDateEdit.Name = "StartDateDateEdit"
        Me.StartDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.StartDateDateEdit.Size = New System.Drawing.Size(345, 20)
        Me.StartDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.StartDateDateEdit.TabIndex = 4
        '
        'EndDateDateEdit
        '
        Me.EndDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EndDate", True))
        Me.EndDateDateEdit.EditValue = Nothing
        Me.EndDateDateEdit.Location = New System.Drawing.Point(111, 36)
        Me.EndDateDateEdit.Name = "EndDateDateEdit"
        Me.EndDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EndDateDateEdit.Size = New System.Drawing.Size(345, 20)
        Me.EndDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.EndDateDateEdit.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(468, 212)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForStartDate, Me.ItemForEndDate, Me.ItemForPaymentFrequency, Me.ItemForCompanyBranch, Me.itemForPayRun})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(448, 192)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForStartDate
        '
        Me.ItemForStartDate.Control = Me.StartDateDateEdit
        Me.ItemForStartDate.CustomizationFormText = "Start Date"
        Me.ItemForStartDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForStartDate.Name = "ItemForStartDate"
        Me.ItemForStartDate.Size = New System.Drawing.Size(448, 24)
        Me.ItemForStartDate.Text = "Start Date"
        Me.ItemForStartDate.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForEndDate
        '
        Me.ItemForEndDate.Control = Me.EndDateDateEdit
        Me.ItemForEndDate.CustomizationFormText = "End Date"
        Me.ItemForEndDate.Location = New System.Drawing.Point(0, 24)
        Me.ItemForEndDate.Name = "ItemForEndDate"
        Me.ItemForEndDate.Size = New System.Drawing.Size(448, 24)
        Me.ItemForEndDate.Text = "End Date"
        Me.ItemForEndDate.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForPaymentFrequency
        '
        Me.ItemForPaymentFrequency.Control = Me.PaymentFrequencyLookUpEdit
        Me.ItemForPaymentFrequency.CustomizationFormText = "Payment Frequency"
        Me.ItemForPaymentFrequency.Location = New System.Drawing.Point(0, 48)
        Me.ItemForPaymentFrequency.Name = "ItemForPaymentFrequency"
        Me.ItemForPaymentFrequency.Size = New System.Drawing.Size(448, 24)
        Me.ItemForPaymentFrequency.Text = "Payment Frequency"
        Me.ItemForPaymentFrequency.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForCompanyBranch
        '
        Me.ItemForCompanyBranch.Control = Me.CompanyBranchLookUpEdit
        Me.ItemForCompanyBranch.CustomizationFormText = "Company Branch"
        Me.ItemForCompanyBranch.Location = New System.Drawing.Point(0, 96)
        Me.ItemForCompanyBranch.Name = "ItemForCompanyBranch"
        Me.ItemForCompanyBranch.Size = New System.Drawing.Size(448, 96)
        Me.ItemForCompanyBranch.Text = "Company Branch"
        Me.ItemForCompanyBranch.TextSize = New System.Drawing.Size(96, 13)
        '
        'itemForPayRun
        '
        Me.itemForPayRun.Control = Me.PayRunLookUpEdit
        Me.itemForPayRun.CustomizationFormText = "Pay Run"
        Me.itemForPayRun.Location = New System.Drawing.Point(0, 72)
        Me.itemForPayRun.Name = "itemForPayRun"
        Me.itemForPayRun.Size = New System.Drawing.Size(448, 24)
        Me.itemForPayRun.Text = "Pay Run"
        Me.itemForPayRun.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PaymentFrequencyLookUpEdit
        Me.LayoutControlItem1.CustomizationFormText = "Payment Frequency"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.Name = "ItemForPaymentFrequency"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(448, 24)
        Me.LayoutControlItem1.Text = "Payment Frequency"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(96, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'xaeGeneratePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 270)
        Me.Name = "xaeGeneratePayment"
        Me.Text = "Payment Run"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.PayRunLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayRunBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentFrequencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBranchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentFrequencyLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPaymentFrequency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCompanyBranch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemForPayRun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents StartDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EndDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PaymentFrequencyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyBranchLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PaymentFrequencyLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ItemForPaymentFrequency As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCompanyBranch As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CompanyBranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PayRunLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents itemForPayRun As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PayRunBindingSource As System.Windows.Forms.BindingSource
End Class
