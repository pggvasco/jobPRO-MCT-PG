

Public Class xaeJob_CTH
    Inherits xaegJob_CTH
    'Public Property Defaults As API.Defaults
    Private Property job As API.Job
    Private Property workCentreCategory As API.WorkCentreCategory
    Private userFieldsLoaded As Boolean = False


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
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of Helper.ActiveRecord.Evolution.Client)(CustomerLookUpEdit, AddressOf LoadClients, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Client.", ex)
        End Try

        'Try
        '    Dim wcclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentreCategory)(WorkCentreCategoryLookUpEdit, xaeWorkCentreCategory, AddressOf LoadWorkCentreCategories, Me.Conversation)
        'Catch ex As Exception
        '    Setup.Log.logError("Error setting lookup maintenance for Work Centre Categories.", ex)
        'End Try

        'Try
        '    Dim jt As New Helper.ActiveRecord.LookupMaintenance(Of API.JobTemplate)(TemplateLookUpEdit, xaeJobTemplate, AddressOf LoadTemplates, Me.Conversation)
        'Catch ex As Exception
        '    Setup.Log.logError("Error setting lookup maintenance for Job Templates.", ex)
        'End Try
        GetTemplatesBassedOnMakeModelFunctionGeneration()
        Try
            Dim rbl As New Helper.Evolution.LookupLoader(Of Pastel.Evolution.SalesRepresentative)(RepresentativeIDLookUpEdit, SalesRepresentativeBindingSource, "idSalesRep")
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Sales Reps.", ex)
        End Try

        'Try
        '    Dim plbl As New Helper.Evolution.LookupLoader(Of Pastel.Evolution.PriceList)(PricelistLookUpEdit, PriceListBindingSource, "IDPricelistName")
        'Catch ex As Exception
        '    Setup.Log.logError("Error setting loader for Pricelists.", ex)
        'End Try

        'Try
        '    Dim clm As New Helper.ActiveRecord.LookupMaintenance(Of API.JobCategory)(JobCategoryLookUpEdit, xaeJobCategory, AddressOf LoadCategories, Me.Conversation)
        'Catch ex As Exception
        '    Setup.Log.logError("Error setting lookup maintenance for Categories.", ex)
        'End Try

        Try
            Dim tlm As New Helper.ActiveRecord.LookupMaintenance(Of API.JobType)(JobTypeLookUpEdit, xaeJobType, AddressOf LoadTypes, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Job Types.", ex)
        End Try

        Try
            Dim cclm As New Helper.ActiveRecord.LookupMaintenance(Of API.CostCentre)(CostCentreLookUpEdit, xaeCostCentre, AddressOf LoadCostCentres, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Cost Centres.", ex)
        End Try

        Try
            Dim mlm As New Helper.ActiveRecord.LookupMaintenance(Of API.Make)(MakeLookUpEdit, xaeMake, AddressOf LoadMakes, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Makes.", ex)
        End Try

        Try
            Dim modlm As New Helper.ActiveRecord.LookupMaintenance(Of API.Model)(ModelLookUpEdit, xaeModel, AddressOf LoadModels, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Models.", ex)
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
            SetDefaultData()
        Catch ex As Exception
            Setup.Log.logError("Error setting default data on job.", ex)
        End Try

        Try
            SetNumbering()
        Catch ex As Exception
            Setup.Log.logError("Error setting numbering on job.", ex)
        End Try



        If Me.Record.CostCentre Is Nothing Then
            Me.Record.CostCentre = API.CostCentre.FindAll().FirstOrDefault
        End If
    End Sub

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

            Dim evolutionjob = New Pastel.Evolution.JobCard(JobNumberTextEdit.Text)
            Dim line As Pastel.Evolution.JobDetail
            'check if any  line  for job is invoiced 
            line = (From lin As Pastel.Evolution.JobDetail In evolutionjob.Detail Select lin Where lin.Quantity <> lin.QuantityWIP And lin.BudgetUnitCostPrice <> 0).FirstOrDefault

            If line IsNot Nothing Then
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
                    Me.Record.JobDate = Today.Date
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
        If userFieldsLoaded = False Then
            Try
                AddAdditionalEnquiryFields()
            Catch ex As Exception
                UniSource.Logging.Log.Log.logError("Error creating user-defined enquiry fields.", ex)
            End Try
        End If
        Try
            RebindAdditionalEnquiryFields()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error binding user-defined enquiry fields.", ex)
        End Try
        userFieldsLoaded = True

        ' user fields end

        MyBase.SetCLH()
        CLH.Components.Add(JobDataLayoutControl)
        CLH.Components.Add(AdditionalFieldsLayoutControlLayoutControl)
        CLH.AddSaveEvent(AdditionalFieldsLayoutControlLayoutControl, "HideCustomization")

    End Sub

    Public Sub AddAdditionalEnquiryFields()
        If AdditionalFieldsLayoutControlLayoutControl IsNot Nothing Then
            For Each udef As Helper.ActiveRecord.Evolution.UserDefinedField In UniSource.Helper.ActiveRecord.Evolution.UserDefinedField.FindAllByType(GetType(API.Job))

                Dim udefLCI = udef.GetLayoutControlItem
                AddHandler udefLCI.Control.Leave, AddressOf GetTemplatesBassedOnMakeModelFunctionGeneration
                AdditionalFieldsLayoutControlLayoutControl.AddItem(udefLCI)
            Next
        End If
    End Sub

    Public Sub RebindAdditionalEnquiryFields()
        If AdditionalFieldsLayoutControlLayoutControl IsNot Nothing Then
            For Each lci As DevExpress.XtraLayout.BaseLayoutItem In AdditionalFieldsLayoutControlLayoutControl.Items
                Dim bc As UniSource.Helper.ActiveRecord.UserDefinedFieldBindingContext = TryCast(lci.Tag, UniSource.Helper.ActiveRecord.UserDefinedFieldBindingContext)
                If bc IsNot Nothing Then
                    bc.ReBind(Me.BindingSource.Current)
                End If
            Next
        End If
    End Sub

    Private Sub BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles BindingSource.CurrentChanged
        Try
            RebindAdditionalEnquiryFields()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error binding user-defined enquiry fields.", ex)
        End Try
    End Sub

    Private Function LoadClients() As IEnumerable(Of Helper.ActiveRecord.Evolution.Client)
        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            Return UniSource.Helper.ActiveRecord.Evolution.Client.FindAll
        End Using
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

    Private Function LoadCostCentres() As IEnumerable(Of API.CostCentre)
        Return API.CostCentre.FindAll
    End Function

    Private Function LoadMakes() As IEnumerable(Of API.Make)
        Return API.Make.FindAll
    End Function

    Private Function LoadTemplates() As IEnumerable(Of API.JobTemplate)
        Return API.JobTemplate.FindAll
    End Function

    Private Function LoadModels() As IEnumerable(Of API.Model)
        Dim mk As API.Make = TryCast(MakeLookUpEdit.EditValue, API.Make)
        If mk IsNot Nothing Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Model)()
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Make", mk), NHibernate.Criterion.Expression.IsNull("Make")))
            Return API.Model.FindAll(crit)
        Else
            Return API.Model.FindAll
        End If
    End Function

    Private Function LoadFunctions() As IEnumerable(Of API.Function)
        Dim mk As API.Make = TryCast(MakeLookUpEdit.EditValue, API.Make)
        If mk IsNot Nothing Then
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Function)()
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Make", mk), NHibernate.Criterion.Expression.IsNull("Make")))
            Return API.Function.FindAll(crit)
        Else
            Return API.Function.FindAll
        End If
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
            If Me.Record.JobTemplate.CostCentre IsNot Nothing AndAlso IIf(IsDBNull(CostCentreLookUpEdit.EditValue), Nothing, CostCentreLookUpEdit.EditValue) Is Nothing Then
                CostCentreLookUpEdit.EditValue = Me.Record.JobTemplate.CostCentre
                Me.Record.CostCentre = Me.Record.JobTemplate.CostCentre
            End If
            If Me.Record.JobTemplate.Drawing IsNot Nothing AndAlso IIf(IsDBNull(DrawingLookUpEdit.EditValue), Nothing, DrawingLookUpEdit.EditValue) Is Nothing Then
                DrawingLookUpEdit.EditValue = Me.Record.JobTemplate.Drawing
                Me.Record.Drawing = Me.Record.JobTemplate.Drawing
            End If
            If Me.Record.JobTemplate.Function IsNot Nothing AndAlso IIf(IsDBNull(FunctionLookUpEdit.EditValue), Nothing, FunctionLookUpEdit.EditValue) Is Nothing Then
                FunctionLookUpEdit.EditValue = Me.Record.JobTemplate.Function
                Me.Record.Function = Me.Record.JobTemplate.Function
            End If
            If Me.Record.JobTemplate.Generation IsNot Nothing AndAlso IIf(IsDBNull(GenerationLookUpEdit.EditValue), Nothing, GenerationLookUpEdit.EditValue) Is Nothing Then
                GenerationLookUpEdit.EditValue = Me.Record.JobTemplate.Generation
                Me.Record.Generation = Me.Record.JobTemplate.Generation
            End If
            If Me.Record.JobTemplate.JobType IsNot Nothing AndAlso IIf(IsDBNull(JobTypeLookUpEdit.EditValue), Nothing, JobTypeLookUpEdit.EditValue) Is Nothing Then
                JobTypeLookUpEdit.EditValue = Me.Record.JobTemplate.JobType
                Me.Record.JobType = Me.Record.JobTemplate.JobType
            End If
            If Me.Record.JobTemplate.Make IsNot Nothing AndAlso IIf(IsDBNull(MakeLookUpEdit.EditValue), Nothing, MakeLookUpEdit.EditValue) Is Nothing Then
                MakeLookUpEdit.EditValue = Me.Record.JobTemplate.Make
                Me.Record.Make = Me.Record.JobTemplate.Make
            End If
            If Me.Record.JobTemplate.Model IsNot Nothing AndAlso IIf(IsDBNull(ModelLookUpEdit.EditValue), Nothing, ModelLookUpEdit.EditValue) Is Nothing Then
                ModelLookUpEdit.EditValue = Me.Record.JobTemplate.Model
                Me.Record.Model = Me.Record.JobTemplate.Model
            End If

            'TODO: generic code to refresh UDF control if value was changed
            If Me.Record.JobTemplate.UserFields("ArticleNumber") IsNot Nothing AndAlso Me.Record.JobTemplate.UserFields("ArticleNumber") <> "" Then
                Me.Record.UserFields("ArticleNumber") = Me.Record.JobTemplate.UserFields("ArticleNumber")
                For i As Integer = 0 To AdditionalFieldsLayoutControlLayoutControl.Items.Count - 1
                    If TypeOf AdditionalFieldsLayoutControlLayoutControl.Items(i) Is DevExpress.XtraLayout.LayoutControlItem Then
                        Dim aName As String = (CType(AdditionalFieldsLayoutControlLayoutControl.Items(i), DevExpress.XtraLayout.LayoutControlItem)).Control.Name
                        If aName.Contains("ArticleNumber") Then
                            CType((CType(AdditionalFieldsLayoutControlLayoutControl.Items(i), DevExpress.XtraLayout.LayoutControlItem)).Control, DevExpress.XtraEditors.TextEdit).EditValue = Me.Record.JobTemplate.UserFields("ArticleNumber")
                        End If
                    End If
                Next i

            End If

            If Me.Record.JobTemplate.UserFields("PartNumber") IsNot Nothing AndAlso Me.Record.JobTemplate.UserFields("PartNumber") <> "" Then
                Me.Record.UserFields("PartNumber") = Me.Record.JobTemplate.UserFields("PartNumber")
                For i As Integer = 0 To AdditionalFieldsLayoutControlLayoutControl.Items.Count - 1
                    If TypeOf AdditionalFieldsLayoutControlLayoutControl.Items(i) Is DevExpress.XtraLayout.LayoutControlItem Then
                        Dim aName As String = (CType(AdditionalFieldsLayoutControlLayoutControl.Items(i), DevExpress.XtraLayout.LayoutControlItem)).Control.Name
                        If aName.Contains("PartNumber") Then
                            CType((CType(AdditionalFieldsLayoutControlLayoutControl.Items(i), DevExpress.XtraLayout.LayoutControlItem)).Control, DevExpress.XtraEditors.TextEdit).EditValue = Me.Record.JobTemplate.UserFields("PartNumber")
                        End If
                    End If
                Next i
            End If
        End If
    End Sub

    Private Sub MakeLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles MakeLookUpEdit.EditValueChanged
        Dim mk As API.Make = TryCast(MakeLookUpEdit.EditValue, API.Make)
        If mk IsNot Nothing Then
            ModelLookUpEdit.Enabled = True
            FunctionLookUpEdit.Enabled = True
            Try
                ModelBindingSource.DataSource = LoadModels()
            Catch ex As Exception
                Setup.Log.logError("Error loading Models.", ex)
            End Try
            Try
                FunctionBindingSource.DataSource = LoadFunctions()
            Catch ex As Exception
                Setup.Log.logError("Error loading Functions.", ex)
            End Try
        Else
            'ModelLookUpEdit.Enabled = False
            'FunctionLookUpEdit.Enabled = False
            'ModelBindingSource.DataSource = Nothing
            'FunctionBindingSource.DataSource = Nothing
        End If

        GetTemplatesBassedOnMakeModelFunctionGeneration()
    End Sub

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
            'If prop.Name = "JobCategory" Then
            '    JobCategoryLookUpEdit.ErrorText = errors(prop)(0)
            'End If
            'If prop.Name = "PricelistID" Then
            '    PricelistLookUpEdit.ErrorText = errors(prop)(0)
            'End If
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

    'Private Sub JobCategoryLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim jc As API.JobCategory = TryCast(JobCategoryLookUpEdit.EditValue, API.JobCategory)
    '    If jc IsNot Nothing Then
    '        If jc <> Me.Record.JobCategory Then
    '            Me.Record.JobCategory = jc
    '            Try
    '                SetNumbering()
    '            Catch ex As Exception
    '                Setup.Log.logError("Error setting numbering on job.", ex)
    '            End Try
    '        End If
    '    End If
    'End Sub

    'Private Sub WorkCentreCategoryLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If IIf(IsDBNull(WorkCentreCategoryLookUpEdit.EditValue), Nothing, WorkCentreCategoryLookUpEdit.EditValue) IsNot Nothing AndAlso IIf(IsDBNull(TemplateLookUpEdit.EditValue), Nothing, TemplateLookUpEdit.EditValue) IsNot Nothing Then
    '        If Me.Record.JobTemplate.WorkCentreCategory IsNot Nothing AndAlso Me.Record.JobTemplate.WorkCentreCategory <> WorkCentreCategoryLookUpEdit.EditValue Then
    '            'MessageBox.Show()
    '            UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Template {0} not part of Work Centre Category {1}. Template cleared.", TemplateLookUpEdit.EditValue, WorkCentreCategoryLookUpEdit.EditValue))
    '            TemplateLookUpEdit.EditValue = Nothing
    '        End If
    '    End If
    '    If IIf(IsDBNull(WorkCentreCategoryLookUpEdit.EditValue), Nothing, WorkCentreCategoryLookUpEdit.EditValue) IsNot Nothing Then
    '        If workCentreCategory Is Nothing OrElse Not workCentreCategory.ID.Equals(CType(WorkCentreCategoryLookUpEdit.EditValue, API.WorkCentreCategory).ID) Then
    '            workCentreCategory = CType(WorkCentreCategoryLookUpEdit.EditValue, API.WorkCentreCategory)
    '            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
    '                JobTemplateBindingSource.DataSource = LoadTemplates()
    '            End Using
    '        End If
    '    End If
    'End Sub

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
        MyBase.DestroyHandle()
        Me.Dispose()
        'TODO: Find Proper why of GC
        'System.GC.GetTotalMemory(True)
    End Sub


    Private Sub GetTemplatesBassedOnMakeModelFunctionGeneration()
        Dim tempCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobTemplate)()

        If IIf(IsDBNull(MakeLookUpEdit.EditValue), Nothing, MakeLookUpEdit.EditValue) IsNot Nothing Then
            tempCrit.CreateAlias("Make", "Make")
            tempCrit.Add((NHibernate.Criterion.Expression.Eq("Make.ID", CType(CType(MakeLookUpEdit.EditValue, API.Make).ID, Integer))))
        End If

        If IIf(IsDBNull(ModelLookUpEdit.EditValue), Nothing, ModelLookUpEdit.EditValue) IsNot Nothing Then
            tempCrit.CreateAlias("Model", "Model")
            tempCrit.Add((NHibernate.Criterion.Expression.Eq("Model.ID", CType(CType(ModelLookUpEdit.EditValue, API.Model).ID, Integer))))
        End If

        If IIf(IsDBNull(FunctionLookUpEdit.EditValue), Nothing, FunctionLookUpEdit.EditValue) IsNot Nothing Then
            tempCrit.CreateAlias("Function", "Function")
            tempCrit.Add((NHibernate.Criterion.Expression.Eq("Function.ID", CType(CType(FunctionLookUpEdit.EditValue, API.Function).ID, Integer))))
        End If

        If IIf(IsDBNull(GenerationLookUpEdit.EditValue), Nothing, GenerationLookUpEdit.EditValue) IsNot Nothing Then
            tempCrit.CreateAlias("Generation", "Generation")
            tempCrit.Add((NHibernate.Criterion.Expression.Eq("Generation.ID", CType(CType(GenerationLookUpEdit.EditValue, API.Generation).ID, Integer))))
        End If

        If Me.Record.UserFields("ArticleNumber") IsNot Nothing AndAlso Me.Record.UserFields("ArticleNumber") <> "" Then
            tempCrit.Add((NHibernate.Criterion.Expression.Sql(String.Format("ArticleNumber = '{0}'", Me.Record.UserFields("ArticleNumber")))))
        End If

        If Me.Record.UserFields("PartNumber") IsNot Nothing AndAlso Me.Record.UserFields("PartNumber") <> "" Then
            tempCrit.Add((NHibernate.Criterion.Expression.Sql(String.Format("PartNumber = '{0}'", Me.Record.UserFields("PartNumber")))))
        End If

        'Using New Castle.ActiveRecord.ConversationalScope(Conversation)
        JobTemplateBindingSource.DataSource = API.JobTemplate.FindAll(tempCrit)
        'End Using


    End Sub

    Private Sub ModelLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles ModelLookUpEdit.EditValueChanged
        GetTemplatesBassedOnMakeModelFunctionGeneration()
    End Sub

    Private Sub FunctionLookUpEdit_EditValueChanging(sender As System.Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles FunctionLookUpEdit.EditValueChanging
        GetTemplatesBassedOnMakeModelFunctionGeneration()
    End Sub

    Private Sub GenerationLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles GenerationLookUpEdit.EditValueChanged
        GetTemplatesBassedOnMakeModelFunctionGeneration()
    End Sub

    Private Sub MakeLookUpEdit_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MakeLookUpEdit.KeyDown
        If e.KeyCode = Keys.Delete Then
            MakeLookUpEdit.CancelPopup()
            Me.Record.Make = Nothing
            MakeLookUpEdit.EditValue = Nothing
        End If
    End Sub

    Private Sub ModelLookUpEdit_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ModelLookUpEdit.KeyDown
        If e.KeyCode = Keys.Delete Then
            ModelLookUpEdit.CancelPopup()
            Me.Record.Model = Nothing
            ModelLookUpEdit.EditValue = Nothing
        End If
    End Sub

    Private Sub FunctionLookUpEdit_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles FunctionLookUpEdit.KeyDown
        If e.KeyCode = Keys.Delete Then
            FunctionLookUpEdit.CancelPopup()
            Me.Record.Function = Nothing
            FunctionLookUpEdit.EditValue = Nothing
        End If
    End Sub

    Private Sub GenerationLookUpEdit_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GenerationLookUpEdit.KeyDown
        If e.KeyCode = Keys.Delete Then
            GenerationLookUpEdit.CancelPopup()
            Me.Record.Generation = Nothing
            GenerationLookUpEdit.EditValue = Nothing
        End If
    End Sub

    Private Sub xaeJob_CTH_Enter(sender As System.Object, e As System.EventArgs) Handles MyBase.Enter
        GetTemplatesBassedOnMakeModelFunctionGeneration()
    End Sub
End Class

Public Class xaegJob_CTH
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Job)

    Public Sub New()
        MyBase.New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

End Class