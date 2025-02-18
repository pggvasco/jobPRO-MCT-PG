﻿Imports System.Data.SqlClient
Public Class xaeRequisition
    Inherits xaegRequisition

    'Public Property Defaults As API.Defaults

    Private Sub xaeRequisition_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Dim jll As New Helper.GUI.LookupBackgroundLoader(Of API.Job)(JobLookUpEdit, AddressOf LoadJobs)
            jll.Form = Me
        Catch ex As Exception
            Setup.Log.logError("Error loading Jobs", ex)
        End Try



        If Me.Record.ID = 0 Then
            Me.Record.RequisitionLineList.Clear()
            For Each rl As API.RequisitionLine In Me.Record.Job.GetRequisitionLines
                Me.Record.RequisitionLineList.Add(rl)
            Next
        End If

        Try
            SetNumbering()
        Catch ex As Exception
            Setup.Log.logError("Error setting numbering.", ex)
        End Try
        Try
            SetState()
        Catch ex As Exception
            Setup.Log.logError("Error setting state.", ex)
        End Try

        If API.Defaults.Defaults.IsRequisitionQtyReadOnly Then
            colQuantity.OptionsColumn.ReadOnly = True
        End If

    End Sub

    Private Sub LoadDefaults()
        'Try
        '    Defaults = API.Defaults.Defaults
        'Catch ex As Exception
        '    Setup.Log.logError("Error loading System Defaults.", ex)
        'End Try
    End Sub

    Private Sub SetNumbering()
        'Dim rowID As Integer = 0
        'If rowID > gvRequisitionLines.RowCount Then
        If Me.Record.ID = 0 Then
            Me.Record.Date = Today.Date
            Me.Record.AgentID = Setup.Agent.ID
            Me.Record.AgentName = Setup.Agent.Name
            If IIf(API.Context.Defaults.isWarehouseIssueNumberAutoGenerated.HasValue, API.Context.Defaults.isWarehouseIssueNumberAutoGenerated, False) Then
                NumberTextEdit.Properties.ReadOnly = True
                'Me.Record.Number = API.Defaults.Defaults.GetNextRequisitionNumber(Me.Record.Job) + " *"
                'Tawanda
                Me.Record.Number = API.Defaults.Defaults.GetNextWarehouseIssueNumber(Me.Record.Job) + " *"



            Else
                NumberTextEdit.Properties.ReadOnly = False
            End If
        Else
            NumberTextEdit.Properties.ReadOnly = True
        End If
        'End If
    End Sub

    Private Sub SetState()
        If Me.Record.ID = 0 Then
            If Me.Record.Job IsNot Nothing Then
                JobLookUpEdit.Properties.ReadOnly = True
                PartGroupLookUpEdit.Properties.ReadOnly = False
                PartLookUpEdit.Properties.ReadOnly = False
                SupplyScopeLookUpEdit.Properties.ReadOnly = False
                WorkCentreCategoryLookUpEdit.Properties.ReadOnly = False
                WorkCentreLookUpEdit.Properties.ReadOnly = False
                gvRequisitionLines.OptionsBehavior.ReadOnly = False
            Else
                JobLookUpEdit.Properties.ReadOnly = False
                PartGroupLookUpEdit.Properties.ReadOnly = True
                PartLookUpEdit.Properties.ReadOnly = True
                SupplyScopeLookUpEdit.Properties.ReadOnly = True
                WorkCentreCategoryLookUpEdit.Properties.ReadOnly = True
                WorkCentreLookUpEdit.Properties.ReadOnly = True
                gvRequisitionLines.OptionsBehavior.ReadOnly = True
            End If
        Else
            JobLookUpEdit.Properties.ReadOnly = True
            PartGroupLookUpEdit.Properties.ReadOnly = True
            PartLookUpEdit.Properties.ReadOnly = True
            SupplyScopeLookUpEdit.Properties.ReadOnly = True
            WorkCentreCategoryLookUpEdit.Properties.ReadOnly = True
            WorkCentreLookUpEdit.Properties.ReadOnly = True
            gvRequisitionLines.OptionsBehavior.ReadOnly = True
            btSave.Visible = False

        End If
    End Sub

    Protected Overrides Sub SetCLH()
        MyBase.SetCLH()
        CLH.Components.Add(gvRequisitionLines)
        CLH.Components.Add(DataLayoutControl)
        CLH.AddSaveEvent(gvRequisitionLines, "Layout")
        CLH.AddSaveEvent(DataLayoutControl, "HideCustomization")
    End Sub

    Private Function LoadJobs() As IEnumerable(Of API.Job)
        'Return API.Job.FindAllByState(API.JobState.Active)

        Return API.Job.FindAllByJobNumber(Me.Record.Job.JobNumber)
    End Function

    Private Sub JobLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.Record IsNot Nothing AndAlso API.Context.Defaults IsNot Nothing Then
            If Me.Record.ID = 0 Then
                Me.Record.Job = JobLookUpEdit.EditValue
                Me.Record.RequisitionLineList.Clear()
                For Each rl As API.RequisitionLine In Me.Record.Job.GetRequisitionLines
                    Me.Record.RequisitionLineList.Add(rl)
                Next

                Try
                    SetNumbering()
                Catch ex As Exception
                    Setup.Log.logError("Error setting numbering.", ex)
                End Try
                Try
                    SetState()
                Catch ex As Exception
                    Setup.Log.logError("Error setting state.", ex)
                End Try
            End If
        End If
    End Sub

    Private Sub gvRequisitionLines_CustomRowCellEdit(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs)

        If e.Column Is colQuantity Then
            Dim rl As API.RequisitionLine = TryCast(gvRequisitionLines.GetRow(e.RowHandle), API.RequisitionLine)
            If rl IsNot Nothing Then
                Dim remainder As Double = IIf(rl.JobLine.QuantityStock.HasValue, rl.JobLine.QuantityStock, 0)
                If rl.JobLine.QuantityStockDrawn.HasValue Then
                    remainder -= rl.JobLine.QuantityStockDrawn
                End If
                CType(e.RepositoryItem, DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit).MaxValue = remainder
                If API.Context.Defaults.IsRequisitionQtyReadOnly IsNot Nothing AndAlso API.Context.Defaults.IsRequisitionQtyReadOnly = True Then
                    CType(e.RepositoryItem, DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit).MinValue = remainder
                End If
            End If
        End If

    End Sub

    'Protected Overrides Sub SaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
    '    Me.DialogResult = Windows.Forms.DialogResult.OK
    '    If Me.DialogResult = Windows.Forms.DialogResult.OK Then
    '        Me.Close()
    '    End If
    'End Sub

    Protected Overrides Sub SaveClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim myUpdate As Boolean
        Dim rowID As Integer = 0

        'StockItem.WarehouseContexts(2)
        If gvRequisitionLines.RowCount > 0 Then
            While rowID < gvRequisitionLines.RowCount
                Dim JobWarehouseID As Integer
                Dim requisitionLine As API.RequisitionLine = CType(gvRequisitionLines.GetRow(rowID), API.RequisitionLine)
                JobWarehouseID = requisitionLine.JobLine.WarehouseID 'Convert.ToInt32(cmd.ExecuteScalar)
                Dim ID As Integer = Convert.ToInt32(requisitionLine.InventoryItem.ID)
                Dim StockItem As Pastel.Evolution.InventoryItem = New Pastel.Evolution.InventoryItem(ID)
                Dim freestock As Double
                If StockItem.IsServiceItem = False Then 'AndAlso Me.Record.WorkCentre.CalculationType = API.CalculationType.Standard 
                    If StockItem.IsWarehouseTracked = True Then
                        Dim SODetail As New Pastel.Evolution.OrderDetail
                        SODetail.InventoryItem = StockItem

                        Dim WID As Integer = JobWarehouseID
                        SODetail.Warehouse = New Pastel.Evolution.Warehouse(WID)
                        freestock = SODetail.WarehouseContext.QtyOnHand - SODetail.WarehouseContext.QtyWIP
                    End If
                End If

                If requisitionLine.Quantity > 0 AndAlso requisitionLine.Quantity > freestock Then 'requisitionLine.InventoryItem.QtyOnHand Then
                    Setup.Log.logError(String.Format("Insufficient quantity available for {0}, Ordered :{1}, available :{2}. Job : {3}", requisitionLine.InventoryItem, requisitionLine.Quantity, freestock, requisitionLine.JobLine.Job))


                    Me.DialogResult = Windows.Forms.DialogResult.None
                    Return
                    Exit Sub
                End If
                rowID += 1
            End While
            MyBase.SaveClick(sender, e)
        End If



        If myUpdate = True And rowID > 0 Then
            Me.Record.Job.IsApproved = True
            Me.Record.Job.IsStockDrawn = True

        End If


    End Sub



    Private Sub gcRequisitionLines_Click(sender As System.Object, e As System.EventArgs) Handles gcRequisitionLines.Click

    End Sub
End Class

Public Class xaegRequisition
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Requisition)

    Public Sub New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

End Class