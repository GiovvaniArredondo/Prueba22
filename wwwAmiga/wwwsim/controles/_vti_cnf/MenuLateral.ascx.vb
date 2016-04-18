Imports System.Web.Security
Public Class MenuLateral
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblUsuario As System.Web.UI.WebControls.Label
    Protected WithEvents txtUsuario As System.Web.UI.WebControls.TextBox
    Protected WithEvents requiredUsuario As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblClave As System.Web.UI.WebControls.Label
    Protected WithEvents txtClave As System.Web.UI.WebControls.TextBox
    Protected WithEvents requiredClave As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents btnIngresar As System.Web.UI.WebControls.Button
    Protected WithEvents FailureText As System.Web.UI.WebControls.Literal
    Protected WithEvents HyperLink5 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents HyperLink4 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents HyperLink3 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents HyperLink2 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents HyperLink1 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents DDowl1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ibtnCarrito As System.Web.UI.WebControls.ImageButton
    Protected WithEvents loginTable As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents perfilUsuario As System.Web.UI.HtmlControls.HtmlSelect

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

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
