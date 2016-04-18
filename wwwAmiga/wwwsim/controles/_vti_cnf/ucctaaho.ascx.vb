Public Class ucctaaho
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents ddloficina As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtcodaho As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents txtnomcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtcodcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents txtfecha As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents ddltipaho As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents ddllineas As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents btnaplicar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btngraba As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents RangeValidator5 As System.Web.UI.WebControls.RangeValidator

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
            CargarCombos()
        End If
    End Sub
    Public Sub CargarPorcliente(ByVal ccodcli As String)
        Me.txtcodcli.Text = ccodcli
        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub

    Public Sub CargarCombos()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi
        Dim clslineas As New cAhotlin

        Dim mListaTabttab As New listatabttab
        Dim mlistalineas As New listaahotlin
        Dim mlistaoficina As New listatabtofi

        mListaTabttab = clstabttab.ObtenerLista("186", "1")
        mlistaoficina = clstabtofi.ObtenerLista()
        mlistalineas = clslineas.ObtenerLista()

        Me.ddltipaho.DataTextField = "cdescri"
        Me.ddltipaho.DataValueField = "ccodigo"
        Me.ddltipaho.DataSource = mListaTabttab
        Me.ddltipaho.DataBind()

        'carga lineas de ahorros

        Me.ddllineas.DataTextField = "cdeslin"
        Me.ddllineas.DataValueField = "cnrolin"
        Me.ddllineas.DataSource = mlistalineas
        Me.ddllineas.DataBind()
        'carga oficinas
        Me.ddloficina.DataTextField = "cnomofi"
        Me.ddloficina.DataValueField = "ccodofi"
        Me.ddloficina.DataSource = mlistaoficina
        Me.ddloficina.DataBind()

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub ddltipaho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick
        Dim eclimide As New climide
        Dim mclimide As New cClimide
        Dim lccodcli As String

        lccodcli = Me.txtcodcli.Text.Trim
        eclimide.ccodcli = Me.txtcodcli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        Me.txtnomcli.Text = eclimide.cnomcli
        Me.txtfecha.Text = Session("gdfecsis")
    End Sub

    Private Sub btngraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngraba.ServerClick
        Dim lccodcli As String
        Dim lccodaho As String
        Dim lctipo As String
        Dim lccodofi As String
        Dim linea1 As String
        Dim ldfecha As Date

        If Me.txtcodaho.Text.Trim = Nothing Then
            lccodofi = Session("gccodofi")
            ldfecha = Session("gdfecsis")
            Dim eahomcta As New ahomcta
            Dim mahomcta As New cAhomcta
            lctipo = Me.ddltipaho.SelectedValue.Trim
            lccodaho = mahomcta.ObtenerID_tipo(lctipo, lccodofi).ToString
            Me.txtcodaho.Text = lccodaho
            Try
                linea1 = Me.ddllineas.SelectedValue.Trim
                eahomcta.ccodaho = lccodaho
                eahomcta.ccodcli = Me.txtcodcli.Text.Trim
                eahomcta.ccodcta = ""
                eahomcta.ccodusu = "9999"
                eahomcta.cestado = " "
                eahomcta.cnrolin = linea1
                eahomcta.cnudotr = Me.txtcodcli.Text.Trim
                eahomcta.dfecapr = ldfecha
                eahomcta.dfeccap = ldfecha
                eahomcta.producto = lctipo
                eahomcta.nsaldoaho = 0
                eahomcta.nsaldnind = 0
                eahomcta.nlibreta = 0
                eahomcta.nmonapr = 0
                eahomcta.nmonini = 0
                eahomcta.nmonres = 0
                eahomcta.nombre = Me.txtnomcli.Text.Trim
                eahomcta.nmonini = 0
                eahomcta.dfecfin = ldfecha
                eahomcta.dfechault = ldfecha
                eahomcta.dfecmod = ldfecha
                eahomcta.dfecult = ldfecha
                eahomcta.dultmov = ldfecha
                eahomcta.dfecini = ldfecha
                mahomcta.agregar(eahomcta)
                Response.Write("<script language='javascript'>alert('ok')</script>")


            Catch ex As Exception
                Response.Write("<script language='javascript'>alert('Error de lectura de datos')</script>")

            End Try
        End If
    End Sub

  
End Class
