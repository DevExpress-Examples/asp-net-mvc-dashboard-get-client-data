Imports System.Web.Http

Namespace MvcDashboardApp_ClientData

    Public Module WebApiConfig

        Public Sub Register(ByVal config As HttpConfiguration)
            config.Routes.MapHttpRoute(name:="DefaultApi", routeTemplate:="api/{controller}/{id}", defaults:=New With {.id = RouteParameter.Optional})
        End Sub
    End Module
End Namespace
