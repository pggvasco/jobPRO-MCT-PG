Namespace Functions
    Public Class Memo
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j As API.Job In Jobs
                Dim bc As New Helper.ActiveRecord.Checkout
                If bc.AddCheckOut("Job", Jobs(0).ID) Then
                    Dim xaejn As New xaeJobMemos(j)
                    xaejn.PerformBatchCheckout = True
                    xaejn.CheckoutGuid = bc.Checkout.GUID
                    xaejn.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                    xaejn.ShowDialog()
                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                        bc.RemoveCheckout(bc.Checkout.GUID)
                    End If
                    xaejn.Close()
                End If
            Next
        End Sub

        Public Overrides Property RequiresInstance As Boolean = False

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Memo"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Job Memo."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.Memo
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_add
            End Get
        End Property
    End Class
End Namespace