Namespace Functions

    Public Class EditJobTolerances
        Inherits JobFunction

        Protected Overrides Sub Action()
            Dim xfjt As New xfJobTolerances(Jobs(0))
            xfjt.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
            xfjt.ShowDialog()
            xfjt.Close()
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Tolerances"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Edit the Job's Tolerances."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.EditJobTolerances
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.cog_edit
            End Get
        End Property

    End Class

End Namespace