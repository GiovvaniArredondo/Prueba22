Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class wbpagosATM
    Inherits ucWBase
    Dim cls1 As New SIM.BL.pagdesver
    Dim clsppal As New SIM.BL.class1

    Protected WithEvents txtfecval As System.Web.UI.WebControls.TextBox
    Dim clsaplica As New SIM.bl.payment
    Dim dsimprimepagos As New DataSet

#Region "Variables"
    Dim ldfecsis As Date
    Dim lcfecha As String

#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            CargarCombos()
        End If

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
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi

        Dim dsc As New DataSet
        Dim dsb As New DataSet
        Dim mListaTabttab As New listatabttab
        Dim mlistainstitu As New listatabttab
        Dim mlistaoficina As New listatabtofi

        Me.txtcapdes.Text = 0
        Me.txtcapita.Text = 0
        Me.txtcomision.Text = 0
        Me.txthonorarios.Text = 0
        Me.txtmora.Text = 0
        Me.txtsegdeu.Text = 0
        Me.txtmanejo.Text = 0
        Me.txtahosim.Text = 0
        Me.txtaporta.Text = 0
        Me.txtahovis.Text = 0
        'Me.txtarcdes.Text = "20" + String.Parse(Session("gdfecsis"))
        ldfecsis = Session("gdfecsis")
        lcfecha = ldfecsis.ToString
        Me.txtarcdes.Text = "20" + lcfecha.Substring(0, 2) + _
