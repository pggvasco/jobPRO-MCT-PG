Public Class xlCommonLetter
    Inherits xlgCommonLetter
End Class

Public Class xlgCommonLetter
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.CommonLetter)

    Public Sub New()
        MyBase.New(GetType(xaeCommonLetter))
    End Sub

End Class