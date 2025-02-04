<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlJobStage
    Inherits UniSource.ShopFloor.GUI.xlgJobStage

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
        Me.gvJobStage = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsRequired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsProcurement = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcJobStage = New DevExpress.XtraGrid.GridControl()
        Me.colValidationErrorMessages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsChanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsLoading = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJobStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJobStage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.gcJobStage)
        '
        'gvJobStage
        '
        Me.gvJobStage.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colDescription, Me.colIsRequired, Me.colIsActive, Me.colIsProcurement, Me.colSequence, Me.colID})
        Me.gvJobStage.GridControl = Me.gcJobStage
        Me.gvJobStage.Name = "gvJobStage"
        Me.gvJobStage.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvJobStage.OptionsBehavior.Editable = False
        Me.gvJobStage.OptionsBehavior.ReadOnly = True
        Me.gvJobStage.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
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
        'colIsRequired
        '
        Me.colIsRequired.FieldName = "IsRequired"
        Me.colIsRequired.Name = "colIsRequired"
        Me.colIsRequired.Visible = True
        Me.colIsRequired.VisibleIndex = 2
        '
        'colIsActive
        '
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        Me.colIsActive.Visible = True
        Me.colIsActive.VisibleIndex = 3
        '
        'colIsProcurement
        '
        Me.colIsProcurement.FieldName = "IsProcurement"
        Me.colIsProcurement.Name = "colIsProcurement"
        Me.colIsProcurement.Visible = True
        Me.colIsProcurement.VisibleIndex = 4
        '
        'colSequence
        '
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        Me.colSequence.Visible = True
        Me.colSequence.VisibleIndex = 5
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'gcJobStage
        '
        Me.gcJobStage.DataSource = Me.BindingSource
        Me.gcJobStage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJobStage.Location = New System.Drawing.Point(0, 0)
        Me.gcJobStage.MainView = Me.gvJobStage
        Me.gcJobStage.MenuManager = Me.barManager
        Me.gcJobStage.Name = "gcJobStage"
        Me.gcJobStage.ShowOnlyPredefinedDetails = True
        Me.gcJobStage.Size = New System.Drawing.Size(925, 506)
        Me.gcJobStage.TabIndex = 0
        Me.gcJobStage.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJobStage})
        '
        'colValidationErrorMessages
        '
        Me.colValidationErrorMessages.FieldName = "ValidationErrorMessages"
        Me.colValidationErrorMessages.Name = "colValidationErrorMessages"
        Me.colValidationErrorMessages.OptionsColumn.ReadOnly = True
        Me.colValidationErrorMessages.Visible = True
        Me.colValidationErrorMessages.VisibleIndex = 8
        '
        'colIsChanged
        '
        Me.colIsChanged.FieldName = "IsChanged"
        Me.colIsChanged.Name = "colIsChanged"
        Me.colIsChanged.OptionsColumn.ReadOnly = True
        Me.colIsChanged.Visible = True
        Me.colIsChanged.VisibleIndex = 8
        '
        'colIsLoading
        '
        Me.colIsLoading.FieldName = "IsLoading"
        Me.colIsLoading.Name = "colIsLoading"
        Me.colIsLoading.OptionsColumn.ReadOnly = True
        Me.colIsLoading.Visible = True
        Me.colIsLoading.VisibleIndex = 8
        '
        'xlJobStage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlJobStage"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJobStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJobStage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcJobStage As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJobStage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsRequired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsProcurement As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidationErrorMessages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsChanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsLoading As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSequence As DevExpress.XtraGrid.Columns.GridColumn

End Class
