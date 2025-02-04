Imports Castle.ActiveRecord
Imports Castle.Components.Validator
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel

' 2015-05-20 Brits - added private properties to readonly fields so it would not fetch data each time it gets the readonly property
' 2015-05-20 Brits - added check if udf is spaces not to try and get value
Public Class Employee

    'Dim _person As Pastel.Evolution.Person

    'Dim a = New Pastel.Evolution.Person(CInt(Me.PersonID))

    Private Property _people As Pastel.Evolution.Person
    Public Overridable ReadOnly Property People As Pastel.Evolution.Person
        Get
            If _people Is Nothing AndAlso Me.PersonID IsNot Nothing AndAlso Me.PersonID > 0 AndAlso (Person IsNot Nothing OrElse _person.ID <> Me.PersonID) Then
                _people = New Pastel.Evolution.Person(CType(Me.PersonID, Integer))
            End If
            Return _people
        End Get
    End Property

    Dim _person As UniSource.Helper.ActiveRecord.Evolution.People
    Public Overridable ReadOnly Property Person As UniSource.Helper.ActiveRecord.Evolution.People
        Get
            If _person Is Nothing OrElse (Me.PersonID IsNot Nothing AndAlso Me.PersonID > 0 AndAlso _person.ID <> Me.PersonID) Then
                _person = UniSource.Helper.ActiveRecord.Evolution.People.Find(Me.PersonID)
            End If
            Return _person
        End Get

    End Property

    Private Property _employeeNumber As String
    Public Overridable ReadOnly Property EmployeeNumber As String
        Get
            If _employeeNumber Is Nothing Then
                If People IsNot Nothing AndAlso Context.Defaults.EmployeeNumberUDF IsNot Nothing AndAlso Context.Defaults.EmployeeNumberUDF <> "" Then
                    _employeeNumber = People.UserFields(Context.Defaults.EmployeeNumberUDF)
                End If
            End If
            Return _employeeNumber
        End Get
    End Property

    Public Overridable ReadOnly Property BranchCode As String
        Get
            If EmployeeNumber IsNot Nothing AndAlso EmployeeNumber.Length > 3 Then
                Return EmployeeNumber.Substring(0, 3)
            Else
                Return ""
            End If
        End Get
    End Property

    Private Property _employeeID As String
    Public Overridable ReadOnly Property EmployeeID As String
        Get
            If _employeeID Is Nothing Then
                If People IsNot Nothing AndAlso Context.Defaults.EmployeeIDUDF IsNot Nothing AndAlso Context.Defaults.EmployeeIDUDF <> "" Then
                    _employeeID = People.UserFields(Context.Defaults.EmployeeIDUDF)
                End If
            End If
            Return _employeeID
        End Get
    End Property

    Private Property _accountNumber As String
    Public Overridable ReadOnly Property AccountNumber As String
        Get
            If _accountNumber Is Nothing Then
                If People IsNot Nothing AndAlso Context.Defaults.AccountNumberUDF IsNot Nothing AndAlso Context.Defaults.AccountNumberUDF <> "" Then
                    Return People.UserFields(Context.Defaults.AccountNumberUDF)
                End If
            End If
            Return _accountNumber
        End Get
    End Property

    Private Property _bankAccHolder As String
    Public Overridable ReadOnly Property BankAccHolder As String
        Get
            If _bankAccHolder Is Nothing Then
                If People IsNot Nothing AndAlso Context.Defaults.AccountHolderNameUDF IsNot Nothing AndAlso Context.Defaults.AccountHolderNameUDF <> "" Then
                    _bankAccHolder = People.UserFields(Context.Defaults.AccountHolderNameUDF)
                End If
            End If
            Return _bankAccHolder
        End Get
    End Property

    Private Property _bankCode As String
    Public Overridable ReadOnly Property BankCode As String
        Get
            If _bankCode Is Nothing Then
                If People IsNot Nothing AndAlso Context.Defaults.BranchCodeUDF IsNot Nothing AndAlso Context.Defaults.BranchCodeUDF <> "" Then
                    _bankCode = People.UserFields(Context.Defaults.BranchCodeUDF)
                End If
            End If
            Return _bankCode
        End Get
    End Property

    Private Property _taxStartDate As Date?
    Public Overridable ReadOnly Property TaxStartDate As Date?
        Get
            If _taxStartDate Is Nothing Then
                If People IsNot Nothing AndAlso Context.Defaults.TaxStartDateUDF IsNot Nothing AndAlso Context.Defaults.TaxStartDateUDF <> "" Then
                    _taxStartDate = People.UserFields(Context.Defaults.TaxStartDateUDF)
                End If
            End If
            Return _taxStartDate
        End Get
    End Property
    Private Property _sANCREFNO As String
    Public Overridable ReadOnly Property SANCREFNO As String
        Get
            If _sANCREFNO Is Nothing Then
                If People IsNot Nothing AndAlso Context.Defaults.SANCRefNumberUDF IsNot Nothing AndAlso Context.Defaults.SANCRefNumberUDF <> "" Then
                    _sANCREFNO = People.UserFields(Context.Defaults.SANCRefNumberUDF)
                End If
            End If
            Return _sANCREFNO
        End Get
    End Property

    




    Private WithEvents _rateQualificationlist As ComponentModel.BindingList(Of EmployeeQualification)
    Public Overridable Overloads ReadOnly Property QualificationLineList As ComponentModel.BindingList(Of EmployeeQualification)
        Get
            If IsLoading = False AndAlso _rateQualificationlist Is Nothing Then
                _rateQualificationlist = New ComponentModel.BindingList(Of EmployeeQualification)(Me.EmployeeQualifications)

            End If
            Return _rateQualificationlist
        End Get
    End Property

    Private Property _paymentFrequency As String
    Public Overridable ReadOnly Property PaymentFrequency As String
        Get
            If _paymentFrequency Is Nothing Then
                If People IsNot Nothing AndAlso Context.Defaults.PaymentFrequencyUDF IsNot Nothing AndAlso Context.Defaults.PaymentFrequencyUDF <> "" Then
                    _paymentFrequency = People.UserFields(Context.Defaults.PaymentFrequencyUDF)
                End If
            End If
            Return _paymentFrequency
        End Get
    End Property

End Class

