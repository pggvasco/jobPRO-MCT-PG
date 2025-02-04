<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfJobTolerances
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
        Dim PivotGridStyleFormatCondition1 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
        Dim PivotGridStyleFormatCondition2 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
        Me.fieldActual1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.riseValue = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.pgcJobTolerances = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.JobToleranceListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.fieldCode = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.ritxtCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.fieldDescription1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBand1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSequence1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNew1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRecon1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPhotographs = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.riseValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcJobTolerances, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobToleranceListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ritxtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fieldActual1
        '
        Me.fieldActual1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldActual1.AreaIndex = 3
        Me.fieldActual1.Caption = "Actual"
        Me.fieldActual1.FieldEdit = Me.riseValue
        Me.fieldActual1.FieldName = "Actual"
        Me.fieldActual1.Name = "fieldActual1"
        '
        'riseValue
        '
        Me.riseValue.AutoHeight = False
        Me.riseValue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.riseValue.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.riseValue.Name = "riseValue"
        Me.riseValue.ValidateOnEnterKey = True
        '
        'pgcJobTolerances
        '
        Me.pgcJobTolerances.DataSource = Me.JobToleranceListBindingSource
        Me.pgcJobTolerances.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcJobTolerances.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCode, Me.fieldDescription1, Me.fieldBand1, Me.fieldSequence1, Me.fieldNew1, Me.fieldRecon1, Me.fieldActual1})
        PivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Green
        PivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        PivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition1.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition1.ApplyToGrandTotalCell = False
        PivotGridStyleFormatCondition1.ApplyToTotalCell = False
        PivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        PivotGridStyleFormatCondition1.Expression = "[Actual] Between ([Recon],[New]) AND [Actual] != 0"
        PivotGridStyleFormatCondition1.Field = Me.fieldActual1
        PivotGridStyleFormatCondition1.FieldName = "fieldActual1"
        PivotGridStyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
        PivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White
        PivotGridStyleFormatCondition2.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition2.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition2.ApplyToGrandTotalCell = False
        PivotGridStyleFormatCondition2.ApplyToTotalCell = False
        PivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        PivotGridStyleFormatCondition2.Expression = "Not [Actual] Between ([Recon],[New]) And [Actual] != 0"
        PivotGridStyleFormatCondition2.Field = Me.fieldActual1
        PivotGridStyleFormatCondition2.FieldName = "fieldActual1"
        Me.pgcJobTolerances.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {PivotGridStyleFormatCondition1, PivotGridStyleFormatCondition2})
        Me.pgcJobTolerances.Location = New System.Drawing.Point(0, 22)
        Me.pgcJobTolerances.Name = "pgcJobTolerances"
        Me.pgcJobTolerances.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.RowArea
        Me.pgcJobTolerances.OptionsDataField.AreaIndex = 1
        Me.pgcJobTolerances.OptionsDataField.Caption = "Tolerances"
        Me.pgcJobTolerances.OptionsView.ShowColumnGrandTotalHeader = False
        Me.pgcJobTolerances.OptionsView.ShowColumnGrandTotals = False
        Me.pgcJobTolerances.OptionsView.ShowColumnHeaders = False
        Me.pgcJobTolerances.OptionsView.ShowColumnTotals = False
        Me.pgcJobTolerances.OptionsView.ShowDataHeaders = False
        Me.pgcJobTolerances.OptionsView.ShowFilterHeaders = False
        Me.pgcJobTolerances.OptionsView.ShowRowGrandTotalHeader = False
        Me.pgcJobTolerances.OptionsView.ShowRowGrandTotals = False
        Me.pgcJobTolerances.OptionsView.ShowRowHeaders = False
        Me.pgcJobTolerances.OptionsView.ShowRowTotals = False
        Me.pgcJobTolerances.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ritxtCode, Me.riseValue})
        Me.pgcJobTolerances.Size = New System.Drawing.Size(952, 639)
        Me.pgcJobTolerances.TabIndex = 0
        '
        'JobToleranceListBindingSource
        '
        Me.JobToleranceListBindingSource.DataMember = "JobToleranceList"
        Me.JobToleranceListBindingSource.DataSource = Me.JobBindingSource
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataSource = GetType(UniSource.ShopFloor.API.Job)
        '
        'fieldCode
        '
        Me.fieldCode.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCode.AreaIndex = 0
        Me.fieldCode.Caption = "Code"
        Me.fieldCode.FieldEdit = Me.ritxtCode
        Me.fieldCode.FieldName = "Code"
        Me.fieldCode.Name = "fieldCode"
        Me.fieldCode.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'ritxtCode
        '
        Me.ritxtCode.AutoHeight = False
        Me.ritxtCode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ritxtCode.Name = "ritxtCode"
        Me.ritxtCode.ValidateOnEnterKey = True
        '
        'fieldDescription1
        '
        Me.fieldDescription1.AreaIndex = 0
        Me.fieldDescription1.Caption = "Description"
        Me.fieldDescription1.FieldName = "Description"
        Me.fieldDescription1.Name = "fieldDescription1"
        '
        'fieldBand1
        '
        Me.fieldBand1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBand1.AreaIndex = 0
        Me.fieldBand1.Caption = "Band"
        Me.fieldBand1.FieldName = "Band"
        Me.fieldBand1.Name = "fieldBand1"
        '
        'fieldSequence1
        '
        Me.fieldSequence1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSequence1.AreaIndex = 0
        Me.fieldSequence1.Caption = "Sequence"
        Me.fieldSequence1.FieldName = "Sequence"
        Me.fieldSequence1.Name = "fieldSequence1"
        '
        'fieldNew1
        '
        Me.fieldNew1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNew1.AreaIndex = 1
        Me.fieldNew1.Caption = "New"
        Me.fieldNew1.FieldEdit = Me.riseValue
        Me.fieldNew1.FieldName = "New"
        Me.fieldNew1.Name = "fieldNew1"
        '
        'fieldRecon1
        '
        Me.fieldRecon1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldRecon1.AreaIndex = 2
        Me.fieldRecon1.Caption = "Recon"
        Me.fieldRecon1.FieldEdit = Me.riseValue
        Me.fieldRecon1.FieldName = "Recon"
        Me.fieldRecon1.Name = "fieldRecon1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiSave, Me.bbiCancel, Me.bbiPhotographs})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCancel), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPhotographs)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Id = 0
        Me.bbiSave.Name = "bbiSave"
        Me.bbiSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiCancel
        '
        Me.bbiCancel.Caption = "Cancel"
        Me.bbiCancel.Id = 1
        Me.bbiCancel.Name = "bbiCancel"
        Me.bbiCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiPhotographs
        '
        Me.bbiPhotographs.Caption = "Photographs"
        Me.bbiPhotographs.Id = 2
        Me.bbiPhotographs.Name = "bbiPhotographs"
        Me.bbiPhotographs.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(952, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 661)
        Me.barDockControlBottom.Size = New System.Drawing.Size(952, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 639)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(952, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 639)
        '
        'xfJobTolerances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 661)
        Me.Controls.Add(Me.pgcJobTolerances)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xfJobTolerances"
        Me.Text = "Job Tolerances"
        CType(Me.riseValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcJobTolerances, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobToleranceListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ritxtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pgcJobTolerances As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldCode As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDescription1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBand1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSequence1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNew1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRecon1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldActual1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents JobToleranceListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ritxtCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents riseValue As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiPhotographs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
