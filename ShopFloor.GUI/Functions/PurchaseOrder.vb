Namespace Functions

    Public Class PurchaseOrder
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j In Jobs
                Dim bc As New Helper.ActiveRecord.Checkout
                For Each jl As API.JobLine In j.JobLines
                    'Check if line is work centere  
                    If jl.WorkCentre.IsBuyOut Then
                        Dim xaejq As New xaePurchaseOrder()
                        xaejq.SupplierLookUpEdit.Properties.ReadOnly = True
                    End If
                Next
                If bc.AddCheckOut("Job", j.ID) Then
                    j.Refresh()
                    For Each jl As API.JobLine In j.JobLines
                        jl.RefreshOrderedStockDrawnQty()
                    Next
                    j.RefreshStockDrawn()
                    If j.IsProcured = False Then
                        Setup.Log.logError(String.Format("Job Pre-Requisition not completed. Job Number {0}", j.JobNumber))
                        If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                            bc.RemoveCheckout(bc.Checkout.GUID)
                        End If
                        Exit Sub
                    End If
                    For Each jl As API.JobLine In j.JobLines
                        jl.RefreshOrderedStockDrawnQty()
                    Next
                    Dim xaer As New xaePurchaseOrder()
                    xaer.Record = New API.PurchaseOrder
                    Using New Castle.ActiveRecord.ConversationalScope(xaer.Conversation)
                        xaer.Record.Job = API.Job.Find(j.ID)
                    End Using
                    'xaer.Record = j.GetPurchaseOrders().FirstOrDefault
                    xaer.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                    If xaer.ShowDialog() = DialogResult.OK Then
                        If xaer.Record.ID > 0 Then
                            Dim xftr As New xfShopFloorTriggerRunner(Of API.PurchaseOrder)
                            xftr.Show()
                            xftr.Run(xaer.Record, API.Trigger.PurchaseOrderToErp)
                        End If
                    End If
                    xaer.Close()
                End If
                If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                    bc.RemoveCheckout(bc.Checkout.GUID)
                End If
            Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Purchase Order"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Create a Purchase Order."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.PurchaseOrder
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.brick
            End Get
        End Property

    End Class

End Namespace
