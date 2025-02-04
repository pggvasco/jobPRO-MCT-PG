' 2015-05-20 Brits - added private properties to readonly fields so it would not fetch data each time it gets the readonly property
' 2015-05-20 Brits - added check if udf is spaces not to try and get value

Public Class SFCustomer
    Dim _customer As Pastel.Evolution.Customer
    Public Overridable ReadOnly Property Client As Pastel.Evolution.Customer
        Get
            If Me.ERPCustomerID IsNot Nothing AndAlso Me.ERPCustomerID > 0 AndAlso (_customer Is Nothing OrElse _customer.ID <> Me.ERPCustomerID) Then
                _customer = New Pastel.Evolution.Customer(CType(Me.ERPCustomerID, Integer))
            End If
            Return _customer
        End Get

    End Property

    Private Property _customerNumber As String
    Public Overridable ReadOnly Property CustomerNumber As String
        Get
            If Client IsNot Nothing AndAlso _customerNumber Is Nothing AndAlso Context.Defaults.HospitalNumberUDF IsNot Nothing AndAlso Context.Defaults.HospitalNumberUDF <> "" Then
                _customerNumber = Client.UserFields(Context.Defaults.HospitalNumberUDF).ToString
            End If
            Return _customerNumber
        End Get
    End Property

    Private Property _commission As Double?
    Public Overridable ReadOnly Property Commission As Double?
        Get
            If Client IsNot Nothing AndAlso _commission Is Nothing AndAlso Context.Defaults.CommissionUDF IsNot Nothing AndAlso Context.Defaults.CommissionUDF <> "" Then
                _commission = CDbl(Client.UserFields(Context.Defaults.CommissionUDF))
            End If
            Return _commission
        End Get

    End Property

    Private Property _plan As String
    Public Overridable ReadOnly Property Plan As String
        Get
            If Client IsNot Nothing AndAlso _plan Is Nothing AndAlso Context.Defaults.PlanUDF IsNot Nothing AndAlso Context.Defaults.PlanUDF <> "" Then
                _plan = Client.UserFields(Context.Defaults.PlanUDF).ToString
            Else
                _plan = Nothing
            End If
            Return _plan
        End Get

    End Property

    Private Property _includeExcel As Boolean?
    Public Overridable ReadOnly Property IncludeExcel As Boolean?
        Get
            If _includeExcel Is Nothing Then
                If Client IsNot Nothing AndAlso Context.Defaults.IncludeExcelInvoiceUDF IsNot Nothing AndAlso Context.Defaults.IncludeExcelInvoiceUDF <> "" Then
                    _includeExcel = CBool(Client.UserFields(Context.Defaults.IncludeExcelInvoiceUDF))
                Else
                    _includeExcel = False
                End If
            End If
            Return _includeExcel
        End Get

    End Property

    Private Property _proforma As Boolean?
    Public Overridable ReadOnly Property Proforma As Boolean?
        Get
            If _proforma Is Nothing Then
                If Client IsNot Nothing AndAlso Context.Defaults.ProformaInvoiceUDF IsNot Nothing AndAlso Context.Defaults.ProformaInvoiceUDF <> "" Then
                    _proforma = CBool(Client.UserFields(Context.Defaults.ProformaInvoiceUDF))
                Else
                    _proforma = False
                End If
            End If
            Return _proforma
        End Get

    End Property
    Private Property _proformaPrint As Boolean?
    Public Overridable ReadOnly Property ProformaPrint As Boolean?
        Get
            If _proformaPrint Is Nothing Then
                If Client IsNot Nothing AndAlso Context.Defaults.ProformaPrintUDF IsNot Nothing AndAlso Context.Defaults.ProformaPrintUDF <> "" Then
                    _proformaPrint = CBool(Client.UserFields(Context.Defaults.ProformaPrintUDF))
                Else
                    _proformaPrint = False
                End If
            End If
            Return _proformaPrint
        End Get

    End Property

    Private Property _proformaEmail As Boolean?
    Public Overridable ReadOnly Property ProformaEmail As Boolean?
        Get
            If _proformaEmail Is Nothing Then
                If Client IsNot Nothing AndAlso Context.Defaults.EmailProformaInvoiceUDF IsNot Nothing AndAlso Context.Defaults.EmailProformaInvoiceUDF <> "" Then
                    _proformaEmail = CBool(Client.UserFields(Context.Defaults.EmailProformaInvoiceUDF))
                Else
                    _proformaEmail = False
                End If
            End If
            Return _proformaEmail
        End Get

    End Property
    Private Property _invoiceEmail As Boolean?
    Public Overridable ReadOnly Property InvoiceEmail As Boolean?
        Get
            If _invoiceEmail Is Nothing Then
                If Client IsNot Nothing AndAlso Context.Defaults.EmailInvoiceUDF IsNot Nothing AndAlso Context.Defaults.EmailInvoiceUDF <> "" Then
                    _invoiceEmail = CBool(Client.UserFields(Context.Defaults.EmailInvoiceUDF))
                Else
                    _invoiceEmail = False
                End If
            End If
            Return _invoiceEmail
        End Get

    End Property

    Private Property _invoicePrint As Boolean?
    Public Overridable ReadOnly Property InvoicePrint As Boolean?
        Get
            If _invoicePrint Is Nothing Then
                If Client IsNot Nothing AndAlso Context.Defaults.PrintInvoiceUDF IsNot Nothing AndAlso Context.Defaults.PrintInvoiceUDF <> "" Then
                    _invoicePrint = CBool(Client.UserFields(Context.Defaults.PrintInvoiceUDF))
                Else
                    _invoicePrint = False
                End If
            End If
            Return _invoicePrint
        End Get

    End Property

    'Dim _rate As API.CustomerRatePrice
    'Public Property customerRate As API.CustomerRatePrice
    '    Get
    '        If Me.ID AndAlso Me.ID > 0 Then
    '            _rate = API.CustomerRatePrice.FindAllByProperty("CustomerID", Me.ID).FirstOrDefault
    '        End If
    '        Return _rate
    '    End Get

    '    Set(ByVal value As API.CustomerRatePrice)
    '        _rate = value
    '        _rate.SaveAndFlush()
    '        NotifyPropertyChanged("CustomerRate")
    '    End Set
    'End Property

    Private WithEvents _CustomerWorkCentreCategory As ComponentModel.BindingList(Of CustomerWorkCentreCategory)
    Public Overridable Overloads ReadOnly Property CustomerWorkCentreCategoryLineList As ComponentModel.BindingList(Of CustomerWorkCentreCategory)
        Get
            If IsLoading = False AndAlso _CustomerWorkCentreCategory Is Nothing Then
                _CustomerWorkCentreCategory = New ComponentModel.BindingList(Of CustomerWorkCentreCategory)(Me.CustomerWorkCentreCategories)

            End If
            Return _CustomerWorkCentreCategory
        End Get
    End Property
End Class
