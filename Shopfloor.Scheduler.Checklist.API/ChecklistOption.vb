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

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", Me.Code, Me.Description)
    End Function

End Class
