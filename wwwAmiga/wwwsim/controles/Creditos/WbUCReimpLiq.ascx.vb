Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Imports System.Data
Imports System.Data.SqlClient

Partial Class controles_Creditos_WbUCReimpLiq
    Inherits ucWBase

#Region "Privadas"
    Private Shared asociado As String
    Private entidadcremcre As New cremcre
    Private mcremcre As New cCremcre
    Private entidadcretlin As New cretlin
    Private mcretlin As New cCretlin
    Private codigoJs As String = ""
    Private omclass As New cClimide
    Private omahomcta As New cAhomcta
    Private clsConvert As New ConversionLetras
#End Region

#Region "Metodos"
    Public Sub Limpia_Pagina()
        '    Me.MtvPrinci.SetActiveView(ViewFind)
        Me.TxtcEvalua.Text = ""
        Me.Txtcnudoci.Text = ""
        Me.TxtcCodcli.Text = ""
        Me.TxtcEvalua.Enabled = True
        Me.Txtclinea.Text = ""
        Me.Txtcnrodoc.Text = ""
        Me.Txtdfecven.Text = ""
        Me.Txtdfecvig.Text = ""
        Me.Txtncapdes.Text = "0.00"
        Me.Txtncuota.Text = "0.00"
        Me.Txtnplazo.Text = ""
        'Me.CbxTipTran.SelectedValue = "00"
    End Sub

    Private Sub Buscar()

        Dim ds As New DataSet
        Dim letra As Char = Left(Me.TxtcEvalua.Text.Trim, 1)
        Dim pntipo As Integer = 2

        If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or _
           letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
            pntipo = 1
        End If

        ds = omclass.Buscar_Socio_ID("%" + Me.TxtcEvalua.Text.Trim + "%")

        GridViewDatos.DataSource = ds
        GridViewDatos.DataBind()

    End Sub

    Private Sub Cargagrid(ByVal ccodcli As String)

        Dim nombre As String
        'Dim ds As DataSet
        Dim clsfind As New ccreditos
        Dim lcestado As String
        'Dim lctipo As String
        Dim lcbusq As String
        Dim lcmetodologia As String
        'Dim filacre As DataRow
        Dim i As Integer
        nombre = ccodcli 'Me.TxtNombre.Text.Trim
        lcestado = " "
        'lctipo = Me.rdbbusqueda.SelectedValue
        lcbusq = "Todos" 'Me.rdbbusqueda2.SelectedValue
        lcmetodologia = "Cliente" 'Me.rdbbusqueda3.SelectedValue


        If lcbusq = "Proceso de Solicitud" Then
            lcbusq = "1"
        ElseIf lcbusq = "Proceso de Sugerencia" Then
            lcbusq = "2"
        ElseIf lcbusq = "Proceso de Autorización" Then
            lcbusq = "3"
        ElseIf lcbusq = "Vigentes" Then
            lcbusq = "4"
        ElseIf lcbusq = "Todos" Then
            lcbusq = "5"
        ElseIf lcbusq = "Proceso de Pre-Autorizados" Then
            lcbusq = "6"
        ElseIf lcbusq = "Cancelados" Then
            lcbusq = "7"
        End If


        lcmetodologia = "1"
        Me.busquedaindividual(ccodcli)

    End Sub
    Private Sub busquedaindividual(ByVal ccodcli As String)

        Dim nombre As String
        Dim ds As DataSet
        Dim clsfind As New ccreditos
        Dim lcestado As String
        Dim lctipo As String
        Dim lcbusq As String
        Dim lcmetodologia As String
        Dim filacre As DataRow
        Dim i As Integer
        nombre = ccodcli 'Me.TxtNombre.Text.Trim
        lcestado = " "
        lctipo = "" 'Me.rdbbusqueda.SelectedValue
        'lcbusq = "0" 'Me.rdbbusqueda2.SelectedValue
        lcbusq = Session("gcstatus")
        lcmetodologia = "Cliente" 'Me.rdbbusqueda3.SelectedValue

        If lctipo = "Por Nombre" Then
            lctipo = "1"
        ElseIf lctipo = "Por Código" Then
            lctipo = "2"
        Else
            lctipo = "3"
        End If

        'If lcbusq = "Proceso de Solicitud" Then
        '    lcbusq = "1"
        'ElseIf lcbusq = "Proceso de Sugerencia" Then
        '    lcbusq = "2"
        'ElseIf lcbusq = "Proceso de Autorización" Then
        '    lcbusq = "3"
        'ElseIf lcbusq = "Vigentes" Then
        '    lcbusq = "4"
        'ElseIf lcbusq = "Todos" Then
        '    lcbusq = "5"
        'ElseIf lcbusq = "Proceso de Pre-Autorizado" Then
        '    lcbusq = "6"
        'ElseIf lcbusq = "Cancelados" Then
        '    lcbusq = "7"
        'End If

        If lcmetodologia = "Cliente" Then
            lcmetodologia = "1"
        End If

        ds = clsfind.Obtenerbusquedacreditos(nombre, lcestado, lctipo, lcbusq, lcmetodologia, "01", Session("gcCodofi"))
        i = 0
        Dim lccodrec As String



        For Each filacre In ds.Tables(0).Rows
            lccodrec = IIf(IsDBNull(filacre("ccodrec")), "", filacre("ccodrec"))
            If lccodrec.Trim = "" Then
                If filacre("cestado") = "F" Then
                    ds.Tables(0).Rows(i)("cestado") = "VIGENTE"

                ElseIf filacre("cestado") = "A" Then
                    ds.Tables(0).Rows(i)("cestado") = "Solicitud"
                ElseIf filacre("cestado") = "C" Then
                    ds.Tables(0).Rows(i)("cestado") = "Sugerido"
                ElseIf filacre("cestado") = "D" Then
                    ds.Tables(0).Rows(i)("cestado") = "Pre-Autorizado"
                ElseIf filacre("cestado") = "E" Then
                    ds.Tables(0).Rows(i)("cestado") = "Autorizado"
                ElseIf filacre("cestado") = "G" Then
                    ds.Tables(0).Rows(i)("cestado") = "Cancelado"
                Else
                    ds.Tables(0).Rows(i)("cestado") = "Otro"
                End If

            Else
                ds.Tables(0).Rows(i)("cestado") = "Rechazado"
            End If
            i = i + 1
        Next
        'If ds.Tables(0).Rows.Count = 0 Then
        '    Me.cuentas_GridView.DataSource = ""
        'Else
        '    Me.cuentas_GridView.DataSource = ds
        'End If

        GridViewCreditos.DataSource = ds
        GridViewCreditos.DataBind()
        '        cuentas_GridView.Visible = True


    End Sub

    Private Sub Imprimir_Liquidacion()
        Dim ecreditos As New ccreditos
        Dim etabttab As New cTabttab
        Dim ecntamov As New cCntamov
        Dim dsdeudas As New DataSet
        Dim lcnumcom As String = ""
        Dim lcnumcom2 As String = ""
        Dim lcCodvista As String = ""
        Dim pcTipGarant As String = ""
        Dim lcdecimal As String
        Dim lntamano As Integer = 0
        Dim lndeposito_vista As Double = 0
        Dim n As Integer = 0
        'Dim i As Integer = 1
        Dim etabtofi As New tabtofi
        Dim mtabtofi As New cTabtofi
        Dim lcNomOfi As String = ""

        etabtofi.ccodofi = Txtccodcta.Text.Trim.Substring(3, 3)
        mtabtofi.ObtenerTabtofi(etabtofi)
        lcNomOfi = etabtofi.cnomofi

        'If Me.cmbAhorro.Items.Count > 0 Then
        lcCodvista = Me.TxtcctaVista.Text.Trim
        'End If


        'dsdeudas = GeneraDatasetdeGrids()
        'Extra cancelación de Prestamos si existieren
        Dim dt_cancela As New DataTable
        Dim omcancela As New cCremRef


        'Extra Refinanciamiento

        dt_cancela = omcancela.Extra_Detalle_Cancelaciones(Me.Txtccodcta.Text.Trim, Date.Parse(Me.Txtdfecvig.Text))
        'dsdeudas = GeneraDatasetdeGrids()

        Dim pcRef1 As String = ""
        Dim pcRef2 As String = ""
        Dim pcRef3 As String = ""
        Dim pcRef4 As String = ""
        Dim pnsaldoRef1 As Double = 0
        Dim pnsaldoRef2 As Double = 0
        Dim pnsaldoRef3 As Double = 0
        Dim pnsaldoRef4 As Double = 0
        Dim pnsalintRef1 As Double = 0
        Dim pnsalintRef2 As Double = 0
        Dim pnsalintRef3 As Double = 0
        Dim pnsalintRef4 As Double = 0
        Dim pnsalmorRef1 As Double = 0
        Dim pnsalmorRef2 As Double = 0
        Dim pnsalmorRef3 As Double = 0
        Dim pnsalmorRef4 As Double = 0
        Dim pnfondoRef1 As Double = 0
        Dim pnfondoRef2 As Double = 0
        Dim pnfondoRef3 As Double = 0
        Dim pnfondoRef4 As Double = 0
        Dim pnTotalRef1 As Double = 0
        Dim pnTotalRef2 As Double = 0
        Dim pnTotalRef3 As Double = 0
        Dim pnTotalRef4 As Double = 0
        Dim i As Integer = 1


        For Each Linea As DataRow In dt_cancela.Rows
            Select Case i
                Case 1
                    pcRef1 = Linea("cCodcta")
                    pnsaldoRef1 = Linea("nsalcap")
                    pnsalintRef1 = Linea("nsalint")
                    pnsalmorRef1 = Linea("nsalmor")
                    pnfondoRef1 = Linea("nseguro")
                    pnTotalRef1 = Linea("ntotal")
                Case 2
                    pcRef2 = Linea("cCodcta")
                    pnsaldoRef2 = Linea("nsalcap")
                    pnsalintRef2 = Linea("nsalint")
                    pnsalmorRef2 = Linea("nsalmor")
                    pnfondoRef2 = Linea("nseguro")
                    pnTotalRef2 = Linea("ntotal")
                Case 3
                    pcRef3 = Linea("cCodcta")
                    pnsaldoRef3 = Linea("nsalcap")
                    pnsalintRef3 = Linea("nsalint")
                    pnsalmorRef3 = Linea("nsalmor")
                    pnfondoRef3 = Linea("nseguro")
                    pnTotalRef3 = Linea("ntotal")
                Case 4
                    pcRef4 = Linea("cCodcta")
                    pnsaldoRef4 = Linea("nsalcap")
                    pnsalintRef4 = Linea("nsalint")
                    pnsalmorRef4 = Linea("nsalmor")
                    pnfondoRef4 = Linea("nseguro")
                    pnTotalRef4 = Linea("ntotal")
            End Select

            i += 1
        Next


        Dim ds As New DataSet
        Dim ds_valida As New DataSet
        'Primero verifica si existe gastos, si no es un DEUDOR

        ds_valida = ecreditos.ObtenerGastos(Me.Txtccodcta.Text.Trim, Me.Txtcnrodoc.Text.Trim)

        ds = ecreditos.ObtenerLiquidacion(Me.Txtccodcta.Text.Trim, Me.Txtcnrodoc.Text.Trim, Session("GNIVA"))

        i = 1

        'If ds.Tables("Gastos").Rows.Count = 0 Then
        '    codigoJs = "<script language='javascript'>alert('No Existen Gastos, " & _
        '                 "Advertencia SIM.NET ')</script>"

        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
        '    Exit Sub
        'End If

        For Each fila As DataRow In ds.Tables("Garantias").Rows
            If i = 1 Then
                pcTipGarant = fila("cdesgarantia")
            ElseIf i > 1 Then
                pcTipGarant = pcTipGarant + "," + fila("cdesgarantia")
            End If

            i += 1
        Next


        'Unir los dos grid con los totales
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CrLiquidacion.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        'crRpt.SetDataSource(dsdeudas.Tables(0))
        crRpt.SetDataSource(ds.Tables("Gastos_Fin"))
        crRpt.Refresh()
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        Dim lccodcta As String = ""
        Dim lccodcli As String = ""
        Dim lcnomcli As String = ""
        Dim ldfecvig As Date
        Dim ldfecven As Date
        Dim lcdeslin As String = ""
        Dim lncuoapr As Integer = 0
        Dim lncapdes As Double = 0
        Dim lnmonapr As Double = 0
        Dim lcnomusu As String = ""
        Dim lnsegvida As Double = 0
        Dim lnahosim As Double = 0
        Dim lnaporta As Double = 0
        Dim lnautnot As Double = 0
        Dim lnivaaut As Double = 0
        Dim lndertra As Double = 0
        Dim lnivader As Double = 0
        Dim lncomision As Double = 0
        Dim lnpricuota As Double = 0
        Dim lnhipoteca As Double = 0
        Dim lnivahip As Double = 0
        Dim lnderreg As Double = 0
        Dim lnsegdeuda As Double = 0
        Dim lnPROTEGE As Double = 0
        Dim lnahoedu As Double = 0
        Dim lnmongra As Double = 0
        Dim lnmoncuo As Double = 0
        Dim lnivacomision As Double = 0

        Dim lcctaapor As String = ""
        Dim lcctasimul As String = ""
        Dim lcctavista As String = ""
        Dim lcfrecint As String = "M"
        Dim lcfrecuencia As String = ""
        Dim lnmeses As Integer = 0
        Dim lcgarantia As String = ""
        Dim ecrepgar As New cCrepgar
        Dim lncapoto As Double = 0
        Dim A_NomChq As New ArrayList
        Dim A_NroChq As New ArrayList
        Dim A_MonChq As New ArrayList
        Dim lnTotChq As Double = 0

        'Inicializa Arreglos
        A_NomChq.Add("")
        A_NomChq.Add("")
        A_NomChq.Add("")
        A_NomChq.Add("")
        A_NomChq.Add("")
        A_NomChq.Add("")
        A_NomChq.Add("")
        A_NomChq.Add("")

        A_NroChq.Add("")
        A_NroChq.Add("")
        A_NroChq.Add("")
        A_NroChq.Add("")
        A_NroChq.Add("")
        A_NroChq.Add("")
        A_NroChq.Add("")
        A_NroChq.Add("")

        A_MonChq.Add(0)
        A_MonChq.Add(0)
        A_MonChq.Add(0)
        A_MonChq.Add(0)
        A_MonChq.Add(0)
        A_MonChq.Add(0)
        A_MonChq.Add(0)
        A_MonChq.Add(0)

        i = 1

        'Cargara Hasta 8 Cheques de ser necesario
        For Each fila As DataRow In ds.Tables("Cheques").Rows

            Select Case i
                Case 1
                    A_NomChq.Item(0) = fila("cnombre")
                    A_NroChq.Item(0) = fila("cnrochq")
                    A_MonChq.Item(0) = fila("nmonto")

                Case 2
                    A_NomChq.Item(1) = fila("cnombre")
                    A_NroChq.Item(1) = fila("cnrochq")
                    A_MonChq.Item(1) = fila("nmonto")

                Case 3
                    A_NomChq.Item(2) = fila("cnombre")
                    A_NroChq.Item(2) = fila("cnrochq")
                    A_MonChq.Item(2) = fila("nmonto")

                Case 4
                    A_NomChq.Item(3) = fila("cnombre")
                    A_NroChq.Item(3) = fila("cnrochq")
                    A_MonChq.Item(3) = fila("nmonto")

                Case 5
                    A_NomChq.Item(4) = fila("cnombre")
                    A_NroChq.Item(4) = fila("cnrochq")
                    A_MonChq.Item(4) = fila("nmonto")

                Case 6
                    A_NomChq.Item(5) = fila("cnombre")
                    A_NroChq.Item(5) = fila("cnrochq")
                    A_MonChq.Item(5) = fila("nmonto")

                Case 7
                    A_NomChq.Item(6) = fila("cnombre")
                    A_NroChq.Item(6) = fila("cnrochq")
                    A_MonChq.Item(6) = fila("nmonto")

                Case 8
                    A_NomChq.Item(7) = fila("cnombre")
                    A_NroChq.Item(7) = fila("cnrochq")
                    A_MonChq.Item(7) = fila("nmonto")

            End Select


            i += 1
        Next


        If Not IsDBNull(ds.Tables("Cheques").Compute("sum(nmonto)", "")) Then
            lnTotChq = ds.Tables("Cheques").Compute("sum(nmonto)", "")
        End If


        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lccodcta = Me.Txtccodcta.Text.Trim
            lccodcli = ds.Tables(0).Rows(0)("ccodcli")
            lcnomcli = ds.Tables(0).Rows(0)("cnomcli")
            ldfecvig = ds.Tables(0).Rows(0)("dfecvig")
            ldfecven = ds.Tables(0).Rows(0)("dfecven")
            lcdeslin = ds.Tables(0).Rows(0)("cdeslin")
            lncuoapr = ds.Tables(0).Rows(0)("ncuoapr")
            lncapdes = ds.Tables(0).Rows(0)("ncapdes")
            lnmonapr = ds.Tables(0).Rows(0)("nmonapr")
            lcnomusu = ds.Tables(0).Rows(0)("cnomusu")

            lnmongra = ds.Tables(0).Rows(0)("nmongra")
            lnmoncuo = ds.Tables(0).Rows(0)("nmoncuo")
            lcctaapor = ds.Tables(0).Rows(0)("cctaapor")
            lcctasimul = ds.Tables(0).Rows(0)("cctasimul")
            lcctavista = ds.Tables(0).Rows(0)("cctavista")
            lcfrecint = ds.Tables(0).Rows(0)("cfrecint")
            lcfrecuencia = etabttab.Describe(lcfrecint, "060")
            lnmeses = DateDiff(DateInterval.Month, ldfecvig, ldfecven)
            lncapoto = Double.Parse(Txtncapdes.Text) 'Double.Parse(TxtCapita.Text)

            lcgarantia = ecrepgar.ObtenerGarantiaComprometida(Txtccodcta.Text.Trim)
            lcnumcom = ecntamov.ObtieneNumeroPartidaporCredito(Txtccodcta.Text.Trim, ldfecvig)
            lcnumcom2 = "" 'txtcnumcom2.Text
            lndeposito_vista = 0 'omahomcta.Extraer_Movi_Dep_Cta_Ahorro_Desembolso(lcCodvista, Date.Parse(Me.Txtdfecvig.Text))


            crRpt.SetParameterValue("pccodcta", lccodcta)
            crRpt.SetParameterValue("pccodcli", lccodcli)
            crRpt.SetParameterValue("pcnomcli", lcnomcli)
            crRpt.SetParameterValue("pdfecvig", ldfecvig)
            crRpt.SetParameterValue("pdfecven", ldfecven)
            crRpt.SetParameterValue("pcdeslin", lcdeslin)
            crRpt.SetParameterValue("pncuoapr", lncuoapr)
            crRpt.SetParameterValue("pncapdes", lncapdes)
            crRpt.SetParameterValue("pnmonapr", lnmonapr)
            crRpt.SetParameterValue("pcnomusu", lcnomusu)

            crRpt.SetParameterValue("pnmongra", lnmongra)
            crRpt.SetParameterValue("pnmoncuo", lnmoncuo)
            crRpt.SetParameterValue("pcctavista", lcCodvista)
            crRpt.SetParameterValue("pcctaapor", lcctaapor)
            crRpt.SetParameterValue("pcctasimul", lcctasimul)
            crRpt.SetParameterValue("pcfrecuencia", lcfrecuencia)
            crRpt.SetParameterValue("pcmeses", ("(" + lnmeses.ToString + " Meses)"))
            crRpt.SetParameterValue("pcgarantia", lcgarantia)
            crRpt.SetParameterValue("pcnumcom", lcnumcom)
            crRpt.SetParameterValue("pncapoto", lncapoto)
            crRpt.SetParameterValue("pcnumcom2", lcnumcom2)
            crRpt.SetParameterValue("pnAhoVista", lndeposito_vista) 'Double.Parse(Me.TextBox30.Text))



            'Agregando 8 Cheques como maximo
            crRpt.SetParameterValue("pcnomchq1", A_NomChq.Item(0))
            crRpt.SetParameterValue("pcnomchq2", A_NomChq.Item(1))
            crRpt.SetParameterValue("pcnomchq3", A_NomChq.Item(2))
            crRpt.SetParameterValue("pcnomchq4", A_NomChq.Item(3))
            crRpt.SetParameterValue("pcnomchq5", A_NomChq.Item(4))
            crRpt.SetParameterValue("pcnomchq6", A_NomChq.Item(5))
            crRpt.SetParameterValue("pcnomchq7", A_NomChq.Item(6))
            crRpt.SetParameterValue("pcnomchq8", A_NomChq.Item(7))

            crRpt.SetParameterValue("pcnrochq1", A_NroChq.Item(0))
            crRpt.SetParameterValue("pcnrochq2", A_NroChq.Item(1))
            crRpt.SetParameterValue("pcnrochq3", A_NroChq.Item(2))
            crRpt.SetParameterValue("pcnrochq4", A_NroChq.Item(3))
            crRpt.SetParameterValue("pcnrochq5", A_NroChq.Item(4))
            crRpt.SetParameterValue("pcnrochq6", A_NroChq.Item(5))
            crRpt.SetParameterValue("pcnrochq7", A_NroChq.Item(6))
            crRpt.SetParameterValue("pcnrochq8", A_NroChq.Item(7))

            crRpt.SetParameterValue("pnMonchq1", A_MonChq.Item(0))
            crRpt.SetParameterValue("pnMonchq2", A_MonChq.Item(1))
            crRpt.SetParameterValue("pnMonchq3", A_MonChq.Item(2))
            crRpt.SetParameterValue("pnMonchq4", A_MonChq.Item(3))
            crRpt.SetParameterValue("pnMonchq5", A_MonChq.Item(4))
            crRpt.SetParameterValue("pnMonchq6", A_MonChq.Item(5))
            crRpt.SetParameterValue("pnMonchq7", A_MonChq.Item(6))
            crRpt.SetParameterValue("pnMonchq8", A_MonChq.Item(7))
            crRpt.SetParameterValue("pnTotchq", lnTotChq)
            crRpt.SetParameterValue("pcTipGarant", pcTipGarant)
            crRpt.SetParameterValue("pcNomOfi", lcNomOfi)

            'Nuevas Variables
            crRpt.SetParameterValue("pcRef1", pcRef1)
            crRpt.SetParameterValue("pcRef2", pcRef2)
            crRpt.SetParameterValue("pcRef3", pcRef3)
            crRpt.SetParameterValue("pcRef4", pcRef4)
            crRpt.SetParameterValue("pnsaldoRef1", pnsaldoRef1)
            crRpt.SetParameterValue("pnsaldoRef2", pnsaldoRef2)
            crRpt.SetParameterValue("pnsaldoRef3", pnsaldoRef3)
            crRpt.SetParameterValue("pnsaldoRef4", pnsaldoRef4)
            crRpt.SetParameterValue("pnsalintRef1", pnsalintRef1)
            crRpt.SetParameterValue("pnsalintRef2", pnsalintRef2)
            crRpt.SetParameterValue("pnsalintRef3", pnsalintRef3)
            crRpt.SetParameterValue("pnsalintRef4", pnsalintRef4)
            crRpt.SetParameterValue("pnsalmorRef1", pnsalmorRef1)
            crRpt.SetParameterValue("pnsalmorRef2", pnsalmorRef2)
            crRpt.SetParameterValue("pnsalmorRef3", pnsalmorRef3)
            crRpt.SetParameterValue("pnsalmorRef4", pnsalmorRef4)
            crRpt.SetParameterValue("pnfondoRef1", pnfondoRef1)
            crRpt.SetParameterValue("pnfondoRef2", pnfondoRef2)
            crRpt.SetParameterValue("pnfondoRef3", pnfondoRef3)
            crRpt.SetParameterValue("pnfondoRef4", pnfondoRef4)
            crRpt.SetParameterValue("pnTotalRef1", pnTotalRef1)
            crRpt.SetParameterValue("pnTotalRef2", pnTotalRef2)
            crRpt.SetParameterValue("pnTotalRef3", pnTotalRef3)
            crRpt.SetParameterValue("pnTotalRef4", pnTotalRef4)


            Dim lcmonlet As String = " "
            Dim lcletras As String = ""
            Dim lndecimal As Integer = 0
            Dim lnvalor As Decimal = 0

            lnvalor = Format(Math.Round(lncapoto, 2), "#########.00")

            lcletras = ConversionLetras.ConversionEnteros(lnvalor)
            lndecimal = clsConvert.ExtraeDecimales(lnvalor)


            'Convertira a 2 digitos los decimales
            lcdecimal = lndecimal.ToString.Trim
            lntamano = lcdecimal.Length
            For n = 1 To 2 - lntamano
                lcdecimal = "0" + lcdecimal
            Next n


            lcletras = lcletras.Trim & " " & lcdecimal.Trim & "/100" & " PESOS"

            crRpt.SetParameterValue("pcletras", lcletras)
        End If



        Dim reportes As String
        reportes = "CrLiquidacion.pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True


        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()
    End Sub



    Private Sub imprimir_Factura(ByVal reportes As String)
        Dim lnCantidad As Double = 0
        Dim ecreditos As New ccreditos
        Dim pnMongas As Double = 0

        Dim vacia As Double = 0
        'Dim eregistrocaja As New cRegistroCaja
        Dim clsConvert As New ConversionLetras
        'Obtener Registro a Imprimir

        Dim ds As New DataSet
        Dim ds_valida As New DataSet
        'ds = eregistrocaja.ObtenerIngresosxllave(Date.Parse(txtdfecha.Text), ddlcajero.SelectedValue.Trim, "I", TextBox5.Text.Trim)

        'ds = ViewState("Dataset")



        'Realiza busqueda de Gastos en el Desembolso
        ds_valida = ecreditos.ObtenerGastos(Me.Txtccodcta.Text.Trim, Me.Txtcnrodoc.Text.Trim)

        If Not IsDBNull(ds_valida.Tables(0).Compute("sum(nmongas)", "")) Then
            pnMongas = ds_valida.Tables(0).Compute("sum(nmongas)", "")
        End If


        ds = ecreditos.ObtenerLiquidacion(Me.Txtccodcta.Text.Trim, Me.Txtcnrodoc.Text.Trim, Session("GNIVA1"))



 
        ' Nombre de usuario
        Dim mUsuarios As New cusuarios
        Dim nomusu As String = ""
        nomusu = mUsuarios.NombreUsuario(Session("gccodusu"))

        Dim lccanlet As String
        Dim lndecimal As Double
        Dim lcCantidad As String

        lnCantidad = Double.Parse(Me.Txtncapdes.Text) - pnMongas
        lcCantidad = Format(Math.Round(lnCantidad, 2), "$###,###,###.00").ToString.Trim

        lccanlet = ConversionLetras.ConversionEnteros(lncantidad)
        lndecimal = clsConvert.ExtraeDecimales(lncantidad)

        Dim lcdecimal As String
        Dim lntamano As Integer

        'Convertira a 2 digitos los decimales
        lcdecimal = lndecimal.ToString.Trim
        lntamano = lcdecimal.Length
        For n = 1 To 2 - lntamano
            lcdecimal = "0" + lcdecimal
        Next n


        lccanlet = "******" + lccanlet.Trim & " PESOS " & lcdecimal.ToString & "/100 M.N." + "******"

        'Formateando IFE a 20 digitos
        Dim lcIFE As String = Me.TxtcIFE.Text.Trim

        lntamano = lcIFE.Length
        For n = 1 To 20 - lntamano
            lcIFE = lcIFE + "0"
        Next n


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(ds.Tables(0))
        crRpt.SetParameterValue("cant1", 0)
        crRpt.SetParameterValue("cant2", 0)
        crRpt.SetParameterValue("cant3", 0)
        crRpt.SetParameterValue("cant4", 0)
        crRpt.SetParameterValue("vacia", vacia)
        crRpt.SetParameterValue("cnomcli", Me.Txtctitular.Text.Trim)
        crRpt.SetParameterValue("csocia", Me.TxtcCodcli.Text.Trim)
        crRpt.SetParameterValue("pcCodpres", Me.Txtccodcta.Text.Trim)
        crRpt.SetParameterValue("cCanlet", lccanlet)
        'crRpt.SetParameterValue("ccodusu", Session("gcCodusu"))
        crRpt.SetParameterValue("cnomusu", nomusu)
        crRpt.SetParameterValue("pdfecsis", CDate(Session("gdfecsis")))
        crRpt.SetParameterValue("pdfecval", Date.Parse(Me.Txtdfecvig.Text))
        crRpt.SetParameterValue("pccantidad", lcCantidad)
        crRpt.SetParameterValue("pcIFE", lcIFE)



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

