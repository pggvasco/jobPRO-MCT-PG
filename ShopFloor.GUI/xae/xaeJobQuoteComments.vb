Public Class xaeJobQuoteComments 
    Inherits xaegJobQuoteComments

    Public Sub New(ByVal job As API.Job)
        InitializeComponent()
        Me.Record = job
        Select Case Me.Record.State
            Case API.JobState.Quote
                Me.Text += " - " & Me.Record.QuoteNumber
            Case Else
                Me.Text += " - " & Me.Record.JobNumber
        End Select
    End Sub

    Private Sub NoteRichEditControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoteRichEditControl.Click

    End Sub

    Private Sub xaeJobQuoteComments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetCLH()
        Catch ex As Exception
            Setup.Log.logError("Error setting component layout helper.", ex)
        End Try

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub
End Class

Public Class xaegJobQuoteComments
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Job)
    Public Sub New()
        MyBase.New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub
End Class