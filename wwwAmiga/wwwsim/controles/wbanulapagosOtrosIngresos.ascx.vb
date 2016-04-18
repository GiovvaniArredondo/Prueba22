Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web


Partial Class wbanulapagosOtrosIngresos
    Inherits ucWBase
    Dim dsimprimepagos As New DataSet
    Dim cls1 As New SIM.BL.pagdesver
    Dim clsppal As New SIM.BL.class1
    Private cClsAdP As New SIM.BL.ClsAdPart
    Private clsConvert As New SIM.BL.ConversionLetras

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
        mlistaoficina = clstabtofi.ObtenerListaporNivel(Session("gnnivel"), Session("gcCodOfi"))

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
        'carga cuentas bancarias asignadas a la agencia
        Dim dsb As New DataSet
        clsbancos.ObtenerDatasetporid(dsb, Session("gcCodofi"))
        Me.cmbbanco.DataTextField = "cnombco"
        Me.cmbbanco.DataValueField = "ccodbco"
        Me.cmbbanco.DataSource = dsb.Tables(0)
        Me.cmbbanco.DataBind()

        'carga productos
        Dim mListaTabttab As New listatabttab
        mListaTabttab = clstabttab.ObtenerLista("125", "1")

        Me.ddlproducto.DataTextField = "cdescri"
        Me.ddlproducto.DataValueField = "ccodigo"
        Me.ddlproducto.DataSource = mListaTabttab
        Me.ddlproducto.DataBind()

        'carga tipo de ingreso
        mListaTabttab = clstabttab.ObtenerLista("117", "1")
        Me.ddlingreso.DataTextField = "cdescri"
        Me.ddlingreso.DataValueField = "ccodigo"
        Me.ddlingreso.DataSource = mListaTabttab
        Me.ddlingreso.DataBind()

    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente
        ViewState.Add("pccodcta", codigoCliente)
        '        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
        Dim entidadcremcre As New cremcre
        Dim ecremcre As New cCremcre
        entidadcremcre.ccodcta = codigoCliente
        ecremcre.ObtenerCremcre(entidadcremcre)
        Dim lcoficina As String
        lcoficina = entidadcremcre.coficina
        ddlcodofi.SelectedValue = lcoficina

        Dim entidad1 As New SIM.EL.climide
        Dim eclimide As New SIM.BL.cClimide
        entidad1.ccodcli = codigoCliente
        eclimide.ObtenerClimide(entidad1)
        Me.txtnomcli.Text = entidad1.cnomcli
        Me.txtcomprobante.Text = ""

    End Sub


    Private Sub imprime_recibo(ByVal boleta As String, ByVal ccodcli As String)
        Dim dsimprimepagos As New DataSet
        Dim ecntamov As New cCntamov

        dsimprimepagos = ecntamov.BuscaPolizaReversadaOtrosIngresosParaImpresion(ccodcli, boleta, Me.ddlingreso.SelectedValue.Trim)

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
            crRpt.Load(Server.MapPath("reportes") + "\crpRevOtrosIngresos.rpt", OpenReportMethod.OpenReportByDefault)
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
        Response.AddHeader("Content-Disposition", "attachment;filename=comprobante_reversion.pdf")

        Response.BinaryWrite(rptStream.ToArray())
        Response.Flush()
        Response.Close()

    End Sub
    Private Overloads Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub


    Private Sub btngrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.ServerClick

        Dim ecredkar As New cCredkar
        Dim ecntamov As New cCntamov
        Dim etabtbco As New cTabtbco
        Dim lccodcta As String = ""
        Dim Monto As Decimal = 0
        Dim NumeroReversiones = 0

        Dim dsPoliza As New DataSet

        'VALIDA EL MONTO QUE NO SEA CERO
        If Double.Parse(Me.txtcomprobante.Text.Trim) <= 0 Then
            Response.Write("<script language='javascript'>alert('Monto Inválido')</script>")
            Return
        End If

        'VERIFICA SI LA BOLETA DE OTROS INGRESOS EXISTE
        dsPoliza = ecntamov.BuscaPolizaOtrosIngresos(Me.txtcnrocta.Text.Trim, Me.txtcomprobante.Text.Trim, Me.ddlingreso.SelectedValue.Trim, Me.txtRecibo.Text.Trim)


        If dsPoliza.Tables(0).Rows.Count = 0 Then
            Response.Write("<script language='javascript'>alert('No existe boleta para aplicar reversion')</script>")
            Return
        End If


        'OBTIENE EL VALOR OTROS INGRESOS DE LA POLIZA ENCONTRADA
        Monto = dsPoliza.Tables(0).Rows(0).Item("ndebe")

        'SI EXISTE LA BOLETA VERIFICA QUE NO TENGA UN EXTORNO YA APLICADO
        'dsPoliza = ecntamov.BuscaPolizaReversadaOtrosIngresos(Me.txtcnrocta.Text.Trim, Me.txtcomprobante.Text.Trim, Me.ddlingreso.SelectedValue.Trim)
        NumeroReversiones = ecntamov.VerificarReversionOtrosIngresos(Me.txtcnrocta.Text.Trim, Me.txtcomprobante.Text.Trim, Me.ddlingreso.SelectedValue.Trim)

        If NumeroReversiones = 0 Then
            Response.Write("<script language='javascript'>alert('la boleta ya fue reversada mas de una vez')</script>")
            Return
        End If

        'If dsPoliza.Tables(0).Rows.Count <> 0 Then
        '    Response.Write("<script language='javascript'>alert('La boleta ya fue extornada, no puede extornarse nuevamente')</script>")
        '    Return
        'End If


        Dim eclimide As New cClimide
        Dim entidadclimide As New climide
        Dim lccodofi As String = ""

        Dim oki As String = ""
        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak
        Dim etabttab As New cTabttab
        Dim lcconcepto As String
        Dim lcdescri As String

        lcdescri = etabttab.Describe(Me.ddlingreso.SelectedValue.Trim, "117")
        lcconcepto = "REV. OTROS INGRESOS POR " + Trim(lcdescri)

        entidadclimide.ccodcli = ViewState("pccodcta")

        eclimide.ObtenerClimide(entidadclimide)
        lccodofi = entidadclimide.ccodofi

        Dim etabtofi As New cTabtofi
        Dim lccomprobante0 As String = "1"

        'lccomprobante0 = etabtofi.ObtieneCorrelativo(Session("gcCodofi"))
        'etabtofi.ActualizaCorrelativo(Session("gcCodofi"))


        'Graba Partida contable
        cClsAdP._dfecmod = Session("gdfecsis")
        cClsAdP._ccodusu = Session("gcCodusu")
        cClsAdP._ccodofi = lccodofi 'Session("gcCodofi")
        cClsAdP._cconcepto = lcconcepto
        cClsAdP._dfeccnt = Session("gdfecsis")
        cClsAdP._cpoliza = "EG"
        cClsAdP._nCuenta = 1
        cClsAdP._cnumdoc = Me.txtcomprobante.Text.Trim
        cClsAdP._llbandera = True
        cClsAdP._ccodpres = ViewState("pccodcta")
        cClsAdP._ffondos = "99"
        cClsAdP._cnumrec = ""
        cClsAdP._pccodcli = Me.ddlingreso.SelectedValue.Trim

        Dim lcctactb As String


        lcctactb = etabtbco.CuentaContableBanco(Me.cmbbanco.SelectedValue.Trim)

        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
        cClsAdP._ccodcta = lcctactb
        cClsAdP._ndebe = 0
        cClsAdP._nhaber = Monto
        cClsAdP._cclase = "1"


        oki = cClsAdP.AdPartida()

        If oki = "0" Then 'Ocurrio un Error
            Exit Sub
        End If
        cClsAdP._nCuenta += 1

        Dim lcmascara As String = ""
        Dim busquedaplantilla As Integer
        Dim cplanti As String = ""
        Dim lcmetodo As String = ""
        lcmetodo = ddlproducto.SelectedValue.Trim

        'abono
        Dim lcopcion As String
        lcopcion = Me.ddlingreso.SelectedValue.Trim
        lcmascara = "C" & lcopcion.Trim & "NN"


        If lcmascara <> Nothing Then
            entidadtabtmak.ccodigo = lcmascara
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lcctactb = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lcctactb = cplanti.Replace("TP", lcmetodo)
            End If
        End If

        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
        cClsAdP._ccodcta = lcctactb
        cClsAdP._ndebe = Monto
        cClsAdP._nhaber = 0
        cClsAdP._cclase = Left(lcctactb, 1)


        oki = cClsAdP.AdPartida()

        If oki = "0" Then 'Ocurrio un Error
            Exit Sub
        End If

        Me.btngrabar.Disabled = True
        Response.Write("<script language='javascript'>alert('Reversion Aplicada')</script>")

    End Sub

    Protected Sub Imprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        imprime_recibo(Me.txtcomprobante.Text.Trim, Me.txtcnrocta.Text.Trim)
    End Sub
End Class


