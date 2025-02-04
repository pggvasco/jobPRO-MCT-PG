Imports Castle.ActiveRecord
Imports Castle.Components.Validator
Imports UniSource
Imports NHibernate.Event
Imports System.Data.SqlClient


Public Class ProformaInvoice


    Public Shared Function FindProformaInvoice(ByVal JobID As Integer) As ProformaInvoice
        Dim ProformaInvoiceobj() As ProformaInvoice

        If JobID > 0 Then
            ProformaInvoiceobj = ProformaInvoice.FindAllByProperty("JobID", JobID)

            If ProformaInvoiceobj.Count >= 1 Then
                Return ProformaInvoiceobj(0)

            ElseIf ProformaInvoiceobj.Count = 0 Then
                Return Nothing
                'Return New UniSource.Batches.JournalBatch With {.Number = batchNumber}
            End If

        End If
    End Function


End Class
