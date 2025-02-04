Imports Castle.Components.Validator
Imports Castle.ActiveRecord
Imports UniSource

Public Class JobTemplateLine

    Protected Property IsCalculating As Boolean = False

    Public Overrides Function IsValid() As Boolean
        If InventoryItem Is Nothing OrElse InventoryItem.ItemActive = False Then
            Return False
        End If
        Return MyBase.IsValid()
    End Function

    Public Overridable Property MarkupFactor As Double?
        Get
            Return 1 + CType(IIf(MyBase.MarkupPercent.HasValue, MyBase.MarkupPercent, 0), Double)
        End Get
        Set(ByVal value As Double?)
            MyBase.MarkupPercent = value - 1
        End Set
    End Property

    Public Overrides Property MarkupPercent As Double?
        Get
            If MyBase.MarkupPercent Is Nothing Then
                MyBase.MarkupPercent = 0
            End If
            Return MyBase.MarkupPercent
        End Get
        Set(ByVal value As Double?)
            MyBase.MarkupPercent = value
        End Set
    End Property

    Public Overrides Property UnitSize As Double?
        Get
            If MyBase.UnitSize Is Nothing Then
                MyBase.UnitSize = 1
            End If
            Return MyBase.UnitSize
        End Get
        Set(ByVal value As Double?)
            MyBase.UnitSize = value
        End Set
    End Property

    Public Overrides Property Quantity As Double?
        Get
            If MyBase.Quantity Is Nothing Then
                MyBase.Quantity = 1
            End If
            Return MyBase.Quantity
        End Get
        Set(ByVal value As Double?)
            MyBase.Quantity = value
        End Set
    End Property

    <ValidateNonEmpty("WorkCentre is required.")>
    Public Overrides Property WorkCentre As WorkCentre
        Get
            Return MyBase.WorkCentre
        End Get
        Set(ByVal value As WorkCentre)
            MyBase.WorkCentre = value
        End Set
    End Property

    Private _inventoryitem As Helper.ActiveRecord.Evolution.StockItem
    <ValidateNonEmpty("Inventory Item is required.")>
    Public Overridable Property InventoryItem As Helper.ActiveRecord.Evolution.StockItem
        Get
            If MyBase.InventoryItemID Is Nothing Then
                _inventoryitem = Nothing
            ElseIf _inventoryitem Is Nothing OrElse _inventoryitem.ID <> MyBase.InventoryItemID Then
                Try
                    _inventoryitem = Helper.ActiveRecord.Evolution.StockItem.TryFind(MyBase.InventoryItemID)
                Catch
                    'MyBase.InventoryItemID = Nothing
                    _inventoryitem = Nothing
                End Try
            End If
            If _inventoryitem Is Nothing And MyBase.InventoryItemID IsNot Nothing Then
                MyBase.InventoryItemID = Nothing
            End If
            Return _inventoryitem
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.StockItem)
            If Not IsLoading AndAlso value IsNot Nothing AndAlso _inventoryitem <> value Then
                If Description1 Is Nothing OrElse Description1.Trim.Length <= 0 OrElse (value IsNot Nothing AndAlso value.ServiceItem = False) Then
                    Description1 = value.Description1
                    NotifyPropertyChanged("Description1")
                End If
                UnitCost = value.AveUCst
            End If
            If (_inventoryitem <> value) Then
                _inventoryitem = value
                If WorkCentre IsNot Nothing AndAlso WorkCentre.CalculationType = CalculationType.Standard Then
                    If Description1 Is Nothing OrElse Description1.Trim.Length <= 0 Then
                        Description1 = value.Description1
                        NotifyPropertyChanged("Description1")
                    End If
                End If
                If value Is Nothing Then
                    MyBase.InventoryItemID = Nothing
                Else
                    MyBase.InventoryItemID = value.ID
                End If
                NotifyPropertyChanged("InventoryItem")
            End If
        End Set
    End Property

    Private Property _supplierType As Helper.ActiveRecord.Evolution.VendorClass
    Public Overridable Property SupplierType As Helper.ActiveRecord.Evolution.VendorClass
        Get
            If MyBase.SupplierTypeID Is Nothing Then
                _supplierType = Nothing
            ElseIf _supplierType Is Nothing OrElse _supplierType.ID <> MyBase.SupplierTypeID Then
                _supplierType = Helper.ActiveRecord.Evolution.VendorClass.Find(MyBase.SupplierTypeID)
            End If
            Return _supplierType
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.VendorClass)
            If (_supplierType <> value) Then
                _supplierType = value
                If value Is Nothing Then
                    MyBase.SupplierTypeID = Nothing
                Else
                    MyBase.SupplierTypeID = value.ID
                End If
                NotifyPropertyChanged("SupplierType")
            End If
        End Set
    End Property

    Private _calculationproperties As List(Of String)
    Private ReadOnly Property CalculationProperties As IEnumerable(Of String)
        Get
            If _calculationproperties Is Nothing Then
                _calculationproperties = New List(Of String)
                _calculationproperties.Add("InventoryItem")
                _calculationproperties.Add("WorkCentre")
                _calculationproperties.Add("Quantity")
                _calculationproperties.Add("MarkupFactor")
                _calculationproperties.Add("UnitSize")
                _calculationproperties.Add("UnitCost")
                _calculationproperties.Add("EstimatedDuration")
                _calculationproperties.Add("LineDiscountPercent")
                _calculationproperties.Add("UnitPrice")
            End If
            Return _calculationproperties
        End Get
    End Property

    Private _priceUpdateProperties As List(Of String)
    Private ReadOnly Property PriceUpdateProperties As IEnumerable(Of String)
        Get
            If _priceUpdateProperties Is Nothing Then
                _priceUpdateProperties = New List(Of String)
                _priceUpdateProperties.Add("InventoryItem")
                '_priceUpdateProperties.Add("WorkCentre")
                '_priceUpdateProperties.Add("Quantity")
                '_priceUpdateProperties.Add("MarkupFactor")
                '_priceUpdateProperties.Add("UnitSize")
                '_priceUpdateProperties.Add("UnitCost")
                '_priceUpdateProperties.Add("EstimatedDuration")
                '_priceUpdateProperties.Add("LineDiscountPercent")
                '_priceUpdateProperties.Add("UnitPrice")
            End If
            Return _priceUpdateProperties
        End Get
    End Property

    Private Sub CheckCalculation(ByVal sender As Object, ByVal e As ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
        If CalculationProperties.Contains(e.PropertyName) Then
            Try
                Recalculate(e.PropertyName)
            Catch ex As Exception
                IsCalculating = False
                Throw New Exception("Calculation error.", ex)
            Finally
                'IsCalculating = False
            End Try
        End If
    End Sub

    Protected Friend Overridable Property InventoryItemSellingPrice As Helper.ActiveRecord.Evolution.PricelistPrice

    Protected Friend Overridable Sub Recalculate(Optional ByVal PropertyName As String = "")
        If (Not IsLoading Or UnitPriceBeforeMarkup <= 0) AndAlso Not IsCalculating AndAlso WorkCentre IsNot Nothing AndAlso InventoryItem IsNot Nothing Then
            Dim RefreshPrice As Boolean = False
            IsCalculating = True
            Dim _pricelistID As Integer = 0
            If Me.JobTemplate.PricelistID IsNot Nothing Then
                _pricelistID = Me.JobTemplate.PricelistID
            ElseIf Context.Defaults.DefaultPricelistID IsNot Nothing Then
                _pricelistID = Context.Defaults.DefaultPricelistID
            Else
                _pricelistID = Pastel.Evolution.Defaults.DefaultPriceList.ID
            End If



            If InventoryItemSellingPrice Is Nothing Then
                If Me.JobTemplate.PricelistID IsNot Nothing Then
                    InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Me.JobTemplate.PricelistID)
                ElseIf Context.Defaults.DefaultPricelistID IsNot Nothing Then
                    InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Context.Defaults.DefaultPricelistID)
                Else
                    InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Pastel.Evolution.Defaults.DefaultPriceList.ID)
                End If
            ElseIf InventoryItemSellingPrice.IStockID <> InventoryItem.ID OrElse _pricelistID <> InventoryItemSellingPrice.IPriceListNameID Then
                RefreshPrice = True
                If Me.JobTemplate.PricelistID IsNot Nothing Then
                    InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Me.JobTemplate.PricelistID)
                ElseIf Context.Defaults.DefaultPricelistID IsNot Nothing Then
                    InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Context.Defaults.DefaultPricelistID)
                Else
                    InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Pastel.Evolution.Defaults.DefaultPriceList.ID)
                End If
            End If

            Select Case WorkCentre.CalculationType

                Case CalculationType.Recovery
                    '' Recovery - Labour lines
                    If UnitPrice > 0 Then

                        MyBase.UnitCost = UnitPrice
                        UnitPriceBeforeMarkup = UnitPrice
                    Else
                        MyBase.UnitCost = WorkCentre.HourlyRate
                    End If
                    If UnitPriceBeforeMarkup Is Nothing OrElse UnitPriceBeforeMarkup <= 0 Then
                        If InventoryItemSellingPrice IsNot Nothing AndAlso IIf(IsNothing(WorkCentre.HourlyRate), 0, WorkCentre.HourlyRate) <= 0 Then
                            UnitPriceBeforeMarkup = InventoryItemSellingPrice.FExclPrice
                        Else
                            UnitPriceBeforeMarkup = WorkCentre.HourlyRate
                        End If
                    End If

                Case CalculationType.Standard
                    '' Standard - Stock Issue or Buyout
                    If WorkCentre.IsBuyOut Then
                        If UnitPriceBeforeMarkup Is Nothing OrElse UnitPriceBeforeMarkup <= 0 Then
                            UnitPriceBeforeMarkup = UnitCost
                        End If
                    Else
                        UnitCost = InventoryItem.AveUCst
                        'If RefreshPrice = True OrElse UnitPriceBeforeMarkup Is Nothing OrElse UnitPriceBeforeMarkup <= 0 Then
                        If InventoryItemSellingPrice IsNot Nothing Then
                            If PriceUpdateProperties.Contains(PropertyName) OrElse UnitPriceBeforeMarkup Is Nothing OrElse UnitPrice Is Nothing Then
                                UnitPriceBeforeMarkup = InventoryItemSellingPrice.FExclPrice
                            Else
                                UnitPriceBeforeMarkup = UnitPrice
                            End If
                        Else
                            UnitPriceBeforeMarkup = 0
                        End If
                        'End If
                        End If

                Case CalculationType.Formula
                    '' Formula - Stock Issue or Buyout
                    If WorkCentre.IsBuyOut Then

                    Else

                    End If

            End Select

            'UnitPrice = UnitPriceBeforeMarkup * WorkCentre.Factor * (1 + MarkupPercent)

            'TotalCost = Quantity * UnitSize * UnitCost
            'TotalPrice = Quantity * UnitSize * UnitPrice
            CalculateTotal()
            IsCalculating = False

        End If
    End Sub

    Private Sub CalculateTotal(Optional IsPriceListChanged As Boolean = True)
        If Me.UnitPriceBeforeMarkup IsNot Nothing AndAlso Me.UnitPriceBeforeMarkup >= 0 Then

            Me.UnitPrice = Me.UnitPriceBeforeMarkup * Me.WorkCentre.Factor * (1 + Me.MarkupPercent)

            If MyBase.TotalCost Is Nothing OrElse MyBase.TotalCost <> Me.Quantity * Me.UnitSize * Me.UnitCost Then
                MyBase.TotalCost = Me.Quantity * Me.UnitSize * Me.UnitCost
                NotifyPropertyChanged("TotalCost")
            End If
            If MyBase.TotalPrice Is Nothing OrElse Math.Round(CDbl(MyBase.TotalPrice), 2) <> Math.Round(CDbl(Me.Quantity * Me.UnitSize * Me.UnitPrice), 2) Then
                Me.TotalPrice = Math.Round(CDbl(Me.Quantity * Me.UnitSize * Me.UnitPrice), 2)
                NotifyPropertyChanged("TotalPrice")
            End If
        End If
    End Sub

    Public Overrides Property UnitCost As Double?
        Get
            If MyBase.UnitCost Is Nothing Then
                Return 0
            End If
            Return MyBase.UnitCost
        End Get
        Set(value As Double?)
            MyBase.UnitCost = value
        End Set
    End Property

    Public Overrides Property UnitPrice As Double?
        Get
            If MyBase.UnitPrice Is Nothing Then
                Return 0
            End If
            Return MyBase.UnitPrice
        End Get
        Set(value As Double?)
            MyBase.UnitPrice = value
        End Set
    End Property


    Public Overrides Property Description1 As String
        Get
            If InventoryItem IsNot Nothing AndAlso (MyBase.Description1 Is Nothing OrElse MyBase.Description1.Trim.Length <= 0) Then
                MyBase.Description1 = InventoryItem.Description1
            End If
            Return MyBase.Description1
        End Get
        Set(ByVal value As String)
            If InventoryItem IsNot Nothing AndAlso (MyBase.Description1 Is Nothing OrElse MyBase.Description1.Trim.Length <= 0) Then
                MyBase.Description1 = InventoryItem.Description1
            End If
            MyBase.Description1 = value
        End Set
    End Property

    Public Overrides Property TotalPrice As Double?
        Get
            If MyBase.TotalPrice Is Nothing OrElse Math.Round(CDbl(MyBase.TotalPrice), 2) <> Math.Round(CDbl(Me.Quantity * Me.UnitSize * Me.UnitPrice), 2) Then
                MyBase.TotalPrice = Math.Round(CDbl(Me.Quantity * Me.UnitSize * Me.UnitPrice), 2)
            End If
            Return MyBase.TotalPrice
        End Get
        Set(value As Double?)
            MyBase.TotalPrice = value
        End Set
    End Property

    Public Overrides Property TotalCost As Double?
        Get
            If MyBase.TotalCost Is Nothing OrElse MyBase.TotalCost <> Me.Quantity * Me.UnitSize * Me.UnitCost Then
                MyBase.TotalCost = Me.Quantity * Me.UnitSize * Me.UnitCost
            End If
            Return MyBase.TotalCost
        End Get
        Set(value As Double?)
            MyBase.TotalCost = value
        End Set
    End Property

End Class
