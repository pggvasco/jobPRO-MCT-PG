Imports DevExpress.XtraReports.UI
Imports Castle.ActiveRecord

Namespace Functions

    Public Class TestBench
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each job As API.Job In Jobs

                'Loads AW for first time use
                Try
                    If Not Castle.ActiveRecord.ActiveRecordStarter.GetRegisteredTypes.Contains(GetType(API.awDOSCOTestBenchHelper)) Then
                        Castle.ActiveRecord.ActiveRecordStarter.RegisterAssemblies(GetType(API.awDOSCOTestBenchHelper).Assembly)
                        ActiveRecordMediator(Of ActiveRecordBase).GetSessionFactoryHolder().RegisterSessionFactory(ActiveRecordMediator(Of ActiveRecordBase).GetSessionFactoryHolder().GetConfiguration(GetType(ActiveRecordBase)).BuildSessionFactory(), GetType(ActiveRecordBase))
                    End If
                Catch ex As Exception
                End Try
                Dim RCCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.RESULT_CHART)()
                RCCrit.Add(NHibernate.Criterion.Expression.Sql(String.Format("Rtrim(Ltrim(JOB_NO)) like '%{0}%'", job.JobNumber)))
                'RCCrit.Add(NHibernate.Criterion.Expression.Eq("RESULT_CHARTBaseCompositeKey.JOB_NO", job.JobNumber))
                Dim ql As Helper.ActiveRecord.xfQuickLookup(Of UniSource.ShopFloor.API.RESULT_CHART)
               
                ql = New Helper.ActiveRecord.xfQuickLookup(Of UniSource.ShopFloor.API.RESULT_CHART)(UniSource.ShopFloor.API.RESULT_CHART.FindAll(RCCrit), "RESULT_CHARTBaseCompositeKey", "RESULT_CHARTBaseCompositeKey")
                ql.Text = "Select Result Chart"
                ql.ShowDialog()
                If IIf(IsDBNull(ql.EditValue), Nothing, ql.EditValue) IsNot Nothing Then
                    Dim xrTB As New ShopFloor.Report.xrJobTestResults
                    xrTB.ResultsBindingSource.DataSource = ql.EditValue
                    xrTB.JobBindingSource.DataSource = job
                    xrTB.ShowPreviewDialog()
                End If
            Next
        End Sub
        Public Overrides ReadOnly Property Code As String
            Get
                Return "Test Bench Report"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Test Bench Report."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.TestBench
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.chart_curve
            End Get
        End Property

    End Class
End Namespace

