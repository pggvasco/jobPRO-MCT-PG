Imports Castle.ActiveRecord
Public Class ScheduleFrequency

    Private Property _jobTemplate As JobTemplate
    '<BelongsTo("TemplateID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    Public Overridable Property JobTemplate As JobTemplate
        Get
            If IsLoading = False Then
                If TemplateID IsNot Nothing AndAlso TemplateID > 0 Then
                    _jobTemplate = JobTemplate.Get(TemplateID)
                End If
            End If
            Return _jobTemplate
        End Get
        Set(value As JobTemplate)
            _jobTemplate = value
            TemplateID = value.ID
            NotifyPropertyChanged("JobTemplate")
        End Set
    End Property


    Private Property _requestType As RequestType
    Public Overridable Property RequestType As RequestType
        Get
            If IsLoading = False Then
                If RequestTypeID IsNot Nothing AndAlso RequestTypeID > 0 Then
                    _requestType = RequestType.Get(RequestTypeID)
                End If
            End If
            Return _requestType
        End Get
        Set(value As RequestType)
            _requestType = value
            RequestTypeID = value.ID
            NotifyPropertyChanged("RequestTypeID")
        End Set
    End Property

    'Public Overridable Property ScheduleTypess As API.ScheduleTypes
    '    Get
    '        If ScheduleID IsNot Nothing Then
    '            Return CType(ScheduleID, API.ScheduleTypes)
    '        End If
    '    End Get
    '    Set(value As API.ScheduleTypes)
    '        ScheduleID = value
    '    End Set
    'End Property

    Public Property ScheduleTypes As ScheduleTypes
        Get
            If ScheduleID Is Nothing Then
                ScheduleID = ScheduleTypes.None
            End If
            Return ScheduleID
        End Get
        Set(value As ScheduleTypes)
            ScheduleID = value
        End Set

    End Property

    Public Property ScheduleFrequencyType As ScheduleFrequencyType
        Get
            If TypeID Is Nothing Then
                TypeID = ScheduleFrequencyType.Day
            End If
            Return TypeID
        End Get
        Set(value As ScheduleFrequencyType)
            TypeID = value
        End Set

    End Property


    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", MyBase.Code, MyBase.Description)
    End Function

End Class
