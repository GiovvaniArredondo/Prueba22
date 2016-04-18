Public Class ucmovimientos
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents ddlcodins As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtcnrocta As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnaplicar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents ddlcodofi As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents txtnomcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtcodcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnimprimir As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents Button5 As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents txtfecval As System.Web.UI.WebControls.TextBox
    Protected WithEvents datos As System.Web.UI.WebControls.DataGrid

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
        If Not IsPostBack Then
            cargarcombos()
        End If
    End Sub
    Private Sub cargarcombos()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi

        Dim mlistainstitu As New listatabttab
        Dim mlistaoficina As New listatabtofi

        mlistainstitu = clstabttab.ObtenerLista("054", "1")
        mlistaoficina = clstabtofi.ObtenerLista()

        'carga instituciones
        Me.ddlcodins.DataTextField = "cdescri"
        Me.ddlcodins.DataValueField = "ccodigo"
        Me.ddlcodins.DataSource = mlistainstitu
        Me.ddlcodins.DataBind()
        'carga oficinas
        Me.ddlcodofi.DataTextField = "cnomofi"
        Me.ddlcodofi.DataValueField = "ccodofi"
        Me.ddlcodofi.DataSource = mlistaoficina
        Me.ddlcodofi.DataBind()
        Me.txtfecval.Text = #1/10/2005# ' Session("gdfecsis")

    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        viewstate.Add("pccodcta", codigoCliente)
        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub

    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick
        'cargara grid

        Dim mControl As New ckardex
        Dim mLista As New listakardex
        Dim mEntidad As New kardex
        Dim lccodcta As String
        lccodcta = viewstate("pccodcta")
        mEntidad.ccodcta = lccodcta
        mControl.Obtenerkardex(mEntidad)
        mLista.Add(mEntidad)
        Me.txtcodcli.Text = mEntidad.ccodcli
        Me.txtnomcli.Text = mEntidad.cnomcli

        Me.BindGrid(mLista)
    End Sub

    Private Sub BindGrid(ByVal aLista As listakardex)
        Me.datos.DataSource = aLista
        Me.datos.DataBind()
    End Sub

    Private Sub btnimprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.ServerClick

    End Sub
End Class
