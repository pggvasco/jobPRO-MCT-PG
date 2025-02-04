Public Class Operation

    Private _activities As ComponentModel.BindingList(Of Activity)
    Public Overridable Overloads ReadOnly Property ActivityList As ComponentModel.BindingList(Of Activity)
        Get
            If _activities Is Nothing Then
                _activities = New ComponentModel.BindingList(Of Activity)(MyBase.Activities)
            End If
            Return _activities
        End Get
    End Property

    Private _serviceitem As Pastel.Evolution.InventoryItem
    Protected Friend ReadOnly Property ServiceItem As Pastel.Evolution.InventoryItem
        Get
            If _serviceitem Is Nothing And Not String.IsNullOrEmpty(Me.ServiceCode) Then
                Try
                    _serviceitem = New Pastel.Evolution.InventoryItem(Me.ServiceCode)
                Catch ex As Exception
                    _serviceitem = New Pastel.Evolution.InventoryItem
                    _serviceitem.IsServiceItem = True
                    _serviceitem.Code = Me.Code
                    _serviceitem.Description = Me.Description
                    Try
                        _serviceitem.Save()
                    Catch ex2 As Exception
                        Throw New Exception("Error creating Service Item.")
                    End Try
                End Try
            End If
            Return _serviceitem
        End Get
    End Property

    Public Overrides Function ToString() As String
        'Return String.Format("{0} - {1}", MyBase.Code, MyBase.Description)
        Return MyBase.Code
    End Function

End Class
