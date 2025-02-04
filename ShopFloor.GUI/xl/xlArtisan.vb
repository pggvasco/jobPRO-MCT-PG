Public Class xlArtisan
    Inherits xlgArtisan

End Class

Public Class xlgArtisan
    Inherits Helper.ActiveRecord.xucgInheritableLookup(Of API.Artisan)

    Public Sub New()
        MyBase.New(GetType(xaeArtisan))
    End Sub

End Class