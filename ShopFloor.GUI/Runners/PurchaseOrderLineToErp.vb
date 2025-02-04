Public Class PurchaseOrderLineToErp
    Inherits ShopFloorTrigger(Of API.PurchaseOrderLine)

    Public Property ErpPurchaseOrder As Pastel.Evolution.PurchaseOrder

    Private _erppurchaseorderline As Pastel.Evolution.OrderDetail
    Protected Friend Property ERPPurchaseOrderLine As Pastel.Evolution.OrderDetail
        Get
            If _erppurchaseorderline Is Nothing And Instance.ERPPurchaseOrderLineID.HasValue Then
                _erppurchaseorderline = New Pastel.Evolution.OrderDetail(Instance.ERPPurchaseOrderLineID.Value)
            End If
            Return _erppurchaseorderline
        End Get
        Set(value As Pastel.Evolution.OrderDetail)
            _erppurchaseorderline = value
            If value IsNot Nothing AndAlso value.ID > 0 Then
                Instance.ERPPurchaseOrderLineID = value.ID
            End If
        End Set
    End Property

    Public Sub New(ByVal reqLine As API.PurchaseOrderLine, ByVal erpPurchaseOrder As Pastel.Evolution.PurchaseOrder, ByVal defaults As API.Defaults)
        MyBase.New(reqLine, defaults)
        Me.ErpPurchaseOrder = erpPurchaseOrder
    End Sub

    Protected Overrides Sub Run()
        Try
            SendPurchaseOrderLineToERP()
        Catch ex As Exception
            Add("", New Exception(String.Format("Error sending Purchase Order Line To Erp. {0}", ex.Message)))
            RollbackTran = True
        End Try
    End Sub

    Public Overridable Sub SendPurchaseOrderLineToERP()
        If Not API.Context.Defaults.JobCardCreatePurchaseOrders Then Exit Sub

        Add(String.Format("Sending PO Item({0}) to ERP...", Instance.InventoryItem.Code))
        If Instance.ERPPurchaseOrderLineID > 0 Then
            Throw New Exception("Purchase Order line has already been created.")
        End If

        Me.ERPPurchaseOrderLine = New Pastel.Evolution.OrderDetail

        With Me.ERPPurchaseOrderLine
            .InventoryItemID = Instance.InventoryItem.ID

            If Not String.IsNullOrEmpty(API.Context.Defaults.ManufacturingWarehouse) AndAlso .InventoryItem.IsWarehouseTracked Then
                '.Warehouse = New Pastel.Evolution.Warehouse(API.Context.Defaults.ManufacturingWarehouse)

                Try
                    If Instance.JobLine.WarehouseID > 0 Then
                        .Warehouse = New Pastel.Evolution.Warehouse(Convert.ToInt32(Instance.JobLine.WarehouseID))
                    End If
                Catch ex As Exception

                End Try
            End If

            If Instance.JobLine.Description1 IsNot Nothing Then
                If Instance.JobLine.Description1.Length > 40 Then
                    .Description = Instance.JobLine.Description1.Substring(0, 40)
                Else
                    .Description = Instance.JobLine.Description1
                End If
            Else
                .Description = ""
            End If
            .JobID = Instance.JobLine.Job.JobCardID

            'Tawanda to remove 
            If Instance.LineNote IsNot Nothing Then
                .Note = Instance.LineNote
            Else
                .Note = "PO"
            End If

            'Tawanda to remove 
            If Instance.JobLine.ProjectID IsNot Nothing Then
                .ProjectID = Instance.JobLine.ProjectID
            Else
                .ProjectID = 0
            End If

            Try
                .Quantity = Instance.Quantity
                '.UnitSellingPrice = Instance.UnitPrice
            Catch ex As Exception
                .Quantity = 0
                '.UnitSellingPrice = Instance.UnitPrice
            End Try
           

            Try
                .UnitSellingPrice = Instance.JobLine.UnitCost
            Catch ex As Exception
                .UnitSellingPrice = 0
            End Try

            '* 100 else evo calcs it incorrectly
            Try
                .DiscountPercent = CDbl(Instance.JobLine.PurchaseDiscountPercent * 100)
            Catch ex As Exception
                .DiscountPercent = 0
            End Try

            'Populates user fields
            'Try
            '    .UserFields("ufIDPOrdTxSTJobProPrice") = Instance.JobLine.UnitPrice * Instance.Quantity
            '    If Instance.JobLine.WorkCentreCategory IsNot Nothing Then
            '        .UserFields("ucIDPOrdTxSTJobProCategory") = Instance.JobLine.WorkCentreCategory.Description
            '    End If
            'Catch ex As Exception
            'End Try
        End With

        ErpPurchaseOrder.Detail.Add(ERPPurchaseOrderLine)

        ErpPurchaseOrder.Save()

        Instance.ERPPurchaseOrderLineID = ERPPurchaseOrderLine.ID

    End Sub

    Protected Overrides Sub RunReport()

    End Sub

End Class