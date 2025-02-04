Public Class xlJobFunctionControl
    Inherits xlgJobFunctionControl
End Class

Public Class xlgJobFunctionControl
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.JobFunctionControl)

    Public Sub New()
        MyBase.New(xaeJobFunctionControl)
    End Sub

End Class
