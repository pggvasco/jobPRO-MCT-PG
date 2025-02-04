Imports Castle.ActiveRecord
Imports Castle.Components.Validator
Imports UniSource
Imports Pastel.Evolution
Public Class JobLineTime
    Public Shared Property HospitalFetchedRecords As IEnumerable(Of API.JobLineTime) = New List(Of API.JobLineTime)
    Public Shared Property BranchFetchedRecords As IEnumerable(Of API.JobLineTime) = New List(Of API.JobLineTime)
    'Protected Friend Property InventoryTimeSellingPrice As Helper.ActiveRecord.Evolution.PricelistPrice
    Private _inventoryitem As Helper.ActiveRecord.Evolution.StockItem
    '<ValidateNonEmpty("Inventory Item is required.")>
    Public Overridable Property InventoryItem As Helper.ActiveRecord.Evolution.StockItem
        Get
            If MyBase.InventoryItemID Is Nothing Then
                _inventoryitem = Nothing
            ElseIf _inventoryitem Is Nothing OrElse _inventoryitem.ID <> MyBase.InventoryItemID Then
                Try
                    _inventoryitem = Helper.ActiveRecord.Evolution.StockItem.TryFind(MyBase.InventoryItemID)
                Catch
                    'MyBase.InventoryItemID = Nothing
                    _inventoryitem = Nothing
                End Try
            End If
            If _inventoryitem Is Nothing And MyBase.InventoryItemID IsNot Nothing Then
                MyBase.InventoryItemID = Nothing
            End If
            Return _inventoryitem
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.StockItem)
            If Not IsLoading AndAlso value IsNot Nothing AndAlso _inventoryitem <> value Then
                If MyBase.Description1 Is Nothing OrElse MyBase.Description1.Trim.Length <= 0 OrElse (value IsNot Nothing AndAlso value.ServiceItem = False) Then
                    MyBase.Description1 = value.Description1
                End If

            End If
            If (_inventoryitem <> value) Then
                _inventoryitem = value
               
                If value Is Nothing Then
                    MyBase.InventoryItemID = Nothing
                Else
                    MyBase.InventoryItemID = value.ID
                    If _inventoryitem.ServiceItem = False Then
                        LineDiscountPercent = Nothing
                    End If
                End If
                NotifyPropertyChanged("InventoryItem")
            End If
        End Set
    End Property

    Public Overrides Property Quantity As Double?
        Get
            If MyBase.Quantity Is Nothing Then
                'MyBase.Quantity = 1
                Return 0
            End If
            Return MyBase.Quantity
        End Get
        Set(ByVal value As Double?)
            MyBase.Quantity = value
            If IsLoading = False AndAlso MyBase.StartDate IsNot Nothing Then
                MyBase.EndDate = StartDate.Value.AddHours(Quantity)
                NotifyPropertyChanged("EndDate")
                NotifyPropertyChanged("Shift")
                NotifyPropertyChanged("RateTypeID")
            End If

        End Set
    End Property

    Public Overrides Property StartDate As Date?
        Get
            Return MyBase.StartDate
        End Get
        Set(value As Date?)
            MyBase.StartDate = value
            If IsLoading = False AndAlso MyBase.StartDate IsNot Nothing Then
                MyBase.EndDate = StartDate.Value.AddHours(Quantity)
                NotifyPropertyChanged("EndDate")
            End If
        End Set
    End Property

    Public Overrides Property EndDate As Date?
        Get
            Return MyBase.EndDate
        End Get
        Set(value As Date?)
            MyBase.EndDate = value
            If IsLoading = False AndAlso MyBase.StartDate IsNot Nothing AndAlso MyBase.EndDate IsNot Nothing Then
                MyBase.Quantity = value.Value.Subtract(MyBase.StartDate).TotalHours
                NotifyPropertyChanged("Quantity")
            End If
        End Set
    End Property

    Public Overridable ReadOnly Property RateType As API.RateType
        Get
            If RateTypeID IsNot Nothing Then
                Return RateTypeID
            End If
        End Get

    End Property
    Public Overridable Property BillingTypes As API.BillingType
        Get
            If BillingType IsNot Nothing Then
                Return CType(BillingType, API.BillingType)
            End If
        End Get
        Set(value As API.BillingType)
            BillingType = value
        End Set
    End Property
    Public Overridable Property PaymentRunOption As API.OptionInvoiceRun
        Get
            If PaymentRun IsNot Nothing Then
                Return CType(PaymentRun, API.OptionInvoiceRun)
            End If
        End Get
        Set(value As API.OptionInvoiceRun)
            PaymentRun = value
        End Set
    End Property
    Public Overridable Property InvoiceRunOption As API.OptionInvoiceRun
        Get
            If InvoiceRun IsNot Nothing Then
                Return CType(InvoiceRun, API.OptionInvoiceRun)
            End If
        End Get
        Set(value As API.OptionInvoiceRun)
            InvoiceRun = value
        End Set
    End Property
    Public Overrides Property PaymentRun As Integer?
        Get
            If MyBase.PaymentRun Is Nothing Then
                Return API.OptionPaymentRun.N
            End If
            Return MyBase.PaymentRun
        End Get
        Set(value As Integer?)
            MyBase.PaymentRun = value
        End Set
    End Property
    Public Overrides Property InvoiceRun As Integer?
        Get
            If MyBase.InvoiceRun Is Nothing Then
                Return API.OptionInvoiceRun.N
            End If
            Return MyBase.InvoiceRun
        End Get
        Set(value As Integer?)
            MyBase.InvoiceRun = value
        End Set
    End Property
    Public Overrides Property Deleted As Boolean?
        Get
            If MyBase.Deleted Is Nothing Then
                Return False
            End If
            Return MyBase.Deleted
        End Get
        Set(value As Boolean?)
            MyBase.Deleted = value
        End Set
    End Property
    Public Overrides Property ExcludeFromPayment As Boolean?
        Get
            If MyBase.ExcludeFromPayment Is Nothing Then
                Return False
            End If
            Return MyBase.ExcludeFromPayment
        End Get
        Set(value As Boolean?)
            MyBase.ExcludeFromPayment = value
        End Set
    End Property

    '20150520 Brits - Shit changed to be Enum
    Public Overridable ReadOnly Property Shift As ShiftType?
        Get
            If Not (IsDBNull(Me.StartDate) And IsDBNull(Me.EndDate)) Then
                If StartDate.Value.TimeOfDay >= Context.Defaults.DayStartTime.Value.TimeOfDay And StartDate.Value.TimeOfDay < Context.Defaults.NightStartTime.Value.TimeOfDay Then
                    Return ShiftType.Day
                Else
                    Return ShiftType.Night
                End If
                'NotifyPropertyChanged("Shift")
            End If
        End Get
    End Property
    '20150520 Brits - Added Shift End to make shift accross 2 shift types eaysier
    Public Overridable ReadOnly Property ShiftEnd As ShiftType?
        Get
            Dim tmpShiftEnd As ShiftType?
            If Not (IsDBNull(Me.EndDate) And IsDBNull(Me.EndDate)) Then
                If EndDate.Value.TimeOfDay >= Context.Defaults.DayStartTime.Value.TimeOfDay And EndDate.Value.TimeOfDay < Context.Defaults.NightStartTime.Value.TimeOfDay Then
                    tmpShiftEnd = ShiftType.Day
                Else
                    tmpShiftEnd = ShiftType.Night
                End If
                'NotifyPropertyChanged("Shift")
            End If
            Return tmpShiftEnd
        End Get
    End Property

    Public Overridable Function IsAccrossShiftTypes() As Boolean
        Dim StartDayShift As Date = New Date(StartDate.Value.Year, StartDate.Value.Month, StartDate.Value.Day, Context.Defaults.DayStartTime.Value.Hour, Context.Defaults.DayStartTime.Value.Minute, Context.Defaults.DayStartTime.Value.Second)
        Dim StartNightShift As Date = New Date(StartDate.Value.Year, StartDate.Value.Month, StartDate.Value.Day, Context.Defaults.NightStartTime.Value.Hour, Context.Defaults.NightStartTime.Value.Minute, Context.Defaults.NightStartTime.Value.Second)
        Dim EndDayShift As Date = New Date(EndDate.Value.Year, EndDate.Value.Month, EndDate.Value.Day, Context.Defaults.DayStartTime.Value.Hour, Context.Defaults.DayStartTime.Value.Minute, Context.Defaults.DayStartTime.Value.Second)
        Dim EndNightShift As Date = New Date(EndDate.Value.Year, EndDate.Value.Month, EndDate.Value.Day, Context.Defaults.NightStartTime.Value.Hour, Context.Defaults.NightStartTime.Value.Minute, Context.Defaults.NightStartTime.Value.Second)

        Dim StartDayDiff As Integer = DateDiff(DateInterval.Minute, CDate(StartDate), CDate(StartDayShift))
        If StartDayDiff < 0 Or StartDayDiff > 30 Then
            StartDayDiff = 0
        Else
            StartDayDiff = 30
        End If
        Dim StartNightDiff As Integer = DateDiff(DateInterval.Minute, CDate(StartNightShift), CDate(StartDate))
        If StartNightDiff < 0 Or StartNightDiff > 30 Then
            StartNightDiff = 0
        Else
            StartNightDiff = 30
        End If

        Dim EndDayDiff As Integer = DateDiff(DateInterval.Minute, CDate(EndDayShift), CDate(EndDate))
        If EndDayDiff < 0 Or EndDayDiff > 30 Then
            EndDayDiff = 0
        Else
            EndDayDiff = 30
        End If
        Dim EndNightDiff As Integer = DateDiff(DateInterval.Minute, CDate(EndDate), CDate(EndNightShift))
        If EndNightDiff < 0 Or StartNightDiff > 30 Then
            EndNightDiff = 0
        Else
            EndNightDiff = 30
        End If

        Dim tmpShift As ShiftType?
        If Not (IsDBNull(Me.EndDate) And IsDBNull(Me.EndDate)) Then
            If StartDate.Value.TimeOfDay >= Context.Defaults.DayStartTime.Value.AddMinutes(-1 * StartDayDiff).TimeOfDay And StartDate.Value.TimeOfDay < Context.Defaults.NightStartTime.Value.AddMinutes(-1 * StartNightDiff).TimeOfDay Then
                tmpShift = ShiftType.Day
            Else
                tmpShift = ShiftType.Night
            End If
        End If

        Dim tmpShiftEnd As ShiftType?
        If Not (IsDBNull(Me.EndDate) And IsDBNull(Me.EndDate)) Then
            If EndDate.Value.TimeOfDay >= Context.Defaults.DayStartTime.Value.AddMinutes(EndDayDiff).TimeOfDay And EndDate.Value.TimeOfDay < Context.Defaults.NightStartTime.Value.AddMinutes(EndNightDiff).TimeOfDay Then
                tmpShiftEnd = ShiftType.Day
            Else
                tmpShiftEnd = ShiftType.Night
            End If
        End If
        If tmpShift = tmpShiftEnd Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Overrides Property TimeSheetClosed As Boolean?
        Get
            If PaymentRun = API.OptionPaymentRun.Y OrElse InvoiceRun = API.OptionInvoiceRun.Y Then
                Return True
            Else
                Return False
            End If
            Return MyBase.TimesheetClosed
        End Get
        Set(value As Boolean?)
            MyBase.TimesheetClosed = value
        End Set
    End Property



    Public Overrides Property RateTypeID As Integer?
        Get
            '20150520 Brits - pdate is used to check if public holiday, because if it is a public holiday gets deturment a bit diffrent to which day of week it is
            '20150520 Brits - changed checks to use Shift as it allready has day or night. So it is done at 1 place and code looks clean
            Dim sdate As New DateTime
            Dim pdate As New DateTime
            If Not IsDBNull(StartDate) AndAlso Me.StartDate IsNot Nothing Then
                If StartDate.Value.TimeOfDay < Context.Defaults.DayStartTime.Value.TimeOfDay Then
                    sdate = StartDate.Value.AddDays(-1)
                Else
                    sdate = StartDate
                End If
                If StartDate.Value.TimeOfDay >= Context.Defaults.NightStartTime.Value.TimeOfDay Then
                    pdate = StartDate.Value.AddDays(1)
                Else
                    pdate = StartDate
                End If
                If API.PublicHoliday.IsHoliday(pdate) Then
                    If Shift = API.ShiftType.Day Then
                        MyBase.RateTypeID = RateType.Publicholidayday
                    Else
                        MyBase.RateTypeID = RateType.Publicholidaynight
                    End If
                ElseIf sdate.DayOfWeek = DayOfWeek.Sunday Then
                    If Shift = API.ShiftType.Day Then
                        MyBase.RateTypeID = RateType.Sundayday
                    Else
                        MyBase.RateTypeID = RateType.Sundaynight
                    End If
                ElseIf sdate.DayOfWeek = DayOfWeek.Saturday Then
                    If Shift = API.ShiftType.Day Then
                        MyBase.RateTypeID = RateType.Saturdayday
                    Else
                        MyBase.RateTypeID = RateType.Saturdaynight
                    End If
                Else
                    If Shift = API.ShiftType.Day Then
                        MyBase.RateTypeID = RateType.Weekday
                    Else
                        MyBase.RateTypeID = RateType.Weeknight
                    End If
                End If
            End If
            Return MyBase.RateTypeID
        End Get
        Set(value As Integer?)
            MyBase.RateTypeID = value
            NotifyPropertyChanged("RateTypeID")
        End Set
    End Property

    'Public Overridable ReadOnly Property Customer As API.Customer
    '    Get
    '        If Me.Job IsNot Nothing Then
    '            Return API.Customer.FindAllByProperty("ERPCustomerID", Me.Job.Customer.ID).FirstOrDefault
    '        End If
    '    End Get
    'End Property


    Public Overrides Property CustomerWorkCentreCategory As CustomerWorkCentreCategory
        Get
            Return MyBase.CustomerWorkCentreCategory
        End Get
        Set(value As CustomerWorkCentreCategory)
            MyBase.CustomerWorkCentreCategory = value
        End Set
    End Property

    Private Property _pricellistID As Integer?
    Public Overridable ReadOnly Property PricellistID As Integer?
        Get
            If CustomerWorkCentreCategory IsNot Nothing Then
                Dim tmpPricellistID As Integer?
                Select Case Me.RateType
                    Case API.RateType.Saturdayday
                        tmpPricellistID = CustomerWorkCentreCategory.SaturdayDayPricelist
                    Case API.RateType.Saturdaynight
                        tmpPricellistID = CustomerWorkCentreCategory.SaturdayNightPricelist
                    Case API.RateType.Sundayday
                        tmpPricellistID = CustomerWorkCentreCategory.SundayDayPricelist
                    Case API.RateType.Sundaynight
                        tmpPricellistID = CustomerWorkCentreCategory.SundayNightPricelist
                    Case API.RateType.Publicholidayday
                        tmpPricellistID = CustomerWorkCentreCategory.PublicHolidayDayPricelist
                    Case API.RateType.Publicholidaynight
                        tmpPricellistID = CustomerWorkCentreCategory.PublicHolidayNightPricelist
                    Case API.RateType.Weekday
                        tmpPricellistID = CustomerWorkCentreCategory.WeekDayPriceList
                    Case API.RateType.Weeknight
                        tmpPricellistID = CustomerWorkCentreCategory.WeekNightPricelist
                End Select
                If _pricellistID Is Nothing OrElse (tmpPricellistID IsNot Nothing AndAlso _pricellistID <> tmpPricellistID) Then
                    _pricellistID = tmpPricellistID
                End If
            End If
            Return _pricellistID
        End Get
    End Property

    Private Property _inventoryPricellist As Helper.ActiveRecord.Evolution.PricelistPrice
    Public Overridable ReadOnly Property InventoryPricellist As Helper.ActiveRecord.Evolution.PricelistPrice
        Get
            If PricellistID IsNot Nothing Then
                If _inventoryPricellist Is Nothing OrElse _inventoryPricellist.IStockID <> Me.InventoryItem.ID OrElse _inventoryPricellist.IPriceListNameID <> PricellistID Then
                    _inventoryPricellist = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(Me.InventoryItem, Me.PricellistID)
                End If
            End If
            Return _inventoryPricellist
        End Get
    End Property

    Public Overrides Property TimeUnitPrice As Double?
        Get
            If Me.PricellistID IsNot Nothing AndAlso Me.InventoryItem IsNot Nothing AndAlso CustomerWorkCentreCategory IsNot Nothing Then
                If Me.InventoryPricellist IsNot Nothing Then
                    If MyBase.TimeUnitPrice <> InventoryPricellist.FExclPrice Then
                        MyBase.TimeUnitPrice = InventoryPricellist.FExclPrice
                        NotifyPropertyChanged("TimeUnitPrice")
                    End If
                End If
            Else
                MyBase.TimeUnitPrice = 0
            End If
            Return (MyBase.TimeUnitPrice)
        End Get
        Set(value As Double?)
            MyBase.TimeUnitPrice = value
            NotifyPropertyChanged("TimeUnitPrice")
        End Set
    End Property

    Private Property _employee As API.Employee
    Public Overridable ReadOnly Property Employee As API.Employee
        Get

            If (Me.EmployeeID IsNot Nothing AndAlso Me.EmployeeID > 0) AndAlso (_employee Is Nothing OrElse _employee.PersonID <> Me.EmployeeID) Then
                _employee = API.Employee.FindAllByProperty("PersonID", Me.EmployeeID).FirstOrDefault
            End If
            Return _employee
        End Get
    End Property
    Public Overrides Property InventoryItemID As Integer?
        Get
            If Me.CustomerJobClass IsNot Nothing Then
                'If MyBase.Description1 Is Nothing OrElse MyBase.Description1.Trim.Length <= 0 Then
                If MyBase.InventoryItemID Is Nothing OrElse MyBase.InventoryItemID <> Me.CustomerJobClass.InventoryItemID Then
                    MyBase.InventoryItemID = Me.CustomerJobClass.InventoryItemID
                End If
                If Me.Description1 Is Nothing OrElse Me.Description1 <> InventoryItem.Description1 Then
                    Me.Description1 = InventoryItem.Description1
                End If
                'End If
            End If
            Return MyBase.InventoryItemID
        End Get
        Set(ByVal value As Integer?)
            If (MyBase.InventoryItemID <> value OrElse (MyBase.InventoryItemID Is Nothing And value IsNot Nothing)) Then
                MyBase.InventoryItemID = value
                If Me.CustomerJobClass IsNot Nothing Then
                    'If MyBase.Description1 Is Nothing OrElse MyBase.Description1.Trim.Length <= 0 Then
                    Me.InventoryItemID = Me.CustomerJobClass.InventoryItemID
                    Me.Description1 = InventoryItem.Description1
                    Me.InventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll Where ii.StockLink = Me.CustomerJobClass.InventoryItemID Select ii).FirstOrDefault
                    '   
                    'End If
                End If
                NotifyPropertyChanged("InventoryItemID")
            End If
        End Set
    End Property
    Public Overrides Property CommisionPercentage As Double?
        Get
            'If MyBase.CommisionPercentage Is Nothing Then
            '    CommisionPercentage = 0
            'End If
            Return MyBase.CommisionPercentage
        End Get
        Set(value As Double?)
            MyBase.CommisionPercentage = value
        End Set
    End Property
    Public Overrides Property CommissionValue As Double?
        Get
            If Me.Job.CustomerTime IsNot Nothing Then
                Return (Me.InvoiceAmount * (Me.Job.CustomerTime.Commission / 100))
            End If
            Return MyBase.CommissionValue
        End Get
        Set(value As Double?)
            MyBase.CommissionValue = value
            NotifyPropertyChanged("CommisionValue")
        End Set
    End Property
    Public Overrides Property InvoiceAmount As Double?
        Get
            'If MyBase.InvoiceAmount Is Nothing Then
            '    Return 0
            'End If
            'Return (Me.TimeUnitPrice * Me.Quantity)
            Return MyBase.InvoiceAmount
        End Get
        Set(value As Double?)
            MyBase.InvoiceAmount = value
            NotifyPropertyChanged("InvoiceAmount")
        End Set
    End Property
    Public Overridable ReadOnly Property PaymentAmount As Double?
        Get
            If Me.Job.CustomerTime IsNot Nothing Then
                Return ((Me.InvoiceAmount) - ((Me.Job.CustomerTime.Commission / 100) * Me.InvoiceAmount))
            End If
        End Get
    End Property

    Public Overrides Property EmployeeRate As Double?
        Get
            If Me.Job.CustomerTime IsNot Nothing Then
                Return (Me.TimeUnitPrice - (Me.TimeUnitPrice * (Me.Job.CustomerTime.Commission / 100)))
            End If
        End Get
        Set(value As Double?)
            MyBase.EmployeeRate = value
            NotifyPropertyChanged("EmployeeRate")
        End Set
    End Property
    'Public Overrides Property EmployeeTotal As Double?
    '    Get
    '        If Employee IsNot Nothing Then
    '            Return (Me.EmployeeRate * Me.Quantity)
    '        End If

    '        Return MyBase.EmployeeTotal
    '    End Get
    '    Set(value As Double?)
    '        MyBase.EmployeeTotal = value
    '        NotifyPropertyChanged("EmployeeTotal")
    '    End Set
    'End Property

    Public Overrides Property TotalPrice As Double?
        Get
            'If MyBase.TotalPrice = 0 OrElse MyBase.TotalPrice = Me.Quantity * Me.TimeUnitPrice Then
            Return (Me.Quantity * Me.TimeUnitPrice)
            'End If

            Return MyBase.TotalPrice
        End Get
        Set(value As Double?)
            MyBase.TotalPrice = value
        End Set
    End Property

    'ToDo: dup time check fix
    Public Overridable Function IsTimeduplicate(ByVal EmployeeID As Integer) As Boolean
        For Each jl In Me.Job.JobLineTimes.Where(Function(j) j.EmployeeID = EmployeeID)
            If Not IsDBNull(jl.StartDate) Then
                If (StartDate.Value >= jl.StartDate And StartDate <= jl.EndDate.Value) OrElse (EndDate >= jl.StartDate.Value And EndDate <= jl.EndDate.Value) OrElse (StartDate <= jl.StartDate.Value And EndDate >= jl.EndDate) Then
                    Return True

                Else
                    Return False
                End If
            End If
        Next

    End Function

    Public Overrides Property IgnoreTimeValidation As Boolean?
        Get
            If MyBase.IgnoreTimeValidation Is Nothing Then
                Return False
            End If
            Return MyBase.IgnoreTimeValidation
        End Get
        Set(value As Boolean?)
            MyBase.IgnoreTimeValidation = value
        End Set
    End Property
    Public Overrides Property IgnoreValidation As Boolean?
        Get
            If MyBase.IgnoreValidation Is Nothing Then
                Return False
            End If
            Return MyBase.IgnoreValidation
        End Get
        Set(value As Boolean?)
            MyBase.IgnoreValidation = value
        End Set
    End Property
    '20150520 Brits - Changed to check Shift as it allredy has day or night
    Public Overridable ReadOnly Property isDayShift() As Boolean
        Get
            'Dim sp As New TimeSpan(0, 31, 0)
            'If startime.TimeOfDay > Context.Defaults.DayStartTime.Value.TimeOfDay.Subtract(sp) AndAlso startime.TimeOfDay < Context.Defaults.NightStartTime.Value.TimeOfDay.Add(sp) AndAlso startime.Date = enddate.Date Then
            If Shift = ShiftType.Day Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    '20150520 Brits - Changed to check Shift as it allredy has day or night
    Public Overridable ReadOnly Property isNightShift() As Boolean
        Get
            'Dim sp As New TimeSpan(0, 31, 0)
            'If enddate.TimeOfDay < Context.Defaults.DayStartTime.Value.TimeOfDay.Add(sp) OrElse enddate.TimeOfDay > Context.Defaults.NightStartTime.Value.TimeOfDay.Add(sp) Then
            If Shift = ShiftType.Night Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    Public Overridable ReadOnly Property DoesEmployeeHasQualification As Boolean
        Get
            If Me.Employee IsNot Nothing AndAlso Me.CustomerJobClass IsNot Nothing Then
                Dim wc = (From EmployeeQual As API.EmployeeQualification In Me.Employee.EmployeeQualifications Where EmployeeQual.InventoryItemID = Me.CustomerJobClass.InventoryItemID).FirstOrDefault
                If wc Is Nothing Then
                    Return False
                Else
                    Return True
                End If
            End If
        End Get
    End Property
    Public Overridable ReadOnly Property CalculatedEndDate As DateTime
        Get
            If Me.StartDate.HasValue And Me.EndDate.HasValue Then
                Return Me.StartDate.Value.AddHours(24)
            End If
            Return Nothing
        End Get
    End Property
    Public Overridable ReadOnly Property CalculatedStartDate As DateTime
        Get
            If Me.StartDate.HasValue And Me.EndDate.HasValue Then
                Return Me.EndDate.Value.AddHours(-24)
            End If
            Return Nothing
        End Get
    End Property
    '20150520 Brits - Changed to check Shift as it allredy has day or night
    Public Overridable ReadOnly Property DayShift As Integer
        Get
            'If Me.RateType = API.RateType.Publicholidayday Or Me.RateType = API.RateType.Saturdayday Or Me.RateType = API.RateType.Sundayday Or Me.RateType = API.RateType.Weekday Then
            If Shift = ShiftType.Day Then
                Return 1
            Else
                Return 0
            End If
        End Get
    End Property
    '20150520 Brits - Changed to check Shift as it allredy has day or night
    Public Overridable ReadOnly Property NightShift As Integer
        Get
            'If Me.RateType = API.RateType.Publicholidaynight Or Me.RateType = API.RateType.Saturdaynight Or Me.RateType = API.RateType.Sundaynight Or Me.RateType = API.RateType.Weeknight Then
            If Shift = ShiftType.Night Then
                Return 1
            Else
                Return 0
            End If
        End Get
    End Property
    Public Overridable ReadOnly Property ShiftTotal As Integer
        Get
            Return NightShift + DayShift
        End Get
    End Property

    Private Property _taxRate As Pastel.Evolution.TaxRate
    Public Overridable ReadOnly Property TaxRate As Pastel.Evolution.TaxRate
        Get
            If _taxRate Is Nothing OrElse _taxRate.ID <> Me.Job.Customer.DefTaxTypeID Then
                _taxRate = New Pastel.Evolution.TaxRate(Me.Job.Customer.DefTaxTypeID)
            End If
            Return _taxRate
        End Get
    End Property
    Public Overridable ReadOnly Property VatAmount As Double?
        Get
            If TaxRate IsNot Nothing Then
                Return InvoiceAmount * ((TaxRate.Rate) / 100)
            End If
        End Get
    End Property
    Public Overridable ReadOnly Property TotalInclusive As Double?
        Get
            If VatAmount IsNot Nothing AndAlso InvoiceAmount IsNot Nothing Then
                Return VatAmount + InvoiceAmount
            End If
        End Get
    End Property

    Private Property _invoicelink As API.InvoiceLink
    Public Overridable ReadOnly Property Invoicelink As API.InvoiceLink
        Get
            If Me.ID IsNot Nothing AndAlso _invoicelink Is Nothing Then
                _invoicelink = API.InvoiceLink.FindAllByProperty("JoblineTimeID", Me.ID).FirstOrDefault
            End If
            Return _invoicelink
        End Get
    End Property

    Public Overridable ReadOnly Property FrontTimeLogged() As Double?
        Get
            Dim EmployCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobLineTime)()
            EmployCrit.Add(NHibernate.Criterion.Expression.Eq("EmployeeID", EmployeeID))
            EmployCrit.Add(NHibernate.Criterion.Expression.Eq("Deleted", False))
            If Me.Job IsNot Nothing Then
                EmployCrit.CreateAlias("Job", "Job")
                EmployCrit.Add(NHibernate.Criterion.Expression.Not((NHibernate.Criterion.Expression.Eq("Job.id", Me.Job.ID))))
            End If
            EmployCrit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.And(NHibernate.Criterion.Expression.Ge("StartDate", StartDate), (NHibernate.Criterion.Expression.Lt("StartDate", CalculatedEndDate))), NHibernate.Criterion.Expression.And(NHibernate.Criterion.Expression.Le("EndDate", CalculatedEndDate), (NHibernate.Criterion.Expression.Gt("EndDate", StartDate)))))
            Dim TotalTime As Long = 0
            For Each JobLineTimeRec As API.JobLineTime In API.JobLineTime.FindAll(EmployCrit)
                TotalTime += DateDiff(DateInterval.Second, CDate(IIf(JobLineTimeRec.StartDate > StartDate, JobLineTimeRec.StartDate, StartDate)), CDate(IIf(JobLineTimeRec.EndDate < CalculatedEndDate, JobLineTimeRec.EndDate, CalculatedEndDate))) / 60 / 60
            Next

            For Each JobLineTimeRec As API.JobLineTime In Me.Job.JobLineTimes
                If JobLineTimeRec.EmployeeID = EmployeeID AndAlso JobLineTimeRec.Deleted = False AndAlso ((JobLineTimeRec.StartDate >= StartDate AndAlso JobLineTimeRec.StartDate < CalculatedEndDate) OrElse (JobLineTimeRec.EndDate > StartDate AndAlso JobLineTimeRec.EndDate <= CalculatedEndDate)) Then
                    TotalTime += DateDiff(DateInterval.Second, CDate(IIf(JobLineTimeRec.StartDate > StartDate, JobLineTimeRec.StartDate, StartDate)), CDate(IIf(JobLineTimeRec.EndDate < CalculatedEndDate, JobLineTimeRec.EndDate, CalculatedEndDate))) / 60 / 60
                End If
            Next
            Return TotalTime
        End Get
    End Property
    Public Overridable ReadOnly Property BackTimeLogged() As Double?
        Get
            Dim EmployCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobLineTime)()
            EmployCrit.Add(NHibernate.Criterion.Expression.Eq("EmployeeID", EmployeeID))
            EmployCrit.Add(NHibernate.Criterion.Expression.Eq("Deleted", False))
            If Me.Job IsNot Nothing Then
                EmployCrit.CreateAlias("Job", "Job")
                EmployCrit.Add(NHibernate.Criterion.Expression.Not((NHibernate.Criterion.Expression.Eq("Job.id", Me.Job.ID))))
            End If
            EmployCrit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.And(NHibernate.Criterion.Expression.Ge("StartDate", CalculatedStartDate), (NHibernate.Criterion.Expression.Lt("StartDate", EndDate))), NHibernate.Criterion.Expression.And(NHibernate.Criterion.Expression.Le("EndDate", EndDate), (NHibernate.Criterion.Expression.Gt("EndDate", CalculatedStartDate)))))
            Dim TotalTime As Long = 0
            For Each JobLineTimeRec As API.JobLineTime In API.JobLineTime.FindAll(EmployCrit)
                TotalTime += DateDiff(DateInterval.Second, CDate(IIf(JobLineTimeRec.StartDate > StartDate, JobLineTimeRec.StartDate, StartDate)), CDate(IIf(JobLineTimeRec.EndDate < CalculatedEndDate, JobLineTimeRec.EndDate, CalculatedEndDate))) / 60 / 60
            Next

            For Each JobLineTimeRec As API.JobLineTime In Me.Job.JobLineTimes
                If JobLineTimeRec.EmployeeID = EmployeeID AndAlso JobLineTimeRec.Deleted = False AndAlso ((JobLineTimeRec.StartDate >= CalculatedStartDate AndAlso JobLineTimeRec.StartDate < EndDate) OrElse (JobLineTimeRec.EndDate > CalculatedStartDate AndAlso JobLineTimeRec.EndDate <= EndDate)) Then
                    TotalTime += DateDiff(DateInterval.Second, CDate(IIf(JobLineTimeRec.StartDate > StartDate, JobLineTimeRec.StartDate, StartDate)), CDate(IIf(JobLineTimeRec.EndDate < CalculatedEndDate, JobLineTimeRec.EndDate, CalculatedEndDate))) / 60 / 60
                End If
            Next
            Return TotalTime
        End Get
    End Property

    Public Overridable Function LoadWorkCentreCategories() As IEnumerable(Of API.CustomerWorkCentreCategory)
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.CustomerWorkCentreCategory)()
        crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Customer", Me.Job.CustomerTime), NHibernate.Criterion.Expression.IsNull("Customer")))
        Return API.CustomerWorkCentreCategory.FindAll(crit)
    End Function

    Public Overridable Function LoadWorkCentres() As IEnumerable(Of API.CustomerJobClass)
        If Me.CustomerWorkCentreCategory IsNot Nothing AndAlso Me.Employee IsNot Nothing Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.CustomerJobClass)()
            Dim eQualificalionList = (From employeequalification In Me.Employee.EmployeeQualifications Select employeequalification.InventoryItemID).ToList
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("CustomerWorkCentreCategory", Me.CustomerWorkCentreCategory), NHibernate.Criterion.Expression.IsNull("CustomerWorkCentreCategory")))
            Me.CustomerJobClass = API.CustomerJobClass.FindAll(crit).Where(Function(x) eQualificalionList.Contains(x.InventoryItemID)).FirstOrDefault
            NotifyPropertyChanged("CustomerJobClass")
            Return API.CustomerJobClass.FindAll(crit).Where(Function(x) eQualificalionList.Contains(x.InventoryItemID))

        Else
            Return API.CustomerJobClass.FindAll
        End If
    End Function


    Public Overridable Sub SetWorkCentre()
        If Me.CustomerJobClass IsNot Nothing AndAlso Me.Employee IsNot Nothing Then
            Dim wc = (From EmployeeQual As API.EmployeeQualification In Employee.EmployeeQualifications Where EmployeeQual.InventoryItemID = Me.CustomerJobClass.InventoryItemID).FirstOrDefault
            If wc Is Nothing Then
                UniSource.Helper.GUI.Dialog.OKDialog("Employee Does not have Selected  Qualification", "Invalid Qualification")
                Me.CustomerJobClass = Nothing
                Me.InventoryItem = Nothing
                Exit Sub
            End If
            Me.InventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll Where ii.StockLink = Me.CustomerJobClass.InventoryItemID Select ii).FirstOrDefault
            Me.Description1 = Me.InventoryItem.Description1

        End If

    End Sub
    Public Overrides Property CustomerJobClass As CustomerJobClass
        Get
            Return MyBase.CustomerJobClass
        End Get
        Set(value As CustomerJobClass)
            MyBase.CustomerJobClass = value

            NotifyPropertyChanged("CustomerJobClass")
        End Set
    End Property

    Public Overridable Sub SetQualification()
        If Me.CustomerWorkCentreCategory IsNot Nothing AndAlso Me.Employee IsNot Nothing Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of ShopFloor.API.CustomerJobClass)()
            Dim eQualificalionList = (From employeequalification In Employee.EmployeeQualifications Select employeequalification.InventoryItemID).ToList
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("CustomerWorkCentreCategory", CustomerWorkCentreCategory), NHibernate.Criterion.Expression.IsNull("CustomerWorkCentreCategory")))
            Me.CustomerJobClass = (ShopFloor.API.CustomerJobClass.FindAll(crit).Where(Function(x) eQualificalionList.Contains(x.InventoryItemID))).FirstOrDefault
            If Me.CustomerJobClass IsNot Nothing Then
                Me.InventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll Where ii.StockLink = CustomerJobClass.InventoryItemID Select ii).FirstOrDefault
                Me.Description1 = Me.InventoryItem.Description1
                Me.CustomerJobClass = Me.CustomerJobClass
            End If
            Me.LoadWorkCentres()
            NotifyPropertyChanged("CustomerJobClass")
        End If
    End Sub

    'Public Shared Function fetchTimeRecords(ByVal Hospital As List(Of UniSource.Helper.ActiveRecord.Evolution.Client), ByVal startdate As DateTime, ByVal EndDate As DateTime) As IEnumerable(Of API.JobLineTime)
    '    Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of ShopFloor.API.JobLineTime)()
    '    crit.Add(NHibernate.Criterion.Expression.Ge("StartDate", StartDate))
    '    crit.Add(NHibernate.Criterion.Expression.Le("StartDate", EndDate))
    '    Return API.JobLineTime.FindAll(crit).Where(Function(x) Hospital.Contains(x.Job.Customer))
    'End Function
    Public Shared Function fetchTimeRecords(ByVal Hospital As UniSource.Helper.ActiveRecord.Evolution.Client, ByVal startdate As DateTime, ByVal EndDate As DateTime, Optional ByVal IncludeStartDate As Boolean = True) As Boolean
        'Brits 20150423 - Added paramater to say if start date must be included in filter
        Dim isSuccessful As Boolean = True
        Try
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of ShopFloor.API.JobLineTime)()
            If IncludeStartDate Then
                crit.Add(NHibernate.Criterion.Expression.Ge("StartDate", startdate))
            End If
            crit.Add(NHibernate.Criterion.Expression.Le("StartDate", EndDate))
            HospitalFetchedRecords = API.JobLineTime.FindAll(crit).Where(Function(x) Hospital = x.Job.Customer AndAlso x.Deleted = False AndAlso (x.InvoiceRunOption = OptionInvoiceRun.N OrElse x.InvoiceRunOption = OptionInvoiceRun.P))
            If HospitalFetchedRecords IsNot Nothing AndAlso HospitalFetchedRecords.Count = 0 Then
                isSuccessful = False
            End If
        Catch ex As Exception
            isSuccessful = False
        End Try
        Return isSuccessful
    End Function

    Public Shared Function fetchPaymentTimeRecords(ByVal Branch As String, ByVal startdate As DateTime, ByVal EndDate As DateTime, Optional ByVal IncludeStartDate As Boolean = True, Optional PaymentFrequency As String = "M", Optional BranchCode As String = "PTA") As Boolean
        'Brits 20150423 - Added paramater to say if start date must be included in filter
        Dim isSuccessful As Boolean = True
        Try
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of ShopFloor.API.JobLineTime)()
            If IncludeStartDate Then
                crit.Add(NHibernate.Criterion.Expression.Ge("StartDate", startdate))
            End If
            crit.Add(NHibernate.Criterion.Expression.Le("StartDate", EndDate))
            Dim tmpBranchFetchedRecords As List(Of API.JobLineTime) = New List(Of API.JobLineTime)
            Dim FullBranchFetchedRecords = API.JobLineTime.FindAll(crit).Where(Function(x) x.Deleted = False AndAlso (x.PaymentRunOption = OptionPaymentRun.N OrElse x.PaymentRunOption = OptionPaymentRun.P))
            BranchFetchedRecords = New List(Of API.JobLineTime)
            For Each tr In FullBranchFetchedRecords
                If tr.Employee.PaymentFrequency.Trim() = PaymentFrequency.Trim() AndAlso tr.Employee.BranchCode.Trim() = BranchCode.Trim() AndAlso tr.PaymentRunDate Is Nothing Then
                    If tr.Employee.People.UserFields(API.Context.Defaults.UIFUDF) = False Then
                        tmpBranchFetchedRecords.Add(tr)
                    End If
                End If
            Next
            BranchFetchedRecords = tmpBranchFetchedRecords
            If BranchFetchedRecords IsNot Nothing AndAlso BranchFetchedRecords.Count = 0 Then
                isSuccessful = False
            End If
        Catch ex As Exception
            isSuccessful = False
        End Try
        Return isSuccessful
    End Function

    'Added Function to check if time is duplicated
    Public Overridable Function IsTimeDuplicated() As Boolean
        Dim ValidTime As Boolean = False

        Dim EmployCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobLineTime)()
        EmployCrit.Add(NHibernate.Criterion.Expression.Eq("EmployeeID", EmployeeID))
        EmployCrit.Add(NHibernate.Criterion.Expression.Eq("Deleted", False))
        If Me.Job IsNot Nothing Then
            EmployCrit.CreateAlias("Job", "Job")
            EmployCrit.Add(NHibernate.Criterion.Expression.Not((NHibernate.Criterion.Expression.Eq("Job.id", Me.Job.ID))))
        End If
        EmployCrit.Add(NHibernate.Criterion.Expression.Not((NHibernate.Criterion.Expression.Eq("ID", Me.ID))))
        EmployCrit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.And(NHibernate.Criterion.Expression.Ge("StartDate", StartDate), (NHibernate.Criterion.Expression.Lt("StartDate", EndDate))), _
                      (NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.And(NHibernate.Criterion.Expression.Le("EndDate", EndDate), (NHibernate.Criterion.Expression.Gt("EndDate", StartDate))), _
                      (NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.And(NHibernate.Criterion.Expression.Le("StartDate", StartDate), (NHibernate.Criterion.Expression.Gt("EndDate", StartDate))), _
                                                          NHibernate.Criterion.Expression.And(NHibernate.Criterion.Expression.Ge("EndDate", EndDate), (NHibernate.Criterion.Expression.Lt("StartDate", EndDate)))))))))
        Dim RecordCount As Long = 0
        For Each JobLineTimeRec As API.JobLineTime In API.JobLineTime.FindAll(EmployCrit)
            RecordCount += 1
        Next

        For Each JobLineTimeRec As API.JobLineTime In Me.Job.JobLineTimes
            If JobLineTimeRec.ID <> Me.ID AndAlso JobLineTimeRec.EmployeeID = EmployeeID AndAlso JobLineTimeRec.Deleted = False _
                AndAlso ((JobLineTimeRec.StartDate >= StartDate AndAlso JobLineTimeRec.StartDate < EndDate) _
                OrElse (JobLineTimeRec.EndDate > StartDate AndAlso JobLineTimeRec.EndDate <= EndDate) _
                OrElse (JobLineTimeRec.EndDate > StartDate AndAlso JobLineTimeRec.StartDate <= StartDate) _
                OrElse (JobLineTimeRec.EndDate >= EndDate AndAlso JobLineTimeRec.StartDate < EndDate)) Then
                RecordCount += 1
            End If
        Next


        If RecordCount > 0 Then
            ValidTime = True
        End If

        Return ValidTime
    End Function
   
    Public Overridable Function GetTimeCopy(ByRef selectedTime As API.JobLineTime) As API.JobLineTime
        Dim Newline As New API.JobLineTime

        'COPY
        Newline.CustomerWorkCentreCategory = selectedTime.CustomerWorkCentreCategory
        Newline.CustomerJobClass = selectedTime.CustomerJobClass
        Newline.RateTypeID = selectedTime.RateTypeID
        Newline.EmployeeID = selectedTime.EmployeeID
        Newline.RateTypeID = selectedTime.RateTypeID
        Newline.Job = selectedTime.Job
        Newline.InventoryItem = selectedTime.InventoryItem

        'NEW

        Newline.StartDate = Now
        Newline.EndDate = Now
        Newline.InvoiceRun = API.OptionInvoiceRun.N
        Newline.PaymentRun = API.OptionPaymentRun.N
        Return Newline
    End Function

    '20150522 Brits -  Moved validations to joblinetime class .
    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid
        If IsLoading = False Then

            If Me.IgnoreValidation = False Then
                If InventoryItem Is Nothing OrElse InventoryItem.ItemActive = False Then
                    valid = False
                End If
            End If
            If Me.Quantity < 0.01 Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Quantity")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Quantity"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Quantity")).Add("Quantinty must be  Greater Than 0.")
                valid = False
            End If
            If Me.Employee Is Nothing Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Employee")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Employee"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Employee")).Add("No Employee Selected.")
                valid = False
            End If

            If IsAccrossShiftTypes() Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("StartDate")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("StartDate"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("StartDate")).Add("Time Spanning into two Shifts.")
                valid = False
            End If

            If IgnoreTimeValidation = False Then
                If Quantity > 12.5 OrElse (FrontTimeLogged()) > 12.5 OrElse (BackTimeLogged()) > 12.5 Then
                    If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("StartDate")) Then
                        Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("StartDate"), New ArrayList())
                    End If
                    Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("StartDate")).Add("Time logged withing 24 hours > 12.5.")
                    valid = False
                End If
            End If

            If IgnoreValidation = False Then
                If DoesEmployeeHasQualification = False AndAlso CustomerWorkCentreCategory IsNot Nothing Then
                    If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Employee")) Then
                        Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Employee"), New ArrayList())
                    End If
                    Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Employee")).Add("Employee Does not have selected Qualification.")
                    valid = False
                End If
                If IsTimeDuplicated() Then
                    If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("StartDate")) Then
                        Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("StartDate"), New ArrayList())
                    End If
                    Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("StartDate")).Add("Duplicate Time loggged.")
                    valid = False
                End If
            End If
            'If EmployeeID IsNot Nothing Then
            '    For Each jl In Me.Record.Job.JobLineTimes.Where(Function(j) j.EmployeeID = Me.Record.EmployeeID)
            '        If (Me.Record.StartDate.Value >= jl.StartDate And Me.Record.StartDate <= jl.EndDate.Value) OrElse (Me.Record.EndDate >= jl.StartDate.Value And Me.Record.EndDate <= jl.EndDate.Value) OrElse (Me.Record.StartDate <= jl.StartDate.Value And Me.Record.EndDate >= jl.EndDate) Then
            '            UniSource.Helper.GUI.Dialog.OKDialog("Duplicate Time Record")
            '            Exit Function
            '        End If
            '    Next
            'End If
        End If

        If valid = False OrElse IgnoreValidation = True Then
            InvoiceRun = False
            PaymentRun = False
        Else
            InvoiceRun = True
            PaymentRun = True
        End If

        Return valid
    End Function
  
    Public Overrides Sub Save()

        If IsValid() Then
            'MyBase.SaveAndFlush()
            MyBase.Save()
        End If



    End Sub

    Private WithEvents _attachments As ComponentModel.BindingList(Of JobLineTimeAttachment)
    <SmartAssembly.Attributes.DoNotPrune()>
    Public Overridable ReadOnly Property AttachmentCollection As ComponentModel.BindingList(Of JobLineTimeAttachment)
        Get
            If IsLoading = False AndAlso _attachments Is Nothing Then
                _attachments = New ComponentModel.BindingList(Of JobLineTimeAttachment)(MyBase.JobLineTimeAttachments)
            End If
            Return _attachments
        End Get
    End Property


End Class
