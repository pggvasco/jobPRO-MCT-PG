Imports System.Globalization

Public Class xaeJoblineTime
    Inherits xaegJobLineTime

    'Public Sub New(ByVal jobline As API.JobLine)
    '    InitializeComponent()
    '    Me.Record = jobline
    '    'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    'End Sub

    'Public OverideRecord As API.JobLine

    Private Sub LoadEnums()
        RateTypeLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.RateType))
        BillingTypeLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.BillingType))
        InvoiceRunLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.OptionInvoiceRun))
        PaymentRunLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.OptionInvoiceRun))
    End Sub


    Private Sub RefreshLookups()
        If IIf(IsDBNull(WorkCentreCategoryLookUpEdit.EditValue), Nothing, WorkCentreCategoryLookUpEdit.EditValue) IsNot Nothing Then
            Me.Record.CustomerWorkCentreCategory = WorkCentreCategoryLookUpEdit.EditValue
            Try
                Dim wclm As New Helper.GUI.LookupBackgroundLoader(Of API.CustomerJobClass)(WorkCentreLookUpEdit, AddressOf LoadWorkCentres)
            Catch ex As Exception
                Setup.Log.logError("Error setting lookup maintenance for Work Centres.", ex)
            End Try

            Try
                Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(InventoryItemIDLookUpEdit, AddressOf LoadStockItems)
            Catch ex As Exception
                Setup.Log.logError("Error setting loader for Inventory Items.", ex)
            End Try
        End If
    End Sub
    Private Function LoadWorkCentreCategories() As IEnumerable(Of API.CustomerWorkCentreCategory)
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.CustomerWorkCentreCategory)()
        crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Customer", Me.Record.Job.CustomerTime), NHibernate.Criterion.Expression.IsNull("Customer")))
        Return API.CustomerWorkCentreCategory.FindAll(crit)
        'Return API.CustomerWorkCentreCategory.FindAll
    End Function

    Private Function LoadWorkCentres() As IEnumerable(Of API.CustomerJobClass)
        If Me.Record.CustomerWorkCentreCategory IsNot Nothing Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.CustomerJobClass)()
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("CustomerWorkCentreCategory", Me.Record.CustomerWorkCentreCategory), NHibernate.Criterion.Expression.IsNull("CustomerWorkCentreCategory")))
            Return API.CustomerJobClass.FindAll(crit)
        Else
            Return API.CustomerJobClass.FindAll
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
    Private Function LoadEmployees() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.People)
        Return UniSource.Helper.ActiveRecord.Evolution.People.FindAll
    End Function

    Private Function LoadStockItems() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)
        'Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
        If Me.Record.CustomerWorkCentreCategory IsNot Nothing Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)()
            'crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("ItemGroup", Me.Record.WorkCentreCategory.Code), NHibernate.Criterion.Expression.IsEmpty("ItemGroup")))
            crit.Add(NHibernate.Criterion.Expression.Eq("ItemGroup", Me.Record.CustomerWorkCentreCategory.Code) Or NHibernate.Criterion.Expression.IsNull("ItemGroup") Or NHibernate.Criterion.Expression.Eq("ItemGroup", ""))
            Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll(crit)
        Else
            Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
        End If
    End Function



    Private Sub SetWorkCentre()

        If Me.Record.CustomerJobClass IsNot Nothing Then

            If InventoryItemBindingSource.List.Count > 0 Then
                Me.Record.InventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In InventoryItemBindingSource.List Where ii.StockLink = Me.Record.CustomerJobClass.InventoryItemID Select ii).FirstOrDefault
                Me.Record.Description1 = Me.Record.InventoryItem.Description1
            End If
            InventoryItemIDLookUpEdit.Properties.ReadOnly = True
        Else

        End If



    End Sub
    Public Sub setDates()
        StartDateEdit.EditValue = System.DateTime.Now
        EndDateEdit.EditValue = System.DateTime.Now
    End Sub



    Private Sub WorkCentreCategoryLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs)
        RefreshLookups()
    End Sub

    Private Sub ExcludeFromPaymentCheckEdit_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If Me.IsInitializing Then
            Exit Sub
        End If
        If Me.ExcludeFromPaymentCheckEdit.Checked = True Then
            If IsDBNull(Me.ExcludeReasonTextEdit.EditValue) OrElse Me.ExcludeReasonTextEdit.EditValue.ToString.Length = 0 Then
                ExcludeReasonTextEdit.ErrorText = "Please Enter the Reason For Exclude from Payment"
            End If
        End If
    End Sub


    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        If IsDBNull(InventoryItemIDLookupEdit.EditValue) Then
            InventoryItemIDLookUpEdit.ErrorText = "Please select a Inventory Item"
            'ElseIf InventoryItemIDLookupEdit.EditValue IsNot Nothing AndAlso CType(InventoryItemIDLookupEdit.EditValue, Helper.ActiveRecord.Evolution.StockItem).ItemActive = False Then
        ElseIf InventoryItemIDLookupEdit.EditValue IsNot Nothing AndAlso Me.Record.InventoryItem.ItemActive = False Then
            InventoryItemIDLookupEdit.ErrorText = "Inventory Item is not Active"
        End If
        If IsDBNull(WorkCentreLookupEdit.EditValue) Then
            WorkCentreLookupEdit.ErrorText = "Please Select a Work Centre"
        End If

        If errors IsNot Nothing Then
            MyBase.ValidationError(errors)
            For Each prop As Reflection.PropertyInfo In errors.Keys
                If prop.Name = "WorkCentre" Then
                    WorkCentreLookUpEdit.ErrorText = errors(prop)(0)
                End If
                If prop.Name = "InventoryItem" Then
                    InventoryItemIDLookUpEdit.ErrorText = errors(prop)(0)
                End If
                If prop.Name = "Quantity" Then
                    QuantitySpinEdit.ErrorText = errors(prop)(0)
                End If
            Next

        End If

        MyBase.ValidationError(errors)
    End Sub

    Protected Overrides Sub SaveClick(sender As Object, e As System.EventArgs)

        'If (Me.Record.isDayShift = True And Me.Record.isNightShift = True) OrElse (Me.Record.isDayShift = False And Me.Record.isNightShift = False) Then
        '    UniSource.Helper.GUI.Dialog.OKDialog("Time Spanning into two Shifts", "Kindly Correct Start and End Time")
        '    Exit Sub
        'End If
        'MyBase.SaveRecord()
    End Sub

    Private Sub xaeJoblineTime_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim sbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.People)(EmployeeLookUpEdit, AddressOf LoadEmployees)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Employees.", ex)
        End Try

        Try
            Dim wcclm As New Helper.GUI.LookupBackgroundLoader(Of API.CustomerWorkCentreCategory)(WorkCentreCategoryLookUpEdit, AddressOf LoadWorkCentreCategories)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centre Categories.", ex)
        End Try

        Try
            LoadEnums()
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Enums.", ex)
        End Try
        'setDates()

        Try
        Catch ex As Exception
            Setup.Log.logError("Error loading enums.", ex)
        End Try

        If Me.Record.ID > 0 Then
            Try
                SetWorkCentre()
            Catch ex As Exception
                Setup.Log.logError("Error setting Work Centre.", ex)
            End Try
        End If

        If Me.Record.TimeSheetClosed Then
            ' TimeLayoutControlGroup.Enabled = False
        End If

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(False)

    End Sub



    Private Sub WorkCentreLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles WorkCentreLookUpEdit.EditValueChanged
        Dim wc As API.CustomerJobClass = TryCast(WorkCentreLookUpEdit.EditValue, API.CustomerJobClass)
        If wc IsNot Nothing Then
            Me.Record.CustomerJobClass = wc
            Try
                SetWorkCentre()
            Catch ex As Exception
                Setup.Log.logError("Error setting Work Centre.", ex)
            End Try
        End If
    End Sub

    Private Sub EndDateEdit_EditValueChanged_1(sender As System.Object, e As System.EventArgs) Handles EndDateEdit.EditValueChanged
        'If Me.IsInitializing Then Exit Sub
        'If Not (IsDBNull(StartDateEdit.EditValue) And IsDBNull(EndDateEdit.EditValue)) Then
        '    Dim startDate As DateTime = CDate(StartDateEdit.EditValue)
        '    Dim EndDate As DateTime = CDate(EndDateEdit.EditValue)
        '    Record.Quantity = EndDate.Subtract(startDate).TotalHours.ToString("F", CultureInfo.InvariantCulture)
        '    Record.StartDate = startDate
        '    Record.EndDate = EndDate
        '    'QuantitySpinEdit.EditValue = EndDate.Subtract(startDate).TotalHours
        'End If
    End Sub

    Private Sub StartDateEdit_EditValueChanged_1(sender As System.Object, e As System.EventArgs) Handles StartDateEdit.EditValueChanged
        'If Me.IsInitializing Then Exit Sub
        'If Not (IsDBNull(EndDateEdit.EditValue)) And Record.EndDate IsNot Nothing And StartDateEdit.EditValue IsNot Nothing AndAlso EndDateEdit.EditValue IsNot Nothing Then
        '    Dim startDate As DateTime = CDate(StartDateEdit.EditValue)
        '    Dim EndDate As DateTime = CDate(EndDateEdit.EditValue)
        '    Record.EndDate = startDate.AddHours(QuantitySpinEdit.EditValue)
        '    Record.StartDate = startDate

        'End If
    End Sub

    Private Sub QuantitySpinEdit_EditValueChanged_1(sender As System.Object, e As System.EventArgs) Handles QuantitySpinEdit.EditValueChanged
        'If Me.IsInitializing Then Exit Sub
        'If Not (IsDBNull(StartDateEdit.EditValue) And IsDBNull(EndDateEdit.EditValue)) Then
        '    Dim startDate As DateTime = CDate(StartDateEdit.EditValue)
        '    Dim EndDate As DateTime = CDate(EndDateEdit.EditValue)
        '    Record.StartDate = startDate
        '    Record.EndDate = EndDate
        '    'QuantitySpinEdit.EditValue = EndDate.Subtract(startDate).TotalHours
        '    Record.EndDate = startDate.AddHours(QuantitySpinEdit.EditValue)

        'End If
    End Sub

    Private Sub DeleteRecordCheckEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles DeleteRecordCheckEdit.CheckedChanged
        If DeleteRecordCheckEdit.Checked = True Then
            WorkCentreCategoryLookUpEdit.Enabled = False
            WorkCentreLookUpEdit.Enabled = False
            InventoryItemIDLookUpEdit.Enabled = False
            EndDateEdit.Enabled = False
            StartDateEdit.Enabled = False
            EmployeeLookUpEdit.Enabled = False
            InvoiceComboBoxEdit.Enabled = False
            EmployeeTotalSpinEdit.Enabled = False
            DescriptionTextEdit.Enabled = False
        Else
            WorkCentreCategoryLookUpEdit.Enabled = True
            WorkCentreLookUpEdit.Enabled = True
            InventoryItemIDLookUpEdit.Enabled = True
            EndDateEdit.Enabled = True
            StartDateEdit.Enabled = True
            EmployeeLookUpEdit.Enabled = True
            InvoiceComboBoxEdit.Enabled = True

        End If
    End Sub



    Private Sub WorkCentreCategoryLookUpEdit_EditValueChanged_1(sender As System.Object, e As System.EventArgs) Handles WorkCentreCategoryLookUpEdit.EditValueChanged
        RefreshLookups()
    End Sub




    Private Sub InvoiceRunLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles InvoiceRunLookUpEdit.EditValueChanged
        If Me.IsInitializing Then Exit Sub
        If Not IsDBNull(InvoiceRunLookUpEdit.EditValue) Then
            If Me.InvoiceRunLookUpEdit.EditValue = API.OptionInvoiceRun.Y Then
                InvoiceRunDateEdit.EditValue = Now
            End If
        End If
    End Sub


    Private Sub PaymentRunLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles PaymentRunLookUpEdit.EditValueChanged
        If Me.IsInitializing Then Exit Sub
        If Not IsDBNull(PaymentRunLookUpEdit.EditValue) Then
            If Me.PaymentRunLookUpEdit.EditValue = API.OptionInvoiceRun.Y Then
                PaymentRunDateEdit.EditValue = Now
            End If
        End If
    End Sub


    
   
    Private Sub bbiAttachment_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAttachment.ItemClick
        Dim xfa As New xfJobLineAttachment(Me.Record)
        xfa.JobLineTime = Me.Record
        xfa.ShowDialog()
        Me.Record.JobLineTimeAttachments = xfa.JobLineTime.JobLineTimeAttachments
    End Sub
End Class

Public Class xaegJobLineTime
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.JobLineTime)
End Class