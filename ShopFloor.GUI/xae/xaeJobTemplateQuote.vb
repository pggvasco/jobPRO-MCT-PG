Imports Unisource.ShopFloor.Report



Public Class xaeJobTemplateQuote
    Inherits xaegJobTemplateQuote

    Dim StockList As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)

    Public Sub New(ByVal template As API.JobTemplate)
        InitializeComponent()
        Me.Record = template
        Me.Text = template.TemplateNumber
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

    Private Sub xucJobActivities_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        bbiSave.Glyph = Unisource.Helper.GUI.My.Resources.disk
        bbiCancel.Glyph = Unisource.Helper.GUI.My.Resources.cross
        bsiReports.Glyph = Unisource.Helper.GUI.My.Resources.report
        bbiExportGrid.Glyph = Unisource.Helper.GUI.My.Resources.table
        bbiAddLine.Glyph = Unisource.Helper.GUI.My.Resources.add
        bbiEditLine.Glyph = Unisource.Helper.GUI.My.Resources.pencil

        Try
            Dim wcclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentreCategory)(rlkpWorkCentreCategory, GetType(xaeWorkCentreCategory), AddressOf LoadWorkCentreCategories, Me.Conversation)
            wcclm.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centre Categories.", ex)
        End Try

        Try
            Dim wclm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentre)(rlkpWorkCentre, GetType(xaeWorkCentre), AddressOf LoadWorkCentres, Me.Conversation)
            wclm.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centres.", ex)
        End Try

        Try
            Dim sslm As New Helper.ActiveRecord.LookupMaintenance(Of API.SupplyScope)(rilkpSupplyScope, GetType(xaeSupplyScope), AddressOf LoadSupplyScopes, Me.Conversation)
            sslm.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Supply Scopes.", ex)
        End Try

        Try
            Dim plm As New Helper.ActiveRecord.LookupMaintenance(Of API.Part)(rlkpPart, GetType(xaePart), AddressOf LoadParts, Me.Conversation)
            plm.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Parts.", ex)
        End Try

        Try
            Dim sbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.Vendor)(rilkpSupplier, AddressOf LoadVendors)
            sbl.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Suppliers.", ex)
        End Try

        Try
            Dim stbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.VendorClass)(rilkpSupplierType, AddressOf LoadVendorClasses)
            stbl.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Supplier Types.", ex)
        End Try

        Try
            Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(rilkpInventoryItem, AddressOf LoadStockItems)
            iibl.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        End Try

        Try
            SetCLH()
        Catch ex As Exception
            Setup.Log.logError("Error setting Component Layout Helper.", ex)
        End Try

        Try
            Unisource.Helper.GUI.GridMenuHandler(gvJobLines, GridPopupMenu)
        Catch ex As Exception
            Setup.Log.logError("Error generating Grid menu.", ex)
        End Try

        Try
            SetGridState()
        Catch ex As Exception
            Setup.Log.logError("Error settings Grid State Controller.", ex)
        End Try

        Try
            AddReports()
        Catch ex As Exception
            Setup.Log.logError("Error generating Report menus.", ex)
        End Try

        Try
            AddAdditionalEnquiryFields()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error creating user-defined enquiry fields.", ex)
        End Try

        Try
            RebindAdditionalEnquiryFields()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error binding user-defined enquiry fields.", ex)
        End Try

    End Sub

    Private Function LoadWorkCentreCategories() As IEnumerable(Of API.WorkCentreCategory)
        Return API.WorkCentreCategory.FindAll
    End Function

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

    Private Function LoadStockItems() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)
        StockList = UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
        Return StockList
    End Function

    Protected Overrides Sub SetCLH()


        MyBase.SetCLH()

        CLH.Components.Add(gvJobLines)
        CLH.Components.Add(JobDataLayoutControl)
        CLH.Components.Add(AdditionalFieldsLayoutControlInternal)
        CLH.AddSaveEvent(gvJobLines, "Layout")
        CLH.AddSaveEvent(JobDataLayoutControl, "HideCustomization")
        CLH.AddSaveEvent(AdditionalFieldsLayoutControlInternal, "HideCustomization")
    End Sub

    Public Property GridStateController As Helper.GUI.GridStateControl(Of API.JobTemplateLine)

    Public Sub SetGridState()
        GridStateController = New Helper.GUI.GridStateControl(Of API.JobTemplateLine)(gvJobLines)
        'GridStateController.AddColumns({colSupplier1, colSupplier2, colPurchaseDiscountPercent, colUnitPurchasePrice}, AddressOf IsBuyOutRecord, UniSource.Helper.GUI.StateControlType.Enabled)
        'GridStateController.AddColumns({colQuantityStock, colQuantitySupplier1, colQuantitySupplier2}, AddressOf IsProcurementRecord, UniSource.Helper.GUI.StateControlType.Enabled)
        GridStateController.AddColumns({colInventoryItem}, AddressOf IsNotRecoveryRecord, UniSource.Helper.GUI.StateControlType.Enabled)
    End Sub

    Protected Overridable Function IsRecoveryRecord(ByVal jl As API.JobTemplateLine) As Boolean
        Return jl.WorkCentre IsNot Nothing AndAlso jl.WorkCentre.CalculationType = API.CalculationType.Recovery
    End Function

    Protected Overridable Function IsNotRecoveryRecord(ByVal jl As API.JobTemplateLine) As Boolean
        If jl.WorkCentre Is Nothing Then
            Return True
        End If
        Return jl.WorkCentre.CalculationType <> API.CalculationType.Recovery
    End Function

    Private Sub AddReports()
        Dim rep As ReportManager.Report = ReportManager.Report.GetByReport(New xrJobActivities)
        If rep IsNot Nothing Then
            bsiReports.AddItem(rep.GetReportPreviewMenu(BarManager1, Me.Record))
        End If
    End Sub

    Private Sub AddReportDesigners()
        Dim rep As ReportManager.Report = ReportManager.Report.GetByReport(New xrJobActivities)
        If rep IsNot Nothing Then
            bsiReports.AddItem(rep.GetReportDesignMenu(BarManager1, Me.Record))
        End If
    End Sub

    Private Sub bbiCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancel.ItemClick
        RefreshJob()
    End Sub

    Private Sub RefreshJob()
        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                Record.Refresh()
            End Using
        Catch ex As Exception
            Me.Conversation.Restart()
            Setup.Log.logError("Error refreshing Job.", ex)
        End Try
    End Sub

    Private Sub bbiSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        'SaveRecord()
        SaveJob()
    End Sub

    Private Sub SaveJob()
        gvJobLines.CloseEditor()
        If gvJobLines.HasColumnErrors Then
            Setup.Log.logError("One of the grids contains errors, please correct before saving the Template.")
            Exit Sub
        End If

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                Me.Record.SaveAndFlush()
            End Using
        Catch ex As Exception
            Conversation.Restart()
            Setup.Log.logError("Error saving Job.", ex)
        End Try
    End Sub

    Private Sub bbiExportGrid_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportGrid.ItemClick
        Try
            Unisource.Helper.GUI.Grid.ExportGrid(gvJobLines)
        Catch ex As Exception
            Setup.Log.logError("Error exporting Grid.", ex)
        End Try
    End Sub

    Private Sub bbiResetFormDefaults_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiResetFormDefaults.ItemClick
        CLH.ResetFormDefaults(sender, e)
    End Sub

    Private Sub bbiAddLine_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAddLine.ItemClick
        gvJobLines.CloseEditor()
        Dim xaejtl As New xaeJobTemplateLineLite With {.Record = New API.JobTemplateLine With {.JobTemplate = Record, .WorkCentreCategory = Record.WorkCentreCategory}}
        'xaejtl.StockItemBindingSource = StockItemBindingSource
        'xaejtl.InventoryItemIDLookupEdit.Properties.DataSource = StockList
        If xaejtl.ShowDialog = DialogResult.OK Then
            Me.Record.JobTemplateLineList.Add(xaejtl.Record)

            BindingSource.DataSource = Me.Record
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
        xaejtl.Close()
    End Sub

    Private Sub bbiEditLine_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditLine.ItemClick
        gvJobLines.CloseEditor()
        Dim jl As API.JobTemplateLine = gvJobLines.GetFocusedRow
        If jl IsNot Nothing AndAlso jl.ID > 0 Then
            Dim xaejl As New xaeJobTemplateLineLite With {.Record = jl}
            'xaejl.StockItemBindingSource = StockItemBindingSource
            'xaejl.InventoryItemIDLookupEdit.Properties.DataSource = StockList
            xaejl.ShowDialog()
            TryCast(gvJobLines.GetFocusedRow, API.JobTemplateLine).Refresh()
            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            '    RefreshJob()
            'End Using
        End If
    End Sub

    Private Sub gvActivities_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvJobLines.FocusedRowChanged
        Dim jl As API.JobTemplateLine = gvJobLines.GetRow(e.FocusedRowHandle)
        If jl IsNot Nothing AndAlso jl.ID > 0 Then
            bbiEditLine.Enabled = True
        Else
            bbiEditLine.Enabled = False
        End If
        If jl IsNot Nothing Then
            If jl.WorkCentreCategory Is Nothing Then
                jl.WorkCentreCategory = Me.Record.WorkCentreCategory
            End If
        End If
    End Sub

    Private Sub gvJobLines_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvJobLines.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        Beep()
    End Sub

    Private Sub gvJobLines_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvJobLines.ValidateRow
        Dim jl As API.JobLine = TryCast(e.Row, API.JobLine)
        If jl IsNot Nothing Then
            e.Valid = jl.IsValid
        End If
    End Sub

    Private Sub gvJobLines_CustomRowCellEdit(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvJobLines.CustomRowCellEdit
        'If e.Column Is colWorkCentre Then
        '    Dim jobLine As API.JobLine = TryCast(gvJobLines.GetRow(e.RowHandle), API.JobLine)
        '    If jobLine IsNot Nothing Then
        '        Dim rilkp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = rlkpWorkCentre.Clone
        '        rilkp.DataSource = (From workCentre As API.WorkCentre In WorkCentreBindingSource.List Where workCentre.WorkCentreCategory Is Nothing OrElse workCentre.WorkCentreCategory.Equals(jobLine.WorkCentreCategory)).ToList
        '        If IsRecoveryRecord(jobLine) Then
        '            TryCast(gvJobLines.GetRow(e.RowHandle), API.JobLine).InventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where ii.Code = jobLine.WorkCentre.RecoveryServiceCode Select ii).FirstOrDefault
        '            'gvJobLines.RefreshRow(e.RowHandle)
        '        End If
        '        e.RepositoryItem = rilkp
        '    End If
        'End If
        'If e.Column Is colInventoryItem Then
        '    Dim jobLine As API.JobLine = TryCast(gvJobLines.GetRow(e.RowHandle), API.JobLine)
        '    If jobLine IsNot Nothing Then
        '        Dim riglkp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = rilkpInventoryItem.Clone
        '        riglkp.DataSource = (From stockItem As UniSource.Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where stockItem.ItemGroup Is Nothing OrElse stockItem.ItemGroup.Trim = "" OrElse stockItem.ItemGroup.Equals(jobLine.WorkCentreCategory.Code)).ToList
        '        e.RepositoryItem = riglkp
        '    End If
        'End If

        If e.Column Is colWorkCentre Then
            If WorkCentreBindingSource.List.Count > 0 Then
                Dim jobTemplateLine As API.JobTemplateLine = TryCast(gvJobLines.GetRow(e.RowHandle), API.JobTemplateLine)
                If jobTemplateLine IsNot Nothing Then
                    Dim rilkp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = rlkpWorkCentre.Clone
                    rilkp.DataSource = (From workCentre As API.WorkCentre In WorkCentreBindingSource.List Where workCentre.WorkCentreCategory Is Nothing OrElse jobTemplateLine.WorkCentreCategory Is Nothing OrElse workCentre.WorkCentreCategory.Equals(jobTemplateLine.WorkCentreCategory)).ToList
                    If IsRecoveryRecord(jobTemplateLine) Then
                        TryCast(gvJobLines.GetRow(e.RowHandle), API.JobTemplateLine).InventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where ii.Code = jobTemplateLine.WorkCentre.RecoveryServiceCode Select ii).FirstOrDefault
                        'gvJobLines.RefreshRow(e.RowHandle)
                    End If
                    e.RepositoryItem = rilkp
                End If
            End If
        End If
        If e.Column Is colInventoryItem Then
            If StockItemBindingSource.List.Count > 0 Then
                Dim jobTemplateLine As API.JobTemplateLine = TryCast(gvJobLines.GetRow(e.RowHandle), API.JobTemplateLine)
                If jobTemplateLine IsNot Nothing Then
                    Dim riglkp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = rilkpInventoryItem.Clone
                    riglkp.DataSource = (From stockItem As UniSource.Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where stockItem.ItemGroup Is Nothing OrElse stockItem.ItemGroup.Trim = "" OrElse jobTemplateLine.WorkCentreCategory Is Nothing OrElse stockItem.ItemGroup.Equals(jobTemplateLine.WorkCentreCategory.Code)).ToList
                    e.RepositoryItem = riglkp
                End If
            End If
        End If
    End Sub

    Private Sub bbiRefreshPricess_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefreshPricess.ItemClick
        gvJobLines.CloseEditor()

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                For Each jtl As API.JobTemplateLine In Record.JobTemplateLines
                    'jtl.c
                Next
                Record.Refresh()
            End Using
        Catch ex As Exception
            Me.Conversation.Restart()
            Setup.Log.logError("Error refreshing Job.", ex)
        End Try

        'For Each jl In datasou
        '    Dim jl As API.JobTemplateLine = gvJobLines.GetFocusedRow
        '    If jl IsNot Nothing AndAlso jl.ID > 0 Then
        '        Dim xaejl As New xaeJobTemplateLineLite With {.Record = jl}
        '        xaejl.ShowDialog()
        '        TryCast(gvJobLines.GetFocusedRow, API.JobTemplateLine).Refresh()
        '    End If
    End Sub

    Protected Overrides Sub SaveClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim rowNo As Integer = 0
        Do While rowNo < gvJobLines.RowCount
            Dim jl As API.JobTemplateLine = TryCast(gvJobLines.GetRow(rowNo), API.JobTemplateLine)
            If jl IsNot Nothing Then
                If jl.IsValid = False Then
                    Setup.Log.logError(String.Format("Some rows did not pass the validation test. Job Template :{0}. Line Description : {1}", jl.JobTemplate.TemplateNumber, jl.Description1))
                Me.DialogResult = Windows.Forms.DialogResult.None
                Return
            End If
            End If
            rowNo += 1
        Loop
        MyBase.SaveClick(sender, e)
    End Sub

    Public Sub AddAdditionalEnquiryFields()
        If AdditionalFieldsLayoutControlInternal IsNot Nothing Then
            For Each udef As Helper.ActiveRecord.Evolution.UserDefinedField In UniSource.Helper.ActiveRecord.Evolution.UserDefinedField.FindAllByType(GetType(API.JobTemplate))
                AdditionalFieldsLayoutControlInternal.AddItem(udef.GetLayoutControlItem)
            Next
        End If
    End Sub

    Public Sub RebindAdditionalEnquiryFields()
        If AdditionalFieldsLayoutControlInternal IsNot Nothing Then
            For Each lci As DevExpress.XtraLayout.BaseLayoutItem In AdditionalFieldsLayoutControlInternal.Items
                Dim bc As UniSource.Helper.ActiveRecord.UserDefinedFieldBindingContext = TryCast(lci.Tag, UniSource.Helper.ActiveRecord.UserDefinedFieldBindingContext)
                If bc IsNot Nothing Then
                    bc.ReBind(Me.BindingSource.Current)
                End If
                bc = Nothing
            Next
        End If
    End Sub


    'Private Sub BindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles BindingSource.CurrentChanged
    '    Try
    '        RebindAdditionalEnquiryFields()
    '    Catch ex As Exception
    '        UniSource.Logging.Log.Log.logError("Error binding user-defined enquiry fields.", ex)
    '    End Try
    'End Sub
End Class

Public Class xaegJobTemplateQuote
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.JobTemplate)

End Class