#End Region

    Protected Sub GridViewDatos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridViewDatos.PageIndexChanging
        GridViewDatos.PageIndex = e.NewPageIndex
        Call Buscar()
    End Sub

    Protected Sub GridViewDatos_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridViewDatos.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not GridViewDatos.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = GridViewDatos.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(GridViewDatos.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = GridViewDatos.PageIndex + 1
        End If
    End Sub


    Protected Sub paginasDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim oIraPag As DropDownList = DirectCast(sender, DropDownList)
        Dim iNumPag As Integer = 0
        If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= GridViewDatos.PageCount Then
            If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= GridViewDatos.PageCount Then
                GridViewDatos.PageIndex = iNumPag - 1
            Else
                GridViewDatos.PageIndex = 0
            End If
        End If
        Call Buscar()
    End Sub

    Protected Sub GridViewDatos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewDatos.SelectedIndexChanged
        asociado = GridViewDatos.SelectedRow.Cells(1).Text.ToString 'asociado
        GridViewCreditos.Visible = True
        Cargagrid(asociado)
    End Sub

    Protected Sub GridViewCreditos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewCreditos.SelectedIndexChanged
        Me.TxtcCodcli.Text = GridViewDatos.SelectedRow.Cells(1).Text.ToString 'asociado
        Me.Txtctitular.Text = GridViewDatos.SelectedRow.Cells(2).Text.ToString 'Nombre Asociado
        Me.Txtctitular.Text = Me.Txtctitular.Text.Trim.Replace("&#209;", "Ñ")
        Me.Txtcnudoci.Text = GridViewDatos.SelectedRow.Cells(3).Text.ToString 'Documento Asociado
        Me.TxtcIFE.Text = GridViewDatos.SelectedRow.Cells(4).Text.ToString 'IFE

        Me.Txtccodcta.Text = GridViewCreditos.SelectedRow.Cells(1).Text.ToString() 'Codigo de Préstamo
        Me.Txtncapdes.Text = GridViewCreditos.SelectedRow.Cells(2).Text.ToString() 'Monto de Apertura

        entidadcremcre.ccodcta = Me.Txtccodcta.Text
        mcremcre.ObtenerCremcre(entidadcremcre)

        Me.Txtdfecvig.Text = entidadcremcre.dfecvig     'Fecha de Apertura
        Me.Txtnplazo.Text = entidadcremcre.nmeses       'Plazo en Meses
        Me.Txtncuota.Text = entidadcremcre.nmoncuo      'Monto de la Cuota
        Me.Txtdfecven.Text = entidadcremcre.dfecven     'Fecha de Vencimiento
        'Me.TxtcctaVista.Text = entidadcremcre.cctavista 'Cuenta a la Vista

        entidadcretlin.cnrolin = entidadcremcre.cnrolin
        mcretlin.ObtenerCretlin(entidadcretlin)

        Me.Txtclinea.Text = entidadcretlin.cdeslin      'Descripcion de Linea de Crédito

        Dim ecredkar As New cCredkar
        Dim lcnrodoc As String
        lcnrodoc = ecredkar.ObtenercnrodocmaxDes(Me.Txtccodcta.Text.Trim)

        Me.Txtcnrodoc.Text = lcnrodoc

        Me.CbxTipTran.SelectedValue = "00"
        Me.MtvPrinci.SetActiveView(ViewLiquidacion)
    End Sub

    Protected Sub CbxTipTran_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxTipTran.SelectedIndexChanged
        Select Case CbxTipTran.SelectedValue.Trim
            Case "01"
                GridViewDatos.Visible = False
                GridViewCreditos.Visible = False
                Me.MtvPrinci.SetActiveView(ViewFind)
        End Select
    End Sub

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

        Dim ds As New DataSet
        Dim letra As Char = Left(Me.TxtcEvalua.Text.Trim, 1)
        Dim pntipo As Integer = 2

        If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or _
           letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
            pntipo = 1
        End If

        ds = omclass.Buscar_Socio_ID("%" + Me.TxtcEvalua.Text.Trim + "%")

        Me.btnImprime.Enabled = True
        Me.btnImprime1.Enabled = True
        Me.Txtcnofact.Enabled = True

        GridViewDatos.DataSource = ds
        GridViewDatos.DataBind()
        GridViewDatos.Visible = True

    End Sub

    Protected Sub btnImprime_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        Imprimir_Liquidacion()
    End Sub

    Protected Sub btnImprime1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprime1.Click
        imprimir_Factura("crFac_Desemb.rpt")
    End Sub

    Protected Sub Txtncapdes_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtncapdes.TextChanged

    End Sub
End Class
