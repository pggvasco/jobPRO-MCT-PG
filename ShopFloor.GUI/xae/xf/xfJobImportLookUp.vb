Public Class xfJobImportLookUp 
    Private Property CLH As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Property EditValue As API.Job
    Public Property Recalculate As Boolean = True


    Private Sub btOK_Click(sender As System.Object, e As System.EventArgs) Handles btOK.Click
        EditValue = lkpQuickLookup.EditValue
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btCancel_Click(sender As System.Object, e As System.EventArgs) Handles btCancel.Click
        Me.EditValue = Nothing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        lkpQuickLookup.Properties.DataSource = Nothing
        GC.Collect()
        Me.Close()
    End Sub

    Private Sub xfJobImportLookUp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CLH = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        Try
            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
            crit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Quote))))
            crit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.QuoteInactive))))
            crit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.None))))
            JobBindingSource.DataSource = API.Job.FindAll(crit)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Job Cards.", ex)
        End Try
    End Sub

    Private Sub cbRecalculateServiceItemPrice_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbRecalculateServiceItemPrice.CheckedChanged
        Recalculate = cbRecalculateServiceItemPrice.Checked
    End Sub
End Class