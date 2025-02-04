Public Class xaeCostCentre
    Inherits xaegCostCentre

    Private Sub xaeCostCentre_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Dim rbl As New Helper.Evolution.LookupLoader(Of Pastel.Evolution.JobTransactionCode)(TransactionCodeLookupEdit, JobTransactionCodeBindingSource, "idJobTxTp")
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Job Transaction Codes.", ex)
        End Try

    End Sub

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

End Class

Public Class xaegCostCentre
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.CostCentre)
End Class
