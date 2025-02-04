Namespace Functions

    Public Class EditQuote
        Inherits JobFunction

        Protected Overrides Sub Action()
            If Jobs(0).State <> API.JobState.Quote Then Exit Sub
            Dim bc As New Helper.ActiveRecord.Checkout
            If bc.AddCheckOut("Job", Jobs(0).ID) Then
                Dim xaej As New xaeJob2
                xaej.Record = Jobs(0)
                xaej.Text = "Quote"
                xaej.PerformBatchCheckout = True
                xaej.CheckoutGuid = bc.Checkout.GUID
                xaej.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaej.ShowDialog()
                If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                    bc.RemoveCheckout(bc.Checkout.GUID)
                End If
                xaej.Close()
                xaej.Dispose()
                xaej = Nothing
            End If
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Edit Quote"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Edit the Quote."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.EditQuote
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.folder_edit
            End Get
        End Property

    End Class

End Namespace