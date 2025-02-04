Public Class xlJobAudit
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

    Public Property Job As API.Job

    Public Sub New(ByVal job As API.Job)
        InitializeComponent()
        Me.Job = job
    End Sub

    Private Sub xlJobAudit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                Dim jobAuditCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Audit)()
                jobAuditCrit.Add(NHibernate.Criterion.Expression.Eq("idJob", CInt(Job.ID)))
                AuditBindingSource.DataSource = API.Audit.FindAll(jobAuditCrit)
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Job Audits.", ex)
            Me.Conversation.Restart()
        End Try
    End Sub
End Class
