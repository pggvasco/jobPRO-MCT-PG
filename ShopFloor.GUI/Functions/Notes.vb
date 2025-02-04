Namespace Functions
    Public Class Notes
        Inherits JobFunction
        Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
        Protected Overrides Sub Action()
            For Each j As API.Job In Jobs
                Dim xaejn As New xaeJobNotes(j)
                'xaejn.Record = j
                'Select Case j.State
                '    Case API.JobState.Quote
                '        xaejn.Text += " - " & j.QuoteNumber
                '    Case Else
                '        xaejn.Text += " - " & j.JobNumber
                'End Select
                xaejn.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaejn.ShowDialog()
                xaejn.Close()
            Next
        End Sub

        Public Overrides Property RequiresInstance As Boolean = False

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Notes"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Job Notes."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.Note
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_add
            End Get
        End Property
    End Class
End Namespace
