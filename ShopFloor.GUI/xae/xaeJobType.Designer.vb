<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobType
    Inherits UniSource.ShopFloor.GUI.xaegJobType

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
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsInspectionRequiredCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.RevenueMethodLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsInspectionRequired = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRevenueMethod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StagesGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.JobTypeStageListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJobStage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.JobStageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsInspectionRequiredCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RevenueMethodLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsInspectionRequired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRevenueMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StagesGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StagesGroupControl.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobTypeStageListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobStageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpGroup.Controls.Add(Me.DataLayoutControl1)
        Me.grpGroup.Size = New System.Drawing.Size(581, 115)
        Me.grpGroup.Text = "Job Type"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(438, 544)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(519, 544)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsInspectionRequiredCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RevenueMethodLookUpEdit)
        Me.DataLayoutControl1.DataSource = Me.BindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 21)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(577, 92)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(92, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(480, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl1
        Me.DescriptionTextEdit.TabIndex = 4
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(92, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(253, 20)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.CodeTextEdit.TabIndex = 5
        '
        'IsInspectionRequiredCheckEdit
        '
        Me.IsInspectionRequiredCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsInspectionRequired", True))
        Me.IsInspectionRequiredCheckEdit.Location = New System.Drawing.Point(355, 5)
        Me.IsInspectionRequiredCheckEdit.Name = "IsInspectionRequiredCheckEdit"
        Me.IsInspectionRequiredCheckEdit.Properties.Caption = "Is Inspection Required"
        Me.IsInspectionRequiredCheckEdit.Size = New System.Drawing.Size(217, 19)
        Me.IsInspectionRequiredCheckEdit.StyleController = Me.DataLayoutControl1
        Me.IsInspectionRequiredCheckEdit.TabIndex = 6
        '
        'RevenueMethodLookUpEdit
        '
        Me.RevenueMethodLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "RevenueMethod", True))
        Me.RevenueMethodLookUpEdit.Location = New System.Drawing.Point(92, 65)
        Me.RevenueMethodLookUpEdit.Name = "RevenueMethodLookUpEdit"
        Me.RevenueMethodLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RevenueMethodLookUpEdit.Properties.NullText = "(Select Revenue Method...)"
        Me.RevenueMethodLookUpEdit.Size = New System.Drawing.Size(480, 20)
        Me.RevenueMethodLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.RevenueMethodLookUpEdit.TabIndex = 7
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(577, 92)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForIsInspectionRequired, Me.ItemForDescription, Me.ItemForRevenueMethod})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(577, 92)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(350, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(82, 13)
        Me.ItemForCode.TextToControlDistance = 5
        '
        'ItemForIsInspectionRequired
        '
        Me.ItemForIsInspectionRequired.Control = Me.IsInspectionRequiredCheckEdit
        Me.ItemForIsInspectionRequired.CustomizationFormText = "Is Inspection Required"
        Me.ItemForIsInspectionRequired.Location = New System.Drawing.Point(350, 0)
        Me.ItemForIsInspectionRequired.Name = "ItemForIsInspectionRequired"
        Me.ItemForIsInspectionRequired.Size = New System.Drawing.Size(227, 30)
        Me.ItemForIsInspectionRequired.Text = "Is Inspection Required"
        Me.ItemForIsInspectionRequired.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIsInspectionRequired.TextToControlDistance = 0
        Me.ItemForIsInspectionRequired.TextVisible = False
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(577, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(82, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForRevenueMethod
        '
        Me.ItemForRevenueMethod.Control = Me.RevenueMethodLookUpEdit
        Me.ItemForRevenueMethod.CustomizationFormText = "Revenue Method"
        Me.ItemForRevenueMethod.Location = New System.Drawing.Point(0, 60)
        Me.ItemForRevenueMethod.Name = "ItemForRevenueMethod"
        Me.ItemForRevenueMethod.Size = New System.Drawing.Size(577, 32)
        Me.ItemForRevenueMethod.Text = "Revenue Method"
        Me.ItemForRevenueMethod.TextSize = New System.Drawing.Size(82, 13)
        Me.ItemForRevenueMethod.TextToControlDistance = 5
        '
        'StagesGroupControl
        '
        Me.StagesGroupControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StagesGroupControl.Controls.Add(Me.GridControl)
        Me.StagesGroupControl.Location = New System.Drawing.Point(15, 134)
        Me.StagesGroupControl.Name = "StagesGroupControl"
        Me.StagesGroupControl.Size = New System.Drawing.Size(579, 404)
        Me.StagesGroupControl.TabIndex = 3
        Me.StagesGroupControl.Text = "Stages"
        '
        'GridControl
        '
        Me.GridControl.DataSource = Me.JobTypeStageListBindingSource
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(2, 21)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl.Size = New System.Drawing.Size(575, 381)
        Me.GridControl.TabIndex = 0
        Me.GridControl.UseEmbeddedNavigator = True
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'JobTypeStageListBindingSource
        '
        Me.JobTypeStageListBindingSource.DataMember = "Stages"
        Me.JobTypeStageListBindingSource.DataSource = Me.BindingSource
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobStage})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'colJobStage
        '
        Me.colJobStage.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colJobStage.FieldName = "JobStage"
        Me.colJobStage.Name = "colJobStage"
        Me.colJobStage.Visible = True
        Me.colJobStage.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.JobStageBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Description"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'JobStageBindingSource
        '
        Me.JobStageBindingSource.DataSource = GetType(UniSource.ShopFloor.API.JobStage)
        '
        'xaeJobType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 579)
        Me.Controls.Add(Me.StagesGroupControl)
        Me.Name = "xaeJobType"
        Me.Text = "Job Type"
        Me.Controls.SetChildIndex(Me.StagesGroupControl, 0)
        Me.Controls.SetChildIndex(Me.btSave, 0)
        Me.Controls.SetChildIndex(Me.btCancel, 0)
        Me.Controls.SetChildIndex(Me.grpGroup, 0)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsInspectionRequiredCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RevenueMethodLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsInspectionRequired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRevenueMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StagesGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StagesGroupControl.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobTypeStageListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobStageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsInspectionRequiredCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsInspectionRequired As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents StagesGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents JobStageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJobStage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JobTypeStageListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RevenueMethodLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ItemForRevenueMethod As DevExpress.XtraLayout.LayoutControlItem
End Class
