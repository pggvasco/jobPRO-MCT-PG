Imports UniSource.Menu
Imports UniSource.Helper.GUI.My.Resources
Imports UniSource.Checklist.GUI

Public Class Setup
    Inherits UniSource.LogOn.Evolution.Setup
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Shared Property ArtisanLogon As Boolean = False
    Public Shared Property ExtendedAgent As Security.ActiveRecord.ExtendedAgent

    Shared Shadows Sub Main(ByVal args() As String)
            _setup = New Setup

            If args.Count > 0 Then
                Select Case args(0)
                    Case "\ArtisanLogon"
                    _setup.MainForm = New xfArtisanLogonPseudo
                    ArtisanLogon = True
                    _setup.IsAutoLogon = True
                End Select
            Else
                _setup.MainForm = New UniSource.Menu.xfMain With {.Text = "UniSource Shopfloor Scheduler"}
            End If
            _setup.CallFromMain()
    End Sub

    Private Sub CreateDesktopShortcutClick(ByVal arts As IEnumerable(Of API.Artisan))
        Dim sl As New UniSource.Helper.GUI.ShellShortcut(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, "UniSource Shopfloor Scheduler - Artisan Logon" & ".lnk"))
        sl.Arguments = "\ArtisanLogon"
        sl.WorkingDirectory = Windows.Forms.Application.StartupPath
        sl.Description = "UniSource Shopfloor Scheduler - Artisan Logon"
        sl.Path = Windows.Forms.Application.ExecutablePath
        sl.Save()
    End Sub

    Public Overrides Sub InitiliaseDatabase()
        MyBase.InitiliaseDatabase()
        Me.ARHelper.AddAssembly(GetType(Checklist.API.awChecklistHelper).Assembly)
        Me.ARHelper.AddAssembly(GetType(API.awShopFloorHelper).Assembly)
        Me.ARHelper.AddAssembly(GetType(ReportManager.awReportRepositoryHelper).Assembly)
        Me.ARHelper.AddAssembly(GetType(Helper.ActiveRecord.GUI.awControlLayoutHelper).Assembly)
        'ExtendedAgent = New Security.ActiveRecord.ExtendedAgent(UniSource.LogOn.Evolution.Setup.Agent)
        API.Context.Agent = UniSource.LogOn.Evolution.Setup.Agent
    End Sub

    Public Overrides Sub InitialiseMenu()
        MyBase.InitialiseMenu()

        EvolutionHelper = New UniSource.Helper.Evolution.Helper(UniSource.Setup.Settings.ActiveConnection)
        EvolutionHelper.ActivateEvolution()

        If TypeOf Me.MainForm Is UniSource.Menu.xfMain Then
            CType(Me.MainForm, xfMain).MainNode = GetMenu()
        End If
    End Sub

    Public Function GetMenu() As INode

        Dim AppVersionNumber As String = String.Format("{0}", My.Application.Info.Version.ToString)

        If (API.Context.Configuration.VersionNumber Is Nothing OrElse AppVersionNumber <> API.Context.Configuration.VersionNumber) AndAlso (API.Context.Agent.Name.Contains("Admin")) Then
            If UniSource.Helper.GUI.Dialog.YesNoDialog(String.Format("Version Number({0}) diffrent than current version({1}), update version number?", AppVersionNumber, API.Context.Configuration.VersionNumber)) = MsgBoxResult.Yes Then
                API.Context.Configuration.VersionNumber = AppVersionNumber
                API.Context.Configuration.SaveAndFlush()
            End If
        ElseIf AppVersionNumber <> API.Context.Configuration.VersionNumber Then
            UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Your version {1} is not valid please install latest version {0}.", API.Context.Configuration.VersionNumber, AppVersionNumber))
            Process.GetCurrentProcess.Kill()
        End If


        GetMenu = New Node("ShopFloor Scheduler", cog)

        Dim maintenanceMenu = New UniSource.Menu.Node("Maintenance", application_view_detail, True)
        maintenanceMenu.AddChild(New DialogNode(xaeConfiguration, "Defaults", page_key))

        Dim artisan As ListNode(Of API.Artisan, xlArtisan) = New ListNode(Of API.Artisan, xlArtisan)(Resources.user, "Artisans") With {.DisableDrilldown = True}
        artisan.AddAction("View Operations", Resources.user_comment, AddressOf ShowArtisanAssignedOperations, False)
        artisan.AddAction("Logon", Resources.user, AddressOf Run, False)
        artisan.AddAction("Create Desktop Shortcut", Resources.application_lightning, AddressOf CreateDesktopShortcutClick, False)
        maintenanceMenu.AddChild(artisan)

        maintenanceMenu.AddChild(Checklist.GUI.Setup.GetMenu)

        maintenanceMenu.AddChild(New ListNode(Of API.CostCentre, xlCostCentre)(basket, "Cost Centres") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.Customer, xlCustomer)(group, "Customers") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.Drawing, xlDrawing)(group, "Drawings") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.Machine, xlMachine)(lorry, "Machines") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.Operation, xlOperation)(brick, "Operations") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.Part, xlPart)(wrench, "Parts") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.ReasonCode, xlReason)(wrench, "Reason") With {.DisableDrilldown = True})

        Dim transactionMenu = New UniSource.Menu.Node("Transactions", application_view_detail, True)

        Dim activeJobsCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        activeJobsCrit.Add(NHibernate.Criterion.Expression.Eq("JobStateID", CType(API.JobState.Active, Integer)))

        Dim jobNode = New ListNode(Of API.Job, xucJobList)(cog, "Jobs") With {.DisableDrilldown = True, .Criterion = activeJobsCrit}
        jobNode.AddAction("View Activities", Sub(jobs)
                                                 For Each j In jobs
                                                     CType(MainForm, Menu.xfMain).AddTab(New xucJobActivities(j), "jobActivities" & j.ID.ToString, String.Format("{0}", j.Number))
                                                 Next
                                             End Sub)



        Dim plannerNode = New ListNode(Of API.Job, xucJobList)(cog, "Job Planner") With {.DisableDrilldown = True}

        transactionMenu.AddChild(jobNode)
        transactionMenu.AddChild(New DialogNode(xfAssignPrimaryArtisan, "Assign Job", transmit))
        transactionMenu.AddChild(New DialogNode(xfAssignOrphanParts, "Assign Orphan Parts", transmit))
        transactionMenu.AddChild(New DialogNode(xfAssignNextActivity, "Assign Next Activity", transmit))
        transactionMenu.AddChild(New DialogNode(xfActivityScan, "Activity Scan", transmit))

        Dim LogMenu = New UniSource.Menu.Node("Enquiries")
        LogMenu.AddChild(New UniSource.Menu.ListNode(Of API.QIR, xlQIR)(script, "QIR Log") With {.DisableDrilldown = True})
        LogMenu.AddChild(New ListNode(Of Checklist.API.ChecklistLog, xlSchedulerCheckListLog)(user_comment, "Checklist Log") With {.DisableDrilldown = False})

        Dim historyJobsCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        historyJobsCrit.Add(NHibernate.Criterion.Expression.Eq("JobStateID", CType(API.JobState.History, Integer)))

        Dim jobHistoryNode = New ListNode(Of API.Job, xucJobList)(cog, "Jobs History") With {.DisableDrilldown = True, .Criterion = historyJobsCrit}
        jobHistoryNode.AddAction("View Activities", Sub(jobs)
                                                        For Each j In jobs
                                                            CType(MainForm, Menu.xfMain).AddTab(New xucJobActivities(j), "jobActivities" & j.ID.ToString, String.Format("{0}", j.Number))
                                                        Next
                                                    End Sub)


        LogMenu.AddChild(jobHistoryNode)

        Dim archiveJobsCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        archiveJobsCrit.Add(NHibernate.Criterion.Expression.Eq("JobStateID", CType(API.JobState.Archive, Integer)))

        Dim jobArchiveNode = New ListNode(Of API.Job, xucJobList)(cog, "Jobs Archived") With {.DisableDrilldown = True, .Criterion = archiveJobsCrit}
        jobArchiveNode.AddAction("View Activities", Sub(jobs)
                                                        For Each j In jobs
                                                            CType(MainForm, Menu.xfMain).AddTab(New xucJobActivities(j), "jobActivities" & j.ID.ToString, String.Format("{0}", j.Number))
                                                        Next
                                                    End Sub)
        LogMenu.AddChild(jobArchiveNode)


        Dim calenderMenu = New UniSource.Menu.Node("Planning Board", application_view_detail, True)
        'calenderMenu.AddChild(New UniSource.Menu.ControlNode(Of xucEstimates)("Estimates", calendar_view_day))
        'calenderMenu.AddChild(New UniSource.Menu.ControlNode(Of xucEstimates)("Actuals", calendar_view_week))

        Dim xr As Reports.xrJobActivities

        Dim reportMenu = New UniSource.Menu.Node("Reports", report)
        reportMenu.AddChild(New DialogNode(GetType(UniSource.ShopFloor.Scheduler.Reports.xfActivityLog), "Activity Logs", page_key))
        reportMenu.AddChild(New UniSource.Menu.ListNode(Of UniSource.ReportManager.Report)(GetType(UniSource.ReportManager.xaeReport), report_picture, "Manage Reports") With {.DisableDrilldown = True})
        reportMenu.AddChild(New UniSource.Menu.ListNode(Of UniSource.ReportManager.ReportLayout)(GetType(UniSource.ReportManager.xaeReportLayout), report_magnify, "Manage Layouts") With {.DisableDrilldown = True})
        reportMenu.AddChild(UniSource.ReportManager.ReportPreviewNode.GetAllReportNodes(GetType(Reports.xrJobActivities).Assembly.GetName.Name))

        GetMenu.AddChild(maintenanceMenu)
        GetMenu.AddChild(transactionMenu)
        GetMenu.AddChild(LogMenu)
        GetMenu.AddChild(reportMenu)
    End Function

    Private Sub CompleteJob(ByVal Jobs As IEnumerable(Of API.Job))
        For Each j In Jobs
            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            j.JobState = API.JobState.History
            'j.SaveAndFlush()
            'End Using
        Next
    End Sub

    Public Sub Run()
        Try
            API.Context.ArtisanLogOut = False
            Dim runner As New ArtisanActivityRunner
            runner.Run()
        Catch ex As Exception
            Log.logError(ex.Message, ex)
        End Try
    End Sub

    Private Sub ShowArtisanAssignedOperations(ByVal art As IEnumerable(Of API.Artisan))
        Try
            Dim detail As List(Of API.Activity) = (From act As API.Activity In art(0).ActiveActivityList Where act.CurrentState <> API.ControlScan.Stop).ToList

            If detail.Count = 0 Then
                UniSource.Logging.Log.Log.logInfo(String.Format("There are no operations for '{0}'", art(0).Description), ex:=Nothing, showMsg:=True)
            Else
                Dim frmArtisanOperations As New xfAssignedArtisanOperations

                Try
                    frmArtisanOperations.Artisan = art(0)
                    frmArtisanOperations.ShowDialog()
                Catch ex As Exception
                    UniSource.Logging.Log.Log.logWarn(ex.Message, ex)
                End Try
            End If
        Catch ex As Exception
            UniSource.Logging.Log.Log.logWarn(ex.Message, ex)
        End Try
    End Sub

    Public Shared Sub ManageJobs()
        Dim xfsl As New UniSource.LogOn.Evolution.xfSimpleLogOn
        If xfsl.ShowDialog = DialogResult.OK Then
            Dim xfl As New DevExpress.XtraEditors.XtraForm
            Dim xlJob As New xlJob

            xlJob.AllowAdd = False
            xlJob.AllowDelete = False
            xlJob.AdditionalActions.Add(New Helper.ActiveRecord.LookupAction(Of API.Job)("Maintain", Sub(jobs)
                                                                                                         For Each j In jobs
                                                                                                             Dim xflj As New DevExpress.XtraEditors.XtraForm
                                                                                                             Dim xucj As New xucJobActivities(j)
                                                                                                             xucj.Dock = DockStyle.Fill
                                                                                                             xflj.Text = j.Number
                                                                                                             xflj.WindowState = FormWindowState.Maximized
                                                                                                             xflj.Controls.Add(xucj)
                                                                                                             xflj.ShowDialog()
                                                                                                         Next
                                                                                                     End Sub))
            xfl.Text = "Job List"
            xlJob.Dock = DockStyle.Fill
            xfl.WindowState = FormWindowState.Maximized
            xfl.Controls.Add(xlJob)
            xfl.ShowDialog()
        End If
    End Sub

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

        LatestTableVersions.Add("ussSSScheduleJobs", 1)

        LatestTableVersions.Add("ussSSActivity", 8)
        LatestTableVersions.Add("ussSSActivityLog", 2)
        LatestTableVersions.Add("ussSSArtisan", 4)
        LatestTableVersions.Add("ussSSConfiguration", 5)
        LatestTableVersions.Add("ussSSCostCentre", 1)
        LatestTableVersions.Add("ussSSCustomer", 1)
        LatestTableVersions.Add("ussSSDrawing", 1)
        LatestTableVersions.Add("ussSSJob", 3)
        LatestTableVersions.Add("ussSSLogonLog", 1)

        LatestTableVersions.Add("ussSSMachine", 1)
        LatestTableVersions.Add("ussSSMachineArtisans", 1)

        LatestTableVersions.Add("ussSSOperation", 2)
        LatestTableVersions.Add("ussSSOperationArtisans", 1)
        LatestTableVersions.Add("ussSSOperationMachines", 1)

        LatestTableVersions.Add("ussSSPart", 1)
        LatestTableVersions.Add("ussSSActivityQIR", 1)
        LatestTableVersions.Add("ussSSReasonCode", 2)

        LatestTableVersions.Add("ussSSActivityLogUpdate", 1)
        LatestTableVersions.Add("ussSSSTATISTICS", 1)

    End Sub

End Class
