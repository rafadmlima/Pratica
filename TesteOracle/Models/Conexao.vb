Imports System.Data
Imports Oracle.ManagedDataAccess.Types
Imports Oracle.ManagedDataAccess.Client

Public Class DB
    Shared oradb As String = "Data Source=localhost:1521/xe;User Id=system;Password=lordsaok;"


    Public Shared Function Conectar(banco As String) As OracleConnection
        Dim conn As New OracleConnection(banco)
        Try
            conn.Open()
            'Dim cmd As New OracleCommand
            'cmd.Connection = conn
            'cmd.CommandText = "select * from usuarios"
            'cmd.CommandType = CommandType.Text
            'Dim dr As OracleDataReader = cmd.ExecuteReader()
            'If dr.Read() Then
            '    Dim Usuario As New Usuario

            '    Usuario.Id = dr.Item("ID")
            '    Usuario.Nome = dr.Item("NOME")
            '    Usuario.Senha = dr.Item("SENHA")
            '    Return Usuario
            'End If
            'conn.Dispose()
            Return conn
        Catch ex As OracleException
            Console.WriteLine(ex.Message)
        End Try
        Return conn
    End Function
    Public Shared Sub Desconectar(conn As OracleConnection)
        Try
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Shared Function Execute(ByVal sql As String) As Boolean
        Dim con As OracleConnection = Conectar(oradb)
        Try
            Dim ma As OracleCommand = New OracleCommand(sql, con)
            Execute = ma.ExecuteNonQuery()
            ma.Dispose()
            Desconectar(con)
            Return True
        Catch ex As OracleException
            Return False
        End Try
    End Function
    Public Shared Function Query(ByVal sql As String) As OracleDataReader
        Dim con As OracleConnection = Conectar(oradb)
        Try
            Dim command As OracleCommand = New OracleCommand(sql, con)
            Return command.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As OracleException
            Desconectar(con)
            Return Nothing
        End Try
    End Function
End Class
