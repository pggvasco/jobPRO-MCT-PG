Imports Castle.ActiveRecord
Imports UniSource

Public Class PurchaseOrder

    <BelongsTo("SupplierID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    Public Overridable Property Supplier As Helper.ActiveRecord.Evolution.Vendor

    Private WithEvents _PurchaseOrderlinelist As ComponentModel.BindingList(Of PurchaseOrderLine)
    Public Overridable Overloads ReadOnly Property PurchaseOrderLineList As ComponentModel.BindingList(Of PurchaseOrderLine)
        Get
            If _PurchaseOrderlinelist Is Nothing Then
                _PurchaseOrderlinelist = New ComponentModel.BindingList(Of PurchaseOrderLine)(Me.PurchaseOrderLines)
            End If
            Return _PurchaseOrderlinelist
        End Get
    End Property

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid()

        For Each pol As PurchaseOrderLine In Me.PurchaseOrderLines
            valid = pol.IsValid
        Next

        Return valid
    End Function

    Protected Overrides Function BeforeSave(ByVal state As System.Collections.IDictionary) As Boolean
        If ID = 0 Then
            Dim AutoGenSuccess As Boolean = False
            'Dim CheckoutGuid As Guid
            While AutoGenSuccess = False
                'Dim bc As New Helper.ActiveRecord.Checkout
                'If bc.AddCheckOutoverrideFalse("Defaults", 1) Then
                'CheckoutGuid = bc.Checkout.GUID
                state("OrderNumber") = Defaults.Defaults.GetNextPurchaseOrderNumberAndIncrement(Me.Job)
                'If bc.AlreadyCheckedOut(CheckoutGuid) Then
                'bc.RemoveCheckout(CheckoutGuid)
                AutoGenSuccess = True
                'Else
                'AutoGenSuccess = False
                'End If
                'End If
            End While
        End If
        Return MyBase.BeforeSave(state)
    End Function

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If obj IsNot Nothing Or Me.GetType() Is obj.GetType() Then
            If Me.ID > 0 Then
                Return MyBase.Equals(obj)
            Else
                Return Me.Supplier = obj.Supplier
            End If
        Else
            Return MyBase.Equals(obj)
        End If
    End Function

    Public Shared Function PrintPO()

        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        crit.Add(New NHibernate.Criterion.OrExpression(NHibernate.Criterion.Expression.IsNull("CollectionLoad"), NHibernate.Criterion.Expression.Eq("CollectionLoad", False)))

        Dim result = API.Job.FindAll(crit).ToList

        If result IsNot Nothing Then
            Return result
        Else
            Return Nothing
        End If
    End Function
End Class
