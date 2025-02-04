Public Class xucChecklistOption

    Public Property [Option] As API.ChecklistOption
        Get
            Return CType(ChecklistOptionBindingSource.Current, API.ChecklistOption)
        End Get
        Private Set(ByVal value As API.ChecklistOption)
            ChecklistOptionBindingSource.DataSource = value
        End Set
    End Property

    Public Property Log As API.ChecklistOptionLog
        Get
            Return CType(ChecklistOptionLogBindingSource.Current, API.ChecklistOptionLog)
        End Get
        Set(ByVal value As API.ChecklistOptionLog)
            ChecklistOptionLogBindingSource.DataSource = value
        End Set
    End Property

    Protected Friend Property EditOption As DevExpress.XtraEditors.BaseEdit

    Public Property ErrorText As String
        Get
            Return EditOption.ErrorText
        End Get
        Set(ByVal value As String)
            EditOption.ErrorText = value
        End Set
    End Property

    Public ReadOnly Property EditValue As Object
        Get
            Return EditOption.EditValue
        End Get
    End Property

    Public Sub New(ByVal [option] As API.ChecklistOption)
        InitializeComponent()
        Me.Option = [option]
        Me.Log = New API.ChecklistOptionLog With {.ChecklistOption = Me.Option}
        SetEditor()
    End Sub

    Public Sub New(ByVal [option] As API.ChecklistOption, ByVal ForceDataType As API.Datatype)
        InitializeComponent()
        Me.Option = [option]
        Me.Log = New API.ChecklistOptionLog With {.ChecklistOption = Me.Option}
        SetEditor(ForceDataType)
    End Sub

    Private Sub SetEditor()
        If [Option] IsNot Nothing And IsNothing([Option].DataTypeID) = False Then

            Select Case [Option].DataTypeID
                Case API.Datatype.Boolean
                    EditOption = New DevExpress.XtraEditors.CheckEdit
                    EditOption.Text = [Option].Description
                    CType(EditOption, DevExpress.XtraEditors.CheckEdit).Properties.AllowGrayed = True
                Case API.Datatype.Date
                    EditOption = New DevExpress.XtraEditors.DateEdit
                Case API.Datatype.Float
                    EditOption = New DevExpress.XtraEditors.SpinEdit
                    EditOption.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    EditOption.Properties.DisplayFormat.FormatString = "f"
                Case API.Datatype.Integer
                    EditOption = New DevExpress.XtraEditors.SpinEdit
                    EditOption.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Case API.Datatype.Lookup
                    EditOption = New DevExpress.XtraEditors.LookUpEdit
                    CType(EditOption, DevExpress.XtraEditors.LookUpEdit).Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code"))
                    CType(EditOption, DevExpress.XtraEditors.LookUpEdit).Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description"))
                    If [Option].Lookup IsNot Nothing Then
                        CType(EditOption, DevExpress.XtraEditors.LookUpEdit).Properties.DataSource = [Option].Lookup.Values
                    End If
                    CType(EditOption, DevExpress.XtraEditors.LookUpEdit).Properties.ValueMember = "Code"
                    CType(EditOption, DevExpress.XtraEditors.LookUpEdit).Properties.DisplayMember = "Description"
                Case API.Datatype.String
                    EditOption = New DevExpress.XtraEditors.TextEdit
                Case Else
                    'defaults to text if nothing
                    EditOption = New DevExpress.XtraEditors.TextEdit
            End Select

            If Not String.IsNullOrEmpty([Option].DefaultValue) Then
                If [Option].DataTypeID = API.Datatype.Boolean Then
                    EditOption.EditValue = FormatBool([Option].DefaultValue)
                    If EditOption.EditValue Is Nothing Then
                        EditOption.EditValue = False
                    End If
                Else
                    EditOption.EditValue = [Option].DefaultValue
                End If
            End If

            Dim fnt As Font = New Font(EditOption.Font.FontFamily, EditOption.Font.Size * 1.5)
            EditOption.Font = fnt

            AddHandler EditOption.EditValueChanged, AddressOf editOption_EditValueChanged

            EditOption.Dock = DockStyle.Fill
            Me.Controls.Add(EditOption)
        End If
    End Sub

    Private Sub SetEditor(ByVal ForceDataType As API.Datatype)
        If [Option] IsNot Nothing And IsNothing([Option].DataTypeID) = False Then

            Select Case ForceDataType
                Case API.Datatype.Boolean
                    EditOption = New DevExpress.XtraEditors.CheckEdit
                    EditOption.Text = [Option].Description
                    CType(EditOption, DevExpress.XtraEditors.CheckEdit).Properties.AllowGrayed = True
                Case API.Datatype.Date
                    EditOption = New DevExpress.XtraEditors.DateEdit
                Case API.Datatype.Float
                    EditOption = New DevExpress.XtraEditors.SpinEdit
                    EditOption.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    EditOption.Properties.DisplayFormat.FormatString = "f"
                Case API.Datatype.Integer
                    EditOption = New DevExpress.XtraEditors.SpinEdit
                    EditOption.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Case API.Datatype.Lookup
                    EditOption = New DevExpress.XtraEditors.LookUpEdit
                    CType(EditOption, DevExpress.XtraEditors.LookUpEdit).Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code"))
                    CType(EditOption, DevExpress.XtraEditors.LookUpEdit).Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description"))
                    If [Option].Lookup IsNot Nothing Then
                        CType(EditOption, DevExpress.XtraEditors.LookUpEdit).Properties.DataSource = [Option].Lookup.Values
                    End If
                    CType(EditOption, DevExpress.XtraEditors.LookUpEdit).Properties.ValueMember = "Code"
                    CType(EditOption, DevExpress.XtraEditors.LookUpEdit).Properties.DisplayMember = "Description"
                Case API.Datatype.String
                    EditOption = New DevExpress.XtraEditors.TextEdit
                Case Else
                    'defaults to text if nothing
                    EditOption = New DevExpress.XtraEditors.TextEdit
            End Select

            If Not String.IsNullOrEmpty([Option].DefaultValue) Then
                If ForceDataType = API.Datatype.Boolean Then
                    EditOption.EditValue = FormatBool([Option].DefaultValue)
                    If EditOption.EditValue Is Nothing Then
                        EditOption.EditValue = False
                    End If
                Else
                    EditOption.EditValue = [Option].DefaultValue
                End If
            End If

            Dim fnt As Font = New Font(EditOption.Font.FontFamily, EditOption.Font.Size * 0.1)
            EditOption.Font = fnt

            AddHandler EditOption.EditValueChanged, AddressOf editOption_EditValueChanged

            EditOption.Dock = DockStyle.Fill
            Me.Controls.Add(EditOption)
        End If
    End Sub

    Private Function FormatBool(ByVal value As String) As Nullable(Of Boolean)
        If value = "True" Or value = "1" Or value = "TRUE" Then
            Return True
        ElseIf value = "False" Or value = "0" Or value = "FALSE" Then
            Return False
        Else
            Return Nothing
        End If
    End Function

    Private Sub editOption_EditValueChanged(sender As System.Object, e As System.EventArgs)
        Log.Value = IIf(IsDBNull(EditOption.EditValue), Nothing, EditOption.EditValue)
        Log.LogDateTime = Now
    End Sub

End Class
