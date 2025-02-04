Public Class xfDoscoInspection 
    Public Job As API.Job

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If rdAcceptablePaintWork.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdAcceptablePaintWork.SelectedIndex = 0 Then
            Exit Sub
        End If

        If rdDirectionCorrect.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdDirectionCorrect.SelectedIndex = 0 Then
            Exit Sub
        End If

        If rdFlangeCleanednPolished.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdFlangeCleanednPolished.SelectedIndex = 0 Then
            Exit Sub
        End If

        If rdHaveFittingsbeenputwithUnit.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdHaveFittingsbeenputwithUnit.SelectedIndex = 0 Then
            Exit Sub
        End If

        If rdPortsPluggednTaped.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdPortsPluggednTaped.SelectedIndex = 0 Then
            Exit Sub
        End If

        If rdRustRemovedFromUnit.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdRustRemovedFromUnit.SelectedIndex = 0 Then
            Exit Sub
        End If

        If rdShaftSteelBrightened.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdShaftSteelBrightened.SelectedIndex = 0 Then
            Exit Sub
        End If

        If rdSplinesinGoodCondition.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdSplinesinGoodCondition.SelectedIndex = 0 Then
            Exit Sub
        End If

        If rdThreadsInGoodCondition.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdThreadsInGoodCondition.SelectedIndex = 0 Then
            Exit Sub
        End If

        If rdUnitWrappedInPlastic.SelectedIndex = -1 Then
            promptSelectOption()
            Exit Sub
        ElseIf rdUnitWrappedInPlastic.SelectedIndex = 0 Then
            Exit Sub
        End If
        MapJob()

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub promptSelectOption()
        MsgBox("You are required to select Yes/No option.", MsgBoxStyle.Exclamation, My.Application.Info.Title + " - Select option..")
    End Sub

    Private Sub MapJob()
        Dim inspec As New API.Inspection

        With inspec
            .Assessor = txtAssessor.Text
            .Authorizer = txtAdmin.Text
            .BAcceptablePaint = rdAcceptablePaintWork.Text
            .BDirectionCorrect = rdDirectionCorrect.Text
            .BFlangeCleanedPolished = rdFlangeCleanednPolished.Text
            .BHaveFittingsBeenPutWithUnit = rdHaveFittingsbeenputwithUnit.Text
            .BPortsPluggedTaped = rdPortsPluggednTaped.Text
            .BRustRemoved = rdRustRemovedFromUnit.Text
            .BShaftsSteelBrightened = rdShaftSteelBrightened.Text
            .BSplinesInGoodCondition = rdSplinesinGoodCondition.Text
            .BThreadsInGoodCondition = rdThreadsInGoodCondition.Text
            .BUnitWrappedinPlastic = rdUnitWrappedInPlastic.Text
            .Save()
        End With
    End Sub
End Class