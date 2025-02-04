Public Class PurchaseOrderToErp
    Inherits ShopFloorTrigger(Of API.PurchaseOrder)

    Private _purchaseorder As Pastel.Evolution.PurchaseOrder
    Protected Friend Property PurchaseOrder As Pastel.Evolution.PurchaseOrder
        Get
            If _purchaseorder Is Nothing And Instance.ERPPurchaseOrderID.HasValue Then
                _purchaseorder = New Pastel.Evolution.PurchaseOrder(Instance.ERPPurchaseOrderID.Value)
            End If
            Return _purchaseorder
        End Get
        Set(value As Pastel.Evolution.PurchaseOrder)
            _purchaseorder = value
            If value IsNot Nothing AndAlso value.ID > 0 Then
                Instance.ERPPurchaseOrderID = value.ID
            End If
        End Set
    End Property

    Public Sub New(ByVal po As API.PurchaseOrder)
        MyBase.New(po)
    End Sub

    Protected Overrides Sub Run()
        Try

            SendPurchaseOrderToERP()

        Catch ex As Exception
            Add("", New Exception(String.Format("Error sending Purchase Order To Erp. {0}", ex.Message)))
            RollbackTran = True

        End Try
    End Sub

    Public Overridable Sub SendPurchaseOrderToERP()
        If Not API.Context.Defaults.JobCardCreateRequisitionLines Then Exit Sub
        If Me.Instance Is Nothing Then
            Throw New Exception("Shopfloor PurchaseOrder not found.")
        End If
        Add(String.Format("Sending Job({0}) PO for supplier({1}) to ERP...", Instance.Job.JobNumber, Instance.Supplier.Account))
        'Checks if Job is still active
        'Tawanda Edits

        Try
            Dim ERPJobCard = New Pastel.Evolution.JobCard(CType(Instance.Job.JobCardID, Integer))
            'Checks if ERP Job is still active
            If ERPJobCard.Status = 2 Then 'Pastel.Evolution.JobStatus.Completed Then
                Throw New Exception("Error ERP JobCard is not active.")
            End If
        Catch ex As Exception
            Dim Conversation As Castle.ActiveRecord.ScopedConversation = New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                Instance.Job.JobCardID = 0
                Instance.SaveAndFlush()
            End Using
            Dim xftr As New xfShopFloorTriggerRunner(Of API.Job)
            xftr.Run(Instance.Job, 0)
            xftr.ShowDialog()

            If xftr.Errors.Count > 0 Then
                Dim ss As String = ""
                For Each Val As Exception In xftr.Errors.ToArray
                    ss = ss & vbCrLf & Val.Message
                Next
                'Throw New Exception(vbCrLf & vbCrLf & vbCrLf & "Portuguese Error Message" & vbCrLf & ss)
                Throw New Exception(vbCrLf & vbCrLf & vbCrLf & "Gestao de Compras(Procurement)- Processo incompleto" & vbCrLf & ss)
            End If
        End Try



        'Try
        '    Dim ERPJobCard = New Pastel.Evolution.JobCard(CType(Instance.Job.JobCardID, Integer))
        '    'Checks if ERP Job is still active
        '    If ERPJobCard.Status = 2 Then 'Pastel.Evolution.JobStatus.Completed Then
        '        Throw New Exception("Error ERP JobCard is not active.")
        '    End If
        'Catch ex As Exception
        '    Throw New Exception("Error Checking ERP JobCard Status.")
        'End Try

        If Instance.ERPPurchaseOrderID > 0 Then 'Tawanda Project Edits 
            Throw New Exception("ERP PurchaseOrder has already been created.")
        Else
            If Instance.Job IsNot Nothing AndAlso Instance.Job.JobCardID IsNot Nothing Then
                PurchaseOrder = New Pastel.Evolution.PurchaseOrder
                With PurchaseOrder
                    .Supplier = New Pastel.Evolution.Supplier(Instance.Supplier.DCLink)
                    .DeliverTo = .Supplier.PhysicalAddress
                    .InvoiceTo = .Supplier.PostalAddress
                    .Project = .Project

                    If Instance.RequiredDate IsNot Nothing Then
                        .DeliveryDate = Instance.RequiredDate
                    End If
                    .Description = "JobCard Purchase Order"
                    If Instance.RequiredDate IsNot Nothing Then
                        .DueDate = Instance.RequiredDate
                    End If
                    .OrderDate = Instance.OrderDate
                    If Instance.OrderNumber IsNot Nothing Then
                        .OrderNo = Instance.OrderNumber
                    End If
                    .ExternalOrderNo = Instance.Job.JobNumber
                End With
            Else
                Throw New Exception("Job not linked or ERP JobCard not yet created.")
            End If
        End If

        PurchaseOrder.Save()

        Instance.ERPPurchaseOrderID = PurchaseOrder.ID

        If Me.PurchaseOrder IsNot Nothing Then
            For Each pol As API.PurchaseOrderLine In Instance.PurchaseOrderLines
                Using t As New PurchaseOrderLineToErp(pol, PurchaseOrder, API.Context.Defaults)
                    t.Subscribe(Me)
                    t.CallRun()
                End Using
            Next
        Else
            Throw New Exception("Error locating ERP PurchaseOrder when posting PurchaseOrder.")
        End If

        Instance.SaveAndFlush()

    End Sub
    Public Overridable Sub SendPurchaseOrderToFC()



    End Sub


    Protected Overrides Sub RunReport()

    End Sub

End Class