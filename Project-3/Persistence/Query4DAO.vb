Public Class Query4DAO
    Public ReadOnly Property query As Collection
    Public ReadOnly Property solution As DataTable
    Public Property trip As Trip
    Public Property tr As Train
    Public Property type As TrainType

    Public Sub New()
        Me.query = New Collection
        Me.solution = New DataTable
    End Sub

    Public Sub ReadQuery4(ByRef q As Query4)
        Dim col As Collection : Dim aux As Collection
        Dim productsCol As Collection
        col = DBBroker.GetBroker.Read("SELECT t1.TripDate, t1.Train, tr1.TrainTypeDescription, SUM(t1.TonsTransported*pr1.EurosPerTon) AS MaxProfit
                                        FROM Trips AS t1, Products AS p1, Prices AS pr1, TrainTypes tr1, Trains tra
                                        WHERE t1.Product = p1.ProductID AND p1.ProductID = pr1.Product AND t1.Train =tra.TrainID AND tra.TrainType = tr1.TrainTypeID
                                        GROUP BY t1.TripDate, t1.Train, tr1.TrainTypeDescription
                                        HAVING SUM(t1.TonsTransported*pr1.EurosPerTon) =
                                            (SELECT MAX(tr.Profit) 
                                             FROM (SELECT t.TripDate, t.Train, SUM(t.TonsTransported*pr.EurosPerTon) AS Profit FROM Trips AS t, Products AS p, Prices AS pr 
                                             WHERE t.Product = p.ProductID AND p.ProductID = pr.Product
                                             GROUP BY t.TripDate, t.Train)  AS tr);")

        For Each aux In col
            Me.query.Add(FormatDateTime(aux(1), DateFormat.ShortDate).ToString)
            Me.query.Add(aux(2).ToString)
            Me.query.Add(aux(3).ToString)
            Me.query.Add(aux(4).ToString)
        Next
        tr = New Train(query(2).ToString)
        tr.ReadTrain()
        trip = New Trip(query(1).ToString, tr.TrainID)
        trip.ReadTrip()

        productsCol = DBBroker.GetBroker.Read("SELECT p.ProductDescription, t.TonsTransported, pri.EurosPerTon, pri.PriceDate, SUM(t.TonsTransported * pri.EurosPerTon) AS Profit
                                               FROM Products p, Trips t, Prices pri
                                               WHERE p.ProductID = t.Product AND pri.Product = p.ProductID AND t.Train ='" & trip.Train & "' AND t.TripDate=#" & trip.TripDate & "#
                                               GROUP BY p.ProductDescription, t.TonsTransported, pri.EurosPerTon, pri.PriceDate")

        'Here we create the table format in which we store the info of the query
        solution.Columns.Add("Product Description", GetType(String))
        solution.Columns.Add("Tons Transported", GetType(Integer))
        solution.Columns.Add("Euros Per Ton", GetType(Double))
        solution.Columns.Add("Price Date", GetType(String))
        solution.Columns.Add("Profit", GetType(Double))

        For Each aux In productsCol
            solution.Rows.Add(aux(1).ToString, aux(2).ToString, aux(3).ToString, FormatDateTime(aux(4), DateFormat.ShortDate).ToString, aux(5).ToString)
        Next

    End Sub
End Class
