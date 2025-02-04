Imports System.Data.SqlClient
Imports DevExpress.XtraEditors


Public Class xaeJob3
    Inherits UniSource.ShopFloor.GUI.xaegJob3
    'Public Property Defaults As API.Defaults
    Private Property job As API.Job
    Private Property workCentreCategory As API.WorkCentreCategory
    Private userFieldsLoaded As Boolean = False

    Dim Loaded As Boolean = False
    Dim MyDataAdapter As New SqlDataAdapter()
    Dim MyDataset As DataSet = New DataSet()

    Dim TotalHrs As Decimal
    Dim Mileage As Decimal


    Dim asset1Usage As Double
    Dim asset2Usage As Double
    Dim asset3Usage As Double
    Dim asset4Usage As Double
    Dim asset5Usage As Double

    Dim asset1 As String
    Dim asset2 As String
    Dim asset3 As String
    Dim asset4 As String
    Dim asset5 As String

    Dim AssetType1 As Boolean
    Dim AssetType2 As Boolean
    Dim AssetType3 As Boolean
    Dim AssetType4 As Boolean
    Dim AssetType5 As Boolean


    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub xaeJob_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        'Try
        '    Defaults = API.Context.Defaults
        'Catch ex As Exception
        '    Setup.Log.logError("Error loading System Defaults.", ex)
        'End Try

        Try
            SetCLH()
        Catch ex As Exception
            Setup.Log.logError("Error setting component layout helper.", ex)
        End Try



        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetClass)(AssetClassLookUpEdit, AddressOf LoadAssetClass, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Class.", ex)
        End Try


        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of Helper.ActiveRecord.Evolution.Client)(CustomerLookUpEdit, AddressOf LoadClients, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Client.", ex)
        End Try


        Try
            Dim ST As New Helper.ActiveRecord.LookupMaintenance(Of API.ServiceType)(ServiceTypeLookUpEdit, xaeServiceType, AddressOf LoadServiceType, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Service Type.", ex)
        End Try


        Try
            Dim STemp As New Helper.ActiveRecord.LookupMaintenance(Of API.ServiceTemplate)(ServiceTemplateLookUpEdit2, xaeServiceTemplate, AddressOf LoadServiceTemplate, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Service Type.", ex)
        End Try


        Try
            Dim wcclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentreCategory)(WorkCenterCATLookUpEdit1, xaeWorkCentreCategory, AddressOf LoadWorkCentreCategories, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centre Categories.", ex)
        End Try

        Try
            Dim jt As New Helper.ActiveRecord.LookupMaintenance(Of API.JobTemplate)(TemplateLookUpEdit, xaeJobTemplate, AddressOf LoadTemplates, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Job Templates.", ex)
        End Try

        Try
            Dim rbl As New Helper.Evolution.LookupLoader(Of Pastel.Evolution.SalesRepresentative)(RepresentativeIDLookUpEdit, SalesRepresentativeBindingSource, "idSalesRep")
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Sales Reps.", ex)
        End Try
        'LoadPeople

        Try
            Dim emplo As New Helper.ActiveRecord.LookupMaintenance(Of API.Employee)(AssetOperatorLookUpEdit1, xaeEmployee, AddressOf LoadPeople, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Employees.", ex)
        End Try

        'OperatorLookUpEdit1

        Try
            Dim emplo1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Employee)(OperatorLookUpEdit1, xaeEmployee, AddressOf LoadPeople, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Employees.", ex)
        End Try

        Try
            Dim emplo1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Employee)(AssetOperatorLookUpEdit2, xaeEmployee, AddressOf LoadPeople, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Employees.", ex)
        End Try

        Try
            Dim emplo1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Employee)(AssetOperatorLookUpEdit3, xaeEmployee, AddressOf LoadPeople, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Employees.", ex)
        End Try

        Try
            Dim emplo1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Employee)(AssetOperatorLookUpEdit4, xaeEmployee, AddressOf LoadPeople, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Employees.", ex)
        End Try

        Try
            Dim emplo1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Employee)(AssetOperatorLookUpEdit5, xaeEmployee, AddressOf LoadPeople, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Employees.", ex)
        End Try

        Try
            Dim emplo3 As New Helper.ActiveRecord.LookupMaintenance(Of API.Employee)(WorkShopManagerLookUpEdit3, xaeEmployee, AddressOf LoadPeople, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Employees.", ex)
        End Try

        Try
            Dim emplo2 As New Helper.ActiveRecord.LookupMaintenance(Of API.Employee)(TechnicianLookUpEdit2, xaeEmployee, AddressOf LoadPeople, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Employees.", ex)
        End Try

        Try
            Dim jt As New Helper.ActiveRecord.LookupMaintenance(Of API.JobTemplate)(TemplateLookUpEdit, xaeJobTemplate, AddressOf LoadTemplates, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Job Templates.", ex)
        End Try

        Try
            Dim plbl As New Helper.Evolution.LookupLoader(Of Pastel.Evolution.PriceList)(PricelistLookUpEdit, PriceListBindingSource, "IDPricelistName")
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Pricelists.", ex)
        End Try

        Try
            Dim clm As New Helper.ActiveRecord.LookupMaintenance(Of API.JobCategory)(JobCategoryLookUpEdit, xaeJobCategory, AddressOf LoadCategories, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Categories.", ex)
        End Try

        Try
            Dim tlm As New Helper.ActiveRecord.LookupMaintenance(Of API.JobType)(JobTypeLookUpEdit, xaeJobType, AddressOf LoadTypes, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Job Types.", ex)
        End Try

        Try
            Dim cclm As New Helper.ActiveRecord.LookupMaintenance(Of API.CostCentre)(CostCentreLookUpEdit, xaeCostCentre, AddressOf LoadCostCentres, Me.Conversation)
            'Set a default value for now until required 
            CostCentreLookUpEdit.EditValue = API.CostCentre.FindFirst
            Me.Record.CostCentre = API.CostCentre.FindFirst
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Cost Centres.", ex)
        End Try

        Try
            Dim flm As New Helper.ActiveRecord.LookupMaintenance(Of API.Function)(FunctionLookUpEdit, xaeFunction, AddressOf LoadFunctions, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Functions.", ex)
        End Try

        Try
            Dim glm As New Helper.ActiveRecord.LookupMaintenance(Of API.Generation)(GenerationLookUpEdit, xaeGeneration, AddressOf LoadGenerations, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Generations.", ex)
        End Try

        Try
            Dim dlm As New Helper.ActiveRecord.LookupMaintenance(Of API.Drawing)(DrawingLookUpEdit, xaeDrawing, AddressOf LoadDrawings, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Drawings.", ex)
        End Try

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetType)(AssetType1LookUpEdit, AddressOf LoadAssetType, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Type.", ex)
        End Try

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetType)(AssetTypeLookUpEdit2, AddressOf LoadAssetType, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Type.", ex)
        End Try

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetType)(AssetTypeLookUpEdit3, AddressOf LoadAssetType, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Type.", ex)
        End Try

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetType)(AssetTypeLookUpEdit4, AddressOf LoadAssetType, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Type.", ex)
        End Try

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.AssetType)(AssetTypeLookUpEdit5, AddressOf LoadAssetType, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Asset Type.", ex)
        End Try

        Try
            Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(Equipment1Lookup, xaeAssets, AddressOf LoadAssetFromAssetClass1, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
        End Try

        Try
            Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit2, xaeAssets, AddressOf LoadAssetFromAssetClass2, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
        End Try

        Try
            Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit3, xaeAssets, AddressOf LoadAssetFromAssetClass3, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
        End Try

        Try
            Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit4, xaeAssets, AddressOf LoadAssetFromAssetClass4, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
        End Try

        Try
            Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit5, xaeAssets, AddressOf LoadAssetFromAssetClass5, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
        End Try

        Try
            SetDefaultData()
        Catch ex As Exception
            Setup.Log.logError("Error setting default data on job.", ex)
        End Try

        Try
            SetNumbering()
        Catch ex As Exception
            Setup.Log.logError("Error setting numbering on job.", ex)
        End Try

        If Equipment1Lookup.EditValue IsNot Nothing AndAlso IsDBNull(Equipment1Lookup.EditValue) = False Then
            UpdateAsset1ValuesOnLoad()
        End If

        'Set JobStart Date today
        If Me.Record.ID IsNot Nothing AndAlso Me.Record.ID = 0 Then
            Me.Record.InicioViagem = Today.Date
            Me.Record.StartDate = Today.Date
            'StartDate11.EditValue = Today.Date

        End If

        If Me.Record.JobCardID IsNot Nothing And Me.Record.ID > 0 Then
            If Me.Record.JobCardID > 0 Then
                JobDateDateEdit.Properties.ReadOnly = True
            End If
        End If

        Try
            If Me.Record.Eq1TotalUsage <> 0 Or Me.Record.Eq2TotalUsage <> 0 Or Me.Record.Eq3TotalUsage <> 0 Or Me.Record.Eq4TotalUsage <> 0 Or Me.Record.Eq5TotalUsage <> 0 Then
                AssetClassLookUpEdit.Properties.ReadOnly = True
                Equipment1Lookup.Properties.ReadOnly = True
                EquipmentLookUpEdit2.Properties.ReadOnly = True
                EquipmentLookUpEdit3.Properties.ReadOnly = True
                EquipmentLookUpEdit4.Properties.ReadOnly = True
                EquipmentLookUpEdit5.Properties.ReadOnly = True

                AssetType1LookUpEdit.Properties.ReadOnly = True
                AssetTypeLookUpEdit2.Properties.ReadOnly = True
                AssetTypeLookUpEdit3.Properties.ReadOnly = True
                AssetTypeLookUpEdit4.Properties.ReadOnly = True
                AssetTypeLookUpEdit5.Properties.ReadOnly = True

                AssetOperatorLookUpEdit1.Properties.ReadOnly = True
                AssetOperatorLookUpEdit2.Properties.ReadOnly = True
                AssetOperatorLookUpEdit3.Properties.ReadOnly = True
                AssetOperatorLookUpEdit4.Properties.ReadOnly = True
                AssetOperatorLookUpEdit5.Properties.ReadOnly = True

            End If
        Catch ex As Exception

        End Try

        Loaded = True

    End Sub

    Private Function LoadAssetClass() As IEnumerable(Of API.AssetClass)
        Return API.AssetClass.FindAll
    End Function

    Private Function LoadAssetType() As IEnumerable(Of API.AssetType)
        Return API.AssetType.FindAll
    End Function


    Private Sub SetDefaultData()

        Select Case Me.Record.State
            Case API.JobState.Active
                If IIf(API.Context.Defaults.IsJobNumberAutoGenerated.HasValue, API.Context.Defaults.IsJobNumberAutoGenerated, False) Then
                    QuoteNumberTextEdit.Properties.ReadOnly = True
                    JobNumberTextEdit.Properties.ReadOnly = True
                Else
                    JobNumberTextEdit.Properties.ReadOnly = False
                    QuoteNumberTextEdit.Properties.ReadOnly = True
                End If
            Case API.JobState.Quote
                If IIf(API.Context.Defaults.IsQuoteNumberAutoGenerated.HasValue, API.Context.Defaults.IsQuoteNumberAutoGenerated, False) Then
                    QuoteNumberTextEdit.Properties.ReadOnly = True
                    JobNumberTextEdit.Properties.ReadOnly = True
                Else
                    JobNumberTextEdit.Properties.ReadOnly = True
                    QuoteNumberTextEdit.Properties.ReadOnly = False
                End If
        End Select
        If Pastel.Evolution.JobCard.FindByCode(JobNumberTextEdit.Text) > 0 Then
            ' Freddie, 14/07/17
            Dim evolutionjob = New Pastel.Evolution.JobCard(JobNumberTextEdit.Text)
            'check if any  line  for job is invoiced 
            If Me.Record.IsERPJobInvoiced = True OrElse Not evolutionjob.Active Then
                'set Customer field to read only
                CustomerLookUpEdit.Properties.ReadOnly = True
                AccountNameTextEdit.Properties.ReadOnly = True
            End If
            If evolutionjob.Status <> Pastel.Evolution.JobCard.JobStatus.Active Then
                JobDataLayoutControl.Enabled = False
            End If
        End If
    End Sub

    Private Sub SetNumbering()
        If Me.Record.ID = 0 Then

            Select Case Me.Record.State
                Case API.JobState.Active
                    If Loaded = False Then
                        Me.Record.JobDate = Today.Date
                    End If
                    Me.Record.JobAgentID = Setup.Agent.ID
                    If IIf(API.Context.Defaults.IsJobNumberAutoGenerated.HasValue, API.Context.Defaults.IsJobNumberAutoGenerated, False) Then
                        Me.Record.JobNumber = API.Defaults.Defaults.GetNextJobNumber(Me.Record) + " *"
                    End If
                Case API.JobState.Quote
                    Me.Record.QuoteDate = Today.Date
                    Me.Record.QuoteAgentID = Setup.Agent.ID
                    If IIf(API.Context.Defaults.IsQuoteNumberAutoGenerated.HasValue, API.Context.Defaults.IsQuoteNumberAutoGenerated, False) Then
                        Me.Record.QuoteNumber = API.Defaults.Defaults.GetNextQuoteNumber(Me.Record) + " *"
                    End If
                Case Else
                    Throw New Exception(String.Format("New Job cannot have state of {0}.", Me.Record.State))
            End Select
        Else
            QuoteNumberTextEdit.Properties.ReadOnly = True
            JobNumberTextEdit.Properties.ReadOnly = True
        End If
    End Sub

    Protected Overrides Sub SetCLH()

        'Setting up user def fields
        'If userFieldsLoaded = False Then
        '    Try
        '        AddAdditionalEnquiryFields()
        '    Catch ex As Exception
        '        UniSource.Logging.Log.Log.logError("Error creating user-defined enquiry fields.", ex)
        '    End Try
        'End If
        'Try
        '    RebindAdditionalEnquiryFields()
        'Catch ex As Exception
        '    UniSource.Logging.Log.Log.logError("Error binding user-defined enquiry fields.", ex)
        'End Try
        userFieldsLoaded = True

        ' user fields end

        '    MyBase.SetCLH()
        '    CLH.Components.Add(JobDataLayoutControl)
        ' CLH.Components.Add(AdditionalFieldsLayoutControlLayoutControl)
        ' CLH.AddSaveEvent(AdditionalFieldsLayoutControlLayoutControl, "HideCustomization")

    End Sub

    'Public Sub AddAdditionalEnquiryFields()
    '    If AdditionalFieldsLayoutControlLayoutControl IsNot Nothing Then
    '        For Each udef As Helper.ActiveRecord.Evolution.UserDefinedField In UniSource.Helper.ActiveRecord.Evolution.UserDefinedField.FindAllByType(GetType(API.Job))
    '            AdditionalFieldsLayoutControlLayoutControl.AddItem(udef.GetLayoutControlItem)
    '        Next
    '    End If
    'End Sub

    'Public Sub RebindAdditionalEnquiryFields()
    '    If AdditionalFieldsLayoutControlLayoutControl IsNot Nothing Then
    '        For Each lci As DevExpress.XtraLayout.BaseLayoutItem In AdditionalFieldsLayoutControlLayoutControl.Items
    '            Dim bc As UniSource.Helper.ActiveRecord.UserDefinedFieldBindingContext = TryCast(lci.Tag, UniSource.Helper.ActiveRecord.UserDefinedFieldBindingContext)
    '            If bc IsNot Nothing Then
    '                bc.ReBind(Me.BindingSource.Current)
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles BindingSource.CurrentChanged
    '    Try
    '        RebindAdditionalEnquiryFields()
    '    Catch ex As Exception
    '        UniSource.Logging.Log.Log.logError("Error binding user-defined enquiry fields.", ex)
    '    End Try
    'End Sub

    Private Function LoadClients() As IEnumerable(Of Helper.ActiveRecord.Evolution.Client)
        'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
        Return UniSource.Helper.ActiveRecord.Evolution.Client.FindAll
        'End Using
    End Function

    Private Function LoadPeople() As IEnumerable(Of API.Employee)
        Return API.Employee.FindAll
    End Function

    Private Function LoadWorkCentreCategories() As IEnumerable(Of API.WorkCentreCategory)
        Return API.WorkCentreCategory.FindAll
    End Function

    Private Function LoadCategories() As IEnumerable(Of API.JobCategory)
        'Dim z As API.JobCategory = New API.JobCategory
        'Return z.invokemethod(z.Assembly.CurrentAssemblyName, "JobCategory", "FindAll", Nothing)
        Return API.JobCategory.FindAll

    End Function

    Private Function LoadTypes() As IEnumerable(Of API.JobType)
        Return API.JobType.FindAll
    End Function

    Private Function LoadAsset() As IEnumerable(Of API.Asset)
        If Me.Record.ID Is Nothing Or Me.Record.ID = 0 Then
            Return API.Asset.FindAll
        Else
            If Me.Record.AssetClass IsNot Nothing And Me.Record.AssetClass > 0 Then

                Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()

                If Me.Record.ClientAsset Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", False))
                Else
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetClass", Me.Record.AssetClass))
                    crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", True))
                End If

                Return API.Asset.FindAll(crit)

            End If
        End If

    End Function

    Private Function LoadServiceType() As IEnumerable(Of API.ServiceType)
        Return API.ServiceType.FindAll
    End Function


    Private Function LoadServiceTemplate() As IEnumerable(Of API.ServiceTemplate)
        Return API.ServiceTemplate.FindAll
    End Function


    Private Function LoadCostCentres() As IEnumerable(Of API.CostCentre)
        Return API.CostCentre.FindAll
    End Function

    Private Function LoadMakes() As IEnumerable(Of API.Make)
        Return API.Make.FindAll
    End Function

    Private Function LoadTemplates() As IEnumerable(Of API.JobTemplate)
        Dim wcc As API.WorkCentreCategory = TryCast(WorkCenterCATLookUpEdit1.EditValue, API.WorkCentreCategory)
        If wcc IsNot Nothing Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobTemplate)()
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("WorkCentreCategory", wcc), NHibernate.Criterion.Expression.IsNull("WorkCentreCategory")))
            Return API.JobTemplate.FindAll(crit)
        Else
            Return API.JobTemplate.FindAll
        End If
    End Function

    'Private Function LoadModels() As IEnumerable(Of API.Model)
    '    Dim mk As API.Make = TryCast(MakeLookUpEdit.EditValue, API.Make)
    '    If mk IsNot Nothing Then
    '        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Model)()
    '        crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Make", mk), NHibernate.Criterion.Expression.IsNull("Make")))
    '        Return API.Model.FindAll(crit)
    '    Else
    '        Return API.Model.FindAll
    '    End If
    'End Function

    Private Function LoadFunctions() As IEnumerable(Of API.Function)
        'Dim mk As API.Make = TryCast(MakeLookUpEdit.EditValue, API.Make)
        'If mk IsNot Nothing Then
        '    Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Function)()
        '    crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Make", mk), NHibernate.Criterion.Expression.IsNull("Make")))
        '    Return API.Function.FindAll(crit)
        'Else
        Return API.Function.FindAll
        ' End If
    End Function

    Private Function LoadDrawings() As IEnumerable(Of API.Drawing)
        Return API.Drawing.FindAll
    End Function

    Private Function LoadGenerations() As IEnumerable(Of API.Generation)
        Return API.Generation.FindAll
    End Function

    Private Sub TemplateLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TemplateLookUpEdit.EditValueChanged
        If IIf(IsDBNull(TemplateLookUpEdit.EditValue), Nothing, TemplateLookUpEdit.EditValue) IsNot Nothing Then
            Me.Record.JobTemplate = TemplateLookUpEdit.EditValue
            If Me.Record.JobTemplate.CostCentre IsNot Nothing AndAlso Me.Record.CostCentre Is Nothing AndAlso IIf(IsDBNull(CostCentreLookUpEdit.EditValue), Nothing, CostCentreLookUpEdit.EditValue) Is Nothing Then
                CostCentreLookUpEdit.EditValue = Me.Record.JobTemplate.CostCentre
            End If
            If Me.Record.JobTemplate.Drawing IsNot Nothing AndAlso Me.Record.Drawing Is Nothing AndAlso IIf(IsDBNull(DrawingLookUpEdit.EditValue), Nothing, DrawingLookUpEdit.EditValue) Is Nothing Then
                DrawingLookUpEdit.EditValue = Me.Record.JobTemplate.Drawing
            End If
            If Me.Record.JobTemplate.Function IsNot Nothing AndAlso Me.Record.Function Is Nothing AndAlso IIf(IsDBNull(FunctionLookUpEdit.EditValue), Nothing, FunctionLookUpEdit.EditValue) Is Nothing Then
                FunctionLookUpEdit.EditValue = Me.Record.JobTemplate.Function
            End If
            If Me.Record.JobTemplate.Generation IsNot Nothing AndAlso Me.Record.Generation Is Nothing AndAlso IIf(IsDBNull(GenerationLookUpEdit.EditValue), Nothing, GenerationLookUpEdit.EditValue) Is Nothing Then
                GenerationLookUpEdit.EditValue = Me.Record.JobTemplate.Generation
            End If
            If Me.Record.JobTemplate.JobType IsNot Nothing AndAlso Me.Record.JobType Is Nothing AndAlso IIf(IsDBNull(JobTypeLookUpEdit.EditValue), Nothing, JobTypeLookUpEdit.EditValue) Is Nothing Then
                JobTypeLookUpEdit.EditValue = Me.Record.JobTemplate.JobType
            End If
            'If Me.Record.JobTemplate.Make IsNot Nothing AndAlso Me.Record.Make Is Nothing AndAlso IIf(IsDBNull(MakeLookUpEdit.EditValue), Nothing, MakeLookUpEdit.EditValue) Is Nothing Then
            '    MakeLookUpEdit.EditValue = Me.Record.JobTemplate.Make
            'End If
            'If Me.Record.JobTemplate.Model IsNot Nothing AndAlso Me.Record.Model Is Nothing AndAlso IIf(IsDBNull(ModelLookUpEdit.EditValue), Nothing, ModelLookUpEdit.EditValue) Is Nothing Then
            '    ModelLookUpEdit.EditValue = Me.Record.JobTemplate.Model
            'End If
        End If
    End Sub

    'Private Sub MakeLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs)
    '    Dim mk As API.Make = TryCast(MakeLookUpEdit.EditValue, API.Make)
    '    If mk IsNot Nothing Then
    '        ModelLookUpEdit.Enabled = True
    '        FunctionLookUpEdit.Enabled = True
    '        Try
    '            ModelBindingSource.DataSource = LoadModels()
    '        Catch ex As Exception
    '            Setup.Log.logError("Error loading Models.", ex)
    '        End Try
    '        Try
    '            FunctionBindingSource.DataSource = LoadFunctions()
    '        Catch ex As Exception
    '            Setup.Log.logError("Error loading Functions.", ex)
    '        End Try

    '    Else
    '        ModelLookUpEdit.Enabled = False
    '        FunctionLookUpEdit.Enabled = False
    '        ModelBindingSource.DataSource = Nothing
    '        FunctionBindingSource.DataSource = Nothing
    '    End If
    'End Sub

    Protected Overrides Sub ValidationError(ByVal errors As Dictionary(Of Reflection.PropertyInfo, ArrayList))
        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "JobNumber" Then
                JobNumberTextEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "QuoteNumber" Then
                QuoteNumberTextEdit.ErrorText = errors(prop)(0)
                SetNumbering()
            End If
            If prop.Name = "Customer" Then
                CustomerLookUpEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "JobType" Then
                JobTypeLookUpEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "JobStage" Then
                JobStageTextEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "CostCentre" Then
                CostCentreLookUpEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "JobCategory" Then
                JobCategoryLookUpEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "PricelistID" Then
                PricelistLookUpEdit.ErrorText = errors(prop)(0)
            End If
        Next
        MyBase.ValidationError(errors)
    End Sub

    Private Sub CostCentreLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CostCentreLookUpEdit.EditValueChanged
        Dim cc As API.CostCentre = TryCast(CostCentreLookUpEdit.EditValue, API.CostCentre)
        If cc IsNot Nothing Then
            If cc <> Me.Record.CostCentre Then
                Me.Record.CostCentre = cc
                Try
                    SetNumbering()
                Catch ex As Exception
                    Setup.Log.logError("Error setting numbering on job.", ex)
                End Try
            End If
        End If
    End Sub

    Private Sub JobTypeLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles JobTypeLookUpEdit.EditValueChanged
        Dim jt As API.JobType = TryCast(JobTypeLookUpEdit.EditValue, API.JobType)
        If jt IsNot Nothing Then
            If jt <> Me.Record.JobType Then
                Me.Record.JobType = jt
                Try
                    SetNumbering()
                Catch ex As Exception
                    Setup.Log.logError("Error setting numbering on job.", ex)
                End Try
            End If
        End If
    End Sub

    Private Sub JobCategoryLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobCategoryLookUpEdit.EditValueChanged
        Dim jc As API.JobCategory = TryCast(JobCategoryLookUpEdit.EditValue, API.JobCategory)
        If jc IsNot Nothing Then
            If jc <> Me.Record.JobCategory Then
                Me.Record.JobCategory = jc
                Try
                    SetNumbering()
                Catch ex As Exception
                    Setup.Log.logError("Error setting numbering on job.", ex)
                End Try
            End If
        End If
    End Sub

    Private Sub WorkCenterCATLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkCenterCATLookUpEdit1.EditValueChanged
        Try


            If IIf(IsDBNull(WorkCenterCATLookUpEdit1.EditValue), Nothing, WorkCenterCATLookUpEdit1.EditValue) IsNot Nothing AndAlso IIf(IsDBNull(TemplateLookUpEdit.EditValue), Nothing, TemplateLookUpEdit.EditValue) IsNot Nothing Then
                If Me.Record.JobTemplate.WorkCentreCategory IsNot Nothing AndAlso Me.Record.JobTemplate.WorkCentreCategory <> WorkCenterCATLookUpEdit1.EditValue Then
                    'MessageBox.Show()
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Template {0} not part of Work Centre Category {1}. Template cleared.", TemplateLookUpEdit.EditValue, WorkCenterCATLookUpEdit1.EditValue))
                    TemplateLookUpEdit.EditValue = Nothing
                End If
            End If
            If IIf(IsDBNull(WorkCenterCATLookUpEdit1.EditValue), Nothing, WorkCenterCATLookUpEdit1.EditValue) IsNot Nothing Then
                If workCentreCategory Is Nothing OrElse Not workCentreCategory.ID.Equals(CType(WorkCenterCATLookUpEdit1.EditValue, API.WorkCentreCategory).ID) Then
                    workCentreCategory = CType(WorkCenterCATLookUpEdit1.EditValue, API.WorkCentreCategory)
                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                        JobTemplateBindingSource.DataSource = LoadTemplates()
                    End Using
                End If
            End If

        Catch ex As Exception

        End Try




    End Sub

    Protected Overrides Sub SaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btSave.Click

        Select Case Me.Record.State
            Case API.JobState.Active
                If IIf(API.Context.Defaults.IsJobNumberAutoGenerated.HasValue, API.Context.Defaults.IsJobNumberAutoGenerated, False) Then
                    'JobNumberTextEdit.ErrorText = ""
                Else
                    If (IIf(IsDBNull(JobNumberTextEdit.EditValue), "", IIf(IsNothing(JobNumberTextEdit.EditValue), "", JobNumberTextEdit.EditValue)).ToString().Trim = "") Then
                        JobNumberTextEdit.ErrorText = "Must enter a Job number"
                        Exit Sub
                    End If
                End If
                If Me.Record.ID Is Nothing OrElse Me.Record.ID <= 0 Then
                    Dim message As String = Me.Record.ValidateAsset
                    If message <> "" Then
                        Equipment1Lookup.ErrorText = "ASSET ALREADY IN USE"
                        UniSource.Helper.GUI.Dialog.OKDialog(message, "ASSET ALREADY IN USE")
                        Exit Sub
                    End If
                End If
            Case API.JobState.Quote
                If IIf(API.Context.Defaults.IsQuoteNumberAutoGenerated.HasValue, API.Context.Defaults.IsQuoteNumberAutoGenerated, False) Then
                    'QuoteNumberTextEdit.ErrorText = ""
                Else
                    If (IIf(IsDBNull(QuoteNumberTextEdit.EditValue), "", IIf(IsNothing(QuoteNumberTextEdit.EditValue), "", QuoteNumberTextEdit.EditValue)).ToString().Trim = "") Then
                        QuoteNumberTextEdit.ErrorText = "Must enter a Quote number"
                        Exit Sub
                    End If
                End If
        End Select
        Try
            'it is not passing the property.
            SaveRecord()
            'Me.Record.UpdatesJobHeadeDetailOnERP()
        Catch ex As Exception
            Logging.Log.Log.logError("Error saving record.", ex)
        End Try
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
    Private Function SavejobChangesToEvolution()
        Dim line As Pastel.Evolution.JobDetail
        'check if job exists in Evolution
        If Pastel.Evolution.JobCard.FindByCode(JobNumberTextEdit.Text) > 0 Then
            Dim evolutionjob = New Pastel.Evolution.JobCard(JobNumberTextEdit.Text)
            Dim previouscustomer = New Pastel.Evolution.Customer(evolutionjob.Account.Code)
            evolutionjob.Account = New Pastel.Evolution.Customer(Me.Record.Customer.Account)
            If evolutionjob.Account.DefaultTaxRate.Code = previouscustomer.DefaultTaxRate.Code Then

                For Each lin As Pastel.Evolution.JobDetail In evolutionjob.Detail
                    line = From bi As API.JobLine In Me.Record.JobLines
                                               Where bi.InventoryItemID = lin.InventoryItemID
                    lin.Description = line.Description
                    MessageBox.Show(line.Description)
                Next
            End If
            evolutionjob.Description = Me.Record.Description1
            evolutionjob.ExtOrderNo = Me.Record.OrderNumber
            ' evolutionjob.DeliverTo = evolutionjob.Account.PhysicalAddress

            evolutionjob.SalesRepresentative = Me.Record.Representative
            evolutionjob.UserFields("ucJCJobProCategory") = Me.Record.WorkCentreCategory.Code
            evolutionjob.UserFields("ucJCJobProCostCentre") = Me.Record.CostCentre.Code
            evolutionjob.Save()
            'MessageBox.Show("great")
            'check if a line exist for the job where  line is completed



        End If
    End Function

    Protected Overrides Sub DestroyHandle()
        'DataBindings.Clear()
        JobTypeBindingSource.Clear()
        SalesRepresentativeBindingSource.Clear()
        AgentBindingSource.Clear()
        DrawingBindingSource.Clear()
        MakeBindingSource.Clear()
        ModelBindingSource.Clear()
        FunctionBindingSource.Clear()
        GenerationBindingSource.Clear()
        ClientBindingSource.Clear()
        JobCategoryBindingSource.Clear()
        PriceListBindingSource.Clear()
        WorkCentreCategoryBindingSource.Clear()
        JobTemplateBindingSource.Clear()
        CostCentreBindingSource.Clear()
        PeopleBindingSource.Clear()
        ServiceTemplateBindingSource.Clear()
        ServiceTypeBindingSource.Clear()
        AssetBindingSource.Clear()
        Asset2BindingSource.Clear()
        Asset3BindingSource.Clear()
        Asset4BindingSource.Clear()
        Asset5BindingSource.Clear()


        JobTypeBindingSource.Dispose()
        SalesRepresentativeBindingSource.Dispose()
        AgentBindingSource.Dispose()
        DrawingBindingSource.Dispose()
        MakeBindingSource.Dispose()
        ModelBindingSource.Dispose()
        FunctionBindingSource.Dispose()
        GenerationBindingSource.Dispose()
        ClientBindingSource.Dispose()
        JobCategoryBindingSource.Dispose()
        CostCentreBindingSource.Dispose()
        PriceListBindingSource.Dispose()
        WorkCentreCategoryBindingSource.Dispose()
        JobTemplateBindingSource.Dispose()
        PeopleBindingSource.Dispose()
        ServiceTemplateBindingSource.Dispose()
        ServiceTypeBindingSource.Dispose()

        AssetBindingSource.Dispose()
        Asset2BindingSource.Dispose()
        Asset3BindingSource.Dispose()
        Asset4BindingSource.Dispose()
        Asset5BindingSource.Dispose()

        MyBase.DestroyHandle()
        Me.Dispose()
        'TODO: Find Proper why of GC
        'System.GC.GetTotalMemory(True)
    End Sub

    Private Sub UpdateEquip1Values(ByVal AssetID As Integer)


        Dim MyAppCon As SqlConnection = New SqlConnection(ShopFloor.API.ActiveConnection.Company.ConnectionString)
        Try
            If AssetID = 0 Then
                AssetID = Val(Equipment1Lookup.EditValue)
            End If
            MyAppCon.Open()

            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand

            Dim query1 As String = "Select Serial_No from [dbo].[ussSFAsset] where Id =" & AssetID
            'cmd = New SqlCommand(query1, MyAppCon)
            'txtSerialNumber.EditValue = cmd.ExecuteScalar


            query1 = "select code from ussSFMake where id in (select Make_id FROM [ussSFAsset] where Id=" & AssetID & ")"
            cmd = New SqlCommand(query1, MyAppCon)
            txtMake.EditValue = cmd.ExecuteScalar


            query1 = "select code from ussSFModel where MakeID in ( select id from ussSFMake where id in (select Make_id FROM [ussSFAsset] where Id=" & AssetID & "))"
            cmd = New SqlCommand(query1, MyAppCon)
            txtModel.EditValue = cmd.ExecuteScalar


            query1 = "Select case when TotalUsage is null then 0 else TotalUsage end from [ussSFAsset] where id =" & AssetID
            cmd = New SqlCommand(query1, MyAppCon)
            TotalHrs = cmd.ExecuteScalar
            txtAsset1Usage.EditValue = TotalHrs

            MyAppCon.Close()

        Catch ex As Exception
            'MsgBox(ex.Message)
            'MyAppCon.Close()
        End Try
        MyAppCon.Close()
    End Sub

    Private Sub UpdateEquipValues()
        Dim MyAppCon As SqlConnection = New SqlConnection(ShopFloor.API.ActiveConnection.Company.ConnectionString)
        Try
            MyAppCon.Open()

            Dim cmd As New SqlCommand
            'Update all assets as Active writer will refresh

            If Equipment1Lookup.EditValue IsNot Nothing AndAlso IsDBNull(Equipment1Lookup.EditValue) = False Then
                Dim query1 As String = "Select case when TotalUsage is null then 0 else TotalUsage end from [ussSFAsset] where id =" & Equipment1Lookup.EditValue
                cmd = New SqlCommand(query1, MyAppCon)
                Dim TotalUsage As Double = cmd.ExecuteScalar
                txtAsset1Usage.EditValue = TotalUsage
                Me.Record.Eq1UsageBefore = TotalUsage

                query1 = "Select Serial_No from [dbo].[ussSFAsset] where Id =" & Equipment1Lookup.EditValue
                cmd = New SqlCommand(query1, MyAppCon)
                txtSerialNumber.EditValue = cmd.ExecuteScalar


                query1 = "select code from ussSFMake where id in (select Make_id FROM [ussSFAsset] where Id=" & Equipment1Lookup.EditValue & ")"
                cmd = New SqlCommand(query1, MyAppCon)
                txtMake.EditValue = cmd.ExecuteScalar


                query1 = "select code from ussSFModel where MakeID in ( select id from ussSFMake where id in (select Make_id FROM [ussSFAsset] where Id=" & Equipment1Lookup.EditValue & "))"
                cmd = New SqlCommand(query1, MyAppCon)
                txtModel.EditValue = cmd.ExecuteScalar

            End If


            If EquipmentLookUpEdit2.EditValue IsNot Nothing AndAlso IsDBNull(EquipmentLookUpEdit2.EditValue) = False Then
                Dim query1 As String = "Select case when TotalUsage is null then 0 else TotalUsage end from [ussSFAsset] where id =" & EquipmentLookUpEdit2.EditValue
                cmd = New SqlCommand(query1, MyAppCon)
                Dim TotalUsage As Double = cmd.ExecuteScalar
                txtAsset2Usage.EditValue = TotalUsage
                Me.Record.Eq2UsageBefore = TotalUsage
            End If

            If EquipmentLookUpEdit3.EditValue IsNot Nothing AndAlso IsDBNull(EquipmentLookUpEdit3.EditValue) = False Then
                Dim query1 As String = "Select case when TotalUsage is null then 0 else TotalUsage end from [ussSFAsset] where id =" & EquipmentLookUpEdit3.EditValue
                cmd = New SqlCommand(query1, MyAppCon)
                Dim TotalUsage As Double = cmd.ExecuteScalar
                txtAsset3Usage.EditValue = TotalUsage
                Me.Record.Eq3UsageBefore = TotalUsage
            End If

            If EquipmentLookUpEdit4.EditValue IsNot Nothing AndAlso IsDBNull(EquipmentLookUpEdit4.EditValue) = False Then
                Dim query1 As String = "Select case when TotalUsage is null then 0 else TotalUsage end from [ussSFAsset] where id =" & EquipmentLookUpEdit4.EditValue
                cmd = New SqlCommand(query1, MyAppCon)
                Dim TotalUsage As Double = cmd.ExecuteScalar
                txtAsset4Usage.EditValue = TotalUsage
                Me.Record.Eq4UsageBefore = TotalUsage
            End If

            If EquipmentLookUpEdit5.EditValue IsNot Nothing AndAlso IsDBNull(EquipmentLookUpEdit5.EditValue) = False Then
                Dim query1 As String = "Select case when TotalUsage is null then 0 else TotalUsage end from [ussSFAsset] where id =" & EquipmentLookUpEdit5.EditValue
                cmd = New SqlCommand(query1, MyAppCon)
                Dim TotalUsage As Double = cmd.ExecuteScalar
                txtAsset5Usage.EditValue = TotalUsage
                Me.Record.Eq5UsageBefore = TotalUsage
            End If

            'If EquipmentLookUpEdit2.EditValue IsNot Nothing AndAlso IsDBNull(EquipmentLookUpEdit2.EditValue) = False Then
            '    Dim query1 As String = "Select case when TotalUsage is null then 0 else TotalUsage end from [ussSFAsset] where id =" & AssetID
            '    cmd = New SqlCommand(query1, MyAppCon)
            '    Dim TotalUsage As Double = cmd.ExecuteScalar
            '    txtAsset2Usage.EditValue = TotalUsage
            'End If

            'If EquipmentLookUpEdit2.EditValue IsNot Nothing AndAlso IsDBNull(EquipmentLookUpEdit2.EditValue) = False Then
            '    Dim query1 As String = "Select case when TotalUsage is null then 0 else TotalUsage end from [ussSFAsset] where id =" & AssetID
            '    cmd = New SqlCommand(query1, MyAppCon)
            '    Dim TotalUsage As Double = cmd.ExecuteScalar
            '    txtAsset2Usage.EditValue = TotalUsage
            'End If




            'Select Case EquipmentNumber
            '    Case 2
            '        txtAsset2Usage.EditValue = TotalUsage
            '        '  Me.Record.Eq2UsageBefore = TotalUsage
            '    Case 3
            '        txtAsset3Usage.EditValue = TotalUsage
            '        ' Me.Record.Eq3UsageBefore = TotalUsage
            '    Case 4
            '        txtAsset4Usage.EditValue = TotalUsage
            '        ' Me.Record.Eq4UsageBefore = TotalUsage
            '    Case 5
            '        txtAsset5Usage.EditValue = TotalUsage
            '        ' Me.Record.Eq5UsageBefore = TotalUsage
            'End Select

            MyAppCon.Close()

        Catch ex As Exception
            'MsgBox(ex.Message)
            'MyAppCon.Close()
        End Try
        MyAppCon.Close()
    End Sub

    Private Sub JobCategoryLookUpEdit_EditValueChanged_1(sender As System.Object, e As System.EventArgs) Handles JobCategoryLookUpEdit.EditValueChanged



        'Try

        '    MyAppCon.Open()

        '    Dim strSQL As String = "SELECT id,Code,Description FROM ussSFWorkCentreCategory Where Description='" & JobCategoryLookUpEdit.Text & "'"
        '    Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, MyAppCon)
        '    Dim ds As New DataSet
        '    da.Fill(ds, "ussSFWorkCentreCategory")

        '    With Me.WorkCenterCATLookUpEdit1
        '        .Properties.DataSource = ds.Tables("ussSFWorkCentreCategory")
        '        .Properties.DisplayMember = "Description"
        '        .Properties.ValueMember = "ID"

        '    End With


        '    MyAppCon.Close()

        'Catch ex As Exception

        'End Try

        'MyAppCon.Close()



    End Sub

    Private Sub UpdateAsset1ValuesOnLoad()
        Dim MyAppCon As SqlConnection = New SqlConnection(ShopFloor.API.ActiveConnection.Company.ConnectionString)
        Try
            MyAppCon.Open()

            Dim cmd As New SqlCommand
            'Update all assets as Active writer will refresh
            If Equipment1Lookup.EditValue IsNot Nothing AndAlso IsDBNull(Equipment1Lookup.EditValue) = False Then
                Dim query1 As String = "Select Serial_No from [dbo].[ussSFAsset] where Id =" & Equipment1Lookup.EditValue
                cmd = New SqlCommand(query1, MyAppCon)
                txtSerialNumber.EditValue = cmd.ExecuteScalar

                query1 = "select code from ussSFMake where id in (select Make_id FROM [ussSFAsset] where Id=" & Equipment1Lookup.EditValue & ")"
                cmd = New SqlCommand(query1, MyAppCon)
                txtMake.EditValue = cmd.ExecuteScalar

                query1 = "select code from ussSFModel where MakeID in ( select id from ussSFMake where id in (select Make_id FROM [ussSFAsset] where Id=" & Equipment1Lookup.EditValue & "))"
                cmd = New SqlCommand(query1, MyAppCon)
                txtModel.EditValue = cmd.ExecuteScalar

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub MileageTextEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs)
        TotalMakchinHrsTextEdit5.Text = TotalHrs
        KMAutorizadoTextEdit.Text = Mileage
        txtAsset1Usage.Text = Mileage
    End Sub

    Private Sub TotalMakchinHrsTextEdit5_EditValueChanged(sender As System.Object, e As System.EventArgs)
        TotalMakchinHrsTextEdit5.Text = TotalHrs
        KMAutorizadoTextEdit.Text = Mileage
        txtAsset1Usage.Text = Mileage

    End Sub


    Private Sub WorkCenterCATLookUpEdit1_EditValueChanged_1(sender As System.Object, e As System.EventArgs)

    End Sub

    'Private Sub CheckEdit1_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    If CheckEdit1.Checked Then

    '    End If
    'End Sub

    'Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click
    '    If CheckEdit1.Checked Then
    '        ' when checked - open new window to allow adding of a new client make, model and asset
    '        ' once added reload the asset makes and models for all those only related to clients and select the required as per previous selection
    '        ' if client clicks cancel then close the box without saving anything and simply filter to all values where intenal =0

    '        Dim form As New xaeClientAsset
    '        form.Show()



    '    End If
    '    MakeLookUpEdit.EditValue = 1

    'End Sub

    Private Sub btnLoadClientAsset_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadClientAsset.Click
        ' when checked - open new window to allow adding of a new client make, model and asset
        ' once added reload the asset makes and models for all those only related to clients and select the required as per previous selection
        ' if client clicks cancel then close the box without saving anything and simply filter to all values where intenal =0

        Dim form As New xaeClientAsset
        Using form

            If form.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' Get all the ID values
                ' Refresh all the Lookups involved
                Dim assetid As String = form.vAssetCode
                Dim makeid As String = form.vMake
                Dim modelid As String = form.vModel

                'Try
                '    Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(Equipment1Lookup, xaeAssets, AddressOf LoadClientAsset, Me.Conversation)
                'Catch ex As Exception
                '    Setup.Log.logError("Error setting lookup maintenance for Client Assets.", ex)
                'End Try

                Try
                    Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(Equipment1Lookup, xaeAssets, AddressOf LoadAssetFromAssetClass1, Me.Conversation)
                Catch ex As Exception
                    Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
                End Try

                Try
                    Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit2, xaeAssets, AddressOf LoadAssetFromAssetClass2, Me.Conversation)
                Catch ex As Exception
                    Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
                End Try

                Try
                    Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit3, xaeAssets, AddressOf LoadAssetFromAssetClass3, Me.Conversation)
                Catch ex As Exception
                    Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
                End Try

                Try
                    Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit4, xaeAssets, AddressOf LoadAssetFromAssetClass4, Me.Conversation)
                Catch ex As Exception
                    Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
                End Try

                Try
                    Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit5, xaeAssets, AddressOf LoadAssetFromAssetClass5, Me.Conversation)
                Catch ex As Exception
                    Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
                End Try

                '  Me.Record.EquipamentoNo1 = assetid
                '  UpdateEquip1Values(assetid)

            End If

        End Using
    End Sub

    Private Sub chkClientAsset_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkClientAsset.CheckedChanged
        If chkClientAsset.Checked Then
            btnLoadClientAsset.Enabled = True

            Try
                Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(Equipment1Lookup, xaeAssets, AddressOf LoadClientAsset, Me.Conversation)
            Catch ex As Exception
                Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
            End Try

        Else
            btnLoadClientAsset.Enabled = False

            Try
                Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(Equipment1Lookup, xaeAssets, AddressOf LoadInternalAsset, Me.Conversation)
            Catch ex As Exception
                Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
            End Try

        End If
    End Sub

    Private Function LoadClientAsset() As IEnumerable(Of API.Asset)
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()
        If AssetClassLookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetClassLookUpEdit.EditValue) = False Then
            crit.Add(NHibernate.Criterion.Expression.Eq("AssetClass", AssetClassLookUpEdit.EditValue))
        End If
        crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", False))

        Return API.Asset.FindAll(crit)

    End Function

    Private Function LoadInternalAsset() As IEnumerable(Of API.Asset)

        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()
        If AssetClassLookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetClassLookUpEdit.EditValue) = False Then
            crit.Add(NHibernate.Criterion.Expression.Eq("AssetClass", AssetClassLookUpEdit.EditValue))
        End If

        crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", True))

        Return API.Asset.FindAll(crit)

    End Function

    Private Function LoadAssetFromAssetClass() As IEnumerable(Of API.Asset)

        If AssetClassLookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetClassLookUpEdit.EditValue) = False Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()

            If chkClientAsset.Checked Then
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", False))
            Else
                crit.Add(NHibernate.Criterion.Expression.Eq("AssetClass", AssetClassLookUpEdit.EditValue))
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", True))

                If AssetType1LookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetType1LookUpEdit.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", AssetType1LookUpEdit.EditValue))
                End If

            End If

            Return API.Asset.FindAll(crit)

        End If

    End Function

    Private Function LoadAssetFromAssetClass1() As IEnumerable(Of API.Asset)

        If AssetClassLookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetClassLookUpEdit.EditValue) = False Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()

            If chkClientAsset.Checked Then
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", False))

                If AssetType1LookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetType1LookUpEdit.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", Convert.ToInt32(AssetType1LookUpEdit.EditValue)))
                End If

            Else
                crit.Add(NHibernate.Criterion.Expression.Eq("AssetClass", AssetClassLookUpEdit.EditValue))
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", True))

                If AssetType1LookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetType1LookUpEdit.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", Convert.ToInt32(AssetType1LookUpEdit.EditValue)))
                End If

            End If

            Return API.Asset.FindAll(crit)

        End If

    End Function

    Private Function LoadAssetFromAssetClass2() As IEnumerable(Of API.Asset)

        If AssetClassLookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetClassLookUpEdit.EditValue) = False Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()

            If chkClientAsset.Checked Then
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", False))

                If AssetTypeLookUpEdit2.EditValue IsNot Nothing And IsDBNull(AssetTypeLookUpEdit2.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", AssetTypeLookUpEdit2.EditValue))
                End If
            Else
                crit.Add(NHibernate.Criterion.Expression.Eq("AssetClass", AssetClassLookUpEdit.EditValue))
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", True))

                If AssetTypeLookUpEdit2.EditValue IsNot Nothing And IsDBNull(AssetTypeLookUpEdit2.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", AssetTypeLookUpEdit2.EditValue))
                End If
            End If

            Return API.Asset.FindAll(crit)

        End If

    End Function

    Private Function LoadAssetFromAssetClass3() As IEnumerable(Of API.Asset)

        If AssetClassLookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetClassLookUpEdit.EditValue) = False Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()

            If chkClientAsset.Checked Then
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", False))

                If AssetTypeLookUpEdit3.EditValue IsNot Nothing And IsDBNull(AssetTypeLookUpEdit3.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", AssetTypeLookUpEdit3.EditValue))
                End If

            Else
                crit.Add(NHibernate.Criterion.Expression.Eq("AssetClass", AssetClassLookUpEdit.EditValue))
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", True))

                If AssetTypeLookUpEdit3.EditValue IsNot Nothing And IsDBNull(AssetTypeLookUpEdit3.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", AssetTypeLookUpEdit3.EditValue))
                End If
            End If

            Return API.Asset.FindAll(crit)

        End If

    End Function

    Private Function LoadAssetFromAssetClass4() As IEnumerable(Of API.Asset)

        If AssetClassLookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetClassLookUpEdit.EditValue) = False Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()

            If chkClientAsset.Checked Then
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", False))

                If AssetTypeLookUpEdit4.EditValue IsNot Nothing And IsDBNull(AssetTypeLookUpEdit4.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", AssetTypeLookUpEdit4.EditValue))
                End If

            Else
                crit.Add(NHibernate.Criterion.Expression.Eq("AssetClass", AssetClassLookUpEdit.EditValue))
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", True))

                If AssetTypeLookUpEdit4.EditValue IsNot Nothing And IsDBNull(AssetTypeLookUpEdit4.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", AssetTypeLookUpEdit4.EditValue))
                End If
            End If

            Return API.Asset.FindAll(crit)
        End If

    End Function

    Private Function LoadAssetFromAssetClass5() As IEnumerable(Of API.Asset)

        If AssetClassLookUpEdit.EditValue IsNot Nothing And IsDBNull(AssetClassLookUpEdit.EditValue) = False Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()

            If chkClientAsset.Checked Then
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", False))

                If AssetTypeLookUpEdit5.EditValue IsNot Nothing And IsDBNull(AssetTypeLookUpEdit5.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", AssetTypeLookUpEdit5.EditValue))
                End If

            Else
                crit.Add(NHibernate.Criterion.Expression.Eq("AssetClass", AssetClassLookUpEdit.EditValue))
                crit.Add(NHibernate.Criterion.Expression.Eq("InternalAsset", True))

                If AssetTypeLookUpEdit5.EditValue IsNot Nothing And IsDBNull(AssetTypeLookUpEdit5.EditValue) = False Then
                    crit.Add(NHibernate.Criterion.Expression.Eq("AssetTypeID", AssetTypeLookUpEdit5.EditValue))
                End If
            End If

            Return API.Asset.FindAll(crit)
        End If

    End Function



    Private Sub AssetClassLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetClassLookUpEdit.EditValueChanged

        If Loaded = True Then
            Me.Record.AssetClass = AssetClassLookUpEdit.EditValue
            Equipment1Lookup.EditValue = Nothing
            EquipmentLookUpEdit2.EditValue = Nothing
            EquipmentLookUpEdit3.EditValue = Nothing
            EquipmentLookUpEdit4.EditValue = Nothing
            EquipmentLookUpEdit5.EditValue = Nothing

            AssetBindingSource.DataSource = Nothing
            Asset2BindingSource.DataSource = Nothing
            Asset3BindingSource.DataSource = Nothing
            Asset4BindingSource.DataSource = Nothing
            Asset5BindingSource.DataSource = Nothing

            Try
                Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(Equipment1Lookup, xaeAssets, AddressOf LoadAssetFromAssetClass1, Me.Conversation)
            Catch ex As Exception
                Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
            End Try

            Try
                Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit2, xaeAssets, AddressOf LoadAssetFromAssetClass2, Me.Conversation)
            Catch ex As Exception
                Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
            End Try

            Try
                Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit3, xaeAssets, AddressOf LoadAssetFromAssetClass3, Me.Conversation)
            Catch ex As Exception
                Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
            End Try

            Try
                Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit4, xaeAssets, AddressOf LoadAssetFromAssetClass4, Me.Conversation)
            Catch ex As Exception
                Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
            End Try

            Try
                Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit5, xaeAssets, AddressOf LoadAssetFromAssetClass5, Me.Conversation)
            Catch ex As Exception
                Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
            End Try
        End If


    End Sub

    Private Sub Equipment1Lookup_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles Equipment1Lookup.EditValueChanged
        If Loaded Then
            If Equipment1Lookup.EditValue IsNot Nothing AndAlso IsDBNull(Equipment1Lookup.EditValue) = False Then
                'asset1 = Equipment1Lookup.EditValue
                Me.Record.EquipamentoNo1 = Convert.ToInt32(Equipment1Lookup.EditValue)
                UpdateEquipValues()
                'Else
                '    If asset1 <> "" Then
                '        Me.Record.EquipamentoNo1 = Convert.ToInt32(asset1)
                '        Equipment1Lookup.EditValue = Convert.ToInt32(asset1)
                '        asset1 = ""
                '    End If
            End If
        End If
        asset1 = ""
    End Sub

    Private Sub Equipment1Lookup_ProcessNewValue(sender As System.Object, e As System.EventArgs) Handles Equipment1Lookup.ProcessNewValue
        If Loaded Then
            '       If Equipment1Lookup.EditValue IsNot Nothing AndAlso IsDBNull(Equipment1Lookup.EditValue) = False Then
            ' asset1 = Equipment1Lookup.EditValue
            Me.Record.EquipamentoNo1 = Convert.ToInt32(Equipment1Lookup.EditValue)
            UpdateEquipValues()
            'Else
            '    If asset1 <> "" Then
            ' Me.Record.EquipamentoNo1 = Convert.ToInt32(asset1)
            ' Equipment1Lookup.EditValue = Convert.ToInt32(asset1)
            ' asset1 = ""
            ' End If
            'End If
        End If

    End Sub

    Private Sub EquipmentLookUpEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles EquipmentLookUpEdit2.EditValueChanged
        If Loaded Then
            '    If EquipmentLookUpEdit2.EditValue IsNot Nothing AndAlso IsDBNull(EquipmentLookUpEdit2.EditValue) = False Then
            'asset2 = EquipmentLookUpEdit2.EditValue
            Me.Record.EquipamentoNo2 = Convert.ToInt32(EquipmentLookUpEdit2.EditValue)
            UpdateEquipValues()
            ' Else
            '     If asset2 <> "" Then
            'Me.Record.EquipamentoNo2 = Convert.ToInt32(asset2)
            '     EquipmentLookUpEdit2.EditValue = Convert.ToInt32(asset2)
            '      asset2 = ""
            '  End If
            ' End If
        End If

    End Sub

    Private Sub EquipmentLookUpEdit3_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles EquipmentLookUpEdit3.EditValueChanged
        If Loaded Then
            'If EquipmentLookUpEdit3.EditValue IsNot Nothing AndAlso IsDBNull(EquipmentLookUpEdit3.EditValue) = False Then
            Me.Record.EquipamentoNo3 = Convert.ToInt32(EquipmentLookUpEdit3.EditValue)
            UpdateEquipValues()
            'Else
            '    If asset3 <> "" Then
            '        Me.Record.EquipamentoNo3 = Convert.ToInt32(asset3)
            '        EquipmentLookUpEdit3.EditValue = Convert.ToInt32(asset3)
            '        asset3 = ""
            '    End If
            'End If
        End If
    End Sub

    Private Sub EquipmentLookUpEdit4_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles EquipmentLookUpEdit4.EditValueChanged

        If Loaded Then
            '     If EquipmentLookUpEdit4.EditValue IsNot Nothing AndAlso IsDBNull(EquipmentLookUpEdit4.EditValue) = False Then
            '     asset4 = EquipmentLookUpEdit4.EditValue
            Me.Record.EquipamentoNo4 = Convert.ToInt32(EquipmentLookUpEdit4.EditValue)
            UpdateEquipValues()
            '  Else
            '      If asset4 <> "" Then
            '      Me.Record.EquipamentoNo4 = Convert.ToInt32(asset4)
            '     EquipmentLookUpEdit4.EditValue = Convert.ToInt32(asset4)
            '     asset4 = ""
            '  End If
            '  End If
        End If

    End Sub

    Private Sub EquipmentLookUpEdit5_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles EquipmentLookUpEdit5.EditValueChanged
        If Loaded Then
            'If EquipmentLookUpEdit5.EditValue IsNot Nothing AndAlso IsDBNull(EquipmentLookUpEdit5.EditValue) = False Then
            '    asset5 = EquipmentLookUpEdit5.EditValue
            Me.Record.EquipamentoNo5 = Convert.ToInt32(EquipmentLookUpEdit5.EditValue)
            UpdateEquipValues()
            'Else
            '    If asset5 <> "" Then
            '        Me.Record.EquipamentoNo5 = Convert.ToInt32(asset5)
            '        EquipmentLookUpEdit5.EditValue = Convert.ToInt32(asset5)
            '        asset5 = ""
            '    End If
            'End If
        End If
    End Sub

    Private Sub AssetType1LookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetType1LookUpEdit.EditValueChanged
        Equipment1Lookup.EditValue = Nothing
        AssetBindingSource.DataSource = Nothing
        Try
            Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(Equipment1Lookup, xaeAssets, AddressOf LoadAssetFromAssetClass1, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
        End Try
    End Sub

    Private Sub AssetTypeLookUpEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetTypeLookUpEdit2.EditValueChanged
        EquipmentLookUpEdit2.EditValue = Nothing
        Asset2BindingSource.DataSource = Nothing

        Try
            Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit2, xaeAssets, AddressOf LoadAssetFromAssetClass2, Me.Conversation)
        Catch ex As Exception
            AssetType2 = False
            Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
        End Try
        AssetType2 = False
    End Sub

    Private Sub AssetTypeLookUpEdit3_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetTypeLookUpEdit3.EditValueChanged
        EquipmentLookUpEdit3.EditValue = Nothing
        Asset3BindingSource.DataSource = Nothing
        Try
            Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit3, xaeAssets, AddressOf LoadAssetFromAssetClass3, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
        End Try

    End Sub


    Private Sub AssetTypeLookUpEdit4_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetTypeLookUpEdit4.EditValueChanged
        EquipmentLookUpEdit4.EditValue = Nothing
        Asset4BindingSource.DataSource = Nothing
        Try
            Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit4, xaeAssets, AddressOf LoadAssetFromAssetClass4, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
        End Try

    End Sub

    Private Sub AssetTypeLookUpEdit5_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetTypeLookUpEdit5.EditValueChanged
        EquipmentLookUpEdit5.EditValue = Nothing
        Asset5BindingSource.DataSource = Nothing
        Try
            Dim ass1 As New Helper.ActiveRecord.LookupMaintenance(Of API.Asset)(EquipmentLookUpEdit5, xaeAssets, AddressOf LoadAssetFromAssetClass5, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Assets.", ex)
        End Try

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit1.CheckedChanged

    End Sub

    Private Sub AssetOperatorLookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetOperatorLookUpEdit1.EditValueChanged
        If Loaded Then
            Me.Record.AssetOperator = Convert.ToInt32(AssetOperatorLookUpEdit1.EditValue)
        End If

    End Sub

    Private Sub AssetOperatorLookUpEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetOperatorLookUpEdit2.EditValueChanged
        If Loaded Then
            Me.Record.AssetOperator2 = Convert.ToInt32(AssetOperatorLookUpEdit2.EditValue)
        End If
    End Sub

    Private Sub AssetOperatorLookUpEdit3_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetOperatorLookUpEdit3.EditValueChanged
        If Loaded Then
            Me.Record.AssetOperator3 = Convert.ToInt32(AssetOperatorLookUpEdit3.EditValue)
        End If
    End Sub

    Private Sub AssetOperatorLookUpEdit4_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetOperatorLookUpEdit4.EditValueChanged
        If Loaded Then
            Me.Record.AssetOperator4 = Convert.ToInt32(AssetOperatorLookUpEdit4.EditValue)
        End If
    End Sub

    Private Sub AssetOperatorLookUpEdit5_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AssetOperatorLookUpEdit5.EditValueChanged
        If Loaded Then
            Me.Record.AssetOperator5 = Convert.ToInt32(AssetOperatorLookUpEdit5.EditValue)
        End If
    End Sub

    Private Sub JobDateDateEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles JobDateDateEdit.EditValueChanged
        If Loaded Then
            Me.Record.JobDate = JobDateDateEdit.EditValue
        End If
    End Sub
End Class

Public Class xaegJob3
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Job)

    Public Sub New()
        MyBase.New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

End Class