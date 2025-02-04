Imports Castle.Components.Validator
Imports Castle.ActiveRecord
Imports UniSource
Imports Pastel.Evolution

Public Class RequisitionLine
    'Public Property QuantityReq As Double = Me.Quantity

    Public Overrides Property TotalCost As Double?
        Get
            If Me.Quantity.HasValue AndAlso Me.UnitCost.HasValue Then
                MyBase.TotalCost = Me.Quantity * Me.UnitCost
            End If
            Return MyBase.TotalCost
        End Get
        Set(ByVal value As Double?)
            MyBase.TotalCost = value
        End Set
    End Property

    Private _inventoryitem As Helper.ActiveRecord.Evolution.StockItem
    <BelongsTo("InventoryItemID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    <ValidateNonEmpty("Inventory Item is required.")>
    Public Overridable Property InventoryItem As Helper.ActiveRecord.Evolution.StockItem
        Get
            Return _inventoryitem
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.StockItem)
            If Not IsLoading AndAlso value IsNot Nothing AndAlso _inventoryitem <> value Then
                UnitCost = value.AveUCst
            End If
            If (_inventoryitem <> value) Then
                _inventoryitem = value
                NotifyPropertyChanged("InventoryItem")
            End If
        End Set
    End Property

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid()

        If Me.ID = 0 AndAlso Me.JobLine IsNot Nothing Then
            Dim remainder As Double = IIf(Me.JobLine.QuantityStock.HasValue, Me.JobLine.QuantityStock, 0)
            Me.JobLine.RequisitionLineList.ToString()
            If Me.JobLine.QuantityStockDrawn.HasValue Then
                remainder -= Me.JobLine.QuantityStockDrawn
            End If
            If Me.Quantity > remainder Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Quantity")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Quantity"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Quantity")).Add(String.Format("Quantity to deliver of {0} exceeds remaining JobLine stock quantity of {1}.", Me.Quantity, remainder))
                valid = False
            End If
        End If

        Dim qtyError As Boolean
        qtyError = Me.Quantity Is Nothing
        qtyError = Me.Quantity <= 0

        If qtyError Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Quantity")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Quantity"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Quantity")).Add(String.Format("Quantity greater than zero required."))
            valid = False
        End If

        Return valid
    End Function

    Public Overridable ReadOnly Property QuantityReq As Double?

        Get
            Return QuantityReq = Quantity
        End Get

    End Property
    'Private _warehouseqty As Double
    'Public Overridable Property WarehouseQTY As Double

    '    Set(ByVal value As Double)
    '        _warehouseqty = 55

    '        Dim ItemId As Int32 = Me.InventoryItem.ID
    '        Dim StockItem As Pastel.Evolution.InventoryItem = New Pastel.Evolution.InventoryItem(ItemId)

    '        If StockItem.IsWarehouseTracked = True Then
    '            Dim SODetail As New Pastel.Evolution.OrderDetail
    '            Dim WID As Integer = JobLine.WarehouseID
    '            SODetail.Warehouse = New Pastel.Evolution.Warehouse(WID)
    '            Dim freestock = SODetail.WarehouseContext.QtyOnHand
    '            _warehouseqty = freestock

    '        End If
    '    End Set

    '    Get
    '        Return _warehouseqty
    '    End Get



    'End Property

    Private Property _maxQuantity As Double
    Public Overridable Property MaxQuantity As Double
        Get
            Return _maxQuantity
        End Get
        Set(value As Double)
            _maxQuantity = value
        End Set
    End Property

    Public Overrides Property Quantity As Double?
        Get
            Return MyBase.Quantity
        End Get
        Set(value As Double?)
            MyBase.Quantity = value
            If ID Is Nothing OrElse ID <= 0 Then
                If MyBase.Quantity > MaxQuantity Then
                    MyBase.Quantity = MaxQuantity
                    NotifyPropertyChanged("Quantity")
                End If
                If API.Context.Defaults.IsRequisitionQtyReadOnly = True AndAlso MyBase.Quantity <> MaxQuantity Then
                    MyBase.Quantity = MaxQuantity
                    NotifyPropertyChanged("Quantity")
                End If
                If MyBase.Quantity < 0 Then
                    MyBase.Quantity = 0
                    NotifyPropertyChanged("Quantity")
                End If
            End If
        End Set
    End Property

End Class
