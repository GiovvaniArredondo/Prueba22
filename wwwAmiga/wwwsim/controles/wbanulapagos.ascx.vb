Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class wbanulapagos
    Inherits ucWBase


#Region "Privadas"
    Private dsimprimepagos As New DataSet
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

    End Sub
    
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        viewstate.Add("pccodcta", codigoCliente)

        'VALIDA SI ES CAJERO Y SI TIENE SU CAJA ABIERTA PARA PODER OPERAR PAGOS CAJ=2
        Dim eusuario As New cusuarios
        Dim eusuariogrupo As New cUsuarioGrupo
        Dim ds As New DataSet
        Dim ecredkar As New cCredkar
        Dim lprocede As Boolean

        btngrabar.Enabled = False
        lprocede = ecredkar.VerificaProcedeCaja(Session("gccodusu"), "A")
        If lprocede = True Then
            'Response.Write("<script language='javascript'>alert('Verifique no hay caja abierta')</script>")
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

        Me.btnAplicar_ServerClick(Me, New System.EventArgs)
        btngrabar.Enabled = True
    End Sub

    Private Sub txtcnrocta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub imprime_recibo(ByVal dsimprimepagos As DataSet)
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
        Dim reportes As String = ""
        reportes = "reversion.pdf"

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
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
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
        lccodcta = viewstate("pccodcta")
        'creditos
        Dim lcoficina As String = ""
        Dim entidadcreditos As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidadcreditos.ccodcta = lccodcta
        ecreditos.Obtenercreditos(entidadcreditos)
        Me.txtnomcli.Text = entidadcreditos.cnomcli
        lcoficina = entidadcreditos.coficina
        Me.txtfecha.Text = Session("gdfecsis") 'Date.Now.ToString.Substring(0, 10)
        Me.txtcomprobante.Text = " "

        'Busca maximo documento
        Dim ecredkar As New cCredkar
        Dim lcnrodoc As String
        lcnrodoc = ecredkar.Obtenercnrodocmax(lccodcta)
        Me.ddlcodofi.SelectedValue = lcoficina 'lccodcta.Substring(3, 3)
        Me.txtcnrodoc.Text = lcnrodoc.Trim

    End Sub

   

    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.ServerClick
        Me.txtcomprobante.Text = " "
        Me.txtfecha.Text = " "
        Me.txtnomcli.Text = " "
        Me.txtcnrocta.Text = " "
        Me.txtcnrodoc.Text = " "
    End Sub

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        'llama funcion que marca de borrado
        Dim clsp As New clspagos
        Dim lnpago As Integer
        Dim clskardex As New ckardex
        Dim lcnrocta As String
        lcnrocta = Me.txtcnrocta.Text.Trim
        If (lcnrocta <> " " Or lcnrocta <> Nothing) And Me.txtcomprobante.Text.Trim <> " " And Me.txtcomprobante.Text.Trim <> Nothing Then
            Try
                clsp.ccodcta1 = ViewState("pccodcta")
                clsp.cnuming = Me.txtcomprobante.Text.Trim
                clsp.cnrodoc = Me.txtcnrodoc.Text.Trim
                clsp.dfecpro = Date.Parse(Me.txtfecha.Text)
                clsp.dfecsis = Session("gdfecsis")
                clsp.ccodusu = Session("gccodusu")

                lnpago = clsp.anulapagos()
                If lnpago = 0 Then
                    'Response.Write("<script language='javascript'>alert('La Fecha o Número de documento no existen')</script>")
                    codigoJs = "<script language='javascript'>alert('La Fecha o Número de documento no existen, " & _
                                "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Else
                    btngrabar.Enabled = False
                    'Response.Write("<script language='javascript'>alert('ok')</script>")
                    'codigoJs = "<script language='javascript'>alert('Proceso Correcto, " & _
                    '            "Advertencia SIM.NET ')</script>"
                    'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                    dsimprimepagos = clskardex.ObtenerDataSetPorID2(ViewState("pccodcta"), Date.Parse(Me.txtfecha.Text), _
                                                                    "C", Me.txtcomprobante.Text.Trim, "X")
                    imprime_recibo(dsimprimepagos)
                    Me.btncancela_ServerClick(sender, e)
                End If
            Catch
                'Response.Write("<script language='javascript'>alert('Problema ocurrido con cadena de conexion')</script>")
                codigoJs = "<script language='javascript'>alert('Problema ocurrido con cadena de conexion, " & _
                                "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            End Try
        End If

    End Sub
End Class


