Imports Pastel.Evolution
Imports NHibernate.Event
Imports NHibernate.Persister.Entity

''' <summary>
''' Represent an Audit record used by various modules.
''' </summary>
''' <remarks></remarks>
Public Class Audit

#Region "Private Variables"

    Public Shared _tablename As String = "ussAudit"
    Public Shared _primary As String = "id"
    Private Shared _limit As Integer = 10000
    Private _id As Integer
    Private _datetime As Date
    Private _jobfile As Job
    Private _agent As Agent
    Private _jobline As JobLine
    Private _description As String
    Private _type As String
    Private _oldvalue As String
    Private _newvalue As String

#End Region

#Region "Constructors"

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Creates a new instance of an Audit record.
    ''' </summary>
    ''' <param name="id">The internal ID of the record to fetch.</param>
    ''' <remarks></remarks>
    'Public Sub New(ByVal id)
    '    load(id)
    'End Sub

#End Region

#Region "Public Properties"

    ''' <summary>
    ''' Gets the internal ID of the current record, or zero if it is not saved.
    ''' </summary>
    ''' <value></value>
    ''' <returns>The integer ID of the current record, or zero if it is not saved.</returns>
    ''' <remarks></remarks>
    Public Property ID() As Integer
        Get
            Return IIf(IsDBNull(_id), 0, _id)
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DateTime() As Date
        Get
            Return IIf(IsDBNull(_datetime), Now, _datetime)
        End Get
    End Property

    ''' <summary>
    ''' Gets or Sets the JobFile of the current record.
    ''' </summary>
    ''' <value>The JobFile for the current record.</value>
    ''' <returns>The JobFile of the current record.</returns>
    ''' <remarks></remarks>
    Public Property job As Job
        Get
            If idJob IsNot Nothing AndAlso idJob > 0 AndAlso (_jobfile Is Nothing OrElse idJob <> _jobfile.ID) Then
                _jobfile = job.Find(idJob)
            End If
            Return _jobfile
        End Get
        Set(ByVal value As Job)
            If value IsNot Nothing AndAlso idJob <> value.ID Then
                idJob = value.ID
            End If
            _jobfile = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or Sets the Agent of the current record.
    ''' </summary>
    ''' <value>The Agent for the current record.</value>
    ''' <returns>The Agent of the current record.</returns>
    ''' <remarks></remarks>
    Public Property Agent() As Agent
        Get
            If _agent Is Nothing Then
                _agent = New Agent(CType(IdAgents, Integer))
            End If
            Return _agent
        End Get
        Set(ByVal value As Agent)
            If value IsNot Nothing Then
                IdAgents = value.ID
            End If
            _agent = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or Sets the JobLine of the current record.
    ''' </summary>
    ''' <value>The JobLine for the current record.</value>
    ''' <returns>The JobLine of the current record.</returns>
    ''' <remarks></remarks>
    Public Property JobLine() As JobLine
        Get
            If _jobline IsNot Nothing Then
                Return _jobline
            ElseIf _jobline Is Nothing AndAlso idJobLine IsNot Nothing AndAlso idJobLine > 0 Then
                _jobline = JobLine.Get(idJobLine)
                Return _jobline
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As JobLine)
            _jobline = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or Sets the Description of the current record.
    ''' </summary>
    ''' <value>The Description for the current record.</value>
    ''' <returns>The Description of the current record.</returns>
    ''' <remarks></remarks>
    Public Overrides Property Description() As String
        Get
            Return IIf(IsDBNull(_description), "", _description)
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return IIf(IsDBNull(_type), "", _type)
        End Get
        Set(ByVal value As String)
            _type = value
        End Set
    End Property

    Public Property OldValue() As String
        Get
            Return IIf(IsDBNull(_oldvalue), "", _oldvalue)
        End Get
        Set(ByVal value As String)
            _oldvalue = value
        End Set
    End Property

    Public Property NewValue() As String
        Get
            Return IIf(IsDBNull(_newvalue), "", _newvalue)
        End Get
        Set(ByVal value As String)
            _newvalue = value
        End Set
    End Property

#End Region

#Region "Private Methods"

    ''' <summary>
    ''' Private method to load a specific Audit record.
    ''' </summary>
    ''' <param name="id">The ID of the Audit record to load.</param>
    ''' <remarks></remarks>
    'Private Sub load(ByVal id As Integer)
    '    Dim tmpRow As DataRow

    '    tmpRow = db.getDataSet("SELECT * FROM [" & _tablename & "] WHERE [" & _primary & "] = " & id).Tables(0).Rows(0)

    '    _id = id
    '    _datetime = nowIfNull(tmpRow.Item("Date"))
    '    _jobfile = New JobFile(CInt(zeroIfNull(tmpRow.Item("idJobFile"))))
    '    _agent = New Agent(CInt(zeroIfNull(tmpRow.Item("idAgents"))))
    '    _jobline = New JobLine(CInt(zeroIfNull(tmpRow.Item("idJobLine"))))
    '    _description = blankIfNull(tmpRow.Item("Description"))
    '    _type = blankIfNull(tmpRow.Item("Type"))
    '    _oldvalue = blankIfNull(tmpRow.Item("OldValue"))
    '    _newvalue = blankIfNull(tmpRow.Item("NewValue"))

    'End Sub

