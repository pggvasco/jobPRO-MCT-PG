Imports UniSource.ShopFloor.API
Imports UniSource.Helper.ActiveRecord
Imports UniSource.ShopFloor.Report
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient
Imports UniSource.B2B.DAL


Namespace Functions

    Public Class ProformaInvTrackingRep
        Inherits JobFunction

        Protected Overrides Sub Action()
            Dim inv As New xfProformaInvDateRange()
            Dim dateTo As Date
            Dim dateFrom As Date

            inv.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)

            If inv.ShowDialog() = DialogResult.OK Then
                ' preview and print the report
                dateFrom = Date.Parse(inv.FromDateEdit.Text)
                dateTo = Date.Parse(inv.ToDateEdit.Text)

                Dim invprn As xrDoscoProformInvTrackingReport = New xrDoscoProformInvTrackingReport


                Dim dt As DataTable = Pastel.Evolution.DatabaseContext.ExecuteCommandDataTable(String.Format("exec ussSFProformaInvoiceTrackingRep '{0}','{1}'", dateFrom.ToString("dd MMMM yyyy"), dateTo.ToString("dd MMMM yyyy")))

                invprn.DataSource = dt
                invprn.ShowPreviewDialog()
            End If


        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Proforma Invoice Tracking"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Print the Proforma Invoice Tracking report"
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_white

            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                'Return API.JobFunction.ProformaInvoiceTrackingReport

            End Get
        End Property
    End Class


End Namespace