lcfecha.Substring(3, 2) + lcfecha.Substring(6, 4)
        mListaTabttab = clstabttab.ObtenerLista("146", "1")
        mlistainstitu = clstabttab.ObtenerLista("054", "1")
        mlistaoficina = clstabtofi.ObtenerLista()
        Me.txtfecpro.Text = Session("gdfecsis")
        Me.cmbtippag.DataTextField = "cdescri"
        Me.cmbtippag.DataValueField = "ccodigo"
        Me.cmbtippag.DataSource = mListaTabttab
        Me.cmbtippag.DataBind()

        clsbancos.ObtenerDatasetporid(dsb, Session("gcCodofi"))
        Me.cmbbanco.DataTextField = "cnombco"
        Me.cmbbanco.DataValueField = "ccodbco"
        Me.cmbbanco.DataSource = dsb.Tables(0)
        Me.cmbbanco.DataBind()

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

        Me.txtfecval2.Text = Session("GDFECSIS")
        Me.btngrabar.EnableViewState = False
        Me.btnaplicar.EnableViewState = True
        Me.txtcCodOfi.Text = Session("gcCodOfi")
    End Sub
    Private Sub btnsalir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Sub cancela()
        Me.txtnrocta.Text = ""
        Me.txtcodcli.Text = ""
        Me.txtnomcli.Text = ""
        Me.txtintere2.Text = 0
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
        Me.txtdeucap.Text = 0
        Me.txtsegdeu.Text = 0
        Me.txtmanejo.Text = 0
        Me.txtahosim.Text = 0
        Me.txtaporta.Text = 0
        Me.txtahovis.Text = 0
        Me.btngrabar.Disabled = False
        Me.btnaplicar.Disabled = True

    End Sub


    Private Sub cmbtippag_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    'Private Sub Button2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.ServerClick
    '    Response.Redirect("wbfecval.aspx")
    'End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtnrocta.Text = codigoCliente.Substring(6, 12)
        Me.txtcCodOfi.Text = codigoCliente.Substring(3, 3)
        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub

    Private Sub btnimprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick
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
        Dim lncomprobante As Integer

        Try
            lccodins = Me.ddlcodins.SelectedItem.Value.Trim
            lccodofi = Me.txtcCodOfi.Text.Trim 'Me.ddlcodofi.SelectedItem.Value.Trim
            lccodcta = lccodins & lccodofi & Me.txtnrocta.Text.Trim
            lncomprobante = Double.Parse(Session("GNCORRELA")) + 1
            Me.txtcompro.Text = lncomprobante.ToString.Trim
            If Me.txtnrocta.Text.Trim = Nothing Then
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
            ok = clsaplica.omcalcinterest("T", ldfecval)
            If ok = 9 Then
                Response.Write("<script language='javascript'>alert('Crédito Cancelado')</script>")
                Exit Try
            End If

            If ok = 1 Then
                Me.txtnrocta.Text = Mid(lccodcta, 7, 12)
                Me.txtcodcli.Text = clsaplica.pccodcli
                Me.txtnomcli.Text = clsaplica.pcnomcli
                Me.txtcuota.Text = utilNumeros.Redondear(clsaplica.pnmoncuo, 2)
                Me.txtintere.Text = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                Me.txtintere2.Text = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                Me.txtmora.Text = utilNumeros.Redondear(clsaplica.pnsalmor, 2)
                ' Me.txtcapita.Text = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
                Me.txtcapita.Text = utilNumeros.Redondear(clsaplica.pndeucap, 2).ToString()

                Me.txtsaldo.Text = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
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
                CalculaSeg()
                lnsegdeu = clsppal.pnSegDeu

                'lnsegdeu = utilNumeros.Redondear((lnpropseg * lnsalcap) * lnmeses, 2)
                lnmanejo = utilNumeros.Redondear(lnpropman * lnmeses, 2)

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
                Me.txtmanejo.Text = utilNumeros.Redondear(lnmanejo, 2)
                Me.txtsegdeu.Text = utilNumeros.Redondear(lnsegdeu, 2)
                Me.txtdeuefe.Text = utilNumeros.Redondear(clsaplica.pndeucap + clsaplica.pnsalint + clsaplica.pnsalmor + lnsegdeu, 2).ToString()
                'fin ahorros
                Me.txtmoncuo.Text = utilNumeros.Redondear(clsaplica.pnmoncuo, 2).ToString
                lntotal = utilNumeros.Redondear(Double.Parse(Me.txtsaldo.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text), 2).ToString
                Me.txtmonpag.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtsegdeu.Text) + Double.Parse(Me.txtmanejo.Text) + Double.Parse(Me.txtaporta.Text) + Double.Parse(Me.txtahosim.Text), 2).ToString
                Me.txttotal.Text = lntotal
                'variables de cesion necesarias para los calculos
                viewstate.Add("pnintpag1", clsaplica.pnintpag)
                viewstate.Add("pnintpen1", clsaplica.pnintpen)
                viewstate.Add("pnintcal1", clsaplica.pnintcal)
                viewstate.Add("pnmorpag1", clsaplica.pnmorpag)
                viewstate.Add("pnpagcta1", clsaplica.pnpagcta)
                viewstate.Add("pnintmor1", clsaplica.pnintmor)
                viewstate.Add("pdultpag1", clsaplica.pdultpag)
                Me.btngrabar.Disabled = False
                Me.btnaplicar.Disabled = True

            Else
                Response.Write("<script language='javascript'>alert('Cuenta no tiene movimientos')</script>")
            End If
        Catch
            Response.Write("<script language='javascript'>alert('Problemas con cadena de conexión')</script>")
        End Try

    End Sub

    Private Sub btngrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.ServerClick
        'graba datos
        Dim ok As Integer
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
        Dim lcbanco As String
        Dim lctippag As String
        Dim lccomprobante As String
        Dim lccodins As String
        Dim lccodofi As String
        Dim dr As DataRow
        Dim ldfecha As Date
        Dim clskardex As New ckardex

        If Me.txtnrocta.Text.Trim = Nothing Then
            Response.Write("<script language='javascript'>alert('Cuenta vacía')</script>")
            Return
        End If
        If Double.Parse(Me.txtmonpag.Text) = 0 Then
            Response.Write("<script language='javascript'>alert('Monto inválido')</script>")
            Return
        End If

        Try
            'coloca el valor del resultado a grabar
            'actualiza nuevamente las propiedades con lo pagado
            'para evitar enviar parametros.
            lccodins = Me.ddlcodins.SelectedItem.Value.Trim
            lccodofi = Me.ddlcodofi.SelectedItem.Value.Trim
            lccodcta = lccodins & lccodofi & Me.txtnrocta.Text.Trim
            lncapita = Double.Parse(Me.txtcapita.Text)
            lnintere = Double.Parse(Me.txtintere2.Text)
            lncomision = Double.Parse(Me.txtcomision.Text)
            lnhonorarios = Double.Parse(Me.txthonorarios.Text)
            lngestion = Double.Parse(Me.txtgestion.Text)
            lnmonpag = Double.Parse(Me.txtmonpag.Text)
            ldfecval = Date.Parse(Me.txtdultpag.Text)
            lnmora = Double.Parse(Me.txtmora.Text)
            lnsaldo = Double.Parse(Me.txtsaldo.Text)
            lctippag = Me.cmbtippag.SelectedItem.Value.Trim
            lcbanco = Me.cmbbanco.SelectedItem.Value.Trim
            lccomprobante = Me.txtcompro.Text.Trim
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
            cls1.gdfecsis = Session("gdfecsis")
            cls1.gccodusu = "9999"
            cls1.ahosim = Double.Parse(Me.txtahosim.Text)
            cls1.ahovis = Double.Parse(Me.txtahovis.Text)
            cls1.aporta = Double.Parse(Me.txtaporta.Text)
            cls1.segdeu = Double.Parse(Me.txtsegdeu.Text)
            cls1.manejo = Double.Parse(Me.txtmanejo.Text)

            'actualiza propiedades de la pagdesver
            cls1.pnintpag = viewstate("pnintpag1")  'clsaplica.pnintpag
            cls1.pnintpen = viewstate("pnintpen1")
            cls1.pnintcal = viewstate("pnintcal1")
            cls1.pnmorpag = viewstate("pnmorpag1")
            cls1.pnpagcta = viewstate("pnpagcta1")
            cls1.pnintmor = viewstate("pnintmor1")
            cls1.pdultpag = viewstate("pdultpag1")
            cls1.pncappag = viewstate("pncappag1")
            cls1.pccodcli = Me.txtcodcli.Text.Trim
            cls1.mxdistribute()
            ldfecha = Session("gdfecsis")
            Dim clspagos1 As New clspagos
            '            dsimprimepagos = clspagos1.conviertepagos_cnuming(lccodcta, lccomprobante)
            dsimprimepagos = clskardex.ObtenerDataSetPorID2(lccodcta, ldfecha, "C", lccomprobante, " ")
            Response.Write("<script language='javascript'>alert('ok')</script>")
            imprime_recibo()
            Me.cancela()

        Catch
            Response.Write("<script language='javascript'>alert('Pago no fue aplicado')</script>")
        End Try
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
        lccodins = Me.ddlcodins.SelectedItem.Value.Trim
        lccodofi = Me.ddlcodofi.SelectedItem.Value.Trim
        lccodcta = lccodins & lccodofi & Me.txtnrocta.Text.Trim
        Dim mcremcre As New cCremcre
        Dim ecremcre As New cremcre
        ecremcre.ccodcta = lccodcta
        mcremcre.ObtenerCremcre(ecremcre)
        clsppal.cCodFor = ecremcre.ctipper
        clsppal.nMonDes = ecremcre.ncapdes
        clsppal.nPerDia = ecremcre.ndiasug
        clsppal.fxSegDeu()

    End Sub

    Private Sub cmbbanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbanco.SelectedIndexChanged
        Dim lcbanco1 As String
        lcbanco1 = Me.cmbbanco.SelectedItem.Value.Trim
        Me.txtarcdes.Text = lcbanco1 + Me.txtarcdes.Text.Substring(2, 8)
    End Sub
End Class


