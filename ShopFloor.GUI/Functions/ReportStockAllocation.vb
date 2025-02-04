Namespace Functions
    Public Class ReportStockAllocation
        Inherits JobFunction

        Public Overrides Property RequiresInstance As Boolean = False

        Protected Overrides Sub Action()

            Dim xaer As New xaeReportStockAllocation()
            xaer.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
            xaer.ShowDialog()
            xaer.Close()
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Relatorio - alocação de estoque"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Relatorio - alocação de estoque."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.ReportStockAllocation
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.report
            End Get
        End Property

    End Class
End Namespace