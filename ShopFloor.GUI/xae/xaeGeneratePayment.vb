Imports Microsoft.Office.Interop

Public Class xaeGeneratePayment
    Inherits xaegGeneratePayment

    Private Sub xaeGeneratePayment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                PaymentFrequencyBindingSource.DataSource = API.PaymentFrequency.FindAll()
            End Using

        Catch ex As Exception
            Setup.Log.logError("Error fetching Payment Run Types list.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                CompanyBranchBindingSource.DataSource = API.CompanyBranch.FindAll()
            End Using

        Catch ex As Exception
            Setup.Log.logError("Error fetching Company Branch list.", ex)
        End Try

        StartDateDateEdit.EditValue = Now
        EndDateDateEdit.EditValue = Now
    End Sub

    Protected Overrides Sub SaveClick(sender As Object, e As System.EventArgs)
        If Me.isInputValid Then
            If InsertPaymentRunHeader() Then
                ExportDataExcell(Me.Record.ID)
                Me.Close()
            End If
        End If

    End Sub

    Private Function isInputValid() As Boolean
        Dim valid As Boolean = True
        If PaymentFrequencyLookUpEdit.EditValue Is Nothing Then
            UniSource.Helper.GUI.Dialog.OKDialog("Kindly Select Payment Frequencye")
            valid = False
        End If
        If CompanyBranchLookUpEdit.EditValue Is Nothing Then
            UniSource.Helper.GUI.Dialog.OKDialog("Kindly Select Company")
            valid = False
        End If
        If (StartDateDateEdit.EditValue > EndDateDateEdit.EditValue) Then
            StartDateDateEdit.ErrorText = "Start Date can not be less than End Date"
            valid = False
        End If
        Return valid
    End Function

    Private Function InsertPaymentRunHeader() As Boolean
        Dim IsSuccessfull As Boolean = True
        Try
            Me.Record.StartDate = StartDateDateEdit.EditValue
            Me.Record.EndDate = EndDateDateEdit.EditValue
            Me.Record.CompanyBranch = CompanyBranchLookUpEdit.EditValue
            Me.Record.PaymentDate = Now()
            Me.Record.PaymentFrequency = PaymentFrequencyLookUpEdit.EditValue
            Me.Record.SaveAndFlush()
            MyBase.SaveRecord()
        Catch ex As Exception
            IsSuccessfull = False
            UniSource.Helper.GUI.Dialog.OKDialog("Error Saving Payment Run", "Error Saving Payment Run")
            UniSource.Logging.Log.Log.logError("Error Saving Payment Run Header.", ex)
        End Try
        Return IsSuccessfull
    End Function

    Private Sub ExportDataExcell(ByVal PaymentRunID As Integer)
        Dim Paymentrun = API.PaymentRun.Find(CInt(PaymentRunID))

        Dim IsSuccesfull As Boolean = True
        Dim temp As API.JobLineTime = New API.JobLineTime

        Dim PaymentTimeRecordsSuccess = temp.fetchPaymentTimeRecords(CType(CompanyBranchLookUpEdit.EditValue, API.CompanyBranch).Code, Record.StartDate, Record.EndDate, True, CType(PaymentFrequencyLookUpEdit.EditValue, API.PaymentFrequency).ERPPaymentFrequencyCode, CType(CompanyBranchLookUpEdit.EditValue, API.CompanyBranch).Code)
        Dim PaymentTimeRecords = temp.BranchFetchedRecords
        If Not PaymentTimeRecordsSuccess Then
            IsSuccesfull = False
            UniSource.Helper.GUI.Dialog.OKDialog(String.Format("No Records To Payment is on Branch:-{0}", CType(CompanyBranchLookUpEdit.EditValue, API.CompanyBranch).Code), "No records Found To Payment on Branch")
        End If

        'Add to Excell

        'If IsSuccesfull = True Then
        '    'PaymentRunline.InvoiceID = SO.ID
        '    'PaymentRunline.CustomerID = hosp.ID
        '    'PaymentRunline.InvoiceRun = invoicerun
        '    'Try
        '    '    invoicerun.InvoiceRunLines.Add(InvoiceRunline)
        '    'Catch ex As Exception
        '    '    IsSuccesfull = False
        '    '    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("{0}-{1}", "Error Saving Invoice Run", ex.Message), "Error in Saving InvoiceRun Line")
        '    '    UniSource.Logging.Log.Log.logError("Error Saving Invoice Run Line.", ex)

        '    'End Try
        'End If
        'Try
        '    If IsSuccesfull = True Then
        '        invoicerun.SaveAndFlush()
        '    End If
        'Catch ex As Exception
        '    IsSuccesfull = False
        'End Try

        If IsSuccesfull = True Then


            'Open Excell
            Dim objApp As Excel.Application
            Dim objBook As Excel._Workbook

            Dim objBooks As Excel.Workbooks
            Dim objSheets As Excel.Sheets
            Dim objSheet As Excel._Worksheet
            Dim range As Excel.Range

            Dim AtRow As Integer = 2

            objApp = New Excel.Application()
            objApp.Visible = True
            objBooks = objApp.Workbooks
            objBook = objBooks.Open(My.Application.Info.DirectoryPath + "\Reports\Master\PaymentReport.xlsx")
            objSheets = objBook.Worksheets
            Dim SheetIndex = 1
            Dim ColumnIndex As Integer = 1
            Dim ReportFileName As String = ""



            For Each line As API.JobLineTime In PaymentTimeRecords
                line.PaymentRun = API.OptionInvoiceRun.P
                line.PaymentRunDate = Now
                Try
                    If SheetIndex > 0 Then
                        ColumnIndex = 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = line.Employee.EmployeeNumber
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = line.Employee.Person.DisplayName
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = String.Format("{0}_INTEN_{1}", line.Employee.BranchCode, CType(PaymentFrequencyLookUpEdit.EditValue, API.PaymentFrequency).Code)
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = CType(PayRunLookUpEdit.EditValue, API.PaymentFrequencyType).Code
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = line.Job.Customer.Account
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = String.Format("{0}_{1}", line.Job.Customer.Account, line.CustomerWorkCentreCategory.Code)
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = line.InventoryItem.Code
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        Dim TransactionCode = API.PaymentRunTypes.FindAllByProperty("RateTypeID", line.RateTypeID).FirstOrDefault
                        objSheet.Cells(AtRow, ColumnIndex) = TransactionCode.Code
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = TransactionCode.PayRollCode
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = line.StartDate.Value.ToString("yyyy/MM/dd")
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = line.EndDate.Value.ToString("yyyy/MM/dd")
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = line.Quantity
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = ""
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = ""
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = line.EmployeeRate
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = line.UnitPrice
                        ColumnIndex += 1
                        objSheet = objSheets(SheetIndex)
                        objSheet.Cells(AtRow, ColumnIndex) = line.StartDate.Value.ToString("HH:mm") & " - " & line.EndDate.Value.ToString("HH:mm")




                        AtRow += 1
                    End If
                    line.Save()
                Catch ex As Exception
                    IsSuccesfull = False
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("{0}-{1}", "Error Updating Time lines for processed Payment", ex.Message), "Error Updating Time")
                    UniSource.Logging.Log.Log.logError("Error In Updating Time.", ex)

                End Try
                
            Next
            Try
                ReportFileName = String.Format(My.Application.Info.DirectoryPath + "\Reports\PaymentRunReport_{0}.xlsx", Now.ToString("yyyyMMdd_HHmmss"))
                objBook.SaveAs(ReportFileName)
                objBooks.Close()
                objBook = Nothing
                objApp.Quit()
                objApp = Nothing
                Try
                    objApp.Quit()
                    objApp = Nothing
                Catch ex2 As Exception
                End Try
            Catch
            End Try
        End If

    End Sub

    Private Sub PaymentFrequencyLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles PaymentFrequencyLookUpEdit.EditValueChanged
        PayRunBindingSource.DataSource = CType(PaymentFrequencyLookUpEdit.EditValue, API.PaymentFrequency).PaymentFrequencyTypeList
    End Sub
End Class

Public Class xaegGeneratePayment
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.PaymentRun)
End Class