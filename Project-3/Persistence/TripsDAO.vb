Public Class TripDAO
    Public ReadOnly Property Trip As Collection

    Public Sub New()
        Me.Trip = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim tr As Trip
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Trips ORDER BY TripDate")
        For Each aux In col
            tr = New Trip(aux(1).ToString)
            tr.Train = aux(2).ToString
            tr.Product = aux(3).ToString
            tr.TonsTransported = aux(4).ToString
            Me.Trip.Add(tr)
        Next
    End Sub

    Public Sub Read(ByRef tr As Trip)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Trips WHERE TripDate=#" & tr.TripDate & "# AND Train='" & tr.Train & "';")
        For Each aux In col
            tr.Train = aux(2).ToString
            tr.Product = aux(3).ToString
            tr.TonsTransported = aux(4).ToString
        Next
    End Sub

    Public Sub ReadTrip(ByRef tr As Trip)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT TripDate, Train, Product FROM Trips WHERE TripDate=#" & tr.TripDate & "# AND Train='" & tr.Train & "';")
        For Each aux In col
            tr.Train = aux(2).ToString
            tr.Product = aux(3).ToString
            tr.TonsTransported = aux(4).ToString
        Next
    End Sub

    Public Function existTrip(ByRef tr As Trip) As Integer
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Trips WHERE TripDate=#" & tr.TripDate & "# AND Train='" & tr.Train & "' AND Product=" & tr.Product & ";")
        For Each aux In col
            If (tr.Train = aux(2).ToString) And (tr.Product = aux(3).ToString) And (tr.TripDate = aux(1).ToString) Then
                Return -1
            Else
                Return 0
            End If
        Next
    End Function

    Public Function Insert(ByVal tr As Trip) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Trips (TripDate, Train, Product, TonsTransported) VALUES (#" & tr.TripDate & "#, '" & tr.Train & "', " & tr.Product & ", " & tr.TonsTransported & ");")
    End Function

    Public Function Change(ByVal tr As Trip) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Trips SET Train='" & tr.Train & "' AND Product=" & tr.Product & " AND TonsTransported=" & tr.TonsTransported & " WHERE TripDate=#" & tr.TripDate & "#;")
    End Function

    Public Function Delete(ByVal tr As Trip) As Integer
        MessageBox.Show(tr.TripDate & " " & tr.Train & " " & tr.Product)
        Return DBBroker.GetBroker.Change("DELETE FROM Trips WHERE TripDate=#" & tr.TripDate & "# AND Train='" & tr.Train & "' AND Product=" & tr.Product & ";")
    End Function
End Class
