Public Class Artisan

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

    Public Overrides Function ToString() As String
        'Return String.Format("{0} - {1}", MyBase.Code, MyBase.Description)
        Return MyBase.Code
    End Function

    Public Shared Function FindByCodeAndPassword(ByVal code As String, ByVal password As String) As Artisan
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of Artisan)()
        crit.Add(NHibernate.Criterion.Expression.Eq("Code", code))
        crit.Add(NHibernate.Criterion.Expression.Eq("Password", password))

        Dim result As Artisan = Artisan.FindOne(crit)

        Return result
    End Function
End Class
