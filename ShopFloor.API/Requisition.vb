Public Class Requisition

    Private WithEvents _requisitionlinelist As ComponentModel.BindingList(Of RequisitionLine)
    Public Overridable Overloads ReadOnly Property RequisitionLineList As ComponentModel.BindingList(Of RequisitionLine)
        Get
            If _requisitionlinelist Is Nothing Then
                _requisitionlinelist = New ComponentModel.BindingList(Of RequisitionLine)(Me.RequisitionLines)
            End If
            Return _requisitionlinelist
        End Get
    End Property

    Private WithEvents _requisitionJob As Job
    Public Overridable Overloads ReadOnly Property RequisitionJob As Job
        Get
            If _requisitionJob Is Nothing Then
                _requisitionJob = Me.Job
            End If
            Return _requisitionJob
        End Get
    End Property

    Protected Overrides Function BeforeSave(ByVal state As System.Collections.IDictionary) As Boolean

        If ID = 0 Then
            Dim AutoGenSuccess As Boolean = False
            'Dim CheckoutGuid As Guid
            While AutoGenSuccess = False
                'Dim bc As New Helper.ActiveRecord.Checkout
                'If bc.AddCheckOutoverrideFalse("Defaults", 1) Then
                'CheckoutGuid = bc.Checkout.GUID

                'Tawanda- This is the line for the req number

                'state("Number") = Defaults.Defaults.GetNextRequisitionNumberAndIncrement(Me.Job)
                'CType(state("Job"), Job).RequisitionNumber = state("Number")
                'CType(state("Job"), Job).Save()

                'Tawanda warehouse issue number 

                state("Number") = Defaults.Defaults.GetNextWarehouseIssueNumberAndIncrement(Me.Job)
                CType(state("Job"), Job).RequisitionNumber = state("Number")
                CType(state("Job"), Job).Save()

                'If bc.AlreadyCheckedOut(CheckoutGuid) Then
                '    bc.RemoveCheckout(CheckoutGuid)
                AutoGenSuccess = True
                'Else
                '    AutoGenSuccess = False
                'End If
                'End If
            End While
        End If
        Return MyBase.BeforeSave(state)
    End Function

    Public Shared Function PrintRequisition()

        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        crit.Add(New NHibernate.Criterion.OrExpression(NHibernate.Criterion.Expression.IsNull("CollectionLoad"), NHibernate.Criterion.Expression.Eq("CollectionLoad", False)))

        Dim result = API.Job.FindAll(crit).ToList

        If result IsNot Nothing Then
            Return result
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function PrintPreRequisition()

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
