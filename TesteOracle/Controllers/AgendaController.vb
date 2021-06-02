Imports System.Web.Mvc

Namespace Controllers
    Public Class AgendaController
        Inherits Controller

        ' GET: Agenda
        Function Agendamentos() As ActionResult
            Return View()
        End Function
    End Class
End Namespace