Public Class JobMemo

    Private _createUser As Helper.ActiveRecord.Evolution.Agents
    Public Overridable Property CreateUser As Helper.ActiveRecord.Evolution.Agents
        Get
            If _createUser Is Nothing AndAlso Me.CreateUserID IsNot Nothing Then
                _createUser = Helper.ActiveRecord.Evolution.Agents.Find(Me.CreateUserID.Value)
            End If
            Return _createUser
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.Agents)
            _createUser = value
            NotifyPropertyChanged("CreateUser")
        End Set
    End Property

    Private _editUser As Helper.ActiveRecord.Evolution.Agents
    Public Overridable Property EditUser As Helper.ActiveRecord.Evolution.Agents
        Get
            If _editUser Is Nothing AndAlso Me.EditUserID IsNot Nothing Then
                _editUser = Helper.ActiveRecord.Evolution.Agents.Find(Me.EditUserID.Value)
            End If
            Return _editUser
        End Get
        Set(ByVal value As Helper.ActiveRecord.Evolution.Agents)
            _editUser = value
            NotifyPropertyChanged("EditUser")
        End Set
    End Property

    Public Overridable Property MemoJobStageID As Integer
        Get
            Return JobStage.ID
        End Get
        Set(value As Integer)
            JobStage = API.JobStage.Get(value)
        End Set
    End Property

End Class
