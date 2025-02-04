Public Class xlWorkCenter2
    Inherits xlgWorkCenter2

End Class


Public Class xlgWorkCenter2
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.WorkCentre)

    Public Sub New()
        MyBase.New(GetType(xaeWorkCentre2))
    End Sub

End Class

