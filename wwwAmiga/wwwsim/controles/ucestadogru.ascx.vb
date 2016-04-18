Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class ucestadoGru
    Inherits ucWBase
    Dim clsppal As New class1

    Dim ds As New DataSet

    Public Event SeleccionarCuenta(ByVal codcta As String)



#Region "Metodos"
    Private Sub Imprimir_PlanPagos_Grupal()
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\plandepagos.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        Dim lccodsol As String = ""
        Dim ldfecha As Date
        Dim mcremsol As New cCremsol
        Dim ds_grupo As New DataSet
        Dim lcCodcta As String = ""

        'Extrae da

        ds_grupo = mcremsol.Datos_Miembros_Grupo(Me.txtcodcli.Text.Trim)


        For Each Linea As DataRow In ds_grupo.Tables(0).Rows
            lcCodcta = Linea("cCodcta")
        Next



        Dim lcnomcli As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = lcCodcta



        ecreditos.Obtenercreditos(entidad3)
        'entidad3.ccodsol

        '--------------------<<<<<>>>>>----------------
        Dim lcnomana As String = ""
        'Dim lccodcta As String = ""
        Dim lcoficina As String = ""

        lcnomana = entidad3.cNomUsu
        '        lccodcta = entidad3.ccodcta
        lcoficina = entidad3.coficina

        Dim etabtofi As New cTabtofi
        Dim lcnomofi As String
        lcnomofi = etabtofi.NombreAgencia(lcoficina)

        Dim lcnrolin As String = ""
        Dim lcdeslin As String = ""
        lcnrolin = entidad3.cnrolin

        Dim entidadcretlin As New cretlin
        Dim ecretlin As New cCretlin

        entidadcretlin.cnrolin = lcnrolin
        ecretlin.ObtenerCretlin(entidadcretlin)

        lcdeslin = entidadcretlin.cdeslin


        '--------------------<<<<<>>>>>-----------------


        lccodsol = Me.txtcodcli.Text.Trim 'entidad3.ccodsol
        ldfecha = entidad3.dfecvig


        Dim ecremsol As New cCremsol
        lcnomcli = ecremsol.ObtenerNombre(entidad3.ccodsol)
        'lcnomcli = entidad3.cnomcli


        Dim dsPlanPago As New DataSet
        Dim entidadCredtpl As New SIM.EL.credppg
        Dim eCredtpl As New SIM.BL.cCredppg
        'entidadCredtpl.ccodcta = Me.txtcCodCta.Text.Trim
        'dsPlanPago = eCredtpl.ObtenerDataSetPorID(Me.txtcCodCta.Text.Trim)

        dsPlanPago = eCredtpl.PlanGrupalTeorico(lccodsol, ldfecha)
        If dsPlanPago.Tables(0).Rows.Count = 0 Then
            Dim ecredppg As New cCredppg
            dsPlanPago = ecredppg.PlanGrupalTeorico(lccodsol, ldfecha)
        End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim fila As DataRow
        Dim nelem As Integer
        Dim lnSaldo As Double = 0
        Dim lctipope As String
        Dim lnsalint As Double = 0

        Dim lntasaiva As Double = Session("gnIVA")
        Dim lniva As Decimal = 0
        Dim ldfecdes As Date = Session("gdfecsis")
        Dim ldfecpri As Date = Session("gdfecsis")
        Dim lcmes As Integer = 0
        Dim lcnota As String = ""
        Dim lnsegdeu As Decimal = 0
        Dim lnmanejo As Decimal = 0

        For Each fila In dsPlanPago.Tables(0).Rows
            lctipope = dsPlanPago.Tables(0).Rows(nelem)("cTipOpe")
            If lctipope = "D" Then
                lnSaldo = lnSaldo + dsPlanPago.Tables(0).Rows(nelem)("nCapita")
            Else
                lnSaldo = lnSaldo - dsPlanPago.Tables(0).Rows(nelem)("nCapita")
            End If
            lnsalint = lnsalint + dsPlanPago.Tables(0).Rows(nelem)("nIntere")
            dsPlanPago.Tables(0).Rows(nelem)("saldo") = lnSaldo
            nelem = nelem + 1
        Next
        nelem = 0
        For Each fila In dsPlanPago.Tables(0).Rows
            lctipope = dsPlanPago.Tables(0).Rows(nelem)("cTipOpe")
            If lctipope = "D" Then
                dsPlanPago.Tables(0).Rows(nelem)("ncapita") = 0
                ldfecdes = dsPlanPago.Tables(0).Rows(nelem)("dfecven")
                fila("nintere") = 0
            Else
                lnsalint = lnsalint - dsPlanPago.Tables(0).Rows(nelem)("nintere")
                lniva = Math.Round(dsPlanPago.Tables(0).Rows(nelem)("nGastos") * lntasaiva / 100, 2)
                dsPlanPago.Tables(0).Rows(nelem)("nGastos") = (dsPlanPago.Tables(0).Rows(nelem)("nGastos") + lniva)

                If dsPlanPago.Tables(0).Rows(nelem)("cnrocuo") = "001" Then
                    ldfecpri = dsPlanPago.Tables(0).Rows(nelem)("dfecven")
                    lnsegdeu = dsPlanPago.Tables(0).Rows(nelem)("nsegdeu")
                    lnmanejo = dsPlanPago.Tables(0).Rows(nelem)("ngastos")
                End If


            End If
            dsPlanPago.Tables(0).Rows(nelem)("salint") = lnsalint
            nelem = nelem + 1
        Next
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim lntotal As Decimal = 0

        lcmes = DateDiff(DateInterval.Month, ldfecdes, ldfecpri)

        lcmes = lcmes - 1
        If lcmes < 0 Then
            lcmes = 0
        End If
        lntotal = Math.Round((lnsegdeu + lnmanejo) * lcmes, 2)
        If lcmes > 0 Then
            lcnota = "Para el pago de la primera cuota, traer adicional al valor de esta " & lntotal.ToString.Trim & " en concepto de Seguro de Deuda y Manejo de Cuenta  "
        End If


        Dim pniva As Double
        Dim lliva As Boolean
        'Dim entidadCretlin As New cretlin
        'Dim eCretlin As New cCretlin

        entidadcretlin.cnrolin = entidad3.cnrolin


        ecretlin.ObtenerCretlinPorllave(entidadcretlin)

        pniva = Session("gnIVA")
        lliva = entidadcretlin.lliva


        ''Valida si la Linea de Credito Incluye Iva
        If lliva Then
            For Each fila In dsPlanPago.Tables(0).Rows
                If fila("cTipOpe") = "N" Then
                    fila("nGastos") = fila("nintere") - (fila("nintere") / pniva)
                    fila("nGastos") = Math.Round(fila("nGastos"), 2)
                    fila("nintere") = fila("nintere") - fila("nGastos")
                Else
                    fila("nintere") = 0
                End If
            Next
        End If

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsPlanPago.Tables(0))

        crRpt.SetParameterValue("pcnomcli", lcnomcli)
        crRpt.SetParameterValue("pcnota", lcnota)

        crRpt.SetParameterValue("cnomana", ("Asesor: " & lcnomana))
        crRpt.SetParameterValue("ccodcta", ("Grupo Nº: " & lccodsol))
        crRpt.SetParameterValue("cdeslin", ("Linea: " & lcdeslin))
        crRpt.SetParameterValue("cnomofi", ("Oficina: " & lcnomofi))
        'crRpt.Refresh()

        'rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        'Response.Clear()
        'Response.Buffer = True
        ' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim reportes As String
        reportes = "plan.pdf"
        'reportes &= ".pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()
    End Sub
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim fecha As Date
            fecha = Session("gdfecsis")
            Me.TXTFECPRO.Text = fecha.ToShortDateString.ToString
            Me.txtninteres.Text = 0
            Me.txtnintmora.Text = 0
            Me.txtncapmora.Text = 0
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

        '        viewstate.Add("pccodcta", codcta)
        Me.txtcodcta.Text = codcta
        fecha = Session("gdfecsis")
        Me.TXTFECPRO.Text = fecha.ToShortDateString
        Me.txtcodcta.Text = codcta


        Dim ladelante As Boolean
        ladelante = CargaFechas()

        If ladelante = False Then
            Return
        End If
        Me.CargaDatosGrupo()
        'CargaParaCredito(codcta)

    End Sub
    Sub CargaDatosGrupo()
        Dim lcnomofi As String
        Dim etabtofi As New tabtofi
        Dim mtabtofi As New cTabtofi
        Dim ecretlin As New cCretlin


        Dim ecremsol As New cCremsol
        Dim icremsol As New cremsol

        icremsol.cCodsol = Me.txtcodcta.Text
        ecremsol.ObtenerCremsol(icremsol)

        Dim lccodofi As String
        lccodofi = icremsol.ccodofi
        Me.txtagencia.Text = mtabtofi.NombreAgencia(lccodofi)

        Me.txtnomcli.Text = ecremsol.ObtenerNombre(Me.txtcodcta.Text.Trim)

        Me.txtcodcli.Text = Me.txtcodcta.Text



        'lcnomofi = Me.txtcodcta.Text.Trim.Substring(3, 3) 'ecreditos.coficina
        'etabtofi.ccodofi = lcnomofi
        'mtabtofi.ObtenerTabtofi(etabtofi)
        'Me.txtagencia.Text = etabtofi.cnomofi.Trim

        Dim etabtusu As New cTabtusu
        Me.txtnomana.Text = etabtusu.ObtieneAnalistaGrupo(Me.txtcodcta.Text.Trim, Me.cbxFechas.SelectedValue)
        Me.txtlinea.Text = ecretlin.ObtieneLineaGrupo(Me.txtcodcta.Text.Trim, Me.cbxFechas.SelectedValue)
    End Sub
    Sub CargaParaCredito(ByVal Codcta)
        Dim etabtofi As New tabtofi
        Dim mtabtofi As New cTabtofi

        Dim lcnomofi As String
        Dim ecreditos As New creditos
        Dim mcreditos As New ccreditos
        ecreditos.ccodcta = codcta

        mcreditos.Obtenercreditos(ecreditos)
        Me.txtnomcli.Text = ecreditos.cnomcli
        Me.txtcodcli.Text = ecreditos.ccodcli
        Me.txtnomana.Text = ecreditos.cNomUsu
        Me.txtlinea.Text = ecreditos.clineac
        Me.txtdireccion.Text = ecreditos.cdirdom
        lcnomofi = codcta.Substring(3, 3) 'ecreditos.coficina
        etabtofi.ccodofi = lcnomofi
        mtabtofi.ObtenerTabtofi(etabtofi)
        Me.txtagencia.Text = etabtofi.cnomofi.Trim

    End Sub
    Private Function CargaFechas() As Boolean
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        ds = ecreditos.CargaFechas(Me.txtcodcta.Text.Trim)

        If ds.Tables(0).Rows.Count = 0 Then
            Me.cbxFechas.Enabled = False
            Me.btnaplica.Enabled = False
            Return False
        Else
            Me.cbxFechas.Enabled = True
            Me.btnaplica.Enabled = True

        End If

        Me.cbxFechas.DataTextField = "dfecvig"
        Me.cbxFechas.DataValueField = "dfecvig"
        Me.cbxFechas.DataSource = ds.Tables(0)
        Me.cbxFechas.DataBind()
        Return True
    End Function

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


    
    Private Sub Aplicar(ByVal pcCodcta As String)

        Dim codcta As String
        codcta = pcCodcta

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
        Dim lccalif As String
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

        Dim lnsalteo As Double = 0

        Dim lcfondos As String = ""
        Dim lcteldom As String = ""
        Dim lcgarantia As String = ""
        Dim lcestado As String
        Dim lccodsol As String = ""
        Dim lcnomcen As String = ""
        Dim lcnomgru As String = ""
        Dim lcpertenece As String = ""
        Dim lcfrecint As String = ""

        gdfecsis = Date.Parse(Me.TXTFECPRO.Text) 'Session("gdfecsis")
        lccodcta = pcCodcta 'Me.txtcodcta.Text  'viewstate("pccodcta")

        cls1.ccodcta1 = lccodcta
        'como es para una sola cuenta siempre sera 0
        bunacuenta = False

        ldfecha1 = #1/1/1900#
        ldfecha2 = gdfecsis

        'Para Calcular Cuota
        Dim lncuota As Double
        ecremcre.ccodcta = lccodcta
        mcremcre.ObtenerCremcre(ecremcre)

        clsppal.gnperbas = Session("gnperbas")
        clsppal.pnComtra = Session("gnComTra")
        If ecremcre.dfecvig >= #7/11/2008# Then
            clsppal.pnSegVm = Session("gnSegVm1")
        Else
            clsppal.pnSegVm = Session("gnSegVm")
        End If

        lncuota = clsppal.ValorCuota(lccodcta)


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
        lccalif = ecremcre.ccalif
        lccodsol = ecremcre.ccodsol
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

        'lccodcli = Me.txtcodcli.Text.Trim
        'If lccodcli = Nothing Then
        '    Response.Write("<script language='javascript'>alert('codigo de cliente en blanco')</script>")
        '    Exit Sub
        'End If
        'eclimide.ccodcli = lccodcli
        'mclimide.ObtenerClimide(eclimide)
        'lcteldom = eclimide.cteldom
        'lcnumcasa = " "
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

        ok = clsaplica.omcalcinterest("T", ldfecval)

        If ok > 0 Then

            lncappag = clsaplica.pncappag.ToString
            'determina que tipo de gastos se le cobraran a la linea
            'Try
            ecretlin.cnrolin = lcnrolin
            mcretlin.ObtenerCretlin(ecretlin)
            lsegdeu = ecretlin.lsegdeu
            lccodlin = ecretlin.ccodlin

            lsegdan = 0 'ecretlin.lsegdan
            lreserva = 0 'ecretlin.lreserva
            ltalona = 0 'ecretlin.ltalona
            ladmon = 0 'ecretlin.ladmon1

            'Catch ex As Exception
            'Response.Write("<script language='javascript'>alert('error al obtener linea')</script>")
            'End Try

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
            If lnsalcap > 0 Then
                lccalif = clsppal.Califica(lndiasatr, lcfrecint)
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

            Dim lncomision As Double
            If lccodlin.Substring(8, 2) = "06" Then
                lncomision = 0
            Else
                If ldfecvig > #11/1/2005# Then
                    lncomision = utilNumeros.Redondear((lncapdes * (Session("gncomtra") / 100) * lndias) / Session("gnperbas"), 2)
                Else
                    lncomision = 0
                End If

            End If
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
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

            Me.txtninteres.Text = lnintere
            Me.txtnintmora.Text = lnintmor
            Me.txtncapmora.Text = lnmorcap
            'Dim ecredppg As New cCredppg
            'lnsalteo = ecredppg.ObtenerSaldoTeorico(lccodcta, ldfecval, lncapdes)


            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        End If



    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Try
        Dim lnciclo As Integer
        Dim ecremsol As New cCremsol
        lnciclo = ecremsol.ObtenerCicloGrupo(Me.txtcodcta.Text.Trim, Me.cbxFechas.SelectedValue) 'cbxFechas.SelectedIndex + 1
        clsppal.GeneraPlanExportable(Me.txtcodcta.Text.Trim, Me.cbxFechas.SelectedValue, lnciclo)
        'Response.Write("<script language='javascript'>alert('El archivo se generó con éxito')</script>")
        'Catch ex As Exception

        'End Try

        Dim lcnombre As String

        lcnombre = ecremsol.ObtenerNombre(Me.txtcodcta.Text.Trim)


        Dim FilePath As String = "c:/txt/" & lcnombre.Trim & ".txt"

        Me.DownloadFile(FilePath, lcnombre.Trim & ".txt")
    End Sub
    Private Sub DownloadFile(ByVal filepath As String, ByVal name As String)

        Dim type As String = ""


        'If Not IsDBNull(ext) Then
        '    ext = LCase(ext)
        'End If

        'Select Case ext
        '    Case ".htm", ".html"
        '        type = "text/HTML"
        '    Case ".txt"
        '        type = "text/plain"
        '    Case ".doc", ".rtf"
        '        type = "Application/msword"
        '    Case ".csv", ".xls"
        '        type = "Application/x-msexcel"
        '    Case Else
        '        type = "text/plain"
        'End Select

        '        If (forceDownload) Then
        Response.AppendHeader("content-disposition", _
        "attachment; filename=" + name)
        'End If
        'If type <> "" Then
        Response.ContentType = "text/plain"
        '"Application/x-msexcel"
        'End If

        Response.WriteFile(filepath)
        Response.End()

    End Sub

    Protected Sub btnaplica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaplica.Click
        'Realiza el calculo para cada cliente del grupo
        Dim m1 As New ccreditos
        Dim ds As New DataSet
        ds = m1.HistoricoGrupal(Me.txtcodcta.Text.Trim, cbxFechas.SelectedValue)


        'Captura datos comunes*******************************************************
        Dim dsclientes As New DataSet
        Dim ecremcre As New cremcre
        Dim mcremcre As New cCremcre
        Dim ecremsol As New cCremsol
        Dim etabtusu As New cTabtusu

        Dim ecretlin As New cretlin
        Dim mcretlin As New cCretlin

        Dim etabttab As New cTabttab
        Dim lcformapago1 As String = ""
        Dim lcformapago2 As String = ""


        Dim ldfecvig As Date
        Dim ldfecven As Date

        Dim lcnomgru As String = ""
        Dim lcdirdom As String = ""
        Dim lcCodigo As String = ""
        Dim lcnomusu As String = ""
        Dim lnclientes As Integer = 0
        Dim lnciclo As Integer = 0
        Dim lcnrolin As String

        Dim lntasint As Double = 0

        Dim lntasmor As Double = 0

        Dim lnmonapr As Double = 0
        Dim lntotapr As Double = 0

        Dim lnmoncuo As Double = 0
        Dim lntotcuo As Double = 0

        Dim lncapdes As Double = 0
        Dim lntotdes As Double = 0

        Dim lncappag As Double = 0
        Dim lntotpag As Double = 0

        Dim lctipocuota As String = ""
        Dim lnsaldo As Double = 0


        Dim lnsalint As Double = 0
        Dim lnsalmora As Double = 0
        Dim lncapmora As Double = 0
        Dim lcfondos As String = ""

        dsclientes = mcremcre.ObtenerCreditosxGrupo(Me.txtcodcta.Text.Trim, cbxFechas.SelectedValue, Date.Parse(Me.TXTFECPRO.Text))
        If dsclientes.Tables(0).Rows.Count = 0 Then
            Return
        Else
            Dim fila1 As DataRow
            Dim i1 As Integer = 0

            For Each fila1 In ds.Tables(0).Rows
                If fila1("cdescob") = "C" Then
                    lnsaldo = lnsaldo - fila1("ncapita")
                    fila1("nsaldo") = lnsaldo
                    '    Else
                    '        lndesembolso = lndesembolso + fila("ncapita")
                    '        fila("nsaldo") = lndesembolso
                    '        lnsaldo = lndesembolso
                    '        fila("npago") = 0
                    '        fila("ncapita") = 0
                    '    End If
                    '    If fila("ndiaatr") < 0 Then
                    '        fila("ndiaatr") = 0
                Else
                    lnsaldo = lnsaldo + fila1("ncapita")
                    fila1("nsaldo") = lnsaldo

                    fila1("npago") = 0
                    fila1("ncapita") = 0

                End If

                i1 += 1
            Next




            Dim lcCodcta As String
            lcCodcta = dsclientes.Tables(0).Rows(0)("cCodcta")
            ecremcre.ccodcta = lcCodcta
            mcremcre.ObtenerCremcre(ecremcre)
            ldfecvig = ecremcre.dfecvig
            ldfecven = ecremcre.dfecven
            lcnomgru = ecremsol.ObtenerNombre(ecremcre.ccodsol.Trim)
            lcdirdom = ecremsol.ObtenerDireccion(ecremcre.ccodsol.Trim)
            lcformapago1 = IIf(IsDBNull(ecremcre.cfreccap), "", etabttab.Describe(ecremcre.cfreccap, "060"))
            lcformapago2 = IIf(IsDBNull(ecremcre.cfrecint), "", etabttab.Describe(ecremcre.cfrecint, "060"))
            lctipocuota = IIf(ecremcre.cflat = "F", "FLAT", "FIJA NIVELADA")
            lcCodigo = Me.txtcodcta.Text.Trim
            lcnomusu = etabtusu.NombreUsuario(ecremcre.ccodana)
            lnclientes = dsclientes.Tables(0).Rows.Count

            lnciclo = cbxFechas.SelectedIndex + 1
            lcnrolin = ecremcre.cnrolin

            ecretlin.cnrolin = lcnrolin
            mcretlin.ObtenerCretlin(ecretlin)

            lntasint = Math.Round(ecretlin.ntasint / 12, 2)
            lntasmor = Math.Round(ecretlin.ntasmor / 12, 2)


            lcfondos = mcretlin.ObtenerFuentedeFondos(ecremcre.cnrolin)

            Dim fila As DataRow
            Dim i As Integer = 0


            For Each fila In dsclientes.Tables(0).Rows
                lnmonapr = dsclientes.Tables(0).Rows(i)("nmonapr")
                'lnmoncuo = dsclientes.Tables(0).Rows(i)("nmoncuo")
                lcCodcta = dsclientes.Tables(0).Rows(i)("cCodcta")

                lntotapr = lntotapr + lnmonapr
                'lntotcuo = lntotcuo + lnmoncuo

                Aplicar(lcCodcta)

                lnsalint = lnsalint + Double.Parse(Me.txtninteres.Text)
                lnsalmora = lnsalmora + Double.Parse(Me.txtnintmora.Text)
                lncapmora = lncapmora + Double.Parse(Me.txtncapmora.Text)

                'lncapdes = dsclientes.Tables(0).Rows(i)("ncapdes")
                'lncappag = dsclientes.Tables(0).Rows(i)("ncappag")
                'lnsaldo = lncapdes - lncappag

                'Calcula los saldos



                i += 1
            Next

            Dim ecredppg As New cCredppg
            lntotcuo = ecredppg.CuotaGrupal(Me.txtcodcli.Text.Trim, cbxFechas.SelectedValue)

        End If


        '*****************************************************************************


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

        crRpt.Load(Server.MapPath("reportes") + "\crestGrupal.rpt", OpenReportMethod.OpenReportByDefault)

        crRpt.SetDataSource(ds.Tables(0))
        crRpt.SetParameterValue("gcnomins", Session("gcnomins"))
        crRpt.SetParameterValue("dfecvig", Date.Parse(Me.TXTFECPRO.Text))
        crRpt.SetParameterValue("gcnombre", lcnomgru)
        crRpt.SetParameterValue("gcdirecc", lcdirdom)
        crRpt.SetParameterValue("gccodigo", lcCodigo)
        crRpt.SetParameterValue("gcnomana", lcnomusu)
        crRpt.SetParameterValue("gdfecoto", ldfecvig)
        crRpt.SetParameterValue("gdfecven", ldfecven)
        crRpt.SetParameterValue("gnmiembros", lnclientes)
        crRpt.SetParameterValue("gnciclo", lnciclo)
        crRpt.SetParameterValue("gntasmen", lntasint)
        crRpt.SetParameterValue("gntasmor", lntasmor)
        crRpt.SetParameterValue("gctipocuota", lctipocuota)

        crRpt.SetParameterValue("gnmonapr", lntotapr)
        crRpt.SetParameterValue("gncuogru", lntotcuo)

        crRpt.SetParameterValue("cformacapital", lcformapago1)
        crRpt.SetParameterValue("cformainteres", lcformapago2)

        crRpt.SetParameterValue("gnsaldo", lnsaldo)
        crRpt.SetParameterValue("gnsalint", lnsalint)
        crRpt.SetParameterValue("gnsalmora", lnsalmora)
        crRpt.SetParameterValue("gncapmora", lncapmora)
        crRpt.SetParameterValue("gcfondos", lcfondos)


        Dim reportes As String
        reportes = "crestGrupal.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.End()



    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Imprimir_PlanPagos_Grupal()
    End Sub
End Class


