Public Class xlScheduleFrequency
    Inherits xlgScheduleFrequency

End Class
Public Class xlgScheduleFrequency
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.ScheduleFrequency)

    Public Sub New()
        MyBase.New(xaeScheduleFrequency)
    End Sub

End Class