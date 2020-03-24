Public Class ProductDAO
    Public ReadOnly Property Product As Collection

    Public Sub New()
        Me.Product = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim p As Product
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Product ORDER BY ProductID")
        For Each aux In col
            p = New Product(aux(1).ToString)
            p.ProductDescription = aux(2).ToString
            Me.Product.Add(p)
        Next
    End Sub

    Public Sub Read(ByRef p As Product)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Products WHERE ProductID='" & p.ProductID & "';")
        For Each aux In col
            p.ProductDescription = aux(2).ToString
        Next
    End Sub

    Public Function Insert(ByVal p As Product) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Products VALUES ('" & p.ProductID & "', '" & p.ProductDescription & "');")
    End Function

    Public Function Change(ByVal p As Product) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Products SET ProductDescription='" & p.ProductDescription & "' WHERE ProductID='" & p.ProductID & "';")
    End Function

    Public Function Delete(ByVal p As Product) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Products WHERE ProductID='" & p.ProductID & "';")
    End Function
End Class
