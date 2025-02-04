Public Class xaeClientAsset
    Public Property vAssetCode As String
    Public Property vMake As String
    Public Property vModel As String
    Public Property vAssetType As String

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        If ValidateValues() Then

            Dim Makeobj As New ShopFloor.API.Make
            Dim Modelobj As New ShopFloor.API.Model
            Dim Assetobj As New ShopFloor.API.Asset

            Makeobj.Code = txtMake.EditValue
            Makeobj.Description = txtMake.EditValue

            Modelobj.Code = txtModel.EditValue
            Modelobj.Description = txtModel.EditValue

            Assetobj.AssetCode = txtAssetCode.EditValue
            Assetobj.Description = txtAssetDescription.EditValue
            Assetobj.SerialNo = txtSerialNumber.EditValue
            Assetobj.AssetClass = 1 ' AssetClassLookup.EditValue
            Assetobj.Measurement_ID = 1 'ConsumptionLookup.EditValue
            Assetobj.AverageConsumption = Convert.ToDouble(txtAvgFuelConsumption.EditValue)
            Assetobj.Active = chkActive.Checked
            Assetobj.InternalAsset = False
            Assetobj.Consumables = chkConsumables.EditValue
            Assetobj.FuelconsumptionApplicable = chkFuelConsumptionApplicable.EditValue
            Assetobj.AssetTypeID = AssetTypeLookUpEdit.EditValue

            Try
                Makeobj.Save()
            Catch ex As Exception
                MsgBox("Error:" & ex.Message.ToString)
            End Try

            Modelobj.Make = Makeobj
            Modelobj.Save()

            Assetobj.Make_ID = Makeobj.ID
            Assetobj.Model_ID = Modelobj.ID

            Assetobj.Save()


            vAssetCode = Assetobj.ID
            vMake = Makeobj.ID
            vModel = Modelobj.ID
            vAssetType = AssetTypeLookUpEdit.EditValue


            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End If
    End Sub

    Private Function ValidateValues() As Boolean

        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()
        crit.Add(NHibernate.Criterion.Expression.Eq("AssetCode", txtAssetCode.EditValue))
        Dim cnt As Integer = API.Asset.FindAll(crit).Count

        If cnt > 0 Then
            MsgBox("AssetCode already exists")
            Return False
        End If

        crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Make)()
        crit.Add(NHibernate.Criterion.Expression.Eq("Code", txtMake.EditValue))
        cnt = API.Make.FindAll(crit).Count

        If cnt > 0 Then
            MsgBox("Make already exists")
            Return False
        End If

        crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Model)()
        crit.Add(NHibernate.Criterion.Expression.Eq("Code", txtModel.EditValue))
        cnt = API.Model.FindAll(crit).Count

        If cnt > 0 Then
            MsgBox("Model already exists")
            Return False
        End If

        Return True

    End Function

    Private Sub xaeClientAsset_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetMeasurement)(ConsumptionLookup, AddressOf LoadAssetMeasurement, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Measurement.", ex)
        End Try

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetType)(AssetTypeLookUpEdit, AddressOf LoadAssetType, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Type.", ex)
        End Try


    End Sub

    Private Function LoadAssetType() As IEnumerable(Of API.AssetType)
        Return API.AssetType.FindAll
    End Function


    Private Function LoadAssetMeasurement() As IEnumerable(Of API.AssetMeasurement)
        Return API.AssetMeasurement.FindAll
    End Function


End Class