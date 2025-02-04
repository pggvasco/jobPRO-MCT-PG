Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls


Public Class xaeLookup
    Inherits xaegLookup
    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "Code" Then
                CodeTextEdit.ErrorText = errors(prop)(0)
            ElseIf prop.Name = "Description" Then
                DescriptionTextEdit.ErrorText = errors(prop)(0)

            Else
            End If
                 Next
    End Sub

    'Private Sub gvLookupValues_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)


    'Dim cls As API.LookupValue = TryCast(e.Row, API.LookupValue)

    'If cls IsNot Nothing Then
    ' If cls.Code Is Nothing Then
    'e.Valid = False
    ' gvLookupValues.SetColumnError(colCode2, "Required field.")
    ' gvLookupValues.SetFocusedRowCellValue(colCode2, cls.Code)
    '  gvLookupValues.FocusedColumn = colCode2
    'End If
    ' If colCode2 Is Nothing Then
    ' e.Valid = False
    ' gvLookupValues.SetColumnError(colDescription, "Required field.")
    ' gvLookupValues.SetFocusedRowCellValue(colDescription, cls.Description)
    ' gvLookupValues.FocusedColumn = colDescription
    'End If
    'End If
    'End Sub

    Protected Overrides Sub SaveRecord()
        Dim rowNo As Integer = 0
        Do While rowNo < gvLookupValues.RowCount
            Dim lv As API.LookupValue = TryCast(gvLookupValues.GetRow(rowNo), API.LookupValue)
            If lv IsNot Nothing Then
                If lv.Lookup Is Nothing Then
                    lv.Lookup = Me.Record
                End If
            End If
            rowNo += 1
        Loop
        MyBase.SaveRecord()
    End Sub


    Private Sub gvLookupValues_ValidateRow(ByVal sender As Object, _
    ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) _
    Handles gvLookupValues.ValidateRow

        With gvLookupValues
            .PostEditor()
            .FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            .OptionsSelection.EnableAppearanceFocusedRow = True
            .OptionsSelection.EnableAppearanceFocusedCell = False
        End With

        'Get the value of the first column
        Dim code As String = CType(gvLookupValues.GetRowCellValue(e.RowHandle, colCode2), String)
        'Get the value of the second column
        Dim description As String = CType(gvLookupValues.GetRowCellValue(e.RowHandle, colDescription2), String)

        'Validity criterion 

        If code Is Nothing Then
            e.Valid = False
            'Set errors with specific descriptions for the column
            gvLookupValues.SetColumnError(colCode2, "Required Field")
        End If

        If description Is Nothing Then
            e.Valid = False
            'Set errors with specific description for the column
            gvLookupValues.SetColumnError(colDescription2, "Required Field")
        End If
    End Sub

    Private Sub gvLookupValues_InvalidRowException(ByVal sender As Object, _
    ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) _
    Handles gvLookupValues.InvalidRowException
        'Suppress displaying the error message box
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub


  
    Private Sub xaeLookup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class xaegLookup
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Lookup)
End Class