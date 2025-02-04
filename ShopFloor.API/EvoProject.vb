Imports Castle.ActiveRecord

    Public Class EvoProject
        Public Overrides Property ID As Object
            Get
            Return ProjectLink
            End Get
            Set(ByVal value As Object)
            ProjectLink = value
            End Set
        End Property
    End Class



