Public Class BudgetLinesToErp
    Inherits ShopFloorTrigger(Of API.JobLine)

    Public Property JobCard As Pastel.Evolution.JobCard

    Private _erpbudgetline As Pastel.Evolution.JobDetail
    Protected Friend Property ERPBudgetLine As Pastel.Evolution.JobDetail
        Get
            If _erpbudgetline Is Nothing And Instance.ERPBudgetLineID.HasValue Then
                _erpbudgetline = New Pastel.Evolution.JobDetail(Instance.ERPBudgetLineID.Value)
            End If
            Return _erpbudgetline
        End Get
        Set(value As Pastel.Evolution.JobDetail)
            _erpbudgetline = value
            If value IsNot Nothing AndAlso value.ID > 0 Then
                Instance.ERPBudgetLineID = value.ID
            End If
        End Set
    End Property

    Public Sub New(ByVal jobLine As API.JobLine, ByVal jobCard As Pastel.Evolution.JobCard, ByVal defaults As API.Defaults)
        MyBase.New(jobLine, defaults)
        Me.JobCard = jobCard
    End Sub

    Protected Overrides Sub Run()
        Try
            SendBudgetLineToErp()
        Catch ex As Exception
            Add("", New Exception(String.Format("Error sending Budget Line To Erp. {0}", ex.Message)))
            RollbackTran = True
        End Try
    End Sub

    Protected Friend Overridable Sub SendBudgetLineToErp()
        If Not API.Context.Defaults.ERPIntegrationMethod = API.ERPIntegrationMethod.JobCard AndAlso Not API.Context.Defaults.JobCardCreateBudgetLines Then Exit Sub
        Try
            ERPBudgetLine.TransactionCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Inventory, Instance.GetTransactionCode)

        Catch ex As Exception
            'portuguese error relating to account and tr code
            Throw New Exception(vbCrLf & vbCrLf & "Portuguese Error Message" & vbCrLf & "")
        End Try

        If Instance.ERPBudgetLineID > 0 Then
            'Add("", New Exception(String.Format("Budget Line has already been sent to ERP, JobCardDetail created with ID {0}.", Instance.ERPBudgetLineID)))
            'Exit Sub
            'Tawanda 
            Try
                'check via SDK for that record in JctxLines
                Dim ids As Long = Instance.ERPBudgetLineID
                ERPBudgetLine = New Pastel.Evolution.JobDetail(ids)
                Add("", New Exception(String.Format("Recovery Line has already been sent to ERP, JobCardDetail created with ID {0}.", Instance.ERPBudgetLineID)))
                Exit Sub
            Catch ex As Exception
                Instance.ERPBudgetLineID = 0
            End Try

        End If

        If Instance.WorkCentre Is Nothing Then Exit Sub
        If Instance.WorkCentre.CalculationType = API.CalculationType.Standard Then Exit Sub
        If Instance.WorkCentre.CalculationType = API.CalculationType.Recovery Then Exit Sub

        ERPBudgetLine = New Pastel.Evolution.JobDetail '

        With ERPBudgetLine
            Try
                .StartDate = Instance.Job.JobDate
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

            Select Case Instance.WorkCentre.CalculationType
                Case API.CalculationType.Formula
                    .Quantity = Instance.Quantity
                Case API.CalculationType.Recovery
                    '.Quantity = Instance.Quantity * (IIf(Instance.EstimatedDuration.HasValue, Instance.EstimatedDuration, 0) / 60)
                    .Quantity = Instance.Quantity
                Case API.CalculationType.Standard
                    .Quantity = Instance.Quantity
            End Select

            .BudgetUnitCostPrice = Instance.UnitCost
            .BudgetUnitSellingPrice = Instance.UnitPrice

            'Populates user fields
            'Try
            '    .UserFields("ufJCTxSTJobProPrice") = Instance.Quantity * Instance.UnitPrice
            '    If Instance.WorkCentreCategory IsNot Nothing Then
            '        .UserFields("ucJCTxSTJobProCategory") = Instance.WorkCentreCategory.Description
            '    End If
            'Catch ex As Exception
            'End Try

            'TODO: Checks and sets Vat
            Dim PastelClient As Pastel.Evolution.Customer = New Pastel.Evolution.Customer(CType(Instance.Job.Customer.ID, Integer))
            If PastelClient.ChargeTax = False Then
                Dim jobDefaults As Pastel.Evolution.Defaults = New Pastel.Evolution.Defaults
                .SalesTaxRate = jobDefaults.DebtorsZeroTaxRate
                .PurchasesTaxRate = jobDefaults.DebtorsZeroTaxRate
            End If

            .Status = Pastel.Evolution.JobCard.JobStatus.Quote
        End With

        JobCard.Detail.Add(ERPBudgetLine)

        JobCard.Save()

        Instance.ERPBudgetLineID = ERPBudgetLine.ID

        'restrictInvoice(jobdetail)
    End Sub

    Protected Overrides Sub RunReport()

    End Sub
End Class
