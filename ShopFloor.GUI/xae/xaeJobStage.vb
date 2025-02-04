Imports UniSource.ShopFloor.Scheduler

Public Class xaeJobStage
    Inherits xaegJobStage

    Private Sub xaeJobStage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetPermissions()
        Catch ex As Exception
            Setup.Log.logError("Error setting form permissions for agents.", ex)
        End Try
        Try
            LoadJobFunctions()
        Catch ex As Exception
            Setup.Log.logError("Error loading Job Functions.", ex)
        End Try

        Try
            LoadJobFields()
        Catch ex As Exception
            Setup.Log.logError("Error loading Job Fields.", ex)
        End Try

        Try
            Dim rlm As New Helper.ActiveRecord.LookupMaintenance(Of ReportManager.Report)(rilkpReport, GetType(ReportManager.xaeReport), AddressOf LoadReports, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting Reports Lookup Maintenance.", ex)
        End Try

        Try
            Dim cllm As New Helper.ActiveRecord.LookupMaintenance(Of Checklist.API.Checklist)(rilkpChecklist, GetType(Checklist.GUI.xaeChecklist), AddressOf LoadChecklists, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting Checklists Lookup Maintenance.", ex)
        End Try

    End Sub

    Private Sub SetPermissions()
        Dim gc As New UniSource.Security.ActiveRecord.GUIController(Me, Setup.ExtendedAgent.User)
    End Sub

    Protected Overrides Sub SetCLH()
        MyBase.SetCLH()
        CLH.Components.Add(DataLayoutControl)
    End Sub

    Private Function LoadReports() As IEnumerable(Of ReportManager.Report)
        Return ReportManager.Report.FindAll
    End Function

    Private Function LoadChecklists() As IEnumerable(Of Checklist.API.Checklist)
        Return Checklist.API.Checklist.FindAll
    End Function

    Private Sub LoadJobFunctions()
        rilkpJobFunction.DataSource = [Enum].GetValues(GetType(API.JobFunction))
        rilkpTrigger.DataSource = [Enum].GetValues(GetType(API.Trigger))
    End Sub

    Private Sub LoadJobFields()
        PropertyInfoBindingSource.DataSource = GetType(API.Job).GetProperties(Reflection.BindingFlags.Instance Or Reflection.BindingFlags.Public)
    End Sub

End Class

Public Class xaegJobStage
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.JobStage)
End Class
