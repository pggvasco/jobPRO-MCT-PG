Imports Castle.ActiveRecord

Public Class JobType

    Private _stages As ComponentModel.BindingList(Of JobTypeStage)
    Public Overridable Overloads ReadOnly Property Stages As ComponentModel.BindingList(Of JobTypeStage)
        Get
            If _stages Is Nothing Then
                _stages = New ComponentModel.BindingList(Of JobTypeStage)(Me.JobTypeStages)
            End If
            Return _stages
        End Get
    End Property

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid

        If Context.Defaults.CostCentreMethod = CostCentreMethod.JobType Then
            If Me.CostCentre Is Nothing Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("CostCentre"), New ArrayList())
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("CostCentre")).Add("Cost Centre is required due to Cost Centre Method.")
                valid = False
            End If
        End If

        Return valid
    End Function

    Public Overridable Property RevenueMethod As API.RevenueMethod
        Get
            If MyBase.RevenueMethodID.HasValue Then
                Return MyBase.RevenueMethodID
            Else
                Return API.RevenueMethod.None
            End If
        End Get
        Set(ByVal value As API.RevenueMethod)
            MyBase.RevenueMethodID = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", MyBase.Code, MyBase.Description)
    End Function

End Class
