
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Drawing

Public Class xaeJobMemos
    Inherits xaegJobMemos


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

    Private Sub xaeJobMemos_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetCLH()
        Catch ex As Exception
            Setup.Log.logError("Error setting component layout helper.", ex)
        End Try

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

    Protected Overrides Sub SetCLH()
        MyBase.SetCLH()
    End Sub

    Private Sub bbiSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        SaveRecord()
        ' set DialogResult to none so that form does not close on save
        Me.DialogResult = Windows.Forms.DialogResult.None
    End Sub

    Private Sub bbiAddLine_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAddLine.ItemClick
        gvJobNotes.CloseEditor()
        'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
        Dim xaejm As New xaeJobMemo With {.Record = New API.JobMemo With {.CreateDate = Now, .Job = Record, .JobStage = Record.JobStage}}
        'xaejn.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiAddLine.Glyph)
        Select Case Record.State
            Case API.JobState.Active
                xaejm.Text = "Job Memo"
            Case API.JobState.Quote
                xaejm.Text = "Quote Memo"
            Case Else
                xaejm.DataLayoutControl1.Enabled = False
        End Select
        xaejm.Conversation = Me.Conversation
        xaejm.JobLookUpEdit.Properties.ReadOnly = True
        If xaejm.ShowDialog = DialogResult.OK Then
            Me.Record.JobMemoes.Add(xaejm.Record)
            'SaveRecord()
            'Me.DialogResult = Windows.Forms.DialogResult.None
            RefreshGrid()
            BindingSource.DataSource = Me.Record
        End If

    End Sub

    Private Sub bbiEditLine_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditLine.ItemClick
        gvJobNotes.CloseEditor()
        Dim jm As API.JobMemo = gvJobNotes.GetFocusedRow
        If jm IsNot Nothing AndAlso jm.ID > 0 Then
            Dim xaejm As New xaeJobMemo With {.Record = jm}
            'xaejn.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiEditLine.Glyph)
            Select Case Record.State
                Case API.JobState.Active
                    xaejm.Text = "Job Memo"
                Case API.JobState.Quote
                    xaejm.Text = "Quote Memo"
                Case API.JobState.History
                    xaejm.Text = "Job Memo"
                Case API.JobState.Archive
                    xaejm.Text = "Job Memo"
                Case API.JobState.Cancelled
                    xaejm.Text = "Quote Memo"
                Case Else
                    xaejm.DataLayoutControl1.Enabled = False
            End Select
            'Me.Conversation.Restart()
            If bbiEditLine.Caption = "View Memo" Then
                xaejm.JobStageLookUpEdit.Enabled = False
                xaejm.JobStageLookUpEdit.Properties.Enabled = False
                'xaejm.MemoRichEditControl.ReadOnly = True
                xaejm.bsiImport.Enabled = False
                xaejm.btSave.Enabled = False
            End If
            xaejm.JobLookUpEdit.Properties.ReadOnly = True
            'xaejm.ShowDialog()
            If xaejm.ShowDialog = DialogResult.OK Then
                'Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                '    TryCast(gvJobNotes.GetFocusedRow, API.JobMemo).Refresh()
                'End Using
                RefreshGrid()
                BindingSource.DataSource = Me.Record
                ' gvJobNotes.RefreshRow(gvJobNotes.FocusedRowHandle)
            End If
            Refresh()
        End If
    End Sub

    Private Sub RefreshJob()
        Try
            gvJobNotes.CloseEditor()
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                Me.Record.Refresh()
                'Me.RefreshGrid()
            End Using

            Me.Refresh()
            'JobMemoListBindingSource.DataSource = Me.Record.JobMemoList
            'Application.DoEvents()
            'Conversation.Restart()
        Catch ex As Exception
            Me.Conversation.Restart()
            Setup.Log.logError("Error refreshing Job.", ex)
        End Try
    End Sub

    Public Sub RefreshGrid()
        'BindingSource.DataSource = API.Job.FindAllByProperty("ID", Me.Record.ID)
        'JobNoteListBindingSource.DataSource = API.Note.FindAllByProperty("Job", Me.Record)
        gvJobNotes.RefreshData()
    End Sub

    Private Sub gvJobNotes_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles gvJobNotes.CalcRowHeight
        Dim view As GridView = sender
        If Not view.IsGroupRow(e.RowHandle) Then
            'If view.GetVisibleIndex(e.RowHandle) Mod 2 = 0 Then
            'e.RowHeight = GetColumnBestHeight(CType(view.GetViewInfo(), GridViewInfo), colContents)
            e.RowHeight = 100
            'End If
        End If
        'gvJobNotes.OptionsView.RowAutoHeight = True
    End Sub

    Private Function GetColumnBestHeight(ByVal viewInfo As GridViewInfo, ByVal column As GridColumn) As Integer
        Dim ex As GridColumnInfoArgs = viewInfo.ColumnsInfo(column)
        If ex Is Nothing Then
            viewInfo.GInfo.AddGraphics(Nothing)
            ex = New GridColumnInfoArgs(viewInfo.GInfo.Cache, Nothing)
            Try
                ex.InnerElements.Add(New DrawElementInfo(New GlyphElementPainter(), New GlyphElementInfoArgs(viewInfo.View.Images, 0, Nothing), StringAlignment.Near))
                If viewInfo.View.CanShowFilterButton(Nothing) Then
                    ex.InnerElements.Add(viewInfo.Painter.ElementsPainter.FilterButton, New GridFilterButtonInfoArgs())
                End If
                ex.SetAppearance(viewInfo.PaintAppearance.HeaderPanel)
                ex.Caption = column.Caption
                ex.CaptionRect = New Rectangle(0, 0, column.Width - 20, 17)
            Finally
                viewInfo.GInfo.ReleaseGraphics()
            End Try
        End If
        Dim grInfo As New GraphicsInfo()
        grInfo.AddGraphics(Nothing)
        ex.Cache = grInfo.Cache
        Dim canDrawMore As Boolean = True
        Dim captionSize As Size = CalcCaptionTextSize(grInfo.Cache, TryCast(ex, HeaderObjectInfoArgs), column.GetCaption())
        Dim res As Size = ex.InnerElements.CalcMinSize(grInfo.Graphics, canDrawMore)
        res.Height = Math.Max(res.Height, captionSize.Height)
        res.Width += captionSize.Width
        res = viewInfo.Painter.ElementsPainter.Column.CalcBoundsByClientRectangle(ex, New Rectangle(Point.Empty, res)).Size
        grInfo.ReleaseGraphics()
        Return res.Height
    End Function

    Private Function CalcCaptionTextSize(ByVal cache As GraphicsCache, ByVal ee As HeaderObjectInfoArgs, ByVal caption As String) As Size
        Dim captionSize As Size = ee.Appearance.CalcTextSize(cache, caption, ee.CaptionRect.Width).ToSize()
        captionSize.Height += 1
        captionSize.Width += 1
        Return captionSize
    End Function

    Protected Overrides Sub SaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btSave.Click
        Me.Close()
    End Sub

    Private Sub xaeJobMemos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        gvJobNotes.CloseEditor()
    End Sub
End Class

Public Class xaegJobMemos
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Job)
    Public Sub New()
        MyBase.New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub
End Class