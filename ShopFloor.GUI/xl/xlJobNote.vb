Public Class xlJobNote
    Inherits xlgJobNote


End Class

Public Class xlgJobNote
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.Note)

    Public Sub New()
        MyBase.New(GetType(xaeJobNote))
    End Sub

End Class