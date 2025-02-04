Imports Castle.ActiveRecord
Imports Castle.Components.Validator
Imports UniSource
Imports NHibernate.Event
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Job


    'Public Function Clone() As Object Implements System.ICloneable.Clone
    '    Dim m As New MemoryStream()
    '    Dim f As New BinaryFormatter()
    '    f.Serialize(m, Me)
    '    m.Seek(0, SeekOrigin.Begin)
    '    Return f.Deserialize(m)
    'End Function
    'Private _OldJob As API.Job
    'Public Property OldJob As API.Job
    '    Get
    '        Return _OldJob
    '    End Get
    '    Set(ByVal value As API.Job)
    '        _OldJob = value
    '    End Set
    'End Property
    Public Overrides Property OrderNumber As String
        Get
            Return MyBase.OrderNumber
        End Get
        Set(ByVal value As String)
            'If value IsNot Nothing AndAlso (MyBase.OrderNumber Is Nothing OrElse value <> MyBase.OrderNumber) Then
            '    If MyBase.JobCardID > 0 Then
            '        Dim JobCard As Pastel.Evolution.JobCard
            '        JobCard = New Pastel.Evolution.JobCard(CType(MyBase.JobCardID, Integer))
            '        JobCard.ExtOrderNo = value
            '        Try
            '            JobCard.SaveAndFlush()
            '        Catch ex As Exception
            '            Throw New Exception(ex.Message)
            '        End Try
            '    End If
            'End If
            MyBase.OrderNumber = value
        End Set
    End Property

    'Public Overrides Property Eq1UsageBefore As Double?
    '    Get
    '        Return MyBase.Eq1UsageBefore
    '    End Get
    '    Set(ByVal value As String)
    '        If value IsNot Nothing AndAlso (MyBase.OrderNumber Is Nothing OrElse value <> MyBase.OrderNumber) Then
    '            If MyBase.JobCardID > 0 Then
    '                Dim JobCard As Pastel.Evolution.JobCard
    '                JobCard = New Pastel.Evolution.JobCard(CType(MyBase.JobCardID, Integer))
    '                JobCard.ExtOrderNo = value
    '                Try
    '                    JobCard.SaveAndFlush()
    '                Catch ex As Exception
    '                    Throw New Exception(ex.Message)
    '                End Try
    '            End If
    '        End If
    '        MyBase.OrderNumber = value
    '    End Set
    'End Property

    Public Overridable ReadOnly Property NextStage As JobStage
        Get
            If Me.JobType Is Nothing Then
                Return Nothing
            Else
                Dim curJtsID As Integer = (From jts As JobTypeStage In Me.JobType.JobTypeStages Where jts.JobStage = Me.JobStage Select jts.ID).FirstOrDefault
                Return (From jts As JobTypeStage In Me.JobType.JobTypeStages Where jts.ID > curJtsID Order By jts.ID Ascending Select jts.JobStage).FirstOrDefault
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property CancelJobStage As JobStage
        Get
            If Me.JobType Is Nothing Then
                Return Nothing
            Else
                Dim Stagelist As List(Of JobStage) = JobStage.FindAll().ToList
                Dim curJtsID As Integer = (From jts As JobStage In Stagelist Where jts.Code = "Cancelled" Select jts.ID).FirstOrDefault
                Return JobStage.Find(curJtsID)
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property PreviousStage As JobStage
        Get
            If Me.JobType Is Nothing Then
                Return Nothing
            Else
                Dim curJtsID As Integer = (From jts As JobTypeStage In Me.JobType.JobTypeStages Where jts.JobStage = Me.JobStage Select jts.ID).FirstOrDefault
                Return (From jts As JobTypeStage In Me.JobType.JobTypeStages Where jts.ID < curJtsID Order By jts.ID Descending Select jts.JobStage).FirstOrDefault
            End If
        End Get
    End Property

    'Private Property _timeCustomer As API.SFCustomer
    'Public Overridable ReadOnly Property TimeCustomer As API.SFCustomer
    '    Get
    '        If Me.Customer IsNot Nothing AndAlso (_timeCustomer Is Nothing OrElse _timeCustomer.ERPCustomerID <> Me.Customer.ID) Then
    '            _timeCustomer = API.SFCustomer.FindAllByProperty("ERPCustomerID", Me.Customer.ID).FirstOrDefault
    '        End If
    '        Return _timeCustomer
    '    End Get
    'End Property

    Private _customer As Helper.ActiveRecord.Evolution.Client
    <BelongsTo("CustomerID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    <ValidateNonEmpty("Customer is required.")>
    Public Overridable Property Customer As Helper.ActiveRecord.Evolution.Client
        Get
            Return _customer
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.Client)
            If Not Me.IsLoading AndAlso value IsNot Nothing AndAlso value <> Me.Customer Then
                Me.AccountName = value.Name
                Me.ContactName = value.ContactPerson
                Me.Telephone = value.Telephone
                'Changes sales rep and price list every time customer is changed
                'If value.RepID > 0 Then
                Me.RepresentativeID = value.RepID
                'End If
                'If value.PriceListNameID > 0 Then
                Me.PricelistID = value.PriceListNameID
                'End If
                Me.Fax = value.Fax1
                Me.Email = value.EMail

            End If
            _customer = value
            'CustomerTime = API.SFCustomer.FindAllByProperty("ERPCustomerID", _customer.ID).FirstOrDefault
            'NotifyPropertyChanged("Customer")
        End Set
    End Property

    Private _customerTime As API.SFCustomer
    Public Overridable Property CustomerTime As API.SFCustomer
        Get
            Return _customerTime
        End Get
        Set(ByVal value As API.SFCustomer)
            _customerTime = value
            'NotifyPropertyChanged("CustomerTime")
        End Set
    End Property

    Private Property _priceList As Pastel.Evolution.PriceList
    Public Overridable Property PriceList As Pastel.Evolution.PriceList
        Get

            If Me.PricelistID IsNot Nothing AndAlso Me.PricelistID > 0 AndAlso (_priceList Is Nothing OrElse _priceList.ID <> Me.PricelistID) Then
                _priceList = New Pastel.Evolution.PriceList(CType(Me.PricelistID, Integer))
            End If

            Return _priceList
        End Get
        Set(value As Pastel.Evolution.PriceList)
            If value IsNot Nothing AndAlso value.ID > 0 Then
                Me.PricelistID = value.ID
                _priceList = value
            End If
        End Set
    End Property

    Private Property _representative As Pastel.Evolution.SalesRepresentative
    Public Overridable Property Representative As Pastel.Evolution.SalesRepresentative
        Get
            If Me.RepresentativeID IsNot Nothing AndAlso Me.RepresentativeID > 0 AndAlso (_representative Is Nothing OrElse _representative.ID <> Me.RepresentativeID) Then
                _representative = New Pastel.Evolution.SalesRepresentative(CType(Me.RepresentativeID, Integer))
            End If
            Return _representative
        End Get
        Set(ByVal value As Pastel.Evolution.SalesRepresentative)
            If value IsNot Nothing Then
                Me.RepresentativeID = value.ID
                _representative = value
            End If
        End Set
    End Property

    Public Overridable Property RepresentativeCode As String
        Get
            If Me.RepresentativeID IsNot Nothing AndAlso Representative IsNot Nothing Then
                Return Representative.Code
            ElseIf Customer IsNot Nothing AndAlso Customer.RepID > 0 Then
                Try
                    Dim tmprep = New Pastel.Evolution.SalesRepresentative(CType(Customer.RepID, Integer))
                    If tmprep IsNot Nothing AndAlso tmprep.ID > 0 Then
                        Return tmprep.Code
                    Else
                        Return ""
                    End If
                Catch
                    Return ""
                End Try
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    Private _quoteAgent As Helper.ActiveRecord.Evolution.Agents
    Public Overridable Property QuoteAgent As Helper.ActiveRecord.Evolution.Agents
        Get
            If _quoteAgent Is Nothing AndAlso Me.QuoteAgentID IsNot Nothing Then
                _quoteAgent = Helper.ActiveRecord.Evolution.Agents.Find(Me.QuoteAgentID.Value)
            End If

            Return _quoteAgent
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.Agents)
            _quoteAgent = value
            NotifyPropertyChanged("QuoteAgent")
        End Set
    End Property

    Private _jobAgent As Helper.ActiveRecord.Evolution.Agents
    Public Overridable Property JobAgent As Helper.ActiveRecord.Evolution.Agents
        Get
            If _jobAgent Is Nothing AndAlso Me.JobAgentID IsNot Nothing Then
                Try
                    _jobAgent = Helper.ActiveRecord.Evolution.Agents.Find(Me.JobAgentID.Value)
                Catch
                End Try
            End If

            Return _jobAgent
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.Agents)
            _jobAgent = value
            NotifyPropertyChanged("JobAgent")
        End Set
    End Property

    Private _preRequisitionPrintedAgent As Helper.ActiveRecord.Evolution.Agents
    Public Overridable Property PreRequisitionPrintedAgent As Helper.ActiveRecord.Evolution.Agents
        Get
            'If IsLoading = False AndAlso _preRequisitionPrintedAgent Is Nothing AndAlso Me.PreRequisitionPrintedAgentID IsNot Nothing Then
            If IsLoading = False AndAlso Me.PreRequisitionPrintedAgentID IsNot Nothing Then
                _preRequisitionPrintedAgent = Helper.ActiveRecord.Evolution.Agents.Find(Me.PreRequisitionPrintedAgentID.Value)
                Return _preRequisitionPrintedAgent
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.Agents)
            _preRequisitionPrintedAgent = value
            NotifyPropertyChanged("PreRequisitionPrintedAgent")
        End Set
    End Property


    Private _requisitionPrintedAgent As Helper.ActiveRecord.Evolution.Agents
    Public Overridable Property RequisitionPrintedAgent As Helper.ActiveRecord.Evolution.Agents
        Get
            If IsLoading = False AndAlso _requisitionPrintedAgent Is Nothing AndAlso Me.RequisitionPrintedAgentID IsNot Nothing Then
                _requisitionPrintedAgent = Helper.ActiveRecord.Evolution.Agents.Find(Me.RequisitionPrintedAgentID.Value)
            End If
            Return _requisitionPrintedAgent
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.Agents)
            _requisitionPrintedAgent = value
            NotifyPropertyChanged("PreRequisitionPrintedAgent")
        End Set
    End Property

    Public Overrides Property ImportReference As String
        Get
            Return MyBase.ImportReference
        End Get
        Set(ByVal value As String)
            MyBase.ImportReference = value
        End Set
    End Property



    Public Overridable Property Jobsource As API.Source
        Get
            If SourceID IsNot Nothing Then
                Return CType(SourceID, API.Source)
            Else
                Return Source.ManualJob
            End If
        End Get
        Set(value As API.Source)
            SourceID = value
        End Set
    End Property


    Public Overridable Property State As JobState
        Get
            If MyBase.StateID Is Nothing Then
                Return JobState.None
            End If
            Return CType(StateID, JobState)
            'Return StateID
        End Get
        Set(ByVal value As JobState)
            MyBase.StateID = CType(value, Integer)
        End Set
    End Property

    Public Overrides Property IsProcured As Boolean?
        Get
            If MyBase.IsProcured Is Nothing Then
                MyBase.IsProcured = False
            End If
            Return MyBase.IsProcured
        End Get
        Set(ByVal value As Boolean?)
            MyBase.IsProcured = value
        End Set
    End Property

    Public Overrides Property IsStockDrawn As Boolean?
        Get
            'If IsStockDrawn Is Nothing Then
            '    MyBase.IsStockDrawn = False
            'End If
            'Return MyBase.IsStockDrawn
            'MyBase.IsStockDrawn = True
            'For Each JobLine As API.JobLine In Me.JobLineList
            '    If JobLine.IsStockDrawn Is Nothing OrElse JobLine.IsStockDrawn = False Then
            '        MyBase.IsStockDrawn = False
            '        Exit For
            '    End If
            'Next

            Return MyBase.IsStockDrawn
        End Get
        Set(ByVal value As Boolean?)
            MyBase.IsStockDrawn = value
        End Set
    End Property

    Public Overrides Property JobType As JobType
        Get
            Return MyBase.JobType
        End Get
        Set(ByVal value As JobType)
            If Not Me.IsLoading AndAlso value IsNot Nothing AndAlso value <> MyBase.JobType Then
                Try
                    If State = JobState.Active Then
                        MyBase.JobStage = value.JobTypeStages.FirstOrDefault.JobStage
                    End If
                Catch ex As Exception
                    Throw New Exception("Error setting first stage on job.", ex)
                End Try
            End If
            MyBase.JobType = value
        End Set
    End Property

    Private WithEvents _joblinelist As ComponentModel.BindingList(Of JobLine)
    Public Overridable Overloads ReadOnly Property JobLineList As ComponentModel.BindingList(Of JobLine)
        Get
            If IsLoading = False AndAlso _joblinelist Is Nothing Then
                'If Me.JobLines IsNot Nothing Then
                _joblinelist = New ComponentModel.BindingList(Of JobLine)(Me.JobLines)
                'End If
            End If
            Return _joblinelist
        End Get
    End Property

    Private WithEvents _jobTimelinelist As ComponentModel.BindingList(Of JobLineTime)
    Public Overridable Overloads ReadOnly Property JobLineTimeList As ComponentModel.BindingList(Of JobLineTime)
        Get
            If IsLoading = False AndAlso _joblinelist Is Nothing Then
                'If Me.JobLines IsNot Nothing Then
                _jobTimelinelist = New ComponentModel.BindingList(Of JobLineTime)(Me.JobLineTimes)
                'End If
            End If
            Return _jobTimelinelist
        End Get
    End Property

    Public Overridable Sub RefreshStockDrawn()
        If 1 <= (From c In Me.JobLineList Where c.IsStockDrawn = False).Count() Then
            MyBase.IsStockDrawn = False
        Else
            MyBase.IsStockDrawn = True
        End If
    End Sub

    Private WithEvents _jobAuditlist As ComponentModel.BindingList(Of Audit)
    Public Overridable Overloads ReadOnly Property JobAuditList As ComponentModel.BindingList(Of Audit)
        Get
            'If IsLoading = False AndAlso _jobAuditlist Is Nothing Then
            '_jobAuditlist = New ComponentModel.BindingList(Of Audit)(Me.Audits)
            'End If
            Return _jobAuditlist
        End Get
    End Property

    Private WithEvents _jobdeliverylist As ComponentModel.BindingList(Of JobDelivery)
    Public Overridable Overloads ReadOnly Property JobDeliveryList As ComponentModel.BindingList(Of JobDelivery)
        Get
            If IsLoading = False AndAlso _jobdeliverylist Is Nothing AndAlso Me.JobDeliveries IsNot Nothing Then
                _jobdeliverylist = New ComponentModel.BindingList(Of JobDelivery)(Me.JobDeliveries)
            End If
            Return _jobdeliverylist
        End Get
    End Property

    Private WithEvents _jobtolerancelist As ComponentModel.BindingList(Of JobTolerance)
    Public Overridable Overloads ReadOnly Property JobToleranceList As ComponentModel.BindingList(Of JobTolerance)
        Get
            If IsLoading = False AndAlso _jobtolerancelist Is Nothing AndAlso Me.JobTolerances IsNot Nothing Then
                _jobtolerancelist = New ComponentModel.BindingList(Of JobTolerance)(Me.JobTolerances)
            End If
            Return _jobtolerancelist
        End Get
    End Property

    Private WithEvents _jobnotelist As ComponentModel.BindingList(Of Note)
    Public Overridable Overloads ReadOnly Property JobNoteList As ComponentModel.BindingList(Of Note)
        Get
            If IsLoading = False AndAlso _jobnotelist Is Nothing Then
                _jobnotelist = New ComponentModel.BindingList(Of Note)(Me.Notes)
            End If
            Return _jobnotelist
        End Get
    End Property

    Private WithEvents _jobDrawingAnnotationsList As ComponentModel.BindingList(Of JobDrawingAnnotation)
    Public Overridable Overloads ReadOnly Property JobDrawingAnnotationsList As ComponentModel.BindingList(Of JobDrawingAnnotation)
        Get
            If IsLoading = False AndAlso _jobDrawingAnnotationsList Is Nothing Then
                _jobDrawingAnnotationsList = New ComponentModel.BindingList(Of JobDrawingAnnotation)(Me.JobDrawingAnnotations)
            End If
            Return _jobDrawingAnnotationsList
        End Get
    End Property

    Private WithEvents _jobMemoList As ComponentModel.BindingList(Of JobMemo)
    Public Overridable Overloads ReadOnly Property JobMemoList As ComponentModel.BindingList(Of JobMemo)
        Get
            If IsLoading = False AndAlso _jobMemoList Is Nothing Then
                _jobMemoList = New ComponentModel.BindingList(Of JobMemo)(Me.JobMemoes)
            End If
            Return _jobMemoList
        End Get
    End Property

    Private Sub HandleNewJobLine(ByVal sender As Object, ByVal e As ComponentModel.AddingNewEventArgs) Handles _joblinelist.AddingNew
        Dim jl As New JobLine
        jl.Job = Me
        jl.JobLineDate = Now
        jl.WorkCentreCategory = Me.WorkCentreCategory
        e.NewObject = jl
    End Sub

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid
        If IsLoading Then
            Return MyBase.IsValid
        End If
        If Me.Quantity <= 0 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Quantity")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Quantity"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Quantity")).Add("Quantity must be greater than zero.")
            valid = False
        End If

        If Context.Defaults.RevenueCodeMethod = API.RevenueCodeMethod.CostCentre Or (IIf(Context.Defaults.IsJobNumberAutoGenerated.HasValue, Context.Defaults.IsJobNumberAutoGenerated, False) And Context.Defaults.JobNumberPrefixType = API.PrefixType.CostCentre) Then
            If Me.CostCentre Is Nothing And (Me.JobSourceID Is Nothing OrElse Me.JobSourceID = API.JobSource.Inventory) Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("CostCentre")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("CostCentre"), New ArrayList())

                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("CostCentre")).Add("Cost Centre is required due to Revenue Code Method or Prefix Type.")
                valid = False
            End If
        End If

        If Context.Defaults.RevenueCodeMethod = API.RevenueCodeMethod.JobCategory Or (IIf(Context.Defaults.IsJobNumberAutoGenerated.HasValue, Context.Defaults.IsJobNumberAutoGenerated, False) And Context.Defaults.JobNumberPrefixType = API.PrefixType.JobCategory) Then
            If Me.JobCategory Is Nothing Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("JobCategory")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("JobCategory"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("JobCategory")).Add("Job Category is required due to Revenue Code Method or Prefix Type.")
                valid = False
            End If
        End If

        If Context.Defaults.CostCentreMethod = CostCentreMethod.Job Then
            If Me.CostCentre Is Nothing And (Me.JobSourceID Is Nothing OrElse Me.JobSourceID = API.JobSource.Inventory) Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("CostCentre")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("CostCentre"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("CostCentre")).Add("Cost Centre is required due to Cost Centre Method.")
                valid = False
            End If
        End If
        If Me.JobNumber IsNot Nothing AndAlso Me.JobNumber.Length > 20 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("JobNumber")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("JobNumber"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("JobNumber")).Add("Job Number cannot be longer than 20 characters.")
            valid = False
        End If

        If Me.QuoteNumber IsNot Nothing AndAlso Me.QuoteNumber.Length > 20 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("QuoteNumber")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("QuoteNumber"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("QuoteNumber")).Add("Quote Number cannot be longer than 20 characters.")
            valid = False
        End If

        If Me.DeliveryNumber IsNot Nothing AndAlso Me.DeliveryNumber.Length > 20 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("DeliveryNumber")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("DeliveryNumber"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("DeliveryNumber")).Add("Delivery Number cannot be longer than 20 characters.")
            valid = False
        End If

        If Me.RequisitionNumber IsNot Nothing AndAlso Me.RequisitionNumber.Length > 20 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("RequisitionNumber")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("RequisitionNumber"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("RequisitionNumber")).Add("Requisition Number cannot be longer than 20 characters.")
            valid = False
        End If

        If Me.OrderNumber IsNot Nothing AndAlso Me.OrderNumber.Length > 20 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("OrderNumber")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("OrderNumber"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("OrderNumber")).Add("Order Number cannot be longer than 20 characters.")
            valid = False
        End If


        If Me.AccountName IsNot Nothing AndAlso Me.AccountName.Length > 50 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("AccountName")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("AccountName"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("AccountName")).Add("Account Name cannot be longer than 50 characters.")
            valid = False
        End If

        If Me.ContactName IsNot Nothing AndAlso Me.ContactName.Length > 50 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("ContactName")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("ContactName"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("ContactName")).Add("Contact Name cannot be longer than 50 characters.")
            valid = False
        End If

        If Me.Telephone IsNot Nothing AndAlso Me.Telephone.Length > 50 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Telephone")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Telephone"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Telephone")).Add("Telephone cannot be longer than 50 characters.")
            valid = False
        End If

        If Me.Email IsNot Nothing AndAlso Me.Email.Length > 50 Then
            'If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Email")) Then
            '    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Email"), New ArrayList())
            'End If
            'Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Email")).Add("Email cannot be longer than 50 characters.")
            'valid = False
            Me.Email = Me.Email.Substring(0, 50)
        End If

        If Me.Fax IsNot Nothing AndAlso Me.Fax.Length > 50 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Fax")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Fax"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Fax")).Add("Fax cannot be longer than 50 characters.")
            valid = False
        End If

        If Me.ID <= 0 Then
            If Me.Description1 Is Nothing OrElse Me.Description1.Trim.Length < Context.Defaults.MinDescription1Lenght Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Description1")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Description1"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Description1")).Add("Insufficient data in description 1.")
                valid = False
            End If

            If Me.Description2 Is Nothing OrElse Me.Description2.Trim.Length < Context.Defaults.MinDescription2Lenght Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Description2")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Description2"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Description2")).Add("Insufficient data in description 2.")
                valid = False
            End If

            If Me.WorkCentreCategory Is Nothing Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("WorkCentreCategory")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("WorkCentreCategory"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("WorkCentreCategory")).Add("Work Centre Category is required.")
                valid = False
            End If
        End If
        If Me.Description1 IsNot Nothing AndAlso Me.Description1.Length > 255 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Description1")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Description1"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Description1")).Add("Description 1 cannot be longer than 255 characters.")
            valid = False
        End If

        If Me.Description2 IsNot Nothing AndAlso Me.Description2.Length > 255 Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Description2")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Description2"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Description2")).Add("Description 2 cannot be longer than 255 characters.")
            valid = False
        End If

        If valid Then
            'JobGPCheck()
        End If
        Return valid
    End Function

    Protected Overrides Function BeforeSave(ByVal state As System.Collections.IDictionary) As Boolean
        If ID = 0 AndAlso ((Me.State = JobState.Active AndAlso Context.Defaults.IsJobNumberAutoGenerated) OrElse ((Me.State = JobState.Quote AndAlso Context.Defaults.IsQuoteNumberAutoGenerated))) Then
            'Dim bc As New Helper.ActiveRecord.Checkout
            ' CheckoutGuid As Guid
            Try
                'Added Checkput to fix AutoGen problem.
                Dim AutoGenSuccess As Boolean = False
                'Trys for 10 secs to get Checkout for Defaults
                Dim WaitLimit As DateTime = Now
                WaitLimit = WaitLimit.AddSeconds(30)
                While AutoGenSuccess = False
                    If WaitLimit < Now Then
                        'Dim lbc As Helper.ActiveRecord.Checkout = New Helper.ActiveRecord.Checkout
                        'lbc.Checkout = lbc.FindCheckout("Defaults", 1)
                        Select Case Me.State
                            Case JobState.Active
                                If Context.Defaults.IsJobNumberAutoGenerated Then
                                    'Throw New Exception(String.Format("Unable to get Defaults CheckOut Authority for next Job Number. Locked by {0}.", lbc.Checkout.NetworkUser))
                                Else
                                    'Throw New Exception(String.Format("Unable to get Defaults CheckOut Authority. Locked by {0}.", lbc.Checkout.NetworkUser))
                                End If
                            Case JobState.Quote
                                If Context.Defaults.IsQuoteNumberAutoGenerated Then
                                    'Throw New Exception(String.Format("Unable to get Defaults CheckOut Authority for next Quote Number. Locked by {0}.", lbc.Checkout.NetworkUser))
                                Else
                                    'Throw New Exception(String.Format("Unable to get Defaults CheckOut Authority. Locked by {0}.", lbc.Checkout.NetworkUser))
                                End If
                            Case Else
                                'Throw New Exception(String.Format("Unable to get Defaults CheckOut Authority. Locked by {0}.", lbc.Checkout.NetworkUser))
                        End Select


                    End If
                    'If bc.AddCheckOutoverrideFalse("Defaults", 1) Then
                    'CheckoutGuid = bc.Checkout.GUID
                    'bc.Checkout.Save()
                    Select Case Me.State
                        Case JobState.Active
                            If Context.Defaults.IsJobNumberAutoGenerated Then
                                state("JobNumber") = Defaults.Defaults.GetNextJobNumberAndIncrement(Me)
                            End If
                        Case JobState.Quote
                            If Context.Defaults.IsQuoteNumberAutoGenerated Then
                                state("QuoteNumber") = Defaults.Defaults.GetNextQuoteNumberAndIncrement(Me)
                            End If
                        Case Else
                            Throw New Exception(String.Format("Cannot save new Job with state of {0}.", Me.State))
                    End Select
                    'If bc.AlreadyCheckedOut(CheckoutGuid) Then
                    'bc.RemoveCheckout(CheckoutGuid)
                    AutoGenSuccess = True
                    'Else
                    'AutoGenSuccess = False
                    'End If
                    'End If

                End While

            Catch ex As Exception
                Try
                    'If bc.AlreadyCheckedOut(CheckoutGuid) Then
                    'bc.RemoveCheckout(CheckoutGuid)
                    'End If
                Catch
                End Try
                UniSource.Logging.Log.Log.logError(String.Format("Error Saving Job State : {0}. Error {1}", Me.State, ex.Message), ex)
                Throw New Exception(String.Format("Error Saving Job State : {0}. Error {1}", Me.State, ex.Message))
            Finally
                'If bc.AlreadyCheckedOut(CheckoutGuid) Then
                'bc.RemoveCheckout(CheckoutGuid)
                'End If
            End Try
        Else
            '  JobGPCheck()
        End If
        Return MyBase.BeforeSave(state)

    End Function

    Public Overridable Function JobGPCheck() As Boolean
        If IsLoading = False Then
            If Me.JobLines.Count > 0 AndAlso Context.Defaults.IsSellingPriceGPChecked = True AndAlso (Context.Defaults.SellingPriceGPCheckType = GPCheckType.JobCard OrElse Context.Defaults.SellingPriceGPCheckType = GPCheckType.PerLineAndJobCard) Then
                Dim JobTotalCost As Double = 0
                Dim JobTotalPrice As Double = 0
                Dim JobTotalPriceBeforeDiscount As Double = 0
                Dim JobTotalDiscount As Double = 0
                Dim NewDiscount As Double? = 0
                Dim DiscountLineCount As Integer = 0

                For Each jobLine In Me.JobLines
                    JobTotalCost += jobLine.TotalActualCost
                    JobTotalPrice += jobLine.TotalPrice
                    JobTotalPriceBeforeDiscount += jobLine.UnitPriceBeforeDiscount * jobLine.Quantity
                    If jobLine.LineDiscountPercent > 0 Then
                        JobTotalDiscount += jobLine.LineDiscountPercent
                        DiscountLineCount += 1
                    End If
                Next
                JobTotalDiscount = JobTotalDiscount / DiscountLineCount
                If Context.Defaults.IsGPCorrect(JobTotalDiscount, JobTotalCost, JobTotalPrice, JobTotalPriceBeforeDiscount, Me.Customer.ID, NewDiscount) = False Then
                    'Dim gpMessage As String = String.Format("Discount Set to high. Can Job Pro Change it from {0}% to {1}% ?", JobTotalDiscount * 100, NewDiscount * 100)
                    Dim GPPercentage As Double = ((UnitPrice - ActualCost) / UnitPrice) '* 100
                    Dim SellingPriceGPPercentage As Double = Context.Defaults.GetSellingPriceGPPercentage(Me.Customer.ID)
                    Dim gpMessage As String = String.Format("GP to low check discounts and mark-up. Current GP {0}% expected GP {1}% ." + vbCrLf + "Do you want to continue saving?", Math.Round(GPPercentage, 4) * 100, SellingPriceGPPercentage * 100)
                    If UniSource.Helper.GUI.Dialog.YesNoDialog(gpMessage) = Windows.Forms.DialogResult.Yes Then
                        UniSource.Logging.Log.Log.logInfo(gpMessage, Nothing, False)
                        'UniSource.Helper.GUI.Dialog.OKDialog("Discount Overide has been logged")
                        'Else
                        '    For Each jobLine In Me.JobLines
                        '        'If (jobLine.WorkCentre IsNot Nothing AndAlso jobLine.WorkCentre.IsBuyOut = False AndAlso jobLine.WorkCentre.CalculationType = CalculationType.Standard) Then
                        '        If jobLine.LineDiscountPercent > 0 Then
                        '            jobLine.LineDiscountPercent = NewDiscount
                        '            'jobLine.SaveAndFlush()
                        '        End If
                        '        'End If
                        '    Next

                        Return True
                    Else
                        Return False
                    End If
                End If
            End If
        End If
        Return True
    End Function

    Public Overrides Sub Save()
        CheckJobAudit()
        UpdatesJobHeadeDetailOnERP()
        MyBase.Save()
    End Sub

    Public Overrides Sub SaveAndFlush()
        CheckJobAudit()
        UpdatesJobHeadeDetailOnERP()
        MyBase.SaveAndFlush()
    End Sub

    Private Sub CheckJobAudit()
        'If ID > 0 Then
        '    Dim oldJob As API.Job = New API.Job()
        '    oldJob = API.Job.Find(Me.ID)
        '    oldJob = API.Job.FindOne("id", Me.ID)
        '    oldJob = API.Job.TryFind(Me.ID)
        '    'API.Audit.AreEqual(Me, oldJob, Context.Agent)
        'End If
        If ID > 0 Then

            'Dim SqlSelectStatement As String = "SELECT * " &
            '                               "FROM dbo.ussSFJob"
            'SqlSelectStatement = SqlSelectStatement & String.Format(" Where id = {0}", Me.ID)
            'Dim PrevJobdatatable As DataTable = Pastel.Evolution.DatabaseContext.ExecuteCommandDataTable(SqlSelectStatement)
            Dim Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
            Try
                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    Dim tmpManualAudit As API.Job = New API.Job
                    'For Each row As DataRow In PrevJobdatatable.Rows
                    '    'This is used to do the reflection
                    '    Dim t As Type = GetType(API.Job)
                    '    For i As Int32 = 0 To PrevJobdatatable.Columns.Count - 1
                    '        'Don't ask it just works
                    '        Try
                    '            'NOTE the datarow column names must match exactly 
                    '            '(including case) to the object property names
                    '            't.InvokeMember(ManualAuditHeaderdatable.Columns(i).ColumnName, Reflection.BindingFlags.DeclaredOnly Or Reflection.BindingFlags.Public Or Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or Reflection.BindingFlags.SetField, Nothing, tmpManualAudit, New Object() {row((ManualAuditHeaderdatable.Columns(i).ColumnName)).ToString})
                    '            'Dim proptype As Type = GetType(String)
                    '            'Dim propInfo As Reflection.PropertyInfo
                    '            'propInfo = t.GetProperty(ManualAuditHeaderdatable.Columns(i).ColumnName)
                    '            'proptype = propInfo.PropertyType
                    '            t.InvokeMember(PrevJobdatatable.Columns(i).ColumnName, Reflection.BindingFlags.SetProperty, Nothing, tmpManualAudit, New Object() {row((PrevJobdatatable.Columns(i).ColumnName))})

                    '        Catch ex As Exception
                    '            'Usually you are getting here because a column 
                    '            'doesn't exist or it is null
                    '            If ex.ToString() IsNot Nothing Then
                    '            End If
                    '        End Try
                    '    Next
                    'Next
                    tmpManualAudit = API.Job.FindOne("id", Me.ID)
                    If Context.SecondAgent Is Nothing Then
                        API.Audit.AreEqual(Me, tmpManualAudit, Context.Agent)
                    Else
                        API.Audit.AreEqual(Me, tmpManualAudit, Context.SecondAgent)
                    End If
                End Using
            Catch
            Finally
                'Conversation.Restart()
            End Try
        End If
    End Sub

    Public Overridable Sub ConvertQuoteToActiveJob(Optional ByVal jobNumber As String = "")
        If Me.State = JobState.Quote Then
            Me.State = JobState.Active
            Dim autoJobNumber As String = Defaults.Defaults.GetNextJobNumberAndIncrement(Me)
            If autoJobNumber IsNot Nothing And Context.Defaults.IsJobNumberAutoGenerated Then
                Me.JobNumber = autoJobNumber
            Else
                Me.JobNumber = jobNumber
            End If
            Me.JobDate = Today.Date
            Me.JobAgentID = Context.Agent.ID
            Me.JobStage = JobType.JobTypeStages.FirstOrDefault.JobStage
            Me.SaveAndFlush()
        End If
    End Sub

    Public Overrides Function ToString() As String
        'Return String.Format("{0} ({1})", MyBase.Number, MyBase.Description)
        Return MyBase.JobNumber
    End Function

    Public Overrides Property UnitCost As Double?
        Get
            If IsLoading = False Then
                If _joblinelist IsNot Nothing Then
                    Dim newUnitCost As Double = Aggregate jl In _joblinelist Into Sum(jl.TotalCost)
                    If MyBase.UnitCost Is Nothing OrElse Math.Round(CDec(MyBase.UnitCost), 4) <> Math.Round(newUnitCost, 4) Then
                        MyBase.UnitCost = Math.Round(newUnitCost, 4)
                    End If
                ElseIf MyBase.UnitCost Is Nothing Then
                    MyBase.UnitCost = 0
                End If
            End If
            Return MyBase.UnitCost
        End Get
        Set(ByVal value As Double?)
            MyBase.UnitCost = value
        End Set
    End Property

    Public Overrides Property ActualCost As Double?
        Get
            If IsLoading = False Then
                If _joblinelist IsNot Nothing Then
                    Dim newActualCost As Double = Aggregate jl In _joblinelist Into Sum(jl.TotalActualCost)
                    If MyBase.ActualCost Is Nothing OrElse Math.Round(CDec(MyBase.ActualCost), 4) <> Math.Round(newActualCost, 4) Then
                        MyBase.ActualCost = Math.Round(newActualCost, 4)
                    End If
                ElseIf MyBase.ActualCost Is Nothing Then
                    MyBase.ActualCost = 0
                End If
            End If
            Return MyBase.ActualCost
        End Get
        Set(ByVal value As Double?)
            MyBase.ActualCost = value
        End Set
    End Property

    Public Overrides Property SupplierQuantityDelivered As Integer?
        Get
            If IsLoading = False Then
                If _supplierdeliverynoteCollection IsNot Nothing Then
                    Dim newSupplierQuantityDelivered As Integer? = Aggregate sdn In _supplierdeliverynoteCollection Into Sum(sdn.Quantity)
                    If MyBase.SupplierQuantityDelivered Is Nothing OrElse MyBase.SupplierQuantityDelivered <> newSupplierQuantityDelivered Then
                        MyBase.SupplierQuantityDelivered = newSupplierQuantityDelivered
                    End If
                ElseIf MyBase.SupplierQuantityDelivered Is Nothing Then
                    MyBase.SupplierQuantityDelivered = 0
                End If
            End If
            Return MyBase.SupplierQuantityDelivered
        End Get
        Set(value As Integer?)
            MyBase.SupplierQuantityDelivered = value
        End Set
    End Property

    Public Overrides Property UnitPrice As Double?
        Get
            If IsLoading = False Then
                If _joblinelist IsNot Nothing Then
                    Dim newUnitPrice As Double = Aggregate jl In _joblinelist Into Sum(jl.TotalPrice)
                    If MyBase.UnitPrice Is Nothing OrElse Math.Round(newUnitPrice, 4) <> Math.Round(CDec(MyBase.UnitPrice), 4) Then
                        Return Math.Round(newUnitPrice, 4)
                    End If
                ElseIf MyBase.UnitPrice Is Nothing Then
                    Return 0
                End If
            End If
            Return MyBase.UnitPrice
        End Get
        Set(ByVal value As Double?)
            MyBase.UnitPrice = value
        End Set
    End Property

    Public Overrides Property TotalCost As Double?
        Get
            'MyBase.TotalCost = MyBase.UnitCost * MyBase.Quantity
            If IsLoading = False Then
                Dim newTotalCost As Double = UnitCost * Quantity
                If MyBase.TotalCost Is Nothing OrElse Math.Round(CDec(MyBase.TotalCost), 4) <> Math.Round(newTotalCost, 4) Then
                    MyBase.TotalCost = Math.Round(newTotalCost, 4)
                End If
                'Dim jobUnitCost As Double? = MyBase.UnitCost * MyBase.Quantity
                'If jobUnitCost <> MyBase.TotalCost Then
                '    MyBase.TotalCost = jobUnitCost
                'End If
            End If
            Return MyBase.TotalCost
        End Get
        Set(ByVal value As Double?)
            MyBase.TotalCost = value
        End Set
    End Property

    Public Overrides Property TotalPrice As Double?
        Get
            If IsLoading = False Then
                Dim newTotalPrice As Double = UnitPrice * Quantity
                If MyBase.TotalPrice Is Nothing OrElse Math.Round(CDec(MyBase.TotalPrice), 2) <> Math.Round(newTotalPrice, 2) Then
                    'MyBase.TotalPrice = Math.Round(newTotalPrice, 4)
                    MyBase.TotalPrice = Math.Round(newTotalPrice, 2)
                End If
                'Dim jobTotalPrice As Double? = MyBase.UnitPrice * MyBase.Quantity
                'If jobTotalPrice <> MyBase.TotalPrice Then
                '    MyBase.TotalCost = jobTotalPrice
                'End If
            End If
            Return MyBase.TotalPrice
        End Get
        Set(ByVal value As Double?)
            MyBase.TotalPrice = value
        End Set
    End Property

    Public Overrides Property Quantity As Double?
        Get
            If MyBase.Quantity Is Nothing OrElse MyBase.Quantity = 0 Then
                MyBase.Quantity = 1
            End If
            Return MyBase.Quantity
        End Get
        Set(ByVal value As Double?)
            MyBase.Quantity = value
        End Set
    End Property

    Public Overridable Sub UpdateGPValues()
        If IsLoading = False Then
            If MyBase.ExpectedGP Is Nothing Then
                Dim SellingPriceGPPercentage As Double = Math.Round(Context.Defaults.GetSellingPriceGPPercentage(Me.Customer.ID), 4)
                MyBase.ExpectedGP = Math.Round(SellingPriceGPPercentage, 4)
            End If

            Dim GPPercentage As Double
            GPPercentage = ((UnitPrice - ActualCost) / UnitPrice) '/ 100
            If UnitPrice = 0 Then
                If UnitCost > 0 Then
                    GPPercentage = -100
                Else
                    GPPercentage = 100
                End If
            Else
                GPPercentage = Math.Round(GPPercentage, 4)
            End If
            If MyBase.CurrentGP Is Nothing OrElse MyBase.CurrentGP <> Math.Round(GPPercentage, 4) Then
                MyBase.CurrentGP = Math.Round(GPPercentage, 4)
            End If
        End If
    End Sub

    Public Overrides Property ExpectedGP As Double?
        Get
            If IsLoading = False Then
                If MyBase.ExpectedGP Is Nothing AndAlso Me.Customer IsNot Nothing Then
                    Dim SellingPriceGPPercentage As Double = Math.Round(Context.Defaults.GetSellingPriceGPPercentage(Me.Customer.ID), 4)
                    If MyBase.ExpectedGP Is Nothing OrElse MyBase.ExpectedGP <> Math.Round(SellingPriceGPPercentage, 4) Then
                        MyBase.ExpectedGP = Math.Round(SellingPriceGPPercentage, 4)
                    End If
                End If
            End If
            Return MyBase.ExpectedGP
        End Get
        Set(value As Double?)
            MyBase.ExpectedGP = value
        End Set
    End Property

    Public Overrides Property CurrentGP As Double?
        Get
            If IsLoading = False Then
                Dim GPPercentage As Double
                GPPercentage = ((UnitPrice - ActualCost) / UnitPrice) '/ 100
                If UnitPrice = 0 Then
                    If UnitCost > 0 Then
                        GPPercentage = -100
                    Else
                        GPPercentage = 100
                    End If
                Else
                    GPPercentage = Math.Round(GPPercentage, 4)
                End If
                If MyBase.CurrentGP Is Nothing OrElse Math.Round(CDbl(MyBase.CurrentGP), 4) <> Math.Round(GPPercentage, 4) Then
                    MyBase.CurrentGP = Math.Round(GPPercentage, 4)
                End If
            End If
            Return MyBase.CurrentGP
        End Get
        Set(value As Double?)
            MyBase.CurrentGP = value
        End Set
    End Property

    Public Overrides Property QuantityDelivered As Double?
        Get
            If IsLoading = False Then
                If _jobdeliverylist IsNot Nothing Then
                    Dim newQuantityDelivered As Double = Aggregate jd In _jobdeliverylist Into Sum(jd.Quantity)
                    If MyBase.QuantityDelivered Is Nothing OrElse Math.Round(newQuantityDelivered, 4) <> MyBase.QuantityDelivered Then
                        MyBase.QuantityDelivered = Math.Round(newQuantityDelivered, 4)
                    End If
                    'Dim jobQuantityDelivered As Double? = Aggregate jd In _jobdeliverylist Into Sum(jd.Quantity)
                    'If jobQuantityDelivered <> MyBase.QuantityDelivered Then
                    '    MyBase.QuantityDelivered = jobQuantityDelivered
                    'End If
                End If
            End If
            Return MyBase.QuantityDelivered
        End Get
        Set(ByVal value As Double?)
            MyBase.QuantityDelivered = value
        End Set
    End Property

    Public Shared Function FindAllByStateAndStage(ByVal state As JobState, ByVal ParamArray jobStage As JobStage())
        Dim jobCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        'jobCrit.Add(NHibernate.Criterion.Expression.Eq("Joblineid", CInt(state)))
        jobCrit.Add(NHibernate.Criterion.Expression.Eq("StateID", CInt(state)))
        jobCrit.Add(NHibernate.Criterion.Expression.In("JobStage", jobStage))
        Return Job.FindAll(jobCrit)
    End Function

    Public Shared Function FindAllByStageAndState(ByVal stage As JobStage, ByVal ParamArray jobState As JobState())
        Dim jobCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        jobCrit.Add(NHibernate.Criterion.Expression.Eq("JobStage", stage))
        'jobCrit.Add(NHibernate.Criterion.Expression.In("State", jobState.Cast(Of Integer).ToArray))
        jobCrit.Add(NHibernate.Criterion.Expression.In("StateID", jobState.Cast(Of Integer).ToArray))
        Return Job.FindAll(jobCrit)
    End Function

    Public Shared Function FindAllByStage(ByVal ParamArray jobStage As JobStage())
        Dim jobCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        jobCrit.Add(NHibernate.Criterion.Expression.In("JobStage", jobStage))
        Return Job.FindAll(jobCrit)
    End Function

    Public Shared Function FindAllByState(ByVal ParamArray pjobState As JobState())
        Dim jobCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        'jobCrit.Add(NHibernate.Criterion.Expression.In("State", jobState.Cast(Of Integer).ToArray))
        jobCrit.Add(NHibernate.Criterion.Expression.In("StateID", pjobState.Cast(Of Integer).ToArray))
        Return Job.FindAll(jobCrit)
    End Function

    Public Shared Function FindAllByJobNumber(ByVal JobNumber As String)
        Dim jobCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        'jobCrit.Add(NHibernate.Criterion.Expression.In("State", jobState.Cast(Of Integer).ToArray))
        jobCrit.Add(NHibernate.Criterion.Expression.Eq("JobNumber", JobNumber))
        Return Job.FindAll(jobCrit)
    End Function


    Public Shared Function FindAllQuotes()
        Dim jobCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        jobCrit.Add(NHibernate.Criterion.Expression.IsNotNull("QuoteNumber"))
        Return Job.FindAll(jobCrit)
    End Function

    Public Overridable Function GetRequisitionLines() As IEnumerable(Of RequisitionLine)
        Dim reqs As New List(Of RequisitionLine)
        For Each jl As JobLine In (From jls In Me.JobLines Where jls.WorkCentre IsNot Nothing AndAlso ((jls.WorkCentre.CalculationType = CalculationType.Standard Or jls.WorkCentre.CalculationType = CalculationType.Formula) AndAlso Not IIf(jls.WorkCentre.IsBuyOut.HasValue, jls.WorkCentre.IsBuyOut, False)) AndAlso jls.InventoryItem IsNot Nothing AndAlso jls.InventoryItem.ServiceItem = False)
            Dim rl As RequisitionLine = jl.GetRequisitionLine
            If rl IsNot Nothing Then
                reqs.Add(rl)
            End If
        Next
        Return reqs
    End Function

    Public Overridable Function GetPurchaseOrders() As IEnumerable(Of PurchaseOrder)
        Dim pos As New List(Of PurchaseOrder)
        Dim sups As IEnumerable(Of Helper.ActiveRecord.Evolution.Vendor) = (From v As Helper.ActiveRecord.Evolution.Vendor In (From jl As API.JobLine In Me.JobLines Where jl.WorkCentre IsNot Nothing AndAlso jl.WorkCentre.IsBuyOut Select jl.Supplier1).Union(From jl As API.JobLine In Me.JobLines Where jl.WorkCentre IsNot Nothing AndAlso jl.WorkCentre.IsBuyOut Select jl.Supplier2) Select v Distinct Where v IsNot Nothing)
        For Each s As Helper.ActiveRecord.Evolution.Vendor In sups.Distinct
            Dim po As New PurchaseOrder
            po.AgentID = Context.Agent.ID
            po.AgentName = Context.Agent.Name
            po.Job = Me
            po.OrderDate = Today.Date
            po.Supplier = s
            po.PurchaseOrderLines = Me.GetPurchaseOrderLines(s)
            po.OrderNumber = "*"
            pos.Add(po)
        Next
        Return pos
    End Function

    Public Overridable Function GetPurchaseOrderLines(ByVal supplier As Helper.ActiveRecord.Evolution.Vendor) As IEnumerable(Of PurchaseOrderLine)
        Dim pos As New List(Of PurchaseOrderLine)
        'For Each jl As JobLine In (From jls In Me.JobLines Where (jls.Supplier1 = supplier Or jls.Supplier2 = supplier) AndAlso jls.WorkCentre IsNot Nothing AndAlso ((jls.WorkCentre.CalculationType = CalculationType.Standard Or jls.WorkCentre.CalculationType = CalculationType.Formula) AndAlso IIf(jls.WorkCentre.IsBuyOut.HasValue, jls.WorkCentre.IsBuyOut, False)))
        For Each jl As JobLine In (From jls In Me.JobLines Where (jls.Supplier1 = supplier Or jls.Supplier2 = supplier) AndAlso jls.WorkCentre IsNot Nothing AndAlso (IIf(jls.WorkCentre.IsBuyOut.HasValue, jls.WorkCentre.IsBuyOut, False)))
            Dim pol As PurchaseOrderLine = jl.GetPurchaseOrderLine(supplier)
            If pol IsNot Nothing Then
                pos.Add(pol)
            End If
        Next
        Return pos
    End Function

    Public Overridable Sub RecalculateLinePrices()
        For Each jobline As JobLine In Me.JobLines
            jobline.Recalculate()
            jobline.SaveAndFlush()
        Next

    End Sub


    Public Overridable ReadOnly Property TaxAmount As Double?
        Get
            If TotalPrice Is Nothing OrElse Customer Is Nothing OrElse Customer.CT = False Then
                Return 0
            Else
                Dim ERPCustomer As Pastel.Evolution.Customer = New Pastel.Evolution.Customer(CInt(Customer.ID))
                Dim TaxRate As Double = 0.15
                If ERPCustomer.DefaultTaxRate IsNot Nothing Then
                    TaxRate = ERPCustomer.DefaultTaxRate.Rate
                End If
                Return Math.Round(CDbl(TotalPrice * CDbl(IIf(TaxRate > 1, (TaxRate / 100), TaxRate))), 2)
            End If

        End Get
    End Property

    Public Overridable ReadOnly Property TotalPriceIncl As Double?
        Get
            Return TotalPrice + TaxAmount
        End Get
    End Property


    'Public ReadOnly Property Agent As Pastel.Evolution.Agent
    '    Get
    '        If UniSource.LogOn.Evolution.Setup.Agent IsNot Nothing Then
    '            Return UniSource.LogOn.Evolution.Setup.Agent
    '        Else
    '            Return Nothing
    '        End If
    '    End Get
    'End Property

    'Public Shared Function PrintDamageAndFailure()

    '    Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
    '    crit.Add(New NHibernate.Criterion.OrExpression(NHibernate.Criterion.Expression.IsNull("CollectionLoad"), NHibernate.Criterion.Expression.Eq("CollectionLoad", False)))

    '    Dim result = API.Job.FindAll(crit).ToList

    '    If result IsNot Nothing Then
    '        Return result
    '    Else
    '        Return Nothing
    '    End If
    'End Function

    'Public Shared Function PrintQuotation()

    '    'Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
    '    'crit.Add(New NHibernate.Criterion.OrExpression(NHibernate.Criterion.Expression.IsNull("CollectionLoad"), NHibernate.Criterion.Expression.Eq("CollectionLoad", False)))

    '    Dim result = API.Job.FindAll.ToList

    '    If result IsNot Nothing Then
    '        Return result
    '    Else
    '        Return Nothing
    '    End If
    'End Function


    'Public Shared Function PrintInspection()

    '    Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
    '    crit.Add(New NHibernate.Criterion.OrExpression(NHibernate.Criterion.Expression.IsNull("CollectionLoad"), NHibernate.Criterion.Expression.Eq("CollectionLoad", False)))

    '    Dim result = API.Job.FindAll(crit).ToList

    '    If result IsNot Nothing Then
    '        Return result
    '    Else
    '        Return Nothing
    '    End If
    'End Function

    Public Shared Function GetAgents() As List(Of Pastel.Evolution.Agent)
        Dim agent As New List(Of Pastel.Evolution.Agent)

        For Each row In Pastel.Evolution.Agent.List("cAgentName <> ''").Rows
            agent.Add(New Pastel.Evolution.Agent(CInt(row("idAgents"))))
        Next
        Return agent
    End Function

    'Protected Overrides Function OnFlushDirty(ByVal id As Object, ByVal previousState As System.Collections.IDictionary, ByVal currentState As System.Collections.IDictionary, ByVal types() As NHibernate.Type.IType) As Boolean

    '    For Each propertyNames As String In previousState.Keys
    '        ' propertyNames = previousState(propertyNames)
    '        Try
    '            If previousState(propertyNames) IsNot Nothing AndAlso (currentState(propertyNames) Is Nothing OrElse Not previousState(propertyNames).Equals(currentState(propertyNames))) Then
    '                'API.Audit.AreEqual(currentState(propertyNames), previousState(propertyNames), Context.Agent)
    '                Dim log As New Audit
    '                log.Agent = Agent
    '                log.Description = "The " & propertyNames & " of the " & previousState(propertyNames).GetType().Name & " was changed."
    '                log.Type = previousState(propertyNames).GetType().Name
    '                log.OldValue = previousState(propertyNames)
    '                log.NewValue = currentState(propertyNames)
    '                log.job = Me
    '                log.SaveAndFlush()
    '            End If
    '        Catch ex As Exception
    '            propertyNames = ex.Message
    '        End Try
    '        '.NewValue = GetPropertyValue("[yourProperty]", currentState, propertyNames)
    '    Next
    '    Return MyBase.OnFlushDirty(id, previousState, currentState, types)
    'End Function
    'Called on an Update

    'TODO Audit

    'Public Sub OnPostUpdate(ByVal updateEvent As PostUpdateEvent)
    '    If TypeOf updateEvent.Entity Is AuditItem Then
    '        Return
    '    End If

    '    Dim dirtyFieldIndexes = updateEvent.Persister.FindDirty(updateEvent.State, updateEvent.OldState, updateEvent.Entity, updateEvent.Session)

    '    Dim data = New XElement("AuditedData")

    '    For Each dirtyFieldIndex As var In dirtyFieldIndexes
    '        Dim oldValue = GetStringValueFromStateArray(updateEvent.OldState, dirtyFieldIndex)
    '        Dim newValue = GetStringValueFromStateArray(updateEvent.State, dirtyFieldIndex)

    '        If oldValue = newValue Then
    '            Continue For
    '        End If

    '        data.Add(New XElement("Item", New XAttribute("Property", updateEvent.Persister.PropertyNames(dirtyFieldIndex)), New XElement("OldValue", oldValue), New XElement("NewValue", newValue)))
    '    Next

    '    AuditService.Record(data, updateEvent.Entity, AuditType.Update)
    'End Sub

    Public Overridable Function IsPOGRVComplete() As Boolean
        Dim AllPOCompleted As Boolean = False
        Dim SqlSelectStatement As String = ""
        SqlSelectStatement = String.Format("Select Count(_btblInvoiceLines.idInvoiceLines) " +
                             "From _btblInvoiceLines with(nolock), _btbljcMaster with(nolock), InvNum with(nolock) " +
                             "Where iJobID = _btbljcMaster.IdJCMaster " +
                             "And _btblInvoiceLines.iInvoiceID =  InvNum.AutoIndex " +
                             "And InvNum.DocState In (1,3) " +
                             "And InvNum.DocFlag In (1) " +
                             "And _btbljcMaster.cJobCode = '{0}'", JobNumber)

        Try
            Dim cn As SqlConnection
            Dim cmd As SqlCommand
            cn = New SqlConnection(Context.ActiveConnection.Company.ConnectionString)
            cn.Open()
            cmd = New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SqlSelectStatement
            Dim dtTypes As DataTable
            dtTypes = New DataTable
            dtTypes.Load(cmd.ExecuteReader)
            For Each rw In dtTypes.Rows
                If CType(rw(0), Integer) = 0 Then
                    AllPOCompleted = True
                End If
            Next
        Catch
        End Try

        Return AllPOCompleted
    End Function


    '    Public Overridable Function AssetUsageByJob() As DataTable
    '        Dim AllPOCompleted As Boolean = False
    '        Dim SqlSelectStatement As String = ""
    '        SqlSelectStatement = String.Format("SELECT  SUM(JL.PrimaryAssetUsage) AS 'Usage', A.Description, AC.Description AS AssetClass, " & _
    '       " w.ApprovedUsage, JL.JobID " & _
    '"FROM            dbo.ussSFJobLine AS JL INNER JOIN " & _
    '"                         dbo.ussSFAsset AS A ON JL.AssetID = A.Id INNER JOIN " & _
    '"                         dbo.ussSFAssetClass AS AC ON AC.ID = A.AssetClass INNER JOIN " & _
    '"                         dbo.ussSFWorkCentre AS w ON w.id = JL.WorkCentreID where JL.JobID = {0}" & _
    '"GROUP BY JL.JobID, A.Description, AC.Description, w.ApprovedUsage", ID)
    '        Dim dtTypes As DataTable
    '        Try
    '            Dim cn As SqlConnection
    '            Dim cmd As SqlCommand
    '            cn = New SqlConnection(Context.ActiveConnection.Company.ConnectionString)
    '            cn.Open()
    '            cmd = New SqlCommand
    '            cmd.Connection = cn
    '            cmd.CommandType = CommandType.Text
    '            cmd.CommandText = SqlSelectStatement

    '            dtTypes = New DataTable
    '            dtTypes.Load(cmd.ExecuteReader)

    '        Catch
    '        End Try

    '        Return dtTypes
    '    End Function

    Public Sub UpdatesJobHeadeDetailOnERP()

        'Checks if Job No exist in ERP
        Try
            Dim ERPJobCard = New Pastel.Evolution.JobCard(JobNumber)
            If ERPJobCard IsNot Nothing AndAlso ERPJobCard.Code = JobNumber AndAlso ERPJobCard.Active AndAlso IsERPJobInvoiced() = False Then
                'Update Job Detail if diffrent.
                Dim UpdateERPJobCard As Boolean = False
                With ERPJobCard
                    Dim previouscustomer = New Pastel.Evolution.Customer(.Account.Code)
                    If .Account.ID <> CInt(Customer.ID) Then
                        .Account = New Pastel.Evolution.Customer(CInt(Customer.ID))
                        .DeliverTo = .Account.PhysicalAddress
                        .InvoiceTo = .Account.PostalAddress
                        UpdateERPJobCard = True
                    End If
                    If Description1 IsNot Nothing Then
                        If Description1.Length > 40 AndAlso .Description <> Description1.Substring(0, 40) Then
                            .Description = Description1.Substring(0, 40)
                            UpdateERPJobCard = True
                        ElseIf Description1.Length <= 40 AndAlso .Description <> Description1 Then
                            .Description = Description1
                            UpdateERPJobCard = True
                        End If
                    End If
                    If OrderNumber IsNot Nothing Then
                        If .ExtOrderNo <> OrderNumber AndAlso OrderNumber.Length <= 50 Then
                            .ExtOrderNo = OrderNumber
                            UpdateERPJobCard = True
                        ElseIf OrderNumber.Length > 50 AndAlso .ExtOrderNo <> OrderNumber.Substring(0, 50) Then
                            .ExtOrderNo = OrderNumber.Substring(0, 50)
                            UpdateERPJobCard = True
                        End If
                    End If

                    If RepresentativeID IsNot Nothing AndAlso .SalesRepresentativeID <> RepresentativeID Then
                        .SalesRepresentativeID = RepresentativeID
                        UpdateERPJobCard = True
                    End If

                    'User Def Fields
                    Try
                        If WorkCentreCategory IsNot Nothing AndAlso .UserFields("ucJCJobProCategory") <> WorkCentreCategory.Code Then
                            .UserFields("ucJCJobProCategory") = WorkCentreCategory.Code
                            UpdateERPJobCard = True
                        End If
                        If TotalPrice IsNot Nothing AndAlso .UserFields("ufJCJobProPrice") <> TotalPrice Then
                            .UserFields("ufJCJobProPrice") = TotalPrice
                            UpdateERPJobCard = True
                        End If
                        If CostCentre IsNot Nothing AndAlso .UserFields("ucJCJobProCostCentre") <> CostCentre.Code Then
                            .UserFields("ucJCJobProCostCentre") = CostCentre.Code
                            UpdateERPJobCard = True
                        End If
                    Catch ex As Exception
                    End Try

                    If .Account.DefaultTaxRate IsNot Nothing Then
                        If .Account.DefaultTaxRate.Code <> previouscustomer.DefaultTaxRate.Code Then
                            'change VAT if  previous customer tax is different from current tax
                            For Each lin As Pastel.Evolution.JobDetail In .Detail
                                lin.SalesTaxRate = New Pastel.Evolution.TaxRate(.Account.DefaultTaxRate.Code)
                            Next
                            'ERPJob.Save()
                            UpdateERPJobCard = True
                        End If
                    End If

                    ' saves job if there is any changes
                    If UpdateERPJobCard Then
                        .Save()
                    End If
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Public Overridable ReadOnly Property Entity As UniSource.Helper.ActiveRecord.Evolution.Entities
    '    Get
    '        Return UniSource.Helper.ActiveRecord.Evolution.Entities.FindAll.FirstOrDefault()

    '    End Get
    'End Property

    'Public Overridable ReadOnly Property TaxDefault As UniSource.Helper.ActiveRecord.Evolution.TaxDefaults
    '    Get
    '        Return UniSource.Helper.ActiveRecord.Evolution.TaxDefaults.FindAll.FirstOrDefault()
    '    End Get
    'End Property
    'Public Overridable ReadOnly Property TotalRate As Double?
    '    Get
    '        Return (Aggregate jll As JobLineTime In Me.JobLineTimes Into Sum(jll.TimeUnitPrice))

    '    End Get
    'End Property
    'Public Overridable ReadOnly Property TotalDayShift As Double?
    '    Get
    '        Return (Aggregate jll As JobLineTime In Me.JobLineTimes Into Sum(jll.DayShift))


    '    End Get
    'End Property
    'Public Overridable ReadOnly Property TotalNightShift As Double?
    '    Get
    '        Return (Aggregate jll As JobLineTime In Me.JobLineTimes Into Sum(jll.NightShift))


    '    End Get
    'End Property
    'Public Overridable ReadOnly Property HourTotal As Double?
    '    Get
    '        Return (Aggregate jll As JobLineTime In Me.JobLineTimes Into Sum(jll.Quantity))


    '    End Get
    'End Property
    'Public Overridable ReadOnly Property ShiftTotal As Double?
    '    Get
    '        If TotalDayShift IsNot Nothing AndAlso TotalNightShift IsNot Nothing Then
    '            Return (TotalDayShift + TotalNightShift)
    '        End If
    '    End Get
    'End Property
    'Public Overridable ReadOnly Property RatePerShift As Double?
    '    Get
    '        Return TotalRate / ShiftTotal

    '    End Get
    'End Property
    'Public Overridable ReadOnly Property RatePerHour As Double?
    '    Get
    '        Return TotalRate / HourTotal

    '    End Get
    'End Property

    Public Function IsERPJobInvoiced() As Boolean
        Dim IsInvoiced As Boolean = False
        If Me.JobCardID IsNot Nothing AndAlso Me.JobCardID > 0 Then
            Dim SQLSelect As String
            SQLSelect = String.Format("Select top 1 idJCTxLines From _btblJCTxLines Where bInvoiced = 1 and iJCMasterID = {0}", Me.JobCardID)
            Dim InvoiceDataset = Context.GetSQLDataTable(SQLSelect)
            If InvoiceDataset.Rows.Count >= 1 Then
                IsInvoiced = True
            End If
        End If
        Return IsInvoiced
    End Function


    Private WithEvents _attachments As ComponentModel.BindingList(Of JobAttachment)
    <SmartAssembly.Attributes.DoNotPrune()>
    Public Overridable ReadOnly Property AttachmentCollection As ComponentModel.BindingList(Of JobAttachment)
        Get
            If IsLoading = False AndAlso _attachments Is Nothing Then
                _attachments = New ComponentModel.BindingList(Of JobAttachment)(MyBase.JobAttachments)
            End If
            Return _attachments
        End Get
    End Property

    'Public Overrides Property CostCentre As CostCentre
    '    Get
    '        Return MyBase.CostCentre
    '    End Get
    '    Set(value As CostCentre)
    '        MyBase.CostCentre = value
    '    End Set
    'End Property

    Private Property _jobTemplate As JobTemplate
    '<BelongsTo("TemplateID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    Public Overridable Property JobTemplate As JobTemplate
        Get
            If IsLoading = False Then
                If TemplateID IsNot Nothing AndAlso TemplateID > 0 Then
                    _jobTemplate = JobTemplate.Get(TemplateID)
                End If
            End If
            Return _jobTemplate
        End Get
        Set(value As JobTemplate)
            _jobTemplate = value
            TemplateID = value.ID
            NotifyPropertyChanged("JobTemplate")
        End Set
    End Property

    Public Overrides Property IsCancelled As Boolean?
        Get
            If MyBase.IsCancelled Is Nothing Then
                MyBase.IsCancelled = False
            End If
            Return MyBase.IsCancelled
        End Get
        Set(value As Boolean?)
            MyBase.IsCancelled = value
        End Set
    End Property

    Public Overrides Property IsApproved As Boolean?
        Get
            If MyBase.IsApproved Is Nothing Then
                MyBase.IsApproved = False
            End If
            Return MyBase.IsApproved
        End Get
        Set(value As Boolean?)
            MyBase.IsApproved = value
        End Set
    End Property

    ' Freddie - Default Dicount Percent 
    Public Overrides Property DefaultDiscountPercent As Double?
        Get
            If MyBase.DefaultDiscountPercent Is Nothing Then
                If Customer IsNot Nothing Then
                    MyBase.DefaultDiscountPercent = Customer.AutoDisc
                End If
            End If
            Return MyBase.DefaultDiscountPercent
        End Get
        Set(value As Double?)
            MyBase.DefaultDiscountPercent = value
        End Set
    End Property

    ' Freddie Dosco SupplierDeliveryNote
    Private WithEvents _supplierdeliverynoteCollection As ComponentModel.BindingList(Of JobSupplierDeliveryNote)
    Public Overridable Overloads ReadOnly Property JobSupplierDeliveryNoteCollection As ComponentModel.BindingList(Of JobSupplierDeliveryNote)
        Get
            If IsLoading = False AndAlso _supplierdeliverynoteCollection Is Nothing AndAlso Me.JobSupplierDeliveryNotes IsNot Nothing Then
                _supplierdeliverynoteCollection = New ComponentModel.BindingList(Of JobSupplierDeliveryNote)(Me.JobSupplierDeliveryNotes)
            End If
            Return _supplierdeliverynoteCollection
        End Get
    End Property


    Public Overridable ReadOnly Property ProformainvoiceType As String
        Get
            If JobNumber Is Nothing OrElse JobNumber = "" Then
                Return "Quote Number"
            Else
                Return "Job Number"
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property ProformainvoiceTypeReference As String
        Get
            If JobNumber Is Nothing OrElse JobNumber = "" Then
                Return QuoteNumber
            Else
                Return JobNumber
            End If
        End Get
    End Property


    Public Sub UpdateAllDiscountLines()

        For Each Line In JobLines
            Line.LineDiscountPercent = Me.DefaultDiscountPercent / 100
        Next
    End Sub

    Public Overridable ReadOnly Property AssetOperatorName As String
        Get
            If AssetOperator Is Nothing OrElse AssetOperator = 0 Then
                Return ""
            Else
                Try
                    Dim emp As API.Employee = API.Employee.FindOne("id", AssetOperator)
                    Return emp.Person.DisplayName
                Catch ex As Exception
                    Return ""
                End Try
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property AssetDescription As String
        Get
            If EquipamentoNo1 Is Nothing OrElse EquipamentoNo1 = 0 Then
                Return ""
            Else
                Try
                    Dim eq As API.Asset = API.Asset.FindOne("id", EquipamentoNo1)

                    Return eq.Description
                Catch ex As Exception
                    Return ""
                End Try
            End If
        End Get
    End Property
    Public Overridable ReadOnly Property SerialNumber As String
        Get
            If EquipamentoNo1 Is Nothing OrElse EquipamentoNo1 = 0 Then
                Return ""
            Else
                Try
                    Dim sn As API.Asset = API.Asset.FindOne("id", EquipamentoNo1)
                    Return sn.SerialNo
                Catch ex As Exception
                    Return ""
                End Try
            End If

        End Get
    End Property


    Public Function ValidateAsset() As String
        Dim EquipmentIDs As List(Of Integer) = New List(Of Integer)
        Dim message As String = ""
        Dim JobAssetList As List(Of JobAsset) = New List(Of JobAsset)

        If If(Context.Defaults.ValidateActiveJobsAsset, False) = False Then
            Return message
        End If

        If EquipamentoNo1 IsNot Nothing AndAlso EquipamentoNo1.Value > 0 Then
            EquipmentIDs.Add(EquipamentoNo1.Value)
        End If
        If EquipamentoNo2 IsNot Nothing AndAlso EquipamentoNo2.Value > 0 Then
            EquipmentIDs.Add(EquipamentoNo2.Value)
        End If
        If EquipamentoNo3 IsNot Nothing AndAlso EquipamentoNo3.Value > 0 Then
            EquipmentIDs.Add(EquipamentoNo3.Value)
        End If
        If EquipamentoNo4 IsNot Nothing AndAlso EquipamentoNo4.Value > 0 Then
            EquipmentIDs.Add(EquipamentoNo4.Value)
        End If
        If EquipamentoNo5 IsNot Nothing AndAlso EquipamentoNo5.Value > 0 Then
            EquipmentIDs.Add(EquipamentoNo5.Value)
        End If

        If EquipmentIDs.Count > 0 Then
            Dim jobCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
            jobCrit.Add(NHibernate.Criterion.Expression.Sql(String.Format("StateID = 0 And (EquipamentoNo1 In ({0}) Or EquipamentoNo2 In ({0}) Or EquipamentoNo3 In ({0}) Or EquipamentoNo4 In ({0}) Or EquipamentoNo5 In ({0})) And StageID In (Select t1.id From ussSFJobStage t1 Where ValidateActiveJobsAsset = 1)", String.Join(",", EquipmentIDs))))
            Dim jobEquipamentlist As List(Of Job) = Job.FindAll(jobCrit).ToList()

            If jobEquipamentlist IsNot Nothing AndAlso jobEquipamentlist.Count > 0 Then
                For Each jobEquipament In jobEquipamentlist
                    If EquipmentIDs.Contains(If(jobEquipament.EquipamentoNo1, 0)) Then
                        Dim equipament As API.Asset = API.Asset.FindOne("id", jobEquipament.EquipamentoNo1)
                        If equipament IsNot Nothing Then
                            Dim JobAsset As JobAsset = New JobAsset()
                            JobAsset.JobNumber = jobEquipament.JobNumber
                            JobAsset.AssetDescription = equipament.Description
                            If JobAssetList.Contains(JobAsset) = False Then
                                JobAssetList.Add(JobAsset)
                            End If
                        End If
                    End If

                    If EquipmentIDs.Contains(If(jobEquipament.EquipamentoNo2, 0)) Then
                        Dim equipament As API.Asset = API.Asset.FindOne("id", jobEquipament.EquipamentoNo2)
                        If equipament IsNot Nothing Then
                            Dim JobAsset As JobAsset = New JobAsset()
                            JobAsset.JobNumber = jobEquipament.JobNumber
                            JobAsset.AssetDescription = equipament.Description
                            If JobAssetList.Contains(JobAsset) = False Then
                                JobAssetList.Add(JobAsset)
                            End If
                        End If
                    End If

                    If EquipmentIDs.Contains(If(jobEquipament.EquipamentoNo3, 0)) Then
                        Dim equipament As API.Asset = API.Asset.FindOne("id", jobEquipament.EquipamentoNo3)
                        If equipament IsNot Nothing Then
                            Dim JobAsset As JobAsset = New JobAsset()
                            JobAsset.JobNumber = jobEquipament.JobNumber
                            JobAsset.AssetDescription = equipament.Description
                            If JobAssetList.Contains(JobAsset) = False Then
                                JobAssetList.Add(JobAsset)
                            End If
                        End If
                    End If

                    If EquipmentIDs.Contains(If(jobEquipament.EquipamentoNo4, 0)) Then
                        Dim equipament As API.Asset = API.Asset.FindOne("id", jobEquipament.EquipamentoNo4)
                        If equipament IsNot Nothing Then
                            Dim JobAsset As JobAsset = New JobAsset()
                            JobAsset.JobNumber = jobEquipament.JobNumber
                            JobAsset.AssetDescription = equipament.Description
                            If JobAssetList.Contains(JobAsset) = False Then
                                JobAssetList.Add(JobAsset)
                            End If
                        End If
                    End If

                    If EquipmentIDs.Contains(If(jobEquipament.EquipamentoNo5, 0)) Then
                        Dim equipament As API.Asset = API.Asset.FindOne("id", jobEquipament.EquipamentoNo5)
                        If equipament IsNot Nothing Then
                            Dim JobAsset As JobAsset = New JobAsset()
                            JobAsset.JobNumber = jobEquipament.JobNumber
                            JobAsset.AssetDescription = equipament.Description
                            If JobAssetList.Contains(JobAsset) = False Then
                                JobAssetList.Add(JobAsset)
                            End If
                        End If
                    End If
                Next

                For Each JobAssetGroup In JobAssetList.OrderBy(Function(x) x.AssetDescription).GroupBy(Function(x) x.AssetDescription)
                    message += String.Format("{0} - Por favor, Processe os Jobcards Pendentes – {1}", JobAssetGroup.Key, String.Join(", ", JobAssetList.Where(Function(x) x.AssetDescription = JobAssetGroup.Key).Select(Function(x) x.JobNumber).ToList())) + vbCrLf
                Next
            End If

        End If

        Return message
    End Function

End Class

Public Class JobAsset

    Public Property JobNumber As String
    Public Property AssetDescription As String

End Class
