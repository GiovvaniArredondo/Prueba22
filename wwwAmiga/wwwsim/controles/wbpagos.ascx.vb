Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.Drawing.Printing

Imports System.Data.SqlClient
Imports System
Imports System.IO

Imports System.Collections.Generic
Imports System.Text
Imports LibPrintTicket
Imports referenciaws
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Collections.Specialized
Imports System.Collections


Partial Class wbpagos
    Inherits ucWBase
    

#Region "Variables"
    Private cls1 As New SIM.BL.pagdesver
    Private clsppal As New SIM.BL.class1
    Private clsConvert As New SIM.BL.ConversionLetras
    Protected WithEvents txtfecval As System.Web.UI.WebControls.TextBox
    Private clsaplica As New SIM.BL.payment
    Private dsimprimepagos As New DataSet
    Private etabtofi As New cTabtofi
    Private claseaditivo As New cClsAditivos
    Private codigoJs As String
#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarCombos()

        End If

    End Sub

    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub

    Private Sub imprime_recibo()
        Try
            If dsimprimepagos Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsimprimepagos.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                    Return
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
            crRpt.Load(Server.MapPath("reportes") + "\crpagos.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsimprimepagos.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()

    End Sub
    Public Sub CargarCombos()
        Me.Label29.Visible = False
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi

        Dim dsc As New DataSet
        Dim dsb As New DataSet
        Dim mListaTabttab As New listatabttab
        Dim mlistainstitu As New listatabttab
        Dim mlistaoficina As New listatabtofi

        Me.reimpresion.Checked = False
        Me.txtcapdes.Text = 0
        Me.txtcapita.Text = 0
        Me.txtcomision.Text = 0
        Me.txthonorarios.Text = 0
        Me.txtmora.Text = 0
        Me.txtsegdeu.Text = 0
        Me.txtmanejo.Text = 0
        txtiva.Text = 0
        Me.txtahosim.Text = 0
        Me.txtaporta.Text = 0
        Me.txtahovis.Text = 0
        Me.txtbandera.Text = 0
        Me.Label29.Text = ""

        mListaTabttab = clstabttab.ObtenerTipodePago(Session("gnNivel"))

        mlistainstitu = clstabttab.ObtenerLista("054", "1")
        mlistaoficina = clstabtofi.ObtenerListaporNivel(Session("gnNivel"), Session("gcCodOfi"))

        Me.cmbtippag.DataTextField = "cdescri"
        Me.cmbtippag.DataValueField = "ccodigo"
        Me.cmbtippag.DataSource = mListaTabttab
        Me.cmbtippag.DataBind()

        Me.cmbtippag.SelectedValue = "E"

        clsbancos.ObtenerDatasetporidtodos(dsb, Session("gcCodofi"), "RE")
        Me.cmbbanco.DataTextField = "cnombco"
        Me.cmbbanco.DataValueField = "ccodbco"
        Me.cmbbanco.DataSource = dsb.Tables(0)
        Me.cmbbanco.DataBind()

        lblbanco.Visible = False
        cmbbanco.Visible = False
        ''carga instituciones
        'Me.ddlcodins.DataTextField = "cdescri"
        'Me.ddlcodins.DataValueField = "ccodigo"
        'Me.ddlcodins.DataSource = mlistainstitu
        'Me.ddlcodins.DataBind()
        ''carga oficinas
        'Me.ddlcodofi.DataTextField = "cnomofi"
        'Me.ddlcodofi.DataValueField = "ccodofi"
        'Me.ddlcodofi.DataSource = mlistaoficina
        'Me.ddlcodofi.DataBind()

        Me.txtfecval2.Text = Session("GDFECSIS")
        Me.btngrabar.EnableViewState = False
        Me.btnaplicar.EnableViewState = True
        'Me.txtcCodOfi.Text = Session("gcCodOfi")
        label_mensaje0.Text = Session("gccodofi")
    End Sub
    Private Sub btnsalir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub cancela()
        Me.txtnrocta.Text = ""
        Me.txtcodcli.Text = ""
        Me.txtnomcli.Text = ""
        Me.txtintere2.Text = 0
        txtncongelado.Text = 0
        txtcapaldia.Text = 0
        txtintere2.Text = 0
        Me.txtgastos.Text = 0
        Me.txtcuota.Text = 0
        Me.txtdiaatr.Text = ""
        Me.txtdeucap.Text = 0
        Me.txtcapita.Text = 0
        Me.txtintere2.Text = 0
        Me.txtcomision.Text = 0
        Me.txtcapdes.Text = 0
        Me.txtdultpag.Text = ""
        Me.txtmoncuo.Text = 0
        Me.txtpagcta.Text = 0
        Me.txtmoncuo.Text = 0
        Me.txtpagcta.Text = 0
        Me.txtdeuefe.Text = 0
        Me.txtmonpag.Text = 0
        Me.txtmora.Text = 0
        Me.txtintere2.Text = 0
        Me.txttotal.Text = 0
        Me.txtgastos.Text = 0
        Me.txtcuota.Text = 0
        Me.txthonorarios.Text = 0
        Me.txtgestion.Text = 0
        Me.txtcomision.Text = 0
        Me.txtsaldo.Text = 0
        Me.txtintere.Text = 0
        Me.txtcompro.Text = ""
        Me.txtcompro0.Text = ""
        Me.txtdeucap.Text = 0
        Me.txtsegdeu.Text = 0
        Me.txtmanejo.Text = 0
        txtiva.Text = 0
        Me.txtahosim.Text = 0
        Me.txtaporta.Text = 0
        Me.txtahovis.Text = 0
        Me.Label29.Text = ""
        Me.Label29.Visible = False
        Me.btngrabar.Enabled = False
        Me.btnaplicar.Disabled = True


    End Sub


    Private Sub cmbtippag_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtippag.SelectedIndexChanged
        If cmbtippag.SelectedItem.Value.Trim = "I" Then
            Dim lnlimcond As Double
            lnlimcond = Math.Round(Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtcomision.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtsegdeu.Text), 2)
            Me.txtmonpag.Text = lnlimcond
        End If

        If cmbtippag.SelectedItem.Value.Trim = "C" Then
            lblbanco.Visible = True
            cmbbanco.Visible = True
        Else
            lblbanco.Visible = False
            cmbbanco.Visible = False

        End If
    End Sub


    'Private Sub Button2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.ServerClick
    '    Response.Redirect("wbfecval.aspx")
    'End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        cancela()
        'VALIDA SI ES CAJERO Y SI TIENE SU CAJA ABIERTA PARA PODER OPERAR PAGOS CAJ=2
        Dim eusuario As New cusuarios
        Dim eusuariogrupo As New cUsuarioGrupo
        Dim lngrupo As Integer
        Dim ds As New DataSet
        Dim ecredkar As New cCredkar
        Dim lprocede As Boolean

        'lngrupo = eusuariogrupo.RetornaGrupo(Session("gccodusu"))

        'If lngrupo = 2 Then
        lprocede = ecredkar.VerificaProcedeCaja(Session("gccodusu"), "A")
        If lprocede = True Then
            '            Response.Write("<script language='javascript'>alert('Verifique no hay caja abierta')</script>")
            codigoJs = "<script language='javascript'>alert('Verifique no hay caja abierta, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            Return
        End If
        'End If
        lprocede = eusuario.ValidaCuentaCajero(Session("gccodusu"))
        If lprocede = False Then
            'Response.Write("<script language='javascript'>alert('Asignar Cuenta Contable al Cajero')</script>")
            codigoJs = "<script language='javascript'>alert('Asignar Cuenta Contable al Cajero, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        Me.txtnrocta.Text = codigoCliente.Trim
        Me.txtcCodOfi.Text = codigoCliente.Substring(3, 3)


        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub


    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick
        aplicar()
    End Sub


    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancela()
    End Sub
    Private Sub CalculaSeg()
        clsppal.pnComtra = Session("gnComTra")
        clsppal.pnSegVm = Session("gnSegVm")

        Dim lccodins As String
        Dim lccodofi As String
        Dim lccodcta As String
        lccodcta = Me.txtnrocta.Text.Trim
        Dim mcremcre As New cCremcre
        Dim ecremcre As New cremcre
        ecremcre.ccodcta = lccodcta
        mcremcre.ObtenerCremcre(ecremcre)
        clsppal.cCodFor = ecremcre.ctipper
        clsppal.nMonDes = ecremcre.ncapdes
        clsppal.nPerDia = ecremcre.ndiasug
        clsppal.fxSegDeu()

    End Sub

    Protected Sub CheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim lncomision As Double
        Dim lnhonorarios As Double
        Dim lngestion As Double
        Dim lnmonpag As Double
        Dim ldfecval As Date
        Dim lccodcta As String
        Dim lncapita As Double
        Dim lnintere As Double
        Dim lnmora As Double
        Dim lnsaldo As Double
        Dim lctippag As String
        Dim lccodins As String
        Dim lccodofi As String
        Dim lntotal As Double = 0


        Dim lninter As Double = 0


        lccodins = Me.Txtccodins.Text.Trim
        lccodofi = Me.txtcCodOfi.Text.Trim
        lccodcta = Me.txtnrocta.Text.Trim
        lncapita = Double.Parse(Me.txtcapita.Text)

        Dim lnmanejo As Double = 0
        lnmanejo = clsppal.CalcularManejo(lccodcta, Date.Parse(txtfecval2.Text), 0, True)


        lnintere = Double.Parse(Me.txtintere2.Text)


        lncomision = Double.Parse(Me.txtcomision.Text)
        lnhonorarios = Double.Parse(Me.txthonorarios.Text)
        lngestion = Double.Parse(Me.txtgestion.Text)
        lnmonpag = Double.Parse(Me.txtmonpag.Text)
        ldfecval = Date.Parse(Me.txtfecval2.Text)
        lnmora = Double.Parse(Me.txtmora.Text)
        lnsaldo = Double.Parse(Me.txtsaldo.Text)
        lctippag = Me.cmbtippag.SelectedItem.Value.Trim


        If Me.txtflat.Text.Trim = "F" Then
            If Me.CheckBox2.Checked = True Then
                clsaplica.porinteres = Session("gnporint")
                lnintere = clsaplica.interesCancelacion(lccodcta, ldfecval)
                lncapita = lnsaldo
                lnmonpag = Math.Round(lncapita + lnintere + lnmora + lncomision + lnhonorarios + lngestion, 2)
            Else
                'lnintere = clsaplica.InteresaAplicar(lccodcta, Math.Round(lnmonpag - (lncomision + lnhonorarios + lngestion + lnmora), 2))
                lnintere = Double.Parse(Me.txtintaldia.Text)
                lncapita = Double.Parse(Me.txtcapaldia.Text)
            End If
        Else

        End If
        Me.txtintere.Text = Math.Round(lnintere, 2)

        'si es intermediacion o de respaldo es tomado como servicio
        Me.txtintere2.Text = Math.Round(lnintere, 2)

        Me.txtcapita.Text = Math.Round(lncapita, 2)

        Me.txtmora.Text = Math.Round(lnmora, 2)


        '---------------------------------------------------------
        Me.txtdeuefe.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtsegdeu.Text) + Double.Parse(Me.txtmanejo.Text) + Double.Parse(Me.txtaporta.Text) + Double.Parse(Me.txtahosim.Text) + Double.Parse(Me.txtcomision.Text), 2).ToString
        Me.txtmonpag.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtsegdeu.Text) + Double.Parse(Me.txtmanejo.Text) + Double.Parse(Me.txtaporta.Text) + Double.Parse(Me.txtahosim.Text) + Double.Parse(Me.txtcomision.Text), 2).ToString

        '----------------------------------------------------
        lntotal = utilNumeros.Redondear(Double.Parse(Me.txtsaldo.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomision.Text), 2).ToString
        Me.txttotal.Text = lntotal
        Me.txtgastos.Text = Me.txtmora.Text

    End Sub


    Protected Sub btnimprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        Imprimir("crpagos.rpt", 1)
        'ImpresionEspecial()
    End Sub

    Private Sub Imprimir(ByVal reporte As String, ByVal tipo As Integer)
        If Me.reimpresion.Checked = True Then

        Else
            If Me.txtbandera.Text = 0 Then
                Return
            End If
        End If

        Dim lccodins As String
        Dim lccodofi As String
        Dim lccodcta As String
        Dim ldfecha As Date
        Dim lccomprobante As String
        Dim lccomprobante0 As String
        Dim lctipo As String = ""
        Dim clskardex As New ckardex
        Dim lnretencion As Double = 0
        Dim lcformapago As String = ""
        Dim lctippag As String = "E"
        Dim etabttab As New cTabttab

        If Me.cmbtippag.SelectedItem.Value.Trim = "I" Then
            lctipo = " (CONDONACION )"
        Else
            lctipo = ""
        End If
        lccodins = Me.Txtccodins.Text.Trim
        lccodofi = Me.txtcCodOfi.Text.Trim
        lccodcta = Me.txtnrocta.Text.Trim
        lccomprobante = Me.txtcompro.Text.Trim
        If Me.reimpresion.Checked = True Then
            lccomprobante0 = Session("gcCodofi") & Me.TxtRecImp.Text.Trim
        Else
            lccomprobante0 = Session("gcCodofi") & Me.txtcompro0.Text.Trim
        End If
      

        ldfecha = Date.Parse(Me.txtfecval2.Text) 'Session("gdfecsis")

        Dim etabtofi As New cTabtofi
        Dim lcnomofi As String = ""
        Dim entidadcremcre As New cremcre
        Dim ecremcre As New cCremcre
        Dim lcoficina As String


        entidadcremcre.ccodcta = lccodcta.Trim
        ecremcre.ObtenerCremcre(entidadcremcre)
        lcoficina = entidadcremcre.coficina


        lcnomofi = etabtofi.NombreAgencia(lcoficina)

        '------------------------------------------------
        Dim lccodcli As String = ""
        Dim lccodzon As String = ""
        lccodcli = Me.txtcodcli.Text.Trim

        Dim eclimide As New climide
        Dim mclimide As New cClimide

        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)

        lccodzon = IIf(IsDBNull(eclimide.ccoddom), "", eclimide.ccoddom)
        Dim lretencion As Boolean
        Dim lctelefono As String = ""
        Dim lcnit As String = ""

        lretencion = IIf(IsDBNull(eclimide.lsegvida), False, eclimide.lsegvida)
        lctelefono = IIf(IsDBNull(eclimide.cteldom), False, eclimide.cteldom)
        lcnit = IIf(IsDBNull(eclimide.cnudotr), False, eclimide.cnudotr)

        Dim etabtzon As New cTabtzon
        Dim lcaldea As String = ""

        lcaldea = etabtzon.Zona(lccodzon)

        '------------------------------------------------

        dsimprimepagos = clskardex.ObtenerDataSetPorID2(lccodcta, ldfecha, "C", lccomprobante0, " ")
        Try
            If dsimprimepagos Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsimprimepagos.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try
        '----Descargamos data set en variables----'




        Dim fila As DataRow
        Dim nCanti As Integer = 0
        Dim pnkp1 As Double = 0
        Dim pnin1 As Double = 0
        Dim pnmo1 As Double = 0
        Dim pnop1 As Double = 0
        Dim pn041 As Double = 0
        Dim pnotro1 As Double = 0
        Dim pntotal1 As Double = 0

        Dim pniva1 As Double = 0

        Dim pcconcep As String = "  "
        Dim pnmonto As Double = 0
        Dim lnflag As Integer = 0

        For Each fila In dsimprimepagos.Tables(0).Rows
            lctippag = dsimprimepagos.Tables(0).Rows(nCanti)("ctippag")
            If lctippag.Trim <> "D" And lnflag = 0 Then 'No aplica cuando es tipo de pago con documento
                lcformapago = etabttab.Describe(lctippag.Trim, "146").Trim
                lnflag = 1
            End If
            pcconcep = dsimprimepagos.Tables(0).Rows(nCanti)("cconcep")
            pnmonto = utilNumeros.Redondear(dsimprimepagos.Tables(0).Rows(nCanti)("nmonto"), 2)
            If pcconcep = "KP" Then
                pnkp1 = pnmonto
            ElseIf pcconcep = "IN" Then
                pnin1 = pnin1 + pnmonto
            ElseIf pcconcep = "MO" Then
                pnmo1 = pnmo1 + pnmonto
            ElseIf pcconcep = "CJ" Then
                pntotal1 = pntotal1 + pnmonto
            Else
                pnotro1 = pnotro1 + pnmonto
            End If
            nCanti = nCanti + 1
        Next

        'ElseIf pcconcep = "05" Then
        'pnop1 = pnmonto
        '    ElseIf pcconcep = "03" Then
        'pn041 = pnmonto
        '    ElseIf pcconcep = "08" Then
        'pniva1 = pnmonto

        Dim pntotal2 As Double = 0

        If lretencion = True Then
            lnretencion = Math.Round(((pnin1 + pnmo1) * Session("gnRetencion") / 100), 2)
        Else
            lnretencion = 0
        End If
        pntotal2 = pntotal1 - lnretencion

        Dim lnDecimal As Double
        Dim pccantlet1 As String
        If tipo = 1 Then
            pccantlet1 = clsConvert.ConversionEnteros(pntotal1)
            lnDecimal = clsConvert.ExtraeDecimales(pntotal1)
            pccantlet1 = pccantlet1.Trim & " " & lnDecimal.ToString & "/100" & " QUETZALES"

        Else
            Dim lntotfac As Double = 0
            lntotfac = pnin1 + pnmo1 + pnop1 + pniva1

            pccantlet1 = clsConvert.ConversionEnteros(lntotfac)
            lnDecimal = clsConvert.ExtraeDecimales(lntotfac)
            pccantlet1 = pccantlet1.Trim & " " & lnDecimal.ToString & "/100" & " QUETZALES"

        End If



        Dim ldfecsis As Date
        Dim lnsaldo1 As Double = 0
        Dim saldoant As Double = 0
        Dim saldoanti As Double = 0
        Dim saldoantm As Double = 0

        Dim lnsaldo2 As Double = 0

        Dim lnsalint2 As Double = 0
        Dim lnsaldoi1 As Double = 0

        Dim lnsalmor2 As Double = 0
        Dim lnsaldom1 As Double = 0


        lnsaldo2 = Double.Parse(Me.txtsaldo.Text)
        lnsalint2 = Double.Parse(Me.txtintere2.Text)
        lnsalmor2 = Double.Parse(Me.txtmora.Text)

        If Me.reimpresion.Checked = True Then
            saldoant = lnsaldo2 + pnkp1
            lnsaldo1 = Double.Parse(Me.txtsaldo.Text)

            saldoanti = lnsalint2 + pnin1
            lnsaldoi1 = Double.Parse(Me.txtintere2.Text)

            saldoantm = lnsalmor2 + pnmo1
            lnsaldom1 = Double.Parse(Me.txtmora.Text)

            If lnsaldoi1 < 0 Then
                lnsaldoi1 = 0
            End If
            If lnsaldom1 < 0 Then
                lnsaldom1 = 0
            End If

        Else
            saldoant = Double.Parse(Me.txtsaldo.Text)
            lnsaldo1 = saldoant - pnkp1

            saldoanti = Double.Parse(Me.txtintere2.Text)
            lnsaldoi1 = saldoanti - pnin1

            saldoantm = Double.Parse(Me.txtmora.Text)
            lnsaldom1 = saldoantm - pnmo1

            If lnsaldoi1 < 0 Then
                lnsaldoi1 = 0
            End If
            If lnsaldom1 < 0 Then
                lnsaldom1 = 0
            End If

        End If

        Dim lcbanco As String = ""
        If cmbbanco.Items.Count = 0 Then

        Else
            lcbanco = Me.cmbbanco.SelectedItem.Text
        End If
        'Dim etabtbco As New cTabtbco
        'Dim lcnombco As String = ""
        'lcnombco = etabtbco.NombredeBanco(lcbanco.Trim)

        Dim etabtusu As New cTabtusu
        Dim lcnomusu As String = ""
        '   lcnomusu = etabtusu.usuario(Session("gcCodusu"))
        lcnomusu = Session("gcCodusu")

        Dim lnsalteo As String
        Dim ecredppg As New cCredppg
        Dim lnmoracap As Double
        lnsalteo = ecredppg.ObtenerSaldoTeorico(lccodcta, Session("gdfecsis"), Double.Parse(Me.txtcapdes.Text))

        lnmoracap = IIf(lnsaldo1 > lnsalteo, Math.Round(lnsaldo1 - lnsalteo, 2), 0)

        'lcnomofi = Session("gcnomofi")
        ldfecsis = Session("gdfecsis")
        '-----------------------------------------'
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\" + reporte, OpenReportMethod.OpenReportByDefault)
            ' crRpt.PrintToPrinter(1, False, 0, 0) 'Probar envio directo a impresora

        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsimprimepagos.Tables(0))
        crRpt.Refresh()

        crRpt.SetParameterValue("pnkp", pnkp1)
        crRpt.SetParameterValue("pn04", pn041)

        If tipo = 1 Then
            crRpt.SetParameterValue("pnin", pnin1)
            crRpt.SetParameterValue("pnmo", pnmo1)
            crRpt.SetParameterValue("pnop", pnop1)

        Else
            crRpt.SetParameterValue("pnin", Math.Round(pnin1 * (1 + Session("gnIva") / 100), 2))
            crRpt.SetParameterValue("pnmo", Math.Round(pnmo1 * (1 + Session("gnIva") / 100), 2))
            crRpt.SetParameterValue("pnop", Math.Round(pnop1 * (1 + Session("gnIva") / 100), 2))

        End If

        crRpt.SetParameterValue("pniva", pniva1)
        crRpt.SetParameterValue("pcformapago", lcformapago)
        crRpt.SetParameterValue("pnotro", pnotro1)


        crRpt.SetParameterValue("pntotal2", pntotal2)
        crRpt.SetParameterValue("pntotal", pntotal1)
        crRpt.SetParameterValue("pclugnac", lcnomofi)
        crRpt.SetParameterValue("pdfecsis", ldfecsis)
        crRpt.SetParameterValue("pccantlet", pccantlet1)
        crRpt.SetParameterValue("nretencion", lnretencion)

        crRpt.SetParameterValue("pdultpag", Me.txtdultpag.Text)
        crRpt.SetParameterValue("pnmonotor", Me.txtcapdes.Text)
        If Me.reimpresion.Checked = True Then
            crRpt.SetParameterValue("pnsaldoant", saldoant)
        Else
            crRpt.SetParameterValue("pnsaldoant", Me.txtsaldo.Text)
        End If

        crRpt.SetParameterValue("pnmoncuo", Me.txtmoncuo.Text)
        crRpt.SetParameterValue("pdfecval", Me.txtfecval2.Text)

        crRpt.SetParameterValue("pdfecoto", Me.txtfecoto.Text)
        crRpt.SetParameterValue("pdfecven", Me.txtfecven.Text)

        crRpt.SetParameterValue("pnsaldo", lnsaldo1)
        crRpt.SetParameterValue("pcnomana", Me.txtcnomana.Text)
        crRpt.SetParameterValue("pcprograma", Me.txtprograma.Text)

        crRpt.SetParameterValue("pctipo", lctipo.Trim)
        crRpt.SetParameterValue("pnmoracap", lnmoracap)

        crRpt.SetParameterValue("saldoanti", saldoanti)
        crRpt.SetParameterValue("saldoantm", saldoantm)

        crRpt.SetParameterValue("lnsaldoi1", lnsaldoi1)
        crRpt.SetParameterValue("lnsaldom1", lnsaldom1)

        crRpt.SetParameterValue("cnomusu", lcnomusu)
        crRpt.SetParameterValue("caldea", lcaldea)
        crRpt.SetParameterValue("cbanco", lcbanco)

        crRpt.SetParameterValue("ctelefono", lctelefono)
        crRpt.SetParameterValue("cnit", lcnit)

        'crRpt.PrintOptions.PrinterName = "EPSON LX-300+ /II"
        'crRpt.PrintToPrinter(1, False, 0, 0)


        Dim reportes As String
        reportes = "crpagos.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.End()
        'Me.cancela()

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Imprimir("crfacturaRecibo.rpt", 2)
        'Imprimir_Ticket2()
    End Sub

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Date.Parse(txtfecval2.Text) > Session("gdfecsis") Then
            Response.Write("<script language='javascript'>alert('Fecha Valor no puede ser mayor a Fecha de Sistema')</script>")
            Exit Sub
        End If
        '        txtcompro.Text = txtcompro0.Text
        If txtcompro0.Text.Trim = "" Then
            '            Response.Write("<script language='javascript'>alert('Nº de Recibo Vacía')</script>")
            codigoJs = "<script language='javascript'>alert('Nº de Recibo Vacía, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'verifica boleta de deposito
        Dim ecredkar As New cCredkar
        Dim ecntamov As New cCntamov
        Dim etabtbco As New cTabtbco

        Dim lverifica As Boolean
        Dim lcctactb As String = ""
        If cmbbanco.Items.Count = 0 Then

        Else
            lcctactb = etabtbco.CuentaContableBanco(Me.cmbbanco.SelectedValue.Trim)
        End If


        'Graba datos
        Dim ok As Integer
        Dim lncomision As Double = 0
        Dim lnhonorarios As Double = 0
        Dim lngestion As Double = 0
        Dim lnmonpag As Double = 0
        Dim ldfecval As Date
        Dim lccodcta As String
        Dim lncapita As Double = 0
        Dim lnintere As Double = 0
        Dim lnmora As Double = 0
        Dim lnsaldo As Double = 0
        Dim lcbanco As String
        Dim lctippag As String
        Dim lccomprobante As String
        Dim lccomprobante0 As String
        Dim lccodins As String
        Dim lccodofi As String
        'Dim dr As DataRow
        Dim ldfecha As Date
        Dim clskardex As New ckardex
        Dim lniva As Double = 0
        Dim lnmanejo As Double = 0
        Dim lretencion As Boolean = False
        Dim mahomcta As New cAhomcta

        If Me.txtnrocta.Text.Trim = Nothing Then
            '            Response.Write("<script language='javascript'>alert('Cuenta vacía')</script>")
            codigoJs = "<script language='javascript'>alert('Cuenta vacía, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If
        If Double.Parse(Me.txtmonpag.Text) = 0 Then
            'Response.Write("<script language='javascript'>alert('Monto inválido')</script>")
            codigoJs = "<script language='javascript'>alert('Monto inválido, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        'Try

        '------------------------------------------------
        Dim lccodcli As String = ""
        lccodcli = Me.txtcodcli.Text.Trim

        Dim eclimide As New climide
        Dim mclimide As New cClimide

        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)


        lretencion = IIf(IsDBNull(eclimide.lsegvida), False, eclimide.lsegvida)

        '------------------------------------------------

        'coloca el valor del resultado a grabar
        'actualiza nuevamente las propiedades con lo pagado 
        'para evitar enviar parametros.
        lccodins = Me.Txtccodins.Text.Trim
        lccodofi = Me.txtcCodOfi.Text.Trim
        lccodcta = Me.txtnrocta.Text.Trim
        lncapita = Double.Parse(Me.txtcapita.Text)


        lnintere = Double.Parse(Me.txtintere2.Text)


        lncomision = Double.Parse(Me.txtcomision.Text)
        lnhonorarios = Double.Parse(Me.txthonorarios.Text)
        lngestion = Double.Parse(Me.txtgestion.Text)
        lnmonpag = Double.Parse(Me.txtmonpag.Text)
        ldfecval = Date.Parse(Me.txtfecval2.Text)
        lnmora = Double.Parse(Me.txtmora.Text)
        lnsaldo = Double.Parse(Me.txtsaldo.Text)
        lctippag = Me.cmbtippag.SelectedItem.Value.Trim

        lnmanejo = Double.Parse(txtmanejo.Text)
        lniva = Double.Parse(txtiva.Text)

        If Me.txtflat.Text.Trim = "F" Then
            Dim lnmontoint As Decimal = 0
            lnmontoint = Decimal.Parse(txtmonpag.Text) - Decimal.Parse(txtmora.Text)  'se le quita gastos en intereses moratorios

            clsaplica.porinteres = 0 'Session("gnporint")
            '                    lnintere = clsaplica.interesCancelacion(lccodcta, ldfecval)
            txtintere2.Text = clsaplica.InteresFlatCobrar(txtnrocta.Text.Trim, lnmontoint, Date.Parse(txtfecval2.Text))
            lnintere = Double.Parse(Me.txtintere2.Text)

            If Me.CheckBox2.Checked = True Then
                lncapita = lnsaldo
                lnmonpag = Math.Round(lncapita + lnintere + lnmora + lncomision + lnhonorarios + lngestion, 2)
            Else
                '    'lnintere = clsaplica.InteresaAplicar(lccodcta, Math.Round(lnmonpag - (lncomision + lnhonorarios + lngestion + lnmora), 2))
            End If

        End If

        If lctippag.Trim = "I" Then
            Dim lnlimcond As Double
            lnlimcond = Math.Round(lnintere + lncomision + lnmora + Double.Parse(Me.txtsegdeu.Text), 2)
            If lnmonpag > lnlimcond Then
                '                    Response.Write("<script language='javascript'>alert('No puede Condonar Capital')</script>")
                codigoJs = "<script language='javascript'>alert('No puede Condonar Capital, " & _
                                            "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                Return
            End If
        End If
        Dim etabtofi As New cTabtofi
        ' lccomprobante = etabtofi.ObtieneCorrelativo(Session("gcCodofi"))
        Me.txtcompro.Text = txtcompro0.Text.Trim 'lccomprobante.Trim
        etabtofi.ActualizaCorrelativo(Session("gcCodofi"), txtcompro0.Text)


        If cmbtippag.SelectedValue.Trim = "C" Then
            'verifica si existen bancos
            If cmbbanco.Items.Count = 0 Then
                '                    Response.Write("<script language='javascript'>alert('Asignar Banco a Oficina')</script>")
                codigoJs = "<script language='javascript'>alert('Asignar Banco a Oficina, " & _
                                            "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Return
            End If
            lcbanco = Me.cmbbanco.SelectedItem.Value.Trim
        Else
            lcbanco = ""
        End If


        lccomprobante = Me.txtcompro.Text.Trim
        lccomprobante0 = Me.txtcompro0.Text.Trim
        cls1.pccodcta = lccodcta
        cls1.pncapita = lncapita
        cls1.pnsalint = lnintere
        cls1.pnsalmor = lnmora
        cls1.pncomision = lncomision
        cls1.pnhonorarios = lnhonorarios
        cls1.pngestion = lngestion
        cls1.pnmonpag = lnmonpag
        cls1.pdfecval = ldfecval
        cls1.pndeucap = lnsaldo
        cls1.pcbanco = lcbanco
        cls1.pctippag = lctippag
        cls1.pcnuming = lccomprobante
        cls1.pcnuming0 = Session("gcCodofi") & lccomprobante0

        cls1.gdfecsis = Session("gdfecsis")

        'Validar que Variable de Sesion de Usuario no vaya vacio

        Dim lccodusu As String
        lccodusu = Session("gccodusu")
        Dim lnretorno As Integer = 0
        lnretorno = clsppal.VerificaConexion(lccodusu)
        If lnretorno = 0 Then
            '                Response.Write("<script language='javascript'>alert('Se perdio Conexion, Ingrese de Nuevo')</script>")
            codigoJs = "<script language='javascript'>alert('Se perdio Conexion, Ingrese de Nuevo, " & _
                                            "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            Return
        End If



        'Extrae cuenta concentradora



        'Valida si es transferencia que exista la cuenta concentradora
        If Me.cmbtippag.SelectedValue.Trim = "T" Then
            Dim array_d As New ArrayList

            array_d = mahomcta.Extraer_ctas_Ahorro_Socio_Saldo(Me.txtcodcli.Text.Trim)


            If array_d.Item(0).ToString.Length = 0 Then
                codigoJs = "<script language='javascript'>alert('No Existe una cuenta concentradora para realizar el Retiro, " & _
                       "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If

            'Evalua el Monto
            If Double.Parse(Me.txtmonpag.Text) > Double.Parse(array_d.Item(1)) Then
                codigoJs = "<script language='javascript'>alert('El Saldo de la cuenta Concentradora es menor al monto Aplicar, " & _
                       "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If

            cls1.pcCodctaAho = array_d.Item(0)

        End If



        Dim error100 As Integer
        Dim miclase As New clase_jaime
        Dim miclase1 As New clase_funciones
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select As String = ""
        con.ConnectionString = stringconnection

        con.Open()


        str_select = "SET LANGUAGE spanish; begin tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)

        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            'Response.Write("<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK')</script>")
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK, " & _
                             "Advertencia SIM.NET ')</script>"


            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If




        cls1.gccodusu = lccodusu


        cls1.ahosim = Double.Parse(Me.txtahosim.Text)
        cls1.ahovis = Double.Parse(Me.txtahovis.Text)
        cls1.aporta = Double.Parse(Me.txtaporta.Text)
        cls1.segdeu = Double.Parse(Me.txtsegdeu.Text)
        cls1.manejo = lnmanejo 'Double.Parse(Me.txtmanejo.Text)
        cls1.niva = lniva

        'actualiza propiedades de la pagdesver
        cls1.pnintpag = ViewState("pnintpag1")  'clsaplica.pnintpag
        cls1.pnintpen = ViewState("pnintpen1")
        cls1.pnintcal = ViewState("pnintcal1")
        cls1.pnmorpag = ViewState("pnmorpag1")
        cls1.pnpagcta = ViewState("pnpagcta1")
        cls1.pnintmor = ViewState("pnintmor1")
        cls1.pdultpag = ViewState("pdultpag1")
        cls1.pncappag = (Double.Parse(Me.txtncappag.Text)) 'viewstate("pncappag1")
        cls1.pccodcli = Me.txtcodcli.Text.Trim
        cls1.pndiaatr = Me.txtdiaatr.Text

        cls1.lsolidario = Me.CheckBox1.Checked

        ''------------------------------------------------------------------------------
        ''recalcula IVA en base a lo que realmente paga
        ''------------------------------------------------------------------------------
        Dim lnpago As Double = Double.Parse(txtmonpag.Text)
        Dim lnivar As Decimal = 0

        If lnpago < (Double.Parse(txtsegdeu.Text) + lnmanejo + lnmora + lnintere + lniva) Then



            If lnpago >= Double.Parse(txtsegdeu.Text) Then
                lnpago = lnpago - Double.Parse(txtsegdeu.Text)

                If lnpago >= Math.Round((lnmanejo + (lnmanejo * Session("gnIVA") / 100)), 2) Then
                    lnpago = lnpago - (lnmanejo + Math.Round((lnmanejo * Session("gnIVA") / 100), 2))
                    lnivar = Math.Round((lnmanejo * Session("gnIVA") / 100), 2)

                    If lnpago > 0 Then
                        If lnpago >= Math.Round((lnmora + (lnmora * Session("gnIVA") / 100)), 2) Then
                            lnpago = lnpago - (lnmora + Math.Round((lnmora * Session("gnIVA") / 100), 2))
                            lnivar = lnivar + Math.Round((lnmora * Session("gnIVA") / 100), 2)
                            If lnpago > 0 Then
                                If lnpago >= Math.Round((lnintere + (lnintere * Session("gnIVA") / 100)), 2) Then
                                    lnpago = lnpago - (lnintere + Math.Round((lnintere * Session("gnIVA") / 100), 2))
                                    lnivar = lnivar + Math.Round((lnintere * Session("gnIVA") / 100), 2)
                                Else
                                    lnintere = Math.Round(lnpago / (1 + (Session("gnIVA") / 100)), 2)
                                    lnivar = Math.Round(lnivar + Math.Round((lnintere * Session("gnIVA") / 100), 2), 2)
                                    lnpago = 0
                                End If

                            End If
                        Else
                            lnmora = Math.Round(lnpago / (1 + (Session("gnIVA") / 100)), 2)
                            lnivar = Math.Round(lnivar + Math.Round(((lnmora) * Session("gnIVA") / 100), 2), 2)
                            lnpago = 0
                        End If

                    End If
                Else
                    lnmanejo = Math.Round(lnpago / (1 + (Session("gnIVA") / 100)), 2)
                    lnivar = Math.Round((lnmanejo) * Session("gnIVA") / 100, 2)
                    lnpago = 0
                End If


            Else
                lnpago = 0
            End If

            cls1.niva = Math.Round(lnivar, 2)
        End If



        cls1.lret = lretencion
        cls1.nretencion = Session("gnRetencion")
        cls1.gniva = Session("gniva")

        cls1.gcpuente = Session("gcpuente")
        'Sera bancario por defecto
        cls1.pccolector = "1"   ' 1 Banamex, 2 Paynet



        '------------------------------------------------------------------------------
        'cls1.mxdistribute()


        error100 = cls1.mxdistribute_Transac(con)


        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            'Response.Write("<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK')</script>")
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK " & _
                           "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        str_select = "commit tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)

        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            'Response.Write("<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK')</script>")
            codigoJs = "<script language='javascript'>alert(''Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK " & _
                           "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        con.Close()


        ldfecha = Session("gdfecsis")

        clsppal.GrabarBoletas(lcbanco, lccomprobante, " ", ldfecha, ldfecval, lnmonpag)

        'Graba Interes congelado en el interes pendiente de cobro
        Dim lnintcong As Decimal = 0
        If txtncongelado.Text.Trim = "" Or txtncongelado.Text = Nothing Then
            lnintcong = 0
        Else
            lnintcong = Double.Parse(txtncongelado.Text)
        End If


        Dim ecredppg As New cCredppg
        Dim ecremcre As New cCremcre
        Dim lcnrocuo As String
        lcnrocuo = ecredppg.ObtenerCuotaUltimaVencida(lccodcta, ldfecval)
        'ecredppg.GrabaInteresCongelado(lccodcta, lcnrocuo, lnintcong)
        'ecremcre.GrabaInteresCongelado(lccodcta, lnintcong)
        '---------------------------------------------------------


        Dim clspagos1 As New clspagos

        'dsimprimepagos = clskardex.ObtenerDataSetPorID2(lccodcta, ldfecha, "C", lccomprobante, " ")
        '            Response.Write("<script language='javascript'>alert('Pago Aplicado, Imprima Recibo')</script>")
        codigoJs = "<script language='javascript'>alert('Pago Aplicado, Imprima Recibo, " & _
                                            "Aviso SIM.NET ')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        'Deshabilita acceso a distribucion----------------------------
        Session("fuente") = "0"

        Me.txtbandera.Text = 1
        Me.btngrabar.Enabled = False
        Me.Label29.Visible = False
        cmbtippag.Enabled = False

        Imprimir("crpagos.rpt", 1)
        'Catch ex As Exception
        '    '            Response.Write("<script language='javascript'>alert('Pago no fue aplicado')</script>")
        '    codigoJs = "<script language='javascript'>alert('Pago no fue aplicado, " & _
        '                                        "Advertencia SIM.NET ')</script>"
        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        'End Try

    End Sub
    Private Sub aplicar()
        Me.reimpresion.Checked = False
        Dim lccodcta As String
        Dim ldfecval As Date
        Dim lntotal As Double
        Dim lndeuda As Double
        Dim ok As Integer
        Dim lccodins As String
        Dim lccodofi As String
        Dim ldultpag As Date
        Dim lnsegdeu As Decimal
        Dim lnmanejo As Double
        Dim lnmeses As Double
        Dim gdfecsis As Date
        Dim lnsalcap As Double
        Dim lnpropseg As Double
        Dim lnpropman As Double
        Dim lnahosim As Double
        Dim lnaporta As Double
        Dim lnahorro As Double
        Dim lccondic As String = ""
        btnActivar.Visible = False

        Dim ecredkar As New cCredkar
        Dim ldfecflag As Date
        Me.txtflat.Text = ""

        Dim etabtvar As New tabtvar
        Dim mtabtvar As New cTabtvar
        etabtvar.cnomvar = "GNCORRELA"
        etabtvar.ccodapl = "CRE"
        mtabtvar.ObtenerTabtvar(etabtvar)
        Session("codigo") = ""
        Session("fuente") = "0"

        Dim lccomprobante0 As String
        lccomprobante0 = etabtofi.ObtieneCorrelativo(Session("gcCodofi"))


        Try
            'verificando si esta habilitado para procesar pagos
            Dim eusuarios As New cusuarios
            Dim lhabilitado As Boolean
            lhabilitado = eusuarios.ValidaProcesaPagos(Session("gcCodusu"))
            If lhabilitado = False Then
                btngrabar.Enabled = False
                '                Response.Write("<script language='javascript'>alert('Caja No Esta Aperturada')</script>")
                codigoJs = "<script language='javascript'>alert('Caja No Esta Aperturada, " & _
                                                "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Return
            End If
            '---------------------------------------------------


            lccodcta = Me.txtnrocta.Text.Trim
            ldfecval = Date.Parse(Me.txtfecval2.Text)



            '    lncomprobante0 = Double.Parse(etabtvar.cconvar) + 1
            Me.txtcompro0.Text = lccomprobante0 'lncomprobante0.ToString.Trim
            If Me.txtnrocta.Text.Trim = Nothing Then
                '                Response.Write("<script language='javascript'>alert('Cuenta vacía')</script>")
                codigoJs = "<script language='javascript'>alert('Cuenta vacía, " & _
                                                "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                Return
            End If

            ldfecflag = ecredkar.UltimafechaProceso(lccodcta, Session("gdfecsis"))
            If ldfecflag > ldfecval Then
                txtfecval2.Text = Session("gdfecsis")
                'Response.Write("<script language='javascript'>alert('Pago fecha valor tiene un pago en fecha posterior')</script>")
                codigoJs = "<script language='javascript'>alert('Pago fecha valor tiene un pago en fecha posterior, " & _
                                                "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                Return
            End If


            'Verifica fecha valor si no existe fecha posterios

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            clsaplica.pccodcta = lccodcta
            clsaplica.pdfecval = ldfecval
            clsaplica.gdfecsis = Session("gdfecsis")
            clsaplica.gnperbas = Session("gnperbas")
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "F"
            'clsaplica.pcflat = ""
            clsaplica.gnpergra = Session("gnpergra")
            ok = clsaplica.omcalcinterest("T", ldfecval)
            If ok = 9 Then
                '                Response.Write("<script language='javascript'>alert('Crédito Cancelado')</script>")
                codigoJs = "<script language='javascript'>alert('Crédito Cancelado, " & _
                                                "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Me.btngrabar.Enabled = False
                Exit Try
            Else

             
               
            End If


            Dim ecremcre As New cCremcre
            Dim entidadcremcre As New cremcre
            Dim lccodpag As String = ""
            Label30.Text = ""

            entidadcremcre.ccodcta = lccodcta
            ecremcre.ObtenerCremcre(entidadcremcre)
            lccodpag = entidadcremcre.ccodpag
            lccondic = entidadcremcre.ccondic

            btnActivar.Visible = False
            If IsDBNull(lccondic) Then
            Else
                If lccondic = "J" Then 'en cobro judicial
                    Label30.Text = "Cliente en Proceso de Demanda"
                    Session("codigo") = "JAG" ' Session("codigo") = "JEAG" Or
                    Session("fuente") = "0"
                    Grabar2.Enabled = False
                    btnActivar.Visible = True
                    '                    Response.Write("<script>window.open('wfAcceso.aspx','cal', 'location=1, toolbar = no, status=1,width=350,height=350')</script>")
                    codigoJs = "<script>window.open('wfAcceso.aspx','cal', 'location=1, toolbar = no, status=1,width=350,height=350')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                    If Session("fuente") = "1" Then 'Habilitar
                        'especial_TextBox.Visible = True
                        Dim a As Integer = 0
                        a = 1
                    End If
                End If
            End If

            If lccondic = "J" Then

            Else
                Me.btngrabar.Enabled = True
                Grabar2.Enabled = True
                cmbtippag.Enabled = True
            End If

            If IsDBNull(lccodpag) Or lccodpag = Nothing Then
            Else

                'cmbtippag.SelectedValue = "C"
                'cmbbanco.SelectedValue = lccodpag.Trim

                cmbtippag.SelectedValue = "E"
                cmbbanco.Visible = False
                lblbanco.Visible = False
            End If



            'Obtiene nota 
            Dim lcnota As String = ""
            Dim enotas As New cNotas

            lcnota = enotas.ObtieneNota(lccodcta, Session("gdfecsis"))
            If lcnota.Trim = "" Then
                Label60.Text = ""
                Label60.Visible = False
            Else
                lcnota = lcnota
                'Response.Write("<script language='javascript'>alert(lcnota)</script>")
                Label60.Text = lcnota
                Label60.Visible = True
            End If


            'Para Calcular Cuota
            Dim lncuota As Double
            clsppal.gnperbas = Session("gnperbas")
            clsppal.pnComtra = Session("gnComTra")
            clsppal.pnSegVm = Session("gnSegVm")
            lncuota = clsppal.ValorCuota(lccodcta)
            '-----


            If ok = 1 Then
                'Calculo de la comision por tramite -----------------
                Dim lncomision As Decimal
                Dim pccodlin As String
                Dim lsegdeu As Boolean
                Dim lndias As Integer
                Dim entidadcretlin As New cretlin
                Dim ecretlin As New cCretlin
                Dim ldultfecha As Date

                ldultfecha = ecredkar.UltimafechaProceso(lccodcta, ldfecval)

                entidadcretlin.cnrolin = clsaplica.cnrolin
                ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                pccodlin = entidadcretlin.ccodlin
                lsegdeu = entidadcretlin.lsegdeu

                'Me.txtnrocta.Text = Mid(lccodcta, 7, 12)
                Me.txtcodcli.Text = clsaplica.pccodcli
                Me.txtnomcli.Text = clsaplica.pcnomcli
                Me.txtflat.Text = clsaplica.pcflat

                If clsaplica.pcflat.Trim = "F" Then
                    Me.CheckBox2.Enabled = False
                Else
                    Me.CheckBox2.Enabled = False
                End If

                Me.txtcuota.Text = lncuota 'utilNumeros.Redondear(clsaplica.pnmoncuo, 2)


                'If clsaplica.pcflat.Trim = "F" Then
                'Me.txtintere.Text = clsaplica.InteresaAplicar(lccodcta, Math.Round(lnmonpag - (lncomision + lnhonorarios + lngestion + lnmora), 2))
                'Me.txtintere2.Text = clsaplica.InteresaAplicar(lccodcta, Math.Round(lnmonpag - (lncomision + lnhonorarios + lngestion + lnmora), 2))
                ' Else

                Me.txtintere.Text = Math.Round(clsaplica.pnsalint, 2)
                Me.txtintere2.Text = Math.Round(clsaplica.pnsalint, 2)
                Me.txtcomision.Text = Math.Round(clsaplica.pnsalser, 2)
                Me.txtintaldia.Text = utilNumeros.Redondear(clsaplica.pnsalint, 2)

                ' End If


                'Nuevo Analisis de Gracia especial AMIGA Mexico 04/05/2015
                If clsaplica.pndiaatr > Session("GNDIAGRACIA") Then
                    Me.txtmora.Text = utilNumeros.Redondear(clsaplica.pnsalmor, 2)
                Else
                    Me.txtmora.Text = "0.00"
                End If


                Me.txtcapita.Text = utilNumeros.Redondear(clsaplica.pndeucap2, 2).ToString() 'utilNumeros.Redondear(clsaplica.pndeucap, 2).ToString()
                txtcapaldia.Text = utilNumeros.Redondear(clsaplica.pndeucap2, 2).ToString() 'utilNumeros.Redondear(clsaplica.pndeucap, 2).ToString()

                Me.txtsaldo.Text = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
                Me.txtncappag.Text = utilNumeros.Redondear(clsaplica.pncappag, 2).ToString()
                Me.txtcapdes.Text = utilNumeros.Redondear(clsaplica.pncapdes, 2).ToString()
                Me.txtdultpag.Text = clsaplica.pdultpag
                ldultpag = clsaplica.pdultpag
                Me.txtdeucap.Text = utilNumeros.Redondear(clsaplica.pndeucap, 2).ToString
                Me.txtdiaatr.Text = utilNumeros.Redondear(clsaplica.pndiaatr, 0).ToString

                'ahorros

                If ldultpag = Nothing Then
                    ldultpag = clsaplica.pdfecvig
                End If
                gdfecsis = Session("gdfecsis")
                ldultpag = clsaplica.pdultpag
                lnsalcap = clsaplica.pncapdes - clsaplica.pncappag
                lnpropseg = Session("gnsegdeu")
                lnpropman = Session("gnmanejo")

                lnmeses = clsaplica.meses_desde_ultimo_pago(gdfecsis, ldultpag)
                '<<<<<<<<<<<<<<<<<<<<<<<<
                'CalculaSeg()
                'lnsegdeu = clsppal.pnSegDeu

                'lnsegdeu = utilNumeros.Redondear((lnpropseg * lnsalcap) * lnmeses, 2)
                'lnmanejo = utilNumeros.Redondear(lnpropman * lnmeses, 2)

                lnahorro = Session("GNAHORRO")
                lnahosim = utilNumeros.Redondear(clsaplica.ahosim, 2)
                lnaporta = utilNumeros.Redondear(clsaplica.aporta, 2)

                If lnahosim > lnahorro Then
                    lnahosim = 0
                Else
                    lnahosim = lnahorro - lnahosim
                End If
                Me.txtahosim.Text = lnahosim.ToString


                If lnaporta > lnahorro Then
                    lnaporta = 0
                Else
                    lnaporta = lnahorro - lnaporta
                End If
                Me.txtahosim.Text = lnahosim.ToString
                Me.txtaporta.Text = lnaporta.ToString

                Me.txtahovis.Text = utilNumeros.Redondear(clsaplica.ahovis, 2)
                'Me.txtmanejo.Text = utilNumeros.Redondear(lnmanejo, 2)
                'Recupera Nombre de Analista
                Dim lcnomusu As String
                Dim entidadtabtusu As New tabtusu
                Dim etabtusu As New cTabtusu
                entidadtabtusu.ccodusu = clsaplica.pccodana.Trim
                etabtusu.ObtenerTabtusu(entidadtabtusu)
                lcnomusu = entidadtabtusu.cnomusu.Trim
                Me.txtcnomana.Text = lcnomusu

                Dim lniva As Decimal = 0
                Dim lniva1 As Decimal = 0
                Dim lniva2 As Decimal = 0
                Dim lniva3 As Decimal = 0


                lndias = DateDiff(DateInterval.Day, ldultfecha, ldfecval)
                lncomision = 0

                '               lnsegdeu = clsppal.CalcularSeguroDeuda(lccodcta, ldfecval, Double.Parse(Me.txtcapdes.Text), clsaplica.pdfecvig)
                '               lnmanejo = clsppal.CalcularManejo(lccodcta, ldfecval, clsaplica.pncapdes, CheckBox2.Checked)

                'lniva1 = clsppal.CalcularIVAManejo(Session("gnIVA"), lnmanejo)
                'lniva2 = clsppal.CalcularIVAManejo(Session("gnIVA"), Double.Parse(Me.txtintere2.Text))
                'lniva3 = clsppal.CalcularIVAManejo(Session("gnIVA"), Double.Parse(Me.txtmora.Text))
                'lniva = lniva1 + lniva2 + lniva3

                '                Me.txtsegdeu.Text = lnsegdeu
                '                Me.txtmanejo.Text = lnmanejo
                '                Me.txtiva.Text = lniva
                '---------------------------------------------------------
                Me.txtdeuefe.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtsegdeu.Text) + Double.Parse(Me.txtmanejo.Text) + Double.Parse(Me.txtaporta.Text) + Double.Parse(Me.txtahosim.Text) + Double.Parse(Me.txtcomision.Text) + Double.Parse(Me.txtiva.Text), 2).ToString
                'utilNumeros.Redondear(clsaplica.pndeucap + clsaplica.pnsalint + clsaplica.pnsalmor + lnsegdeu + Double.Parse(Me.txtcomision.Text), 2).ToString()
                Me.txtmoncuo.Text = utilNumeros.Redondear(lncuota, 2).ToString

                Dim ecredgas As New cCredgas
                Dim dsg As New DataSet
                Dim lncargos As Double = 0
                dsg = ecredgas.CargaGastosCuota(txtnrocta.Text.Trim, Date.Parse(txtfecval2.Text), "C", "001")
                GridView1.DataSource = dsg.Tables(0)
                GridView1.DataBind()
                Me.txtiva.Text = 0 'claseaditivo.ObtenerIVACargos(dsg, Session("gnIVA"))
                lncargos = claseaditivo.ObtenerSumaCargos(dsg)



                Me.txtmonpag.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtiva.Text) + lncargos, 2).ToString

                '----------------------------------------------------
                lntotal = utilNumeros.Redondear(Double.Parse(Me.txtsaldo.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtiva.Text) + lncargos, 2).ToString
                Me.txttotal.Text = lntotal
                Me.txtgastos.Text = Me.txtmora.Text

                'variables de cesion necesarias para los calculos
                ViewState.Add("pnintpag1", clsaplica.pnintpag)
                ViewState.Add("pnintpen1", clsaplica.pnintpen)
                ViewState.Add("pnintcal1", clsaplica.pnintcal)
                ViewState.Add("pnmorpag1", clsaplica.pnmorpag)
                ViewState.Add("pnpagcta1", clsaplica.pnpagcta)
                ViewState.Add("pnintmor1", clsaplica.pnintmor)
                ViewState.Add("pdultpag1", clsaplica.pdultpag)

                Me.txtfecoto.Text = clsaplica.pdfecoto
                Me.txtfecven.Text = clsaplica.pdfecven
                Dim etabttab As New cTabttab
                Me.txtprograma.Text = pccodlin.Substring(2, 2) 'etabttab.Describe(pccodlin.Substring(2, 2), "033").Trim

                'muestra la proxima fecha de pago
                Dim ecredppg As New cCredppg
                Dim ldnext As Date
                Dim lcnrocuo As String = ""
                ldnext = ecredppg.ProximaFecha(lccodcta, Session("gdfecsis"))
                lcnrocuo = ecredppg.NumeroCuotaProximaFecha(lccodcta, Session("gdfecsis"))
                Me.Label29.Visible = True
                Me.Label29.Text = "Próxima fecha de pago, Cuota " & lcnrocuo & " : " & ldnext.ToString.Substring(0, 10)


                ''cuando es primera cuota******************
                If lcnrocuo.Trim = "001" Then
                    Dim lnmesesgracia As Integer = 0
                    lnmesesgracia = DateDiff(DateInterval.Month, Date.Parse(txtdultpag.Text), Date.Parse(txtfecval2.Text))
                    If lnmesesgracia >= 2 Then
                        Dim lncapital1 As Double = 0
                        'lncapital1 = ecredppg.CuotasTeoricasMonto(lccodcta, Date.Parse(txtfecval2.Text))
                        Me.txtmonpag.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtsegdeu.Text) + Double.Parse(Me.txtmanejo.Text) + Double.Parse(Me.txtaporta.Text) + Double.Parse(Me.txtahosim.Text) + Double.Parse(Me.txtcomision.Text) + Double.Parse(Me.txtiva.Text) + lncapital1, 2).ToString
                        If Decimal.Parse(txtmonpag.Text) > lntotal Then
                            txtmonpag.Text = lntotal
                        End If
                    End If
                Else
                    If ldnext = Date.Parse(txtfecval2.Text) Then
                        'Obtener el capital de la cuota
                        Dim lncapital1 As Double = 0
                        ' lncapital1 = ecredppg.CuotaTeoricaMonto(lccodcta, Date.Parse(txtfecval2.Text))
                        '                        Me.txtmonpag.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtsegdeu.Text) + Double.Parse(Me.txtmanejo.Text) + Double.Parse(Me.txtaporta.Text) + Double.Parse(Me.txtahosim.Text) + Double.Parse(Me.txtcomision.Text) + Double.Parse(Me.txtiva.Text) + lncapital1, 2).ToString
                        Me.txtmonpag.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtiva.Text) + lncargos + lncapital1, 2).ToString()
                        If Decimal.Parse(txtmonpag.Text) > lntotal Then
                            txtmonpag.Text = lntotal
                        End If
                    End If
                End If

                '**************************
                '------------------------------------------------
                Dim lccodcli As String = ""
                lccodcli = Me.txtcodcli.Text.Trim
                Dim eclimide As New climide
                Dim mclimide As New cClimide

                eclimide.ccodcli = lccodcli
                mclimide.ObtenerClimide(eclimide)


                'Dim lretencion As Boolean

                'lretencion = IIf(IsDBNull(eclimide.lsegvida), False, eclimide.lsegvida)
                'If lretencion = True Then
                '    Label30.Text = "Solicitar a Cliente Constacia de Retencion"
                'Else
                '    Label30.Text = ""
                'End If
                '------------------------------------------------


                Me.btngrabar.Enabled = True
                Me.btnaplicar.Disabled = True



            Else
                '                Response.Write("<script language='javascript'>alert('Cuenta no tiene movimientos')</script>")
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

    End Sub

    Protected Sub txtfecval2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfecval2.TextChanged
        If Date.Parse(txtfecval2.Text) > Session("gdfecsis") Then
            txtfecval2.Text = Session("gdfecsis")
            aplicar()
            '            Response.Write("<script language='javascript'>alert('Fecha No puede ser Posterior a Fecha de Sistema')</script>")
            codigoJs = "<script language='javascript'>alert('Fecha No puede ser Posterior a Fecha de Sistema, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If
        aplicar()
    End Sub



    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        imprime()
    End Sub
    Sub imprime()
        Dim lncuenta As Integer
        Dim mControl As New cCredppg
        Dim mLista As New listacredppg
        Dim mov As New creditos
        Dim mcreditos As New ccreditos
        Dim i As Integer
        Dim lnsaldo As Double
        Dim dsplan1 As New DataSet
        Dim clsprincipal As New class1

        Dim ecremcre As New cCremcre
        Dim lntasa As Double = 0

        Dim lccodins, lccodofi, lccodcta As String
        lccodins = Me.Txtccodins.Text.Trim
        lccodofi = Me.txtcCodOfi.Text.Trim
        lccodcta = Me.txtnrocta.Text.Trim
        Dim codcta As String = lccodcta

        '--------------------<<<<<>>>>>----------------


        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = lccodcta
        ecreditos.Obtenercreditos(entidad3)

        Dim lcnomana As String = ""

        Dim lcoficina As String = ""

        lcnomana = entidad3.cNomUsu
        lccodcta = entidad3.ccodcta
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

        lntasa = ecremcre.TasaCredito(codcta)

        'carga dataset para imprimir
        dsplan1 = mControl.ObtenerDataSetPorID2(codcta)


        Dim pniva As Double
        Dim lliva As Boolean
        'Dim entidadCretlin As New SIM.EL.cretlin
        'Dim eCretlin As New SIM.BL.cCretlin

        entidadCretlin.cnrolin = mov.cnrolin

        eCretlin.ObtenerCretlinPorllave(entidadCretlin)

        pniva = Session("gnIVA")
        lliva = entidadCretlin.lliva


        'Valida si la Linea de Credito Incluye Iva
        If lliva Then
            For Each Linea In dsplan1.Tables(0).Rows
                If Linea("cTipOpe") = "N" Then
                    Linea("nGastos") = Linea("nintere") - (Linea("nintere") / pniva)
                    Linea("nGastos") = Math.Round(Linea("nGastos"), 2)
                    Linea("nintere") = Linea("nintere") - Linea("nGastos")
                Else
                    Linea("nintere") = 0
                End If
            Next
        End If

        'carga lista
        mov.ccodcta = codcta
        mcreditos.Obtenercreditos(mov)


        mLista = mControl.ObtenerListaPorCuenta(codcta)
        mLista(0).nmoncuo = 0

        '----------------------------------------------
        clsprincipal.cNrolin = mov.cnrolin
        clsprincipal.nMonDes = mov.ncapdes
        clsprincipal.cCodFor = mov.ctipper
        clsprincipal.nPerDia = mov.ndiasug
        clsprincipal.gnperbas = Session("gnperbas")
        clsprincipal.pnComtra = Session("gnComTra")

        If mov.dfecvig >= #7/11/2008# Then
            clsprincipal.pnSegVm = Session("gnSegVm1")
        Else
            clsprincipal.pnSegVm = Session("gnSegVm")
        End If

        'clsprincipal.OtrosGastos()




        '----------------------------------------------
        Dim lncapita, lnintere, lngastos, lnsegdeu As Decimal
        'lnsegdeu = utilNumeros.Redondear(clsprincipal.pnSegDeu, 2)
        'lngastos = utilNumeros.Redondear(clsprincipal.pnComPer, 2)

        dsplan1.Tables(0).Rows(0)("nmoncuo") = 0
        dsplan1.Tables(0).Rows(0)("ncapita") = 0
        'obtiene el saldo de la lista
        lncuenta = mLista.Count - 1
        lnsaldo = mLista(0).ncapita

        Dim lntasaiva As Double = Session("gnIVA")
        Dim lniva As Double = 0

        For i = 0 To lncuenta
            If mLista(i).ctipope = "D" Then
                mLista(i).nsaldo = lnsaldo
                dsplan1.Tables(0).Rows(0)("nsaldo") = lnsaldo
            Else

                mLista(i).nsaldo = lnsaldo - mLista(i).ncapita
                dsplan1.Tables(0).Rows(i)("nsaldo") = lnsaldo - mLista(i).ncapita
                lnsaldo = lnsaldo - mLista(i).ncapita
                lncapita = mLista(i).ncapita
                lnintere = mLista(i).nintere
                lngastos = mLista(i).ngastos
                lnsegdeu = mLista(i).nsegdeu

                lniva = Math.Round(lngastos * lntasaiva / 100, 2)
                dsplan1.Tables(0).Rows(i)("ntasint") = Math.Round(lntasa / 12 / 100, 2)
                dsplan1.Tables(0).Rows(i)("nmoncuo") = lncapita + lnintere + lngastos + lnsegdeu + lniva
                dsplan1.Tables(0).Rows(i)("nsegdeu") = lnsegdeu
                'dsplan1.Tables(0).Rows(i)("ngastos") = (lngastos + lniva) 'comision por manejo
                mLista(i).ngastos = (lngastos + lniva)
                mLista(i).nmoncuo = lncapita + lnintere + lngastos + lnsegdeu + lniva

            End If
        Next


        Try
            If dsplan1 Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsplan1.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim ldfecdes As Date = Session("gdfecsis")
        Dim ldfecpri As Date = Session("gdfecsis")
        Dim lcmes As Integer = 0
        Dim lcnota As String = ""
        Dim lnmanejo As Decimal = 0

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim fila As DataRow
        Dim nelem As Integer
        Dim lctipope As String
        Dim lnsalint As Double = 0
        For Each fila In dsplan1.Tables(0).Rows
            If dsplan1.Tables(0).Rows(nelem)("ctipope") = "D" Then
                dsplan1.Tables(0).Rows(nelem)("ncapita") = 0
                ldfecdes = dsplan1.Tables(0).Rows(nelem)("dfecven")
            Else

                If dsplan1.Tables(0).Rows(nelem)("cnrocuo") = "001" Then
                    ldfecpri = dsplan1.Tables(0).Rows(nelem)("dfecven")
                    lnsegdeu = dsplan1.Tables(0).Rows(nelem)("nsegdeu")
                    lnmanejo = dsplan1.Tables(0).Rows(nelem)("ngastos")
                End If

            End If
            dsplan1.Tables(0).Rows(nelem)("saldo") = dsplan1.Tables(0).Rows(nelem)("nsaldo")
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
            '            lcnota = "Para el pago de la primera cuota, traer adicional al valor de esta " & lntotal.ToString.Trim & " en concepto de Seguro de Deuda y Manejo de Cuenta  "
        End If


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\plandepagos.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try
        Dim reportes As String
        reportes = "Planpagos.pdf"

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsplan1.Tables(0))
        crRpt.Refresh()
        crRpt.SetParameterValue("pcnomcli", Me.txtnomcli.Text.Trim)
        crRpt.SetParameterValue("pcnota", lcnota)

        crRpt.SetParameterValue("cnomana", ("Asesor: " & lcnomana))
        crRpt.SetParameterValue("ccodcta", ("Crédito Nº: " & lccodcta))
        crRpt.SetParameterValue("cdeslin", ("Linea: " & lcdeslin))
        crRpt.SetParameterValue("cnomofi", ("Oficina: " & lcnomofi))

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStreamIA.ToArray())
        'Response.End()
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
    End Sub

    Sub EstadodeCuenta()
        '--------------------------------------------
        Dim lnsaliniint As Double = 0
        Dim ldpagven As Date = Session("gdfecsis")
        Dim lnsalintpen As Double = 0
        Dim lnintpenpag As Double = 0

        '--------------------------------------------

        Dim lccodcli As String = ""
        Dim lccodins, lccodofi, lccodcta As String
        lccodins = Me.Txtccodins.Text.Trim
        lccodofi = Me.txtcCodOfi.Text.Trim
        lccodcta = Me.txtnrocta.Text.Trim

        Dim ds As New DataSet
        Dim codcta As String
        codcta = lccodcta

        If codcta = Nothing Then
            Exit Sub
        End If


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


        Dim m1 As New ccreditos
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date

        Dim ldfecvig As Date
        Dim ldfecven As Date
        Dim lctasa As Double
        Dim lcnumcuo As Double
        Dim fila As DataRow
        Dim lnsaldo As Double

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
        Dim lnservicio As Double = 0
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
        Dim lcFrecint As String = ""
        Dim lcFlat As String = ""
        Dim lnSaldoInteresFlat_total As Double = 0

        gdfecsis = Session("gdfecsis")


        cls1.ccodcta1 = lccodcta
        'como es para una sola cuenta siempre sera 0
        bunacuenta = False

        ldfecha1 = #1/1/1900#
        ldfecha2 = gdfecsis

        'Para Calcular Cuota
        Dim lncuota As Double
        ecremcre.ccodcta = lccodcta
        mcremcre.ObtenerCremcre(ecremcre)

        lccodcli = ecremcre.ccodcli

        '----------------------------------------------------
        Dim lcnomofi As String = ""
        Dim lcnomana As String = ""
        Dim lclinea As String = ""
        Dim lcdireccion As String = ""
        Dim lcagencia As String = ""
        Dim ecreditos As New creditos
        Dim mcreditos As New ccreditos
        ecreditos.ccodcta = codcta

        mcreditos.Obtenercreditos(ecreditos)


        lcnomana = ecreditos.cNomUsu
        lclinea = ecreditos.clineac
        lcdireccion = ecreditos.cdirdom
        lcnomofi = codcta.Substring(3, 3) 'ecreditos.coficina

        etabtofi.ccodofi = lcnomofi
        mtabtofi.ObtenerTabtofi(etabtofi)

        lcagencia = etabtofi.cnomofi.Trim


        '----------------------------------------------------
        clsppal.gnperbas = Session("gnperbas")
        clsppal.pnComtra = Session("gnComTra")
        If ecremcre.dfecvig >= #7/11/2008# Then
            clsppal.pnSegVm = Session("gnSegVm1")
        Else
            clsppal.pnSegVm = Session("gnSegVm")
        End If

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
        Next
        Dim lcformapago1 As String = ""
        Dim lcformapago2 As String = ""
        Dim lctipocuota As String = ""
        Dim lnmonapr As Double = 0
        Dim etabttab As New cTabttab
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
        lcFrecint = ecremcre.cfrecint

        lcformapago1 = IIf(IsDBNull(ecremcre.cfreccap), "", etabttab.Describe(ecremcre.cfreccap, "060"))
        lcformapago2 = IIf(IsDBNull(ecremcre.cfrecint), "", etabttab.Describe(ecremcre.cfrecint, "060"))
        lctipocuota = IIf(ecremcre.cflat = "F", "FLAT", "FIJA NIVELADA")

        Dim lccondic As String = ""
        Dim lcstatus As String = ""

        lccondic = IIf(IsDBNull(ecremcre.ccondic), "", ecremcre.ccondic)
        lcstatus = mcremcre.StatusCredito(lccondic)

        Dim lnciclo As Integer

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
            '            Response.Write("<script language='javascript'>alert('codigo de cliente en blanco')</script>")
            codigoJs = "<script language='javascript'>alert('Codigo de cliente en blanco, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)
        lcteldom = eclimide.cteldom
        lcnumcasa = " "
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

        ldfecval = Session("gdfecsis")
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

        '        Try
        '            etabtofi.ccodofi = lccodofi
        '           mtabtofi.ObtenerTabtofi(etabtofi)
        '          Me.txtagencia.Text = etabtofi.cnomofi

        '       Catch ex As Exception
        '      Response.Write("<script language='javascript'>alert('error al obtener oficinas')</script>")
        '     End Try

        'Try
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

            lntasint = Math.Round(ecretlin.ntasint / 12, 2)
            lntasmor = Math.Round(ecretlin.ntasmor / 12, 2)

            lsegdan = 0 'ecretlin.lsegdan
            lreserva = 0 'ecretlin.lreserva
            ltalona = 0 'ecretlin.ltalona
            ladmon = 0 'ecretlin.ladmon1

            'Catch ex As Exception
            'Response.Write("<script language='javascript'>alert('error al obtener linea')</script>")
            'End Try


            lnservicio = Math.Round(clsaplica.pnsalser, 2)
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
                '        lccalif = clsppal.Califica(lndiasatr)
            Else
                Dim lndiashis As Integer
                lndiashis = m1.diashis(lccodcta)
                lccalif = clsppal.Califica(lndiasatr, lcFrecint) 'clsppal.Califica(lndiashis)
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



            lnsegdeu = clsppal.CalcularSeguroDeuda(lccodcta, ldfecval, lnsalcap, clsaplica.pdfecvig)
            lngasadm = clsppal.CalcularManejo(lccodcta, ldfecval, clsaplica.pncapdes, False)
            lniva = clsppal.CalcularIVAManejo(Session("gnIVA"), (lngasadm + lnintere + lnintmor))

            '----------------------------------------------------------
            lnmonpag = utilNumeros.Redondear(lnmorcap + lnintere + lnservicio + lnintmor + lnsegdeu + lnsegdan + lntalona + lnreserva + lngasadm + lniva, 2)

            Dim ecredppg As New cCredppg
            lnsalteo = ecredppg.ObtenerSaldoTeorico(lccodcta, ldfecval, lncapdes)
            '---------------------------------------------------------------
            lnsaliniint = ecredppg.ObtenerSaldoInteresPlan(lccodcta)
            If lndiasatr > 0 Then
                ldpagven = DateAdd(DateInterval.Day, (lndiasatr * (-1)), ldfecval)
            End If
            lnsalintpen = ecredppg.InteresPendiente(lccodcta, ldfecval)
            lnintpenpag = ecredkar.InteresPendientePagado(lccodcta, ldfecval)


            If lcFlat = "F" Then
                lnSaldoInteresFlat_total = ecredppg.Extrae_Saldo_Interes_Total_Flat(lccodcta, ldfecval)
            Else
                lnSaldoInteresFlat_total = 0
            End If

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

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            Dim dstipo As New DataSet
            Dim mcrepgar As New cCrepgar
            Dim nelemgar As Integer

            dstipo = clsppal.Garantizados(lccodcli.Trim)

            nelemgar = dstipo.Tables(0).Rows.Count
            If nelemgar = 0 Then
                lcgarantia = ""
            ElseIf (nelemgar = 1) Then
                lcgarantia = dstipo.Tables(0).Rows(0)("cdescri")
            Else
                If dstipo.Tables(0).Rows(0)("ctipgar") = "05" Then
                    lcgarantia = "CREDITO PREFERENCIAL"
                Else
                    lcgarantia = "MIXTA"
                End If
            End If
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        End If


        '***********************************************************
        '********************  reporte *********************



        Dim ldfecproval As Date
        ldfecproval = Session("gdfecsis")
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
        crRpt.SetParameterValue("nsalmor", lnintmor)
        crRpt.SetParameterValue("nsegdeu", lnsegdeu) 'seguro de deuda
        crRpt.SetParameterValue("nsegdan", lnsegdan)
        crRpt.SetParameterValue("nreserva", lnreserva)
        crRpt.SetParameterValue("ntalona", lntalona)
        crRpt.SetParameterValue("ngasadm", lngasadm) 'comision
        crRpt.SetParameterValue("ndiaatr2", lndiasatr.ToString.Trim)
        crRpt.SetParameterValue("dultpag", ldultpag)
        crRpt.SetParameterValue("dfecsis", ldfecproval)
        crRpt.SetParameterValue("ntotal", lnmonpag)

        crRpt.SetParameterValue("cnomcli", Me.txtnomcli.Text.Trim)
        crRpt.SetParameterValue("cnomusu", lcnomana)
        crRpt.SetParameterValue("agencia", lcagencia)

        crRpt.SetParameterValue("numcasa", lcnumcasa)
        crRpt.SetParameterValue("ccodcli", Me.txtcodcli.Text)

        crRpt.SetParameterValue("nCapDes", lncapdes)
        crRpt.SetParameterValue("ncappag", lncappag)
        crRpt.SetParameterValue("ntotpag", lntotpag)
        crRpt.SetParameterValue("linea", lclinea)
        crRpt.SetParameterValue("direccion", lcdireccion)
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
        crRpt.SetParameterValue("nsalser", lnservicio)

        crRpt.SetParameterValue("pnsaliniint", lnsaliniint)
        crRpt.SetParameterValue("pdpagven", ldpagven)

        crRpt.SetParameterValue("pnsalintpen", lnsalintpen)
        crRpt.SetParameterValue("pnintpenpag", lnintpenpag)
        crRpt.SetParameterValue("pnsalint_total_Flat", lnSaldoInteresFlat_total)
        crRpt.SetParameterValue("pcFlat", lcFlat)

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

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        EstadodeCuenta()
    End Sub


    Public Sub Ejecutar(ByVal sender As Object, ByVal e As EventArgs)
        btngrabar_Click(sender, e)
    End Sub
  
    Private Sub ImpresionEspecial()
        Dim printDoc As New PrintDocument
        ' asignamos el método de evento para cada página a imprimir
        AddHandler printDoc.PrintPage, AddressOf print_PrintPage
        ' indicamos que queremos imprimir
        printDoc.Print()
    End Sub
    Private Sub print_PrintPage(ByVal sender As Object, _
                          ByVal e As PrintPageEventArgs)

     
        '' La fuente a usar
        Dim prtFont As New Font("Verdana", 10, FontStyle.Regular)
        Dim fontTitulo As New Font("Verdana", 10, FontStyle.Regular)

        Dim Título As String = ""

        'e.HasMorePages = False
        ' Este evento se produce cada vez que se va a imprimir una página
        Dim lineHeight As Single
        Dim yPos As Single = e.MarginBounds.Top
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim printFont As System.Drawing.Font
        Dim lineaActual As Integer = 0

        Dim lccodcta As String
        Dim lcfecha2 As String = Left(Session("gdfecsis").ToString, 10)
        lccodcta = Me.txtnrocta.Text.Trim
        Dim lccodcli As String = txtcodcli.Text.Trim
        Dim lcnomcli As String = txtnomcli.Text.Trim
        ' Asignar el tipo de letra
        printFont = prtFont
        lineHeight = printFont.GetHeight(e.Graphics)


        yPos = 0

        e.Graphics.DrawString(lcfecha2, fontTitulo, _
                              Brushes.Black, leftMargin, yPos)
        yPos += fontTitulo.GetHeight(e.Graphics)


        yPos += lineHeight

        e.Graphics.DrawString(StrDup(30, Chr(32)) & "FUNDEA", _
                              fontTitulo, Brushes.Black, leftMargin, yPos)

     
       

        Dim linea As String
        linea = StrDup(80, "=")
        yPos += lineHeight
        e.Graphics.DrawString(linea, _
                              fontTitulo, Brushes.Black, leftMargin, yPos)

        yPos += lineHeight
        e.Graphics.DrawString("Nº DE PRESTAMO: " & lccodcta & " CUOTA: " & Format(Double.Parse(txtmoncuo.Text), "Q###,###0.00 "), _
                              fontTitulo, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        e.Graphics.DrawString("CODIGO: " & lccodcli & "  NOMBRE: " & lcnomcli, _
                              fontTitulo, Brushes.Black, leftMargin, yPos)

      
        yPos += lineHeight
        e.Graphics.DrawString(linea, _
                              fontTitulo, Brushes.Black, leftMargin, yPos)

        'If pnkp1 <> 0 Then
        '    yPos += lineHeight
        '    e.Graphics.DrawString(lcctakp & StrDup(15, Chr(32)) & "Capital:" & StrDup(37, Chr(32)) & Format(pnkp1, "$###,###0.00 "), _
        '                          fontTitulo, Brushes.Black, leftMargin, yPos)
        'End If
        'If pnin1 <> 0 Then
        '    yPos += lineHeight
        '    e.Graphics.DrawString(lcctain & StrDup(15, Chr(32)) & "Interes:" & StrDup(37, Chr(32)) & Format(pnin1, "$###,###0.00 "), _
        '                          fontTitulo, Brushes.Black, leftMargin, yPos)
        'End If
        'If pnmo1 <> 0 Then
        '    yPos += lineHeight
        '    e.Graphics.DrawString(lcctamo & StrDup(15, Chr(32)) & "Mora:" & StrDup(40, Chr(32)) & Format(pnmo1, "$###,###0.00 "), _
        '                          fontTitulo, Brushes.Black, leftMargin, yPos)
        'End If

      
        'yPos += lineHeight
        'e.Graphics.DrawString("PAGO TOTAL: " & StrDup(69, Chr(32)) & Format(pntotal1, "$###,###0.00 "), _
        '                      fontTitulo, Brushes.Black, leftMargin, yPos)

        yPos += lineHeight
        yPos += lineHeight
        yPos += lineHeight
        e.Graphics.DrawString("CAJERO:" & StrDup(2, Chr(32)) & Session("gcCodusu"), _
                              fontTitulo, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        yPos += lineHeight
        e.Graphics.DrawString(StrDup(30, Chr(32)) & "FIRMA Y SELLO DEL CAJERO ", _
                              fontTitulo, Brushes.Black, leftMargin, yPos)


      
        e.HasMorePages = False

    End Sub
    Private Sub Imprimir_Ticket()
        Dim ticket As New Ticket()
        ticket.AddHeaderLine("ChafiTienda")
        ticket.AddHeaderLine("EXPEDIDO EN:")
        ticket.AddHeaderLine("CALLE CONOCIDA")
        ticket.AddHeaderLine("PUEBLA, PUEBLA")
        ticket.AddHeaderLine("RFC: CSI-020226-MV4")

        ticket.AddSubHeaderLine("Ticket # 1")
        ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())

        ticket.AddItem("Cantidad", "Nombre producto", "Total")

        ticket.AddTotal("SUBTOTAL", "12.00")
        ticket.AddTotal("IVA", "0")
        ticket.AddTotal("TOTAL", "24")
        ticket.AddTotal("", "")
        ticket.AddTotal("RECIBIDO", "0")
        ticket.AddTotal("CAMBIO", "0")
        ticket.AddTotal("", "")

        ticket.AddFooterLine("VUELVA PRONTO")

        ticket.PrintTicket("EPSON LX-300+ /II") 'Nombre de la impresora de tickets
    End Sub
    Private Sub Imprimir_Ticket2()
        Dim sw1 As System.IO.StreamWriter = System.IO.File.CreateText("C:\txt\recibo.txt")
        sw1.WriteLine("Esta es una prueba para el salto de linea.")
        sw1.Write("Esta no salta linea. ")
        sw1.Write("Continua con la linea anterior")
        sw1.WriteLine("Linea nueva")
        sw1.Close()
        Try
          
            'Shell("print /d:LPT1 C:\txt\recibo.txt") 'si quieres en FUNCIONA ESTA LINEA CORRECTAMENTE
            ' Shell("print /d:USB001 C:\txt\recibo.txt")
            'un puerto COM : "print/d:COM1 C:\txt\recibo.txt"

            'Dim fileToPrint As System.IO.StreamReader
            'Dim printFont As System.Drawing.Font
            'Dim PrintPath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            'fileToPrint = New System.IO.StreamReader(PrintPath & "\myFile.txt")
            'printFont = New System.Drawing.Font("Arial", 10)
            'PrintDocument1.Print()
            'fileToPrint.Close()
        Catch X As System.IO.FileNotFoundException
            MsgBox(X.Message)
        End Try

        
    End Sub

   
   

    Protected Sub btnActivar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnActivar.Click
        If Session("fuente") = "1" Then
            Me.btngrabar.Enabled = True
            Grabar2.Enabled = True
            cmbtippag.Enabled = True
        Else
            '            Response.Write("<script language='javascript'>alert('Verifique Credenciales de Autorización')</script>")
            codigoJs = "<script language='javascript'>alert('Verifique Credenciales de Autorización, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End If
        
    End Sub
    Private Sub prueba()



        Dim jws As New referenciaws.ConsultarRemesa()
        Dim jws1 As New referenciaws.RespuestaConsultaRemesa

        jws.ID_INTEGRACION = "7930d46828f5a0c2"
        jws.ID_PAGADOR = "FUNDEA"


        jws.BEN_PRIMER_NOMBRE = ""
        jws.BEN_SEGUNDO_NOMBRE = ""
        jws.BEN_PRIMER_APELLIDO = ""
        jws.BEN_SEGUNDO_APELLIDO = ""


      
        Dim ProxyGetStocks As New referenciaws.PagadorService
        jws1 = ProxyGetStocks.Consulta(jws)

        Dim lnregistro As Integer, lcmensaje As String, lcintegracion As String, lccodmensaje As String, lcusuario As String
        lnregistro = jws1.CANTIDAD_REGISTROS
        lccodmensaje = jws1.CODIGO_MENSAJE
        lcintegracion = jws1.ID_INTEGRACION
        lcmensaje = jws1.TEXTO_MENSAJE
        lcusuario = jws1.USUARIO

        Dim listado(lnregistro, 26) As String
        For i As Integer = 0 To lnregistro - 1
            listado(i, 1) = jws1.LISTADO(i).BEN_PAIS
            listado(i, 2) = jws1.LISTADO(i).BEN_PRIMER_APELLIDO
            listado(i, 3) = jws1.LISTADO(i).BEN_PRIMER_NOMBRE
            listado(i, 4) = jws1.LISTADO(i).BEN_SEGUNDO_APELLIDO
            listado(i, 5) = jws1.LISTADO(i).BEN_SEGUNDO_NOMBRE
            listado(i, 6) = jws1.LISTADO(i).BEN_TELEFONO
            listado(i, 7) = jws1.LISTADO(i).CORRELATIVO_ID
            listado(i, 8) = jws1.LISTADO(i).ESTADO_GIRO
            listado(i, 9) = jws1.LISTADO(i).ID_INTEGRACION
            listado(i, 10) = jws1.LISTADO(i).ID_INTERNO
            listado(i, 11) = jws1.LISTADO(i).ID_OPERACION
            listado(i, 12) = jws1.LISTADO(i).MONEDA_ORIGEN
            listado(i, 13) = jws1.LISTADO(i).MONEDA_PAGO
            listado(i, 14) = jws1.LISTADO(i).OBSERVACIONES
            listado(i, 15) = jws1.LISTADO(i).REM_CIUDAD
            listado(i, 16) = jws1.LISTADO(i).REM_DIRECCION
            listado(i, 17) = jws1.LISTADO(i).REM_ESTADO
            listado(i, 18) = jws1.LISTADO(i).REM_PAIS
            listado(i, 19) = jws1.LISTADO(i).REM_PRIMER_APELLIDO
            listado(i, 20) = jws1.LISTADO(i).REM_PRIMER_NOMBRE
            listado(i, 21) = jws1.LISTADO(i).REM_SEGUNDO_APELLIDO
            listado(i, 22) = jws1.LISTADO(i).REM_SEGUNDO_NOMBRE
            listado(i, 23) = jws1.LISTADO(i).REMESADOR
            listado(i, 24) = jws1.LISTADO(i).TASA_CAMBIO.ToString
            listado(i, 25) = jws1.LISTADO(i).VALOR_ENVIADO.ToString
            listado(i, 26) = jws1.LISTADO(i).VALOR_PAGAR.ToString
        Next



        'agregar al web config
        '  <system.net>
        '<settings>
        '   <httpWebRequest useUnsafeHeaderParsing = "true"/>
        '</settings>
        '</system.net>
        'en el appsetting : 	<add key="referenciaws.Pagador" value="http://portal.redchapina.com/Pagador.php"/>
    End Sub
  

    
    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        prueba()
    End Sub
End Class


