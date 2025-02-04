Imports DevExpress.XtraReports.UI

Public Class xrJobDrawings

    Private Sub xrsJobDrawingAnnotations_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrsJobDrawingAnnotations.BeforePrint
        'CType(sender, XRSubreport).ReportSource.DataSource = BindingSource1
        'CType(sender, XRSubreport).ReportSource.DataSource = BindingSource1.DataSource
        CType(sender, XRSubreport).ReportSource.DataSource = CType(BindingSource1.DataSource, API.Job).JobDrawingAnnotations
    End Sub

    Private Sub xrsJobDrawingImage_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrsJobDrawingImage.BeforePrint
        CType(sender, XRSubreport).ReportSource.DataSource = BindingSource1
        'xrsJobDrawingImage.ReportSource.DataSource = BindingSource1.DataSource
    End Sub
End Class