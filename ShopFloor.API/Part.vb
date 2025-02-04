
Public Class Part

    Public Overridable Property Colour As System.Drawing.Color
        Get
            If Not String.IsNullOrEmpty(MyBase.DBColour) Then
                Return System.Drawing.Color.FromName(MyBase.DBColour)
            End If
            Return Nothing
        End Get
        Set(ByVal value As System.Drawing.Color)
            MyBase.DBColour = value.Name
        End Set
    End Property

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid

        If Context.Defaults.CostCentreMethod = CostCentreMethod.Part Then
            If Me.TransactionTypeID Is Nothing Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("TransactionTypeID"), New ArrayList())
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("TransactionTypeID")).Add("Transaction Type is required due to Cost Centre Method.")
                valid = False
            End If
        End If

        Return valid
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", MyBase.Code, MyBase.Description)
    End Function

    'Public Overrides Function Equals(obj As Object) As Boolean
    '    If Me Is Nothing OrElse obj Is Nothing Then
    '        Return False
    '    End If
    '    If Me.Code = CType(obj, Part).Code Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

End Class
