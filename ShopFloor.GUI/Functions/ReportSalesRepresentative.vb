Namespace Functions
    Public Class ReportSalesRepresentative
        Inherits JobFunction

        Protected Overrides Sub Action()
            
            Dim xaer As New xaeJobReports()
            xaer.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
            xaer.ShowDialog()
            xaer.Close()
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Sales Representative Report"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Sales Representative Report."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.ReportSalesRepresentative
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.user_suit
            End Get
        End Property

    End Class

End Namespace
