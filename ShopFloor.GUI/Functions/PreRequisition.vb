Imports DevExpress.XtraReports.UI
Namespace Functions
    Public Class PreRequisition
        Inherits JobFunction


        Protected Overrides Sub Action()
            For Each j In Jobs
                'Dim bc As New Helper.ActiveRecord.Checkout
                'If bc.AddCheckOut("Job", j.ID) Then
                '    If j.IsProcured Then
                '        If j.PreRequisitionPrintedAgent IsNot Nothing Then
                '            Setup.Log.logError(String.Format("Pre-Requisition was printed by {0}", IIf(IsNothing(j.PreRequisitionPrintedAgent), "N\A", j.PreRequisitionPrintedAgent.CDisplayName)))
                '        Else
                '            Setup.Log.logError(String.Format("Pre-Requisition was printed by {0}", "N\A"))
                '        End If
                '        Dim jfc As API.JobFunctionControl
                '        Dim crit As NHibernate.Criterion.DetachedCriteria = NHibernate.Criterion.DetachedCriteria.For(Of API.JobFunctionControl)()
                '        crit.Add(NHibernate.Criterion.Expression.Eq("JobFunctionID", CInt(API.JobFunction.PreRequisitionRePrint)))
                '        jfc = API.JobFunctionControl.FindFirst(crit)
                '        If jfc IsNot Nothing Then
                '            If Not String.IsNullOrEmpty(jfc.Password) Then
                '                Dim password = Helper.GUI.Dialog.PromptPasswordDialog("Password", "Password")
                '                If password Is Nothing OrElse Not password = jfc.Password Then
                '                    If password IsNot Nothing Then
                '                        Setup.Log.logError("Incorrect password.")
                '                    End If
                '                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                '                        bc.RemoveCheckout(bc.Checkout.GUID)
                '                    End If
                '                    Exit Sub
                '                End If
                '            End If
                '        End If
                '    End If

                Dim reserveMessage As String = ""

                If API.Context.Defaults.IsStockReservedOnPreRequisition IsNot Nothing AndAlso API.Context.Defaults.IsStockReservedOnPreRequisition = True Then
                    For Each jobLine As API.JobLine In j.JobLineList
                        jobLine.RefreshOrderedStockDrawnQty()
                        If (jobLine.Quantity - jobLine.QuantityStockDrawn) > 0 AndAlso jobLine.InventoryItem IsNot Nothing AndAlso (jobLine.InventoryItem.ServiceItem = Nothing OrElse jobLine.InventoryItem.ServiceItem = False) Then
                            Dim jobLineCrit = NHibernate.Criterion.DetachedCriteria.For(Of API.JobLine)()
                            jobLineCrit.Add(NHibernate.Criterion.Expression.Sql("JobID In (Select t1.id From ussSFJob t1 with(nolock) Where t1.IsApproved = 1 And (t1.IsStockDrawn Is Null Or t1.IsStockDrawn = 0) And t1.StateID = 0 And t1.IsProcured = 1) And (QuantityStock - QuantityStockDrawn) > 0  And InventoryItemID = " & jobLine.InventoryItemID.Value.ToString() & " And JobID != " & jobLine.Job.ID.ToString()))
                            Dim jobLineListStock As List(Of API.JobLine) = API.JobLine.FindAll(jobLineCrit).ToList()
                            Dim jobLinesQty As Double = jobLineListStock.Sum(Function(x) x.Quantity.Value - x.QuantityStockDrawn.Value)
                            If (jobLine.AvailibleERPQty - jobLinesQty - (jobLine.Quantity - jobLine.QuantityStockDrawn)) < 0 Then
                                reserveMessage += jobLine.InventoryItem.Code + " Qty required " + (jobLine.Quantity - jobLine.QuantityStockDrawn).ToString() + ", Insufficient qty available, " + jobLine.OnHandERPQty.ToString() + " On Hand, " + (jobLinesQty + jobLine.AllocatedERPQty).ToString() + " Allocated Stock, Total Free " + (jobLine.AvailibleERPQty - jobLinesQty).ToString() + vbCrLf
                            End If
                        End If
                    Next
                End If
                If reserveMessage <> "" Then

                    UniSource.Helper.GUI.Dialog.OKDialog(reserveMessage)

                Else
                    Dim xrPR As New ShopFloor.Report.xrDoscoPrerequisitionSummary
                    'Shannen 23102020

                    j.IsProcured = True
                    j.PreRequisitionPrintedAgentID = API.Context.Agent.ID

                    j.SaveAndFlush()

                    xrPR.BindingSource1.DataSource = j 'CorrectJobData(j)
                    xrPR.ShowPreview()


                    'If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                    '    bc.RemoveCheckout(bc.Checkout.GUID)
                    'End If
                    'End If
                End If
            Next
        End Sub


        'Private Function CorrectJobData(ByVal OldJob As API.Job) As API.Job
        '    Dim LoopJoblines As New List(Of API.JobLine)

        '    For Each line In OldJob.JobLines
        '        If (line.WorkCentre.GLExpense = False Or line.WorkCentre.GLExpense Is Nothing) And (line.WorkCentre.APExpense = False Or line.WorkCentre.APExpense Is Nothing) Then
        '            'this will only return already requisitioned lines
        '            If line.InventoryItem IsNot Nothing AndAlso IsDBNull(line.InventoryItem) = False AndAlso line.IsRequisitionedGenerated = True Then
        '                If line.InventoryItem.SerialItem = False Then
        '                    LoopJoblines.Add(line)
        '                End If
        '            End If
        '        End If
        '    Next

        '    OldJob.JobLines = LoopJoblines

        '    Return OldJob
        'End Function


        Public Overrides ReadOnly Property Code As String
            Get
                Return "Requisition Summary"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Print the Job Stock Pre-Requisition."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.PreRequisition
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.report
            End Get
        End Property
    End Class
End Namespace
