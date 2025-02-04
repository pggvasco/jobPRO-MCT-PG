Public Class JobTolerance
    Public Shared Function PrintJobTolerances()

        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.Job)()
        crit.Add(New NHibernate.Criterion.OrExpression(NHibernate.Criterion.Expression.IsNull("CollectionLoad"), NHibernate.Criterion.Expression.Eq("CollectionLoad", False)))

        Dim result = API.Job.FindAll(crit).ToList

        If result IsNot Nothing Then
            Return result
        Else
            Return Nothing
        End If
    End Function
End Class
