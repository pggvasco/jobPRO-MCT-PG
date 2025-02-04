Public Class ChecklistOption

    Private _checklistoptions As ComponentModel.BindingList(Of ChecklistChecklistOption)
    Public Overridable Overloads ReadOnly Property ChecklistOption As ComponentModel.BindingList(Of ChecklistChecklistOption)
        Get
            If _checklistoptions Is Nothing Then
                _checklistoptions = New ComponentModel.BindingList(Of ChecklistChecklistOption)(MyBase.ChecklistChecklistTasks)
            End If
            Return _checklistoptions
        End Get
    End Property

    Public Overrides Property RequiredValue As String
        Get
            If MyBase.RequiredValue Is Nothing Then
                MyBase.RequiredValue = ""
            End If
            Return MyBase.RequiredValue
        End Get
        Set(value As String)
            MyBase.RequiredValue = value
        End Set
    End Property

    Public Property DataType As Datatype
        Get
            If DataTypeID IsNot Nothing Then
                Return CType(DataTypeID, Datatype)
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Datatype)
            DataTypeID = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", Me.Code, Me.Description)
    End Function

End Class
