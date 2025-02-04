Namespace Functions

    Public Class Delivery
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j In Jobs
                Dim xaejd As New xaeJobDelivery
                xaejd.Record = New API.JobDelivery
                Using New Castle.ActiveRecord.ConversationalScope(xaejd.Conversation)
                    xaejd.Record.Job = API.Job.Find(j.ID)
                End Using
                xaejd.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaejd.ShowDialog()
                xaejd.Close()
            Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Delivery"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Create the Job Delivery Note."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.JobDelivery
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.lorry
            End Get
        End Property

    End Class

End Namespace