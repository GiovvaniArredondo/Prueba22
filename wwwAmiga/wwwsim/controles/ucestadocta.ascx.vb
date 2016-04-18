Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class ucestadocta
    Inherits ucWBase

    Public Event SeleccionarCuenta(ByVal codcta As String)

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub


    Public Sub CargarDatosPorCliente(ByVal codcli As String)
        ' Dim mControl As New cCredkar
        ' Dim mLista As New listacredkar
        Dim fecha As Date
        fecha = Session("gdfecsis")
        Me.TXTFECPRO.Text = fecha.ToShortDateString.ToString
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
        Me.txtnomcli.Text = ecreditos.cnomcli
        Me.txtcodcli.Text = ecreditos.ccodcli
        Me.txtnomana.Text = ecreditos.cNomUsu
        Me.txtlinea.Text = ecreditos.clineac
        Me.txtdireccion.Text = ecreditos.cdirdom
        lcnomofi = ecreditos.coficina
        etabtofi.ccodofi = lcnomofi
        mtabtofi.ObtenerTabtofi(etabtofi)
        Me.txtagencia.Text = etabtofi.cnomofi

    End Sub


    Sub imprimir(ByVal ds As DataSet, ByVal lnmorcap As Double, ByVal lnsalcap As Double, ByVal lnintere As Double, ByVal lnintmor As Double, ByVal lnsegdeu As Double, ByVal lnsegdan As Double, ByVal lnreserva As Double, ByVal lntalona As Double, ByVal lngasadm As Double, ByVal lndiasatr As Double, ByVal ldultpag As Date, ByVal lnmonpag As Double, ByVal ldfecvig As Date, ByVal lncosdir As Double, ByVal lncosind As Double, ByVal lcprima As Double, ByVal lcnumcasa As String, ByVal lncappag As Double, ByVal lntotpag As Double)

        Dim ldfecproval As Date
        ldfecproval = Date.Parse(Me.TXTFECPRO.Text)

        '***************** inicia proceso de impresion **********************
        '********************************************************************

        'Try
        If ds Is Nothing Then
            Me.AsignarMensaje("Error al obtener informacion del reporte", True)
            Return
        Else
            If ds.Tables(0).Rows.Count = 0 Then
                Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                Return
            End If
        End If

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try

            'crRpt.Load(Server.MapPath("reportes") + "\crestcta.rpt", OpenReportMethod.OpenReportByDefault)
            crRpt.Load(Server.MapPath("reportes") + "\crstatecount.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = "HENCORP"

        Dim a As String
        a = ds.Tables(0).TableName

        crRpt.SetDataSource(ds.Tables(a))
        crRpt.SetParameterValue("nmoracap", lnmorcap)
        crRpt.SetParameterValue("nsalcap", lnsalcap)
        crRpt.SetParameterValue("nsalint", lnintere)
        crRpt.SetParameterValue("nsalmor", lnintmor)
        crRpt.SetParameterValue("nsegdeu", lnsegdeu)
        crRpt.SetParameterValue("ngasadm", lngasadm)
        crRpt.SetParameterValue("ndiaatr", lndiasatr)
        crRpt.SetParameterValue("dultpag", ldultpag)
        crRpt.SetParameterValue("dfecsis", ldfecproval)
        crRpt.SetParameterValue("ntotal", lnmonpag)
        crRpt.SetParameterValue("dfecvig", ldfecvig)
        crRpt.SetParameterValue("cnomcli", Me.txtnomcli.Text.Trim)
        crRpt.SetParameterValue("cnomusu", Me.txtnomana.Text.Trim)
        crRpt.SetParameterValue("agencia", Me.txtagencia.Text)
        crRpt.SetParameterValue("ccodcli", Me.txtcodcli.Text)
        crRpt.SetParameterValue("ncappag", lncappag)
        crRpt.SetParameterValue("ntotpag", lntotpag)
        crRpt.SetParameterValue("linea", Me.txtlinea.Text)
        crRpt.SetParameterValue("direccion", Me.txtdireccion.Text)
        '>>>>>>>>>>>>>>>>>>>
        crRpt.SetParameterValue("nsegdan", 0)
        crRpt.SetParameterValue("nreserva", 0)
        crRpt.SetParameterValue("ntalona", 0)
        crRpt.SetParameterValue("NCOSDIR", 0)
        crRpt.SetParameterValue("NCOSIND", 0)
        crRpt.SetParameterValue("NPRIMA", 0)
        crRpt.SetParameterValue("numcasa", 0)

        '<<<<<<<<<<<<<<<<<<<<
        'crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True
        '        .
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()

        ds.Tables(0).Clear()
        ds.Clear()

    End Sub



    Private Sub btnaplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.Click

        Dim codcta As String
        codcta = Me.txtcodcta.Text.Trim

        If codcta = Nothing Then
            Exit Sub
        End If

        Dim ds As New DataSet

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

        gdfecsis = Session("gdfecsis")
        lccodcta = Me.txtcodcta.Text  'viewstate("pccodcta")

        cls1.ccodcta1 = lccodcta
        'como es para una sola cuenta siempre sera 0
        bunacuenta = False

        ldfecha1 = #1/1/1900#
        ldfecha2 = gdfecsis
        Try
            'ds = m1.DETALLE_CARTERA_Y_PAGOS_POR_CUENTA(ldfecha1, ldfecha2, "C", "*", "*", "*", "*", lccodcta)
            ds = m1.Detalle_Kardex(ldfecha1, ldfecha2, "C", "*", "*", "*", "*", lccodcta)
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('error al obtener cartera')</script>")

        End Try

        lnsaldo = ds.Tables(0).Rows(0)("ncapdes")
        ds.Tables(0).Rows(0)("nsaldo") = lnsaldo
        For Each fila In ds.Tables(0).Rows
            If fila("cdescob") = "C" Then
                lnsaldo = lnsaldo - fila("ncapita")
                fila("nsaldo") = lnsaldo
            End If
        Next

        'obtiene datos de la prima y otros
        Try
            ecremcre.ccodcta = lccodcta
            mcremcre.ObtenerCremcre(ecremcre)
            clsaplica.pnprima = ecremcre.nprima
            clsaplica.pncosdir = ecremcre.ncosdir
            clsaplica.pncosind = ecremcre.ncosind
            clsaplica.pnsubcidio = ecremcre.nahoprg
            lccodofi = ecremcre.coficina.Trim
            lccodciu = ecremcre.ccodact.Trim
            lccalif = ecremcre.ccalif
            lccodana = ecremcre.ccodana
            etabtusu.ccodusu = lccodana
            mtabtusu.ObtenerTabtusu(etabtusu)

            ldfecvig = ecremcre.dfecvig.ToString
            ldfecven = ecremcre.dfecven.ToString
            lctasa = ecremcre.ntasint
            lcnumcuo = ecremcre.ncuoapr

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('error al obtener cremcre')</script>")
        End Try

        Try
            lccodcli = Me.txtcodcli.Text.Trim
            If lccodcli = Nothing Then
                Response.Write("<script language='javascript'>alert('codigo de cliente en blanco')</script>")
                Exit Sub
            End If
            eclimide.ccodcli = lccodcli
            mclimide.ObtenerClimide(eclimide)
            lcnumcasa = "" 'eclimide.cnumcasa.Trim
            If lcnumcasa = Nothing Then
                lcnumcasa = eclimide.ccodcli.Substring(4, 8)
            End If

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('error al obtener climide')</script>")

        End Try
        Try
            elinea.cnrolin = ecremcre.cnrolin
            clinea.ObtenerCretlin(elinea)

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('error al obtener linea')</script>")

        End Try

        'obtiene agencia

        ldfecval = Date.Parse(Me.TXTFECPRO.Text)

        clsaplica.pccodcta = lccodcta
        clsaplica.pdfecval = ldfecval
        clsaplica.gdfecsis = Session("gdfecsis")
        clsaplica.gnperbas = Session("gnperbas")
        clsaplica.cosind = Session("gncosind")
        clsaplica.gnmora = Session("gnmora")
        clsaplica.gdultpag = #2/1/1970#
        clsaplica.pcestado = "F"
        lnpropseg = Session("gnsegdeu")
        lnpropman = Session("gnmanejo")
        lnperbas = Session("gnperbas")
        If ldfecvig >= #7/11/2008# Then
            lnporsegdeu = Session("gnSegVm1")
        Else
            lnporsegdeu = Session("gnSegVm")
        End If

        lnporsegdan = Session("gnsegdan")
        lnporres = Session("gnporres")
        lnportalona = Session("gntalona")
        gdfecmor = Session("gdfecmor")
        clsaplica.gdfecmor = gdfecmor
        clsaplica.pcestado = "F"

        'busca actividad economica
        Dim etabtciu As New tabtciu
        Dim mtabtciu As New cTabtciu
        Try
            etabtciu.ccodigo = lccodciu
            mtabtciu.ObtenerTabtciu(etabtciu)

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('error al obtener tabtciu')</script>")

        End Try
        'Me.txtactividad.Text = etabtciu.cdescri

        'obtiene monto de la garantias
        Dim lncappag As Double
        Dim lcnrolin As String
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

        ' Me.txtmongar.Text = mclimgar.ObtenerID_codigo(Me.txtcodcli.Text.Trim)

        'busca oficina
        If lccodofi = "" Then
            lccodofi = lccodcta.Substring(3, 3)
        End If
        'Try
        ' etabtofi.ccodofi = lccodofi
        'mtabtofi.ObtenerTabtofi(etabtofi)
        'Me.txtagencia.Text = etabtofi.cnomofi

        '       Catch ex As Exception
        '      Response.Write("<script language='javascript'>alert('error al obtener oficinas')</script>")

        '     End Try

        Try

            ok = clsaplica.omcalcinterest("T", ldfecval)
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('error al calcular intereses')</script>")
        End Try

        If ok > 0 Then

            lncappag = clsaplica.pncappag.ToString
            lcnrolin = clsaplica.cnrolin
            'determina que tipo de gastos se le cobraran a la linea
            Try
                ecretlin.cnrolin = lcnrolin
                mcretlin.ObtenerCretlin(ecretlin)
                lsegdeu = ecretlin.lsegdeu
                lsegdan = 0 'ecretlin.lsegdan
                lreserva = 0 'ecretlin.lreserva
                ltalona = 0 'ecretlin.ltalona
                ladmon = 0 'ecretlin.ladmon1

            Catch ex As Exception
                Response.Write("<script language='javascript'>alert('error al obtener linea')</script>")
            End Try



            Me.txtcodcta.Text = lccodcta.Trim

            Me.txtcodcli.Text = clsaplica.pccodcli
            lnintere = utilNumeros.Redondear(clsaplica.pnsalint, 2)
            lnintmor = utilNumeros.Redondear(clsaplica.pnsalmor, 2)
            lnmorcap = utilNumeros.Redondear(clsaplica.pndeucap, 2).ToString()

            lnsalcap = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
            lncapdes = utilNumeros.Redondear(clsaplica.pncapdes, 2).ToString()
            ldultpag = clsaplica.pdultpag
            lndiasatr = utilNumeros.Redondear(clsaplica.pndiaatr, 0).ToString

            lncappag = utilNumeros.Redondear(clsaplica.pncappag, 2).ToString()
            lntotpag = utilNumeros.Redondear(clsaplica.pnmonpag1, 2).ToString()
            '
            gdfecsis = Session("gdfecsis")
            ldultpag = clsaplica.pdultpag
            lnsalcap = clsaplica.pncapdes - clsaplica.pncappag

            lnmeses = clsaplica.meses_desde_ultimo_pago(gdfecsis, ldultpag)
            'habitat
            lndias = ldfecval.ToOADate - ldultpag.ToOADate
            If ldfecvig >= #7/11/2008# Then
                clsaplica.porsegdeu = Session("gnSegVm1")
            Else
                clsaplica.porsegdeu = Session("gnSegVm")
            End If


            clsaplica.porcomision = Session("gncomtra")
            clsaplica.porres = lnporres
            clsaplica.portalona = lnportalona
            'seguro de deuda
            Try

                If lsegdeu = True Then
                    lnsegdeu = 0 'clsaplica.segdeu1   ' utilNumeros.Redondear(lnsalcap * lnporsegdeu * (lndias / lnperbas), 2)
                Else
                    lnsegdeu = 0
                End If

                'seguro danos
                If lsegdan = True Then
                    lnsegdan = 0 'clsaplica.segdan1 'utilNumeros.Redondear(clsaplica.pncapdes * lnporsegdan * (30 / lnperbas), 2)
                Else
                    lnsegdan = 0
                End If

                'reserva
                If lreserva = True Then
                    lnreserva = 0 'clsaplica.reserva1   ' utilNumeros.Redondear(lnsalcap * lnporres * (lndias / lnperbas), 2)
                Else
                    lnreserva = 0
                End If
                If ltalona = True Then
                    lntalona = 0 'clsaplica.talonario1  'utilNumeros.Redondear(lnportalona, 2)
                Else
                    lntalona = 0
                End If

                If ladmon = True Then
                    lngasadm = 0 'clsaplica.cosadm1
                Else
                    lngasadm = 0
                End If

            Catch ex As Exception
                Response.Write("<script language='javascript'>alert('error al obtener seguros')</script>")

            End Try

            'fin ahorros
            '     lntotal = utilNumeros.Redondear(Double.Parse(Me.txtmorcap.Text) + Double.Parse(Me.txtintere.Text) + Double.Parse(Me.txtintmor.Text), 2).ToString
            lnmonpag = utilNumeros.Redondear(lnmorcap + lnintere + lnintmor + lnsegdeu + lnsegdan + lntalona + lnreserva, 2)

            lnprima = clsaplica.pnprima
            lncosdir = clsaplica.pncosdir
            lncosind = clsaplica.pncosind
            lnsubcidio = clsaplica.pnsubcidio
            lcprima = clsaplica.pnprima
            lccosdir = clsaplica.pncosdir
            lccosind = clsaplica.pncosind
            lcsubcidio = clsaplica.pnsubcidio

        End If


            '*******************************************************
            'finaliza cargar datos *****************************



            '        Dim ldfecproval As Date
            '        ldfecproval = Date.Parse(Me.TXTFECPRO.Text)

            '***************** inicia proceso de impresion **********************
            '********************************************************************

            '        Try
            '       If ds Is Nothing Then
            '       Me.AsignarMensaje("Error al obtener informacion del reporte", True)
            '       Return
            '       Else
            '           If ds.Tables(0).Rows.Count = 0 Then
            '       Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
            '       Return
            '           End If
            '       End If
            '       Catch ex As Exception
            '       Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            '       Return
            '       End Try

            '      Dim crRpt As New ReportDocument
            '      Dim rptStream As New System.IO.MemoryStream

            '     Try
            'Cargar Definicion del Reporte
            '     crRpt.Load(Server.MapPath("reportes") + "\crestcta.rpt", OpenReportMethod.OpenReportByDefault)
            '     Catch ex As Exception
            '        Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            '        Return
            '       End Try

            '        crRpt.SetDataSource(ds.Tables(0))
            '        crRpt.SetParameterValue("nmoracap", lnmorcap)
            '        crRpt.SetParameterValue("nsalcap", lnsalcap)
            '        crRpt.SetParameterValue("nsalint", lnintere)
            '       crRpt.SetParameterValue("nsalmor", lnintmor)
            '       crRpt.SetParameterValue("nsegdeu", lnsegdeu)
            '       crRpt.SetParameterValue("nsegdan", lnsegdan)
            '       crRpt.SetParameterValue("nreserva", lnreserva)
            '       crRpt.SetParameterValue("ntalona", lntalona)
            '       crRpt.SetParameterValue("ngasadm", lngasadm)
            '       crRpt.SetParameterValue("ndiaatr", lndiasatr)
            '       crRpt.SetParameterValue("dultpag", ldultpag)
            '       crRpt.SetParameterValue("dfecsis", ldfecproval)
            '       crRpt.SetParameterValue("ntotal", lnmonpag)
            '       crRpt.SetParameterValue("dfecvig", ldfecvig)

            '        crRpt.SetParameterValue("cnomcli", Me.txtnomcli.Text.Trim)
            '        crRpt.SetParameterValue("cnomusu", Me.txtnomana.Text.Trim)
            '        crRpt.SetParameterValue("NCOSDIR", lccosdir)
            '        crRpt.SetParameterValue("NCOSIND", lccosind)
            '        crRpt.SetParameterValue("NPRIMA", lcprima)
            '        crRpt.SetParameterValue("agencia", Me.txtagencia.Text)

            '       crRpt.SetParameterValue("numcasa", lcnumcasa)
            '       crRpt.SetParameterValue("ccodcli", Me.txtcodcli.Text)

            '        crRpt.SetParameterValue("ncappag", lncappag)
            '        crRpt.SetParameterValue("ntotpag", lntotpag)
            '        crRpt.SetParameterValue("linea", Me.txtlinea.Text)
            '        crRpt.SetParameterValue("direccion", Me.txtdireccion.Text)

            '       rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
            '        Response.Clear()
            '      Response.Buffer = True
            ' Establece el tipo de documento
            '      Response.ContentType = "application/pdf"
            '      Response.BinaryWrite(rptStream.ToArray())
            '      Response.End()
            '  Try
            imprimir(ds, lnmorcap, lnsalcap, lnintere, lnintmor, lnsegdeu, lnsegdan, lnreserva, lntalona, lngasadm, lndiasatr, ldultpag, lnmonpag, ldfecvig, lncosdir, lncosind, lcprima, lcnumcasa, lncappag, lntotpag)
            ' Catch ex As Exception
            '    Response.Write("<script language='javascript'>alert('error de impresion')</script>")
            '   End Try

            '       Catch ex As Exception
            '      Response.Write("<script language='javascript'>alert('no es posible entrar al estado de cuenta')</script>")
            '     End Try

    End Sub



End Class


