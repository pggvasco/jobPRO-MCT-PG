Public Class xaeJobTemplateLineLite
    Inherits xaegJobTemplateLineLite

    Private Sub xaeJobLineLite_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Dim wcclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentreCategory)(WorkCentreCategoryLookUpEdit, xaeWorkCentreCategory, AddressOf LoadWorkCentreCategories, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centre Categories.", ex)
        End Try

        Try
            Dim wclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentre)(WorkCentreLookupEdit, xaeWorkCentre, AddressOf LoadWorkCentres, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centres.", ex)
        End Try

        Try
            Dim sslm As New Helper.ActiveRecord.LookupMaintenance(Of API.SupplyScope)(SupplyScopeLookupEdit, xaeSupplyScope, AddressOf LoadSupplyScopes, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Supply Scopes.", ex)
        End Try

        Try
            Dim plm As New Helper.ActiveRecord.LookupMaintenance(Of API.Part)(PartLookupEdit, xaePart, AddressOf LoadParts, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Parts.", ex)
        End Try

        Try
            Dim stbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.VendorClass)(SupplierTypeIDLookupEdit, AddressOf LoadVendorClasses)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Supplier Types.", ex)
        End Try

        'Try
        '    Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(InventoryItemIDLookupEdit, AddressOf LoadStockItems)
        'Catch ex As Exception
        '    Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        'End Try

        Try
            SetWorkCentre()
        Catch ex As Exception
            Setup.Log.logError("Error setting Work Centre.", ex)
        End Try

    End Sub

    Protected Overrides Sub SetCLH()
        MyBase.SetCLH()
        CLH.Components.Add(DataLayoutControl1)
    End Sub

    Private Function LoadWorkCentreCategories() As IEnumerable(Of API.WorkCentreCategory)
        Return API.WorkCentreCategory.FindAll
    End Function

    Private Function LoadWorkCentres() As IEnumerable(Of API.WorkCentre)
        If Me.Record.WorkCentreCategory IsNot Nothing Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.WorkCentre)()
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("WorkCentreCategory", Me.Record.WorkCentreCategory), NHibernate.Criterion.Expression.IsNull("WorkCentreCategory")))
            Return API.WorkCentre.FindAll(crit)
        Else
            Return API.WorkCentre.FindAll
        End If
    End Function

    Private Function LoadParts() As IEnumerable(Of API.Part)
        Return API.Part.FindAll
    End Function

    Private Function LoadSupplyScopes() As IEnumerable(Of API.SupplyScope)
        Return API.SupplyScope.FindAll
    End Function

    Private Function LoadVendors() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.Vendor)
        Return UniSource.Helper.ActiveRecord.Evolution.Vendor.FindAll
    End Function

    Private Function LoadVendorClasses() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.VendorClass)
        Return UniSource.Helper.ActiveRecord.Evolution.VendorClass.FindAll
    End Function

    Private Function LoadStockItems() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)
        '  Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
        If Me.Record.WorkCentreCategory IsNot Nothing AndAlso API.Context.Defaults.FilterInventoryOnGroup = True Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)()
            'crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("ItemGroup", Me.Record.WorkCentreCategory.Code), NHibernate.Criterion.Expression.IsEmpty("ItemGroup")))
            crit.Add(NHibernate.Criterion.Expression.Eq("ItemGroup", Me.Record.WorkCentreCategory.Code) Or NHibernate.Criterion.Expression.IsNull("ItemGroup") Or NHibernate.Criterion.Expression.Eq("ItemGroup", ""))
            If API.Context.Defaults.ActiveItemsOnly Then
                crit.Add(NHibernate.Criterion.Expression.Sql("ItemActive = 1"))
            End If
            Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll(crit)
        Else
            If API.Context.Defaults.ActiveItemsOnly Then
                Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)()
                crit.Add(NHibernate.Criterion.Expression.Sql("ItemActive = 1"))
                Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll(crit)
            Else
                Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
            End If
        End If
    End Function

    Private Sub WorkCentreLookupEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles WorkCentreLookupEdit.EditValueChanged
        Dim wc As API.WorkCentre = TryCast(WorkCentreLookupEdit.EditValue, API.WorkCentre)
        If wc IsNot Nothing Then
            Me.Record.WorkCentre = wc
            Try
                SetWorkCentre()
            Catch ex As Exception
                Setup.Log.logError("Error setting Work Centre.", ex)
            End Try
        End If
    End Sub

    Private Sub SetWorkCentre()
        If Me.Record.WorkCentre IsNot Nothing Then
            If Me.Record.WorkCentre.CalculationType = API.CalculationType.Recovery Then
                If StockItemBindingSource.List.Count > 0 Then
                    Me.Record.InventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where ii.Code IsNot Nothing AndAlso ii.Code.Trim = Me.Record.WorkCentre.RecoveryServiceCode.Trim Select ii).FirstOrDefault
                End If
                InventoryItemIDLookupEdit.Properties.ReadOnly = True
                UnitPriceSpinEdit.Properties.ReadOnly = False
            Else
                InventoryItemIDLookupEdit.Properties.ReadOnly = False
                UnitPriceSpinEdit.Properties.ReadOnly = False
            End If
        End If
    End Sub

    Protected Overrides Sub ValidationError(errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))
        MyBase.ValidationError(errors)
        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "WorkCentre" Then
                WorkCentreLookupEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "InventoryItem" Then
                InventoryItemIDLookupEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "Quantity" Then
                QuantitySpinEdit.ErrorText = errors(prop)(0)
            End If
        Next
    End Sub

    Private Sub WorkCentreCategoryLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkCentreCategoryLookUpEdit.EditValueChanged
        RefreshLookups()
    End Sub

    Private Sub RefreshLookups()
        If IIf(IsDBNull(WorkCentreCategoryLookUpEdit.EditValue), Nothing, WorkCentreCategoryLookUpEdit.EditValue) IsNot Nothing Then
            Me.Record.WorkCentreCategory = WorkCentreCategoryLookUpEdit.EditValue
            Try
                Dim wclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentre)(WorkCentreLookupEdit, xaeWorkCentre, AddressOf LoadWorkCentres, Me.Conversation)
            Catch ex As Exception
                Setup.Log.logError("Error setting lookup maintenance for Work Centres.", ex)
            End Try

            Try
                Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(InventoryItemIDLookupEdit, AddressOf LoadStockItems)

            Catch ex As Exception
                Setup.Log.logError("Error setting loader for Inventory Items.", ex)
            End Try
        End If
    End Sub



    Private Sub StockItemBindingSource_DataSourceChanged(sender As System.Object, e As System.EventArgs) Handles StockItemBindingSource.DataSourceChanged
        Dim i As Integer = StockItemBindingSource.List.Count
        If i > 0 Then
            i = i
        End If

    End Sub

    Private Sub StockItemBindingSource_ListChanged(sender As System.Object, e As System.ComponentModel.ListChangedEventArgs) Handles StockItemBindingSource.ListChanged
        Dim i As Integer = StockItemBindingSource.List.Count
        If i > 0 Then
            i = i
        End If
    End Sub
End Class

Public Class xaegJobTemplateLineLite
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.JobTemplateLine)
End Class