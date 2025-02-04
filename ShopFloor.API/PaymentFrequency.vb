Public Class PaymentFrequency

    Private WithEvents _paymentFrequencyTypelist As ComponentModel.BindingList(Of PaymentFrequencyType)
    Public Overridable Overloads ReadOnly Property PaymentFrequencyTypeList As ComponentModel.BindingList(Of PaymentFrequencyType)
        Get
            If IsLoading = False AndAlso _paymentFrequencyTypelist Is Nothing Then
                'If Me.JobLines IsNot Nothing Then
                _paymentFrequencyTypelist = New ComponentModel.BindingList(Of PaymentFrequencyType)(Me.PaymentFrequencyTypes)
                'End If
            End If
            Return _paymentFrequencyTypelist
        End Get
    End Property
End Class
