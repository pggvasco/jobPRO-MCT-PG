Imports System
Imports System.IO

Public Class xaeDrawing
    Inherits xaegDrawing

    Public Function getFilePath() As String
        Dim ofd As New OpenFileDialog
        Dim path As String = ""

        ofd.AddExtension = True
        ofd.CheckFileExists = True
        ofd.Filter = "Drawings|*.pdf"
        ofd.Title = "Select Drawing"

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not String.IsNullOrEmpty(ofd.FileName) Then
                path = ofd.FileName
                Record.Description = IO.Path.GetFileNameWithoutExtension(ofd.FileName)
            End If
        End If
        Return path
    End Function

    Private Sub DrawingPathButtonEdit_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles DrawingPathButtonEdit.ButtonClick
        Try
            DrawingPathButtonEdit.Text = getFilePath()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error selecting drawing.", ex)
        End Try
    End Sub

    Private Sub btView_Click(sender As System.Object, e As System.EventArgs) Handles btView.Click
        If Not String.IsNullOrEmpty(Me.Record.DrawingPath) Then
            If File.Exists(Me.Record.DrawingPath) Then
                Try
                    Process.Start(Me.Record.DrawingPath)
                Catch ex As Exception
                    Setup.Log.logError("Error opening drawing for viewing.", ex)
                End Try
            Else
                Setup.Log.logWarn("No drawing path has been set.")
            End If
        End If
    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "Code" Then
                CodeTextEdit.ErrorText = errors(prop)(0)
            ElseIf prop.Name = "Description" Then
                DescriptionTextEdit.ErrorText = errors(prop)(0)
            ElseIf prop.Name = "DrawingPath" Then
                DrawingPathButtonEdit.ErrorText = errors(prop)(0)
            Else
            End If
        Next
    End Sub

End Class

Public Class xaegDrawing
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Drawing)
End Class