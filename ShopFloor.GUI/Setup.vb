Imports UniSource.Helper.GUI.My.Resources
'Imports UniSource.ShopFloor.Reports
'Imports UniSource.ShopFloor.Scheduler
Imports DevExpress.XtraReports.UI
Public Class Setup
    Inherits UniSource.LogOn.Evolution.Setup

    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Shared Property ExtendedAgent As Security.ActiveRecord.ExtendedAgent

    Overloads Shared Sub Main()
        _setup = New Setup
        '_setup.MainForm = New Menu.xfMain With {.Text = "UniSource ShopFloor", .Icon = EvolutionDefault}
        _setup.MainForm = New Menu.xfMain With {.Text = "UniSource Job Pro", .Icon = EvolutionDefault}
        _setup.CallFromMain()
    End Sub

    Public Overrides Sub InitiliaseDatabase()
        MyBase.InitiliaseDatabase()
        ARHelper.AddAssembly(GetType(UniSource.Helper.ActiveRecord.GUI.awControlLayoutHelper).Assembly)
        ARHelper.AddAssembly(GetType(UniSource.Checklist.API.awChecklistHelper).Assembly)
        ARHelper.AddAssembly(GetType(UniSource.ReportManager.awReportRepositoryHelper).Assembly)
        ARHelper.AddAssembly(GetType(UniSource.ShopFloor.API.awShopFloorHelper).Assembly)
        ARHelper.AddAssembly(GetType(UniSource.Security.ActiveRecord.awSecurityHelper).Assembly)

        ARHelper.AddAssembly(GetType(API.awDOSCOTestBenchHelper).Assembly)

        'ARHelper.AddAssembly(GetType(Shopfloor.Scheduler.API.awShopFloorHelper).Assembly)
        Me.ARHelper.AddAssembly(Reflection.Assembly.GetAssembly(GetType(UniSource.B2B.DAL.awB2BHelper)))
        ExtendedAgent = New Security.ActiveRecord.ExtendedAgent(UniSource.LogOn.Evolution.Setup.Agent)
        API.Context.Agent = ExtendedAgent.Agent
        Pastel.Evolution.DatabaseContext.ExecuteCommandNonQuery(" insert into ussSFEmployee Select idPeople From _rtblPeople Where idPeople Not In ( Select PersonID From ussSFEmployee)")
        Pastel.Evolution.DatabaseContext.ExecuteCommandNonQuery(" insert into  ussSFCustomer Select DCLink From Client Where DCLink Not In ( Select ERPCustomerID From  ussSFCustomer)")

    End Sub

    Public Overrides Sub InitialiseMenu()
        MyBase.InitialiseMenu()
        CType(_setup.MainForm, Menu.xfMain).MainNode = GetMenu()
    End Sub

    Private Function GetMenu() As Menu.INode

        Dim AppVersionNumber As String = String.Format("{0}", My.Application.Info.Version.ToString)

        If (API.Context.Defaults.LiveVersion Is Nothing OrElse AppVersionNumber <> API.Context.Defaults.LiveVersion) AndAlso (ExtendedAgent.Agent.Name.Contains("Admin") OrElse ExtendedAgent.Agent.Name.Contains("Unisource")) Then
            If UniSource.Helper.GUI.Dialog.YesNoDialog(String.Format("Version Number({0}) diffrent than current version({1}), update version number?", AppVersionNumber, API.Context.Defaults.LiveVersion)) = MsgBoxResult.Yes Then
                API.Context.Defaults.LiveVersion = AppVersionNumber
                API.Context.Defaults.SaveAndFlush()
            End If
        ElseIf AppVersionNumber <> API.Context.Defaults.LiveVersion Then
            UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Your version {1} is not valid please install latest version {0}.", API.Context.Defaults.LiveVersion, AppVersionNumber))
            Process.GetCurrentProcess.Kill()
        End If


        API.Context.ActiveConnection = Settings.ActiveConnection

        GetMenu = New Menu.Node("UniSource") With {.User = ExtendedAgent.User}

        Dim sfMenu As New Menu.Node("Job Pro", package, True)

        Dim sfMaintenanceMenu = New Menu.Node("Maintenance", key)
        Dim sfTransactionMenu = New Menu.Node("Transactions\Job Stages", cog)
        Dim sfEnquiriesMenu = New Menu.Node("Enquiries\Processing", magnifier)
        Dim sfReportMenu = New Menu.Node("Report Maintenance", Resources.report)
        Dim sfAdministration = New Menu.Node("Administration", user_suit)
        Dim B2bmapping = New Menu.Node("B2B Mappings", user_suit)

        Dim b2bNode = New Menu.Node("&B2B Mappings", UniSource.Helper.GUI.My.Resources.database_link)
        Dim b2bUpload As New Menu.DelegateNode(AddressOf UploadMapping, "Upload", UniSource.Helper.GUI.My.Resources.database_go)
        Dim b2bImport As New Menu.DelegateNode(AddressOf ImportMapping, "Import", UniSource.Helper.GUI.My.Resources.database_gear)
        Dim b2bIntegration As New Menu.DelegateNode(AddressOf IntegrationMapping, "Integration", UniSource.Helper.GUI.My.Resources.database_connect)
        b2bNode.AddChild(b2bUpload)
        b2bNode.AddChild(b2bImport)
        b2bNode.AddChild(b2bIntegration)
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.JobCategory, xlJobCategory)(folder_table, "Job Categories") With {.DisableDrilldown = True})
        End If

        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.Asset, xlAsset)(lorry, "Assets") With {.DisableDrilldown = True})
            'Schedule Forms 
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.RequestType, xlRequestType)(report_edit, "Request Type") With {.DisableDrilldown = True})
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.ScheduleFrequency, xlScheduleFrequency)(note, "Schedule Frequency") With {.DisableDrilldown = True})
        End If

        'If API.Context.Defaults.IsTimeSheetVersion = False Then
        '    sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.AssetClass, xlAsset)(picture, "Asset Class") With {.DisableDrilldown = True})
        'End If

        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.ServiceType, xlServiceType)(folder_picture, "Service Type") With {.DisableDrilldown = True})
        End If

        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.ServiceTemplate, xlServiceTemplate)(folder_image, "Service Template") With {.DisableDrilldown = True})
        End If

        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(UniSource.Checklist.GUI.Setup.GetMenu)
        End If
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.CommonLetter, xlCommonLetter)(page_white_stack, "Common Letters") With {.DisableDrilldown = True})
        End If
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.CostCentre, xlCostCentre)(chart_pie, "Cost Centres") With {.DisableDrilldown = True})
        End If
        sfMaintenanceMenu.AddChild(New Menu.DialogNode(GetType(xaeDefaults), "Defaults", cog))
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.Drawing, xlDrawing)(picture, "Drawings") With {.DisableDrilldown = True})
        End If
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.Function, xlFunction)(medal_silver_1, "Functions") With {.DisableDrilldown = True})
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.Generation, xlGeneration)(rosette, "Generations") With {.DisableDrilldown = True})
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.Make, xlMake)(shield, "Makes") With {.DisableDrilldown = True})
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.Model, xlModel)(ruby, "Models") With {.DisableDrilldown = True})





        End If
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.JobMemo, xlJobMemo)(page_white_stack, "Memos") With {.DisableDrilldown = True})
        End If
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.Note, xlJobNote)(page_white_stack, "Notes") With {.DisableDrilldown = True})
        End If
        sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.JobStage, xlJobStage)(folder_go, "Job Stages") With {.DisableDrilldown = True})
        sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.JobType, xlJobType)(folder_key, "Job Types") With {.DisableDrilldown = True})
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.Part, xlPart)(wrench, "Parts") With {.DisableDrilldown = True})
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.PartGroup, xlPartGroup)(folder_wrench, "Part Groups") With {.DisableDrilldown = True})
        End If
        sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.JobFunctionControl, xlJobFunctionControl)(user_comment, "Passwords") With {.DisableDrilldown = True})
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.SupplyScope, xlSupplyScope)(basket, "Supply Scopes") With {.DisableDrilldown = True})
        End If
        sfMaintenanceMenu.AddChild(New Menu.ListNode(Of Helper.ActiveRecord.Evolution.UserDefinedField)(GetType(xaeUserDefinedField), basket, "User-Defined Fields") With {.DisableDrilldown = True})
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.WorkCentre, xlWorkCentre)(brick, "Work Centres") With {.DisableDrilldown = True})
        End If
        sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.WorkCentreCategory, xlWorkCentreCategory)(bricks, "Work Centre Categories") With {.DisableDrilldown = True})
        sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.Employee, xlEmployee)(bricks, "Employee") With {.DisableDrilldown = True})
        sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.SFCustomer, xlCustomerWardWarehouse)(bricks, "Customer Ward Link") With {.DisableDrilldown = True})
        sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.PublicHoliday, xlPublicHoliday)(date_link, "Public Holiday") With {.DisableDrilldown = True})
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            sfMaintenanceMenu.AddChild(New Menu.ListNode(Of API.Artisan, xlArtisan)(Resources.user, "Artisans") With {.DisableDrilldown = True})
        End If
        For Each js As API.JobStage In API.JobStage.FindAll(NHibernate.Criterion.Order.Asc("Sequence"))
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
            Dim ln As Menu.ListNode(Of API.Job, xlJob) = New Menu.ListNode(Of API.Job, xlJob)(page_white_gear, js.Description) With {.DisableDrilldown = True, .Criterion = crit}

            crit.Add(NHibernate.Criterion.Expression.Eq("JobStage", js))
            'crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("State", CInt(API.JobState.Active)), NHibernate.Criterion.Expression.Eq("State", CInt(API.JobState.Completed))))
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Active)), NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Completed))))
            sfTransactionMenu.AddChild(ln)
            ln.AddAction("View Job Audit", Sub(jobs)
                                               For Each j In jobs
                                                   CType(MainForm, Menu.xfMain).AddTab(New xlJobAudit(j), "Job Audit" & j.ID.ToString, String.Format("{0}", j.JobNumber))
                                               Next
                                           End Sub)
            For Each jf As API.JobStageFunction In js.Functions
                Try
                    Dim jfh As Functions.JobFunction = Functions.JobFunction.GetHandler(jf.JobFunctionID)
                    If jfh IsNot Nothing Then
                        Dim la As New Helper.ActiveRecord.LookupAction(Of API.Job)(jfh.Code, jfh.Glyph, AddressOf jfh.Process)
                        la.Description = jfh.Description
                        la.WrapInConversationalScope = False
                        la.RequiresInstance = jfh.RequiresInstance
                        ln.AdditionalActions.Add(la)
                    End If
                Catch
                End Try
            Next
            For Each cl As API.JobStageChecklist In js.JobStageChecklists
                Try
                    If cl.Checklist IsNot Nothing Then
                        Dim la As New Helper.ActiveRecord.LookupAction(Of API.Job)(cl.Checklist.Code, user_comment, AddressOf ShowChecklist)
                        If js.JobStageChecklists.First = cl Then
                            la.IsBeginGroup = True
                        End If
                        la.Description = cl.Checklist.Description
                        la.WrapInConversationalScope = False
                        ln.AdditionalActions.Add(la)
                    End If
                Catch
                End Try
            Next
            'TODO: add function print job list
            'For Each jsr As API.JobStageReport In js.JobStageReports
            '    If IIf(IsDBNull(jsr.IsReportOnListScreen), False, jsr.IsReportOnListScreen) Then
            '        ln.AdditionalActions.Add((jsr.Report.ReportName, UniSource.Helper.GUI.My.Resources.report, AddressOf RunReport, False)
            '    End If
            'Next
        Next

        If API.Context.Defaults.IsTimeSheetVersion = False Then
            Dim quoteCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
            'quoteCrit.Add(NHibernate.Criterion.Expression.Eq("State", CInt(API.JobState.Quote)))
            'quoteCrit.Add(NHibernate.Criterion.Expression.Ge("QuoteDate", Now.AddDays(-1 * API.Context.Defaults.ValidityDays.Value)))
            quoteCrit.Add(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Quote)))
            Dim quoteNode = New Menu.ListNode(Of API.Job, xlJob)(folder_find, "Quotes") With {.DisableDrilldown = True, .Criterion = quoteCrit}
            quoteNode.AddAction("Add Quote", AddressOf AddQuotation, "Add a new Quotation.", folder_add, False, False)
            quoteNode.AddAction("Edit Quote", AddressOf EditQuotation, "Edit the Quotation.", folder_edit, False)
            quoteNode.AddAction("Quotation", AddressOf MaintainQuotation, "Prepare and maintain the Quotation details.", folder_page_white, False)
            quoteNode.AddAction("Quotation Discount", AddressOf MaintainQuotationDiscount, "Prepare and maintain the Quotation Discount details.", folder_page_white, False)
            quoteNode.AddAction("Convert To Job", AddressOf ConvertQuoteToJob, "Convert the Quotation to an Active Job.", folder_go, False)
            quoteNode.AddAction("Comments", AddressOf AddQuotationComments, "Job Comments.", page_add, False, False)
            quoteNode.AddAction("Drawing", AddressOf JobDrawings, "Edit the Job Drawing.", page_add, False, False)
            quoteNode.AddAction("Generate Proforma Invoice", AddressOf JobProformaInvoice, "Generate Proforma Invoice.", brick, False, False)
            quoteNode.AddAction("Proforma Invoice Tracking", AddressOf ProformaInvTrackingRep, "Print the Proforma Invoice Tracking report.", page_white, False, False)
            sfEnquiriesMenu.AddChild(quoteNode)
        End If

        If API.Context.Defaults.IsTimeSheetVersion = False Then
            Dim templateNode = New Menu.ListNode(Of API.JobTemplate, xlJobTemplate)(page_find, "Templates") With {.DisableDrilldown = True}
            templateNode.AddAction("Maintain", AddressOf MaintainTemplate, "Maintain the template's details.", page_white_edit, False)
            sfEnquiriesMenu.AddChild(templateNode)
        End If

        Dim jobCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        'jobCrit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("State", CInt(API.JobState.Active)), NHibernate.Criterion.Expression.Eq("State", CInt(API.JobState.Completed))))
        jobCrit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Active)), NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Completed))))
        'Dim joblist As List(Of API.Job) = API.Job.FindAll(jobCrit).ToList
        ' sfEnquiriesMenu.AddChild(New Menu.ListNode(Of API.Job, xlJob)(page_white_find, "Jobs") With {.DisableDrilldown = True, .Criterion = jobCrit})
        Dim jobNode = New Menu.ListNode(Of API.Job, xlJob)(page_white_find, "Jobs") With {.DisableDrilldown = True, .Criterion = jobCrit}
        jobNode.AddAction("View Job Audit", Sub(jobs)
                                                For Each j In jobs
                                                    CType(MainForm, Menu.xfMain).AddTab(New xlJobAudit(j), "Job Audit" & j.ID.ToString, String.Format("{0}", j.JobNumber))
                                                Next
                                            End Sub)
        jobNode.AddAction("View", AddressOf ViewJob, "View the Job in Read-Only mode.", page_find, False, False)
        jobNode.AddAction("View Quotation", AddressOf ViewQuotation, "View the Quotation in Read-Only mode.", folder_find, False)
        jobNode.AddAction("View Notes", AddressOf ViewNote, "View the Note in Read-Only mode.", page_add, False)
        jobNode.AddAction("Check List Report", AddressOf ViewJobFinalInspectionReport, "View the Job Check List Report.", package, False)
        jobNode.AddAction("Test Bench Report", AddressOf ViewJobTestBenchReport, "View the JobTest Bench Report.", chart_curve, False)
        If API.Context.Defaults.IsTimeSheetVersion = False Then
            jobNode.AddAction("View Memos", AddressOf ViewMemo, "View the Memo in Read-Only mode.", page_add, False)
            jobNode.AddAction("Memo", AddressOf CommonLetter, "Job Memo.", page_add, False)
            jobNode.AddAction("View Drawing", AddressOf ViewJobDrawing, "View the Job Drawing in Read-Only mode.", picture, False)
        End If
        Dim jfhrsr As Functions.JobFunction = Functions.JobFunction.GetHandler(API.JobFunction.ReportSalesRepresentative)
        If jfhrsr IsNot Nothing Then
            Dim la As New Helper.ActiveRecord.LookupAction(Of API.Job)(jfhrsr.Code, jfhrsr.Glyph, AddressOf jfhrsr.Process)
            la.Description = jfhrsr.Description
            la.WrapInConversationalScope = False
            la.RequiresInstance = jfhrsr.RequiresInstance
            jobNode.AdditionalActions.Add(la)
        End If

        Dim jfReportStockAllocation As Functions.JobFunction = Functions.JobFunction.GetHandler(API.JobFunction.ReportStockAllocation)
        If jfReportStockAllocation IsNot Nothing Then
            Dim la As New Helper.ActiveRecord.LookupAction(Of API.Job)(jfReportStockAllocation.Code, jfReportStockAllocation.Glyph, AddressOf jfReportStockAllocation.Process)
            la.Description = jfReportStockAllocation.Description
            la.WrapInConversationalScope = False
            la.RequiresInstance = jfReportStockAllocation.RequiresInstance
            jobNode.AdditionalActions.Add(la)
        End If


        'Req for jobs testing
        'Dim jfhr As Functions.JobFunction = Functions.JobFunction.GetHandler(API.JobFunction.Requisition)
        'If jfhr IsNot Nothing Then
        '    Dim la As New Helper.ActiveRecord.LookupAction(Of API.Job)(jfhr.Code, jfhr.Glyph, AddressOf jfhr.Process)
        '    la.Description = jfhr.Description
        '    la.WrapInConversationalScope = False
        '    la.RequiresInstance = jfhr.RequiresInstance
        '    jobNode.AdditionalActions.Add(la)
        'End If
        'Dim jfhq As Functions.JobFunction = Functions.JobFunction.GetHandler(API.JobFunction.Quotation)
        'If jfhq IsNot Nothing Then
        '    Dim la As New Helper.ActiveRecord.LookupAction(Of API.Job)(jfhq.Code, jfhq.Glyph, AddressOf jfhq.Process)
        '    la.Description = jfhq.Description
        '    la.WrapInConversationalScope = False
        '    la.RequiresInstance = jfhq.RequiresInstance
        '    jobNode.AdditionalActions.Add(la)
        'End If

        sfEnquiriesMenu.AddChild(jobNode)
        For Each ay As API.ArchiveYear In API.ArchiveYear.FindAll(NHibernate.Criterion.Order.Asc("id"))
            Dim archiveCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
            Dim StartDate As Date = New Date(ay.Year, 1, 1)
            Dim EndDate As Date = New Date(ay.Year + 1, 1, 1)
            archiveCrit.Add(NHibernate.Criterion.Expression.Ge("JobDate", StartDate))
            archiveCrit.Add(NHibernate.Criterion.Expression.Lt("JobDate", EndDate))
            archiveCrit.Add(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Archive)))
            'sfEnquiriesMenu.AddChild(New Menu.ListNode(Of API.Job, xlJob)(page_white_cd, "Archive") With {.DisableDrilldown = True, .Criterion = archiveCrit})
            Dim archiveNode = New Menu.ListNode(Of API.Job, xlJob)(folder_find, "Archive " & ay.Year) With {.DisableDrilldown = True, .Criterion = archiveCrit}
            archiveNode.AddAction("View Job Audit", Sub(jobs)
                                                        For Each j In jobs
                                                            CType(MainForm, Menu.xfMain).AddTab(New xlJobAudit(j), "Job Audit" & j.ID.ToString, String.Format("{0}", j.JobNumber))
                                                        Next
                                                    End Sub)
            archiveNode.AddAction("View", AddressOf ViewJob, "View the Job in Read-Only mode.", page_find, False, False)
            archiveNode.AddAction("View Quotation", AddressOf ViewQuotation, "View the Quotation in Read-Only mode.", folder_find, False)
            archiveNode.AddAction("View Notes", AddressOf ViewNote, "View the Note in Read-Only mode.", page_add, False)
            archiveNode.AddAction("View Memos", AddressOf ViewMemo, "View the Memo in Read-Only mode.", page_add, False)
            archiveNode.AddAction("View Drawing", AddressOf ViewJobDrawing, "View the Job Drawing in Read-Only mode.", picture, False)
            archiveNode.AddAction("Check List Report", AddressOf ViewJobFinalInspectionReport, "View the Job Check List Report.", package, False)
            archiveNode.AddAction("Test Bench Report", AddressOf ViewJobTestBenchReport, "View the JobTest Bench Report.", chart_curve, False)
            sfEnquiriesMenu.AddChild(archiveNode)
        Next
        Dim historyCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        'historyCrit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("State", CInt(API.JobState.History)), NHibernate.Criterion.Expression.Eq("State", CInt(API.JobState.Cancelled))))
        historyCrit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.History)), NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Cancelled))))
        'sfEnquiriesMenu.AddChild(New Menu.ListNode(Of API.Job, xlJob)(page_white_database, "History") With {.DisableDrilldown = True, .Criterion = historyCrit})
        Dim historyNode = New Menu.ListNode(Of API.Job, xlJob)(folder_find, "History") With {.DisableDrilldown = True, .Criterion = historyCrit}
        historyNode.AddAction("View Job Audit", Sub(jobs)
                                                    For Each j In jobs
                                                        CType(MainForm, Menu.xfMain).AddTab(New xlJobAudit(j), "Job Audit" & j.ID.ToString, String.Format("{0}", j.JobNumber))
                                                    Next
                                                End Sub)
        historyNode.AddAction("View", AddressOf ViewJob, "View the Job in Read-Only mode.", page_find, False, False)
        historyNode.AddAction("View Quotation", AddressOf ViewQuotation, "View the Quotation in Read-Only mode.", folder_find, False)
        historyNode.AddAction("View Notes", AddressOf ViewNote, "View the Note in Read-Only mode.", page_add, False)
        historyNode.AddAction("View Memos", AddressOf ViewMemo, "View the Memo in Read-Only mode.", page_add, False)
        historyNode.AddAction("View Drawing", AddressOf ViewJobDrawing, "View the Job Drawing in Read-Only mode.", picture, False)
        historyNode.AddAction("Check List Report", AddressOf ViewJobFinalInspectionReport, "View the Job Check List Report.", package, False)
        historyNode.AddAction("Test Bench Report", AddressOf ViewJobTestBenchReport, "View the JobTest Bench Report.", chart_curve, False)

        'Req for jobs testing
        'Dim hjfhr As Functions.JobFunction = Functions.JobFunction.GetHandler(API.JobFunction.Requisition)
        'If hjfhr IsNot Nothing Then
        '    Dim la As New Helper.ActiveRecord.LookupAction(Of API.Job)(hjfhr.Code, hjfhr.Glyph, AddressOf hjfhr.Process)
        '    la.Description = hjfhr.Description
        '    la.WrapInConversationalScope = False
        '    la.RequiresInstance = hjfhr.RequiresInstance
        '    historyNode.AdditionalActions.Add(la)
        'End If
        'Dim hjfhq As Functions.JobFunction = Functions.JobFunction.GetHandler(API.JobFunction.Quotation)
        'If hjfhq IsNot Nothing Then
        '    Dim la As New Helper.ActiveRecord.LookupAction(Of API.Job)(hjfhq.Code, hjfhq.Glyph, AddressOf hjfhq.Process)
        '    la.Description = hjfhq.Description
        '    la.WrapInConversationalScope = False
        '    la.RequiresInstance = hjfhq.RequiresInstance
        '    historyNode.AdditionalActions.Add(la)
        'End If

        Dim InvoiceNode = New Menu.ListNode(Of API.InvoiceRun, xlInvoiceRun)(money_dollar, "Invoice") With {.DisableDrilldown = True}
        ' Dim InvoiceNode = New Menu.ListNode(Of API.InvoiceRun, xuctest)(folder_explore, "Invoice") With {.DisableDrilldown = False}

        InvoiceNode.AddAction("Generate Invoice", AddressOf GenerateInvoice, "Generate Invoice.", picture, False, False)

        Dim PaymentRunNode = New Menu.ListNode(Of API.PaymentRun, xlPaymentRun)(money, "Payment") With {.DisableDrilldown = True}
        PaymentRunNode.AddAction("Generate Payment", AddressOf GeneratePayment, "Payment Run.", picture, False, False)

        sfEnquiriesMenu.AddChild(historyNode)
        If API.Context.Defaults.IsTimeSheetVersion = True Then
            sfEnquiriesMenu.AddChild(InvoiceNode)
            sfEnquiriesMenu.AddChild(PaymentRunNode)
        End If

        If API.Context.Defaults.IsTimeSheetVersion = False Then
            Dim preRequisitionCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
            preRequisitionCrit.CreateAlias("JobStage", "JobStage")
            'preRequisitionCrit.Add(NHibernate.Criterion.Expression.Eq("State", CInt(API.JobState.Active)))
            preRequisitionCrit.Add(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Active)))
            preRequisitionCrit.Add(NHibernate.Criterion.Expression.Eq("IsProcured", CBool(True)))
            preRequisitionCrit.Add(NHibernate.Criterion.Expression.Eq("JobStage.IsProcurement", CBool(True)))
            'Tawanda 
            Dim prerequisitionNode = New Menu.ListNode(Of API.Job, xlJob)(bricks, "Pre-Requisitions") With {.DisableDrilldown = True, .Criterion = preRequisitionCrit}
            prerequisitionNode.AddAction("Re-print_Pre-Requisition", AddressOf ReprintPreRequisition, "Re-print the Pre-Requisition.", page_white_edit, False)
            sfEnquiriesMenu.AddChild(prerequisitionNode)
        End If

        If API.Context.Defaults.IsTimeSheetVersion = False Then
            Dim requisitionCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Requisition)()
            requisitionCrit.CreateAlias("Job", "Job")
            'requisitionCrit.Add(NHibernate.Criterion.Expression.Eq("Job.State", CInt(API.JobState.Active)))
            requisitionCrit.Add(NHibernate.Criterion.Expression.Eq("Job.StateID", CInt(API.JobState.Active)))
            'Tawanda 
            Dim requisitionNode = New Menu.ListNode(Of API.Requisition, xlRequisition)(bricks, "Requisitions") With {.DisableDrilldown = True, .Criterion = requisitionCrit}
            requisitionNode.AddAction("Re-print_Requisition", AddressOf ReprintRequisition, "Re-print the Requisition.", page_white_edit, False)
            sfEnquiriesMenu.AddChild(requisitionNode)
        End If

        If API.Context.Defaults.IsTimeSheetVersion = False Then
            Dim deliveryNode = New Menu.ListNode(Of API.JobDelivery, xlJobDelivery)(lorry, "Deliveries") With {.DisableDrilldown = True}
            deliveryNode.AddAction("Re-print", AddressOf ReprintJobDelivery, "Re-print the Delivery Note.", page_white_edit, False)
            sfEnquiriesMenu.AddChild(deliveryNode)
        End If

        If API.Context.Defaults.IsTimeSheetVersion = False Then
            Dim quoteInActiveCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
            'quoteInActiveCrit.Add(NHibernate.Criterion.Expression.Lt("QuoteDate", Now.AddDays(-1 * API.Context.Defaults.ValidityDays.Value)))
            quoteInActiveCrit.Add(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.QuoteInactive)))
            Dim quoteInActiveNode = New Menu.ListNode(Of API.Job, xlJob)(folder_find, "Quote In-Active") With {.DisableDrilldown = True, .Criterion = quoteInActiveCrit}
            'quoteInActiveNode.AddAction("Add Quote", AddressOf AddQuotation, "Add a new Quotation.", folder_add, False, False)
            quoteInActiveNode.AddAction("ReActivateQuote", AddressOf RecalculateQuote, "ReActivate Quote", folder_add, False)
            'quoteInActiveNode.AddAction("Edit Quote", AddressOf EditQuotation, "Edit the Quotation.", folder_edit, False)
            'quoteInActiveNode.AddAction("Quotation", AddressOf MaintainQuotation, "Prepare and maintain the Quotation details.", folder_page_white, False)
            'quoteInActiveNode.AddAction("Convert To Job", AddressOf ConvertQuoteToJob, "Convert the Quotation to an Active Job.", folder_go, False)
            'quoteInActiveNode.AddAction("Comments", AddressOf AddQuotationComments, "Job Comments.", page_add, False, False)
            'quoteInActiveNode.AddAction("Drawing", AddressOf JobDrawings, "Edit the Job Drawing.", page_add, False, False)
            sfEnquiriesMenu.AddChild(quoteInActiveNode)
        End If

        'Dim cancelledNode = New Menu.ListNode(Of API.Job, xlJob)(page_white_find, "Cancelled") With {.DisableDrilldown = True}
        'sfEnquiriesMenu.AddChild(cancelledNode)

        'sfReportMenu.AddChild(New UniSource.Menu.ListNode(Of UniSource.ReportManager.Report)(GetType(UniSource.ReportManager.xaeReport), UniSource.Helper.GUI.My.Resources.report, "Manage Reports") With {.DisableDrilldown = True})

        Dim ReportLayoutNode = New Menu.ListNode(Of UniSource.ReportManager.Report, UniSource.ReportManager.xlReport)(report_picture, "Manage Reports") With {.DisableDrilldown = True}
        sfReportMenu.AddChild(ReportLayoutNode)

        'sfReportMenu.AddChild(New UniSource.Menu.ListNode(Of UniSource.ReportManager.ReportLayout)(GetType(UniSource.ReportManager.xaeReportLayout), UniSource.Helper.GUI.My.Resources.report_picture, "Manage Layouts") With {.DisableDrilldown = True})
        Dim ReportLayoutNode2 = New Menu.ListNode(Of UniSource.ReportManager.ReportLayout, UniSource.ReportManager.xlReportLayout)(report_picture, "Manage Layouts") With {.DisableDrilldown = True}
        sfReportMenu.AddChild(ReportLayoutNode2)



        sfReportMenu.AddChild(UniSource.ReportManager.ReportPreviewNode.GetAllReportNodes("Unisource.Shopfloor%"))

        'Dim reportNode As New UniSource.Menu.Node("Reports")
        '' sfReportMenu.AddChild(New UniSource.Menu.DialogNode(GetType(xfPrint), "Job List", UniSource.Helper.GUI.My.Resources.report))
        'reportNode.AddChild(New UniSource.Menu.DelegateNode(AddressOf PrintDamageAndFailure, "Damage And Failure", UniSource.Helper.GUI.My.Resources.report))
        'reportNode.AddChild(New UniSource.Menu.DelegateNode(AddressOf PrintInspection, "Inspection", UniSource.Helper.GUI.My.Resources.report))
        'reportNode.AddChild(New UniSource.Menu.DelegateNode(AddressOf PrintPO, "Purchase Order", UniSource.Helper.GUI.My.Resources.report))
        'reportNode.AddChild(New UniSource.Menu.DialogNode(GetType(xrDoscoPickingSlip), "Picking Slip", UniSource.Helper.GUI.My.Resources.report))
        'reportNode.AddChild(New UniSource.Menu.DelegateNode(AddressOf PrintPreRequisition, "Pre Requisition", UniSource.Helper.GUI.My.Resources.report))
        'reportNode.AddChild(New UniSource.Menu.DelegateNode(AddressOf PrintQuotation, "Quotation", UniSource.Helper.GUI.My.Resources.report))
        'reportNode.AddChild(New UniSource.Menu.DelegateNode(AddressOf PrintRequisition, "Requisition", UniSource.Helper.GUI.My.Resources.report))
        'reportNode.AddChild(New UniSource.Menu.DelegateNode(AddressOf PrintJobTolerances, "Tolerances", UniSource.Helper.GUI.My.Resources.report))

        sfAdministration.AddChild(UniSource.Security.GUI.Setup.GetMenu)

        sfMenu.AddChild(sfMaintenanceMenu)
        sfMenu.AddChild(sfTransactionMenu)
        sfMenu.AddChild(sfEnquiriesMenu)
        sfMenu.AddChild(sfReportMenu)
        'sfMenu.AddChild(reportNode)
        sfMenu.AddChild(sfAdministration)

        'sfMenu.AddChild(b2bNode)
        GetMenu.AddChild(sfMenu)

    End Function

    'Private Sub PrintDamageAndFailure()
    '    Try
    '        Dim lay As New UniSource.ReportManager.xfReportRunner(New xrDoscoDamageAndFailure, API.Job.PrintDamageAndFailure)
    '        lay.ShowReportPreviewDialogUsingDefaultLayout()
    '    Catch ex As Exception
    '        Log.logError("Error running report.", ex)
    '    End Try
    'End Sub

    'Private Sub PrintQuotation()
    '    Try
    '        Dim lay As New UniSource.ReportManager.xfReportRunner(New xrJobQuote, API.Job.FindAll)
    '        lay.ShowReportPreviewDialogUsingDefaultLayout()
    '    Catch ex As Exception
    '        Log.logError("Error running report.", ex)
    '    End Try
    'End Sub

    'Private Sub PrintRequisition()
    '    Try
    '        Dim lay As New UniSource.ReportManager.xfReportRunner(New xrDoscoRequisition, API.Requisition.PrintRequisition)
    '        lay.ShowReportPreviewDialogUsingDefaultLayout()
    '    Catch ex As Exception
    '        Log.logError("Error running report.", ex)
    '    End Try
    'End Sub

    'Private Sub PrintPreRequisition()
    '    Try
    '        Dim lay As New UniSource.ReportManager.xfReportRunner(New xrDoscoPrerequisition, API.Requisition.PrintPreRequisition)
    '        lay.ShowReportPreviewDialogUsingDefaultLayout()
    '    Catch ex As Exception
    '        Log.logError("Error running report.", ex)
    '    End Try
    'End Sub

    'Private Sub PrintInspection()
    '    Try
    '        Dim lay As New UniSource.ReportManager.xfReportRunner(New xrDoscoInspection, API.Job.PrintInspection)
    '        lay.ShowReportPreviewDialogUsingDefaultLayout()
    '    Catch ex As Exception
    '        Log.logError("Error running report.", ex)
    '    End Try
    'End Sub

    'Private Sub PrintPO()
    '    Try
    '        Dim lay As New UniSource.ReportManager.xfReportRunner(New xrDoscoPO, API.PurchaseOrder.PrintPO)
    '        lay.ShowReportPreviewDialogUsingDefaultLayout()
    '    Catch ex As Exception
    '        Log.logError("Error running report.", ex)
    '    End Try
    'End Sub

    'Private Sub PrintJobTolerances()
    '    Try
    '        Dim lay As New UniSource.ReportManager.xfReportRunner(New xrDoscoTolerances, API.JobTolerance.PrintJobTolerances)
    '        lay.ShowReportPreviewDialogUsingDefaultLayout()
    '    Catch ex As Exception
    '        Log.logError("Error running report.", ex)
    '    End Try
    'End Sub

    Public Overrides Sub SetTableVersions()
        MyBase.SetTableVersions()

        LatestTableVersions.Add("ussChecklist", 2)
        LatestTableVersions.Add("ussChecklistChecklistTasks", 1)
        LatestTableVersions.Add("ussChecklistLog", 3)
        LatestTableVersions.Add("ussChecklistTask", 2)
        LatestTableVersions.Add("ussChecklistTaskLog", 2)
        LatestTableVersions.Add("ussChecklistType", 1)
        LatestTableVersions.Add("ussSSLookup", 1)
        LatestTableVersions.Add("ussSSLookupValues", 1)
        LatestTableVersions.Add("ussSFPublicHoliday", 2)
        LatestTableVersions.Add("ussSFCommonLetter", 1)
        LatestTableVersions.Add("ussSFCostCentre", 1)
        LatestTableVersions.Add("ussSFDefaults", 30)
        LatestTableVersions.Add("ussSFDrawing", 2)
        LatestTableVersions.Add("ussSFFunction", 1)
        LatestTableVersions.Add("ussSFGeneration", 1)
        LatestTableVersions.Add("ussSFJob", 12)
        LatestTableVersions.Add("ussSFJobNote", 1)
        LatestTableVersions.Add("ussSFJobCategory", 1)
        LatestTableVersions.Add("ussSFJobFunctionControl", 1)
        LatestTableVersions.Add("ussSFJobLine", 8)
        LatestTableVersions.Add("ussSFJobStage", 5)
        LatestTableVersions.Add("ussSFJobStageFunction", 1)
        LatestTableVersions.Add("ussSFJobStageFieldPrompt", 2)
        LatestTableVersions.Add("ussSFJobStageReport", 3)
        LatestTableVersions.Add("ussSFJobStageTrigger", 2)
        LatestTableVersions.Add("ussSFJobStageChecklist", 1)
        LatestTableVersions.Add("ussSFJobTemplate", 3)
        LatestTableVersions.Add("ussSFJobTemplateLine", 2)
        LatestTableVersions.Add("ussSFJobType", 2)
        LatestTableVersions.Add("ussSFJobTypeStages", 1)
        LatestTableVersions.Add("ussSFJobTypeStageReport", 1)
        LatestTableVersions.Add("ussSFMake", 1)
        LatestTableVersions.Add("ussSFModel", 1)
        LatestTableVersions.Add("ussSFPart", 1)
        LatestTableVersions.Add("ussSFPartGroup", 1)
        LatestTableVersions.Add("ussSFRequisition", 1)
        LatestTableVersions.Add("ussSFRequisitionLine", 1)
        LatestTableVersions.Add("ussSFPurchaseOrder", 1)
        LatestTableVersions.Add("ussSFPurchaseOrderLine", 1)
        LatestTableVersions.Add("ussSFSupplyScope", 1)
        LatestTableVersions.Add("ussSFWorkCentre", 1)
        LatestTableVersions.Add("ussSFWorkCentreCategory", 1)
        LatestTableVersions.Add("ussSFJobDelivery", 1)
        LatestTableVersions.Add("ussSFEmployee", 1)
        LatestTableVersions.Add("ussSFCustomerCostCentre", 1)
        LatestTableVersions.Add("ussSSArtisan", 2)
        LatestTableVersions.Add("ussJobLineTimeAttachmentAttachment", 1)
        LatestTableVersions.Add("ussSFJobAttachment", 1)
        LatestTableVersions.Add("ussSFAudit", 1)
        LatestTableVersions.Add("ussSFAsset", 2)

        LatestTableVersions.Add("ussPermission", 1)
        LatestTableVersions.Add("ussPermissionSecurityOperations", 1)
        LatestTableVersions.Add("ussSecurityOperation", 1)
        LatestTableVersions.Add("ussSecurityOperationRelationships", 1)
        LatestTableVersions.Add("ussSystemTree", 1)
        LatestTableVersions.Add("ussUser", 1)
        LatestTableVersions.Add("ussUserGroup", 1)
        LatestTableVersions.Add("ussUserGroups", 1)
        LatestTableVersions.Add("ussUserPermissions", 1)
        LatestTableVersions.Add("ussUserGroupPermissions", 1)
        LatestTableVersions.Add("ussUserSystemTree", 1)
        LatestTableVersions.Add("ussSFEmployeeRate", 1)
        LatestTableVersions.Add("ussSFCustomer", 1)
        LatestTableVersions.Add("ussSFJobLineTime", 2)
        LatestTableVersions.Add("ussSFCustomerJobClass", 1)
        LatestTableVersions.Add("ussSFEmployeeQualification", 1)
        LatestTableVersions.Add("ussSFInvoiceLink", 1)
        LatestTableVersions.Add("ussSFInvoiceRun", 1)
        LatestTableVersions.Add("ussSFInvoiceRunline", 1)

        LatestTableVersions.Add("ussSFPaymentRun", 2)
        LatestTableVersions.Add("ussSFPaymentRunTypes", 2)
        LatestTableVersions.Add("ussSFCompanyBranch", 1)
        LatestTableVersions.Add("ussSFPaymentFrequency", 1)
        LatestTableVersions.Add("ussSFPaymentFrequencyTypes", 1)

        LatestTableVersions.Add("ussSFJobMemo", 1)
        LatestTableVersions.Add("ussSFJobMemoPhotograph", 1)
        LatestTableVersions.Add("ussSFCancelReasonCode", 1)

        LatestTableVersions.Add("ussSFTestBenchJobsTested", 1)
        LatestTableVersions.Add("ussSFTestBenchResultChart", 1)

        LatestTableVersions.Add("ussSFArchiveYear", 1)
        LatestTableVersions.Add("ussSFJobSupplierDeliveryNote", 1)
        LatestTableVersions.Add("ussSFProformaInvoice", 1)
        LatestTableVersions.Add("ussSFProformaInvoiceLine", 1)
        LatestTableVersions.Add("ussSFValidateProformaJobLines", 1)
        LatestTableVersions.Add("ussSFProformaInvoiceTrackingRep", 1)


        'B2B tables
        'LatestTableVersions.Add("ussB2BAudit", 1)
        'LatestTableVersions.Add("ussB2BImport", 1)
        'LatestTableVersions.Add("ussB2BImportDetail", 1)
        'LatestTableVersions.Add("ussB2BImportScript", 1)
        'LatestTableVersions.Add("ussB2BUpload", 1)
        'LatestTableVersions.Add("ussB2BUploadRow", 1)
        'LatestTableVersions.Add("ussB2BUploadColumn", 2)
        'LatestTableVersions.Add("ussB2BSchedule", 1)
        'LatestTableVersions.Add("ussB2BIntegrationMapping", 1)
        'LatestTableVersions.Add("ussB2BExportMapping", 2)
        'LatestTableVersions.Add("ussB2BExportRow", 1)
        'LatestTableVersions.Add("ussB2BExportDetail", 1)
        'LatestTableVersions.Add("ussB2BExportScript", 1)
        'LatestTableVersions.Add("ussB2BExportSchedules", 1)
        'LatestTableVersions.Add("ussB2BImportSchedules", 1)
        'LatestTableVersions.Add("ussB2BUploadSchedules", 1)
        'LatestTableVersions.Add("ussB2BIntegrationSchedules", 1)
        'LatestTableVersions.Add("ussB2BFTPMapping", 1)
        'LatestTableVersions.Add("ussB2BFTPHistory", 1)
        'LatestTableVersions.Add("ussB2BFTPSchedules", 1)
        'LatestTableVersions.Add("ussB2BFTPServer", 1)
        'LatestTableVersions.Add("sp_ussMoveRecord", 1)


        MyBase.SetTableVersions()

    End Sub



    Private Sub UploadMapping()
        Dim int As UniSource.B2B.DAL.Upload = UniSource.B2B.DAL.Upload.FindOne("Code", "TSU")
        If int IsNot Nothing Then
            Dim xaeu As New UniSource.B2B.GUI.xaeUpload
            xaeu.Record = int
            xaeu.ShowDialog()
        Else
            Log.logError("The upload mapping for ShopFloor TimeSheet Upload has not been created for this company, please contact your system Administrator.")
        End If
    End Sub

    Private Sub ImportMapping()
        Dim int As UniSource.B2B.DAL.Import = UniSource.B2B.DAL.Import.FindOne("Code", "TSI")
        If int IsNot Nothing Then
            Dim xaeu As New UniSource.B2B.GUI.xaeImport
            xaeu.Record = int
            xaeu.ShowDialog()
        Else
            Log.logError("The import mapping for ShopFloor  TimeSheet Import has not been created for this company, please contact your system Administrator.")
        End If
    End Sub

    Private Sub IntegrationMapping()
        Dim int As UniSource.B2B.DAL.IntegrationMapping = UniSource.B2B.DAL.IntegrationMapping.FindOne("Code", "TSU")
        If int IsNot Nothing Then
            Dim xaeu As New UniSource.B2B.GUI.xaeIntegration
            xaeu.Record = int
            xaeu.ShowDialog()
        Else
            Log.logError("The integration mapping for Time Sheet Integration  has not been created for this company, please contact your system Administrator.")
        End If
    End Sub

    Private Sub MaintainTemplate(ByVal templates As IEnumerable(Of API.JobTemplate))
        For Each t As API.JobTemplate In templates
            Dim xaejtq As New xaeJobTemplateQuote(t)
            xaejtq.Icon = Helper.GUI.Extensions.MakeIcon(Helper.GUI.My.Resources.page_white_edit)
            xaejtq.ShowDialog()
        Next
    End Sub

    Private Sub MaintainQuotation(ByVal quotes As IEnumerable(Of API.Job))
        Dim func As Functions.Quotation = Functions.JobFunction.GetHandler(API.JobFunction.Quotation)
        func.Process(quotes)
    End Sub

    Private Sub MaintainQuotationDiscount(ByVal quotes As IEnumerable(Of API.Job))
        Dim func As Functions.QuotationWithDiscount = Functions.JobFunction.GetHandler(API.JobFunction.QuotationDiscount)
        func.Process(quotes)
    End Sub

    Private Sub AddQuotationComments(ByVal quotes As IEnumerable(Of API.Job))
        Dim func As Functions.JobQuoteComments = Functions.JobFunction.GetHandler(API.JobFunction.JobComments)
        func.Process(quotes)
    End Sub
    Private Sub GenerateInvoice()
        Dim xaejl As New xaeGenerateInvoice With {.Record = New API.InvoiceRun() With {.EndDate = Now, .InvoiceDate = Now}}
        If xaejl.ShowDialog = DialogResult.OK Then

        End If
        
    End Sub

    Private Sub GeneratePayment()
        Dim xaepr As New xaeGeneratePayment With {.Record = New API.PaymentRun() With {.EndDate = Now, .PaymentDate = Now}}
        If xaepr.ShowDialog = DialogResult.OK Then

        End If

    End Sub

    Private Sub AddQuotation(ByVal quotes As IEnumerable(Of API.Job))
        Dim func As Functions.AddQuote = Functions.JobFunction.GetHandler(API.JobFunction.AddQuote)
        func.Process(quotes)
    End Sub

    Private Sub EditQuotation(ByVal quotes As IEnumerable(Of API.Job))
        Dim func As Functions.EditQuote = Functions.JobFunction.GetHandler(API.JobFunction.EditQuote)
        func.Process(quotes)
    End Sub

    Private Sub ConvertQuoteToJob(ByVal quotes As IEnumerable(Of API.Job))
        Dim func As Functions.ConvertQuoteToJob = Functions.JobFunction.GetHandler(API.JobFunction.ConvertQuoteToJob)
        func.Process(quotes)
    End Sub

    Private Sub JobDrawings(ByVal quotes As IEnumerable(Of API.Job))
        Dim func As Functions.JobDrawings = Functions.JobFunction.GetHandler(API.JobFunction.Drawing)
        func.Process(quotes)
    End Sub

    Private Sub JobProformaInvoice(ByVal quotes As IEnumerable(Of API.Job))
        Dim func As Functions.GenerateProformaInvoice = Functions.JobFunction.GetHandler(API.JobFunction.ProformaInvoice)
        func.Process(quotes)
    End Sub

    Private Sub ProformaInvTrackingRep(ByVal quotes As IEnumerable(Of API.Job))
        Dim func As Functions.ProformaInvTrackingRep = Functions.JobFunction.GetHandler(API.JobFunction.ProformaInvoiceTrackingReport)
        func.Process(quotes)
    End Sub

    Private Sub ViewJob(ByVal job As IEnumerable(Of API.Job))
        Dim func As Functions.ViewJob = Functions.JobFunction.GetHandler(API.JobFunction.ViewJob)
        func.Process(job)
    End Sub

    Private Sub ViewQuote(ByVal Quote As IEnumerable(Of API.Job))
        Dim func As Functions.ViewQuote = Functions.JobFunction.GetHandler(API.JobFunction.ViewQuote)
        func.Process(Quote)
    End Sub

    Private Sub ViewQuotation(ByVal job As IEnumerable(Of API.Job))
        Dim func As Functions.ViewQuotation = Functions.JobFunction.GetHandler(API.JobFunction.ViewQuotation)
        func.Process(job)
    End Sub

    Private Sub ViewNote(ByVal job As IEnumerable(Of API.Job))
        Dim func As Functions.ViewNotes = Functions.JobFunction.GetHandler(API.JobFunction.ViewNote)
        func.Process(job)
    End Sub

    Private Sub ViewMemo(ByVal job As IEnumerable(Of API.Job))
        Dim func As Functions.ViewMemos = Functions.JobFunction.GetHandler(API.JobFunction.ViewMemo)
        func.Process(job)
    End Sub

    Private Sub CommonLetter(ByVal job As IEnumerable(Of API.Job))
        Dim func As Functions.Memo = Functions.JobFunction.GetHandler(API.JobFunction.Memo)
        func.Process(job)
    End Sub

    Private Sub ViewJobDrawing(ByVal job As IEnumerable(Of API.Job))
        Dim func As Functions.ViewJobDrawings = Functions.JobFunction.GetHandler(API.JobFunction.ViewDrawing)
        func.Process(job)
    End Sub

    Private Sub ViewJobFinalInspectionReport(ByVal job As IEnumerable(Of API.Job))
        Dim func As Functions.FinalInspectionReport = Functions.JobFunction.GetHandler(API.JobFunction.FinalInspectionReport)
        func.Process(job)
    End Sub

    Private Sub ViewJobTestBenchReport(ByVal job As IEnumerable(Of API.Job))
        Dim func As Functions.TestBench = Functions.JobFunction.GetHandler(API.JobFunction.TestBench)
        func.Process(job)
    End Sub

    Private Sub RecalculateQuote(ByVal recalculatequote As IEnumerable(Of API.Job))
        Dim func As Functions.RecalculateLinePrices = Functions.JobFunction.GetHandler(API.JobFunction.RecalculateLinePrices)
        func.Process(recalculatequote)
    End Sub

    Private Sub ReprintJobDelivery()
        Throw New NotImplementedException
    End Sub

    Private Sub ReprintRequisition(ByVal requisition As IEnumerable(Of API.Requisition))
        Dim jfc As API.JobFunctionControl
        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.JobFunctionControl)()
        crit.Add(NHibernate.Criterion.Expression.Eq("JobFunctionID", CInt(API.JobFunction.PreRequisitionRePrint)))
        jfc = API.JobFunctionControl.FindFirst(crit)

        If jfc IsNot Nothing Then
            If Not String.IsNullOrEmpty(jfc.Password) Then
                If Not Helper.GUI.Dialog.PromptPasswordDialog("Password", "Password") = jfc.Password Then
                    Setup.Log.logError("Incorrect password.")
                    Exit Sub
                End If
            End If
        End If
        Dim xrPR As New ShopFloor.Report.xrDoscoRequisition
        xrPR.RequisitionBindingSource.DataSource = requisition
        xrPR.ShowPreviewDialog()
    End Sub

    Private Sub RunReport(ByVal job As IEnumerable(Of API.Job))

    End Sub


    Private Sub PrintJobList(ByVal js As API.JobStage)
        'TODO: Fix job list print look at Audit trail
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        Dim ln As Menu.ListNode(Of API.Job, xlJob) = New Menu.ListNode(Of API.Job, xlJob)(page_white_gear, js.Description) With {.DisableDrilldown = True, .Criterion = crit}
        crit.Add(NHibernate.Criterion.Expression.Eq("JobStage", js))
        'crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("State", CInt(API.JobState.Active)), NHibernate.Criterion.Expression.Eq("State", CInt(API.JobState.Completed))))
        crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Active)), NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Completed))))


        Dim xrJL As New ShopFloor.Report.xrDoscoJobList
        xrJL.BindingSource1.DataSource = API.Job.FindAll(crit)
        xrJL.ShowPreviewDialog()
    End Sub

    Private Sub ReprintPreRequisition(ByVal job As IEnumerable(Of API.Job))
        Dim jfc As API.JobFunctionControl
        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.JobFunctionControl)()
        crit.Add(NHibernate.Criterion.Expression.Eq("JobFunctionID", CInt(API.JobFunction.PreRequisitionRePrint)))
        jfc = API.JobFunctionControl.FindFirst(crit)

        If jfc IsNot Nothing Then
            If Not String.IsNullOrEmpty(jfc.Password) Then
                If Not Helper.GUI.Dialog.PromptPasswordDialog("Password", "Password") = jfc.Password Then
                    Setup.Log.logError("Incorrect password.")
                    Exit Sub
                End If
            End If
        End If
        Dim xrPR As New ShopFloor.Report.xrDoscoPrerequisition
        xrPR.BindingSource1.DataSource = job
        xrPR.ShowPreviewDialog()
    End Sub

    Private Sub ShowChecklist(ByVal jobs As IEnumerable(Of API.Job))
        For Each j As API.Job In jobs
            Dim xfjc As New xfJobChecklist(j.JobStage.Checklists(0).Checklist, j)
            xfjc.ShowDialog()
        Next
    End Sub

End Class
