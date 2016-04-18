Imports System.Web
Imports System.Web.SessionState
Imports System.Web.Security
Imports System.Security
Imports System.Security.Principal
Imports System
Imports SIM.EL
Imports SIM.BL
Imports System.Collections


Public Class [Global]
    Inherits System.Web.HttpApplication

#Region " Código generado por el Diseñador de componentes "

    Public Sub New()
        MyBase.New()

        'El Diseñador de componentes requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Requerido por el Diseñador de componentes
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de componentes requiere el siguiente procedimiento
    'Se puede modificar utilizando el Diseñador de componentes.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se inicia la aplicación
        Application("UsuariosVivos") = 0 'Establecemos el contador de sesion
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se inicia la sesión
        Application("UsuariosVivos") += 1 'Incrementamos en 1 la sesión del usuarios cundo este ingresa
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al principio de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso
        Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-SV")

        If Request.IsAuthenticated = True Then

            Dim roles() As String

            ' Create the roles cookie if it doesn't exist yet for this session.
            If Request.Cookies("roles") Is Nothing Then

                ' Get roles from UserRoles table, and add to cookie
                Dim controlLogin As New cLogin
                Dim mUsuario As New usuarios

                roles = controlLogin.ObtenerRoles(configuracion.idUsuario)

                ' Create a string to persist the roles
                Dim roleStr As String = ""
                Dim role As String

                For Each role In roles

                    roleStr += role
                    roleStr += ";"

                Next role


                Dim ticket As New FormsAuthenticationTicket(1, _
                    Context.User.Identity.Name, _
                    DateTime.Now, _
                    DateTime.Now.AddHours(1), _
                    False, _
                    roleStr)

                ' Encrypt the ticket
                Dim cookieStr As String = FormsAuthentication.Encrypt(ticket)

                ' Send the cookie to the client
                Response.Cookies("roles").Value = cookieStr
                Response.Cookies("roles").Path = "/"
                Response.Cookies("roles").Expires = DateTime.Now.AddMinutes(5)
                Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-SV")

            Else

                ' Get roles from roles cookie
                Dim ticket As FormsAuthenticationTicket = FormsAuthentication.Decrypt(Context.Request.Cookies("roles").Value)

                'convert the string representation of the role data into a string array
                Dim userRoles As New ArrayList

                Dim role As String

                For Each role In ticket.UserData.Split(New Char() {";"c})
                    userRoles.Add(role)
                Next role

                roles = CType(userRoles.ToArray(GetType(String)), String())

            End If

            ' Add our own custom principal to the request containing the roles in the auth ticket
            Context.User = New GenericPrincipal(User.Identity, roles)
            'HttpContext.Current.Items.Add("bienvenida", nombreEmpresa)
            'If Context.User.IsInRole("DESA") Then HttpContext.Current.Items.Add("titulo", "Bienvenido")
        End If

    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando ocurre un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando termina la sesión
        Application("UsuariosVivos") -= 1 'Decrementamos en 1 la sesión del usuarios cundo este abandona
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando termina la aplicación
    End Sub
End Class


