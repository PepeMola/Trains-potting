Public Class DBBroker

    Private Shared _instance As DBBroker
    Private Shared connection As OleDb.OleDbConnection 'objeto de conexion a la BD
    Private Const baseConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared connectionString As String

    Private Sub New()
        DBBroker.connection = New OleDb.OleDbConnection(DBBroker.connectionString)
        DBBroker.connection.Open()
    End Sub

    Public Shared Function GetBroker() As DBBroker 'Objeto Singleton 
        If DBBroker._instance Is Nothing Then 'si no existe ninguna instancia de agente
            DBBroker._instance = New DBBroker 'se crea una nueva
        End If
        Return DBBroker._instance 'devuelve la nueva instancia o la ya existente
    End Function

    Public Shared Function GetBroker(path As String) As DBBroker
        DBBroker.connectionString = DBBroker.baseConnectionString & path
        Return DBBroker.GetBroker 'con la cadena de conexion llama al metodo anterior
    End Function

    Public Function Read(sql As String) As Collection
        Dim result As New Collection
        Dim row As Collection
        Dim i As Integer
        Dim reader As OleDb.OleDbDataReader 'Almacena toda la información de la consulta
        Dim com As New OleDb.OleDbCommand(sql, DBBroker.connection) 'comando de la consulta
        Connect()
        reader = com.ExecuteReader 'ejecuta la consulta
        While reader.Read
            row = New Collection
            For i = 0 To reader.FieldCount - 1
                row.Add(reader(i).ToString) 'i número de columnas de las cuales queremos leer un valor
            Next
            result.Add(row)
        End While
        Diconnect()
        Return result
    End Function

    Public Function Change(sql As String) As Integer
        Dim com As New OleDb.OleDbCommand(sql, DBBroker.connection)
        Dim result As Integer
        Diconnect()
        result = com.ExecuteNonQuery 'Devuelve el número de filas afectadas
        Diconnect()
        Return result
    End Function

    Private Sub Connect()
        If DBBroker.connection.State = ConnectionState.Closed Then
            DBBroker.connection.Open()
        End If
    End Sub

    Private Sub Diconnect()
        If DBBroker.connection.State = ConnectionState.Open Then
            DBBroker.connection.Close()
        End If
    End Sub

End Class
