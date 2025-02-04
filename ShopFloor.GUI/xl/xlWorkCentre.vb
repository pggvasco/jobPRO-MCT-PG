Public Class xlWorkCentre
    Inherits xlgWorkCentre
End Class

Public Class xlgWorkCentre
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.WorkCentre)

    Public Sub New()
        MyBase.New(xaeWorkCentre)
    End Sub

End Class
