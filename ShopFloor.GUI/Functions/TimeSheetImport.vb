Namespace Functions

    Public Class TimeSheetImport
        Inherits JobFunction

        Protected Overrides Sub Action()
            Dim int As UniSource.B2B.DAL.IntegrationMapping = UniSource.B2B.DAL.IntegrationMapping.FindOne("Code", "TSU")
            If int IsNot Nothing Then
                Dim xfri As New UniSource.B2B.GUI.xfRunIntegration(int)
                'AddHandler xfri.AddedRow, Sub(s As Object, ea As DataTableNewRowEventArgs) ea.Row("ReconciliationBatchID") = Me.ReconciliationBatch.ID
                'xfri.xrIntegration.gcUploadData.ForceInitialize()
                'xfri.xrIntegration.gvUploadData.Columns.ColumnByFieldName("ussID").Visible = False
                'xfri.xrIntegration.gvUploadData.Columns.ColumnByFieldName("ReconciliationBatchID").Visible = False
                xfri.ShowDialog()



                Try

                Catch
                End Try
            Else
                Setup.Log.logError("The integration mapping for Credit Manager Statement Upload has not been created for this company, please contact your system Administrator.")
            End If

        End Sub

        Public Overrides ReadOnly Property Code As String
            Get
                Return "TimeSheet Import"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "TimeSheet Import."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.TimeSheetImport
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.folder_edit
            End Get
        End Property

    End Class

End Namespace
