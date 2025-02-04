Imports UniSource.ShopFloor.Scheduler

Public Class xfJobChecklist

    Public Property Job As API.Job
    Public WithEvents ChecklistForm As Checklist.GUI.xucChecklist
    Public Property CLH As Helper.ActiveRecord.GUI.ComponentLayoutHelper

    Private Sub SetCLH()
        CLH = New Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
    End Sub

    Public Sub New(ByVal checklist As Checklist.API.Checklist, ByVal job As API.Job)
        InitializeComponent()
        ChecklistForm = New Checklist.GUI.xucChecklist(checklist)
        Me.Job = job
        ChecklistForm.Log.RecordID = job.ID
        ChecklistForm.Dock = DockStyle.Fill
        Me.Text = checklist.Description
        Me.Controls.Add(ChecklistForm)
    End Sub

    Private Sub xfJobChecklist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetCLH()
        Catch ex As Exception
            Setup.Log.logError("Error setting Component Layout Helper.", ex)
        End Try
    End Sub

    Private Sub ChecklistForm_DoneClick() Handles ChecklistForm.DoneClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class
