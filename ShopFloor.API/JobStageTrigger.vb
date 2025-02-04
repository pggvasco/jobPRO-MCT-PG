Public Class JobStageTrigger

    Public Property TriggerID As Trigger
        Get
            If Me.TriggerIDValue Is Nothing Then
                Me.TriggerIDValue = Trigger.JobToErp
            End If
            Return Me.TriggerIDValue
        End Get
        Set(value As Trigger)
            Me.TriggerIDValue = value
        End Set
    End Property
End Class
