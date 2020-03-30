Public Class Products
    Public Property ProductID As Integer
    Public Property ProductDescription As String
    Public Property ProDao As ProductDAO

    Public Sub New()
        Me.ProDao = New ProductDAO
    End Sub

    Public Sub New(id As String)
        Me.ProDao = New ProductDAO
        Me.ProductID = id
    End Sub

    Public Sub ReadAllProducts(path As String)
        Me.ProDao.ReadAll(path)
    End Sub

    Public Sub ReadProducts()
        Me.ProDao.Read(Me)
    End Sub

    Public Sub ReadProductDescription()
        Me.ProDao.Read(Me)
    End Sub

    Public Function InsertProducts() As Integer
        Return Me.ProDao.Insert(Me)
    End Function

    Public Function UpdateProducts() As Integer
        Return Me.ProDao.Change(Me)
    End Function

    Public Function DeleteProducts() As Integer
        Return Me.ProDao.Delete(Me)
    End Function

End Class
