<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeEditSupplierDeliveryNote
    Inherits UniSource.ShopFloor.GUI.xaegEditSupplierDeliveryNote

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
        Me.SupplierLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.JobSupplierDeliveryNoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobSupplierDeliveryNoteListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DeliveryNoteLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobSupplierDeliveryNoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobSupplierDeliveryNoteListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryNoteLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DeliveryNoteLookUpEdit)
        Me.grpGroup.Controls.Add(Me.LabelControl2)
        Me.grpGroup.Controls.Add(Me.LabelControl1)
        Me.grpGroup.Controls.Add(Me.SupplierLookUpEdit)
        Me.grpGroup.Size = New System.Drawing.Size(252, 126)
        Me.grpGroup.Text = "Select Criteria"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(106, 149)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(187, 149)
        '
        'SupplierLookUpEdit
        '
        Me.SupplierLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JobSupplierDeliveryNoteBindingSource, "SupplierID", True))
        Me.SupplierLookUpEdit.Enabled = False
        Me.SupplierLookUpEdit.Location = New System.Drawing.Point(6, 92)
        Me.SupplierLookUpEdit.Name = "SupplierLookUpEdit"
        Me.SupplierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account", "Account", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SupplierLookUpEdit.Properties.DataSource = Me.VendorBindingSource
        Me.SupplierLookUpEdit.Properties.DisplayMember = "Name"
        Me.SupplierLookUpEdit.Properties.NullText = "Select Supplier..."
        Me.SupplierLookUpEdit.Properties.ReadOnly = True
        Me.SupplierLookUpEdit.Properties.ValueMember = "ID"
        Me.SupplierLookUpEdit.Size = New System.Drawing.Size(238, 20)
        Me.SupplierLookUpEdit.TabIndex = 1
        '
        'JobSupplierDeliveryNoteBindingSource
        '
        Me.JobSupplierDeliveryNoteBindingSource.DataSource = GetType(UniSource.ShopFloor.API.JobSupplierDeliveryNote)
        '
        'VendorBindingSource
        '
        Me.VendorBindingSource.DataSource = GetType(UniSource.Helper.ActiveRecord.Evolution.Vendor)
        '
        'JobSupplierDeliveryNoteListBindingSource
        '
        Me.JobSupplierDeliveryNoteListBindingSource.DataMember = "JobSupplierDeliveryNoteCollection"
        Me.JobSupplierDeliveryNoteListBindingSource.DataSource = Me.BindingSource
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Delivery Note"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(6, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Supplier"
        '
        'DeliveryNoteLookUpEdit
        '
        Me.DeliveryNoteLookUpEdit.Location = New System.Drawing.Point(6, 47)
        Me.DeliveryNoteLookUpEdit.Name = "DeliveryNoteLookUpEdit"
        Me.DeliveryNoteLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeliveryNoteLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DeliveryNumber", "Delivery Note Number", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.DeliveryNoteLookUpEdit.Properties.DataSource = Me.JobSupplierDeliveryNoteListBindingSource
        Me.DeliveryNoteLookUpEdit.Properties.DisplayMember = "DeliveryNumber"
        Me.DeliveryNoteLookUpEdit.Properties.NullText = "Select Delivery Note..."
        Me.DeliveryNoteLookUpEdit.Size = New System.Drawing.Size(238, 20)
        Me.DeliveryNoteLookUpEdit.TabIndex = 4
        '
        'xaeEditSupplierDeliveryNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 180)
        Me.Name = "xaeEditSupplierDeliveryNote"
        Me.Text = "Edit Supplier Delivery Note"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        Me.grpGroup.PerformLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobSupplierDeliveryNoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobSupplierDeliveryNoteListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryNoteLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SupplierLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents VendorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveryNoteLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents JobSupplierDeliveryNoteListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobSupplierDeliveryNoteBindingSource As System.Windows.Forms.BindingSource
End Class
