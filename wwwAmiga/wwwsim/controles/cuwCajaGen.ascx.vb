Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class cuwCajaGen
    Inherits ucWBase
    Dim ecredkar As New cCredkar
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            txtfecha.Text = Session("gdfecsis")
        End If
    End Sub

  
    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        'If esError Then
        '    label_mensaje.CssClass = "MensajeError"
        'Else
        '    label_mensaje.CssClass = "MensajeInformativo"
        'End If
        'label_mensaje.Text = mensaje
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
        Detalle("crCuadreCajeroGen.rpt")
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
    
  
  
   
    Private Function DataCaja() As DataSet
        Dim dsofi As New DataSet
        Dim etabtofi As New cTabtofi
        dsofi = etabtofi.ObtenerDataSetPorID()
        Dim dsbase As New DataSet
        Dim M1 As New ccreditos
        Dim ldfecdate As Date
        Dim lccajeros As String
        Dim tipo As String = ""
        ldfecdate = Date.Parse(txtfecha.Text)

        'Nombre de la Institución
        Dim lcNomofi As String = "FUNDEA"
        Dim lcagencia As String = ""

      

        '-----------------------------------------------------------------------
        Dim dsusu As New DataSet
        Dim eusuarios As New cusuarios
        Dim lnsaldo As Decimal = 0
        Dim lnsalini As Decimal = 0

        '------------------------------
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim clsppal As New class1
        Dim ldfecmod As DateTime
        Dim dt As New DataTable
        lcampos1 = "negreso, cnuming,ccodtrx,cdestrx,cnomcli,npago,ncapita,nintere,nmora,notros,nexced,ncontaI,ncontaE,nsalini,dfecha2,cnomofi,ccodofi,ccodusu,cnomusu,nsaldo,cfecmod,"
        ltipos1 = "D,S,S,S,S,D,D,D,D,D,D,D,D,D,F,S,S,S,S,S,S,"
        dt = clsppal.creadatasetdesconec(lcampos1, ltipos1, "CAJA")
        '------------------------------
        dsbase.Tables.Add(dt)


        'Dim lnpagot As Decimal = 0
        'Dim lnegresot As Decimal = 0

        Dim dskardex As New DataSet
        For Each filaofi As DataRow In dsofi.Tables(0).Rows
            'Obtener los cajeros de la oficina
            dsusu = eusuarios.ObtenerCajerosOficina(filaofi("ccodofi"))
            For Each filausu As DataRow In dsusu.Tables(0).Rows
                lnsalini = 0
               
                lnsalini = ecredkar.Obtener_Saldo_inicial_Cuadre(filausu("usuario"), Date.Parse(txtfecha.Text))

                lcagencia = filaofi("cnomofi")
                lcNomofi = "Oficina: " & lcagencia.Trim

                Dim dr As DataRow
                Dim dsdeposito As New DataSet
                Dim dsope As New DataSet
                '-----------------------------------------------------------------------
                dskardex = M1.DETALLE_CARTERA_Y_PAGOS_CAJA(ldfecdate, ldfecdate, "C", "*", "*", "*", "*", " ", filausu("usuario"), "*", "E")
                'Barrer pagos y agregarlos a la tabla
                For Each fila As DataRow In dskardex.Tables(0).Rows
                    ldfecmod = fila("dfecmod")
                    dr = dsbase.Tables(0).NewRow
                    dr("negreso") = 0
                    dr("cnuming") = fila("cnuming")
                    dr("ccodtrx") = "001"
                    dr("cdestrx") = "COBRO DE PRESTAMOS"
                    dr("cnomcli") = fila("cnomcli")
                    dr("npago") = fila("npago")
                    dr("ncapita") = fila("ncapita")
                    dr("nintere") = fila("nintere")
                    dr("nmora") = fila("nmora")
                    dr("notros") = fila("notros")
                    dr("nexced") = fila("NEXCED")
                    dr("ncontaI") = fila("npago")
                    dr("ncontaE") = 0
                    dr("nsalini") = lnsalini
                    dr("dfecha2") = ldfecdate
                    dr("cnomofi") = lcNomofi
                    dr("ccodofi") = filaofi("ccodofi")
                    dr("ccodusu") = filausu("usuario")
                    dr("cnomusu") = filausu("nombre")
                    Try
                        dr("cfecmod") = ldfecmod.ToString.Trim.Substring(11, 12)
                    Catch ex As Exception
                        dr("cfecmod") = ""
                    End Try
                    dsbase.Tables(0).Rows.Add(dr)
                Next

                dsdeposito = ecredkar.ObtenerDeposito(filausu("usuario"), ldfecdate, "D")

                For Each fila As DataRow In dsdeposito.Tables(0).Rows
                    ldfecmod = fila("dfecha")
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
                    dr("nsalini") = lnsalini
                    dr("dfecha2") = ldfecdate
                    dr("cnomofi") = lcNomofi
                    dr("ccodofi") = filaofi("ccodofi")
                    dr("ccodusu") = filausu("usuario")
                    dr("cnomusu") = filausu("nombre")
                    Try
                        dr("cfecmod") = ldfecmod.ToString.Trim.Substring(11, 12)
                    Catch ex As Exception
                        dr("cfecmod") = ""
                    End Try
                    dsbase.Tables(0).Rows.Add(dr)
                Next

                dsope = ecredkar.ObtenerDeposito(filausu("usuario"), ldfecdate, "005")

                For Each fila As DataRow In dsope.Tables(0).Rows
                    ldfecmod = fila("dfecha")
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
                    dr("nsalini") = lnsalini
                    dr("dfecha2") = ldfecdate
                    dr("cnomofi") = lcNomofi
                    dr("ccodofi") = filaofi("ccodofi")
                    dr("ccodusu") = filausu("usuario")
                    dr("cnomusu") = filausu("nombre")
                    Try
                        dr("cfecmod") = ldfecmod.ToString.Trim.Substring(11, 12)
                    Catch ex As Exception
                        dr("cfecmod") = ""
                    End Try
                    dsbase.Tables(0).Rows.Add(dr)
                Next

                dsope.Clear()
                dsope = ecredkar.ObtenerDeposito(filausu("usuario"), ldfecdate, "016")

                For Each fila As DataRow In dsope.Tables(0).Rows
                    ldfecmod = fila("dfecha")
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
                    dr("nsalini") = lnsalini
                    dr("dfecha2") = ldfecdate
                    dr("cnomofi") = lcNomofi
                    dr("ccodofi") = filaofi("ccodofi")
                    dr("ccodusu") = filausu("usuario")
                    dr("cnomusu") = filausu("nombre")
                    Try
                        dr("cfecmod") = ldfecmod.ToString.Trim.Substring(11, 12)
                    Catch ex As Exception
                        dr("cfecmod") = ""
                    End Try
                    dsbase.Tables(0).Rows.Add(dr)
                Next

                dsope.Clear()
                dsope = ecredkar.ObtenerDeposito(filausu("usuario"), ldfecdate, "003")

                For Each fila As DataRow In dsope.Tables(0).Rows
                    ldfecmod = fila("dfecha")
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
                    dr("nsalini") = lnsalini
                    dr("dfecha2") = ldfecdate
                    dr("cnomofi") = lcNomofi
                    dr("ccodofi") = filaofi("ccodofi")
                    dr("ccodusu") = filausu("usuario")
                    dr("cnomusu") = filausu("nombre")
                    Try
                        dr("cfecmod") = ldfecmod.ToString.Trim.Substring(11, 12)
                    Catch ex As Exception
                        dr("cfecmod") = ""
                    End Try
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
                    dr("nsalini") = lnsalini
                    dr("dfecha2") = ldfecdate
                    dr("cnomofi") = lcNomofi
                    dr("ccodofi") = filaofi("ccodofi")
                    dr("ccodusu") = filausu("usuario")
                    dr("cnomusu") = filausu("nombre")
                    dr("cfecmod") = ""
                    dsbase.Tables(0).Rows.Add(dr)
                End If
            Next
        Next

        Return dsbase
    End Function

   
End Class


