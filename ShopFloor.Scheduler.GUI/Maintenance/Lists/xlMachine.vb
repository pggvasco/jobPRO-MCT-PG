Public Class xlMachine
    Inherits xlgMachine
End Class

Public Class xlgMachine
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Machine)

    Public Sub New()
        MyBase.New(GetType(xaeMachine))
    End Sub

End Class