Public Class ChecklistLog

    Private _checklistoptionlogs As ComponentModel.BindingList(Of ChecklistOptionLog)
    Public Overridable Overloads ReadOnly Property ChecklistOptionLogList As ComponentModel.BindingList(Of ChecklistOptionLog)
        Get
            If _checklistoptionlogs Is Nothing Then
                _checklistoptionlogs = New ComponentModel.BindingList(Of ChecklistOptionLog)(MyBase.ChecklistOptionLogs)
            End If
            Return _checklistoptionlogs
        End Get
    End Property

End Class
