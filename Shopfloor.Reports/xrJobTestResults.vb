Imports DevExpress.XtraReports.UI

Public Class xrJobTestResults

    Private Sub xrsJobDrawingAnnotations_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
        'CType(sender, XRSubreport).ReportSource.DataSource = BindingSource1
        'CType(sender, XRSubreport).ReportSource.DataSource = BindingSource1.DataSource
        CType(sender, XRSubreport).ReportSource.DataSource = CType(JobBindingSource.DataSource, API.Job).JobDrawingAnnotations
    End Sub

    Private Sub xrsJobDrawingImage_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
        CType(sender, XRSubreport).ReportSource.DataSource = JobBindingSource
        'xrsJobDrawingImage.ReportSource.DataSource = BindingSource1.DataSource
    End Sub
End Class