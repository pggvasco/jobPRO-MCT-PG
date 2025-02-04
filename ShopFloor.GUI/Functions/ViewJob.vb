Namespace Functions

    Public Class ViewJob
        Inherits JobFunction

        Protected Overrides Sub Action()
            If API.Context.Defaults.DefaultJobScreen = API.DefaultJobScreen.Job Then
                Dim xaej As New xaeJob
                xaej.Record = Jobs(0)
                xaej.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaej.JobDataLayoutControl.Enabled = False
                xaej.btSave.Visible = False
                xaej.ShowDialog()
                xaej.Close()
            ElseIf API.Context.Defaults.DefaultJobScreen = API.DefaultJobScreen.Job2 Then
                Dim xaej As New xaeJob2
                xaej.Record = Jobs(0)
                xaej.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaej.JobDataLayoutControl.Enabled = False
                xaej.btSave.Visible = False
                xaej.ShowDialog()
                xaej.Close()
            ElseIf API.Context.Defaults.DefaultJobScreen = API.DefaultJobScreen.Job3 Then
                Dim xaej As New xaeJob3
                xaej.Record = Jobs(0)
                xaej.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaej.JobDataLayoutControl.Enabled = False
                xaej.btSave.Visible = False
                xaej.ShowDialog()
                xaej.Close()
            ElseIf API.Context.Defaults.DefaultJobScreen = API.DefaultJobScreen.Job4 Then
                Dim xaej As New xaeJob_CTH
                xaej.Record = Jobs(0)
                xaej.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaej.JobDataLayoutControl.Enabled = False
                xaej.btSave.Visible = False
                xaej.ShowDialog()
                xaej.Close()

            End If
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "View"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "View the Job in Read-Only mode."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.ViewJob
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_find
            End Get
        End Property

    End Class

End Namespace