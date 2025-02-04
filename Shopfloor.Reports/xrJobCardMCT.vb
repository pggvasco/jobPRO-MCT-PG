Imports DevExpress.XtraReports.UI

Public Class xrJobCardMCT
    Public Property _JOBID As Integer

    Private Sub xrsJobDrawingImage_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrsJobDrawingImage.BeforePrint
        Try
            CType(sender, XRSubreport).ReportSource.DataSource = DetailReportJobDrawing.DataSource
        Catch
        End Try
    End Sub


    Private Sub xrsJobDrawingAnnotations_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrsJobDrawingAnnotations.BeforePrint
        Try
            CType(sender, XRSubreport).ReportSource.DataSource = CType(BindingSource1.DataSource, API.Job).JobDrawingAnnotations

            'CType(sender, XRSubreport).ReportSource.DataSource = CType(DetailReport2.DataSource, API.Job).JobDrawingAnnotations
        Catch
        End Try
    End Sub

    Private Sub GroupHeader1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        Try
            xrlArticleNumber.Text = CType(BindingSource1.DataSource, API.Job).UserFields("ArticleNumber")
            xrlAuthorityNumber.Text = CType(BindingSource1.DataSource, API.Job).UserFields("AuthorityNumber")
            xrlCustomerReference.Text = CType(BindingSource1.DataSource, API.Job).UserFields("CustomerReference")
            xrlPRNumber.Text = CType(BindingSource1.DataSource, API.Job).UserFields("PRNumber")
            xrlSQNumber.Text = CType(BindingSource1.DataSource, API.Job).UserFields("SQNumber")
            xrlWaybillNo.Text = CType(BindingSource1.DataSource, API.Job).UserFields("WaybillNo")
            xrPartNumber.Text = CType(BindingSource1.DataSource, API.Job).UserFields("PartNumber")

            If CType(BindingSource1.DataSource, API.Job).Drawing Is Nothing Then
                DetailReportJobDrawing.Visible = False
            End If
        Catch
        End Try
    End Sub
End Class