<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeLookup
    Inherits Checklist.GUI.xaegLookup

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
        Me.DataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.gcLookupValues = New DevExpress.XtraGrid.GridControl()
        Me.LookupValuesBindingSource = New System.Windows.Forms.BindingSource()
        Me.gvLookupValues = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UssSSLookupValuesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UssChecklistTasksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsLoadingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsChangedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PropertiesValidationErrorMessagesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForUssSSLookupValues = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUssChecklistTasks = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsLoading = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsChanged = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPropertiesValidationErrorMessages = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForValues = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLookup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colError = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl.SuspendLayout()
        CType(Me.gcLookupValues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupValuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLookupValues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UssSSLookupValuesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UssChecklistTasksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUssSSLookupValues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUssChecklistTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.DataLayoutControl)
        Me.grpGroup.Size = New System.Drawing.Size(725, 419)
        Me.grpGroup.Text = "Lookup"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(582, 438)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(663, 438)
        '
        'DataLayoutControl
        '
        Me.DataLayoutControl.Controls.Add(Me.gcLookupValues)
        Me.DataLayoutControl.Controls.Add(Me.CodeTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.DescriptionTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.UssSSLookupValuesTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.UssChecklistTasksTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.IDTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.IsLoadingCheckEdit)
        Me.DataLayoutControl.Controls.Add(Me.IsChangedCheckEdit)
        Me.DataLayoutControl.Controls.Add(Me.ValidationErrorMessagesTextEdit)
        Me.DataLayoutControl.Controls.Add(Me.PropertiesValidationErrorMessagesTextEdit)
        Me.DataLayoutControl.DataSource = Me.BindingSource
        Me.DataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForUssSSLookupValues, Me.ItemForUssChecklistTasks, Me.ItemForID, Me.ItemForIsLoading, Me.ItemForIsChanged, Me.ItemForValidationErrorMessages, Me.ItemForPropertiesValidationErrorMessages})
        Me.DataLayoutControl.Location = New System.Drawing.Point(2, 21)
        Me.DataLayoutControl.Name = "DataLayoutControl"
        Me.DataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(303, 244, 250, 350)
        Me.DataLayoutControl.OptionsView.UseSkinIndents = False
        Me.DataLayoutControl.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl.Size = New System.Drawing.Size(721, 396)
        Me.DataLayoutControl.TabIndex = 0
        Me.DataLayoutControl.Text = "DataLayoutControl1"
        '
        'gcLookupValues
        '
        Me.gcLookupValues.CausesValidation = False
        Me.gcLookupValues.DataSource = Me.LookupValuesBindingSource
        Me.gcLookupValues.Location = New System.Drawing.Point(5, 83)
        Me.gcLookupValues.MainView = Me.gvLookupValues
        Me.gcLookupValues.Name = "gcLookupValues"
        Me.gcLookupValues.Size = New System.Drawing.Size(711, 308)
        Me.gcLookupValues.TabIndex = 13
        Me.gcLookupValues.UseEmbeddedNavigator = True
        Me.gcLookupValues.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLookupValues})
        '
        'LookupValuesBindingSource
        '
        Me.LookupValuesBindingSource.DataMember = "LookupValues"
        Me.LookupValuesBindingSource.DataSource = Me.BindingSource
        '
        'gvLookupValues
        '
        Me.gvLookupValues.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode2, Me.colDescription2})
        Me.gvLookupValues.CustomizationFormBounds = New System.Drawing.Rectangle(565, 436, 216, 185)
        Me.gvLookupValues.GridControl = Me.gcLookupValues
        Me.gvLookupValues.Name = "gvLookupValues"
        Me.gvLookupValues.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvLookupValues.OptionsView.ShowGroupPanel = False
        Me.gvLookupValues.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDescription2, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCode2
        '
        Me.colCode2.FieldName = "Code"
        Me.colCode2.Name = "colCode2"
        Me.colCode2.Visible = True
        Me.colCode2.VisibleIndex = 0
        '
        'colDescription2
        '
        Me.colDescription2.FieldName = "Description"
        Me.colDescription2.Name = "colDescription2"
        Me.colDescription2.Visible = True
        Me.colDescription2.VisibleIndex = 1
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(63, 5)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Size = New System.Drawing.Size(653, 20)
        Me.CodeTextEdit.StyleController = Me.DataLayoutControl
        Me.CodeTextEdit.TabIndex = 4
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(63, 35)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(653, 20)
        Me.DescriptionTextEdit.StyleController = Me.DataLayoutControl
        Me.DescriptionTextEdit.TabIndex = 5
        '
        'UssSSLookupValuesTextEdit
        '
        Me.UssSSLookupValuesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UssSSLookupValues", True))
        Me.UssSSLookupValuesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UssSSLookupValuesTextEdit.Name = "UssSSLookupValuesTextEdit"
        Me.UssSSLookupValuesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UssSSLookupValuesTextEdit.StyleController = Me.DataLayoutControl
        Me.UssSSLookupValuesTextEdit.TabIndex = 6
        '
        'UssChecklistTasksTextEdit
        '
        Me.UssChecklistTasksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UssChecklistTasks", True))
        Me.UssChecklistTasksTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UssChecklistTasksTextEdit.Name = "UssChecklistTasksTextEdit"
        Me.UssChecklistTasksTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UssChecklistTasksTextEdit.StyleController = Me.DataLayoutControl
        Me.UssChecklistTasksTextEdit.TabIndex = 7
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IDTextEdit.StyleController = Me.DataLayoutControl
        Me.IDTextEdit.TabIndex = 8
        '
        'IsLoadingCheckEdit
        '
        Me.IsLoadingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsLoading", True))
        Me.IsLoadingCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsLoadingCheckEdit.Name = "IsLoadingCheckEdit"
        Me.IsLoadingCheckEdit.Properties.Caption = "Is Loading"
        Me.IsLoadingCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsLoadingCheckEdit.StyleController = Me.DataLayoutControl
        Me.IsLoadingCheckEdit.TabIndex = 9
        '
        'IsChangedCheckEdit
        '
        Me.IsChangedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsChanged", True))
        Me.IsChangedCheckEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsChangedCheckEdit.Name = "IsChangedCheckEdit"
        Me.IsChangedCheckEdit.Properties.Caption = "Is Changed"
        Me.IsChangedCheckEdit.Size = New System.Drawing.Size(0, 19)
        Me.IsChangedCheckEdit.StyleController = Me.DataLayoutControl
        Me.IsChangedCheckEdit.TabIndex = 10
        '
        'ValidationErrorMessagesTextEdit
        '
        Me.ValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidationErrorMessages", True))
        Me.ValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ValidationErrorMessagesTextEdit.Name = "ValidationErrorMessagesTextEdit"
        Me.ValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ValidationErrorMessagesTextEdit.StyleController = Me.DataLayoutControl
        Me.ValidationErrorMessagesTextEdit.TabIndex = 11
        '
        'PropertiesValidationErrorMessagesTextEdit
        '
        Me.PropertiesValidationErrorMessagesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PropertiesValidationErrorMessages", True))
        Me.PropertiesValidationErrorMessagesTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesValidationErrorMessagesTextEdit.Name = "PropertiesValidationErrorMessagesTextEdit"
        Me.PropertiesValidationErrorMessagesTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.PropertiesValidationErrorMessagesTextEdit.StyleController = Me.DataLayoutControl
        Me.PropertiesValidationErrorMessagesTextEdit.TabIndex = 12
        '
        'ItemForUssSSLookupValues
        '
        Me.ItemForUssSSLookupValues.Control = Me.UssSSLookupValuesTextEdit
        Me.ItemForUssSSLookupValues.CustomizationFormText = "Uss SS Lookup Values"
        Me.ItemForUssSSLookupValues.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUssSSLookupValues.Name = "ItemForUssSSLookupValues"
        Me.ItemForUssSSLookupValues.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUssSSLookupValues.Text = "Uss SS Lookup Values"
        Me.ItemForUssSSLookupValues.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUssSSLookupValues.TextToControlDistance = 5
        '
        'ItemForUssChecklistTasks
        '
        Me.ItemForUssChecklistTasks.Control = Me.UssChecklistTasksTextEdit
        Me.ItemForUssChecklistTasks.CustomizationFormText = "Uss Checklist Tasks"
        Me.ItemForUssChecklistTasks.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUssChecklistTasks.Name = "ItemForUssChecklistTasks"
        Me.ItemForUssChecklistTasks.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUssChecklistTasks.Text = "Uss Checklist Tasks"
        Me.ItemForUssChecklistTasks.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUssChecklistTasks.TextToControlDistance = 5
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
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(721, 396)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCode, Me.ItemForDescription})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(721, 60)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCode
        '
        Me.ItemForCode.Control = Me.CodeTextEdit
        Me.ItemForCode.CustomizationFormText = "Code"
        Me.ItemForCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCode.Name = "ItemForCode"
        Me.ItemForCode.Size = New System.Drawing.Size(721, 30)
        Me.ItemForCode.Text = "Code"
        Me.ItemForCode.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForCode.TextToControlDistance = 5
        '
        'ItemForDescription
        '
        Me.ItemForDescription.Control = Me.DescriptionTextEdit
        Me.ItemForDescription.CustomizationFormText = "Description"
        Me.ItemForDescription.Location = New System.Drawing.Point(0, 30)
        Me.ItemForDescription.Name = "ItemForDescription"
        Me.ItemForDescription.Size = New System.Drawing.Size(721, 30)
        Me.ItemForDescription.Text = "Description"
        Me.ItemForDescription.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForDescription.TextToControlDistance = 5
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AllowDrawBackground = False
        Me.LayoutControlGroup3.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForValues})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlGroup3.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup3.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(721, 336)
        Me.LayoutControlGroup3.Text = "autoGeneratedGroup0"
        '
        'ItemForValues
        '
        Me.ItemForValues.Control = Me.gcLookupValues
        Me.ItemForValues.CustomizationFormText = "Values"
        Me.ItemForValues.Location = New System.Drawing.Point(0, 0)
        Me.ItemForValues.Name = "ItemForValues"
        Me.ItemForValues.Size = New System.Drawing.Size(721, 336)
        Me.ItemForValues.Text = "Values"
        Me.ItemForValues.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForValues.TextSize = New System.Drawing.Size(53, 13)
        Me.ItemForValues.TextToControlDistance = 5
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        '
        'colCode1
        '
        Me.colCode1.FieldName = "Code"
        Me.colCode1.Name = "colCode1"
        Me.colCode1.Visible = True
        Me.colCode1.VisibleIndex = 0
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 1
        '
        'colLookup
        '
        Me.colLookup.FieldName = "Lookup"
        Me.colLookup.Name = "colLookup"
        Me.colLookup.Visible = True
        Me.colLookup.VisibleIndex = 2
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 3
        '
        'colError
        '
        Me.colError.FieldName = "Error"
        Me.colError.Name = "colError"
        Me.colError.OptionsColumn.ReadOnly = True
        Me.colError.Visible = True
        Me.colError.VisibleIndex = 4
        '
        'xaeLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 473)
        Me.Name = "xaeLookup"
        Me.Text = "Lookup"
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl.ResumeLayout(False)
        CType(Me.gcLookupValues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupValuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLookupValues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UssSSLookupValuesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UssChecklistTasksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsLoadingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsChangedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesValidationErrorMessagesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUssSSLookupValues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUssChecklistTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsChanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPropertiesValidationErrorMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UssSSLookupValuesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UssChecklistTasksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsLoadingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsChangedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PropertiesValidationErrorMessagesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForUssSSLookupValues As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUssChecklistTasks As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsLoading As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsChanged As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPropertiesValidationErrorMessages As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LookupValuesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gcLookupValues As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLookupValues As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemForValues As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLookup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colError As DevExpress.XtraGrid.Columns.GridColumn
End Class
