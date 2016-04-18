Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class wbsaldo
    Inherits ucWBase


#Region "Privadas"
    Private codigoJs As String
#End Region

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
        Me.calfecval.SelectedDate = Session("gdfecsis")

        Me.btnprocesar.Disabled = False
        Me.btnimprimir.Disabled = True
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        viewstate.Add("pccodcta", codigoCliente)
        '        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
        Me.aplicar()
    End Sub

    Sub aplicar()
        'cremcre
        Dim entidad1 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad1.ccodcta = viewstate("pccodcta")
        ecreditos.Obtenercreditos(entidad1)
        Me.txtnomcli.Text = entidad1.cnomcli
        Me.txtccodcli.Text = entidad1.ccodcli

    End Sub

    Private Sub calfecval_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calfecval.SelectionChanged

    End Sub

    Private Sub Button5_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnprocesar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocesar.ServerClick
        Dim ecreditos As New ccreditos
        Dim lnsaldo As Double = 0
        Dim lccodcta As String
        Dim ldfecval As Date
        Dim lntotal As Double
        Dim lndeuda As Double
        Dim ok As Integer
        Dim lccodins As String
        Dim lccodofi As String
        Dim clsaplica As New SIM.bl.payment

        Dim ldfec30 As Date
        Dim lncapdeu30, lntotal30 As Double
        Dim ldfec60 As Date
        Dim lncapdeu60, lntotal60 As Double

        Try
            lccodins = Me.ddlcodins.SelectedItem.Value.Trim
            lccodofi = Me.ddlcodofi.SelectedItem.Value.Trim
            lccodcta = viewstate("pccodcta")
            If Me.txtcnrocta.Text.Trim = Nothing Then
                '                Response.Write("<script language='javascript'>alert('Cuenta vacía')</script>")
                codigoJs = "<script language='javascript'>alert('Cuenta vacía, " & _
                                                "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                Return
            End If
            ldfecval = Me.calfecval.SelectedDate
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
                'Response.Write("<script language='javascript'>alert('Crédito Cancelado')</script>")
                codigoJs = "<script language='javascript'>alert('Crédito Cancelado, " & _
                                                "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

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
                Me.txtdeucap.Text = utilNumeros.Redondear(clsaplica.pndeucap2, 2).ToString
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

                'If lccodlin.Substring(8, 2) = "06" Then
                '    lncomision = 0
                'Else
                '    If ldfecvig > #11/1/2005# Then
                '        lncomision = utilNumeros.Redondear((lncapdes * (Session("gncomtra") / 100) * lndias) / Session("gnperbas"), 2)
                '    Else
                '        lncomision = 0
                '    End If

                'End If
                'If lsegdeu = True Then
                '    lnsegdeu = (lncapdes * Session("gnSegVm") / 31) * lndias
                'Else
                '    lnsegdeu = 0
                'End If
                'lnsegdeu = utilNumeros.Redondear(lnsegdeu, 2)
                Dim lniva As Decimal = 0
                Dim lniva1 As Decimal = 0
                Dim lniva2 As Decimal = 0
                Dim lniva3 As Decimal = 0


                'lndias = DateDiff(DateInterval.Day, ldultpag, ldfecval)
                lndias = DateDiff(DateInterval.Day, ldultfecha, ldfecval)
                lncomision = 0

                lnsegdeu = clsppal.CalcularSeguroDeuda(lccodcta, ldfecval, Math.Round((clsaplica.pncapdes - clsaplica.pncappag), 2), clsaplica.pdfecvig)
                lncomision = clsppal.CalcularManejo(lccodcta, ldfecval, clsaplica.pncapdes, False)
                'lniva = clsppal.CalcularIVAManejo(Session("gnIVA"), lnmanejo)
                lniva1 = clsppal.CalcularIVAManejo(Session("gnIVA"), lncomision)
                lniva2 = clsppal.CalcularIVAManejo(Session("gnIVA"), clsaplica.pnsalint)
                lniva3 = clsppal.CalcularIVAManejo(Session("gnIVA"), clsaplica.pnsalmor)
                lniva = lniva1 + lniva2 + lniva3

                
                '---------------------------------------------------------



                lntotcom = lncomision + lnsegdeu
                Me.txtnseguro.Text = lnsegdeu
                Me.txtcomisiones.Text = lncomision
                Me.txtiva.Text = lniva
                '--------------------------------------------------------->>>>

                lntotal = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text) + Double.Parse(Me.txtiva.Text), 2).ToString
                Me.txttotal.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text) + Double.Parse(Me.txtiva.Text), 2).ToString
                Me.txttotal.Text = lntotal
                Dim lntotalaldia As Double
                lntotalaldia = utilNumeros.Redondear(Double.Parse(Me.txtdeucap.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text) + Double.Parse(Me.txtiva.Text), 2).ToString
                Me.txtaldia.Text = lntotalaldia

                'Procede a Calculo de 1-30 dias
                Dim lnsalteo30 As Double = 0
                ldfec30 = ldfecval.AddDays(-30)
                'clsaplica.pdfecval = ldfec30
                'clsaplica.pcestado = "F"
                lnsalteo30 = ecreditos.DeudaProyectada(lccodcta, ldfec30)
                If lnsalteo30 = 0 Then
                    lncapdeu30 = 0
                Else
                    lncapdeu30 = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))
                End If

                '                ok = clsaplica.omcalcinterest
                '               If ok = 1 Then
                'lncapdeu30 = utilNumeros.Redondear(clsaplica.pndeucap, 2)

                lntotal30 = Math.Round(Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text) + Double.Parse(Me.txtiva.Text), 2).ToString
                Me.txt30.Text = lncapdeu30
                Me.txtmon30.Text = lntotal30 + lncapdeu30
                '          End If

                'Procede a Calculo de 31-60 dias
                Dim lnsalteo60 As Double = 0
                ldfec60 = ldfecval.AddDays(-60)
                lnsalteo60 = ecreditos.DeudaProyectada(lccodcta, ldfec60)
                'clsaplica.pdfecval = ldfec60
                If lnsalteo60 = 0 Then
                    lncapdeu60 = 0
                Else
                    lncapdeu60 = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))

                End If


                'ok = clsaplica.omcalcinterest
                'If ok = 1 Then
                '   lncapdeu60 = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                lntotal60 = Math.Round(Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text) + Double.Parse(Me.txtiva.Text), 2).ToString
                Me.txt60.Text = lncapdeu60
                Me.txtmon60.Text = lntotal60 + lncapdeu60
                'End If

            Else
                'Response.Write("<script language='javascript'>alert('Cuenta no tiene movimientos')</script>")
                codigoJs = "<script language='javascript'>alert('Cuenta no tiene movimientos, " & _
                                                "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            End If
            
        Catch ex As Exception
            'Response.Write("<script language='javascript'>alert('Problemas con cadena de conexión')</script>")
            codigoJs = "<script language='javascript'>alert('Problemas con cadena de conexión, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        End Try

        Me.btnimprimir.Disabled = False
    End Sub

    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.ServerClick
        Me.txtcapita.Text = " "
        Me.txtinteres.Text = " "
        Me.txtmora.Text = " "
        Me.txttotal.Text = " "
        Me.txtcnrocta.Text = " "
        Me.txtnomcli.Text = " "
        Me.txtmoncuo.Text = " "
        Me.txtdias.Text = " "
        Me.txtcomisiones.Text = " "
        Me.txtnseguro.Text = " "
        Me.txtdeucap.Text = " "

        Me.txtmon30.Text = " "
        Me.txtmon60.Text = " "
        Me.txtdultpag.Text = " "
        Me.txtaldia.Text = " "

        Me.btnprocesar.Disabled = False
        Me.btnimprimir.Disabled = True
    End Sub

    Private Sub btnimprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.ServerClick
        '-----------------------------------------'
        Dim ldfecval As Date

        ldfecval = Me.calfecval.SelectedDate
        Dim ecreditos As New ccreditos
        Dim nciclo As Integer
        nciclo = ecreditos.ciclo(Me.txtccodcli.Text.Trim, viewstate("pccodcta"))

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crConsal.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.Refresh()

        crRpt.SetParameterValue("pcnomcli", Me.txtnomcli.Text.Trim)
        crRpt.SetParameterValue("pdfecval", ldfecval)
        crRpt.SetParameterValue("pccodcta", viewstate("pccodcta"))
        crRpt.SetParameterValue("pccodcli", Me.txtccodcli.Text.Trim)
        crRpt.SetParameterValue("pncuota", Double.Parse(Me.txtmoncuo.Text))
        crRpt.SetParameterValue("pndias", Integer.Parse(Me.txtdias.Text))

        crRpt.SetParameterValue("pnaldia", Double.Parse(Me.txtaldia.Text))
        crRpt.SetParameterValue("pncapita", Double.Parse(Me.txtdeucap.Text))

        crRpt.SetParameterValue("pn30dias", Double.Parse(Me.txtmon30.Text))
        crRpt.SetParameterValue("pn30cap", Double.Parse(Me.txt30.Text))

        crRpt.SetParameterValue("pn60dias", Double.Parse(Me.txtmon60.Text))
        crRpt.SetParameterValue("pn60cap", Double.Parse(Me.txt60.Text))

        crRpt.SetParameterValue("pninteres", Double.Parse(Me.txtinteres.Text))
        crRpt.SetParameterValue("pnintmor", Double.Parse(Me.txtmora.Text))

        crRpt.SetParameterValue("pnseguro", Double.Parse(Me.txtnseguro.Text))
        crRpt.SetParameterValue("pncomision", Double.Parse(Me.txtcomisiones.Text))

        crRpt.SetParameterValue("pnsalcap", Double.Parse(Me.txtcapita.Text))
        crRpt.SetParameterValue("pntotal", Double.Parse(Me.txttotal.Text))
        crRpt.SetParameterValue("pnciclo", nciclo)

        crRpt.SetParameterValue("pniva", Double.Parse(Me.txtiva.Text))

        Dim reportes As String
        reportes = "crConsal.pdf"

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

        Me.btnimprimir.Disabled = True
    End Sub
End Class


