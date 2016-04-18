Public Class uccreausu
    Inherits System.Web.UI.UserControl
    Protected WithEvents encriptado As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents clave As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtcodusu As System.Web.UI.WebControls.TextBox
    Protected WithEvents indica As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents btngrabar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btnaplicar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents cbxCodOFi As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtconfirmar As System.Web.UI.WebControls.TextBox
    ' Protected WithEvents Button1 As System.Web.UI.WebControls.Button

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents txtcodigo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtnombre As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtdireccion As System.Web.UI.WebControls.TextBox
    Protected WithEvents txttelefono As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlcargo As System.Web.UI.WebControls.DropDownList

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            carga()
        End If
    End Sub
#Region " Variables "
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private ds As New DataSet

    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String

    Private Transacc As String
#End Region

    Sub carga()
        Dim listaprf As New listatabtprf
        Dim clsprf As New cTabtprf

        listaprf = clsprf.ObtenerLista()

        Me.ddlcargo.DataTextField = "cdescri"
        Me.ddlcargo.DataValueField = "ccodigo"
        Me.ddlcargo.DataSource = listaprf
        Me.ddlcargo.DataBind()

        '----------------------------
        'Llenando Oficinas
        '----------------------------
        lnparametro1_R = "cNomOfi , cCodOfi, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTOFI"
        lnparametro5_R = "S"
        lnparametro6_R = " "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        'For Each fila1 In ds.Tables("Resultado").Rows
        '    Me.CbxCodOFi.Items.Add(fila1("cCodOfi") & "   --" & " " & fila1("cNomOFi"))
        'Next
        'Me.CbxCodOFi.SelectedIndex = 0
        Me.CbxCodOFi.DataTextField = "cNomOfi"
        Me.CbxCodOFi.DataValueField = "cCodOfi"
        Me.CbxCodOFi.DataSource = ds.Tables("Resultado")
        Me.CbxCodOFi.DataBind()

    End Sub

    Public Sub CargarPorusu(ByVal codigo As String)
        Me.txtcodigo.Text = codigo
        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub



    Private Sub clave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clave.TextChanged

    End Sub



    Private Sub btngrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.ServerClick
        Dim strClave As String
        Dim strClave2 As String
        Dim eusuarios As New usuarios
        Dim musuarios As New cusuarios
        Dim lccodusu As String
        Dim lccargo As String
        Dim lccodofi As String

        'encripta la clave
        strClave = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(clave.Text, "MD5")
        strClave2 = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Me.txtconfirmar.Text, "MD5")

        lccodusu = Me.txtcodigo.Text.Trim
        lccargo = Me.ddlcargo.SelectedValue.Trim
        lccodofi = Me.cbxCodOFi.SelectedValue.Trim

        If lccodusu <> Nothing And Me.txtcodigo.Text.Trim <> Nothing Then
            If strClave = strClave2 Then
                'grabar
                Try
                    eusuarios.idUsuario = Me.txtcodigo.Text.Trim
                    eusuarios.usuario = Me.txtcodusu.Text.Trim
                    eusuarios.nombre = Me.txtnombre.Text.Trim
                    eusuarios.password = strClave
                    eusuarios.telefono = Me.txttelefono.Text.Trim
                    eusuarios.direccion = Me.txtdireccion.Text.Trim
                    eusuarios.cargo = lccargo
                    eusuarios.ccodofi = lccodofi
                    If lccodusu = "0000" Then
                        'agregar
                        lccodusu = musuarios.ObtenerID(eusuarios)
                        lccodusu = lccodusu.Trim
                        eusuarios.idUsuario = lccodusu
                        musuarios.agregar(eusuarios)
                    Else
                        'actualizar datos
                        musuarios.Actualizarusuarios(eusuarios)
                    End If
                    Response.Write("<script language='javascript'>alert('ok')</script>")

                Catch ex As Exception

                    Response.Write("<script language='javascript'>alert('error en traslado de informacion')</script>")
                End Try
            Else
                Response.Write("<script language='javascript'>alert('Claves son distintas, intentar otra vez')</script>")
            End If
        Else
            Response.Write("<script language='javascript'>alert('Codigo usuario vacio')</script>")
        End If
    End Sub

    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick
        Dim lccodusu As String
        Dim musuarios As New cusuarios
        Dim eusuarios As New usuarios
        lccodusu = Me.txtcodigo.Text
        eusuarios.idUsuario = lccodusu
        Me.txtcodigo.Text = lccodusu
        Me.txtcodigo.Enabled = False
        If lccodusu <> "0000" Then
            Me.indica.Text = "Modificacion de Usuarios"
            musuarios.Obtenerusuarios(eusuarios)
            Me.txtnombre.Text = eusuarios.nombre
            Me.txtcodusu.Text = eusuarios.usuario
            Me.txtdireccion.Text = eusuarios.direccion
            Me.txttelefono.Text = eusuarios.telefono
            '     Me.ddlcargo.SelectedValue = eusuarios.cargo
        Else
            Me.indica.Text = "Crear Usuario"
        End If
    End Sub
End Class


