Imports Castle.ActiveRecord

Public Class WorkCentre


    Public Overrides Property Factor As Double?
        Get
            If MyBase.Factor Is Nothing Then
                MyBase.Factor = 1
            End If
            Return MyBase.Factor
        End Get
        Set(ByVal value As Double?)
            MyBase.Factor = value
        End Set
    End Property

    Public Overrides Property Code As String
        Get
            Return MyBase.Code
        End Get
        Set(ByVal value As String)
            If Not IsLoading AndAlso MyBase.Code <> value AndAlso MyBase.CalculationTypeID = API.CalculationType.Recovery Then
                If String.IsNullOrEmpty(Me.RecoveryServiceCode) Or Me.RecoveryServiceCode = MyBase.Code Then
                    Me.RecoveryServiceCode = value
                End If
            End If
            MyBase.Code = value
        End Set
    End Property

    'Public Overrides Property CalculationType As CalculationType
    '    Get
    '        Return MyBase.CalculationType
    '    End Get
    '    Set(ByVal value As CalculationType)
    '        If Not IsLoading AndAlso MyBase.CalculationType <> value AndAlso value = API.CalculationType.Recovery Then
    '            If String.IsNullOrEmpty(Me.RecoveryServiceCode) Then
    '                Me.RecoveryServiceCode = Me.Code
    '            End If
    '        End If
    '        MyBase.CalculationType = value
    '    End Set
    'End Property

    Public Overridable Property CalculationType As CalculationType
        Get
            If MyBase.CalculationTypeID Is Nothing Then
                Return CalculationType.Standard
            Else
                Return MyBase.CalculationTypeID
            End If
        End Get
        Set(ByVal value As CalculationType)
            If Not IsLoading AndAlso MyBase.CalculationTypeID <> value AndAlso value = API.CalculationType.Recovery Then
                If String.IsNullOrEmpty(Me.RecoveryServiceCode) Then
                    Me.RecoveryServiceCode = Me.Code
                End If
            End If
            MyBase.CalculationTypeID = value
        End Set
    End Property

    Public Overrides Function IsValid() As Boolean
        Dim valid As Boolean = MyBase.IsValid

        If Context.Defaults.CostCentreMethod = CostCentreMethod.WorkCentre Then
            If Me.CostCentre Is Nothing Then
                Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("CostCentre"), New ArrayList())
                Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("CostCentre")).Add("Cost Centre is required due to Cost Centre Method.")
                valid = False
            End If
        End If

        Dim cnt As Integer
        If APExpense Then
            cnt = cnt + 1
        End If

        If GLExpense Then
            cnt = cnt + 1
        End If

        If IsBuyOut Then
            cnt = cnt + 1
        End If

        If cnt > 1 Then
            Me.PropertiesValidationErrorMessages.Add(Me.GetType.GetProperty("GLExpense"), New ArrayList())
            Me.PropertiesValidationErrorMessages(Me.GetType.GetProperty("GLExpense")).Add("Error: Multiple Options cannot be selected (Buyout, APExpense & GLExpense)")

            valid = False
        End If

        Return valid
    End Function

    Public Overrides Property IsBuyOut As Boolean?
        Get
            If MyBase.IsBuyOut Is Nothing Then
                Return False
            End If
            Return MyBase.IsBuyOut
        End Get
        Set(value As Boolean?)
            MyBase.IsBuyOut = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", MyBase.Code, MyBase.Description)
    End Function



End Class
