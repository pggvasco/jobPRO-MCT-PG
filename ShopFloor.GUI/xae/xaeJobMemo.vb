Imports UniSource.Helper.ActiveRecord
Imports Castle.ActiveRecord

Public Class xaeJobMemo
    Inherits xaegJobMemo

    Private Sub xaeJobMemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Dim js As API.JobStage = API.JobStage.Get(jts.JobStage.ID)
            jsList.Add(js)
        Next
        Return jsList
        ' Return API.JobStage.FindAll()
    End Function

    Private Sub bbiSpellCheck_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSpellCheck.ItemClick
        Try
            SpellChecker1.Check(MemoRichEditControl)
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

    Private Sub bbiImportCommonLetter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImportCommonLetter.ItemClick
        ImportCommonLetter()
    End Sub

    Protected Sub ImportCommonLetter()
        Dim jm As API.CommonLetter
        Using New Castle.ActiveRecord.ConversationalScope(Conversation)
            Dim ql As Helper.ActiveRecord.xfQuickLookup(Of API.CommonLetter)
            ql = New Helper.ActiveRecord.xfQuickLookup(Of API.CommonLetter)(API.CommonLetter.FindAll, "Code", "Description")
            ql.ShowDialog()
            jm = ql.EditValue
        End Using
        If jm IsNot Nothing Then
            MemoRichEditControl.RtfText = jm.Contents
        End If
    End Sub

    Private Sub MemoRichEditControl_ContentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoRichEditControl.ContentChanged
        If JobStageLookUpEdit.Enabled = False Then
            MemoRichEditControl.Undo()
            MemoRichEditControl.Undo()
        End If
    End Sub

    Private Sub JobStageBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles JobStageBindingSource.CurrentChanged

    End Sub
End Class

Public Class xaegJobMemo
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.JobMemo)
End Class