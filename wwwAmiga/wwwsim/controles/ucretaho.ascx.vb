

Partial Class ucretaho
    Inherits ucWBase

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
        Dim ldfecha As Date
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab

        Dim dsc As New DataSet
        Dim dsb As New DataSet
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("187", "1")

        Me.ddltipo.DataTextField = "cdescri"
        Me.ddltipo.DataValueField = "ccodigo"
        Me.ddltipo.DataSource = mListaTabttab
        Me.ddltipo.DataBind()

        clsbancos.ObtenerDatasetporid(dsb, Session("gcCodofi"))
        Me.ddlbanco.DataTextField = "cnombco"
        Me.ddlbanco.DataValueField = "ccodbco"
        Me.ddlbanco.DataSource = dsb.Tables(0)
        Me.ddlbanco.DataBind()
        Me.btnaplicar.EnableViewState = True


        '***********

        mListaTabttab = clstabttab.ObtenerLista("189", "1")

        Me.ddltipaho.DataTextField = "cdescri"
        Me.ddltipaho.DataValueField = "ccodigo"
        Me.ddltipaho.DataSource = mListaTabttab
        Me.ddltipaho.DataBind()
        ldfecha = Session("GDFECSIS")
        Me.txtfecha.Text = ldfecha.ToString
        '        Me.txtfecha.EnableViewState = False
        Me.btnaplicar.EnableViewState = True


    End Sub


    
    Sub cancela()
        Me.txtcodcli.Text = ""
        Me.txtnomcli.Text = ""
        Me.txtcodcta.Text = ""
        Me.txtfecha.Text = ""
        Me.txtsaldo.Text = ""
        Me.txtnrodoc.Text = ""
        Me.txtmonto.Text = ""

    End Sub


    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick
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
        Me.txtdispo.Text = eahomcta.nsaldoaho

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
        Dim lnretiro As Double
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
        Dim lctipo As String
        lccodofi = Session("gccodofi")
        lctipo = Me.ddltipo.SelectedValue
        If lctipo = "01" Then 'es efectivo
            lccodcaja = ""
            lctippag = "E"
        Else
            lccodcaja = lctipo
            lctippag = "N"
        End If


        If Me.txtcodcta.Text.Trim = " " Or Me.txtcodcta.Text.Trim = Nothing Or Me.txtmonto.Text.Trim = " " Or Me.txtmonto.Text.Trim = Nothing Then
            Exit Sub
        End If

        lccodaho = Me.txtcodcta.Text.Trim
        lcnrodoc = Me.txtnrodoc.Text.Trim
        lnretiro = Double.Parse(Me.txtmonto.Text.Trim)
        ldfecha = Date.Parse(Me.txtfecha.Text.Trim)

        Dim cahomcta1 As New cAhomcta
        Dim ahomcta1 As New ahomcta

        Dim cahommov1 As New cAhommov
        Dim ahommov1 As New ahommov
        If lccodaho <> Nothing And lnretiro > 0 Then

            Try
                'busca el saldo de las cuentas 
                ahomcta1.ccodaho = lccodaho
                cahomcta1.ObtenerAhomcta(ahomcta1)
                lnsaldo = ahomcta1.nsaldoaho
                If lnsaldo > lnretiro Then
                    lnnewsal = lnsaldo - lnretiro
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
                    ahommov1.cconcep = "RT"
                    ahommov1.ccodusu = "9999"
                    ahommov1.cnumdoc = lcnrodoc
                    ahommov1.dfecefe = ldfecha
                    ahommov1.dfecomp = ldfecha
                    ahommov1.dfecmod = ldfecha
                    ahommov1.dfecope = ldfecha
                    ahommov1.clinea = "S"
                    ahommov1.npartida = 0
                    ahommov1.interes = 0
                    ahommov1.ctipope = "R"
                    ahommov1.ncompen = 0
                    ahommov1.notromon = 0
                    ahommov1.ccodtra = " "
                    cahommov1.agregar(ahommov1)

                    ' graba en contabilidad
                    'cntamov
                    Dim cclase As New crefunc
                    lcnumpar = cclase.fxStevo(ldfecha)

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
                Else
                    Response.Write("<script language='javascript'>alert('Monto a retirar es menor que saldo disponible')</script>")

                End If

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


