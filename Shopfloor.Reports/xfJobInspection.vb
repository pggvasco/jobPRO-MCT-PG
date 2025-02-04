Public Class xfSATJobInspection
    Public Job As API.Job
    'test
    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        xtcJobInspection.SelectedTabPageIndex = 1

        If RdPreviousJob.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf RdPreviousJob.SelectedIndex = 0 Then
            If txtPreviousJob.Text = "" Then
                promptSupplyDetails()
                txtPreviousJob.Focus()
                Exit Sub
            End If
        End If

        If RdComponentClean.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf RdComponentClean.SelectedIndex = 0 Then
            If txtComponentClean.Text = "" Then
                promptSupplyDetails()
                txtComponentClean.Focus()
                Exit Sub
            End If
        End If

        If RdPortsPlugged.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf RdPortsPlugged.SelectedIndex = 0 Then
            If txtPortsPlugged.Text = "" Then
                promptSupplyDetails()
                txtPortsPlugged.Focus()
                Exit Sub
            End If
        End If

        If RdValve.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf RdValve.SelectedIndex = 0 Then
            If txtValve.Text = "" Then
                promptSupplyDetails()
                txtValve.Focus()
                Exit Sub
            End If
        End If

        If RdFittings.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf RdFittings.SelectedIndex = 0 Then
            If txtFittings.Text = "" Then
                promptSupplyDetails()
                txtFittings.Focus()
                Exit Sub
            End If
        End If

        If RdFeederTube.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf RdFeederTube.SelectedIndex = 0 Then
            If txtFeederTube.Text = "" Then
                promptSupplyDetails()
                txtFeederTube.Focus()
                Exit Sub
            End If
        End If

        If RdPaint.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf RdPaint.SelectedIndex = 0 Then
            If txtPaint.Text = "" Then
                promptSupplyDetails()
                txtPaint.Focus()
                Exit Sub
            End If
        End If

        If RdPortOrientation.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf RdPortOrientation.SelectedIndex = 0 Then
            If txtPortOrientation.Text = "" Then
                promptSupplyDetails()
                txtPortOrientation.Focus()
                Exit Sub
            End If
        End If

        If rdNormaWearAndTear.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdNormaWearAndTear.SelectedIndex = 0 Then
            If txtNormaWearAndTear.Text = "" Then
                promptSupplyDetails()
                txtNormaWearAndTear.Focus()
                Exit Sub
            End If
        End If
        If rdgReasonForFailure.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdgReasonForFailure.SelectedIndex = 0 Then
            If txtNormaWearAndTear.Text = "" Then
                promptSupplyDetails()
                txtNormaWearAndTear.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub promptSelectOption()
        MsgBox("You are required to select Yes/No option.", MsgBoxStyle.Exclamation, My.Application.Info.Title + " - Select option..")
    End Sub

    Private Sub promptSupplyDetails()
        MsgBox("You are required to supply details here.", MsgBoxStyle.Exclamation, My.Application.Info.Title + " - Details required..")
    End Sub

    Private Sub MapJob()

    End Sub
End Class