Namespace Areas.vproyectos
    Public Class vproyectosAreaRegistration
        Inherits AreaRegistration

        Public Overrides ReadOnly Property AreaName() As String
            Get
                Return "vproyectos"
            End Get
        End Property

        Public Overrides Sub RegisterArea(ByVal context As System.Web.Mvc.AreaRegistrationContext)
            context.MapRoute( _
                "vproyectos_default", _
               "vproyectos/{controller}/{action}/{id}", _
                New With {.action = "Index", .id = UrlParameter.Optional, .namespace = "Area.vproyectos"} _
            )
        End Sub
    End Class
End Namespace

