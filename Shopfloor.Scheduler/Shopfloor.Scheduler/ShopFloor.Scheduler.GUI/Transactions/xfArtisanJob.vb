Public Class xfArtisanJob
    Inherits xaegArtisanJob

    Private Sub xaeArtisanJob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim form As New xfActivityControls

        form.ShowDialog()
    End Sub
End Class

Public Class xaegArtisanJob
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Job)
End Class