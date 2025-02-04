Public Class StockAllocation

    Public Overridable Property StockItemForm As UniSource.Helper.ActiveRecord.Evolution.StockItem
    Public Overridable Property StockItemTo As UniSource.Helper.ActiveRecord.Evolution.StockItem

    Private WithEvents _jobLines As List(Of JobLine)
    Public Overridable Overloads Property JobLines As List(Of JobLine)
        Get
            Return _jobLines
        End Get
        Set(value As List(Of JobLine))
            _jobLines = value
        End Set
    End Property

    Private WithEvents _jobLinelist As ComponentModel.BindingList(Of JobLine)
    Public Overridable Overloads ReadOnly Property JobLinelist As ComponentModel.BindingList(Of JobLine)
        Get
            If _jobLinelist Is Nothing OrElse _jobLinelist.Count = 0 Then
                _jobLinelist = New ComponentModel.BindingList(Of JobLine)(Me.JobLines)
            End If
            Return _jobLinelist
        End Get
    End Property

    Private WithEvents _eRPJobLines As List(Of Pastel.Evolution.JobDetail)
    Public Overridable Overloads Property ERPJobLines As List(Of Pastel.Evolution.JobDetail)
        Get
            Return _eRPJobLines
        End Get
        Set(value As List(Of Pastel.Evolution.JobDetail))
            _eRPJobLines = value
        End Set
    End Property

    Private WithEvents _eRPJobLinelist As ComponentModel.BindingList(Of Pastel.Evolution.JobDetail)
    Public Overridable Overloads ReadOnly Property ERPJobLinelist As ComponentModel.BindingList(Of Pastel.Evolution.JobDetail)
        Get
            If _eRPJobLinelist Is Nothing OrElse _eRPJobLinelist.Count = 0 Then
                _eRPJobLinelist = New ComponentModel.BindingList(Of Pastel.Evolution.JobDetail)(Me.ERPJobLines)
            End If
            Return _eRPJobLinelist
        End Get
    End Property

End Class
