Namespace Functions

    Public MustInherit Class JobFunction

        'Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
        Public Property Jobs As IList(Of API.Job)
        ' Public Property JobLines As IList(Of API.JobLine)
        Public Property FocusRowHandleID As Integer = -1
        Public Property FocusRowJobStage As API.JobStage
        Public MustOverride ReadOnly Property ID As API.JobFunction
        Public MustOverride ReadOnly Property Code As String
        Public MustOverride ReadOnly Property Description As String
        Public MustOverride ReadOnly Property Glyph As Drawing.Image
        Public Overridable Property RequiresInstance As Boolean = True
        Public Overridable Property RequiresJobs As Boolean = True
        Protected MustOverride Sub Action()

        Public Sub Process(ByVal jobs As IEnumerable(Of API.Job))
            Dim jfc As API.JobFunctionControl
            Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.JobFunctionControl)()
            crit.Add(NHibernate.Criterion.Expression.Eq("JobFunctionID", CInt(Me.ID)))

            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            jfc = API.JobFunctionControl.FindFirst(crit)
            'End Using

            If jfc IsNot Nothing Then
                If Not String.IsNullOrEmpty(jfc.Password) Then
                    Dim PromptPassword As String = Helper.GUI.Dialog.PromptPasswordDialog("Password", "Password")
                    If PromptPassword Is Nothing OrElse PromptPassword = "" Then
                        Exit Sub
                    ElseIf Not PromptPassword = jfc.Password Then
                        Setup.Log.logError("Incorrect password.")
                        Exit Sub
                    End If
                End If
            End If

            Me.Jobs = New List(Of API.Job)
            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            If RequiresJobs = True Then
                For Each j As API.Job In jobs
                    Me.Jobs.Add(API.Job.Find(j.ID))
                Next
            End If
            'End Using

            Me.Action()

            If FocusRowHandleID >= 0 Then
                Dim ln As Menu.ListNode(Of API.Job, xlJob) = CType(Setup.Setup.MainForm, Menu.xfMain).MainNode.FindFirstChildByCaption(FocusRowJobStage.Description)
                ln.PerformAction()
                'ln.RefreshData()
                Try
                    ln.LookupControl.GridView.FocusedRowHandle = FocusRowHandleID
                    ln.LookupControl.GridView.SelectRow(FocusRowHandleID)
                Catch
                    If ln.LookupControl.GridView.RowCount > 0 Then
                        ln.LookupControl.GridView.FocusedRowHandle = 0
                    End If
                End Try
            End If
            Me.Jobs = Nothing
            jfc = Nothing
            GC.Collect()
        End Sub

        Public Shared Function GetHandler(ByVal id As API.JobFunction) As JobFunction
            Select Case id
                Case API.JobFunction.PreviousStage
                    Return New PreviousStage
                Case API.JobFunction.NextStage
                    Return New NextStage
                Case API.JobFunction.NextStage2
                    Return New NextStage2
                Case API.JobFunction.NextStageForce
                    Return New NextStageForce
                Case API.JobFunction.AddJob
                    Return New AddJob
                Case API.JobFunction.AddQuote
                    Return New AddQuote
                Case API.JobFunction.EditJob
                    Return New EditJob
                Case API.JobFunction.EditQuote
                    Return New EditQuote
                Case API.JobFunction.ViewJob
                    Return New ViewJob
                Case API.JobFunction.Quotation
                    Return New Quotation
                Case API.JobFunction.ViewQuote
                    Return New Delivery
                Case API.JobFunction.ConvertQuoteToJob
                    Return New ConvertQuoteToJob
                Case API.JobFunction.EditJobTolerances
                    Return New EditJobTolerances
                Case API.JobFunction.PreRequisition
                    Return New PreRequisition
                Case API.JobFunction.Requisition
                    Return New Requisition
                Case API.JobFunction.PurchaseOrder
                    Return New PurchaseOrder
                Case API.JobFunction.GeneratePurchaseOrders
                    Return New GeneratePurchaseOrders
                Case API.JobFunction.AssignTester
                    Return New AssignTester
                Case API.JobFunction.AssignFitter
                    Return New AssignFitter
                Case API.JobFunction.AssignInspector
                    Return New AssignInspector
                Case API.JobFunction.Note
                    Return New Notes
                Case API.JobFunction.JobComments
                    Return New JobQuoteComments
                Case API.JobFunction.Memo
                    Return New Memo
                Case API.JobFunction.RequisitionRePrint
                    Throw New NotImplementedException
                Case API.JobFunction.PreRequisitionRePrint
                    Throw New NotImplementedException
                Case API.JobFunction.ViewQuotation
                    Return New ViewQuotation
                Case API.JobFunction.ViewNote
                    Return New ViewNotes
                Case API.JobFunction.ViewMemo
                    Return New ViewMemos
                Case API.JobFunction.Drawing
                    Return New JobDrawings
                Case API.JobFunction.ViewDrawing
                    Return New ViewJobDrawings
                Case API.JobFunction.ReportSalesRepresentative
                    Return New ReportSalesRepresentative
                Case API.JobFunction.CancelJobStage
                    Return New CancelJobStage
                Case API.JobFunction.RecalculateLinePrices
                    Return New RecalculateLinePrices
                Case API.JobFunction.FinalInspectionReport
                    Return New FinalInspectionReport
                Case API.JobFunction.AddJobTime
                    Return New AddJobTime
                Case API.JobFunction.EditJobTime
                    Return New EditJobTime

                Case API.JobFunction.AddQuoteTime
                    Return New AddQuoteTime
                Case API.JobFunction.TimeSheetImport
                    Return New TimeSheetImport
                Case API.JobFunction.QuotationTime
                    Return New QuotationTime
                Case API.JobFunction.EditJob_CTH
                    Return New EditJob_CTH
                Case API.JobFunction.AddJob_CTH
                    Return New AddJob_CTH
                Case API.JobFunction.TestBench
                    Return New TestBench
                Case API.JobFunction.JobAttachment
                    Return New JobAttachment
                Case API.JobFunction.QuotationDiscount
                    Return New QuotationWithDiscount
                Case API.JobFunction.JobSupplierDeliveryNotePrint
                    Return New JobSupplierDeliveryNotePrint
                Case API.JobFunction.JobSupplierDeliveryNoteReprint
                    Return New JobSupplierDeliveryNoteReprint
                Case API.JobFunction.EditSupplierDeliveryNote
                    Return New EditSupplierDeliveryNote
                Case API.JobFunction.ProformaInvoice
                    Return New GenerateProformaInvoice
                Case API.JobFunction.ProformaInvoiceTrackingReport
                    Return New ProformaInvTrackingRep
                    'Shannen 26102020
                Case API.JobFunction.MCTRequisition
                    Return New MCTRequisition
                Case API.JobFunction.ReportStockAllocation
                    Return New ReportStockAllocation
                Case Else
                    Return Nothing
            End Select
        End Function

    End Class

End Namespace