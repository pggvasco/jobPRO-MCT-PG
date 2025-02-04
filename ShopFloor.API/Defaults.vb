Imports Castle.Components.Validator

Public Class Defaults

    Private Const DefaultPadding As Integer = 5

    Public Shared ReadOnly Property Defaults As Defaults
        Get
            Dim tmpDefaults = API.Defaults.FindFirst
            If tmpDefaults Is Nothing Then
                tmpDefaults = New API.Defaults
            End If
            Return tmpDefaults
            'Return API.Defaults.FindFirst
        End Get
    End Property

    Public Overrides Property ValidityDays As Integer?
        Get
            If MyBase.ValidityDays Is Nothing Then
                MyBase.ValidityDays = 14
            End If
            Return MyBase.ValidityDays
        End Get
        Set(value As Integer?)
            MyBase.ValidityDays = value
        End Set
    End Property


    Public Property RevenueCodeMethod As RevenueCodeMethod
        Get
            If MyBase.RevenueCodeMethodID.HasValue Then
                Return MyBase.RevenueCodeMethodID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As RevenueCodeMethod)
            MyBase.RevenueCodeMethodID = value
        End Set
    End Property

    Private _inventoryitem As Helper.ActiveRecord.Evolution.StockItem
    Public Overridable Property InventoryItem As Helper.ActiveRecord.Evolution.StockItem
        Get
            If MyBase.RevenueOneLinerInventoryItemID Is Nothing Then
                _inventoryitem = Nothing
            ElseIf _inventoryitem Is Nothing OrElse _inventoryitem.ID <> MyBase.RevenueOneLinerInventoryItemID Then
                Try
                    _inventoryitem = Helper.ActiveRecord.Evolution.StockItem.TryFind(MyBase.RevenueOneLinerInventoryItemID)
                Catch
                    'MyBase.InventoryItemID = Nothing
                    _inventoryitem = Nothing
                End Try
            End If
            If _inventoryitem Is Nothing And MyBase.RevenueOneLinerInventoryItemID IsNot Nothing Then
                MyBase.RevenueOneLinerInventoryItemID = Nothing
            End If
            Return _inventoryitem
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.StockItem)
            If (_inventoryitem <> value) Then
                _inventoryitem = value
                If value Is Nothing Then
                    MyBase.RevenueOneLinerInventoryItemID = Nothing
                Else
                    MyBase.RevenueOneLinerInventoryItemID = value.ID
                End If
                NotifyPropertyChanged("InventoryItem")
            End If
        End Set
    End Property

    Public Property JobNumberPrefixType As PrefixType
        Get
            If MyBase.JobNumberPrefixTypeID.HasValue Then
                Return MyBase.JobNumberPrefixTypeID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As PrefixType)
            MyBase.JobNumberPrefixTypeID = value
        End Set
    End Property

    Public Property PricingMethod As PricingMethod
        Get
            If MyBase.PricingMethodID.HasValue Then
                Return MyBase.PricingMethodID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As PricingMethod)
            MyBase.PricingMethodID = value
        End Set
    End Property

    Public Property SellingPriceGPCheckType As GPCheckType
        Get
            If MyBase.SellingPriceGPCheckTypeID.HasValue Then
                Return MyBase.SellingPriceGPCheckTypeID
            Else
                MyBase.SellingPriceGPCheckTypeID = GPCheckType.PerLine
            End If
            Return MyBase.SellingPriceGPCheckTypeID
        End Get
        Set(ByVal value As GPCheckType)
            MyBase.SellingPriceGPCheckTypeID = value
        End Set
    End Property

    Public Property DeliveryNumberPrefixType As PrefixType
        Get
            If MyBase.DeliveryNumberPrefixTypeID.HasValue Then
                Return MyBase.DeliveryNumberPrefixTypeID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As PrefixType)
            MyBase.DeliveryNumberPrefixTypeID = value
        End Set
    End Property

    Public Property QuoteNumberPrefixType As PrefixType
        Get
            If MyBase.QuoteNumberPrefixTypeID.HasValue Then
                Return MyBase.QuoteNumberPrefixTypeID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As PrefixType)
            MyBase.QuoteNumberPrefixTypeID = value
        End Set
    End Property

    Public Property RequisitionNumberPrefixType As PrefixType
        Get
            If MyBase.RequisitionNumberPrefixTypeID.HasValue Then
                Return MyBase.RequisitionNumberPrefixTypeID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As PrefixType)
            MyBase.RequisitionNumberPrefixTypeID = value
        End Set
    End Property

    Public Property WarehouseIssuePrefixType As PrefixType
        Get
            If MyBase.WarehouseIssueNumberPrefixTypeID.HasValue Then
                Return MyBase.WarehouseIssueNumberPrefixTypeID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As PrefixType)
            MyBase.WarehouseIssueNumberPrefixTypeID = value
        End Set
    End Property

    'Tawanda 2019/07/23 MCT Warehouse issue
    Public Property WarehouseIssueNumberPrefixType As PrefixType
        Get
            If MyBase.WarehouseIssueNumberPrefixTypeID.HasValue Then
                Return MyBase.WarehouseIssueNumberPrefixTypeID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As PrefixType)
            MyBase.WarehouseIssueNumberPrefixTypeID = value
        End Set
    End Property

    Public Property PurchaseOrderNumberPrefixType As PrefixType
        Get
            If MyBase.PurchaseOrderNumberPrefixTypeID.HasValue Then
                Return MyBase.PurchaseOrderNumberPrefixTypeID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As PrefixType)
            MyBase.PurchaseOrderNumberPrefixTypeID = value
        End Set
    End Property

    Public Property CostCentreMethod As CostCentreMethod
        Get
            If MyBase.CostCentreMethodID.HasValue Then
                Return MyBase.CostCentreMethodID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As CostCentreMethod)
            MyBase.CostCentreMethodID = value
        End Set
    End Property

    Public Property Pricelistsourceop As PricelistSource
        Get
            If MyBase.PricelistSource.HasValue Then
                Return MyBase.PricelistSource
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As PricelistSource)
            MyBase.PricelistSource = value
        End Set
    End Property

    Public Overrides Property JobLineCancelledReasonMinLenght As Short?
        Get
            If MyBase.JobLineCancelledReasonMinLenght Is Nothing Then
                Return 15
            End If
            Return MyBase.JobLineCancelledReasonMinLenght
        End Get
        Set(value As Short?)
            MyBase.JobLineCancelledReasonMinLenght = value
        End Set
    End Property

    Public Property ERPIntegrationMethod As ERPIntegrationMethod
        Get
            If MyBase.ERPIntegrationMethodID.HasValue Then
                Return MyBase.ERPIntegrationMethodID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As ERPIntegrationMethod)
            MyBase.ERPIntegrationMethodID = value
        End Set
    End Property

    Public Property RevenueMethod As RevenueMethod
        Get
            If MyBase.RevenueMethodID.HasValue Then
                Return MyBase.RevenueMethodID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As RevenueMethod)
            MyBase.RevenueMethodID = value
        End Set
    End Property

    Public Overrides Property IsTimeSheetVersion As Boolean?
        Get
            If MyBase.IsTimeSheetVersion Is Nothing Then
                Return False
            Else
                Return MyBase.IsTimeSheetVersion
            End If
        End Get
        Set(value As Boolean?)
            MyBase.IsTimeSheetVersion = value
        End Set
    End Property

    ' Freddie - 01/02/2017 dosco Supplier delivery note
    Public Overrides Property SupplierDeliveryNoteNextNumber As Integer?
        Get
            Return MyBase.SupplierDeliveryNoteNextNumber
        End Get
        Set(value As Integer?)
            MyBase.SupplierDeliveryNoteNextNumber = value
        End Set
    End Property


    Public Property SupplierDeliveryNotePrefixType As PurchaseOrderPrefixType
        Get
            If MyBase.SupplierDeliveryNotePrefixTypeID.HasValue Then
                Return (MyBase.SupplierDeliveryNotePrefixTypeID)
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As PurchaseOrderPrefixType)
            MyBase.SupplierDeliveryNotePrefixTypeID = value
        End Set
    End Property


    Public Function GetNextJobNumber(ByVal job As API.Job) As String
        If IIf(Me.IsJobNumberAutoGenerated.HasValue, Me.IsJobNumberAutoGenerated.Value, False) Then
            Select Case JobNumberPrefixType
                Case PrefixType.Default
                    Return Me.JobNumberPrefix + CStr(Me.JobNumberNextNumber).PadLeft(IIf(Me.JobNumberPadding.HasValue, Me.JobNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.CostCentre
                    If job.CostCentre Is Nothing Then Return CStr(Me.JobNumberNextNumber).PadLeft(IIf(Me.JobNumberPadding.HasValue, Me.JobNumberPadding, DefaultPadding), CChar("0"))
                    Return job.CostCentre.Code + CStr(Me.JobNumberNextNumber).PadLeft(IIf(Me.JobNumberPadding.HasValue, Me.JobNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobType
                    If job.JobType Is Nothing Then Return CStr(Me.JobNumberNextNumber).PadLeft(IIf(Me.JobNumberPadding.HasValue, Me.JobNumberPadding, DefaultPadding), CChar("0"))
                    Return job.JobType.Code + CStr(Me.JobNumberNextNumber).PadLeft(IIf(Me.JobNumberPadding.HasValue, Me.JobNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobCategory
                    If job.JobCategory Is Nothing Then Return CStr(Me.JobNumberNextNumber).PadLeft(IIf(Me.JobNumberPadding.HasValue, Me.JobNumberPadding, DefaultPadding), CChar("0"))
                    Return job.JobCategory.Code + CStr(Me.JobNumberNextNumber).PadLeft(IIf(Me.JobNumberPadding.HasValue, Me.JobNumberPadding, DefaultPadding), CChar("0"))
                Case Else
                    Return Me.JobNumberPrefix + CStr(Me.JobNumberNextNumber).PadLeft(IIf(Me.JobNumberPadding.HasValue, Me.JobNumberPadding, DefaultPadding), CChar("0"))
            End Select
        Else
            Return ""
        End If
    End Function

    Protected Friend Function GetNextJobNumberAndIncrement(ByVal job As API.Job) As String
        If IIf(Me.IsJobNumberAutoGenerated.HasValue, Me.IsJobNumberAutoGenerated.Value, False) Then
            GetNextJobNumberAndIncrement = GetNextJobNumber(job)
            Me.JobNumberNextNumber += 1
            Me.Save()
        End If
    End Function

    Public Function GetNextTemplateNumber(ByVal template As API.JobTemplate) As String
        If IIf(Me.IsTemplateNumberAutoGenerated.HasValue, Me.IsTemplateNumberAutoGenerated.Value, False) Then
            Select Case TemplateNumberPrefixType
                Case PrefixType.Default
                    Return Me.TemplateNumberPrefix + CStr(Me.TemplateNumberNextNumber).PadLeft(IIf(Me.TemplateNumberPadding.HasValue, Me.TemplateNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.CostCentre
                    If template.CostCentre Is Nothing Then Return CStr(Me.TemplateNumberNextNumber).PadLeft(IIf(Me.TemplateNumberPadding.HasValue, Me.TemplateNumberPadding, DefaultPadding), CChar("0"))
                    Return template.CostCentre.Code + CStr(Me.TemplateNumberNextNumber).PadLeft(IIf(Me.TemplateNumberPadding.HasValue, Me.TemplateNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobType
                    If template.JobType Is Nothing Then Return CStr(Me.TemplateNumberNextNumber).PadLeft(IIf(Me.TemplateNumberPadding.HasValue, Me.TemplateNumberPadding, DefaultPadding), CChar("0"))
                    Return template.JobType.Code + CStr(Me.TemplateNumberNextNumber).PadLeft(IIf(Me.TemplateNumberPadding.HasValue, Me.TemplateNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobCategory
                    If template.JobCategory Is Nothing Then Return CStr(Me.TemplateNumberNextNumber).PadLeft(IIf(Me.TemplateNumberPadding.HasValue, Me.TemplateNumberPadding, DefaultPadding), CChar("0"))
                    Return template.JobCategory.Code + CStr(Me.TemplateNumberNextNumber).PadLeft(IIf(Me.TemplateNumberPadding.HasValue, Me.TemplateNumberPadding, DefaultPadding), CChar("0"))
                Case Else
                    Return Me.TemplateNumberPrefix + CStr(Me.TemplateNumberNextNumber).PadLeft(IIf(Me.TemplateNumberPadding.HasValue, Me.TemplateNumberPadding, DefaultPadding), CChar("0"))
            End Select
        Else
            Return ""
        End If
    End Function

    Protected Friend Function GetNextTemplateNumberAndIncrement(ByVal template As API.JobTemplate) As String
        If IIf(Me.IsTemplateNumberAutoGenerated.HasValue, Me.IsTemplateNumberAutoGenerated.Value, False) Then
            GetNextTemplateNumberAndIncrement = GetNextTemplateNumber(template)
            Me.TemplateNumberNextNumber += 1
            Me.Save()
        Else
            Return ""
        End If
    End Function

    Public Function GetNextDeliveryNumber(ByVal delivery As API.JobDelivery) As String
        If IIf(Me.IsDeliveryNumberAutoGenerated.HasValue, Me.IsDeliveryNumberAutoGenerated.Value, False) Then
            Select Case DeliveryNumberPrefixType
                Case PrefixType.Default
                    Return Me.DeliveryNumberPrefix + CStr(Me.DeliveryNumberNextNumber).PadLeft(IIf(Me.DeliveryNumberPadding.HasValue, Me.DeliveryNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.CostCentre
                    If delivery.Job.CostCentre Is Nothing Then Return CStr(Me.DeliveryNumberNextNumber).PadLeft(IIf(Me.DeliveryNumberPadding.HasValue, Me.DeliveryNumberPadding, DefaultPadding), CChar("0"))
                    Return delivery.Job.CostCentre.Code + CStr(Me.DeliveryNumberNextNumber).PadLeft(IIf(Me.DeliveryNumberPadding.HasValue, Me.DeliveryNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobType
                    If delivery.Job.JobType Is Nothing Then Return CStr(Me.DeliveryNumberNextNumber).PadLeft(IIf(Me.DeliveryNumberPadding.HasValue, Me.DeliveryNumberPadding, DefaultPadding), CChar("0"))
                    Return delivery.Job.JobType.Code + CStr(Me.DeliveryNumberNextNumber).PadLeft(IIf(Me.DeliveryNumberPadding.HasValue, Me.DeliveryNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobCategory
                    If delivery.Job.JobCategory Is Nothing Then Return CStr(Me.DeliveryNumberNextNumber).PadLeft(IIf(Me.DeliveryNumberPadding.HasValue, Me.DeliveryNumberPadding, DefaultPadding), CChar("0"))
                    Return delivery.Job.JobCategory.Code + CStr(Me.DeliveryNumberNextNumber).PadLeft(IIf(Me.DeliveryNumberPadding.HasValue, Me.DeliveryNumberPadding, DefaultPadding), CChar("0"))
                Case Else
                    Return Me.DeliveryNumberPrefix + CStr(Me.DeliveryNumberNextNumber).PadLeft(IIf(Me.DeliveryNumberPadding.HasValue, Me.DeliveryNumberPadding, DefaultPadding), CChar("0"))
            End Select
        Else
            Return ""
        End If
    End Function

    Protected Friend Function GetNextDeliveryNumberAndIncrement(ByVal Delivery As API.JobDelivery) As String
        If IIf(Me.IsDeliveryNumberAutoGenerated.HasValue, Me.IsDeliveryNumberAutoGenerated.Value, False) Then
            GetNextDeliveryNumberAndIncrement = GetNextDeliveryNumber(Delivery)
            Me.DeliveryNumberNextNumber += 1
            Me.Save()
        Else
            Return ""
        End If
    End Function

    Public Function GetNextQuoteNumber(ByVal job As API.Job) As String
        If IIf(Me.IsQuoteNumberAutoGenerated.HasValue, Me.IsQuoteNumberAutoGenerated.Value, False) Then
            Select Case QuoteNumberPrefixType
                Case PrefixType.Default
                    Return Me.QuoteNumberPrefix + CStr(Me.QuoteNumberNextNumber).PadLeft(IIf(Me.QuoteNumberPadding.HasValue, Me.QuoteNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.CostCentre
                    If job.CostCentre Is Nothing Then Return CStr(Me.QuoteNumberNextNumber).PadLeft(IIf(Me.QuoteNumberPadding.HasValue, Me.QuoteNumberPadding, DefaultPadding), CChar("0"))
                    Return job.CostCentre.Code + CStr(Me.QuoteNumberNextNumber).PadLeft(IIf(Me.QuoteNumberPadding.HasValue, Me.QuoteNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobType
                    If job.JobType Is Nothing Then Return CStr(Me.QuoteNumberNextNumber).PadLeft(IIf(Me.QuoteNumberPadding.HasValue, Me.QuoteNumberPadding, DefaultPadding), CChar("0"))
                    Return job.JobType.Code + CStr(Me.QuoteNumberNextNumber).PadLeft(IIf(Me.QuoteNumberPadding.HasValue, Me.QuoteNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobCategory
                    If job.JobCategory Is Nothing Then Return CStr(Me.QuoteNumberNextNumber).PadLeft(IIf(Me.QuoteNumberPadding.HasValue, Me.QuoteNumberPadding, DefaultPadding), CChar("0"))
                    Return job.JobCategory.Code + CStr(Me.QuoteNumberNextNumber).PadLeft(IIf(Me.QuoteNumberPadding.HasValue, Me.QuoteNumberPadding, DefaultPadding), CChar("0"))
                Case Else
                    Return Me.QuoteNumberPrefix + CStr(Me.QuoteNumberNextNumber).PadLeft(IIf(Me.QuoteNumberPadding.HasValue, Me.QuoteNumberPadding, DefaultPadding), CChar("0"))
            End Select
        Else
            Return ""
        End If
    End Function

    Protected Friend Function GetNextQuoteNumberAndIncrement(ByVal job As API.Job) As String
        If IIf(Me.IsQuoteNumberAutoGenerated.HasValue, Me.IsQuoteNumberAutoGenerated.Value, False) Then
            GetNextQuoteNumberAndIncrement = GetNextQuoteNumber(job)
            Me.QuoteNumberNextNumber += 1
            Me.Save()
        Else
            Return ""
        End If
    End Function

    Public Function GetNextRequisitionNumber(ByVal job As API.Job) As String

        If IIf(Me.IsRequisitionNumberAutoGenerated.HasValue, Me.IsRequisitionNumberAutoGenerated.Value, False) Then
            Select Case RequisitionNumberPrefixType
                Case PrefixType.Default
                    Return Me.RequisitionNumberPrefix + CStr(Me.RequisitionNumberNextNumber).PadLeft(IIf(Me.RequisitionNumberPadding.HasValue, Me.RequisitionNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.CostCentre
                    If job.CostCentre Is Nothing Then Return CStr(Me.RequisitionNumberNextNumber).PadLeft(IIf(Me.RequisitionNumberPadding.HasValue, Me.RequisitionNumberPadding, DefaultPadding), CChar("0"))
                    Return job.CostCentre.Code + CStr(Me.RequisitionNumberNextNumber).PadLeft(IIf(Me.RequisitionNumberPadding.HasValue, Me.RequisitionNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobType
                    If job.JobType Is Nothing Then Return CStr(Me.RequisitionNumberNextNumber).PadLeft(IIf(Me.RequisitionNumberPadding.HasValue, Me.RequisitionNumberPadding, DefaultPadding), CChar("0"))
                    Return job.JobType.Code + CStr(Me.RequisitionNumberNextNumber).PadLeft(IIf(Me.RequisitionNumberPadding.HasValue, Me.RequisitionNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobCategory
                    If job.JobCategory Is Nothing Then Return CStr(Me.RequisitionNumberNextNumber).PadLeft(IIf(Me.RequisitionNumberPadding.HasValue, Me.RequisitionNumberPadding, DefaultPadding), CChar("0"))
                    Return job.JobCategory.Code + CStr(Me.RequisitionNumberNextNumber).PadLeft(IIf(Me.RequisitionNumberPadding.HasValue, Me.RequisitionNumberPadding, DefaultPadding), CChar("0"))
                Case Else
                    Return Me.RequisitionNumberPrefix + CStr(Me.RequisitionNumberNextNumber).PadLeft(IIf(Me.RequisitionNumberPadding.HasValue, Me.RequisitionNumberPadding, DefaultPadding), CChar("0"))
            End Select
        Else
            Return ""
        End If


    End Function

    Public Function GetNextRequisitionNumberAndIncrement(ByVal job As API.Job) As String

        If IIf(Me.IsRequisitionNumberAutoGenerated.HasValue, Me.IsRequisitionNumberAutoGenerated.Value, False) Then
            GetNextRequisitionNumberAndIncrement = GetNextRequisitionNumber(job)
            Me.RequisitionNumberNextNumber += 1
            Me.Save()
        Else
            Return ""
        End If

    End Function

    Public Function GetNextWarehouseIssueNumber(ByVal job As API.Job) As String
        'Tawanda
        If IIf(Me.isWarehouseIssueNumberAutoGenerated.HasValue, Me.isWarehouseIssueNumberAutoGenerated.Value, False) Then
            Select Case WarehouseIssueNumberPrefixType
                Case PrefixType.Default
                    Return Me.WarehouseIssueNumberPrefix + CStr(Me.WarehouseIssueNumberNextNumber).PadLeft(IIf(Me.WarehouseIssueNumberPadding.HasValue, Me.WarehouseIssueNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.CostCentre
                    If job.CostCentre Is Nothing Then Return CStr(Me.WarehouseIssueNumberNextNumber).PadLeft(IIf(Me.WarehouseIssueNumberPadding.HasValue, Me.WarehouseIssueNumberPadding, DefaultPadding), CChar("0"))
                    Return job.CostCentre.Code + CStr(Me.WarehouseIssueNumberNextNumber).PadLeft(IIf(Me.WarehouseIssueNumberPadding.HasValue, Me.WarehouseIssueNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobType
                    If job.JobType Is Nothing Then Return CStr(Me.WarehouseIssueNumberNextNumber).PadLeft(IIf(Me.WarehouseIssueNumberPadding.HasValue, Me.WarehouseIssueNumberPadding, DefaultPadding), CChar("0"))
                    Return job.JobType.Code + CStr(Me.WarehouseIssueNumberNextNumber).PadLeft(IIf(Me.WarehouseIssueNumberPadding.HasValue, Me.WarehouseIssueNumberPadding, DefaultPadding), CChar("0"))
                Case PrefixType.JobCategory
                    If job.JobCategory Is Nothing Then Return CStr(Me.WarehouseIssueNumberNextNumber).PadLeft(IIf(Me.WarehouseIssueNumberPadding.HasValue, Me.WarehouseIssueNumberPadding, DefaultPadding), CChar("0"))
                    Return job.JobCategory.Code + CStr(Me.WarehouseIssueNumberNextNumber).PadLeft(IIf(Me.WarehouseIssueNumberPadding.HasValue, Me.WarehouseIssueNumberPadding, DefaultPadding), CChar("0"))
                Case Else
                    Return Me.WarehouseIssueNumberPrefixType + CStr(Me.WarehouseIssueNumberNextNumber).PadLeft(IIf(Me.WarehouseIssueNumberPadding.HasValue, Me.WarehouseIssueNumberPadding, DefaultPadding), CChar("0"))
            End Select
        Else
            Return ""
        End If


    End Function

    'Tawanda
    Protected Friend Function GetNextWarehouseIssueNumberAndIncrement(ByVal job As API.Job) As String

        If IIf(Me.isWarehouseIssueNumberAutoGenerated.HasValue, Me.isWarehouseIssueNumberAutoGenerated.Value, False) Then
            GetNextWarehouseIssueNumberAndIncrement = GetNextWarehouseIssueNumber(job)
            Me.WarehouseIssueNumberNextNumber += 1
            Me.Save()
        Else
            Return ""
        End If

    End Function

    Public Function GetNextPurchaseOrderNumber(ByVal job As API.Job) As String
        If IIf(Me.IsPurchaseOrderNumberAutoGenerated.HasValue, Me.IsPurchaseOrderNumberAutoGenerated.Value, False) Then
            Select Case PurchaseOrderNumberPrefixType
                Case PurchaseOrderPrefixType.ERP
                    Return ""
                Case PurchaseOrderPrefixType.Default
                    Return Me.PurchaseOrderNumberPrefix + CStr(Me.PurchaseOrderNumberNextNumber).PadLeft(IIf(Me.PurchaseOrderNumberPadding.HasValue, Me.PurchaseOrderNumberPadding, DefaultPadding), CChar("0"))
                Case PurchaseOrderPrefixType.CostCentre
                    If job.CostCentre Is Nothing Then Return CStr(Me.PurchaseOrderNumberNextNumber).PadLeft(IIf(Me.PurchaseOrderNumberPadding.HasValue, Me.PurchaseOrderNumberPadding, DefaultPadding), CChar("0"))
                    Return job.CostCentre.Code + CStr(Me.PurchaseOrderNumberNextNumber).PadLeft(IIf(Me.PurchaseOrderNumberPadding.HasValue, Me.PurchaseOrderNumberPadding, DefaultPadding), CChar("0"))
                Case PurchaseOrderPrefixType.JobType
                    If job.JobType Is Nothing Then Return CStr(Me.PurchaseOrderNumberNextNumber).PadLeft(IIf(Me.PurchaseOrderNumberPadding.HasValue, Me.PurchaseOrderNumberPadding, DefaultPadding), CChar("0"))
                    Return job.JobType.Code + CStr(Me.PurchaseOrderNumberNextNumber).PadLeft(IIf(Me.PurchaseOrderNumberPadding.HasValue, Me.PurchaseOrderNumberPadding, DefaultPadding), CChar("0"))
                Case PurchaseOrderPrefixType.JobCategory
                    If job.JobCategory Is Nothing Then Return CStr(Me.PurchaseOrderNumberNextNumber).PadLeft(IIf(Me.PurchaseOrderNumberPadding.HasValue, Me.PurchaseOrderNumberPadding, DefaultPadding), CChar("0"))
                    Return job.JobCategory.Code + CStr(Me.PurchaseOrderNumberNextNumber).PadLeft(IIf(Me.PurchaseOrderNumberPadding.HasValue, Me.PurchaseOrderNumberPadding, DefaultPadding), CChar("0"))
                Case Else
                    Return Me.PurchaseOrderNumberPrefix + CStr(Me.PurchaseOrderNumberNextNumber).PadLeft(IIf(Me.PurchaseOrderNumberPadding.HasValue, Me.PurchaseOrderNumberPadding, DefaultPadding), CChar("0"))
            End Select
        Else
            Return ""
        End If
    End Function

    Protected Friend Function GetNextPurchaseOrderNumberAndIncrement(ByVal job As API.Job) As String
        If Me.IsPurchaseOrderNumberAutoGenerated IsNot Nothing AndAlso IIf(Me.IsPurchaseOrderNumberAutoGenerated.HasValue, Me.IsPurchaseOrderNumberAutoGenerated.Value, False) Then
            GetNextPurchaseOrderNumberAndIncrement = GetNextPurchaseOrderNumber(job)
            Me.PurchaseOrderNumberNextNumber += 1
            Me.Save()
        Else
            Return ""
        End If
    End Function

    Public Function GetSellingPriceGPPercentage(ByVal customerid As Integer) As Double
        Dim customer As Pastel.Evolution.Customer = New Pastel.Evolution.Customer(customerid)
        If Me.SellingPriceGPPercentageUDF IsNot Nothing AndAlso Me.SellingPriceGPPercentageUDF.Length > 4 Then
            Try
                If customer.UserFields(Me.SellingPriceGPPercentageUDF) > 0 Then
                    Return customer.UserFields(Me.SellingPriceGPPercentageUDF) / 100
                End If
            Catch
                'will return default value
            End Try
        End If
        If Me.SellingPriceGPPercentage Is Nothing Then
            Return 0
        Else
            Return Me.SellingPriceGPPercentage
        End If

    End Function

    Public Function IsGPCorrect(ByRef DiscountPercent As Double?, ByRef UnitCost As Double?, ByRef UnitPrice As Double?, ByRef UnitPriceBeforeDiscount As Double?, ByRef CustomerID As Integer, ByRef NewDiscountPercent As Double?) As Boolean
        Dim GPValid As Boolean = True
        If UnitCost IsNot Nothing AndAlso DiscountPercent IsNot Nothing AndAlso UnitCost > 0 And UnitPriceBeforeDiscount > 0 Then
            Dim GPPercentage As Double = ((UnitPrice - UnitCost) / UnitPrice) '* 100
            Dim SellingPriceGPPercentage As Double = Context.Defaults.GetSellingPriceGPPercentage(CustomerID)
            If UnitPrice < 0 OrElse GPPercentage < SellingPriceGPPercentage Then
                Dim tmpLineDiscountPercent As Double = DiscountPercent
                Dim NewLineDiscountPercent As Double = (UnitCost / (1 - SellingPriceGPPercentage))
                NewLineDiscountPercent = 1 - (NewLineDiscountPercent / UnitPriceBeforeDiscount)
                NewLineDiscountPercent = NewLineDiscountPercent * 10000
                NewLineDiscountPercent = Math.Truncate(NewLineDiscountPercent)
                NewLineDiscountPercent = NewLineDiscountPercent / 10000
                NewDiscountPercent = NewLineDiscountPercent
                'UnitPrice = UnitPriceBeforeDiscount * (1 - NewDiscountPercent)
                GPValid = False
            End If

        End If
        Return GPValid
    End Function

    Public Overrides Property MinDescription1Lenght As Integer?
        Get
            If MyBase.MinDescription1Lenght Is Nothing OrElse MyBase.MinDescription1Lenght < 0 Then
                MyBase.MinDescription1Lenght = 5
            End If
            Return MyBase.MinDescription1Lenght
        End Get
        Set(value As Integer?)
            MyBase.MinDescription1Lenght = value
        End Set
    End Property

    Public Overrides Property MinDescription2Lenght As Integer?
        Get
            If MyBase.MinDescription2Lenght Is Nothing OrElse MyBase.MinDescription2Lenght < 0 Then
                MyBase.MinDescription2Lenght = 5
            End If
            Return MyBase.MinDescription2Lenght
        End Get
        Set(value As Integer?)
            MyBase.MinDescription2Lenght = value
        End Set
    End Property

    Public Overrides Property FilterInventoryOnGroup As Boolean?
        Get
            If MyBase.FilterInventoryOnGroup Is Nothing Then
                MyBase.FilterInventoryOnGroup = True
            End If
            Return MyBase.FilterInventoryOnGroup
        End Get
        Set(value As Boolean?)
            MyBase.FilterInventoryOnGroup = value
        End Set
    End Property

    Public Overrides Property ActiveItemsOnly As Boolean?
        Get
            If MyBase.ActiveItemsOnly Is Nothing Then
                MyBase.ActiveItemsOnly = False
            End If
            Return MyBase.ActiveItemsOnly
        End Get
        Set(value As Boolean?)
            MyBase.ActiveItemsOnly = value
        End Set
    End Property

    ' Freddie - Dosco Supplier DeliveryNote
    Public Function GetNextSupplierDeliveryNumber(ByVal delivery As API.Job) As String
        If IIf(Me.isSupplierDeliveryNoteNumberAutoGenerated.HasValue, Me.isSupplierDeliveryNoteNumberAutoGenerated.Value, False) Then
            Select Case SupplierDeliveryNotePrefixType
                Case PurchaseOrderPrefixType.ERP
                    Return ""
                Case PurchaseOrderPrefixType.Default
                    Return Me.SupplierDeliveryNotePrefix + CStr(Me.SupplierDeliveryNoteNextNumber).PadLeft(IIf(Me.SupplierDeliveryNotePadding.HasValue, Me.SupplierDeliveryNotePadding, DefaultPadding), CChar("0"))
                Case PurchaseOrderPrefixType.CostCentre
                    If delivery.CostCentre Is Nothing Then Return CStr(Me.SupplierDeliveryNoteNextNumber).PadLeft(IIf(Me.SupplierDeliveryNotePadding.HasValue, Me.SupplierDeliveryNotePadding, DefaultPadding), CChar("0"))
                    Return delivery.CostCentre.Code + CStr(Me.SupplierDeliveryNoteNextNumber).PadLeft(IIf(Me.SupplierDeliveryNotePadding.HasValue, Me.SupplierDeliveryNotePadding, DefaultPadding), CChar("0"))
                Case PurchaseOrderPrefixType.JobType
                    If delivery.JobType Is Nothing Then Return CStr(Me.SupplierDeliveryNoteNextNumber).PadLeft(IIf(Me.SupplierDeliveryNotePadding.HasValue, Me.SupplierDeliveryNotePadding, DefaultPadding), CChar("0"))
                    Return delivery.JobType.Code + CStr(Me.SupplierDeliveryNoteNextNumber).PadLeft(IIf(Me.SupplierDeliveryNotePadding.HasValue, Me.SupplierDeliveryNotePadding, DefaultPadding), CChar("0"))
                Case PurchaseOrderPrefixType.JobCategory
                    If delivery.JobCategory Is Nothing Then Return CStr(Me.SupplierDeliveryNoteNextNumber).PadLeft(IIf(Me.SupplierDeliveryNotePadding.HasValue, Me.SupplierDeliveryNotePadding, DefaultPadding), CChar("0"))
                    Return delivery.JobCategory.Code + CStr(Me.SupplierDeliveryNoteNextNumber).PadLeft(IIf(Me.SupplierDeliveryNotePadding.HasValue, Me.SupplierDeliveryNotePadding, DefaultPadding), CChar("0"))
                Case Else
                    Return Me.SupplierDeliveryNotePrefix + CStr(Me.SupplierDeliveryNoteNextNumber).PadLeft(IIf(Me.SupplierDeliveryNotePadding.HasValue, Me.SupplierDeliveryNotePadding, DefaultPadding), CChar("0"))
            End Select
        Else
            Return ""
        End If
    End Function

    Protected Friend Function GetNextSupplierDeliveryNoteNumberAndIncrement(JOb As Job) As String
        If IIf(Me.isSupplierDeliveryNoteNumberAutoGenerated.HasValue, Me.isSupplierDeliveryNoteNumberAutoGenerated.Value, False) Then
            GetNextSupplierDeliveryNoteNumberAndIncrement = GetNextSupplierDeliveryNumber(JOb)
            Me.SupplierDeliveryNoteNextNumber += 1
            Me.Save()
        Else
            Return ""
        End If
    End Function


    Public Function GetNextProformaInvoiceNumber() As String
        Return Me.ProformaInvoiceNumberPrefix + CStr(Me.ProformaInvoiceNumberNextNumber).PadLeft(IIf(Me.ProformaInvoiceNumberPadding.HasValue, Me.ProformaInvoiceNumberPadding, DefaultPadding), CChar("0"))
    End Function

    Public Function GetNextProformaInvoiceNumberAndIncrement() As String
        GetNextProformaInvoiceNumberAndIncrement = GetNextProformaInvoiceNumber()
        Me.ProformaInvoiceNumberNextNumber += 1
        Me.Save()
    End Function

    Public Property DefaultJobScreen As DefaultJobScreen

        Get
            If DefaultJobScreenID Is Nothing Then
                DefaultJobScreenID = DefaultJobScreen.Job
            End If
            Return DefaultJobScreenID
        End Get
        Set(value As DefaultJobScreen)
            DefaultJobScreenID = value
        End Set

    End Property

    Public Property DefaultJobLineScreen As DefaultJobLineScreen

        Get
            If DefaultJobLineScreenID Is Nothing Then
                DefaultJobLineScreenID = DefaultJobLineScreen.JobLine
            End If
            Return DefaultJobLineScreenID
        End Get
        Set(value As DefaultJobLineScreen)
            DefaultJobLineScreenID = value
        End Set

    End Property

End Class
