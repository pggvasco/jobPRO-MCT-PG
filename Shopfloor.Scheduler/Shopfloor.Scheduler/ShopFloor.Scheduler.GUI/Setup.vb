Imports UniSource.Menu
Imports UniSource.Helper.GUI.My.Resources

Public Class Setup
    Inherits UniSource.LogOn.Evolution.Setup

    Shared Shadows Sub Main()
        _setup = New Setup
        _setup.MainForm = New UniSource.Menu.xfMain With {.Text = "UniSource Shopfloor Scheduler"}
        _setup.CallFromMain()
    End Sub

    Public Overrides Sub InitiliaseDatabase()
        MyBase.InitiliaseDatabase()
        Me.ARHelper.AddAssembly(GetType(API.awShopFloorHelper).Assembly)
        Me.ARHelper.AddAssembly(GetType(ReportManager.awReportRepositoryHelper).Assembly)
        Me.ARHelper.AddAssembly(GetType(Helper.ActiveRecord.GUI.awControlLayoutHelper).Assembly)
    End Sub

    Public Overrides Sub InitialiseMenu()
        MyBase.InitialiseMenu()

        EvolutionHelper = New UniSource.Helper.Evolution.Helper(UniSource.Setup.Settings.ActiveConnection)
        EvolutionHelper.ActivateEvolution()

        CType(Me.MainForm, xfMain).MainNode = GetMenu()
    End Sub

    Public Function GetMenu() As INode
        GetMenu = New Node("ShopFloor Scheduler", cog)

        Dim maintenanceMenu = New UniSource.Menu.Node("Maintenance", application_view_detail)
        maintenanceMenu.AddChild(New ListNode(Of API.Artisan)(xaeArtisan, Resources.user, "Artisans") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New DialogNode(xaeConfiguration, "Configuration", page_key))
        maintenanceMenu.AddChild(New DialogNode(xaeDefault, "Defaults", page_key))
        maintenanceMenu.AddChild(New ListNode(Of API.Drawings)(xaeDrawing, Resources.user, "Drawings") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.CostCentre)(xaeCostCentre, basket, "Cost Centres") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.Customer)(xaeCustomer, group, "Customers") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.Lookup)(xaeLookup, group, "Lookups") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.LookupValue)(xaeLookupValues, group, "LookupValues") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.MachineChecklist)(xaeMachineChecklist, lorry, "MachineChecklists") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.Machine)(xaeMachine, lorry, "Machines") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.OperationChecklist)(xaeOperationChecklist, brick, "OperationChecklists") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.Operation)(xaeOperation, brick, "Operations") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.Part)(xaePart, wrench, "Parts") With {.DisableDrilldown = True})
        maintenanceMenu.AddChild(New ListNode(Of API.ReasonCode)(xaeReason, wrench, "Reason") With {.DisableDrilldown = True})
       
        Dim transactionMenu = New UniSource.Menu.Node("Transactions", application_view_detail)

        Dim jobNode = New ListNode(Of API.Job, xucJobList)(cog, "Jobs") With {.DisableDrilldown = True}
        jobNode.AddAction("View Activities", Sub(jobs)
                                                 For Each j In jobs
                                                     CType(MainForm, Menu.xfMain).AddTab(New xucJobActivities(j), "jobActivities" & j.ID.ToString, String.Format("{0}", j.Number))
                                                 Next
                                             End Sub)
        transactionMenu.AddChild(jobNode)
        transactionMenu.AddChild(New DialogNode(xfActivityScan, "Activity Scan", transmit))
        transactionMenu.AddChild(New DialogNode(xfAssignJob, "Assign Job", transmit))
        transactionMenu.AddChild(New DialogNode(xfArtisanJobActivities, "Job Activities", transmit))
        transactionMenu.AddChild(New DialogNode(xfArtisanJob, "Artisan Job", transmit))
        transactionMenu.AddChild(New DialogNode(xfAssignNextOperation, "Assign Next Activity", transmit))
        ' transactionMenu.AddChild(New DialogNode(xfActivityControls, "Artisan Activity", transmit))
        transactionMenu.AddChild(New DialogNode(xfReasonSelect, "Reason", transmit))

        Dim calenderMenu = New UniSource.Menu.Node("Planning Board", calendar)
        calenderMenu.AddChild(New UniSource.Menu.ControlNode(Of xucEstimates)("Estimates", calendar_view_day))
        calenderMenu.AddChild(New UniSource.Menu.ControlNode(Of xucEstimates)("Actuals", calendar_view_week))

        Dim xr As Reports.xrJobActivities

        Dim reportMenu = New UniSource.Menu.Node("Reports", report)
        reportMenu.AddChild(New UniSource.Menu.ListNode(Of UniSource.ReportManager.Report)(GetType(UniSource.ReportManager.xaeReport), report_picture, "Manage Reports") With {.DisableDrilldown = True})
        reportMenu.AddChild(New UniSource.Menu.ListNode(Of UniSource.ReportManager.ReportLayout)(GetType(UniSource.ReportManager.xaeReportLayout), report_magnify, "Manage Layouts") With {.DisableDrilldown = True})
        reportMenu.AddChild(UniSource.ReportManager.ReportPreviewNode.GetAllReportNodes(GetType(Reports.xrJobActivities).Assembly.FullName))

        GetMenu.AddChild(maintenanceMenu)
        GetMenu.AddChild(transactionMenu)
        GetMenu.AddChild(calenderMenu)
        GetMenu.AddChild(reportMenu)
    End Function

    Public Overrides Sub SetTableVersions()
        LatestTableVersions.Add("ussReport", 1)
        LatestTableVersions.Add("ussReportLayout", 1)

        LatestTableVersions.Add("ussControl", 1)
        LatestTableVersions.Add("ussControlLayout", 1)

        LatestTableVersions.Add("ussSSActivity", 1)
        LatestTableVersions.Add("ussSSActivityLog", 1)
        LatestTableVersions.Add("ussSSArtisan", 1)
        LatestTableVersions.Add("ussSSConfiguration", 1)
        LatestTableVersions.Add("ussSSCostCentre", 1)
        LatestTableVersions.Add("ussSSCustomer", 1)
        LatestTableVersions.Add("ussSSJob", 1)
        LatestTableVersions.Add("ussSSMachine", 1)
        LatestTableVersions.Add("ussSSMachineArtisans", 1)
        LatestTableVersions.Add("ussSSOperation", 1)
        LatestTableVersions.Add("ussSSOperationArtisans", 1)
        LatestTableVersions.Add("ussSSOperationMachines", 1)
        LatestTableVersions.Add("ussSSPart", 1)

        'LatestTableVersions.Add("ussOperation", 1)
        'LatestTableVersions.Add("ussOperationRelationships", 1)
        'LatestTableVersions.Add("ussPermission", 1)
        'LatestTableVersions.Add("ussPermissionOperations", 1)
        'LatestTableVersions.Add("ussUser", 1)
        'LatestTableVersions.Add("ussUserGroup", 1)
        'LatestTableVersions.Add("ussUserGroups", 1)
        'LatestTableVersions.Add("ussUserPermissions", 1)

    End Sub

End Class
