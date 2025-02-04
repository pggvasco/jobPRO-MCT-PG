Namespace Functions

    Public Class AddJobTime
        Inherits JobFunction

        Protected Overrides Sub Action()
            Dim xaej As New xaeJobTime
            xaej.Record = New API.Job
            xaej.Record.State = API.JobState.Active
            xaej.Icon = Helper.GUI.Extensions.MakeIcon(Me.Glyph)
            xaej.ShowDialog()
            If xaej.Record IsNot Nothing AndAlso xaej.Record.ID > 0 Then
                Dim ln As Menu.ListNode(Of API.Job, xlJob) = CType(Setup.Setup.MainForm, Menu.xfMain).MainNode.FindFirstChildByCaption(xaej.Record.JobStage.Description)
                ln.PerformAction()
                If Not ln.LookupControl.BindingSource.Contains(xaej.Record) Then
                    ln.RefreshData()
                End If
                Try
                    FocusRowHandleID = ln.LookupControl.GridView.GetRowHandle(ln.LookupControl.BindingSource.IndexOf(xaej.Record))
                    FocusRowJobStage = xaej.Record.JobStage
                Catch
                    FocusRowHandleID = -1
                End Try
            End If
        End Sub

        Public Overrides Property RequiresInstance As Boolean = False

        Public Overrides ReadOnly Property Code As String
            Get
                Return "Add Job Time"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "Add a new Job Time ."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.AddJob
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_add
            End Get
        End Property


    End Class
End Namespace
