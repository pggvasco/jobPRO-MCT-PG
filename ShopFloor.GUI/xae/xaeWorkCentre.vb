Public Class xaeWorkCentre
    Inherits xaegWorkCentre

    Dim Loaded As Boolean
    Private Sub xaeWorkCentre_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Loaded = False
        CalculationTypeLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.CalculationType))

        Try
            Dim clm As New Helper.ActiveRecord.LookupMaintenance(Of API.WorkCentreCategory)(WorkCentreCategoryLookUpEdit, xaeWorkCentreCategory, AddressOf LoadWorkCentreCategories, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Work Centre Categories.", ex)
        End Try

        Try
            Dim cclm As New Helper.ActiveRecord.LookupMaintenance(Of API.CostCentre)(CostCentreLookUpEdit, xaeCostCentre, AddressOf LoadCostCentres, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Cost Centres.", ex)
        End Try

        Try
            Dim cclm As New Helper.ActiveRecord.LookupMaintenance(Of API.EvoProject)(ProjectLookUpEdit1, Nothing, AddressOf LoadAllProjects, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Cost Centres.", ex)
        End Try



        'Try
        '    Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.EvoProject)(ProjectLookUpEdit1, AddressOf LoadAllProjects, False)
        'Catch ex As Exception
        '    Setup.Log.logError("Error setting loader for Warehouses.", ex)
        'End Try

        Loaded = True
    End Sub

    Private Sub SetDefaultData()
        If Me.Record.ID = 0 Then
            Me.Record.Factor = 1
            Me.Record.HourlyRate = 0
        End If
    End Sub

    Private Function LoadAllProjects() As IEnumerable(Of API.EvoProject)
        Dim crit = NHibernate.Criterion.DetachedCriteria.For(Of API.EvoProject)()
        crit.Add(NHibernate.Criterion.Expression.Sql("Active=1"))

        Return API.EvoProject.FindAll(crit)

    End Function

    Private Function LoadWorkCentreCategories() As IEnumerable(Of API.WorkCentreCategory)
        Return API.WorkCentreCategory.FindAll
    End Function

    Private Function LoadCostCentres() As IEnumerable(Of API.CostCentre)
        Return API.CostCentre.FindAll
    End Function

    Private Sub CalculationTypeLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CalculationTypeLookUpEdit.EditValueChanged
        If Me.Record IsNot Nothing Then
            Me.Record.CalculationType = CType(IIf(IsDBNull(CalculationTypeLookUpEdit.EditValue), Nothing, CalculationTypeLookUpEdit.EditValue), API.CalculationType)
            Select Case CType(CalculationTypeLookUpEdit.EditValue, API.CalculationType)
                Case API.CalculationType.Formula
                    RecoveryServiceCodeTextEdit.Properties.ReadOnly = True
                    FormulaTextEdit.Properties.ReadOnly = False
                    Me.Record.Formula = ""
                    HourlyRateSpinEdit.Properties.ReadOnly = True
                    Me.Record.HourlyRate = Nothing
                Case API.CalculationType.Recovery
                    RecoveryServiceCodeTextEdit.Properties.ReadOnly = False
                    FormulaTextEdit.Properties.ReadOnly = True
                    HourlyRateSpinEdit.Properties.ReadOnly = False
                Case API.CalculationType.Standard
                    RecoveryServiceCodeTextEdit.Properties.ReadOnly = True
                    FormulaTextEdit.Properties.ReadOnly = True
                    Me.Record.Formula = ""
                    '  HourlyRateSpinEdit.Properties.ReadOnly = True
                    Me.Record.HourlyRate = Nothing
            End Select
        End If
    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))

        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "Code" Then
                CodeTextEdit.ErrorText = errors(prop)(0)
            ElseIf prop.Name = "Description" Then
                DescriptionTextEdit.ErrorText = errors(prop)(0)
            Else
            End If
        Next
    End Sub

    Dim ButtonClicked As String = ""

    Private Sub CheckButtons()
        Dim cnt As Integer

        If chkBuyOut.Checked Then
            cnt = cnt + 1
        End If

        If chkGLExpense.Checked Then
            cnt = cnt + 1
        End If

        If chkAPExpense.Checked Then
            cnt = cnt + 1
        End If

        If cnt > 1 Then
            MessageBox.Show("Only one option can be selected")
            'chkAPExpense.Checked = False
            'chkGLExpense.Checked = False
            'chkBuyOut.Checked = False
        End If

        'Select Case Control
        '    Case "Buy"
        '        ButtonClicked = "buy"
        '        chkAPExpense.Checked = False
        '        chkGLExpense.Checked = False

        '        If IsBuyOutCheckEdit.Checked = False Then
        '            IsBuyOutCheckEdit.Checked = True
        '        Else
        '            IsBuyOutCheckEdit.Checked = False
        '        End If

        '        ButtonClicked = ""
        '    Case "AP"
        '        ButtonClicked = "ap"
        '        IsBuyOutCheckEdit.Checked = False
        '        chkGLExpense.Checked = False

        '        If chkAPExpense.Checked = True Then
        '            chkAPExpense.Checked = False
        '        Else
        '            chkAPExpense.Checked = True
        '        End If

        '        ButtonClicked = ""
        '    Case "GL"
        '        ButtonClicked = "gl"
        '        chkAPExpense.Checked = False
        '        IsBuyOutCheckEdit.Checked = False

        '        If chkGLExpense.Checked = True Then
        '            chkGLExpense.Checked = False
        '        Else
        '            chkGLExpense.Checked = True
        '        End If

        '        ButtonClicked = ""
        'End Select
    End Sub

    Private Sub chkGLExpense_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGLExpense.CheckedChanged
        'CheckButtons()
    End Sub

    Private Sub chkAPExpense_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAPExpense.CheckedChanged
        'CheckButtons()
    End Sub

    Private Sub chkBuyOut_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkBuyOut.CheckedChanged
        ' CheckButtons()
    End Sub

End Class

Public Class xaegWorkCentre
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.WorkCentre)
End Class


