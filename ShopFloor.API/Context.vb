
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports UniSource.Settings
Imports Castle.ActiveRecord
Imports System.Data.SqlClient

'2015-05-11 Brits -added defaults to context to make reads on defaults less as it gets used in clases with UDF fields.
Public Module Context

    Public Property ActiveConnection() As Connection

    Public Property Agent As Pastel.Evolution.Agent

    Public Property _agentActiveWriter As Helper.ActiveRecord.Evolution.Agents
    Public ReadOnly Property AgentActiveWriter As Helper.ActiveRecord.Evolution.Agents
        Get
            If _agentActiveWriter Is Nothing AndAlso Agent IsNot Nothing Then
                _agentActiveWriter = Helper.ActiveRecord.Evolution.Agents.Find(Agent.ID)
            End If
            Return _agentActiveWriter
        End Get
    End Property

    Public Property SecondAgent As Pastel.Evolution.Agent
    Public Property IsImporting As Boolean = False
    'Public Property Defaults As API.Defaults = API.Defaults.Defaults
    Private _defaults As API.Defaults
    Public Property Defaults As API.Defaults
        Get
            If Agent IsNot Nothing AndAlso _defaults Is Nothing Then
                _defaults = API.Defaults.Defaults
            End If
            Return _defaults
        End Get
        Set(value As API.Defaults)
            _defaults = value
        End Set
    End Property

    Private Property _publicHolidayList As List(Of PublicHoliday)
    Public Property PublicHolidayList As List(Of PublicHoliday) ' = API.PublicHoliday.PublicHolidayList
        Get
            If Agent IsNot Nothing AndAlso _publicHolidayList Is Nothing Then
                _publicHolidayList = API.PublicHoliday.PublicHolidayList
            End If
            Return _publicHolidayList
        End Get
        Set(value As List(Of PublicHoliday))
            _publicHolidayList = value
        End Set
    End Property

    Public Function GetSQLDataTable(ByVal SQLQuery As String) As DataTable
        Dim SQLDataTable As DataTable = New DataTable
        Using cn As New SqlConnection(ActiveConnection.Company.ConnectionString)
            cn.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SQLQuery

            SQLDataTable.Load(cmd.ExecuteReader())
        End Using
        Return SQLDataTable
    End Function

    Public Sub ExicuteSQLScript(ByVal SQLQuery As String)
        Using cn As New SqlConnection(ActiveConnection.Company.ConnectionString)
            cn.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SQLQuery
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Module
