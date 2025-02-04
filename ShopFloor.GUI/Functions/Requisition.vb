Namespace Functions

    Public Class Requisition
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j In Jobs
                Dim bc As New Helper.ActiveRecord.Checkout
                If bc.AddCheckOut("Job", j.ID) Then
                    j.Refresh()
                    For Each jl As API.JobLine In j.JobLines
                        jl.RefreshOrderedStockDrawnQty()
                    Next
                    If j.IsProcured = False Then
                        If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                            bc.RemoveCheckout(bc.Checkout.GUID)
                        End If
                        Setup.Log.logError(String.Format("Job Pre-Requisition not completed. Job Number {0}", j.JobNumber))
                        Exit Sub

                    End If

                    If CheckAllLinesAreRequisitioned(j) = False Then
                        Setup.Log.logError(String.Format("Job Pre-Requisition not completed for all required lines. Job Number {0}", j.JobNumber))
                        Exit Sub
                        If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                            bc.RemoveCheckout(bc.Checkout.GUID)
                        End If

                    End If

                    Dim xaer As New xaeRequisition()
                    xaer.Record = New API.Requisition
                    For Each jl As API.JobLine In j.JobLines
                        jl.RefreshOrderedStockDrawnQty()
                    Next
                    Using New Castle.ActiveRecord.ConversationalScope(xaer.Conversation)
                        xaer.Record.Job = API.Job.Find(j.ID)
                    End Using

                    j.RefreshStockDrawn()
                    xaer.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
                    Dim errors As Boolean = False
                    If xaer.ShowDialog() = DialogResult.OK Then
                        If xaer.Record.ID > 0 Then
                            If xaer.Record.RequisitionLineList.Count > 0 Then
                                Dim xftr As New xfShopFloorTriggerRunner(Of API.Requisition)
                                'xftr.Show()
                                xftr.Run(xaer.Record, API.Trigger.RequisitionToErp)
                                xftr.ShowDialog()
                            End If
                        End If
                    End If
                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                        bc.RemoveCheckout(bc.Checkout.GUID)
                    End If
                    xaer.Close()
                End If
            Next
        End Sub


        Private Function CheckAllLinesAreRequisitioned(ByVal CurrentJob As API.Job) As Boolean
            Dim TotalLinesRequisitioned As Integer
            Dim TotalLinesRequisitionRequired As Integer
            For Each line In CurrentJob.JobLines
                If (line.WorkCentre.GLExpense = False Or line.WorkCentre.GLExpense Is Nothing) And (line.WorkCentre.APExpense = False Or line.WorkCentre.APExpense Is Nothing) Then
                    If line.InventoryItem IsNot Nothing AndAlso IsDBNull(line.InventoryItem) = False Then
                        If line.InventoryItem.SerialItem = False Then
                            TotalLinesRequisitionRequired = TotalLinesRequisitionRequired + 1

                            If line.IsRequisitionedGenerated = True Then
                                TotalLinesRequisitioned = TotalLinesRequisitioned + 1
                            End If
                        End If
                    End If
                End If
            Next
            If TotalLinesRequisitionRequired = TotalLinesRequisitioned Then
                Return True
            Else
                Return False
            End If

        End Function
        Public Overrides ReadOnly Property Code As String
            Get
                Return "Warehouse Issue"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Create the Job Stock Requisition."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.Requisition
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.bricks
            End Get
        End Property

    End Class

End Namespace