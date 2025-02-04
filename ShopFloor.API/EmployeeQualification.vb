Public Class EmployeeQualification
    Public Overrides Property Active As Boolean?
        Get
            If MyBase.Active Is Nothing Then
                Return True
            End If
            Return MyBase.Active
        End Get
        Set(value As Boolean?)
            MyBase.Active = value
        End Set
    End Property
    
    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid
        Dim ql = (From q In API.EmployeeQualification.FindAll Where q.InventoryItemID = Me.InventoryItemID And q.Employee = Me.Employee).FirstOrDefault
        If ql IsNot Nothing Then
            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("InventoryID"), New ArrayList())
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("InventoryID")).Add("Duplicate Qualification")
            valid = False
        End If

        Return valid
    End Function

    Public Overrides Sub Save()
        If IsValid() Then
            'MyBase.SaveAndFlush()
            MyBase.Save()
        End If
    End Sub
End Class
