Namespace Functions

    Public Class ViewQuote
        Inherits JobFunction

        Protected Overrides Sub Action()
            If Jobs(0).State <> API.JobState.Quote Then Exit Sub
            Dim xaej As New xaeJob2
            xaej.Record = Jobs(0)
            xaej.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
            xaej.JobDataLayoutControl.Enabled = False
            xaej.btSave.Visible = False
            xaej.ShowDialog()
            xaej.Close()
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "View Quote"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "View the Quote in Read-Only mode."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.ViewQuote
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.folder_find
            End Get
        End Property

    End Class

End Namespace