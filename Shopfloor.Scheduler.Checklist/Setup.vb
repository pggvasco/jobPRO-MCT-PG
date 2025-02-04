Imports UniSource.Menu
Imports UniSource.Helper.GUI.My.Resources

Public Class Setup
    Inherits UniSource.LogOn.Evolution.Setup

    Shared Shadows Sub Main()
        _setup = New Setup
        _setup.MainForm = New UniSource.Menu.xfMain With {.Text = "UniSource Shopfloor Scheduler Checklists"}
        _setup.CallFromMain()
    End Sub

    Public Overrides Sub InitiliaseDatabase()
        MyBase.InitiliaseDatabase()
        Me.ARHelper.AddAssembly(GetType(API.awChecklistHelper).Assembly)
        Me.ARHelper.AddAssembly(GetType(Helper.ActiveRecord.GUI.awControlLayoutHelper).Assembly)
    End Sub

    Public Overrides Sub InitialiseMenu()
        MyBase.InitialiseMenu()

        EvolutionHelper = New UniSource.Helper.Evolution.Helper(UniSource.Setup.Settings.ActiveConnection)
        EvolutionHelper.ActivateEvolution()

        CType(Me.MainForm, xfMain).MainNode = GetMenu()
    End Sub

    Public Shared Function GetMenu() As INode
        GetMenu = New Node("Checklists")

        'Dim maintenanceMenu = New UniSource.Menu.Node("Maintenance")
        Dim cln = New ListNode(Of API.Checklist, xlChecklist)(UniSource.Helper.GUI.My.Resources.comments, "Checklists") With {.DisableDrilldown = True}
        cln.AddAction("Log", UniSource.Helper.GUI.My.Resources.user_comment, Sub(cls As IEnumerable(Of API.Checklist))
                                                                                 For Each cl As API.Checklist In cls
                                                                                     CType(Setup.MainForm, Menu.xfMain).AddTab(New xucChecklist(cl), "cl" + cl.Code, cl.Code)
                                                                                 Next
                                                                             End Sub, False)
        GetMenu.AddChild(cln)
        GetMenu.AddChild(New ListNode(Of API.ChecklistOption, xlChecklistOption)(UniSource.Helper.GUI.My.Resources.comment, "Options") With {.DisableDrilldown = True})
        GetMenu.AddChild(New ListNode(Of API.ChecklistType, xlChecklistType)(UniSource.Helper.GUI.My.Resources.comment_edit, "Types") With {.DisableDrilldown = True})
        GetMenu.AddChild(New ListNode(Of API.Lookup, xlLookup)(UniSource.Helper.GUI.My.Resources.table, "Lookups") With {.DisableDrilldown = True})
        GetMenu.AddChild(New ListNode(Of API.LookupValue, xlLookupValue)(UniSource.Helper.GUI.My.Resources.table_row_insert, "Values") With {.DisableDrilldown = True})
    End Function

    Public Overrides Sub SetTableVersions()
        LatestTableVersions.Add("ussChecklist", 1)
        LatestTableVersions.Add("ussChecklistChecklistTasks", 1)
        LatestTableVersions.Add("ussChecklistLog", 1)
        LatestTableVersions.Add("ussChecklistTask", 1)
        LatestTableVersions.Add("ussChecklistTaskLog", 1)
        LatestTableVersions.Add("ussChecklistType", 1)
        LatestTableVersions.Add("ussSSLookup", 1)
        LatestTableVersions.Add("ussSSLookupValues", 1)
    End Sub
End Class
