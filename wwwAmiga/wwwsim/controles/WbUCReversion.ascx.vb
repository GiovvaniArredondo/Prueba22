Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class WbUCReversion
    Inherits ucWBase

#Region "Privadas"
    Private codigoJs As String
    Private clsRev As New SIM.BL.ClsRevDesem
#End Region
    

#Region " Metodos "
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Dim lcuenta As String
        Dim gdfecsis As Date

        lcuenta = codigoCliente

        Me.TxtCuenta.Text = codigoCliente.Substring(6, 12)
        Me.TxtInst.Text = codigoCliente.Substring(0, 3)
        Me.TxtOficina.Text = codigoCliente.Substring(3, 3)
        Me.TxtCodigo.Text = lcuenta

        If lcuenta = Nothing Then
            Exit Sub
        End If

        gdfecsis = Session("gdfecsis") 'Carga la fecha de sistema de la Tabtvar

        'VALIDA SI ES CAJERO Y SI TIENE SU CAJA ABIERTA PARA PODER OPERAR PAGOS CAJ=2
        Dim eusuario As New cusuarios
        Dim eusuariogrupo As New cUsuarioGrupo
        Dim ds As New DataSet
        Dim ecredkar As New cCredkar
        Dim lprocede As Boolean

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
        lnmonpag = ecredkar.ObtenerMontoPagado(lcuenta, Session("gdfecsis"), "CJ")
        If lnmonpag > 0 Then
            'Response.Write("<script language='javascript'>alert('Credito Tiene Pagos, No Aplica para Reversión')</script>")
            codigoJs = "<script language='javascript'>alert('Credito Tiene Pagos, No Aplica para Reversión, " & _
                        "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        Me.Aplica()

        Me.btnGrabar.Enabled = True


    End Sub

    Public Sub Limpieza()
        Me.Txtcnrodoc.Text = " "
        Me.TxtCodcli.Text = " "
        Me.TxtCodigo.Text = " "
        Me.TxtCuenta.Text = " "
        Me.TxtDfecvig.Text = " "
        Me.TxtInst.Text = " "
        Me.TxtNomcli.Text = " "
        Me.TxtOficina.Text = " "
        Me.btnGrabar.Enabled = False
        Me.txtcnrochq.Text = " "

    End Sub
    Public Sub Aplica()
        'Sacando los datos necesarios para el Desembolso
        Dim lcestado As String
        Dim lndescuento As Double
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre



        Try


            entidad1.ccodcta = Me.TxtCodigo.Text

            ecreditos.ObtenerCremcre(entidad1)

            lcestado = entidad1.cestado

            If lcestado <> "F" Then
                'Response.Write("<script language='javascript'>alert('Estado de Credito Errado')</script>")
                codigoJs = "<script language='javascript'>alert('Estado de Credito Errado, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If

            Me.TxtDfecvig.Text = entidad1.dfecvig
            Me.TxtCodcli.Text = entidad1.ccodcli

            

            '     Me.Txtcnrodoc.Text = entidad1.cnrodes

            'Datos del Cliente
            Dim entidad2 As New SIM.EL.climide
            Dim eClimide As New SIM.BL.cClimide

            entidad2.ccodcli = Me.TxtCodcli.Text

            eClimide.ObtenerClimide(entidad2)

            Me.TxtNomcli.Text = entidad2.cnomcli
            Me.btnGrabar.EnableViewState = True

            Dim entidadcredkar As New SIM.EL.credkar
            Dim eCredkar As New SIM.BL.cCredkar
            Dim ds As New DataSet
            Dim ncanti As Integer

            'Obtener el ultimo documento de desembolso
            Dim lcnrodoc As String = ""
            lcnrodoc = eCredkar.ObtenercnrodocmaxDes(Me.TxtCodigo.Text.Trim)
            Me.Txtcnrodoc.Text = lcnrodoc


            ds = eCredkar.Obtenerdatasetporid1(Me.TxtCodigo.Text.Trim, "D", " ", Me.Txtcnrodoc.Text.Trim)

            ncanti = ds.Tables(0).Rows.Count()

            If ncanti = 0 Then  'En caso que no devuelva nada se sale
                Exit Sub
            End If

            Me.txtcnrochq.Text = ds.Tables(0).Rows(0)("cnuming")


        Catch ex As Exception

        End Try

    End Sub


    Public Sub Imprime()

        'Imprime la Reversión >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CrRevDes.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsRev As New DataSet

        Dim eKardex As New SIM.BL.ckardex
        Dim nCanti As Integer
        Dim reportes As String
        reportes = "Reversion.pdf"

        dsRev = eKardex.ObtenerDataSetPorcuenta1(Me.TxtCodigo.Text.Trim, "EG", Me.txtcnrochq.Text.Trim)

        nCanti = dsRev.Tables(0).Rows.Count


        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsRev.Tables(0))
        crRpt.Refresh()

        ''crRpt.SetParameterValue("lcnomcli", TxtNomcli.Text.Trim)
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

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Limpieza()
        End If
    End Sub



   
    Private Sub btnCancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.ServerClick
        Me.Limpieza()
    End Sub

    Private Sub btnImprime_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.ServerClick
        Me.Imprime()
    End Sub

    Protected Sub btnGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            'Revertir provision
            'Genera Partida Contable de Provision
            Dim i As Integer
            i = clsRev.RevierteProvisionContable(TxtCodigo.Text, Session("gdfecsis"), Session("gccodusu"))
            If i = 9 Then
                'Response.Write("<script language='javascript'>alert('Ocurrio un Problema, No se Reverso')</script>")
                codigoJs = "<script language='javascript'>alert('Ocurrio un Problema, No se Reverso, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Return
            End If

            Dim ecremcre As New cCremcre
            ecremcre.ReseteaProvision(Me.TxtCodigo.Text.Trim)

            clsRev._gdFecsis = Session("gdfecsis")
            clsRev._gcCodUsu = Session("gcCodUsu")
            clsRev._cCuenta = Me.TxtCodigo.Text.Trim
            clsRev._cNrodoc = Me.Txtcnrodoc.Text.Trim
            clsRev._cGlosa = " REVERSION DE DESEMBOLSO # " & Me.TxtCodigo.Text.Trim + " A NOMBRE DE " & Me.TxtNomcli.Text.Trim
            clsRev._cOficina = Me.TxtOficina.Text.Trim
            clsRev._cReg = Me.TxtInst.Text.Trim
            clsRev._cNrochq = Me.txtcnrochq.Text.Trim

            clsRev.Revierte()

            btnGrabar.Enabled = False


            Me.Imprime()
            Me.Limpieza()
        Catch ex As Exception

        End Try

    End Sub
End Class


