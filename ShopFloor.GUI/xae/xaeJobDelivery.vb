﻿Public Class xaeJobDelivery 
    Inherits xaegJobDelivery

    'Public Property Defaults As API.Defaults

    Private Sub xaeJobDelivery_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'If Defaults Is Nothing Then LoadDefaults()

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of API.Job)(JobLookUpEdit, AddressOf LoadJobs, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Jobs.", ex)
        End Try

        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of Pastel.Evolution.Agent)(ResponsibleAgentIDLookUpEdit, AddressOf LoadAgents, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Responsible Agent.", ex)
        End Try

        Try
            SetState()
        Catch ex As Exception
            Setup.Log.logError("Error setting state.", ex)
        End Try

    End Sub

    Private Sub LoadDefaults()
        'Try
        '    Defaults = API.Defaults.Defaults
        'Catch ex As Exception
        '    Setup.Log.logError("Error loading System Defaults.", ex)
        'End Try
    End Sub

    Private Sub SetNumbering()
        'If Defaults Is Nothing Then LoadDefaults()
        If Me.Record.ID = 0 Then
            Me.Record.DeliveryDate = Today.Date
            Me.Record.AgentID = Setup.Agent.ID
            If Me.Record.ResponsibleAgentID Is Nothing OrElse Me.Record.ResponsibleAgentID <= 0 Then
                Me.Record.ResponsibleAgentID = Setup.Agent.ID
            End If
            'Me.Record.AgentName = Setup.Agent.Name
            If IIf(API.Context.Defaults.IsDeliveryNumberAutoGenerated.HasValue, API.Context.Defaults.IsDeliveryNumberAutoGenerated, False) Then
                DeliveryNumberTextEdit.Properties.ReadOnly = True
                Me.Record.DeliveryNumber = API.Defaults.Defaults.GetNextDeliveryNumber(Me.Record) + " *"
            Else
                DeliveryNumberTextEdit.Properties.ReadOnly = False
            End If
        Else
            DeliveryNumberTextEdit.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub SetState()
        If Me.Record.ID = 0 Then
            If Me.Record.Job IsNot Nothing Then
                JobLookUpEdit.Properties.ReadOnly = True
                DeliveryDateDateEdit.Properties.ReadOnly = False
                QuantitySpinEdit.Properties.ReadOnly = False
                If Record.Job IsNot Nothing Then
                    Record.Job.JobDeliveryList.ToString()
                    Dim remainder As Double = IIf(Record.Job.Quantity.HasValue, Record.Job.Quantity, 0)
                    If Record.Job.QuantityDelivered.HasValue Then
                        remainder -= Record.Job.QuantityDelivered
                    End If
                    Record.Quantity = remainder
                    QuantitySpinEdit.EditValue = remainder
                End If
                ResponsibleAgentIDLookUpEdit.Properties.ReadOnly = False
                Information1TextEdit.Properties.ReadOnly = False
                Information2TextEdit.Properties.ReadOnly = False
                ReasonTextEdit.Properties.ReadOnly = False
            Else
                JobLookUpEdit.Properties.ReadOnly = False
                DeliveryDateDateEdit.Properties.ReadOnly = True
                QuantitySpinEdit.Properties.ReadOnly = True
                ResponsibleAgentIDLookUpEdit.Properties.ReadOnly = True
                Information1TextEdit.Properties.ReadOnly = True
                Information2TextEdit.Properties.ReadOnly = True
                ReasonTextEdit.Properties.ReadOnly = True
            End If
        Else
            JobLookUpEdit.Properties.ReadOnly = True
            DeliveryDateDateEdit.Properties.ReadOnly = True
            QuantitySpinEdit.Properties.ReadOnly = True
            ResponsibleAgentIDLookUpEdit.Properties.ReadOnly = True
            Information1TextEdit.Properties.ReadOnly = True
            Information2TextEdit.Properties.ReadOnly = True
            ReasonTextEdit.Properties.ReadOnly = True
        End If
    End Sub

    Protected Overrides Sub SetCLH()
        MyBase.SetCLH()
        CLH.Components.Add(JobDeliveryDataLayoutControl)
    End Sub

    Private Function LoadJobs() As IEnumerable(Of API.Job)
        Return API.Job.FindAllByState(API.JobState.Active)
    End Function


 Private Function LoadAgents() As IList(Of Pastel.Evolution.Agent)
        Setup.EvolutionHelper.ActivateEvolution()
        Return API.Job.GetAgents()
    End Function


    Private Sub JobLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles JobLookUpEdit.EditValueChanged
        If Me.Record IsNot Nothing Then
            If Me.Record.ID = 0 Then
                Me.Record.Job = JobLookUpEdit.EditValue

                Try
                    SetNumbering()
                Catch ex As Exception
                    Setup.Log.logError("Error setting numbering.", ex)
                End Try

                Try
                    SetState()
                Catch ex As Exception
                    Setup.Log.logError("Error setting state.", ex)
                End Try

            End If
        End If
    End Sub

    Protected Overrides Sub ValidationError(ByVal errors As Dictionary(Of Reflection.PropertyInfo, ArrayList))
        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "DeliveryNumber" Then
                DeliveryNumberTextEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "Job" Then
                JobLookUpEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "DeliveryDate" Then
                DeliveryDateDateEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "Quantity" Then
                QuantitySpinEdit.ErrorText = errors(prop)(0)
            End If
        Next
        MyBase.ValidationError(errors)
    End Sub

End Class

Public Class xaegJobDelivery
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.JobDelivery)

End Class