Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class wbanulapagosct
    Inherits ucWBase
    Dim dsimprimepagos As New DataSet

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            cargarcombos()
        End If
    End Sub

    Private Sub cargarcombos()


    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente
        Me.btnAplicar_ServerClick(Me, New System.EventArgs)

    End Sub

    Private Sub txtcnrocta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
            crRpt.Load(Server.MapPath("reportes") + "\crrevpagos.rpt", OpenReportMethod.OpenReportByDefault)
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
    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub


    Private Sub btnAplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.ServerClick
        Dim lccodcta As String
        Me.txtcomprobante.Text = Nothing
        lccodcta = Me.txtcnrocta.Text.Trim
        'creditos
        Dim ecremsol As New cCremsol
        Me.txtnomcli.Text = ecremsol.ObtenerNombre(lccodcta)
        Me.txtfecha.Text = Session("gdfecsis") 'Date.Now.ToString.Substring(0, 10)
        Me.txtcomprobante.Text = " "
        CargaFechas()
    End Sub

    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.ServerClick
        Me.txtcomprobante.Text = " "
        Me.txtfecha.Text = " "
        Me.txtnomcli.Text = " "
        Me.txtcnrocta.Text = " "
        Me.txtcnrodoc.Text = " "
    End Sub

    Private Function CargaFechas() As Boolean
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        ds = ecreditos.CargaFechas(Me.txtcnrocta.Text.Trim)

        If ds.Tables(0).Rows.Count = 0 Then
            '    Me.cbxFechas.Enabled = False
            Me.btngrabar.Enabled = False
            Return False
        Else
            '   Me.cbxFechas.Enabled = True
            Me.btngrabar.Enabled = True

        End If

        Me.cbxFechas.DataTextField = "dfecvig"
        Me.cbxFechas.DataValueField = "dfecvig"
        Me.cbxFechas.DataSource = ds.Tables(0)
        Me.cbxFechas.DataBind()
        Return True
    End Function

    'Private Function SOSReconstruir() As Integer
    '    Dim ecredkar As New cCredkar
    '    Dim ds As New DataSet
    '    Dim clsp As New clspagos

    '    ds = ecredkar.PagosaConstruir()
    '    Dim fila As DataRow
    '    Dim i As Integer = 0
    '    Dim lcnrodoc As String = ""
    '    Dim lnpago As Integer = 0

    '    For Each fila In ds.Tables(0).Rows
    '        lcnrodoc = ds.Tables(0).Rows(i)("cnrodoc")
    '        clsp.ccodcta1 = ds.Tables(0).Rows(i)("cCodcta")
    '        clsp.cnuming = ds.Tables(0).Rows(i)("cnuming")
    '        clsp.cnrodoc = lcnrodoc
    '        clsp.dfecpro = ds.Tables(0).Rows(i)("dfecpro")
    '        clsp.dfecsis = ds.Tables(0).Rows(i)("dfecsis")
    '        clsp.ccodusu = Session("gccodusu")
    '        lnpago = clsp.anulapagos()
    '        i += 1
    '    Next

    '    Return 1
    'End Function

    
    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        'llama funcion que marca de borrado
        Dim clsp As New clspagos
        Dim lnpago As Integer
        Dim clskardex As New ckardex
        Dim lcnrocta As String
        Dim ecremcre As New cCremcre
        lcnrocta = Me.txtcnrocta.Text.Trim

        'Dim Validacion As Boolean
        'Validacion = clsp.FueAplicadoMesActual(Me.txtcomprobante.Text.Trim, Session("gcCodOfi"), Session("gdfecsis"), Me.txtfecha.Text.Trim, Session("gdfecsis"))

        'If Validacion = False Then
        '    Response.Write("<script language='javascript'>alert('No puede reversar pagos que no sean del mismo dia')</script>")
        '    Return
        'End If

        If (lcnrocta <> " " Or lcnrocta <> Nothing) And Me.txtcomprobante.Text.Trim <> " " And Me.txtcomprobante.Text.Trim <> Nothing Then
            Try

                'Carga Dataset con miembros del centro para proceder a Anular pago con pago
                Dim ecredkar As New cCredkar
                Dim ds As New DataSet
                Dim fila As DataRow
                Dim i As Integer = 0
                Dim lncuota As Double = 0
                Dim lnaaplicar As Double = 0
                Dim lcnrodoc As String = ""
                ds = ecremcre.ObtenerSociasporCentroAnular(lcnrocta, cbxFechas.SelectedValue)
                For Each fila In ds.Tables(0).Rows

                    'lcnrodoc = ecredkar.Obtenercnrodocmax(ds.Tables(0).Rows(i)("codigo"))
                    lcnrodoc = ecredkar.UltimadDocumentoProceso(ds.Tables(0).Rows(i)("codigo"), Session("gdfecsis"))
                    clsp.ccodcta1 = ds.Tables(0).Rows(i)("codigo")
                    clsp.cnuming = Me.txtcomprobante.Text.Trim
                    clsp.cnrodoc = lcnrodoc
                    clsp.dfecpro = Date.Parse(Me.txtfecha.Text)
                    clsp.dfecsis = Session("gdfecsis")
                    clsp.ccodusu = Session("gccodusu")
                    lnpago = clsp.anulapagos()
                    i += 1
                Next



                If lnpago = 0 Then
                    Response.Write("<script language='javascript'>alert('La Fecha o Número de documento no existen')</script>")
                Else
                    Response.Write("<script language='javascript'>alert('reversion aplicada')</script>")
                    'dsimprimepagos = clskardex.ObtenerDataSetPorID2(ViewState("pccodcta"), Date.Parse(Me.txtfecha.Text), "C", Me.txtcomprobante.Text.Trim, "X")
                    'imprime_recibo()
                    Me.btncancela_ServerClick(sender, e)
                End If
            Catch
                Response.Write("<script language='javascript'>alert('Problema ocurrido con cadena de conexion')</script>")
            End Try
        End If

        btngrabar.Enabled = False
    End Sub
End Class


