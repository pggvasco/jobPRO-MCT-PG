Public Class xlEmployee 
    Inherits xlgEmployee
    
    Public Overrides Sub PreLayout()
        MyBase.bbiAdd.Enabled = False
        Me.AllowDelete = False
        MyBase.PreLayout()
    End Sub
End Class

Public Class xlgEmployee
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.Employee)

    Public Sub New()
        MyBase.New(xaeEmployee)
    End Sub

End Class