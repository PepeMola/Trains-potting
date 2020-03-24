Public Class TrainsDAO
    Public ReadOnly Property Trains As Collection

    Public Sub New()
        Me.Trains = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim t As Trains
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Trains ORDER BY TrainID")
        For Each aux In col
            t = New Trains(aux(1).ToString)
            t.TrainType = aux(2).ToString
            Me.Trains.Add(t)
        Next
    End Sub

    Public Sub Read(ByRef t As Trains)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Trains WHERE TrainID='" & t.TrainID & "';")
        For Each aux In col
            t.TrainType = aux(2).ToString

        Next
    End Sub

    Public Function Insert(ByVal t As Trains) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Trains VALUES ('" & t.TrainID & "', '" & t.TrainType & "');")
    End Function

    Public Function Change(ByVal t As Trains) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Trains SET TrainType='" & t.TrainType & "' WHERE TrainID='" & t.TrainID & "';")
    End Function

    Public Function Delete(ByVal t As Trains) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Trains WHERE TrainID='" & t.TrainID & "';")
    End Function
End Class
