Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports System.IO


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class ucCajaChica
    Inherits System.Web.UI.UserControl
    Private Shared cuenta As String
    Private clase As New class1
    Private ectbmcta As New cCtbmcta
    Dim clscntaemp As New SIM.BL.cCntaemp

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            CargarDatos()
        End If
    End Sub
    Private Sub CargarDatos()
        Dim ldfecini As Date
        Dim ldfecfin As Date
        Dim dsOficinas As DataSet

        ldfecini = clase.fxIniDate(Session("gdfecsis"))
        ldfecfin = clase.fxEndDate(Session("gdfecsis"))

        txtdfecini.Text = ldfecini
        txtdfecfin.Text = ldfecfin


        Dim etabtofi As New cTabtofi
        dsOficinas = etabtofi.ObtenerDataSetPorNivel2(Session("gnNivel"), Session("gcCodOfi"))

        If dsOficinas.Tables(0).Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If



        Me.cmbOficina.DataTextField = "cnomofi"
        Me.cmbOficina.DataValueField = "ccodofi"
        Me.cmbOficina.DataSource = dsOficinas.Tables(0)
        Me.cmbOficina.DataBind()

        Dim mListaTabttab1 As New listatabttab
        Dim clstabttab As New cTabttab

        mListaTabttab1 = clstabttab.ObtenerLista("033", "1")

        Me.cmbfondo.DataTextField = "cdescri"
        Me.cmbfondo.DataValueField = "ccodigo"
        Me.cmbfondo.DataSource = mListaTabttab1
        Me.cmbfondo.DataBind()
        Me.cmbfondo.SelectedValue = "99"
        Me.cmbfondo.Enabled = False

        Dim ds As New DataSet
        Dim etabtusu As New cTabtusu
        ds = etabtusu.ObtenerResponsableCaja(Session("gccodofi"))
        cmbresponsable.DataTextField = "nombre"
        cmbresponsable.DataValueField = "usuario"
        cmbresponsable.DataSource = ds
        cmbresponsable.DataBind()


        ds.Clear()


        Dim dsb As New DataSet
        Dim dsc As New DataSet


        'Informacion del Combo
        Dim clsbancos As New cTabtbco
        Dim dsbanco As New DataSet
        clsbancos.ObtenerDatasetporidtodos2(dsbanco, Session("gcCodofi"))

        Me.cmbbancos.DataTextField = "cnombco"
        Me.cmbbancos.DataValueField = "ccodbco"
        Me.cmbbancos.DataSource = dsbanco
        Me.cmbbancos.DataBind()

        Dim eusuarios As New cusuarios
        Dim dsres As New DataSet
        dsres = eusuarios.ObtenerResponsableCC(Session("gcCodofi"), Session("gccodusu"))

        cmbencargado.DataTextField = "nombre"
        cmbencargado.DataValueField = "usuario"
        cmbencargado.DataSource = dsres
        cmbencargado.DataBind()

        Gasto()

        CargaProveedores()

        Me.txtdfecha.Text = Session("gdfecsis")

        HabilitaPorNivel(Session("gcCodofi"))

    End Sub
    Private Sub CargarGrid(ByVal ds As DataSet)

        cuentas_GridView.DataSource = ds
        cuentas_GridView.DataBind()

        If ds.Tables(0).Rows.Count = 0 Then
            cuentas_GridView.Visible = False
        Else
            cuentas_GridView.Visible = True
        End If
    End Sub

    Private Sub cuentas_GridView_PageIndexChanging(ByVal source As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles cuentas_GridView.PageIndexChanging
        If Me.IsPostBack Then

            Me.cuentas_GridView.PageIndex = 0

            Me.cuentas_GridView.PageIndex = e.NewPageIndex

            Dim ds As New DataSet
            ds = Calculo()
            CargarGrid(ds)


        End If


    End Sub


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        ds = Calculo()
        CargarGrid(ds)
        ObtieneSaldoPorOficina(ds)
    End Sub


    Private Sub imprimir(ByVal ds As DataSet)
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CajaChica.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try


        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))

        crRpt.SetParameterValue("cnompol", cmbfondo.SelectedItem.Text.Trim)
        crRpt.SetParameterValue("cnumpol", txtcnit.Text.Trim)
        crRpt.SetParameterValue("dfecini", Date.Parse(txtdfecini.Text))
        crRpt.SetParameterValue("dfecfin", Date.Parse(txtdfecfin.Text))
        crRpt.SetParameterValue("cnomofi", cmbOficina.SelectedItem.Text.Trim)

        'crRpt.Refresh()

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim reportes As String
        reportes = "poliza.pdf"
        'reportes &= ".pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Response.Write("<script>window.open('wbProvee.aspx','cal', 'location=1, toolbar = no, status=1,width=650,height=650')</script>")
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        CargaProveedores()
    End Sub
    Private Sub CargaProveedores()
        'oficinas

        Dim mListacntaemp As New listacntaemp

        mListacntaemp = clscntaemp.ObtenerLista()

        Me.cmbprovee.DataTextField = "cdescri"
        Me.cmbprovee.DataValueField = "ccodemp"
        Me.cmbprovee.DataSource = mListacntaemp
        Me.cmbprovee.DataBind()

        Dim entidadcntaemp As New cntaemp
        entidadcntaemp.ccodemp = cmbprovee.SelectedValue.Trim
        clscntaemp.ObtenerCntaemp(entidadcntaemp)


    End Sub
    Private Sub Cajachica_calculo()
        Dim niva, nisr, nmonto, iva, isr, ncantidad As Double
        nmonto = Double.Parse(txtntotal.Text)

        niva = Math.Round(nmonto * iva / 100, 2)
        nisr = Math.Round(nmonto * isr / 100, 2)
        ncantidad = Math.Round(nmonto - (niva + nisr), 2)

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Cajachica_calculo()

        Dim lctipo As String
        Dim objConta As New cCntamov


        lctipo = cmbtipo.SelectedValue.Trim

        'If Left(lctipo, 10) = "1011010401" And (txtcdescripcion.Text.Trim = "" Or Double.Parse(txtncantidad.Text) <= 0) Then
        If Left(lctipo, 10) = "1011010401" And txtcdescripcion.Text.Trim = "" Then
            Response.Write("<script language='javascript'>alert('Falta Datos')</script>")
            Return
        ElseIf (txtcnit.Text.Trim = "" Or txtcdescripcion.Text.Trim = "" Or txtcfactura.Text.Trim = "") And _
        Left(lctipo, 6) <> "101101" Then
            Response.Write("<script language='javascript'>alert('Falta Datos')</script>")
            Return
        ElseIf objConta.ValidaUltimaFechaDeLiquidacion(cmbOficina.SelectedValue, txtdfecha.Text) = False Then
            Response.Write("<script language='javascript'>alert('fecha invalida ya se realizo liquidacion revise')</script>")
            Return
        End If

        Dim etabtbco As New cTabtbco
        Dim lcctabco As String
        'lcctabco = etabtbco.CuentaContableBanco(Me.cmbbancos.SelectedValue.Trim)
        lcctabco = ""
        Dim ectbmcta As New cCtbmcta
        Dim lcauxcta As Decimal = 0
        'lcauxcta = ectbmcta.ObtieneAuxCta(cmbtipo.SelectedValue.Trim)
        lcauxcta = 0

        Dim ecntamov As New cCntamov
        Dim entidadcntamov As New cntamov

        entidadcntamov.cnit = Me.cmbprovee.SelectedValue.Trim
        entidadcntamov.cproveedor = Me.cmbprovee.SelectedValue.Trim
        entidadcntamov.cdescri = Me.txtcdescripcion.Text.Trim
        entidadcntamov.dfecha = Date.Parse(txtdfecha.Text)
        entidadcntamov.ctipo = Me.cmbtipo.SelectedValue.Trim
        'entidadcntamov.cfactura = IIf(RadioButton1.Checked = True, "", Me.txtcfactura.Text.Trim)
        entidadcntamov.cfactura = Me.txtcfactura.Text.Trim
        entidadcntamov.ndebe = Double.Parse(txtntotal.Text)
        entidadcntamov.nsaldo = 0
        entidadcntamov.cflag = " "
        entidadcntamov.ccodant = " "
        entidadcntamov.laplcon = False
        entidadcntamov.cctabco = lcctabco.Trim
        entidadcntamov.ccodofi = Me.cmbOficina.SelectedValue.Trim
        entidadcntamov.ccodins = "001"
        entidadcntamov.ccodenc = Me.cmbencargado.SelectedValue.Trim
        entidadcntamov.nmonfac = Double.Parse(Me.txtntotal.Text)
        entidadcntamov.niva = 0
        entidadcntamov.nisr = 0
        entidadcntamov.cnumcom = ""
        entidadcntamov.cfuente = Me.cmbfondo.SelectedValue.Trim
        entidadcntamov.dfecmod = Now
        entidadcntamov.ccodbco = "" 'Me.cmbbancos.SelectedValue.Trim
        entidadcntamov.cestado = " "
        entidadcntamov.ctipope = IIf(RadioButton1.Checked = True, "A", "G")
        entidadcntamov.ccodres = Me.cmbresponsable.SelectedValue.Trim
        entidadcntamov.cauxcta = lcauxcta

        Try
            ecntamov.AgregarAuxiliarCaja(entidadcntamov)
        Catch ex As Exception

        End Try

        Dim ds As New DataSet
        ds = Calculo()
        CargarGrid(ds)
        ObtieneSaldoPorOficina(ds)
        LimpiaDatos()

    End Sub

    Private Function Calculo() As DataSet
        Dim lcfondo As String = ""
        Dim lcunidad As String = ""
        Dim lcencargado As String = ""


        If CheckBox2.Checked = True Then
            lcfondo = ""
        Else
            lcfondo = cmbfondo.SelectedValue.Trim
        End If
        If CheckBox1.Checked = True Then
            lcunidad = ""
        Else
            lcunidad = cmbOficina.SelectedValue.Trim
        End If
        If CheckBox3.Checked = True Then
            lcencargado = ""
        Else
            lcencargado = cmbencargado.SelectedValue.Trim
        End If


        'Dim ecntamov As New cCntamov
        'Dim ds As New DataSet

        'ds = ecntamov.Obtenermovcajachica(Date.Parse(txtdfecini.Text), Date.Parse(txtdfecfin.Text), lcunidad.Trim, lcfondo, lcencargado)

        Dim ds As New DataSet
        'ds = clase.CalculoCajaChica(Date.Parse(txtdfecini.Text), Date.Parse(txtdfecfin.Text), lcunidad, lcfondo, lcencargado)
        ds = clase.CalculoCajaChica(Date.Parse(txtdfecini.Text), Date.Parse(txtdfecfin.Text), lcunidad, lcfondo, "")
        Return ds
    End Function

    Protected Sub btnimprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        Dim ds As New DataSet
        Dim etabttab As New cTabttab
        Dim ecntamov As New cCntamov
        Dim totalEfectivo As Decimal = 0

        Dim lcnomfue, lcnomuni, lcnomenc As String
        Dim lcfondo, lcunidad, lcencargado As String
        If CheckBox2.Checked = True Then
            lcfondo = ""
            lcnomfue = ""
        Else
            lcfondo = cmbfondo.SelectedValue.Trim
            lcnomfue = cmbfondo.SelectedItem.Text.Trim
        End If
        If CheckBox1.Checked = True Then
            lcunidad = ""
            lcnomuni = ""
        Else
            lcunidad = cmbOficina.SelectedValue.Trim
            lcnomuni = cmbOficina.SelectedItem.Text.Trim
        End If
        If CheckBox3.Checked = True Then
            lcencargado = ""
            lcnomenc = ""
        Else
            lcencargado = cmbencargado.SelectedValue.Trim
            lcnomenc = cmbencargado.SelectedItem.Text.Trim
        End If

        'ds = ecntamov.ObtenermovcajachicaImpresion(Date.Parse(txtdfecini.Text), Date.Parse(txtdfecfin.Text), lcunidad, lcfondo, lcencargado)
        ds = ecntamov.ObtenermovcajachicaImpresion(Date.Parse(txtdfecini.Text), Date.Parse(txtdfecfin.Text), lcunidad, lcfondo, "")

    

        totalEfectivo = ecntamov.ObtenerEfectivoCajaChicaAgencia(lcunidad)


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crCajaChica.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(ds.Tables(0))
        '        crRpt.Refresh()

        crRpt.SetParameterValue("cnomofi", lcnomuni)
        crRpt.SetParameterValue("cnomenc", lcnomenc)
        crRpt.SetParameterValue("cnomfue", lcnomfue)
        crRpt.SetParameterValue("dfecini", Date.Parse(txtdfecini.Text))
        crRpt.SetParameterValue("dfecfin", Date.Parse(txtdfecfin.Text))
        crRpt.SetParameterValue("totalefectivo", totalEfectivo)        

        Dim reportes As String
        reportes = "caja.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()


    End Sub

    Private Sub Gasto()
        Dim ds As New DataSet
        ds = ectbmcta.ObtieneCuentaCajaChica
        cmbtipo.DataTextField = "cdescrip"
        cmbtipo.DataValueField = "ccodcta"
        cmbtipo.DataSource = ds
        cmbtipo.DataBind()
        ds.Clear()
    End Sub
    Private Sub Apertura()
        Dim ds As New DataSet
        ds = ectbmcta.ObtieneCuentaCajaChica2(Session("gcCodOfi"))
        cmbtipo.DataTextField = "cdescrip"
        cmbtipo.DataValueField = "ccodcta"
        cmbtipo.DataSource = ds
        cmbtipo.DataBind()
        ds.Clear()
    End Sub

    Protected Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Apertura()

        Me.cmbtipo.Enabled = True
        Me.cmbbancos.Enabled = True
        Me.cmbprovee.SelectedValue = "90"
        Me.cmbprovee.Enabled = False
        
        Dim entidadcntaemp As New cntaemp
        entidadcntaemp.ccodemp = cmbprovee.SelectedValue.Trim
        clscntaemp.ObtenerCntaemp(entidadcntaemp)

        
        txtcnit.Text = entidadcntaemp.ccodemp

    End Sub

    Protected Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Gasto()
        Me.cmbtipo.Enabled = True
        Me.cmbbancos.Enabled = True
        Me.cmbprovee.Enabled = True

        txtcfactura.Enabled = True
    End Sub


    Protected Sub cmbprovee_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbprovee.SelectedIndexChanged
        Dim entidadcntaemp As New cntaemp
        entidadcntaemp.ccodemp = cmbprovee.SelectedValue.Trim
        clscntaemp.ObtenerCntaemp(entidadcntaemp)


        txtcnit.Text = entidadcntaemp.ccodemp
    End Sub

    Protected Sub btnliquidar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnliquidar.Click
        
        Dim etabtbco As New cTabtbco
        Dim lcctabco As String


        lcctabco = etabtbco.CuentaContableBanco(Me.cmbbancos.SelectedValue.Trim)

        If txtRef.Text = "" Then
            Response.Write("<script language='javascript'>alert('debe colocar un numero de referencia ')</script>")
            Return
        End If

        
        Dim lcpartidas As String = ""
        Try
            clase.dfecha = Session("gdfecsis")
            clase.cctabco = lcctabco.Trim
            clase.cfactura = Me.txtRef.Text
            clase.pcCodUsu = Session("gccodusu")


            lcpartidas = clase.LiquidaCajaChica(Date.Parse(txtdfecini.Text), Date.Parse(txtdfecfin.Text), Me.cmbOficina.SelectedValue.Trim)

            If lcpartidas = "0" Then
                Response.Write("<script language='javascript'>alert('no hay datos para liquidar ')</script>")
            Else
                Response.Write("<script language='javascript'>alert('Caja Chica Liquidada, referencia partida no: " + lcpartidas + "')</script>")
            End If
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('error: " + ex.Message.ToString + "')</script>")
        End Try


    End Sub

    Protected Sub cuentas_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cuentas_GridView.SelectedIndexChanged
        Dim lentidad As New cntamov
        Dim clsConta As New cCntamov
        Dim correlativo As String
        correlativo = CType(cuentas_GridView.SelectedRow.FindControl("Label1"), Label).Text()
        lentidad.ccodsec = correlativo
        clsConta.ObtenerAuxiliarCajaPorId(lentidad)        

        'If Session("gcCodOfi") <> "001" Then
        '    'Response.Write("<script language='javascript'>alert('ud no tiene permisos para modificar datos')</script>")
        '    'Return
        'Else
        '    Me.btnmodificar.Enabled = True
        'End If

        Me.btnmodificar.Enabled = True

        If lentidad.laplcon = True Then
            Response.Write("<script language='javascript'>alert('no se puede modificar, pq ya se realizo la liquidacion')</script>")
            Return
        End If

        If lentidad.ctipope = "G" Then
            Me.RadioButton2.Checked = True
            Me.RadioButton1.Checked = False
            Me.cmbtipo.SelectedValue = lentidad.ctipo.Trim
            Me.txtcnit.Text = lentidad.cnit.Trim
            Me.cmbprovee.SelectedValue = lentidad.cproveedor.Trim
            Me.txtcdescripcion.Text = lentidad.cdescri.Trim
            Me.txtntotal.Text = lentidad.ndebe
            Me.txtdfecha.Text = lentidad.dfecha
            Me.txtcfactura.Text = lentidad.cfactura.Trim
            Me.HiddenFieldCorrelativo.Value = correlativo
        Else
            Response.Write("<script language='javascript'>alert('solo se puede modificar un gasto')</script>")
        End If

    End Sub

    Protected Sub btnmodificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Dim lctipo As String
        lctipo = cmbtipo.SelectedValue.Trim

        'If Left(lctipo, 10) = "1011010401" And (txtcdescripcion.Text.Trim = "" Or Double.Parse(txtncantidad.Text) <= 0) Then
        If Left(lctipo, 10) = "1011010401" And txtcdescripcion.Text.Trim = "" Then
            Response.Write("<script language='javascript'>alert('Falta Datos')</script>")
            Return
        ElseIf (txtcnit.Text.Trim = "" Or txtcdescripcion.Text.Trim = "" Or txtcfactura.Text.Trim = "") And _
        Left(lctipo, 6) <> "101101" Then
            Response.Write("<script language='javascript'>alert('Falta Datos')</script>")
            Return

        Else
        End If

        Dim etabtbco As New cTabtbco
        Dim lcctabco As String
        lcctabco = "" 'etabtbco.CuentaContableBanco(Me.cmbbancos.SelectedValue.Trim)

        Dim ectbmcta As New cCtbmcta
        Dim lcauxcta As Decimal = 0
        lcauxcta = 0 'ectbmcta.ObtieneAuxCta(cmbtipo.SelectedValue.Trim)

        Dim ecntamov As New cCntamov
        Dim entidadcntamov As New cntamov

        entidadcntamov.cnit = txtcnit.Text.Trim
        entidadcntamov.cproveedor = Me.cmbprovee.SelectedValue.Trim
        entidadcntamov.cdescri = Me.txtcdescripcion.Text.Trim
        entidadcntamov.dfecha = Date.Parse(txtdfecha.Text)
        entidadcntamov.ctipo = Me.cmbtipo.SelectedValue.Trim
        entidadcntamov.cfactura = IIf(RadioButton1.Checked = True, "", Me.txtcfactura.Text.Trim)
        entidadcntamov.ndebe = Double.Parse(txtntotal.Text)
        entidadcntamov.nsaldo = 0
        entidadcntamov.cflag = " "
        entidadcntamov.ccodant = " "
        entidadcntamov.laplcon = False
        entidadcntamov.cctabco = lcctabco.Trim
        entidadcntamov.ccodofi = Me.cmbOficina.SelectedValue.Trim
        entidadcntamov.ccodins = "001"
        entidadcntamov.ccodenc = Me.cmbencargado.SelectedValue.Trim
        entidadcntamov.nmonfac = Double.Parse(txtntotal.Text)
        entidadcntamov.niva = 0
        entidadcntamov.nisr = 0
        entidadcntamov.cnumcom = ""
        entidadcntamov.cfuente = Me.cmbfondo.SelectedValue.Trim
        entidadcntamov.dfecmod = Now
        entidadcntamov.ccodbco = "" 'Me.cmbbancos.SelectedValue.Trim
        entidadcntamov.cestado = " "
        entidadcntamov.ctipope = IIf(RadioButton1.Checked = True, "A", "G")
        entidadcntamov.ccodres = Me.cmbresponsable.SelectedValue.Trim
        entidadcntamov.cauxcta = lcauxcta
        entidadcntamov.ccodsec = Me.HiddenFieldCorrelativo.Value
        entidadcntamov.cconcepto = Me.txtObservac.Text

        Try
            ecntamov.ActualizarAuxiliarCaja(entidadcntamov)
        Catch ex As Exception

        End Try

        Dim ds As New DataSet
        ds = Calculo()
        CargarGrid(ds)
        ObtieneSaldoPorOficina(ds)

        LimpiaDatos()

        btnmodificar.Enabled = False

    End Sub

    Private Sub LimpiaDatos()
        Me.txtcdescripcion.Text = ""
        Me.txtntotal.Text = ""
        Me.txtcfactura.Text = ""
        Me.HiddenFieldCorrelativo.Value = ""        
    End Sub

    Private Sub HabilitaPorNivel(ByVal ccodofi As String)

        If ccodofi = "001" Then
            txtObservac.Visible = True
            Panel1.Visible = True
            ButtonConsolidadoXAgencia.Visible = True

        Else
            txtObservac.Visible = False
            Panel1.Visible = False
            ButtonConsolidadoXAgencia.Visible = False
        End If

    End Sub

    Protected Sub ButtonImpConsolidado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonImpConsolidado.Click    
        Dim ds As New DataSet
        Dim etabttab As New cTabttab
        Dim ecntamov As New cCntamov
        Dim totalEfectivo As Decimal = 0
        Dim liquidado As String


    
        liquidado = RadioButtonListOpciones.SelectedValue

        ds = ecntamov.ObtenerCajaChicaConsolidado(Date.Parse(txtdfecini.Text), Date.Parse(txtdfecfin.Text), liquidado, Me.cmbOficina.SelectedValue.Trim)


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crCajaChicaConsolidado.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(ds.Tables(0))
        '        crRpt.Refresh()

        crRpt.SetParameterValue("dfecini", Date.Parse(txtdfecini.Text))
        crRpt.SetParameterValue("dfecfin", Date.Parse(txtdfecfin.Text))


        Dim reportes As String
        reportes = "caja.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()



    End Sub

    Protected Sub ButtonGenerarArchivoBanca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonGenerarArchivoBanca.Click
        Dim objUtilidades As New Utilidades
        Dim Archivo As StreamWriter
        Dim ecntamov As New cCntamov
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim liquidado As String



        liquidado = RadioButtonListOpciones.SelectedValue

        Dim Columnas() As String = {"correlativo", "cctabco", "total"}

        Archivo = File.CreateText("c:\txt\cajachica.csv")

        ds = ecntamov.ObtenerCajaChicaConsolidado(Date.Parse(txtdfecini.Text), Date.Parse(txtdfecfin.Text), liquidado, Me.cmbOficina.SelectedValue.Trim)

        If ds.Tables(0).Rows.Count > 0 Then
            dt = objUtilidades.CopiaDataTable(ds.Tables(0), Columnas)

            ds.Tables.Add(dt)

            objUtilidades.ProduceCSV(ds.Tables(1), Archivo, False)

            Archivo.Close()

            Response.Clear()
            Response.Buffer = True
            ' Establece el tipo de documento
            Response.ContentType = "application/pdf"
            Response.WriteFile("c:\txt\cajachica.csv")
            Response.AddHeader("Content-Disposition", "attachment;filename=cajachica.csv")
            Response.Flush()
            Response.Close()
        Else
            Response.Write("<script language='javascript'>alert('no hay datos para exportar')</script>")
            Return
        End If


    End Sub

    Protected Sub ButtonConsolidadoXAgencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonConsolidadoXAgencia.Click
        Dim ds As New DataSet
        Dim etabttab As New cTabttab

        Dim ecntamov As New cCntamov
        Dim totalEfectivo As Decimal = 0


        Dim lcnomfue, lcnomuni, lcnomenc As String
        Dim lcfondo, lcunidad, lcencargado As String
        If CheckBox2.Checked = True Then
            lcfondo = ""
            lcnomfue = ""
        Else
            lcfondo = cmbfondo.SelectedValue.Trim
            lcnomfue = cmbfondo.SelectedItem.Text.Trim
        End If
        If CheckBox1.Checked = True Then
            lcunidad = ""
            lcnomuni = ""
        Else
            lcunidad = cmbOficina.SelectedValue.Trim
            lcnomuni = cmbOficina.SelectedItem.Text.Trim
        End If
        If CheckBox3.Checked = True Then
            lcencargado = ""
            lcnomenc = ""
        Else
            lcencargado = cmbencargado.SelectedValue.Trim
            lcnomenc = cmbencargado.SelectedItem.Text.Trim
        End If

        'ds = ecntamov.ObtenermovcajachicaImpresion(Date.Parse(txtdfecini.Text), Date.Parse(txtdfecfin.Text), lcunidad, lcfondo, lcencargado)
        ds = ecntamov.ObtenermovcajachicaImpresion(Date.Parse(txtdfecini.Text), Date.Parse(txtdfecfin.Text), lcunidad, lcfondo, "")

  

        totalEfectivo = ecntamov.ObtenerEfectivoCajaChicaAgencia(lcunidad)


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crCajaChicaConsolidadoPorAgencia.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(ds.Tables(0))
        '        crRpt.Refresh()

        crRpt.SetParameterValue("cnomofi", lcnomuni)
        crRpt.SetParameterValue("cnomenc", lcnomenc)
        crRpt.SetParameterValue("cnomfue", lcnomfue)
        crRpt.SetParameterValue("dfecini", Date.Parse(txtdfecini.Text))
        crRpt.SetParameterValue("dfecfin", Date.Parse(txtdfecfin.Text))
        crRpt.SetParameterValue("totalefectivo", totalEfectivo)

        Dim reportes As String
        reportes = "caja.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()
    End Sub

    Protected Sub btnBNit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBNit.Click

        Try
            cmbprovee.SelectedValue = txtBuscarNit.Text.Trim
            txtcnit.Text = cmbprovee.SelectedValue.Trim

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('el nit no existe')</script>")
            Return
        End Try


    End Sub

    Protected Sub btnBCuenta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBCuenta.Click
        Try
            cmbtipo.SelectedValue = txtBuscarCuenta.Text.Trim
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('la cuenta no existe')</script>")
            Return
        End Try
    End Sub

    Protected Sub ObtieneSaldoPorOficina(ByVal ds As DataSet)
        Dim objConta As New cCntamov
        Dim objUtilidades As New Utilidades
        Dim dtTemporal As New DataTable
        Dim apertura As Decimal
        Dim gastos As Decimal
        Dim saldo As Decimal

        

        Try
            apertura = objConta.ObtieneMontoAutorizadoCajaChicaOficina(cmbOficina.SelectedValue)
            dtTemporal = objUtilidades.FiltraTabla(ds.Tables(0), "laplcon=false and destipope='Gasto' ")
            If dtTemporal.Rows.Count = 0 Then
                gastos = 0
            Else
                gastos = dtTemporal.Compute("sum(ndebe)", "")
            End If
            saldo = apertura - gastos

            'lblSaldo.Text = (apertura - gastos).ToString("###,###.##")
            lblSaldo.Text = saldo.ToString("N2")
        Catch ex As Exception

        End Try



    End Sub
End Class
