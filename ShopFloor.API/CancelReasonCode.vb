Public Class CancelReasonCode
    Public Overrides Property IsCommentAllowed As Boolean?
        Get
            If MyBase.IsCommentAllowed Is Nothing Then
                MyBase.IsCommentAllowed = False
            End If
            Return MyBase.IsCommentAllowed
        End Get
        Set(value As Boolean?)
            MyBase.IsCommentAllowed = value
        End Set
    End Property
    Public Overrides Property IsForceCommentValue As Boolean?
        Get
            If MyBase.IsForceCommentValue Is Nothing Then
                MyBase.IsForceCommentValue = False
            End If
            Return MyBase.IsForceCommentValue
        End Get
        Set(value As Boolean?)
            MyBase.IsForceCommentValue = value
        End Set
    End Property
End Class
