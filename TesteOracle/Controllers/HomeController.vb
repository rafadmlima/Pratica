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
            Return View("Home", New With {result.Nome})
        End If
        Return View("Index")
    End Function

End Class
