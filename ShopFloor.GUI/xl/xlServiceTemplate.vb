Public Class xlServiceTemplate 
    Inherits xlgServiceTemplate
End Class


Public Class xlgServiceTemplate
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.ServiceTemplate)

    Public Sub New()
        MyBase.New(GetType(xaeServiceTemplate))
    End Sub

End Class