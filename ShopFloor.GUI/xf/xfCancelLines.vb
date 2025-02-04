Public Class xfCancelLines 

    Public Property JobLineList As List(Of API.JobLine) = New List(Of API.JobLine)
    Public Property JobLineProcessedList As List(Of API.JobLine) = New List(Of API.JobLine)

    Private Sub btCancel_Click(sender As System.Object, e As System.EventArgs) Handles btCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btOK_Click(sender As System.Object, e As System.EventArgs) Handles btOK.Click
        If JobLineList.Count > 0 Then

            If CancelledReasonTextEdit.EditValue Is Nothing Then
                UniSource.Helper.GUI.Dialog.OKDialog("Please enter reason")
                CancelledReasonTextEdit.Focus()
            ElseIf CancelledReasonTextEdit.EditValue.ToString().Length < API.Context.Defaults.JobLineCancelledReasonMinLenght Then
                UniSource.Helper.GUI.Dialog.OKDialog("Reason must be " + API.Context.Defaults.JobLineCancelledReasonMinLenght.ToString() + " characters or longer, currently only " + CancelledReasonTextEdit.EditValue.ToString().Length.ToString())
                CancelledReasonTextEdit.Focus()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
                For Each jobLine As API.JobLine In JobLineList
                    jobLine.IsCancelled = True
                    jobLine.CancelledUser = API.Context.Agent.DisplayName
                    jobLine.CancelledDateTime = Date.Now
                    jobLine.CancelledReason = CancelledReasonTextEdit.EditValue.ToString
                Next
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub xfCancelLines_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(_jobLineList As List(Of API.JobLine), _jobLineProcessedList As List(Of API.JobLine))

        InitializeComponent()
        JobLineList = _jobLineList
        JobLineBindingSource.DataSource = JobLineList

        JobLineProcessedList = _jobLineProcessedList
        JobLineProcessedBindingSource.DataSource = JobLineProcessedList

    End Sub
End Class