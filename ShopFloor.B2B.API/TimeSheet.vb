Imports Castle.ActiveRecord
Imports UniSource.ShopFloor
<UniSource.B2B.DAL.B2B(UniSource.B2B.DAL.B2BOperation.Import)>
Public Class TimeSheet
    Private Property JobTime As UniSource.ShopFloor.API.Job
    Public Property EmployeeNumber As String
    Public Property CustomerNumber As String
    Public Property Agency As String
    Public Property JobClass As String
    Public Property PayCode As String
    Public Property ClockIn As String
    Public Property ClockOut As String
    Public Property HoursClocked As Double
    Public Property SignOffDate As String
    Public Property CostCentre As String
    Public Property JobDate As String
    Public Property EmployeeSurname As String
    Public Property UploadDate As String
    Public Property EmployeeFirstName As String
    Public Property ImportFileName As String
    Public Property Defaults As ShopFloor.API.Defaults = ShopFloor.API.Defaults.Defaults
    Public Property Job As UniSource.ShopFloor.API.Job


    Private ReadOnly Property ImportReference As String
        Get
            Return String.Format("{0}-{1}", ImportFileName, Me.CustomerNumber)
        End Get
    End Property

    Private Property _customer As UniSource.ShopFloor.API.SFCustomer
    Public ReadOnly Property Customer As UniSource.ShopFloor.API.SFCustomer
        Get
            If _customer Is Nothing Then
                _customer = (From s As UniSource.ShopFloor.API.SFCustomer In UniSource.ShopFloor.API.SFCustomer.FindAll Select s Where s.Client.UserFields(Defaults.HospitalNumberUDF) = Me.CustomerNumber).FirstOrDefault
            End If
            Return _customer
            'Return (From s As UniSource.ShopFloor.API.SFCustomer In UniSource.ShopFloor.API.SFCustomer.FindAll Select s Where s.Client.UserFields(Defaults.HospitalNumberUDF) = Me.CustomerNumber).FirstOrDefault
        End Get
    End Property
    Public ReadOnly Property CustomerWorkCentreCategory As ShopFloor.API.CustomerWorkCentreCategory
        Get
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of ShopFloor.API.CustomerWorkCentreCategory)()
            crit.Add(NHibernate.Criterion.Expression.Eq("Code", Me.CostCentre))
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Customer", customer), NHibernate.Criterion.Expression.IsNull("Customer")))

            Return ShopFloor.API.CustomerWorkCentreCategory.FindAll(crit).FirstOrDefault
        End Get
    End Property

    Private Property _employeeID As Integer
    Public ReadOnly Property EmployeeID As Integer
        Get
            If _employeeID = 0 Then
                Dim dt = Pastel.Evolution.DatabaseContext.ExecuteCommandDataTable(String.Format("select * from  _rtblpeople where {1}='{0}'", Me.EmployeeNumber, Defaults.EmployeeImportCodeUDF))
                If dt.Rows.Count = 1 Then
                    Dim firstRow As DataRow = dt.Rows(0)
                    Dim idPeople As Integer = firstRow("idPeople")
                    _employeeID = idPeople
                ElseIf dt.Rows.Count > 1 Then
                    Throw New Exception("Multi Employee found on same code")
                End If
            End If
            Return _employeeID
        End Get
    End Property

    Private Property _employee As UniSource.ShopFloor.API.Employee
    Public ReadOnly Property Employee As UniSource.ShopFloor.API.Employee
        Get
            If _employee Is Nothing Then
                _employee = UniSource.ShopFloor.API.Employee.FindAllByProperty("PersonID", EmployeeID).FirstOrDefault
            End If
            Return _employee
            'Return (UniSource.ShopFloor.API.Employee.FindAll.Where(Function(emp) emp.People.UserFields(Defaults.EmployeeNumberUDF) = Me.EmployeeNumber)).FirstOrDefault
            'Return (UniSource.ShopFloor.API.Employee.

        End Get
    End Property
    Public ReadOnly Property CustomerJobclass As UniSource.ShopFloor.API.CustomerJobClass
        Get
              Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of ShopFloor.API.CustomerJobClass)()
            Dim eQualificalionList = (From employeequalification In Employee.EmployeeQualifications Select employeequalification.InventoryItemID).ToList
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("CustomerWorkCentreCategory", CustomerWorkCentreCategory), NHibernate.Criterion.Expression.IsNull("CustomerWorkCentreCategory")))
            Return (ShopFloor.API.CustomerJobClass.FindAll(crit).Where(Function(x) eQualificalionList.Contains(x.InventoryItemID))).FirstOrDefault

        End Get
    End Property
    Public ReadOnly Property ErpCustomer As Pastel.Evolution.Customer
        Get
            Return New Pastel.Evolution.Customer(CInt(customer.ERPCustomerID))
        End Get
    End Property
   

    Public Sub New()
        Try
            If Not ActiveRecordStarter.GetRegisteredTypes.Contains(GetType(UniSource.ShopFloor.API.Job)) Then
                ActiveRecordStarter.RegisterAssemblies(GetType(UniSource.ShopFloor.API.Job).Assembly)
                ActiveRecordMediator(Of ActiveRecordBase).GetSessionFactoryHolder().RegisterSessionFactory(ActiveRecordMediator(Of ActiveRecordBase).GetSessionFactoryHolder().GetConfiguration(GetType(ActiveRecordBase)).BuildSessionFactory(), GetType(ActiveRecordBase))
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub Save()
        If Defaults.EmployeeNumberUDF Is Nothing Or Defaults.EmployeeNumberUDF = "" Then
            Throw New Exception("Employee Number UDF not configured")
        End If

        If Defaults.HospitalNumberUDF Is Nothing Or Defaults.HospitalNumberUDF = "" Then
            Throw New Exception("Hospital Number UDF not configured")
        End If

        If customer Is Nothing Then
            Throw New Exception("Customer Not found")
        End If


        ' check  if job  exists,use find method 
           'Dim custome = Unisource.ShopFloor.API.Customer.FindAllByProperty("CustomerNumber", Me.CustomerNumber).FirstOrDefault
    
        If Employee Is Nothing Then
            Throw New Exception("Employee Not Found")
        End If
        If CustomerWorkCentreCategory Is Nothing Then
            Throw New Exception("Ward Not Found")
        End If
        If CustomerJobclass Is Nothing Then
            Throw New Exception("Jobclass not found for the Employee")
        End If

        Job = (UniSource.ShopFloor.API.Job.FindAllByProperty("ImportReference", Me.ImportReference)).FirstOrDefault
        If Job Is Nothing Then
            Job = New UniSource.ShopFloor.API.Job
            ' insert completely new job card 
            Job = New UniSource.ShopFloor.API.Job
            Job.JobDate = Me.JobDate
            Job.State = ShopFloor.API.JobState.Active
            Job.SourceID = CInt(UniSource.ShopFloor.API.Source.ImportedJob)
            If IIf(Defaults.IsJobNumberAutoGenerated.HasValue, Defaults.IsJobNumberAutoGenerated, False) Then
                Me.Job.JobNumber = Defaults.GetNextJobNumber(Job) + " *"
            End If
            Job.Customer = UniSource.Helper.ActiveRecord.Evolution.Client.Find(ErpCustomer.ID)
            Job.JobType = ShopFloor.API.JobType.FindAllByProperty("Code", "TimeSheet").FirstOrDefault
            Job.ImportDate = Date.Now()
            Job.ImportReference = Me.ImportReference
            Job.SaveAndFlush()
        End If
        Job = UniSource.ShopFloor.API.Job.FindAllByProperty("ImportReference", Me.ImportReference).FirstOrDefault
        Dim jobline As New UniSource.ShopFloor.API.JobLineTime

        jobline.StartDate = Me.ClockIn
        jobline.EndDate = Me.ClockOut
        If jobline.Shift = ShopFloor.API.ShiftType.Day And jobline.ShiftEnd = ShopFloor.API.ShiftType.Night Then
            ' OrElse (jobline.isDayShift(jobline.StartDate, jobline.EndDate) = False And jobline.isNightShift(jobline.EndDate) = False) Then
            Dim FirstSplitline As New ShopFloor.API.JobLineTime
            FirstSplitline.CustomerJobClass = CustomerJobclass
            FirstSplitline.CustomerWorkCentreCategory = CustomerWorkCentreCategory
            FirstSplitline.InventoryItemID = CustomerJobclass.InventoryItemID
            FirstSplitline.StartDate = jobline.StartDate
            FirstSplitline.EndDate = New DateTime(jobline.EndDate.Value.Year, jobline.EndDate.Value.Month, jobline.EndDate.Value.Day, Defaults.NightStartTime.Value.Hour, Defaults.NightStartTime.Value.Minute, Defaults.NightStartTime.Value.Second)

            'Defaults.NightStartTime
            FirstSplitline.Quantity = (FirstSplitline.EndDate.Value.Subtract(FirstSplitline.StartDate.Value).TotalHours)
            FirstSplitline.JobLineDate = Me.JobDate
            FirstSplitline.EmployeeID = EmployeeID
            FirstSplitline.Job = Job
            Job.JobLineTimes.Add(FirstSplitline)
            Dim sFirstSplitline As New ShopFloor.API.JobLineTime
            sFirstSplitline.CustomerJobClass = CustomerJobclass
            sFirstSplitline.CustomerWorkCentreCategory = CustomerWorkCentreCategory
            sFirstSplitline.InventoryItemID = CustomerJobclass.InventoryItemID
            sFirstSplitline.StartDate = New DateTime(jobline.StartDate.Value.Year, jobline.StartDate.Value.Month, jobline.StartDate.Value.Day, Defaults.NightStartTime.Value.Hour, Defaults.NightStartTime.Value.Minute, Defaults.NightStartTime.Value.Second)

            'Defaults.NightStartTime
            sFirstSplitline.EndDate = jobline.EndDate
            sFirstSplitline.Quantity = (sFirstSplitline.EndDate.Value.Subtract(sFirstSplitline.StartDate.Value).TotalHours)

            sFirstSplitline.JobLineDate = Me.JobDate
            sFirstSplitline.EmployeeID = EmployeeID
            sFirstSplitline.Job = Job
            Job.JobLineTimes.Add(sFirstSplitline)
        ElseIf jobline.Shift = ShopFloor.API.ShiftType.Day And jobline.ShiftEnd = ShopFloor.API.ShiftType.Day Then
            Dim SecondSplitline As New ShopFloor.API.JobLineTime
            SecondSplitline.CustomerJobClass = CustomerJobclass
            SecondSplitline.CustomerWorkCentreCategory = CustomerWorkCentreCategory
            SecondSplitline.InventoryItemID = CustomerJobclass.InventoryItemID
            SecondSplitline.StartDate = jobline.StartDate
            SecondSplitline.EndDate = New DateTime(jobline.EndDate.Value.Year, jobline.EndDate.Value.Month, jobline.EndDate.Value.Day, Defaults.DayStartTime.Value.Hour, Defaults.DayStartTime.Value.Minute, Defaults.DayStartTime.Value.Second)
            SecondSplitline.Quantity = (SecondSplitline.EndDate.Value.Subtract(SecondSplitline.StartDate.Value).TotalHours)

            SecondSplitline.EmployeeID = Me.EmployeeID
            SecondSplitline.Job = Job
            Job.JobLineTimes.Add(SecondSplitline)
            Dim AnotherSecondSplitline As New ShopFloor.API.JobLineTime
            AnotherSecondSplitline.CustomerJobClass = CustomerJobclass
            AnotherSecondSplitline.CustomerWorkCentreCategory = CustomerWorkCentreCategory
            AnotherSecondSplitline.InventoryItemID = CustomerJobclass.InventoryItemID
            AnotherSecondSplitline.StartDate = New DateTime(jobline.EndDate.Value.Year, jobline.EndDate.Value.Month, jobline.EndDate.Value.Day, Defaults.DayStartTime.Value.Hour, Defaults.DayStartTime.Value.Minute, Defaults.DayStartTime.Value.Second)
            AnotherSecondSplitline.EndDate = jobline.EndDate
            AnotherSecondSplitline.Quantity = (AnotherSecondSplitline.EndDate.Value.Subtract(AnotherSecondSplitline.StartDate.Value).TotalHours)
            AnotherSecondSplitline.EmployeeID = Me.EmployeeID
            AnotherSecondSplitline.Job = Job
            Job.JobLineTimes.Add(AnotherSecondSplitline)
        Else
            jobline.CustomerJobClass = CustomerJobclass
            jobline.CustomerWorkCentreCategory = CustomerWorkCentreCategory
            jobline.Quantity = Me.HoursClocked
            jobline.EmployeeID = Me.EmployeeID
            jobline.JobLineDate = Me.JobDate
            jobline.Job = Me.Job
            Job.JobLineTimes.Add(jobline)
        End If
        Try
            Job.SaveAndFlush()
        Catch ex As Exception
            Throw New Exception("Error Saving Job.", ex)

        End Try

    End Sub

    Private Function ConvertDate(ByVal stringdate As String) As Date
        Dim converteddate As Date
        If stringdate.IndexOf("/") = 4 Then
            converteddate = New DateTime(CType(stringdate.Substring(0, 4), Integer), CType(stringdate.Substring(5, 2), Integer), CType(stringdate.Substring(8, 2), Integer))
            '2014/10/01
        Else
            ' 01/10/2014
            converteddate = New DateTime(CType(stringdate.Substring(6), Integer), CType(stringdate.Substring(3, 2), Integer), CType(stringdate.Substring(0, 2), Integer))
            'ConvertDate  = New DateTime(
        End If

        Return converteddate
    End Function
End Class
