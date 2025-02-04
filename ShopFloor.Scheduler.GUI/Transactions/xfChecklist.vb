Imports DevExpress.XtraLayout

Public Class xfChecklist

    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Property CLU As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Property Checklist As Checklist.API.Checklist
    Public WithEvents ChecklistControl As Checklist.GUI.xucChecklist
    Public checkDone As Boolean = False

    Public Sub SetFullScreen()
        With Me
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
        End With
    End Sub

    Public Sub New(ByVal checklist As Checklist.API.Checklist)
        InitializeComponent()
        If checklist IsNot Nothing Then
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                ChecklistControl = New Checklist.GUI.xucChecklist(checklist)
            End Using
        End If
        ChecklistControl.Dock = DockStyle.Fill
        Controls.Add(ChecklistControl)
    End Sub

    Private Sub xfChecklist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFullScreen()
    End Sub

    Public Sub CLUhelper()
        CLU = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
    End Sub

    Private Sub Done() Handles ChecklistControl.DoneClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub xtcTabs_CloseButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
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