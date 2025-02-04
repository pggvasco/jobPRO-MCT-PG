Public Class Part

    Private _activities As ComponentModel.BindingList(Of Activity)
    Public Overridable Overloads ReadOnly Property ActivityList As ComponentModel.BindingList(Of Activity)
        Get
            If _activities Is Nothing Then
                _activities = New ComponentModel.BindingList(Of Activity)(MyBase.Activities)
            End If
            Return _activities
        End Get
    End Property

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
