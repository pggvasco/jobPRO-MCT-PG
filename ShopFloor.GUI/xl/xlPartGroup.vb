Public Class xlPartGroup
    Inherits xlgPartGroup
End Class

Public Class xlgPartGroup
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.PartGroup)

    Public Sub New()
        MyBase.New(xaePartGroup)
    End Sub

End Class