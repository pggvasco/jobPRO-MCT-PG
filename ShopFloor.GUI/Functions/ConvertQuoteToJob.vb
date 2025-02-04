﻿Namespace Functions

    Public Class ConvertQuoteToJob
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j As API.Job In Jobs
                If j.State = API.JobState.Quote Then
                    Dim bc As New Helper.ActiveRecord.Checkout
                    If bc.AddCheckOut("Job", j.ID) Then
                        'Using New Castle.ActiveRecord.ConversationalScope(Conversation)

                        Dim message As String = j.ValidateAsset
                        If message <> "" Then
                            UniSource.Helper.GUI.Dialog.OKDialog(message, "Asset on active job")
                        Else
                            If Not IIf(API.Context.Defaults.IsJobNumberAutoGenerated.HasValue, API.Context.Defaults.IsJobNumberAutoGenerated.Value, False) Then
                                Dim jobNumber As String = Helper.GUI.Dialog.PromptDialog("Please specify Job Number.", "Job Number?")
                                If Not String.IsNullOrEmpty(jobNumber) Then
                                    j.ConvertQuoteToActiveJob(jobNumber)
                                End If
                            Else
                                j.ConvertQuoteToActiveJob()
                            End If
                            'End Using
                            If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                                bc.RemoveCheckout(bc.Checkout.GUID)
                            End If
                        End If
                    End If
                End If
            Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Convert Quote To Job"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Convert a Quote to an active Job."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.ConvertQuoteToJob
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_link
            End Get
        End Property

    End Class

End Namespace