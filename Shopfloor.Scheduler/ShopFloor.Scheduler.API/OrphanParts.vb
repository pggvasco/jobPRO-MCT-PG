Public Class OrphanParts

    Private Property _job As API.Job
    Private Property _part As API.Part
    Private Property _nextActivity As API.Activity

    Private Property _activityList As List(Of API.Activity)

    Public Property ActivityList As List(Of API.Activity)
        Get
            If _job IsNot Nothing AndAlso _part IsNot Nothing Then
                If _activityList Is Nothing OrElse _activityList.Count = 0 Then
                    _activityList = GetOrphanActivity(_job.ID, _part.ID)
                End If
            End If
            Return _activityList
        End Get
        Set(value As List(Of API.Activity))

        End Set
    End Property

    Public Property Job As API.Job
        Get
            Return _job
        End Get
        Set(ByVal value As API.Job)
            _job = value
        End Set
    End Property
    Public Property Part As API.Part
        Get
            Return _part
        End Get
        Set(ByVal value As API.Part)
            _part = value
        End Set
    End Property
    Public Property NextActivity As API.Activity
        Get
            Return _nextActivity
        End Get
        Set(ByVal value As API.Activity)
            _nextActivity = value
        End Set
    End Property

    Public Shared Function GetOrphanParts() As List(Of OrphanParts)
        Dim OrphanPartsList As New List(Of OrphanParts)

        'Dim SqlSelectStatement As String = "Select JobID, PartID,Max(cast(ISNULL(IsNextActivity,0)as int))  as IsNextActivity" +
        '                                  " From ussSSActivity " +
        '                                  " Where id in(Select ActivityID " +
        '                                  " From ussSSActivityLog  " +
        '                                  " Where id in(Select Max(id) as id From ussSSActivityLog Group By ActivityID) " +
        '                                  " And CurrentState <> 1)" +
        '                                  " Group By JobID,PartID" +
        '                                  " Having Max(cast(ISNULL(IsNextActivity,0)as int)) = 0"

        Dim SqlSelectStatement As String = "Select JobID, PartID,Max(cast(ISNULL(IsNextActivity,0)as int))  as IsNextActivity " +
                                           "From ussSSActivity,ussSSJob  " +
                                           "Where Not ussSSActivity.id in(Select ActivityID " +
                                           "			    From ussSSActivityLog " +
                                           "			    Where ID in (Select Max(ID) As ID " +
                                           "							 From ussSSActivityLog  " +
                                           "							 Group By ActivityID) " +
                                           "                And CurrentState = 1) " +
                                           "And ussSSActivity.JobID = ussSSJob.ID " +
                                           "And ussSSJob.JobStateID = 0 " +
                                           "And Not ussSSJob.PrimaryArtisanID is Null " +
                                           "Group By JobID,PartID " +
                                           "Having Max(cast(ISNULL(IsNextActivity,0)as int)) = 0 "


        Dim OrphanPartsDatable As DataTable = Pastel.Evolution.DatabaseContext.ExecuteCommandDataTable(SqlSelectStatement)
        For Each row As DataRow In OrphanPartsDatable.Rows
            Try
                Dim OrphanParts As New OrphanParts
                Dim jobID As Integer = CType(row.Item(0), Integer)
                Dim partID As Integer = CType(row.Item(1), Integer)

                OrphanParts.Job = API.Job.Get(jobID)
                OrphanParts.Part = API.Part.Get(partID)
                OrphanPartsList.Add(OrphanParts)
            Catch ex As Exception
            End Try
        Next

        Return OrphanPartsList
    End Function

    Public Shared Function GetOrphanActivity(ByVal JobID As Integer, ByVal PartID As Integer) As List(Of Activity)
        Dim OrphanActivityList As New List(Of Activity)

        Dim SqlSelectStatement As String = "Select ussSSActivity.id,Max(cast(ISNULL(IsNextActivity,0)as int))  as IsNextActivity " +
                                           "From ussSSActivity,ussSSJob  " +
                                           "Where Not ussSSActivity.id in(Select ActivityID " +
                                           "			    From ussSSActivityLog " +
                                           "			    Where ID in (Select Max(ID) As ID " +
                                           "							 From ussSSActivityLog  " +
                                           "							 Group By ActivityID) " +
                                           "                And CurrentState = 1) " +
                                           "And ussSSActivity.JobID = ussSSJob.ID " +
                                           "And ussSSJob.JobStateID = 0 " +
                                           "And Not ussSSJob.PrimaryArtisanID is Null " +
                                           "And ussSSActivity.JobID = " + JobID.ToString() + " " +
                                           "And ussSSActivity.PartID = " + PartID.ToString() + " " +
                                           "Group By ussSSActivity.id " +
                                           "Having Max(cast(ISNULL(IsNextActivity,0)as int)) = 0 "


        Dim OrphanActivityDatable As DataTable = Pastel.Evolution.DatabaseContext.ExecuteCommandDataTable(SqlSelectStatement)
        For Each row As DataRow In OrphanActivityDatable.Rows
            Try
                Dim OrphanActivity As Activity = Activity.Find(row(0))
                OrphanActivityList.Add(OrphanActivity)
            Catch ex As Exception
            End Try
        Next

        Return OrphanActivityList
    End Function


    Public Shared Function GetOrphanPartsJobsByArtisan(ByVal Artisan As Artisan) As List(Of Job)
        Dim OrphanJobList As New List(Of Job)

        'Dim SqlSelectStatement As String = "Select JobID, PartID,Max(cast(ISNULL(IsNextActivity,0)as int))  as IsNextActivity" +
        '                                  " From ussSSActivity " +
        '                                  " Where id in(Select ActivityID " +
        '                                  " From ussSSActivityLog  " +
        '                                  " Where id in(Select Max(id) as id From ussSSActivityLog Group By ActivityID) " +
        '                                  " And CurrentState <> 1)" +
        '                                  " Group By JobID,PartID" +
        '                                  " Having Max(cast(ISNULL(IsNextActivity,0)as int)) = 0"

        'Dim SqlSelectStatement As String = String.Format("Select JobID " +
        '                                   "From ussSSActivity,ussSSJob  " +
        '                                   "Where Not ussSSActivity.id in(Select ActivityID " +
        '                                   "			    From ussSSActivityLog " +
        '                                   "			    Where ID in (Select Max(ID) As ID " +
        '                                   "							 From ussSSActivityLog  " +
        '                                   "							 Group By ActivityID) " +
        '                                   "                And CurrentState = 1) " +
        '                                   "And ussSSActivity.JobID = ussSSJob.ID " +
        '                                   "And ussSSJob.JobStateID = 0 " +
        '                                   "And Not ussSSJob.PrimaryArtisanID is Null " +
        '                                   "and ussSSActivity.OperationID In (Select ussSSOperationArtisans.OperationID From ussSSOperationArtisans Where ussSSOperationArtisans.ArtisanID = {0}) " +
        '                                   "And ussSSActivity.OperationID In (Select ussSSOperation.id From ussSSOperation Where ussSSOperation.AllowArtisanToAssign = 1) " +
        '                                   "Group By JobID " +
        '                                   "Having Max(cast(ISNULL(IsNextActivity,0)as int)) = 0 ", Artisan.ID)
        Dim SqlSelectStatement As String = String.Format("Select JobID " & _
                                           "From ussSSActivity Join ussSSJob   " & _
                                           "	On ussSSActivity.JobID = ussSSJob.id " & _
                                           "Join ussSSOperation OperationM " & _
                                           "	On ussSSActivity.OperationID =  OperationM.id " & _
                                           "        Join ussSSOperationArtisans  " & _
                                           "	On ussSSActivity.OperationID = ussSSOperationArtisans.OperationID " & _
                                           "	And ussSSOperationArtisans.ArtisanID = {0} " & _
                                           "Where Not ussSSActivity.id in (Select ActivityID From ussSSActivityLog Where ID in (Select Max(ID) As ID From ussSSActivityLog Group By ActivityID) And CurrentState = 1)  " & _
                                           "And ussSSActivity.JobID = ussSSJob.ID  " & _
                                           "And ussSSJob.JobStateID = 0  " & _
                                           "And Not ussSSJob.PrimaryArtisanID is Null  " & _
                                           "And OperationM.AllowArtisanToAssign = 1 " & _
                                           "Group By JobID Having Max(cast(ISNULL(IsNextActivity,0)as int)) = 0 ", Artisan.ID)


        Dim OrphanJobssDatable As DataTable = Pastel.Evolution.DatabaseContext.ExecuteCommandDataTable(SqlSelectStatement)
        For Each row As DataRow In OrphanJobssDatable.Rows
            Try
                Dim OrphanJob As New Job
                Dim jobID As Integer = CType(row.Item(0), Integer)

                OrphanJob = API.Job.Get(jobID)
                OrphanJobList.Add(OrphanJob)
            Catch ex As Exception
            End Try
        Next

        Return OrphanJobList
    End Function


    Public Shared Function GetOrphanPartsActivityByArtisanJob(ByVal Artisan As Artisan, ByVal currentJob As Job) As List(Of Activity)
        Dim OrphanActivityList As New List(Of Activity)

        'Dim SqlSelectStatement As String = "Select JobID, PartID,Max(cast(ISNULL(IsNextActivity,0)as int))  as IsNextActivity" +
        '                                  " From ussSSActivity " +
        '                                  " Where id in(Select ActivityID " +
        '                                  " From ussSSActivityLog  " +
        '                                  " Where id in(Select Max(id) as id From ussSSActivityLog Group By ActivityID) " +
        '                                  " And CurrentState <> 1)" +
        '                                  " Group By JobID,PartID" +
        '                                  " Having Max(cast(ISNULL(IsNextActivity,0)as int)) = 0"

        Dim SqlSelectStatement As String = String.Format("Select ussSSActivity.id,JobID " +
                                           "From ussSSActivity,ussSSJob  " +
                                           "Where Not ussSSActivity.id in(Select ActivityID " +
                                           "			    From ussSSActivityLog " +
                                           "			    Where ID in (Select Max(ID) As ID " +
                                           "							 From ussSSActivityLog  " +
                                           "							 Group By ActivityID) " +
                                           "                And CurrentState = 1) " +
                                           "And ussSSActivity.JobID = ussSSJob.ID " +
                                           "And ussSSActivity.JobID = {1} " +
                                           "And ussSSJob.JobStateID = 0 " +
                                           "And Not ussSSJob.PrimaryArtisanID is Null " +
                                           "and ussSSActivity.OperationID In (Select ussSSOperationArtisans.OperationID From ussSSOperationArtisans Where ussSSOperationArtisans.ArtisanID = {0}) " +
                                           "And ussSSActivity.OperationID In (Select ussSSOperation.id From ussSSOperation Where ussSSOperation.AllowArtisanToAssign = 1) " +
                                           "Group By ussSSActivity.id,JobID " +
                                           "Having Max(cast(ISNULL(IsNextActivity,0)as int)) = 0 ", Artisan.ID, currentJob.ID)


        Dim OrphanActivityDatable As DataTable = Pastel.Evolution.DatabaseContext.ExecuteCommandDataTable(SqlSelectStatement)
        For Each row As DataRow In OrphanActivityDatable.Rows
            Try
                Dim OrphanActivity As New Activity
                Dim ActivityID As Integer = CType(row.Item(0), Integer)

                OrphanActivity = API.Activity.Get(ActivityID)
                OrphanActivityList.Add(OrphanActivity)
            Catch ex As Exception
            End Try
        Next

        Return OrphanActivityList
    End Function

End Class
