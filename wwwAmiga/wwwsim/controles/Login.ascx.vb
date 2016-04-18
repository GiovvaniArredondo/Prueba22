Imports System.Web.Security
Public Class Login
    Inherits System.Web.UI.UserControl

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
#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region
    Private perfil As String
    Private cinfo As Globalization.CultureInfo
    Dim pClassIdio As New PageBase
    Dim eusuarios As New cusuarios

    Dim ldfecsis As Date
    Dim ldfecven As Date
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Session.Add("Usuario", "")
            Me.cargar()
            Me.CargarCombo()
            Me.inactiva()
            Session.Add("contador", 0)
        End If
        Me._ClienteSeleccionado = Me.ViewState("ClienteSeleccionado")
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim miLogin As New cLogin
        If miLogin.ValidarUsuario(Me.txtUsuario.Text, System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Me.txtClave.Text, "MD5")) Then
            FormsAuthentication.SetAuthCookie(Me.txtUsuario.Text, False)
            FormsAuthentication.RedirectFromLoginPage(Me.txtUsuario.Text, False)
        Else
            Me.FailureText.Text = "Verifique usuario y/o clave. Acceso Denegado."
        End If
    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Dim etabtvar As New cTabtvar
        Dim etabtofi As New cTabtofi
        Dim etabusu As New cTabtusu
        Dim lvalida As Boolean
        Dim lvalida2 As Boolean
        Dim lccodofi As String
        Dim lccodusu As String

        lccodusu = etabusu.usuariooficina(Me.txtUsuario.Text.Trim)

        If lccodusu = "" Then
            Response.Write("<script language='javascript'>alert('Usuario no existe, Ingrese datos correctos ')</script>")
            Exit Sub
        Else

            lccodofi = lccodusu

            lvalida2 = etabtofi.ValidaEstadoAgencia(lccodofi)
            If lvalida2 = False Then
                Response.Write("<script language='javascript'>alert('Cierre de Agencia Operado, Intente más Tarde ')</script>")
                Exit Sub
            Else
            End If
        End If


        'Verifica estado del aplicativo
        lvalida = etabtvar.ValidaEstadoCierre()

        If lvalida = False Then

            'Valida grupo de usuario
            lvalida2 = eusuarios.VerificarAccesoGrupo(Me.txtUsuario.Text.Trim)
            If lvalida2 = True Then
            Else
                Response.Write("<script language='javascript'>alert('Cierre Diario en Proceso, Intente más Tarde ')</script>")
                Exit Sub
            End If
        End If

        'If miLogin.ValidarUsuario(Me.txtUsuario.Text, System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Me.txtClave.Text, "MD5")) Then
        'FormsAuthentication.SetAuthCookie(Me.txtUsuario.Text, False)
        'FormsAuthentication.RedirectFromLoginPage(Me.txtUsuario.Text, False)
        'Else
        '   Me.FailureText.Text = "Verifique usuario y/o clave. Acceso Denegado."
        'End If
        '----
        Me.txtClave.Text = Me.txtClave.Text.ToUpper
        If Me.txtUsuario.Text = "" Or Me.txtClave.Text = "" Then
            Me.FailureText.Text = "Verifique usuario y/o clave. Acceso Denegado."
            Exit Sub
        Else
            Me.FailureText.Text = ""
        End If
        Dim miLogin As New cLogin
        Dim lcnombre As String
        Dim sys As New System.Security.Cryptography.SHA1CryptoServiceProvider

        lcnombre = Me.txtUsuario.Text.Trim
        Session.Add("gccodusu", lcnombre.ToUpper)

        'Verifica si usuario esta Activo o Bloqueado
        Dim lstatus As Boolean
        lstatus = eusuarios.RecuperarEstatus(Me.txtUsuario.Text.Trim)
        If lstatus = False Then
            Me.FailureText.Text = "Usuario Bloqueado. Acceso Denegado."
            Return

        End If
        If miLogin.ValidarUsuario(Me.txtUsuario.Text, Convert.ToBase64String(sys.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Me.txtClave.Text)))) Then
            'Verifica fecha de vencimiento de clave
            Dim lndiaven As Integer
            Dim ldvence As Date
            lndiaven = Session("gndiasven")
            ldfecven = miLogin.VenClave(lcnombre)

            ldvence = DateAdd(DateInterval.Day, lndiaven, ldfecven)
            ldfecsis = Session("gdfecsis")

            If ldfecsis > ldvence Then
                Me.FailureText.Text = "Clave ha Caducado, Actualizar"
                'Response.Redirect("wflogin2.aspx")
                'Session.Abandon()
                'Server.Transfer("wflogin2.aspx")
                Session("Usuario") = Me.txtUsuario.Text.Trim
                ClienteSeleccionado = "0"
                RaiseEvent Seleccionado(ClienteSeleccionado)
                'Me.activa()

                '                Response.Write("<script>window.open('wfClave.aspx','cal', 'location=1, toolbar = no, status=1,width=500,height=400')</script>")
                Return
            End If
            Dim eusuarios As New cusuarios
            Dim lcyears As String
            lcyears = Me.cbxanos.SelectedValue.Trim

            FormsAuthentication.SetAuthCookie(Me.txtUsuario.Text, False)
            FormsAuthentication.RedirectFromLoginPage(Me.txtUsuario.Text, False)
            Session.Add("gnNivel", 0)
            Session.Add("gcCodOfi", "001")
            Session.Add("gnIdusuario", 0)
            Session.Add("latitud", "")
            Session.Add("longitud", "")
            Session.Add("str_select", "")
            Session.Add("gcZona", "")

            Session("gnNivel") = miLogin.Nivel(lcnombre)
            Session("gcCodOfi") = miLogin.Oficina(lcnombre)
            Session("gcfondo") = "99"
            Session("gnIdusuario") = miLogin.IdUsuario(lcnombre)
            Session("gcZona") = miLogin.zona(Session("gcCodOfi"))
            Session.Add("gdfecha", #1/1/1980#)

            Session.Add("cflag", "")
            Session.Add("gcmesvig", lcyears)

            Me.CreaCadena()
            eusuarios.GrabarIntentos(Me.txtUsuario.Text.Trim, 0)
            'Auditoria'
            'ObtenerDatos()

            Dim ip As Net.Dns
            Dim nombre_Host As String = ip.GetHostName
            Dim este_Host As Net.IPHostEntry = ip.GetHostByName(nombre_Host)
            Dim direccion_Ip As String = este_Host.AddressList(0).ToString
            Dim entidadusuarios As New usuarios
            entidadusuarios.cip = direccion_Ip
            entidadusuarios.dfecha = Today
            entidadusuarios.chora = TimeOfDay.ToString.Substring(11, 12)
            entidadusuarios.idUsuario = miLogin.IdUsuario(lcnombre)
            entidadusuarios.gdfecsis = ldfecsis
            entidadusuarios.ctrs = "IN"
            entidadusuarios.idopcion = 0
            Try
                eusuarios.RegistraAuditoria(entidadusuarios)
            Catch ex As Exception
            End Try


        Else
            Dim lncontador As Integer = 0
            Dim lnconta As Integer = 0
            lncontador = eusuarios.RecuperarIntentos(Me.txtUsuario.Text.Trim)
            lnconta = lncontador + 1
            Session("contador") = lnconta
            'Graba intento de usuario '
            eusuarios.GrabarIntentos(Me.txtUsuario.Text.Trim, lnconta)
            If lnconta >= 3 Then 'Bloquear usuario
                eusuarios.ActualizaEstado(Me.txtUsuario.Text.Trim)
                Me.FailureText.Text = "Usuario Bloqueado. Acceso Denegado."
            End If

            Me.FailureText.Text = "Verifique usuario y/o clave. Acceso Denegado."
        End If

    End Sub
    Private Sub inactiva()

        Me.Label1.Visible = False
        Me.Label7.Visible = False
        Me.Label8.Visible = False
        Me.Label9.Visible = False
        Me.Label5.Visible = False

        Me.txtClave0.Visible = False
        Me.txtClave1.Visible = False
        Me.txtClave2.Visible = False

        Me.Button1.Visible = False
    End Sub
    Private Sub activa()
        Me.Label1.Visible = True
        Me.Label7.Visible = True
        Me.Label8.Visible = True
        Me.Label9.Visible = True
        Me.Label5.Visible = True

        Me.txtClave0.Visible = True
        Me.txtClave1.Visible = True
        Me.txtClave2.Visible = True

        Me.Button1.Visible = True

    End Sub

    Private Sub cargayears()
        Dim clscntaprm As New SIM.BL.cCntaprm
        Dim mlistacntaprm As New listacntaprm

        Dim lcfondo As String

        lcfondo = Me.cbxfondos.SelectedValue.Trim
        clscntaprm.cfondo = lcfondo
        mlistacntaprm = clscntaprm.ObtenerListaPorIDyear()

        Me.cbxanos.DataTextField = "año"
        Me.cbxanos.DataValueField = "cmesvig"
        Me.cbxanos.DataSource = mlistacntaprm
        Me.cbxanos.DataBind()
    End Sub

    Private Sub CargarCombo()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab


        mListaTabttab = clstabttab.ObtenerLista("120", "1")

        Me.cbxfondos.DataTextField = "cdescri"
        Me.cbxfondos.DataValueField = "ccodigo"
        Me.cbxfondos.DataSource = mListaTabttab
        Me.cbxfondos.DataBind()

        Me.cargayears()

    End Sub

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub GrabaIdioma()
        'actualiza tabla de idiomas
        Dim idioma As String
        idioma = Session("gcIdioma")
        Dim mtabtvar As New cTabtvar
        Dim etabtvar As New tabtvar

        etabtvar.ccodapl = "CRE"
        etabtvar.cnomvar = "gcIdioma"
        mtabtvar.ObtenerTabtvar(etabtvar)
        etabtvar.lcarini = True
        etabtvar.cconvar = idioma
        mtabtvar.ActualizarTabtvar(etabtvar)
    End Sub
    Private Sub cargar()
        'carga variables globales
        Dim clsvariables As New SIM.BL.cTabtvar
        Dim dst As New DataSet
        Dim filavariables As DataRow
        Dim lcnomvar As String
        Dim lcconvar As String
        dst = clsvariables.ObtenerDataSetPorID()
        If dst.Tables(0).Rows.Count > 0 Then
            For Each filavariables In dst.Tables(0).Rows
                If filavariables("lcarini") = True Then
                    lcnomvar = filavariables("cnomvar")
                    lcnomvar = lcnomvar.Trim
                    lcconvar = filavariables("cconvar")
                    lcconvar = lcconvar.Trim
                    Select Case filavariables("ctipvar") ' Evaluate Number.
                        Case "F"
                            Session.Add(lcnomvar, Date.Parse(lcconvar))
                        Case "D"
                            Session.Add(lcnomvar, Double.Parse(lcconvar))
                        Case "N"
                            Session.Add(lcnomvar, Integer.Parse(lcconvar))
                        Case "C"
                            Session.Add(lcnomvar, lcconvar.ToString)
                        Case Else   ' Other values.
                            Session.Add(lcnomvar, lcconvar.ToString)
                    End Select
                End If
            Next
        End If
    End Sub
    Private Sub CreaCadena()
        Dim cnnstr1 As String
        Dim lcnomser As String
        Dim lcfondo As String
        Dim lcyears As String

        lcfondo = Me.cbxfondos.SelectedValue.Trim
        lcyears = Me.cbxanos.SelectedValue.Trim

        lcnomser = Session("gcnomser")
        If lcfondo = "99" Then
        Else
            Dim ectbmcta As New cCtbmcta
            Dim j As Integer
            j = ectbmcta.EntradaCatalogo(lcfondo.Trim)

        End If
        Session.Add("gcfondo", lcfondo)
        Session.Add("gcyears", lcyears)
        Dim lcnomfon As String
        Dim i As Integer
        i = Me.cbxfondos.SelectedIndex
        lcnomfon = Me.cbxfondos.Items(i).Text
        Session.Add("gcnomfon", lcnomfon)

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim miLogin As New cLogin

        Dim sys As New System.Security.Cryptography.SHA1CryptoServiceProvider


        If miLogin.ValidarUsuario(Me.txtUsuario.Text, Convert.ToBase64String(sys.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Me.txtClave2.Text.ToUpper)))) Then
            'Clave Valida
            'verifica claves
            If Me.txtClave0.Text.Trim <> Me.txtClave1.Text.Trim Then
                Response.Write("<script language='javascript'>alert('Claves no coinciden')</script>")
                Return
            Else
                If txtClave2.Text.Trim = txtClave0.Text.Trim Then
                    Response.Write("<script language='javascript'>alert('Clave no puede ser igual a Anterior')</script>")
                    Return

                End If

                '
                Dim ldfecven As Date
                Dim ldfecsis As Date
                Dim lndiasven As Integer
                ldfecsis = Session("gdfecsis")
                lndiasven = Session("gndiasven")
                ldfecven = DateAdd(DateInterval.Day, lndiasven, ldfecsis)
                Dim i As Integer
                i = eusuarios.ActualizaClave(Me.txtUsuario.Text.Trim, Convert.ToBase64String(sys.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Me.txtClave0.Text.ToUpper))), ldfecven)
                inactiva()
                Me.FailureText.Text = ""
                eusuarios.GrabarIntentos(Me.txtUsuario.Text.Trim, 0)
                Response.Write("<script language='javascript'>alert('Clave Actualizada')</script>")
            End If
        Else
            Response.Write("<script language='javascript'>alert('Clave Iválida')</script>")
            Return
        End If
    End Sub

    Protected Sub txtClave1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClave1.TextChanged
        Me.Button1_Click(sender, e)
    End Sub
    'Private Sub ObtenerDatos()
    '    '    Dim nombreHost As String = System.Net.Dns.GetHostName
    '    '    Dim hostInfo As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(nombreHost)
    '    '    Dim lblDireccionHost As String = ""
    '    '    Dim lblNombreHost As String = ""

    '    '    lblNombreHost = "El nombre de tu maquina es: " & hostInfo.HostName.ToString
    '    '    For Each ip As System.Net.IPAddress In hostInfo.AddressList
    '    '        lblDireccionHost = ip.ToString
    '    '    Next
    '    '    Return lblDireccionHost
    '    System.Net.Dns.GetHostEntry("").AddressList(0).ToString()
    '    Dim ipentry As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry("")
    '    For i As Integer = 0 To ipentry.AddressList.Rank - 1
    '        MsgBox(System.Net.Dns.GetHostEntry("").AddressList(i).ToString)
    '    Next

    'End Sub

End Class
