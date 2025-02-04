Imports Unisource.Helper.ActiveRecord
Imports Castle.ActiveRecord
Imports Unisource.ShopFloor.Report


Public Class xucJobLines

    Public Property CLH As Unisource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

    Public Property Job As API.Job
        Get
            If JobBindingSource.Current IsNot Nothing Then
                Return CType(JobBindingSource.Current, API.Job)
            End If
            Return Nothing
        End Get
        Protected Set(ByVal value As API.Job)
            JobBindingSource.Clear()
            If value IsNot Nothing Then
                If CInt(DirectCast(value, IIdentifier).ID) > 0 Then
                    Try
                        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                            JobBindingSource.Add(API.Job.Find(DirectCast(value, IIdentifier).ID))
                        End Using
                    Catch ex As Exception
                        Unisource.Logging.Log.Log.logError(ex.Message, ex)
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

    Private Sub xucJobActivities_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            bbiSave.Glyph = Unisource.Helper.GUI.My.Resources.disk
            bbiCancel.Glyph = Unisource.Helper.GUI.My.Resources.cross
            bsiReports.Glyph = Unisource.Helper.GUI.My.Resources.report
            bbiExportGrid.Glyph = Unisource.Helper.GUI.My.Resources.table
            bbiAddLine.Glyph = Unisource.Helper.GUI.My.Resources.add
            bbiEditLine.Glyph = Unisource.Helper.GUI.My.Resources.pencil
        Catch ex As Exception

        End Try

        Try
            Dim wclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentre)(lkpWorkCentre, GetType(xaeWorkCentre), AddressOf LoadWorkCentres, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centres.", ex)
        End Try

        Try
            Dim sslm As New Helper.ActiveRecord.LookupMaintenance(Of API.SupplyScope)(rilkpSupplyScope, GetType(xaeSupplyScope), AddressOf LoadSupplyScopes, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Supply Scopes.", ex)
        End Try

        Try
            Dim plm As New Helper.ActiveRecord.LookupMaintenance(Of API.Part)(rilePart, GetType(xaePart), AddressOf LoadParts, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Parts.", ex)
        End Try

        Try
            Dim sbl As New Helper.GUI.LookupBackgroundLoader(Of Unisource.Helper.ActiveRecord.Evolution.Vendor)(rilkpSupplier, AddressOf LoadVendors)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Suppliers.", ex)
        End Try

        Try
            Dim stbl As New Helper.GUI.LookupBackgroundLoader(Of Unisource.Helper.ActiveRecord.Evolution.VendorClass)(rilkpSupplierType, AddressOf LoadVendorClasses)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Supplier Types.", ex)
        End Try

        Try
            Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of Unisource.Helper.ActiveRecord.Evolution.StockItem)(rilkpInventoryItem, AddressOf LoadStockItems)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
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

    Private Function LoadWorkCentres() As IEnumerable(Of API.WorkCentre)
        Return API.WorkCentre.FindAll
    End Function

    Private Function LoadParts() As IEnumerable(Of API.Part)
        Return API.Part.FindAll
    End Function

    Private Function LoadSupplyScopes() As IEnumerable(Of API.SupplyScope)
        Return API.SupplyScope.FindAll
    End Function

    Private Function LoadVendors() As IEnumerable(Of Unisource.Helper.ActiveRecord.Evolution.Vendor)
        Return Unisource.Helper.ActiveRecord.Evolution.Vendor.FindAll
    End Function

    Private Function LoadVendorClasses() As IEnumerable(Of Unisource.Helper.ActiveRecord.Evolution.VendorClass)
        Return Unisource.Helper.ActiveRecord.Evolution.VendorClass.FindAll
    End Function

    Private Function LoadStockItems() As IEnumerable(Of Unisource.Helper.ActiveRecord.Evolution.StockItem)
        Return Unisource.Helper.ActiveRecord.Evolution.StockItem.FindAll
    End Function

    Public Sub SetCLH()
        CLH = New Unisource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        CLH.AddSaveEvent(gvActivities, "Layout")
        CLH.Components.Add(gvActivities)
    End Sub

    Private Sub AddReports()
        Dim rep As ReportManager.Report = ReportManager.Report.GetByReport(New xrJobActivities)
        If rep IsNot Nothing Then
            bsiReports.AddItem(rep.GetReportPreviewMenu(BarManager1, Me.Job))
        End If
    End Sub

    Private Sub AddReportDesigners()
        Dim rep As ReportManager.Report = ReportManager.Report.GetByReport(New xrJobActivities)
        If rep IsNot Nothing Then
            bsiReports.AddItem(rep.GetReportDesignMenu(BarManager1, Me.Job))
        End If
    End Sub

    Private Sub bbiCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancel.ItemClick
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

    Private Sub bbiSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        SaveJob()
    End Sub

    Private Sub SaveJob()
        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                Job.SaveAndFlush()
            End Using
        Catch ex As Exception
            Me.Conversation.Restart()
            Setup.Log.logError("Error saving Job.", ex)
        End Try

        Try
            Me.Conversation.Flush()
            Me.Conversation.Dispose()
        Catch ex As Exception
            Unisource.Logging.Log.Log.logError(ex.Message, ex)
        End Try
    End Sub

    Private Sub bbiExportGrid_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportGrid.ItemClick
        Try
            Unisource.Helper.GUI.Grid.ExportGrid(gvActivities)
        Catch ex As Exception
            Setup.Log.logError("Error exporting Grid.", ex)
        End Try
    End Sub

    Private Sub bbiResetFormDefaults_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiResetFormDefaults.ItemClick
        CLH.ResetFormDefaults(sender, e)
    End Sub

    Private Sub gvActivities_FocusedColumnChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles gvActivities.FocusedColumnChanged
        Dim jl As API.JobLine = TryCast(gvActivities.GetFocusedRow, API.JobLine)
        If jl IsNot Nothing Then

            If e.FocusedColumn Is colSupplier1 Or e.FocusedColumn Is colSupplier2 Then
                If Not (jl.WorkCentre IsNot Nothing AndAlso jl.WorkCentre.IsBuyOut) Or (jl.WorkCentre Is Nothing) Then
                    Dim move As Integer
                    move = CInt(IIf(e.FocusedColumn.VisibleIndex > e.PrevFocusedColumn.VisibleIndex, 1, -1))
                    If e.FocusedColumn.VisibleIndex = gvActivities.VisibleColumns.Count - 1 Then
                        gvActivities.FocusedColumn = e.PrevFocusedColumn
                    Else
                        gvActivities.FocusedColumn = gvActivities.VisibleColumns(e.FocusedColumn.VisibleIndex + move)
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub gvActivities_ShowingEditor(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gvActivities.ShowingEditor
        Dim jl As API.JobLine = TryCast(gvActivities.GetFocusedRow, API.JobLine)
        If jl IsNot Nothing Then

            If gvActivities.FocusedColumn Is colSupplier1 Or gvActivities.FocusedColumn Is colSupplier2 Then
                If Not (jl.WorkCentre IsNot Nothing AndAlso jl.WorkCentre.IsBuyOut) Or (jl.WorkCentre Is Nothing) Then
                    e.Cancel = True
                End If
            End If

        End If
    End Sub

    Private Sub gvActivities_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gvActivities.RowCellStyle
        Dim jl As API.JobLine = TryCast(gvActivities.GetRow(e.RowHandle), API.JobLine)
        If jl IsNot Nothing Then
            If Not (jl.WorkCentre IsNot Nothing AndAlso jl.WorkCentre.IsBuyOut) Or (jl.WorkCentre Is Nothing) Then
                If e.Column Is colSupplier1 Or e.Column Is colSupplier2 Then
                    e.Appearance.BackColor = Color.LightGray
                    e.Appearance.ForeColor = Color.LightGray
                End If
            End If
        End If
    End Sub

    Private Sub gvActivities_CustomRowCellEdit(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvActivities.CustomRowCellEdit
        Dim jl As API.JobLine = TryCast(gvActivities.GetRow(e.RowHandle), API.JobLine)
        If jl IsNot Nothing Then

            If Not (jl.WorkCentre IsNot Nothing AndAlso jl.WorkCentre.IsBuyOut) Or (jl.WorkCentre Is Nothing) Then
                If e.Column Is colSupplier1 Or e.Column Is colSupplier2 Then
                    e.RepositoryItem = Nothing
                End If
            End If

        End If
    End Sub

    Private Sub bbiAddLine_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAddLine.ItemClick
        Dim xaejl As New xaeJobLineLite With {.Record = New API.JobLine With {.JobLineDate = Now}}
        If xaejl.ShowDialog = DialogResult.OK Then
            Me.Job.JobLineList.Add(xaejl.Record)
        End If
    End Sub

    Private Sub bbiEditLine_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditLine.ItemClick
        Dim jl As API.JobLine = gvActivities.GetFocusedRow
        If jl IsNot Nothing AndAlso jl.ID > 0 Then
            Dim xaejl As New xaeJobLineLite With {.Record = jl}
            xaejl.ShowDialog()
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                RefreshJob()
            End Using
        End If
    End Sub

    Private Sub gvActivities_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvActivities.FocusedRowChanged
        Dim jl As API.JobLine = gvActivities.GetRow(e.FocusedRowHandle)
        If jl IsNot Nothing AndAlso jl.ID > 0 Then
            bbiEditLine.Enabled = True
        Else
            bbiEditLine.Enabled = False
        End If
    End Sub

End Class
