Imports UniSource
Imports DevExpress.XtraReports.UI

Public Class xfSupplierDeliveryNoteReprint

    Public Property Job As API.Job
        Get
            Return JobBindingSource.Current
        End Get
        Set(ByVal value As API.Job)
            JobBindingSource.Clear()
            If value IsNot Nothing Then
                If value.ID > 0 Then
                    'Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    value = API.Job.Find(value.ID)
                    'End Using
                End If
                JobBindingSource.Add(value)
            End If
        End Set
    End Property

    Private Sub Reprint()
        If SupplierDeliveryNoteLookUpEdit.EditValue Is Nothing Then
            Dim gpMessage As String = String.Format("Reprint Delivery Note." + vbCrLf + "Select a delivery note to reprint")
            If UniSource.Helper.GUI.Dialog.OKDialog(gpMessage) = Windows.Forms.DialogResult.OK Then
                Exit Sub
            End If
        End If

        Dim rp As UniSource.ShopFloor.Report.xrDoscoJobSupplierDeliveryNote = New UniSource.ShopFloor.Report.xrDoscoJobSupplierDeliveryNote


        rp.JobSupplierDelivery.DataSource = SupplierDeliveryNoteLookUpEdit.EditValue

        rp.ShowPreview()

    End Sub


    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Reprint()
    End Sub
    Private Sub GroupControl1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint
    End Sub

    Private Sub xfSupplierDeliveryNoteReprint_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' JobSupplierDeliveryNoteBindingSource.DataSource = Job.JobSupplierDeliveryNoteCollection

    End Sub

End Class