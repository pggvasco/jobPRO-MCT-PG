Public Class xfJobDrawings
    Inherits xfgJobDrawings


    Public Property Job As API.Job
        Get
            Return BindingSource.Current
        End Get
        Set(ByVal value As API.Job)
            BindingSource.Clear()
            If value IsNot Nothing Then
                If value.ID > 0 Then
                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                        value = API.Job.Find(value.ID)
                    End Using
                End If
                BindingSource.Add(value)
            End If
        End Set
    End Property

    Public Sub New(ByVal job As API.Job)
        InitializeComponent()
        Me.Job = job
        'If job.JobDrawingAnnotationsList.Count = 0 Then
        '    For seq As Integer = 1 To job.Drawing.NumberOfAnnotations
        '        Dim jda As New API.JobDrawingAnnotations
        '        jda.Job = Me.Job
        '        jda.Code = NumberToLetter(seq)
        '        jda.Sequence = seq
        '        Me.Job.JobDrawingAnnotations.Add(jda)
        '    Next
        '    JobDrawingAnnotationsBindingSource.DataSource = Me.Job.JobDrawingAnnotations
        'End If

        If job.Drawing.NumberOfAnnotations IsNot Nothing AndAlso job.JobDrawingAnnotationsList.Count < job.Drawing.NumberOfAnnotations Then
            For seq As Integer = job.JobDrawingAnnotationsList.Count + 1 To job.Drawing.NumberOfAnnotations
                Dim jda As New API.JobDrawingAnnotation
                jda.Job = Me.Job
                jda.Code = NumberToLetter(seq)
                jda.Sequence = seq
                Me.Job.JobDrawingAnnotations.Add(jda)
            Next
            JobDrawingAnnotationsBindingSource.DataSource = Me.Job.JobDrawingAnnotations
        End If
    End Sub

    Public Shared Function NumberToLetter(ByVal column As Integer) As String
        Dim columnString As String = ""
        Dim columnNumber As Decimal = column
        While columnNumber > 0
            Dim currentLetterNumber As Decimal = (columnNumber - 1) Mod 26
            Dim CharValue As Integer = currentLetterNumber + 65
            Dim currentLetter As Char = Convert.ToChar(CharValue)
            columnString = currentLetter & columnString
            columnNumber = (columnNumber - (currentLetterNumber + 1)) / 26
        End While
        Return columnString
    End Function

    Protected Overrides Sub SetCLH()
        MyBase.SetCLH()
        'CLH.Components.Add(gcAnotations)
        'CLH.Components.Add(pgcJobTolerances)
    End Sub

End Class

Public Class xfgJobDrawings
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Job)
End Class