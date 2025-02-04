Public Class xaeAssets
    Inherits xaegAssets

    Public Property isClientAsset As Boolean

    Private Sub xaeAssets_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of API.ScheduleFrequency)(rileSchedule, AddressOf LoadScheduleCode)
            iibl.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        End Try
        Try
            Dim ST As New Helper.ActiveRecord.LookupMaintenance(Of API.Make)(MarkLookUpEdit, xaeMake, AddressOf LoadMake, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Make.", ex)
        End Try

        Try
            Dim ST As New Helper.ActiveRecord.LookupMaintenance(Of API.Model)(ModelLookUpEdit, xaeModel, AddressOf LoadModel, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Model.", ex)
        End Try


        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of Helper.ActiveRecord.Evolution.People)(TechnicianLookUpEdit, AddressOf LoadPeople, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Technician.", ex)
        End Try

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.Asset)(PrimaryassetIdLookUpEdit, AddressOf LoadAsset, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Primary Asset.", ex)
        End Try

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetMeasurement)(AssetMeasurementLooupEdit, AddressOf LoadAssetMeasurement, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Measurement.", ex)
        End Try

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetClass)(AssetClassLookUpEdit, AddressOf LoadAssetClass, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Class.", ex)
        End Try


        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetType)(AssetTypeLookUpEdit, AddressOf LoadAssetType, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Type.", ex)
        End Try

        If Me.Record.ID Is Nothing Or Me.Record.ID = 0 Then
            Me.Record.InternalAsset = True
        End If


        'Try
        '    Dim ST As New Helper.ActiveRecord.LookupMaintenance(Of API.Model)(ModelLookUpEdit, xaeModel, AddressOf LoadModel, Me.Conversation)
        'Catch ex As Exception
        '    Setup.Log.logError("Error setting lookup maintenance for Service Type.", ex)
        'End Try

    End Sub

    Private Function LoadPeople() As IEnumerable(Of Helper.ActiveRecord.Evolution.People)
        Return UniSource.Helper.ActiveRecord.Evolution.People.FindAll
    End Function

    Private Function LoadAsset() As IEnumerable(Of API.Asset)
        Return API.Asset.FindAll
    End Function

    Private Function LoadAssetClass() As IEnumerable(Of API.AssetClass)
        Return API.AssetClass.FindAll
    End Function

    Private Function LoadAssetType() As IEnumerable(Of API.AssetType)
        Return API.AssetType.FindAll
    End Function

    Private Function LoadMake() As IEnumerable(Of API.Make)
        Return API.Make.FindAll
    End Function

    Private Function LoadAssetMeasurement() As IEnumerable(Of API.AssetMeasurement)
        Return API.AssetMeasurement.FindAll
    End Function
    Private Function LoadScheduleCode() As IEnumerable(Of API.ScheduleFrequency)
        Return API.ScheduleFrequency.FindAll
    End Function

    'Private Function LoadModel() As IEnumerable(Of API.Model)
    '    Return API.Asset.FindAll
    'End Function

    Private Function LoadModel() As IEnumerable(Of API.Model)
        Dim mk As API.Make = TryCast(MarkLookUpEdit.EditValue, API.Make)
        If mk IsNot Nothing Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Model)()
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Make", mk), NHibernate.Criterion.Expression.IsNull("Make")))
            Return API.Model.FindAll(crit)
        Else
            Return API.Model.FindAll
        End If
    End Function

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        If IsDBNull(AssetCodeTextEdit.EditValue) Or AssetCodeTextEdit Is Nothing Then
            AssetCodeTextEdit.ErrorText = "Asset Code cannot be blank"
        End If
        If IsDBNull(DescriptionTextEdit.EditValue) Or DescriptionTextEdit Is Nothing Then
            DescriptionTextEdit.ErrorText = "Description cannot be blank"
        End If

        If AssetTypeLookUpEdit.EditValue Is Nothing AndAlso IsDBNull(AssetTypeLookUpEdit.EditValue) = False Then
            AssetTypeLookUpEdit.ErrorText = "Please select Asset Type"

        End If
        If AssetClassLookUpEdit.EditValue Is Nothing AndAlso IsDBNull(AssetClassLookUpEdit.EditValue) = False Then
            AssetTypeLookUpEdit.ErrorText = "Please select Asset Class"

        End If
        MyBase.ValidationError(errors)
        If errors IsNot Nothing Then

            For Each prop As Reflection.PropertyInfo In errors.Keys
                If prop.Name = "AssetCode" Then
                    AssetCodeTextEdit.ErrorText = errors(prop)(0)
                End If
                If prop.Name = "Description" Then
                    DescriptionTextEdit.ErrorText = errors(prop)(0)
                End If
                If prop.Name = "AssetClass" Then
                    AssetClassLookUpEdit.ErrorText = errors(prop)(0)
                End If
            Next
        End If

    End Sub

    Protected Overrides Sub SaveRecord()
        Try
            If IsDBNull(AssetCodeTextEdit.EditValue) Or AssetCodeTextEdit Is Nothing Then
                AssetCodeTextEdit.ErrorText = "Asset Code is a required field."
            End If
            If IsDBNull(DescriptionTextEdit.EditValue) Or DescriptionTextEdit Is Nothing Then
                DescriptionTextEdit.ErrorText = "Description cannot be blank"
            End If
            MyBase.SaveRecord()
        Catch ex As Exception
            Setup.Log.logError("Error Asset details incorrect.", ex)
        End Try

    End Sub

    Private Sub AssetCodeTextEdit_Leave(sender As System.Object, e As System.EventArgs) Handles AssetCodeTextEdit.Leave
        If IsDBNull(AssetCodeTextEdit.EditValue) Or AssetCodeTextEdit Is Nothing Then
            AssetCodeTextEdit.ErrorText = "Asset Code is a required field." & vbCrLf & " Código do ativo é um campo obrigatório."
            Setup.Log.logError("Asset Code is a required field." & vbCrLf & " Código do ativo é um campo obrigatório.")
            AssetCodeTextEdit.Focus()
        End If
    End Sub

    Private Sub DescriptionTextEdit_Leave(sender As System.Object, e As System.EventArgs) Handles DescriptionTextEdit.Leave
        If IsDBNull(DescriptionTextEdit.EditValue) Or DescriptionTextEdit Is Nothing Then
            DescriptionTextEdit.ErrorText = "Asset descrition is a required field." & vbCrLf & "A descrição de ativos é um campo obrigatório."
            Setup.Log.logError("Asset descrition is a required field." & vbCrLf & "A descrição de ativos é um campo obrigatório.")
            DescriptionTextEdit.Focus()
        End If
    End Sub

    
    Private Sub TextEdit4_Leave(sender As System.Object, e As System.EventArgs) Handles TextEdit4.Leave
        If IsDBNull(TextEdit4.EditValue) Or TextEdit4 Is Nothing Then
            TextEdit4.ErrorText = "Registration Number is a required field." & vbCrLf & "Número de registro é um campo obrigatório."
            Setup.Log.logError("Registration Number is a required field." & vbCrLf & "Número de registro é um campo obrigatório.")
            TextEdit4.Focus()
        End If
    End Sub
End Class


Public Class xaegAssets
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Asset)

    Public Sub New()
        MyBase.New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

End Class