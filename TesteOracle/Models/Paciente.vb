Public Class Paciente
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
    Private _DataNascimento As Date
    Public Property DataNascimento() As String
        Get
            Return _DataNascimento
        End Get
        Set(ByVal value As String)
            _DataNascimento = value
        End Set
    End Property
End Class
