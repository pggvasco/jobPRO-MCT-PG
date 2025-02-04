Public Class xlJobMemo
    Inherits xlgJobMemo
End Class

Public Class xlgJobMemo
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.JobMemo)

    Public Sub New()
        MyBase.New(GetType(xaeJobMemo))
    End Sub

End Class
