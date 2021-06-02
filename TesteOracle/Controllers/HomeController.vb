Imports Microsoft.Ajax.Utilities

Public Class HomeController
    Inherits System.Web.Mvc.Controller
    Function Index() As ActionResult
        ViewBag.ShowMenu = "hidden"
        Return View()
    End Function
    <HttpPost()>
    Function Index(u As Usuario) As ActionResult
        Dim result = Usuario.Login(u)
        If Not IsNothing(result) Then
            ViewData("UNAME") = result.Nome
            ViewBag.ShowMenu = "visible"
            Return Redirect("~/Agenda/Agendamentos")
        End If
        ViewBag.ShowMenu = "hidden"
        Return View()
    End Function
End Class
