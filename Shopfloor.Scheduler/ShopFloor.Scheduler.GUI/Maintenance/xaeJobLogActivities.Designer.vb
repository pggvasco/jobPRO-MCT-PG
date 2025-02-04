<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobLogActivities
    Inherits UniSource.ShopFloor.Scheduler.GUI.xaegJobLogActivities

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
        Me.ActivityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ArtisanLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ArtisanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrentStateComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DurationSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.EndDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.StartDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciCurrentState = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDuration = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciArtisan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciActivity = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.ActivityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentStateComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DurationSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCurrentState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciArtisan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Location = New System.Drawing.Point(13, 12)
        Me.grpGroup.Size = New System.Drawing.Size(689, 143)
        Me.grpGroup.Text = "Log Information"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(546, 161)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(627, 161)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.ActivityTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ArtisanLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CurrentStateComboBoxEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DurationSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EndDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.StartDateDateEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 21)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(246, 218, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(685, 120)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'ActivityTextEdit
        '
        Me.ActivityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Activity", True))
        Me.ActivityTextEdit.Location = New System.Drawing.Point(90, 12)
        Me.ActivityTextEdit.Name = "ActivityTextEdit"
        Me.ActivityTextEdit.Properties.ReadOnly = True
        Me.ActivityTextEdit.Size = New System.Drawing.Size(583, 20)
        Me.ActivityTextEdit.StyleController = Me.DataLayoutControl1
        Me.ActivityTextEdit.TabIndex = 9
        '
        'ArtisanLookUpEdit
        '
        Me.ArtisanLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Artisan", True))
        Me.ArtisanLookUpEdit.Location = New System.Drawing.Point(90, 84)
        Me.ArtisanLookUpEdit.Name = "ArtisanLookUpEdit"
        Me.ArtisanLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ArtisanLookUpEdit.Properties.DataSource = Me.ArtisanBindingSource
        Me.ArtisanLookUpEdit.Properties.DisplayMember = "Description"
        Me.ArtisanLookUpEdit.Size = New System.Drawing.Size(583, 20)
        Me.ArtisanLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.ArtisanLookUpEdit.TabIndex = 8
        '
        'ArtisanBindingSource
        '
        Me.ArtisanBindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.API.Artisan)
        '
        'CurrentStateComboBoxEdit
        '
        Me.CurrentStateComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CurrentStateID", True))
        Me.CurrentStateComboBoxEdit.Location = New System.Drawing.Point(422, 60)
        Me.CurrentStateComboBoxEdit.Name = "CurrentStateComboBoxEdit"
        Me.CurrentStateComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CurrentStateComboBoxEdit.Size = New System.Drawing.Size(251, 20)
        Me.CurrentStateComboBoxEdit.StyleController = Me.DataLayoutControl1
        Me.CurrentStateComboBoxEdit.TabIndex = 7
        '
        'DurationSpinEdit
        '
        Me.DurationSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Duration", True))
        Me.DurationSpinEdit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DurationSpinEdit.Location = New System.Drawing.Point(422, 36)
        Me.DurationSpinEdit.Name = "DurationSpinEdit"
        Me.DurationSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DurationSpinEdit.Properties.MaxValue = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.DurationSpinEdit.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DurationSpinEdit.Size = New System.Drawing.Size(251, 20)
        Me.DurationSpinEdit.StyleController = Me.DataLayoutControl1
        Me.DurationSpinEdit.TabIndex = 6
        '
        'EndDateDateEdit
        '
        Me.EndDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EndDate", True))
        Me.EndDateDateEdit.EditValue = New Date(2013, 7, 3, 22, 17, 18, 85)
        Me.EndDateDateEdit.Location = New System.Drawing.Point(90, 60)
        Me.EndDateDateEdit.Name = "EndDateDateEdit"
        Me.EndDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDateDateEdit.Properties.DisplayFormat.FormatString = "g"
        Me.EndDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EndDateDateEdit.Properties.Mask.EditMask = "g"
        Me.EndDateDateEdit.Properties.ReadOnly = True
        Me.EndDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EndDateDateEdit.Size = New System.Drawing.Size(250, 20)
        Me.EndDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.EndDateDateEdit.TabIndex = 5
        '
        'StartDateDateEdit
        '
        Me.StartDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "StartDate", True))
        Me.StartDateDateEdit.EditValue = New Date(2013, 7, 3, 22, 5, 47, 129)
        Me.StartDateDateEdit.Location = New System.Drawing.Point(90, 36)
        Me.StartDateDateEdit.Name = "StartDateDateEdit"
        Me.StartDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDateDateEdit.Properties.DisplayFormat.FormatString = "g"
        Me.StartDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDateDateEdit.Properties.EditFormat.FormatString = "g"
        Me.StartDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.StartDateDateEdit.Size = New System.Drawing.Size(250, 20)
        Me.StartDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.StartDateDateEdit.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciStartDate, Me.lciCurrentState, Me.lciDuration, Me.lciEndDate, Me.lciArtisan, Me.lciActivity})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(685, 120)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lciStartDate
        '
        Me.lciStartDate.Control = Me.StartDateDateEdit
        Me.lciStartDate.CustomizationFormText = "LayoutControlItem1"
        Me.lciStartDate.Location = New System.Drawing.Point(0, 24)
        Me.lciStartDate.Name = "lciStartDate"
        Me.lciStartDate.Size = New System.Drawing.Size(332, 24)
        Me.lciStartDate.Text = "Start Date Time"
        Me.lciStartDate.TextSize = New System.Drawing.Size(75, 13)
        '
        'lciCurrentState
        '
        Me.lciCurrentState.Control = Me.CurrentStateComboBoxEdit
        Me.lciCurrentState.CustomizationFormText = "Current State"
        Me.lciCurrentState.Location = New System.Drawing.Point(332, 48)
        Me.lciCurrentState.Name = "lciCurrentState"
        Me.lciCurrentState.Size = New System.Drawing.Size(333, 24)
        Me.lciCurrentState.Text = "Current State"
        Me.lciCurrentState.TextSize = New System.Drawing.Size(75, 13)
        '
        'lciDuration
        '
        Me.lciDuration.Control = Me.DurationSpinEdit
        Me.lciDuration.CustomizationFormText = "Duration"
        Me.lciDuration.Location = New System.Drawing.Point(332, 24)
        Me.lciDuration.Name = "lciDuration"
        Me.lciDuration.Size = New System.Drawing.Size(333, 24)
        Me.lciDuration.Text = "Duration"
        Me.lciDuration.TextSize = New System.Drawing.Size(75, 13)
        '
        'lciEndDate
        '
        Me.lciEndDate.Control = Me.EndDateDateEdit
        Me.lciEndDate.CustomizationFormText = "End Date Time"
        Me.lciEndDate.Location = New System.Drawing.Point(0, 48)
        Me.lciEndDate.Name = "lciEndDate"
        Me.lciEndDate.Size = New System.Drawing.Size(332, 24)
        Me.lciEndDate.Text = "End Date Time"
        Me.lciEndDate.TextSize = New System.Drawing.Size(75, 13)
        '
        'lciArtisan
        '
        Me.lciArtisan.Control = Me.ArtisanLookUpEdit
        Me.lciArtisan.CustomizationFormText = "Artisan"
        Me.lciArtisan.Location = New System.Drawing.Point(0, 72)
        Me.lciArtisan.Name = "lciArtisan"
        Me.lciArtisan.Size = New System.Drawing.Size(665, 28)
        Me.lciArtisan.Text = "Artisan"
        Me.lciArtisan.TextSize = New System.Drawing.Size(75, 13)
        '
        'lciActivity
        '
        Me.lciActivity.Control = Me.ActivityTextEdit
        Me.lciActivity.CustomizationFormText = "Activity"
        Me.lciActivity.Location = New System.Drawing.Point(0, 0)
        Me.lciActivity.Name = "lciActivity"
        Me.lciActivity.Size = New System.Drawing.Size(665, 24)
        Me.lciActivity.Text = "Activity"
        Me.lciActivity.TextSize = New System.Drawing.Size(75, 13)
        '
        'xaeJobLogActivities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 196)
        Me.Name = "xaeJobLogActivities"
        Me.Text = "Job Activities Log"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.ActivityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtisanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentStateComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DurationSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCurrentState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciArtisan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DurationSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EndDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents StartDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lciStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciDuration As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CurrentStateComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lciCurrentState As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ArtisanLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciArtisan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ActivityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciActivity As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ArtisanBindingSource As System.Windows.Forms.BindingSource
End Class
