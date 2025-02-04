<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfActivityLog
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ArtisanLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.btPreview = New DevExpress.XtraEditors.SimpleButton()
        Me.AllJobsCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AllArtisansCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.JobLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ToDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.FromDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciFromDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciJob = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciToDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciArtisan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.ArtisanBindingSource = New System.Windows.Forms.BindingSource()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ArtisanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllJobsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllArtisansCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFromDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciToDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ArtisanLookUpEdit)
        Me.LayoutControl1.Controls.Add(Me.btPreview)
        Me.LayoutControl1.Controls.Add(Me.AllJobsCheckEdit)
        Me.LayoutControl1.Controls.Add(Me.AllArtisansCheckEdit)
        Me.LayoutControl1.Controls.Add(Me.JobLookUpEdit)
        Me.LayoutControl1.Controls.Add(Me.ToDateDateEdit)
        Me.LayoutControl1.Controls.Add(Me.FromDateDateEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(331, 81, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(531, 162)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ArtisanLookUpEdit
        '
        Me.ArtisanLookUpEdit.Location = New System.Drawing.Point(77, 43)
        Me.ArtisanLookUpEdit.Name = "ArtisanLookUpEdit"
        Me.ArtisanLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ArtisanLookUpEdit.Size = New System.Drawing.Size(342, 20)
        Me.ArtisanLookUpEdit.StyleController = Me.LayoutControl1
        Me.ArtisanLookUpEdit.TabIndex = 11
        '
        'btPreview
        '
        Me.btPreview.Location = New System.Drawing.Point(412, 127)
        Me.btPreview.Name = "btPreview"
        Me.btPreview.Size = New System.Drawing.Size(107, 22)
        Me.btPreview.StyleController = Me.LayoutControl1
        Me.btPreview.TabIndex = 10
        Me.btPreview.Text = "Preview"
        '
        'AllJobsCheckEdit
        '
        Me.AllJobsCheckEdit.EditValue = True
        Me.AllJobsCheckEdit.Location = New System.Drawing.Point(424, 91)
        Me.AllJobsCheckEdit.Name = "AllJobsCheckEdit"
        Me.AllJobsCheckEdit.Properties.Caption = "All Jobs"
        Me.AllJobsCheckEdit.Size = New System.Drawing.Size(83, 19)
        Me.AllJobsCheckEdit.StyleController = Me.LayoutControl1
        Me.AllJobsCheckEdit.TabIndex = 9
        '
        'AllArtisansCheckEdit
        '
        Me.AllArtisansCheckEdit.Location = New System.Drawing.Point(423, 43)
        Me.AllArtisansCheckEdit.Name = "AllArtisansCheckEdit"
        Me.AllArtisansCheckEdit.Properties.Caption = "All Artisans"
        Me.AllArtisansCheckEdit.Size = New System.Drawing.Size(84, 19)
        Me.AllArtisansCheckEdit.StyleController = Me.LayoutControl1
        Me.AllArtisansCheckEdit.TabIndex = 8
        '
        'JobLookUpEdit
        '
        Me.JobLookUpEdit.Enabled = False
        Me.JobLookUpEdit.Location = New System.Drawing.Point(77, 91)
        Me.JobLookUpEdit.Name = "JobLookUpEdit"
        Me.JobLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JobLookUpEdit.Size = New System.Drawing.Size(343, 20)
        Me.JobLookUpEdit.StyleController = Me.LayoutControl1
        Me.JobLookUpEdit.TabIndex = 7
        '
        'ToDateDateEdit
        '
        Me.ToDateDateEdit.EditValue = New Date(2013, 12, 19, 10, 12, 49, 0)
        Me.ToDateDateEdit.Location = New System.Drawing.Point(320, 67)
        Me.ToDateDateEdit.Name = "ToDateDateEdit"
        Me.ToDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ToDateDateEdit.Size = New System.Drawing.Size(187, 20)
        Me.ToDateDateEdit.StyleController = Me.LayoutControl1
        Me.ToDateDateEdit.TabIndex = 6
        '
        'FromDateDateEdit
        '
        Me.FromDateDateEdit.EditValue = New Date(2013, 12, 19, 10, 12, 10, 0)
        Me.FromDateDateEdit.Location = New System.Drawing.Point(77, 67)
        Me.FromDateDateEdit.Name = "FromDateDateEdit"
        Me.FromDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FromDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FromDateDateEdit.Size = New System.Drawing.Size(186, 20)
        Me.FromDateDateEdit.StyleController = Me.LayoutControl1
        Me.FromDateDateEdit.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(531, 162)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Filter"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciFromDate, Me.LayoutControlItem1, Me.lciJob, Me.LayoutControlItem2, Me.lciToDate, Me.lciArtisan})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(511, 115)
        Me.LayoutControlGroup3.Text = "Filter"
        '
        'lciFromDate
        '
        Me.lciFromDate.Control = Me.FromDateDateEdit
        Me.lciFromDate.CustomizationFormText = "From Date"
        Me.lciFromDate.Location = New System.Drawing.Point(0, 24)
        Me.lciFromDate.Name = "lciFromDate"
        Me.lciFromDate.Size = New System.Drawing.Size(243, 24)
        Me.lciFromDate.Text = "From Date"
        Me.lciFromDate.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.AllArtisansCheckEdit
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(399, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(88, 24)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'lciJob
        '
        Me.lciJob.Control = Me.JobLookUpEdit
        Me.lciJob.CustomizationFormText = "Job"
        Me.lciJob.Location = New System.Drawing.Point(0, 48)
        Me.lciJob.Name = "lciJob"
        Me.lciJob.Size = New System.Drawing.Size(400, 24)
        Me.lciJob.Text = "Job"
        Me.lciJob.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.AllJobsCheckEdit
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(400, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(87, 24)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'lciToDate
        '
        Me.lciToDate.Control = Me.ToDateDateEdit
        Me.lciToDate.CustomizationFormText = "To Date"
        Me.lciToDate.Location = New System.Drawing.Point(243, 24)
        Me.lciToDate.Name = "lciToDate"
        Me.lciToDate.Size = New System.Drawing.Size(244, 24)
        Me.lciToDate.Text = "To Date"
        Me.lciToDate.TextSize = New System.Drawing.Size(50, 13)
        '
        'lciArtisan
        '
        Me.lciArtisan.Control = Me.ArtisanLookUpEdit
        Me.lciArtisan.CustomizationFormText = "Artisan"
        Me.lciArtisan.Location = New System.Drawing.Point(0, 0)
        Me.lciArtisan.Name = "lciArtisan"
        Me.lciArtisan.Size = New System.Drawing.Size(399, 24)
        Me.lciArtisan.Text = "Artisan"
        Me.lciArtisan.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btPreview
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(400, 115)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(111, 27)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 115)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(400, 27)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'xfActivityLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 162)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xfActivityLog"
        Me.Text = "Activity Log Report"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ArtisanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllJobsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllArtisansCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFromDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciToDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents JobLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ToDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FromDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lciFromDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciToDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciJob As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AllJobsCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AllArtisansCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btPreview As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ArtisanLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciArtisan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ArtisanBindingSource As System.Windows.Forms.BindingSource
End Class
