Public Class xfActivityControls

    
    Private Sub btPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPause.Click
        Dim form As New xfReasonSelect
        form.ShowDialog()
    End Sub

    Private Sub btComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btComplete.Click
        Dim form As New xfAssignNextOperation
        form.ShowDialog()
    End Sub
End Class