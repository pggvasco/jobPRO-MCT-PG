Public Class PartGroup

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", MyBase.Code, MyBase.Description)
    End Function

    'Public Overrides Function Equals(obj As Object) As Boolean
    '    If Me Is Nothing OrElse obj Is Nothing Then
    '        Return False
    '    End If
    '    If Me.Code = CType(obj, PartGroup).Code Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

End Class
