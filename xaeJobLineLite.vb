Public Class xaeJobLineLite
    Inherits xaegJobLineLite

    Private Property IsBusyLoading As Boolean = True
    Private Property Load As Boolean = True

    Public Property CanEditDiscount As Boolean = False

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
        'DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(Me, GetType(Helper.ActiveRecord.WaitForm), False, True)



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

        Try
            Dim wclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentre)(WorkCentreLookupEdit, xaeWorkCentre, AddressOf LoadWorkCentres, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centres.", ex)
        End Try

        'Try
        '    Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(InventoryItemIDLookupEdit, AddressOf LoadStockItems)
        'Catch ex As Exception
        '    Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        'End Try


        'If Me.Record.ID > 0 Then
        Try
            SetWorkCentre()
            Load = False
        Catch ex As Exception
            Setup.Log.logError("Error setting Work Centre.", ex)
        End Try
        'End If

        If CanEditDiscount = True Then
            LineDiscountSpinEdit.Properties.ReadOnly = False
        Else
            LineDiscountSpinEdit.Properties.ReadOnly = True
        End If

        'DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(False)
        'Me.TopMost = True

        Try
            SetPermissions()
        Catch ex As Exception
            Setup.Log.logError("Error setting form permissions for agents.", ex)
        End Try

        IsBusyLoading = False
    End Sub

    Protected Overrides Sub SetCLH()
        MyBase.SetCLH()
        CLH.Components.Add(DataLayoutControl1)
    End Sub

    Private Sub SetPermissions()
        Dim gc As New UniSource.Security.ActiveRecord.GUIController(Me, Setup.ExtendedAgent.User)
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
            Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
        End If
    End Function

    Private Sub WorkCentreLookupEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkCentreLookupEdit.EditValueChanged
        Dim wc As API.WorkCentre = TryCast(WorkCentreLookupEdit.EditValue, API.WorkCentre)
        If wc IsNot Nothing Then

            If Load = False Then
                Me.Record.UnitPriceBeforeMarkup = 0
            End If


            Me.Record.WorkCentre = wc
            Try
                SetWorkCentre()
                If Load = False Then
                    Try
                        '  Dim Item As Helper.ActiveRecord.Evolution.StockItem = UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAllByProperty("Code", Me.Record.WorkCentre.RecoveryServiceCode.Trim).FirstOrDefault)
                        Dim Item As Helper.ActiveRecord.Evolution.StockItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where ii.Code.Trim = Me.Record.WorkCentre.RecoveryServiceCode.Trim Select ii).FirstOrDefault
                        Me.Record.Description1 = Item.Description1
                        Me.Description1TextEdit.Text = Me.Record.Description1
                        Me.Record.Description2 = Item.Description2
                        Me.Description2TextEdit.Text = Me.Record.Description2
                    Catch ex As Exception

                    End Try
                End If
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
            If Me.Record.WorkCentre.CalculationType = API.CalculationType.Standard AndAlso Not IIf(IsNothing(Me.Record.WorkCentre.IsBuyOut), False, Me.Record.WorkCentre.IsBuyOut) Then
                LineDiscountSpinEdit.Properties.ReadOnly = False
                Me.Record.MarkupPercent = 0
                MarkupPercentSpinEdit.Properties.ReadOnly = True
                If Me.LineDiscountSpinEdit.EditValue = 0 AndAlso Me.IsBusyLoading = False Then
                    Me.Record.LineDiscountPercent = Me.Record.Job.Customer.AutoDisc / 100
                End If
            Else
                Me.Record.LineDiscountPercent = 0
                LineDiscountSpinEdit.Properties.ReadOnly = True
            End If
            If Me.Record.WorkCentre.CalculationType = API.CalculationType.Recovery Then
                If StockItemBindingSource.List.Count > 0 Then
                    'Me.Record.InventoryItem = (From ii As Unisource.Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where ii.Code IsNot Nothing AndAlso ii.Code.Trim = Me.Record.WorkCentre.RecoveryServiceCode.Trim Select ii).FirstOrDefault
                End If
                Me.Record.InventoryItem = UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAllByProperty("Code", Me.Record.WorkCentre.RecoveryServiceCode.Trim).FirstOrDefault
                'InventoryItemIDLookupEdit.EditValue = Me.Record.InventoryItemID
                InventoryItemIDLookupEdit.Properties.ReadOnly = True
                DurationSpinEdit.Properties.ReadOnly = False
                If Me.Record.WorkCentre.IsBuyOut Then
                    UnitPriceBeforeMarkupSpinEdit.Properties.ReadOnly = True
                Else
                    UnitPriceBeforeMarkupSpinEdit.Properties.ReadOnly = False
                End If
            Else
                InventoryItemIDLookupEdit.Properties.ReadOnly = False
                DurationSpinEdit.Properties.ReadOnly = True
                UnitPriceBeforeMarkupSpinEdit.Properties.ReadOnly = True
            End If
            If Me.Record.WorkCentre.IsBuyOut = True And Me.Record.ISPOGenerated Then
                InventoryItemIDLookupEdit.Properties.ReadOnly = True
            End If
            If (Me.Record.WorkCentre.IsBuyOut = False Or Me.Record.WorkCentre.IsBuyOut Is Nothing) And Me.Record.ISRlGenerated = True Then
                InventoryItemIDLookupEdit.Properties.ReadOnly = True
            End If
            UnitPriceBeforeMarkupSpinEdit.Properties.ReadOnly = False
        End If
        If CanEditDiscount = True Then
            LineDiscountSpinEdit.Properties.ReadOnly = False
        Else
            LineDiscountSpinEdit.Properties.ReadOnly = True
        End If

    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        If IsDBNull(InventoryItemIDLookupEdit.EditValue) Then
            InventoryItemIDLookupEdit.ErrorText = "Please select a Inventory Item"
            'ElseIf InventoryItemIDLookupEdit.EditValue IsNot Nothing AndAlso CType(InventoryItemIDLookupEdit.EditValue, Helper.ActiveRecord.Evolution.StockItem).ItemActive = False Then
        ElseIf InventoryItemIDLookupEdit.EditValue IsNot Nothing AndAlso Me.Record.InventoryItem.ItemActive = False Then
            InventoryItemIDLookupEdit.ErrorText = "Inventory Item is not Active"
        End If
        If IsDBNull(WorkCentreLookupEdit.EditValue) Then
            WorkCentreLookupEdit.ErrorText = "Please Select a Work Centre"
        ElseIf WorkCentreLookupEdit.EditValue IsNot Nothing AndAlso CType(WorkCentreLookupEdit.EditValue, API.WorkCentre).IsBuyOut = True Then
            If Supplier1IDLookupEdit.EditValue Is Nothing Then
                Supplier1IDLookupEdit.ErrorText = "Please Select a Supplier"
            End If
        End If

        If errors IsNot Nothing Then
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
        End If
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

    Private Sub LineDiscountSpinEdit_Properties_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineDiscountSpinEdit.EditValueChanged
        'If LineDiscountSpinEdit.EditValue IsNot Nothing AndAlso LineDiscountSpinEdit.EditValue <> Record.LineDiscountPercent Then
        '    Dim defs As API.Defaults = API.Defaults.Defaults
        '    If defs.IsSellingPriceGPChecked = True Then
        '        If Record.UnitCost IsNot Nothing AndAlso Record.LineDiscountPercent IsNot Nothing AndAlso Record.LineDiscountPercent > 0 AndAlso Record.UnitCost > 0 Then
        '            Dim GPPercentage As Double = ((Record.UnitPrice - Record.UnitCost) / Record.UnitCost) '* 100
        '            If GPPercentage < defs.SellingPriceGPPercentage Then
        '                Dim tmpLineDiscountPercent As Double = Record.LineDiscountPercent
        '                Dim NewLineDiscountPercent As Double = (Record.UnitPriceBeforeDiscount - (Record.UnitCost * (1 + defs.SellingPriceGPPercentage))) / Record.UnitPriceBeforeDiscount
        '                Record.LineDiscountPercent = Math.Truncate(NewLineDiscountPercent * 100) / 100
        '                Record.UnitPrice = Record.UnitPriceBeforeDiscount * (1 - Record.LineDiscountPercent)
        '                UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Discout changed from {0}% to {1}% as it was set to high.", tmpLineDiscountPercent * 100, Record.LineDiscountPercent * 100))
        '                'NotifyPropertyChanged("LineDiscountPercent")
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub QuantitySpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantitySpinEdit.Enter
        SetDiscountValue()
    End Sub
    Private Sub SetDiscountValue()
        If LineDiscountSpinEdit.EditValue IsNot Nothing AndAlso LineDiscountSpinEdit.EditValue <> Record.LineDiscountPercent Then
            LineDiscountSpinEdit.EditValue = Record.LineDiscountPercent
        End If
    End Sub

    Private Sub WorkCentreCategoryLookUpEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub WorkCentreLookupEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub SupplyScopeLookupEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplyScopeLookupEdit.Enter
        SetDiscountValue()
    End Sub

    Private Sub InventoryItemIDLookupEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryItemIDLookupEdit.Enter
        SetDiscountValue()
    End Sub

    Private Sub Description1TextEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Description1TextEdit.Enter
        SetDiscountValue()
    End Sub

    Private Sub DurationSpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub UnitPriceBeforeMarkupSpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub MarkupPercentSpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarkupPercentSpinEdit.Enter
        SetDiscountValue()
    End Sub

    Private Sub UnitPriceSpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub TotalPriceSpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub StockItemBindingSource_DataSourceChanged(sender As System.Object, e As System.EventArgs) Handles StockItemBindingSource.DataSourceChanged

    End Sub

    Private Sub StockItemBindingSource_ListChanged(sender As System.Object, e As System.ComponentModel.ListChangedEventArgs) Handles StockItemBindingSource.ListChanged

    End Sub

    Private Sub InventoryItemIDLookupEdit_Edit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryItemIDLookupEdit.EditValueChanged
        'If Load = False Then
        '    Try
        '        Dim Item As Helper.ActiveRecord.Evolution.StockItem = UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAllByProperty("Code", InventoryItemIDLookupEdit.Text).FirstOrDefault

        '        Me.Record.InventoryItem = UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAllByProperty("Code", InventoryItemIDLookupEdit.Text).FirstOrDefault


        '        Me.Record.Description1 = Item.Description1
        '        Me.Description1TextEdit.Text = Item.Description1
        '        Me.Record.Description2 = Item.Description2
        '        Me.Description2TextEdit.Text = Item.Description2
        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub
End Class

Public Class xaegJobLineLite
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.JobLine)
End Class
