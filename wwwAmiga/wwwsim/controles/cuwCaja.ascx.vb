Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class cuwCaja
    Inherits ucWBase
    Dim ecredkar As New cCredkar
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then

            cargarvariables()
            Dim ecredkar As New cCredkar
            Dim lprocede As Boolean

            'lngrupo = eusuariogrupo.RetornaGrupo(Session("gccodusu"))

            'If lngrupo = 2 Then
            lprocede = ecredkar.VerificaProcedeCaja(Session("gccodusu"), "A")
            If lprocede = True Then
                btncuadre.Enabled = False
                btnarqueo.Enabled = False
                btnValida.Enabled = False
                Response.Write("<script language='javascript'>alert('Verifique no hay caja abierta')</script>")
                Return
            End If

            btncuadre.Enabled = True
            btnarqueo.Enabled = True
            btnValida.Enabled = True
        End If
    End Sub

    Private Sub cargarvariables()
        txtfecha.Text = Session("gdfecsis")
        moneda_1_TextBox.Text = 0
        moneda_5_TextBox.Text = 0
        moneda_10_TextBox.Text = 0
        moneda_25_TextBox.Text = 0
        moneda_50_TextBox.Text = 0
        moneda_100_TextBox.Text = 0

        moneda_1_TextBox0.Text = 0
        moneda_5_TextBox0.Text = 0
        moneda_10_TextBox0.Text = 0
        moneda_25_TextBox0.Text = 0
        moneda_50_TextBox0.Text = 0
        moneda_100_TextBox0.Text = 0


        billete_1_TextBox.Text = 0
        billete_5_TextBox.Text = 0
        billete_10_TextBox.Text = 0
        billete_20_TextBox.Text = 0
        billete_50_TextBox.Text = 0
        billete_100_TextBox.Text = 0
        billete_200_TextBox.Text = 0

        billete_1_TextBox0.Text = 0
        billete_5_TextBox0.Text = 0
        billete_10_TextBox0.Text = 0
        billete_20_TextBox0.Text = 0
        billete_50_TextBox0.Text = 0
        billete_100_TextBox0.Text = 0
        billete_200_TextBox0.Text = 0

    End Sub
    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        'If esError Then
        '    label_mensaje.CssClass = "MensajeError"
        'Else
        '    label_mensaje.CssClass = "MensajeInformativo"
        'End If
        'label_mensaje.Text = mensaje
    End Sub
    Private Sub GeneraCuentaDinero()
        Try
            Dim dsbase As New DataSet
            Dim lnsalini As Decimal = 0
            Dim lnpago As Decimal = 0, lnegreso As Decimal = 0
            Dim lnsaldo As Decimal = 0
            dsbase = DataCaja()

            For Each fila As DataRow In dsbase.Tables(0).Rows
                lnsalini = fila("nsalini")
                lnpago = lnpago + fila("npago")
                lnegreso = lnegreso + fila("negreso")
            Next
            lnsaldo = Math.Round(lnsalini + lnpago - lnegreso, 2)

           
            calculoArqueo()
            'Graba Arqueo como saldo final
            TrasladaSaldoFinal()
         
            Dim lcmensaje As String = ""
            If lnsaldo <> Decimal.Parse(total.Text) Then
                lcmensaje = "Arqueo No Cuadra con Saldo Final"
            Else
                lcmensaje = "Arqueo Cuadrado"
            End If
            'label_mensaje.Text = lcmensaje
            'label_mensaje.Visible = True


            Dim crRpt As New ReportDocument
            Dim rptStream As New System.IO.MemoryStream

            Try
                'Cargar Definicion del Reporte
                crRpt.Load(Server.MapPath("reportes") + "\crCuentaDinero.rpt", OpenReportMethod.OpenReportByDefault)

            Catch ex As Exception
                Return
            End Try
            'crRpt.SetDataSource(dskardex.Tables(0))
            crRpt.Refresh()

            crRpt.SetParameterValue("m1", Integer.Parse(moneda_1_TextBox.Text))
            crRpt.SetParameterValue("m5", Integer.Parse(moneda_5_TextBox.Text))
            crRpt.SetParameterValue("m10", Integer.Parse(moneda_10_TextBox.Text))
            crRpt.SetParameterValue("m25", Integer.Parse(moneda_25_TextBox.Text))
            crRpt.SetParameterValue("m50", Integer.Parse(moneda_50_TextBox.Text))
            crRpt.SetParameterValue("m100", Integer.Parse(moneda_100_TextBox.Text))

            crRpt.SetParameterValue("b1", Integer.Parse(billete_1_TextBox.Text))
            crRpt.SetParameterValue("b5", Integer.Parse(billete_5_TextBox.Text))
            crRpt.SetParameterValue("b10", Integer.Parse(billete_10_TextBox.Text))
            crRpt.SetParameterValue("b20", Integer.Parse(billete_20_TextBox.Text))
            crRpt.SetParameterValue("b50", Integer.Parse(billete_50_TextBox.Text))
            crRpt.SetParameterValue("b100", Integer.Parse(billete_100_TextBox.Text))
            crRpt.SetParameterValue("b200", Integer.Parse(billete_200_TextBox.Text))

            crRpt.SetParameterValue("dfecha", Date.Parse(txtfecha.Text))
            crRpt.SetParameterValue("pcmensaje", lcmensaje)

            rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)

            'Response.Clear()
            'Response.Buffer = True
            '' Establece el tipo de documento
            'Response.ContentType = "application/pdf"
            'Response.BinaryWrite(rptStream.ToArray())
            Dim reportes As String = ""
            reportes = "Arqueo.pdf"

            Response.Clear()
            Response.Buffer = True
            ' Establece el tipo de documento
            Response.ContentType = "application/pdf"
            Response.BinaryWrite(rptStream.ToArray())
            Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
            Response.End()
            'Response.End()
        Catch ex As Exception

        End Try

    End Sub
   
    Protected Sub btnarqueo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnarqueo.Click
        GeneraCuentaDinero()
    End Sub
    Private Sub Aplicar()
        Dim ldfecdate As Date
        ldfecdate = Date.Parse(txtfecha.Text)


        'Obtiene saldo inicial de turno
        Dim lnsalini As Decimal = 0
        Dim ecredkar As New cCredkar
        lnsalini = ecredkar.ObtieneSaldodeCaja(Session("gcCodusu"), "A")


        'obtiene fecha y hora de apertura
        Dim ldfecdesde As Date
        Dim ldfecini As Date
        Dim lcfecini As String

        ldfecdesde = ecredkar.ObtieneFechayHoraCaja(Session("gccodusu"), "A")
        lcfecini = Left(ldfecdate.ToString.Trim, 10)
        ldfecini = Date.Parse(lcfecini)


        Dim lchoraini As String
        'lchoraini = Format(ldfecdesde.ToString.Substring(11, 12).Replace(".", "").ToUpper, "HH:mm:ss")
        lchoraini = Format(ldfecdesde, "HH:mm:ss")

        'Obtiene fecha y hora actual

        Dim lchora As String = Format(TimeOfDay, "HH:mm:ss")
        'Format(TimeOfDay.ToString.Substring(11, 12).Replace(".", "").ToUpper, "HH:mm:ss")
        'Dim lcfecha As String

        'lcfecha = "#" & Left(ldfecdate.ToString, 10) & "#"

        Dim ldfecha As Date
        ldfecha = ldfecdate 'DateTime.Parse(lcfecha)


        '----------------------------------------
        Dim lcnomusu As String
        Dim dskardex As New DataSet
        'dskardex = ecredkar.ResumenKardex(ldfecdate, Session("gccodusu"))
        dskardex = ecredkar.ResumenKardexdosfechas(Session("gccodusu"), ldfecini, ldfecha, lchoraini, lchora)

        Dim eTabtusu As New cTabtusu
        lcnomusu = eTabtusu.usuario(Session("gccodusu"))

        Dim nelem As Integer = 0
        Dim fila As DataRow
        Dim lctipopago As String
        Dim lncapital As Double = 0
        Dim lnintere As Double = 0
        Dim lnmora As Double = 0
        Dim lnotro As Double = 0
        Dim lnotroing As Double = 0
        Dim lnefectivo As Double = 0
        Dim lnbanco As Double = 0
        Dim lnefectivootr As Double = 0
        Dim lnbancootr As Double = 0
        Dim lntotefe As Double = 0
        Dim lntotban As Double = 0
        Dim lngasadm As Double = 0
        Dim lniva As Double = 0
        Dim lnsegdeu As Double = 0
        Dim lnexced As Double = 0



        Dim lnkp As Double = 0
        Dim lnin As Double = 0
        Dim lnmo As Double = 0
        Dim lnot As Double = 0
        Dim lngas As Double = 0
        Dim lniv As Double = 0
        Dim lnseg As Double = 0
        Dim lnex As Double = 0


        For Each fila In dskardex.Tables(0).Rows
            lctipopago = dskardex.Tables(0).Rows(nelem)("tipopago")
            lnkp = dskardex.Tables(0).Rows(nelem)("ncapita")
            lnin = dskardex.Tables(0).Rows(nelem)("nintere")
            lnmo = dskardex.Tables(0).Rows(nelem)("nmora")
            lngas = dskardex.Tables(0).Rows(nelem)("ngasadm")
            lnseg = dskardex.Tables(0).Rows(nelem)("nsegdeu")
            lniv = dskardex.Tables(0).Rows(nelem)("niva")
            lnex = dskardex.Tables(0).Rows(nelem)("nexced")

            lncapital = lncapital + lnkp
            lnintere = lnintere + lnin
            lnmora = lnmora + lnmo
            lngasadm = lngasadm + lngas
            lniva = lniva + lniv
            lnsegdeu = lnsegdeu + lnseg
            lnexced = lnexced + lnex

            'lnotro = lnotro + lnot
            If lctipopago = "E" Then
                lnefectivo = lnkp + lnin + lnmo + lngas + lnseg + lniv + lnex
                lnefectivootr = lnefectivo
            Else
                lnbanco = lnkp + lnin + lnmo + +lngas + lnseg + lniv + lnex
                lnbancootr = lnbanco
            End If
            nelem += 1
        Next
        Try
            If dskardex Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dskardex.Tables(0).Rows.Count = 0 Then
                    'Me.AsignarMensaje("No se encontro información a ser desplegada")
                    'Return
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\crcaja.rpt", OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try
        'crRpt.SetDataSource(dskardex.Tables(0))
        crRpt.Refresh()

        crRpt.SetParameterValue("pncapital", lncapital)
        crRpt.SetParameterValue("pnintere", lnintere)
        crRpt.SetParameterValue("pnmora", lnmora)
        crRpt.SetParameterValue("pnotro", lnotro)

        crRpt.SetParameterValue("pngasadm", lngasadm)
        crRpt.SetParameterValue("pnsegdeu", lnsegdeu)
        crRpt.SetParameterValue("pniva", lniva)
        crRpt.SetParameterValue("pnexced", lnexced)

        crRpt.SetParameterValue("pnefectivo", lnefectivo)
        crRpt.SetParameterValue("pnbanco", lnbanco)
        crRpt.SetParameterValue("pcnomusu", lcnomusu)
        crRpt.SetParameterValue("pnsalini", lnsalini)

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()

    End Sub

    Protected Sub btncuadre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncuadre.Click
        'Aplicar()
        Detalle("crCuadreCajero.rpt")
    End Sub
    Private Sub Detalle(ByVal Reporte As String)
        Dim dsbase As New DataSet
        dsbase = dataCaja()

        Dim reportes As String = "crCuadreCajero.rpt"
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" + Reporte, OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try


      
        crRpt.SetDataSource(dsbase.Tables(0))
        ' crRpt.SetParameterValue("cNomOfi", lcNomofi)
        ' crRpt.SetParameterValue("dfecha1", ldfecdate)
        ' crRpt.SetParameterValue("dfecha2", ldfecdate)
        ' crRpt.SetParameterValue("ccajeros", Session("gccodusu"))
        ' crRpt.SetParameterValue("nsalini", lnsalini)

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)


        reportes = "Caja.pdf"

        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.End()


    End Sub
    
    Protected Sub btnValida_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnValida.Click
        Detalle("crCierreAgencia.rpt")
    End Sub
    Private Sub TrasladaSaldoFinal()
        'Verifica si ya existe grabado el arqueo del dia
        Dim lverifica As Boolean
        Dim ecredkar As New cCredkar
        lverifica = ecredkar.VerificaExisteArqueo(Session("gccodusu"), Date.Parse(txtfecha.Text))
        If lverifica = True Then 'Se actualiza
            ecredkar.GrabaSaldoArqueo(Session("gccodusu"), Date.Parse(txtfecha.Text), Decimal.Parse(total.Text))
        Else 'Se agrega
            ecredkar.AgregaraCaja(Session("gccodusu"), Decimal.Parse(total.Text), Date.Parse(txtfecha.Text), "Q", "", "", Session("gccodusu"))
        End If

        Response.Write("<script language='javascript'>alert('Se Grabo Saldo de Arqueo')</script>")
    End Sub
    Private Sub calculoArqueo()
        Dim moneda1, moneda1t As Decimal
        Dim moneda5, moneda5t As Decimal
        Dim moneda10, moneda10t As Decimal
        Dim moneda25, moneda25t As Decimal
        Dim moneda50, moneda50t As Decimal
        Dim moneda100, moneda100t As Decimal

        moneda1 = Decimal.Parse(moneda_1_TextBox.Text)
        moneda5 = Decimal.Parse(moneda_5_TextBox.Text)
        moneda10 = Decimal.Parse(moneda_10_TextBox.Text)
        moneda25 = Decimal.Parse(moneda_25_TextBox.Text)
        moneda50 = Decimal.Parse(moneda_50_TextBox.Text)
        moneda100 = Decimal.Parse(moneda_100_TextBox.Text)

        moneda1t = moneda1 * 0.01
        moneda5t = moneda5 * 0.05
        moneda10t = moneda10 * 0.1
        moneda25t = moneda25 * 0.25
        moneda50t = moneda50 * 0.5
        moneda100t = moneda100 * 1

        moneda_1_TextBox0.Text = moneda1t
        moneda_5_TextBox0.Text = moneda5t
        moneda_10_TextBox0.Text = moneda10t
        moneda_25_TextBox0.Text = moneda25t
        moneda_50_TextBox0.Text = moneda50t
        moneda_100_TextBox0.Text = moneda100t

        Dim totalmonedas0 As Decimal = 0
        totalmonedas0 = moneda1t + moneda5t + moneda10t + moneda25t + moneda50t + moneda100t
        totalmonedas.Text = totalmonedas0

        Dim billete1, billete1t As Decimal
        Dim billete5, billete5t As Decimal
        Dim billete10, billete10t As Decimal
        Dim billete20, billete20t As Decimal
        Dim billete50, billete50t As Decimal
        Dim billete100, billete100t As Decimal
        Dim billete200, billete200t As Decimal

        billete1 = Decimal.Parse(billete_1_TextBox.Text)
        billete5 = Decimal.Parse(billete_5_TextBox.Text)
        billete10 = Decimal.Parse(billete_10_TextBox.Text)
        billete20 = Decimal.Parse(billete_20_TextBox.Text)
        billete50 = Decimal.Parse(billete_50_TextBox.Text)
        billete100 = Decimal.Parse(billete_100_TextBox.Text)
        billete200 = Decimal.Parse(billete_200_TextBox.Text)


        billete1t = billete1 * 1
        billete5t = billete5 * 5
        billete10t = billete10 * 10
        billete20t = billete20 * 20
        billete50t = billete50 * 50
        billete100t = billete100 * 100
        billete200t = billete200 * 200

        billete_1_TextBox0.Text = billete1t
        billete_5_TextBox0.Text = billete5t
        billete_10_TextBox0.Text = billete10t
        billete_20_TextBox0.Text = billete20t
        billete_50_TextBox0.Text = billete50t
        billete_100_TextBox0.Text = billete100t
        billete_200_TextBox0.Text = billete200t

        Dim totalbilletes0, total0 As Decimal
        totalbilletes0 = billete1t + billete5t + billete10t + billete20t + billete50t + billete100t + billete200t
        total0 = totalmonedas0 + totalbilletes0

        totalbilletes.Text = totalbilletes0
        total.Text = Math.Round(total0, 2)

    End Sub
    Private Function DataCaja() As DataSet
        Dim dsbase As New DataSet
        Dim M1 As New ccreditos
        Dim ldfecdate As Date
        Dim lccajeros As String
        Dim tipo As String = ""
        ldfecdate = Date.Parse(txtfecha.Text)

        '-----------------------------------------------------------------------

        Dim lnsaldo As Decimal = 0
        Dim lnsalini As Decimal = 0
        lnsalini = ecredkar.Obtener_Saldo_inicial_Cuadre(Session("gccodusu"), Date.Parse(txtfecha.Text))

        '-----------------------------------------------------------------------
        dsbase = M1.DETALLE_CARTERA_Y_PAGOS_CAJA(ldfecdate, ldfecdate, "C", "*", "*", "*", "*", " ", Session("gcCodusu"), "*", "E")

        Dim dr As DataRow
        Dim dsdeposito As New DataSet
        Dim dsope As New DataSet

        dsdeposito = ecredkar.ObtenerDeposito(Session("gccodusu"), ldfecdate, "D")

        For Each fila As DataRow In dsdeposito.Tables(0).Rows
            dr = dsbase.Tables(0).NewRow
            dr("negreso") = fila("nsaldo")
            dr("cnuming") = fila("cnumdoc")
            dr("ccodtrx") = "015"
            dr("cdestrx") = "ENVIO DE EFECTIVO A BANCO"
            dr("cnomcli") = fila("cnombco")
            dr("npago") = 0
            dr("ncapita") = 0
            dr("nintere") = 0
            dr("nmora") = 0
            dr("notros") = 0
            dr("nexced") = 0
            dr("ncontaI") = 0
            dr("ncontaE") = fila("ncontaE")
            dsbase.Tables(0).Rows.Add(dr)
        Next

        dsope = ecredkar.ObtenerDeposito(Session("gccodusu"), ldfecdate, "005")

        For Each fila As DataRow In dsope.Tables(0).Rows
            dr = dsbase.Tables(0).NewRow
            dr("negreso") = 0
            dr("cnuming") = fila("cnumdoc")
            dr("ccodtrx") = "005"
            dr("cdestrx") = "SOBRANTE DE CAJA"
            dr("cnomcli") = fila("cnombco")
            dr("npago") = fila("nsaldo")
            dr("ncapita") = 0
            dr("nintere") = 0
            dr("nmora") = 0
            dr("notros") = 0
            dr("nexced") = 0
            dr("ncontaI") = 0
            dr("ncontaE") = fila("ncontaE")
            dsbase.Tables(0).Rows.Add(dr)
        Next

        dsope.Clear()
        dsope = ecredkar.ObtenerDeposito(Session("gccodusu"), ldfecdate, "016")

        For Each fila As DataRow In dsope.Tables(0).Rows
            dr = dsbase.Tables(0).NewRow
            dr("negreso") = fila("nsaldo")
            dr("cnuming") = fila("cnumdoc")
            dr("ccodtrx") = "016"
            dr("cdestrx") = "FALTANTE DE CAJA"
            dr("cnomcli") = fila("cnombco")
            dr("npago") = 0
            dr("ncapita") = 0
            dr("nintere") = 0
            dr("nmora") = 0
            dr("notros") = 0
            dr("nexced") = 0
            dr("ncontaI") = fila("ncontaI")
            dr("ncontaE") = 0
            dsbase.Tables(0).Rows.Add(dr)
        Next

        dsope.Clear()
        dsope = ecredkar.ObtenerDeposito(Session("gccodusu"), ldfecdate, "003")

        For Each fila As DataRow In dsope.Tables(0).Rows
            dr = dsbase.Tables(0).NewRow
            dr("negreso") = fila("nsaldo")
            dr("cnuming") = fila("cnumdoc")
            dr("ccodtrx") = "003"
            dr("cdestrx") = "REMESAS EN TRANSITO"
            dr("cnomcli") = fila("cnombco")
            dr("npago") = 0
            dr("ncapita") = 0
            dr("nintere") = 0
            dr("nmora") = 0
            dr("notros") = 0
            dr("nexced") = 0
            dr("ncontaI") = fila("ncontaI")
            dr("ncontaE") = 0
            dsbase.Tables(0).Rows.Add(dr)
        Next

        If dsbase.Tables(0).Rows.Count = 0 Then
            dr = dsbase.Tables(0).NewRow
            dr("negreso") = 0
            dr("cnuming") = ""
            dr("ccodtrx") = ""
            dr("cdestrx") = ""
            dr("cnomcli") = ""
            dr("npago") = 0
            dr("ncapita") = 0
            dr("nintere") = 0
            dr("nmora") = 0
            dr("notros") = 0
            dr("nexced") = 0
            dr("ncontaI") = 0
            dr("ncontaE") = 0
            dsbase.Tables(0).Rows.Add(dr)
        End If

        'Nombre de la Institución
        Dim lcNomofi As String = "FUNDEA"
        Dim lcagencia As String = ""
        Dim etabtofi As New cTabtofi
        lcagencia = etabtofi.NombreAgencia(Session("gccodofi"))
        lcNomofi = "FUNDEA-Oficina: " & lcagencia.trim

        For Each fila In dsbase.Tables(0).Rows
            fila("dfecha2") = ldfecdate
            fila("cnomofi") = lcNomofi
            fila("nsalini") = lnsalini
        Next

        Return dsbase
    End Function

    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1
    '    Dim dsbase As New DataSet
    '    Dim lnsalini As Decimal = 0
    '    Dim lnpago As Decimal = 0, lnegreso As Decimal = 0
    '    Dim lnsaldo As Decimal = 0
    '    dsbase = DataCaja()

    '    For Each fila As DataRow In dsbase.Tables(0).Rows
    '        lnsalini = fila("nsalini")
    '        lnpago = lnpago + fila("npago")
    '        lnegreso = lnegreso + fila("negreso")
    '    Next
    '    lnsaldo = Math.Round(lnsalini + lnpago - lnegreso, 2)


    '    calculoArqueo()
    '    'Graba Arqueo como saldo final
    '    TrasladaSaldoFinal()

    '    Dim lcmensaje As String = ""
    '    If lnsaldo <> Decimal.Parse(total.Text) Then
    '        Response.Write("<script language='javascript'>alert('Arqueo No Cuadra con Saldo')</script>")
    '    Else
    '        Response.Write("<script language='javascript'>alert('Arqueo OK ')</script>")
    '    End If

    'End Sub
End Class


