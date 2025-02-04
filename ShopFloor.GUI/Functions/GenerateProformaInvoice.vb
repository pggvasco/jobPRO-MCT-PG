Imports UniSource.ShopFloor.API
Imports UniSource.Helper.ActiveRecord
Imports UniSource.ShopFloor.Report
Imports DevExpress.XtraReports.UI

Namespace Functions


    Public Class GenerateProformaInvoice
        Inherits JobFunction
        Dim ProformaInvoiceNumber As String


        Protected Overrides Sub Action()
            Dim bc As New Helper.ActiveRecord.Checkout

            CreateSnapShot()
            Dim ProformaInvoiceCrit = NHibernate.Criterion.DetachedCriteria.For(Of ProformaInvoice)()
            ProformaInvoiceCrit.Add(NHibernate.Criterion.Expression.Eq("ProformaInvoiceNumber", ProformaInvoiceNumber))


            Dim ProformaInvoiceList As List(Of ProformaInvoice)
            Try
                ProformaInvoiceList = ProformaInvoice.FindAll(ProformaInvoiceCrit).ToList()
            Catch ex As Exception
                '  Throw New Exception(ex)
                ex = ex
            End Try

            Jobs(0).ProformaInvoices = ProformaInvoiceList

            Dim xrPRs As New ShopFloor.Report.xrDoscoProformaInvoice
            xrPRs.JobBindingSource.DataSource = Jobs(0)
            xrPRs.ShowPreviewDialog()

        End Sub

        Public Function CreateSnapShot() As Integer

            Dim ProformaExists As Integer
            Dim comparecount As Integer
            Dim LatestProformaID As Integer

            '            Dim newpf As New ProformaInvoice()

            ' get the last proforma invoice number
            ProformaExists = Pastel.Evolution.DatabaseContext.ExecuteCommandScalar _
                    (String.Format( _
                            "SELECT case when count(*) is null then 0 else count(*) end as Count from ussSFProformaInvoice WHERE JobID = {0}", Jobs(0).ID))

            If ProformaExists > 0 Then
                'Get Latest Proforma Line Number for Job Card

                LatestProformaID = Pastel.Evolution.DatabaseContext.ExecuteCommandScalar _
                   (String.Format( _
                           "SELECT Top 1 ID from ussSFProformaInvoice WHERE JobID = {0} order by id desc", Jobs(0).ID))

                'Compare Job Card to latest proforma lines
                comparecount = Pastel.Evolution.DatabaseContext.ExecuteCommandScalar _
                        (String.Format( _
                                "  Exec ussSFValidateProformaJobLines {0} , {1} ", Jobs(0).ID, LatestProformaID))

                'If compare count is greater than 0 then create a new ProformaInvoice Number and add the lines for that JobID
                If comparecount > 0 Then
                    Dim Ver As String = Pastel.Evolution.DatabaseContext.ExecuteCommandScalar _
                    (String.Format("SELECT Version from ussSFProformaInvoice WHERE ID = {0}", LatestProformaID))

                    CreateNewProformaInvoice(CInt(Ver))
                Else
                    'If not then generate using the existing lines
                    ProformaInvoiceNumber = Pastel.Evolution.DatabaseContext.ExecuteCommandScalar _
                   (String.Format("SELECT ProformaInvoiceNumber from ussSFProformaInvoice WHERE ID = {0}", LatestProformaID))

                End If
            Else
                'Create New proforma and take joblines
                CreateNewProformaInvoice(0)

            End If

        End Function

        Private Function CreateNewProformaInvoice(ByVal ProVersion As Integer)
            Dim ProInvoice As New ShopFloor.API.ProformaInvoice

            ProInvoice.Job = Jobs(0)

            ProInvoice.CreatedUserName = Agent.DisplayName
            ProInvoice.CreatedDateTime = Now

            ProInvoice.ProformaInvoiceNumber = Defaults.Defaults.GetNextProformaInvoiceNumberAndIncrement()
            ProformaInvoiceNumber = ProInvoice.ProformaInvoiceNumber

            If ProVersion = 0 Then
                ProInvoice.Version = 1
            Else
                ProInvoice.Version = ProVersion + 1
            End If

            ProInvoice.SaveAndFlush()

            'Get all Job lines for Job and Insert into DB
            Dim JobLineCrit = NHibernate.Criterion.DetachedCriteria.For(Of JobLine)()
            JobLineCrit.Add(NHibernate.Criterion.Expression.Eq("Job", Jobs(0)))


            Dim JobLineList As List(Of JobLine)
            Try
                JobLineList = JobLine.FindAll(JobLineCrit).ToList()
            Catch ex As Exception
                '  Throw New Exception(ex)
                ex = ex
            End Try

            For Each jl As JobLine In JobLineList
                Dim PIL As New ProformaInvoiceLine
                PIL.ProformaInvoice = ProInvoice
                PIL.JobLineID = jl.ID
                PIL.InventoryItemID = jl.InventoryItemID
                PIL.Quantity = jl.Quantity
                PIL.UnitPriceBeforeDiscount = jl.UnitPriceBeforeDiscount
                PIL.UnitPrice = jl.UnitPrice
                PIL.LineDiscountPercent = jl.LineDiscountPercent
                PIL.TotalPrice = jl.TotalPrice
                PIL.Save()

            Next
        End Function


        Public Overrides ReadOnly Property Code As String
            Get
                Return "Generate Proforma Invoice"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Generate Proforma Invoice"
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.brick
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.ProformaInvoice
            End Get
        End Property

    End Class

End Namespace