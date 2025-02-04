Imports System.Data.SqlClient

Public Class xaeJobLineLite
    Inherits xaegJobLineLite
    Private Property IsBusyLoading As Boolean = True
    Private Property Load As Boolean = True
    Dim ErrorLevel As String = ""
    Dim asset1 As API.Asset
    Dim loaded As Boolean
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
            Dim sbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.Accounts)(AccountLookup, AddressOf LoadAccounts)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Accounts.", ex)
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

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster)(WarehouseLookUpEdit, AddressOf LoadWarehouses, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Warehouses.", ex)
        End Try

        Try
            Dim cclm As New Helper.ActiveRecord.LookupMaintenance(Of API.EvoProject)(ProjectLookUpEdit1, Nothing, AddressOf LoadAllProjects, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Cost Centres.", ex)
        End Try

        Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(InventoryItemIDLookupEdit, AddressOf LoadStockItems)
        LoadAccountGroups()
        Try
            Dim wclm As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(AssetLookUpEdit, xaeAssets, AddressOf LoadJobsAssets, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centres.", ex)
        End Try
        'If Me.Record.ID > 0 Then
        Try
            SetWorkCentre()
            Load = False
        Catch ex As Exception
            If ex.Message.ToString.ToLower.Contains("bindingsource cannot be its own data source") Then
                'Setup.Log.logError("Would have shown ", ex)
                ' SetWorkCentre()
            Else
                Setup.Log.logError("Error setting Work Centre: " & ErrorLevel, ex)
            End If
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

    Private Function LoadAllProjects() As IEnumerable(Of API.EvoProject)
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.EvoProject)()
        crit.Add(NHibernate.Criterion.Expression.Sql("Active=1"))
        Return API.EvoProject.FindAll(crit)
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

    Private Function LoadJobsAssets() As IEnumerable(Of API.Asset)
        Dim SQLString As String = "Exec GetAllAssetCodesForJob " & Me.Record.Job.ID
        ' SQLString = SQLString.Replace("@ID", Me.Record.Job.ID)
        Dim MyAppCon As SqlConnection = New SqlConnection(ShopFloor.API.ActiveConnection.Company.ConnectionString)
        MyAppCon.Open()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand(SQLString, MyAppCon)
        Dim AssetList As String = cmd.ExecuteScalar
        'crit.Add(NHibernate.Criterion.Expression.Eq("ItemGroup", Me.Record.WorkCentreCategory.Code) Or NHibernate.Criterion.Expression.IsNull("ItemGroup") Or NHibernate.Criterion.Expression.Eq("ItemGroup", ""))
        '' Dim AssetList As String = Pastel.Evolution.DatabaseContext.ExecuteCommandScalar(SQLString)
        'crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("WorkCentreCategory", Me.Record.WorkCentreCategory), NHibernate.Criterion.Expression.IsNull("WorkCentreCategory")))
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()
        crit.Add(NHibernate.Criterion.Expression.Sql("Id in (" & AssetList & ")"))
        'For Each value In AssetList.Split(";")
        '    If value <> "0" Then
        '        crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Sql("Id in ('" & value & "')")))
        '    End If
        'Next

        Return API.Asset.FindAll(crit)

    End Function

    Private Function LoadParts() As IEnumerable(Of API.Part)
        Return API.Part.FindAll
    End Function

    Private Function LoadWarehouses() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster)

        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster)()
        Dim addInWarehouseID As String = ""
        If Me.Record IsNot Nothing Then
            If Me.Record.WarehouseID IsNot Nothing AndAlso Me.Record.WarehouseID <> "" AndAlso Me.Record.ID > 0 Then
                addInWarehouseID = String.Format(",{0}", Me.Record.WarehouseID)
            End If

            If API.Context.AgentActiveWriter IsNot Nothing Then
                If API.Context.AgentActiveWriter.CAccessSalesWhChkLstInd = 0 Then
                    crit.Add(NHibernate.Criterion.Expression.Sql(String.Format("WhseLink in(-1{0})", addInWarehouseID)))
                ElseIf API.Context.AgentActiveWriter.CAccessSalesWhChkLstInd = 1 Then
                    crit.Add(NHibernate.Criterion.Expression.Sql(String.Format("WhseLink In ({0}{1})", API.Context.AgentActiveWriter.CAccessSalesWhIDLst, addInWarehouseID)))
                End If
            End If
            If Me.Record.InventoryItem IsNot Nothing AndAlso Me.Record.InventoryItem.ServiceItem = False Then
                If Me.Record.InventoryItem.WarehouseStocklist IsNot Nothing AndAlso Me.Record.InventoryItem.WarehouseStocklist.Count() > 0 Then
                    Dim WarehouseStockIDs As String = ""
                    For Each WarehouseStock In Me.Record.InventoryItem.WarehouseStocklist
                        WarehouseStockIDs += String.Format("{0},", WarehouseStock.WarehouseID.ToString())
                    Next
                    WarehouseStockIDs = WarehouseStockIDs.Substring(0, WarehouseStockIDs.Length - 1)
                    crit.Add(NHibernate.Criterion.Expression.Sql(String.Format("WhseLink In ({0}{1})", WarehouseStockIDs, addInWarehouseID)))
                End If
            End If
        End If
        Return UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster.FindAll(crit)

    End Function

    Private Function LoadSupplyScopes() As IEnumerable(Of API.SupplyScope)
        Return API.SupplyScope.FindAll
    End Function

    Private Function LoadVendors() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.Vendor)
        Return UniSource.Helper.ActiveRecord.Evolution.Vendor.FindAll
    End Function

    Private Function LoadAccounts() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.Accounts)
        Return UniSource.Helper.ActiveRecord.Evolution.Accounts.FindAll
    End Function
    Private Function LoadAccountGroups()
        Dim AccountGroupList As String = Pastel.Evolution.DatabaseContext.ExecuteCommandScalar("SELECT cLookupOptions  FROM [dbo].[_rtblUserDict] where cFieldName ='ulGLAccountGroup'")
        Dim Dt As New DataTable
        Dt.Columns.Add("Group")
        For Each value In AccountGroupList.Split(";")
            Dim row As DataRow = Dt.NewRow
            row(0) = value
            Dt.Rows.Add(row)
        Next
        Dt = Dt
        AccountGroupLookUpEdit1.Properties.DataSource = Dt
        AccountGroupLookUpEdit1.Properties.DisplayMember = "Group"
        AccountGroupLookUpEdit1.Properties.ValueMember = "Group"
    End Function
    Private Function ConfirmWarehouseStock()
        Try
            Dim ID As Integer = InventoryItemIDLookupEdit.EditValue
            Dim IsWareHouseError As Boolean = False
            If ID > 0 Then
                Dim StockItem As Pastel.Evolution.InventoryItem = New Pastel.Evolution.InventoryItem(ID)
                If StockItem.IsServiceItem = False AndAlso Me.Record.WorkCentre.CalculationType = API.CalculationType.Standard Then
                    If StockItem.IsWarehouseTracked = True Then
                        'StockItem.WarehouseContexts
                        Dim SODetail As New Pastel.Evolution.OrderDetail
                        QuantityTextEdit.EditValue = ""
                        WarehouseNameTextEdit1.EditValue = ""
                        SODetail.InventoryItem = StockItem
                        Dim WID As Integer = WarehouseLookUpEdit.EditValue
                        Try
                            SODetail.Warehouse = New Pastel.Evolution.Warehouse(WID)
                        Catch ex As Exception
                            Setup.Log.logError("Error setting Warehouse.", ex)
                            QuantityTextEdit.EditValue = ""

                            WarehouseLookUpEdit.Focus()
                            IsWareHouseError = True
                        End Try
                        If IsWareHouseError = False Then
                            Dim WarehouseDescription As String = SODetail.Warehouse.Description
                            Dim freestock = SODetail.WarehouseContext.QtyOnHand - SODetail.WarehouseContext.QtyWIP
                            QuantityTextEdit.EditValue = freestock
                        End If
                    Else
                        QuantityTextEdit.ErrorText = "Stock Item is not Warehouse Tracked"
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

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

    Private Sub WorkCentreLookupEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim wc As API.WorkCentre = TryCast(WorkCentreLookupEdit.EditValue, API.WorkCentre)
        If wc IsNot Nothing Then

            If Load = False Then
                Me.Record.UnitPriceBeforeMarkup = 0

                If wc.HourlyRate > 0 And wc.GLExpense = True Then
                    Me.Record.UnitPriceBeforeMarkup = wc.HourlyRate
                    UnitPriceBeforeMarkupSpinEdit.EditValue = Me.Record.UnitPriceBeforeMarkup
                End If

            End If
            Me.Record.WorkCentre = wc
            Try
                SetWorkCentre()

                If Me.Record.WorkCentre.GLExpense AndAlso Load = False Then
                    Try
                        ' If Me.Record.GLAccount Is Nothing Or Me.Record.GLAccount = "" Then
                        Dim TransCode As Pastel.Evolution.JobTransactionCode
                        TransCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Ledger, Me.Record.WorkCentre.CostCentre.TransactionCode)
                        AccountLookup.EditValue = TransCode.RecoveryAccount.Code
                        AccountLookup.SelectedText = TransCode.RecoveryAccount.Code
                        Me.Record.GLAccount = TransCode.RecoveryAccount.Code
                        '  End If

                    Catch ex As Exception
                    End Try
                End If


                If Load = False Then
                    Try
                        '  Dim Item As Helper.ActiveRecord.Evolution.StockItem = UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAllByProperty("Code", Me.Record.WorkCentre.RecoveryServiceCode.Trim).FirstOrDefault)
                        Dim Item As Helper.ActiveRecord.Evolution.StockItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where ii.Code.Trim = Me.Record.WorkCentre.RecoveryServiceCode.Trim Select ii).FirstOrDefault

                        If Not Me.Record.WorkCentre.GLExpense Then
                            Me.Record.Description1 = Item.Description1
                            Me.Description1TextEdit.Text = Me.Record.Description1
                            Me.Record.Description2 = Item.Description2
                            Me.Description2TextEdit.Text = Me.Record.Description2
                        End If

                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception
                Setup.Log.logError("Error setting Work Centre.", ex)
            End Try
        End If
    End Sub

    Private Sub SetWorkCentre()
        ErrorLevel = "0"
        If IIf(Me.Record.Job.IsApproved.HasValue, Me.Record.Job.IsApproved, False) Then
            ErrorLevel = "0.1"
            MarkupFactorSpinEdit.Properties.ReadOnly = True
            MarkupPercentSpinEdit.Properties.ReadOnly = True
        Else
            ErrorLevel = "0.2 - "
            MarkupFactorSpinEdit.Properties.ReadOnly = False
            MarkupPercentSpinEdit.Properties.ReadOnly = False
        End If
        ErrorLevel = "1.1"
        If Me.Record.WorkCentre IsNot Nothing Then

            ' ItemForAccount.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            InventoryItemIDLookupEdit.Enabled = True
            Dim showBuyout As Boolean
            Dim BuyoutText As String
            ErrorLevel = "1"
            If Me.Record.WorkCentre.IsBuyOut Then
                showBuyout = True
                BuyoutText = "Buy Out"
                ItemForSupplier1ID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForPurchasePrice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForSupplierTypeID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForUnitCost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForPurchaseDiscountPercent.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemControlForAccount.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                ItemForAccountGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If
            ErrorLevel = "2"
            If Me.Record.WorkCentre.GLExpense Then
                showBuyout = True
                ItemForSupplier1ID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                ItemForPurchasePrice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                ItemForSupplierTypeID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                ItemForUnitCost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForPurchaseDiscountPercent.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never



                ItemControlForAccount.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForAccountGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                InventoryItemIDLookupEdit.Enabled = False
                InventoryItemIDLookupEdit.Properties.ReadOnly = True
                BuyoutText = "GL Expense"

                'Try
                '    If Me.Record.GLAccount Is Nothing Or Me.Record.GLAccount = "" Then
                '        Dim TransCode As Pastel.Evolution.JobTransactionCode
                '        TransCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Ledger, Me.Record.WorkCentre.CostCentre.TransactionCode)
                '        AccountLookup.EditValue = TransCode.RecoveryAccount.Code
                '        AccountLookup.SelectedText = TransCode.RecoveryAccount.Code
                '        Me.Record.GLAccount = TransCode.RecoveryAccount.Code
                '    End If

                'Catch ex As Exception


                'End Try
            End If
            ErrorLevel = "3"
            If Me.Record.WorkCentre.APExpense Then
                showBuyout = True
                ItemForSupplier1ID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForPurchasePrice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForSupplierTypeID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForUnitCost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForPurchaseDiscountPercent.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemControlForAccount.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                ItemForAccountGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

                InventoryItemIDLookupEdit.Properties.ReadOnly = True
                BuyoutText = "AP Expense"
            End If

            If Not Me.Record.WorkCentre.APExpense AndAlso Not Me.Record.WorkCentre.GLExpense AndAlso Me.Record.WorkCentre.CalculationType.Standard Then

            End If

            ErrorLevel = "4"
            If showBuyout = True Then
                BuyOutLayoutControlGroup.Enabled = True
                BuyOutLayoutControlGroup.Expanded = True
                BuyOutLayoutControlGroup.Text = BuyoutText
            Else
                BuyOutLayoutControlGroup.Enabled = False
                BuyOutLayoutControlGroup.Expanded = False
            End If
            ErrorLevel = "5"
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
            ErrorLevel = "6"
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
            ErrorLevel = "7"
            If Me.Record.WorkCentre.IsBuyOut = True And Me.Record.ISPOGenerated Then
                InventoryItemIDLookupEdit.Properties.ReadOnly = True

            End If
            ErrorLevel = "8"
            If (Me.Record.WorkCentre.IsBuyOut = False Or Me.Record.WorkCentre.IsBuyOut Is Nothing) And Me.Record.ISRlGenerated = True Then
                InventoryItemIDLookupEdit.Properties.ReadOnly = True
            End If
            ErrorLevel = "9"
            UnitPriceBeforeMarkupSpinEdit.Properties.ReadOnly = False

            If Me.Record.WorkCentre.APExpense = True Or Me.Record.WorkCentre.GLExpense = True Then
                Me.Record.InventoryItem = UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAllByProperty("Code", "JOBPRO").FirstOrDefault
                InventoryItemIDLookupEdit.Properties.ReadOnly = True
            End If
            ErrorLevel = "10"
        End If
        If CanEditDiscount = True Then
            LineDiscountSpinEdit.Properties.ReadOnly = False
        Else
            LineDiscountSpinEdit.Properties.ReadOnly = True
        End If
        ErrorLevel = "11"

        If Me.Record.WorkCentre IsNot Nothing Then
            If Me.Record.WorkCentre.GLExpense Then
                Me.Record.Description1 = Me.Record.WorkCentre.Description
                Description1TextEdit.EditValue = Me.Record.WorkCentre.Description
            End If


            If Me.Record.WorkCentre.UsageRequired = True Then
                txtAssetUsage.Enabled = True
                '     AssetLookUpEdit.Enabled = True
                txtAsset2Usage.Enabled = True
                '     Asset2LookUpEdit.Enabled = True

            Else
                txtAssetUsage.Enabled = False
                txtAssetUsage.EditValue = 0
                '      AssetLookUpEdit.Enabled = False

                txtAsset2Usage.Enabled = False
                ' txtAsset2Usage.EditValue = 0
                '     Asset2LookUpEdit.Enabled = False
            End If
        End If

        'If Me.Record.WorkCentre.APExpense Or Me.Record.WorkCentre.GLExpense Then
        '    WarehouseLookUpEdit.Enabled = False
        'Else
        '    WarehouseLookUpEdit.Enabled = True
        'End If


    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        If Me.Record.WorkCentre IsNot Nothing AndAlso Me.Record.WorkCentre.APExpense = False AndAlso Me.Record.WorkCentre.GLExpense = False Then
            If IsDBNull(InventoryItemIDLookupEdit.EditValue) AndAlso (Me.Record.WorkCentre.APExpense) Then
                InventoryItemIDLookupEdit.ErrorText = "Please select a Inventory Item"
                'ElseIf InventoryItemIDLookupEdit.EditValue IsNot Nothing AndAlso CType(InventoryItemIDLookupEdit.EditValue, Helper.ActiveRecord.Evolution.StockItem).ItemActive = False Then
            ElseIf InventoryItemIDLookupEdit.EditValue IsNot Nothing AndAlso Me.Record.InventoryItem.ItemActive = False Then
                InventoryItemIDLookupEdit.ErrorText = "Inventory Item is not Active"
            End If
        End If

        If IsDBNull(WorkCentreLookupEdit.EditValue) Then
            WorkCentreLookupEdit.ErrorText = "Please Select a Work Centre"
        ElseIf WorkCentreLookupEdit.EditValue IsNot Nothing AndAlso CType(WorkCentreLookupEdit.EditValue, API.WorkCentre).IsBuyOut = True Then
            If Supplier1IDLookupEdit.EditValue Is Nothing Then
                Supplier1IDLookupEdit.ErrorText = "Please Select a Supplier"
            End If
        End If

        If Me.Record.WorkCentre IsNot Nothing AndAlso Record.WorkCentre.UsageRequired = True Then

            If (txtAssetUsage.EditValue <= 0 Or txtAssetUsage Is Nothing) Then 'And (txtAsset2Usage.EditValue <= 0 Or txtAsset2Usage Is Nothing) Then
                txtAssetUsage.ErrorText = "Primary Asset Usage is required for this Work Centre"
            End If
            'Tawanda Equipment One 1

            If Record.Job.EquipamentoNo1 IsNot Nothing Then
                If Record.AssetID = Record.Job.EquipamentoNo1 Then
                    If txtAssetUsage.EditValue < Me.Record.Job.Eq1UsageBefore Then
                        txtAssetUsage.ErrorText = "The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura."
                    End If
                End If
                If Record.Asset2ID = Record.Job.EquipamentoNo1 Then
                    If txtAsset2Usage.EditValue < Me.Record.Job.Eq1UsageBefore Then
                        txtAsset2Usage.ErrorText = "The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura."
                    End If
                End If
            End If

            'Equipment Two
            If Record.Job.EquipamentoNo2 IsNot Nothing Then
                If Record.AssetID = Record.Job.EquipamentoNo2 Then
                    If txtAssetUsage.EditValue < Me.Record.Job.Eq2UsageBefore Then
                        txtAssetUsage.ErrorText = "The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura."
                    End If
                End If
                If Record.Asset2ID = Record.Job.EquipamentoNo2 Then
                    If txtAsset2Usage.EditValue < Me.Record.Job.Eq2UsageBefore Then
                        txtAsset2Usage.ErrorText = "The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura."
                    End If
                End If
            End If

            'Equipment 3
            If Record.Job.EquipamentoNo3 IsNot Nothing Then
                If Record.AssetID = Record.Job.EquipamentoNo3 Then
                    If txtAssetUsage.EditValue < Me.Record.Job.Eq3UsageBefore Then
                        txtAssetUsage.ErrorText = "The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura."

                    End If
                End If
                If Record.Asset2ID = Record.Job.EquipamentoNo3 Then
                    If txtAsset2Usage.EditValue < Me.Record.Job.Eq3UsageBefore Then
                        txtAsset2Usage.ErrorText = "The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura."
                    End If
                End If
            End If
            'Equipment 4
            If Record.Job.EquipamentoNo4 IsNot Nothing Then
                If Record.AssetID = Record.Job.EquipamentoNo4 Then
                    If txtAssetUsage.EditValue < Me.Record.Job.Eq4UsageBefore Then
                        txtAssetUsage.ErrorText = "The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura."

                    End If
                End If
                If Record.Asset2ID = Record.Job.EquipamentoNo4 Then
                    If txtAsset2Usage.EditValue < Me.Record.Job.Eq4UsageBefore Then
                        txtAsset2Usage.ErrorText = "The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura."
                    End If
                End If
            End If
            'Equipment 5
            If Record.Job.EquipamentoNo5 IsNot Nothing Then
                If Record.AssetID = Record.Job.EquipamentoNo5 Then
                    If txtAssetUsage.EditValue < Me.Record.Job.Eq5UsageBefore Then
                        txtAssetUsage.ErrorText = "The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura."

                    End If
                End If
                If Record.Asset2ID = Record.Job.EquipamentoNo5 Then
                    If txtAsset2Usage.EditValue < Me.Record.Job.Eq5UsageBefore Then
                        txtAsset2Usage.ErrorText = "The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura."
                    End If
                End If
            End If

            'Tawanda Commnet 31/10/2019
            If AssetLookUpEdit.EditValue Is Nothing AndAlso IsDBNull(AssetLookUpEdit.EditValue) = False Then
                AssetLookUpEdit.ErrorText = "Please select Asset"

                If Asset2LookUpEdit.EditValue IsNot Nothing AndAlso IsDBNull(Asset2LookUpEdit.EditValue) = False Then
                    AssetLookUpEdit.ErrorText = "Primary Asset must be set"
                End If
            End If

        End If

        If txtAsset2Usage.EditValue IsNot Nothing AndAlso IsDBNull(txtAsset2Usage.EditValue) = False Then
            If Asset2LookUpEdit.EditValue Is Nothing AndAlso IsDBNull(Asset2LookUpEdit.EditValue) = True Then
                Asset2LookUpEdit.ErrorText = "Please select a Asset"
            End If

        End If



        If Me.Record.WorkCentre IsNot Nothing AndAlso Record.WorkCentre.APExpense = True AndAlso Me.Record.Supplier1ID Is Nothing Then
            Supplier1IDLookupEdit.ErrorText = "Please select Supplier"
        End If

        If Me.Record.WorkCentre IsNot Nothing AndAlso (Record.WorkCentre.GLExpense = True AndAlso (Me.Record.GLAccount Is Nothing Or Me.Record.GLAccount = "")) Then
            AccountLookup.ErrorText = "Please select Account"
        End If

        If Me.Record.WorkCentre IsNot Nothing AndAlso Record.WorkCentre.IsBuyOut Then
            If Record.InventoryItem.ServiceItem = False Then
                If Record.WarehouseID = 0 Or Record.WarehouseID Is Nothing Then
                    WarehouseLookUpEdit.ErrorText = "Please select warehouse"
                End If
            End If

            If Record.InventoryItem.ServiceItem = True Then
                If Record.UnitCost < 0 Then
                    UnitCostSpinEdit.ErrorText = "Invalid Cost Value"
                End If
            End If
        End If

        If Record.AssetID = Record.Asset2ID Then
            Asset2LookUpEdit.ErrorText = "Seconday Asset cannot be the same as Primary Asset"
        End If


        If errors IsNot Nothing Then
            MyBase.ValidationError(errors)
            ' Dim propDelete As Reflection.PropertyInfo

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
                ' If prop.Name = "InventoryItemID" AndAlso (Me.Record.WorkCentre.APExpense = True Or Me.Record.WorkCentre.GLExpense = True) Then
                'propDelete = prop
                'End If
            Next
            ' errors.Remove(propDelete)
        End If

        'Tawanda 



        'Dim PrimaryLineItemsCount As Integer = 0
        'For Each jobline As API.JobLine In Me.Record.Job.JobLines
        '    If jobline.WorkCentre.PrimaryService Then
        '        PrimaryLineItemsCount = PrimaryLineItemsCount + 1
        '    End If
        'Next

        'If PrimaryLineItemsCount > 1 Then
        '    WorkCentreLookupEdit.ErrorText = "Mulitple Primary Servce's exist, only one Primary Service is allowed per Job"
        'End If

    End Sub

    Private Sub WorkCentreCategoryLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub LineDiscountSpinEdit_Properties_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub QuantitySpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub SupplyScopeLookupEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub InventoryItemIDLookupEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub Description1TextEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub DurationSpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub UnitPriceBeforeMarkupSpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub MarkupPercentSpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub UnitPriceSpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub TotalPriceSpinEdit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDiscountValue()
    End Sub

    Private Sub StockItemBindingSource_DataSourceChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub StockItemBindingSource_ListChanged(sender As System.Object, e As System.ComponentModel.ListChangedEventArgs)

    End Sub

    Private Sub InventoryItemIDLookupEdit_Edit(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        'ConfirmWarehouseStock()
    End Sub

    Private Sub WarehouseLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs)
        'ConfirmWarehouseStock()
    End Sub

    Private Sub AccountGroupLookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs)
        Try
            Dim sbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.Accounts)(AccountLookup, AddressOf GetAccountsFromGroup)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Accounts.", ex)
        End Try

    End Sub

    Private Function GetAccountsFromGroup() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.Accounts)
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of UniSource.Helper.ActiveRecord.Evolution.Accounts)()

        If AccountGroupLookUpEdit1.EditValue IsNot Nothing AndAlso IsDBNull(AccountGroupLookUpEdit1.EditValue) = False Then
            If AccountGroupLookUpEdit1.EditValue = "none" Then
                crit.Add(NHibernate.Criterion.Expression.Sql("ulGLAccountGroup is not null or ulGLAccountGroup is null"))
            Else
                crit.Add(NHibernate.Criterion.Expression.Sql("ulGLAccountGroup = '" & AccountGroupLookUpEdit1.EditValue & "'"))
            End If
        End If
        Return UniSource.Helper.ActiveRecord.Evolution.Accounts.FindAll(crit)

    End Function

    Private Sub AssetLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs)
        Try
            If IsBusyLoading = False Then
                If AssetLookUpEdit.EditValue IsNot Nothing AndAlso IsDBNull(AssetLookUpEdit.EditValue) = False Then
                    Me.Record.AssetID = AssetLookUpEdit.EditValue
                    asset1 = New API.Asset().Find(AssetLookUpEdit.EditValue)
                    Dim sqlstring As String = "select top 1 id from ussEvoProject where Code='" & asset1.AssetCode & "'"

                    Dim ProjectID As String = Pastel.Evolution.DatabaseContext.ExecuteCommandScalar(sqlstring)

                    If ProjectID IsNot Nothing AndAlso ProjectID <> "" Then
                        Me.Record.ProjectID = ProjectID
                    End If
                Else
                    Me.Record.AssetID = asset1.ID
                    AssetLookUpEdit.EditValue = asset1.ID
                    asset1 = Nothing
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InventoryItemIDLookupEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles InventoryItemIDLookupEdit.EditValueChanged
        'ConfirmWarehouseStock()
        
    End Sub

    Private Sub WarehouseLookUpEdit_EditValueChanged_1(sender As System.Object, e As System.EventArgs)
        ' ConfirmWarehouseStock()
    End Sub

    Private Sub WorkCentreLookupEdit_EditValueChanged_1(sender As System.Object, e As System.EventArgs) Handles WorkCentreLookupEdit.EditValueChanged
        Dim wc As API.WorkCentre = TryCast(WorkCentreLookupEdit.EditValue, API.WorkCentre)
        If wc IsNot Nothing Then

            If Load = False Then
                Me.Record.UnitPriceBeforeMarkup = 0

                If wc.HourlyRate > 0 And wc.GLExpense = True Then
                    Me.Record.UnitPriceBeforeMarkup = wc.HourlyRate
                    UnitPriceBeforeMarkupSpinEdit.EditValue = Me.Record.UnitPriceBeforeMarkup
                End If

            End If
            Me.Record.WorkCentre = wc
            Try
                SetWorkCentre()

                If Me.Record.WorkCentre.GLExpense AndAlso Load = False Then
                    Try
                        ' If Me.Record.GLAccount Is Nothing Or Me.Record.GLAccount = "" Then
                        Dim TransCode As Pastel.Evolution.JobTransactionCode
                        TransCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Ledger, Me.Record.WorkCentre.CostCentre.TransactionCode)
                        AccountLookup.EditValue = TransCode.RecoveryAccount.Code
                        AccountLookup.SelectedText = TransCode.RecoveryAccount.Code
                        Me.Record.GLAccount = TransCode.RecoveryAccount.Code
                        '  End If

                    Catch ex As Exception
                    End Try
                End If


                If Load = False Then
                    Try
                        '  Dim Item As Helper.ActiveRecord.Evolution.StockItem = UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAllByProperty("Code", Me.Record.WorkCentre.RecoveryServiceCode.Trim).FirstOrDefault)
                        Dim Item As Helper.ActiveRecord.Evolution.StockItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where ii.Code.Trim = Me.Record.WorkCentre.RecoveryServiceCode.Trim Select ii).FirstOrDefault

                        If Not Me.Record.WorkCentre.GLExpense Then
                            Me.Record.Description1 = Item.Description1
                            Me.Description1TextEdit.Text = Me.Record.Description1
                            Me.Record.Description2 = Item.Description2
                            Me.Description2TextEdit.Text = Me.Record.Description2
                        End If

                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception
                Setup.Log.logError("Error setting Work Centre.", ex)
            End Try
        End If
    End Sub

    Private Sub WarehouseLookUpEdit_Leave(sender As System.Object, e As System.EventArgs)
        ConfirmWarehouseStock()
    End Sub

    Private Sub InventoryItemIDLookupEdit_Leave(sender As System.Object, e As System.EventArgs) Handles InventoryItemIDLookupEdit.Leave
        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster)(WarehouseLookUpEdit, AddressOf LoadWarehouses, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Warehouses.", ex)
        End Try
    End Sub

    Private Sub AccountGroupLookUpEdit1_EditValueChanged_1(sender As System.Object, e As System.EventArgs) Handles AccountGroupLookUpEdit1.EditValueChanged
        
    End Sub
End Class

Public Class xaegJobLineLite
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.JobLine)
End Class
