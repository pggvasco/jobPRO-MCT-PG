Imports Castle.ActiveRecord
Imports System.Reflection
Imports System.Windows.Forms
Imports NHibernate.Criterion
Imports NHibernate.Criterion.Expression
Imports UniSource.Settings
Imports UniSource
Imports UniSource.Menu
Imports UniSource.Helper.GUI.My.Resources

Public Class xfTestReports
    Dim session As SessionScope
    Public Overridable Property Job As UniSource.ShopFloor.API.Job

    Private Sub bbiJobList_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiJobList.ItemClick
        Dim report As New xrJobList
        Try
            If JobBindingSource IsNot Nothing Then
                report.JobListBindingSource1.DataSource = JobBindingSource.Current
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error job doesn't exist.")
        End Try

        Try
            'If report.JobListBindingSource1 IsNot Nothing AndAlso report.HeaderBindingSource IsNot Nothing Then
            If report.JobListBindingSource1 IsNot Nothing Then
                report.ShowPreview()
            End If
        Catch ex As Exception
            MsgBox("Error running report.")
        End Try
    End Sub

    Private Sub bbiJobQuote_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiJobQuote.ItemClick
        Dim report As New xrJobCard
        Try
            If JobBindingSource IsNot Nothing Then
                report.BindingSource1.DataSource = JobBindingSource.Current
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error bindingsource has no values.")
        End Try

        Try
            'If report.JobQuoteBindingSource IsNot Nothing AndAlso report.HeaderBindingSource IsNot Nothing Then
            If report.BindingSource1 IsNot Nothing Then
                report.ShowPreview()
            End If
        Catch ex As Exception
            MsgBox("Error running report.")
        End Try
    End Sub

    Private Sub xfTestReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim config As Framework.Config.InPlaceConfigurationSource
            With My.Settings
                config = Framework.Config.InPlaceConfigurationSource.BuildForMSSqlServer(.Server, .Database, .Username, .Password)
            End With

            Dim asm As Assembly = Assembly.GetCallingAssembly
            Dim api As Assembly = GetType(UniSource.ShopFloor.API.awShopFloorHelper).Assembly
            Dim rep As Assembly = GetType(UniSource.ReportManager.awReportRepositoryHelper).Assembly

            ActiveRecordStarter.Initialize(asm, config)
            ActiveRecordStarter.RegisterAssemblies(api)
            ActiveRecordStarter.RegisterAssemblies(rep)

            session = New SessionScope(FlushAction.Never)

        Catch ex As Exception
            UniSource.Logging.Log.Log.logWarn(ex.Message)
        End Try

        Dim jobs As IEnumerable(Of UniSource.ShopFloor.API.Job)
        Try
            jobs = New List(Of UniSource.ShopFloor.API.Job)

        Catch ex As Exception

        End Try
        Try
            'Dim JobList() As API.Job = API.Job.FindAllByProperty("JobNo = '{0}'", "S1-101100396")
            JobBindingSource.DataSource = Pastel.Evolution.JobCard.List("1=1")
        Catch ex As Exception
            MsgBox("Error job not found.")
        End Try
    End Sub

    Private Sub bbiJobDeliveryNode_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiJobDeliveryNode.ItemClick
        Dim report As New xrJobDeliveryNote
        Try
            If JobBindingSource IsNot Nothing Then
                report.DeliveryNoteBindingSource.DataSource = JobBindingSource.Current
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error bindingsource has no values.")
        End Try

        Try
            If report.DeliveryNoteBindingSource IsNot Nothing Then
                report.ShowPreview()
            End If
        Catch ex As Exception
            MsgBox("Error running report.")
        End Try
    End Sub
End Class
