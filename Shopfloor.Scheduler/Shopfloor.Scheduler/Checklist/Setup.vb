Imports UniSource.Menu

Public Class Setup
    Inherits UniSource.LogOn.Evolution.Setup

    Shared Shadows Sub Main()
        _setup = New Setup
        _setup.MainForm = New UniSource.Menu.xfMain With {.Text = "UniSource Shopfloor Scheduler"}
        _setup.CallFromMain()
    End Sub

    Public Overrides Sub InitiliaseDatabase()
        MyBase.InitiliaseDatabase()
        Me.ARHelper.AddAssembly(GetType(API.awChecklistHelper).Assembly)
    End Sub

    Public Overrides Sub InitialiseMenu()
        MyBase.InitialiseMenu()

        EvolutionHelper = New UniSource.Helper.Evolution.Helper(UniSource.Setup.Settings.ActiveConnection)
        EvolutionHelper.ActivateEvolution()

        CType(Me.MainForm, xfMain).MainNode = GetMenu()
    End Sub

    Public Function GetMenu() As INode

    End Function

    Public Overrides Sub SetTableVersions()
        LatestTableVersions.Add("ussChecklist", 1)
        LatestTableVersions.Add("ussChecklistChecklistTasks", 1)

        LatestTableVersions.Add("ussChecklistLog", 1)
        LatestTableVersions.Add("ussChecklistTask", 1)

        LatestTableVersions.Add("ussChecklistTaskLog", 1)
        LatestTableVersions.Add("ussChecklistType", 1)
    End Sub
End Class
