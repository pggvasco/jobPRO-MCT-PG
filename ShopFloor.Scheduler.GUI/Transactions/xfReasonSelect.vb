Imports DevExpress.XtraLayout

Public Class xfReasonSelect

    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Property CLU As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Overridable Property Reason As API.ReasonCode

    Public Sub SetFullScreen()
        With Me
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
        End With
    End Sub

    Private Sub xfReason_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CLU = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)

        SetFullScreen()

        Dim reasons As IEnumerable(Of API.ReasonCode)
        Try
            Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.ReasonCode)()
            crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("IsQIR", False), NHibernate.Criterion.Expression.IsNull("IsQIR")))
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                reasons = API.ReasonCode.FindAll(crit)
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Reasons.", ex)
        End Try

        If reasons IsNot Nothing Then
            For Each reason As API.ReasonCode In reasons
                Dim reasonButton As New DevExpress.XtraEditors.SimpleButton
                reasonButton.Text = reason.Description
                UniSource.Helper.DoubleSize(reasonButton, 1, 1, 1, 1)
                reasonButton.MinimumSize = reasonButton.Size

                reasonButton.Tag = reason

                Dim lci As New LayoutControlItem(lcReason, reasonButton)
                lci.TextVisible = False

                AddHandler reasonButton.Click, AddressOf ReasonClicked
            Next
        End If

    End Sub

    Public Sub ReasonClicked(ByVal sender As Object, ByVal e As EventArgs)
        Me.Reason = CType(sender, DevExpress.XtraEditors.SimpleButton).Tag
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bbiCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bbiManage_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiManage.ItemClick
        Try
            Setup.ManageJobs()
        Catch ex As Exception
            Setup.Log.logError("Error loading management screens.", ex)
        End Try
    End Sub

End Class
