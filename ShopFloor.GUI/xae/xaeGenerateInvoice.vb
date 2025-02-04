Imports System.Globalization
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports UniSource.Settings
Imports System.Threading
Imports Microsoft.Office.Interop
Public Class xaeGenerateInvoice
    Inherits xaegGenerateInvoice
    Public Property Hospitals As List(Of UniSource.Helper.ActiveRecord.Evolution.Client) = New List(Of UniSource.Helper.ActiveRecord.Evolution.Client)

    Private Sub LoadWeeknumbers()
        'Brits 20150422 - Changed week no to start from 4 weeks back and default to current week date
        Dim currentCulture = CultureInfo.CurrentCulture
        Dim WeekList As New List(Of String)
        Dim week As Integer = currentCulture.Calendar.GetWeekOfYear(DateTime.Now.AddDays(-28), currentCulture.DateTimeFormat.CalendarWeekRule.FirstFourDayWeek, currentCulture.DateTimeFormat.FirstDayOfWeek)
        Dim weeksAdded = 0

        For i As Integer = 0 To 8 Step 1
            '  Dim week As String = ciCurr.Calendar.GetWeekOfYear(DateTime.Now.AddDays(i * -7), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
            Dim weeknr As String = week & "/" & DateTime.Now.Year.ToString()
            'weeknr = weeknr.Replace("54/", "1/") 'for some reason 54 is in this loop, so we replace it
            week += 1
            WeekList.Add(weeknr.ToString)
            weeksAdded += 1
        Next i
        'WeekListLookUpEdit.EditValue = WeekList.FirstOrDefault

        ''now add another set of weeknumbers to the dropdownlist
        'Dim nextDate = New DateTime(DateTime.Now.Year - 1, 12, 27)
        'week = currentCulture.Calendar.GetWeekOfYear(nextDate, currentCulture.DateTimeFormat.CalendarWeekRule.FirstFourDayWeek, currentCulture.DateTimeFormat.FirstDayOfWeek)


        'For i As Integer = week To 1 Step -1
        '    If (weeksAdded < 53) Then
        '        '  Dim week As String = ciCurr.Calendar.GetWeekOfYear(DateTime.Now.AddDays(i * -7), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
        '        Dim weeknr As String = i & "/" & nextDate.Year.ToString()
        '        weeknr = weeknr.Replace("54/", "1/") 'for some reason 54 is in this loop, so we replace it
        '        WeekList.Add("Week: " & weeknr.ToString)
        '        weeksAdded += 1
        '    End If
        'Next i
        WeekListLookUpEdit.Properties.DataSource = WeekList
        'WeekListLookUpEdit.EditValue = WeekList.FirstOrDefault
        WeekListLookUpEdit.EditValue = currentCulture.Calendar.GetWeekOfYear(DateTime.Now, currentCulture.DateTimeFormat.CalendarWeekRule.FirstFourDayWeek, currentCulture.DateTimeFormat.FirstDayOfWeek) & "/" & DateTime.Now.Year.ToString()
    End Sub



    Private Sub xaeGenerateInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                ClientBindingSource.DataSource = UniSource.Helper.ActiveRecord.Evolution.Client.FindAll
            End Using

        Catch ex As Exception
            Setup.Log.logError("Error fetching Hospital list.", ex)
        End Try
        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                WardsBindingSource.DataSource = UniSource.Helper.ActiveRecord.Evolution.People.FindAll
            End Using

        Catch ex As Exception
            Setup.Log.logError("Error fetching Employee List.", ex)
        End Try
        LoadWeeknumbers()
        loaddefaults()
    End Sub
    Public Sub loaddefaults()
        'GET LAST SUNDAY
        Dim dLastSunday As Date = Now.AddDays(-(Now.DayOfWeek))
        InvoiceDateEdit.EditValue = Now
        StartDateEdit.EditValue = dLastSunday
        EndDateEdit.EditValue = Now
        'Brits 20150423 - default ProformaCheckEdit & IncludeStartDate to true
        ProformaCheckEdit.Checked = True
        IncludeStartDateCheckEdit.Checked = True
        Me.Record.InvoiceWeek = WeekListLookUpEdit.EditValue
    End Sub
    Protected Overrides Sub SaveClick(sender As Object, e As System.EventArgs)
        If Me.isInputValid Then

            If ProformaCheckEdit.Checked Then
                If InvoiceReport() Then
                    '
                    Me.Close()
                End If
            Else
                If InsertInvoiceRunHeader() Then
                    InsertSOHeader(Me.Record.ID)
                    Me.Close()
                End If
            End If
        End If

    End Sub
    Private Function InsertInvoiceRunHeader() As Boolean
        Dim IsSuccessfull As Boolean = True
        Try
            Me.Record.StartDate = StartDateEdit.EditValue
            Me.Record.InvoiceWeek = WeekListLookUpEdit.EditValue
            Me.Record.ExcludeDummy = DummyCheckEdit.EditValue
            Me.Record.SaveAndFlush()
            MyBase.SaveRecord()
        Catch ex As Exception
            IsSuccessfull = False
            Unisource.Helper.GUI.Dialog.OKDialog("Error Saving Invoice Run", "Error Saving InvoiceRun")
            Unisource.Logging.Log.Log.logError("Error Saving Invoice Run Header.", ex)
        End Try
        Return IsSuccessfull
    End Function

    ' Use this method if you want to automaically open
    ' the created XLS file in the default program.
    Public Sub StartProcess(ByVal path As String)
        Dim process As New Process()
        Try
            process.StartInfo.FileName = path
            process.Start()
            process.WaitForInputIdle()
        Catch
        End Try
    End Sub
    Private Sub InsertSOHeader(ByVal InvoiceRunID As Integer)
         Dim invoicerun = API.InvoiceRun.Find(CInt(InvoiceRunID))
        For Each hosp In Hospitals
            Dim IsSuccesfull As Boolean = True
            If Not API.JobLineTime.fetchTimeRecords(hosp, Record.StartDate, Record.EndDate, Me.IncludeStartDateCheckEdit.Checked) Then
                IsSuccesfull = False
                UniSource.Helper.GUI.Dialog.OKDialog(String.Format("No Records To Invoice is on Hospital:-{0}", hosp.Name), "No records Found To invoice on Hospital")
            End If
                Dim SO As New Pastel.Evolution.SalesOrder
                Dim InvoiceRunline As New API.InvoiceRunline

                SO.Customer = New Pastel.Evolution.Customer(CInt(hosp.ID))
                SO.Description = "Invoice"
            SO.InvoiceDate = InvoiceDateEdit.EditValue

            Try
                If IsSuccesfull = True Then
                    SO.Save()
                End If
            Catch ex As Exception
                IsSuccesfull = False
                Unisource.Helper.GUI.Dialog.OKDialog("Error Saving Sales Order", ex.Message)
                Unisource.Logging.Log.Log.logError("Error Saving SalesOrder.", ex)
            End Try

                If IsSuccesfull = True Then
                    InvoiceRunline.InvoiceID = SO.ID
                    InvoiceRunline.CustomerID = hosp.ID
                    InvoiceRunline.InvoiceRun = invoicerun
                    Try
                        invoicerun.InvoiceRunLines.Add(InvoiceRunline)
                    Catch ex As Exception
                    IsSuccesfull = False
                    Unisource.Helper.GUI.Dialog.OKDialog(String.Format("{0}-{1}", "Error Saving Invoice Run", ex.Message), "Error in Saving InvoiceRun Line")
                    Unisource.Logging.Log.Log.logError("Error Saving Invoice Run Line.", ex)

                    End Try
                End If
                Try
                    If IsSuccesfull = True Then
                    invoicerun.SaveAndFlush()
                    End If
                Catch ex As Exception
                    IsSuccesfull = False
                End Try

                If IsSuccesfull = True Then
                    For Each line As API.JobLineTime In API.JobLineTime.HospitalFetchedRecords
                        Dim soLine As New Pastel.Evolution.OrderDetail
                        Dim invoicelink As New API.InvoiceLink
                        soLine.InventoryItemID = line.InventoryItemID
                        soLine.Quantity = line.Quantity
                    soLine.UnitSellingPrice = line.InvoiceAmount
                    soLine.ToProcess = line.Quantity
                        SO.Detail.Add(soLine)
                    SO.Save()

                        invoicelink.JoblineTimeID = line.ID
                        invoicelink.InvoiceRunLine = InvoiceRunline
                        InvoiceRunline.Invoicelinks.Add(invoicelink)
                    InvoiceRunline.SaveAndFlush()
                    Next
                End If
            If IsSuccesfull = True Then
                Try
                    SO.Process()

                Catch ex As Exception
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("{0}-{1}", "Error Processing Sales Order", ex.Message), "Error in Processing Sales Order")
                    UniSource.Logging.Log.Log.logError("Error Processing Sales Order.", ex)
                    IsSuccesfull = False
                End Try
            End If
            Dim InvoiceType As String = "Invoice"
            If ProformaCheckEdit.Checked Then
                InvoiceType = "Pro-Forma"
            End If
            'Brits 20150422 - Changed dir format to include Type & Week no
            Dim savedir = String.Format("{0}\{1}\{2}\{3}\{4}\", API.Context.Defaults.FileSaveDefault, InvoiceType, Year(Me.Record.InvoiceDate), WeekListLookUpEdit.EditValue.ToString.Replace("/", "_"), hosp.Name)
            Dim PdfreportPath As String = String.Format("{0}{1}_{2}.pdf", savedir, hosp.Account, SO.Reference)
            Dim xlsreportPath As String = String.Format("{0}{1}_{2}.xls", savedir, hosp.Account, SO.Reference)
            Dim InvoiceRpt As UniSource.ShopFloor.Report.xrInvoiceReport = New UniSource.ShopFloor.Report.xrInvoiceReport
            Dim job = (From time As API.JobLineTime In API.JobLineTime.HospitalFetchedRecords).FirstOrDefault
            Dim customer = API.SFCustomer.FindAllByProperty("ERPCustomerID", hosp.ID).FirstOrDefault

            If IsSuccesfull Then
                Try
                    InvoiceRpt.DataSource = API.Job.FindAllByJobNumber(job.Job.JobNumber)
                    ' Get its XLS export options.
                    Dim pdfOptions As PdfExportOptions = InvoiceRpt.ExportOptions.Pdf
                    Dim xlsOptions As XlsExportOptions = InvoiceRpt.ExportOptions.Xls
                    ' Set XLS-specific export options.
                    'xlsOptions.ShowGridLines = True
                    ' xlsOptions.TextExportMode = TextExportMode.Value
                    ' Export the report to XLS.
                    InvoiceRpt.ExportToPdf(PdfreportPath, pdfOptions)
                    If customer.IncludeExcel Then
                        InvoiceRpt.ExportToXls(xlsreportPath, xlsOptions)

                    End If
                    ' Show the result.
                    'StartProcess(reportPath)
                    If customer.InvoicePrint Then
                        InvoiceRpt.ShowPreview()
                    End If
                Catch ex As Exception
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("{0}-{1}", "Error Saving Invoice invoice ", ex.Message), "Error in Saving invoice")
                    UniSource.Logging.Log.Log.logError("Error Sending Email.", ex)
                End Try
            End If

            If IsSuccesfull Then
                Try
                    If customer.InvoiceEmail Then
                        SendEmail(hosp.EMail, "InvoiceReport", Nothing, Nothing, MailPriority.Normal, PdfreportPath)
                    End If
                Catch ex As Exception
                    IsSuccesfull = False
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("{0}-{1}", "Error Sending Email For Invoice", ex.Message), "Error in Sending Email For Invoice")
                    UniSource.Logging.Log.Log.logError("Error Sending Email.", ex)

                End Try
            End If

            If IsSuccesfull = True Then
                For Each line As API.JobLineTime In API.JobLineTime.HospitalFetchedRecords
                    line.InvoiceRunOption = API.OptionInvoiceRun.Y
                    line.TimeSheetClosed = True
                    Try
                        line.SaveAndFlush()
                    Catch ex As Exception
                        IsSuccesfull = False
                        UniSource.Helper.GUI.Dialog.OKDialog(String.Format("{0}-{1}", "Error Updating Time lines for processed Sales Order", ex.Message), "Error Updating Time")
                        UniSource.Logging.Log.Log.logError("Error In Updating Time.", ex)

                    End Try

                Next

            End If


        Next

    End Sub

    Private Function InvoiceReport() As Boolean
        Dim IsAllSuccessful As Boolean = True
        For Each hosp In Hospitals
            Dim IsSuccessfull As Boolean = True
            Dim InvoiceType As String = "Invoice"
            If ProformaCheckEdit.Checked Then
                InvoiceType = "Pro-Forma"
            End If
            'Brits 20150422 - Changed dir format to include Type & Week no
            Dim savedir = String.Format("{0}\{1}\{2}\{3}\{4}", API.Context.Defaults.FileSaveDefault, InvoiceType, Year(Me.Record.InvoiceDate), WeekListLookUpEdit.EditValue.ToString.Replace("/", "_"), hosp.Name)
            If Not (Directory.Exists(savedir)) Then ' if directory doesnt exist create
                Try
                    Directory.CreateDirectory(savedir)
                Catch ex As Exception
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Can not Create Directory:-{0}", API.Context.Defaults.FileSaveDefault), "UnAble to create invoice Save Directory")
                    Exit Function
                End Try
            End If
            Dim PdfreportPath As String = String.Format("{0}\{1}_{2}.pdf", savedir, hosp.Account, Me.Record.InvoiceDate.Value.ToString("yyyyMMdd"))
            Dim XlsreportPath As String = String.Format("{0}\{1}_{2}.xls", savedir, hosp.Account, Me.Record.InvoiceDate.Value.ToString("yyyyMMdd"))
            Dim InvoiceRpt As UniSource.ShopFloor.Report.xrInvoiceReport = New UniSource.ShopFloor.Report.xrInvoiceReport
            Dim xlsOptions As XlsExportOptions = InvoiceRpt.ExportOptions.Xls
            Dim PDFOptions As PdfExportOptions = InvoiceRpt.ExportOptions.Pdf
            Dim customer = API.SFCustomer.FindAllByProperty("ERPCustomerID", hosp.ID).FirstOrDefault
            If Not customer.Proforma Then
                UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Proforma Invoice is set to No on Hospital:-{0}", hosp.Name), "Proforma not Activated on Hospital")
                Exit For
            End If
            Try
                If Not API.JobLineTime.fetchTimeRecords(hosp, Me.StartDateEdit.EditValue, Me.EndDateEdit.EditValue, Me.IncludeStartDateCheckEdit.Checked) Then
                    IsSuccessfull = False
                    IsAllSuccessful = False
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("No  Time Records to Invoice on Hospital:-{0}", hosp.Name), "No Time Records to Invoice")
                    Exit For
                End If
                If IsSuccessfull = True Then
                    Dim job = (From time As API.JobLineTime In API.JobLineTime.HospitalFetchedRecords).FirstOrDefault
                    InvoiceRpt.DataSource = API.Job.FindAllByJobNumber(job.Job.JobNumber)
                    InvoiceRpt.XrTaxInvoice.Text = "PROFORMA INVOICE"
                    InvoiceRpt.XrTaxInvoiceSummarry.Text = "PROFORMA INVOICE SUMMARY"
                    InvoiceRpt.XrTaxInvoiceBreakDown.Text = "PROFORMA INVOICE BREAKDOWN"
                    ' Get its XLS export options.
                    ' Set XLS-specific export options.
                    'xlsOptions.ShowGridLines = True
                    ' xlsOptions.TextExportMode = TextExportMode.Value
                    ' Export the report to XLS.
                    'InvoiceRpt.ExportToXls(reportPath)
                    'InvoiceRpt.ExportToPdf(reportPath)
                    InvoiceRpt.ExportToPdf(PdfreportPath, PDFOptions)
                    If customer.IncludeExcel Then
                        InvoiceRpt.ExportToXls(XlsreportPath, xlsOptions)
                    End If
                    ' Show the result.
                    'StartProcess(reportPath)
                    If customer.ProformaPrint Then
                        InvoiceRpt.ShowPreview()
                    End If
                End If
            Catch ex As Exception
                IsSuccessfull = False
                IsAllSuccessful = False
            End Try
            If IsSuccessfull Then
                Try
                    If customer.ProformaEmail Then
                        SendEmail(hosp.EMail, "Proforma Invoice Report", Nothing, Nothing, MailPriority.Normal, PdfreportPath)
                    End If
                Catch ex As Exception
                    IsSuccessfull = False
                    IsAllSuccessful = False
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("{0}-{1}", "Error Sending Email For Invoice", ex.Message), "Error in Sending Email For Invoice")
                    UniSource.Logging.Log.Log.logError("Error Sending Email.", ex)
                End Try
            End If
        Next

        Return IsAllSuccessful
    End Function

    Public Function SendEmail(ByVal ToEmail As String, ByVal Message As String, ByVal ex As Exception, Optional ByVal MessageLines As List(Of String) = Nothing, Optional ByVal MailPriority As MailPriority = MailPriority.Normal, Optional ByVal MailAttach As String = "") As String
        Dim tmpEmailBody = ""
        Try
            Dim Mail As New MailMessage

            Mail.Priority = MailPriority

            Mail.Subject = Message
            For Each ToEmail In Regex.Split(ToEmail, ";")
                'For Each ToEmail In Regex.Split("ClaudiusM@Unisource.co.za;claumoyo@gmail.com", ";")
                Mail.To.Add(ToEmail)
            Next
            Mail.From = New MailAddress(API.Context.Defaults.EmailFrom)
            ' Mail.From = New MailAddress("ClaudiusM@Unisource.co.za")

            Mail.Body += Message + vbCrLf
            Mail.Body += "" + vbCrLf

            If ex IsNot Nothing Then
                Mail.Body += "Error Message 1 :" + ex.Message + vbCrLf
                If ex.InnerException IsNot Nothing AndAlso ex.InnerException.Message IsNot Nothing Then
                    Mail.Body += "" + vbCrLf
                    Mail.Body += "Error Message 2 :" + ex.InnerException.Message + vbCrLf
                    Mail.Body += "" + vbCrLf
                End If
            End If


            Mail.Body += vbCrLf
            Mail.Body += vbCrLf
            Mail.Body += "Regards" + vbCrLf
            Mail.Body += "I.T. Department" + vbCrLf
            Mail.Body += "Unisource Software Services" + vbCrLf

            If MailAttach <> "" Then
                Dim oAttch As Mail.Attachment = New Mail.Attachment(MailAttach)
                Mail.Attachments.Add(oAttch)
            End If

            Mail.IsBodyHtml = False

            Dim SMTP As New SmtpClient(API.Context.Defaults.EmailSmtpClient)
            'Dim SMTP As New SmtpClient("Mail.unisource.co.za")

            SMTP.EnableSsl = CType(API.Context.Defaults.EmailEnableSsl, Boolean)
            'SMTP.EnableSsl = True

            SMTP.Credentials = New System.Net.NetworkCredential(API.Context.Defaults.EmailUserName, API.Context.Defaults.EmailPassword)
            'SMTP.Credentials = New System.Net.NetworkCredential("ClaudiusM@Unisource.co.za", "Greatkhali@1987!")

            SMTP.Port = CType(API.Context.Defaults.EmailPort, Integer)
            ' SMTP.Port = 25
            'so it does not check certificate
            ServicePointManager.ServerCertificateValidationCallback = Function(s As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) True
            SMTP.Send(Mail)
            tmpEmailBody = Mail.Body
        Catch exMail As Exception
            UniSource.Logging.Log.Log.logError("Error SendingEmail", exMail)
        End Try

        Return tmpEmailBody
    End Function


    Private Sub HospitalCheckedListBoxControl_ItemCheck(sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles HospitalCheckedListBoxControl.ItemCheck
        If e.State = Windows.Forms.CheckState.Checked Then
            If Not Hospitals.Contains(HospitalCheckedListBoxControl.GetItem(e.Index)) Then
                Hospitals.Add(HospitalCheckedListBoxControl.GetItem(e.Index))
            End If
        Else
            If Hospitals.Contains(HospitalCheckedListBoxControl.GetItem(e.Index)) Then
                Hospitals.Remove(HospitalCheckedListBoxControl.GetItem(e.Index))
            End If
        End If
    End Sub
    Private Function isInputValid() As Boolean
        Dim valid As Boolean = True
        If Hospitals.Count = 0 Then
            UniSource.Helper.GUI.Dialog.OKDialog("Kindly Select Hospital To invoice")
            valid = False
        End If
        If (StartDateEdit.EditValue > EndDateEdit.EditValue) Then
            StartDateEdit.ErrorText = "Start Date can not be less than End Date"
            valid = False
        End If
        Return valid
    End Function

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        '    If IsDBNull(InvoiceDateEdit.EditValue) Then
        '        InvoiceDateEdit.ErrorText = "Please Select an InvoiceDate"
        '    End If
        '    If (StartDateEdit.EditValue > EndDateEdit.EditValue) Then
        '        StartDateEdit.ErrorText = "Start Date can not be less than End Date"
        '    End If
        '    If Hospitals.Count = 0 Then
        '        UniSource.Helper.GUI.Dialog.OKDialog("Kindly Select Hospital To invoice")
        '    End If

        '    If errors IsNot Nothing Then
        '        MyBase.ValidationError(errors)
        '        For Each prop As Reflection.PropertyInfo In errors.Keys
        '            If prop.Name = "EndDate" Then
        '                EndDateEdit.ErrorText = errors(prop)(0)
        '            End If

        '        Next

        '    End If

        '    MyBase.ValidationError(errors)

    End Sub

   
   
    Private Sub IncludeStartDateCheckEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles IncludeStartDateCheckEdit.CheckedChanged
        StartDateEdit.Enabled = IncludeStartDateCheckEdit.Checked
    End Sub
End Class


Public Class xaegGenerateInvoice
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.InvoiceRun)
End Class
