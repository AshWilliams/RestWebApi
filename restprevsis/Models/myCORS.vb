
Public Class myCORSAttribute
    Inherits ActionFilterAttribute

    Public Overrides Sub OnActionExecuting(ByVal filterContext As ActionExecutingContext)
        Dim ctx As HttpContext = HttpContext.Current
        ctx.Response.AddHeader("Access-Control-Allow-Origin", "*")
        ctx.Response.AddHeader("Access-Control-Allow-Headers", "*")
        MyBase.OnActionExecuting(filterContext)
    End Sub
End Class
