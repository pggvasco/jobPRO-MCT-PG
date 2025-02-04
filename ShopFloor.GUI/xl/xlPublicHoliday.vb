Public Class xlPublicHoliday 
    Inherits xlgPublicHoliday
    Public Overrides Sub PreLayout()
        '    MyBase.bbiAdd.Enabled = False
        '    Me.AllowDelete = False
        '    MyBase.PreLayout()
    End Sub
End Class
Public Class xlgPublicHoliday
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.PublicHoliday)

    Public Sub New()
        MyBase.New(xaePublicHoliday)
    End Sub

End Class