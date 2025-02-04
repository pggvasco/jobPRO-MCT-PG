Imports DevExpress.XtraReports.UI
'Imports UniSource.ShopFloor.API
Namespace Functions
    Public Class MCTRequisition
        Inherits JobFunction
        'Public Property DataTable As New DataTable
        'Public Property JobsMCT As IList(Of API.Job)
        'Public Property JobLinesMCT As IList(Of API.JobLine)

        Public Overrides Property RequiresInstance As Boolean = False
        Public Overrides Property RequiresJobs As Boolean = False


        Protected Overrides Sub Action()

            Dim Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                Dim jobStageCritReq = NHibernate.Criterion.DetachedCriteria.For(Of API.JobStage)()
                jobStageCritReq.Add(NHibernate.Criterion.Expression.Eq("IsProcurement", CBool(True)))
                Dim jobStage As API.JobStage = API.JobStage.FindAll(jobStageCritReq).FirstOrDefault()
                Dim xrRMCT As New ShopFloor.Report.xrMCTRequisition

                Dim jobCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
                jobCrit.Add(NHibernate.Criterion.Expression.Eq("JobStage", jobStage))

                xrRMCT.BindingSource1.DataSource = API.Job.FindAll(jobCrit).SelectMany(Function(x) x.JobLines)
                ' xrRMCT.ShowPreview()
                xrRMCT.ShowPreviewDialog()
            End Using
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Requisition"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Print the Requisition report."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.MCTRequisition
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.report
            End Get
        End Property
    End Class
End Namespace
