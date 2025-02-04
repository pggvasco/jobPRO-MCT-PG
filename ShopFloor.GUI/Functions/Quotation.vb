Namespace Functions

    Public Class Quotation
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j In Jobs
                Dim bc As New Helper.ActiveRecord.Checkout
                Dim CheckedOut As Boolean = False
                Try
                    Dim xaejq As New xaeJobQuote(j)
                    'check if job exists in evolution
                    If Pastel.Evolution.JobCard.FindByCode(j.JobNumber) > 0 Then
                        Dim evolutionjob = New Pastel.Evolution.JobCard(j.JobNumber)
                        If evolutionjob.Status <> Pastel.Evolution.JobCard.JobStatus.Active Then
                            xaejq.AdditionalFieldsLayoutControlGroup.Enabled = False
                            xaejq.gvJobLines.OptionsBehavior.AllowAddRows = False
                            xaejq.gvJobLines.OptionsBehavior.AllowDeleteRows = False
                            xaejq.gvJobLines.OptionsBehavior.Editable = False
                            xaejq.bbiAddLine.Enabled = False
                            xaejq.bbiEditLine.Enabled = False
                            xaejq.bbiSave.Enabled = False
                            xaejq.bbiImportTemplate.Enabled = False
                            xaejq.bbiImportJob.Enabled = False
                            xaejq.bbiImportQuote.Enabled = False
                            xaejq.btSave.Visible = False
                        End If
                        evolutionjob = Nothing
                    End If
                    If bc.AddCheckOut("Job", Jobs(0).ID) Then
                        CheckedOut = True
                        xaejq.PerformBatchCheckout = True
                        xaejq.CheckoutGuid = bc.Checkout.GUID
                        xaejq.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                        xaejq.ShowDialog()
                        If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                            bc.RemoveCheckout(bc.Checkout.GUID)
                        End If
                    End If

                    xaejq.Close()

                    'xaejq.gvJobLines.Dispose()
                    'xaejq.BindingSource.Dispose()
                    'xaejq.StockItemBindingSource.Dispose()
                    'xaejq.WorkCentreBindingSource.Dispose()
                    'xaejq.WorkCentreCategoryBindingSource.Dispose()
                    'xaejq.VendorClassBindingSource.Dispose()
                    'xaejq.VendorBindingSource.Dispose()
                    'xaejq.SupplyScopeBindingSource.Dispose()
                    'xaejq.PartBindingSource.Dispose()
                    'xaejq.JobLineListBindingSource.Dispose()

                    'xaejq.gvJobLines = Nothing
                    'xaejq.BindingSource = Nothing
                    'xaejq.StockItemBindingSource = Nothing
                    'xaejq.WorkCentreBindingSource = Nothing
                    'xaejq.WorkCentreCategoryBindingSource = Nothing
                    'xaejq.VendorClassBindingSource = Nothing
                    'xaejq.VendorBindingSource = Nothing
                    'xaejq.SupplyScopeBindingSource = Nothing
                    'xaejq.PartBindingSource = Nothing
                    'xaejq.JobLineListBindingSource = Nothing

                    'xaejq.Dispose()

                    xaejq.Dispose()
                    xaejq = Nothing
                    'GC.Collect()

                Catch ex As Exception
                    Setup.Log.logError("Error Job Quatation Screen.", ex)
                Finally
                    If CheckedOut Then
                        If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                            bc.RemoveCheckout(bc.Checkout.GUID)
                        End If
                    End If
                End Try
                bc = Nothing
            Next

            GC.Collect()
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Job Card"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Edit the Job Card Lines."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.Quotation
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_white_paint
            End Get
        End Property

    End Class

End Namespace
