Public Class ChecklistType

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", Me.Code, Me.Description)
    End Function

End Class
