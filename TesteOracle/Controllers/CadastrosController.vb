Imports System.Web.Mvc
Imports Oracle.ManagedDataAccess.Client

Namespace Controllers
    Public Class CadastrosController
        Inherits Controller

        ' GET: Cadatros
        Function Medicos() As ActionResult
            Dim Result As New List(Of Medico)
            Dim DR As OracleDataReader = DB.Query($"select * from medicos order by nome")
            While DR.Read()
                Dim m As New Medico
                m.Id = DR("Id")
                m.Nome = DR("Nome")
                m.CRM = DR("CRM")
                m.Especialidade = DR("Especialidade")
                Result.Add(m)
            End While
            Return View(Result)
        End Function
        Function InserirMedico() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function InserirMedico(m As Medico) As ActionResult
            If Not IsNothing(m) Then
                Dim result = DB.Execute($"insert into medicos (nome,especialidade,crm) values ('{m.Nome}','{m.Especialidade}','{m.CRM}')")
                If result Then
                    Return View("Medicos")
                End If
            End If
            Return View()
        End Function
        Function Pacientes(p As Paciente) As ActionResult
            Return View()
        End Function

        Function InserirPaciente() As ActionResult
            Return View()
        End Function
    End Class
End Namespace