#End Region

#Region "Public Methods"

    ''' <summary>
    ''' Commits the current record to the database.
    ''' </summary>
    ''' <remarks></remarks>
    'Public Sub save()
    '    Dim values As New Hashtable
    '    Dim whereValues As New Hashtable

    '    values.Add("Date", Now)
    '    values.Add("idAgents", Agent.ID)
    '    If JobLine.ID <> 0 Then
    '        values.Add("idJobFile", JobLine.JobFileID)
    '        values.Add("idJobLine", JobLine.ID)
    '    Else
    '        values.Add("idJobFile", job.ID)
    '    End If

    '    values.Add("Description", Description)
    '    values.Add("Type", Type)
    '    values.Add("OldValue", OldValue)
    '    values.Add("NewValue", NewValue)

    '    whereValues.Add(_primary, _id)

    '    If ID = 0 Then
    '        _id = db.insertSQL(_tablename, values)
    '    Else
    '        db.updateSQL(_tablename, values, whereValues)
    '    End If
    'End Sub
#End Region

#Region "Shared Methods"

    ''' <summary>
    ''' Returns a DataTable containing the database records from the Audit table.
    ''' </summary>
    ''' <returns>Returns a DataTable containing the database records from the Audit table.</returns>
    ''' <remarks></remarks>
    'Shared Function list()
    '    Dim listTable As DataTable

    '    listTable = db.getDataSet("SELECT TOP " & _limit & " * FROM [" & _tablename & "]").Tables(0)

    '    Return listTable
    'End Function

    ''' <summary>
    ''' Returns a DataTable containing the database records from the Audit table matching the supplied criteria.
    ''' </summary>
    ''' <param name="whereClause">The SQL criteria used to filter the records, eg: "1=1".</param>
    ''' <returns>Returns a DataTable containing the database records from the Audit table matching the supplied criteria.</returns>
    ''' <remarks>The whereClause is not sanitised, please ensure it is accurate and free of malicious intent.</remarks>
    'Shared Function list(ByVal whereClause As String)
    '    Dim listTable As DataTable

    '    listTable = db.getDataSet("SELECT TOP " & _limit & " * FROM [" & _tablename & "] WHERE " & whereClause).Tables(0)

    '    Return listTable
    'End Function

    ''' <summary>
    ''' Returns a DataTable containing the database records from the Audit table matching the supplied criteria.
    ''' </summary>
    ''' <returns>Returns a DataTable containing the database records from the Audit table matching the supplied criteria.</returns>
    ''' <remarks></remarks>
    'Shared Function listColumns(Optional ByVal whereClause As String = Nothing) As DataTable
    '    Dim sql As String
    '    Dim listTable As DataTable

    '    sql = "SELECT TOP " & _limit & " "
    '    sql += "[" & _tablename & "].Date AS 'Date', [_rtblAgents].cDisplayName AS 'Agent', [" & JobFile._tablename & "].[JobNo] AS 'Job File', [" & _tablename & "].Description, [" & _tablename & "].Type, [" & _tablename & "].OldValue, [" & _tablename & "].NewValue "
    '    sql += "FROM [" & _tablename & "] "
    '    sql += "LEFT JOIN [_rtblAgents] ON [_rtblAgents].idAgents = [" & _tablename & "].idAgents "
    '    sql += "LEFT JOIN [" & JobFile._tablename & "] ON [" & JobFile._tablename & "].[" & JobFile._primary & "] = [" & _tablename & "].idJobFile "
    '    If whereClause IsNot Nothing Then
    '        sql += "WHERE " & whereClause & " "
    '    End If
    '    sql += "ORDER BY Date DESC"

    '    listTable = db.getDataSet(sql).Tables(0)

    '    Return listTable
    'End Function

    ''' <summary>
    ''' Finds an Audit ID.
    ''' </summary>
    ''' <param name="criteria">The criteria passed to the SQL query.</param>
    ''' <returns>The integer ID of the Audit returned by the supplied criteria.</returns>
    ''' <remarks></remarks>
    'Shared Function find(ByVal criteria As String) As Integer
    '    Return zeroIfNull(db.getDataSet("SELECT TOP 1 [" & _primary & "] FROM [" & _tablename & "] WHERE " & criteria & ";").Tables(0).Rows(0).Item(0))
    'End Function

    ''' <summary>
    ''' Returns an instance of the first record returned matching the supplied criteria; otherwise, returns null.
    ''' </summary>
    ''' <param name="criteria">The criteria passed to the SQL query.</param>
    ''' <returns>A new instance of the Audit matching the supplied criteria.</returns>
    ''' <remarks></remarks>
    'Shared Function [Get](ByVal criteria As String) As Audit
    '    Dim id As Integer = find(criteria)
    '    If id = 0 Then
    '        Return Nothing
    '    Else
    '        Return New Audit(id)
    '    End If
    'End Function

    Shared Function AreEqual(ByVal a As Object, ByVal b As Object, ByVal Agent As Pastel.Evolution.Agent, Optional ByVal recursive As Boolean = False)
        Dim nochange As Boolean = True
        If a Is Nothing Or b Is Nothing Then
            If a IsNot Nothing Or b IsNot Nothing Then
                Return False
            Else
                Return True
            End If
        End If
        Dim typeA As Type = a.[GetType]()
        Dim typeB As Type = b.[GetType]()

        Dim myProperties As Reflection.PropertyInfo() = typeA.GetProperties()

        For Each myPropertyA As Reflection.PropertyInfo In myProperties
            If myPropertyA.Name <> "Item" And myPropertyA.Name <> "IsChanged" And myPropertyA.Name <> "IsLoading" Then
                Dim myPropertyB As Reflection.PropertyInfo = typeB.GetProperty(myPropertyA.Name)
                Dim type As String = myPropertyA.PropertyType.Name

                If type = "String" Or type = "DateTime" Or type = "Int32" Or type = "Boolean" Or type = "Double" Or type = "JobState" Then
                    Dim itemA = myPropertyA.GetValue(a, Nothing)
                    Dim itemB = myPropertyB.GetValue(b, Nothing)
                    If itemA IsNot Nothing And itemB IsNot Nothing Then
                        If itemA.ToString <> itemB.ToString Then
                            If recursive <> True Then
                                Dim log As New Audit
                                log.Date = Now
                                log.Agent = Agent
                                log.Description = "The " & myPropertyA.Name & " of the " & typeA.Name & " was changed."
                                log.Type = myPropertyA.Name
                                If type <> "JobState" Then
                                    log.OldValue = itemB
                                    log.NewValue = itemA
                                Else
                                    log.OldValue = itemB.ToString
                                    log.NewValue = itemA.ToString
                                End If
                                If TypeOf a Is Job Then
                                    log.idJob = CType(a, Job).ID
                                ElseIf TypeOf a Is JobLine Then
                                    log.idJob = CType(a, JobLine).Job.ID
                                    log.idJobLine = CType(a, JobLine).ID
                                End If
                                log.SaveAndFlush()
                            End If
                                nochange = False
                            End If
                        End If

                    ElseIf type = "List`1" Then
                        Dim x = 0
                        Dim list1 = myPropertyA.GetValue(a, Nothing)
                        Dim list2 = myPropertyB.GetValue(a, Nothing)
                        If list1 IsNot Nothing Then
                            If list2 IsNot Nothing Then
                                If list1.count <> list2.count Then
                                    nochange = False
                                End If
                                For Each itemA In list1
                                    If AreEqual(itemA, (list2(x)), Agent) = False Then nochange = False
                                    x += 1
                                Next
                            End If
                        End If


                ElseIf myPropertyA.Name = "PriceList" Or myPropertyA.Name = "CostCentre" Or myPropertyA.Name = "JobType" Or myPropertyA.Name = "Customer" Or myPropertyA.Name = "WorkCentre" Or myPropertyA.Name = "JobStage" Or myPropertyA.Name = "OrderNumber" Or myPropertyA.Name = "Drawing" Or myPropertyA.Name = "JobCategory" Or myPropertyA.Name = "WorkCentreCategory" Then
                    If AreEqual(myPropertyA.GetValue(a, Nothing), myPropertyB.GetValue(b, Nothing), Agent, True) = False Then
                        If recursive <> True Then
                            Dim log As New Audit
                            log.Date = Now
                            log.Agent = Agent
                            log.Description = "The " & type & " (" & myPropertyA.Name & ") of the " & typeA.Name & " was changed."
                            log.Type = type

                            Try
                                log.OldValue = myPropertyB.GetValue(b, Nothing).Description
                                log.NewValue = myPropertyA.GetValue(a, Nothing).Description
                            Catch ex As Exception
                                Try
                                    log.OldValue = myPropertyB.GetValue(b, Nothing).Code
                                    log.NewValue = myPropertyA.GetValue(a, Nothing).Code
                                Catch ex2 As Exception
                                    Try
                                        log.OldValue = myPropertyB.GetValue(b, Nothing).ID
                                        log.NewValue = myPropertyA.GetValue(a, Nothing).ID
                                    Catch ex3 As Exception
                                    End Try
                                End Try
                            End Try


                            If TypeOf a Is Job Then
                                log.idJob = CType(a, Job).ID
                            ElseIf TypeOf a Is JobLine Then
                                log.idJob = CType(a, JobLine).Job.ID
                                log.idJobLine = CType(a, JobLine).ID
                            End If
                            log.SaveAndFlush()
                            nochange = False
                        End If
                    End If

                    End If
                End If
        Next
        Return nochange
    End Function

