Public Class CustomerWorkCentreCategory



    Private WithEvents _jobclasslist As ComponentModel.BindingList(Of CustomerJobClass)
    Public Overridable Overloads ReadOnly Property JobclassLineList As ComponentModel.BindingList(Of CustomerJobClass)
        Get
            If IsLoading = False AndAlso _jobclasslist Is Nothing Then
                _jobclasslist = New ComponentModel.BindingList(Of CustomerJobClass)(Me.CustomerJobClasses)

            End If
            Return _jobclasslist
        End Get
    End Property
End Class
