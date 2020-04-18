Public Class Query1DAO
    Public ReadOnly Property query As Collection
    Public ReadOnly Property solution1 As DataTable

    Public Sub New()
        Me.query = New Collection
        Me.solution1 = New DataTable
    End Sub

    Public Sub ReadQuery(ByRef q As Query1)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT Trips.TripDate, Trips.Train, Products.ProductDescription FROM Products INNER JOIN Trips ON Products.ProductID = Trips.Product
                                       WHERE (((Trips.TripDate)>=#" & q.DateStart & "# And (Trips.TripDate)<=# " & q.DateEnd & "#) AND ((Trips.Train)='" & q.TrainID & "'));")
        For Each aux In col
            solution1.Rows.Add(aux(1).ToString, aux(2).ToString, aux(3).ToString)
        Next
    End Sub
End Class
