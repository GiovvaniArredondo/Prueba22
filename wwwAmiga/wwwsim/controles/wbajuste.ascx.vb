Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class wbajuste
    Inherits ucWBase
    Private clsConvert As New SIM.BL.ConversionLetras
    Dim cls1 As New SIM.BL.pagdesver
    Dim clsppal As New SIM.BL.class1


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            cargarcombos()
        End If
    End Sub
    Private Sub cargarcombos()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi

        Dim mlistainstitu As New listatabttab
        Dim mlistaoficina As New listatabtofi

        mlistainstitu = clstabttab.ObtenerLista("054", "1")
        mlistaoficina = clstabtofi.ObtenerListaporNivel(Session("gnNivel"), Session("gcCodOfi"))

        'carga instituciones
        Me.ddlcodins.DataTextField = "cdescri"
        Me.ddlcodins.DataValueField = "ccodigo"
        Me.ddlcodins.DataSource = mlistainstitu
        Me.ddlcodins.DataBind()
        'carga oficinas
        Me.ddlcodofi.DataTextField = "cnomofi"
        Me.ddlcodofi.DataValueField = "ccodofi"
        Me.ddlcodofi.DataSource = mlistaoficina
        Me.ddlcodofi.DataBind()

        'Me.btnprocesar.Disabled = False
        Me.Button3.Enabled = False
        Me.txtfecval2.Text = Session("GDFECSIS")

        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0

        Me.Button2.Enabled = True
        Me.Button3.Enabled = False

        HiddenField4.Value = ""
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        ViewState.Add("pccodcta", codigoCliente)
        '        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
        HiddenField4.Value = ""
        Me.aplicar()
    End Sub

    Sub aplicar()
        'cremcre
        Dim entidad1 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad1.ccodcta = ViewState("pccodcta")
        ecreditos.Obtenercreditos(entidad1)
        Me.txtnomcli.Text = entidad1.cnomcli
        Me.txtccodcli.Text = entidad1.ccodcli
        txtncappag.Text = entidad1.ncappag
        TextBox6.Text = "20210101"
        CargarCuenta(TextBox6.Text.Trim)
        Me.Calcular()
        CargaCuentas()
    End Sub



    Private Sub Button5_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Calcular()
        Dim ecreditos As New ccreditos
        Dim lnsaldo As Double = 0
        Dim lccodcta As String
        Dim ldfecval As Date
        Dim lntotal As Double
        Dim lndeuda As Double
        Dim ok As Integer
        Dim lccodins As String
        Dim lccodofi As String
        Dim clsaplica As New SIM.BL.payment

        Dim ldfec30 As Date
        Dim lncapdeu30, lntotal30 As Double
        Dim ldfec60 As Date
        Dim lncapdeu60, lntotal60 As Double

        Try
            lccodins = Me.ddlcodins.SelectedItem.Value.Trim
            lccodofi = Me.ddlcodofi.SelectedItem.Value.Trim
            lccodcta = ViewState("pccodcta")
            If Me.txtcnrocta.Text.Trim = Nothing Then
                Response.Write("<script language='javascript'>alert('Cuenta vacía')</script>")
                Return
            End If
            ldfecval = Date.Parse(Me.txtfecval2.Text)
            clsaplica.pccodcta = lccodcta
            clsaplica.pdfecval = ldfecval
            clsaplica.gdfecsis = Session("gdfecsis")
            clsaplica.gnperbas = Session("gnperbas")
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "F"
            Dim clsppal As New class1
            Dim lncuota As Double
            clsppal.gnperbas = Session("gnperbas")
            clsppal.pnComtra = Session("gnComTra")
            clsppal.pnSegVm = Session("gnSegVm")

            lncuota = clsppal.ValorCuota(lccodcta)
            Me.txtmoncuo.Text = lncuota

            ok = clsaplica.omcalcinterest("T", ldfecval)
            If ok = 9 Then
                Response.Write("<script language='javascript'>alert('Crédito Cancelado')</script>")
                Exit Try
            End If
            If ok = 1 Then
                Me.txtinteres.Text = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                Me.txtmora.Text = utilNumeros.Redondear(clsaplica.pnsalmor, 2)
                Me.txtcapita.Text = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
                lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
                Me.txtdultpag.Text = clsaplica.pdultpag
                Me.txtdias.Text = utilNumeros.Redondear(clsaplica.pndiaatr, 0).ToString
                '                Me.txtmoncuo.Text = utilNumeros.Redondear(clsaplica.pnmoncuo, 2).ToString
                Me.txtdeucap.Text = utilNumeros.Redondear(clsaplica.pndeucap, 2).ToString
                txtncappag.Text = clsaplica.pncappag
                'Calcula comisiones y seguro
                'Calculo de la comision por tramite ----------------->>>>
                Dim ecretlin As New cretlin
                Dim mcretlin As New cCretlin
                Dim lcnrolin As String


                Dim lncomision, lncapdes, lnsegdeu, lngasadm, lntotcom As Double
                Dim ldfecvig As Date
                Dim lccodlin As String
                Dim lndias As Integer
                Dim lsegdeu As Boolean

                lncapdes = clsaplica.pncapdes
                ldfecvig = clsaplica.pdfecvig

                lcnrolin = clsaplica.cnrolin
                ecretlin.cnrolin = lcnrolin
                mcretlin.ObtenerCretlin(ecretlin)
                lsegdeu = ecretlin.lsegdeu
                lccodlin = ecretlin.ccodlin

                Dim ecredkar As New cCredkar
                Dim ldultfecha As Date
                ldultfecha = ecredkar.UltimafechaProceso(lccodcta.Trim, ldfecval)
                lndias = ldfecval.ToOADate - ldultfecha.ToOADate

                If lccodlin.Substring(8, 2) = "06" Then
                    lncomision = 0
                Else
                    If ldfecvig > #11/1/2005# Then
                        lncomision = utilNumeros.Redondear((lncapdes * (Session("gncomtra") / 100) * lndias) / Session("gnperbas"), 2)
                    Else
                        lncomision = 0
                    End If

                End If
                If lsegdeu = True Then
                    lnsegdeu = (lncapdes * Session("gnSegVm") / 31) * lndias
                Else
                    lnsegdeu = 0
                End If
                lnsegdeu = utilNumeros.Redondear(lnsegdeu, 2)

                lntotcom = lncomision + lnsegdeu
                'Me.txtnseguro.Text = lnsegdeu
                'Me.txtcomisiones.Text = lncomision
                '--------------------------------------------------------->>>>

                lntotal = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text), 2).ToString
                Me.txttotal.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text), 2).ToString
                Me.txttotal.Text = lntotal
                Dim lntotalaldia As Double
                lntotalaldia = utilNumeros.Redondear(Double.Parse(Me.txtdeucap.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text), 2).ToString
                ' Me.txtaldia.Text = lntotalaldia

                'Procede a Calculo de 1-30 dias
                Dim lnsalteo30 As Double = 0
                ldfec30 = ldfecval.AddDays(-30)
                'clsaplica.pdfecval = ldfec30
                'clsaplica.pcestado = "F"


                lnsalteo30 = ecreditos.DeudaProyectada(lccodcta, ldfec30)
                lncapdeu30 = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))

                '                ok = clsaplica.omcalcinterest
                '               If ok = 1 Then
                'lncapdeu30 = utilNumeros.Redondear(clsaplica.pndeucap, 2)

                lntotal30 = Math.Round(Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text), 2).ToString
                Me.txt30.Text = lncapdeu30
                'Me.txtmon30.Text = lntotal30 + lncapdeu30
                '          End If

                'Procede a Calculo de 31-60 dias
                Dim lnsalteo60 As Double = 0
                ldfec60 = ldfecval.AddDays(-60)
                'clsaplica.pdfecval = ldfec60
                lnsalteo60 = ecreditos.DeudaProyectada(lccodcta, ldfec60)
                lncapdeu60 = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))

                'ok = clsaplica.omcalcinterest
                'If ok = 1 Then
                '   lncapdeu60 = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                lntotal60 = Math.Round(Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text), 2).ToString
                Me.txt60.Text = lncapdeu60
                Me.txtmon60.Text = lntotal60 + lncapdeu60
                'End If

            Else
                Response.Write("<script language='javascript'>alert('Cuenta no tiene movimientos')</script>")
            End If
        Catch
            Response.Write("<script language='javascript'>alert('Problemas con cadena de conexión')</script>")
        End Try

        Me.Button3.Enabled = True

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Calcular()
    End Sub

    Protected Sub TextBox6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim lnvalida As Integer
        lnvalida = Me.validador
        If lnvalida = 0 Then
            Me.Label20.Text = "Cuenta No Existe"
            Me.Button2.Enabled = False
            Exit Sub
        Else
            Me.Label20.Text = " "
            Me.Button2.Enabled = True
        End If

        Me.CargarCuenta(Me.TextBox6.Text.Trim)
    End Sub
    Public Sub CargarCuenta(ByVal codigoCliente As String)
        Dim ectbmcta As New cCtbmcta
        Dim ds As New DataSet
        ds = ectbmcta.ObtenerDescripcionPorCuenta(codigoCliente.Trim, Session("gcfondo"))
        If ds.Tables(0).Rows.Count = 0 Then
            Me.Label20.Text = ""
            '            Response.Write("<script language='javascript'>alert('Cuenta Contable No Existe')</script>")
        Else
            Me.Label20.Text = ds.Tables(0).Rows(0)("cdescrip")

        End If
    End Sub
    Private Function validador()
        Dim ectbmcta As New cCtbmcta
        Dim lnvalida As Integer
        lnvalida = ectbmcta.ValidarCuenta(Me.TextBox6.Text.Trim)
        Return lnvalida
    End Function

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        '-----------------------------------------'
        Dim ldfecval As Date
        Dim lcnomcli As String = txtnomcli.Text.Trim
        Dim lccodcli As String = Me.txtccodcli.Text.Trim
        ldfecval = Date.Parse(Me.txtfecval2.Text)
        Dim ecreditos As New ccreditos
        Dim nciclo As Integer
        nciclo = ecreditos.ciclo(Me.txtccodcli.Text.Trim, ViewState("pccodcta"))

        Dim lcletras As String = Me.txtcletras.Text
        Dim lcnomofi As String = ""
        Dim etabtofi As New cTabtofi

        Dim lcglosa As String = Me.TextBox5.Text.Trim

        lcnomofi = etabtofi.NombreAgencia(Session("gcCodofi"))

        Dim ds As New DataSet
        Dim ecredkar As New cCredkar
        ds = ecredkar.RecuperarAjuste(ViewState("pccodcta"), Session("gdfecsis"), Me.TextBox4.Text.Trim)

        Dim lncapaju As Double = 0

        Dim lcctacap As String = ""

        Dim lnintaju As Double = 0
        Dim lcctaint As String = ""

        Dim lnmoraju As Double = 0
        Dim lcctamor As String = ""

        Dim lncajaju As Double = 0
        Dim lcctacaja As String = ""
        Dim lcctain As String = ""
        Dim lcctamo As String = ""

        Dim lctipo As String = IIf(RadioButton1.Checked = True, "C", "D")
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            Dim fila As DataRow
            Dim i As Integer = 0
            Dim lcconcep As String = ""
            For Each fila In ds.Tables(0).Rows
                lcconcep = ds.Tables(0).Rows(i)("cConcep")
                If lcconcep.Trim = "KP" Then
                    lncapaju = ds.Tables(0).Rows(i)("nmonto")
                    lcctacap = ds.Tables(0).Rows(i)("cCodctb")
                ElseIf lcconcep.Trim = "IN" Then
                    lnintaju = ds.Tables(0).Rows(i)("nmonto")
                    lcctaint = ds.Tables(0).Rows(i)("cCodctb")
                ElseIf lcconcep.Trim = "MO" Then
                    lnmoraju = ds.Tables(0).Rows(i)("nmonto")
                    lcctamor = ds.Tables(0).Rows(i)("cCodctb")
                ElseIf lcconcep.Trim = "CJ" Then
                    lncajaju = ds.Tables(0).Rows(i)("nmonto")
                End If

                i += 1
            Next

        End If


        lcctacaja = HiddenField1.Value.Trim
        lcctain = HiddenField2.Value.Trim
        lcctamo = HiddenField3.Value.Trim


        Dim dspartida As New DataSet
        Dim ectbmcta As New cCtbmcta
        dspartida = ectbmcta.ObtenerDataSetEsp9(HiddenField4.Value.Trim, "99", "")

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream




        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crAjuste.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dspartida.Tables(0))
        crRpt.Refresh()

        'crRpt.SetDataSource(ds.Tables(0))
        crRpt.SetParameterValue("dfecval", ldfecval)
        crRpt.SetParameterValue("cletras", lcletras)
        crRpt.SetParameterValue("cnomofi", lcnomofi)
        crRpt.SetParameterValue("cglosa", lcglosa)
        crRpt.SetParameterValue("cnomcli", lcnomcli)
        crRpt.SetParameterValue("ccodcta", ViewState("pccodcta"))
        crRpt.SetParameterValue("ccodcli", lccodcli)


        crRpt.SetParameterValue("ncapaju", lncapaju)
        crRpt.SetParameterValue("cctacap", lcctacap)

        crRpt.SetParameterValue("nintaju", lnintaju)
        crRpt.SetParameterValue("cctaint", lcctaint)

        crRpt.SetParameterValue("nmoraju", lnmoraju)
        crRpt.SetParameterValue("cctamor", lcctamor)

        crRpt.SetParameterValue("ncajaju", lncajaju)
        crRpt.SetParameterValue("cctacaja", lcctacaja)
        crRpt.SetParameterValue("cctain", lcctain)
        crRpt.SetParameterValue("cctamo", lcctamo)

        crRpt.SetParameterValue("tipo", lctipo)
        crRpt.SetParameterValue("cnomcta", Label20.Text.Trim)

        Dim reportes As String
        reportes = "crAjuste.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()

        Me.Button3.Enabled = False

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim lncapaju As Double = 0
        Dim lnintaju As Double = 0
        Dim lnmoraju As Double = 0

        Dim lntotgen As Double = 0

        lncapaju = Double.Parse(Me.TextBox1.Text)
        lnintaju = Double.Parse(Me.TextBox2.Text)
        lnmoraju = Double.Parse(Me.TextBox3.Text)


        If Me.RadioButton1.Checked = True Then 'Nota de crédito
            lncapaju = lncapaju * (-1)
            lnintaju = lnintaju * (-1)
            lnmoraju = lnmoraju * (-1)
        Else 'Nota de Débito
            If Math.Round(lncapaju, 2) > Math.Round(Double.Parse(txtcapita.Text), 2) Then
                Response.Write("<script language='javascript'>alert('Ajuste de Capital Mayor al Saldo, Incorrecto')</script>")
                Exit Sub
            End If

            If Math.Round(lnintaju, 2) > Math.Round(Double.Parse(txtinteres.Text), 2) Then
                Response.Write("<script language='javascript'>alert('Ajuste de Interes Mayor al Saldo, Incorrecto')</script>")
                Exit Sub
            End If

            If Math.Round(lnmoraju, 2) > Math.Round(Double.Parse(txtmora.Text), 2) Then
                Response.Write("<script language='javascript'>alert('Ajuste de Mora Mayor al Saldo, Incorrecto')</script>")
                Exit Sub
            End If

        End If

        lntotgen = Math.Round((lncapaju + lnintaju + lnmoraju), 2)

        Dim lnDecimal As Double = 0
        Dim lcletras As String = ""
        lcletras = clsConvert.ConversionEnteros(Math.Abs(lntotgen))
        lnDecimal = clsConvert.ExtraeDecimales(Math.Abs(lntotgen).ToString)
        lcletras = lcletras.Trim & " " & lnDecimal.ToString & "/100"

        txtcletras.Text = lcletras
        cls1.pccodcta = ViewState("pccodcta")
        cls1.pncapita = lncapaju
        cls1.pnsalint = lnintaju
        cls1.pnsalmor = lnmoraju
        cls1.pncomision = 0
        cls1.pnhonorarios = 0
        cls1.pngestion = 0
        cls1.pnmonpag = lntotgen
        cls1.pdfecval = Date.Parse(Me.txtfecval2.Text)
        cls1.pndeucap = Double.Parse(Me.txtdeucap.Text)
        cls1.pcbanco = ""
        cls1.pctippag = "P"
        cls1.pcnuming = "AJUSTE"
        cls1.pcnuming0 = Me.TextBox4.Text.Trim

        cls1.gdfecsis = Session("gdfecsis")
        cls1.gccodusu = Session("gccodusu")
        cls1.ahosim = 0
        cls1.ahovis = 0
        cls1.aporta = 0
        cls1.segdeu = 0
        cls1.manejo = 0

        cls1.pnintpag = 0
        cls1.pnintpen = 0
        cls1.pnintcal = 0
        cls1.pnmorpag = 0
        cls1.pnpagcta = 0
        cls1.pnintmor = 0
        cls1.pdultpag = Date.Parse(Me.txtdultpag.Text)
        cls1.pncappag = (Double.Parse(Me.txtncappag.Text)) 'viewstate("pncappag1")
        cls1.pccodcli = Me.txtccodcli.Text
        cls1.pndiaatr = Me.txtdias.Text
        cls1.pcCuentaAj = HiddenField1.Value.Trim
        cls1.pcCuentaAj2 = HiddenField2.Value.Trim
        cls1.pcCuentaAj3 = HiddenField3.Value.Trim

        cls1.lsolidario = False
        HiddenField4.Value = cls1.mxdistributeAjuste(IIf(RadioButton1.Checked = True, "C", "D"))
        Dim ldfecha As Date
        ldfecha = Session("gdfecsis")
        Dim clspagos1 As New clspagos

        Me.Button2.Enabled = False
        Me.Button3.Enabled = True

        'dsimprimepagos = clskardex.ObtenerDataSetPorID2(lccodcta, ldfecha, "C", lccomprobante, " ")
        Response.Write("<script language='javascript'>alert('Ajuste Aplicado, Imprima Recibo')</script>")



    End Sub
    Private Sub CargaCuentas()
        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak
        Dim busquedaplantilla As Integer

        entidadtabtmak.ccodigo = "CAJKP"
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            HiddenField1.Value = "*"
        Else
            HiddenField1.Value = entidadtabtmak.cplanti.Trim
        End If
        entidadtabtmak.ccodigo = "CAJIN"
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            HiddenField2.Value = "*"
        Else
            HiddenField2.Value = entidadtabtmak.cplanti.Trim
        End If
        entidadtabtmak.ccodigo = "CAJMO"
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            HiddenField3.Value = "*"
        Else
            HiddenField3.Value = entidadtabtmak.cplanti.Trim
        End If
    End Sub
End Class


