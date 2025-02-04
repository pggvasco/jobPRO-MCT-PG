Public Class StandardLinetoERP

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
            SendStandardLinetoERP()
        Catch ex As Exception
            RollbackTran = True
            Add("", New Exception(String.Format("Error sending Standard Line To Erp. {0}", ex.Message)))
        End Try
    End Sub

    Protected Friend Overridable Sub SendStandardLinetoERP()
        If Not API.Context.Defaults.ERPIntegrationMethod = API.ERPIntegrationMethod.JobCard AndAlso Not API.Context.Defaults.JobCardCreateRecoveryLines Then Exit Sub
        If Instance.ERPRecoveryLineID > 0 Then
            'Tawanda Edit
            'Add("", New Exception(String.Format("Standard Line has already been sent to ERP, JobCardDetail created with ID {0}.", Instance.ERPRecoveryLineID)))
            'Exit Sub
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
        If Instance.WorkCentre.CalculationType <> API.CalculationType.Standard Then Exit Sub
        ERPRecoveryLine = New Pastel.Evolution.JobDetail

        'Try
        '    ERPRecoveryLine.TransactionCode = New Pastel.Evolution.JobTransactionCode(Instance.WorkCentre.CostCentre.TransactionCode)

        'Catch ex As Exception
        '    'portuguese error relating to account and tr code
        '    Throw New Exception(vbCrLf & vbCrLf & "Tipo de Transaccao nao encontrado" & vbCrLf & Instance.WorkCentre.APExpense & Instance.WorkCentre.CostCentre.TransactionCode, ex)
        'End Try


        With ERPRecoveryLine

            If (Instance.WorkCentre.GLExpense = False Or Instance.WorkCentre.GLExpense Is Nothing) And (Instance.WorkCentre.APExpense = False Or Instance.WorkCentre.APExpense Is Nothing) Then
                Exit Sub
            End If


            If Instance.WorkCentre.GLExpense Then

                Try
                    Dim trcode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Ledger, Instance.WorkCentre.CostCentre.TransactionCode)

                Catch ex As Exception
                    'portuguese error relating to account and tr code
                    Throw New Exception(vbCrLf & vbCrLf & "Tipo de Transaccao nao encontrado" & vbCrLf & Instance.WorkCentre.CostCentre.TransactionCode, ex)
                End Try

                'Check for the GL code 
                Try
                    Dim acc = New Pastel.Evolution.GLAccount(Instance.GLAccount)
                Catch ex As Exception
                    'portuguese error relating to account and tr code
                    Throw New Exception(vbCrLf & vbCrLf & vbCrLf & "Conta do Razão Geral Invalido" & vbCrLf & Instance.GLAccount, ex)
                End Try

                ''If Instance.GLAccount Is Nothing Then
                ''    Dim TransCode As Pastel.Evolution.JobTransactionCode
                ''    TransCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Ledger, Instance.WorkCentre.CostCentre.TransactionCode)
                ''    .Account = New Pastel.Evolution.GLAccount(TransCode.RecoveryAccount.Code)
                ''Else
                '.Account = New Pastel.Evolution.GLAccount(Instance.GLAccount)
                ''End If

                '.TransactionCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Ledger, Instance.WorkCentre.CostCentre.TransactionCode)
                ''.TransactionCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Ledger, "FL")


                Try
                    Try
                        'Tawanda Changes 2019/08/01
                        .Account = New Pastel.Evolution.GLAccount(Instance.GLAccount)
                        .TransactionCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Ledger, Instance.WorkCentre.CostCentre.TransactionCode)

                    Catch ex As Exception
                        .Account = New Pastel.Evolution.GLAccount(Instance.GLAccount)
                        .TransactionCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Ledger, Instance.WorkCentre.CostCentre.TransactionCode)
                    End Try
                Catch ex As Exception
                    'portuguese error relating to account and tr code
                    Throw New Exception(vbCrLf & vbCrLf & "Tipo de Transaccao nao encontrado  / Conta do Razão Geral Invalido" & vbCrLf & Instance.WorkCentre.CostCentre.TransactionCode & Instance.GLAccount, ex)
                End Try

            End If

            If Instance.WorkCentre.APExpense Then

                Try
                    Dim trcode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Payables, Instance.WorkCentre.CostCentre.TransactionCode)

                Catch ex As Exception
                    'portuguese error relating to account and tr code
                    Throw New Exception(vbCrLf & vbCrLf & "Tipo de Transaccao nao encontrado" & vbCrLf & Instance.WorkCentre.CostCentre.TransactionCode, ex)
                End Try

                'check for the supplier
                Try
                    Dim acc = New Pastel.Evolution.Supplier(Convert.ToInt32(Instance.Supplier1ID))
                Catch ex As Exception
                    'portuguese error relating to account and tr code
                    Throw New Exception(vbCrLf & vbCrLf & vbCrLf & "Conta do Fornecedor Invalido" & vbCrLf & Instance.Supplier1ID, ex)
                End Try
                .Account = New Pastel.Evolution.Supplier(Convert.ToInt32(Instance.Supplier1ID))
                .TransactionCode = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Payables, Instance.WorkCentre.CostCentre.TransactionCode)
            End If
            If Instance.ProjectID IsNot Nothing AndAlso IsDBNull(Instance.ProjectID) = False Then
                If Instance.ProjectID > 0 Then
                    .ProjectID = Instance.ProjectID
                End If
            End If
            Try
                'Tawanda Dates 
                '.StartDate = Instance.Job.JobDate
                '.EndDate = Instance.Job.JobDate
                'Instance.JobLineDate = Instance.Job.JobDate

                .StartDate = Date.Now
                .EndDate = Date.Now
                Instance.JobLineDate = Date.Now


            Catch ex As Exception

            End Try

            .UnitCostPrice = Instance.UnitCost
            .UnitSellingPrice = Instance.UnitPrice
            .Quantity = Instance.Quantity

            'If Not String.IsNullOrEmpty(API.Context.Defaults.ManufacturingWarehouse) AndAlso .InventoryItem.IsWarehouseTracked Then
            '    .Warehouse = New Pastel.Evolution.Warehouse(API.Context.Defaults.ManufacturingWarehouse)
            'End If

            If Instance.Description1 IsNot Nothing Then
                If Instance.Description1.Length > 40 Then
                    .Description = Instance.Description1.Substring(0, 40)
                Else
                    .Description = Instance.Description1
                End If
            Else
                .Description = ""
            End If


            ' If API.Context.Defaults.RevenueMethod = API.RevenueMethod.PerLine OrElse (API.Context.Defaults.RevenueMethod = API.RevenueMethod.JobTypeDefined AndAlso Instance.Job.JobType.RevenueMethod = API.RevenueMethod.PerLine) Then

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
            Else
                Dim IsSalesTax As Boolean = Convert.ToBoolean(Pastel.Evolution.DatabaseContext.ExecuteCommandScalar("Select bSalesFilter  from JobTxTp  Where idJobTxTp =" & .TransactionCode.ID).ToString())

                If Instance.WorkCentre.GLExpense And IsSalesTax Then
                    .SalesTaxRate = New Pastel.Evolution.TaxRate(.TransactionCode.SellingTaxType.Code)

                End If
                If Instance.WorkCentre.APExpense And IsSalesTax = False Then
                    .SalesTaxRate = New Pastel.Evolution.TaxRate(.TransactionCode.CostingTaxType.Code)

                End If

            End If
            .Status = Pastel.Evolution.JobCard.JobStatus.Active
        End With

        JobCard.Detail.Add(ERPRecoveryLine)
        Dim ss As String
        For Each jobl As Pastel.Evolution.JobDetail In JobCard.Detail
            ss = jobl.StartDate.ToString
            ss = jobl.EndDate.ToString
        Next

        JobCard.Save()
        Instance.ERPRecoveryLineID = ERPRecoveryLine.ID

    End Sub

    Protected Overrides Sub RunReport()

    End Sub

End Class
