Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Reporting.WebControls
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.Web.Caching
Imports System.IO


Partial Class reporte_contenedor
    Inherits System.Web.UI.Page
    Private clsConvert As New SIM.BL.ConversionLetras
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Variables agregadas para formatos de exportación -- Alex 29/11/2011
        Dim tipo As String = ""
        Dim exportar As String = Session("tipoexportar")

        'Nuevas variables para generarlo directamente a pdf
        Dim rptStream As New System.IO.MemoryStream
        Dim reportes As String

        Dim tit As String = ""
        Dim parm1 As String = Request.QueryString("parametro")
        Dim huella As String
        huella = Server.MapPath("reportes") + "\"
        'crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select As String = ""

        Dim dt As New DataTable
        Dim ds As New DataSet

        con.ConnectionString = stringconnection

        'bloque 1
        If parm1 = "Bloqueados" Or parm1 = "Control_Entrega_Libreta" Or parm1 = "historial_certificado" Or _
         parm1 = "certificados" Or parm1 = "pago_intereses" Or parm1 = "pago_intereses_acumulado" Or parm1 = "rpt_historial_ahorros" Or _
         parm1 = "rpt_sumario_ahorros" Or parm1 = "rpt_captacion_aportaciones_creditos" Or _
         parm1 = "sumario_cajero" Then
            con.Open()
            str_select = Session("str_select")
            ds = miclase.devolver_dataset(con, str_select)
            con.Close()
            dt = ds.Tables("tabla")
        End If
        'bloque 2
        If parm1 = "rpt_movimientos_diarios_ahorros" Or parm1 = "rpt_inactividad_cuentas_ahorros" Or _
        parm1 = "rpt_mayor_concentracion" Or parm1 = "rpt_asociados_categoria" Or _
        parm1 = "rpt_dividendos_pagados" Or parm1 = "rpt_fondo_defunsion" Or parm1 = "fondo_cubiertos" Or _
        parm1 = "rpt_dividendos_calculados" Or parm1 = "rpt_dividendos_pendientes" Or parm1 = "interes_plazo_provisionado" Then
            con.Open()
            str_select = Session("str_select")
            ds = miclase.devolver_dataset(con, str_select)
            con.Close()
            dt = ds.Tables("tabla")
        End If
        'bloque 3
        If parm1 = "aplicaciones_programadas" Or parm1 = "rpt_provision_diaria" Or _
           parm1 = "rpt_capitalizacion" Or parm1 = "rpt_capitalizacion_resumida" Or _
           parm1 = "rpt_cartera_ahorros" Or parm1 = "cuenta_billetes" Or _
           parm1 = "partida" Or parm1 = "certificado_nuevo" Or parm1 = "resguardo" Or _
           parm1 = "libreta_frente" Or parm1 = "pago_intereses_tasa" Or parm1 = "pago_intereses_historial" Or _
           parm1 = "cartera_creditos_grafica" Or parm1 = "cartera_creditos_grafica1" Or _
           parm1 = "resumen_provision_ahorros" Then
            con.Open()
            str_select = Session("str_select")
            ds = miclase.devolver_dataset(con, str_select)
            con.Close()
            dt = ds.Tables("tabla")

        End If


        If parm1 = "lavado_detallado" Or parm1 = "lavado_resumen" Then
            con.Open()
            str_select = Session("str_select")
            ds = miclase.devolver_dataset(con, str_select)
            con.Close()
            dt = ds.Tables("tabla")
        End If

        'este es un caso especial
        If parm1 = "pignorados" Then
            dt = caso_especial1(con)
        End If

        If parm1 = "cheque" Then
            con.Open()
            str_select = Session("str_select")
            ds = miclase.devolver_dataset(con, str_select)
            con.Close()
            dt = ds.Tables("tabla")

        End If
        'crea una tabla y la guarda de la que viene del cache
        'las tablas que vienen de cache son pequeñas, un solo registro
        '
        Dim crrep As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        'Agregado para los reportes de lavado de dinero -- Alex 28/11/2011
        If parm1 = "lavado_detallado" Or parm1 = "lavado_resumen" Then
            crrep.Load(huella & parm1 & ".rpt")
        End If

        If parm1 = "libreta_lineas" Then
            dt = Cache("tabla1") ' es una tabla que viene del formulario devolucion_aportaciones a traves del cache
            crrep.Load(huella & "libreta.rpt")
        End If

        If parm1 = "Fondo" Then
            dt = Cache("tabla1") ' es una tabla que viene del formulario devolucion_aportaciones a traves del cache
            crrep.Load(huella & "fondo_defunsion_recibo.rpt")
        End If
        If parm1 = "rpt_fondo_defunsion" Then  'viene del formulario rpt_control_entrega_libreta
            crrep.Load(huella & "rpt_fondo_defunsion.rpt")
        End If
        If parm1 = "fondo_cubiertos" Then  '
            crrep.Load(huella & "fondo_defunsion.rpt")
        End If

        If parm1 = "Deposito" Then
            dt = Cache("tabla2") ' es una tabla que viene del formulario devolucion_aportaciones a traves del cache
            crrep.Load(huella & "deposito.rpt")
        End If
        If parm1 = "Libreta" Then
            dt = Cache("tabla3") ' es una tabla que viene del formulario devolucion_aportaciones a traves del cache
            crrep.Load(huella & "crlibreta.rpt")
        End If
        If parm1 = "Asamblea" Then
            dt = Cache("tabla4") ' es una tabla que viene del formulario asamblea a traves del cache
            crrep.Load(huella & "cr_asamblea.rpt")
        End If
        If parm1 = "Bloqueados" Then  'viene del formulario rpt_bloqueados
            crrep.Load(huella & "bloqueos.rpt")
        End If
        If parm1 = "Control_Entrega_Libreta" Then  'viene del formulario rpt_control_entrega_libreta
            crrep.Load(huella & "control_entrega_libreta.rpt")
        End If
        If parm1 = "historial_certificado" Then  'viene del formulario rpt_historial_certificado
            crrep.Load(huella & "historial_certificado.rpt")
        End If
        If parm1 = "certificados" Or parm1 = "pignorados" Or parm1 = "rpt_mayor_concentracion" Then  'viene del formulario rpt_certificados, rpt_mayor_concentracion
            crrep.Load(huella & "certificados.rpt")
        End If
        If parm1 = "pago_intereses" Then  'viene del formulario rpt_pago_interes_plazo
            crrep.Load(huella & "pago_interes_plazo.rpt")
            'tit = "CERTIFICADOS VENCIDOS Y PAGO DE INTERESES"
            'crrep.SetParameterValue("tit", tit)
        End If
        If parm1 = "pago_intereses_acumulado" Then  'viene del formulario rpt_pago_interes_plazo
            crrep.Load(huella & "pago_interes_plazo_acumulado.rpt")
        End If
        If parm1 = "pago_intereses_tasa" Then  'viene del formulario rpt_pago_interes_plazo
            crrep.Load(huella & "pago_interes_tasa.rpt")
        End If
        If parm1 = "pago_intereses_historial" Then  'viene del formulario rpt_pago_interes_plazo
            crrep.Load(huella & "pago_interes_historial.rpt")
        End If

        If parm1 = "rpt_historial_ahorros" Then  'viene del formulario rpt_historial_ahorros
            crrep.Load(huella & "historial_ahorros.rpt")
        End If
        If parm1 = "rpt_sumario_ahorros" Then  'viene del formulario rpt_sumario_ahorro
            crrep.Load(huella & "sumario_ahorros.rpt")
        End If
        If parm1 = "rpt_captacion_aportaciones_creditos" Then  'viene del formulario rpt_sumario_ahorro
            crrep.Load(huella & "captacion_aportaciones_creditos.rpt")
        End If
        If parm1 = "rpt_movimientos_diarios_ahorros" Then  'viene del formulario rpt_movimientos_diarios_ahorros
            crrep.Load(huella & "movimientos_diarios_ahorros.rpt")
        End If
        If parm1 = "rpt_inactividad_cuentas_ahorros" Then  'viene del formulario rpt_inactividad_cuentas_ahorros
            crrep.Load(huella & "inactividad_cuentas_ahorros.rpt")
        End If
        If parm1 = "rpt_asociados_categoria" Then  'viene del formulario rpt_asociados_categoria
            crrep.Load(huella & "asociados_categoria.rpt")
        End If
        If parm1 = "rpt_dividendos_pagados" Then  'viene del formulario rpt_dividendos_pagados
            crrep.Load(huella & "dividendos_pagados.rpt")
        End If
        If parm1 = "rpt_dividendos_calculados" Or parm1 = "rpt_dividendos_pendientes" Then  'viene del formulario rpt_dividendos_pagados
            crrep.Load(huella & "dividendos_calculados.rpt")
        End If
        If parm1 = "aplicaciones_programadas" Then 'viene del formulario aplicaciones_programadas
            crrep.Load(huella & "aplicaciones_programadas.rpt")
        End If
        If parm1 = "rpt_provision_diaria" Then 'viene del formulario rpt_provision_diaria
            crrep.Load(huella & "provision_diaria.rpt")
        End If
        If parm1 = "rpt_capitalizacion" Then 'viene del formulario rpt_capitalizacion
            crrep.Load(huella & "capitalizacion.rpt")
        End If
        If parm1 = "rpt_capitalizacion_resumida" Then 'viene del formulario rpt_capitalizacion
            crrep.Load(huella & "capitalizacion_resumida.rpt")
        End If
        If parm1 = "rpt_cartera_ahorros" Then 'viene del formulario rpt_ca
            crrep.Load(huella & "rpt_cartera_ahorros.rpt")
        End If
        If parm1 = "cuenta_billetes" Then
            crrep.Load(huella & "cuenta_billetes.rpt")
        End If
        If parm1 = "sumario_cajero" Then
            crrep.Load(huella & "sumario_cajero.rpt")
        End If
        If parm1 = "cheque" Then
            crrep.Load(huella & "RptChequesPre.rpt")
        End If
        If parm1 = "partida" Then
            crrep.Load(huella & "partida.rpt")
        End If
        If parm1 = "certificado_nuevo" Then
            crrep.Load(huella & "certificado.rpt")
        End If
        If parm1 = "resguardo" Then
            crrep.Load(huella & "resguardo.rpt")
        End If
        If parm1 = "libreta_lineas" Then
            crrep.Load(huella & "libreta.rpt")
        End If
        If parm1 = "libreta_frente" Then
            crrep.Load(huella & "libreta_frente.rpt")
        End If
        If parm1 = "cartera_creditos_grafica" Then
            crrep.Load(huella & "cartera_creditos_grafica.rpt")
        End If
        If parm1 = "cartera_creditos_grafica1" Then
            crrep.Load(huella & "cartera_creditos_grafica1.rpt")
        End If
        If parm1 = "resumen_provision_ahorros" Then
            crrep.Load(huella & "resumen_provision_ahorros.rpt")
        End If
        If parm1 = "interes_plazo_provisionado" Then
            crrep.Load(huella & "interes_plazo_provisionado.rpt")
        End If


        crrep.Refresh()

        crrep.SetDataSource(dt)
        If parm1 = "cuenta_billetes" Then
            crrep.SetParameterValue("ccodusu", Session("gccodusu"))
        End If

        If parm1 = "cheque" Then
            Dim lcnumpar As String = ""
            Dim lcnrochq As String = ""
            Dim lcmonchq As Decimal = 0
            Dim fila As DataRow
            For Each fila In dt.Rows
                lcnumpar = fila("cnumcom")
                lcnrochq = fila("cnrochq")
                lcmonchq = fila("cmonchq")
            Next

            Dim lcletras As String
            Dim lndecimal As Double
            lcletras = clsConvert.ConversionEnteros(lcmonchq)
            lndecimal = clsConvert.ExtraeDecimales(lcmonchq.ToString.Trim)
            If lndecimal >= 10 Then
                lcletras = lcletras.Trim & " " & lndecimal.ToString & "/100"
            Else
                lcletras = lcletras.Trim & " 0" & lndecimal.ToString & "/100"
            End If

            For Each fila In dt.Rows
                fila("cmonlet") = lcletras
            Next
            'crrep.SetParameterValue("cnomlug", Session("gcnomofi"))
            'crrep.SetParameterValue("cnumpar", "PARTIDA Nº: " & lcnumpar)
            'crrep.SetParameterValue("cnrochq", "Cheque: " & lcnrochq)

        End If

        fondo_CrystalReportViewer1.ReportSource = crrep
        ' crrep.PrintToPrinter(1, False, 1, 1)
        fondo_CrystalReportViewer1.DataBind()
        fondo_CrystalReportViewer1.RefreshReport()
        fondo_CrystalReportViewer1.Visible = True


        Exit Sub
        ''Agregado para enviar el reporte directamente a pdf - Alex
        'reportes = parm1 & ".pdf"

        'rptStream = CType(crrep.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        ''>>>>
        ''<<<<
        'Response.Clear()
        'Response.Buffer = True

        '' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()

        '********************Modificado para exportar a otros formatos - Alex 29/11/2011 ****************************
        reportes = parm1

        If exportar = "XLS2" Then
            Me.ExportToExcel(ds.Tables(0))
        Else
            Select Case exportar
                Case "PDF"
                    tipo = "application/pdf"
                    reportes &= ".pdf"
                    rptStream = CType(crrep.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                Case "WRD"
                    tipo = "application/msword"
                    reportes &= ".doc"
                    rptStream = CType(crrep.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                Case "XLS"
                    tipo = "application/vnd.ms-excel"
                    reportes &= ".xls"
                    rptStream = CType(crrep.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                Case Else
                    'Para el caso de reportes que no posean el combo de exportación - Alex 29/11/2011
                    'se exportan a pdf directamente
                    tipo = "application/pdf"
                    reportes &= ".pdf"
                    rptStream = CType(crrep.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
            End Select
        End If

        Response.ContentType = tipo

        'Automaticamente se descarga el archivo
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

        Response.BinaryWrite(rptStream.ToArray())
        Response.Flush()
        Response.Close()
        '******************Fin Modificacion ********************************
    End Sub

    Private Function caso_especial1(ByVal con As SqlConnection) As DataTable
        Dim miclase As New clase_especial
        Dim str_select As String
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        Dim ds3 As New DataSet
        Dim fila1 As DataRow
        Dim fila2 As DataRow
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable

        con.Open()

        str_select = "select  'CERTIFICADOS PIGNORADOS A LA FECHA DE HOY' as titulo, crt.cnudotr, rtrim(crt.ccodcrt) + ' ' + rtrim(crt.cctacte) as ccodcrt, " & _
                         "crt.nombre,  crt.dfecapr, crt.dfecven, crt.dfecori, crt.nmonapr, crt.nplazo, crt.ntasint, gar.ccodcta as creditos " & _
                         "from ahomcrt as crt, crepgar as gar " & _
                         "where crt.cpignor = 'S' AND crt.cliq <> 'S' AND " & _
                         "crt.ccodcrt = gar.ccodcrt ORDER BY crt.ccodcrt"
        ds1 = miclase.devolver_dataset(con, str_select)
        dt1 = ds1.Tables("tabla")

        str_select = "select  distinct 'CERTIFICADOS PIGNORADOS A LA FECHA DE HOY' as titulo, crt.cnudotr, rtrim(crt.ccodcrt) + ' ' + rtrim(crt.cctacte) as ccodcrt, " & _
                         "crt.nombre,  crt.dfecapr, crt.dfecven, crt.dfecori, crt.nmonapr, crt.nplazo, crt.ntasint " & _
                         "from ahomcrt as crt, crepgar as gar " & _
                         "where crt.cpignor = 'S' AND crt.cliq <> 'S' AND " & _
                         "NOT exists  (select gar1.ccodcrt FROM crepgar as gar1 WHERE crt.ccodcrt = gar1.ccodcrt) "

        ds2 = miclase.devolver_dataset(con, str_select)


        'este es el que no tiene las creditos
        For Each fila2 In ds2.Tables(0).Rows
            fila1 = dt1.NewRow()
            fila1("titulo") = fila2("titulo")
            fila1("cnudotr") = fila2("cnudotr")
            fila1("ccodcrt") = fila2("ccodcrt")
            fila1("nombre") = fila2("nombre")
            fila1("dfecapr") = fila2("dfecapr")
            fila1("dfecven") = fila2("dfecven")
            fila1("dfecori") = fila2("dfecori")
            fila1("nmonapr") = fila2("nmonapr")
            fila1("nplazo") = fila2("nplazo")
            fila1("ntasint") = fila2("ntasint")
            fila1("creditos") = ""
            dt1.Rows.Add(fila1)
        Next

        Dim dv As DataView
        'ordena el dataview ambos dataset
        dv = New DataView(dt1, "", "nombre asc, ccodcrt ASC", DataViewRowState.CurrentRows)

        dt2.Clear()
        dt2 = dv.Table.Clone()
        Dim dvr As DataRowView
        For Each dvr In dv
            dt2.ImportRow(dvr.Row)
        Next
        dt2.AcceptChanges()

        con.Close()

        'extra
        Dim ccodcrt As String = "1", creditos As String = "1"
        Dim primera As Integer = 0
        Dim una As Integer = 0
        For Each fila In dt2.Rows


            If una = 0 Then
                ccodcrt = fila("ccodcrt")
                creditos = fila("creditos")
                una = 1
            End If

            If ccodcrt <> fila("ccodcrt") Then
                ccodcrt = fila("ccodcrt")
                creditos = fila("creditos")
                primera = 0
            End If

            If ccodcrt = fila("ccodcrt") And creditos = fila("creditos") Then
                primera = primera + 1
            End If
            If primera > 1 Then
                fila.delete()
                primera = 0
            End If
        Next
        dt2.AcceptChanges()



        Return dt2
    End Function

    Private Sub ExportToExcel(ByVal dt As DataTable)
        Dim sb As New StringBuilder()
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim dg As New GridView

        dg.AllowPaging = False
        dg.PagerSettings.Visible = False
        dg.AutoGenerateColumns = True
        dg.RowStyle.HorizontalAlign = HorizontalAlign.Left

        Dim Page As New Page()
        Dim form As New HtmlForm()



        dg.DataSource = dt 'esta es una funcion que ya lo debes tener hecha, te tiene que retornar un datatabla para llenar tu grilla
        dg.DataBind()

        Page.EnableEventValidation = False

        Page.DesignerInitialize()

        Page.Controls.Add(form)
        form.Controls.Add(dg)

        Page.RenderControl(htw)

        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"
        Response.AddHeader("Content-Disposition", "attachment;filename=Datos.xls")
        Response.Charset = "UTF-8"
        Response.ContentEncoding = Encoding.Default
        Response.Write(sb.ToString())
        Response.End()
    End Sub
End Class
