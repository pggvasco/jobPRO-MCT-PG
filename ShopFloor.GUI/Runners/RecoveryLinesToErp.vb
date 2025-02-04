Public Class RecoveryLinesToErp
    Inherits ShopFloorTrigger(Of API.JobLine)

    Public Property JobCard As Pastel.Evolution.JobCard

    Private _erprecoveryline As Pastel.Evolution.JobDetail
    Protected Friend Property ERPRecoveryLine As Pastel.Evolution.JobDetail
        Get
            If _erprecoveryline Is Nothing And Instance.ERPRecoveryLineID.HasValue Then
                _erprecoveryline = New Pastel.Evolution.JobDetail(Instance.ERPRecoveryLineID.Value)
            End If
            Return _erprecoveryline
        End Get
        Set(value As Pastel.Evolution.JobDetail)
            _erprecoveryline = value
            If value IsNot Nothing AndAlso value.ID > 0 Then
                Instance.ERPRecoveryLineID = value.ID
            End If
        End Set
    End Property

    Public Sub New(ByVal jobLine As API.JobLine, ByVal jobCard As Pastel.Evolution.JobCard, ByVal defaults As API.Defaults)
        MyBase.New(jobLine, defaults)
        Me.JobCard = jobCard
    End Sub

    Protected Overrides Sub Run()
        Try
            SendRecoveryLineToErp()
        Catch ex As Exception
            Add("", New Exception(String.Format("Error sending Recovery Line To Erp. {0}", ex.Message)))
            RollbackTran = True
        End Try
    End Sub

    Protected Friend Overridable Sub SendRecoveryLineToErp()
        If Not API.Context.Defaults.ERPIntegrationMethod = API.ERPIntegrationMethod.JobCard AndAlso Not API.Context.Defaults.JobCardCreateRecoveryLines Then Exit Sub
        'To check the 
        'Tawanda edits
        If Instance.ERPRecoveryLineID > 0 Then
            Try
                'check via SDK for that record in JctxLines
                Dim ids As Long = Instance.ERPRecoveryLineID
                ERPRecoveryLine = New Pastel.Evolution.JobDetail(ids)

                Add("", New Exception(String.Format("Recovery Line has already been sent to ERP, JobCardDetail created with ID {0}.", Instance.ERPRecoveryLineID)))
                Exit Sub
            Catch ex As Exception
                Instance.ERPRecoveryLineID = 0
            End Try

        End If

        If Instance.WorkCentre Is Nothing Then Exit Sub
        If Instance.WorkCentre.CalculationType <> API.CalculationType.Recovery Then Exit Sub
        If Instance.WorkCentre.IsBuyOut Then Exit Sub

        ERPRecoveryLine = New Pastel.Evolution.JobDetail
        With ERPRecoveryLine
            Try
                'Tawanda Date 
                '.StartDate = Instance.Job.JobDate
                .StartDate = Date.Now
            Catch ex As Exception

            End Try
            .TransactionCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Inventory, Instance.GetTransactionCode)
            .InventoryItemID = Instance.InventoryItem.ID

            If Not String.IsNullOrEmpty(API.Context.Defaults.ManufacturingWarehouse) AndAlso .InventoryItem.IsWarehouseTracked Then
                .Warehouse = New Pastel.Evolution.Warehouse(API.Context.Defaults.ManufacturingWarehouse)
            End If

            If Instance.ProjectID IsNot Nothing AndAlso IsDBNull(Instance.ProjectID) = False Then
                If Instance.ProjectID > 0 Then
                    .ProjectID = Instance.ProjectID
                End If
            End If

            If Instance.Description1 IsNot Nothing Then
                If Instance.Description1.Length > 40 Then
                    .Description = Instance.Description1.Substring(0, 40)
                Else
                    .Description = Instance.Description1
                End If
            Else
                .Description = ""
            End If
            .Quantity = Instance.Quantity
            '.Quantity = Instance.Quantity * (IIf(Instance.EstimatedDuration.HasValue, Instance.EstimatedDuration, 0) / 60)
            '.UnitCostPrice = Instance.UnitCost

            If API.Context.Defaults.RevenueMethod = API.RevenueMethod.PerLine OrElse (API.Context.Defaults.RevenueMethod = API.RevenueMethod.JobTypeDefined AndAlso Instance.Job.JobType.RevenueMethod = API.RevenueMethod.PerLine) Then
                .UnitSellingPrice = Instance.UnitPrice
            End If

            'If JobCard.Account.IsForeignCurrencyAccount Then
            '    'Me.CurrencyID = supplier.CurrencyID
            '    Dim Currency = New Pastel.Evolution.Currency(JobCard.Account.CurrencyID)
            '    'Dim Exchangerate = New Pastel.Evolution.ExchangeRate(Currency.ID, Me.OrderDate)

            '    Dim SellingPrice As Double = Currency.Rates(DateTime.Now).SellingRate
            '    .UnitSellingPrice = (.UnitSellingPrice * SellingPrice)

            'End If

            If API.Context.Defaults.JobCardCreateBudgetLines Then
                .BudgetUnitCostPrice = 0
                .BudgetUnitSellingPrice = 0
            End If

            'Populates user fields
            Try
                '.UserFields("ufJCTxSTJobProPrice") = Instance.Quantity * Instance.UnitPrice
                'If Instance.WorkCentreCategory IsNot Nothing Then
                '    .UserFields("ucJCTxSTJobProCategory") = Instance.WorkCentreCategory.Code
                'End If
            Catch ex As Exception
            End Try

            'TODO: Checks and sets Vat
            Dim PastelClient As Pastel.Evolution.Customer = New Pastel.Evolution.Customer(CType(Instance.Job.Customer.ID, Integer))
            If PastelClient.ChargeTax = False Then
                Dim jobDefaults As Pastel.Evolution.Defaults = New Pastel.Evolution.Defaults
                .SalesTaxRate = jobDefaults.DebtorsZeroTaxRate
                .PurchasesTaxRate = jobDefaults.DebtorsZeroTaxRate
            End If
            .Status = Pastel.Evolution.JobCard.JobStatus.Active
        End With

        JobCard.Detail.Add(ERPRecoveryLine)
        JobCard.Save()
        Instance.ERPRecoveryLineID = ERPRecoveryLine.ID

    End Sub

    Protected Overrides Sub RunReport()

    End Sub

End Class
