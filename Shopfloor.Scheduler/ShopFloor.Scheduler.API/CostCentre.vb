Public Class CostCentre

    Private _transactiontype As Pastel.Evolution.JobTransactionCode
    Protected Friend Overridable ReadOnly Property TransactionType As Pastel.Evolution.JobTransactionCode
        Get
            If _transactiontype Is Nothing And Not String.IsNullOrEmpty(Me.TransactionCode) Then
                Try
                    _transactiontype = New Pastel.Evolution.JobTransactionCode(Pastel.Evolution.JobDetail.TransactionSource.Inventory, Me.TransactionCode)
                Catch ex As Exception

                End Try
            End If
            Return _transactiontype
        End Get
    End Property

    Public Overrides Function ToString() As String
        'Return String.Format("{0} - {1}", MyBase.Code, MyBase.Description)
        Return MyBase.Code
    End Function

End Class
