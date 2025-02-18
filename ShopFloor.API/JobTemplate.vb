﻿Imports Castle.ActiveRecord

Public Class JobTemplate

    Private WithEvents _jobtemplatelinelist As ComponentModel.BindingList(Of JobTemplateLine)
    Public Overridable Overloads ReadOnly Property JobTemplateLineList As ComponentModel.BindingList(Of JobTemplateLine)
        Get
            If _jobtemplatelinelist Is Nothing Then
                _jobtemplatelinelist = New ComponentModel.BindingList(Of JobTemplateLine)(Me.JobTemplateLines)
            End If
            Return _jobtemplatelinelist
        End Get
    End Property

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid

        If IIf(Context.Defaults.IsTemplateNumberAutoGenerated.HasValue, Context.Defaults.IsTemplateNumberAutoGenerated, False) And Context.Defaults.TemplateNumberPrefixType = API.PrefixType.CostCentre Then
            If Me.CostCentre Is Nothing Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("CostCentre"), New ArrayList())
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("CostCentre")).Add("Cost Centre is required due to Prefix Type.")
                valid = False
            End If
        End If

        If IIf(Context.Defaults.IsTemplateNumberAutoGenerated.HasValue, Context.Defaults.IsTemplateNumberAutoGenerated, False) And Context.Defaults.TemplateNumberPrefixType = API.PrefixType.JobCategory Then
            If Me.JobCategory Is Nothing Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("JobCategory"), New ArrayList())
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("JobCategory")).Add("Job Category is required due to Prefix Type.")
                valid = False
            End If
        End If

        Return valid
    End Function

    Protected Overrides Function BeforeSave(ByVal state As System.Collections.IDictionary) As Boolean
        If ID = 0 Then
            If Context.Defaults.IsTemplateNumberAutoGenerated Then
                state("TemplateNumber") = Defaults.Defaults.GetNextTemplateNumberAndIncrement(Me)
            End If
        End If
        Return MyBase.BeforeSave(state)
    End Function

    Public Overrides Function ToString() As String
        'Return String.Format("{0} ({1})", MyBase.Number, MyBase.Description)
        Return MyBase.TemplateNumber
    End Function

    Public Overrides Property UnitCost As Double?
        Get
            If _jobtemplatelinelist IsNot Nothing Then
                Return Aggregate jl In _jobtemplatelinelist Into Sum(jl.TotalCost)
            End If
            Return MyBase.UnitCost
        End Get
        Set(value As Double?)
            MyBase.UnitCost = value
        End Set
    End Property

    Public Overrides Property UnitPrice As Double?
        Get
            If _jobtemplatelinelist IsNot Nothing Then
                Return Aggregate jl In _jobtemplatelinelist Into Sum(jl.TotalPrice)
            End If
            Return MyBase.UnitPrice
        End Get
        Set(value As Double?)
            MyBase.UnitPrice = value
        End Set
    End Property

    Public Overrides Property UseTemplatePricing As Boolean?
        Get
            If MyBase.UseTemplatePricing Is Nothing Then
                MyBase.UseTemplatePricing = False
            End If
            Return MyBase.UseTemplatePricing
        End Get
        Set(value As Boolean?)
            MyBase.UseTemplatePricing = value
        End Set
    End Property

End Class
