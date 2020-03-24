Public Class TripsDAO
    Public ReadOnly Property Trips As Collection

    Public Sub New()
        Me.Trips = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim tr As Trips
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Trips ORDER BY TripDate")
        For Each aux In col
            tr = New Trips(aux(1).ToString)
            tr.Train = aux(2).ToString
            tr.Product = aux(3).ToString
            tr.TonsTransported = aux(4).ToString
            Me.Trips.Add(tr)
        Next
    End Sub

    Public Sub Read(ByRef tr As Trips)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Trips WHERE TripDate='" & tr.TripDate & "';")
        For Each aux In col
            tr.Train = aux(2).ToString
            tr.Product = aux(3).ToString
            tr.TonsTransported = aux(4).ToString
        Next
    End Sub

    Public Function Insert(ByVal tr As Trips) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Trips VALUES ('" & tr.TripDate & "', '" & tr.Train & "', '" & tr.Product & "', '" & tr.TonsTransported & "');")
    End Function

    Public Function Change(ByVal tr As Trips) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Trips SET Train='" & tr.Train & "' AND Product='" & tr.Product & "' AND TonsTransported='" & tr.TonsTransported & "'WHERE TripDate='" & tr.TripDate & "';")
    End Function

    Public Function Delete(ByVal tr As Trips) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Trips WHERE TripDate='" & tr.TripDate & "';")
    End Function
End Class
