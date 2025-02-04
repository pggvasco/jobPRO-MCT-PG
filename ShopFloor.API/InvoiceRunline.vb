Public Class InvoiceRunline
    Public Overridable ReadOnly Property Hospital As UniSource.Helper.ActiveRecord.Evolution.Client
        Get
            Return UniSource.Helper.ActiveRecord.Evolution.Client.Find(CInt(Me.CustomerID))
        End Get
    End Property
    Public Overridable ReadOnly Property Name As String
        Get
            If Hospital IsNot Nothing Then
                Return Hospital.Name
            End If
        End Get
    End Property
    Public Overridable ReadOnly Property SalesOrder As Pastel.Evolution.SalesOrder
        Get
            Return New Pastel.Evolution.SalesOrder(CInt(InvoiceID))
        End Get
    End Property


    Private WithEvents _invoicelinklist As ComponentModel.BindingList(Of InvoiceLink)
    Public Overridable Overloads ReadOnly Property InvoiceLinkLineList As ComponentModel.BindingList(Of InvoiceLink)
        Get
            If IsLoading = False AndAlso _invoicelinklist Is Nothing Then
                _invoicelinklist = New ComponentModel.BindingList(Of InvoiceLink)(Me.Invoicelinks)

            End If
            Return _invoicelinklist
        End Get
    End Property
End Class