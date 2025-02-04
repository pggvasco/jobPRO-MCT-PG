<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xlEmployee
    Inherits UniSource.ShopFloor.GUI.xlgEmployee

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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gvRates = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LastName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Initials = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmployeeNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisplayName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPanel.SuspendLayout()
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.GridControl1)
        Me.GridPanel.Size = New System.Drawing.Size(871, 274)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gvRates
        Me.GridControl1.MenuManager = Me.barManager
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(871, 274)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRates})
        '
        'gvRates
        '
        Me.gvRates.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFirstName, Me.colID, Me.LastName, Me.Initials, Me.EmployeeNumber, Me.colIDNumber, Me.colDisplayName})
        Me.gvRates.GridControl = Me.GridControl1
        Me.gvRates.Name = "gvRates"
        '
        'colFirstName
        '
        Me.colFirstName.FieldName = "Person.FirstName"
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.OptionsColumn.ReadOnly = True
        Me.colFirstName.Visible = True
        Me.colFirstName.VisibleIndex = 0
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'LastName
        '
        Me.LastName.Caption = "Last Name"
        Me.LastName.FieldName = "Person.LastName"
        Me.LastName.Name = "LastName"
        Me.LastName.Visible = True
        Me.LastName.VisibleIndex = 2
        '
        'Initials
        '
        Me.Initials.Caption = "Initials"
        Me.Initials.FieldName = "Person.Initials"
        Me.Initials.Name = "Initials"
        Me.Initials.Visible = True
        Me.Initials.VisibleIndex = 1
        '
        'EmployeeNumber
        '
        Me.EmployeeNumber.Caption = "Employee Number"
        Me.EmployeeNumber.FieldName = "EmployeeNumber"
        Me.EmployeeNumber.Name = "EmployeeNumber"
        Me.EmployeeNumber.Visible = True
        Me.EmployeeNumber.VisibleIndex = 4
        '
        'colIDNumber
        '
        Me.colIDNumber.Caption = "ID Number"
        Me.colIDNumber.FieldName = "EmployeeID"
        Me.colIDNumber.Name = "colIDNumber"
        Me.colIDNumber.Visible = True
        Me.colIDNumber.VisibleIndex = 5
        '
        'colDisplayName
        '
        Me.colDisplayName.Caption = "Display Name"
        Me.colDisplayName.FieldName = "Person.FullName"
        Me.colDisplayName.Name = "colDisplayName"
        Me.colDisplayName.Visible = True
        Me.colDisplayName.VisibleIndex = 3
        '
        'xlEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "xlEmployee"
        Me.Size = New System.Drawing.Size(871, 327)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPanel.ResumeLayout(False)
        CType(Me.pmGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRates As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFirstName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LastName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Initials As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmployeeNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisplayName As DevExpress.XtraGrid.Columns.GridColumn
End Class
