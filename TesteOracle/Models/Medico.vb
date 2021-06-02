Public Class Medico
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
    Private _Especialidade As String
    Public Property Especialidade() As String
        Get
            Return _Especialidade
        End Get
        Set(ByVal value As String)
            _Especialidade = value
        End Set
    End Property
    Private _CRM As Long
    Public Property CRM() As Long
        Get
            Return _CRM
        End Get
        Set(ByVal value As Long)
            _CRM = value
        End Set
    End Property
End Class
