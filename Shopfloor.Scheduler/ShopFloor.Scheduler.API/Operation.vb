Imports Castle.ActiveRecord

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

    Private _checklist As UniSource.Checklist.API.Checklist
    <BelongsTo("ChecklistID", Cascade:=CascadeEnum.SaveUpdate, NotFoundBehaviour:=NotFoundBehaviour.Ignore)> _
    Public Overridable Property Checklist() As UniSource.Checklist.API.Checklist
        Get
            Return Me._checklist
        End Get
        Set(ByVal value As UniSource.Checklist.API.Checklist)
            If ((_checklist <> value) _
                        Or (_checklist Is Nothing)) Then
                Me._checklist = value
                Me.NotifyPropertyChanged("Checklist")
            End If
        End Set
    End Property

    Private _serviceitem As Pastel.Evolution.InventoryItem
    Protected Friend Overridable ReadOnly Property ServiceItem As Pastel.Evolution.InventoryItem
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
    Public Overrides Property AllowArtisanToAssign As Boolean?
        Get
           
            Return MyBase.AllowArtisanToAssign
        End Get
        Set(value As Boolean?)
            MyBase.AllowArtisanToAssign = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        'Return String.Format("{0} - {1}", MyBase.Code, MyBase.Description)
        Return MyBase.Code
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If Me Is Nothing OrElse obj Is Nothing OrElse Me.Code Is Nothing OrElse CType(obj, Operation).Code Is Nothing Then
            Return False
        End If
        If Me.Code = CType(obj, Operation).Code Then
            Return True
        Else
            Return False
        End If
        'Return MyBase.Equals(obj)
    End Function

End Class
