﻿Public Class xaeJobTime 
    Inherits xaegJobTime
    Private Property job As API.Job
    Private Property workCentreCategory As API.WorkCentreCategory
    Private userFieldsLoaded As Boolean = False

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Private Sub xaeJobTime_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Try
        '    Defaults = API.Defaults.Defaults
        'Catch ex As Exception
        '    Setup.Log.logError("Error loading System Defaults.", ex)
        'End Try

        Try
            SetCLH()
        Catch ex As Exception
            Setup.Log.logError("Error setting component layout helper.", ex)
        End Try
        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of Helper.ActiveRecord.Evolution.Client)(CustomerSearchLookUpEdit, AddressOf LoadClients, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Client.", ex)
        End Try
        Try
            Dim rbl As New Helper.Evolution.LookupLoader(Of Pastel.Evolution.SalesRepresentative)(RepresentativeLookUpEdit, SalesRepresantativeBindingSource, "idSalesRep")
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Sales Reps.", ex)
        End Try


        
        Try
            Dim tlm As New Helper.ActiveRecord.LookupMaintenance(Of API.JobType)(JobTypeLookUpEdit, xaeJobType, AddressOf LoadTypes, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Job Types.", ex)
        End Try

        Try
            Dim cclm As New Helper.ActiveRecord.LookupMaintenance(Of API.CostCentre)(CostCentreLookUpEdit, xaeCostCentre, AddressOf LoadCostCentres, Me.Conversation)
        Catch ex As Exception
            Setup.Log.logError("Error setting lookup maintenance for Cost Centres.", ex)
        End Try



        Try
            SetDefaultData()
        Catch ex As Exception
            Setup.Log.logError("Error setting default data on job.", ex)
        End Try

        Try
            SetNumbering()
        Catch ex As Exception
            Setup.Log.logError("Error setting numbering on job.", ex)
        End Try
        Try
            LoadEnums()
        Catch ex As Exception
            Setup.Log.logError("Error  Load Enums on job.", ex)
        End Try

    End Sub
    Private Sub LoadEnums()
        SourceLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.Source))
    End Sub

    Private Sub SetDefaultData()

        Select Case Me.Record.State
            Case API.JobState.Active
                If IIf(API.Context.Defaults.IsJobNumberAutoGenerated.HasValue, API.Context.Defaults.IsJobNumberAutoGenerated, False) Then

                    JobNumberTextEdit.Properties.ReadOnly = True
                Else
                    JobNumberTextEdit.Properties.ReadOnly = False

                End If
            Case API.JobState.Quote
                If IIf(API.Context.Defaults.IsQuoteNumberAutoGenerated.HasValue, API.Context.Defaults.IsQuoteNumberAutoGenerated, False) Then

                    JobNumberTextEdit.Properties.ReadOnly = True
                Else
                    JobNumberTextEdit.Properties.ReadOnly = True

                End If
        End Select
       
    End Sub

    Private Sub SetNumbering()
        If Me.Record.ID = 0 Then

            Select Case Me.Record.State
                Case API.JobState.Active
                    Me.Record.JobDate = Today.Date
                    Me.Record.SourceID = API.Source.ManualJob
                    Me.Record.JobAgentID = Setup.Agent.ID
                    If IIf(API.Context.Defaults.IsJobNumberAutoGenerated.HasValue, API.Context.Defaults.IsJobNumberAutoGenerated, False) Then
                        Me.Record.JobNumber = API.Defaults.Defaults.GetNextJobNumber(Me.Record) + " *"
                    End If
                Case API.JobState.Quote
                    Me.Record.QuoteDate = Today.Date
                    Me.Record.QuoteAgentID = Setup.Agent.ID
                    If IIf(API.Context.Defaults.IsQuoteNumberAutoGenerated.HasValue, API.Context.Defaults.IsQuoteNumberAutoGenerated, False) Then
                        Me.Record.QuoteNumber = API.Defaults.Defaults.GetNextQuoteNumber(Me.Record) + " *"
                    End If
                Case Else
                    Throw New Exception(String.Format("New Job cannot have state of {0}.", Me.Record.State))
            End Select
        Else
            JobNumberTextEdit.Properties.ReadOnly = True
        End If
    End Sub

    Protected Overrides Sub SetCLH()

        'Setting up user def fields
        'If userFieldsLoaded = False Then
        Try
            AddAdditionalEnquiryFields()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error creating user-defined enquiry fields.", ex)
        End Try
        'End If
        Try
            RebindAdditionalEnquiryFields()
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error binding user-defined enquiry fields.", ex)
        End Try
        'userFieldsLoaded = True

        ' user fields end

        MyBase.SetCLH()
        ' CLH.Components.Add(JobDataLayoutControl)
        CLH.Components.Add(AdditionalFieldsLayoutControlLayoutControl)
        CLH.AddSaveEvent(AdditionalFieldsLayoutControlLayoutControl, "HideCustomization")

    End Sub

    Public Sub AddAdditionalEnquiryFields()
        If AdditionalFieldsLayoutControlLayoutControl IsNot Nothing Then
            For Each udef As Helper.ActiveRecord.Evolution.UserDefinedField In UniSource.Helper.ActiveRecord.Evolution.UserDefinedField.FindAllByType(GetType(API.Job))
                AdditionalFieldsLayoutControlLayoutControl.AddItem(udef.GetLayoutControlItem)
            Next
        End If
    End Sub

    Public Sub RebindAdditionalEnquiryFields()
        If AdditionalFieldsLayoutControlLayoutControl IsNot Nothing Then
            For Each lci As DevExpress.XtraLayout.BaseLayoutItem In AdditionalFieldsLayoutControlLayoutControl.Items
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

    Private Function LoadClients() As IEnumerable(Of Helper.ActiveRecord.Evolution.Client)
        Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
            Return UniSource.Helper.ActiveRecord.Evolution.Client.FindAll
        End Using
    End Function
    Private Function LoadWorkCentreCategories() As IEnumerable(Of API.WorkCentreCategory)
        Return API.WorkCentreCategory.FindAll
    End Function

    Private Function LoadCategories() As IEnumerable(Of API.JobCategory)
        Return API.JobCategory.FindAll

    End Function

    Private Function LoadTypes() As IEnumerable(Of API.JobType)
        Return API.JobType.FindAll
    End Function

    Private Function LoadCostCentres() As IEnumerable(Of API.CostCentre)
        Return API.CostCentre.FindAll
    End Function


    Protected Overrides Sub ValidationError(ByVal errors As Dictionary(Of Reflection.PropertyInfo, ArrayList))
        For Each prop As Reflection.PropertyInfo In errors.Keys
            If prop.Name = "JobNumber" Then
                JobNumberTextEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "Customer" Then
                CustomerSearchLookUpEdit.ErrorText = errors(prop)(0)
            End If
            If prop.Name = "JobType" Then
                JobTypeLookUpEdit.ErrorText = errors(prop)(0)
            End If
           
          
            'If prop.Name = "CostCentre" Then
            '    errors.Remove(prop)
            'End If
             Next
        MyBase.ValidationError(errors)
    End Sub





    Private Sub CustomerLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs)
        'If Not (IsDBNull(CustomerLookUpEdit.EditValue)) Then
        '    AccountNameTextEdit.Text = CType(CustomerLookUpEdit.EditValue, Helper.ActiveRecord.Evolution.Client).Name
        '    RepresentativeLookUpEdit.EditValue = CType(CustomerLookUpEdit.EditValue, Helper.ActiveRecord.Evolution.Client).RepID
        'End If
    End Sub

    Private Sub JobTypeLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles JobTypeLookUpEdit.EditValueChanged
        Dim jt As API.JobType = TryCast(JobTypeLookUpEdit.EditValue, API.JobType)
        If jt IsNot Nothing Then
            If jt <> Me.Record.JobType Then
                Me.Record.JobType = jt
                Try
                    SetNumbering()
                Catch ex As Exception
                    Setup.Log.logError("Error setting numbering on job.", ex)
                End Try
            End If
        End If
    End Sub

   

    Private Sub CostCentreLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CostCentreLookUpEdit.EditValueChanged
        Dim cc As API.CostCentre = TryCast(CostCentreLookUpEdit.EditValue, API.CostCentre)
        If cc IsNot Nothing Then
            If cc <> Me.Record.CostCentre Then
                Me.Record.CostCentre = cc
                Try
                    SetNumbering()
                Catch ex As Exception
                    Setup.Log.logError("Error setting numbering on job.", ex)
                End Try
            End If
        End If
    End Sub
End Class

Public Class xaegJobtime
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Job)

    Public Sub New()
        MyBase.New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

End Class