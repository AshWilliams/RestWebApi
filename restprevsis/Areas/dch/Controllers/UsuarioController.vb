Namespace Areas.dch
    Public Class UsuarioController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /dch/Usuario

        Function Index() As ActionResult
            Return View()
        End Function

        '
        ' GET: /dch/Usuario/Details/5

        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' GET: /dch/Usuario/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /dch/Usuario/Create

        <HttpPost()> _
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        '
        ' GET: /dch/Usuario/Edit/5

        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' POST: /dch/Usuario/Edit/5

        <HttpPost()> _
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        '
        ' GET: /dch/Usuario/Delete/5

        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' POST: /dch/Usuario/Delete/5

        <HttpPost()> _
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        Function Login() As JsonResult
            Return Json(New With {.respuesta = "saludos desde dch api"}, "application/json", JsonRequestBehavior.AllowGet)
        End Function
    End Class
End Namespace
