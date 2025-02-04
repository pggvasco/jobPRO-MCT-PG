Public Class Customer

    Public Overridable Property Colour As System.Drawing.Color
        Get
            If Not String.IsNullOrEmpty(MyBase.DBColour) Then
                Return System.Drawing.Color.FromName(MyBase.DBColour)
            End If
            Return Nothing
        End Get
        Set(ByVal value As System.Drawing.Color)
            MyBase.DBColour = value.Name
        End Set
    End Property

    Public Overrides Function ToString() As String
        'Return String.Format("{0} - {1}", MyBase.Code, MyBase.Description)
        Return MyBase.Code
    End Function

End Class
