Public Class ArtisanActivityRunner
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Private Property Artisan As API.Artisan
    Private Property CurrentActivity As API.Activity
    Private Property CurrentJob As API.Job
    Public Property CheckoutGuid As Guid
    Public Shared Property AssignArtisan As Boolean = False

    Public Sub Run()
        If showLogonScreen() Then
            Try
                showArtisanJobScreen()
            Catch ex As Exception
                UniSource.Logging.Log.Log.logError("Error performing operation.", ex)
                showLogonScreen()
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Public Function ShowLogonScreen() As Boolean
        If API.Context.ArtisanLogOut Then
            Return False
        End If
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
                'TODO: must it say checklist not found?
                'UniSource.Logging.Log.Log.logWarn("Artisan machine checklist not found.")
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Public Function HasMachineChecklistAlreadyBeenCompletedForToday(ByVal checklist As Checklist.API.Checklist) As Boolean
        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of Checklist.API.ChecklistLog)()
        'crit.Add(NHibernate.Criterion.Expression.Sql(String.Format("CAST(FLOOR(CAST(StartDateTime AS FLOAT)) AS DATETIME) = '{0}'", New SqlTypes.SqlDateTime(Now.Date.ToString("dd MMMM yyyy")))))
        crit.Add(NHibernate.Criterion.Expression.Sql(String.Format("CAST(FLOOR(CAST(StartDateTime AS FLOAT)) AS DATETIME) = '{0}'", Now.Date.ToString("dd MMMM yyyy"))))
        crit.Add(NHibernate.Criterion.Expression.Eq("AgentID", Artisan.ID))
        crit.Add(NHibernate.Criterion.Expression.Eq("Checklist", checklist))
        Return UniSource.Checklist.API.ChecklistLog.FindAll(crit).Count > 0
    End Function

    Public Function HasActivityChecklistAlreadyBeenCompleted(ByVal checklist As Checklist.API.Checklist) As Boolean
        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of Checklist.API.ChecklistLog)()
        crit.Add(NHibernate.Criterion.Expression.Eq("RecordID", currentActivity.ID))
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
            'TODO: must it say checklist not found?
            'UniSource.Logging.Log.Log.logWarn("Activity Operation checklist not found.")
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
        frmArtisanJobs.Conversation = Me.Conversation
        If frmArtisanJobs.ShowDialog = DialogResult.OK Then
            CurrentJob = frmArtisanJobs.selectedJob

            'Conversation.Restart()
            'Conversation.Dispose()
            'Conversation.Flush()

            If xfArtisanJobs.AssignArtisan Then
                    ''CurrentActivity = (From act As API.Activity In API.Activity.FindAll Where act.CurrentState <> API.ControlScan.Stop And act.Job = CurrentJob And act.Operation.AllowArtisanToAssign = True And act.ActivityLogList.Count = 0).First
                    xfActivityList.Text = String.Format("Unassigned-{0}", xfActivityList.Text)
                    If HasMultipleUnassignedActivities() Then
                        ShowCurrentUnAssignedJobActivities()
                    End If
                Else
                    If HasMultipleActivitiesForArtisan() Then
                        ShowCurrentJobActivities()
                    Else

                        CurrentActivity = (From act As API.Activity In Artisan.ActiveActivityList Where act.CurrentState <> API.ControlScan.Stop And act.Job = CurrentJob).First

                        If ShowActivityChecklist() Then
                            ShowActivityControlScreen()
                        Else
                            ShowArtisanJobScreen()
                        End If
                    End If
                End If
        Else
            If xfArtisanJobs.AssignArtisan = True Then
                xfArtisanJobs.AssignArtisan = False
                Artisan.RefreshActiveActivityList()
                ShowArtisanJobScreen()
            End If
            If frmArtisanJobs.DialogResult = DialogResult.Retry Then
                ShowArtisanJobScreen()
            Else
                Run()
            End If
            End If
    End Sub

    Public Function HasMultipleActivitiesForArtisan() As Boolean
        Return (From act As API.Activity In Artisan.ActiveActivityList Where act.CurrentState <> API.ControlScan.Stop And act.Job = CurrentJob).Count > 0
    End Function
    Public Function HasMultipleUnassignedActivities() As Boolean
        Return (From act As API.Activity In CurrentJob.Activities Where act.CurrentState <> API.ControlScan.Stop And act.Job = CurrentJob).Count > 0
    End Function

    Public Sub ShowCurrentJobActivities()
        Dim frm As New xfActivityList
        frm.Conversation = Me.Conversation
        frm.Artisan = Me.Artisan
        frm.Job = CurrentJob

        If frm.ShowDialog = DialogResult.OK Then
            currentActivity = frm.Activity
            If showActivityChecklist() Then
                ShowActivityControlScreen()
            Else
                ShowCurrentJobActivities()
            End If
        Else
            showArtisanJobScreen()
        End If
    End Sub
    Public Sub ShowCurrentUnAssignedJobActivities()
        Dim frm As New xfActivityList
        frm.Conversation = Me.Conversation
        frm.Artisan = Me.Artisan
        frm.Job = CurrentJob
        frm.Text = String.Format("Unassigned-{0}", frm.Text)

        If frm.ShowDialog = DialogResult.OK Then
            CurrentActivity = frm.Activity
            If ShowActivityChecklist() Then
                ShowAssignActivityControlScreen()
            Else
                ShowCurrentUnAssignedJobActivities()
            End If
        Else
            ShowArtisanJobScreen()
        End If
    End Sub

    Public Sub ShowActivityControlScreen()

        Dim frmControls As New xfControlScreen
        Me.Conversation.Restart()
        Me.Conversation.Flush()
        Me.Conversation.Dispose()

        frmControls.ActiveActivity = CurrentActivity
        frmControls.ShowDialog()
        If frmControls.NextArtisan IsNot Nothing Then
            CurrentActivity.Artisan = frmControls.NextArtisan
            CurrentActivity.Save()
        End If
        If HasMultipleActivitiesForArtisan() Then
            ShowCurrentJobActivities()
        Else
            ShowArtisanJobScreen()
        End If

    End Sub
    Public Sub ShowAssignActivityControlScreen()

        'Dim Currenta = New API.Activity
        Dim dialogue = UniSource.Helper.GUI.Dialog.YesNoDialog("Are sure you want to assign this activity to yourself", "Assign Activity To Yourself")
        If dialogue = DialogResult.Yes Then
            'Conversation.Restart()
            ''Conversation.Dispose()
            Using c As New Castle.ActiveRecord.ConversationalScope(Conversation)
                CurrentActivity.Artisan = API.Artisan.Find(Artisan.ID)
                CurrentActivity.IsNextActivity = True
                Try
                    CurrentActivity.SaveAndFlush()
                Catch ex As Exception

                End Try

            End Using
            Conversation.Flush()
            Conversation.Restart()
            Dim frmControls As New xfControlScreen
            frmControls.Conversation = Me.Conversation
            frmControls.ActiveActivity = CurrentActivity
            frmControls.ShowDialog()

            If frmControls.NextArtisan IsNot Nothing Then
                CurrentActivity.Artisan = frmControls.NextArtisan
                CurrentActivity.Save()
            End If
        End If
        If HasMultipleUnassignedActivities() Then
            ShowCurrentUnAssignedJobActivities()
        Else
            ShowArtisanJobScreen()
        End If

    End Sub


    'Public Sub ShowCurrentActivitieValidArtisans()
    '    Dim frm As New xfArtisanList
    '    frm.Artisan = Me.Artisan
    '    frm.CurrentArtisan = Me.Artisan
    '    frm.Job = CurrentJob
    '    frm.Activity = CurrentActivity

    '    If frm.ShowDialog = DialogResult.OK Then
    '        If frm.Artisan <> frm.CurrentArtisan Then
    '            CurrentActivity.Artisan = frm.Artisan
    '            CurrentActivity.Save()
    '        End If
    '    End If

    '    ShowCurrentJobActivities()
    'End Sub

End Class
