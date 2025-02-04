Public Class xfJobLineAttachment

    Public Property CLH As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Property JobLineTime As API.JobLineTime
    'Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

    Public Sub New(ByVal LineTime As API.JobLineTime)
        InitializeComponent()

        Me.JobLineTime = LineTime
        bbiAdd.Glyph = UniSource.Helper.GUI.My.Resources.add
        bbiSaveClose.Glyph = UniSource.Helper.GUI.My.Resources.disk
        bbiSaveAttachment.Glyph = UniSource.Helper.GUI.My.Resources.report_disk
        bbiView.Glyph = UniSource.Helper.GUI.My.Resources.report_disk

        'Me.ReconciliationBatch = batch
        Me.BindingSource.DataSource = Me.JobLineTime.AttachmentCollection
    End Sub

    Private Sub AttachmentCollectionBindingSource_AddingNew(sender As System.Object, e As System.ComponentModel.AddingNewEventArgs) Handles BindingSource.AddingNew
        Dim att As New API.JobLineTimeAttachment With {.JobLineTime = Me.JobLineTime}
        Dim ofd As New OpenFileDialog
        ofd.Multiselect = True
        ofd.Title = "Select Files To Attach"

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each filepath As String In ofd.FileNames
                If String.IsNullOrEmpty(att.Name) Then
                    att.Name = IO.Path.GetFileName(filepath)
                    Try
                        Using file As IO.FileStream = IO.File.OpenRead(filepath)
                            att.Attachment = New Byte(file.Length) {}
                            Dim result = file.Read(att.Attachment, 0, file.Length)
                            e.NewObject = att
                            BindingSource.Add(att)
                        End Using
                    Catch ex As Exception
                        Setup.Log.logError(String.Format("Error reading file '{0}'.", filepath))
                    End Try
                Else
                    Dim att2 As New API.JobLineTimeAttachment With {.JobLineTime = Me.JobLineTime}
                    att2.Name = IO.Path.GetFileName(filepath)
                    Try
                        Using file As IO.FileStream = IO.File.OpenRead(filepath)
                            att2.Attachment = New Byte(file.Length) {}
                            Dim result = file.Read(att2.Attachment, 0, file.Length)
                            BindingSource.Add(att2)
                        End Using
                    Catch ex As Exception
                        Setup.Log.logError(String.Format("Error reading file '{0}'.", filepath))
                    End Try
                End If
            Next
        Else
            BindingSource.CancelEdit()
        End If

    End Sub

    Private Sub lvcAttachment_DoubleClick(sender As System.Object, e As System.EventArgs)
        SaveAttachment()
    End Sub

    Private Sub bbiSaveAttachment_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSaveAttachment.ItemClick
        SaveAttachment()
    End Sub

    Private Sub SaveAttachment()
        Dim att As API.JobLineTimeAttachment = TryCast(lvAttachments.GetFocusedRow, API.JobLineTimeAttachment)
        If att IsNot Nothing AndAlso Not String.IsNullOrEmpty(att.Name) AndAlso Not att.Attachment Is Nothing Then
            Dim sfd As New SaveFileDialog
            sfd.Title = "Save Attachment"
            sfd.FileName = att.Name
            Try
                If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using file As IO.FileStream = IO.File.Create(sfd.FileName)
                        file.Write(att.Attachment, 0, att.Attachment.Length)
                    End Using
                    If UniSource.Helper.GUI.Dialog.YesNoDialog("Would you like to open the saved attachment now?", "Open Saved Attachment?") = Windows.Forms.DialogResult.Yes Then
                        Try
                            Process.Start(sfd.FileName)
                        Catch ex As Exception
                            Setup.Log.logError(String.Format("Error opening file '{0}'.", sfd.FileName))
                        End Try
                    End If
                End If
            Catch ex As Exception
                Setup.Log.logError(String.Format("Error saving file '{0}'.", att.Name))
            End Try
        End If
    End Sub

    Private Sub bbiAdd_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd.ItemClick
        BindingSource.AddNew()
            'Me.BindingSource.DataSource = Me.ReconciliationBatch.AttachmentCollection
    End Sub

    Private Sub bbiSaveClose_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSaveClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbiView_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiView.ItemClick
        SaveAttachment()
    End Sub

    Private Sub xfJobLineAttachment_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CLH = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
            CLH.Components.Add(lvAttachments)
        Catch ex As Exception
            UniSource.Setup.Log.logError("Error setting Component Layout Helper.", ex)
        End Try
    End Sub

End Class