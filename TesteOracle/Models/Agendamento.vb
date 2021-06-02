Public Class Agendamento

    Private _Id As String
    Public Property Id() As Long
        Get
            Return _Id
        End Get
        Set(ByVal value As Long)
            _Id = value
        End Set
    End Property
    Private _IdPaciente As Long
    Public Property IdPaciente() As Long
        Get
            Return _IdPaciente
        End Get
        Set(ByVal value As Long)
            _IdPaciente = value
        End Set
    End Property
    Private _Paciente As String
    Public Property Paciente() As String
        Get
            Return _Paciente
        End Get
        Set(ByVal value As String)
            _Paciente = value
        End Set
    End Property

    Private _IdMedico As String
    Public Property IdMedico() As Long
        Get
            Return _IdMedico
        End Get
        Set(ByVal value As Long)
            _IdMedico = value
        End Set
    End Property
    Private _Medico As String
    Public Property Medico() As String
        Get
            Return _Medico
        End Get
        Set(ByVal value As String)
            _Medico = value
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
    Private _DataConsulta As DateTime
    Public Property DataConsulta() As DateTime
        Get
            Return _DataConsulta
        End Get
        Set(ByVal value As DateTime)
            _DataConsulta = value
        End Set
    End Property
    Private _Situacao As String
    Public Property Situacao() As String
        Get
            Return _Situacao
        End Get
        Set(ByVal value As String)
            _Situacao = value
        End Set
    End Property

End Class
