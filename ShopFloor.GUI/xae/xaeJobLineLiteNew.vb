Public Class xaeJobLineLiteNew
    Inherits xaegJobLineLiteNew

    'Public Sub New(ByVal jobline As API.JobLine)
    '    InitializeComponent()
    '    Me.Record = jobline
    '    'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    'End Sub

    'Public OverideRecord As API.JobLine

    Private Sub xaeJobLineLite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If OverideRecord IsNot Nothing Then
        '    Me.Record = OverideRecord
        '    Me.Record.Quantity = OverideRecord.Quantity
        '    Me.Refresh()
        'End If
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(Me, GetType(Helper.ActiveRecord.WaitForm), False, True)

        Try
            If IIf(Record.Job.IsApproved.HasValue, Record.Job.IsApproved, False) Then
                ItemForUnitPrice.Image = UniSource.Helper.GUI.My.Resources.Information
                ItemForUnitPrice.OptionsToolTip.ToolTip = "Job is Approved, changes will not calculate or affect pricing."
                ItemForTotalPrice.Image = UniSource.Helper.GUI.My.Resources.Information
                ItemForTotalPrice.OptionsToolTip.ToolTip = "Job is Approved, changes will not calculate or affect pricing."
            Else
                ItemForUnitPrice.Image = Nothing
                ItemForUnitPrice.OptionsToolTip.ToolTip = String.Empty
                ItemForTotalPrice.Image = Nothing
                ItemForTotalPrice.OptionsToolTip.ToolTip = String.Empty
            End If
        Catch ex As Exception
            Setup.Log.logError("Error displaying warning messages.", ex)
        End Try

        Try
            Dim wcclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentreCategory)(WorkCentreCategoryLookUpEdit, xaeWorkCentreCategory, AddressOf LoadWorkCentreCategories, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centre Categories.", ex)
        End Try

        'Try
        '    Dim wclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentre)(WorkCentreLookupEdit, xaeWorkCentre, AddressOf LoadWorkCentres, Me.Conversation)
        'Catch ex As Exception
        '    Setup.Log.logError("Error setting lookup maintenance for Work Centres.", ex)
        'End Try

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
            Dim sbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.Vendor)(Supplier1IDLookupEdit, AddressOf LoadVendors)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Suppliers.", ex)
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

        If Me.Record.ID > 0 Then
            Try
                SetWorkCentre()
            Catch ex As Exception
                Setup.Log.logError("Error setting Work Centre.", ex)
            End Try
        End If

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(False)

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
        'Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
        If Me.Record.WorkCentreCategory IsNot Nothing Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)()
            'crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("ItemGroup", Me.Record.WorkCentreCategory.Code), NHibernate.Criterion.Expression.IsEmpty("ItemGroup")))
            crit.Add(NHibernate.Criterion.Expression.Eq("ItemGroup", Me.Record.WorkCentreCategory.Code) Or NHibernate.Criterion.Expression.IsNull("ItemGroup") Or NHibernate.Criterion.Expression.Eq("ItemGroup", ""))
            Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll(crit)
        Else
            Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
        End If
    End Function

    Private Sub WorkCentreLookupEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkCentreLookupEdit.EditValueChanged
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
        If IIf(Me.Record.Job.IsApproved.HasValue, Me.Record.Job.IsApproved, False) Then
            MarkupFactorSpinEdit.Properties.ReadOnly = True
            MarkupPercentSpinEdit.Properties.ReadOnly = True
        Else
            MarkupFactorSpinEdit.Properties.ReadOnly = False
            MarkupPercentSpinEdit.Properties.ReadOnly = False
        End If
        If Me.Record.WorkCentre IsNot Nothing Then
            If Me.Record.WorkCentre.IsBuyOut Then
                BuyOutLayoutControlGroup.Enabled = True
                BuyOutLayoutControlGroup.Expanded = True
            Else
                BuyOutLayoutControlGroup.Enabled = False
                BuyOutLayoutControlGroup.Expanded = False
            End If
            If Me.Record.WorkCentre.CalculationType = API.CalculationType.Standard And Not IIf(IsNothing(Me.Record.WorkCentre.IsBuyOut), False, Me.Record.WorkCentre.IsBuyOut) Then
                LineDiscountSpinEdit.Properties.ReadOnly = False
            Else
                Me.Record.LineDiscountPercent = 0
                LineDiscountSpinEdit.Properties.ReadOnly = True
            End If
            If Me.Record.WorkCentre.CalculationType = API.CalculationType.Recovery Then
                If StockItemBindingSource.List.Count > 0 Then
                    Me.Record.InventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where ii.Code.Trim = Me.Record.WorkCentre.RecoveryServiceCode.Trim Select ii).FirstOrDefault
                End If
                InventoryItemIDLookupEdit.EditValue = Me.Record.InventoryItem
                InventoryItemIDLookupEdit.Properties.ReadOnly = True
                DurationSpinEdit.Properties.ReadOnly = False
            Else
                InventoryItemIDLookupEdit.Properties.ReadOnly = False
                DurationSpinEdit.Properties.ReadOnly = True
            End If
        End If
    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))
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
End Class

Public Class xaegJobLineLiteNew
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.JobLine)
End Class