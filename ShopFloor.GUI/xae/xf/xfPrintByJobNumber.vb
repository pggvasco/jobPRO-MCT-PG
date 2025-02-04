Imports UniSource.ReportManager.ReportPreviewNode
Imports UniSource.Shopfloor.Reports

Public Class xfPrintByJobNumber

    Private Sub xfPrintByJobNumber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindJobNumbers()
    End Sub

    Public Sub BindJobNumbers()
        Try
            Dim bll As New UniSource.Helper.GUI.LookupBackgroundLoader(Of API.Job)(luJobCard, AddressOf GetJobCards, True)
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError(ex.Message, ex)
        End Try
    End Sub

    Private Function GetJobCards() As IList(Of API.Job)
        Setup.EvolutionHelper.ActivateEvolution()
        Return API.Job.FindAll
    End Function

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click
        'Dim lay As New UniSource.ReportManager.xfReportRunner(New UniSource.ShopFloor.Scheduler.Reports.xrJobCard, luJobCard.EditValue)
        Try
            'lay.ShowReportPreviewDialogUsingDefaultLayout()
        Catch ex As Exception
            Setup.Log.logError("Error running report.", ex)
        End Try
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

End Class

