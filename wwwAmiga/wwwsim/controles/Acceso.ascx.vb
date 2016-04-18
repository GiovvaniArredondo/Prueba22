
Partial Class Acceso
    Inherits ucWBase

    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)


    Public Property ClienteSeleccionado() As String
        Get
            Return _ClienteSeleccionado
        End Get
        Set(ByVal Value As String)
            _ClienteSeleccionado = Value
            If ViewState("ClienteSeleccionado") Is Nothing Then
                ViewState.Add("ClienteSeleccionado", Value)
            Else
                ViewState("ClienteSeleccionado") = Value
            End If
        End Set
    End Property

    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

    Dim eusuarios As New cusuarios

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.txtClave.Text = Me.txtClave.Text.ToUpper
        If Me.txtUsuario.Text = "" Or Me.txtClave.Text = "" Then
            Session("fuente") = "0"
            Exit Sub
        Else

        End If
        Dim miLogin As New cLogin
        Dim lcnombre As String
        Dim sys As New System.Security.Cryptography.SHA1CryptoServiceProvider

       
        'Verifica si usuario esta Activo o Bloqueado
        Dim lstatus As Boolean
        lstatus = eusuarios.RecuperarEstatus(Me.txtUsuario.Text.Trim)
        If lstatus = False Then
            Session("fuente") = "0"
            Return

        End If

        'Verifica si usuarios es Jefe de Agencia

        Dim lvalida As Boolean
        lvalida = eusuarios.VerificaCargo(txtusuario.Text.Trim, Session("gccodofi"), Session("codigo"))
        If lvalida = False Then
            Session("fuente") = "0"
            'Return
        Else
            If miLogin.ValidarUsuario(Me.txtusuario.Text, Convert.ToBase64String(sys.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Me.txtClave.Text)))) Then
                'FormsAuthentication.SetAuthCookie(Me.txtUsuario.Text, False)
                'FormsAuthentication.RedirectFromLoginPage(Me.txtUsuario.Text, False)
                Session("fuente") = "1"
            Else
                Dim lncontador As Integer = 0
                Session("fuente") = "0"
            End If
        End If
     
        Response.Write("<script>window.close('wfAcceso.aspx')</script>")
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then


            Me.txtusuario.Text = "" 'Session("codigo")
            '           Me.txtfuente.Text = Session("fuente")
            '            Session("codigo") = "EMLA"
            '           Session("fuente") = ""



        End If

    End Sub
End Class
