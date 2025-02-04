Public Class Checklist

    Private _checklistoptions As ComponentModel.BindingList(Of ChecklistChecklistOption)
    Public Overridable Overloads ReadOnly Property ChecklistOption As ComponentModel.BindingList(Of ChecklistChecklistOption)
        Get
            If _checklistoptions Is Nothing Then
                _checklistoptions = New ComponentModel.BindingList(Of ChecklistChecklistOption)(MyBase.ChecklistChecklistTasks)
            End If
            Return _checklistoptions
        End Get
    End Property

    Private _checklistlogs As ComponentModel.BindingList(Of ChecklistLog)
    Public Overridable Overloads ReadOnly Property ChecklistLog As ComponentModel.BindingList(Of ChecklistLog)
        Get
            If _checklistlogs Is Nothing Then
                _checklistlogs = New ComponentModel.BindingList(Of ChecklistLog)(MyBase.CheckListLogs)
            End If
            Return _checklistlogs
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", Me.Code, Me.Description)
    End Function

End Class
