Imports Unisource.Helper.GUI.My.Resources

Namespace Functions

    Public Class NextStageForce
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
                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)

                    End Using
                    Conversation.Restart()
                    If bc.AddCheckOut("Job", j.ID) Then
                        CheckedOut = True

                        If UniSource.Helper.GUI.Dialog.YesNoDialog("Are you sure you want to force job to next stage? Action will be logged.") = DialogResult.Yes Then

                            Dim xfns As New xfNextStage(j)
                            xfns.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)

                            If xfns.ShowDialog = DialogResult.OK Then
                                Dim log As New API.Audit
                                log.Date = Now
                                log.Agent = xfns.User
                                log.Description = "Job Forced to next stage."
                                'log.Type = myPropertyA.Name
                                log.OldValue = ""
                                log.NewValue = ""
                                log.idJob = j.ID
                                log.SaveAndFlush()
                                Setup.Log.logInfo(String.Format("Job was forced to next ."))
                                If j.NextStage IsNot Nothing Then

                                    Dim js As API.JobStage = j.NextStage

                                    '' Run any triggers.

                                    For Each trig As API.JobStageTrigger In js.Triggers
                                        Try
                                            Select Case trig.TriggerID
                                                Case API.Trigger.JobToErp, API.Trigger.RenevueOneLinerToErp
                                                    Dim xftr As New xfShopFloorTriggerRunner(Of API.Job)
                                                    xftr.Run(j, trig.TriggerID)
                                                    xftr.ShowDialog()
                                                    'If xftr.Errors.Count > 0 Then
                                                    '    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                                    '        bc.RemoveCheckout(bc.Checkout.GUID)
                                                    '    End If
                                                    '    Exit Sub
                                                    'End If
                                                Case Else
                                                    Setup.Log.logError(String.Format("Trigger '{0}' is not supported when moving jobs between stages.", trig.TriggerID))
                                                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                                        bc.RemoveCheckout(bc.Checkout.GUID)
                                                    End If
                                                    Exit Sub
                                            End Select
                                        Catch
                                        End Try
                                    Next

                                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                                        If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                            j.JobStage = j.NextStage
                                            j.SaveAndFlush()
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
                Return "Force Next"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Force Job to next stage."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.NextStageForce
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.arrow_out
            End Get
        End Property

    End Class

End Namespace
