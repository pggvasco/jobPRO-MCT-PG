Namespace Functions

    Public Class AddQuote
        Inherits JobFunction

        Protected Overrides Sub Action()
            Dim xaej As New xaeJob2()
            xaej.Record = New API.Job With {.State = API.JobState.Quote}
            xaej.Text = "Quote"
            xaej.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
            xaej.ShowDialog()
            xaej.Close()
        End Sub

        Public Overrides Property RequiresInstance As Boolean = False

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Add Quote"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Add a new Quote."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.AddQuote
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.folder_add
            End Get
        End Property

    End Class

End Namespace