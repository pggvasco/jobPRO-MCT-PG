Imports System.Globalization

Public Class xaeTimeEntry
    Inherits xaegJobTimeEntry


    Private Sub xaeTimeEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim sbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.People)(EmployeeSearchLookUpEdit, AddressOf LoadEmployees)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Employees.", ex)
        End Try
        
        Try
            Dim wcclm As New Helper.GUI.LookupBackgroundLoader(Of API.CustomerWorkCentreCategory)(WardLookUpEdit, AddressOf Me.Record.LoadWorkCentreCategories)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centre Categories.", ex)
        End Try

        Try
            LoadEnums()
        Catch ex As Exception
            Setup.Log.logError("Error loading Enums.", ex)
        End Try


 
        If Me.Record.ID > 0 Then
            Try
                Me.Record.SetWorkCentre()
            Catch ex As Exception
                Setup.Log.logError("Error setting Job Class.", ex)
            End Try
            If Me.Record.TimeSheetClosed Then
                MainLayoutControlGroup.Enabled = False
            End If
        End If

       
        'Me.SearchLookUpEdit1.Properties.View.Columns.AddF

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(False)

    End Sub

    Private Sub LoadEnums()
        RateTypeLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.RateType))
        BillingTypeLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.BillingType))
        InvoiceRunLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.OptionInvoiceRun))
        PaymentRunLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.OptionInvoiceRun))
    End Sub


    Private Sub RefreshLookups()
        If IIf(IsDBNull(WardLookUpEdit.EditValue), Nothing, WardLookUpEdit.EditValue) IsNot Nothing Then
            Me.Record.CustomerWorkCentreCategory = WardLookUpEdit.EditValue
            Try
                Dim wclm As New Helper.GUI.LookupBackgroundLoader(Of API.CustomerJobClass)(JobClassLookUpEdit, AddressOf Me.Record.LoadWorkCentres)
            Catch ex As Exception
                Setup.Log.logError("Error setting lookup maintenance for Job Class.", ex)
            End Try
        End If
    End Sub
    'Private Function LoadWorkCentreCategories() As IEnumerable(Of API.CustomerWorkCentreCategory)
    '    Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.CustomerWorkCentreCategory)()
    '    crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Customer", Me.Record.Customer), NHibernate.Criterion.Expression.IsNull("Customer")))
    '    Return API.CustomerWorkCentreCategory.FindAll(crit)
    '    'Return API.CustomerWorkCentreCategory.FindAll
    'End Function

    'Private Function LoadWorkCentres() As IEnumerable(Of API.CustomerJobClass)
    '    If Me.Record.CustomerWorkCentreCategory IsNot Nothing AndAlso Me.Record.Employee IsNot Nothing Then
    '        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.CustomerJobClass)()
    '        Dim eQualificalionList = (From employeequalification In Me.Record.Employee.EmployeeQualifications Select employeequalification.InventoryItemID).ToList
    '        crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("CustomerWorkCentreCategory", Me.Record.CustomerWorkCentreCategory), NHibernate.Criterion.Expression.IsNull("CustomerWorkCentreCategory")))

    '        Return API.CustomerJobClass.FindAll(crit).Where(Function(x) eQualificalionList.Contains(x.InventoryItemID))
    '        Me.Record.CustomerJobClass = API.CustomerJobClass.FindAll(crit).Where(Function(x) eQualificalionList.Contains(x.InventoryItemID)).FirstOrDefault
    '    Else
    '        Return API.CustomerJobClass.FindAll
    '    End If
    'End Function

   
    Private Function LoadEmployees() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.People)
        Return UniSource.Helper.ActiveRecord.Evolution.People.FindAll
    End Function
    'Private Sub SetWorkCentre()

    '    If Me.Record.Employee Is Nothing Then
    '        EmployeeLookUpEdit.ErrorText = "Select Employee For Qualification"
    '        Exit Sub
    '    End If
    '    If Me.Record.CustomerJobClass IsNot Nothing AndAlso Me.Record.Employee IsNot Nothing Then

    '        Dim wc = (From EmployeeQual As API.EmployeeQualification In Me.Record.Employee.EmployeeQualifications Where EmployeeQual.InventoryItemID = Me.Record.CustomerJobClass.InventoryItemID).FirstOrDefault
    '        If wc Is Nothing Then
    '            UniSource.Helper.GUI.Dialog.OKDialog("Employee Does not have Selected  Qualification", "Invalid Qualification")
    '            Me.Record.CustomerJobClass = Nothing
    '            Me.Record.InventoryItem = Nothing
    '            Exit Sub
    '        End If
    '        Me.Record.InventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll Where ii.StockLink = Me.Record.CustomerJobClass.InventoryItemID Select ii).FirstOrDefault
    '        Me.Record.Description1 = Me.Record.InventoryItem.Description1
    '        QualificationTextEdit.Properties.ReadOnly = True
    '    End If
    '    QualificationTextEdit.Properties.ReadOnly = True






    'End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        If Me.Record.IgnoreValidation = False Then
            If IsDBNull(JobClassLookUpEdit.EditValue) Then
                JobClassLookUpEdit.ErrorText = "Please Select a Job Class"
            End If
            If IsDBNull(WardLookUpEdit.EditValue) Then
                WardLookUpEdit.ErrorText = "Please Select a Ward"
            End If
            If IsDBNull(EmployeeSearchLookUpEdit.EditValue) Then
                EmployeeSearchLookUpEdit.ErrorText = "Please Select an Employee"
            End If

            If errors IsNot Nothing Then
                MyBase.ValidationError(errors)
                For Each prop As Reflection.PropertyInfo In errors.Keys
                    If prop.Name = "InventoryItem" Then
                        QualificationTextEdit.ErrorText = errors(prop)(0)
                    End If
                    If prop.Name = "Quantity" Then
                        QuantitySpinEdit.ErrorText = errors(prop)(0)
                    End If
                    If prop.Name = "Employee" Then
                        EmployeeSearchLookUpEdit.ErrorText = errors(prop)(0)
                    End If
                Next

            End If

            MyBase.ValidationError(errors)
        End If
    End Sub

    Protected Overrides Sub SaveClick(sender As Object, e As System.EventArgs)
        If IsDBNull(EmployeeSearchLookUpEdit.EditValue) AndAlso Me.Record.Employee Is Nothing Then
            EmployeeSearchLookUpEdit.ErrorText = "Please Select an Employee"
            Exit Sub
        End If
        If Me.Record.IsAccrossShiftTypes Then
            UniSource.Helper.GUI.Dialog.OKDialog("Time Spanning into two Shifts", "Kindly Correct Start and End Time")
            Exit Sub
        End If


        'If Me.Record.Quantity >= 12.5 Or (Me.Record.FrontTimeLogged + Me.Record.Quantity) > 12.5 Or (Me.Record.BackTimeLogged + Me.Record.Quantity) > 12.5 Then
        If Me.Record.Quantity > 12.5 OrElse (Me.Record.FrontTimeLogged()) > 12.5 OrElse (Me.Record.BackTimeLogged()) > 12.5 Then

            'If Me.Record.Quantity >= 12.5 Or Me.Record.Job.FrontTimeLogged(Me.Record.Employee, Me.Record.StartDate, Me.Record.CalculatedEndDate) >= 12.5 Or Me.Record.Job.BackTimeLogged(Me.Record.Employee, Me.Record.CalculatedStartDate, Me.Record.StartDate) >= 12.5 Then
            Me.Record.InvoiceRun = False
            Me.Record.PaymentRun = False
            If Me.Record.IgnoreTimeValidation = False Then
                UniSource.Helper.GUI.Dialog.OKDialog("Time logged withing 24 hours > 12.5", "Time  Validation")
                Exit Sub
            End If
        End If
        'If Me.Record.DoesEmployeeHasQualification = False AndAlso Me.Record.CustomerWorkCentreCategory IsNot Nothing Then
        '    Me.Record.InvoiceRun = False
        '    Me.Record.PaymentRun = False
        '    If Me.Record.IgnoreValidation = False Then
        '        UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Employee Does not have selected Qualification"))

        '        Exit Sub
        '    End If
        'End If
        'If Me.Record.EmployeeID IsNot Nothing AndAlso Me.Record.ID = 0 Then
        '    For Each jl In Me.Record.Job.JobLineTimes.Where(Function(j) j.EmployeeID = Me.Record.EmployeeID)
        '        If (Me.Record.StartDate.Value >= jl.StartDate And Me.Record.StartDate <= jl.EndDate.Value) OrElse (Me.Record.EndDate >= jl.StartDate.Value And Me.Record.EndDate <= jl.EndDate.Value) OrElse (Me.Record.StartDate <= jl.StartDate.Value And Me.Record.EndDate >= jl.EndDate) Then
        '            UniSource.Helper.GUI.Dialog.OKDialog("Duplicate Time Record")
        '            Exit Sub
        '        End If
        '    Next
        'End If
        MyBase.SaveRecord()

    End Sub

  Private Sub JobClassLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles JobClassLookUpEdit.EditValueChanged
        Dim wc As API.CustomerJobClass = TryCast(JobClassLookUpEdit.EditValue, API.CustomerJobClass)
        If wc IsNot Nothing Then
            Me.Record.CustomerJobClass = wc
            Try
                Me.Record.SetWorkCentre()
            Catch ex As Exception
                Setup.Log.logError("Error setting Job Class.", ex)
            End Try
        End If
    End Sub

    Private Sub WardLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles WardLookUpEdit.EditValueChanged
        RefreshLookups()
    End Sub

    Private Sub EndDateEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles EndDateEdit.EditValueChanged
        'If Me.IsInitializing Then Exit Sub
        'If Not (IsDBNull(StartDateEdit.EditValue)) And Not (IsDBNull(EndDateEdit.EditValue)) And StartDateEdit.EditValue IsNot Nothing Then
        '    Dim startDate As DateTime = CDate(StartDateEdit.EditValue)
        '    Dim EndDate As DateTime = CDate(EndDateEdit.EditValue)
        '    Record.Quantity = EndDate.Subtract(startDate).TotalHours.ToString("F", CultureInfo.InvariantCulture)
        '    ' Record.StartDate = startDate
        '    'Record.EndDate = EndDate
        '    'QuantitySpinEdit.EditValue = Record.Quantity
        'End If
    End Sub


    Private Sub StartDateEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles StartDateEdit.EditValueChanged
        'If Me.IsInitializing Then Exit Sub
        'If Not (IsDBNull(EndDateEdit.EditValue)) And Record.EndDate IsNot Nothing And Not (IsDBNull(StartDateEdit.EditValue)) And StartDateEdit.EditValue IsNot Nothing AndAlso EndDateEdit.EditValue IsNot Nothing Then
        '    Dim startDate As DateTime = CDate(StartDateEdit.EditValue)
        '    Dim EndDate As DateTime = CDate(EndDateEdit.EditValue)
        '    Record.Quantity = CDbl(QuantitySpinEdit.EditValue)
        '    Record.EndDate = startDate.AddHours(Record.Quantity)
        '    'EndDateEdit.EditValue = Record.EndDate
        '    'Record.StartDate = startDate

        'End If
    End Sub

  

    Private Sub QuantitySpinEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles QuantitySpinEdit.EditValueChanged
        'If Me.IsInitializing Then Exit Sub
        'If Not (IsDBNull(StartDateEdit.EditValue)) And Not (IsDBNull(EndDateEdit.EditValue)) Then
        '    Dim startDate As DateTime = CDate(StartDateEdit.EditValue)
        '    Dim EndDate As DateTime = CDate(EndDateEdit.EditValue)
        '    'Record.StartDate = startDate
        '    'Record.EndDate = EndDate
        '    'QuantitySpinEdit.EditValue = EndDate.Subtract(startDate).TotalHours
        '    Record.Quantity = CDbl(QuantitySpinEdit.EditValue)
        '    Record.EndDate = startDate.AddHours(Record.Quantity)

        'End If

    End Sub

    Private Function LoadQualification()

    End Function

   
    

    Private Sub EmployeeSearchLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles EmployeeSearchLookUpEdit.EditValueChanged
        If Me.IsInitializing Then Exit Sub

        If EmployeeSearchLookUpEdit.EditValue IsNot Nothing AndAlso Not IsDBNull(EmployeeSearchLookUpEdit.EditValue) Then
            Me.Record.EmployeeID = CInt(EmployeeSearchLookUpEdit.EditValue)
            Try
                Me.Record.SetQualification()
            Catch ex As Exception
                Setup.Log.logError("Error setting Job Class.", ex)
            End Try
        End If

    End Sub

   
    Private Sub bbiAttachment_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAttachment.ItemClick
        Dim xfa As New xfJobLineAttachment(Me.Record)
        xfa.JobLineTime = Me.Record
        xfa.ShowDialog()
        Me.Record.JobLineTimeAttachments = xfa.JobLineTime.JobLineTimeAttachments
    End Sub
End Class



Public Class xaegJobTimeEntry
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.JobLineTime)
End Class


