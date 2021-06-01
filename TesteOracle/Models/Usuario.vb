Imports Oracle.ManagedDataAccess.Client

Public Class Usuario
    Dim conn As DB
    Private _Id As Long
    Public Property Id() As Long
        Get
            Return _Id
        End Get
        Set(ByVal value As Long)
            _Id = value
        End Set
    End Property
    Private _Nome As String
    Public Property Nome() As String
        Get
            Return _Nome
        End Get
        Set(ByVal value As String)
            _Nome = value
        End Set
    End Property
    Private _Senha As String
    Public Property Senha() As String
        Get
            Return _Senha
        End Get
        Set(ByVal value As String)
            _Senha = value
        End Set
    End Property

    Public Shared Function Login(u As Usuario) As Usuario
        If Not IsNothing(u) Then
            Dim DR As OracleDataReader = DB.Query($"select * from usuarios where nome='{u.Nome}' and senha='{u.Senha}'")
            If DR.Read() Then
                u.Id = DR("ID")
                u.Nome = DR("NOME")
                u.Senha = DR("SENHA")
                Return u
            End If
        End If
        Return Nothing
    End Function

End Class
