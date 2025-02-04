Imports DevExpress.XtraEditors.Controls

Public Class xaeEmployee
    Inherits xaegEmployee


    Private Sub xaeEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)(InventoryRepositoryItemSearchLookUpEdit, AddressOf LoadStockItems)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        End Try

    End Sub


    Private Function LoadStockItems() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.StockItem)

        Return UniSource.Helper.ActiveRecord.Evolution.StockItem.FindAll

    End Function

    Private Sub gvJobLines_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        If e.Row Is Nothing Then
            Exit Sub
        End If
        Dim ql As API.EmployeeQualification = TryCast(e.Row, API.EmployeeQualification)
        If ql IsNot Nothing Then
            e.Valid = ql.IsValid
        End If

    End Sub

    Private Sub gvQualification_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GvEmployeeQualification.ValidateRow
        Dim selectedQualification As API.EmployeeQualification = CType(GvEmployeeQualification.GetFocusedRow(), API.EmployeeQualification)
        If selectedQualification Is Nothing Then
            Exit Sub
        End If
        If selectedQualification IsNot Nothing Then
            If selectedQualification.InventoryItemID Is Nothing Then
                e.Valid = False
                'e.ErrorText = "Please Enter a valid Quantity"
                UniSource.Helper.GUI.Dialog.OKDialog("Please Enter Qualification.", "Qualification")
                GvEmployeeQualification.SetColumnError(colInventoryItemID, "Please Enter  Qualification.")
            End If
            If selectedQualification.InventoryItemID IsNot Nothing Then
                Dim qual = Nothing '(From ql In API.EmployeeQualification.FindAll.Where(Function(ql) ql.Employee = Me.Record.e And ql.InventoryItemID = selectedQualification.InventoryItemID)).FirstOrDefault
                If qual IsNot Nothing Then
                    e.Valid = False
                    'e.ErrorText = "Please Enter a valid Quantity"
                    UniSource.Helper.GUI.Dialog.OKDialog("Duplicate  Entry.", "Duplicate Qualification")
                    GvEmployeeQualification.SetColumnError(colInventoryItemID, "Please  Select Another Qualification.")
                    e.Valid = False
                End If
            End If

        End If

    End Sub
    Private Sub gvLookupValues_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) _
  Handles GvEmployeeQualification.InvalidRowException
        'Suppress displaying the error message box
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub
End Class

Public Class xaegEmployee
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Employee)

    Public Sub New()
        MyBase.New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

End Class