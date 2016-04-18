Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class wbanulagrudes
    Inherits ucWBase

#Region "Privadas"
    Private dsimprimepagos As New DataSet
    Private clsRev As New SIM.BL.ClsRevDesem
    Private codigoJs As String
#End Region
    

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            cargarcombos()
        End If
    End Sub

    Private Sub cargarcombos()


    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente

        'VALIDA SI ES CAJERO Y SI TIENE SU CAJA ABIERTA PARA PODER OPERAR PAGOS 
        Dim eusuario As New cusuarios
        Dim eusuariogrupo As New cUsuarioGrupo
        Dim ds As New DataSet
        Dim ecredkar As New cCredkar
        Dim lprocede As Boolean
        ImageButton1.Enabled = False

        'lprocede = ecredkar.VerificaProcedeCaja(Session("gccodusu"), "A")
        'If lprocede = True Then
        '    Response.Write("<script language='javascript'>alert('Verifique no hay caja abierta')</script>")
        '    Return
        'End If
        'End If
        lprocede = eusuario.ValidaCuentaCajero(Session("gccodusu"))
        If lprocede = False Then
            'Response.Write("<script language='javascript'>alert('Asignar Cuenta Contable al Cajero')</script>")
            codigoJs = "<script language='javascript'>alert('Asignar Cuenta Contable al Cajero, " & _
                        "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            Return
        End If

        'Verifica Si tiene Pagos este prestamo
        Dim lnmonpag As Decimal = 0

        lnmonpag = ecredkar.ObtenerMontoPagadoG(Me.txtcnrocta.Text.Trim, Session("gdfecsis"), "CJ")
        If lnmonpag > 0 Then
            'Response.Write("<script language='javascript'>alert('Credito Tiene Pagos, No Aplica para Reversión')</script>")
            codigoJs = "<script language='javascript'>alert('Credito Tiene Pagos, No Aplica para Reversión, " & _
                        "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If



        Me.btnAplicar_ServerClick(Me, New System.EventArgs)
        ImageButton1.Enabled = True

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
                    'Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                    codigoJs = "<script language='javascript'>alert('El Cliente elegido no tiene información a ser desplegada, " & _
                               "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
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

        Dim reportes As String
        reportes = "Reversion_Grupal.pdf"

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsimprimepagos.Tables(0))
        crRpt.Refresh()

        'rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        'Response.Clear()
        'Response.Buffer = True
        '' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.End()

        
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
        'Obtiene Fecha de ultimo credito vigente
        Me.txtfecha.Text = Session("gdfecsis") 'Date.Now.ToString.Substring(0, 10)
        Me.txtcomprobante.Text = " "
    End Sub


    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.ServerClick
        Me.txtcomprobante.Text = " "
        Me.txtfecha.Text = " "
        Me.txtnomcli.Text = " "
        Me.txtcnrocta.Text = " "
        Me.txtcnrodoc.Text = " "
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        'Verifica si existe fecha de desembolso y esta vigente
        Dim ecremcre As New cCremcre
        Dim lverifica As Boolean
        lverifica = ecremcre.ValidaExistenciaCredito(Me.txtcnrocta.Text.Trim, Date.Parse(Me.txtfecha.Text))
        If lverifica = False Then
            'Response.Write("<script language='javascript'>alert('Verifique Fecha o Vigencia de Crédito')</script>")
            codigoJs = "<script language='javascript'>alert('Verifique Fecha o Vigencia de Crédito, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'Verifica si tiene pagos los desembolsos
        Dim ecredkar As New cCredkar
        Dim lvalida As Boolean
        lvalida = ecredkar.ValidaPagosRevertirDes(Me.txtcnrocta.Text.Trim, Date.Parse(Me.txtfecha.Text))
        If lvalida = False Then
            'Response.Write("<script language='javascript'>alert('Tiene Pagos Aplicados')</script>")
            codigoJs = "<script language='javascript'>alert('Tiene Pagos Aplicados, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'inicar proceso
        Dim ds As New DataSet
        ds = ecremcre.ObtenerCreditosxGrupo(Me.txtcnrocta.Text.Trim, Date.Parse(Me.txtfecha.Text), Date.Parse(Me.txtfecha.Text))
        If ds.Tables(0).Rows.Count = 0 Then
            'Response.Write("<script language='javascript'>alert('No Existen miembros del Grupo')</script>")
            codigoJs = "<script language='javascript'>alert('No Existen miembros del Grupo, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lccodcta As String
        Dim lcnomcli As String
        Dim lcnrodoc As String
        Dim lcnrochq As String
        Dim ncanti As Integer = 0
        Dim dschq As New DataSet
        For Each fila In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(i)("cCodcta")
            lcnrodoc = ecredkar.ObtenercnrodocmaxDes(lccodcta)
            lcnomcli = ds.Tables(0).Rows(i)("cnomcli")

            Try
                'Revertir provision
                'Genera Partida Contable de Provision
                Dim x As Integer
                x = clsRev.RevierteProvisionContable(lccodcta, Session("gdfecsis"), Session("gccodusu"))
                If x = 9 Then
                    'Response.Write("<script language='javascript'>alert('Ocurrio un Problema, No se Reverso')</script>")
                    codigoJs = "<script language='javascript'>alert('Ocurrio un Problema, No se Reverso, " & _
                               "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                    Return
                End If
                'Revertir provision
                ecremcre.ReseteaProvision(lccodcta)

                dschq = ecredkar.Obtenerdatasetporid1(lccodcta, "D", " ", lcnrodoc)

                ncanti = dschq.Tables(0).Rows.Count()

                If ncanti = 0 Then  'En caso que no devuelva nada se sale
                Else
                    lcnrochq = IIf(IsDBNull(dschq.Tables(0).Rows(0)("cnuming")), "", dschq.Tables(0).Rows(0)("cnuming"))

                    Grabadora(lccodcta, lcnomcli, lcnrodoc, lcnrochq)

                End If

            Catch ex As Exception

            End Try
            i += 1
        Next
        ImageButton1.Enabled = False
        'Response.Write("<script language='javascript'>alert('Proceso Correcto')</script>")
        codigoJs = "<script language='javascript'>alert('Proceso Correcto, " & _
                   "Aviso SIM.NET ')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)


    End Sub

    Private Sub Grabadora(ByVal cCodcta As String, ByVal cnomcli As String, ByVal cnrodoc As String, ByVal cnrochq As String)
        clsRev._gdFecsis = Session("gdfecsis")
        clsRev._gcCodUsu = Session("gcCodUsu")
        clsRev._cCuenta = cCodcta
        clsRev._cNrodoc = cnrodoc
        clsRev._cGlosa = " REVERSION DE DESEMBOLSO # " & cCodcta + " A NOMBRE DE " & cnomcli
        clsRev._cOficina = cCodcta.Substring(3, 3)
        clsRev._cReg = cCodcta.Substring(0, 3)
        clsRev._cNrochq = cnrochq

        clsRev.Revierte()

    End Sub
End Class


