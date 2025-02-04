Imports DevExpress.XtraReports.UI
Imports UniSource.ShopFloor.API
Public Class xaeJobQuote
    Inherits UniSource.ShopFloor.GUI.xaegJobQuote

    Public Property GridStateController As Helper.GUI.GridStateControl(Of API.JobLine)
    Private IsLookUpDataLoaded As Boolean = False
    Private AAIsLoadFormComplete As Boolean = False

    Private Property CurrentGP As Double? = 0
    Private Property ExpectedGP As Double? = 0

    Public Property CanEditDiscount As Boolean = False


    Public Sub New(ByVal job As API.Job)
        InitializeComponent()
        Me.Record = job
        If Me.Record.ValidityDays Is Nothing Then
            Me.Record.ValidityDays = API.Context.Defaults.ValidityDays
        End If
        Select Case job.State
            Case API.JobState.Quote
                Me.Text = job.QuoteNumber
            Case Else
                Me.Text = job.JobNumber
        End Select
        CurrentGP = Me.Record.CurrentGP
        ExpectedGP = Me.Record.ExpectedGP
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.TopMost = False
    End Sub

    Private Sub AppendWarnings()
        gvJobLines.Images = New DevExpress.Utils.ImageCollection()
        CType(gvJobLines.Images, DevExpress.Utils.ImageCollection).AddImage(UniSource.Helper.GUI.My.Resources.Information)
        If IIf(Me.Record.IsApproved.HasValue, Me.Record.IsApproved, False) Then
            colUnitPrice.ImageIndex = 0
            colTotalPrice.ImageIndex = 0
            colUnitPrice.ToolTip = "Job is Approved, changes will not calculate or affect pricing."
            colTotalPrice.ToolTip = "Job is Approved, changes will not calculate or affect pricing."
        End If
    End Sub

    Private Sub xucJobActivities_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(Me, GetType(Helper.ActiveRecord.WaitForm), False, True)

        Try
            AppendWarnings()
        Catch ex As Exception
            Setup.Log.logError("Error displaying warning messages.", ex)
        End Try

        bbiSave.Glyph = UniSource.Helper.GUI.My.Resources.disk
        bbiCancel.Glyph = UniSource.Helper.GUI.My.Resources.cross
        bsiReports.Glyph = UniSource.Helper.GUI.My.Resources.report
        bbiExportGrid.Glyph = UniSource.Helper.GUI.My.Resources.table
        bbiAddLine.Glyph = UniSource.Helper.GUI.My.Resources.add
        bbiEditLine.Glyph = UniSource.Helper.GUI.My.Resources.pencil
        bsiImport.Glyph = UniSource.Helper.GUI.My.Resources.basket
        bbiImportJob.Glyph = UniSource.Helper.GUI.My.Resources.page_white
        bbiImportTemplate.Glyph = UniSource.Helper.GUI.My.Resources.page
        bbiImportQuote.Glyph = UniSource.Helper.GUI.My.Resources.page_world
        'Application.DoEvents()

        btnCreateRequisition.Glyph = UniSource.Helper.GUI.My.Resources.box
        btnRePrintRequisition.Glyph = UniSource.Helper.GUI.My.Resources.page
        bbiCancelSelectedLines.Glyph = UniSource.Helper.GUI.My.Resources.delete

        If CanEditDiscount = False Then
            defaultDiscountSpinEdit.Properties.ReadOnly = True
            bbiUpdateLinesDiscount.Enabled = False
        Else
            defaultDiscountSpinEdit.Properties.Enabled = True
            bbiUpdateLinesDiscount.Enabled = True
        End If

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(False, 400, Nothing)
        AAIsLoadFormComplete = True
        Me.TopMost = False
        Me.Refresh()

        Try
            SetPermissions()
        Catch ex As Exception
            Setup.Log.logError("Error setting form permissions for agents.", ex)
        End Try


        'For Each jobline As API.JobLine In Me.Record.JobLines
        '    jobline.IsRequisitionReportSelected = False
        'Next

    End Sub

    Private Sub SetPermissions()
        Dim gc As New UniSource.Security.ActiveRecord.GUIController(Me, Setup.ExtendedAgent.User)
    End Sub

    Private Sub LoadLookUpData()
        Me.TopMost = False
        Try
            Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(rilkpInventoryItem, AddressOf LoadStockItems)
            iibl.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        End Try

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
            UniSource.Helper.GUI.GridMenuHandler(gvJobLines, GridPopupMenu)
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

        Me.TopMost = False

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

    Private Function LoadVendors() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.Vendor)
        Return UniSource.Helper.ActiveRecord.Evolution.Vendor.FindAll
    End Function

    Private Function LoadVendorClasses() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.VendorClass)
        Return UniSource.Helper.ActiveRecord.Evolution.VendorClass.FindAll
    End Function

    Private Function LoadStockItems() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)
        Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
    End Function

    'Private Function LoadStockItems(ByRef WorkCentereCategory As API.WorkCentreCategory) As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)
    '    If WorkCentereCategory IsNot Nothing Then
    '        Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAllByProperty("Group", WorkCentereCategory.Code)
    '    Else
    '        Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
    '    End If
    'End Function

    Protected Overrides Sub SetCLH()
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

        MyBase.SetCLH()
        Select Case Record.State
            Case API.JobState.Quote
                gvJobLines.Name = "gvQuoteLines"
                JobDataLayoutControl.Name = "QuoteDataLayoutControl"
                AdditionalFieldsLayoutControlInternal.Name = "QuoteAdditionalFieldsLayoutControlInternal"
        End Select
        CLH.Components.Add(gvJobLines)
        CLH.Components.Add(JobDataLayoutControl)
        CLH.Components.Add(AdditionalFieldsLayoutControlInternal)
        CLH.AddSaveEvent(gvJobLines, "Layout")
        CLH.AddSaveEvent(JobDataLayoutControl, "HideCustomization")
        CLH.AddSaveEvent(AdditionalFieldsLayoutControlInternal, "HideCustomization")
    End Sub


    Public Sub SetGridState()
        GridStateController = New Helper.GUI.GridStateControl(Of API.JobLine)(gvJobLines)
        GridStateController.AddColumns({colSupplier1, colSupplier2, colPurchaseDiscountPercent, colUnitPurchasePrice, colSupplierType, colUnitPurchasePrice}, AddressOf IsBuyOutRecord, UniSource.Helper.GUI.StateControlType.Enabled)
        GridStateController.AddColumns({colQuantityStock, colQuantitySupplier1, colQuantitySupplier2}, AddressOf IsProcurementRecord, UniSource.Helper.GUI.StateControlType.Enabled)
        GridStateController.AddColumns({colInventoryItem}, AddressOf IsNotRecoveryRecord, UniSource.Helper.GUI.StateControlType.Enabled)
    End Sub

    Private Sub AddReports()
        Dim rep As ReportManager.Report = ReportManager.Report.GetByReport(New Report.xrDoscoQuotation)
        If rep IsNot Nothing Then
            bsiReports.AddItem(rep.GetReportPreviewMenu(BarManager, Me.Record))
        End If
        Me.TopMost = False
        Dim showreqMenu As Boolean = False
        'Config Reports
        If Record.JobStage IsNot Nothing AndAlso Record.JobStage.Reports IsNot Nothing Then
            For Each jf As API.JobStageReport In Me.Record.JobStage.Reports
                Dim jobStageReport As ReportManager.Report = ReportManager.Report.GetByName(jf.Report.ReportName)
                If IIf(IsDBNull(jf.IsReportOnEditScreen), True, jf.IsReportOnEditScreen) Then
                    If jobStageReport IsNot Nothing Then
                        If jf.Report.ReportName = "Prerequisition" Then
                            showreqMenu = True
                        End If
                        If jf.Report.DataSourceTypeName = "UniSource.ShopFloor.API.Job" Then
                            bsiReports.AddItem(jobStageReport.GetReportPreviewMenu(BarManager, Me.Record))
                        ElseIf jf.Report.DataSourceTypeName = "UniSource.ShopFloor.API.JobTolerance" Then
                            bsiReports.AddItem(jobStageReport.GetReportPreviewMenu(BarManager, Me.Record.JobTolerances))
                        ElseIf jf.Report.DataSourceTypeName = "UniSource.ShopFloor.API.Requisition" Then
                            bsiReports.AddItem(jobStageReport.GetReportPreviewMenu(BarManager, Me.Record.Requisitions))
                        ElseIf jf.Report.DataSourceTypeName = "UniSource.ShopFloor.API.PurchaseOrder" Then
                            bsiReports.AddItem(jobStageReport.GetReportPreviewMenu(BarManager, Me.Record.PurchaseOrders))
                        ElseIf jf.Report.DataSourceTypeName = "UniSource.ShopFloor.API.JobDelivery" Then
                            bsiReports.AddItem(jobStageReport.GetReportPreviewMenu(BarManager, Me.Record.JobDeliveries))
                        Else
                        End If
                    End If
                End If
                jobStageReport = Nothing
            Next
        End If

        If showreqMenu Then
            btnCreateRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            btnRePrintRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            bbiCancelSelectedLines.Enabled = True
        Else
            btnCreateRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnRePrintRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        rep = Nothing
        Me.TopMost = False
    End Sub

    Private Sub AddReportDesigners()
        Me.TopMost = False
        Dim rep As ReportManager.Report = ReportManager.Report.GetByReport(New Report.xrJobActivities)
        If rep IsNot Nothing Then
            bsiReports.AddItem(rep.GetReportDesignMenu(BarManager, Me.Record))
        End If
        rep = Nothing
        Me.TopMost = False
    End Sub

    Private Sub bbiCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        RefreshJob()
    End Sub

    Private Sub RefreshJob()
        Try
            Me.TopMost = False
            gvJobLines.CloseEditor()
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                Record.Refresh()
            End Using
            Me.Refresh()
        Catch ex As Exception
            'Me.Conversation.Restart()
            Setup.Log.logError("Error refreshing Job.", ex)
        End Try
    End Sub

    Private Sub bbiSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        gvJobLines.CloseEditor()
        'SaveRecord()
        SaveJob()
        'Refresh()
    End Sub

    Private Sub SaveJob()
        gvJobLines.CloseEditor()
        Me.Record.UpdateGPValues()
        If Me.CurrentGP Is Nothing OrElse Me.CurrentGP <> Me.Record.CurrentGP Then
            If Me.Record.JobGPCheck() = True Then
                Dim log As New API.Audit
                log.Date = Now
                log.Agent = API.Context.Agent
                log.Description = String.Format("The suggested GP was overridden. Suggested GP {0}%, Current GP {1}%", Me.Record.ExpectedGP * 100, Me.Record.CurrentGP * 100)
                log.Type = "CurrentGP"
                log.OldValue = Me.CurrentGP
                log.NewValue = Me.Record.CurrentGP
                log.idJob = Me.Record.ID
                log.SaveAndFlush()
                Me.CurrentGP = Me.Record.CurrentGP
                log = Nothing
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
                Return
            End If
        End If

        Try
            Dim bc As New UniSource.Helper.ActiveRecord.Checkout
            If Not bc.AlreadyCheckedOut(Me.CheckoutGuid) Then
                Throw New Exception("You have lost your checkout authority, your changes cannot be saved.")
            End If
            bc = Nothing
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error testing checkout authority.", ex)
            'Me.Conversation.Restart()
            Me.DialogResult = Windows.Forms.DialogResult.None
            Me.Close()
            Exit Sub
        End Try

        gvJobLines.CloseEditor()

        If gvJobLines.HasColumnErrors Then
            Setup.Log.logError("One of the grids contains errors, please correct before saving the Job.")
            Exit Sub
        End If

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                Me.Record.SaveAndFlush()
            End Using
        Catch ex As Exception
            'Conversation.Restart()
            Setup.Log.logError("Error saving Job.", ex)
        End Try
        'Conversation.Flush()
        'Conversation.Restart()
    End Sub

    Protected Overrides Sub SaveRecord()
        gvJobLines.CloseEditor()
        Me.Record.UpdateGPValues()
        If Me.CurrentGP Is Nothing OrElse Me.CurrentGP <> Me.Record.CurrentGP Then
            If Me.Record.JobGPCheck() = True Then
                Dim log As New API.Audit
                log.Date = Now
                log.Agent = API.Context.Agent
                log.Description = String.Format("The suggested GP was overridden. Suggested GP {0}%, Current GP {1}%", Me.Record.ExpectedGP * 100, Me.Record.CurrentGP * 100)
                log.Type = "CurrentGP"
                log.OldValue = Me.CurrentGP
                log.NewValue = Me.Record.CurrentGP
                log.idJob = Me.Record.ID
                log.SaveAndFlush()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
                Return
            End If
        End If
        MyBase.SaveRecord()
    End Sub

    Private Sub bbiExportGrid_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportGrid.ItemClick
        Try
            Me.TopMost = False
            Me.Refresh()
            gvJobLines.CloseEditor()
            UniSource.Helper.GUI.Grid.ExportGrid(gvJobLines)
        Catch ex As Exception
            Setup.Log.logError("Error exporting Grid.", ex)
        End Try
    End Sub

    Private Sub bbiResetFormDefaults_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        CLH.ResetFormDefaults(sender, e)
    End Sub

    Protected Overridable Function IsProcurementRecord(ByVal jl As API.JobLine) As Boolean
        'If jl IsNot Nothing AndAlso Me.Record IsNot Nothing AndAlso Me.Record.JobStage IsNot Nothing Then
        If jl IsNot Nothing AndAlso jl.Job IsNot Nothing AndAlso jl.Job.JobStage IsNot Nothing Then
            'Return IIf(Me.Record.JobStage.IsProcurement.HasValue, Me.Record.JobStage.IsProcurement, False) AndAlso Not IsRecoveryRecord(jl)
            Return IIf(jl.Job.JobStage.IsProcurement.HasValue, jl.Job.JobStage.IsProcurement, False) AndAlso Not IsRecoveryRecord(jl)
        Else
            Return False
        End If
    End Function

    Protected Overridable Function IsBuyOutRecord(ByVal jl As API.JobLine) As Boolean
        Return jl IsNot Nothing AndAlso jl.WorkCentre IsNot Nothing AndAlso IIf(jl.WorkCentre.IsBuyOut.HasValue, jl.WorkCentre.IsBuyOut, False)
    End Function

    Protected Overridable Function IsRecoveryRecord(ByVal jl As API.JobLine) As Boolean
        Return jl IsNot Nothing AndAlso jl.WorkCentre IsNot Nothing AndAlso jl.WorkCentre.CalculationType = API.CalculationType.Recovery
    End Function

    Protected Overridable Function IsNotRecoveryRecord(ByVal jl As API.JobLine) As Boolean
        If jl Is Nothing OrElse jl.WorkCentre Is Nothing Then
            Return True
        End If
        Return jl.WorkCentre.CalculationType <> API.CalculationType.Recovery
    End Function

    Private Sub bbiAddLine_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAddLine.ItemClick
        gvJobLines.CloseEditor()
        Me.TopMost = False
        Me.Refresh()
        'Conversation.Flush()
        'Conversation.Restart()
        If API.Context.Defaults.DefaultJobLineScreen = API.DefaultJobLineScreen.JobLine Then


            Dim xaejl As xaeJobLineLite
            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)                                                                                                                     Freddie, added line discount percent
            xaejl = New xaeJobLineLite With {.Record = New API.JobLine With {.JobLineDate = Now, .Job = CType(BindingSource.Current, API.Job), .WorkCentreCategory = Record.WorkCentreCategory, .AssetID = Record.EquipamentoNo1, .Asset2ID = Record.EquipamentoNo2}}
            'End Using
            'xaejl.PerformBatchCheckout = True
            xaejl.CanEditDiscount = CanEditDiscount
            xaejl.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiAddLine.Glyph)
            Select Case Record.State
                Case API.JobState.Active
                    xaejl.Text = "Job Line"
                Case API.JobState.Quote
                    xaejl.Text = "Quote Line"
                Case Else
                    xaejl.DataLayoutControl1.Enabled = False
            End Select

            'SuspendBinding()

            If xaejl.ShowDialog = DialogResult.OK Then
                'ResumeBinding()
                CType(BindingSource.Current, API.Job).JobLines.Add(xaejl.Record)
                'BindingSource.DataSource = Me.Record
                'SaveRecord()
                Me.DialogResult = Windows.Forms.DialogResult.None
                'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)

                'End Using
            Else
                'ResumeBinding()
            End If
            xaejl.Close()
            xaejl = Nothing
        ElseIf API.Context.Defaults.DefaultJobLineScreen = API.DefaultJobLineScreen.JobLine2 Then
            Dim xaejl As xaeJobLineLite2
            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)                                                                                                                     Freddie, added line discount percent
            xaejl = New xaeJobLineLite2 With {.Record = New API.JobLine With {.JobLineDate = Now, .Job = CType(BindingSource.Current, API.Job), .WorkCentreCategory = Record.WorkCentreCategory, .AssetID = Record.EquipamentoNo1, .Asset2ID = Record.EquipamentoNo2}}
            'End Using
            'xaejl.PerformBatchCheckout = True
            xaejl.CanEditDiscount = CanEditDiscount
            xaejl.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiAddLine.Glyph)
            Select Case Record.State
                Case API.JobState.Active
                    xaejl.Text = "Job Line"
                Case API.JobState.Quote
                    xaejl.Text = "Quote Line"
                Case Else
                    xaejl.DataLayoutControl1.Enabled = False
            End Select

            'SuspendBinding()

            If xaejl.ShowDialog = DialogResult.OK Then
                'ResumeBinding()
                CType(BindingSource.Current, API.Job).JobLines.Add(xaejl.Record)
                'BindingSource.DataSource = Me.Record
                'SaveRecord()
                Me.DialogResult = Windows.Forms.DialogResult.None
                'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)

                'End Using
            Else
                'ResumeBinding()
            End If
            xaejl.Close()
            xaejl = Nothing

        End If
        gvJobLines.RefreshData()
        'Refresh()
        'Conversation.Flush()
        'Conversation.Restart()
        'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
        'Me.Record.UpdateGPValues()
        'Me.Record.Refresh()
        'BindingSource.DataSource = Me.Record
        'End Using


    End Sub

    Private Sub SuspendBinding()
        'BindingSource.SuspendBinding()
        'PartBindingSource.SuspendBinding()
        'StockItemBindingSource.SuspendBinding()
        'SupplyScopeBindingSource.SuspendBinding()
        'VendorBindingSource.SuspendBinding()
        'VendorClassBindingSource.SuspendBinding()
        'WorkCentreBindingSource.SuspendBinding()
        'WorkCentreCategoryBindingSource.SuspendBinding()
    End Sub

    Private Sub ResumeBinding()
        'BindingSource.ResumeBinding()
        'PartBindingSource.ResumeBinding()
        'StockItemBindingSource.ResumeBinding()
        'SupplyScopeBindingSource.ResumeBinding()
        'VendorBindingSource.ResumeBinding()
        'VendorClassBindingSource.ResumeBinding()
        'WorkCentreBindingSource.ResumeBinding()
        'WorkCentreCategoryBindingSource.ResumeBinding()
    End Sub


    Private Sub bbiEditLine_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditLine.ItemClick
        'Application.DoEvents()
        gvJobLines.CloseEditor()
        Me.TopMost = False
        Me.Refresh()
        'Conversation.Flush()
        'Conversation.Restart()
        'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
        'SaveRecord()
        Me.DialogResult = Windows.Forms.DialogResult.None
        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            TryCast(gvJobLines.GetFocusedRow, API.JobLine).SaveAndFlush()
        End Using
        Dim jl As API.JobLine = gvJobLines.GetFocusedRow

        If jl IsNot Nothing Then
            'Dim xaejl As New xaeJobLineLite With {.Conversation = Me.Conversation, .IgnoreRecordReload = True, .Record = jl}
            'Dim xaejl As New xaeJobLineLite With {.Conversation = Me.Conversation, .Record = jl}
            'Conversation.Flush()
            'Conversation.Restart()
            Dim xaejl As New xaeJobLineLite With {.Record = jl}
            'Me.Conversation.Restart()
            xaejl.CanEditDiscount = CanEditDiscount
            'Dim xaejl As New xaeJobLineLite With {.Record = New API.JobLine With {.ActualDuration .JobLineDate = Now, .Job = Record, .WorkCentreCategory = Record.WorkCentreCategory}}
            'xaejl.OverideRecord = jl
            If jl.WorkCentre.IsBuyOut = True And jl.ISPOGenerated = True Then
                xaejl.WorkCentreLookupEdit.Properties.ReadOnly = True
                xaejl.InventoryItemIDLookupEdit.Properties.ReadOnly = True
                xaejl.Description1TextEdit.Properties.ReadOnly = True
                xaejl.Supplier1IDLookupEdit.Properties.ReadOnly = True
                xaejl.Supplier2TextEdit.Properties.ReadOnly = True
                xaejl.WorkCentreCategoryLookUpEdit.Properties.ReadOnly = True
            End If
            If (jl.WorkCentre.IsBuyOut = False Or jl.WorkCentre.IsBuyOut Is Nothing) And jl.ISRlGenerated = True Then
                xaejl.WorkCentreLookupEdit.Properties.ReadOnly = True
                xaejl.InventoryItemIDLookupEdit.Properties.ReadOnly = True
                xaejl.Description1TextEdit.Properties.ReadOnly = True
                xaejl.WorkCentreCategoryLookUpEdit.Properties.ReadOnly = True
            End If

            xaejl.PerformBatchCheckout = True
            xaejl.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiEditLine.Glyph)
            Select Case Record.State
                Case API.JobState.Active
                    xaejl.Text = "Job Line"
                Case API.JobState.Quote
                    xaejl.Text = "Quote Line"
                Case Else
                    xaejl.DataLayoutControl1.Enabled = False
            End Select
            gvJobLines.CloseEditor()
            'SuspendBinding()
            xaejl.ShowDialog()
            'ResumeBinding()
            'SaveRecord()
            ' set DialogResult to none so that form does not close on save
            Me.DialogResult = Windows.Forms.DialogResult.None
            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)          
            'End Using
            'Refresh()
            'RefreshJob()
            'Application.DoEvents()

            'SaveRecord()
            xaejl.Close()
            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            Me.DialogResult = Windows.Forms.DialogResult.None

            'BindingSource.DataSource = Me.Record
            'Refresh()
            'TryCast(gvJobLines.GetFocusedRow, API.JobLine).Refresh()
            'Me.Record.UpdateGPValues()
            'End Using
        End If
        'End Using
        'Conversation.Flush()
        'Conversation.Restart()
        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            TryCast(gvJobLines.GetFocusedRow, API.JobLine).Refresh()
            'Me.Record.Refresh()
        End Using
        'Conversation.Flush()
        'Conversation.Restart()
        'Me.Refresh()

        gvJobLines.RefreshData()
    End Sub

    Private Sub gvJobLines_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvJobLines.FocusedRowChanged
        If e.FocusedRowHandle <= -1 Then
            Return
            MessageBox.Show("oops")
        End If
        Dim jl As API.JobLine = gvJobLines.GetRow(e.FocusedRowHandle)
        'If jl IsNot Nothing AndAlso jl.ID > 0 AndAlso btSave.Visible Then
        '    bbiEditLine.Enabled = True
        'Else
        '    bbiEditLine.Enabled = False
        'End If

        If jl IsNot Nothing Then
            Dim tmpQuantityDrawn As Double = IIf(IsNothing(jl.QuantitySupplierOrdered), 0, jl.QuantitySupplierOrdered) + IIf(IsNothing(jl.QuantityStockDrawn), 0, jl.QuantityStockDrawn)
            If tmpQuantityDrawn > 0 Then
                gcLobLines.EmbeddedNavigator.Buttons.Remove.Enabled = False
            Else
                gcLobLines.EmbeddedNavigator.Buttons.Remove.Enabled = True
            End If
        End If
        jl = Nothing
    End Sub

    Private Sub bbiImportTemplate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImportTemplate.ItemClick
        Try
            'SaveRecord()
            gvJobLines.CloseEditor()
            Me.TopMost = False
            Me.Refresh()
            API.Context.IsImporting = True
            ImportTemplate()
            'SaveRecord()
            'Me.DialogResult = Windows.Forms.DialogResult.None
            'BindingSource.DataSource = Me.Record
        Catch ex As Exception
            Setup.Log.logError("Error importing Template.", ex)
            'Conversation.Restart()
        Finally
            Me.DialogResult = Windows.Forms.DialogResult.None
            'Me.Record.Refresh()
            'BindingSource.DataSource = Me.Record
            gvJobLines.RefreshData()
            API.Context.IsImporting = False
        End Try
        'Conversation.Restart()
    End Sub

    Protected Sub ImportTemplate()
        gvJobLines.CloseEditor()
        Me.TopMost = False
        Me.Refresh()
        Dim jt As API.JobTemplate
        'Try
        '    'Using New Castle.ActiveRecord.ConversationalScope(Conversation)
        '    Dim ql As Helper.ActiveRecord.xfQuickLookup(Of API.JobTemplate)
        '    If Me.Record.WorkCentreCategory IsNot Nothing Then
        '        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobTemplate)()
        '        crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("WorkCentreCategory", Me.Record.WorkCentreCategory), NHibernate.Criterion.Expression.IsNull("WorkCentreCategory")))
        '        ql = New Helper.ActiveRecord.xfQuickLookup(Of API.JobTemplate)(API.JobTemplate.FindAll(crit), "TemplateNumber", "TemplateNumber", "Description1")
        '        crit = Nothing
        '    Else
        '        ql = New Helper.ActiveRecord.xfQuickLookup(Of API.JobTemplate)(API.JobTemplate.FindAll, "TemplateNumber", "TemplateNumber", "Description1")
        '    End If
        '    If Me.Record.JobTemplate IsNot Nothing Then
        '        CType(ql.Controls(2), DevExpress.XtraEditors.LookUpEdit).EditValue = Me.Record.JobTemplate
        '    End If
        '    'ql.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiImportTemplate.Glyph)
        '    ql.ShowDialog()
        '    jt = ql.EditValue

        '    'If jt IsNot Nothing Then
        '    '    For Each jtl In jt.JobTemplateLineList
        '    '        If jtl.IsValid = False Then
        '    '            Setup.Log.logError("Error importing Template. Validation Failed.")
        '    '            Return
        '    '        End If
        '    '    Next
        '    'End If
        '    ql.Close()
        '    'End Using
        'Catch ex As Exception
        '    Setup.Log.logError("Error importing Template. Validation Failed.", ex)
        '    'Conversation.Restart()
        '    Return
        'Finally
        'End Try

        'Using New Castle.ActiveRecord.ConversationalScope(Conversation)
        '    If jt IsNot Nothing Then
        '        Dim JobTemplateCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobTemplate)()
        '        JobTemplateCrit.Add(NHibernate.Criterion.Expression.Eq("TemplateNumber", jt.TemplateNumber))
        '        Dim JobTemplate As API.JobTemplate = API.JobTemplate.FindFirst(JobTemplateCrit)

        '        For Each jtl In JobTemplate.JobTemplateLines
        '            If jtl.IsValid = False Then
        '                Setup.Log.logError("Error importing Template. Validation Failed.")
        '                Return
        '            End If
        '        Next
        '    End If
        'End Using

        Dim Recalculate As Boolean
        Try
            Dim ql As New xfTemplateImportLookUp()
            ql.Record = Me.Record
            ql.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiImportJob.Glyph)
            If ql.ShowDialog() = Windows.Forms.DialogResult.OK Then
                jt = ql.EditValue
                Recalculate = ql.Recalculate

                If jt IsNot Nothing Then
                    Dim jti As New JobTemplateImport(Me.Record, Recalculate)
                    jti.Template = jt
                    jti.Process()
                    jti = Nothing
                End If

            End If

            ql.Close()
            ql.Dispose()
        Catch ex As Exception

        End Try

        jt = Nothing
        'Me.Refresh()
        'Conversation.Flush()
        'Conversation.Restart()
        GC.Collect()
    End Sub

    Private Sub bbiImportJob_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImportJob.ItemClick
        Try
            'Me.TopMost = False
            Me.Refresh()
            API.Context.IsImporting = True
            ImportJob()

            'SaveRecord()
            Me.DialogResult = Windows.Forms.DialogResult.None
            'Refresh()
            'RefreshJob()
            'BindingSource.DataSource = Me.Record
        Catch ex As Exception
            Setup.Log.logError("Error importing Job.", ex)
            'Conversation.Restart()
        Finally
            Me.DialogResult = Windows.Forms.DialogResult.None
            'Me.Record.Refresh()
            'BindingSource.DataSource = Me.Record
            gvJobLines.RefreshData()
            API.Context.IsImporting = False
        End Try

    End Sub

    Public Overridable Sub DeleteRow(ByVal rowHandle As Integer)
        gvJobLines.GetDataRow(rowHandle).EndEdit()
        gvJobLines.GetDataRow(rowHandle).Delete()
    End Sub

    Protected Sub ImportJob()
        gvJobLines.CloseEditor()
        Me.TopMost = False
        'Me.Refresh()
        Dim ji As API.Job
        Dim Recalculate As Boolean
        Try

            Dim ql As New xfJobImportLookUp()

            ql.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiImportJob.Glyph)
            If ql.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ji = ql.EditValue
                Recalculate = ql.Recalculate

                Dim Use = UniSource.Helper.GUI.Dialog.YesNoDialog("Use Imported Job's Discount?", "Default Discount")
                Dim UseDiscount As Boolean = False

                If Use = Windows.Forms.DialogResult.Yes Then
                    UseDiscount = True
                End If

                If ji IsNot Nothing AndAlso ji.JobLines.Count > 0 Then
                    Dim jti As New JobImport(Me.Record, Recalculate, UseDiscount, defaultDiscountSpinEdit.EditValue)
                    jti.JobToImport = ji
                    jti.Process()
                    jti = Nothing
                End If

                If UseDiscount Then
                    defaultDiscountSpinEdit.EditValue = ji.DefaultDiscountPercent
                End If
                ji = Nothing
            End If

            ql.Close()
            ql.Dispose()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub gvJobLines_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvJobLines.InvalidRowException
        'e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        Beep()
    End Sub

    Private Sub gvJobLines_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvJobLines.ValidateRow
        If e.Row Is Nothing Then
            Exit Sub
        End If
        Dim jl As API.JobLine = TryCast(e.Row, API.JobLine)
        If jl IsNot Nothing Then
            e.Valid = jl.IsValid
        End If
        Me.Record.UpdateGPValues()
        jl = Nothing
    End Sub

    Public Sub AddAdditionalEnquiryFields()
        If AdditionalFieldsLayoutControlInternal IsNot Nothing Then
            For Each udef As Helper.ActiveRecord.Evolution.UserDefinedField In UniSource.Helper.ActiveRecord.Evolution.UserDefinedField.FindAllByType(GetType(API.Job))
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

    Private Sub BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles BindingSource.CurrentChanged
        Try
            RebindAdditionalEnquiryFields()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error binding user-defined enquiry fields.", ex)
        End Try
    End Sub

    'Private Sub gvJobLines_ShownEditor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvJobLines.ShownEditor

    '    'Filters inventory depending on Workcentere Item group
    '    Dim view As DevExpress.XtraGrid.Views.Grid.GridView
    '    view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
    '    If view.FocusedColumn.FieldName = "InventoryItem" AndAlso TypeOf view.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
    '        'Dim edit As DevExpress.XtraEditors.LookUpEdit
    '        'Dim table As DataTable
    '        'Dim row As DataRow
    '        'edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
    '        'table = CType(edit.Properties.DataSource, DataTable)
    '        'clone = New DataView(table)
    '        'row = view.GetDataRow(view.FocusedRowHandle)
    '        'clone.RowFilter = "[WorkCentreCategory] = " + row("WorkCentreCategory").ToString()
    '        'edit.Properties.DataSource = clone
    '        WorkCentreCategoryBindingSource.Filter = "[WorkCentreCategory] = " + "zz" 'row("WorkCentreCategory").ToString()
    '    End If

    'End Sub


    Private Sub gvJobLines_CustomRowCellEdit(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvJobLines.CustomRowCellEdit
        'If Me.TopMost <> True Then
        'Me.TopMost = False
        ''Me.Refresh()
        ''End If
        'If e.RowHandle < 0 Then
        '    Return
        '    MessageBox.Show("Oops")
        'End If
        'If e.Column Is colWorkCentre Then
        '    If WorkCentreBindingSource.List.Count > 0 Then
        '        Dim jobLine As API.JobLine = TryCast(gvJobLines.GetRow(e.RowHandle), API.JobLine)
        '        If jobLine IsNot Nothing Then
        '            Dim rilkp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = rlkpWorkCentre.Clone
        '            rilkp.DataSource = (From workCentre As API.WorkCentre In WorkCentreBindingSource.List Where workCentre.WorkCentreCategory Is Nothing OrElse jobLine.WorkCentreCategory Is Nothing OrElse workCentre.WorkCentreCategory.Equals(jobLine.WorkCentreCategory)).ToList
        '            If IsRecoveryRecord(jobLine) Then
        '                Dim tmpInventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where ii.Code = jobLine.WorkCentre.RecoveryServiceCode Select ii).FirstOrDefault
        '                If tmpInventoryItem IsNot Nothing AndAlso TryCast(gvJobLines.GetRow(e.RowHandle), API.JobLine).InventoryItem.ID <> tmpInventoryItem.ID Then
        '                    TryCast(gvJobLines.GetRow(e.RowHandle), API.JobLine).InventoryItem = tmpInventoryItem

        '                    'gvJobLines.RefreshRow(e.RowHandle)
        '                End If
        '            End If
        '            e.RepositoryItem = rilkp
        '        End If
        '        jobLine = Nothing
        '    End If
        'ElseIf e.Column Is colInventoryItem Then
        '    If StockItemBindingSource.List.Count > 0 Then
        '        Dim jobLine As API.JobLine = TryCast(gvJobLines.GetRow(e.RowHandle), API.JobLine)
        '        If jobLine IsNot Nothing Then
        '            Dim riglkp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = rilkpInventoryItem.Clone
        '            riglkp.DataSource = (From stockItem As UniSource.Helper.ActiveRecord.Evolution.StockItem In StockItemBindingSource.List Where stockItem.ItemGroup Is Nothing OrElse stockItem.ItemGroup.Trim = "" OrElse jobLine.WorkCentreCategory Is Nothing OrElse stockItem.ItemGroup.Equals(jobLine.WorkCentreCategory.Code)).ToList
        '            e.RepositoryItem = riglkp
        '        End If
        '        jobLine = Nothing
        '    End If
        'ElseIf e.Column Is colQuantityStock Then
        '    Dim jobLine As API.JobLine = TryCast(gvJobLines.GetRow(e.RowHandle), API.JobLine)
        '    If jobLine IsNot Nothing Then
        '        If jobLine.WorkCentre IsNot Nothing AndAlso (IIf(IsNothing(jobLine.WorkCentre.IsBuyOut), False, jobLine.WorkCentre.IsBuyOut)) = False Then
        '            If jobLine.QuantityStock > jobLine.Quantity Then
        '                jobLine.QuantityStock = jobLine.Quantity
        '            End If
        '            If jobLine.QuantityStock < jobLine.QuantityStockDrawn Then
        '                jobLine.QuantityStock = jobLine.QuantityStockDrawn
        '            End If
        '        Else
        '            If jobLine.QuantityStock <> 0 Then
        '                jobLine.QuantityStock = 0
        '            End If
        '        End If
        '    End If
        '    jobLine = Nothing
        'ElseIf e.Column Is colQuantitySupplier1 Then
        '    Dim jobLine As API.JobLine = TryCast(gvJobLines.GetRow(e.RowHandle), API.JobLine)
        '    If jobLine IsNot Nothing Then
        '        If jobLine.WorkCentre IsNot Nothing AndAlso jobLine.WorkCentre.IsBuyOut.HasValue AndAlso jobLine.WorkCentre.IsBuyOut = True Then
        '            If jobLine.QuantitySupplier1 > jobLine.Quantity Then
        '                jobLine.QuantitySupplier1 = jobLine.Quantity
        '            End If
        '            If jobLine.QuantitySupplier1 < jobLine.QuantitySupplierOrdered Then
        '                jobLine.QuantitySupplier1 = jobLine.QuantitySupplierOrdered
        '            End If
        '        Else
        '            If jobLine.QuantitySupplier1 <> 0 Then
        '                jobLine.QuantitySupplier1 = 0
        '            End If
        '        End If
        '    End If
        '    jobLine = Nothing
        'ElseIf e.Column Is colQuantity Then
        '    Dim jobLine As API.JobLine = TryCast(gvJobLines.GetRow(e.RowHandle), API.JobLine)
        '    If jobLine IsNot Nothing Then
        '        Dim tmpQuantity As Double = IIf(IsNothing(jobLine.QuantitySupplier1), 0, jobLine.QuantitySupplier1) + IIf(IsNothing(jobLine.QuantityStock), 0, jobLine.QuantityStock)
        '        Dim tmpQuantityDrawn As Double = IIf(IsNothing(jobLine.QuantitySupplierOrdered), 0, jobLine.QuantitySupplierOrdered) + IIf(IsNothing(jobLine.QuantityStockDrawn), 0, jobLine.QuantityStockDrawn)
        '        If e.CellValue.ToString <> jobLine.Quantity Then
        '            If jobLine.Quantity < tmpQuantity Then
        '                jobLine.Quantity = tmpQuantity
        '            End If
        '            If jobLine.Quantity < tmpQuantityDrawn Then
        '                jobLine.Quantity = tmpQuantityDrawn
        '            End If
        '        End If
        '    End If
        '    jobLine = Nothing
        'End If
    End Sub

    Private Sub bsiReports_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bsiReports.ItemClick
        If bsiReports.ItemLinks.Count <= 0 Then
            Try
                AddReports()
            Catch ex As Exception
                Setup.Log.logError("Error generating Report menus.", ex)
            End Try
        End If
    End Sub

    Private Sub bbiImportQuote_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImportQuote.ItemClick
        Try
            'SaveRecord()
            API.Context.IsImporting = True
            gvJobLines.CloseEditor()
            Me.TopMost = False
            Me.Refresh()
            ImportQuote()
            'SaveRecord()
            'Me.DialogResult = Windows.Forms.DialogResult.None
            'BindingSource.DataSource = Me.Record
        Catch ex As Exception
            Setup.Log.logError("Error importing Quote.", ex)
            'Conversation.Restart()
        Finally
            Me.DialogResult = Windows.Forms.DialogResult.None
            'Me.Record.Refresh()
            'BindingSource.DataSource = Me.Record
            gvJobLines.RefreshData()
            API.Context.IsImporting = False
        End Try

    End Sub


    Protected Sub ImportQuote()
        gvJobLines.CloseEditor()
        Me.TopMost = False
        Me.Refresh()
        Dim ji As API.Job
        Dim Recalculate As Boolean = True
        Try

            Dim ql As New xfQuoteImportLookUp
            ql.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiImportQuote.Glyph)

            If ql.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ji = ql.EditValue
                Recalculate = ql.Recalculate

                Dim Use = UniSource.Helper.GUI.Dialog.YesNoDialog("Use Imported Quote's Discount?", "Default Discount")
                Dim UseDiscount As Boolean = False

                If Use = Windows.Forms.DialogResult.Yes Then
                    UseDiscount = True
                End If

                If ji IsNot Nothing Then
                    Dim jti As New QuoteImport(Me.Record, Recalculate, UseDiscount, defaultDiscountSpinEdit.EditValue)
                    jti.QuoteToImport = ji
                    jti.Process()
                    jti = Nothing

                End If


                If UseDiscount Then
                    defaultDiscountSpinEdit.EditValue = ji.DefaultDiscountPercent
                End If
                ji = Nothing
            End If
            ql.Close()

        Catch ex As Exception
            'Setup.Log.logError("Error importing Quote. Validation Failed.", ex)
            'Conversation.Restart()
            'Return
        End Try


    End Sub

    Protected Overrides Sub SaveClick(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim IsCheckOutValid As Boolean = False
        Dim bc As New UniSource.Helper.ActiveRecord.Checkout
        If bc.AlreadyCheckedOut(Me.CheckoutGuid) Then
            IsCheckOutValid = True
        End If
        Try

            Dim rowNo As Integer = 0
            Do While rowNo < gvJobLines.RowCount
                Dim jl As API.JobLine = TryCast(gvJobLines.GetRow(rowNo), API.JobLine)
                If jl IsNot Nothing Then
                    'gvJobLines_ValidateRow(sender, e)
                    If jl.IsValid = False OrElse (jl.InventoryItem IsNot Nothing AndAlso jl.InventoryItem.ItemActive = False) Then
                        'gvJobLines.SetColumnError(colInventoryItem, "Error")
                        If jl.Job.State = API.JobState.Quote Then
                            Setup.Log.logError(String.Format("Some rows did not pass the validation test. Quote :{0}. Line Description : {1}", jl.Job.QuoteNumber, jl.Description1))
                        Else
                            Setup.Log.logError(String.Format("Some rows did not pass the validation test. Job :{0}. Line Description : {1}", jl.Job.JobNumber, jl.Description1))
                        End If
                        'gvJobLines.SetColumnError(colInventoryItem, "Error")

                        Me.DialogResult = Windows.Forms.DialogResult.None
                        Return
                    End If
                End If
                rowNo += 1
            Loop
            If Me.Record.QuoteAgent Is Nothing Then
                Me.Record.QuoteAgentID = API.Context.Agent.ID
                Me.Record.QuoteDate = Now
            End If
            MyBase.SaveClick(sender, e)
        Catch ex As Exception
            If IsCheckOutValid = True Then
                If Not (bc.AlreadyCheckedOut(Me.CheckoutGuid)) Then
                    bc.AddCheckOut("Job", Record.ID)
                    Me.CheckoutGuid = bc.Checkout.GUID
                End If
            End If
        End Try
        If Me.DialogResult = Windows.Forms.DialogResult.None Then
            If IsCheckOutValid = True Then
                If Not (bc.AlreadyCheckedOut(Me.CheckoutGuid)) Then
                    bc.AddCheckOut("Job", Record.ID)
                    Me.CheckoutGuid = bc.Checkout.GUID
                End If
            End If
        End If
    End Sub


    Protected Overrides Sub DestroyHandle()
        'DataBindings.Clear()
        'JobLineListBindingSource.Clear()
        'PartBindingSource.Clear()
        'WorkCentreBindingSource.Clear()
        'SupplyScopeBindingSource.Clear()
        'VendorBindingSource.Clear()
        'VendorBindingSource.Clear()
        'StockItemBindingSource.Clear()
        'WorkCentreCategoryBindingSource.Clear()


        'JobLineListBindingSource.Dispose()
        'PartBindingSource.Dispose()
        'WorkCentreBindingSource.Dispose()
        'SupplyScopeBindingSource.Dispose()
        'VendorBindingSource.Dispose()
        'VendorBindingSource.Dispose()
        'StockItemBindingSource.Dispose()
        'WorkCentreCategoryBindingSource.Dispose()
        'MyBase.DestroyHandle()
        'Me.Dispose()
        'TODO: Find Proper why of GC
        'System.GC.GetTotalMemory(True)
    End Sub

    Private Sub gvJobLines_ShowingEditor(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gvJobLines.ShowingEditor
        Dim selectedline As API.JobLine
        Try
            If gvJobLines.GetFocusedRow() Is Nothing Then
                Exit Sub
            End If
            selectedline = CType(gvJobLines.GetFocusedRow(), API.JobLine)
            If selectedline Is Nothing Then
                Exit Sub

            End If
            If selectedline.WorkCentre IsNot Nothing Then
                If selectedline.WorkCentre.IsBuyOut = True AndAlso selectedline.ISPOGenerated Then
                    If gvJobLines.FocusedColumn Is colInventoryItem OrElse
                        gvJobLines.FocusedColumn Is colWorkCentre OrElse
                        gvJobLines.FocusedColumn Is colDescription1 OrElse
                        gvJobLines.FocusedColumn Is colDescription2 OrElse
                        gvJobLines.FocusedColumn Is colWorkCentreCategory OrElse
                    gvJobLines.FocusedColumn Is colSupplier1 OrElse
                    gvJobLines.FocusedColumn Is colSupplier2 Then
                        e.Cancel = True
                    End If
                End If

                If (selectedline.WorkCentre.IsBuyOut = False OrElse selectedline.WorkCentre.IsBuyOut Is Nothing) AndAlso selectedline.ISRlGenerated = True Then
                    If gvJobLines.FocusedColumn Is colInventoryItem OrElse
                        gvJobLines.FocusedColumn Is colDescription1 OrElse
                         gvJobLines.FocusedColumn Is colDescription2 OrElse
                         gvJobLines.FocusedColumn Is colWorkCentreCategory OrElse
                  gvJobLines.FocusedColumn Is colWorkCentre Then

                        e.Cancel = True
                    End If

                End If
            End If
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error Editing  line", ex, True)
        Finally
            selectedline = Nothing
        End Try


    End Sub

    Private Sub gvJobLines_EmbeddedNavigator_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcLobLines.EmbeddedNavigator.ButtonClick
        Dim selectedline As API.JobLine = CType(gvJobLines.GetFocusedRow(), API.JobLine)
        If selectedline Is Nothing Then
            Exit Sub
        End If
        Try

            If selectedline.WorkCentre.IsBuyOut = True And selectedline.ISPOGenerated Then
                If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
                    e.Handled = True
                End If
            End If
            If (selectedline.WorkCentre.IsBuyOut = False Or selectedline.WorkCentre.IsBuyOut Is Nothing) And selectedline.ISRlGenerated Then
                If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            Setup.Log.logError("Error in Job line", ex)
        Finally
            selectedline = Nothing
        End Try

    End Sub
    Private Sub xaeJobQuote_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        If IsLookUpDataLoaded = False Then
            IsLookUpDataLoaded = True
            LoadLookUpData()
        End If
        Me.TopMost = False
    End Sub

    Private Sub bbiUpdateLinesDiscount_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUpdateLinesDiscount.ItemClick

        Record.UpdateAllDiscountLines()
    End Sub

    Private Sub btnCreateRequisition_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateRequisition.ItemClick
        Dim rowNo As Integer = 0
        Dim rowNo2 As Integer = 0
        Dim SelectedRowNumber As Integer = 0
        Dim JobHeader As New API.Job
        'Dim LoopJoblines As New List(Of API.JobLine)
        Dim reqnumber As String = ""
        Dim ValidLines As Integer = 0
        'get next - without increment

        If UniSource.Helper.GUI.Dialog.YesNoDialog("All Data will be Saved." & vbCrLf & "Click Yes to Continue" & vbCrLf & "Click No to return to Quote Screen", "Create Requisition") = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim reserveMessage As String = ""
        Dim dupStockItem As Integer = 0
        Do While rowNo < gvJobLines.RowCount

            Dim jl As API.JobLine = TryCast(gvJobLines.GetRow(rowNo), API.JobLine)

            If jl IsNot Nothing AndAlso (jl.IsRequisitionedGenerated Is Nothing OrElse jl.IsRequisitionedGenerated = False) Then

                'If jl IsNot Nothing Then
                ' SelectedRowNumber = SelectedRowNumber + 1
                ' If jl.IsRequisitionedGenerated = True Then ' we dont mix new and previously printed lines- either new or copy
                '     Setup.Log.logError("Error: Only New Lines can be selected.")
                '      Exit Sub
                '   End If
                'End If
                'If (jl.WorkCentre.GLExpense = False Or jl.WorkCentre.GLExpense Is Nothing) And (jl.WorkCentre.APExpense = False Or jl.WorkCentre.APExpense Is Nothing) Then
                '    If jl.InventoryItem IsNot Nothing AndAlso IsDBNull(jl.InventoryItem) = False Then
                '        Dim StockItem As Pastel.Evolution.InventoryItem = New Pastel.Evolution.InventoryItem(Convert.ToInt32(jl.InventoryItemID))
                '        If StockItem.IsWarehouseTracked = True Then
                '            Dim freestock = StockItem.WarehouseContexts(Convert.ToInt32(jl.WarehouseID)).QtyOnHand - StockItem.WarehouseContexts(Convert.ToInt32(jl.WarehouseID)).QtyWIP
                '            If jl.Quantity > freestock Then
                '                'Setup.Log.logError("Error: Insufficient Warehouse quantity available, Requisition cannot be created.")
                '                reserveMessage += jl.InventoryItem.Code + "Error: Insufficient Warehouse quantity available, Requisition cannot be created."
                '                Exit Sub
                '            End If
                '        End If
                '    End If
                'End If
                If (jl.WorkCentre.GLExpense = False Or jl.WorkCentre.GLExpense Is Nothing) And (jl.WorkCentre.APExpense = False Or jl.WorkCentre.APExpense Is Nothing) Then
                    If jl.InventoryItem IsNot Nothing AndAlso IsDBNull(jl.InventoryItem) = False Then
                        Dim jobLineCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobLine)()
                        'jobLineCrit.Add(NHibernate.Criterion.Expression.Sql("JobID In (Select t1.id From ussSFJob t1 with(nolock) Where t1.IsApproved = 1 And (t1.IsStockDrawn Is Null Or t1.IsStockDrawn = 0) And t1.StateID = 0 And t1.IsProcured = 1) And (QuantityStock - QuantityStockDrawn) > 0  And InventoryItemID = " & jl.InventoryItemID.Value.ToString() & " And JobID != " & jl.Job.ID.ToString()))
                        jobLineCrit.Add(NHibernate.Criterion.Expression.Sql("Requisition_Number Is not Null And Requisition_Number <> '' AND JobID In (Select t1.id From ussSFJob t1 with(nolock) Where t1.IsApproved = 1 And t1.StateID = 0 And t1.IsProcured = 1) And (QuantityStock - QuantityStockDrawn) > 0  And InventoryItemID = " & jl.InventoryItemID.Value.ToString() & " And JobID != " & jl.Job.ID.ToString()))
                        If jl.InventoryItem.WhseItem Then
                            If jl.WarehouseID Is Nothing OrElse jl.WarehouseID <= 0 Then
                                Dim warehouseCrit = NHibernate.Criterion.DetachedCriteria.For(Of UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster)()
                                warehouseCrit.Add(NHibernate.Criterion.Expression.Sql("DefaultWhse = 1"))
                                Dim warehouseMaster As UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster = UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster.FindAll(warehouseCrit).FirstOrDefault()
                                If warehouseMaster IsNot Nothing Then
                                    jl.WarehouseID = warehouseMaster.ID
                                End If
                            End If
                            jobLineCrit.Add(NHibernate.Criterion.Expression.Sql("WarehouseID = " & jl.WarehouseID))
                        End If
                        Dim jobLineListStock As List(Of API.JobLine) = API.JobLine.FindAll(jobLineCrit).ToList()
                        Dim jobLinesQty As Double = jobLineListStock.Sum(Function(x) x.Quantity.Value - x.QuantityStockDrawn.Value)

                        'If jl.InventoryItem.ID = dupStockItem Then
                        Dim dupStock As Boolean = False
                        Dim allLineStockItemQty As Integer = 0
                        Do While rowNo2 < gvJobLines.RowCount - 1
                            Dim jlTwo As API.JobLine = TryCast(gvJobLines.GetRow(rowNo2), API.JobLine)
                            If (jl.InventoryItem IsNot Nothing AndAlso IsDBNull(jl.InventoryItem) = False And jlTwo.InventoryItem IsNot Nothing AndAlso IsDBNull(jlTwo.InventoryItem) = False) Then
                                If jl.InventoryItem.ID = jlTwo.InventoryItem.ID Then
                                    allLineStockItemQty = allLineStockItemQty + (jlTwo.Quantity - jlTwo.QuantityStockDrawn)
                                    dupStock = True
                                End If
                            End If
                            rowNo2 += 1
                        Loop
                        If dupStock = True Then
                            If (jl.AvailibleERPQty - jobLinesQty - allLineStockItemQty) < 0 Then
                                reserveMessage += jl.InventoryItem.Code + " Qty required " + (allLineStockItemQty).ToString() + ", Insufficient qty available, " + jl.OnHandERPQty.ToString() + " On Hand, " + (jobLinesQty + jl.AllocatedERPQty).ToString() + " Allocated Stock, Total Free " + (jl.AvailibleERPQty - jobLinesQty).ToString() + vbCrLf
                            End If
                        Else
                            If (jl.AvailibleERPQty - jobLinesQty - (jl.Quantity - jl.QuantityStockDrawn)) < 0 Then
                                reserveMessage += jl.InventoryItem.Code + " Qty required " + (jl.Quantity - jl.QuantityStockDrawn).ToString() + ", Insufficient qty available, " + jl.OnHandERPQty.ToString() + " On Hand, " + (jobLinesQty + jl.AllocatedERPQty).ToString() + " Allocated Stock, Total Free " + (jl.AvailibleERPQty - jobLinesQty).ToString() + vbCrLf
                            End If
                        End If

                    End If
                End If

            End If
            'If rowNo < gvJobLines.RowCount - 1 Then
            '    If jl.InventoryItem IsNot Nothing AndAlso IsDBNull(jl.InventoryItem) = False Then
            '        dupStockItem = jl.InventoryItem.ID
            '    End If
            'End If
            rowNo += 1

        Loop

        If reserveMessage <> "" Then
            UniSource.Helper.GUI.Dialog.OKDialog(reserveMessage)
            Exit Sub
        End If
        rowNo = 0

        Do While rowNo < gvJobLines.RowCount
            Dim jl As API.JobLine = TryCast(gvJobLines.GetRow(rowNo), API.JobLine)
            If jl IsNot Nothing AndAlso (jl.IsRequisitionedGenerated Is Nothing OrElse jl.IsRequisitionedGenerated = False) Then
                SelectedRowNumber = SelectedRowNumber + 1
                JobHeader = jl.Job
                If (jl.WorkCentre.GLExpense = False Or jl.WorkCentre.GLExpense Is Nothing) And (jl.WorkCentre.APExpense = False Or jl.WorkCentre.APExpense Is Nothing) Then
                    If jl.InventoryItem IsNot Nothing AndAlso IsDBNull(jl.InventoryItem) = False Then
                        'Dim StockItem As Pastel.Evolution.InventoryItem = New Pastel.Evolution.InventoryItem(Convert.ToInt32(jl.InventoryItemID))
                        'If StockItem.IsWarehouseTracked = True Then
                        '    Dim freestock = StockItem.WarehouseContexts(Convert.ToInt32(jl.WarehouseID)).QtyOnHand - StockItem.WarehouseContexts(Convert.ToInt32(jl.WarehouseID)).QtyWIP
                        '    If jl.Quantity > freestock Then
                        '        Setup.Log.logError("Error: Insufficient Warehouse quantity available, Requisition cannot be created.")
                        '        'Exit Sub
                        '    End If
                        'End If

                        If jl.InventoryItem.ServiceItem = False Then
                            jl.IsRequisitionedGenerated = True
                            jl.IsRequisitionReportSelected = True

                            ValidLines = ValidLines + 1
                            If reqnumber = "" Then
                                reqnumber = Defaults.Defaults.GetNextRequisitionNumber(JobHeader)
                            End If
                            jl.Requisition_Number = reqnumber
                            jl.PreRequisitionPrintedAgentID = API.Context.Agent.ID
                        Else
                            jl.IsRequisitionedGenerated = True
                        End If
                    End If
                Else
                    jl.IsRequisitionedGenerated = True
                End If

            End If
            rowNo += 1
        Loop

        If SelectedRowNumber = 0 Then ' just to make sure the user indeed selected a row
            UniSource.Helper.GUI.Dialog.OKDialog("No new rows to process")
            Exit Sub
        End If

        If ValidLines = 0 Then
            Exit Sub
        End If

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                JobHeader.SaveAndFlush()
            End Using
        Catch ex As Exception

        End Try

        Dim xrPR As New ShopFloor.Report.xrDoscoPrerequisition
        JobHeader.RequisitionNumber = Defaults.Defaults.GetNextRequisitionNumberAndIncrement(JobHeader)
        JobHeader.IsProcured = True
        JobHeader.PreRequisitionPrintedAgentID = API.Context.Agent.ID
        xrPR.BindingSource1.DataSource = JobHeader
        xrPR.ShowPreview()

       
        'btSave.PerformClick()

    End Sub

    Private Sub btnRePrintRequisition_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRePrintRequisition.ItemClick

        Dim rowNo As Integer = 0

        Dim SelectedRowNumber As Integer = 0
        Dim JobHeader As New API.Job
        Dim LoopJoblines As New List(Of API.JobLine)
        Dim ValidLines As Integer = 0

        Do While rowNo < gvJobLines.RowCount
            If gvJobLines.IsRowSelected(rowNo) Then

                Dim jl As API.JobLine = TryCast(gvJobLines.GetRow(rowNo), API.JobLine)
                '    Try

                '   If jl.IsRequisitionReportSelected Then
                If jl IsNot Nothing Then
                    If jl.IsRequisitionedGenerated = False Or jl.IsRequisitionedGenerated Is Nothing Then ' we dont mix new and previously printed lines- either new or copy
                        Setup.Log.logError("Error: Only Previously Printed Lines can be selected.")
                        Exit Sub

                    End If
                    JobHeader = jl.Job
                    SelectedRowNumber = SelectedRowNumber + 1

                    If (jl.WorkCentre.GLExpense = False Or jl.WorkCentre.GLExpense Is Nothing) And (jl.WorkCentre.APExpense = False Or jl.WorkCentre.APExpense Is Nothing) Then
                        If jl.InventoryItem IsNot Nothing AndAlso IsDBNull(jl.InventoryItem) = False Then
                            If jl.InventoryItem.ServiceItem = False Then
                                jl.IsRequisitionedGenerated = True
                                jl.IsRequisitionReportSelected = True
                                ValidLines = ValidLines + 1
                                'LoopJoblines.Add(jl)
                            End If
                        End If
                    End If
                End If
                ' End If

            Else
                Try
                    Dim jl As API.JobLine = TryCast(gvJobLines.GetRow(rowNo), API.JobLine)
                    jl.IsRequisitionReportSelected = False
                Catch ex As Exception

                End Try
            End If
            '                Catch ex As Exception

            'End Try
            rowNo += 1
        Loop

        If SelectedRowNumber = 0 And LoopJoblines.Count <= 0 Then ' just to make sure the user indeed selected a row
            Exit Sub
        End If

        If ValidLines = 0 Then
            Exit Sub
        End If

        'Here you will split the report into one that states copy and the one that does not
        Dim jfc As API.JobFunctionControl
        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.JobFunctionControl)()
        crit.Add(NHibernate.Criterion.Expression.Eq("JobFunctionID", CInt(API.JobFunction.PreRequisitionRePrint)))
        jfc = API.JobFunctionControl.FindFirst(crit)
        If jfc IsNot Nothing Then
            If Not String.IsNullOrEmpty(jfc.Password) Then
                Dim password = UniSource.Helper.GUI.Dialog.PromptPasswordDialog("Password", "Password")

                If password Is Nothing OrElse Not password = jfc.Password Then
                    If password IsNot Nothing Then
                        Setup.Log.logError("Incorrect password.")
                    End If

                    Exit Sub
                End If
            End If
        End If

        Dim xrPR As New ShopFloor.Report.xrDoscoPrerequisitionReprint
        JobHeader.IsProcured = True
        JobHeader.PreRequisitionPrintedAgentID = API.Context.Agent.ID
        '  JobHeader.SaveAndFlush()
        Me.TopMost = False
        xrPR.BindingSource1.DataSource = JobHeader
        xrPR.ShowPreview()




        'btSave.PerformClick()
        'Me.Close()
    End Sub



    Private Sub bbiCancelSelectedLines_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancelSelectedLines.ItemClick



        Dim JobLineList As List(Of API.JobLine) = New List(Of API.JobLine)
        Dim JobLineProcessedList As List(Of API.JobLine) = New List(Of API.JobLine)

        If gvJobLines.SelectedRowsCount <= 0 Then
            UniSource.Helper.GUI.Dialog.OKDialog("Please select lines", "Cancel Selected Lines")
        Else
            For Each i As Integer In gvJobLines.GetSelectedRows
                If If(CType(gvJobLines.GetRow(i), API.JobLine).QuantityStockDrawn, 0) <= 0 AndAlso If(CType(gvJobLines.GetRow(i), API.JobLine).QuantitySupplierOrdered, 0) <= 0 AndAlso If(CType(gvJobLines.GetRow(i), API.JobLine).QuantitySupplier1, 0) <= 0 AndAlso If(CType(gvJobLines.GetRow(i), API.JobLine).QuantitySupplier2, 0) <= 0 Then
                    JobLineList.Add(CType(gvJobLines.GetRow(i), API.JobLine))
                Else
                    JobLineProcessedList.Add(CType(gvJobLines.GetRow(i), API.JobLine))
                End If
            Next
            Dim CancelLines As xfCancelLines = New xfCancelLines(JobLineList, JobLineProcessedList)
            Me.TopMost = False
            CancelLines.ShowDialog()
            If CancelLines.DialogResult = Windows.Forms.DialogResult.OK Then
                If JobLineList.Count > 0 Then
                    Dim totalQtyCancel As Double = 0
                    Dim amountCancel As Double = 0
                    Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                        'For Each i As Integer In gvJobLines.GetSelectedRows
                        For Each jobLine As API.JobLine In JobLineList
                            totalQtyCancel += jobLine.Quantity
                            totalQtyCancel += jobLine.TotalPrice
                            jobLine.SaveAndFlush()
                        Next
                    End Using

                    Dim log As New API.Audit
                    log.Date = Now
                    log.Agent = API.Context.Agent
                    log.Description = String.Format("There was {0} lines canceled, Qty {1}, Amount {2}", gvJobLines.SelectedRowsCount, totalQtyCancel, amountCancel)
                    log.Type = "CancelLines"
                    log.OldValue = ""
                    log.NewValue = CancelLines.CancelledReasonTextEdit.EditValue
                    log.idJob = Me.Record.ID
                    log.SaveAndFlush()

                    gvJobLines.DeleteSelectedRows()
                    Me.Refresh()
                    gvJobLines.RefreshData()
                End If
            End If
            End If
    End Sub
End Class

Public Class xaegJobQuote
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.Job)
End Class
