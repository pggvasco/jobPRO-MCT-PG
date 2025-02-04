<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xaeJobNotes
    Inherits UniSource.ShopFloor.GUI.xaegJobNotes

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
        Me.DataLayoutControl2 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.NextStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PreviousStageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.JobNoteListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvJobNotes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
        Me.colCreateDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEditUserDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobStage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreateUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.UnitPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TotalCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TotalPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuantityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuantityDeliveredTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DeliveryNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrderNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JobDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuoteDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.InvoiceDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AcceptedDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstimatedDeliveryDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CancelledDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstimatedStartDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstimatedEndDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ActualStartDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ActualEndDateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ValidityDaysTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DeliveryDaysTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsTemplateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForNextStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPreviousStage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnitCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnitPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTotalCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTotalPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuantity = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuantityDelivered = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrderNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJobDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForQuoteDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForInvoiceDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAcceptedDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedDeliveryDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCancelledDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstimatedEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActualStartDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForActualEndDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForValidityDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeliveryDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsTemplate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCustomer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAddLine = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditLine = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GridPopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl2.SuspendLayout()
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobNoteListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityDeliveredTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcceptedDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedDeliveryDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelledDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatedEndDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualEndDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidityDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsTemplateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPreviousStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTotalPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuantityDelivered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrderNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForQuoteDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAcceptedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCancelledDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstimatedEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActualStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForActualEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForValidityDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeliveryDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grpGroup.Controls.Add(Me.DataLayoutControl2)
        Me.grpGroup.Location = New System.Drawing.Point(0, 28)
        Me.grpGroup.ShowCaption = False
        Me.grpGroup.Size = New System.Drawing.Size(704, 297)
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(536, 331)
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(617, 331)
        '
        'DataLayoutControl2
        '
        Me.DataLayoutControl2.Controls.Add(Me.NextStageTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.PreviousStageTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.CustomerTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.UnitCostTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.GridControl2)
        Me.DataLayoutControl2.Controls.Add(Me.UnitPriceTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.TotalCostTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.TotalPriceTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.QuantityTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.QuantityDeliveredTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.DeliveryNumberTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.OrderNumberTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.JobDateTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.QuoteDateTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.InvoiceDateTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.AcceptedDateTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.EstimatedDeliveryDateTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.CancelledDateTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.EstimatedStartDateTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.EstimatedEndDateTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.ActualStartDateTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.ActualEndDateTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.ValidityDaysTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.DeliveryDaysTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.IsTemplateTextEdit)
        Me.DataLayoutControl2.DataMember = Nothing
        Me.DataLayoutControl2.DataSource = Me.BindingSource
        Me.DataLayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForNextStage, Me.ItemForPreviousStage, Me.ItemForUnitCost, Me.ItemForUnitPrice, Me.ItemForTotalCost, Me.ItemForTotalPrice, Me.ItemForQuantity, Me.ItemForQuantityDelivered, Me.ItemForDeliveryNumber, Me.ItemForOrderNumber, Me.ItemForJobDate, Me.ItemForQuoteDate, Me.ItemForInvoiceDate, Me.ItemForAcceptedDate, Me.ItemForEstimatedDeliveryDate, Me.ItemForCancelledDate, Me.ItemForEstimatedStartDate, Me.ItemForEstimatedEndDate, Me.ItemForActualStartDate, Me.ItemForActualEndDate, Me.ItemForValidityDays, Me.ItemForDeliveryDays, Me.ItemForIsTemplate, Me.LayoutControlGroup6, Me.LayoutControlGroup7, Me.LayoutControlGroup8, Me.LayoutControlGroup5})
        Me.DataLayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl2.Name = "DataLayoutControl2"
        Me.DataLayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(902, 134, 250, 350)
        Me.DataLayoutControl2.Root = Me.LayoutControlGroup3
        Me.DataLayoutControl2.Size = New System.Drawing.Size(704, 297)
        Me.DataLayoutControl2.TabIndex = 0
        Me.DataLayoutControl2.Text = "DataLayoutControl2"
        '
        'NextStageTextEdit
        '
        Me.NextStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "NextStage", True))
        Me.NextStageTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.NextStageTextEdit.Name = "NextStageTextEdit"
        Me.NextStageTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.NextStageTextEdit.StyleController = Me.DataLayoutControl2
        Me.NextStageTextEdit.TabIndex = 14
        '
        'PreviousStageTextEdit
        '
        Me.PreviousStageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "PreviousStage", True))
        Me.PreviousStageTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.PreviousStageTextEdit.Name = "PreviousStageTextEdit"
        Me.PreviousStageTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.PreviousStageTextEdit.StyleController = Me.DataLayoutControl2
        Me.PreviousStageTextEdit.TabIndex = 15
        '
        'CustomerTextEdit
        '
        Me.CustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Customer", True))
        Me.CustomerTextEdit.Location = New System.Drawing.Point(51, 2)
        Me.CustomerTextEdit.Name = "CustomerTextEdit"
        Me.CustomerTextEdit.Size = New System.Drawing.Size(651, 20)
        Me.CustomerTextEdit.StyleController = Me.DataLayoutControl2
        Me.CustomerTextEdit.TabIndex = 16
        '
        'UnitCostTextEdit
        '
        Me.UnitCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UnitCost", True))
        Me.UnitCostTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UnitCostTextEdit.Name = "UnitCostTextEdit"
        Me.UnitCostTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UnitCostTextEdit.StyleController = Me.DataLayoutControl2
        Me.UnitCostTextEdit.TabIndex = 18
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.JobNoteListBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(2, 26)
        Me.GridControl2.MainView = Me.gvJobNotes
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemRichTextEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(700, 269)
        Me.GridControl2.TabIndex = 41
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobNotes})
        '
        'JobNoteListBindingSource
        '
        Me.JobNoteListBindingSource.DataMember = "JobNoteList"
        Me.JobNoteListBindingSource.DataSource = Me.BindingSource
        '
        'gvJobNotes
        '
        Me.gvJobNotes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNote, Me.colCreateDate, Me.colEditUserDate, Me.colJobStage, Me.colCreateUser})
        Me.gvJobNotes.GridControl = Me.GridControl2
        Me.gvJobNotes.Name = "gvJobNotes"
        Me.gvJobNotes.OptionsBehavior.ReadOnly = True
        '
        'colNote
        '
        Me.colNote.ColumnEdit = Me.RepositoryItemRichTextEdit1
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        Me.colNote.Visible = True
        Me.colNote.VisibleIndex = 1
        '
        'RepositoryItemRichTextEdit1
        '
        Me.RepositoryItemRichTextEdit1.Name = "RepositoryItemRichTextEdit1"
        Me.RepositoryItemRichTextEdit1.ShowCaretInReadOnly = False
        '
        'colCreateDate
        '
        Me.colCreateDate.DisplayFormat.FormatString = "l"
        Me.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colCreateDate.FieldName = "CreateDate"
        Me.colCreateDate.Name = "colCreateDate"
        Me.colCreateDate.Visible = True
        Me.colCreateDate.VisibleIndex = 2
        '
        'colEditUserDate
        '
        Me.colEditUserDate.DisplayFormat.FormatString = "l"
        Me.colEditUserDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colEditUserDate.FieldName = "EditUserDate"
        Me.colEditUserDate.Name = "colEditUserDate"
        Me.colEditUserDate.Visible = True
        Me.colEditUserDate.VisibleIndex = 3
        '
        'colJobStage
        '
        Me.colJobStage.FieldName = "JobStage"
        Me.colJobStage.Name = "colJobStage"
        Me.colJobStage.Visible = True
        Me.colJobStage.VisibleIndex = 0
        '
        'colCreateUser
        '
        Me.colCreateUser.Caption = "Create User"
        Me.colCreateUser.FieldName = "CreateUser.CDisplayName"
        Me.colCreateUser.Name = "colCreateUser"
        Me.colCreateUser.OptionsColumn.AllowEdit = False
        Me.colCreateUser.OptionsColumn.ReadOnly = True
        Me.colCreateUser.Visible = True
        Me.colCreateUser.VisibleIndex = 4
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'UnitPriceTextEdit
        '
        Me.UnitPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "UnitPrice", True))
        Me.UnitPriceTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.UnitPriceTextEdit.Name = "UnitPriceTextEdit"
        Me.UnitPriceTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.UnitPriceTextEdit.StyleController = Me.DataLayoutControl2
        Me.UnitPriceTextEdit.TabIndex = 19
        '
        'TotalCostTextEdit
        '
        Me.TotalCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "TotalCost", True))
        Me.TotalCostTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.TotalCostTextEdit.Name = "TotalCostTextEdit"
        Me.TotalCostTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.TotalCostTextEdit.StyleController = Me.DataLayoutControl2
        Me.TotalCostTextEdit.TabIndex = 20
        '
        'TotalPriceTextEdit
        '
        Me.TotalPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "TotalPrice", True))
        Me.TotalPriceTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.TotalPriceTextEdit.Name = "TotalPriceTextEdit"
        Me.TotalPriceTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.TotalPriceTextEdit.StyleController = Me.DataLayoutControl2
        Me.TotalPriceTextEdit.TabIndex = 21
        '
        'QuantityTextEdit
        '
        Me.QuantityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "Quantity", True))
        Me.QuantityTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.QuantityTextEdit.Name = "QuantityTextEdit"
        Me.QuantityTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.QuantityTextEdit.StyleController = Me.DataLayoutControl2
        Me.QuantityTextEdit.TabIndex = 22
        '
        'QuantityDeliveredTextEdit
        '
        Me.QuantityDeliveredTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuantityDelivered", True))
        Me.QuantityDeliveredTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.QuantityDeliveredTextEdit.Name = "QuantityDeliveredTextEdit"
        Me.QuantityDeliveredTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.QuantityDeliveredTextEdit.StyleController = Me.DataLayoutControl2
        Me.QuantityDeliveredTextEdit.TabIndex = 23
        '
        'DeliveryNumberTextEdit
        '
        Me.DeliveryNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DeliveryNumber", True))
        Me.DeliveryNumberTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.DeliveryNumberTextEdit.Name = "DeliveryNumberTextEdit"
        Me.DeliveryNumberTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.DeliveryNumberTextEdit.StyleController = Me.DataLayoutControl2
        Me.DeliveryNumberTextEdit.TabIndex = 26
        '
        'OrderNumberTextEdit
        '
        Me.OrderNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "OrderNumber", True))
        Me.OrderNumberTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.OrderNumberTextEdit.Name = "OrderNumberTextEdit"
        Me.OrderNumberTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.OrderNumberTextEdit.StyleController = Me.DataLayoutControl2
        Me.OrderNumberTextEdit.TabIndex = 27
        '
        'JobDateTextEdit
        '
        Me.JobDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "JobDate", True))
        Me.JobDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.JobDateTextEdit.Name = "JobDateTextEdit"
        Me.JobDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.JobDateTextEdit.StyleController = Me.DataLayoutControl2
        Me.JobDateTextEdit.TabIndex = 28
        '
        'QuoteDateTextEdit
        '
        Me.QuoteDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "QuoteDate", True))
        Me.QuoteDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.QuoteDateTextEdit.Name = "QuoteDateTextEdit"
        Me.QuoteDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.QuoteDateTextEdit.StyleController = Me.DataLayoutControl2
        Me.QuoteDateTextEdit.TabIndex = 29
        '
        'InvoiceDateTextEdit
        '
        Me.InvoiceDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "InvoiceDate", True))
        Me.InvoiceDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.InvoiceDateTextEdit.Name = "InvoiceDateTextEdit"
        Me.InvoiceDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.InvoiceDateTextEdit.StyleController = Me.DataLayoutControl2
        Me.InvoiceDateTextEdit.TabIndex = 30
        '
        'AcceptedDateTextEdit
        '
        Me.AcceptedDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "AcceptedDate", True))
        Me.AcceptedDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.AcceptedDateTextEdit.Name = "AcceptedDateTextEdit"
        Me.AcceptedDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.AcceptedDateTextEdit.StyleController = Me.DataLayoutControl2
        Me.AcceptedDateTextEdit.TabIndex = 31
        '
        'EstimatedDeliveryDateTextEdit
        '
        Me.EstimatedDeliveryDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EstimatedDeliveryDate", True))
        Me.EstimatedDeliveryDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.EstimatedDeliveryDateTextEdit.Name = "EstimatedDeliveryDateTextEdit"
        Me.EstimatedDeliveryDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.EstimatedDeliveryDateTextEdit.StyleController = Me.DataLayoutControl2
        Me.EstimatedDeliveryDateTextEdit.TabIndex = 32
        '
        'CancelledDateTextEdit
        '
        Me.CancelledDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "CancelledDate", True))
        Me.CancelledDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.CancelledDateTextEdit.Name = "CancelledDateTextEdit"
        Me.CancelledDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.CancelledDateTextEdit.StyleController = Me.DataLayoutControl2
        Me.CancelledDateTextEdit.TabIndex = 33
        '
        'EstimatedStartDateTextEdit
        '
        Me.EstimatedStartDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EstimatedStartDate", True))
        Me.EstimatedStartDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.EstimatedStartDateTextEdit.Name = "EstimatedStartDateTextEdit"
        Me.EstimatedStartDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.EstimatedStartDateTextEdit.StyleController = Me.DataLayoutControl2
        Me.EstimatedStartDateTextEdit.TabIndex = 34
        '
        'EstimatedEndDateTextEdit
        '
        Me.EstimatedEndDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "EstimatedEndDate", True))
        Me.EstimatedEndDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.EstimatedEndDateTextEdit.Name = "EstimatedEndDateTextEdit"
        Me.EstimatedEndDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.EstimatedEndDateTextEdit.StyleController = Me.DataLayoutControl2
        Me.EstimatedEndDateTextEdit.TabIndex = 35
        '
        'ActualStartDateTextEdit
        '
        Me.ActualStartDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ActualStartDate", True))
        Me.ActualStartDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ActualStartDateTextEdit.Name = "ActualStartDateTextEdit"
        Me.ActualStartDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ActualStartDateTextEdit.StyleController = Me.DataLayoutControl2
        Me.ActualStartDateTextEdit.TabIndex = 36
        '
        'ActualEndDateTextEdit
        '
        Me.ActualEndDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ActualEndDate", True))
        Me.ActualEndDateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ActualEndDateTextEdit.Name = "ActualEndDateTextEdit"
        Me.ActualEndDateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ActualEndDateTextEdit.StyleController = Me.DataLayoutControl2
        Me.ActualEndDateTextEdit.TabIndex = 37
        '
        'ValidityDaysTextEdit
        '
        Me.ValidityDaysTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "ValidityDays", True))
        Me.ValidityDaysTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ValidityDaysTextEdit.Name = "ValidityDaysTextEdit"
        Me.ValidityDaysTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ValidityDaysTextEdit.StyleController = Me.DataLayoutControl2
        Me.ValidityDaysTextEdit.TabIndex = 38
        '
        'DeliveryDaysTextEdit
        '
        Me.DeliveryDaysTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "DeliveryDays", True))
        Me.DeliveryDaysTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.DeliveryDaysTextEdit.Name = "DeliveryDaysTextEdit"
        Me.DeliveryDaysTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.DeliveryDaysTextEdit.StyleController = Me.DataLayoutControl2
        Me.DeliveryDaysTextEdit.TabIndex = 39
        '
        'IsTemplateTextEdit
        '
        Me.IsTemplateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource, "IsTemplate", True))
        Me.IsTemplateTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IsTemplateTextEdit.Name = "IsTemplateTextEdit"
        Me.IsTemplateTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IsTemplateTextEdit.StyleController = Me.DataLayoutControl2
        Me.IsTemplateTextEdit.TabIndex = 40
        '
        'ItemForNextStage
        '
        Me.ItemForNextStage.Control = Me.NextStageTextEdit
        Me.ItemForNextStage.CustomizationFormText = "Next Stage"
        Me.ItemForNextStage.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNextStage.Name = "ItemForNextStage"
        Me.ItemForNextStage.Size = New System.Drawing.Size(0, 0)
        Me.ItemForNextStage.Text = "Next Stage"
        Me.ItemForNextStage.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForNextStage.TextToControlDistance = 5
        '
        'ItemForPreviousStage
        '
        Me.ItemForPreviousStage.Control = Me.PreviousStageTextEdit
        Me.ItemForPreviousStage.CustomizationFormText = "Previous Stage"
        Me.ItemForPreviousStage.Location = New System.Drawing.Point(0, 0)
        Me.ItemForPreviousStage.Name = "ItemForPreviousStage"
        Me.ItemForPreviousStage.Size = New System.Drawing.Size(0, 0)
        Me.ItemForPreviousStage.Text = "Previous Stage"
        Me.ItemForPreviousStage.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForPreviousStage.TextToControlDistance = 5
        '
        'ItemForUnitCost
        '
        Me.ItemForUnitCost.Control = Me.UnitCostTextEdit
        Me.ItemForUnitCost.CustomizationFormText = "Unit Cost"
        Me.ItemForUnitCost.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUnitCost.Name = "ItemForUnitCost"
        Me.ItemForUnitCost.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUnitCost.Text = "Unit Cost"
        Me.ItemForUnitCost.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUnitCost.TextToControlDistance = 5
        '
        'ItemForUnitPrice
        '
        Me.ItemForUnitPrice.Control = Me.UnitPriceTextEdit
        Me.ItemForUnitPrice.CustomizationFormText = "Unit Price"
        Me.ItemForUnitPrice.Location = New System.Drawing.Point(0, 0)
        Me.ItemForUnitPrice.Name = "ItemForUnitPrice"
        Me.ItemForUnitPrice.Size = New System.Drawing.Size(0, 0)
        Me.ItemForUnitPrice.Text = "Unit Price"
        Me.ItemForUnitPrice.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForUnitPrice.TextToControlDistance = 5
        '
        'ItemForTotalCost
        '
        Me.ItemForTotalCost.Control = Me.TotalCostTextEdit
        Me.ItemForTotalCost.CustomizationFormText = "Total Cost"
        Me.ItemForTotalCost.Location = New System.Drawing.Point(0, 0)
        Me.ItemForTotalCost.Name = "ItemForTotalCost"
        Me.ItemForTotalCost.Size = New System.Drawing.Size(0, 0)
        Me.ItemForTotalCost.Text = "Total Cost"
        Me.ItemForTotalCost.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForTotalCost.TextToControlDistance = 5
        '
        'ItemForTotalPrice
        '
        Me.ItemForTotalPrice.Control = Me.TotalPriceTextEdit
        Me.ItemForTotalPrice.CustomizationFormText = "Total Price"
        Me.ItemForTotalPrice.Location = New System.Drawing.Point(0, 0)
        Me.ItemForTotalPrice.Name = "ItemForTotalPrice"
        Me.ItemForTotalPrice.Size = New System.Drawing.Size(0, 0)
        Me.ItemForTotalPrice.Text = "Total Price"
        Me.ItemForTotalPrice.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForTotalPrice.TextToControlDistance = 5
        '
        'ItemForQuantity
        '
        Me.ItemForQuantity.Control = Me.QuantityTextEdit
        Me.ItemForQuantity.CustomizationFormText = "Quantity"
        Me.ItemForQuantity.Location = New System.Drawing.Point(0, 0)
        Me.ItemForQuantity.Name = "ItemForQuantity"
        Me.ItemForQuantity.Size = New System.Drawing.Size(0, 0)
        Me.ItemForQuantity.Text = "Quantity"
        Me.ItemForQuantity.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForQuantity.TextToControlDistance = 5
        '
        'ItemForQuantityDelivered
        '
        Me.ItemForQuantityDelivered.Control = Me.QuantityDeliveredTextEdit
        Me.ItemForQuantityDelivered.CustomizationFormText = "Quantity Delivered"
        Me.ItemForQuantityDelivered.Location = New System.Drawing.Point(0, 0)
        Me.ItemForQuantityDelivered.Name = "ItemForQuantityDelivered"
        Me.ItemForQuantityDelivered.Size = New System.Drawing.Size(0, 0)
        Me.ItemForQuantityDelivered.Text = "Quantity Delivered"
        Me.ItemForQuantityDelivered.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForQuantityDelivered.TextToControlDistance = 5
        '
        'ItemForDeliveryNumber
        '
        Me.ItemForDeliveryNumber.Control = Me.DeliveryNumberTextEdit
        Me.ItemForDeliveryNumber.CustomizationFormText = "Delivery Number"
        Me.ItemForDeliveryNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForDeliveryNumber.Name = "ItemForDeliveryNumber"
        Me.ItemForDeliveryNumber.Size = New System.Drawing.Size(0, 0)
        Me.ItemForDeliveryNumber.Text = "Delivery Number"
        Me.ItemForDeliveryNumber.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForDeliveryNumber.TextToControlDistance = 5
        '
        'ItemForOrderNumber
        '
        Me.ItemForOrderNumber.Control = Me.OrderNumberTextEdit
        Me.ItemForOrderNumber.CustomizationFormText = "Order Number"
        Me.ItemForOrderNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOrderNumber.Name = "ItemForOrderNumber"
        Me.ItemForOrderNumber.Size = New System.Drawing.Size(0, 0)
        Me.ItemForOrderNumber.Text = "Order Number"
        Me.ItemForOrderNumber.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForOrderNumber.TextToControlDistance = 5
        '
        'ItemForJobDate
        '
        Me.ItemForJobDate.Control = Me.JobDateTextEdit
        Me.ItemForJobDate.CustomizationFormText = "Job Date"
        Me.ItemForJobDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJobDate.Name = "ItemForJobDate"
        Me.ItemForJobDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForJobDate.Text = "Job Date"
        Me.ItemForJobDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForJobDate.TextToControlDistance = 5
        '
        'ItemForQuoteDate
        '
        Me.ItemForQuoteDate.Control = Me.QuoteDateTextEdit
        Me.ItemForQuoteDate.CustomizationFormText = "Quote Date"
        Me.ItemForQuoteDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForQuoteDate.Name = "ItemForQuoteDate"
        Me.ItemForQuoteDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForQuoteDate.Text = "Quote Date"
        Me.ItemForQuoteDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForQuoteDate.TextToControlDistance = 5
        '
        'ItemForInvoiceDate
        '
        Me.ItemForInvoiceDate.Control = Me.InvoiceDateTextEdit
        Me.ItemForInvoiceDate.CustomizationFormText = "Invoice Date"
        Me.ItemForInvoiceDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForInvoiceDate.Name = "ItemForInvoiceDate"
        Me.ItemForInvoiceDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForInvoiceDate.Text = "Invoice Date"
        Me.ItemForInvoiceDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForInvoiceDate.TextToControlDistance = 5
        '
        'ItemForAcceptedDate
        '
        Me.ItemForAcceptedDate.Control = Me.AcceptedDateTextEdit
        Me.ItemForAcceptedDate.CustomizationFormText = "Accepted Date"
        Me.ItemForAcceptedDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForAcceptedDate.Name = "ItemForAcceptedDate"
        Me.ItemForAcceptedDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForAcceptedDate.Text = "Accepted Date"
        Me.ItemForAcceptedDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForAcceptedDate.TextToControlDistance = 5
        '
        'ItemForEstimatedDeliveryDate
        '
        Me.ItemForEstimatedDeliveryDate.Control = Me.EstimatedDeliveryDateTextEdit
        Me.ItemForEstimatedDeliveryDate.CustomizationFormText = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForEstimatedDeliveryDate.Name = "ItemForEstimatedDeliveryDate"
        Me.ItemForEstimatedDeliveryDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForEstimatedDeliveryDate.Text = "Estimated Delivery Date"
        Me.ItemForEstimatedDeliveryDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForEstimatedDeliveryDate.TextToControlDistance = 5
        '
        'ItemForCancelledDate
        '
        Me.ItemForCancelledDate.Control = Me.CancelledDateTextEdit
        Me.ItemForCancelledDate.CustomizationFormText = "Cancelled Date"
        Me.ItemForCancelledDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCancelledDate.Name = "ItemForCancelledDate"
        Me.ItemForCancelledDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForCancelledDate.Text = "Cancelled Date"
        Me.ItemForCancelledDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCancelledDate.TextToControlDistance = 5
        '
        'ItemForEstimatedStartDate
        '
        Me.ItemForEstimatedStartDate.Control = Me.EstimatedStartDateTextEdit
        Me.ItemForEstimatedStartDate.CustomizationFormText = "Estimated Start Date"
        Me.ItemForEstimatedStartDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForEstimatedStartDate.Name = "ItemForEstimatedStartDate"
        Me.ItemForEstimatedStartDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForEstimatedStartDate.Text = "Estimated Start Date"
        Me.ItemForEstimatedStartDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForEstimatedStartDate.TextToControlDistance = 5
        '
        'ItemForEstimatedEndDate
        '
        Me.ItemForEstimatedEndDate.Control = Me.EstimatedEndDateTextEdit
        Me.ItemForEstimatedEndDate.CustomizationFormText = "Estimated End Date"
        Me.ItemForEstimatedEndDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForEstimatedEndDate.Name = "ItemForEstimatedEndDate"
        Me.ItemForEstimatedEndDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForEstimatedEndDate.Text = "Estimated End Date"
        Me.ItemForEstimatedEndDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForEstimatedEndDate.TextToControlDistance = 5
        '
        'ItemForActualStartDate
        '
        Me.ItemForActualStartDate.Control = Me.ActualStartDateTextEdit
        Me.ItemForActualStartDate.CustomizationFormText = "Actual Start Date"
        Me.ItemForActualStartDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForActualStartDate.Name = "ItemForActualStartDate"
        Me.ItemForActualStartDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForActualStartDate.Text = "Actual Start Date"
        Me.ItemForActualStartDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForActualStartDate.TextToControlDistance = 5
        '
        'ItemForActualEndDate
        '
        Me.ItemForActualEndDate.Control = Me.ActualEndDateTextEdit
        Me.ItemForActualEndDate.CustomizationFormText = "Actual End Date"
        Me.ItemForActualEndDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForActualEndDate.Name = "ItemForActualEndDate"
        Me.ItemForActualEndDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForActualEndDate.Text = "Actual End Date"
        Me.ItemForActualEndDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForActualEndDate.TextToControlDistance = 5
        '
        'ItemForValidityDays
        '
        Me.ItemForValidityDays.Control = Me.ValidityDaysTextEdit
        Me.ItemForValidityDays.CustomizationFormText = "Validity Days"
        Me.ItemForValidityDays.Location = New System.Drawing.Point(0, 0)
        Me.ItemForValidityDays.Name = "ItemForValidityDays"
        Me.ItemForValidityDays.Size = New System.Drawing.Size(0, 0)
        Me.ItemForValidityDays.Text = "Validity Days"
        Me.ItemForValidityDays.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForValidityDays.TextToControlDistance = 5
        '
        'ItemForDeliveryDays
        '
        Me.ItemForDeliveryDays.Control = Me.DeliveryDaysTextEdit
        Me.ItemForDeliveryDays.CustomizationFormText = "Delivery Days"
        Me.ItemForDeliveryDays.Location = New System.Drawing.Point(0, 0)
        Me.ItemForDeliveryDays.Name = "ItemForDeliveryDays"
        Me.ItemForDeliveryDays.Size = New System.Drawing.Size(0, 0)
        Me.ItemForDeliveryDays.Text = "Delivery Days"
        Me.ItemForDeliveryDays.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForDeliveryDays.TextToControlDistance = 5
        '
        'ItemForIsTemplate
        '
        Me.ItemForIsTemplate.Control = Me.IsTemplateTextEdit
        Me.ItemForIsTemplate.CustomizationFormText = "Is Template"
        Me.ItemForIsTemplate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIsTemplate.Name = "ItemForIsTemplate"
        Me.ItemForIsTemplate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIsTemplate.Text = "Is Template"
        Me.ItemForIsTemplate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForIsTemplate.TextToControlDistance = 5
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.AllowDrawBackground = False
        Me.LayoutControlGroup6.CustomizationFormText = "autoGeneratedGroup1"
        Me.LayoutControlGroup6.GroupBordersVisible = False
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 121)
        Me.LayoutControlGroup6.Name = "autoGeneratedGroup1"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(647, 83)
        Me.LayoutControlGroup6.Text = "autoGeneratedGroup1"
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.AllowDrawBackground = False
        Me.LayoutControlGroup7.CustomizationFormText = "autoGeneratedGroup2"
        Me.LayoutControlGroup7.GroupBordersVisible = False
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 121)
        Me.LayoutControlGroup7.Name = "autoGeneratedGroup2"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(647, 165)
        Me.LayoutControlGroup7.Text = "autoGeneratedGroup2"
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.AllowDrawBackground = False
        Me.LayoutControlGroup8.CustomizationFormText = "autoGeneratedGroup3"
        Me.LayoutControlGroup8.GroupBordersVisible = False
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 121)
        Me.LayoutControlGroup8.Name = "autoGeneratedGroup3"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(647, 170)
        Me.LayoutControlGroup8.Text = "autoGeneratedGroup3"
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.AllowDrawBackground = False
        Me.LayoutControlGroup5.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlGroup5.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(647, 142)
        Me.LayoutControlGroup5.Text = "autoGeneratedGroup0"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup4, Me.ItemForCustomer})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(704, 297)
        Me.LayoutControlGroup3.Text = "LayoutControlGroup3"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AllowDrawBackground = False
        Me.LayoutControlGroup4.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlGroup4.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(704, 273)
        Me.LayoutControlGroup4.Text = "autoGeneratedGroup0"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridControl2
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(704, 273)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'ItemForCustomer
        '
        Me.ItemForCustomer.Control = Me.CustomerTextEdit
        Me.ItemForCustomer.CustomizationFormText = "Customer"
        Me.ItemForCustomer.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCustomer.Name = "ItemForCustomer"
        Me.ItemForCustomer.Size = New System.Drawing.Size(704, 24)
        Me.ItemForCustomer.Text = "Customer"
        Me.ItemForCustomer.TextSize = New System.Drawing.Size(46, 13)
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiSave, Me.bbiAddLine, Me.bbiEditLine})
        Me.BarManager.MainMenu = Me.Bar2
        Me.BarManager.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAddLine), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditLine)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Id = 0
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiAddLine
        '
        Me.bbiAddLine.Caption = "Add Line"
        Me.bbiAddLine.Id = 1
        Me.bbiAddLine.Name = "bbiAddLine"
        '
        'bbiEditLine
        '
        Me.bbiEditLine.Caption = "Edit Line"
        Me.bbiEditLine.Id = 2
        Me.bbiEditLine.Name = "bbiEditLine"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(704, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 361)
        Me.barDockControlBottom.Size = New System.Drawing.Size(704, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 339)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(704, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 339)
        '
        'GridPopupMenu
        '
        Me.GridPopupMenu.Manager = Me.BarManager
        Me.GridPopupMenu.Name = "GridPopupMenu"
        '
        'xaeJobNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(704, 361)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = True
        Me.Name = "xaeJobNotes"
        Me.Text = "Job Notes"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.btCancel, 0)
        Me.Controls.SetChildIndex(Me.btSave, 0)
        Me.Controls.SetChildIndex(Me.grpGroup, 0)
        CType(Me.grpGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl2.ResumeLayout(False)
        CType(Me.NextStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousStageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobNoteListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityDeliveredTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcceptedDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedDeliveryDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelledDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatedEndDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualStartDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualEndDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidityDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDaysTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsTemplateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNextStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPreviousStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTotalCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTotalPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuantityDelivered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrderNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJobDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForQuoteDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAcceptedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCancelledDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstimatedEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActualStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForActualEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForValidityDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeliveryDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContentsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreateUserIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreateDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EditUserIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EditUserDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ErrorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForContents As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCreateUserID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCreateDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForEditUserID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEditUserDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJob As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForError As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataLayoutControl2 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents NextStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PreviousStageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitPriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalPriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuantityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuantityDeliveredTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliveryNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrderNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoteDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InvoiceDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AcceptedDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EstimatedDeliveryDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CancelledDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EstimatedStartDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EstimatedEndDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ActualStartDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ActualEndDateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ValidityDaysTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliveryDaysTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsTemplateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForNextStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPreviousStage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCustomer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUnitCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUnitPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTotalCost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTotalPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuantity As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuantityDelivered As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeliveryNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrderNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJobDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForQuoteDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForInvoiceDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAcceptedDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedDeliveryDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCancelledDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstimatedEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActualStartDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForActualEndDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForValidityDays As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeliveryDays As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIsTemplate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents JobNoteListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobNotes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEditUserDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobStage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridPopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAddLine As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditLine As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents colCreateUser As DevExpress.XtraGrid.Columns.GridColumn
End Class
