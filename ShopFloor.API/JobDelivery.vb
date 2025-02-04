Public Class JobDelivery

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid()

        If Me.ID = 0 AndAlso Me.Job IsNot Nothing Then
            Dim remainder As Double = IIf(Me.Job.Quantity.HasValue, Me.Job.Quantity, 0)
            Me.Job.JobDeliveryList.ToString()
            If Me.Job.QuantityDelivered.HasValue Then
                remainder -= Me.Job.QuantityDelivered
            End If
            If Me.Quantity > remainder Then
                If Not Me.PropertiesValidationErrorMessages.Contains(Me.GetType.GetProperty("Quantity")) Then
                    Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("Quantity"), New ArrayList())
                End If
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("Quantity")).Add(String.Format("Quantity to deliver of {0} exceeds remaining Job quantity of {1}.", Me.Quantity, remainder))
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
        If ID = 0 Then
            state("DeliveryNumber") = Defaults.Defaults.GetNextDeliveryNumberAndIncrement(Me)
            CType(state("Job"), Job).DeliveryNumber = state("DeliveryNumber")
            CType(state("Job"), Job).Save()
        End If
        Return MyBase.BeforeSave(state)
    End Function

End Class
