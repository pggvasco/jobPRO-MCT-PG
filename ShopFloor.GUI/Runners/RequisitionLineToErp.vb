Public Class RequisitionLineToErp
    Inherits ShopFloorTrigger(Of API.RequisitionLine)
    Public Property ErpRequisition As Pastel.Evolution.JobCard
    Private _erprequisitionline As Pastel.Evolution.JobDetail
    Protected Friend Property ERPRequisitionLine As Pastel.Evolution.JobDetail
        Get
            If _erprequisitionline Is Nothing And Instance.ERPRequisitionLineID.HasValue Then
                _erprequisitionline = New Pastel.Evolution.JobDetail(CType(Instance.ERPRequisitionLineID.Value, Integer))
            End If
            Return _erprequisitionline
        End Get
        Set(value As Pastel.Evolution.JobDetail)
            _erprequisitionline = value
            If value IsNot Nothing AndAlso value.ID > 0 Then
                Instance.ERPRequisitionLineID = value.ID
            End If
        End Set
    End Property

    Public Sub New(ByVal reqLine As API.RequisitionLine, ByVal erpJobCard As Pastel.Evolution.JobCard, ByVal defaults As API.Defaults)
        MyBase.New(reqLine, defaults)
        Me.ErpRequisition = erpJobCard
    End Sub

    Protected Overrides Sub Run()
        Try
            SendRequisitionLineToERP()
        Catch ex As Exception
            Add("", New Exception(String.Format("Error sending Requisition Line To Erp. {0}", ex.Message)))
            RollbackTran = True
        End Try
    End Sub

    Public Overridable Sub SendRequisitionLineToERP()

        If Not API.Context.Defaults.JobCardCreateRequisitionLines OrElse Instance.Quantity <= 0 Then Exit Sub
        Add(String.Format("Sending Item({0}) to ERP...", Instance.InventoryItem.Code))
        If Instance.ERPRequisitionLineID > 0 Then
            Throw New Exception("Requisition line has already been created.")
        End If

        Me.ERPRequisitionLine = New Pastel.Evolution.JobDetail


        With Me.ERPRequisitionLine
            Try
                'Tawanda Date 

                '.StartDate = Instance.JobLine.Job.JobDate
                .StartDate = Date.Now
            Catch ex As Exception

            End Try
            .TransactionCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Inventory, Instance.JobLine.GetTransactionCode)
            .InventoryItemID = Instance.InventoryItem.ID

            If Instance.JobLine.ProjectID IsNot Nothing AndAlso IsDBNull(Instance.JobLine.ProjectID) = False Then
                If Instance.JobLine.ProjectID > 0 Then
                    .ProjectID = Instance.JobLine.ProjectID
                End If
            End If

            If Not String.IsNullOrEmpty(API.Context.Defaults.ManufacturingWarehouse) AndAlso .InventoryItem.IsWarehouseTracked Then
                .Warehouse = New Pastel.Evolution.Warehouse(API.Context.Defaults.ManufacturingWarehouse)

                Try
                    If Instance.JobLine.WarehouseID > 0 Then
                        .Warehouse = New Pastel.Evolution.Warehouse(Convert.ToInt32(Instance.JobLine.WarehouseID))
                    End If
                Catch ex As Exception
                    Throw New Exception("Warehouse Error:" & ex.Message.ToString)
                End Try
            End If

            'If Not String.IsNullOrEmpty(API.Context.Defaults.ManufacturingWarehouse) AndAlso .InventoryItem.IsWarehouseTracked Then
            '    .Warehouse = New Pastel.Evolution.Warehouse(.InventoryItem.LinkedWarehouse)
            'End If

            If API.Context.Defaults.RevenueMethod = API.RevenueMethod.PerLine OrElse (API.Context.Defaults.RevenueMethod = API.RevenueMethod.JobTypeDefined AndAlso Instance.JobLine.Job.JobType.RevenueMethod = API.RevenueMethod.PerLine) Then
                If Instance.JobLine.LineDiscountPercent IsNot Nothing Then
                    .DiscountPercent = Instance.JobLine.LineDiscountPercent * 100
                    If Instance.JobLine.UnitPriceBeforeDiscount Is Nothing Then
                        .UnitSellingPrice = 0
                    Else
                        .UnitSellingPrice = Instance.JobLine.UnitPriceBeforeDiscount

                    End If
                Else
                    If Instance.JobLine.UnitPrice Is Nothing Then
                        .UnitSellingPrice = 0
                    Else
                        .UnitSellingPrice = Instance.JobLine.UnitPrice
                    End If
                End If

                '.UnitSellingPrice = Instance.JobLine.UnitPrice
            Else
                .UnitSellingPrice = 0
            End If


            'If .Then Then
            '    'Me.CurrencyID = supplier.CurrencyID
            '    purchaseOrderline.UnitSellingPriceForeign = Me.UnitSellingPrice
            '    Dim Currency = New Pastel.Evolution.Currency(supplier.CurrencyID)
            '    'Dim Exchangerate = New Pastel.Evolution.ExchangeRate(Currency.ID, Me.OrderDate)

            '    Dim SellingPrice As Double = Currency.Rates(Me.OrderDate).SellingRate
            '    purchaseOrderline.UnitSellingPrice = (Me.UnitSellingPrice * SellingPrice)
            '    Me.ExchangeRate = SellingPrice
            'Else
            '    purchaseOrderline.UnitSellingPrice = Me.UnitSellingPrice
            'End If

            If Instance.JobLine.Description1 IsNot Nothing Then
                If Instance.JobLine.Description1.Length > 40 Then
                    .Description = Instance.JobLine.Description1.Substring(0, 40)
                Else
                    .Description = Instance.JobLine.Description1
                End If
            Else
                .Description = ""
            End If
            .Quantity = Instance.Quantity

            If API.Context.Defaults.JobCardCreateBudgetLines Then
                .BudgetUnitCostPrice = 0
                .BudgetUnitSellingPrice = 0
            End If

            .Status = Pastel.Evolution.JobCard.JobStatus.Active


            'TODO: Checks and sets Vat
            Dim PastelClient As Pastel.Evolution.Customer = New Pastel.Evolution.Customer(CType(Instance.JobLine.Job.Customer.ID, Integer))
            If PastelClient.ChargeTax = False Then
                Dim jobDefaults As Pastel.Evolution.Defaults = New Pastel.Evolution.Defaults
                .SalesTaxRate = jobDefaults.DebtorsZeroTaxRate
                .PurchasesTaxRate = jobDefaults.DebtorsZeroTaxRate
            End If

            'Populates user fields
            Try
                '.UserFields("ufJCTxSTJobProPrice") = Instance.Quantity * Instance.JobLine.UnitPrice
                'If Instance.JobLine.WorkCentreCategory IsNot Nothing Then
                '    .UserFields("ucJCTxSTJobProCategory") = Instance.JobLine.WorkCentreCategory.Code
                'End If
            Catch ex As Exception
            End Try

        End With
        If Me.ERPRequisitionLine.InventoryItem.QtyFree < Instance.Quantity Then
            Throw New Exception(String.Format("Inefficient Quantity available for product {0}. ordered {1}, availible {2}.", Me.ERPRequisitionLine.InventoryItem.Code, Instance.Quantity, Me.ERPRequisitionLine.InventoryItem.QtyFree))
        End If

        'ToDo: Test delete does not delete any job info
        ErpRequisition.Detail.Add(ERPRequisitionLine)
        Try
            ErpRequisition.Save()
        Catch ex As Exception
            Instance.Delete()
            RollbackTran = True
            'Throw New Exception("Request line TO ERP Error")
            Throw New Exception(ex.Message)
        End Try
        Instance.ERPRequisitionLineID = ERPRequisitionLine.ID
        'Instance.SaveAndFlush()
    End Sub

    Protected Overrides Sub RunReport()
    End Sub
End Class