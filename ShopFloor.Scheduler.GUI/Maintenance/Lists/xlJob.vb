Public Class xlJob
    Inherits xlgJob
End Class

Public Class xlgJob
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Job)

    Public Sub New()
        MyBase.New(GetType(xaeJob))
    End Sub

End Class