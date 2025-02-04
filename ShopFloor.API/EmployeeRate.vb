Public Class EmployeeRate
   
    Public Overrides Property Employee As Employee
        Get
            Return MyBase.Employee
        End Get
        Set(value As Employee)
            MyBase.Employee = value
        End Set
    End Property
    Public Overrides Property Deleted As Boolean?
        Get
            If MyBase.Deleted Is Nothing Then
                Return False
            End If
            Return MyBase.Deleted
        End Get
        Set(value As Boolean?)
            MyBase.Deleted = value
        End Set
    End Property
End Class
