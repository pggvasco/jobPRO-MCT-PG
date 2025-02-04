Public Class xlJobStage
    Inherits xlgJobStage


End Class

Public Class xlgJobStage
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.JobStage)

    Public Sub New()
        MyBase.New(xaeJobStage)
    End Sub

End Class
