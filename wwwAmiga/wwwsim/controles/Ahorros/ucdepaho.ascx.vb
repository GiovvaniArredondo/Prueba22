Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Drawing.Printing
Imports System.IO


Partial Class ucdepaho
    Inherits ucWBase
    
#Region "Privadas"
    Private dataset_lineas As New DataSet
    Private clsConvert As New SIM.BL.ConversionLetras
    Private control1 As Integer = 0
    Private codigoJs As String
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        'txtmonto.Attributes.Add("onChange", "return Calculatotal()")

        If Not IsPostBack Then
            CargarCombos()

        End If
    End Sub

    Public Sub CargarDatosPorCuenta(ByVal cuenta As String)
        Me.txtcodcta.Text = cuenta
        init2()
        Me.btnaplicar_Click(Me, New System.EventArgs)

    End Sub



    Public Sub CargarCombos()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi
        Dim clspromo As New SIM.BL.cPromociones

        btnprogra.Visible = False
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


        Dim mlistapromociones As New listapromociones


        mlistapromociones = clspromo.ObtenerLista()

        ddlpromociones.DataTextField = "nombre"
        ddlpromociones.DataValueField = "codigo"
        ddlpromociones.DataSource = mlistapromociones
        ddlpromociones.DataBind()


        'Evalua si usuario es cajero
        Dim lverifica As Boolean
        lverifica = clstabttab.VerificaUsuarioCajero(Session("gccodusu"))
        If lverifica = True Then
            'Obtiene el codigo del usuario en cajeros
            Dim lccodigo As String
            lccodigo = clstabttab.ObtieneCodigoCajero(Session("gccodusu"))
            ddlcajero.SelectedValue = lccodigo
            Me.Button1.Enabled = True
        Else
            Me.Button1.Enabled = False
        End If

        '------------------------------------------------

        'mListaTabttab = clstabttab.ObtenerLista("186", "1")

        'Me.ddltipaho.DataTextField = "cdescri"
        'Me.ddltipaho.DataValueField = "ccodigo"
        'Me.ddltipaho.DataSource = mListaTabttab
        'Me.ddltipaho.DataBind()

        clsbancos.ObtenerDatasetporid(dsb, Session("gcCodofi"))
        Me.ddlbancos.DataTextField = "cnombco"
        Me.ddlbancos.DataValueField = "ccodbco"
        Me.ddlbancos.DataSource = dsb.Tables(0)
        Me.ddlbancos.DataBind()

        Me.ddloficina.DataTextField = "cnomofi"
        Me.ddloficina.DataValueField = "ccodofi"
        Me.ddloficina.DataSource = mlistaoficina
        Me.ddloficina.DataBind()
        Me.ddloficina.SelectedValue = Session("gccodofi")

        ldfecha = Session("GDFECSIS")
        Me.txtfecha.Text = ldfecha.ToString

        '    Me.txtfecha.EnableViewState = False
        Me.btnaplicar.EnableViewState = True
        Me.ddlbancos.Enabled = False
        Me.btnimprimir.Enabled = False
        Me.Button1.Enabled = False
        Me.btnaplicar.Enabled = True
        Me.btncancela.Enabled = True
        btnlibreta.Enabled = False
        inicializa()
    End Sub
    Sub init2()
        Me.txtnrodoc.Text = ""
        Me.txtmonto.Text = 0
        Me.txtcheque.Text = 0
        Me.txtotros.Text = 0
        Me.txttotal.Text = 0
        Me.txtobserva.Text = ""
    End Sub

    Sub inicializa()
        Me.txtcodcli.Text = ""
        Me.txtnomcli.Text = ""
        Me.txtcodcta.Text = ""
        Me.txtfecha.Text = ""
        Me.txtnrodoc.Text = ""
        Me.txtmonto.Text = 0
        Me.txtcheque.Text = 0
        Me.txtotros.Text = 0
        Me.txttotal.Text = 0
        Me.txtobserva.Text = ""
    End Sub
    Sub cancela()
        Me.txtcodcli.Text = ""
        Me.txtnomcli.Text = ""
        Me.txtcodcta.Text = ""
        Me.txtfecha.Text = ""
        Me.txtnrodoc.Text = ""
        Me.txtmonto.Text = 0
        Me.txtcheque.Text = 0
        Me.txtotros.Text = 0
        Me.txttotal.Text = 0
        Me.txtobserva.Text = ""
        Me.btnaplicar.Enabled = True
        Me.Button1.Enabled = False
        Me.btnimprimir.Enabled = False
        Me.btncancela.Enabled = True
    End Sub
    Private Sub Deshabilitado()
        ddlpromociones.Enabled = False
        txtnrodoc.Enabled = False
        txtmonto.Enabled = False
        txtcheque.Enabled = False
        txtotros.Enabled = False
        txtfecha.Enabled = False
        txtnotas.Enabled = False
        txtcolector.Enabled = False
        txtobserva.Enabled = False
        txtnroche.Enabled = False
    End Sub
    Private Sub ParaImprimir()
        Me.btnaplicar.Enabled = True
        Me.btncancela.Enabled = True
        Button1.Enabled = False
        btnimprimir.Enabled = True
        If RadioButton1.Checked = True Then
            btnlibreta.Enabled = True
        Else
            btnlibreta.Enabled = False

        End If

    End Sub
    Private Sub Habilitado()
        ddlpromociones.Enabled = True
        txtnrodoc.Enabled = True
        txtmonto.Enabled = True
        txtcheque.Enabled = True
        txtotros.Enabled = True
        txtfecha.Enabled = True
        txtnotas.Enabled = True
        txtcolector.Enabled = True
        txtobserva.Enabled = True
        txtnroche.Enabled = True
        Me.btnaplicar.Enabled = False
        Me.Button1.Enabled = True
        Me.btnimprimir.Enabled = False
        Me.btncancela.Enabled = True
        btnlibreta.Enabled = False

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



    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If escondido_TextBox.Text <> 0 Then
            Exit Sub
        End If

        escondido_TextBox.Text = 100

        control1 = control1 + 1
        If control1 <> 1 Then
            Exit Sub
        End If
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
        Dim lnefectivo As Double
        Dim lccodofi As String
        Dim lncompen As Integer = 0


        lccodofi = Session("gccodofi")

        If Me.txtcodcta.Text.Trim = " " Or Me.txtcodcta.Text.Trim = Nothing Or Me.txtmonto.Text.Trim = " " Or Me.txtmonto.Text.Trim = Nothing Then
            Exit Sub
        End If


        'Valida cheque en blanco
        If Double.Parse(txtcheque.Text) > 0 Then
            If txtnroche.Text.Trim = "" Then
                '                Response.Write("<script language='javascript'>alert('Cheque en Blanco')</script>")
                codigoJs = "<script language='javascript'>alert('Cheque en Blanco, " & _
                           "Aviso SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                Exit Sub
            End If
            lncompen = 1
        Else
            lncompen = 0
        End If

        If txtmonto.Text.Trim = "" Then
            txtmonto.Text = 0
        End If
        If txtcheque.Text.Trim = "" Then
            txtcheque.Text = 0
        End If
        If txtotros.Text.Trim = "" Then
            txtotros.Text = 0
        End If


        txttotal.Text = Math.Round(Double.Parse(txtmonto.Text) + Double.Parse(txtcheque.Text) + Double.Parse(txtotros.Text), 2)

        Dim lccodcaj As String
        lccodcaj = Me.ddlcajero.SelectedValue.Trim
        'Obtiene si es caja o cajero contable
        Dim etabttab As New cTabttab
        'lctippag = etabttab.ObtieneTipoCajero(Me.ddlcajero.SelectedValue.Trim)
        lctippag = "E"

        'If lctippag.Trim = "" Then 'usuario no es cajero
        '    'Response.Write("<script language='javascript'>alert('Usuario no tiene Autorización para esta opción, Ingrese con otro Usuario ')</script>")
        '    codigoJs = "<script language='javascript'>alert('Usuario no tiene Autorización para esta opción, Ingrese con otro Usuario, " & _
        '                   "Advertencia SIM.NET ')</script>"

        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
        '    Exit Sub
        'End If
        'If Me.efectivo.Checked = True Then
        '    lccodcaja = Me.ddlcajero.SelectedValue
        '    lccodcaja = ""
        '    lctippag = "E"
        'Else
        '    lccodcaja = Me.ddlbancos.SelectedValue
        '    lctippag = "N"
        'End If

        lccodaho = Me.txtcodcta.Text.Trim
        lcnrodoc = Me.txtnrodoc.Text.Trim
        lnefectivo = Double.Parse(Me.txtmonto.Text.Trim)
        ldfecha = Date.Parse(Me.txtfecha.Text.Trim)

        Dim lncheque As Double = Double.Parse(txtcheque.Text)
        Dim lnotros As Double = Double.Parse(txtotros.Text)


        Dim cahomcta1 As New cAhomcta
        Dim ahomcta1 As New ahomcta

        Dim cahommov1 As New cAhommov
        Dim ahommov1 As New ahommov



        If (lccodaho <> Nothing And lccodaho.Trim <> "") And (lnefectivo > 0 Or lncheque > 0 Or lnotros > 0) Then

            Try
                'busca el saldo de las cuentas 


                Dim lntotal As Double = 0
                Dim val_chq As Double = 0
                Dim lndeposito1 As Double = 0

                lndeposito = lnefectivo + lncheque + lnotros
                lndeposito1 = lnefectivo + lnotros

                If lncompen = 1 Then
                    val_chq = lncheque
                End If

                'Obtiene numero de linea
                Dim lnlinea As Integer = 1
                Dim lncorrel As Integer = 1
                Dim eahommov As New cAhommov
                Dim clsppal As New class1

                lnlinea = eahommov.ObtieneLinea(lccodaho)
                lnlinea = clsppal.fxLinea(lnlinea)
                If lnlinea = 1 Then
                    '                    Response.Write("<script language='javascript'>alert('Libreta ha Terminado, pasar por una nueva')</script>")
                    codigoJs = "<script language='javascript'>alert('Libreta ha Terminado, pasar por una nueva, " & _
                           "Aviso SIM.NET ')</script>"

                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                End If

                lncorrel = eahommov.ObtieneCorrelativo(lccodaho)

                ahomcta1.ccodaho = lccodaho
                cahomcta1.ObtenerAhomcta(ahomcta1)
                lnsaldo = ahomcta1.nsaldoaho
                lnnewsal = lnsaldo + lndeposito1
                lnnumlin = lnlinea

                ahomcta1.ncorrel = lncorrel
                ahomcta1.nsaldoaho = lnnewsal
                ahomcta1.nsaldnind = lnnewsal
                ahomcta1.dfechault = ldfecha
                ahomcta1.dfecult = ldfecha
                ahomcta1.dfecmod = ldfecha
                ahomcta1.dultmov = ldfecha
                ahomcta1.nnum = lnnumlin
                ahomcta1.nmonres = (ahomcta1.nmonres)
                cahomcta1.ActualizarAhomcta(ahomcta1)

                'graba los movimientos
                '-----------------------------------------------------------
                ahommov1.ccodaho = lccodaho
                ahommov1.nnum = lnnumlin
                ahommov1.nmonto = lndeposito1
                ahommov1.nsaldoaho = lnnewsal
                ahommov1.nsaldnind = lnnewsal
                ahommov1.cconcep = "DP"
                ahommov1.ccodusu = Session("gccodusu")
                ahommov1.cnumdoc = lcnrodoc
                ahommov1.dfecefe = ldfecha
                ahommov1.dfecomp = ldfecha
                ahommov1.dfecmod = ldfecha
                ahommov1.dfecope = ldfecha
                ahommov1.clinea = "N"
                ahommov1.npartida = 0
                'ahommov1.interes = Me.ddlpromociones.SelectedValue.Trim
                ahommov1.interes = 0.0
                ahommov1.ctipope = "D"
                ahommov1.ncompen = 0
                ahommov1.notromon = 0
                ahommov1.ccodtra = " "
                ahommov1.ncorrel = lncorrel

                ahommov1.ctipdoc = lctippag
                ahommov1.crazon = "DEPOSITO"
                ahommov1.nlibreta = Integer.Parse(txtlibreta.Text)
                ahommov1.cnrochq = ""
                ahommov1.ctipchq = Me.ddlcajero.SelectedValue.Trim
                ahommov1.ctipaho = Me.ddltipaho.SelectedValue.Trim

                ahommov1.tip = ""
                ahommov1.producto = ""
                ahommov1.ccodtra = ""
                ahommov1.notromon = 0

                cahommov1.agregar(ahommov1)

                '-----------------Cuando es cheque toca realizar movimiento adicional
                If lncompen = 1 And val_chq > 0 Then

                    lnlinea = eahommov.ObtieneLinea(lccodaho)
                    lnlinea = clsppal.fxLinea(lnlinea)
                    If lnlinea = 1 Then
                        '                        Response.Write("<script language='javascript'>alert('Libreta ha Terminado, pasar por una nueva')</script>")
                        codigoJs = "<script language='javascript'>alert('Libreta ha Terminado, pasar por una nueva, " & _
                           "Aviso SIM.NET ')</script>"

                        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                    End If

                    lncorrel = eahommov.ObtieneCorrelativo(lccodaho)

                    ahomcta1.ccodaho = lccodaho
                    cahomcta1.ObtenerAhomcta(ahomcta1)
                    lnsaldo = ahomcta1.nsaldoaho
                    lnnewsal = lnsaldo + val_chq
                    lnnumlin = lnlinea

                    ahomcta1.ncorrel = lncorrel
                    ahomcta1.nsaldoaho = lnnewsal
                    ahomcta1.nsaldnind = lnnewsal
                    ahomcta1.dfechault = ldfecha
                    ahomcta1.dfecult = ldfecha
                    ahomcta1.dfecmod = ldfecha
                    ahomcta1.dultmov = ldfecha
                    ahomcta1.nnum = lnnumlin
                    ahomcta1.nmonres = (ahomcta1.nmonres + val_chq)
                    cahomcta1.ActualizarAhomcta(ahomcta1)

                    'graba los movimientos
                    '-----------------------------------------------------------
                    ahommov1.ccodaho = lccodaho
                    ahommov1.nnum = lnnumlin
                    ahommov1.nmonto = val_chq
                    ahommov1.nsaldoaho = lnnewsal
                    ahommov1.nsaldnind = lnnewsal
                    ahommov1.cconcep = "DP"
                    ahommov1.ccodusu = Session("gccodusu")
                    ahommov1.cnumdoc = lcnrodoc
                    ahommov1.dfecefe = ldfecha
                    ahommov1.dfecomp = ldfecha
                    ahommov1.dfecmod = ldfecha
                    ahommov1.dfecope = ldfecha
                    ahommov1.clinea = "N"
                    ahommov1.npartida = 0
                    ahommov1.interes = Me.ddlpromociones.SelectedValue.Trim
                    ahommov1.ctipope = "D"
                    ahommov1.ncompen = lncompen
                    ahommov1.notromon = 0
                    ahommov1.ccodtra = " "
                    ahommov1.ncorrel = lncorrel

                    ahommov1.ctipdoc = lctippag
                    ahommov1.crazon = "DEPOSITO"
                    ahommov1.nlibreta = Integer.Parse(txtlibreta.Text)
                    ahommov1.cnrochq = txtnroche.Text.Trim
                    ahommov1.ctipchq = Me.ddlcajero.SelectedValue.Trim
                    ahommov1.ctipaho = Me.ddltipaho.SelectedValue.Trim

                    ahommov1.tip = ""
                    ahommov1.producto = ""
                    ahommov1.ccodtra = ""
                    ahommov1.notromon = 0

                    cahommov1.agregar(ahommov1)

                End If

                '--------------------------------------------------------------------

                ' graba en contabilidad
                'cntamov
                Dim cclase As New crefunc
                lcnumpar = cclase.fxStevo(ldfecha)

                Dim entidadcntamov As New SIM.EL.cntamov
                Dim ecntamov As New SIM.BL.cCntamov
                entidadcntamov.cnumcom = lcnumpar

                Dim lcconcep As String
                Dim eahomtrs As New cAhomtrs
                lcconcep = Mid(lccodaho, 7, 2)

                Dim lctipoaho As String = ""
                lctipoaho = etabttab.Describe(lcconcep, "186")

                'diario
                Dim entidaddiario As New SIM.EL.diario
                Dim ediario As New SIM.BL.cDiario
                entidaddiario.cnumcom = lcnumpar

                'diario
                entidaddiario.cnumcom = lcnumpar
                entidaddiario.cglosa = "Deposito de ahorros " & lctipoaho.Trim & " " & lndeposito.ToString & " DOLARES " & Me.txtnomcli.Text.Trim & " recibo No. " & lcnrodoc
                entidaddiario.cnumdoc = lcnrodoc
                entidaddiario.dfeccnt = ldfecha
                entidaddiario.cestado = " "
                entidaddiario.ccodofi = lccodofi
                entidaddiario.ffondos = "01"
                entidaddiario.dfecdoc = ldfecha
                entidaddiario.dfecmod = ldfecha
                ediario.agregarDiario(entidaddiario)

                'cntamov

                lcctactb = etabttab.ObtieneContabledelCajero(ddlcajero.SelectedValue)

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
                entidadcntamov.ffondos = "01"
                entidadcntamov.cclase = Left(lcctactb, 1)
                entidadcntamov.cpoliza = "DP"
                entidadcntamov.corden = Me.txtcolector.Text.Trim
                ecntamov.agregarCntamov(entidadcntamov)

                'cuenta por contra
                lcctactb = eahomtrs.ObtenerCuenta(lcconcep, 1)

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
                entidadcntamov.ffondos = "01"
                entidadcntamov.cclase = Left(lcctactb, 1)
                entidadcntamov.cpoliza = "DP"
                entidadcntamov.corden = Me.txtcolector.Text.Trim
                ecntamov.agregarCntamov(entidadcntamov)

                ParaImprimir()



                '----------------------------------

                Dim lndepositos As Decimal = 0
                txtdepositos.Text = ObtenerDepositos()

                lndepositos = Double.Parse(txtdepositos.Text)

                lndepositos = lndepositos + Double.Parse(txttotal.Text)

                If (Double.Parse(txttotal.Text) >= 5000.0 And Double.Parse(txttotal.Text) <= 57000) Or _
                (lndepositos > 57000) Then
                    'Session("fuente") = "Los Depositos Realizados a 30 días Superan el Limite de LAVADO " + Chr(13) + "DE DINERO Permitido, Esta Advertencia Debe de ser Trasladada  " + Chr(13) + "al Jefe de Mercadeo ,para que LLene el Formulario Correspondiante y sea Enviado a LA FISCALIA DE LA REPUBLICA"
                    Session("fuente") = "Los Depositos Realizados a 30 días Superan el Limite de LAVADO " + Chr(13) + "DE DINERO Permitido, Esta Advertencia Debe de ser Trasladada  " + Chr(13) + "al Oficial de Cumplimiento ,para que LLene el Formulario Correspondiante y sea Enviado a LA FISCALIA DE LA REPUBLICA"
                    'Response.Write("<script>window.open('Mensaje.aspx','cal', 'location=1, toolbar = no, status=1,width=550,height=230')</script>")
                    codigoJs = "<script>window.open('Mensaje.aspx','cal', 'location=1, toolbar = no, status=1,width=550,height=230')</script>"

                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)

                    btnprogra.Visible = True
                Else
                    btnprogra.Visible = False
                    '          Response.Write("<script language='javascript'>alert('ok, Imprima Recibo')</script>")
                    codigoJs = "<script language='javascript'>alert('ok, Imprima Recibo, " & _
                           "Aviso SIM.NET ')</script>"

                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)

                End If
        '----------------------------------

        control1 = 0

        ' cancela()



            Catch ex As Exception
                '            Response.Write("<script language='javascript'>alert('No se completo operacion de grabado')</script>")
                codigoJs = "<script language='javascript'>alert('No se completo operacion de grabado, " & _
                           "Advertencia SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
        End Try
        Else
            'Response.Write("<script language='javascript'>alert('Cuenta vacia o deposito nulo')</script>")
            codigoJs = "<script language='javascript'>alert('Cuenta vacia o deposito nulo, " & _
                           "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)

        End If


        btnlibreta.Focus()

        '    Me.Deshabilitado()
    End Sub

    Protected Sub btncancela_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancela.Click
        cancela()
    End Sub

    Protected Sub btnaplicar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaplicar.Click
        escondido_TextBox.Text = 0
        btnprogra.Visible = False
        Dim lccodaho As String
        Dim mclimide As New cClimide
        Dim eclimide As New climide
        Dim mahomcta As New cAhomcta
        Dim eahomcta As New ahomcta
        Dim lccodcli As String
        Dim ldfecha As Date
        lccodaho = Me.txtcodcta.Text.Trim
        If lccodaho.Trim = "" Or lccodaho.Trim.Length <> 14 Then
            Exit Sub
        End If
        eahomcta.ccodaho = lccodaho
        mahomcta.ObtenerAhomcta(eahomcta)
        Me.txtcodcli.Text = eahomcta.cnudotr
        Me.txtsaldo.Text = eahomcta.nsaldoaho
        Me.txtlibreta.Text = eahomcta.nlibreta


        'Verifica esta de la cuenta para entrar
        If eahomcta.cestado <> "A" Then
            codigoJs = "<script language='javascript'>alert('La cuenta no se encuentra activa, " & _
                          "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If


        eclimide.ccodcli = Me.txtcodcli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        Me.txtnomcli.Text = eclimide.cnomcli

        ldfecha = Session("GDFECSIS")
        Me.txtfecha.Text = ldfecha.ToString

        ddltipaho.SelectedValue = txtcodcta.Text.Substring(6, 2)

        'Obtiene Cuenta de Aportaciones
        Dim lnsalapo As Double = 0
        lnsalapo = mahomcta.Aportaciones(txtcodcli.Text.Trim)
        txttotaporta.Text = lnsalapo
        Dim lnmoraaporta As Decimal = 0
        Dim clase As New class1
        'lnmoraaporta = clase.Moraaportaciones(txtcodcli.Text.Trim, Session("gdfecsis"))

        txtmoraaporta.Text = lnmoraaporta
        Me.Habilitado()

    End Sub

    Protected Sub btnimprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        ImpresionRecibo()
    End Sub

    Private Sub ImpresionRecibo()
        If txtcodcta.Text.Trim <> "" Then
            Dim crRpt As New ReportDocument
            Dim rptStream As New System.IO.MemoryStream
            Dim reportes As String = "crDeposito.pdf"
            crRpt.Load(Server.MapPath("reportes") + "\crDeposito.rpt", OpenReportMethod.OpenReportByDefault)

            Dim dtrecibo As New DataTable
            Dim eahommov As New cAhommov
            dtrecibo = eahommov.ObtenerMovimientoAhorro(Me.txtcodcta.Text.Trim, "DP", Date.Parse(txtfecha.Text), txtnrodoc.Text.Trim)
            'Obtiene el movimiento que se ha generado

            Dim lcnumdoc As String = ""
            Dim lccodaho As String = ""
            Dim ldfecha As Date = Today

            Dim lnefectivo As Double = 0
            Dim lncheque As Double = 0
            Dim lnotros As Double = 0
            Dim lntotal As Double = 0
            Dim lcletras As String = ""
            Dim lcobserva As String = ""
            Dim lcnombre As String = ""
            Dim etabtusu As New cTabtusu
            Dim lcnomusu As String = ""
            lcnomusu = etabtusu.usuario(Session("gcCodusu"))


            If dtrecibo.Rows.Count = 0 Then
                Exit Sub
            Else
                lcnumdoc = dtrecibo.Rows(0)("cnumdoc")
                lccodaho = txtcodcta.Text.Trim
                ldfecha = Date.Parse(txtfecha.Text)
                lnefectivo = Double.Parse(txtmonto.Text)
                lncheque = Double.Parse(txtcheque.Text)
                lnotros = Double.Parse(txtotros.Text)
                lntotal = lnefectivo + lncheque + lnotros
                lcobserva = txtobserva.Text.Trim
                lcnombre = txtnomcli.Text.Trim

                Dim lcmonlet As String = " "
                Dim lndecimal As Integer = 0

                lcletras = clsConvert.ConversionEnteros(lntotal)
                lndecimal = clsConvert.ExtraeDecimales(lntotal)
                lcletras = lcletras.Trim & " " & lndecimal.ToString & "/100" & " DOLARES"

            End If
            Dim lctipoaho As String = ""
            Dim etabttab As New cTabttab
            lctipoaho = etabttab.Describe(Mid(lccodaho, 7, 2), "186").Trim


            crRpt.SetDataSource(dtrecibo)
            crRpt.Refresh()


            crRpt.SetParameterValue("cnombre", lcnombre)
            crRpt.SetParameterValue("cnumdoc", lcnumdoc)
            crRpt.SetParameterValue("ccodaho", lccodaho)
            crRpt.SetParameterValue("dfecha", ldfecha)
            crRpt.SetParameterValue("nefectivo", lnefectivo)
            crRpt.SetParameterValue("ncheque", lncheque)
            crRpt.SetParameterValue("notros", lnotros)
            crRpt.SetParameterValue("ntotal", lntotal)
            crRpt.SetParameterValue("cobserva", lcobserva)
            crRpt.SetParameterValue("cletras", lcletras)
            crRpt.SetParameterValue("ccodusu", Session("gccodusu"))
            crRpt.SetParameterValue("tipo_cuenta", lctipoaho)
            crRpt.SetParameterValue("socio", txtcodcli.Text.Trim)
            crRpt.SetParameterValue("cnomusu", lcnomusu)
            'crRpt.PrintToPrinter(1, False, 0, 0)

            rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
            Response.Clear()
            Response.Buffer = True


            ' Establece el tipo de documento
            Response.ContentType = "application/pdf"
            Response.BinaryWrite(rptStream.ToArray())
            Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
            Response.Flush()
            Response.Close()

            btnlibreta.Focus()

        End If
    End Sub

    Private Function ImpresionReciboDirect() As String
        If txtcodcta.Text.Trim <> "" Then
            Dim crRpt As New ReportDocument
            Dim rptStream As New System.IO.MemoryStream
            Dim reportes As String = "crDeposito.pdf"
            crRpt.Load(Server.MapPath("reportes") + "\crDeposito.rpt", OpenReportMethod.OpenReportByDefault)

            Dim dtrecibo As New DataTable
            Dim eahommov As New cAhommov
            dtrecibo = eahommov.ObtenerMovimientoAhorro(Me.txtcodcta.Text.Trim, "DP", Date.Parse(txtfecha.Text), txtnrodoc.Text.Trim)
            'Obtiene el movimiento que se ha generado

            Dim lcnumdoc As String = ""
            Dim lccodaho As String = ""
            Dim ldfecha As Date = Today

            Dim lnefectivo As Double = 0
            Dim lncheque As Double = 0
            Dim lnotros As Double = 0
            Dim lntotal As Double = 0
            Dim lcletras As String = ""
            Dim lcobserva As String = ""
            Dim lcnombre As String = ""


            If dtrecibo.Rows.Count = 0 Then
                Exit Function
            Else
                lcnumdoc = dtrecibo.Rows(0)("cnumdoc")
                lccodaho = txtcodcta.Text.Trim
                ldfecha = Date.Parse(txtfecha.Text)
                lnefectivo = Double.Parse(txtmonto.Text)
                lncheque = Double.Parse(txtcheque.Text)
                lnotros = Double.Parse(txtotros.Text)
                lntotal = lnefectivo + lncheque + lnotros
                lcobserva = txtobserva.Text.Trim
                lcnombre = txtnomcli.Text.Trim

                Dim lcmonlet As String = " "
                Dim lndecimal As Integer = 0

                lcletras = clsConvert.ConversionEnteros(lntotal)
                lndecimal = clsConvert.ExtraeDecimales(lntotal)

                If lndecimal >= 10 Then
                    lcletras = lcletras.Trim & " " & lndecimal.ToString & "/100 DOLARES DE LOS ESTADOS UNIDOS DE AMERICA"
                Else
                    lcletras = lcletras.Trim & " 0" & lndecimal.ToString & "/100 DOLARES DE LOS ESTADOS UNIDOS DE AMERICA"
                End If

                'lcletras = lcletras.Trim & " " & lndecimal.ToString & "/100" & " DOLARES"

            End If
            Dim lctipoaho As String = ""

            Dim etabtusu As New cTabtusu
            Dim lcnomusu As String = ""
            lcnomusu = etabtusu.usuario(Session("gcCodusu"))


            Dim etabttab As New cTabttab
            lctipoaho = etabttab.Describe(Mid(lccodaho, 7, 2), "186").Trim


            crRpt.SetDataSource(dtrecibo)
            crRpt.Refresh()


            crRpt.SetParameterValue("cnombre", lcnombre)
            crRpt.SetParameterValue("cnumdoc", lcnumdoc)
            crRpt.SetParameterValue("ccodaho", lccodaho)
            crRpt.SetParameterValue("dfecha", ldfecha)
            crRpt.SetParameterValue("nefectivo", lnefectivo)
            crRpt.SetParameterValue("ncheque", lncheque)
            crRpt.SetParameterValue("notros", lnotros)
            crRpt.SetParameterValue("ntotal", lntotal)
            crRpt.SetParameterValue("cobserva", lcobserva)
            crRpt.SetParameterValue("cletras", lcletras)
            crRpt.SetParameterValue("ccodusu", Session("gccodusu"))
            crRpt.SetParameterValue("tipo_cuenta", lctipoaho)
            crRpt.SetParameterValue("socio", txtcodcli.Text.Trim)
            crRpt.SetParameterValue("cnomusu", lcnomusu)

            'crRpt.PrintToPrinter(1, False, 0, 0)

            'rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
            'Response.Clear()
            'Response.Buffer = True


            ' Establece el tipo de documento
            'Response.ContentType = "application/pdf"
            'Response.BinaryWrite(rptStream.ToArray())
            'Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
            'Response.Flush()
            'Response.Close()

            Dim reporte As String = ""
            reporte = GuardarWord(crRpt)

            btnlibreta.Focus()
            Return reporte
        End If

    End Function

    Public Function GuardarWord(ByRef crrpt As ReportDocument) As String
        ' Crear el Directorio Temporal de los Archivos si es que no existe
        Dim mUsuarios As New cusuarios
        Dim ofi As String = ""
        Dim user As String = ""
        Dim rep As String = ""
        Dim exis As Boolean = True
        Dim complemento As String = ""
        Dim dir_completa As String = ""

        Try
            user = Session("gccodusu").ToString.Trim.ToUpper
            ofi = mUsuarios.Oficina(user).Trim

            ' Crear un nombre aleatorio y buscar si ya existe, si existe crear otro que no exista
            Do While exis = True
                rep = Guid.NewGuid.ToString("D")
                complemento = "\" + ofi + "\" + user + "\" + rep + ".doc"

                If File.Exists(Server.MapPath("Impresiones") + complemento) Then
                    exis = True
                Else
                    Directory.CreateDirectory(Server.MapPath("Impresiones") + "\" + ofi + "\" + user)
                    exis = False
                End If
            Loop

            dir_completa = Server.MapPath("Impresiones") + complemento
            crrpt.ExportToDisk(ExportFormatType.WordForWindows, dir_completa)
        Catch ex As Exception
            rep = "*"
        End Try

        Return rep
    End Function

    Private Sub imprimir_lineas(ByVal cuenta As String)
        Dim miclase As New clase_jaime
        Dim miclase1 As New clase_funciones
        Dim salto_pagina As Boolean = False
        Dim dt As DataTable
        Dim fila As DataRow


        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select As String = ""
        con.ConnectionString = stringconnection

        con.Open()

        salto_pagina = miclase1.habra_cambio_pagina(con, cuenta)

        If salto_pagina = True Then

            'Session("fuente") = "Habrá cambio de  libreta " + Chr(13) + "Se imprimiran primero las lineas antiguas y luego las nuevas en la libreta nueva" + Chr(13) + "deberá hacer clic al boton de impresion"
            'Response.Write("<script>window.open('Mensaje.aspx','cal', 'location=1, toolbar = no, status=1,width=550,height=130')</script>")

        End If

        dataset_lineas.Clear()
        dataset_lineas = miclase1.devolver_dataset_lineas_libreta_imprimir(con, cuenta)

        dt = dataset_lineas.Tables(0)

        con.Close()



        ImprimeLineas(dataset_lineas)
    End Sub

    Private Sub ImprimeLineas(ByVal ds As DataSet)
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\libreta.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()

        Dim reportes As String
        reportes = "libreta.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()
    End Sub

    Private Function imprimir_lineasDirect(ByVal cuenta As String) As String
        Dim miclase As New clase_jaime
        Dim miclase1 As New clase_funciones
        Dim salto_pagina As Boolean = False
        Dim dt As DataTable
        Dim fila As DataRow


        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select As String = ""
        con.ConnectionString = stringconnection

        con.Open()

        salto_pagina = miclase1.habra_cambio_pagina(con, cuenta)

        If salto_pagina = True Then

            'Session("fuente") = "Habrá cambio de  libreta " + Chr(13) + "Se imprimiran primero las lineas antiguas y luego las nuevas en la libreta nueva" + Chr(13) + "deberá hacer clic al boton de impresion"
            'Response.Write("<script>window.open('Mensaje.aspx','cal', 'location=1, toolbar = no, status=1,width=550,height=130')</script>")

        End If

        dataset_lineas.Clear()
        dataset_lineas = miclase1.devolver_dataset_lineas_libreta_imprimir(con, cuenta)

        dt = dataset_lineas.Tables(0)

        con.Close()



        Return ImprimeLineasDirect(dataset_lineas)
    End Function

    Private Function ImprimeLineasDirect(ByVal ds As DataSet) As String
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\libreta.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return "*"
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()

        Dim nomrep As String = "*"
        nomrep = GuardarWord(crRpt)
        Return nomrep

        'Dim reportes As String
        'reportes = "libreta.pdf"

        'rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        'Response.Clear()
        'Response.Buffer = True
        ' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()
    End Function



    Private Sub print_lineas(ByVal sender As Object, _
                               ByVal e As PrintPageEventArgs)


        Dim miclase1 As New clase_funciones
        Dim prtFont As New Font("Arial", 9, FontStyle.Regular)

        e.HasMorePages = False

        Dim lineHeight As Single
        Dim yPos As Single = 30
        Dim leftMargin As Single = 1
        Dim printFont As System.Drawing.Font
        ' Asignar el tipo de letra
        printFont = prtFont
        lineHeight = printFont.GetHeight(e.Graphics)

        Dim dep As Decimal, ret As Decimal, sal As Decimal
        Dim fila As DataRow
        Dim dfecope As Date, nmonto As Decimal, ctipope As String, nsaldoaho As Decimal
        Dim clinea As String, nnum As Integer, primera As Boolean = True

        Dim veces As Integer = 0

        For Each fila In dataset_lineas.Tables(0).Rows
            nnum = fila("nnum")
            dfecope = fila("dfecope")
            nmonto = fila("nmonto")
            ctipope = fila("ctipope")
            nsaldoaho = fila("nsaldoaho")
            clinea = fila("clinea")

            'este es el margen superior
            If nnum = 1 And clinea = "N" Then
                For m = 1 To 9 'este es el margen superior
                    yPos += lineHeight
                    e.Graphics.DrawString("    ", printFont, Brushes.Black, leftMargin, yPos)
                Next
            End If

            'ajustar la primera impresion
            If nnum > 1 And clinea = "N" And primera = True Then
                For m = 1 To 9 'este es el margen superior
                    yPos += lineHeight
                    e.Graphics.DrawString("    ", printFont, Brushes.Black, leftMargin, yPos)
                Next

                For m = 1 To nnum - 1 'ajustar la primera impresion
                    yPos += lineHeight
                    e.Graphics.DrawString("    ", printFont, Brushes.Black, leftMargin, yPos)
                Next
                primera = False
            End If

            If clinea = "N" Then
                sal = nsaldoaho
                If ctipope = "D" Then
                    dep = nmonto
                    ret = 0.0
                Else
                    dep = 0.0
                    ret = nmonto
                End If
                yPos += lineHeight
                e.Graphics.DrawString("    " & Left(dfecope.ToString, 10), printFont, Brushes.Black, 15, yPos)
                e.Graphics.DrawString("    " & miclase1.mascara_numerica(ret), printFont, Brushes.Black, 180, yPos)
                e.Graphics.DrawString("    " & miclase1.mascara_numerica(dep), printFont, Brushes.Black, 320, yPos)
                e.Graphics.DrawString("    " & miclase1.mascara_numerica(sal), printFont, Brushes.Black, 450, yPos)
                veces = veces + 1
            End If

            If nnum = 65 And clinea = "N" Then
                fila("clinea") = "S"
                e.HasMorePages = True

                Exit Sub
            End If

            fila("clinea") = "S"

        Next

        If veces = 0 Then
            MsgBox("No Hay Ninguna Transaccion Pendiente que Imprimir", MsgBoxStyle.Information, "Administrador SIM.NET")
        End If

    End Sub

    Protected Sub btnlibreta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlibreta.Click
        If txtcodcta.Text.Trim <> "" Then
            Dim lccodaho As String = ""
            lccodaho = txtcodcta.Text.Trim
            imprimir_lineas(lccodaho)
        End If

    End Sub

    Protected Sub btnprogra_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnprogra.Click
        lavado()
    End Sub
    Private Sub lavado()
        '        Try

        Dim origen As String
        Dim Destino As String
        Dim lcnomcli As String = ""
        Dim ldnacimi As Date = Session("gdfecsis")
        Dim lcsexo As String = ""
        Dim lcdui As String = ""
        Dim lcteldom As String = ""
        Dim lccelular As String = ""
        Dim lccodpro As String = ""
        Dim lcprofesion As String = ""
        Dim lcestciv As String = ""
        Dim lccivil As String = ""
        Dim lcdirdom As String = ""
        Dim etabtprf As New cTabtprf
        Dim entidadtabtprf As New tabtprf
        Dim eclimide As New cClimide
        Dim entidadclimide As New climide
        Dim etabttab As New cTabttab
        Dim ds As New DataSet


        ds = eclimide.ObtenerDatosClimide(txtnomcli.Text.Trim)

        origen = Session("codigo")
        Destino = Session("fuente")


        entidadclimide.ccodcli = txtcodcli.Text.Trim
        eclimide.ObtenerClimide(entidadclimide)

        lcnomcli = entidadclimide.cnomcli.Trim
        ldnacimi = entidadclimide.dnacimi
        lcsexo = entidadclimide.csexo
        lcdui = entidadclimide.cnudoci
        lcteldom = entidadclimide.cteldom
        lccelular = entidadclimide.cTelFam
        lccodpro = entidadclimide.ccodpro
        lcestciv = entidadclimide.cestciv
        lccivil = etabttab.Describe(lcestciv, "012")
        lcdirdom = entidadclimide.cdirdom

        entidadtabtprf.ccodigo = lccodpro
        etabtprf.ObtenerTabtprf(entidadtabtprf)

        lcprofesion = entidadtabtprf.cdescri


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream


        Try
            'Cargar Definicion del Reporte
            If Double.Parse(txtmonto.Text) >= 5000 And Double.Parse(txtmonto.Text) <= 57000 Then
                crRpt.Load(Server.MapPath("reportes") + "\CrLavado.rpt", OpenReportMethod.OpenReportByDefault)
            Else
                crRpt.Load(Server.MapPath("reportes") + "\CrLavado2.rpt", OpenReportMethod.OpenReportByDefault)
            End If

        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()

        crRpt.SetParameterValue("pcorigen", origen)
        crRpt.SetParameterValue("pcdestino", Destino)

        crRpt.SetParameterValue("id1", "")
        crRpt.SetParameterValue("id2", "")
        crRpt.SetParameterValue("id3", "")
        crRpt.SetParameterValue("id4", "")
        crRpt.SetParameterValue("id5", "")
        crRpt.SetParameterValue("id6", "X")
        crRpt.SetParameterValue("id7", "")

        crRpt.SetParameterValue("nmonto1", 0)
        crRpt.SetParameterValue("nmonto2", 0)
        crRpt.SetParameterValue("nmonto3", 0)
        crRpt.SetParameterValue("nmonto4", 0)
        crRpt.SetParameterValue("nmonto5", 0)
        crRpt.SetParameterValue("nmonto6", Double.Parse(txtmonto.Text))
        crRpt.SetParameterValue("nmonto7", 0)

        crRpt.SetParameterValue("pccodcli", txtcodcli.Text.Trim)
        crRpt.SetParameterValue("pcnomcli", lcnomcli)
        crRpt.SetParameterValue("pdnacimi", ldnacimi)
        crRpt.SetParameterValue("pcsexo", lcsexo)
        crRpt.SetParameterValue("pcdui", lcdui)
        crRpt.SetParameterValue("pcteldom", (lcteldom + " " + lccelular))
        crRpt.SetParameterValue("pcprofesion", lcprofesion)
        crRpt.SetParameterValue("pccivil", lccivil)
        crRpt.SetParameterValue("pcdirdom", lcdirdom)

        Dim reportes As String

        reportes = "Lavado.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()

        '       Catch ex As Exception

        '      End Try

    End Sub
    Private Function ObtenerDepositos() As Decimal
        Dim clsppal As New class1
        Dim ldfecini As Date
        Dim lccodaho As String = ""
        Dim eahomcta As New cAhomcta
        Dim ds As New DataSet
        Dim lndepositos As Decimal = 0
        ldfecini = DateAdd(DateInterval.Day, -30, Session("gdfecsis"))
        'Obtiene codigo de cuenta de ahorro
        lndepositos = clsppal.ObtenerSumadeDepositos(txtcodcli.Text.Trim, ldfecini)


        Return lndepositos
    End Function


    Protected Sub btnreimp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnreimp.Click
        Try
            ImpresionRecibo()
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub btn_rec_direct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_rec_direct.Click
        Dim mUsuarios As New cusuarios
        Dim user As String = ""
        Dim ofi As String = ""
        Dim rep As String = ""

        user = Session("gccodusu").ToString()
        ofi = mUsuarios.Oficina(user).Trim()
        rep = "*"

        rep = ImpresionReciboDirect()

        If rep = "*" Then
            Return
        Else
            'Response.Write("<script>window.open('Print.aspx?user=" + Session("gccodusu").ToString() + "&ofi=" + ofi + "&rep=" + rep + "','cal', 'location=1, toolbar = no, status=1,width=550,height=230')</script>")
            codigoJs = "<script language='javascript'>window.open('Print.aspx?user=" + Session("gccodusu").ToString() + "&ofi=" + ofi + "&rep=" + rep + "','cal', 'location=1, toolbar = no, status=1,width=550,height=230')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If
    End Sub

    Protected Sub btnlibreta0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlibreta0.Click
        Dim mUsuarios As New cusuarios
        Dim user As String = ""
        Dim ofi As String = ""
        Dim rep As String = ""

        user = Session("gccodusu").ToString()
        ofi = mUsuarios.Oficina(user).Trim()
        rep = "*"

        If txtcodcta.Text.Trim <> "" Then
            Dim lccodaho As String = ""
            lccodaho = txtcodcta.Text.Trim
            rep = imprimir_lineasDirect(lccodaho)
        End If

        If rep = "*" Then
            Return
        Else
            codigoJs = "<script language='javascript'>window.open('Print.aspx?user=" + Session("gccodusu").ToString() + "&ofi=" + ofi + "&rep=" + rep + "','cal', 'location=1, toolbar = no, status=1,width=550,height=230')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If
    End Sub
End Class


