Namespace Functions

    Public Class GeneratePurchaseOrders
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j In Jobs
                Dim bc As New Helper.ActiveRecord.Checkout
                If bc.AddCheckOut("Job", j.ID) Then
                    If j.IsProcured = False Then
                        If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                            bc.RemoveCheckout(bc.Checkout.GUID)
                        End If
                        Setup.Log.logError(String.Format("Job Pre-Requisition not completed. Job Number {0}", j.JobNumber))
                        Exit Sub
                    End If
                    For Each jl As API.JobLine In j.JobLines
                        jl.RefreshOrderedStockDrawnQty()
                    Next
                    j.RefreshStockDrawn()
                    Dim xaer As New xfGeneratePurchaseOrders
                    xaer.Records = j.GetPurchaseOrders
                    xaer.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                    If xaer.ShowDialog() = DialogResult.OK Then
                        For Each rec In xaer.Records
                            If rec.PurchaseOrderLineList.Count > 0 Then
                                Dim xftr As New xfShopFloorTriggerRunner(Of API.PurchaseOrder)
                                xftr.Show()
                                xftr.Run(rec, API.Trigger.PurchaseOrderToErp)
                            End If
                        Next
                    End If
                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                        bc.RemoveCheckout(bc.Checkout.GUID)
                    End If
                    xaer.Close()
                End If
            Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Generate Purchase Orders"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Create the Job Purchase Orders."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.GeneratePurchaseOrders
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.bricks
            End Get
        End Property

    End Class

End Namespace