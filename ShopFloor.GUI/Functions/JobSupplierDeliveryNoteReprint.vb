Namespace Functions

    Public Class JobSupplierDeliveryNoteReprint
        Inherits JobFunction

        Protected Overrides Sub Action()

            Dim xaer As New xfSupplierDeliveryNoteReprint()
            xaer.Job = Jobs(0)
            'Using New Castle.ActiveRecord.ConversationalScope(xaer.Conversation)
            '    xaer.Record.ID = API.Job.Find(j.ID)
            'End Using
            ''xaer.Record = j.GetPurchaseOrders().FirstOrDefault
            'xaer.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
            If xaer.ShowDialog() = DialogResult.OK Then
                '    If xaer.Record.Id > 0 Then   xaer.JobSupplierDelivery.
                '        Dim xftr As New xfShopFloorTriggerRunner(Of API.JobSupplierDeliveryNote)
                'xftr.Show()

                'End If
            End If
            xaer.Close()

        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Reprint Supplier Delivery Note"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "RePrint Supplier Delivery Note."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.JobSupplierDeliveryNoteReprint
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.brick
            End Get
        End Property

    End Class

End Namespace
