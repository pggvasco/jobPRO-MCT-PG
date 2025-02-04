Namespace Functions

    Public Class CancelJobStage
        Inherits JobFunction

        Protected Overrides Sub Action()

            For Each j As API.Job In Jobs
                Dim bc As New Helper.ActiveRecord.Checkout
                Dim jobOriginalStage As API.JobStage = j.JobStage
                Try
                    Dim Conversation As Castle.ActiveRecord.ScopedConversation = New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                        j.Refresh()
                    End Using

                    If bc.AddCheckOut("Job", j.ID) Then
                        If j.Customer.OnHold Then
                            Setup.Log.logInfo(String.Format("Customer {0} Account is on hold.", j.Customer.Account))
                            UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Customer {0} Account is on hold.", j.Customer.Account))
                            If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                bc.RemoveCheckout(bc.Checkout.GUID)
                            End If
                            Exit Sub
                        End If

                        Dim xfns As New xfCancelJobStage(j)
                        xfns.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)

                        If xfns.ShowDialog = DialogResult.OK Then
                            If j.CancelJobStage IsNot Nothing Then

                                Dim js As API.JobStage = j.CancelJobStage

                                Dim xftr As New xfShopFloorTriggerRunner(Of API.Job)
                                xftr.Run(j, API.Trigger.JobCancelRenevueOneLinerToErp)
                                xftr.ShowDialog()

                                If xftr.Errors.Count > 0 Then
                                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                        bc.RemoveCheckout(bc.Checkout.GUID)
                                    End If
                                    Exit Sub
                                End If

                                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                                    j.JobStage = j.CancelJobStage
                                    j.CancelledDate = Now()
                                    j.CancelReason = xfns.CancelComentTextEdit.Text
                                    j.CancelReasonCode = xfns.CancelReasonCodeLookUpEdit.EditValue
                                    j.CancelAgentID = xfns.User.ID
                                    j.IsCancelled = True
                                    j.SaveAndFlush()
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
                                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                                    j.SaveAndFlush()
                                End Using

                            End If

                        End If

                        If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                            bc.RemoveCheckout(bc.Checkout.GUID)
                        End If
                    End If
                    'End Using
                Catch ex As Exception
                    j.JobStage = jobOriginalStage
                    Setup.Log.logError(String.Format("Error on Job {0}.", j.JobNumber), ex)
                Finally
                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                        bc.RemoveCheckout(bc.Checkout.GUID)
                    End If
                End Try
                API.Context.SecondAgent = Nothing
                '' Preview any reports.
                'For Each rep As API.JobStageReport In j.JobStage.Reports
                '    If rep.Report IsNot Nothing AndAlso IIf(rep.IsAutomatic.HasValue, rep.IsAutomatic, False) Then
                '        If rep.Report.DefaultLayout IsNot Nothing Then
                '            rep.Report.DefaultLayout.PreviewReport(j)
                '        End If
                '    End If
                'Next
            Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Cancel"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Cancel job."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.CancelJobStage
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.cancel
            End Get
        End Property

    End Class

End Namespace

