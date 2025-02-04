<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobReports
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
        Me.ItemForRepresentativeID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SalesRepresentativeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.RepresentativeIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ceRepresentative = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciSalesRepresentative = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btPreviewReport = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ReportTypeComboBoxEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.IncludeQuotesComboBoxEdit = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.ItemForRepresentativeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesRepresentativeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.RepresentativeIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceRepresentative.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSalesRepresentative, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncludeQuotesComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemForRepresentativeID
        '
        Me.ItemForRepresentativeID.CustomizationFormText = "Representative"
        Me.ItemForRepresentativeID.Location = New System.Drawing.Point(0, 90)
        Me.ItemForRepresentativeID.Name = "ItemForRepresentativeID"
        Me.ItemForRepresentativeID.Size = New System.Drawing.Size(406, 30)
        Me.ItemForRepresentativeID.Text = "Representative"
        Me.ItemForRepresentativeID.TextSize = New System.Drawing.Size(109, 13)
        Me.ItemForRepresentativeID.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.CustomizationFormText = "Representative"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem1.Name = "ItemForRepresentativeID"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(406, 30)
        Me.LayoutControlItem1.Text = "Representative"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(109, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.CustomizationFormText = "Representative"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem2.Name = "ItemForRepresentativeID"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(406, 30)
        Me.LayoutControlItem2.Text = "Representative"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(109, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.CustomizationFormText = "Representative"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem3.Name = "ItemForRepresentativeID"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(406, 30)
        Me.LayoutControlItem3.Text = "Representative"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(109, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'SalesRepresentativeBindingSource
        '
        Me.SalesRepresentativeBindingSource.DataSource = GetType(Pastel.Evolution.SalesRepresentative)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LayoutControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(620, 100)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Filter Options"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.RepresentativeIDLookUpEdit)
        Me.LayoutControl1.Controls.Add(Me.ceRepresentative)
        Me.LayoutControl1.Controls.Add(Me.ReportTypeComboBoxEdit)
        Me.LayoutControl1.Controls.Add(Me.IncludeQuotesComboBoxEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(2, 21)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(616, 77)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'RepresentativeIDLookUpEdit
        '
        Me.RepresentativeIDLookUpEdit.Enabled = False
        Me.RepresentativeIDLookUpEdit.Location = New System.Drawing.Point(309, 12)
        Me.RepresentativeIDLookUpEdit.Name = "RepresentativeIDLookUpEdit"
        Me.RepresentativeIDLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepresentativeIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepresentativeIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Comment1", "Comment1", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepresentativeIDLookUpEdit.Properties.DataSource = Me.SalesRepresentativeBindingSource
        Me.RepresentativeIDLookUpEdit.Properties.DisplayMember = "Code"
        Me.RepresentativeIDLookUpEdit.Properties.NullText = "(Select Rep...)"
        Me.RepresentativeIDLookUpEdit.Properties.ValueMember = "ID"
        Me.RepresentativeIDLookUpEdit.Size = New System.Drawing.Size(295, 20)
        Me.RepresentativeIDLookUpEdit.StyleController = Me.LayoutControl1
        Me.RepresentativeIDLookUpEdit.TabIndex = 35
        '
        'ceRepresentative
        '
        Me.ceRepresentative.Location = New System.Drawing.Point(12, 12)
        Me.ceRepresentative.Name = "ceRepresentative"
        Me.ceRepresentative.Properties.Caption = "Show All Sales Representative"
        Me.ceRepresentative.Size = New System.Drawing.Size(188, 19)
        Me.ceRepresentative.StyleController = Me.LayoutControl1
        Me.ceRepresentative.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.lciSalesRepresentative, Me.LayoutControlItem5, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(616, 126)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ceRepresentative
        Me.LayoutControlItem4.CustomizationFormText = "Show All Sales Representative"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(192, 24)
        Me.LayoutControlItem4.Text = "Show All Sales Representative"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'lciSalesRepresentative
        '
        Me.lciSalesRepresentative.Control = Me.RepresentativeIDLookUpEdit
        Me.lciSalesRepresentative.CustomizationFormText = "SalesRepresentative"
        Me.lciSalesRepresentative.Location = New System.Drawing.Point(192, 0)
        Me.lciSalesRepresentative.Name = "lciSalesRepresentative"
        Me.lciSalesRepresentative.Size = New System.Drawing.Size(404, 24)
        Me.lciSalesRepresentative.Text = "Sales Representative"
        Me.lciSalesRepresentative.TextSize = New System.Drawing.Size(102, 13)
        '
        'btPreviewReport
        '
        Me.btPreviewReport.Location = New System.Drawing.Point(527, 118)
        Me.btPreviewReport.Name = "btPreviewReport"
        Me.btPreviewReport.Size = New System.Drawing.Size(103, 23)
        Me.btPreviewReport.TabIndex = 1
        Me.btPreviewReport.Text = "Preview Report"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.ReportTypeComboBoxEdit
        Me.LayoutControlItem5.CustomizationFormText = "Layout"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(298, 33)
        Me.LayoutControlItem5.Text = "Layout"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.IncludeQuotesComboBoxEdit
        Me.LayoutControlItem6.CustomizationFormText = "Include Quotes"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(298, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(298, 33)
        Me.LayoutControlItem6.Text = "Include Quotes"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(102, 13)
        '
        'ReportTypeComboBoxEdit
        '
        Me.ReportTypeComboBoxEdit.Location = New System.Drawing.Point(117, 36)
        Me.ReportTypeComboBoxEdit.Name = "ReportTypeComboBoxEdit"
        Me.ReportTypeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReportTypeComboBoxEdit.Properties.NullText = ""
        Me.ReportTypeComboBoxEdit.Properties.PopupSizeable = False
        Me.ReportTypeComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ReportTypeComboBoxEdit.Size = New System.Drawing.Size(189, 20)
        Me.ReportTypeComboBoxEdit.StyleController = Me.LayoutControl1
        Me.ReportTypeComboBoxEdit.TabIndex = 36
        '
        'IncludeQuotesComboBoxEdit
        '
        Me.IncludeQuotesComboBoxEdit.Location = New System.Drawing.Point(415, 36)
        Me.IncludeQuotesComboBoxEdit.Name = "IncludeQuotesComboBoxEdit"
        Me.IncludeQuotesComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IncludeQuotesComboBoxEdit.Properties.NullText = ""
        Me.IncludeQuotesComboBoxEdit.Properties.PopupSizeable = False
        Me.IncludeQuotesComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.IncludeQuotesComboBoxEdit.Size = New System.Drawing.Size(189, 20)
        Me.IncludeQuotesComboBoxEdit.StyleController = Me.LayoutControl1
        Me.IncludeQuotesComboBoxEdit.TabIndex = 37
        '
        'xaeJobReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 149)
        Me.Controls.Add(Me.btPreviewReport)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "xaeJobReports"
        Me.Text = "Job Reports"
        CType(Me.ItemForRepresentativeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesRepresentativeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.RepresentativeIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceRepresentative.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSalesRepresentative, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncludeQuotesComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemForRepresentativeID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SalesRepresentativeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ceRepresentative As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btPreviewReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepresentativeIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciSalesRepresentative As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ReportTypeComboBoxEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IncludeQuotesComboBoxEdit As DevExpress.XtraEditors.LookUpEdit
End Class
