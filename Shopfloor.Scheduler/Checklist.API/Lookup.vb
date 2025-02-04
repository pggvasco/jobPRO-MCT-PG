Public Class Lookup

    Private _lookupvalues As ComponentModel.BindingList(Of LookupValue)
    Public Overridable Overloads ReadOnly Property Values As ComponentModel.BindingList(Of LookupValue)
        Get
            If _lookupvalues Is Nothing Then
                _lookupvalues = New ComponentModel.BindingList(Of LookupValue)(MyBase.LookupValues)
            End If
            Return _lookupvalues
        End Get
    End Property

    Public ReadOnly Property DefaultDatatype As Datatype
        Get
            Return Datatype.Integer
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", Me.Code, Me.Description)
    End Function

End Class
