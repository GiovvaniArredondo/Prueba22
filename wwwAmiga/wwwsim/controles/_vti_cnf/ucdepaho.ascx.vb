Public Class ucdepaho
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents txtcodcta As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtcodcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtnomcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtsaldo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents ddlcajero As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Imprimir As System.Web.UI.WebControls.CheckBox
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents ddlbancos As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents ddloficina As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtfecha As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddltipaho As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtnrodoc As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtmonto As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents efectivo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents bancos As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents btnAplicar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btngraba As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btncancela As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents RangeValidator3 As System.Web.UI.WebControls.RangeValidator

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
            CargarCombos()
        End If
    End Sub

    Public Sub CargarDatosPorCuenta(ByVal cuenta As String)
        Me.txtcodcta.Text = cuenta
        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub



    Public Sub CargarCombos()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi
        Dim ldfecha As Date

        Dim dsc As New DataSet
        Dim dsb As New DataSet
        Dim mListaTabttab As New listatabttab
        Dim mlistainstitu As New listatabttab
        Dim mlistaoficina As New listatabtofi


        mListaTabttab = clstabttab.ObtenerLista("187", "1")
        mlistainstitu = clstabttab.ObtenerLista("054", "1")
        mlistaoficina = clstabtofi.ObtenerLista()

        Me.ddlcajero.DataTextField = "cdescri"
        Me.ddlcajero.DataValueField = "ccodigo"
        Me.ddlcajero.DataSource = mListaTabttab
        Me.ddlcajero.DataBind()

        mListaTabttab = clstabttab.ObtenerLista("189", "1")

        Me.ddltipaho.DataTextField = "cdescri"
        Me.ddltipaho.DataValueField = "ccodigo"
        Me.ddltipaho.DataSource = mListaTabttab
        Me.ddltipaho.DataBind()

        clsbancos.ObtenerDatasetporid(dsb)
        Me.ddlbancos.DataTextField = "cnombco"
        Me.ddlbancos.DataValueField = "ccodbco"
        Me.ddlbancos.DataSource = dsb.Tables(0)
        Me.ddlbancos.DataBind()

        Me.ddloficina.DataTextField = "cnomofi"
        Me.ddloficina.DataValueField = "ccodofi"
        Me.ddloficina.DataSource = mlistaoficina
        Me.ddloficina.DataBind()

        ldfecha = Session("GDFECSIS")
        Me.txtfecha.Text = ldfecha.ToString

        '    Me.txtfecha.EnableViewState = False
        Me.btnaplicar.EnableViewState = True
        Me.ddlbancos.Enabled = False

    End Sub

    Sub cancela()
        Me.txtcodcli.Text = ""
        Me.txtnomcli.Text = ""
        Me.txtcodcta.Text = ""
        Me.txtfecha.Text = ""
        Me.txtnrodoc.Text = ""
        Me.txtmonto.Text = ""
    End Sub

    Private Sub efectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efectivo.CheckedChanged
        If Me.efectivo.Checked = True Then
            Me.ddlbancos.Enabled = False
            Me.ddlcajero.Enabled = True
            Me.bancos.Checked = False
        End If
    End Sub

    Private Sub bancos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bancos.CheckedChanged
        If Me.bancos.Checked = True Then
            Me.ddlbancos.Enabled = True
            Me.ddlcajero.Enabled = False
            Me.efectivo.Checked = False
        End If
    End Sub

    Private Sub btnAplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.ServerClick
        Dim lccodaho As String
        Dim mclimide As New cClimide
        Dim eclimide As New climide
        Dim mahomcta As New cAhomcta
        Dim eahomcta As New ahomcta
        Dim lccodcli As String
        Dim ldfecha As Date
        lccodaho = Me.txtcodcta.Text.Trim
        eahomcta.ccodaho = lccodaho
        mahomcta.ObtenerAhomcta(eahomcta)
        Me.txtcodcli.Text = eahomcta.ccodcli
        Me.txtsaldo.Text = eahomcta.nsaldoaho

        eclimide.ccodcli = Me.txtcodcli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        Me.txtnomcli.Text = eclimide.cnomcli

        ldfecha = Session("GDFECSIS")
        Me.txtfecha.Text = ldfecha.ToString

    End Sub

    Private Sub btngraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngraba.ServerClick
        Dim lccodaho As String
        Dim lcnrodoc As String
        Dim lndeposito As Double
        Dim lnsaldo As Double
        Dim lnnewsal As Double
        Dim lnnumlin As Integer
        Dim ldfecha As Date
        Dim lcnumpar As String
        Dim lnnumlin2 As Integer
        Dim lcctactb As String
        Dim lccodcaja As String
        Dim lctippag As String
        Dim lccodofi As String
        lccodofi = Session("gccodofi")

        If Me.txtcodcta.Text.Trim = " " Or Me.txtcodcta.Text.Trim = Nothing Or Me.txtmonto.Text.Trim = " " Or Me.txtmonto.Text.Trim = Nothing Then
            Exit Sub
        End If

        If Me.efectivo.Checked = True Then
            lccodcaja = Me.ddlcajero.SelectedValue
            lccodcaja = ""
            lctippag = "E"
        Else
            lccodcaja = Me.ddlbancos.SelectedValue
            lctippag = "N"
        End If

        lccodaho = Me.txtcodcta.Text.Trim
        lcnrodoc = Me.txtnrodoc.Text.Trim
        lndeposito = Double.Parse(Me.txtmonto.Text.Trim)
        ldfecha = Date.Parse(Me.txtfecha.Text.Trim)

        Dim cahomcta1 As New cAhomcta
        Dim ahomcta1 As New ahomcta

        Dim cahommov1 As New cAhommov
        Dim ahommov1 As New ahommov

        If lccodaho <> Nothing And lndeposito > 0 Then

            Try
                'busca el saldo de las cuentas 
                ahomcta1.ccodaho = lccodaho
                cahomcta1.ObtenerAhomcta(ahomcta1)
                lnsaldo = ahomcta1.nsaldoaho
                lnnewsal = lnsaldo + lndeposito
                lnnumlin = ahomcta1.nnum + 1

                ahomcta1.nsaldoaho = lnnewsal
                ahomcta1.dfechault = ldfecha
                ahomcta1.dfecult = ldfecha
                ahomcta1.dfecmod = ldfecha
                ahomcta1.dultmov = ldfecha
                ahomcta1.nnum = lnnumlin
                cahomcta1.ActualizarAhomcta(ahomcta1)

                'graba los movimientos
                ahommov1.ccodaho = lccodaho
                ahommov1.nnum = lnnumlin
                ahommov1.nmonto = lndeposito
                ahommov1.nsaldoaho = lnnewsal
                ahommov1.nsaldnind = lnnewsal
                ahommov1.cconcep = "DP"
                ahommov1.ccodusu = "9999"
                ahommov1.cnumdoc = lcnrodoc
                ahommov1.dfecefe = ldfecha
                ahommov1.dfecomp = ldfecha
                ahommov1.dfecmod = ldfecha
                ahommov1.dfecope = ldfecha
                ahommov1.clinea = "S"
                ahommov1.npartida = 0
                ahommov1.interes = 0
                ahommov1.ctipope = "D"
                ahommov1.ncompen = 0
                ahommov1.notromon = 0
                ahommov1.ccodtra = " "
                cahommov1.agregar(ahommov1)

                ' graba en contabilidad
                'cntamov
                Dim cclase As New crefunc
                lcnumpar = cclase.fxStevo()

                Dim entidadcntamov As New SIM.EL.cntamov
                Dim ecntamov As New SIM.BL.cCntamov
                entidadcntamov.cnumcom = lcnumpar

                'diario
                Dim entidaddiario As New SIM.EL.diario
                Dim ediario As New SIM.BL.cDiario
                entidaddiario.cnumcom = lcnumpar

                'diario
                entidaddiario.cnumcom = lcnumpar
                entidaddiario.cglosa = "Deposito de ahorros " & lccodaho & " recibo No. " & lcnrodoc
                entidaddiario.cnumdoc = lcnrodoc
                entidaddiario.dfeccnt = ldfecha
                entidaddiario.cestado = " "
                entidaddiario.ccodofi = lccodofi
                entidaddiario.ffondos = " "
                entidaddiario.dfecdoc = ldfecha
                entidaddiario.dfecmod = ldfecha
                ediario.agregarDiario(entidaddiario)

                'cntamov
                Dim lcconcep As String
                lcconcep = Mid(lccodaho, 7, 2)
                lcctactb = cclase.fxcuentacontableahorros("C", lcconcep, "N", "N", "N", lccodofi)

                lnnumlin2 = 1
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin2
                entidadcntamov.nhaber = 0
                entidadcntamov.ndebe = lndeposito
                entidadcntamov.ccodpres = lccodaho
                entidadcntamov.cnumdoc = lcnrodoc
                entidadcntamov.ccodofi = lccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = ldfecha
                entidadcntamov.dfecmod = ldfecha
                entidadcntamov.ccodusu1 = Session("gccodusu")
                entidadcntamov.ffondos = " "
                entidadcntamov.cclase = Left(lcctactb, 1)
                entidadcntamov.cpoliza = "DP"
                ecntamov.agregarCntamov(entidadcntamov)

                'cuenta por contra
                lcctactb = cclase.fxcuentacontableahorros("CCJ", lccodcaja, "N", "N", "N", lccodofi)

                lnnumlin2 = 2
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin2
                entidadcntamov.nhaber = lndeposito
                entidadcntamov.ndebe = 0
                entidadcntamov.ccodpres = lccodaho
                entidadcntamov.cnumdoc = lcnrodoc
                entidadcntamov.ccodofi = lccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = ldfecha
                entidadcntamov.dfecmod = ldfecha
                entidadcntamov.ccodusu1 = Session("gccodusu")
                entidadcntamov.ffondos = " "
                entidadcntamov.cclase = Left(lcctactb, 1)
                entidadcntamov.cpoliza = "DP"
                ecntamov.agregarCntamov(entidadcntamov)


                Response.Write("<script language='javascript'>alert('ok')</script>")
                cancela()

            Catch ex As Exception
                Response.Write("<script language='javascript'>alert('No se completo operacion de grabado')</script>")
            End Try
        Else
            Response.Write("<script language='javascript'>alert('Cuenta vacia o deposito nulo')</script>")

        End If

    End Sub

    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.ServerClick
        cancela()
    End Sub

End Class
