Namespace Functions
    Public Class Reports
        Inherits JobFunction

        Protected Overrides Sub Action()
            'For Each j As API.Job In Jobs
            '    Dim repPay As ReportManager.Report = ReportManager.Report.GetByReport(New Reports.xrPayment)
            '    If repPay IsNot Nothing Then
            '        bsiReports.AddItem(repPay.GetReportPreviewMenu(BarManager, Me.PaymentBatch))
            '    End If
            'Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Report"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Reports."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.Reports
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.report
            End Get
        End Property
    End Class
End Namespace
