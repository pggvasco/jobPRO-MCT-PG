Namespace Functions

    Public Class QuotationTime
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j In Jobs
                Dim bc As New Helper.ActiveRecord.Checkout
                Try
                    Dim xaejq As New xaeJobQuoteTime(j)
                    ''check if job exists in evolution
                    'If Pastel.Evolution.JobCard.FindByCode(j.JobNumber) > 0 Then
                    '    Dim evolutionjob = New Pastel.Evolution.JobCard(j.JobNumber)
                    '    If evolutionjob.Status <> Pastel.Evolution.JobCard.JobStatus.Active Then
                    '        xaejq.AdditionalFieldsLayoutControlGroup.Enabled = False
                    '        xaejq.gvJobLines.OptionsBehavior.AllowAddRows = False
                    '        xaejq.gvJobLines.OptionsBehavior.AllowDeleteRows = False
                    '        xaejq.gvJobLines.OptionsBehavior.Editable = False
                    '        xaejq.bbiAddLine.Enabled = False
                    '        xaejq.bbiEditLine.Enabled = False
                    '        xaejq.bbiSave.Enabled = False
                    '        xaejq.bbiImportTemplate.Enabled = False
                    '        xaejq.bbiImportJob.Enabled = False
                    '        xaejq.bbiImportQuote.Enabled = False
                    '        xaejq.btSave.Visible = False
                    '    End If
                    'End If
                    If bc.AddCheckOut("Job", Jobs(0).ID) Then
                        xaejq.PerformBatchCheckout = True
                        xaejq.CheckoutGuid = bc.Checkout.GUID
                        xaejq.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                        xaejq.ShowDialog()
                        If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                            bc.RemoveCheckout(bc.Checkout.GUID)
                        End If
                        xaejq.gvJobLines.Dispose()
                        xaejq.BindingSource.Dispose()
                        xaejq.InventoryItemBindingSource.Dispose()
                        xaejq.WorkCentreBindingSource.Dispose()
                        xaejq.WorkCentreCategoryBindingSource.Dispose()
                        xaejq.PeopleBindingSource.Dispose()
                        xaejq.JobLineListBindingSource.Dispose()

                        xaejq.gvJobLines = Nothing
                        xaejq.BindingSource = Nothing
                        xaejq.InventoryItemBindingSource = Nothing
                        xaejq.WorkCentreBindingSource = Nothing
                        xaejq.WorkCentreCategoryBindingSource = Nothing
                       xaejq.JobLineListBindingSource = Nothing

                        xaejq.Dispose()
                        xaejq = Nothing
                        'GC.Collect()
                    End If
                Catch
                Finally
                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                        bc.RemoveCheckout(bc.Checkout.GUID)
                    End If
                End Try
            Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Time Entry"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Edit the Job Quotation Time ."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.QuotationTime
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_white_paint
            End Get
        End Property

    End Class

End Namespace

