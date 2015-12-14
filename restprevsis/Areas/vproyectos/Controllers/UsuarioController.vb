Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json
Imports System.Web.Helpers

Namespace Areas.vproyectos
    Public Class UsuarioController
        Inherits System.Web.Mvc.Controller

        ' GET api/usuario
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET api/usuario/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST api/usuario
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT api/usuario/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE api/usuario/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub

        <HttpPost()>
        <myCORS()>
        Public Function Login() As ActionResult
            Dim datos As Dictionary(Of String, String) = New Dictionary(Of String, String)
            datos.Add("respuesta", "saludos desde vp api")
            Dim jsonNetResult As New Mvc.JsonResult
            jsonNetResult.ContentType = "application/json"
            jsonNetResult.ContentEncoding = Encoding.Unicode
            jsonNetResult.Data = datos
            Return jsonNetResult
        End Function
    End Class
End Namespace