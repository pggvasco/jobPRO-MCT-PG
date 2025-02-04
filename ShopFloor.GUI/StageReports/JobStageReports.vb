'Namespace StageReports

'    Public MustInherit Class JobStageReports

'        'Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
'        Public Property Jobs As IList(Of API.Job)
'        'Public MustOverride ReadOnly Property ID As API.JobFunction
'        Public MustOverride ReadOnly Property ReportName As String
'        Public MustOverride ReadOnly Property Description As String
'        Public MustOverride ReadOnly Property Glyph As Drawing.Image
'        Public Overridable Property RequiresInstance As Boolean = True
'        Protected MustOverride Sub Action()

'        Public Sub Process(ByVal jobs As IEnumerable(Of API.Job))
'            Dim jfc As API.JobFunctionControl
'            Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.JobFunctionControl)()
'            crit.Add(NHibernate.Criterion.Expression.Eq("JobFunctionID", CInt(Me.ID)))

'            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
'            jfc = API.JobFunctionControl.FindFirst(crit)
'            'End Using

'            If jfc IsNot Nothing Then
'                If Not String.IsNullOrEmpty(jfc.Password) Then
'                    If Not Helper.GUI.Dialog.PromptPasswordDialog("Password", "Password") = jfc.Password Then
'                        Setup.Log.logError("Incorrect password.")
'                        Exit Sub
'                    End If
'                End If
'            End If

'            Me.Jobs = New List(Of API.Job)
'            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
'            For Each j As API.Job In jobs
'                Me.Jobs.Add(API.Job.Find(j.ID))
'            Next
'            'End Using

'            Me.Action()

'        End Sub

'        Public Shared Function GetHandler(ByVal id As API.JobFunction) As JobFunction
'            Select Case id
'                Case API.JobFunction.PreviousStage
'                    Return New PreviousStage
'                Case API.JobFunction.NextStage
'                    Return New NextStage
'                Case API.JobFunction.AddJob
'                    Return New AddJob
'                Case API.JobFunction.AddQuote
'                    Return New AddQuote
'                Case API.JobFunction.EditJob
'                    Return New EditJob
'                Case API.JobFunction.EditQuote
'                    Return New EditQuote
'                Case API.JobFunction.ViewJob
'                    Return New ViewJob
'                Case API.JobFunction.Quotation
'                    Return New Quotation
'                Case API.JobFunction.ViewQuote
'                    Return New Delivery
'                Case API.JobFunction.ConvertQuoteToJob
'                    Return New ConvertQuoteToJob
'                Case API.JobFunction.EditJobTolerances
'                    Return New EditJobTolerances
'                Case API.JobFunction.PreRequisition
'                    Return New PreRequisition
'                Case API.JobFunction.Requisition
'                    Return New Requisition
'                Case API.JobFunction.PurchaseOrder
'                    Return New PurchaseOrder
'                Case API.JobFunction.GeneratePurchaseOrders
'                    Return New GeneratePurchaseOrders
'                Case API.JobFunction.AssignTester
'                    Return New AssignTester
'                Case API.JobFunction.AssignFitter
'                    Return New AssignFitter
'                Case API.JobFunction.AssignInspector
'                    Return New AssignInspector
'                Case API.JobFunction.Note
'                    Return New Notes
'                Case API.JobFunction.JobComments
'                    Return New JobQuoteComments
'                Case API.JobFunction.Memo
'                    Return New Memo
'                Case API.JobFunction.RequisitionRePrint
'                    Throw New NotImplementedException
'                Case API.JobFunction.PreRequisitionRePrint
'                    Throw New NotImplementedException
'                Case API.JobFunction.ViewQuotation
'                    Return New ViewQuotation
'                Case API.JobFunction.ViewNote
'                    Return New ViewNotes
'                Case API.JobFunction.ViewMemo
'                    Return New ViewMemos
'                Case API.JobFunction.Drawing
'                    Return New JobDrawings
'                Case API.JobFunction.ViewDrawing
'                    Return New ViewJobDrawings
'                Case Else
'                    Return Nothing
'            End Select
'        End Function

'    End Class

'End Namespace