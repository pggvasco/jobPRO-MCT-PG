Imports Castle.ActiveRecord

Public Class JobStageFunction

    Private _jobFunctionControl As JobFunctionControl
    <BelongsTo("JobFunctionID", Fetch:=FetchEnum.Join, Access:=PropertyAccess.NosetterCamelcaseUnderscore, NotFoundBehaviour:=NotFoundBehaviour.Ignore, Update:=False, insert:=False)> _
    Public Overridable ReadOnly Property JobFunctionControl() As JobFunctionControl
        Get
            Return _jobFunctionControl
        End Get
    End Property

    Public Overridable Property JobFunction As JobFunction
        Get
            If MyBase.JobFunctionID Is Nothing Then
                Return JobFunction.None
            Else
                Return MyBase.JobFunctionID
            End If
        End Get
        Set(ByVal value As JobFunction)
            MyBase.JobFunctionID = value
        End Set
    End Property

    Public Overrides Property JobFunctionID As Integer?
        Get
            If MyBase.JobFunctionID Is Nothing Then
                Return JobFunction.None
            Else
                Return MyBase.JobFunctionID
            End If
        End Get
        Set(ByVal value As Integer?)
            MyBase.JobFunctionID = value
        End Set
    End Property

End Class
