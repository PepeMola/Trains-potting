Public Class Query2DAO
    Public ReadOnly Property query As Collection
    Public ReadOnly Property solution As DataTable

    Public Sub New()
        Me.query = New Collection
        Me.solution = New DataTable
    End Sub

    Public Sub ReadQuery2(ByRef q As Query2)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT ty.TrainTypeDescription, COUNT(*) As Total FROM Trips t, Trains tr, TrainTypes ty WHERE t.Train = tr.TrainID AND tr.TrainType= ty.TrainTypeID 
                                       AND t.TripDate>=#" & q.DateStart & "# AND t.TripDate <=#" & q.DateEnd & "# 
                                       GROUP BY ty.TrainTypeDescription ORDER BY COUNT(*);")

        'Here we create the table format in which we store the info of the query
        solution.Columns.Add("Train Type", GetType(String))
        solution.Columns.Add("Total Trips", GetType(String))

        For Each aux In col
            solution.Rows.Add(aux(1).ToString, aux(2).ToString)
        Next
    End Sub
End Class
