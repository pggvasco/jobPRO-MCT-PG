<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlChecklistOption
    Inherits UniSource.ShopFloor.Scheduler.Checklist.GUI.xlgChecklistOption

    'UserControl overrides dispose to clean up the component list.
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
        Me.gcChecklistOption = New DevExpress.XtraGrid.GridControl()
        Me.gvChecklistOption = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLongDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsForceValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDefaultValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentFileName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLookup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcChecklistOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChecklistOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(UniSource.ShopFloor.Scheduler.Checklist.API.ChecklistOption)
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcChecklistOption)
        Me.GridPanel.Location = New System.Drawing.Point(0, 53)
        Me.GridPanel.Size = New System.Drawing.Size(925, 506)
        '
        'gcChecklistOption
        '
        Me.gcChecklistOption.DataSource = Me.BindingSource
        Me.gcChecklistOption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcChecklistOption.Location = New System.Drawing.Point(0, 0)
        Me.gcChecklistOption.MainView = Me.gvChecklistOption
        Me.gcChecklistOption.MenuManager = Me.barManager
        Me.gcChecklistOption.Name = "gcChecklistOption"
        Me.gcChecklistOption.ShowOnlyPredefinedDetails = True
        Me.gcChecklistOption.Size = New System.Drawing.Size(925, 506)
        Me.gcChecklistOption.TabIndex = 0
        Me.gcChecklistOption.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChecklistOption})
        '
        'gvChecklistOption
        '
        Me.gvChecklistOption.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescription, Me.colLongDescription, Me.colIsForceValue, Me.colDefaultValue, Me.colCode, Me.colDataTypeID, Me.colDocumentFileName, Me.colLookup, Me.colID})
        Me.gvChecklistOption.GridControl = Me.gcChecklistOption
        Me.gvChecklistOption.Name = "gvChecklistOption"
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        '
        'colLongDescription
        '
        Me.colLongDescription.FieldName = "LongDescription"
        Me.colLongDescription.Name = "colLongDescription"
        Me.colLongDescription.Visible = True
        Me.colLongDescription.VisibleIndex = 2
        '
        'colIsForceValue
        '
        Me.colIsForceValue.FieldName = "IsForceValue"
        Me.colIsForceValue.Name = "colIsForceValue"
        Me.colIsForceValue.Visible = True
        Me.colIsForceValue.VisibleIndex = 3
        '
        'colDefaultValue
        '
        Me.colDefaultValue.FieldName = "DefaultValue"
        Me.colDefaultValue.Name = "colDefaultValue"
        Me.colDefaultValue.Visible = True
        Me.colDefaultValue.VisibleIndex = 4
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        '
        'colDataTypeID
        '
        Me.colDataTypeID.FieldName = "DataTypeID"
        Me.colDataTypeID.Name = "colDataTypeID"
        Me.colDataTypeID.Visible = True
        Me.colDataTypeID.VisibleIndex = 5
        '
        'colDocumentFileName
        '
        Me.colDocumentFileName.FieldName = "DocumentFileName"
        Me.colDocumentFileName.Name = "colDocumentFileName"
        '
        'colLookup
        '
        Me.colLookup.FieldName = "Lookup"
        Me.colLookup.Name = "colLookup"
        Me.colLookup.Visible = True
        Me.colLookup.VisibleIndex = 6
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'xlChecklistOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlChecklistOption"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcChecklistOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChecklistOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcChecklistOption As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvChecklistOption As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLongDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsForceValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentFileName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLookup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn

End Class
