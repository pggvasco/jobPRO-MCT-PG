Imports UniSource

Public Class JobFunctionControl
    Implements Helper.ActiveRecord.IIdentifier

    Protected Overridable Property ID As Object Implements Helper.ActiveRecord.IIdentifier.ID
        Get
            If MyBase.JobFunctionID Is Nothing Then
                Return -1
            End If

            Return MyBase.JobFunctionID
        End Get
        Set(ByVal value As Object)
            MyBase.JobFunctionID = value
        End Set
    End Property

    Public Overridable Property JobFunction As JobFunction
        Get
            Return IIf(IsNothing(MyBase.JobFunctionID) OrElse MyBase.JobFunctionID < 0, Nothing, MyBase.JobFunctionID)
        End Get
        Set(ByVal value As JobFunction)
            MyBase.JobFunctionID = value
        End Set
    End Property

End Class
