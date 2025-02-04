Imports UniSource.Helper.ActiveRecord
Imports Castle.ActiveRecord

Public Class xucJobActivities

    Public Property CLH As New UniSource.Helper.GUI.ComponentLayoutHelper
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

    Public Property Job As API.Job
        Get
            If JobBindingSource.Current IsNot Nothing Then
                Return CType(JobBindingSource.Current, API.Job)
            End If
            Return Nothing
        End Get
        Protected Set(value As API.Job)
            JobBindingSource.Clear()
            If value IsNot Nothing Then
                If CInt(DirectCast(value, IIdentifier).ID) > 0 Then
                    Try
                        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                            JobBindingSource.Add(API.Job.Find(DirectCast(value, IIdentifier).ID))
                        End Using
                    Catch ex As Exception
                        UniSource.Logging.Log.Log.logError(ex.Message, ex)
                    End Try
                Else
                    JobBindingSource.Add(value)
                End If
            End If
        End Set
    End Property

    Public Sub New(ByVal job As API.Job)
        InitializeComponent()
        Me.Job = job
    End Sub

    Private Sub xucJobActivities_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Try
            bbiSave.Glyph = UniSource.Helper.GUI.My.Resources.disk
            bbiCancel.Glyph = UniSource.Helper.GUI.My.Resources.cross
            bsiReports.Glyph = UniSource.Helper.GUI.My.Resources.report
            bbiExportGrid.Glyph = UniSource.Helper.GUI.My.Resources.table
            bbiCreateJobCard.Glyph = UniSource.Helper.GUI.My.Resources.book
            bbiProcessActuals.Glyph = UniSource.Helper.GUI.My.Resources.cog
        Catch ex As Exception

        End Try

        Try
            If Me.Job.JobCardID.HasValue Then
                bbiCreateJobCard.Enabled = False
            End If
        Catch ex As Exception

        End Try

        Try
            Dim bgl As New UniSource.Helper.GUI.LookupBackgroundLoader(Of API.Operation, DevExpress.XtraEditors.LookUpEdit)(Me, OperationBindingSource, Function() API.Operation.FindAll, False)
        Catch ex As Exception
            Setup.Log.logError("Error fetching Operations.", ex)
        End Try

        Try
            Dim bgl As New UniSource.Helper.GUI.LookupBackgroundLoader(Of API.Artisan, DevExpress.XtraEditors.LookUpEdit)(Me, ArtisanBindingSource, Function() API.Artisan.FindAll, False)
        Catch ex As Exception
            Setup.Log.logError("Error fetching Artisans.", ex)
        End Try

        Try
            Dim bgl As New UniSource.Helper.GUI.LookupBackgroundLoader(Of API.Machine, DevExpress.XtraEditors.LookUpEdit)(Me, MachineBindingSource, Function() API.Machine.FindAll, False)
        Catch ex As Exception
            Setup.Log.logError("Error fetching Machines.", ex)
        End Try

        Try
            Dim bgl As New UniSource.Helper.GUI.LookupBackgroundLoader(Of API.Part, DevExpress.XtraEditors.LookUpEdit)(Me, PartBindingSource, Function() API.Part.FindAll, False)
        Catch ex As Exception
            Setup.Log.logError("Error fetching Parts.", ex)
        End Try

        Try
            SetCLH()
        Catch ex As Exception
            Setup.Log.logError("Error setting Component Layout Helper.", ex)
        End Try

        Try
            AddReports()
        Catch ex As Exception
            Setup.Log.logError("Error generating Report menus.", ex)
        End Try

    End Sub

    Public Sub SetCLH()
        CLH.AddSaveEvent(gvActivities, "Layout")
        CLH.Components.Add(gvActivities)
    End Sub

    Private Sub AddReports()
        Dim rep As ReportManager.Report = ReportManager.Report.GetByReport(New Reports.xrJobActivities)
        If rep IsNot Nothing Then
            bsiReports.AddItem(rep.GetReportPreviewMenu(BarManager1, Me.Job))
        End If
    End Sub

    Private Sub AddReportDesigners()
        Dim rep As ReportManager.Report = ReportManager.Report.GetByReport(New Reports.xrJobActivities)
        If rep IsNot Nothing Then
            bsiReports.AddItem(rep.GetReportDesignMenu(BarManager1, Me.Job))
        End If
    End Sub

    Private Sub bbiCancel_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancel.ItemClick
        RefreshJob()
    End Sub

    Private Sub RefreshJob()
        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                Job.Refresh()
            End Using
        Catch ex As Exception
            Me.Conversation.Restart()
            Setup.Log.logError("Error refreshing Job.", ex)
        End Try
    End Sub

    Private Sub bbiSave_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        SaveJob()
    End Sub

    Private Sub SaveJob()
        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                Job.Save()
            End Using
        Catch ex As Exception
            Me.Conversation.Restart()
            Setup.Log.logError("Error saving Job.", ex)
        End Try

        Try
            Me.Conversation.Flush()
            Me.Conversation.Dispose()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError(ex.Message, ex)
        End Try
    End Sub

    Private Sub bbiExportGrid_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportGrid.ItemClick
        Try
            UniSource.Helper.GUI.Grid.ExportGrid(gvActivities)
        Catch ex As Exception
            Setup.Log.logError("Error exporting Grid.", ex)
        End Try
    End Sub

    Private Sub bbiProcessActuals_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcessActuals.ItemClick
        Try
            Me.Job.ProcessActuals()
        Catch ex As Exception
            Setup.Log.logError("Error Processing Actuals.", ex)
        End Try
    End Sub

    Private Sub bbiCreateJobCard_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCreateJobCard.ItemClick
        Try
            Me.Job.CreateJobCard()
        Catch ex As Exception
            Setup.Log.logError("Error Creating Job Card.", ex)
        End Try
    End Sub

End Class
