Namespace Functions
    Public Class ViewMemos
        Inherits JobFunction
        Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
        Protected Overrides Sub Action()
            For Each j As API.Job In Jobs
                Dim xaejn As New xaeJobMemos(j)
                xaejn.bbiEditLine.Caption = "View Memo"
                xaejn.bbiAddLine.Enabled = False
                xaejn.bbiSave.Enabled = False
                xaejn.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaejn.ShowDialog()
                xaejn.Close()
            Next
        End Sub

        Public Overrides Property RequiresInstance As Boolean = False

        Public Overrides ReadOnly Property Code As String
            Get
                Return "View Memos"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "View the Memos in Read-Only mode."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.ViewMemo
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_add
            End Get
        End Property
    End Class
End Namespace
