Public Class xucJobList
    Inherits xucgJobList

End Class

Public Class xucgJobList
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.Job)

    Public Sub New()
        MyBase.New(xaeJob)
    End Sub

End Class