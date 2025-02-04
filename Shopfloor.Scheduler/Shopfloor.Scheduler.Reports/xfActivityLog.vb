Imports DevExpress.XtraReports.UI
Imports UniSource.Helper.GUI
Public Class xfActivityLog
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    ' Public Property CLU As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper


    Private Sub xfActivityLog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Dim al As New Helper.GUI.LookupBackgroundLoader(Of API.Artisan)(ArtisanLookUpEdit, AddressOf LoadArtisans)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Artisan.", ex)
        End Try

        Try
            Dim al As New Helper.GUI.LookupBackgroundLoader(Of API.Job)(JobLookUpEdit, AddressOf LoadJobs)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Job.", ex)
        End Try

        SetControlls()
    End Sub

    Private Function LoadArtisans() As IEnumerable(Of API.Artisan)
        Return API.Artisan.FindAll
    End Function

    Private Function LoadJobs() As IEnumerable(Of API.Job)
        Return API.Job.FindAll
    End Function


    Private Sub AllArtisansCheckEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AllArtisansCheckEdit.CheckedChanged
        SetControlls()
    End Sub

    Public Sub SetControlls()

        If AllJobsCheckEdit.Checked Then
            If AllArtisansCheckEdit.Checked Then
                ArtisanLookUpEdit.Enabled = False
            Else
                ArtisanLookUpEdit.Enabled = True
            End If
            FromDateDateEdit.Enabled = True
            ToDateDateEdit.Enabled = True
            AllArtisansCheckEdit.Enabled = True

            JobLookUpEdit.Enabled = False
        Else
            ArtisanLookUpEdit.Enabled = False
            FromDateDateEdit.Enabled = False
            ToDateDateEdit.Enabled = False
            AllArtisansCheckEdit.Enabled = False

            JobLookUpEdit.Enabled = True
        End If
    End Sub


    Private Sub AllJobsCheckEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AllJobsCheckEdit.CheckedChanged
        SetControlls()
    End Sub

    Private Sub btPreview_Click(sender As System.Object, e As System.EventArgs) Handles btPreview.Click
        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.ActivityLog)()
        

        If AllJobsCheckEdit.Checked = True Then
            If AllArtisansCheckEdit.Checked = False Then
                crit.Add(NHibernate.Criterion.Expression.Eq("Artisan", ArtisanLookUpEdit.EditValue))
            End If
            crit.Add(NHibernate.Criterion.Expression.Ge("StartDate", FromDateDateEdit.EditValue))
            crit.Add(NHibernate.Criterion.Expression.Le("StartDate", ToDateDateEdit.EditValue))
        Else
            crit.CreateAlias("Activity", "Activity")
            'crit.CreateAlias("Job", "Job")
            crit.Add(NHibernate.Criterion.Expression.Eq("Activity.Job", JobLookUpEdit.EditValue))
        End If

        Dim xrAL As New xrActivityLog
        xrAL.BindingSource1.DataSource = API.ActivityLog.FindAll(crit)
        xrAL.ShowPreviewDialog()

    End Sub
End Class