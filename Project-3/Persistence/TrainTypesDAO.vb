Public Class TrainTypesDAO
    Public ReadOnly Property TrainTypes As Collection

    Public Sub New()
        Me.TrainTypes = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim typ As TrainTypes
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM TrainTypes ORDER BY TrainTypeID")
        For Each aux In col
            typ = New TrainTypes(aux(1).ToString)
            typ.TrainTypeDescription = aux(2).ToString
            typ.MaxCapacity = aux(3).ToString
            Me.TrainTypes.Add(typ)
        Next
    End Sub

    Public Sub Read(ByRef typ As TrainTypes)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM TrainTypes WHERE Product='" & typ.TrainTypeID & "';")
        For Each aux In col
            typ.TrainTypeDescription = aux(2).ToString
            typ.MaxCapacity = aux(3).ToString
        Next
    End Sub

    Public Function Insert(ByVal typ As TrainTypes) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO TrainTypes VALUES ('" & typ.TrainTypeID & "', '" & typ.TrainTypeDescription & "', '" & typ.MaxCapacity & "');")
    End Function

    Public Function Change(ByVal typ As TrainTypes) As Integer
        Return DBBroker.GetBroker.Change("UPDATE TrainTypes SET TrainTypeDescription='" & typ.TrainTypeDescription & "' AND MaxCapacity='" & typ.MaxCapacity & "' WHERE TrainTypeID='" & typ.TrainTypeID & "';")
    End Function

    Public Function Delete(ByVal typ As TrainTypes) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM TrainTypes WHERE TrainTypeID='" & typ.TrainTypeID & "';")
    End Function
End Class
