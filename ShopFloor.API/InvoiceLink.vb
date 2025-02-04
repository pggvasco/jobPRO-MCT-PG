Imports Castle.ActiveRecord
Imports Castle.Components.Validator
Imports UniSource
Imports NHibernate.Event
Imports System.Data.SqlClient
Public Class InvoiceLink

    Public Overridable ReadOnly Property Time As API.JobLineTime
        Get
            Return API.JobLineTime.Find(CInt(Me.JoblineTimeID))
        End Get
    End Property
End Class
