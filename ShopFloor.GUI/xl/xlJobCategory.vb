Public Class xlJobCategory
    Inherits xlgJobCategory
End Class

Public Class xlgJobCategory
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.JobCategory)

    Public Sub New()
        MyBase.New(xaeJobCategory)
    End Sub

End Class