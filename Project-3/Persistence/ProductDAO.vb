Public Class ProductDAO
    Public ReadOnly Property Product As Collection

    Public Sub New()
        Me.Product = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim p As Products
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Products ORDER BY ProductID")
        For Each aux In col
            p = New Products(aux(1).ToString)
            p.ProductDescription = aux(2).ToString
            Me.Product.Add(p)
        Next
    End Sub

    Public Sub Read(ByRef p As Products)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Products WHERE ProductID=" & p.ProductID & ";")
        For Each aux In col
            p.ProductDescription = aux(2).ToString
        Next
    End Sub

    Public Sub ReadDescription(ByRef p As Products)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Products WHERE ProductID=" & p.ProductID & ";")
        For Each aux In col
            p.ProductDescription = aux(1).ToString
        Next
    End Sub

    Public Function Insert(ByVal p As Products) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Products (ProductDesciption) VALUES ('" & p.ProductDescription & "');")
    End Function

    Public Function Change(ByVal p As Products) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Products SET ProductDescription='" & p.ProductDescription & "' WHERE ProductDescription='" & p.ProductDescription & "';")
    End Function

    Public Function Delete(ByVal p As Products) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Products WHERE ProductDescription='" & p.ProductDescription & "';")
    End Function
End Class
