Public Class xaeCommonLetter 
    Inherits xaegCommonLetter

    Protected Overrides Sub SetCLH()
        MyBase.SetCLH()
        bbiSpellCheck.Glyph = UniSource.Helper.GUI.My.Resources.spellcheck
        CLH.Components.Add(BarManager1, "CommonLettersBarManager")
        CLH.Components.Add(dlcCommonLetter)
    End Sub

    Private Sub bbiSpellCheck_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSpellCheck.ItemClick
        Try
            SpellChecker1.Check(ContentsRichEditControl)
        Catch ex As Exception
            Setup.Log.logError("Error checking spelling.", ex)
        End Try
    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "Code" Then
                CodeTextEdit.ErrorText = errors(prop)(0)
            ElseIf prop.Name = "Description" Then
                DescriptionTextEdit.ErrorText = errors(prop)(0)
            Else
            End If
        Next
    End Sub

End Class

Public Class xaegCommonLetter
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.CommonLetter)

    Public Sub New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

End Class