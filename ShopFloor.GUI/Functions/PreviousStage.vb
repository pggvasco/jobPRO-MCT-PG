Namespace Functions

    Public Class PreviousStage
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j As API.Job In Jobs
                Dim bc As New Helper.ActiveRecord.Checkout
                'check if job exists in evolution
                Dim selectedtab = CType(Setup.Setup.MainForm, Menu.xfMain).xtcTabs.SelectedTabPage.Text
                If j.JobStage.Description <> selectedtab Then
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format(" Please Refresh screen as Job {0}.is no longer at {1}.Job is now at stage {2} ", j.JobNumber, selectedtab, j.JobStage))
                    Exit Sub
                End If
                If Pastel.Evolution.JobCard.FindByCode(j.JobNumber) > 0 Then
                    Dim ERPJob = New Pastel.Evolution.JobCard(CInt(j.JobCardID))
                    'prevents a job which is not active from to move to previous stage
                    If ERPJob.Status <> Pastel.Evolution.JobCard.JobStatus.Active Then
                        UniSource.Helper.GUI.Dialog.OKDialog(String.Format(" Job {0}. Job Not Active in ERP Can't move to Previous Stage", j.JobNumber))
                        Exit Sub
                    End If
                End If
                If bc.AddCheckOut("Job", j.ID) Then
                    If j.PreviousStage IsNot Nothing Then
                        If j.JobStage.IsProcurement IsNot Nothing AndAlso j.JobStage.IsProcurement Then
                            j.IsApproved = False
                        End If

                        j.JobStage = j.PreviousStage
                        'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                        j.SaveAndFlush()
                        'End Using
                    End If
                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                        bc.RemoveCheckout(bc.Checkout.GUID)
                    End If
                End If
                API.Context.SecondAgent = Nothing
            Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Previous"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Proceed Job to previous stage."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.PreviousStage
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.arrow_left
            End Get
        End Property

    End Class

End Namespace