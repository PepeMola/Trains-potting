Public Class Trains
    Public Property TrainID As String
    Public Property TrainType As Integer
    Public Property TraDao As TrainsDAO

    Public Sub New()
        Me.TraDao = New TrainsDAO
    End Sub

    Public Sub New(TrainID As String)
        Me.TraDao = New TrainsDAO
        Me.TrainID = TrainID
    End Sub

    Public Sub New(TrainType As Integer)
        Me.TraDao = New TrainsDAO
        Me.TrainType = TrainType
    End Sub

    Public Sub ReadAllTrains(path As String)
        Me.TraDao.ReadAll(path)
    End Sub

    Public Sub ReadTrain()
        Me.TraDao.Read(Me)
    End Sub

    Public Sub ReadTrainType()
        Me.TraDao.ReadTrainType(Me)
    End Sub

    Public Function InsertTrain() As Integer
        Return Me.TraDao.Insert(Me)
    End Function

    Public Function UpdateTrain() As Integer
        Return Me.TraDao.Change(Me)
    End Function

    Public Function DeleteTrain() As Integer
        Return Me.TraDao.Delete(Me)
    End Function

End Class
