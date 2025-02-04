<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfSupplierDeliveryNoteReprint
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SupplierDeliveryNoteLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.JobSupplierDeliveryNoteBindingSource = New System.Windows.Forms.BindingSource()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SupplierDeliveryNoteLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobSupplierDeliveryNoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(224, 69)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 18
        Me.SimpleButton1.Text = "Reprint"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SupplierDeliveryNoteLookUpEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(288, 50)
        Me.GroupControl1.TabIndex = 17
        Me.GroupControl1.Text = "Delivery Note..."
        '
        'SupplierDeliveryNoteLookUpEdit
        '
        Me.SupplierDeliveryNoteLookUpEdit.Location = New System.Drawing.Point(14, 25)
        Me.SupplierDeliveryNoteLookUpEdit.Name = "SupplierDeliveryNoteLookUpEdit"
        Me.SupplierDeliveryNoteLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.SupplierDeliveryNoteLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierDeliveryNoteLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DeliveryNumber", "Delivery Number", 89, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SupplierDeliveryNoteLookUpEdit.Properties.DataSource = Me.JobSupplierDeliveryNoteBindingSource
        Me.SupplierDeliveryNoteLookUpEdit.Properties.DisplayMember = "DeliveryNumber"
        Me.SupplierDeliveryNoteLookUpEdit.Properties.NullText = "(Select Delivery Note...)"
        Me.SupplierDeliveryNoteLookUpEdit.Size = New System.Drawing.Size(250, 20)
        Me.SupplierDeliveryNoteLookUpEdit.TabIndex = 13
        '
        'JobSupplierDeliveryNoteBindingSource
        '
        Me.JobSupplierDeliveryNoteBindingSource.DataMember = "JobSupplierDeliveryNoteCollection"
        Me.JobSupplierDeliveryNoteBindingSource.DataSource = Me.JobBindingSource
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Job)
        '
        'xfSupplierDeliveryNoteReprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 101)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "xfSupplierDeliveryNoteReprint"
        Me.Text = "Reprint Supplier Delivery Note"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.SupplierDeliveryNoteLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobSupplierDeliveryNoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SupplierDeliveryNoteLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents JobSupplierDeliveryNoteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
End Class