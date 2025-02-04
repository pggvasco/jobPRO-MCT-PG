Imports UniSource.Helper.ActiveRecord
Imports Castle.ActiveRecord

Public Class xaeJobNote
    Inherits xaegJobNote

    Private Sub xaeJobNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            Try
                Dim jbl As New Helper.GUI.LookupBackgroundLoader(Of API.Job)(JobLookUpEdit, AddressOf LoadJob)
            Catch ex As Exception
                Setup.Log.logError("Error setting loader for Job.", ex)
            End Try
        End Using

        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            Try
                Dim jsbl As New Helper.GUI.LookupBackgroundLoader(Of API.JobStage)(JobStageLookUpEdit, AddressOf LoadJobStage)
            Catch ex As Exception
                Setup.Log.logError("Error setting loader for Job Stage.", ex)
            End Try
        End Using
    End Sub

    Private Function LoadJob() As IEnumerable(Of API.Job)
        Return API.Job.FindAllByProperty("ID", Me.Record.Job.ID)
    End Function
    Private Function LoadJobStage() As IEnumerable(Of API.JobStage)
        Dim jsCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobTypeStage)()
        jsCrit.Add((NHibernate.Criterion.Expression.Eq("JobType", Me.Record.Job.JobType)))
        Dim jtsList As API.JobTypeStage() = API.JobTypeStage.FindAll(jsCrit)
        Dim jsList As New List(Of API.JobStage)
        For Each jts As API.JobTypeStage In jtsList
            jsList.Add(jts.JobStage)
        Next
        Return jsList
        ' Return API.JobStage.FindAll()
    End Function

    Private Sub bbiSpellCheck_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSpellCheck.ItemClick
        Try
            SpellChecker1.Check(NoteRichEditControl)
        Catch ex As Exception
            Setup.Log.logError("Error checking spelling.", ex)
        End Try
    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "Job" Then
                JobLookUpEdit.ErrorText = errors(prop)(0)
            ElseIf prop.Name = "JobStage" Then
                JobStageLookUpEdit.ErrorText = errors(prop)(0)
            Else
            End If
        Next
    End Sub

    Protected Overrides Sub SaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btSave.Click
        Try
            If Me.Record.CreateUserID Is Nothing OrElse Me.Record.CreateUserID < 0 Then
                Me.Record.CreateUserID = API.Context.Agent.ID()
            ElseIf Me.Record.EditUserID Is Nothing OrElse Me.Record.EditUserID < 0 Then
                Me.Record.EditUserID = API.Context.Agent.ID()
                Me.Record.EditUserDate = Now
            End If
            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            SaveRecord()
            'End Using
        Catch ex As Exception
            Logging.Log.Log.logError("Error saving record.", ex)
        End Try
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub NoteRichEditControl_ContentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoteRichEditControl.ContentChanged
        If JobStageLookUpEdit.Enabled = False Then
            NoteRichEditControl.Undo()
            NoteRichEditControl.Undo()
        End If
    End Sub
End Class

Public Class xaegJobNote
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Note)
End Class