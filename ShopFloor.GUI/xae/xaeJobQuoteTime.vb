Imports System.Globalization
Imports DevExpress.XtraEditors.Controls

Public Class xaeJobQuoteTime
    Inherits xaegJobQuoteTime

    'Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

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

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub
    Private Sub xaeJobQuoteTime_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'JobLineBindingSource.DataSource = API.JobLine.FindAllByProperty("Job", Me.Record)
        Try

            Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(InventoryItemLookUpEdit, AddressOf LoadStockItems)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        End Try

        Try

            Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.People)(EmployeeRepositoryItemLookUpEdit, AddressOf LoadEmployees)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        End Try

        'Try
        '    Dim wcclm As New Helper.GUI.LookupBackgroundLoader(Of API.CustomerWorkCentreCategory)(WorkCentreCategoryItemLookUpEdit, AddressOf Me.LoadWorkCentreCategories)
        'Catch ex As Exception
        '    Setup.Log.logError("Error setting lookup maintenance for Work Centre Categories.", ex)
        'End Try

        Try
            Dim wclm As New Helper.GUI.LookupBackgroundLoader(Of API.CustomerJobClass)(WorkCentreItemLookUpEdit, AddressOf LoadWorkCentres)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centres.", ex)
        End Try

        Try
            LoadEnums()
        Catch ex As Exception
            Setup.Log.logError("Error loading Enums.", ex)
        End Try
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(False, 400, Me)
        Me.Refresh()
    End Sub

    'Private Function LoadWorkCentreCategories() As IEnumerable(Of API.CustomerWorkCentreCategory)

    '    Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.CustomerWorkCentreCategory)()
    '    crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("Customer", Me.Record.TimeCustomer), NHibernate.Criterion.Expression.IsNull("Customer")))
    '    Return API.CustomerWorkCentreCategory.FindAll(crit)
    'End Function
    Private Function LoadWorkCentres() As IEnumerable(Of API.CustomerJobClass)
        Return API.CustomerJobClass.FindAll


    End Function

    Private Function LoadStockItems() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)
        Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll
    End Function
    Private Function LoadEmployees() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.People)
        Return UniSource.Helper.ActiveRecord.Evolution.People.FindAll
    End Function
    Private Sub LoadEnums()
        RateTypeRepositoryItemLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.RateType))
        InvoiceRunRepositoryItemLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.OptionInvoiceRun))
        PaymentRunRepositoryItemLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.OptionInvoiceRun))
    End Sub


    Private Sub bbiAddLine_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAddLine.ItemClick
        gvJoblines.CloseEditor()
        Me.TopMost = False
        Me.Refresh()
        Dim xaejl As New xaeTimeEntry With {.Record = New API.JobLineTime With {.JobLineDate = Now, .StartDate = Now, .EndDate = Now, .Job = Record}}
        'xaejl.PerformBatchCheckout = True
        'xaejl.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiAddLine.Glyph)
        Select Case Record.State
            Case API.JobState.Active
                xaejl.Text = "Job Line"
            Case API.JobState.Quote
                xaejl.Text = "Quote Line"
            Case Else
                'xaejl.DataLayoutControl1.Enabled = False
        End Select
        If xaejl.ShowDialog = DialogResult.OK Then
            Me.Record.JobLineTimes.Add(xaejl.Record)
            BindingSource.DataSource = Me.Record
            'SaveRecord()
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
        Me.Record.UpdateGPValues()
        'Refresh()
        'BindingSource.DataSource = Me.Record

    End Sub

    Private Sub bbiEditLine_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditLine.ItemClick
        'Application.DoEvents()
        gvJoblines.CloseEditor()
        Me.TopMost = False
        Me.Refresh()
        'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
        'SaveRecord()
        Me.DialogResult = Windows.Forms.DialogResult.None
        'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
        '    TryCast(gvJobLines.GetFocusedRow, API.JobLine).SaveAndFlush()
        'End Using
        Dim jl As API.JobLineTime = gvJoblines.GetFocusedRow
        If jl IsNot Nothing AndAlso jl.ID > 0 Then
            Dim xaejl As New xaeTimeEntry With {.Conversation = Me.Conversation, .IgnoreRecordReload = True, .Record = jl}
            'Dim xaejl As New xaeJobLineLite With {.Record = New API.JobLine With {.ActualDuration .JobLineDate = Now, .Job = Record, .WorkCentreCategory = Record.WorkCentreCategory}}
            'xaejl.OverideRecord = jl


            xaejl.PerformBatchCheckout = True
            'xaejl.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiEditLine.Glyph)
            Select Case Record.State
                Case API.JobState.Active
                    xaejl.Text = "Job Line"
                Case API.JobState.Quote
                    xaejl.Text = "Quote Line"
                Case Else

            End Select
            gvJoblines.CloseEditor()
            xaejl.ShowDialog()
            'SaveRecord()
            ' set DialogResult to none so that form does not close on save
            Me.DialogResult = Windows.Forms.DialogResult.None
            'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            'BindingSource.DataMember = Me.Record.JobLines
            'TryCast(gvJoblines.GetFocusedRow, API.JobLine).Refresh()

            'Me.JobLineListBindingSource.DataSource = API.JobLineTime.FindAllByProperty("Job", Me.Record)

            'gvJoblines.RefreshData()
            Me.DialogResult = Windows.Forms.DialogResult.None
            TryCast(gvJoblines.GetFocusedRow, API.JobLineTime).Refresh()
            xaejl.Close()
            Me.DialogResult = Windows.Forms.DialogResult.None
            'End Using
            'Refresh()
            'RefreshJob()
            'Application.DoEvents()

            'SaveRecord()


            'BindingSource.DataSource = Me.Record
            'Refresh()
        End If
        'End Using

        'Me.Record.UpdateGPValues()
    End Sub

    Private Sub SaveJob()
        gvJoblines.CloseEditor()
        Me.Record.UpdateGPValues()
        If Me.Record.JobGPCheck() = True Then
            Dim log As New API.Audit
            log.Date = Now
            log.Agent = API.Context.Agent
            'log.Description = String.Format("The suggested GP was overridden. Suggested GP {0}%, Current GP {1}%", Me.Record.ExpectedGP * 100, Me.Record.CurrentGP * 100)
            'log.Type = "CurrentGP"

            log.NewValue = Me.Record.CurrentGP
            log.idJob = Me.Record.ID
            log.SaveAndFlush()

        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
            Return
        End If


        Try
            Dim bc As New UniSource.Helper.ActiveRecord.Checkout
            If Not bc.AlreadyCheckedOut(Me.CheckoutGuid) Then
                Throw New Exception("You have lost your checkout authority, your changes cannot be saved.")
            End If
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error testing checkout authority.", ex)
            Me.Conversation.Restart()
            Me.DialogResult = Windows.Forms.DialogResult.None
            Me.Close()
            Exit Sub
        End Try

        gvJoblines.CloseEditor()

        If gvJoblines.HasColumnErrors Then
            Setup.Log.logError("One of the grids contains errors, please correct before saving the Job.")
            Exit Sub
        End If

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                Conversation.Dispose()
                Conversation.Restart()
                Me.Record.SaveAndFlush()
            End Using

        Catch ex As Exception
            Conversation.Restart()
            Setup.Log.logError("Error saving Job.", ex)
        End Try
    End Sub

    Private Sub bbiSave_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        gvJoblines.CloseEditor()
        SaveRecord()
        Me.DialogResult = Windows.Forms.DialogResult.None
    End Sub



    Private Sub GvJobline_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcJobline.EmbeddedNavigator.ButtonClick

        Dim selectedline As API.JobLineTime = CType(gvJoblines.GetFocusedRow(), API.JobLineTime)
        If selectedline Is Nothing Then
            Exit Sub
        End If
        Try

            If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
                selectedline.Deleted = True
                gvJoblines.CloseEditor()
                TryCast(gvJoblines.GetFocusedRow, API.JobLineTime).SaveAndFlush()
                'Me.DialogResult = Windows.Forms.DialogResult.None
                e.Handled = True
            End If

        Catch ex As Exception
            Setup.Log.logError("Error in deleting job line", ex)
        End Try

    End Sub

    Private Sub bbiCopyline_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCopyline.ItemClick
        Try

            Dim newTime As New API.JobLineTime 'new  time will be created

            Dim selectedTime = CType(gvJoblines.GetFocusedRow, API.JobLineTime) 'selected job
            If selectedTime Is Nothing Then
                UniSource.Helper.GUI.Dialog.OKDialog("Please Select Line To be Copied", "Time Line To be Copied")
                Exit Sub
            End If

            newTime = newTime.GetTimeCopy(selectedTime) 'new job
            Dim xae As New xaeTimeEntry With {.Record = newTime}

            If xae.ShowDialog = DialogResult.OK Then
                Me.Record.JobLineTimes.Add(xae.Record)
                BindingSource.DataSource = Me.Record
                'SaveRecord()
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If

        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error Copying ", ex, True)

        End Try
    End Sub


    Private Sub bbidelete_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbidelete.ItemClick
        Try
            Dim selectedline As API.JobLineTime = CType(gvJoblines.GetFocusedRow(), API.JobLineTime)
            If selectedline Is Nothing Then
                UniSource.Helper.GUI.Dialog.OKDialog("Please Select Line To be Deleted", "Time Line To be Deleted")
                Exit Sub
            End If
            If UniSource.Helper.GUI.Dialog.YesNoDialog("Are you sure you want to delete this record?") = Windows.Forms.DialogResult.Yes Then

                Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)

                    'Me.JobLineListBindingSource.Remove(CType(gvJoblines.GetFocusedRow, API.JobLine))
                    selectedline.Deleted = True
                    gvJoblines.CloseEditor()
                    TryCast(gvJoblines.GetFocusedRow, API.JobLineTime).SaveAndFlush()
                End Using
            End If
        Catch ex As Exception
            Logging.Log.Log.logError("Error deleting record.", ex)
        Finally
            Conversation.Restart()
        End Try
        'RefreshJob()

    End Sub

    Protected Overrides Sub DestroyHandle()
        'DataBindings.Clear()
        JobLineListBindingSource.Clear()
        PeopleBindingSource.Clear()
        WorkCentreBindingSource.Clear()
        InventoryItemBindingSource.Clear()
        WorkCentreCategoryBindingSource.Clear()


        JobLineListBindingSource.Dispose()
        PeopleBindingSource.Dispose()
        WorkCentreBindingSource.Dispose()
        InventoryItemBindingSource.Dispose()
        WorkCentreCategoryBindingSource.Dispose()
        MyBase.DestroyHandle()
        Me.Dispose()
        'TODO: Find Proper why of GC
        'System.GC.GetTotalMemory(True)
    End Sub
    Private Sub gvJobLines_CustomRowCellEdit(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvJoblines.CustomRowCellEdit
        'If Me.TopMost <> True Then
        'Me.TopMost = False
        'Me.Refresh()
        'End If
        If e.Column Is colWorkCentre Then
            If WorkCentreBindingSource.List.Count > 0 Then
                Dim jobLine As API.JobLineTime = TryCast(gvJoblines.GetRow(e.RowHandle), API.JobLineTime)
                If jobLine IsNot Nothing AndAlso jobLine.CustomerWorkCentreCategory IsNot Nothing Then
                    Dim rilkp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = WorkCentreItemLookUpEdit.Clone
                    If jobLine.CustomerWorkCentreCategory IsNot Nothing Then
                        ' Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.CustomerJobClass)()
                        If jobLine.Employee Is Nothing Then
                            'ho
                        End If
                        Dim eQualificalionList = (From employeequalification In jobLine.Employee.QualificationLineList Select employeequalification.InventoryItemID).ToList
                        'crit.Add(NHibernate.Criterion.Expression.Or(NHibernate.Criterion.Expression.Eq("CustomerWorkCentreCategory", jobLine.CustomerWorkCentreCategory), NHibernate.Criterion.Expression.IsNull("CustomerWorkCentreCategory")))

                        'rilkp.DataSource = (From workCentre As API.CustomerJobClass In API.CustomerJobClass.FindAll Where workCentre.CustomerWorkCentreCategory IsNot Nothing OrElse jobLine.CustomerWorkCentreCategory IsNot Nothing OrElse workCentre.CustomerWorkCentreCategory.ID = jobLine.CustomerWorkCentreCategory.ID).ToList
                        'rilkp.DataSource = API.CustomerJobClass.FindAll(crit).Where(Function(x) eQualificalionList.Contains(x.InventoryItemID))
                        Dim CustomerWorkCentreCategoryList = (From CustomerWorkCentreCategory In Record.CustomerTime.CustomerWorkCentreCategoryLineList Where CustomerWorkCentreCategory = jobLine.CustomerWorkCentreCategory AndAlso CustomerWorkCentreCategory.JobclassLineList.Where(Function(y) eQualificalionList.Contains(y.InventoryItemID)).Count > 0 Select CustomerWorkCentreCategory)
                        Dim CustomerJobClassList As List(Of API.CustomerJobClass) = New List(Of API.CustomerJobClass)
                        For Each CustomerWorkCentreCategory In CustomerWorkCentreCategoryList
                            CustomerJobClassList.AddRange(CustomerWorkCentreCategory.CustomerJobClasses.Where(Function(y) eQualificalionList.Contains(y.InventoryItemID)))
                        Next

                        rilkp.DataSource = CustomerJobClassList
                    End If
                    If jobLine.CustomerJobClass IsNot Nothing Then
                        TryCast(gvJoblines.GetRow(e.RowHandle), API.JobLineTime).InventoryItem = (From ii As Helper.ActiveRecord.Evolution.StockItem In InventoryItemBindingSource.List Where ii.StockLink = jobLine.CustomerJobClass.InventoryItemID Select ii).FirstOrDefault
                        TryCast(gvJoblines.GetRow(e.RowHandle), API.JobLineTime).Description1 = TryCast(gvJoblines.GetRow(e.RowHandle), API.JobLineTime).InventoryItem.Description1
                    End If
                    If jobLine.ID = 0 Then
                        TryCast(gvJoblines.GetRow(e.RowHandle), API.JobLineTime).StartDate = Now
                        TryCast(gvJoblines.GetRow(e.RowHandle), API.JobLineTime).EndDate = Now
                    End If
                    e.RepositoryItem = rilkp
                End If
            End If

            'ElseIf e.Column Is colQuantity Then
            '    If Me.IsInitializing Then Exit Sub
            '    Dim jobLine As API.JobLineTime = TryCast(gvJoblines.GetRow(e.RowHandle), API.JobLineTime)
            '    If jobLine IsNot Nothing Then
            '        If jobLine.Quantity IsNot Nothing Then

            '            'If Not (IsDBNull(jobLine.StartDate)) And Not (IsDBNull(jobLine.EndDate)) AndAlso jobLine.StartDate IsNot Nothing AndAlso jobLine.EndDate IsNot Nothing And 1 = 2 Then
            '            '    Dim startDate As DateTime = CDate(jobLine.StartDate)
            '            '    Dim EndDate As DateTime = CDate(jobLine.EndDate)
            '            '    'Record.StartDate = startDate
            '            '    'Record.EndDate = EndDate
            '            '    'QuantitySpinEdit.EditValue = EndDate.Subtract(startDate).TotalHours

            '            '    jobLine.EndDate = startDate.AddHours(jobLine.Quantity)

            '            'End If
            '        End If

            '    End If
            'ElseIf e.Column Is StartDateRepositoryItemDateEdit Then
            '    If Me.IsInitializing Then Exit Sub
            '    Dim jobLine As API.JobLineTime = TryCast(gvJoblines.GetRow(e.RowHandle), API.JobLineTime)
            '    If jobLine IsNot Nothing Then
            '        If jobLine.Quantity IsNot Nothing Then
            '            If Not (IsDBNull(jobLine.StartDate)) And Not (IsDBNull(jobLine.EndDate)) AndAlso jobLine.StartDate IsNot Nothing AndAlso jobLine.EndDate IsNot Nothing Then
            '                Dim startDate As DateTime = CDate(jobLine.StartDate)
            '                Dim EndDate As DateTime = CDate(jobLine.EndDate)
            '                Record.Quantity = CDbl(jobLine.Quantity)
            '                jobLine.EndDate = startDate.AddHours(jobLine.Quantity)
            '                jobLine.EndDate = jobLine.EndDate
            '                jobLine.StartDate = startDate
            '            End If
            '        End If

            '    End If
            'ElseIf e.Column Is EndDateRepositoryItemDateEdit Then
            '    If Me.IsInitializing Then Exit Sub
            '    Dim jobLine As API.JobLineTime = TryCast(gvJoblines.GetRow(e.RowHandle), API.JobLineTime)
            '    If jobLine IsNot Nothing Then
            '        If jobLine.Quantity IsNot Nothing Then
            '            If Not (IsDBNull(jobLine.StartDate)) And Not (IsDBNull(jobLine.EndDate)) And jobLine.StartDate IsNot Nothing Then
            '                Dim startDate As DateTime = CDate(jobLine.StartDate)
            '                Dim EndDate As DateTime = CDate(jobLine.EndDate)
            '                jobLine.Quantity = EndDate.Subtract(startDate).TotalHours.ToString("F", CultureInfo.InvariantCulture)
            '                ' Record.StartDate = startDate
            '                jobLine.EndDate = EndDate

            '            End If
            '        End If

            'End If
        End If
    End Sub

    Private Sub gvJob_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvJoblines.RowStyle
        If e.RowHandle > -1 Then
            Dim jobline As API.JobLineTime = gvJoblines.GetRow(e.RowHandle)

            If jobline IsNot Nothing Then
                If e.RowHandle = gvJoblines.FocusedRowHandle Then
                    SetFocusedRowColor(jobline)
                ElseIf jobline.IgnoreTimeValidation OrElse jobline.IgnoreValidation Then
                    e.Appearance.BackColor = Color.Salmon
                    e.Appearance.BackColor2 = Color.SeaShell
                End If
            End If
        End If
    End Sub
    Private Sub SetFocusedRowColor(ByVal joblineTime As API.JobLineTime)
        If joblineTime IsNot Nothing Then
            If joblineTime.IgnoreTimeValidation = True OrElse joblineTime.IgnoreValidation = True Then
                gvJoblines.Appearance.FocusedRow.BackColor = Color.Red

            Else
                gvJoblines.Appearance.FocusedRow.BackColor = Nothing
            End If
        End If
    End Sub


    Private Sub gvJoblines_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvJoblines.ValidateRow
        Dim selectedJobline As API.JobLineTime = CType(gvJoblines.GetFocusedRow(), API.JobLineTime)
        If selectedJobline Is Nothing Then
            Exit Sub
        End If
        If selectedJobline IsNot Nothing Then
            e.Valid = selectedJobline.IsValid
            If (selectedJobline.EmployeeID) Is Nothing Then
                e.Valid = False
                UniSource.Helper.GUI.Dialog.OKDialog("Please Select Employee.", "Job Class")
                gvJoblines.SetColumnError(colEmployee, "Please Select  Employee.")
                Exit Sub
            End If

            'If (selectedJobline.isDayShift(selectedJobline.StartDate, selectedJobline.EndDate) = True And selectedJobline.isNightShift(selectedJobline.EndDate)) = True OrElse (selectedJobline.isDayShift(selectedJobline.StartDate, selectedJobline.EndDate) = False And selectedJobline.isNightShift(selectedJobline.EndDate) = False) Then
            '    e.Valid = False
            '    UniSource.Helper.GUI.Dialog.OKDialog("Time Spanning into two Shifts", "Kindly Correct Start and End Time")
            '    Exit Sub
            'End If


            'If Me.Record.Quantity >= 12.5 Or (Me.Record.FrontTimeLogged + Me.Record.Quantity) > 12.5 Or (Me.Record.BackTimeLogged + Me.Record.Quantity) > 12.5 Then
            If selectedJobline.Quantity > 12.5 OrElse (selectedJobline.FrontTimeLogged()) > 12.5 OrElse (selectedJobline.BackTimeLogged()) > 12.5 Then
                If selectedJobline.IgnoreTimeValidation = False Then
                    e.Valid = True
                    UniSource.Helper.GUI.Dialog.OKDialog("Time logged withing 24 hours > 12.5", "Time  Validation")
                    gvJoblines.SetColumnError(colQuantity, "Time logged withing 24 hours > 12.5.")

                    Exit Sub
                End If
            End If
            If selectedJobline.DoesEmployeeHasQualification = False Then
                selectedJobline.InvoiceRun = False
                selectedJobline.PaymentRun = False
                If selectedJobline.IgnoreValidation = False Then
                    e.Valid = False
                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Employee Does not have selected Qualification"))
                      Exit Sub
                End If
            End If
            If selectedJobline.EmployeeID IsNot Nothing AndAlso Me.Record.ID = 0 Then
                For Each jl In Record.JobLineTimes.Where(Function(j) j.EmployeeID = selectedJobline.EmployeeID)
                    If (selectedJobline.StartDate.Value >= jl.StartDate And selectedJobline.StartDate <= jl.EndDate.Value) OrElse (selectedJobline.EndDate >= jl.StartDate.Value And selectedJobline.EndDate <= jl.EndDate.Value) OrElse (selectedJobline.StartDate <= jl.StartDate.Value And selectedJobline.EndDate >= jl.EndDate) Then
                        UniSource.Helper.GUI.Dialog.OKDialog("Duplicate Time Record")
                        Exit Sub
                    End If
                Next

            End If
        End If

    End Sub

    Private Sub gvJoblines_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) _
Handles gvJoblines.InvalidRowException
        'Suppress displaying the error message box
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub
End Class



Public Class xaegJobQuoteTime
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.Job)
End Class