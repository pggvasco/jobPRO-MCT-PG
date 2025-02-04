Namespace Functions

    Public Class AddQuoteTime
        Inherits JobFunction

        Protected Overrides Sub Action()
            Dim xaej As New xaeJobTime
            xaej.Record = New API.Job With {.State = API.JobState.Quote}
            xaej.Text = "QuoteTime"
            xaej.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
            xaej.ShowDialog()
        End Sub

        Public Overrides Property RequiresInstance As Boolean = False

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Add QuoteTime"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Add a new QuoteTime."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.AddQuoteTime
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.folder_add
            End Get
        End Property

    End Class

End Namespace
