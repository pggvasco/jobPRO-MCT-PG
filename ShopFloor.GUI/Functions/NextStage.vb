Imports UniSource.Helper.GUI.My.Resources
Imports System.Data.SqlClient

Namespace Functions

    Public Class NextStage
        Inherits JobFunction
        Protected _mainform As Form = Nothing
        Public Property MainForm() As DevExpress.XtraEditors.XtraForm
            Get
                Return _mainform
            End Get
            Set(ByVal value As DevExpress.XtraEditors.XtraForm)
                _mainform = value
            End Set
        End Property
        Protected Overrides Sub Action()

            For Each j As API.Job In Jobs
                Dim bc As New Helper.ActiveRecord.Checkout
                Dim CheckedOut As Boolean = False
                Dim jobOriginalStage As API.JobStage = j.JobStage
                Dim selectedtab = CType(Setup.Setup.MainForm, Menu.xfMain).xtcTabs.SelectedTabPage.Text
                If j.JobStage.Description <> selectedtab Then
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format(" Please Refresh screen as Job {0}.is no longer at {1}.Job is now at stage {2} ", j.JobNumber, selectedtab, j.JobStage))
                    Exit Sub
                End If
                Try
                    Dim Conversation As Castle.ActiveRecord.ScopedConversation = New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
                    'Dim holder = Castle.ActiveRecord.ActiveRecordMediator.GetSessionFactoryHolder()
                    'Dim sfl = holder.GetSessionFactories
                    'For Each sf In sfl
                    'Conversation = sf.GetCurrentSession
                    'Next
                    'Dim lne As Menu.ListNode(Of API.Job, xlJob) =New (Setup.Setup.MainForm, Menu.xfMain).MainNode.FindFirstChildByCaption(j.JobStage.Description)

                    'Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    '    j.SaveAndFlush()
                    'j.Refresh()

                    'End Using
                    Conversation.Restart()
                    'Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    If bc.AddCheckOut("Job", j.ID) Then
                        CheckedOut = True
                        If j.JobStage.IsZeroDiscountChecked Then
                            Dim NoZeroDiscountLines As Integer = 0
                            For Each jl In j.JobLines
                                If jl.WorkCentre.CalculationType = API.CalculationType.Standard AndAlso jl.WorkCentre.IsBuyOut = False Then
                                    If jl.LineDiscountPercent <= 0 Then
                                        NoZeroDiscountLines += 1
                                    End If
                                End If
                            Next

                            If NoZeroDiscountLines > 0 Then
                                Dim gpMessage As String = String.Format("Found {0} lines with zero discount." + vbCrLf + "Do you want to continue to next stage?", NoZeroDiscountLines)
                                If UniSource.Helper.GUI.Dialog.YesNoDialog(gpMessage) = Windows.Forms.DialogResult.Yes Then
                                    Dim log As New API.Audit
                                    log.Date = Now
                                    log.Agent = API.Context.Agent
                                    log.Description = String.Format("The suggestion for {0} zero discount lines was acknowledged.", NoZeroDiscountLines)
                                    log.Type = "LinesZeroDiscount"
                                    log.OldValue = NoZeroDiscountLines.ToString
                                    log.NewValue = NoZeroDiscountLines.ToString
                                    log.idJob = j.ID
                                    log.SaveAndFlush()
                                    log = Nothing
                                Else
                                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                        bc.RemoveCheckout(bc.Checkout.GUID)
                                    End If
                                    Exit Sub
                                End If
                            End If
                        End If
                        If j.JobStage.IsInvoicing Then
                            If j.JobCardID.HasValue AndAlso j.JobCardID > 0 Then
                                Dim jobInvoices As Boolean = True
                                Dim jobCard As Pastel.Evolution.JobCard = New Pastel.Evolution.JobCard(j.JobCardID.Value)
                                For Each jobDetail As Pastel.Evolution.JobDetail In jobCard.Detail
                                    If jobDetail.Status <> 2 Then
                                        jobInvoices = False
                                    End If
                                Next
                                If (jobCard.Status <> 2 And jobInvoices = False) Then
                                    Setup.Log.logInfo(String.Format("Job is not Invoiced yet. Job Number {0}", j.JobNumber))
                                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Job is not Invoiced yet. Job Number {0}", j.JobNumber))
                                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                        bc.RemoveCheckout(bc.Checkout.GUID)
                                    End If
                                    Exit Sub
                                End If

                                'If jobCard.Detail.Count <= 0 Then
                                '    Setup.Log.logError(String.Format("Job Card on ERP have no detail lines. Job Number {0}", j.JobNumber))
                                '    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                '        bc.RemoveCheckout(bc.Checkout.GUID)
                                '    End If
                                '    Exit Sub
                                'End If
                            End If
                        ElseIf j.JobStage.IsProcurement Then
                            'j.Refresh()
                            If j.IsProcured Is Nothing OrElse j.IsProcured = False Then
                                Setup.Log.logInfo(String.Format("Job Procurement not completed. Job Number {0}", j.JobNumber))
                                UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Job Procurement not completed. Job Number {0}", j.JobNumber))
                                If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                    bc.RemoveCheckout(bc.Checkout.GUID)
                                End If
                                Exit Sub
                            End If
                            For Each jl As API.JobLine In j.JobLines
                                jl.RefreshOrderedStockDrawnQty()
                            Next
                            j.RefreshStockDrawn()
                            If j.IsStockDrawn Is Nothing OrElse j.IsStockDrawn = False Then
                                Setup.Log.logInfo(String.Format("Not All stock is drawn yet. Job Number {0}", j.JobNumber))
                                UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Not All stock is drawn yet. Job Number {0}", j.JobNumber))
                                If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                    bc.RemoveCheckout(bc.Checkout.GUID)
                                End If
                                Exit Sub
                            End If

                            If API.Context.Defaults.CheckPOCompleted IsNot Nothing AndAlso API.Context.Defaults.CheckPOCompleted Then
                                If j.IsPOGRVComplete = False Then
                                    Setup.Log.logInfo(String.Format("There is outstanding Purchase Order  on Job. Job Number {0}", j.JobNumber))
                                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("There is outstanding Purchase Order on Job. Job Number {0}", j.JobNumber))
                                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                        bc.RemoveCheckout(bc.Checkout.GUID)
                                    End If
                                    Exit Sub
                                End If
                            End If
                        End If

                        If j.JobStage.IsCustomerOnHoldChecked = True AndAlso j.Customer.OnHold Then
                            Setup.Log.logInfo(String.Format("Customer {0} Account is on hold.", j.Customer.Account))
                            UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Customer {0} Account is on hold.", j.Customer.Account))
                            If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                bc.RemoveCheckout(bc.Checkout.GUID)
                            End If
                            Exit Sub
                        End If

                        If j.JobStage.Checklists.Count > 0 Then
                            If Checklist.API.ChecklistLog.FindAllByProperty("RecordID", j.ID).Count <= 0 Then
                                Setup.Log.logInfo(String.Format("Please complete checklist for Job {0}.", j.JobNumber))
                                UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Please complete checklist for Job {0}.", j.JobNumber))
                                If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                    bc.RemoveCheckout(bc.Checkout.GUID)
                                End If
                                Exit Sub
                            End If
                        End If

                        For Each jsf As API.JobStageFunction In j.JobStage.Functions
                            Dim userFieldName As String = ""
                            If jsf.JobFunctionID = CInt(API.JobFunction.AssignFitter) Then
                                userFieldName = "Fitter"
                                If j.UserFields.Item(userFieldName) Is Nothing OrElse j.UserFields.Item(userFieldName) = "" Then
                                    Setup.Log.logInfo(String.Format("Please select a {0} for Job {1}.", userFieldName, j.JobNumber))
                                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Please select a {0} for Job {1}.", userFieldName, j.JobNumber))
                                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                        bc.RemoveCheckout(bc.Checkout.GUID)
                                    End If
                                    Exit Sub
                                End If
                            End If
                            If jsf.JobFunctionID = CInt(API.JobFunction.AssignInspector) Then
                                userFieldName = "Inspector"
                                If j.UserFields.Item(userFieldName) Is Nothing OrElse j.UserFields.Item(userFieldName) = "" Then
                                    Setup.Log.logInfo(String.Format("Please select a {0} for Job {1}.", userFieldName, j.JobNumber))
                                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Please select a {0} for Job {1}.", userFieldName, j.JobNumber))
                                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                        bc.RemoveCheckout(bc.Checkout.GUID)
                                    End If
                                    Exit Sub
                                End If
                            End If
                            If jsf.JobFunctionID = CInt(API.JobFunction.AssignTester) Then
                                userFieldName = "Tester"
                                If j.UserFields.Item(userFieldName) Is Nothing OrElse j.UserFields.Item(userFieldName) = "" Then
                                    Setup.Log.logInfo(String.Format("Please select a {0} for Job {1}.", userFieldName, j.JobNumber))
                                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Please select a {0} for Job {1}.", userFieldName, j.JobNumber))
                                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                        bc.RemoveCheckout(bc.Checkout.GUID)
                                    End If
                                    Exit Sub
                                End If
                            End If
                        Next

                        Dim xfns As New xfNextStage(j)
                        xfns.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)

                        If xfns.ShowDialog = DialogResult.OK Then
                            If j.NextStage IsNot Nothing Then

                                'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                                'j.SaveAndFlush()
                                'End Using


                                Dim js As API.JobStage = j.NextStage
                                Dim CreateNewJob As Boolean = False
                                '' Run any triggers.

                                For Each trig As API.JobStageTrigger In js.Triggers
                                    Select Case trig.TriggerID
                                        Case API.Trigger.JobToErp, API.Trigger.RenevueOneLinerToErp
                                            If trig.TriggerID = API.Trigger.JobToErp Then
                                                CreateNewJob = True
                                            End If
                                            Dim xftr As New xfShopFloorTriggerRunner(Of API.Job)
                                            'xftr.OnNext(New Helper.ActiveRecord.TriggerMessage With {.Message = String.Format("KB Testing", New Object), .Exception = Nothing})
                                            xftr.Run(j, trig.TriggerID)
                                            xftr.ShowDialog()
                                            If xftr.Errors.Count > 0 Then
                                                If jobOriginalStage IsNot Nothing Then
                                                    'Cancell move if error on job
                                                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                                                        j.JobStage = jobOriginalStage
                                                        'j.JobCardID = 0

                                                        j.SaveAndFlush()
                                                        bc.RemoveCheckout(bc.Checkout.GUID)
                                                        UniSource.Helper.GUI.Dialog.OKDialog(String.Format("O Sistema registou um erro: Por favor corrija os erros abaixo antes da Folha Obra  proceder para o estagio seguinte {0}.", j.JobNumber))

                                                    End Using

                                                End If
                                                If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                                    bc.RemoveCheckout(bc.Checkout.GUID)
                                                End If
                                                Exit Sub
                                            End If
                                        Case Else
                                            Setup.Log.logError(String.Format("Trigger '{0}' is not supported when moving jobs between stages.", trig.TriggerID))
                                            If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                                bc.RemoveCheckout(bc.Checkout.GUID)
                                            End If
                                            Exit Sub
                                    End Select
                                Next

                                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                        j.JobStage = j.NextStage
                                        j.SaveAndFlush()

                                        If CreateNewJob Then
                                            '  Dim CreatedJob As New Pastel.Evolution.JobCard(j.JobNumber)
                                            'If CreatedJob.Account.IsForeignCurrencyAccount Then
                                            Dim JobObj As New API.Job()

                                            Dim MyAppCon As SqlConnection = New SqlConnection(ShopFloor.API.ActiveConnection.Company.ConnectionString)
                                            Try
                                                MyAppCon.Open()
                                                Dim cmd As New SqlCommand
                                                'Lance Update Job Dates to correct date, relink must be done after
                                                ' Dim query1 As String = "exec ussUpdateJobCardDates " & j.ID
                                                ' cmd = New SqlCommand(query1, MyAppCon)
                                                'cmd.ExecuteNonQuery()
                                                '  add("Foreign Currency Set")
                                            Catch ex As Exception
                                                Dim ss As String = "ss"
                                                ss = ss
                                                '  add("Error update Currency for Job Card- " & ex.Message)
                                            End Try
                                            MyAppCon.Close()
                                            ' End If
                                        End If
                                    Else
                                        Setup.Log.logError(String.Format("You have lost your checkout authority, your changes cannot be saved."))
                                        Exit Sub
                                    End If
                                End Using
                                If xfns.TraceJobCheckEdit.Checked Then
                                    Dim ln As Menu.ListNode(Of API.Job, xlJob) = CType(Setup.Setup.MainForm, Menu.xfMain).MainNode.FindFirstChildByCaption(js.Description)
                                    ln.PerformAction()
                                    If Not ln.LookupControl.BindingSource.Contains(j) Then
                                        ln.RefreshData()
                                    End If
                                    ln.LookupControl.GridView.FocusedRowHandle = ln.LookupControl.GridView.GetRowHandle(ln.LookupControl.BindingSource.IndexOf(j))
                                End If
                            Else
                                'Job Thru all Stages now going to archive
                                j.State = API.JobState.History
                                If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                                        j.SaveAndFlush()
                                    End Using
                                Else
                                    Setup.Log.logError(String.Format("You have lost your checkout authority, your changes cannot be saved."))
                                    Exit Sub
                                End If
                            End If

                        End If

                        If CheckedOut AndAlso bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                            bc.RemoveCheckout(bc.Checkout.GUID)
                        End If
                        xfns.Close()
                    End If

                    'End Using
                Catch ex As Exception
                    j.JobStage = jobOriginalStage
                    Setup.Log.logError(String.Format("Error on Job {0}.", j.JobNumber), ex)
                Finally
                    If CheckedOut AndAlso bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                        bc.RemoveCheckout(bc.Checkout.GUID)
                    End If
                End Try
                API.Context.SecondAgent = Nothing
                '' Preview any reports.
                For Each rep As API.JobStageReport In j.JobStage.Reports
                    If rep.Report IsNot Nothing AndAlso IIf(rep.IsAutomatic.HasValue, rep.IsAutomatic, False) Then
                        If rep.Report.DefaultLayout IsNot Nothing Then
                            rep.Report.DefaultLayout.PreviewReport(j)
                        End If
                    End If
                Next


            Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Next"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Proceed Job to next stage."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.NextStage
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.arrow_right
            End Get
        End Property

    End Class

End Namespace
