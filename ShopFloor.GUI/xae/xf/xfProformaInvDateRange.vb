Public Class xfProformaInvDateRange

    Dim dateFrom As Date
    Dim dateTo As Date


    Private Sub DateEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles ToDateEdit.EditValueChanged
        '        dateTo = CDate(ToDateEdit.Text)

    End Sub

    Private Sub LabelControl1_Click(sender As System.Object, e As System.EventArgs) Handles ToLabelControl.Click

    End Sub

    Private Sub xfProformaInvDateRange_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim nowDate As Date
        nowDate = Date.Now()

        FromDateEdit.Text = nowDate.ToString("dd MMM yyyy")
        ToDateEdit.Text = nowDate.ToString("dd MMM yyyy")
    End Sub

    Private Sub FromDateEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles FromDateEdit.EditValueChanged
        '        dateFrom = CDate(FromDateEdit.Text)
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click

    End Sub
End Class