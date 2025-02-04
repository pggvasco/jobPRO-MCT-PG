<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeDrawing
    Inherits UniSource.ShopFloor.Scheduler.GUI.xaegDrawing

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
        Me.dlcDrawings = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DrawingPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.JobsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsLoadingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsChangedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PropertiesValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DrawingPathButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.ActivityDrawingsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDrawingsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForJobs = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsLoading = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsChanged = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPropertiesValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActivityDrawings = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDrawings = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDrawing = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDrawingPath = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dlcDrawings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dlcDrawings.SuspendLayout()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingPathButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityDrawingsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDrawingsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActivityDrawings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDrawings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDrawingPath, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.dlcDrawings)
        Me.grpGroup.Size = New System.Drawing.Size(285, 163)
        Me.grpGroup.Text = ""
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(140, 194)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(221, 194)
        '
        'dlcDrawings
        '
        Me.dlcDrawings.Controls.Add(Me.CodeTextEdit)
        Me.dlcDrawings.Controls.Add(Me.DrawingPictureEdit)
        Me.dlcDrawings.Controls.Add(Me.JobsTextEdit)
        Me.dlcDrawings.Controls.Add(Me.IDTextEdit)
        Me.dlcDrawings.Controls.Add(Me.IsLoadingCheckEdit)
        Me.dlcDrawings.Controls.Add(Me.IsChangedCheckEdit)
        Me.dlcDrawings.Controls.Add(Me.ValidationErrorMessagesTextEdit)
        Me.dlcDrawings.Controls.Add(Me.PropertiesValidationErrorMessagesTextEdit)
        Me.dlcDrawings.Controls.Add(Me.DrawingPathButtonEdit)
        Me.dlcDrawings.Controls.Add(Me.ActivityDrawingsTextEdit)
        Me.dlcDrawings.Controls.Add(Me.JobDrawingsTextEdit)
        Me.dlcDrawings.DataSource = Me.BindingSource
        Me.dlcDrawings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dlcDrawings.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForJobs, Me.ItemForID, Me.ItemForIsLoading, Me.ItemForIsChanged, Me.ItemForValidationErrorMessages, Me.ItemForPropertiesValidationErrorMessages, Me.ItemForActivityDrawings, Me.ItemForJobDrawings})
        Me.dlcDrawings.Location = New System.Drawing.Point(2, 21)
        Me.dlcDrawings.Name = "dlcDrawings"
        Me.dlcDrawings.OptionsView.UseSkinIndents = False
        Me.dlcDrawings.Root = Me.LayoutControlGroup1
        Me.dlcDrawings.Size = New System.Drawing.Size(281, 140)
        Me.dlcDrawings.TabIndex = 0
        Me.dlcDrawings.Text = "DataLayoutControl1"
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(74, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(202, 20)
        Me.CodeTextEdit.StyleController = Me.dlcDrawings
        Me.CodeTextEdit.TabIndex = 4
        '
        'DrawingPictureEdit
        '
        Me.DrawingPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Drawing", True))
        Me.DrawingPictureEdit.Location = New System.Drawing.Point(5, 65)
        Me.DrawingPictureEdit.Name = "DrawingPictureEdit"
        Me.DrawingPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.DrawingPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.DrawingPictureEdit.Size = New System.Drawing.Size(271, 70)
        Me.DrawingPictureEdit.StyleController = Me.dlcDrawings
        Me.DrawingPictureEdit.TabIndex = 5
        '
        'JobsTextEdit
        '
        Me.JobsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Jobs", True))
        Me.JobsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobsTextEdit.Name = "JobsTextEdit"
        Me.JobsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobsTextEdit.StyleController = Me.dlcDrawings
        Me.JobsTextEdit.TabIndex = 6
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IDTextEdit.StyleController = Me.dlcDrawings
        Me.IDTextEdit.TabIndex = 7
        '
        'IsLoadingCheckEdit
        '
        Me.IsLoadingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsLoading", True))
        Me.IsLoadingCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsLoadingCheckEdit.Name = "IsLoadingCheckEdit"
        Me.IsLoadingCheckEdit.Properties.Caption = "Is Loading"
        Me.IsLoadingCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsLoadingCheckEdit.StyleController = Me.dlcDrawings
        Me.IsLoadingCheckEdit.TabIndex = 8
        '
        'IsChangedCheckEdit
        '
        Me.IsChangedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsChanged", True))
        Me.IsChangedCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsChangedCheckEdit.Name = "IsChangedCheckEdit"
        Me.IsChangedCheckEdit.Properties.Caption = "Is Changed"
        Me.IsChangedCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsChangedCheckEdit.StyleController = Me.dlcDrawings
        Me.IsChangedCheckEdit.TabIndex = 9
        '
        'ValidationErrorMessagesTextEdit
        '
        Me.ValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidationErrorMessages", True))
        Me.ValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ValidationErrorMessagesTextEdit.Name = "ValidationErrorMessagesTextEdit"
        Me.ValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ValidationErrorMessagesTextEdit.StyleController = Me.dlcDrawings
        Me.ValidationErrorMessagesTextEdit.TabIndex = 10
        '
        'PropertiesValidationErrorMessagesTextEdit
        '
        Me.PropertiesValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PropertiesValidationErrorMessages", True))
        Me.PropertiesValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesValidationErrorMessagesTextEdit.Name = "PropertiesValidationErrorMessagesTextEdit"
        Me.PropertiesValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.PropertiesValidationErrorMessagesTextEdit.StyleController = Me.dlcDrawings
        Me.PropertiesValidationErrorMessagesTextEdit.TabIndex = 11
        '
        'DrawingPathButtonEdit
        '
        Me.DrawingPathButtonEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DrawingPath", True))
        Me.DrawingPathButtonEdit.Location = New System.Drawing.Point(74, 35)
        Me.DrawingPathButtonEdit.Name = "DrawingPathButtonEdit"
        Me.DrawingPathButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DrawingPathButtonEdit.Size = New System.Drawing.Size(202, 20)
        Me.DrawingPathButtonEdit.StyleController = Me.dlcDrawings
        Me.DrawingPathButtonEdit.TabIndex = 12
        '
        'ActivityDrawingsTextEdit
        '
        Me.ActivityDrawingsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ActivityDrawings", True))
        Me.ActivityDrawingsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ActivityDrawingsTextEdit.Name = "ActivityDrawingsTextEdit"
        Me.ActivityDrawingsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ActivityDrawingsTextEdit.StyleController = Me.dlcDrawings
        Me.ActivityDrawingsTextEdit.TabIndex = 13
        '
        'JobDrawingsTextEdit
        '
        Me.JobDrawingsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobDrawings", True))
        Me.JobDrawingsTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobDrawingsTextEdit.Name = "JobDrawingsTextEdit"
        Me.JobDrawingsTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobDrawingsTextEdit.StyleController = Me.dlcDrawings
        Me.JobDrawingsTextEdit.TabIndex = 14
        '
        'ItemForJobs
        '
        Me.ItemForJobs.Control = Me.JobsTextEdit
        Me.ItemForJobs.CustomizationFormText = "Jobs"
        Me.ItemForJobs.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobs.Name = "ItemForJobs"
        Me.ItemForJobs.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobs.Text = "Jobs"
        Me.ItemForJobs.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobs.TextToControlDistance = 5
        '
        'ItemForID
        '
        Me.ItemForID.Control = Me.IDTextEdit
        Me.ItemForID.CustomizationFormText = "ID"
        Me.ItemForID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForID.Name = "ItemForID"
        Me.ItemForID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForID.Text = "ID"
        Me.ItemForID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForID.TextToControlDistance = 5
        '
        'ItemForIsLoading
        '
        Me.ItemForIsLoading.Control = Me.IsLoadingCheckEdit
        Me.ItemForIsLoading.CustomizationFormText = "Is Loading"
        Me.ItemForIsLoading.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsLoading.Name = "ItemForIsLoading"
        Me.ItemForIsLoading.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIsLoading.Text = "Is Loading"
        Me.ItemForIsLoading.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsLoading.TextToControlDistance = 0
        Me.ItemForIsLoading.TextVisible = False
        '
        'ItemForIsChanged
        '
        Me.ItemForIsChanged.Control = Me.IsChangedCheckEdit
        Me.ItemForIsChanged.CustomizationFormText = "Is Changed"
        Me.ItemForIsChanged.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsChanged.Name = "ItemForIsChanged"
        Me.ItemForIsChanged.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIsChanged.Text = "Is Changed"
        Me.ItemForIsChanged.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsChanged.TextToControlDistance = 0
        Me.ItemForIsChanged.TextVisible = False
        '
        'ItemForValidationErrorMessages
        '
        Me.ItemForValidationErrorMessages.Control = Me.ValidationErrorMessagesTextEdit
        Me.ItemForValidationErrorMessages.CustomizationFormText = "Validation Error Messages"
        Me.ItemForValidationErrorMessages.Location = New System.Drawing.Point(0, 0)
        Me.ItemForValidationErrorMessages.Name = "ItemForValidationErrorMessages"
        Me.ItemForValidationErrorMessages.Size = New System.Drawing.Size(0, 0)
        Me.ItemForValidationErrorMessages.Text = "Validation Error Messages"
        Me.ItemForValidationErrorMessages.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForValidationErrorMessages.TextToControlDistance = 5
        '
        'ItemForPropertiesValidationErrorMessages
        '
        Me.ItemForPropertiesValidationErrorMessages.Control = Me.PropertiesValidationErrorMessagesTextEdit
        Me.ItemForPropertiesValidationErrorMessages.CustomizationFormText = "Properties Validation Error Messages"
        Me.ItemForPropertiesValidationErrorMessages.Location = New System.Drawing.Point(0, 0)
        Me.ItemForPropertiesValidationErrorMessages.Name = "ItemForPropertiesValidationErrorMessages"
        Me.ItemForPropertiesValidationErrorMessages.Size = New System.Drawing.Size(0, 0)
        Me.ItemForPropertiesValidationErrorMessages.Text = "Properties Validation Error Messages"
        Me.ItemForPropertiesValidationErrorMessages.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForPropertiesValidationErrorMessages.TextToControlDistance = 5
        '
        'ItemForActivityDrawings
        '
        Me.ItemForActivityDrawings.Control = Me.ActivityDrawingsTextEdit
        Me.ItemForActivityDrawings.CustomizationFormText = "Activity Drawings"
        Me.ItemForActivityDrawings.Location = New System.Drawing.Point(0, 0)
        Me.ItemForActivityDrawings.Name = "ItemForActivityDrawings"
        Me.ItemForActivityDrawings.Size = New System.Drawing.Size(0, 0)
        Me.ItemForActivityDrawings.Text = "Activity Drawings"
        Me.ItemForActivityDrawings.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForActivityDrawings.TextToControlDistance = 5
        '
        'ItemForJobDrawings
        '
        Me.ItemForJobDrawings.Control = Me.JobDrawingsTextEdit
        Me.ItemForJobDrawings.CustomizationFormText = "Job Drawings"
        Me.ItemForJobDrawings.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobDrawings.Name = "ItemForJobDrawings"
        Me.ItemForJobDrawings.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobDrawings.Text = "Job Drawings"
        Me.ItemForJobDrawings.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobDrawings.TextToControlDistance = 5
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(281, 140)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDrawing, Me.ItemForDrawingPath})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(281, 140)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(281, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(64, 13)
        Me.ItemForCode.TextToControlDistance = 5
        '
        'ItemForDrawing
        '
        Me.ItemForDrawing.Control = Me.DrawingPictureEdit
        Me.ItemForDrawing.CustomizationFormText = "Drawing"
        Me.ItemForDrawing.Location = New System.Drawing.Point(0, 60)
        Me.ItemForDrawing.Name = "ItemForDrawing"
        Me.ItemForDrawing.Size = New System.Drawing.Size(281, 80)
        Me.ItemForDrawing.Text = "Drawing"
        Me.ItemForDrawing.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForDrawing.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForDrawing.TextToControlDistance = 0
        Me.ItemForDrawing.TextVisible = False
        '
        'ItemForDrawingPath
        '
        Me.ItemForDrawingPath.Control = Me.DrawingPathButtonEdit
        Me.ItemForDrawingPath.CustomizationFormText = "Drawing Path"
        Me.ItemForDrawingPath.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDrawingPath.Name = "ItemForDrawingPath"
        Me.ItemForDrawingPath.Size = New System.Drawing.Size(281, 30)
        Me.ItemForDrawingPath.Text = "Drawing Path"
        Me.ItemForDrawingPath.TextSize = New System.Drawing.Size(64, 13)
        Me.ItemForDrawingPath.TextToControlDistance = 5
        '
        'xaeDrawing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 242)
        Me.Name = "xaeDrawing"
        Me.Text = "Drawing"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dlcDrawings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dlcDrawings.ResumeLayout(False)
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingPathButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityDrawingsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDrawingsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActivityDrawings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDrawings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDrawingPath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dlcDrawings As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DrawingPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents JobsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsLoadingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsChangedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PropertiesValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForJobs As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsLoading As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsChanged As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPropertiesValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDrawing As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DrawingPathButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ActivityDrawingsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobDrawingsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForActivityDrawings As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDrawings As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDrawingPath As DevExpress.XtraLayout.LayoutControlItem
End Class
