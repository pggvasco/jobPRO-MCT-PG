Namespace Functions
    Public Class AssignInspector
        Inherits JobFunction

        Protected Overrides Sub Action()
            For Each j As API.Job In Jobs
                Dim userFieldName As String = "Inspector"
                If j.State <> API.JobState.Active Then Exit Sub
                Dim ql As Helper.ActiveRecord.xfQuickLookup(Of API.Artisan)
                ql = New Helper.ActiveRecord.xfQuickLookup(Of API.Artisan)(API.Artisan.FindAll, "Description", "Code", "Description")
                If j.UserFields(userFieldName) IsNot Nothing AndAlso API.Artisan.FindAllByProperty("Description", Jobs(0).UserFields(userFieldName)).FirstOrDefault() IsNot Nothing Then
                    CType(ql.Controls(2), DevExpress.XtraEditors.LookUpEdit).EditValue = API.Artisan.FindAllByProperty("Description", Jobs(0).UserFields(userFieldName)).First()
                End If
                ql.Text = "Assign Inspector"
                ql.ShowDialog()
                If IIf(IsDBNull(ql.EditValue), Nothing, ql.EditValue) IsNot Nothing Then
                    'j.UserFields(userFieldName) = ql.EditValue.Description
                    j.UserFields.Item(userFieldName) = ql.EditValue.Description
                    j.SaveAndFlush()
                End If
                ql.Close()
            Next
        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Inspector"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Assign Inspector."
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.user_orange
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.AssignTester
            End Get
        End Property
    End Class
End Namespace

