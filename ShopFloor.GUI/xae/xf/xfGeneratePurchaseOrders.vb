﻿Public Class xfGeneratePurchaseOrders 
    Inherits xfgGeneratePurchaseOrders



    Private Sub xaePurchaseOrder_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            SetState()
        Catch ex As Exception
            Setup.Log.logError("Error setting state.", ex)
        End Try

    End Sub

    Private Sub LoadDefaults()
        'Try
        '    Defaults = API.Defaults.Defaults
        'Catch ex As Exception
        '    Setup.Log.logError("Error loading System Defaults.", ex)
        'End Try
    End Sub

    Private Sub SetNumbering()

        If Me.CurrentRecord.ID = 0 Then
            Me.CurrentRecord.OrderDate = Today.Date
            Me.CurrentRecord.AgentID = Setup.Agent.ID
            Me.CurrentRecord.AgentName = Setup.Agent.Name
            If IIf(API.Context.Defaults.IsPurchaseOrderNumberAutoGenerated.HasValue, API.Context.Defaults.IsPurchaseOrderNumberAutoGenerated, False) Then
                OrderNumberTextEdit.Properties.ReadOnly = True
                Me.CurrentRecord.OrderNumber = API.Defaults.Defaults.GetNextPurchaseOrderNumber(Me.CurrentRecord.Job) + " *"
            Else
                OrderNumberTextEdit.Properties.ReadOnly = False
            End If
        Else
            OrderNumberTextEdit.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub SetState()
        If Me.CurrentRecord Is Nothing OrElse Me.CurrentRecord.ID = 0 Then
            If Me.CurrentRecord IsNot Nothing AndAlso Me.CurrentRecord.Job IsNot Nothing Then
                gvPurchaseOrderLines.OptionsBehavior.ReadOnly = False
            Else
                gvPurchaseOrderLines.OptionsBehavior.ReadOnly = True
            End If
        Else
            gvPurchaseOrderLines.OptionsBehavior.ReadOnly = True
        End If
    End Sub

    Private Sub gvPurchaseOrderLines_CustomRowCellEdit(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvPurchaseOrderLines.CustomRowCellEdit
        If e.Column Is colQuantity Then
            Dim rl As API.PurchaseOrderLine = TryCast(gvPurchaseOrderLines.GetRow(e.RowHandle), API.PurchaseOrderLine)
            If rl IsNot Nothing Then
                Dim remainder As Double = (IIf(rl.JobLine.QuantitySupplier1.HasValue, rl.JobLine.QuantitySupplier1, 0) + IIf(rl.JobLine.QuantitySupplier2.HasValue, rl.JobLine.QuantitySupplier2, 0))
                If rl.JobLine.QuantitySupplierOrdered.HasValue Then
                    remainder -= rl.JobLine.QuantitySupplierOrdered
                End If
                CType(e.RepositoryItem, DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit).MaxValue = remainder
            End If
        End If
    End Sub

    Protected Overrides Sub RecordsLookUpEdit_EditValueChanged(sender As Object, e As System.EventArgs)
        MyBase.RecordsLookUpEdit_EditValueChanged(sender, e)
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
    End Sub

End Class

Public Class xfgGeneratePurchaseOrders
    Inherits Helper.ActiveRecord.xfMultipleAddEdit(Of API.PurchaseOrder)
End Class