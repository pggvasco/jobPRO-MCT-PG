Public Class xlJobType
    Inherits xlgJobType
End Class

Public Class xlgJobType
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.JobType)

    Public Sub New()
        MyBase.New(xaeJobType)
    End Sub

End Class
