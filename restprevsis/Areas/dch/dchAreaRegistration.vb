Namespace Areas.dch
    Public Class dchAreaRegistration
        Inherits AreaRegistration

        Public Overrides ReadOnly Property AreaName() As String
            Get
                Return "dch"
            End Get
        End Property

        Public Overrides Sub RegisterArea(ByVal context As System.Web.Mvc.AreaRegistrationContext)
            context.MapRoute( _
                "dch_default", _
               "dch/{controller}/{action}/{id}", _
                New With {.action = "Index", .id = UrlParameter.Optional, .namespace = "Area.dch"} _
            )
           
        End Sub
    End Class
End Namespace

