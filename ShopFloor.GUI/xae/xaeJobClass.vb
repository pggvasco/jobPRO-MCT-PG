Imports DevExpress.XtraEditors.Controls

Public Class xaeJobClass
    Inherits xaegJobClass
    Private Sub xaeJobClass_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(InventoryRepositoryItemLookUpEdit, AddressOf LoadStockItems)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        End Try
    End Sub


    Private Function LoadStockItems() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)

        Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll

    End Function

    Private Sub gvJobClass_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvJobClass.ValidateRow
        Dim selectedJobClass As API.CustomerJobClass = CType(gvJobClass.GetFocusedRow(), API.CustomerJobClass)
        If selectedJobClass Is Nothing Then
            Exit Sub
        End If
        If selectedJobClass IsNot Nothing Then
            If selectedJobClass.InventoryItemID Is Nothing Then
                e.Valid = False
                UniSource.Helper.GUI.Dialog.OKDialog("Please Enter Qualification.", "Qualification")
                gvJobClass.SetColumnError(colInventoryItemID, "Please Enter  Qualification.")
            ElseIf selectedJobClass.Code Is Nothing Then
                e.Valid = False
                UniSource.Helper.GUI.Dialog.OKDialog("Please Enter Code.", "Job Class")
                gvJobClass.SetColumnError(colCode, "Please Enter  Job class.")

            End If
            If selectedJobClass.InventoryItemID IsNot Nothing AndAlso selectedJobClass.ID = 0 Then
                'Dim jobclass = From s In Me.Record.JobclassLineList
                'If jobclass IsNot Nothing Then
                '    e.Valid = False
                '    UniSource.Helper.GUI.Dialog.OKDialog("Duplicate  Entry.", "Duplicate Job Class")
                '    gvJobClass.SetColumnError(colCode, "Please  Select Another Job Class.")
                '    e.Valid = False
                'End If

            End If

        End If

    End Sub
    Private Sub gvLookupValues_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) _
  Handles gvJobClass.InvalidRowException
        'Suppress displaying the error message box
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub
End Class

Public Class xaegJobClass
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.CustomerWorkCentreCategory)

    'Public Sub New()
    '    MyBase.New()
    '    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    'End Sub


End Class