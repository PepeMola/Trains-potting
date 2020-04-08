Public Class Trips
    Public Property TripDate As Date
    Public Property Train As String
    Public Property Product As Integer
    Public Property TonsTransported As String
    Public Property TrDao As TripsDAO

    Public Sub New()
        Me.TrDao = New TripsDAO
    End Sub

    Public Sub New(tDate As Date)
        Me.TrDao = New TripsDAO
        Me.TripDate = tDate
    End Sub

    Public Sub ReadAllTrips(path As String)
        Me.TrDao.ReadAll(path)
    End Sub

    Public Sub ReadTrip()
        Me.TrDao.Read(Me)
    End Sub

    Public Function InsertTrip() As Integer
        Return Me.TrDao.Insert(Me)
    End Function

    Public Function UpdateTrip() As Integer
        Return Me.TrDao.Change(Me)
    End Function

    Public Function DeleteTrip() As Integer
        Return Me.TrDao.Delete(Me)
    End Function

End Class
