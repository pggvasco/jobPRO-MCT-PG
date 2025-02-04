Namespace Functions

    Public Class JobDrawings
        Inherits JobFunction

        Protected Overrides Sub Action()
            'If Jobs(0).State <> API.JobState.Active Then Exit Sub
            If Jobs(0).Drawing Is Nothing Then
                Setup.Log.logError(String.Format("Job has no drawing. Job Number {0}", Jobs(0).JobNumber))
                Exit Sub
            End If
            Dim bc As New Helper.ActiveRecord.Checkout
            If bc.AddCheckOut("Job", Jobs(0).ID) Then
                Dim xaej As New xfJobDrawings(Jobs(0))
                xaej.Record = Jobs(0)
                xaej.PerformBatchCheckout = True
                xaej.CheckoutGuid = bc.Checkout.GUID
                xaej.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaej.ShowDialog()
                If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                    bc.RemoveCheckout(bc.Checkout.GUID)
                End If
                xaej.Close()
            End If
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Drawing"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Edit the Job Drawing."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.Drawing
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.picture
            End Get
        End Property

    End Class

End Namespace