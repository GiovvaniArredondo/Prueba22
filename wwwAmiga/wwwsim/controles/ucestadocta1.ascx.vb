Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web


Partial Class ucestadocta1
    Inherits ucWBase

#Region "Variables"
    Private clsppal As New class1
    Private ds As New DataSet
    Private codigoJs As String
#End Region
    
    Public Event SeleccionarCuenta(ByVal codcta As String)

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim fecha As Date
            fecha = Session("gdfecsis")
            Me.TXTFECPRO.Text = fecha.ToShortDateString.ToString
        End If
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

        If Not (ecreditos.cestado = "F" Or ecreditos.cestado = "G") Then
            codigoJs = "<script language='javascript'>alert('codigo de cliente en blanco, " & _
                                               "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Button1.Enabled = False
            Exit Sub
        End If

        Me.txtnomcli.Text = ecreditos.cnomcli
        Me.txtcodcli.Text = ecreditos.ccodcli
        Me.txtnomana.Text = ecreditos.cNomUsu
        Me.txtlinea.Text = ecreditos.clineac
        Me.txtdireccion.Text = ecreditos.cdirdom
        lcnomofi = ecreditos.coficina

        Dim lccodpag As String = ""
        lccodpag = ecreditos.ccodpag
        Dim lcbanco As String = ""
        Dim etabtbaco As New cTabtbco
        Dim entidadtabtbco As New tabtbco

        If IsDBNull(lccodpag) Or lccodpag = Nothing Then
            lccodpag = ""
        End If
        Dim i As Integer
        entidadtabtbco.ccodbco = lccodpag
        i = etabtbaco.ObtenerTabtbco(entidadtabtbco)

        If i = 0 Then
        Else
            lcbanco = entidadtabtbco.cnombco.Trim + " " + entidadtabtbco.cctacte.Trim
        End If



        etabtofi.ccodofi = lcnomofi
        mtabtofi.ObtenerTabtofi(etabtofi)
        Me.txtagencia.Text = etabtofi.cnomofi.Trim
        txtbanco.Text = lcbanco
        Button1.Enabled = True
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

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim codcta As String
        codcta = Me.txtcodcta.Text.Trim
        'Cesar Torres cambiar estatus a cancelado si la cuenta ya pagó todo el capital
        Dim saldactual As Double

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
        Dim lniva As Double = 0

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
        Dim lcestado As String = ""
        Dim lccodsol As String = ""
        Dim lcnomcen As String = ""
        Dim lcnomgru As String = ""
        Dim lcpertenece As String = ""
        Dim lnservicio As Double = 0
        Dim lnSaldoInteresFlat_total As Double = 0

        '--------------------------------------------
        Dim lnsaliniint As Double = 0
        Dim ldpagven As Date = Session("gdfecsis")

        Dim lnsalintpen As Double = 0
        Dim lnintpenpag As Double = 0
        Dim lcFlat As String = ""
        '--------------------------------------------


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
        mcremcre.CancelarCredito(codcta)

        clsppal.gnperbas = Session("gnperbas")
        clsppal.pnComtra = Session("gnComTra")
        If ecremcre.dfecvig >= #7/11/2008# Then
            clsppal.pnSegVm = Session("gnSegVm1")
        Else
            clsppal.pnSegVm = Session("gnSegVm")
        End If

        Dim lcfectra As String = ""
        Try
            If ecremcre.ccondic = "S" Then
                lcfectra = "Fecha de Traslado: " & Left(ecremcre.dfectra.ToString, 10)
            Else
                lcfectra = ""
            End If
        Catch ex As Exception

        End Try
      

        lncuota = clsppal.ValorCuota(lccodcta)


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
            If Trim(fila("cnuming")) = "COND" Or Trim(fila("cnuming")) = "AJUSTE" Then
                fila("cnumrec") = fila("cnuming")
            End If
        Next
        Dim lcformapago1 As String = ""
        Dim lcformapago2 As String = ""
        Dim lctipocuota As String = ""
        Dim lnmonapr As Double = 0
        Dim etabttab As New cTabttab
        Dim lccontra As String = ""
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
        lccalif = IIf(ecremcre.ccalif = Nothing, "", ecremcre.ccalif)
        lccodsol = ecremcre.ccodsol
        lnmonapr = ecremcre.nmonapr

        lcformapago1 = IIf(IsDBNull(ecremcre.cfreccap), "", etabttab.Describe(ecremcre.cfreccap, "060"))
        lcformapago2 = IIf(IsDBNull(ecremcre.cfrecint), "", etabttab.Describe(ecremcre.cfrecint, "060"))
        lctipocuota = IIf(ecremcre.cflat = "F", "FLAT", "FIJA NIVELADA")
        lcFlat = ecremcre.cflat

        Dim lccondic As String = ""
        Dim lcstatus As String = ""


        lccondic = IIf(IsDBNull(ecremcre.ccondic), "", ecremcre.ccondic)
        lccontra = IIf(IsDBNull(ecremcre.ccontra), "", ecremcre.ccontra)

        If lccontra.Trim = "R" Or lccontra.Trim = "P" Then
            lcstatus = mcremcre.StatusCredito(lccontra) & " " & lcfectra
        Else
            lcstatus = mcremcre.StatusCredito(lccondic) & " " & lcfectra
        End If


        Dim lnciclo As Integer
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
        lncapdes = ecremcre.ncapdes

        lccodcli = Me.txtcodcli.Text.Trim
        If lccodcli = Nothing Then
            'Response.Write("<script language='javascript'>alert('codigo de cliente en blanco')</script>")
            codigoJs = "<script language='javascript'>alert('codigo de cliente en blanco, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)
        lcteldom = eclimide.cteldom
        lcnumcasa = " "
       
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

        If ldfecvig >= #7/11/2008# Then
            clsaplica.porsegdeu = Session("gnSegVm1")
        Else
            clsaplica.porsegdeu = Session("gnSegVm")
        End If

        clsaplica.porcomision = Session("gncomtra")
        '****************
        'busca actividad economica

        etabtciu.ccodigo = lccodciu
        mtabtciu.ObtenerTabtciu(etabtciu)

        If lccodofi = "" Then
            lccodofi = lccodcta.Substring(3, 3)
        End If

        
        clsaplica.gnpergra = Session("gnpergra")
        ok = clsaplica.omcalcinterest("T", ldfecval)
        'Catch ex As Exception
        'Response.Write("<script language='javascript'>alert('error al calcular intereses')</script>")
        'End Try

        If ok > 0 Then

            lncappag = clsaplica.pncappag.ToString
            'determina que tipo de gastos se le cobraran a la linea
            'Try
            ecretlin.cnrolin = lcnrolin
            mcretlin.ObtenerCretlin(ecretlin)
            lsegdeu = ecretlin.lsegdeu
            lccodlin = ecretlin.ccodlin

            lntasint = Math.Round(ecremcre.ntasint / 12, 2)
            lntasmor = Math.Round(ecretlin.ntasmor / 12, 2)

            lsegdan = 0 'ecretlin.lsegdan
            lreserva = 0 'ecretlin.lreserva
            ltalona = 0 'ecretlin.ltalona
            ladmon = 0 'ecretlin.ladmon1

            'Catch ex As Exception
            'Response.Write("<script language='javascript'>alert('error al obtener linea')</script>")
            'End Try

            Me.txtcodcta.Text = lccodcta.Trim

            lnintere = utilNumeros.Redondear(clsaplica.pnsalint, 2)
            lnservicio = Math.Round(clsaplica.pnsalser, 2)
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
                '        lccalif = clsppal.Califica(lndiasatr)
            Else
                Dim lndiashis As Integer
                lndiashis = m1.diashis(lccodcta)
                lccalif = clsppal.Califica(lndiasatr, ecremcre.cfrecint) 'clsppal.Califica(lndiashis)
            End If


            lncappag = utilNumeros.Redondear(clsaplica.pncappag, 2).ToString()
            lntotpag = utilNumeros.Redondear(clsaplica.pnmonpag1, 2).ToString()
            '
            gdfecsis = Session("gdfecsis")
            ldultpag = clsaplica.pdultpag
            ' lnsalcap = clsaplica.pncapdes - clsaplica.pncappag

            lnmeses = clsaplica.meses_desde_ultimo_pago(gdfecsis, ldultpag)
            'habitat

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

            'Dim lncomision As Double
            'If lccodlin.Substring(8, 2) = "06" Then
            '    lncomision = 0
            'Else
            '    If ldfecvig > #11/1/2005# Then
            '        lncomision = utilNumeros.Redondear((lncapdes * (Session("gncomtra") / 100) * lndias) / Session("gnperbas"), 2)
            '    Else
            '        lncomision = 0
            '    End If

            'End If
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            'If lnsalcap = 0 Then
            '    lngasadm = 0
            'Else
            '    lngasadm = lncomision
            'End If

            'If lsegdeu = True Then
            '    If ldfecvig >= #7/11/2008# Then
            '        lnsegdeu = (lncapdes * Session("gnSegVm1") / 31) * lndias
            '    Else
            '        lnsegdeu = (lncapdes * Session("gnSegVm") / 31) * lndias
            '    End If

            'Else
            '    lnsegdeu = 0
            'End If

            'If lnsalcap = 0 Then
            '    lnsegdeu = 0
            'Else
            '    lnsegdeu = utilNumeros.Redondear(lnsegdeu, 2)
            'End If
            '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            lnsegdeu = clsppal.CalcularSeguroDeuda(lccodcta, ldfecval, lnsalcap, clsaplica.pdfecvig)
            lngasadm = clsppal.CalcularManejo(lccodcta, ldfecval, clsaplica.pncapdes, False)
            lniva = 0 'clsppal.CalcularIVAManejo(Session("gnIVA"), (lngasadm + lnintere + lnintmor))

            lnmonpag = utilNumeros.Redondear(lnmorcap + lnintere + lnservicio + lnintmor + lnsegdeu + lnsegdan + lntalona + lnreserva + lngasadm + lniva, 2)
            '----------------------------------------------------------
            Dim ecredppg As New cCredppg
            If lcFlat = "F" Then
                lnSaldoInteresFlat_total = ecredppg.Extrae_Saldo_Interes_Total_Flat(lccodcta, ldfecval)
                lnintere = lnSaldoInteresFlat_total
                saldactual = ecredppg.SaldoAlDia(lccodcta, ldfecval)
                lnmonpag = utilNumeros.Redondear(lnmorcap + saldactual + lnservicio + lnintmor + lnsegdeu + lnsegdan + lntalona + lnreserva + lngasadm + lniva, 2)

            End If




            lnsalteo = ecredppg.ObtenerSaldoTeorico(lccodcta, ldfecval, lncapdes)
            '---------------------------------------------------------------
            lnsaliniint = ecredppg.ObtenerSaldoInteresPlan(lccodcta)
            If lndiasatr > 0 Then
                ldpagven = DateAdd(DateInterval.Day, (lndiasatr * (-1)), ldfecval)
            End If

            lnsalintpen = ecredppg.InteresPendiente(lccodcta, ldfecval)
            lnintpenpag = ecredkar.InteresPendientePagado(lccodcta, ldfecval)

            



            '---------------------------------------------------------------
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

            
            Dim lctipgar As String

          
            lctipgar = clsppal.ObtenerCodigoGarantia(lccodcta)
            lcgarantia = etabttab.Describe(lctipgar, "074")
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        End If


        '***********************************************************
        '********************  reporte *********************



        Dim ldfecproval As Date
        ldfecproval = Date.Parse(Me.TXTFECPRO.Text)

        '***************** inicia proceso de impresion **********************
        '********************************************************************

        '    Try
        If ds Is Nothing Then
            Me.AsignarMensaje("Error al obtener informacion del reporte", True)
            Return
        Else
            If ds.Tables(0).Rows.Count = 0 Then
                Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                Return
            End If
        End If

        '   Catch ex As Exception
        '      Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
        '     Return
        '    End Try

        '   Try

       

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        crRpt.Load(Server.MapPath("reportes") + "\crestcta1.rpt", OpenReportMethod.OpenReportByDefault)

        crRpt.SetDataSource(ds.Tables(0))


        crRpt.SetParameterValue("nmoracap", lnmorcap)
        crRpt.SetParameterValue("nsalcap", lnsalcap)
        crRpt.SetParameterValue("nsalint", lnintere)
        crRpt.SetParameterValue("nsalser", lnservicio)
        crRpt.SetParameterValue("nsalmor", lnintmor)
        crRpt.SetParameterValue("nsegdeu", lnsegdeu) 'seguro de deuda
        crRpt.SetParameterValue("nsegdan", lnsegdan)
        crRpt.SetParameterValue("nreserva", lnreserva)
        crRpt.SetParameterValue("ntalona", lntalona)
        crRpt.SetParameterValue("ngasadm", lngasadm) 'interes acumulado
        crRpt.SetParameterValue("ndiaatr2", lndiasatr.ToString.Trim)
        crRpt.SetParameterValue("dultpag", ldultpag)
        crRpt.SetParameterValue("dfecsis", ldfecproval)
        crRpt.SetParameterValue("ntotal", lnmonpag)

        crRpt.SetParameterValue("cnomcli", Me.txtnomcli.Text.Trim)
        crRpt.SetParameterValue("cnomusu", Me.txtnomana.Text.Trim)
        crRpt.SetParameterValue("agencia", Me.txtagencia.Text)

        crRpt.SetParameterValue("numcasa", lcnumcasa)
        crRpt.SetParameterValue("ccodcli", Me.txtcodcli.Text)

        crRpt.SetParameterValue("nCapDes", lncapdes)
        crRpt.SetParameterValue("ncappag", lncappag)
        crRpt.SetParameterValue("ntotpag", lntotpag)
        crRpt.SetParameterValue("linea", Me.txtlinea.Text)
        crRpt.SetParameterValue("direccion", Me.txtdireccion.Text)
        crRpt.SetParameterValue("calificacion", lccalif)
        crRpt.SetParameterValue("nsalTeo", lnsalteo)
        crRpt.SetParameterValue("pnmoncuo", lncuota)
        crRpt.SetParameterValue("cfondos", lcfondos)
        crRpt.SetParameterValue("ctelefono", lcteldom)
        crRpt.SetParameterValue("cgarantia", lcgarantia)
        crRpt.SetParameterValue("cpertenece", lcpertenece)

        crRpt.SetParameterValue("cformapago1", lcformapago1)
        crRpt.SetParameterValue("cformapago2", lcformapago2)
        crRpt.SetParameterValue("ctipocuota", lctipocuota)
        crRpt.SetParameterValue("nmonapr", lnmonapr)

        crRpt.SetParameterValue("ntasint", lntasint)
        crRpt.SetParameterValue("ntasmor", lntasmor)

        crRpt.SetParameterValue("cstatus", lcstatus)
        crRpt.SetParameterValue("nciclo", lnciclo)
        crRpt.SetParameterValue("nIVA", lniva)
        '----------------------------------------------------------------
        crRpt.SetParameterValue("pnsaliniint", lnsaliniint)
        crRpt.SetParameterValue("pdpagven", ldpagven)

        crRpt.SetParameterValue("pnsalintpen", lnsalintpen)
        crRpt.SetParameterValue("pnintpenpag", lnintpenpag)
        crRpt.SetParameterValue("pnsalint_total_Flat", lnSaldoInteresFlat_total)
        crRpt.SetParameterValue("pcFlat", lcFlat)

        '----------------------------------------------------------------

        Dim reportes As String
        reportes = "crestcta1.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
        '        Response.End()
        Response.CacheControl = "Private"

    End Sub
End Class


