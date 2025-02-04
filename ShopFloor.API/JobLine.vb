Imports Castle.ActiveRecord
Imports Castle.Components.Validator
Imports UniSource
Imports Pastel.Evolution
Imports System.Data.SqlClient

Public Class JobLine

    Protected Property IsCalculating As Boolean = False

    Public Overridable Property IsImporting As Boolean = False

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid
        If IsLoading = False Then
            If InventoryItem Is Nothing OrElse InventoryItem.ItemActive = False Then
                valid = False
            End If

            If WorkCentre Is Nothing OrElse (WorkCentre.APExpense = True AndAlso Supplier1ID Is Nothing) Then
                valid = False
            End If

            If WorkCentre Is Nothing OrElse (WorkCentre.GLExpense = True AndAlso (GLAccount Is Nothing Or GLAccount = "")) Then
                valid = False
            End If

            If WorkCentre IsNot Nothing AndAlso WorkCentre.IsBuyOut Then
                If InventoryItem.ServiceItem = False Then
                    If WarehouseID = 0 Or WarehouseID Is Nothing Then
                        valid = False
                    End If
                End If

                If InventoryItem.ServiceItem = True Then
                    If UnitCost < 0 Then
                        valid = False
                    End If
                End If
            End If

            If AssetID = Asset2ID Then
                valid = False
            End If
            'Tawanda
            'this is where you write the code to check the relevant exception, if its set to false it will fire the validation method in the JobLIneLite
            ' the method in JobLIne Lte is used to notify the user with a message and prevent saving
            ' So youll need to do the following
            ' Find the AssetID selected in the primary asset field
            'Check the Job for which Asset number it is
            'then compare to the relevant asset before value as the user can choose 5 of them ie Eq2UsageBefore, Eq3UsageBefore

            'Tawanda Equipment One 1
            If Job.EquipamentoNo1 IsNot Nothing Then
                If AssetID = Job.EquipamentoNo1 Then
                    If PrimaryAssetUsage < Me.Job.Eq1UsageBefore Then
                        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("PrimaryAssetUsage")) Then
                            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("PrimaryAssetUsage"), New ArrayList())
                        End If
                        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("PrimaryAssetUsage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
                        valid = False
                    End If
                End If
                If Asset2ID = Job.EquipamentoNo1 Then
                    If Asset2Usage < Me.Job.Eq1UsageBefore Then
                        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Asset2Usage")) Then
                            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Asset2Usage"), New ArrayList())
                        End If
                        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Asset2Usage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
                        valid = False

                    End If
                End If
            End If


            'Tawanda Equipment Two 2
            If Job.EquipamentoNo2 IsNot Nothing Then
                If AssetID = Job.EquipamentoNo2 Then
                    If PrimaryAssetUsage < Me.Job.Eq2UsageBefore Then
                        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("PrimaryAssetUsage")) Then
                            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("PrimaryAssetUsage"), New ArrayList())
                        End If
                        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("PrimaryAssetUsage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
                        valid = False
                    End If
                End If
                If Asset2ID = Job.EquipamentoNo2 Then
                    If Asset2Usage < Me.Job.Eq2UsageBefore Then
                        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Asset2Usage")) Then
                            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Asset2Usage"), New ArrayList())
                        End If
                        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Asset2Usage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
                        valid = False

                    End If
                End If
            End If

            'Tawanda Equipment Three 3 
            If Job.EquipamentoNo3 IsNot Nothing Then
                If AssetID = Job.EquipamentoNo3 Then
                    If PrimaryAssetUsage < Me.Job.Eq3UsageBefore Then
                        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("PrimaryAssetUsage")) Then
                            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("PrimaryAssetUsage"), New ArrayList())
                        End If
                        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("PrimaryAssetUsage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
                        valid = False
                    End If
                End If
                If Asset2ID = Job.EquipamentoNo3 Then
                    If Asset2Usage < Me.Job.Eq3UsageBefore Then
                        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Asset2Usage")) Then
                            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Asset2Usage"), New ArrayList())
                        End If
                        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Asset2Usage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
                        valid = False

                    End If
                End If
            End If

            'Tawanda Equipment Four 4
            If Job.EquipamentoNo4 IsNot Nothing Then
                If AssetID = Job.EquipamentoNo4 Then
                    If PrimaryAssetUsage < Me.Job.Eq4UsageBefore Then
                        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("PrimaryAssetUsage")) Then
                            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("PrimaryAssetUsage"), New ArrayList())
                        End If
                        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("PrimaryAssetUsage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
                        valid = False
                    End If
                End If
                If Asset2ID = Job.EquipamentoNo4 Then
                    If Asset2Usage < Me.Job.Eq4UsageBefore Then
                        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Asset2Usage")) Then
                            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Asset2Usage"), New ArrayList())
                        End If
                        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Asset2Usage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
                        valid = False

                    End If
                End If
            End If

            'Tawanda Equipment Five 5
            If Job.EquipamentoNo5 IsNot Nothing Then
                If AssetID = Job.EquipamentoNo5 Then
                    If PrimaryAssetUsage < Me.Job.Eq5UsageBefore Then
                        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("PrimaryAssetUsage")) Then
                            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("PrimaryAssetUsage"), New ArrayList())
                        End If
                        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("PrimaryAssetUsage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
                        valid = False
                    End If
                End If
                If Asset2ID = Job.EquipamentoNo5 Then
                    If Asset2Usage < Me.Job.Eq5UsageBefore Then
                        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Asset2Usage")) Then
                            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Asset2Usage"), New ArrayList())
                        End If
                        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Asset2Usage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
                        valid = False

                    End If
                End If
            End If

            'If AssetID IsNot Nothing Then
            '    If PrimaryAssetUsage < Me.Job.Eq1UsageBefore Then
            '        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("PrimaryAssetUsage")) Then
            '            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("PrimaryAssetUsage"), New ArrayList())
            '        End If
            '        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("PrimaryAssetUsage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
            '        valid = False
            '    End If
            'End If

            'If Asset2ID IsNot Nothing Then
            '    If Asset2Usage < Me.Job.Eq2UsageBefore Then
            '        If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Asset2Usage")) Then
            '            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Asset2Usage"), New ArrayList())
            '        End If
            '        Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Asset2Usage")).Add("The Current Asset Odometer reading can not be less than the previous Odometer reading." & vbCrLf & "   A leitura da kilometragem do activo nao pode ser menos que a anterior leitura.")
            '        valid = False

            '    End If
            'End If


            'If PrimaryAssetUsage > Me.Job.'Relevant Asset Usage Before, either 1 2 3etc' Then
            'End If

            'Dim PrimaryLineItemsCount As Integer = 0
            'For Each jobline As API.JobLine In Me.Job.JobLines
            '    If jobline.WorkCentre.PrimaryService = True Then
            '        PrimaryLineItemsCount = PrimaryLineItemsCount + 1
            '    End If
            'Next

            'If PrimaryLineItemsCount > 1 Then
            '    valid = False
            'End If

            'If InventoryItem.WhseItem Then
            ' Lance Add warehouse over here
            'End If

            If WorkCentre IsNot Nothing AndAlso WorkCentre.UsageRequired = True Then
                'Tawanda add Asset2Usage
                If (PrimaryAssetUsage <= 0 Or PrimaryAssetUsage Is Nothing) And (Asset2Usage <= 0 Or Asset2Usage Is Nothing) Then
                    valid = False
                End If
                'Tawanda and Asset2ID
                If AssetID Is Nothing And Asset2ID Is Nothing Then
                    valid = False
                End If
                'If (Asset2Usage <= 0 Or Asset2Usage Is Nothing) Then
                '    valid = False
                'End If

                'If Asset2ID Is Nothing Then
                '    valid = False
                'End If

            End If



            If PrimaryAssetUsage > 0 Then
                If AssetID = 0 Or AssetID Is Nothing Then
                End If
            End If

            If IsImporting = False Then
                If WorkCentre IsNot Nothing AndAlso IIf(IsNothing(WorkCentre.IsBuyOut), False, WorkCentre.IsBuyOut) Then
                    If Supplier1 Is Nothing Then
                        valid = False
                    End If
                End If
            End If

            If Me.Quantity < 0.01 Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Quantity")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Quantity"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Quantity")).Add("Quantinty must be  Greater Than 0.")
                valid = False
            End If
            If Me.UnitSize < 0.01 Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("UnitSize")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("UnitSize"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("UnitSize")).Add("Unit Size must be  Greater Equal to 1.")
                valid = False
            End If


        End If
        Return valid
    End Function

    Private WithEvents _requisitionlinelist As ComponentModel.BindingList(Of RequisitionLine)
    Public Overridable Overloads ReadOnly Property RequisitionLineList As ComponentModel.BindingList(Of RequisitionLine)
        Get
            If _requisitionlinelist Is Nothing OrElse _requisitionlinelist.Count = 0 Then
                _requisitionlinelist = New ComponentModel.BindingList(Of RequisitionLine)(Me.RequisitionLines)
            End If
            Return _requisitionlinelist
        End Get
    End Property

    Private WithEvents _purchaseorderlinelist As ComponentModel.BindingList(Of PurchaseOrderLine)
    Public Overridable Overloads ReadOnly Property PurchaseOrderLineList As ComponentModel.BindingList(Of PurchaseOrderLine)
        Get
            If _purchaseorderlinelist Is Nothing OrElse _purchaseorderlinelist.Count = 0 Then
                _purchaseorderlinelist = New ComponentModel.BindingList(Of PurchaseOrderLine)(Me.PurchaseOrderLines)
            End If
            Return _purchaseorderlinelist
        End Get
    End Property

    Public Overridable Property MarkupFactor As Double?
        Get
            Return 1 + CDbl(IIf(MyBase.MarkupPercent.HasValue, MyBase.MarkupPercent, 0))
        End Get
        Set(ByVal value As Double?)
            MyBase.MarkupPercent = value - 1
        End Set
    End Property

    Public Property AssetName As String
        Get
            If MyBase.AssetID IsNot Nothing AndAlso IsDBNull(MyBase.AssetID) = False Then
                Dim AssetN As String = ""
                Try
                    Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Asset)()
                    crit.Add(NHibernate.Criterion.Expression.Sql("Id in ('" & MyBase.AssetID & "')"))
                    Dim asset As API.Asset() = API.Asset.FindAll(crit)
                    For Each a As API.Asset In asset
                        AssetN = a.Description
                    Next

                Catch ex As Exception

                End Try

                Return AssetN

                ' Return MyBase.AssetID
            End If

        End Get
        Set(value As String)

        End Set
    End Property

    Public Overrides Property EstimatedDuration As Double?
        Get
            If MyBase.EstimatedDuration Is Nothing AndAlso Me.WorkCentre IsNot Nothing AndAlso Me.WorkCentre.CalculationType = CalculationType.Recovery Then
                Return 1
            End If
            Return MyBase.EstimatedDuration
        End Get
        Set(ByVal value As Double?)
            MyBase.EstimatedDuration = value
        End Set
    End Property

    Public Overrides Property UnitSize As Double?
        Get
            If MyBase.UnitSize Is Nothing Then
                'MyBase.UnitSize = 1
                Return 1
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
                'MyBase.Quantity = 1
                Return 1
            End If
            Return MyBase.Quantity
        End Get
        Set(ByVal value As Double?)
            MyBase.Quantity = value
            If MyBase.WorkCentre IsNot Nothing Then
                If MyBase.WorkCentre.IsBuyOut Is Nothing OrElse MyBase.WorkCentre.IsBuyOut = False Then
                    If MyBase.QuantityStock Is Nothing OrElse MyBase.QuantityStock < MyBase.Quantity Then
                        MyBase.QuantityStock = MyBase.Quantity
                    End If
                Else
                    If IIf(IsNothing(MyBase.QuantitySupplier1), 0, MyBase.QuantitySupplier1) < MyBase.Quantity Then
                        MyBase.QuantitySupplier1 = MyBase.Quantity
                    End If
                End If
            End If
        End Set
    End Property

    Public Overrides Property MarkupPercent As Double?
        Get
            If MyBase.MarkupPercent Is Nothing Then
                Return 0
            End If
            Return MyBase.MarkupPercent
        End Get
        Set(ByVal value As Double?)
            MyBase.MarkupPercent = value
        End Set
    End Property

    Public Overrides Property LineDiscountPercent As Double?
        Get
            If Me.Job.IsApproved = False Then
                If Me.WorkCentre IsNot Nothing AndAlso Me.WorkCentre.CalculationType = API.CalculationType.Standard Then
                    If (MyBase.LineDiscountPercent Is Nothing OrElse MyBase.LineDiscountPercent < 0) Then
                        If (Me.WorkCentre.IsBuyOut.HasValue = False OrElse Me.WorkCentre.IsBuyOut = False) AndAlso Me.Job IsNot Nothing AndAlso Me.Job.Customer IsNot Nothing AndAlso IIf(IsNothing(Me.Job.Customer.AutoDisc), 0, Me.Job.Customer.AutoDisc) > 0 Then
                            '        MyBase.LineDiscountPercent = Me.Job.Customer.AutoDisc / 100
                            MyBase.LineDiscountPercent = Me.Job.DefaultDiscountPercent / 100
                        Else
                            MyBase.LineDiscountPercent = 0
                        End If
                    End If
                    Return MyBase.LineDiscountPercent
                Else
                    If Me.WorkCentre Is Nothing Then
                        Return MyBase.LineDiscountPercent
                    Else
                        Return 0
                    End If
                End If
            End If
            If MyBase.LineDiscountPercent Is Nothing Then
                MyBase.LineDiscountPercent = 0
            End If
            Return MyBase.LineDiscountPercent
        End Get
        Set(ByVal value As Double?)
            MyBase.LineDiscountPercent = value
        End Set
    End Property

    Public Overrides Property PurchaseDiscountPercent As Double?
        Get
            If MyBase.PurchaseDiscountPercent Is Nothing Then
                Return 0
            End If
            Return MyBase.PurchaseDiscountPercent
        End Get
        Set(ByVal value As Double?)
            MyBase.PurchaseDiscountPercent = value
        End Set
    End Property

    Public Overrides Property IsStockDrawn As Boolean?
        Get
            'MyBase.IsStockDrawn = False
            Dim jobIsStockDrawn As Boolean = False
            If Me.WorkCentre IsNot Nothing Then
                If Me.WorkCentre.CalculationType = CalculationType.Standard And (Me.WorkCentre.IsBuyOut Is Nothing OrElse Me.WorkCentre.IsBuyOut <> True) Then
                    If Me.InventoryItem.ServiceItem = True Then
                        jobIsStockDrawn = True
                    Else
                        jobIsStockDrawn = (Me.Quantity = IIf(IsNothing(Me.QuantityStockDrawn), 0, Me.QuantityStockDrawn))
                    End If

                ElseIf Me.WorkCentre.CalculationType = CalculationType.Recovery Then
                    jobIsStockDrawn = True
                ElseIf Me.WorkCentre.IsBuyOut = True Then
                    'jobIsStockDrawn = True
                    'If MyBase.IsStockDrawn = False Then
                    '    MyBase.IsStockDrawn = True
                    'End If
                    jobIsStockDrawn = (Me.Quantity <= IIf(IsNothing(Me.QuantitySupplierOrdered), 0, Me.QuantitySupplierOrdered))

                Else
                    jobIsStockDrawn = True
                End If
            End If
            'If Me.IsStockDrawn Is Nothing OrElse jobIsStockDrawn <> Me.IsStockDrawn Then
            MyBase.IsStockDrawn = jobIsStockDrawn
            'End If
            Return MyBase.IsStockDrawn
        End Get
        Set(ByVal value As Boolean?)
            MyBase.IsStockDrawn = value
        End Set
    End Property


    Public Overrides Property QuantityStockDrawn As Double?
        Get
            'Tawanda Uncomment this 

            If Requisitionlinelist IsNot Nothing Then
                'MyBase.QuantityStockDrawn = Aggregate rl In _requisitionlinelist Into Sum(rl.Quantity)
                Dim jobQuantityStockDrawn As Double? = Aggregate rl In _requisitionlinelist Where rl.ERPRequisitionLineID.HasValue = True Into Sum(rl.Quantity)
                If MyBase.QuantityStockDrawn Is Nothing OrElse MyBase.QuantityStockDrawn <> jobQuantityStockDrawn Then
                    MyBase.QuantityStockDrawn = jobQuantityStockDrawn
                End If
            End If
            If MyBase.QuantityStockDrawn Is Nothing Then
                MyBase.QuantityStockDrawn = 0
            End If
            Return MyBase.QuantityStockDrawn
        End Get
        Set(ByVal value As Double?)
            MyBase.QuantityStockDrawn = value
        End Set
    End Property

    Public Overridable Sub RefreshOrderedStockDrawnQty()
        If PurchaseOrderLines IsNot Nothing Then
            Me.QuantitySupplierOrdered = Aggregate rl In PurchaseOrderLines Where rl.ERPPurchaseOrderLineID.HasValue = True Into Sum(rl.Quantity)
        End If
        If RequisitionLines IsNot Nothing Then
            Me.QuantityStockDrawn = Aggregate rl In RequisitionLines Where rl.ERPRequisitionLineID.HasValue = True Into Sum(rl.Quantity)
        End If
    End Sub

    Public Overrides Property QuantitySupplierOrdered As Double?
        Get
            'If _purchaseorderlinelist IsNot Nothing Then
            '    'MyBase.QuantitySupplierOrdered = Aggregate rl In _purchaseorderlinelist Into Sum(rl.Quantity)
            '    Dim jobQuantitySupplierOrdered As Double? = Aggregate rl In _purchaseorderlinelist Where rl.ERPPurchaseOrderLineID.HasValue = True Into Sum(rl.Quantity)
            '    If MyBase.QuantitySupplierOrdered Is Nothing OrElse MyBase.QuantitySupplierOrdered <> jobQuantitySupplierOrdered Then
            '        MyBase.QuantitySupplierOrdered = jobQuantitySupplierOrdered
            '    End If
            'End If
            Return MyBase.QuantitySupplierOrdered
        End Get
        Set(ByVal value As Double?)
            MyBase.QuantitySupplierOrdered = value
        End Set
    End Property

    Public Overrides Property UnitPrice As Double?
        Get
            If MyBase.UnitPrice Is Nothing Then
                'MyBase.UnitPrice = 0
                Return 0
            End If
            Return MyBase.UnitPrice
        End Get
        Set(ByVal value As Double?)
            MyBase.UnitPrice = value
        End Set
    End Property

    Private _inventoryitem As Helper.ActiveRecord.Evolution.StockItem
    '<ValidateNonEmpty("Inventory Item is required.")>
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
                If MyBase.Description1 Is Nothing OrElse MyBase.Description1.Trim.Length <= 0 OrElse (value IsNot Nothing AndAlso value.ServiceItem = False) Then
                    MyBase.Description1 = value.Description1
                End If
                MyBase.UnitCost = value.AveUCst
            End If
            If (_inventoryitem <> value) Then
                _inventoryitem = value
                If MyBase.WorkCentre IsNot Nothing AndAlso MyBase.WorkCentre.CalculationType = CalculationType.Standard Then
                    If MyBase.Description1 Is Nothing OrElse MyBase.Description1.Trim.Length <= 0 Then
                        MyBase.Description1 = value.Description1
                    End If
                End If
                If value Is Nothing Then
                    MyBase.InventoryItemID = Nothing
                Else
                    MyBase.InventoryItemID = value.ID
                    If _inventoryitem.ServiceItem = False Then
                        LineDiscountPercent = Nothing
                        NotifyPropertyChanged("LineDiscountPercent")
                    End If
                End If

                NotifyPropertyChanged("InventoryItem")
            End If
        End Set
    End Property

    Public Overrides Property InventoryItemID As Integer?
        Get
            Return MyBase.InventoryItemID
        End Get
        Set(ByVal value As Integer?)

            If (MyBase.InventoryItemID <> value OrElse (MyBase.InventoryItemID Is Nothing And value IsNot Nothing)) Then
                MyBase.InventoryItemID = value
                If MyBase.WorkCentre IsNot Nothing AndAlso MyBase.WorkCentre.CalculationType = CalculationType.Standard Then
                    'If MyBase.Description1 Is Nothing OrElse MyBase.Description1.Trim.Length <= 0 Then
                    MyBase.Description1 = InventoryItem.Description1

                    'End If
                End If
                NotifyPropertyChanged("InventoryItem")
            End If
        End Set
    End Property

    '<BelongsTo("InventoryItemID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    '<ValidateNonEmpty("Inventory Item is required.")>
    'Public Overridable Property InventoryItem As Helper.ActiveRecord.Evolution.StockItem
    '    Get
    '        Return _inventoryitem
    '    End Get
    '    Set(ByVal value As Helper.ActiveRecord.Evolution.StockItem)
    '        If Not IsLoading AndAlso value IsNot Nothing AndAlso _inventoryitem <> value Then
    '            If Description1 Is Nothing OrElse Description1.Trim.Length <= 0 Then
    '                Description1 = value.Description1
    '            End If
    '            UnitCost = value.AveUCst
    '        End If
    '        If (_inventoryitem <> value) Then
    '            _inventoryitem = value
    '            If WorkCentre IsNot Nothing AndAlso WorkCentre.CalculationType = CalculationType.Standard Then
    '                If Description1 Is Nothing OrElse Description1.Trim.Length <= 0 Then
    '                    Description1 = value.Description1
    '                End If
    '            End If
    '            NotifyPropertyChanged("InventoryItem")
    '        End If
    '    End Set
    'End Property

    Public Overrides Property Description1 As String
        Get
            If InventoryItem IsNot Nothing AndAlso (MyBase.Description1 Is Nothing OrElse MyBase.Description1.Trim.Length <= 0) Then
                Return InventoryItem.Description1
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
    Public ReadOnly Property StockCodeSample As String
        Get
            Dim myCode As String = ""
            If InventoryItemID IsNot Nothing Then
                Dim SqlSelectStatement As String = "Select Top 1 Code From StkItem Where StockLink =" & InventoryItemID
                Dim cn As SqlConnection
                Dim cmd As SqlCommand
                cn = New SqlConnection(Context.ActiveConnection.Company.ConnectionString)
                cn.Open()
                cmd = New SqlCommand(SqlSelectStatement, cn)
                myCode = Convert.ToString(cmd.ExecuteScalar)
                cmd.CommandType = CommandType.Text
                cmd.CommandText = SqlSelectStatement
                cn.Close()
            End If
            Return myCode.ToString
        End Get
    End Property

    '<BelongsTo("SupplierTypeID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    'Public Overridable Property SupplierType As Helper.ActiveRecord.Evolution.VendorClass
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

    '<BelongsTo("Supplier1ID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    'Public Overridable Property Supplier1 As Helper.ActiveRecord.Evolution.Vendor
    Private Property _supplier1 As Helper.ActiveRecord.Evolution.Vendor
    Public Overridable Property Supplier1 As Helper.ActiveRecord.Evolution.Vendor
        Get
            If MyBase.Supplier1ID Is Nothing Then
                _supplier1 = Nothing
            ElseIf _supplier1 Is Nothing OrElse _supplier1.ID <> MyBase.Supplier1ID Then
                _supplier1 = Helper.ActiveRecord.Evolution.Vendor.Find(MyBase.Supplier1ID)
            End If
            Return _supplier1
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.Vendor)
            If (_supplier1 <> value) Then
                _supplier1 = value
                If value Is Nothing Then
                    MyBase.Supplier1ID = Nothing
                Else
                    MyBase.Supplier1ID = value.ID
                End If
                NotifyPropertyChanged("Supplier1")
            End If
        End Set
    End Property

    '<BelongsTo("Supplier2ID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    'Public Overridable Property Supplier2 As Helper.ActiveRecord.Evolution.Vendor
    Private Property _supplier2 As Helper.ActiveRecord.Evolution.Vendor
    Public Overridable Property Supplier2 As Helper.ActiveRecord.Evolution.Vendor
        Get
            If MyBase.Supplier2ID Is Nothing Then
                _supplier2 = Nothing
            ElseIf _supplier2 Is Nothing OrElse _supplier2.ID <> MyBase.Supplier2ID Then
                _supplier2 = Helper.ActiveRecord.Evolution.Vendor.Find(MyBase.Supplier2ID)
            End If
            Return _supplier2
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.Vendor)
            If (_supplier2 <> value) Then
                _supplier2 = value
                If value Is Nothing Then
                    MyBase.Supplier2ID = Nothing
                Else
                    MyBase.Supplier2ID = value.ID
                End If
                NotifyPropertyChanged("Supplier2")
            End If
        End Set
    End Property

    Private _calculationproperties As List(Of String)
    Private ReadOnly Property CalculationProperties As IEnumerable(Of String)
        Get
            If _calculationproperties Is Nothing Then
                _calculationproperties = New List(Of String)
                _calculationproperties.Add("InventoryItem")
                _calculationproperties.Add("InventoryItemID")
                _calculationproperties.Add("WorkCentre")
                _calculationproperties.Add("Quantity")
                _calculationproperties.Add("MarkupPercent")
                _calculationproperties.Add("UnitSize")
                _calculationproperties.Add("UnitCost")
                _calculationproperties.Add("EstimatedDuration")
                _calculationproperties.Add("PurchaseDiscountPercent")
                _calculationproperties.Add("LineDiscountPercent")
                'For service item to edit price.
                _calculationproperties.Add("UnitPriceBeforeMarkup")
            End If
            Return _calculationproperties
        End Get
    End Property

    Private Sub CheckCalculation(ByVal sender As Object, ByVal e As ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
        If CalculationProperties.Contains(e.PropertyName) Then
            Try
                'If e.PropertyName <> "UnitPriceBeforeMarkup" OrElse (e.PropertyName = "UnitPriceBeforeMarkup" AndAlso WorkCentre IsNot Nothing AndAlso WorkCentre.CalculationType = CalculationType.Recovery) Then
                Recalculate()
                'End If
            Catch ex As Exception
                IsCalculating = False
                Throw New Exception("Calculation error.", ex)
            Finally
                'IsCalculating = False
            End Try
        End If
    End Sub

    Protected Friend Overridable Property InventoryItemSellingPrice As Helper.ActiveRecord.Evolution.PricelistPrice
    Protected Friend Overridable Property InventoryTimeSellingPrice As Helper.ActiveRecord.Evolution.PricelistPrice

    Public Overridable Sub Recalculate() 'Lance
        If Me.Job IsNot Nothing AndAlso (Not IsLoading OrElse Me.UnitPriceBeforeMarkup <= 0) AndAlso Not Me.IsCalculating AndAlso Me.WorkCentre IsNot Nothing AndAlso Me.InventoryItem IsNot Nothing AndAlso ((Me.WorkCentre.APExpense = False Or IsDBNull(Me.WorkCentre.APExpense) = False) AndAlso (Me.WorkCentre.GLExpense = False Or IsDBNull(Me.WorkCentre.GLExpense) = False)) Then
            Dim IsPriceListChanged As Boolean = False
            IsCalculating = True

            If InventoryItemSellingPrice Is Nothing OrElse Me.UnitPriceBeforeMarkup < 0 Then
                If Me.Job.PricelistID IsNot Nothing Then
                    InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Me.Job.PricelistID)
                Else
                    InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Pastel.Evolution.Defaults.DefaultPriceList.ID)
                End If
                IsPriceListChanged = True
            ElseIf InventoryItemSellingPrice.IStockID <> InventoryItem.ID Then
                'InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Pastel.Evolution.Defaults.DefaultPriceList.ID)
                If Me.Job.PricelistID IsNot Nothing Then
                    InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Me.Job.PricelistID)
                Else
                    InventoryItemSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(InventoryItem, Pastel.Evolution.Defaults.DefaultPriceList.ID)
                End If
                IsPriceListChanged = True
            End If

            If InventoryItemSellingPrice IsNot Nothing OrElse (Me.WorkCentre IsNot Nothing AndAlso Me.WorkCentre.CalculationType = CalculationType.Standard AndAlso Me.WorkCentre.IsBuyOut IsNot Nothing AndAlso Me.WorkCentre.IsBuyOut) Then
                CalculatePrice(IsPriceListChanged)
                'Select Case Me.WorkCentre.CalculationType

                '    Case CalculationType.Recovery
                '        '' Recovery - Labour lines
                '        If Me.WorkCentre.IsBuyOut Or Me.WorkCentre.APExpense Or Me.WorkCentre.GLExpense Then
                '            Me.UnitPurchasePrice = Me.UnitCost * (1 - Me.PurchaseDiscountPercent)
                '            If Not IIf(Me.Job.IsApproved.HasValue, Me.Job.IsApproved, False) Then
                '                If Me.UnitPriceBeforeMarkup <> Me.UnitPurchasePrice Then
                '                    Me.UnitPriceBeforeMarkup = Me.UnitPurchasePrice
                '                End If
                '            End If
                '        Else
                '            'Me.UnitCost = Me.WorkCentre.HourlyRate
                '            Me.UnitCost = 0
                '            If Me.UnitPriceBeforeMarkup Is Nothing OrElse Me.UnitPriceBeforeMarkup <= 0 Then
                '                If Not IIf(Me.Job.IsApproved.HasValue, Me.Job.IsApproved, False) AndAlso IsPriceListChanged = True Then
                '                    Me.UnitPriceBeforeMarkup = InventoryItemSellingPrice.FExclPrice * Me.EstimatedDuration
                '                    If InventoryItemSellingPrice IsNot Nothing AndAlso IIf(IsNothing(Me.WorkCentre.HourlyRate), 0, Me.WorkCentre.HourlyRate) <= 0 Then
                '                        If Me.UnitPriceBeforeMarkup <> InventoryItemSellingPrice.FExclPrice * Me.EstimatedDuration Then
                '                            Me.UnitPriceBeforeMarkup = InventoryItemSellingPrice.FExclPrice * Me.EstimatedDuration
                '                        End If
                '                    Else
                '                        If Me.UnitPriceBeforeMarkup <> Me.WorkCentre.HourlyRate * Me.EstimatedDuration Then
                '                            Me.UnitPriceBeforeMarkup = Me.WorkCentre.HourlyRate * Me.EstimatedDuration
                '                        End If
                '                    End If
                '                End If
                '            End If
                '        End If
                '    Case CalculationType.Standard
                '        '' Standard - Stock Issue or Buyout
                '        If Me.WorkCentre.IsBuyOut Or Me.WorkCentre.APExpense Or Me.WorkCentre.GLExpense Then
                '            If Me.UnitPurchasePrice <> Me.UnitCost * (1 - Me.PurchaseDiscountPercent) Then
                '                Me.UnitPurchasePrice = Me.UnitCost * (1 - Me.PurchaseDiscountPercent)
                '            End If
                '            If Not IIf(Me.Job.IsApproved.HasValue, Me.Job.IsApproved, False) Then
                '                If Me.UnitPriceBeforeMarkup <> Me.UnitPurchasePrice Then
                '                    Me.UnitPriceBeforeMarkup = Me.UnitPurchasePrice
                '                End If
                '            End If
                '        Else
                '            Me.UnitCost = InventoryItem.AveUCst
                '            If Not IIf(Me.Job.IsApproved.HasValue, Me.Job.IsApproved, False) Then
                '                If Me.UnitPriceBeforeMarkup <> InventoryItemSellingPrice.FExclPrice AndAlso IsPriceListChanged = True Then
                '                    Me.UnitPriceBeforeMarkup = InventoryItemSellingPrice.FExclPrice
                '                End If
                '            End If
                '        End If

                '    Case CalculationType.Formula
                '        '' Formula - Stock Issue or Buyout
                '        If Me.WorkCentre.IsBuyOut Then

                '        Else

                '        End If

                'End Select

                'If Not IIf(Job.IsApproved.HasValue, Job.IsApproved, False) Then
                '    UnitPriceBeforeDiscount = UnitPriceBeforeMarkup * WorkCentre.Factor * (1 + MarkupPercent)
                '    UnitPrice = UnitPriceBeforeDiscount * (1 - LineDiscountPercent)

                '    TotalCost = Quantity * UnitSize * UnitCost
                '    TotalPrice = Quantity * UnitSize * UnitPrice
                'End If
            Else
                If InventoryItemSellingPrice <> InventoryItemSellingPrice Then
                    InventoryItemSellingPrice = InventoryItemSellingPrice
                End If
            End If
            CalculateTotal(IsPriceListChanged)
            IsCalculating = False

        Else
            If Me.Job IsNot Nothing AndAlso (Not IsLoading OrElse Me.UnitPriceBeforeMarkup <= 0) AndAlso Not Me.IsCalculating AndAlso Me.WorkCentre IsNot Nothing Then
                If Me.WorkCentre.APExpense Or Me.WorkCentre.GLExpense Then

                    CalculatePrice(False)
                    CalculateTotal(False)
                    IsCalculating = False
                End If
            End If
        End If

    End Sub

    Private Sub CalculatePrice(ByVal IsPriceListChanged As Boolean)
        Select Case Me.WorkCentre.CalculationType

            Case CalculationType.Recovery
                '' Recovery - Labour lines
                If Me.WorkCentre.IsBuyOut Or Me.WorkCentre.APExpense Or Me.WorkCentre.GLExpense Then
                    Me.UnitPurchasePrice = Me.UnitCost * (1 - Me.PurchaseDiscountPercent)
                    If Not IIf(Me.Job.IsApproved.HasValue, Me.Job.IsApproved, False) Then
                        If Me.UnitPriceBeforeMarkup <> Me.UnitPurchasePrice Then
                            Me.UnitPriceBeforeMarkup = Me.UnitPurchasePrice
                        End If
                    End If
                Else
                    'Me.UnitCost = Me.WorkCentre.HourlyRate
                    Me.UnitCost = 0
                    If Me.UnitPriceBeforeMarkup Is Nothing OrElse Me.UnitPriceBeforeMarkup <= 0 Then
                        If Not IIf(Me.Job.IsApproved.HasValue, Me.Job.IsApproved, False) AndAlso IsPriceListChanged = True Then
                            Me.UnitPriceBeforeMarkup = InventoryItemSellingPrice.FExclPrice * Me.EstimatedDuration
                            If InventoryItemSellingPrice IsNot Nothing AndAlso IIf(IsNothing(Me.WorkCentre.HourlyRate), 0, Me.WorkCentre.HourlyRate) <= 0 Then
                                If Me.UnitPriceBeforeMarkup <> InventoryItemSellingPrice.FExclPrice * Me.EstimatedDuration Then
                                    Me.UnitPriceBeforeMarkup = InventoryItemSellingPrice.FExclPrice * Me.EstimatedDuration
                                End If
                            Else
                                If Me.UnitPriceBeforeMarkup <> Me.WorkCentre.HourlyRate * Me.EstimatedDuration Then
                                    Me.UnitPriceBeforeMarkup = Me.WorkCentre.HourlyRate * Me.EstimatedDuration
                                End If
                            End If
                        End If
                    End If
                End If
            Case CalculationType.Standard
                '' Standard - Stock Issue or Buyout
                If Me.WorkCentre.IsBuyOut Then
                    If Me.UnitPurchasePrice <> Me.UnitCost * (1 - Me.PurchaseDiscountPercent) Then
                        Me.UnitPurchasePrice = Me.UnitCost * (1 - Me.PurchaseDiscountPercent)
                    End If
                    If Not IIf(Me.Job.IsApproved.HasValue, Me.Job.IsApproved, False) Then
                        If Me.UnitPriceBeforeMarkup <> Me.UnitPurchasePrice Then
                            Me.UnitPriceBeforeMarkup = Me.UnitPurchasePrice
                        End If
                    End If
                Else
                    If Me.WorkCentre.APExpense Or Me.WorkCentre.GLExpense Then

                    Else
                        Me.UnitCost = InventoryItem.AveUCst
                        If Not IIf(Me.Job.IsApproved.HasValue, Me.Job.IsApproved, False) Then
                            If Me.UnitPriceBeforeMarkup <> InventoryItemSellingPrice.FExclPrice AndAlso IsPriceListChanged = True Then
                                Me.UnitPriceBeforeMarkup = InventoryItemSellingPrice.FExclPrice
                            End If
                        End If
                    End If
                End If

            Case CalculationType.Formula
                '' Formula - Stock Issue or Buyout
                If Me.WorkCentre.IsBuyOut Then

                Else

                End If

        End Select
    End Sub

    Overrides Property UnitPurchasePrice As Double?
        Get
            If MyBase.UnitPurchasePrice Is Nothing Then
                Return 0
            Else
                Return MyBase.UnitPurchasePrice
            End If
        End Get
        Set(value As Double?)
            MyBase.UnitPurchasePrice = value
        End Set
    End Property

    Public Overridable ReadOnly Property ActualCost As Double?
        Get
            If (Me.WorkCentre IsNot Nothing AndAlso Me.WorkCentre.IsBuyOut IsNot Nothing AndAlso Me.WorkCentre.IsBuyOut) Then
                Return Me.UnitPurchasePrice
            Else
                Return Me.UnitCost
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property TotalActualCost As Double?
        Get
            If Me.ActualCost IsNot Nothing AndAlso Me.Quantity IsNot Nothing Then
                Return Me.ActualCost * Me.Quantity
            Else
                Return 0
            End If
        End Get
    End Property
   

    Private Sub CalculateTotal(Optional IsPriceListChanged As Boolean = True)
        If IIf(Me.Job.IsApproved.HasValue, Me.Job.IsApproved, False) = False AndAlso Me.UnitPriceBeforeMarkup IsNot Nothing AndAlso Me.UnitPriceBeforeMarkup >= 0 Then
            Me.UnitPriceBeforeDiscount = Me.UnitPriceBeforeMarkup * Me.WorkCentre.Factor * (1 + Me.MarkupPercent)

            Me.UnitPrice = Me.UnitPriceBeforeDiscount * (1 - Me.LineDiscountPercent)
            If Context.Defaults.IsSellingPriceGPChecked = True AndAlso (Context.Defaults.SellingPriceGPCheckType = GPCheckType.PerLine OrElse Context.Defaults.SellingPriceGPCheckType = GPCheckType.PerLineAndJobCard) Then
                If Me.UnitCost IsNot Nothing AndAlso Me.LineDiscountPercent IsNot Nothing AndAlso Me.LineDiscountPercent > 0 AndAlso Me.UnitCost > 0 And UnitPriceBeforeDiscount > 0 Then
                    Dim GPPercentage As Double = ((Me.UnitPrice - Me.UnitCost) / Me.UnitPrice) '* 100
                    Dim SellingPriceGPPercentage As Double = Context.Defaults.GetSellingPriceGPPercentage(Me.Job.Customer.ID)
                    If Me.UnitPrice < 0 OrElse GPPercentage < SellingPriceGPPercentage Then
                        Dim tmpLineDiscountPercent As Double = Me.LineDiscountPercent
                        'Dim NewLineDiscountPercent As Double = (Me.UnitPriceBeforeDiscount - (Me.UnitCost * (1 + SellingPriceGPPercentage))) / Me.UnitPriceBeforeDiscount
                        Dim NewLineDiscountPercent As Double = (Me.UnitCost / (1 - SellingPriceGPPercentage))
                        NewLineDiscountPercent = 1 - (NewLineDiscountPercent / Me.UnitPriceBeforeDiscount)
                        'Me.LineDiscountPercent = Math.Truncate((NewLineDiscountPercent * 100)) / 100
                        NewLineDiscountPercent = NewLineDiscountPercent * 10000
                        NewLineDiscountPercent = Math.Truncate(NewLineDiscountPercent)
                        NewLineDiscountPercent = NewLineDiscountPercent / 10000
                        Me.LineDiscountPercent = NewLineDiscountPercent
                        Me.UnitPrice = Me.UnitPriceBeforeDiscount * (1 - Me.LineDiscountPercent)
                        UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Discount changed from {0}% to {1}% as it was set to high.", tmpLineDiscountPercent * 100, Me.LineDiscountPercent * 100))
                    End If
                End If
            End If
            If Me.TotalCost <> Me.Quantity * Me.UnitSize * Me.UnitCost Then
                Me.TotalCost = Me.Quantity * Me.UnitSize * Me.UnitCost
            End If

            If Me.WorkCentre.GLExpense Or Me.WorkCentre.APExpense Then
                Me.TotalCost = Me.Quantity * Me.UnitCost
            End If

            If Math.Round(CDbl(Me.TotalPrice), 2) <> Math.Round(CDbl(Me.Quantity * Me.UnitSize * Me.UnitPrice), 2) Then
                Me.TotalPrice = Math.Round(CDbl(Me.Quantity * Me.UnitSize * Me.UnitPrice), 2)
            End If

            ' qty * unit b4 * 
        End If
    End Sub





    'Public Overridable ReadOnly Property CustomerWorkCenterCategory As API.CustomerWorkCentreCategory
    '    Get
    '        If Me.WorkCentreCategory IsNot Nothing Then
    '            Return API.CustomerWorkCentreCategory.FindAllByProperty("WorkCentreCategoryID", Me.WorkCentreCategory.ID).FirstOrDefault
    '        End If
    '        Return Nothing
    '    End Get
    'End Property

    'Public Overridable ReadOnly Property CustomerRatePrice As API.CustomerRatePrice
    '    Get
    '        Return API.CustomerRatePrice.FindAllByProperty("CustomerID", Me.Customer.ID).FirstOrDefault

    '    End Get
    'End Property

    'Public Overridable ReadOnly Property PricellistID As Integer
    '    Get
    '        
    '        If CustomerRatePrice IsNot Nothing And CustomerWorkCenterCategory IsNot Nothing Then
    '            Select Case Me.RateType
    '                Case API.RateType.Saturdayday
    '                    If defs.PricelistSource = API.PricelistSource.Customer Then
    '                        Return CustomerRatePrice.SaturdayDayPriceList
    '                    Else
    '                        Return CustomerWorkCenterCategory.SaturdayDayPricelist
    '                    End If
    '                Case API.RateType.Saturdaynight
    '                    If defs.PricelistSource = API.PricelistSource.Customer Then
    '                        Return CustomerRatePrice.SaturdayNightPriceList
    '                    Else
    '                        Return CustomerWorkCenterCategory.SaturdayNightPricelist
    '                    End If
    '                Case API.RateType.Sundayday
    '                    If defs.PricelistSource = API.PricelistSource.Customer Then
    '                        Return CustomerRatePrice.SaturdayDayPriceList
    '                    End If
    '                Case API.RateType.Sundaynight
    '                    If defs.PricelistSource = API.PricelistSource.Customer Then
    '                        Return CustomerRatePrice.SundayNightPriceList
    '                    End If
    '                Case API.RateType.Publicholidayday
    '                    If defs.PricelistSource = API.PricelistSource.Customer Then
    '                        Return CustomerRatePrice.PublicHolidayDayPricelist
    '                    End If
    '                Case API.RateType.Publicholidaynight
    '                    If defs.PricelistSource = API.PricelistSource.Customer Then
    '                        Return CustomerRatePrice.PublicHolidayNightPricelist
    '                    End If
    '                Case API.RateType.Weekday
    '                    If defs.PricelistSource = API.PricelistSource.Customer Then
    '                        Return CustomerRatePrice.WeekDayPriceList
    '                    ElseIf defs.PricelistSource = API.PricelistSource.WorkCentreCategory Then
    '                        Return CustomerWorkCenterCategory.WeekDayPriceList
    '                    End If
    '                Case API.RateType.Weeknight
    '                    If defs.PricelistSource = API.PricelistSource.Customer Then
    '                        Return CustomerRatePrice.WeekNightPriceList
    '                    Else
    '                        Return CustomerWorkCenterCategory.WeekNightPricelist
    '                    End If
    '            End Select

    '        End If
    '    End Get
    'End Property
    'Public Overrides Property TimeUnitPrice As Double?
    '    Get
    '        If Me.PricellistID > 0 AndAlso Me.InventoryItem IsNot Nothing AndAlso CustomerWorkCenterCategory IsNot Nothing Then

    '            Me.InventoryTimeSellingPrice = Helper.ActiveRecord.Evolution.PricelistPrice.FindByItemAndPricelistID(Me.InventoryItem, Me.PricellistID)
    '            If Me.InventoryTimeSellingPrice IsNot Nothing Then
    '                Return InventoryTimeSellingPrice.FInclPrice
    '            End If
    '        End If
    '        Return (MyBase.TimeUnitPrice)
    '    End Get
    '    Set(value As Double?)
    '        MyBase.TimeUnitPrice = value
    '    End Set
    'End Property




    Public Overrides Property TotalPrice As Double?
        Get
            If MyBase.TotalPrice Is Nothing OrElse MyBase.TotalPrice = Me.Quantity * Me.UnitSize * Me.UnitPrice Then
                Return (Me.Quantity * Me.UnitSize * Me.UnitPrice)
            End If

            Return MyBase.TotalPrice
        End Get
        Set(value As Double?)
            MyBase.TotalPrice = value
        End Set
    End Property

    Public Overrides Property UnitPriceBeforeDiscount As Double?
        Get
            If MyBase.UnitPriceBeforeDiscount Is Nothing Then
                'MyBase.UnitPriceBeforeDiscount = 0
                Return 0
            End If
            Return MyBase.UnitPriceBeforeDiscount
        End Get
        Set(value As Double?)
            MyBase.UnitPriceBeforeDiscount = value
        End Set
    End Property

    Public Overrides Property UnitPriceBeforeMarkup As Double?
        Get
            If MyBase.UnitPriceBeforeMarkup Is Nothing Then
                'MyBase.UnitPriceBeforeMarkup = 0
                Return 0
            End If
            Return MyBase.UnitPriceBeforeMarkup
        End Get
        Set(value As Double?)
            MyBase.UnitPriceBeforeMarkup = value
        End Set
    End Property



    Public Overridable Function GetTransactionCode() As String
        Select Case Context.Defaults.CostCentreMethod
            Case CostCentreMethod.Default
                Return Context.Defaults.DefaultTransactionCode
            Case CostCentreMethod.Job
                If MyBase.Job.CostCentre IsNot Nothing Then
                    Return MyBase.Job.CostCentre.TransactionCode
                Else
                    Return Context.Defaults.DefaultTransactionCode
                End If
            Case CostCentreMethod.JobType
                If MyBase.Job.JobType IsNot Nothing AndAlso MyBase.Job.JobType.CostCentre IsNot Nothing Then
                    Return MyBase.Job.JobType.CostCentre.TransactionCode
                Else
                    Return Context.Defaults.DefaultTransactionCode
                End If
            Case CostCentreMethod.Part
                If MyBase.Part IsNot Nothing AndAlso MyBase.Part.TransactionTypeID IsNot Nothing Then
                    Return MyBase.Part.TransactionTypeID
                Else
                    Return Context.Defaults.DefaultTransactionCode
                End If
            Case CostCentreMethod.WorkCentre
                If MyBase.WorkCentre IsNot Nothing AndAlso MyBase.WorkCentre.CostCentre IsNot Nothing Then
                    Return MyBase.WorkCentre.CostCentre.TransactionCode
                Else
                    Return Context.Defaults.DefaultTransactionCode
                End If
            Case Else
                Return Nothing
        End Select
    End Function

    Public Overrides Property QuantityStock As Double?
        Get
            If MyBase.WorkCentre Is Nothing Then
                Return MyBase.QuantityStock
            End If
            If (MyBase.WorkCentre.IsBuyOut Is Nothing OrElse MyBase.WorkCentre.IsBuyOut = False) AndAlso MyBase.WorkCentre.CalculationType = UniSource.ShopFloor.API.CalculationType.Standard Then
                If MyBase.QuantityStock > MyBase.Quantity Then
                    MyBase.QuantityStock = MyBase.Quantity
                End If
                If MyBase.QuantityStock.HasValue = True AndAlso MyBase.QuantityStock >= 0 Then
                    Return MyBase.QuantityStock
                Else
                    Return MyBase.Quantity
                End If
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Double?)
            MyBase.QuantityStock = value
        End Set
    End Property

    Public Overrides Property QuantitySupplier1 As Double?
        Get
            If MyBase.WorkCentre Is Nothing Then
                Return MyBase.QuantitySupplier1
            End If
            If (MyBase.WorkCentre.IsBuyOut IsNot Nothing AndAlso MyBase.WorkCentre.IsBuyOut = True) Then 'AndAlso MyBase.WorkCentre.CalculationType = UniSource.ShopFloor.API.CalculationType.Standard Then
                If MyBase.QuantitySupplier1 > MyBase.Quantity Then
                    MyBase.QuantitySupplier1 = MyBase.Quantity
                End If
                If MyBase.QuantitySupplier1.HasValue = True AndAlso MyBase.QuantitySupplier1 > 0 Then
                    Return MyBase.QuantitySupplier1
                Else
                    Return MyBase.Quantity
                End If
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Double?)
            MyBase.QuantitySupplier1 = value
        End Set
    End Property

    Protected Friend Overridable Function GetRequisitionLine() As API.RequisitionLine

        If Me.WorkCentre Is Nothing Then Return Nothing
        If Not (Me.WorkCentre.CalculationType = CalculationType.Formula OrElse Me.WorkCentre.CalculationType = CalculationType.Standard) OrElse IIf(Me.WorkCentre.IsBuyOut.HasValue, Me.WorkCentre.IsBuyOut, False) Then Return Nothing

        If Me.InventoryItem Is Nothing Then Return Nothing

        If IIf(Me.QuantityStock.HasValue, Me.QuantityStock, 0) = 0 Then Return Nothing

        Dim remainder As Double = IIf(Me.QuantityStock.HasValue, Me.QuantityStock, 0)

        Me.RequisitionLineList.ToList()
        Me.RefreshOrderedStockDrawnQty()
        If Me.QuantityStockDrawn.HasValue Then
            remainder -= Me.QuantityStockDrawn
        End If

        If remainder <= 0 Then Return Nothing

        Dim rl As New RequisitionLine
        rl.JobLine = Me
        rl.InventoryItem = InventoryItem
        rl.MaxQuantity = remainder
        rl.Quantity = remainder
        Return rl
    End Function

    Protected Friend Overridable Function GetPurchaseOrderLine(ByVal supplier As Helper.ActiveRecord.Evolution.Vendor) As API.PurchaseOrderLine

        If Me.WorkCentre Is Nothing Then Return Nothing
        'If Not (Me.WorkCentre.CalculationType = CalculationType.Formula Or Me.WorkCentre.CalculationType = CalculationType.Standard) Or Not IIf(Me.WorkCentre.IsBuyOut.HasValue, Me.WorkCentre.IsBuyOut, False) Then Return Nothing
        If Not IIf(Me.WorkCentre.IsBuyOut.HasValue, Me.WorkCentre.IsBuyOut, False) Then Return Nothing

        If Me.InventoryItem Is Nothing Then Return Nothing

        If (IIf(Me.QuantitySupplier1.HasValue, Me.QuantitySupplier1, 0) + IIf(Me.QuantitySupplier2.HasValue, Me.QuantitySupplier2, 0)) = 0 Then Return Nothing

        If (Me.Supplier1 = supplier And IIf(Me.QuantitySupplier1.HasValue, Me.QuantitySupplier1, 0) = 0) Then Return Nothing
        If (Me.Supplier2 = supplier And IIf(Me.QuantitySupplier2.HasValue, Me.QuantitySupplier2, 0) = 0) Then Return Nothing

        Dim remainder As Double
        If Me.Supplier1 = supplier Then
            remainder = IIf(Me.QuantitySupplier1.HasValue, Me.QuantitySupplier1, 0)
        ElseIf Me.Supplier2 = supplier Then
            remainder = IIf(Me.QuantitySupplier2.HasValue, Me.QuantitySupplier2, 0)
        End If

        Me.PurchaseOrderLineList.ToString()
        If Me.QuantitySupplierOrdered.HasValue Then
            remainder -= Me.QuantitySupplierOrdered
        End If

        If remainder <= 0 Then Return Nothing

        Dim pol As New PurchaseOrderLine
        pol.JobLine = Me
        pol.UnitPrice = Me.UnitPurchasePrice
        pol.InventoryItem = InventoryItem
        pol.Quantity = remainder
        Return pol
    End Function

    'Public ReadOnly Property ISPOGenerated As Boolean
    Public Overridable ReadOnly Property ISPOGenerated As Boolean
        Get
            If Me.PurchaseOrderLines IsNot Nothing AndAlso Me.PurchaseOrderLines.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property ISRlGenerated As Boolean
        Get
            If Me.RequisitionLines IsNot Nothing AndAlso Me.RequisitionLines.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property


    'Public ReadOnly Property PartGroup As PartGroup
    '    Get
    '        If Part IsNot Nothing AndAlso Part.PartGroup IsNot Nothing Then
    '            Return Part.PartGroup
    '        Else
    '            Return Nothing
    '        End If
    '    End Get
    'End Property

    'Shannen 27/10/2020
    'To pull through the Project name for the MCTRequisition Report
    Public ReadOnly Property ProjectName As String
        Get
            Dim myProjectCode As String = ""
            If ProjectID IsNot Nothing Then
                Dim SqlSelectStatement As String = "Select Top 1 ProjectName From Project Where ProjectLink =" & ProjectID
                Dim cn As SqlConnection
                Dim cmd As SqlCommand
                cn = New SqlConnection(Context.ActiveConnection.Company.ConnectionString)
                cn.Open()
                cmd = New SqlCommand(SqlSelectStatement, cn)
                myProjectCode = Convert.ToString(cmd.ExecuteScalar)
                cmd.CommandType = CommandType.Text
                cmd.CommandText = SqlSelectStatement
                cn.Close()
            End If
            Return myProjectCode.ToString
        End Get
    End Property

    'Shannen 27/10/2020
    'To pull through the Req Line Quantity to work out the Quantity Drawn for the MCTRequisition Report
    Public Overridable ReadOnly Property QtyToBeDrawn As Double?

        Get

            Return Me.Quantity - QuantityStockDrawn

            ''Dim requisitionLineCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.RequisitionLine)()
            ''requisitionLineCrit.Add(NHibernate.Criterion.Expression.Sql("JobLineID = " & ID))
            ''Dim RequisitionLineList As List(Of API.RequisitionLine) = API.RequisitionLine.FindAll(requisitionLineCrit).ToList()


            'Dim ReqLineQty As String = ""
            'Dim SqlSelectStatement As String = "select Quantity from ussSFRequisitionLine where JobLineID = " & ID
            'Dim cn As SqlConnection
            'Dim cmd As SqlCommand
            'cn = New SqlConnection(Context.ActiveConnection.Company.ConnectionString)
            'cn.Open()
            'cmd = New SqlCommand(SqlSelectStatement, cn)
            'ReqLineQty = Convert.ToString(cmd.ExecuteScalar)
            'cmd.CommandType = CommandType.Text
            'cmd.CommandText = SqlSelectStatement
            'cn.Close()

            'If ReqLineQty Is Nothing OrElse ReqLineQty = "" Then
            '    ReqLineQty = "0"
            'End If

            'Dim QtyRepLine As Double = CDbl(ReqLineQty)

            'Dim QtyToBeDrawnRep As Double? = Me.Quantity - QtyRepLine

            'If Me.Quantity Is Nothing Then
            '    QtyToBeDrawn = QtyRepLine
            'End If

            'If QtyToBeDrawnRep <> 0 Then
            '    QtyToBeDrawn = QtyToBeDrawnRep
            'End If

            'If QtyToBeDrawn Is Nothing Then
            '    QtyToBeDrawn = 0

            'End If
            'Return QtyToBeDrawn
        End Get
    End Property

    Public Overrides Sub Save()
        If IsValid() Then
            'MyBase.SaveAndFlush()
            MyBase.Save()
        End If

    End Sub

    Public Overrides Sub Delete()
        If IsCancelled Is Nothing OrElse IsCancelled = False Then
            MyBase.Delete()
        End If
    End Sub

    Private Property _eRPInventoryItem As Pastel.Evolution.InventoryItem
    Public ReadOnly Property ERPInventoryItem As Pastel.Evolution.InventoryItem
        Get
            If IsLoading = False Then
                If _eRPInventoryItem Is Nothing AndAlso InventoryItemID IsNot Nothing AndAlso InventoryItemID > 0 Then
                    Try
                        _eRPInventoryItem = New Pastel.Evolution.InventoryItem(InventoryItemID.Value)
                    Catch ex As Exception

                    End Try
                End If
            End If
            Return _eRPInventoryItem
        End Get
    End Property

    Private Property _eRPWarehouse As Pastel.Evolution.Warehouse
    '<BelongsTo("TemplateID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    Public Overridable ReadOnly Property ERPWarehouse As Pastel.Evolution.Warehouse
        Get
            If IsLoading = False Then
                Dim _changedERPWarehouse As Boolean = False
                If InventoryItem.WhseItem = True Then
                    If WarehouseID IsNot Nothing AndAlso WarehouseID <> "" AndAlso WarehouseID <> "0" Then
                        Try
                            If _eRPWarehouse Is Nothing OrElse _eRPWarehouse.ID <> WarehouseID Then
                                _eRPWarehouse = New Pastel.Evolution.Warehouse(CInt(WarehouseID))
                                _changedERPWarehouse = True
                            End If
                        Catch ex As Exception
                        End Try
                    End If
                    If _eRPWarehouse Is Nothing OrElse WarehouseID Is Nothing OrElse WarehouseID = "" OrElse WarehouseID = "0" Then
                        Try
                            _eRPWarehouse = New Pastel.Evolution.Warehouse(API.Context.Defaults.ManufacturingWarehouse)
                            _changedERPWarehouse = True
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    If _eRPWarehouse IsNot Nothing Then
                        _eRPWarehouse = Nothing
                        WarehouseID = Nothing
                        _changedERPWarehouse = True
                    End If
                End If

                'If _changedERPWarehouse Then
                '    Me.NotifyPropertyChanged("ERPWarehouseDescription")
                'End If

            End If
            Return _eRPWarehouse
        End Get
    End Property

    Public Overridable ReadOnly Property ERPWarehouseDescription As String
        Get
            If IsLoading = False Then
                If ERPWarehouse IsNot Nothing Then
                    Return String.Format("{0}", ERPWarehouse.Code)
                End If
            End If
            Return ""
        End Get
    End Property

    Private Property _availibleERPQty As Double?
    Public Overridable ReadOnly Property AvailibleERPQty As Double?

        Get
            Dim _currentAvailibleERPQty As Double? = _availibleERPQty

            _availibleERPQty = OnHandERPQty - AllocatedERPQty

            If _availibleERPQty <> _currentAvailibleERPQty Then
                Me.NotifyPropertyChanged("AvailibleERPQty")
            End If
            Return _availibleERPQty
        End Get
    End Property

    Private Property _onHandERPQty As Double?
    Public Overridable ReadOnly Property OnHandERPQty As Double?

        Get
            Dim _currentOnHandERPQty As Double? = _onHandERPQty
            If InventoryItem IsNot Nothing AndAlso InventoryItem.ServiceItem = False AndAlso ERPWarehouse IsNot Nothing Then
                If InventoryItem.WhseItem Then
                    If ERPInventoryItem.LinkedWarehouse(ERPWarehouse.Code) Then
                        _onHandERPQty = ERPInventoryItem.WarehouseContexts(ERPWarehouse).QtyOnHand
                    Else
                        _onHandERPQty = 0
                    End If

                Else
                    _onHandERPQty = ERPInventoryItem.QtyOnHand
                End If
            Else
                _onHandERPQty = 0
            End If

            If _onHandERPQty <> _currentOnHandERPQty Then
                Me.NotifyPropertyChanged("OnHandERPQty")
            End If
            Return _onHandERPQty
        End Get
    End Property

    Private Property _allocatedERPQty As Double?
    Public Overridable ReadOnly Property AllocatedERPQty As Double?

        Get
            Dim _currentAllocatedERPQty As Double? = _allocatedERPQty
            If InventoryItem IsNot Nothing AndAlso InventoryItem.ServiceItem = False AndAlso ERPWarehouse IsNot Nothing Then
                If InventoryItem.WhseItem Then
                    If ERPInventoryItem.LinkedWarehouse(ERPWarehouse.Code) Then
                        _allocatedERPQty = ERPInventoryItem.WarehouseContexts(ERPWarehouse).QtyWIP
                    Else
                        _allocatedERPQty = 0
                    End If

                Else
                    _allocatedERPQty = ERPInventoryItem.QtyWIP
                End If
            Else
                _allocatedERPQty = 0
            End If

            If _allocatedERPQty <> _currentAllocatedERPQty Then
                Me.NotifyPropertyChanged("AllocatedERPQty")
            End If
            Return _allocatedERPQty
        End Get
    End Property
    Private _preRequisitionPrintedAgent As Helper.ActiveRecord.Evolution.Agents
    Public Overridable Property PreRequisitionPrintedAgent As Helper.ActiveRecord.Evolution.Agents
        Get
            If IsLoading = False AndAlso Me.PreRequisitionPrintedAgentID IsNot Nothing Then
                _preRequisitionPrintedAgent = Helper.ActiveRecord.Evolution.Agents.Find(Me.PreRequisitionPrintedAgentID.Value)
                Return _preRequisitionPrintedAgent
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.Agents)
            _preRequisitionPrintedAgent = value
            NotifyPropertyChanged("PreRequisitionPrintedAgent")
        End Set
    End Property

End Class
