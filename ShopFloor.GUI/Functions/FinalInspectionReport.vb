Imports DevExpress.XtraReports.UI
Namespace Functions

    Public Class FinalInspectionReport
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each job As API.Job In Jobs

                Dim ql As Helper.ActiveRecord.xfQuickLookup(Of UniSource.Checklist.API.ChecklistLog)
                ql = New Helper.ActiveRecord.xfQuickLookup(Of Checklist.API.ChecklistLog)(Checklist.API.ChecklistLog.FindAllByProperty("RecordID", job.ID), "ChecklistDescription", "Checklist", "AgentName", "EndDateTime")
                ql.Text = "Select Checklist"
                ql.ShowDialog()
                If IIf(IsDBNull(ql.EditValue), Nothing, ql.EditValue) IsNot Nothing Then
                    Dim xrPR As New ShopFloor.Report.xrFinalInspectionReport
                    xrPR.ChecklistBindingSource.DataSource = ql.EditValue.ChecklistOptionLogs
                    xrPR.JobBindingSource.DataSource = job
                    xrPR.ShowPreviewDialog()
                End If
            Next
        End Sub
        Public Overrides ReadOnly Property Code As String
            Get
                Return "Checklist Report"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Checklist Report."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.FinalInspectionReport
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.user_suit
            End Get
        End Property

    End Class
End Namespace
