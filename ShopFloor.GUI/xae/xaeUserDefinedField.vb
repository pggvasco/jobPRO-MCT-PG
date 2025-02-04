Public Class xaeUserDefinedField 
    Inherits xaegUserDefinedField
    'Public Property Assembly As New UniSource.Helper.ActiveRecord.AssemblyReflection("Pastel.Evolution")
    'Public Property AssemblyLookup As UniSource.Helper.ActiveRecord.AssemblyLookUp

       

    Private Sub xaeUserDefinedField_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            LoadEnums()
        Catch ex As Exception
            Setup.Log.logError("Error loading Enums.", ex)
        End Try

        Try
            UserDefinedFieldTypeBindingSource.DataSource = UniSource.Helper.ActiveRecord.Evolution.UserDefinedFieldType.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error loading user-defined field types.", ex)
        End Try

        'AssemblyLookUpBindingSource.DataSource = Assembly.GetAssemblies

    End Sub
    Private Sub setAssembly(ByVal sender As Object, ByVal e As EventArgs) Handles AssemblyNameLookUpEdit.EditValueChanged
        'If AssemblyNameLookUpEdit.EditValue IsNot Nothing Then

        '    Try
        '        AssemblyLookup = New Helper.ActiveRecord.AssemblyLookUp(CType(AssemblyNameLookUpEdit.EditValue, Helper.ActiveRecord.AssemblyLookUp).Assembly)
        '    Catch ex As Exception
        '        Setup.Setup.Log.logError("Error loading Assembly Lookup.", ex)
        '        Exit Sub
        '    End Try
        '     Try
        '        Assembly = New Helper.ActiveRecord.AssemblyReflection(AssemblyLookup.AssemblyName)
        '    Catch ex As Exception
        '        Setup.Setup.Log.logError("Error loading Assembly.", ex)
        '        Exit Sub
        '    End Try
        '        Try
        '        DataSourceTypeLookupBindingSource.DataSource = AssemblyLookup.DataSourceTypes
        '    Catch ex As Exception
        '        UniSource.Logging.Log.Log.logError("Error fetching classes.", ex)
        '    End Try
        'End If
    End Sub
    Private Sub LoadEnums()
        FieldTypeLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(Helper.ActiveRecord.Evolution.UserFieldType))
    End Sub

    Private Sub FieldTypeLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldTypeLookUpEdit.EditValueChanged
        Dim ft As Helper.ActiveRecord.Evolution.UserFieldType = CType(IIf(IsDBNull(FieldTypeLookUpEdit.EditValue), Nothing, FieldTypeLookUpEdit.EditValue), Helper.ActiveRecord.Evolution.UserFieldType)
        Select Case ft
            Case UniSource.Helper.ActiveRecord.Evolution.UserFieldType.String
                FieldSizeSpinEdit.Properties.ReadOnly = False
            Case UniSource.Helper.ActiveRecord.Evolution.UserFieldType.Lookup
                LookupOptionsTextEdit.Properties.ReadOnly = False
                FieldDecimalsSpinEdit.Properties.ReadOnly = True
                FieldSizeSpinEdit.Properties.ReadOnly = True
            Case UniSource.Helper.ActiveRecord.Evolution.UserFieldType.Double
                LookupOptionsTextEdit.Properties.ReadOnly = True
                FieldDecimalsSpinEdit.Properties.ReadOnly = False
                FieldSizeSpinEdit.Properties.ReadOnly = True
            Case Else
                LookupOptionsTextEdit.Properties.ReadOnly = True
                FieldDecimalsSpinEdit.Properties.ReadOnly = True
                FieldSizeSpinEdit.Properties.ReadOnly = True
        End Select
    End Sub

    Private Sub TableNameLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TableNameLookUpEdit.EditValueChanged
        If TableNameLookUpEdit.EditValue Is Nothing Or IsDBNull(TableNameLookUpEdit.EditValue) Then
            FieldTypeLookUpEdit.Properties.ReadOnly = True
            FieldNameTextEdit.Properties.ReadOnly = True
            FieldDescriptionTextEdit.Properties.ReadOnly = True
            IsForceValueCheckEdit.Properties.ReadOnly = True
            DefaultValueTextEdit.Properties.ReadOnly = True
            FieldIndexSpinEdit.Properties.ReadOnly = True
            PageNameTextEdit.Properties.ReadOnly = True
            PageIndexSpinEdit.Properties.ReadOnly = True
        Else
            FieldTypeLookUpEdit.EditValue = UniSource.Helper.ActiveRecord.Evolution.UserFieldType.String
            FieldTypeLookUpEdit.Properties.ReadOnly = False
            FieldNameTextEdit.Properties.ReadOnly = False
            FieldDescriptionTextEdit.Properties.ReadOnly = False
            IsForceValueCheckEdit.Properties.ReadOnly = False
            DefaultValueTextEdit.Properties.ReadOnly = False
            FieldIndexSpinEdit.Properties.ReadOnly = False
            PageNameTextEdit.Properties.ReadOnly = False
            PageIndexSpinEdit.Properties.ReadOnly = False
        End If
    End Sub
    Protected Overrides Sub SaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btSave.Click
        adduserdictextend()
        Try
            'it is not passing the property.
            SaveRecord()
        Catch ex As Exception
            Logging.Log.Log.logError("Error saving record.", ex)
        End Try
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btnDataSourceMembers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataSourceMembers.Click

        Dim DataSourceMember As New xaeDataSourceMember
        'DataSourceMember.TypeLookup = CType(DataSourceTypeLookUpEdit.EditValue, UniSource.Helper.ActiveRecord.DataSourceTypeLookup)
        DataSourceMember.Show()
    End Sub

    Private _exportobjecttype As Type
    
    Public Sub adduserdictextend()
        'If Me.Record.UserDictExtend Is Nothing Then
        '    Me.Record.UserDictExtend = New Helper.ActiveRecord.Evolution.UserDictExtend
        'End If
        'Me.Record.UserDictExtend.DataSourceAssemblyName = AssemblyLookup.AssemblyName
        'Me.Record.UserDictExtend.DataSourcedTypeName = CType(DataSourceTypeLookUpEdit.EditValue, Helper.ActiveRecord.DataSourceTypeLookup).FullName
        'Me.Record.UserDictExtend.DataSourceConstructorValue = "1:1"
        'Me.Record.UserDictExtend.DataSourcedValuePropertyName = "Code"
        'Me.Record.UserDictExtend.UseObjectDataSource = True
        'Me.Record.UserDictExtend.UserDictID = Me.Record.ID
        'Me.Record.UserDictExtend.SaveAndFlush()
    End Sub

    Private Sub ObjectDataSourceCheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObjectDataSourceCheckEdit.CheckedChanged
        If ObjectDataSourceCheckEdit.Checked = True Then
            LookupOptionsTextEdit.Enabled = False
            DataSourceTypeLookUpEdit.Enabled = True
            AssemblyNameLookUpEdit.Enabled = True
        Else
            LookupOptionsTextEdit.Enabled = True
            DataSourceTypeLookUpEdit.Enabled = False
            AssemblyNameLookUpEdit.Enabled = False

        End If
    End Sub

  
End Class

Public Class xaegUserDefinedField
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of Helper.ActiveRecord.Evolution.UserDefinedField)
End Class