<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeDrawing
    Inherits xaegDrawing

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xaeDrawing))
        Me.dlcDrawings = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DrawingPathButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.DrawingPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ErrorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NumberOfAnnotationsSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForError = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDrawing = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDrawingPath = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNumberOfAnnotations = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btView = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dlcDrawings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dlcDrawings.SuspendLayout()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingPathButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawingPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberOfAnnotationsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDrawingPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNumberOfAnnotations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.dlcDrawings)
        Me.grpGroup.Size = New System.Drawing.Size(639, 281)
        Me.grpGroup.Text = "Drawing"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(496, 300)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(577, 300)
        '
        'dlcDrawings
        '
        Me.dlcDrawings.Controls.Add(Me.CodeTextEdit)
        Me.dlcDrawings.Controls.Add(Me.DrawingPathButtonEdit)
        Me.dlcDrawings.Controls.Add(Me.DrawingPictureEdit)
        Me.dlcDrawings.Controls.Add(Me.DescriptionTextEdit)
        Me.dlcDrawings.Controls.Add(Me.IDTextEdit)
        Me.dlcDrawings.Controls.Add(Me.ErrorTextEdit)
        Me.dlcDrawings.Controls.Add(Me.NumberOfAnnotationsSpinEdit)
        Me.dlcDrawings.DataSource = Me.BindingSource
        Me.dlcDrawings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dlcDrawings.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForID, Me.ItemForError})
        Me.dlcDrawings.Location = New System.Drawing.Point(2, 21)
        Me.dlcDrawings.Name = "dlcDrawings"
        Me.dlcDrawings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(644, 144, 250, 350)
        Me.dlcDrawings.OptionsView.UseSkinIndents = False
        Me.dlcDrawings.Root = Me.LayoutControlGroup1
        Me.dlcDrawings.Size = New System.Drawing.Size(635, 258)
        Me.dlcDrawings.TabIndex = 0
        Me.dlcDrawings.Text = "DataLayoutControl1"
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(123, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(209, 20)
        Me.CodeTextEdit.StyleController = Me.dlcDrawings
        Me.CodeTextEdit.TabIndex = 4
        '
        'DrawingPathButtonEdit
        '
        Me.DrawingPathButtonEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DrawingPath", True))
        Me.DrawingPathButtonEdit.Location = New System.Drawing.Point(123, 95)
        Me.DrawingPathButtonEdit.Name = "DrawingPathButtonEdit"
        Me.DrawingPathButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DrawingPathButtonEdit.Size = New System.Drawing.Size(209, 20)
        Me.DrawingPathButtonEdit.StyleController = Me.dlcDrawings
        Me.DrawingPathButtonEdit.TabIndex = 12
        '
        'DrawingPictureEdit
        '
        Me.DrawingPictureEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DrawingPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Drawing", True))
        Me.DrawingPictureEdit.EditValue = resources.GetString("DrawingPictureEdit.EditValue")
        Me.DrawingPictureEdit.Location = New System.Drawing.Point(342, 5)
        Me.DrawingPictureEdit.Name = "DrawingPictureEdit"
        Me.DrawingPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.DrawingPictureEdit.Properties.ShowScrollBars = True
        Me.DrawingPictureEdit.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.DrawingPictureEdit.Size = New System.Drawing.Size(288, 248)
        Me.DrawingPictureEdit.StyleController = Me.dlcDrawings
        Me.DrawingPictureEdit.TabIndex = 15
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(123, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(209, 20)
        Me.DescriptionTextEdit.StyleController = Me.dlcDrawings
        Me.DescriptionTextEdit.TabIndex = 16
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IDTextEdit.StyleController = Me.dlcDrawings
        Me.IDTextEdit.TabIndex = 18
        '
        'ErrorTextEdit
        '
        Me.ErrorTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Error", True))
        Me.ErrorTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ErrorTextEdit.Name = "ErrorTextEdit"
        Me.ErrorTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ErrorTextEdit.StyleController = Me.dlcDrawings
        Me.ErrorTextEdit.TabIndex = 19
        '
        'NumberOfAnnotationsSpinEdit
        '
        Me.NumberOfAnnotationsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "NumberOfAnnotations", True))
        Me.NumberOfAnnotationsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumberOfAnnotationsSpinEdit.Location = New System.Drawing.Point(123, 65)
        Me.NumberOfAnnotationsSpinEdit.Name = "NumberOfAnnotationsSpinEdit"
        Me.NumberOfAnnotationsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.NumberOfAnnotationsSpinEdit.Size = New System.Drawing.Size(209, 20)
        Me.NumberOfAnnotationsSpinEdit.StyleController = Me.dlcDrawings
        Me.NumberOfAnnotationsSpinEdit.TabIndex = 17
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
        'ItemForError
        '
        Me.ItemForError.Control = Me.ErrorTextEdit
        Me.ItemForError.CustomizationFormText = "Error"
        Me.ItemForError.Location = New System.Drawing.Point(0, 0)
        Me.ItemForError.Name = "ItemForError"
        Me.ItemForError.Size = New System.Drawing.Size(0, 0)
        Me.ItemForError.Text = "Error"
        Me.ItemForError.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForError.TextToControlDistance = 5
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(635, 258)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription, Me.ItemForDrawing, Me.ItemForDrawingPath, Me.ItemForNumberOfAnnotations})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(635, 258)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(337, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForCode.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(337, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'ItemForDrawing
        '
        Me.ItemForDrawing.Control = Me.DrawingPictureEdit
        Me.ItemForDrawing.CustomizationFormText = "Drawing"
        Me.ItemForDrawing.Location = New System.Drawing.Point(337, 0)
        Me.ItemForDrawing.Name = "ItemForDrawing"
        Me.ItemForDrawing.Size = New System.Drawing.Size(298, 258)
        Me.ItemForDrawing.Text = "Drawing"
        Me.ItemForDrawing.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForDrawing.TextToControlDistance = 0
        Me.ItemForDrawing.TextVisible = False
        '
        'ItemForDrawingPath
        '
        Me.ItemForDrawingPath.Control = Me.DrawingPathButtonEdit
        Me.ItemForDrawingPath.CustomizationFormText = "Drawing Path"
        Me.ItemForDrawingPath.Location = New System.Drawing.Point(0, 90)
        Me.ItemForDrawingPath.Name = "ItemForDrawingPath"
        Me.ItemForDrawingPath.Size = New System.Drawing.Size(337, 168)
        Me.ItemForDrawingPath.Text = "Drawing Path"
        Me.ItemForDrawingPath.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForDrawingPath.TextToControlDistance = 5
        '
        'ItemForNumberOfAnnotations
        '
        Me.ItemForNumberOfAnnotations.Control = Me.NumberOfAnnotationsSpinEdit
        Me.ItemForNumberOfAnnotations.CustomizationFormText = "Number Of Annotations"
        Me.ItemForNumberOfAnnotations.Location = New System.Drawing.Point(0, 60)
        Me.ItemForNumberOfAnnotations.Name = "ItemForNumberOfAnnotations"
        Me.ItemForNumberOfAnnotations.Size = New System.Drawing.Size(337, 30)
        Me.ItemForNumberOfAnnotations.Text = "Number Of Annotations"
        Me.ItemForNumberOfAnnotations.TextSize = New System.Drawing.Size(113, 13)
        Me.ItemForNumberOfAnnotations.TextToControlDistance = 5
        '
        'btView
        '
        Me.btView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btView.Location = New System.Drawing.Point(415, 300)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(75, 23)
        Me.btView.TabIndex = 3
        Me.btView.Text = "View"
        '
        'xaeDrawing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 335)
        Me.Controls.Add(Me.btView)
        Me.MaximizeBox = True
        Me.Name = "xaeDrawing"
        Me.Text = "Drawing"
        Me.Controls.SetChildIndex(Me.btView, 0)
        Me.Controls.SetChildIndex(Me.btSave, 0)
        Me.Controls.SetChildIndex(Me.btCancel, 0)
        Me.Controls.SetChildIndex(Me.grpGroup, 0)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dlcDrawings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dlcDrawings.ResumeLayout(False)
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingPathButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawingPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberOfAnnotationsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDrawingPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNumberOfAnnotations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dlcDrawings As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DrawingPathButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ItemForDrawingPath As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DrawingPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForDrawing As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ErrorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NumberOfAnnotationsSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForError As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNumberOfAnnotations As DevExpress.XtraLayout.LayoutControlItem
End Class
