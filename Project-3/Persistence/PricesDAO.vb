Public Class PricesDAO
    Public ReadOnly Property Prices As Collection

    Public Sub New()
        Me.Prices = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim p As Prices
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Prices ORDER BY Product")
        For Each aux In col
            p = New Prices(aux(1).ToString)
            p.PriceDate = aux(2).ToString
            p.EurosPerTon = aux(3).ToString
            Me.Prices.Add(p)
        Next
    End Sub

    Public Sub Read(ByRef p As Prices)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Prices WHERE Product='" & p.Product & "';")
        For Each aux In col
            p.PriceDate = aux(2).ToString
            p.EurosPerTon = aux(3).ToString
        Next
    End Sub

    Public Function Insert(ByVal p As Prices) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Prices VALUES ('" & p.Product & "', '" & p.PriceDate & "', '" & p.EurosPerTon & "');")
    End Function

    Public Function Change(ByVal p As Prices) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Prices SET PriceDate='" & p.PriceDate & "' AND EurosPerTon='" & p.EurosPerTon & "'WHERE Product='" & p.Product & "';")
    End Function

    Public Function Delete(ByVal p As Prices) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Prices WHERE ProductID='" & p.Product & "';")
    End Function
End Class
