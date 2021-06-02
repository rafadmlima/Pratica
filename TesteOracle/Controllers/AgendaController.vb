Imports System.Web.Mvc
Imports Oracle.ManagedDataAccess.Client

Namespace Controllers
    Public Class AgendaController
        Inherits Controller

        ' GET: Agenda
        Function Agendamentos() As ActionResult
            Dim Result As New List(Of Agendamento)
            Dim DR As OracleDataReader = DB.Query($"SELECT A.*,P.NOME AS PACIENTE,M.NOME AS MEDICO, M.ESPECIALIDADE FROM AGENDAMENTOS A, PACIENTES P, MEDICOS M WHERE TRUNC(DATACONSULTA)<>TRUNC(SYSDATE) 
AND A.IDPACIENTE = P.ID AND M.ID = A.IDMEDICO")
            While DR.Read()
                Dim m As New Agendamento
                m.Id = DR("Id")
                m.IdMedico = DR("IdMedico")
                m.IdPaciente = DR("IdPaciente")
                m.Especialidade = DR("Especialidade")
                m.Medico = DR("Medico")
                m.Paciente = DR("Paciente")
                m.DataConsulta = DR("DataConsulta")

                Result.Add(m)
            End While
            Return View(Result)

        End Function
    End Class
End Namespace