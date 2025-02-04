Public Class xfNextStage

    Public Property CLH As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper

    Public Property Job As API.Job
        Get
            Return CType(JobBindingSource.Current, API.Job)
        End Get
        Set(value As API.Job)
            JobBindingSource.Clear()
            JobBindingSource.Add(value)
        End Set
    End Property

    Public Property User As Pastel.Evolution.Agent

    Public Sub New(ByVal job As API.Job)
        InitializeComponent()

        Me.Job = job

    End Sub

    Private Sub xfNextStage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CLH = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        CLH.Components.Add(LayoutControl)
        Me.UserNameTextEdit.EditValue = Setup.Agent.Name

        Try
            LoadFieldPromptEditors()
        Catch ex As Exception
            Setup.Log.logError("Error loading Field Prompts.", ex)
        End Try
    End Sub

    Private Sub LoadFieldPromptEditors()
        If Job.NextStage IsNot Nothing Then
            For Each fp As API.JobStageFieldPrompt In Job.NextStage.FieldPrompts
                If IIf(IsDBNull(fp.PromptBefore), False, fp.PromptBefore) Then
                    Dim prop As Reflection.PropertyInfo = GetType(API.Job).GetProperty(fp.FieldName, Reflection.BindingFlags.Public Or Reflection.BindingFlags.Instance)
                    If prop Is Nothing Then
                        Dim udef As Helper.ActiveRecord.Evolution.UserDefinedField = UniSource.Helper.ActiveRecord.Evolution.UserDefinedField.FindByTypeAndFieldName(GetType(API.Job), fp.FieldName)
                        If udef IsNot Nothing Then
                            FieldPromptsLayoutControlGroup.AddItem(udef.GetLayoutControlItem)
                        End If
                    Else
                        FieldPromptsLayoutControlGroup.AddItem(Job.GetLayoutControlItem(fp.FieldName, Nothing))
                    End If
                End If
            Next


            For Each fp As API.JobStageFieldPrompt In Job.JobStage.FieldPrompts
                If IIf(IsDBNull(fp.PromptAfter), False, fp.PromptAfter) Then
                    Dim prop As Reflection.PropertyInfo = GetType(API.Job).GetProperty(fp.FieldName, Reflection.BindingFlags.Public Or Reflection.BindingFlags.Instance)
                    If prop Is Nothing Then
                        Dim udef As Helper.ActiveRecord.Evolution.UserDefinedField = UniSource.Helper.ActiveRecord.Evolution.UserDefinedField.FindByTypeAndFieldName(GetType(API.Job), fp.FieldName)
                        If udef IsNot Nothing Then
                            FieldPromptsLayoutControlGroup.AddItem(udef.GetLayoutControlItem)
                        End If
                    Else
                        FieldPromptsLayoutControlGroup.AddItem(Job.GetLayoutControlItem(fp.FieldName, Nothing))
                    End If
                End If
            Next
        End If
    End Sub


    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click

        Try
            If Not TestInfo() Then
                Exit Sub
            End If
        Catch ex As Exception
            Setup.Log.logError("Error checking supplied information.", ex)
            Exit Sub
        End Try

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Function FormatBool(ByVal stringToConvertToBool As String) As Boolean
        If stringToConvertToBool.ToLower = "True".ToLower Or stringToConvertToBool = "1" Then
            Return True
        ElseIf stringToConvertToBool.ToLower = "False".ToLower Or stringToConvertToBool = "0" Then
            Return False
        Else
            Return Nothing
        End If
    End Function
    Private Function TestInfo()
        Dim check As Boolean = True

        'validation for Field prompts
        If FieldPromptsLayoutControlGroup.Items.Count > 0 Then
            For Each LayoutControlItem As DevExpress.XtraLayout.LayoutControlItem In FieldPromptsLayoutControlGroup.Items
                Dim BaseEditControl As DevExpress.XtraEditors.BaseEdit = LayoutControlItem.Control
                Dim FieldPrompt As API.JobStageFieldPrompt
                Try
                    FieldPrompt = Job.NextStage.FieldPrompts.Where(Function(num) num.FieldName = BaseEditControl.Name.Substring(4)).First
                Catch
                    FieldPrompt = Job.JobStage.FieldPrompts.Where(Function(num) num.FieldName = BaseEditControl.Name.Substring(4)).First
                End Try
                Select Case BaseEditControl.GetType
                    Case GetType(DevExpress.XtraEditors.TextEdit), GetType(DevExpress.XtraEditors.DateEdit)
                        If FieldPrompt.IsRequired And (IIf(IsDBNull(BaseEditControl.EditValue), Nothing, BaseEditControl.EditValue) Is Nothing Or IIf(IsDBNull(BaseEditControl.EditValue), "", BaseEditControl.EditValue) = "") Then
                            BaseEditControl.ErrorText = "Please specify a " + FieldPrompt.FieldName
                            check = False
                        ElseIf FieldPrompt.RequiredValue IsNot Nothing And FieldPrompt.RequiredValue <> "" And BaseEditControl.EditValue <> FieldPrompt.RequiredValue Then
                            BaseEditControl.ErrorText = "Invalid Value For " + FieldPrompt.FieldName
                            check = False
                        End If
                        'Case GetType(DevExpress.XtraEditors.SpinEdit)

                        'Case GetType(DevExpress.XtraEditors.DateEdit)
                    Case GetType(DevExpress.XtraEditors.SpinEdit)
                        If FieldPrompt.RequiredValue IsNot Nothing And FieldPrompt.RequiredValue <> "" And BaseEditControl.EditValue <> FieldPrompt.RequiredValue Then
                            BaseEditControl.ErrorText = "Invalid Value For " + FieldPrompt.FieldName
                            check = False
                        End If
                    Case GetType(DevExpress.XtraEditors.CheckEdit)
                        Dim XtraEditorsCheckEdit As DevExpress.XtraEditors.CheckEdit = CType(BaseEditControl, DevExpress.XtraEditors.CheckEdit)
                        If FieldPrompt.IsRequired And (IIf(IsDBNull(XtraEditorsCheckEdit.EditValue), Nothing, XtraEditorsCheckEdit.EditValue)) Is Nothing Then
                            BaseEditControl.ErrorText = "Please specify a " + FieldPrompt.FieldName
                            check = False
                        ElseIf IsNothing(FormatBool(FieldPrompt.RequiredValue)) = False And XtraEditorsCheckEdit.EditValue <> FormatBool(FieldPrompt.RequiredValue) Then
                            BaseEditControl.ErrorText = "Invalid Value For " + FieldPrompt.FieldName
                            check = False
                        End If
                    Case Else
                        'DevExpress.XtraEditors.TextEdit
                        If FieldPrompt.IsRequired And (IIf(IsDBNull(BaseEditControl.EditValue), Nothing, BaseEditControl.EditValue) Is Nothing Or IIf(IsDBNull(BaseEditControl.EditValue), "", BaseEditControl.EditValue) = "") Then
                            BaseEditControl.ErrorText = "Please specify a " + FieldPrompt.FieldName
                            check = False
                        ElseIf FieldPrompt.RequiredValue IsNot Nothing And FieldPrompt.RequiredValue <> "" And BaseEditControl.EditValue <> FieldPrompt.RequiredValue Then
                            BaseEditControl.ErrorText = "Invalid Value For " + FieldPrompt.FieldName
                            check = False
                        End If
                End Select
            Next
        End If

        If String.IsNullOrEmpty(UserNameTextEdit.Text) Then
            UserNameTextEdit.ErrorText = "Please specify a user name."
            check = False
        End If

        If String.IsNullOrEmpty(UserPasswordTextEdit.Text) Then
            UserPasswordTextEdit.ErrorText = "Please specify a user password."
            check = False
        End If

        If Not check Then
            Return False
        End If

        Try
            User = Pastel.Evolution.Agent.GetByName(UserNameTextEdit.Text)
        Catch ex As Exception
            Setup.Log.logError("Error trying to get User.", ex)
            Return False
        End Try

        If User Is Nothing Then
            UserNameTextEdit.ErrorText = "User not found."
            Return False
        End If

        If Not Pastel.Evolution.Agent.Authenticate(User.Name, UserPasswordTextEdit.Text) Then
            UserPasswordTextEdit.ErrorText = "Incorrect password."
            Return False
        End If
        API.Context.SecondAgent = New Pastel.Evolution.Agent(User.Name)
        Return True
    End Function

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class