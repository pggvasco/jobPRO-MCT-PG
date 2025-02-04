Public Class xfTemplateImportLookUp
    Private Property CLH As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Property EditValue As API.JobTemplate
    Public Property Recalculate As Boolean = True
    Public Property Record As API.Job

    Private Sub xfQouteImportLookUp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CLH = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        Try
            ' Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobTemplate)()
            ' crit.Add(NHibernate.Criterion.Expression.IsNotNull("QuoteNumber"))
            ' crit.Add(NHibernate.Criterion.Expression.Not(NHibernate.Criterion.Expression.Eq("QuoteNumber", "")))

            Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobTemplate)()
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("WorkCentreCategory", Record.WorkCentreCategory), NHibernate.Criterion.Expression.IsNull("WorkCentreCategory")))
            ' ql = New Helper.ActiveRecord.xfQuickLookup(Of API.JobTemplate)(API.JobTemplate.FindAll(crit), "TemplateNumber", "TemplateNumber", "Description1")


            JobBindingSource.DataSource = API.JobTemplate.FindAll(crit)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Job Template.", ex)
        End Try
    End Sub

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

    Private Sub cbRecalculateServiceItemPrice_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbRecalculateServiceItemPrice.CheckedChanged
        Recalculate = cbRecalculateServiceItemPrice.Checked
    End Sub
End Class