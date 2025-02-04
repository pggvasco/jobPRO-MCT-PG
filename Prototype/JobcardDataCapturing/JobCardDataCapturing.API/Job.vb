Imports System.ComponentModel

Public Class Job
    Private _customer As Pastel.Evolution.Customer

    Private _activities As System.ComponentModel.BindingList(Of Activity)

    Public Overridable ReadOnly Property JobActivity As System.ComponentModel.BindingList(Of Activity)
        Get
            If _activities Is Nothing Then
                _activities = New System.ComponentModel.BindingList(Of Activity)(Me.Activities)
            End If
            Return _activities
        End Get
    End Property
End Class
