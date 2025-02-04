<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfProformaInvDateRange
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
        Me.DateRangeLayoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.ToLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.ToDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.FromLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.FromDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.DateRangeLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DateRangeLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DateRangeLayoutControl.SuspendLayout()
        CType(Me.ToDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateRangeLayoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateRangeLayoutControl
        '
        Me.DateRangeLayoutControl.Controls.Add(Me.ToLabelControl)
        Me.DateRangeLayoutControl.Controls.Add(Me.ToDateEdit)
        Me.DateRangeLayoutControl.Controls.Add(Me.FromLabelControl)
        Me.DateRangeLayoutControl.Controls.Add(Me.FromDateEdit)
        Me.DateRangeLayoutControl.Location = New System.Drawing.Point(2, 3)
        Me.DateRangeLayoutControl.Name = "DateRangeLayoutControl"
        Me.DateRangeLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1759, 224, 250, 350)
        Me.DateRangeLayoutControl.Root = Me.DateRangeLayoutControlGroup
        Me.DateRangeLayoutControl.Size = New System.Drawing.Size(302, 44)
        Me.DateRangeLayoutControl.TabIndex = 0
        Me.DateRangeLayoutControl.Text = "LayoutControl1"
        '
        'ToLabelControl
        '
        Me.ToLabelControl.Location = New System.Drawing.Point(152, 12)
        Me.ToLabelControl.Name = "ToLabelControl"
        Me.ToLabelControl.Size = New System.Drawing.Size(12, 13)
        Me.ToLabelControl.StyleController = Me.DateRangeLayoutControl
        Me.ToLabelControl.TabIndex = 7
        Me.ToLabelControl.Text = "To"
        '
        'ToDateEdit
        '
        Me.ToDateEdit.EditValue = Nothing
        Me.ToDateEdit.Location = New System.Drawing.Point(168, 12)
        Me.ToDateEdit.Name = "ToDateEdit"
        Me.ToDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToDateEdit.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.ToDateEdit.Properties.EditFormat.FormatString = "dd MMM yyyy"
        Me.ToDateEdit.Properties.Mask.EditMask = "dd MMM yyyy"
        Me.ToDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ToDateEdit.Size = New System.Drawing.Size(122, 20)
        Me.ToDateEdit.StyleController = Me.DateRangeLayoutControl
        Me.ToDateEdit.TabIndex = 6
        '
        'FromLabelControl
        '
        Me.FromLabelControl.Location = New System.Drawing.Point(12, 12)
        Me.FromLabelControl.Name = "FromLabelControl"
        Me.FromLabelControl.Size = New System.Drawing.Size(24, 13)
        Me.FromLabelControl.StyleController = Me.DateRangeLayoutControl
        Me.FromLabelControl.TabIndex = 5
        Me.FromLabelControl.Text = "From"
        '
        'FromDateEdit
        '
        Me.FromDateEdit.EditValue = Nothing
        Me.FromDateEdit.Location = New System.Drawing.Point(40, 12)
        Me.FromDateEdit.Name = "FromDateEdit"
        Me.FromDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FromDateEdit.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.FromDateEdit.Properties.EditFormat.FormatString = "dd MMM yyyy"
        Me.FromDateEdit.Properties.Mask.EditMask = "dd MMM yyyy"
        Me.FromDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FromDateEdit.Size = New System.Drawing.Size(108, 20)
        Me.FromDateEdit.StyleController = Me.DateRangeLayoutControl
        Me.FromDateEdit.TabIndex = 4
        '
        'DateRangeLayoutControlGroup
        '
        Me.DateRangeLayoutControlGroup.CustomizationFormText = "LayoutControlGroup1"
        Me.DateRangeLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.DateRangeLayoutControlGroup.GroupBordersVisible = False
        Me.DateRangeLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem1, Me.LayoutControlItem3})
        Me.DateRangeLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.DateRangeLayoutControlGroup.Name = "DateRangeLayoutControlGroup"
        Me.DateRangeLayoutControlGroup.Size = New System.Drawing.Size(302, 44)
        Me.DateRangeLayoutControlGroup.Text = "DateRangeLayoutControlGroup"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.FromLabelControl
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(28, 24)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ToLabelControl
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(140, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(16, 24)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.FromDateEdit
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(28, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(112, 24)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ToDateEdit
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(156, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(126, 24)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'cancelSimpleButton
        '
        Me.cancelSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelSimpleButton.Location = New System.Drawing.Point(138, 46)
        Me.cancelSimpleButton.Name = "cancelSimpleButton"
        Me.cancelSimpleButton.Size = New System.Drawing.Size(75, 19)
        Me.cancelSimpleButton.TabIndex = 1
        Me.cancelSimpleButton.Text = "Cancel"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.okSimpleButton.Location = New System.Drawing.Point(219, 46)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(75, 19)
        Me.okSimpleButton.TabIndex = 2
        Me.okSimpleButton.Text = "Ok"
        '
        'xfProformaInvDateRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 75)
        Me.Controls.Add(Me.okSimpleButton)
        Me.Controls.Add(Me.cancelSimpleButton)
        Me.Controls.Add(Me.DateRangeLayoutControl)
        Me.Name = "xfProformaInvDateRange"
        Me.Text = "Select Daterange..."
        CType(Me.DateRangeLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DateRangeLayoutControl.ResumeLayout(False)
        CType(Me.ToDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateRangeLayoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateRangeLayoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents FromLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FromDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateRangeLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ToDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ToLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
End Class
