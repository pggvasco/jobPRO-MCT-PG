Public Class xaeCheckListOption
    Inherits xaegCheckListTask

    Public Sub New()
        InitializeComponent()
        'Dim lm As New UniSource.Helper.ActiveRecord.LookupMaintenance(Of API.Lookup)(luLookup, xaeLookup, AddressOf GetLookups, Conversation)
    End Sub
   
    Private Sub xaeCheckListOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                LookupBindingSource.DataSource = GetLookups()
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Lookups.", ex)
        End Try

        Try
            luDataType.Properties.DataSource = [Enum].GetValues(GetType(API.Datatype))
        Catch ex As Exception
            Setup.Log.logError("Error fetching Data Types.", ex)
        End Try
    End Sub

    Private Function GetLookups() As IEnumerable(Of API.Lookup)
        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            Return API.Lookup.FindAll
        End Using
    End Function

    Private reqEdit As DevExpress.XtraEditors.BaseEdit
    Private defEdit As DevExpress.XtraEditors.BaseEdit

    Private Sub luDataType_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles luDataType.EditValueChanged

        RefreshDefaultRequiredControls()

    End Sub

    Private Sub RefreshDefaultRequiredControls()
        If Me.Record Is Nothing Then
            luLookup.Properties.ReadOnly = True
        Else
            Dim a As API.Datatype = luDataType.EditValue
            Me.Record.DataTypeID = a
            If Me.Record.DataTypeID = API.Datatype.Lookup Then
                luLookup.Properties.ReadOnly = False
            Else
                luLookup.Properties.ReadOnly = True
            End If
        End If

        Dim xucoReq As New xucChecklistOption(Me.Record)
        Dim xucoDef As New xucChecklistOption(Me.Record)

        If reqEdit IsNot Nothing Then
            reqEdit.Dispose()
        End If

        If defEdit IsNot Nothing Then
            defEdit.Dispose()
        End If

        reqEdit = xucoReq.EditOption
        defEdit = xucoDef.EditOption

        Dim defItem = DataLayoutControl.AddItem("Default Value", defEdit)
        Dim reqItem = DataLayoutControl.AddItem("Required Value", reqEdit)

        Dim defBinding As Binding = New Binding("EditValue", Me.BindingSource, "DefaultValue", True)
        Dim reqBinding As Binding = New Binding("EditValue", Me.BindingSource, "RequiredValue", True)

        If Me.Record IsNot Nothing Then
            If Me.Record.DataTypeID = API.Datatype.Boolean Then
                AddHandler defBinding.Format, AddressOf FormatBool
                AddHandler reqBinding.Format, AddressOf FormatBool
            End If
        End If

        If defEdit IsNot Nothing Then
            defEdit.DataBindings.Add(defBinding)
            defItem.TextVisible = True
            defItem.Control.Text = ""
        End If
        If reqEdit IsNot Nothing Then
            reqEdit.DataBindings.Add(reqBinding)
            reqItem.TextVisible = True
            reqItem.Control.Text = ""
        End If
    End Sub

    Private Sub RefreshDefaultRequiredControlsDatasource()
        If defEdit IsNot Nothing Then
            If Me.Record.DataTypeID = API.Datatype.Lookup Then
                Me.Record.Lookup = luLookup.EditValue
                If Me.Record.Lookup IsNot Nothing Then
                    CType(defEdit, DevExpress.XtraEditors.LookUpEdit).Properties.DataSource = Me.Record.Lookup.Values
                    CType(reqEdit, DevExpress.XtraEditors.LookUpEdit).Properties.DataSource = Me.Record.Lookup.Values
                End If
            End If
        End If
    End Sub

    Private Sub FormatBool(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If TypeOf e.Value Is String Then
            If e.Value = "True" Or e.Value = "1" Or e.Value = "TRUE" Then
                e.Value = True
            ElseIf e.Value = "False" Or e.Value = "0" Or e.Value = "FALSE" Then
                e.Value = False
            Else
                e.Value = Nothing
            End If
        End If
    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "Code" Then
                CodeTextEdit.ErrorText = errors(prop)(0)
            ElseIf prop.Name = "Description" Then
                DescriptionTextEdit.ErrorText = errors(prop)(0)
            ElseIf prop.Name = "luDataType" Then
                DescriptionTextEdit.ErrorText = errors(prop)(0)
            Else
            End If
        Next
    End Sub

    Private Sub luLookup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luLookup.EditValueChanged
        If Me.Record Is Nothing Then
            Exit Sub
        ElseIf IsNothing(Me.Record.DataTypeID) Then
            Exit Sub
        ElseIf IsDBNull(luDataType.EditValue) Then
            Exit Sub
            'ElseIf Me.Record.DataTypeID = luDataType.EditValue And defEdit.Controls.Count > 0 Then
            '    Exit Sub
        End If
        RefreshDefaultRequiredControlsDatasource()
    End Sub

    Private Sub luLookup_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luLookup.Leave
        If Me.Record Is Nothing Then
            Exit Sub
        ElseIf IsNothing(Me.Record.DataTypeID) Then
            Exit Sub
        ElseIf IsDBNull(luDataType.EditValue) Then
            Exit Sub
            'ElseIf defEdit.Controls.Count > 0 Then
            '   Exit Sub
        End If
        RefreshDefaultRequiredControlsDatasource()
    End Sub
End Class

Public Class xaegCheckListTask
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.ChecklistOption)
End Class
