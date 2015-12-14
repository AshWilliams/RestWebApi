Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Public Class WebApiConfig
    Public Shared Sub Register(ByVal config As HttpConfiguration)

        config.Routes.MapHttpRoute( _
            name:="DefaultApi", _
            routeTemplate:="api/{controller}/{id}", _
            defaults:=New With {.id = RouteParameter.Optional} _
        )

        config.Routes.MapHttpRoute(
           name:="dch", _
           routeTemplate:="dch/{controller}/{action}/{id}", _
           defaults:=New With {.id = RouteParameter.Optional, .namespace = "Area.dch"} _
       )

        config.Routes.MapHttpRoute(
           name:="vproyectos", _
           routeTemplate:="vproyectos/{controller}/{action}/{id}", _
           defaults:=New With {.id = RouteParameter.Optional, .namespace = "Area.vproyectos"} _
       )
        'Quite los comentarios de la siguiente línea de código para habilitar la compatibilidad de consultas para las acciones con un tipo de valor devuelto IQueryable o IQueryable(Of T).
        'Para evitar el procesamiento de consultas inesperadas o malintencionadas, use la configuración de validación en QueryableAttribute para validar las consultas entrantes.
        'Para obtener más información, visite http://go.microsoft.com/fwlink/?LinkId=279712.
        'config.EnableQuerySupport()

        'Para deshabilitar el seguimiento en la aplicación, incluya un comentario o quite la siguiente línea de código
        ' Para obtener más información, consulte: http://www.asp.net/web-api
        config.EnableSystemDiagnosticsTracing()
    End Sub
End Class