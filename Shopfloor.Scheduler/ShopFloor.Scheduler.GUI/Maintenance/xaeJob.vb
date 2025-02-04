Public Class xaeJob
    Inherits xaegJob

    Private Sub xaeJob_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            CustomerBindingSource.DataSource = API.Customer.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error fetching Customers.", ex)
        End Try
    End Sub

    'CvN - added copy job button
    Public Property Job As API.Job
        Get
            If Me.BindingSource IsNot Nothing Then
                Return Me.BindingSource.Current
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.Job)
            BindingSource.Clear()
            BindingSource.DataSource = value
        End Set
    End Property
    
End Class

Public Class xaegJob
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Job)
End Class
