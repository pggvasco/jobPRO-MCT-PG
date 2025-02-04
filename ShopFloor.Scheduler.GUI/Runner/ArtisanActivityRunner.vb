'Imports UniSource.ShopFloor.Scheduler.Checklist
Public Class ArtisanActivityRunner

    Private Property Artisan As API.Artisan
    Private Property CurrentActivity As API.Activity
    Private Property CurrentJob As API.Job

    Public Sub Run()
        If ShowLogonScreen() Then
            Try
                ShowArtisanJobScreen()
            Catch ex As Exception
                UniSource.Logging.Log.Log.logError("Error performing operation.", ex)
                ShowLogonScreen()
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Public Function ShowLogonScreen() As Boolean
        Dim frmArtisanLogon As New xfArtisanLogon
        If frmArtisanLogon.ShowDialog() = DialogResult.OK Then
            Artisan = frmArtisanLogon.LoggedOnArtisan
            If Artisan.Machine IsNot Nothing AndAlso Artisan.Machine.Checklist IsNot Nothing Then
                If HasMachineChecklistAlreadyBeenCompletedForToday(Artisan.Machine.Checklist) Then
                    Return True
                Else
                    If ShowArtisanChecklist() Then
                        Return True
                    Else
                        Return ShowLogonScreen()
                    End If
                End If
            Else
                UniSource.Logging.Log.Log.logWarn("Artisan machine checklist not found.")
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Public Function HasMachineChecklistAlreadyBeenCompletedForToday(ByVal checklist As Checklist.API.Checklist) As Boolean
        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of Checklist.API.ChecklistLog)()
        crit.Add(NHibernate.Criterion.Expression.Sql(String.Format("CAST(FLOOR(CAST(StartDateTime AS FLOAT)) AS DATETIME) = '{0}'", New SqlTypes.SqlDateTime(Now.Date))))
        crit.Add(NHibernate.Criterion.Expression.Eq("AgentID", Artisan.ID))
        crit.Add(NHibernate.Criterion.Expression.Eq("Checklist", checklist))
        Return UniSource.Checklist.API.ChecklistLog.FindAll(crit).Count > 0
    End Function

    Public Function HasActivityChecklistAlreadyBeenCompleted(ByVal checklist As Checklist.API.Checklist) As Boolean
        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of Checklist.API.ChecklistLog)()
        crit.Add(NHibernate.Criterion.Expression.Eq("RecordID", CurrentActivity.ID))
        crit.Add(NHibernate.Criterion.Expression.Eq("AgentID", Artisan.ID))
        crit.Add(NHibernate.Criterion.Expression.Eq("Checklist", checklist))
        Return UniSource.Checklist.API.ChecklistLog.FindAll(crit).Count > 0
    End Function

    Public Function ShowArtisanChecklist() As Boolean
        Dim xfCheck As New xfChecklist(Artisan.Machine.Checklist)
        xfCheck.Checklist = Artisan.Machine.Checklist
        xfCheck.ChecklistControl.Log.AgentID = Artisan.ID
        xfCheck.ChecklistControl.Log.AgentName = Artisan.Description
        If xfCheck.ShowDialog() = DialogResult.OK Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ShowActivityChecklist() As Boolean
        If CurrentActivity.Operation.Checklist Is Nothing Then
            UniSource.Logging.Log.Log.logWarn("Activity Operation checklist not found.")
            Return True
        End If

        If HasActivityChecklistAlreadyBeenCompleted(CurrentActivity.Operation.Checklist) Then Return True

        Dim xfCheck As New xfChecklist(CurrentActivity.Operation.Checklist)
        xfCheck.Checklist = CurrentActivity.Operation.Checklist
        xfCheck.ChecklistControl.Log.RecordID = CurrentActivity.ID
        xfCheck.ChecklistControl.Log.AgentID = Artisan.ID
        xfCheck.ChecklistControl.Log.AgentName = Artisan.Description
        If xfCheck.ShowDialog = DialogResult.OK Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub ShowArtisanJobScreen()
        Dim frmArtisanJobs As New xfArtisanJobs
        frmArtisanJobs.Artisan = Artisan

        If frmArtisanJobs.ShowDialog = DialogResult.OK Then
            CurrentJob = frmArtisanJobs.selectedJob
            If HasMultipleActivitiesForArtisan() Then
                ShowCurrentJobActivities()
            Else
                CurrentActivity = (From act As API.Activity In Artisan.ActivityList Where act.CurrentState <> API.ControlScan.Stop And act.Job = CurrentJob).First
                If ShowActivityChecklist() Then
                    ShowActivityControlScreen()
                Else
                    ShowArtisanJobScreen()
                End If
            End If
        Else
            Run()
        End If
    End Sub

    Public Function HasMultipleActivitiesForArtisan() As Boolean
        Return (From act As API.Activity In Artisan.ActivityList Where act.CurrentState <> API.ControlScan.Stop And act.Job = CurrentJob).Count > 0
    End Function

    Public Sub ShowCurrentJobActivities()
        Dim frm As New xfActivityList
        frm.Artisan = Me.Artisan
        frm.Job = CurrentJob

        If frm.ShowDialog = DialogResult.OK Then
            CurrentActivity = frm.Activity
            If ShowActivityChecklist() Then
                ShowActivityControlScreen()
            Else
                ShowCurrentJobActivities()
            End If
        Else
            ShowArtisanJobScreen()
        End If
    End Sub

    Public Sub ShowActivityControlScreen()
        Dim frmControls As New xfControlScreen
        frmControls.ActiveActivity = CurrentActivity
        frmControls.ShowDialog()

        If HasMultipleActivitiesForArtisan() Then
            ShowCurrentJobActivities()
        Else
            ShowArtisanJobScreen()
        End If

    End Sub

End Class
