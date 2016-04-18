Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO

Partial Class ucgestion
    Inherits ucWBase


#Region "Privadas"
    Private clsppal As New class1
    Private eahomcta As New cAhomcta
    ' Dim clsaditivos As New cClsAditivos
    Private ds As New DataSet
    Private ecredppg As New cCredppg
    Private _ClienteSeleccionado As String
    Private codigoJs As String = ""

#End Region
    

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

    Private _URLCodigo As String
    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

    Public Event SeleccionarCuenta(ByVal codcta As String)

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim fecha As Date
            fecha = Session("gdfecsis")
            txtdfec1.Text = Session("gdfecsis")
            txtdfec2.Text = Session("gdfecsis")
            Me.TXTFECPRO.Text = fecha.ToShortDateString.ToString
            CargarCombo()
        End If
    End Sub
    Private Sub CargarCombo()
        Dim clsTabtusu As New SIM.BL.cTabtusu
        Dim mListaTabtUsu As New listatabtusu


        mListaTabtUsu = clsTabtusu.ObtenerListaPorID2()

        Me.ddlanalistas.DataTextField = "cNomusu"
        Me.ddlanalistas.DataValueField = "cCodUsu"
        Me.ddlanalistas.DataSource = mListaTabtUsu
        Me.ddlanalistas.DataBind()

        habilitar()
        Inhabilitar()

    End Sub

    Public Sub CargarDatosPorCliente(ByVal codcli As String)
        '        Dim fecha As Date
        '        fecha = Session("gdfecsis")
        '        Me.TXTFECPRO.Text = fecha.ToShortDateString.ToString
    End Sub


    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub
    Private Sub Aplicar()
        Dim codcta As String
        codcta = Me.txtcodcta.Text.Trim

        If codcta = Nothing Then
            Exit Sub
        End If

        Dim lccodcta As String
        Dim gdfecsis As Date
        Dim ecremcre As New cremcre
        Dim mcremcre As New cCremcre
        Dim clsaplica As New payment
        Dim ldfecval As Date
        Dim ok As Integer
        Dim gdfecmor As Date
        Dim lnporsegdeu, lnporsegdan, lnporres, lnportalona As Double
        Dim lnpropseg, lnpropman, lnperbas As Double
        Dim cls1 As New clspagos
        Dim bunacuenta As Boolean
        Dim etabtusu As New tabtusu
        Dim mtabtusu As New cTabtusu
        Dim lccodana As String
        Dim etabtofi As New tabtofi
        Dim mtabtofi As New cTabtofi
        Dim eclimide As New climide
        Dim mclimide As New cClimide
        Dim lcnumcasa As String

        Dim elinea As New cretlin
        Dim clinea As New cCretlin
        Dim lccodciu As String
        Dim lccalif As String = ""
        Dim lccodofi As String

        Dim m1 As New ccreditos
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date

        Dim ldfecvig As Date
        Dim ldfecven As Date
        Dim lctasa As Double
        Dim lcnumcuo As Double
        Dim fila As DataRow
        Dim lnsaldo As Double
        Dim lccodcli As String
        Dim lndesembolso As Double
        Dim lcnrolin As String

        Dim etabtciu As New tabtciu
        Dim mtabtciu As New cTabtciu

        'obtiene monto de la garantias
        Dim lncappag As Double
        Dim ecretlin As New cretlin
        Dim mcretlin As New cCretlin
        Dim lsegdeu, lsegdan, lreserva, ltalona, ladmon As String
        Dim lnsegdeu As Double
        Dim lnsegdan As Double
        Dim lnreserva As Double
        Dim lntalona As Double
        Dim lngasadm As Double
        Dim lndias As Double
        Dim ldultpag As Date
        Dim lnsalcap As Double
        Dim lnmeses As Double
        Dim lccodlin As String

        Dim mclimgar As New cClimgar
        Dim lntotal As Double
        Dim lcprima As Double
        Dim lccosdir As Double
        Dim lccosind As Double
        Dim lcsubcidio As Double

        Dim lnmonpag As Double
        Dim lnprima As Double
        Dim lncosdir As Double
        Dim lncosind As Double
        Dim lnsubcidio As Double

        Dim lnintere As Double
        Dim lnintmor As Double
        Dim lnmorcap As Double
        Dim lncapdes As Double
        Dim lndiasatr As Double
        Dim lntotpag As Double

        Dim lntasint As Double = 0
        Dim lntasmor As Double = 0

        Dim lnsalteo As Double = 0

        Dim lcfondos As String = ""
        Dim lcteldom As String = ""
        Dim lcgarantia As String = ""
        Dim lcestado As String
        Dim lccodsol As String = ""
        Dim lcnomcen As String = ""
        Dim lcnomgru As String = ""
        Dim lcpertenece As String = ""
        Dim lnmonres As Double = 0
        Dim ldultres As Date
        Dim lnpagadu As Integer = 0
        Dim lcconcepto As String = ""
        Dim ldcapcub As Date
        Dim ldintcub As Date
        Dim ldultcap As Date

        Dim lnaportaciones As Double = 0

        gdfecsis = Date.Parse(Me.TXTFECPRO.Text) 'Session("gdfecsis")
        lccodcta = Me.txtcodcta.Text  'viewstate("pccodcta")

        cls1.ccodcta1 = lccodcta
        'como es para una sola cuenta siempre sera 0
        bunacuenta = False

        ldfecha1 = #1/1/1900#
        ldfecha2 = gdfecsis

        'Para Calcular Cuota
        Dim lncuota As Double
        ecremcre.ccodcta = lccodcta
        mcremcre.ObtenerCremcre(ecremcre)

        lnmonres = 0
        ldultres = ecremcre.dfecvig
        lnpagadu = 0
        ldcapcub = ecremcre.dfecvig
        ldintcub = ecremcre.dfecvig



       

        clsppal.gnperbas = Session("gnperbas")
        clsppal.pnComtra = Session("gnComTra")
        If ecremcre.dfecvig >= #7/11/2008# Then
            clsppal.pnSegVm = Session("gnSegVm1")
        Else
            clsppal.pnSegVm = Session("gnSegVm")
        End If

        lncuota = ecremcre.nmoncuo 'clsppal.ValorCuota(lccodcta)

        'Try
        'ds = m1.DETALLE_CARTERA_Y_PAGOS_POR_CUENTA(ldfecha1, ldfecha2, "C", "*", "*", "*", "*", lccodcta)
        ds = m1.Detalle_Kardex(ldfecha1, ldfecha2, "C", "*", "*", "*", "*", lccodcta)

        'Catch ex As Exception
        'Response.Write("<script language='javascript'>alert('error al obtener cartera')</script>")
        'End Try
        lnsaldo = 0
        If ds.Tables(0).Rows.Count = 0 Then
            Return
            'lnsaldo = 0
            ds.Tables(0).Rows(0)("dfecven") = ds.Tables(0).Rows(0)("dfecven1")
        Else
            'lnsaldo = ds.Tables(0).Rows(0)("ncapdes")
            ds.Tables(0).Rows(0)("dfecven") = ds.Tables(0).Rows(0)("dfecven1")
        End If

        ds.Tables(0).Rows(0)("nsaldo") = lnsaldo
        lndesembolso = 0

        Dim lcflag As Integer = 0
        Dim i As Integer = 0

        For Each fila In ds.Tables(0).Rows

            If fila("cdescob") = "C" Then
                lnsaldo = lnsaldo - fila("ncapita")
                fila("nsaldo") = lnsaldo
            Else
                lnsaldo = lnsaldo + fila("ncapita")
                'lndesembolso = lndesembolso + fila("ncapita")
                fila("nsaldo") = lnsaldo 'lndesembolso
                'lnsaldo = lndesembolso
                fila("npago") = 0
                fila("ncapita") = 0
            End If
            If fila("ndiaatr") < 0 Then
                fila("ndiaatr") = 0
            End If
            If lnmonres > 0 And fila("dfecsis") > ldultres And lcflag = 0 Then
                fila("cflag") = "A M P L I A C I O N   D E   C R E D I T O"
                lcflag = 1
            End If


        Next


        Dim lcformapago1 As String = ""
        Dim lcformapago2 As String = ""
        Dim lctipocuota As String = ""
        Dim lnmonapr As Double = 0
        Dim etabttab As New cTabttab
        Dim lcfrecint As String = ""
        'obtiene datos de la prima y otros

        'Try
        ecremcre.ccodcta = lccodcta
        mcremcre.ObtenerCremcre(ecremcre)
        lcnrolin = ecremcre.cnrolin
        clsaplica.pnprima = ecremcre.nprima
        clsaplica.pncosdir = ecremcre.ncosdir
        clsaplica.pncosind = ecremcre.ncosind
        clsaplica.pnsubcidio = ecremcre.nahoprg
        lccodofi = ecremcre.coficina.Trim
        lccodciu = ecremcre.ccodact.Trim
        'IIf(ecremcre.ccalif = Nothing, "", ecremcre.ccalif)
        lccodsol = ecremcre.ccodsol
        lnmonapr = ecremcre.nmonapr
        lcfrecint = ecremcre.cfrecint

        lcformapago1 = IIf(IsDBNull(ecremcre.cfreccap), "", etabttab.Describe(ecremcre.cfreccap, "060"))
        lcformapago2 = IIf(IsDBNull(ecremcre.cfrecint), "", etabttab.Describe(ecremcre.cfrecint, "060"))
        lctipocuota = IIf(ecremcre.cflat = "F", "FLAT", "FIJA NIVELADA")

        Dim lccondic As String = ""
        Dim lcstatus As String = ""

        lccondic = IIf(IsDBNull(ecremcre.ccondic), "", ecremcre.ccondic)
        lcstatus = mcremcre.StatusCredito(lccondic)
        'Dim f_estruc As Date = ecremcre.dultres
       

        Dim lnciclo As Integer
        Dim lcpagadu As String = ""
        Dim mcreditos As New ccreditos

        lnciclo = mcreditos.fxCiclo(ecremcre.ccodcli, lccodcta)

        Dim ecremsol As New cCremsol

        lcnomcen = ecremsol.ObtenerNombreCentro2(lccodsol)
        lcnomgru = ecremsol.ObtenerNombre(lccodsol)

        lcpertenece = RTrim(LTrim(lcnomcen)) + "-" + RTrim(LTrim(lcnomgru))

        lccodana = ecremcre.ccodana
        etabtusu.ccodusu = lccodana
        mtabtusu.ObtenerTabtusu(etabtusu)

        ldfecvig = ecremcre.dfecvig.ToString
        ldfecven = ecremcre.dfecven.ToString
        lctasa = ecremcre.ntasint
        lcnumcuo = ecremcre.ncuoapr

        'Catch ex As Exception
        'Response.Write("<script language='javascript'>alert('error al obtener cremcre')</script>")
        'End Try

        'Try
        lccodcli = Me.txtcodcli.Text.Trim
        If lccodcli = Nothing Then
            'Response.Write("<script language='javascript'>alert('codigo de cliente en blanco')</script>")
            codigoJs = "<script language='javascript'>alert('Codigo de cliente en blanco, " & _
                     "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If
        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)
        lcteldom = eclimide.cteldom
        txttelefonos.Text = eclimide.cteldom.Trim & " " & eclimide.cTelFam.Trim & " " & eclimide.mDatAdi.Trim & " " & eclimide.ccodcon


        lcnumcasa = " "
        lcpagadu = ""

        'If lcnumcasa = Nothing Then
        '    lcnumcasa = eclimide.ccodcli.Substring(4, 8)
        'End If

        'Catch ex As Exception
        'Response.Write("<script language='javascript'>alert('error al obtener climide')</script>")

        'End Try
        'Try
        elinea.cnrolin = ecremcre.cnrolin
        clinea.ObtenerCretlin(elinea)

        'Catch ex As Exception
        'Response.Write("<script language='javascript'>alert('error al obtener linea')</script>")
        'End Try

        'obtiene agencia

        ldfecval = Date.Parse(Me.TXTFECPRO.Text)
        clsaplica.pcestado = m1.Estado(ldfecval, lccodcta)   'ecremcre.cestado
        clsaplica.pccodcta = lccodcta
        clsaplica.pdfecval = ldfecval
        clsaplica.gdfecsis = Session("gdfecsis")
        clsaplica.gnperbas = Session("gnperbas")
        clsaplica.cosind = Session("gncosind")
        clsaplica.gnmora = Session("gnmora")
        clsaplica.gdultpag = #2/1/1970#
        lnpropseg = Session("gnsegdeu")
        lnpropman = Session("gnmanejo")
        lnperbas = Session("gnperbas")
        lnporsegdeu = Session("gnporseg")
        lnporsegdan = Session("gnsegdan")
        lnporres = Session("gnporres")
        lnportalona = Session("gntalona")
        gdfecmor = Session("gdfecmor")
        clsaplica.gdfecmor = gdfecmor

        '****************
        If ldfecvig >= #7/11/2008# Then
            clsaplica.porsegdeu = Session("gnSegVm1")
        Else
            clsaplica.porsegdeu = Session("gnSegVm")
        End If

        clsaplica.porcomision = Session("gncomtra")
        '****************
        'busca actividad economica
        'Try
        etabtciu.ccodigo = lccodciu
        mtabtciu.ObtenerTabtciu(etabtciu)

        'Catch ex As Exception
        'Response.Write("<script language='javascript'>alert('error al obtener tabtciu')</script>")

        'End Try

        'busca oficina
        If lccodofi = "" Then
            lccodofi = lccodcta.Substring(3, 3)
        End If

        clsaplica.gnpergra = Session("gnpergra")
        ok = clsaplica.omcalcinterest("T", ldfecval)

        If ok > 0 Then

            lncappag = clsaplica.pncappag.ToString
            'determina que tipo de gastos se le cobraran a la linea
            'Try
            ecretlin.cnrolin = lcnrolin
            mcretlin.ObtenerCretlin(ecretlin)
            lsegdeu = ecretlin.lsegdeu
            lccodlin = ecretlin.ccodlin

            lntasint = Math.Round(ecretlin.ntasint / 12, 2)
            lntasmor = Math.Round(ecretlin.ntasmor / 12, 2)

            lsegdan = 0 'ecretlin.lsegdan
            lreserva = 0 'ecretlin.lreserva
            ltalona = 0 'ecretlin.ltalona
            ladmon = 0 'ecretlin.ladmon1


            Me.txtcodcta.Text = lccodcta.Trim

            lnintere = utilNumeros.Redondear(clsaplica.pnsalint, 2)
            lnintmor = utilNumeros.Redondear(clsaplica.pnsalmor, 2)
            lnmorcap = utilNumeros.Redondear(clsaplica.pndeucap, 2).ToString()

            lnsalcap = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
            lncapdes = utilNumeros.Redondear(clsaplica.pncapdes, 2).ToString()
            ldultpag = clsaplica.pdultpag
            lndiasatr = utilNumeros.Redondear(clsaplica.pndiaatr, 0).ToString
            'obtiene calificacion
            'si credito esta vigente o si es estado de cuenta historico
            Dim ecredkar As New cCredkar
            If lnsalcap <= 0 Then

            Else
                Dim lndiashis As Integer
                lndiashis = m1.diashis(lccodcta)
                lccalif = ecredkar.fxCalifica(lccodcta) 'clsppal.Califica(lndiashis)
            End If


            lncappag = utilNumeros.Redondear(clsaplica.pncappag, 2).ToString()
            lntotpag = utilNumeros.Redondear(clsaplica.pnmonpag1, 2).ToString()
            '
            gdfecsis = Session("gdfecsis")
            ldultpag = clsaplica.pdultpag


            lnmeses = clsaplica.meses_desde_ultimo_pago(gdfecsis, ldultpag)


            Dim ldultfecha As Date
            ldultfecha = ecredkar.UltimafechaProceso(lccodcta.Trim, ldfecval)
            'lndias = ldfecval.ToOADate - ldultpag.ToOADate
            lndias = ldfecval.ToOADate - ldultfecha.ToOADate
            If ldfecvig >= #7/11/2008# Then
                clsaplica.porsegdeu = Session("gnSegVm1")
            Else
                clsaplica.porsegdeu = Session("gnSegVm")
            End If

            clsaplica.porcomision = Session("gncomtra")
            clsaplica.porres = lnporres
            clsaplica.portalona = lnportalona

            lnsegdeu = 0
            lnsegdan = 0
            lnreserva = 0
            lntalona = 0
            lngasadm = 0


            lnprima = clsaplica.pnprima
            lncosdir = clsaplica.pncosdir
            lncosind = clsaplica.pncosind
            lnsubcidio = clsaplica.pnsubcidio
            lcprima = clsaplica.pnprima
            lccosdir = clsaplica.pncosdir
            lccosind = clsaplica.pncosind
            lcsubcidio = clsaplica.pnsubcidio

            'Calcula comisiones y seguro
            'Calculo de la comision por tramite -----------------

            Dim lncomision As Double = 0
            If lnsalcap = 0 Then
                lngasadm = 0
            Else
                lngasadm = lncomision
            End If

            If lsegdeu = True Then
                If ldfecvig >= #7/11/2008# Then
                    lnsegdeu = (lncapdes * Session("gnSegVm1") / 31) * lndias
                Else
                    lnsegdeu = (lncapdes * Session("gnSegVm") / 31) * lndias
                End If

            Else
                lnsegdeu = 0
            End If

            If lnsalcap = 0 Then
                lnsegdeu = 0
            Else
                lnsegdeu = utilNumeros.Redondear(lnsegdeu, 2)
            End If
            '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            '----------------------------------------------------------
            lnmonpag = utilNumeros.Redondear(lnmorcap + lnintere + lnintmor + lnsegdeu + lnsegdan + lntalona + lnreserva + lngasadm, 2)


            Dim lnintpag As Double = 0

            lnintpag = ecredkar.InteresPagado(lccodcta, ldfecval)


            lnsalteo = ecredppg.ObtenerSaldoTeorico(lccodcta, ldfecval, lncapdes)
            ldcapcub = ecredppg.FechaCapitalCubierto(lccodcta, (lncapdes - lnsalcap), ldfecvig)
            ldintcub = ecredppg.FechaInteresCubierto(lccodcta, lnintpag, ldfecvig)

            ldultcap = ecredkar.UltimafechadePago(lccodcta, ldfecval, "KP", ldfecvig)
            'Busca fuente de fondos
            Dim ds033 As New DataSet
            Dim clstabttab As New cTabttab
            Dim lcfondos1 As String
            Dim nelemf As Integer
            lcfondos1 = lccodlin.ToString.Substring(2, 2).Trim

            ds033 = clstabttab.ObtenerDataSetPorID2("033", "1", lcfondos1)
            nelemf = ds033.Tables(0).Rows.Count
            If nelemf = 0 Then
                lcfondos = ""
            Else
                lcfondos = ds033.Tables(0).Rows(0)("cdescri")
            End If

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            'Dim dstipo As New DataSet
            'Dim mcrepgar As New cCrepgar
            'Dim nelemgar As Integer

            'dstipo = clsppal.Garantizados(lccodcli.Trim)

            'nelemgar = dstipo.Tables(0).Rows.Count
            'If nelemgar = 0 Then
            '    lcgarantia = ""
            'ElseIf (nelemgar = 1) Then
            '    lcgarantia = dstipo.Tables(0).Rows(0)("cdescri")
            'Else
            '    If dstipo.Tables(0).Rows(0)("ctipgar") = "05" Then
            '        lcgarantia = "CREDITO PREFERENCIAL"
            '    Else
            '        lcgarantia = "MIXTA"
            '    End If
            'End If
            Dim ecrepgar As New cCrepgar
            Dim lcfiadores As String = ""
            lcgarantia = ecrepgar.ObtenerGarantiaPorGravamen(lccodcta, lccodcli)
            lcfiadores = ecrepgar.ObtenerGarantiaFiadoresPorGravamen(lccodcta, lccodcli)
            Txtgarantia.Text = lcgarantia
            Txtfiador.Text = lcfiadores
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            txtncapdes.Text = lncapdes
            txtdfecvig.Text = ldfecvig
            txtdfecven.Text = ldfecven
            txtncappag.Text = lncappag
            txtnsalcap.Text = lnsalcap
            txtntasa.Text = lntasint * 12
            txtnmoncuo.Text = lncuota
            txtndiaatr.Text = lndiasatr


            Dim lnmes As Integer = 0
            Dim dt As New DataTable
            dt = ecredkar.ObtenerUltimoPago(lccodcta, Session("gdfecsis"))
            If dt.Rows.Count = 0 Then
            Else
                Dim filapago As DataRow
                For Each filapago In dt.Rows
                    txtdfecval.Text = filapago("dfecpro")
                    txtdultpag.Text = filapago("dfecsis")
                    txtnultpag.Text = filapago("nmonto")
                Next

            End If

            lnmes = DateDiff(DateInterval.Month, ldfecvig, ldfecven)
            txtnmeses.Text = lnmes


        End If


        '***********************************************************
        '********************  reporte *********************
        Dim lcvendes As String = ""
        If lndiasatr > 0 Then
            lcvendes = Left(ldfecval.AddDays(lndiasatr * (-1)).ToString, 10)

        End If

        lccalif = clsppal.Califica(clsaplica.pndiaatr, lcfrecint)

        Dim ldfecproval As Date
        ldfecproval = Date.Parse(Me.TXTFECPRO.Text)

        Dim lnnavi As Double = 0
        Dim lnahosim As Double = 0
        Dim lnahoedu As Double = 0
        Dim lnahovis As Double = 0
        Dim lnahomen As Double = 0
        Dim lnmoraaporta As Double = 0
        '---------------------------------
        lnaportaciones = 0 'eahomcta.Aportaciones(lccodcli)
        lnnavi = 0 'eahomcta.ObtieneSaldo(lccodcli, "03")
        lnahosim = 0 'eahomcta.ObtieneSaldo(lccodcli, "01")
        lnahoedu = 0 'eahomcta.ObtieneSaldo(lccodcli, "04")
        lnahovis = 0 'eahomcta.ObtieneSaldo(lccodcli, "02")
        lnahomen = 0 'eahomcta.ObtieneSaldo(lccodcli, "05")
        lnmoraaporta = 0 'clsppal.Moraaportaciones(lccodcli, Session("gdfecsis"))

        Dim lncostas As Double = 0
        Dim lnanotacion As Double = 0
        Dim lndeudores As Double = 0
        'clsaditivos.pccodcta = lccodcta
        'clsaditivos.pdfecval = ldfecval
        'clsaditivos.pnsalcap = lnsalcap

        'clsaditivos.pdfeclim = Session("gdfeclim")
        'clsaditivos.pnsegmax = Session("gnsegmax")
        'clsaditivos.pdfecseg1 = Session("gdfecseg1")
        'clsaditivos.pdfecseg2 = Session("gdfecseg2")
        'clsaditivos.pdfecsis = Session("gdfecsis")
        'clsaditivos.pnmancta = Session("GNMANCTA")
        'clsaditivos.pdfecefec6 = Session("gdfecefec6")
        'clsaditivos.pnmancta6 = Session("gnmancta6")
        'clsaditivos.pnmancta5 = Session("gnmancta5")
        'clsaditivos.pcCostas = Session("gcCostas")
        'clsaditivos.pcAnotacion = Session("gcAnotacion")
        'clsaditivos.pcDeudores = Session("gcDeudores")
        'clsaditivos.pcPorCob = Session("gcPorCob")
        'clsaditivos.pnsegvid = Session("gnsegvid")
        lncostas = 0 ' clsaditivos.CostasProcesales()
        lnanotacion = 0 ' clsaditivos.AnotacionPreventiva()
        lndeudores = 0 ' clsaditivos.Deudores()

        Dim lnintereteo As Double = 0
        'Dim ecredppg As New cCredppg
        lnintereteo = 0 'ecredppg.ObtenerSaldodeInteresTeorico(lccodcta, ldintcub, ldfecval)

        Dim ecreditos As New ccreditos
        Dim dshis As New DataSet
        dshis = ecreditos.HistorialCreditos(txtcodcli.Text.Trim)

        If dshis.Tables(0).Rows.Count = 0 Then
        Else
            txtncrevig.Text = dshis.Tables(0).Rows(0)("ncrevig")
            txtncrecan.Text = dshis.Tables(0).Rows(0)("ncrecan")
        End If

        Botoninicio()
    End Sub

    'carga datos tomados de un unico select
    Public Sub CargarDatosPorCuenta(ByVal codcta As String)

        Dim fecha As Date
        Dim lcnomofi As String
        Dim etabtofi As New tabtofi
        Dim mtabtofi As New cTabtofi

        '        viewstate.Add("pccodcta", codcta)
        Me.txtcodcta.Text = codcta
        fecha = Session("gdfecsis")
        Me.TXTFECPRO.Text = fecha.ToShortDateString
        Me.txtcodcta.Text = codcta

        Dim ecreditos As New creditos
        Dim mcreditos As New ccreditos
        ecreditos.ccodcta = codcta

        mcreditos.Obtenercreditos(ecreditos)
        Me.txtnomcli.Text = ecreditos.cnomcli
        Me.txtcodcli.Text = ecreditos.ccodcli
        Me.txtnomana.Text = ecreditos.ccodana
        txtnomana0.Text = ecreditos.cNomUsu
        Me.txtlinea.Text = ecreditos.clineac
        Me.txtdireccion.Text = ecreditos.cdirdom
        lcnomofi = codcta.Substring(3, 3) 'ecreditos.coficina
        etabtofi.ccodofi = lcnomofi
        mtabtofi.ObtenerTabtofi(etabtofi)
        Me.txtagencia.Text = etabtofi.cnomofi.Trim

        Dim entidadclimide As New climide
        Dim omclimide As New cClimide


        entidadclimide.ccodcli = Me.txtcodcli.Text.Trim
        omclimide.ObtenerClimide(entidadclimide)

        Me.txtnoExterior.Text = entidadclimide.cNoExt
        Me.txtnoInterior.Text = entidadclimide.cNoInt
        Me.txtcalle.Text = entidadclimide.cCalle
        Me.txtcodpostal.Text = entidadclimide.cCodPostal
        Me.txtcelular.Text = entidadclimide.cTelFam

        'Carga Colonia
        BuscaColonia(entidadclimide.ccoddom)

        Me.DropDownComu.SelectedValue = entidadclimide.ccoddom

        CargarGrid()
        Txtndesde.Text = 1
        Txtnhasta.Text = 7


        Aplicar()
        Inhabilitar()
        ''
    End Sub

    Private Sub CargarGrid()
        Dim egestion As New cGestion
        Dim ds As New DataSet
        ds = egestion.ObtenerGestion(Me.txtcodcta.Text)

        Datagrid1.DataSource = ds
        Datagrid1.DataBind()

        Me.Datagrid1.Columns(7).Visible = False
        'Dim xy As Integer = 0
        'Dim txtid As TextBox
        'Dim fila As DataRow

        'For xy = 0 To Me.Datagrid1.Items.Count - 1
        '    Dim gvrow As DataGridItem

        '    gvrow = CType(Me.Datagrid1.Items(xy).Cells(3).NamingContainer, DataGridItem)
        '    txtid = CType(gvrow.FindControl("TextBox1"), TextBox)


        '    txtid.Text = 


        'Next

    End Sub

    Sub imprimir(ByVal lnmorcap As Double, ByVal lnsalcap As Double, ByVal lnintere As Double, ByVal lnintmor As Double, ByVal lnsegdeu As Double, ByVal lnsegdan As Double, ByVal lnreserva As Double, ByVal lntalona As Double, ByVal lngasadm As Double, ByVal lndiasatr As Double, ByVal ldultpag As Date, ByVal lnmonpag As Double, ByVal ldfecvig As Date, ByVal lncosdir As Double, ByVal lncosind As Double, ByVal lcprima As Double, ByVal lcnumcasa As String, ByVal lncappag As Double, ByVal lntotpag As Double, ByVal lccalif As String)
        Dim ldfecproval As Date
        ldfecproval = Date.Parse(Me.TXTFECPRO.Text)

        '***************** inicia proceso de impresion **********************
        '********************************************************************

        Try
            If ds Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If ds.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                    Return
                End If
            End If

        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Try
            Dim crRpt As New ReportDocument
            Dim rptStream As New System.IO.MemoryStream

            crRpt.Load(Server.MapPath("reportes") + "\crestcta1.rpt", OpenReportMethod.OpenReportByDefault)

            crRpt.SetDataSource(ds.Tables(0))
            crRpt.SetParameterValue("nmoracap", lnmorcap)
            crRpt.SetParameterValue("nsalcap", lnsalcap)
            crRpt.SetParameterValue("nsalint", lnintere)
            crRpt.SetParameterValue("nsalmor", lnintmor)
            crRpt.SetParameterValue("nsegdeu", lnsegdeu)
            crRpt.SetParameterValue("nsegdan", lnsegdan)
            crRpt.SetParameterValue("nreserva", lnreserva)
            crRpt.SetParameterValue("ntalona", lntalona)
            crRpt.SetParameterValue("ngasadm", lngasadm)
            crRpt.SetParameterValue("ndiaatr2", lndiasatr.ToString.Trim)
            crRpt.SetParameterValue("dultpag", ldultpag)
            crRpt.SetParameterValue("dfecsis", ldfecproval)
            crRpt.SetParameterValue("ntotal", lnmonpag)

            crRpt.SetParameterValue("cnomcli", Me.txtnomcli.Text.Trim)
            crRpt.SetParameterValue("cnomusu", Me.txtnomana.Text.Trim)
            crRpt.SetParameterValue("agencia", Me.txtagencia.Text)

            crRpt.SetParameterValue("numcasa", lcnumcasa)
            crRpt.SetParameterValue("ccodcli", Me.txtcodcli.Text)

            crRpt.SetParameterValue("ncappag", lncappag)
            crRpt.SetParameterValue("ntotpag", lntotpag)
            crRpt.SetParameterValue("linea", Me.txtlinea.Text)
            crRpt.SetParameterValue("direccion", Me.txtdireccion.Text)
            crRpt.SetParameterValue("calificacion", lccalif)

            rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
            Response.Clear()
            Response.Buffer = True
            ' Establece el tipo de documento
            Response.ContentType = "application/pdf"
            Response.BinaryWrite(rptStream.ToArray())
            Response.End()
            Response.CacheControl = "Private"

        Catch ex As Exception
            Response.CacheControl = "Private"
        End Try

    End Sub


    Protected Sub btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        txtbandera.Text = "1"
        Txtdetalle.Enabled = True
        Txtdetalle.Text = ""
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        txtfecpag.Text = Session("gdfecsis")
        CheckBox1.Checked = False
        CheckBox2.Checked = False

        txtinicio.Text = TimeOfDay.ToString.Substring(11, 12)

        habilitar()
        Botonseleccionar()
    End Sub

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        Dim entidadgestion As New gestion
        Dim egestion As New cGestion
        Dim lcidgestion As String = ""


        entidadgestion.ccodcli = Me.txtcodcli.Text.Trim
        entidadgestion.ccodcta = Me.txtcodcta.Text.Trim
        entidadgestion.dfecges = Session("gdfecsis")
        entidadgestion.time_in = txtinicio.Text.Trim
        entidadgestion.time_out = TimeOfDay.ToString.Substring(11, 12)
        entidadgestion.gestion = Txtdetalle.Text.Trim
        entidadgestion.cflag = IIf(CheckBox1.Checked = True, "P", IIf(CheckBox2.Checked = True, "E", ""))
        entidadgestion.ccodusu = Session("gccodusu")
        entidadgestion.ccodana = txtnomana.Text.Trim
        entidadgestion.dias_mora = Integer.Parse(txtndiaatr.Text)
        entidadgestion.dfecpag = Date.Parse(txtfecpag.Text)
        entidadgestion.resultados = ""
        entidadgestion.cfrecpag = txtfrecpag.Text.Trim
        entidadgestion.nmonconv = Decimal.Parse(txtmonconv.Text)

        If txtbandera.Text.Trim = "1" Then 'Nuevo
            lcidgestion = egestion.ObtenerCodigoGestion(txtcodcta.Text.Trim)
            entidadgestion.idgestion = lcidgestion
            egestion.Agregar(entidadgestion)

        Else 'Modificacion
            entidadgestion.idgestion = TxtComodin.Text.Trim
            egestion.ActualizarGestion(entidadgestion)
        End If

        Txtdetalle.Enabled = False
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False

        CargarGrid()
        Botoninicio()
        'Response.Write("<script language='javascript'>alert('Grabado')</script>")
        codigoJs = "<script language='javascript'>alert('Gestión Almacenada Correctamente, " & _
                     "Advertencia SIM.NET ')</script>"

        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
    End Sub


    'Protected Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
    '    Datagrid1.EditItemIndex = e.Item.ItemIndex
    'End Sub
    Private Sub Datagrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datagrid1.SelectedIndexChanged
        Dim ds As New DataSet
        ClienteSeleccionado = CType(Me.Datagrid1.SelectedItem.FindControl("TextBox1"), TextBox).Text
        Me.TxtComodin.Text = Me.ClienteSeleccionado
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        Txtdetalle.Text = ""

        Dim id As TextBox
        Dim lcidgestion As String
        Dim xy As Integer = 0
        Dim lcflag As String
        For xy = 0 To Me.Datagrid1.Items.Count - 1
            id = CType(Me.Datagrid1.Items(xy).FindControl("Textbox1"), TextBox)
            lcidgestion = id.Text.Trim

            If TxtComodin.Text.Trim = lcidgestion.Trim Then
                Txtdetalle.Text = Me.Datagrid1.Items(xy).Cells(3).Text.Trim
                txtfrecpag.Text = Me.Datagrid1.Items(xy).Cells(8).Text.Trim
                txtfecpag.Text = Date.Parse(Me.Datagrid1.Items(xy).Cells(9).Text.Trim)
                txtmonconv.Text = Me.Datagrid1.Items(xy).Cells(10).Text.Trim

                lcflag = Me.Datagrid1.Items(xy).Cells(7).Text.Trim
                txtbandera.Text = "0"
                Txtdetalle.Enabled = True
                txtfrecpag.Enabled = True
                txtfecpag.Enabled = True
                txtmonconv.Enabled = True
                CheckBox1.Enabled = True
                CheckBox2.Enabled = True

                If lcflag.Trim = "P" Then
                    CheckBox1.Checked = True
                End If
                If lcflag.Trim = "E" Then
                    CheckBox2.Checked = True
                End If

            End If

        Next

        Botonseleccionar()
    End Sub


    Protected Sub btnborrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        'Cambia estado para que no aparezca gestion
        Dim egestion As New cGestion
        egestion.ActualizaEstadoGestion(TxtComodin.Text.Trim, txtcodcta.Text.Trim)
        CargarGrid()
        Botoninicio()
        'Response.Write("<script language='javascript'>alert('Gestión Inhabilitada')</script>")
        codigoJs = "<script language='javascript'>alert('Gestión Inhabilitada, " & _
                   "Advertencia SIM.NET ')</script>"

        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
    End Sub

    Private Sub Botoninicio()
        btnnuevo.Enabled = True
        btnborrar.Enabled = False
        btngrabar.Enabled = False
    End Sub
    Private Sub Botonseleccionar()
        btnnuevo.Enabled = True
        btnborrar.Enabled = True
        btngrabar.Enabled = True
    End Sub

    Protected Sub btnnuevo0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo0.Click
        Dim ds As New DataSet
        Dim reportes As String = ""


        ds = clsppal.MoraNogestionada(txtnomana.Text.Trim, Integer.Parse(Txtndesde.Text), Integer.Parse(Txtnhasta.Text), Date.Parse(txtdfec1.Text), Date.Parse(txtdfec2.Text))

        

        Me.ExportToExcel(ds.Tables(0))

    End Sub

    Private Sub ExportToExcel(ByVal dt As DataTable)
        Dim sb As New StringBuilder()
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim dg As New GridView

        dg.AllowPaging = False
        dg.PagerSettings.Visible = False
        dg.AutoGenerateColumns = True
        dg.RowStyle.HorizontalAlign = HorizontalAlign.Left

        Dim Page As New Page()
        Dim form As New HtmlForm()



        dg.DataSource = dt 'esta es una funcion que ya lo debes tener hecha, te tiene que retornar un datatabla para llenar tu grilla
        dg.DataBind()

        Page.EnableEventValidation = False

        Page.DesignerInitialize()

        Page.Controls.Add(form)
        form.Controls.Add(dg)

        Page.RenderControl(htw)

        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"
        Response.AddHeader("Content-Disposition", "attachment;filename=Datos.xls")
        Response.Charset = "UTF-8"
        Response.ContentEncoding = Encoding.Default
        Response.Write(sb.ToString())
        Response.End()
    End Sub

    Protected Sub btnnuevo1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo1.Click
        Dim egestion As New cGestion
        Dim ds As New DataSet
        Dim lccodusu As String = ""
        Dim Reportes As String = "Gestion1.rpt"


        If CheckBox3.Checked = True Then
            lccodusu = ddlanalistas.SelectedValue.Trim
        Else
            lccodusu = ""
        End If
        ds = egestion.Gestiones(lccodusu, Date.Parse(txtdfec1.Text), Date.Parse(txtdfec2.Text), "")

        If ds.Tables(0).Rows.Count = 0 Then
            'Response.Write("<script language='javascript'>alert('No Existe Información ')</script>")
            codigoJs = "<script language='javascript'>alert('No Existe Información, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        Else
            imprimir("Gestion1.rpt", ds)

        End If


    End Sub

    Protected Sub btnnuevo2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo2.Click
        Dim egestion As New cGestion
        Dim ds As New DataSet
        Dim lccodusu As String = ""
        Dim lcgestor As String = ""
        Dim Reportes As String = "Gestion1.rpt"


        If CheckBox3.Checked = True Then
            lccodusu = ddlanalistas.SelectedValue.Trim
            lcgestor = lccodusu & " " & ddlanalistas.SelectedItem.Text.Trim
        Else
            lccodusu = ""
            lcgestor = txtnomana.Text.Trim & " " & txtnomana0.Text.Trim
        End If
        ds = egestion.Gestiones(lccodusu, Date.Parse(txtdfec1.Text), Date.Parse(txtdfec2.Text), "")

        If ds.Tables(0).Rows.Count = 0 Then
            'Response.Write("<script language='javascript'>alert('No Existe Información ')</script>")
            codigoJs = "<script language='javascript'>alert('No Existe Información, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        Else
            Me.ExportToExcel(ds.Tables(0))
        End If

    End Sub

    Protected Sub btnnuevo3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo3.Click
       
        Dim egestion As New cGestion
        Dim ds As New DataSet
        Dim lccodusu As String = ""
        Dim Reportes As String = "Gestion1.rpt"


        If CheckBox3.Checked = True Then
            lccodusu = ddlanalistas.SelectedValue.Trim
        Else
            lccodusu = ""
        End If
        ds = egestion.Gestiones(lccodusu, Date.Parse(txtdfec1.Text), Date.Parse(txtdfec2.Text), "P")

        If ds.Tables(0).Rows.Count = 0 Then
            'Response.Write("<script language='javascript'>alert('No Existe Información ')</script>")
            codigoJs = "<script language='javascript'>alert('No Existe Información, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        Else
            imprimir("Gestion1.rpt", ds)
        End If

    End Sub


    Private Sub imprimir(ByVal reportes As String, ByVal ds As DataSet)
        Dim lcgestor As String = ""
        Dim lccodusu As String = ""
        If CheckBox3.Checked = True Then
            lccodusu = ddlanalistas.SelectedValue.Trim
            lcgestor = lccodusu & " " & ddlanalistas.SelectedItem.Text.Trim
        Else
            lccodusu = ""
            lcgestor = txtnomana.Text.Trim & " " & txtnomana0.Text.Trim
        End If

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(ds.Tables(0))
        crRpt.SetParameterValue("gestor", lcgestor)

        reportes &= ".pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True

        Response.ContentType = "application/pdf"
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

        Response.BinaryWrite(rptStream.ToArray())
        Response.Flush()
        Response.Close()

    End Sub

    Protected Sub btnnuevo4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo4.Click
        Dim egestion As New cGestion
        Dim ds As New DataSet
        Dim lccodusu As String = ""
        Dim Reportes As String = "Gestion1.rpt"


        If CheckBox3.Checked = True Then
            lccodusu = ddlanalistas.SelectedValue.Trim
        Else
            lccodusu = ""
        End If
        ds = egestion.Gestiones(lccodusu, Date.Parse(txtdfec1.Text), Date.Parse(txtdfec2.Text), "E")

        If ds.Tables(0).Rows.Count = 0 Then
            'Response.Write("<script language='javascript'>alert('No Existe Información ')</script>")
            codigoJs = "<script language='javascript'>alert('No Existe Información, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        Else
            imprimir("Gestion1.rpt", ds)
        End If

    End Sub

    Protected Sub btnnota_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnota.Click
        Session("codigo") = Me.txtcodcta.Text.Trim
        Session("fuente") = Me.txtcodcli.Text.Trim
        'Response.Write("<script>window.open('wfNotas.aspx','cal', 'location=1, toolbar = no, status=1,width=700,height=550')</script>")

        codigoJs = "<script>window.open('wfNotas.aspx','cal', 'location=1, toolbar = no, status=1,width=700,height=550')</script>"
        

        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
    End Sub
    Private Sub Inhabilitar()
        txtfrecpag.Enabled = False
        txtfecpag.Enabled = False
        txtmonconv.Enabled = False
    End Sub
    Private Sub habilitar()
        txtfrecpag.Enabled = True
        txtfecpag.Enabled = True
        txtmonconv.Enabled = True

        txtfrecpag.Text = ""
        txtfecpag.Text = Session("gdfecsis")
        txtmonconv.Text = 0
    End Sub


    Public Sub BuscaColonia(ByVal cCodDom As String)

        Me.DropDownComu.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        If DropDownComu.Items.Count > 0 Then
            DropDownComu.Items.Clear()
        End If

        'Colonia
        mTabtZon = clsTabtZon.ObtenerLista1(Left(cCodDom, 5), "3")
        Me.DropDownComu.DataTextField = "cDesZon"
        Me.DropDownComu.DataValueField = "cCodzon"
        Me.DropDownComu.DataSource = mTabtZon
        Me.DropDownComu.DataBind()

    End Sub

End Class


