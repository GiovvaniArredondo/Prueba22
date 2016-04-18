Imports System.Web.Security




Partial Class MenuLateral
    Inherits ucWBase

    Private _UsarCarrito As Boolean
    Private _ClienteVisitante As Boolean

    Public Property UsarCarrito() As Boolean
        Get
            Return _UsarCarrito
        End Get
        Set(ByVal Value As Boolean)
            Me.ibtnCarrito.Enabled = Value
            Me._UsarCarrito = Value
        End Set
    End Property

    Public Property ClienteVisitante() As Boolean
        Get
            Return _ClienteVisitante
        End Get
        Set(ByVal Value As Boolean)
            Me.ibtnCarrito.Visible = Value
            Me._ClienteVisitante = Value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Request.IsAuthenticated Then
            Me.loginTable.Visible = HttpContext.Current.User.IsInRole("VS")
            'Si es Cliente o Visitante
            If HttpContext.Current.User.IsInRole("VS") Or HttpContext.Current.User.IsInRole("CL") Then
                Me.ClienteVisitante = True
                Me.UsarCarrito = Not HttpContext.Current.User.IsInRole("VS")
            End If
            'Si es Distribuidora
            If HttpContext.Current.User.IsInRole("DS") Then
                Me.ClienteVisitante = False
            End If
        End If
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        'Dim miLogin As New cLogin
        'If miLogin.ValidarUsuario(Me.txtUsuario.Text, Me.txtClave.Text, Me.perfilUsuario.Value) Then
        'FormsAuthentication.SignOut()
        'FormsAuthentication.SetAuthCookie(Me.txtUsuario.Text, False)
        'Response.Redirect("Principal.aspx")
        'Else
        '    Me.FailureText.Text = "Verifique usuario y/o clave. Acceso Denegado."
        'End If
    End Sub
End Class


