Public Class Drawing

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", MyBase.Code, MyBase.DrawingPath)
    End Function

    Public Overrides Property NumberOfAnnotations As Integer?
        Get
            If MyBase.NumberOfAnnotations Is Nothing Then
                MyBase.NumberOfAnnotations = 0
            End If
            Return MyBase.NumberOfAnnotations
        End Get
        Set(value As Integer?)
            MyBase.NumberOfAnnotations = value
        End Set
    End Property

End Class
