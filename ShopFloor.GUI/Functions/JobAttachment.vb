
Namespace Functions
    Public Class JobAttachment
        Inherits JobFunction

        Protected Overrides Sub Action()

            Dim bc As New Helper.ActiveRecord.Checkout
            If bc.AddCheckOut("Job", Jobs(0).ID) Then
                Dim xfa As New xfJobAttachment(Jobs(0))
                xfa.job = Jobs(0)
                'xfa.Record = Jobs(0)
                'xfa.PerformBatchCheckout = True
                'xfa.CheckoutGuid = bc.Checkout.GUID
                xfa.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xfa.ShowDialog()
                If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                    bc.RemoveCheckout(bc.Checkout.GUID)
                End If
                xfa.Close()
            End If

        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Job Attachment"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Job Attachment."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.JobAttachment
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.email_attach
            End Get
        End Property
    End Class

End Namespace