#End Region


End Class


'Public Class AuditEventListener
'    Implements IPreUpdateEventListener
'    Implements IPreInsertEventListener

'    Public Function OnPreInsert(ByVal [event] As PreInsertEvent) As Boolean Implements NHibernate.Event.IPreInsertEventListener.OnPreInsert
'        'Dim audit = TryCast([event].Entity, IHaveAuditInformation)
'        'If audit Is Nothing Then
'        '    Return False
'        'End If


'        Dim time = DateTime.Now
'        Dim name = Security.Principal.WindowsIdentity.GetCurrent().Name

'        [Set]([event].Persister, [event].State, "CreatedAt", time)
'        [Set]([event].Persister, [event].State, "UpdatedAt", time)
'        [Set]([event].Persister, [event].State, "CreatedBy", name)
'        [Set]([event].Persister, [event].State, "UpdatedBy", name)

'        'audit.CreatedAt = time
'        'audit.CreatedBy = name
'        'audit.UpdatedAt = time
'        'audit.UpdatedBy = name

'        Return False
'    End Function

'    Private Sub [Set](ByVal persister As IEntityPersister, ByVal state As Object(), ByVal propertyName As String, ByVal value As Object)
'        Dim index = Array.IndexOf(persister.PropertyNames, propertyName)
'        If index = -1 Then
'            Return
'        End If
'        state(index) = value
'    End Sub

'    Public Function OnPreUpdate(ByVal [event] As NHibernate.Event.PreUpdateEvent) As Boolean Implements NHibernate.Event.IPreUpdateEventListener.OnPreUpdate
'        'Dim audit = TryCast([event].Entity, IHaveAuditInformation)
'        'If audit Is Nothing Then
'        '    Return False
'        'End If

'        Dim time = DateTime.Now
'        Dim name = Security.Principal.WindowsIdentity.GetCurrent().Name

'        [Set]([event].Persister, [event].State, "UpdatedAt", time)
'        [Set]([event].Persister, [event].State, "UpdatedBy", name)

'        'audit.UpdatedAt = time
'        'audit.UpdatedBy = name

'        Return False
'    End Function
'End Class

