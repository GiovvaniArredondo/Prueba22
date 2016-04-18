Public Class ucregistro
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents ddlusuarios As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlgrupos As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ltbopciones As System.Web.UI.WebControls.ListBox
    Protected WithEvents txtcodigo As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnaplicar2 As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents btngrabar As System.Web.UI.HtmlControls.HtmlInputButton

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
        '        If Not IsPostBack Then
        cargar()
        '        End If

    End Sub
    Public Sub CargarPorusu(ByVal codigo As String)
        Me.txtcodigo.Text = codigo
        '        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub

    Sub cargar()
        'carga datos
        Dim musuarios As New cusuarios
        Dim eusuarios As New usuarios
        Dim listausu1 As New listausuarios
        Dim lccodigo As String
        Dim lncodigo As Integer
        'usuarios
        lccodigo = Me.txtcodigo.Text.Trim
        If lccodigo = "" Then
            lncodigo = 1
        Else

            lncodigo = Integer.Parse(lccodigo)
        End If


        '        listausu1 = musuarios.ObtenerLista()
        listausu1 = musuarios.ObtenerListaPorcodigo(lncodigo)
        Me.ddlusuarios.DataTextField = "usuario"
        Me.ddlusuarios.DataValueField = "idusuario"
        Me.ddlusuarios.DataSource = listausu1
        Me.ddlusuarios.DataBind()

        'grupos

        Dim mgrupos As New cgrupos
        Dim egrupos As New grupos
        Dim listagrupos2 As New listagrupos

        listagrupos2 = mgrupos.ObtenerLista()
        Me.ddlgrupos.DataTextField = "grupo"
        Me.ddlgrupos.DataValueField = "idgrupo"
        Me.ddlgrupos.DataSource = listagrupos2
        Me.ddlgrupos.DataBind()

        Dim mopciones As New copciones
        Dim eopciones As New opciones
        Dim listaopciones1 As New listaopciones
        Dim lidgrupo As String
        lidgrupo = "1"
        listaopciones1 = mopciones.ObtenerListaOpcionesGrupo(lidgrupo)
        Me.ltbopciones.DataTextField = "opcion"
        Me.ltbopciones.DataValueField = "idopcion"
        Me.ltbopciones.DataSource = listaopciones1
        Me.ltbopciones.DataBind()

    End Sub


    Private Sub btnaplicar2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar2.ServerClick

        Dim mopciones As New copciones
        Dim eopciones As New opciones
        Dim listaopciones1 As New listaopciones
        Dim lidgrupo As String
        lidgrupo = Me.ddlgrupos.SelectedValue.Trim
        listaopciones1 = mopciones.ObtenerListaOpcionesGrupo(lidgrupo)
        Me.ltbopciones.DataTextField = "opcion"
        Me.ltbopciones.DataValueField = "idopcion"
        Me.ltbopciones.DataSource = listaopciones1
        Me.ltbopciones.DataBind()

    End Sub

    Private Sub btngrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.ServerClick
        'graba en tabla usuariogrupo
        Dim eusuariogrupo As New usuarioGrupo
        Dim musuariogrupo As New cUsuarioGrupo
        Dim lnusuario As Integer
        Dim lngrupo As Integer
        Dim lcusu As String
        Dim ds As DataSet

        lcusu = Me.ddlusuarios.SelectedValue.Trim

        lnusuario = Integer.Parse(lcusu)
        lngrupo = Integer.Parse(Me.ddlgrupos.SelectedValue.Trim)
        'verfica si usuario ya tiene aplicado su perfil
        ds = musuariogrupo.ObtenerDataSetPorID2(lnusuario, lngrupo)
        If ds.Tables(0).Rows.Count > 0 Then
            Response.Write("<script language='javascript'>alert('Usuario ya tiene asignado perfil')</script>")
        Else
            eusuariogrupo.idGrupo = lngrupo
            eusuariogrupo.idUsuario = lnusuario
            musuariogrupo.agregar(eusuariogrupo)
            Response.Write("<script language='javascript'>alert('ok')</script>")

        End If

    End Sub
End Class
