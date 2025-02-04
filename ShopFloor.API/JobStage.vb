Public Class JobStage

    Private _functions As ComponentModel.BindingList(Of JobStageFunction)
    Public Overridable Overloads ReadOnly Property Functions As ComponentModel.BindingList(Of JobStageFunction)
        Get
            If _functions Is Nothing Then
                _functions = New ComponentModel.BindingList(Of JobStageFunction)(Me.JobStageFunctions)
            End If
            Return _functions
        End Get
    End Property

    Private _triggers As ComponentModel.BindingList(Of JobStageTrigger)
    Public Overridable Overloads ReadOnly Property Triggers As ComponentModel.BindingList(Of JobStageTrigger)
        Get
            If _triggers Is Nothing Then
                _triggers = New ComponentModel.BindingList(Of JobStageTrigger)(Me.JobStageTriggers)
            End If
            Return _triggers
        End Get
    End Property

    Private _fieldprompts As ComponentModel.BindingList(Of JobStageFieldPrompt)
    Public Overridable Overloads ReadOnly Property FieldPrompts As ComponentModel.BindingList(Of JobStageFieldPrompt)
        Get
            If _fieldprompts Is Nothing Then
                _fieldprompts = New ComponentModel.BindingList(Of JobStageFieldPrompt)(Me.JobStageFieldPrompts)
            End If
            Return _fieldprompts
        End Get
    End Property

    Private _reports As ComponentModel.BindingList(Of JobStageReport)
    Public Overridable Overloads ReadOnly Property Reports As ComponentModel.BindingList(Of JobStageReport)
        Get
            If _reports Is Nothing Then
                _reports = New ComponentModel.BindingList(Of JobStageReport)(Me.JobStageReports)
            End If
            Return _reports
        End Get
    End Property

    Private _checklists As ComponentModel.BindingList(Of JobStageChecklist)
    Public Overridable Overloads ReadOnly Property Checklists As ComponentModel.BindingList(Of JobStageChecklist)
        Get
            If _checklists Is Nothing Then
                _checklists = New ComponentModel.BindingList(Of JobStageChecklist)(Me.JobStageChecklists)
            End If
            Return _checklists
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", MyBase.Code, MyBase.Description)
    End Function


    Public Overrides Property IsZeroDiscountChecked As Boolean?
        Get
            If MyBase.IsZeroDiscountChecked Is Nothing Then
                MyBase.IsZeroDiscountChecked = False
            End If
            Return MyBase.IsZeroDiscountChecked
        End Get
        Set(value As Boolean?)
            MyBase.IsZeroDiscountChecked = value
        End Set
    End Property

    Public Overrides Property IsCustomerOnHoldChecked As Boolean?
        Get
            If MyBase.IsCustomerOnHoldChecked Is Nothing Then
                MyBase.IsCustomerOnHoldChecked = False
            End If
            Return MyBase.IsCustomerOnHoldChecked
        End Get
        Set(value As Boolean?)
            MyBase.IsCustomerOnHoldChecked = value
        End Set
    End Property

End Class
