Namespace Functions

    Public Class EditSupplierDeliveryNote
        Inherits JobFunction

        Protected Overrides Sub Action()
            Dim bc As New Helper.ActiveRecord.Checkout

            If bc.AddCheckOut("Job", Jobs(0).ID) Then
                Dim xaer As New xaeEditSupplierDeliveryNote()

                xaer.Record = Jobs(0)

                xaer.PerformBatchCheckout = True
                xaer.CheckoutGuid = bc.Checkout.GUID

                xaer.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                xaer.ShowDialog()

                xaer.Close()
            End If


        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Edit Supplier Delivery Note"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Edit Supplier Delivery Note"
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.brick
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.EditSupplierDeliveryNote
            End Get
        End Property

    End Class

End Namespace
