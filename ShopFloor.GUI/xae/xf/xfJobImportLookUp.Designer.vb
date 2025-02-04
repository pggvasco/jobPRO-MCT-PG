<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfJobImportLookUp
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
        Me.btOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cbRecalculateServiceItemPrice = New DevExpress.XtraEditors.CheckEdit()
        Me.lkpQuickLookup = New DevExpress.XtraEditors.LookUpEdit()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.cbRecalculateServiceItemPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpQuickLookup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btOK
        '
        Me.btOK.Location = New System.Drawing.Point(116, 63)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(75, 23)
        Me.btOK.TabIndex = 5
        Me.btOK.Text = "OK"
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(197, 63)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 4
        Me.btCancel.Text = "Cancel"
        '
        'cbRecalculateServiceItemPrice
        '
        Me.cbRecalculateServiceItemPrice.EditValue = True
        Me.cbRecalculateServiceItemPrice.Enabled = False
        Me.cbRecalculateServiceItemPrice.Location = New System.Drawing.Point(12, 38)
        Me.cbRecalculateServiceItemPrice.Name = "cbRecalculateServiceItemPrice"
        Me.cbRecalculateServiceItemPrice.Properties.Caption = "Recalculate Service Item Price"
        Me.cbRecalculateServiceItemPrice.Size = New System.Drawing.Size(260, 19)
        Me.cbRecalculateServiceItemPrice.TabIndex = 6
        '
        'lkpQuickLookup
        '
        Me.lkpQuickLookup.Location = New System.Drawing.Point(14, 12)
        Me.lkpQuickLookup.Name = "lkpQuickLookup"
        Me.lkpQuickLookup.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lkpQuickLookup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpQuickLookup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobNumber", "Job Number", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuoteNumber", "Quote Number", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description1", 600, "Description")})
        Me.lkpQuickLookup.Properties.DataSource = Me.JobBindingSource
        Me.lkpQuickLookup.Properties.DisplayMember = "JobNumber"
        Me.lkpQuickLookup.Properties.NullText = "(Please Select a Job)"
        Me.lkpQuickLookup.Size = New System.Drawing.Size(258, 20)
        Me.lkpQuickLookup.TabIndex = 7
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Job)
        '
        'xfJobImportLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 96)
        Me.Controls.Add(Me.lkpQuickLookup)
        Me.Controls.Add(Me.cbRecalculateServiceItemPrice)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.btCancel)
        Me.Name = "xfJobImportLookUp"
        Me.Text = "Job Import"
        CType(Me.cbRecalculateServiceItemPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpQuickLookup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbRecalculateServiceItemPrice As DevExpress.XtraEditors.CheckEdit
    Public WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lkpQuickLookup As DevExpress.XtraEditors.LookUpEdit
End Class
