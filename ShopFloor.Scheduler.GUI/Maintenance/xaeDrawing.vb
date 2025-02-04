Imports System
Imports System.IO

Public Class xaeDrawing
    Inherits xaegDrawing

    Private Sub DrawingPathButtonEdit_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles DrawingPathButtonEdit.ButtonClick
        Try
            Dim ofd As New OpenFileDialog
            ofd.AddExtension = True
            ofd.CheckPathExists = True
            ofd.Filter = "Drawing PDF|*.pdf"
            ofd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not String.IsNullOrEmpty(ofd.FileName) Then
                    Process.Start(ofd.FileName)
                End If
            End If
        Catch ex As Exception
            UniSource.Logging.Log.Log.logWarn("Selected path does not exist.")
        End Try

    End Sub

End Class

Public Class xaegDrawing
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Drawing)
End Class