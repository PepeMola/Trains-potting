Public Class TrainTypes
    Public Property TrainTypeID As Integer
    Public Property TrainTypeDescription As String
    Public Property MaxCapacity As Integer
    Public Property TypDao As TrainTypesDAO

    Public Sub New()
        Me.TypDao = New TrainTypesDAO
    End Sub

    Public Sub New(id As Integer)
        Me.TypDao = New TrainTypesDAO
        Me.TrainTypeID = id
    End Sub

    Public Sub ReadAllTrainTypes(path As String)
        Me.TypDao.ReadAll(path)
    End Sub

    Public Sub ReadTrainType()
        Me.TypDao.Read(Me)
    End Sub

    Public Function InsertTrainType() As Integer
        Return Me.TypDao.Insert(Me)
    End Function

    Public Function UpdateTrainType() As Integer
        Return Me.TypDao.Change(Me)
    End Function

    Public Function DeleteTrainType() As Integer
        Return Me.TypDao.Delete(Me)
    End Function

End Class
