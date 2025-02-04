Public Class xlJob 
    Inherits xlgJob

    Private Property PreviewPanelButton As DevExpress.XtraBars.BarButtonItem

    Public Overrides Sub PreLayout()
        PreviewPanelButton = New DevExpress.XtraBars.BarButtonItem(barManager, "Preview Panel")
        PreviewPanelButton.Glyph = UniSource.Helper.GUI.My.Resources.magnifier
        PreviewPanelButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        PreviewPanelButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        PreviewPanelButton.Id = 90
        AddHandler PreviewPanelButton.ItemClick, AddressOf ShowPreviewPanel
        barMenu.AddItem(PreviewPanelButton)

        Try
            AddAdditionalEnquiryFields()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error creating user-defined enquiry fields.", ex)
        End Try

        Try
            RebindAdditionalEnquiryFields()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error binding user-defined enquiry fields.", ex)
        End Try

        MyBase.PreLayout()
    End Sub

    Public Overrides Sub SetCLH()
        MyBase.SetCLH()
        CLH.AddSaveEvent(GridView, "Layout")
        CLH.AddSaveEvent(barManager, "EndCustomization")
        CLH.AddSaveEvent(dlcJobEnquiry, "HideCustomization")
        CLH.Components.Add(DockManager, String.Format("{0}DockManager - {1}", LookupType.Name, Criterion.ToString))
        CLH.Components.Add(dlcJobEnquiry, "dlcJob - " & Criterion.ToString)
    End Sub

    Private Sub ShowPreviewPanel(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        If PreviewPanelButton IsNot Nothing Then
            If PreviewPanelButton.Down Then
                JobEnquiryDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
                JobEnquiryDockPanel.Show()
            Else
                JobEnquiryDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                JobEnquiryDockPanel.HideSliding()
            End If
        End If
    End Sub

    Private Sub DockManager_VisibilityChanged(sender As System.Object, e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles DockManager.VisibilityChanged
        Select Case JobEnquiryDockPanel.Visibility
            Case DevExpress.XtraBars.Docking.DockVisibility.AutoHide, DevExpress.XtraBars.Docking.DockVisibility.Visible
                PreviewPanelButton.Down = True
            Case DevExpress.XtraBars.Docking.DockVisibility.Hidden
                PreviewPanelButton.Down = False
        End Select
        CLH.SaveLayouts()
    End Sub

    Private Sub DockManager_EndSizing(sender As System.Object, e As DevExpress.XtraBars.Docking.EndSizingEventArgs) Handles DockManager.EndSizing
        CLH.SaveLayouts()
    End Sub

    Private Sub DockManager_EndDocking(sender As System.Object, e As DevExpress.XtraBars.Docking.EndDockingEventArgs) Handles DockManager.EndDocking
        CLH.SaveLayouts()
    End Sub

    Public Sub AddAdditionalEnquiryFields()
        If dlcJobEnquiry IsNot Nothing Then
            For Each udef As Helper.ActiveRecord.Evolution.UserDefinedField In UniSource.Helper.ActiveRecord.Evolution.UserDefinedField.FindAllByType(GetType(API.Job))
                dlcJobEnquiry.AddItem(udef.GetLayoutControlItem)
            Next
        End If
    End Sub

    Public Sub RebindAdditionalEnquiryFields()
        If dlcJobEnquiry IsNot Nothing Then
            For Each lci As DevExpress.XtraLayout.BaseLayoutItem In dlcJobEnquiry.Items
                Dim bc As UniSource.Helper.ActiveRecord.UserDefinedFieldBindingContext = TryCast(lci.Tag, UniSource.Helper.ActiveRecord.UserDefinedFieldBindingContext)
                If bc IsNot Nothing Then
                    bc.ReBind(Me.BindingSource.Current)
                End If
            Next
        End If
    End Sub

    Private Sub BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles BindingSource.CurrentChanged
        Try
            RebindAdditionalEnquiryFields()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error binding user-defined enquiry fields.", ex)
        End Try
    End Sub

    Private Sub SetFocusedRowColor(ByVal job As API.Job)
        If job IsNot Nothing Then
            If job.Customer.OnHold Then
                gvJob.Appearance.FocusedRow.BackColor = Color.Gray
            ElseIf job.JobNoteList.Count > 0 Then
                gvJob.Appearance.FocusedRow.BackColor = Color.Red
            Else
                gvJob.Appearance.FocusedRow.BackColor = Color.Blue
            End If
            gvJob.Appearance.SelectedRow.BackColor = gvJob.Appearance.FocusedRow.BackColor
            'System.GC.Collect()
        End If
    End Sub

    Private Sub gvJob_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvJob.RowStyle
        If e.RowHandle > -1 Then
            Dim job As API.Job = gvJob.GetRow(e.RowHandle)
            'e.HighPriority = True
            If job IsNot Nothing Then
                If e.RowHandle = gvJob.FocusedRowHandle Then
                    ' SetFocusedRowColor(job)
                ElseIf job.Customer.OnHold Then
                    e.Appearance.BackColor = Color.Gray
                    e.Appearance.BackColor2 = Color.White
                ElseIf job.JobNoteList.Count > 0 Then
                    e.Appearance.BackColor = Color.Salmon
                    e.Appearance.BackColor2 = Color.SeaShell
                End If
            End If
        End If
    End Sub

    Public Overrides Sub ReleaseResources()
        gvJob.Dispose()
        gcJob.Dispose()
        dlcJobEnquiry.Dispose()
        JobEnquiryDockPanel.Dispose()
        MyBase.ReleaseResources()
    End Sub

End Class

Public Class xlgJob
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.Job)

    Public Sub New()
        MyBase.New()
    End Sub

End Class