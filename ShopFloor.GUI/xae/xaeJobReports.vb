Imports DevExpress.XtraReports.UI
Public Class xaeJobReports

    Private Sub LayoutControlItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LayoutControlItem4.Click

    End Sub

    Private Sub btPreviewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPreviewReport.Click
        Dim jfc As API.Job
        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        If IncludeQuotesComboBoxEdit.EditValue = API.RepReportQuoteTypes.Active Then
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Active)), NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Quote))))
        ElseIf IncludeQuotesComboBoxEdit.EditValue = API.RepReportQuoteTypes.Inactive Then
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Active)), NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.QuoteInactive))))
        ElseIf IncludeQuotesComboBoxEdit.EditValue = API.RepReportQuoteTypes.All Then
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Active)), NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.QuoteInactive)), NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Quote)))))
        Else
            crit.Add(NHibernate.Criterion.Expression.Eq("StateID", CInt(API.JobState.Active)))
        End If
        If ceRepresentative.Checked = False AndAlso IsNothing(RepresentativeIDLookUpEdit.EditValue) = False Then
            crit.Add(NHibernate.Criterion.Expression.Eq("RepresentativeID", CType(RepresentativeIDLookUpEdit.EditValue, Integer)))
        End If
        'crit.Add(NHibernate.Criterion.Expression.Eq("JobFunctionID", CInt(API.JobFunction.PreRequisitionRePrint)))
        If ReportTypeComboBoxEdit.EditValue = API.RepReportTypes.Standard Then
            Dim xrPR As New ShopFloor.Report.xrDoscoJobSalesRepresentativeList
            'Dim joblist As List(Of API.Job) = API.Job.FindAll(crit).ToList
            xrPR.BindingSource1.DataSource = API.Job.FindAll(crit)
            xrPR.ExportOptions.GetOptionVisibility(DevExpress.XtraPrinting.ExportOptionKind.XlsxExportMode)
            xrPR.ShowPreviewDialog()
        Else
            Dim xrPR As New ShopFloor.Report.xrDoscoJobSalesRepresentativeListNotes
            'Dim joblist As List(Of API.Job) = API.Job.FindAll(crit).ToList
            xrPR.BindingSource1.DataSource = API.Job.FindAll(crit)
            xrPR.ExportOptions.GetOptionVisibility(DevExpress.XtraPrinting.ExportOptionKind.XlsxExportMode)
            xrPR.ShowPreviewDialog()
        End If
    End Sub

    Private Sub ceRepresentative_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ceRepresentative.CheckedChanged
        If ceRepresentative.Checked Then
            RepresentativeIDLookUpEdit.Enabled = False
        Else
            RepresentativeIDLookUpEdit.Enabled = True
        End If
    End Sub

    Private Sub xaeJobReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim rbl As New Helper.Evolution.LookupLoader(Of Pastel.Evolution.SalesRepresentative)(RepresentativeIDLookUpEdit, SalesRepresentativeBindingSource, "idSalesRep")
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Sales Reps.", ex)
        End Try

        Try
            LoadEnums()
        Catch ex As Exception
            Setup.Log.logError("Error populating enums.", ex)
        End Try

        RepresentativeIDLookUpEdit.Enabled = False
    End Sub

    Private Sub LoadEnums()
        IncludeQuotesComboBoxEdit.Properties.DataSource = [Enum].GetValues(GetType(API.RepReportQuoteTypes))
        IncludeQuotesComboBoxEdit.EditValue = API.RepReportQuoteTypes.None
        ReportTypeComboBoxEdit.Properties.DataSource = [Enum].GetValues(GetType(API.RepReportTypes))
        ReportTypeComboBoxEdit.EditValue = API.RepReportTypes.Standard
    End Sub
End Class