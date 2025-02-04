Imports Castle.Components.Validator
Imports Castle.ActiveRecord
Imports UniSource

Public Class PurchaseOrderLine

    Public Overrides Property TotalPrice As Double?
        Get
            If Me.Quantity.HasValue AndAlso Me.UnitPrice.HasValue Then
                MyBase.TotalPrice = Me.Quantity * Me.UnitPrice
            End If
            Return MyBase.TotalPrice
        End Get
        Set(ByVal value As Double?)
            MyBase.TotalPrice = value
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
            If (_inventoryitem <> value) Then
                _inventoryitem = value
                NotifyPropertyChanged("InventoryItem")
            End If
        End Set
    End Property

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid()

        If Me.ID = 0 AndAlso Me.JobLine IsNot Nothing Then
            Dim remainder As Double = (IIf(Me.JobLine.QuantitySupplier1.HasValue, Me.JobLine.QuantitySupplier1, 0) + IIf(Me.JobLine.QuantitySupplier2.HasValue, Me.JobLine.QuantitySupplier2, 0))
            Me.JobLine.PurchaseOrderLineList.ToString()
            If Me.JobLine.QuantitySupplierOrdered.HasValue Then
                remainder -= Me.JobLine.QuantityStockDrawn
            End If
            If Me.Quantity > remainder Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Quantity")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Quantity"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Quantity")).Add(String.Format("Quantity to order of {0} exceeds remaining JobLine Supplier quantity of {1}.", Me.Quantity, remainder))
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

    Protected Overrides Function BeforeSave(ByVal state As System.Collections.IDictionary) As Boolean
        If Me.ID = 0 Then
            'CType(state("JobLine"), JobLine).OrderDate = CType(state("PurchaseOrder"), PurchaseOrder).OrderDate
            'CType(state("JobLine"), JobLine).OrderNumber = CType(state("PurchaseOrder"), PurchaseOrder).OrderNumber
            'CType(state("JobLine"), JobLine).SaveAndFlush()
        End If
        Return MyBase.BeforeSave(state)
    End Function

End Class
