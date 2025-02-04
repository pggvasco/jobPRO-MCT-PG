Namespace Functions

    Public Class JobSupplierDeliveryNotePrint
        Inherits JobFunction
        Protected Overrides Sub Action()
            Dim xaer As New xaeJobSupplierDeliveryNote()
            xaer.Record = New API.JobSupplierDeliveryNote With {.Job = Jobs(0), .AgentID = API.Context.Agent.ID}
            xaer.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
            If xaer.ShowDialog() = DialogResult.OK Then

            End If
            xaer.Close()

        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Print Supplier Delivery Note"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Print Supplier Delivery Note."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.JobSupplierDeliveryNotePrint
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.brick
            End Get
        End Property

        Public Sub Print()

        End Sub

    End Class

End Namespace
