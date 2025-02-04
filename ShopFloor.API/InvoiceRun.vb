Public Class InvoiceRun

    Private WithEvents _invoicerunlist As ComponentModel.BindingList(Of InvoiceRunline)
    Public Overridable Overloads ReadOnly Property InvoiceRunLineList As ComponentModel.BindingList(Of InvoiceRunline)
        Get
            If IsLoading = False AndAlso _invoicerunlist Is Nothing Then
                _invoicerunlist = New ComponentModel.BindingList(Of InvoiceRunline)(Me.InvoiceRunLines)

            End If
            Return _invoicerunlist
        End Get
    End Property
    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid
        If IsLoading = False Then
                
        End If

        If Me.StartDate.Value > Me.EndDate.Value Then
            If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("EndDate")) Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("EndDate"), New ArrayList())
            End If
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("EndDate")).Add("EndDate must be  Greater StartDate.")
            valid = False
        End If
            
        Return valid
    End Function
End Class
