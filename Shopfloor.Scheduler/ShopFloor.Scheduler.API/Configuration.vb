Public Class Configuration

    ''' <summary>
    ''' Gets the configuration.
    ''' </summary><returns></returns>
    Shared Function GetConfiguration() As Configuration
        Dim config As Configuration = API.Configuration.FindFirst
        If config Is Nothing Then
            config = New API.Configuration
        End If
        Return config
    End Function


    Public Property LogOffIntervalType As IntervalTypes
        Get
            If LogOffIntervalTypeID Is Nothing Then
                LogOffIntervalType = IntervalTypes.Seconds
                Return 0
            End If
            Return CType(LogOffIntervalTypeID, IntervalTypes)
        End Get
        Set(value As IntervalTypes)
            LogOffIntervalTypeID = value
        End Set
    End Property
    Public Overrides Property LogOffInterval As Integer?
        Get
            If MyBase.LogOffInterval Is Nothing Then
                Return 3000
            End If
            Return MyBase.LogOffInterval
        End Get
        Set(value As Integer?)
            MyBase.LogOffInterval = value
        End Set
    End Property

    Public Function GetInterval(Interval As Integer, IntervalType As API.IntervalTypes) As Integer
        Dim loginterval As Integer
        Select Case IntervalType
            Case API.IntervalTypes.Seconds
                loginterval = 1000 * Interval
            Case API.IntervalTypes.Minute
                loginterval = 60000 * Interval
            Case API.IntervalTypes.Hours
                loginterval = 3600000 * Interval
            Case Else
                loginterval = 86400000 * Interval
        End Select
        Return loginterval
    End Function

    Public Overrides Property TimerInterval As Integer?
        Get
            If MyBase.TimerInterval Is Nothing Then
                Return 86400000
            End If
            Return MyBase.TimerInterval
        End Get
        Set(value As Integer?)
            MyBase.TimerInterval = value
        End Set
    End Property



End Class
