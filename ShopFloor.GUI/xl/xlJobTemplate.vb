Public Class xlJobTemplate
    Inherits xlgJobTemplate

    Private Sub gcJobTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcJobTemplate.Click

    End Sub
End Class

Public Class xlgJobTemplate
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.JobTemplate)

    Public Sub New()
        MyBase.New(xaeJobTemplate)
    End Sub
End Class