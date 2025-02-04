Imports DevExpress.XtraReports.UI

Public Class xrDoscoQuotation

    Private Sub ReportHeader_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles ReportHeader.BeforePrint
        Try
            'xrlArticleNumber.Text = CType(BindingSource1.DataSource, API.Job).UserFields("ArticleNumber")
            'xrlAuthorityNumber.Text = CType(BindingSource1.DataSource, API.Job).UserFields("AuthorityNumber")
            'xrlCustomerReference.Text = CType(BindingSource1.DataSource, API.Job).UserFields("CustomerReference")
            'xrlPRNumber.Text = CType(BindingSource1.DataSource, API.Job).UserFields("PRNumber")
            'xrlSQNumber.Text = CType(BindingSource1.DataSource, API.Job).UserFields("SQNumber")
            'xrlWaybillNo.Text = CType(BindingSource1.DataSource, API.Job).UserFields("WaybillNo")
            'xrPartNumber.Text = CType(BindingSource1.DataSource, API.Job).UserFields("PartNumber")
            If CType(BindingSource1.DataSource, API.Job).Drawing Is Nothing Then
                DrawingDetailReport.Visible = False
            End If

            'CType(sender, XRSubreport).ReportSource.DataSource = BindingSource1.DataSource
            'CType(sender, XRSubreport).ReportSource.DataSource = BindingSource1.DataSource
        Catch
        End Try
    End Sub

    Private Sub xrsJobDrawingAnnotations_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrsJobDrawingAnnotations.BeforePrint
        'CType(sender, XRSubreport).ReportSource.DataSource = CType(BindingSource1.DataSource, API.Job).JobDrawingAnnotations
        Try
            CType(sender, XRSubreport).ReportSource.DataSource = CType(BindingSource1.DataSource, API.Job).JobDrawingAnnotations

            'CType(sender, XRSubreport).ReportSource.DataSource = CType(DetailReport2.DataSource, API.Job).JobDrawingAnnotations
        Catch
        End Try
    End Sub

    Private Sub xrsJobDrawingImage_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrsJobDrawingImage.BeforePrint
        'CType(sender, XRSubreport).ReportSource.DataSource = BindingSource1.DataSource
        Try
            CType(sender, XRSubreport).ReportSource.DataSource = DrawingDetailReport.DataSource
        Catch
        End Try
        'CType(sender, XRSubreport).ReportSource.DataSource = CType(DetailReport2.DataSource, API.Job).JobDrawingAnnotations
    End Sub
End Class