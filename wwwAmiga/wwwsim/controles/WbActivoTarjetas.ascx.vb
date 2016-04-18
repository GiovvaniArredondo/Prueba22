Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO

Partial Class controles_WbActivoTarjetas
    Inherits System.Web.UI.UserControl


    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim cnombre As String

        cnombre = TxtNombre.Text.Trim

        Dim cUsuarios As New SIM.BL.cusuarios
        Dim ds As New DataSet

        ds = cUsuarios.ObtnerDataSetPorNombreActivoFijo(cnombre)

        If ds.Tables(0).Rows.Count > 0 Then
            Me.gvEmpleados.DataSource = ds.Tables(0)
            Me.gvEmpleados.DataBind()
        Else
            Response.Write("<script language='javascript'>alert('EL Empleado no Existe')</script>")
        End If

    End Sub

    Protected Sub gvEmpleados_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvEmpleados.SelectedIndexChanged
        Dim ccodemp As String
        Dim ccodofi As String
        Dim ccargo As String
        Dim cnombre As String
        Dim cnomofi As String
        Dim nidusu As Integer


        ccodemp = CType(gvEmpleados.SelectedRow.FindControl("Label1"), Label).Text.Trim()
        ccodofi = CType(gvEmpleados.SelectedRow.FindControl("Label2"), Label).Text.Trim()
        cnombre = CType(gvEmpleados.SelectedRow.FindControl("Label3"), Label).Text.Trim()

        txtCodOfi.Text = ccodofi

        'Busco idusuario
        Dim cUsuarios As New SIM.BL.cusuarios
        nidusu = cUsuarios.IdUsuario(ccodemp)
        txtIdUsuario.Text = nidusu

        'Busca idGrupo
        Dim eUsuarioGrupo As New SIM.BL.cUsuarioGrupo
        Dim x As Integer

        x = eUsuarioGrupo.RetornaGrupo(ccodemp)

        'Busca Grupo
        Dim entidadGrupos As New SIM.EL.grupos
        Dim eGrupos As New SIM.BL.cgrupos

        entidadGrupos.idGrupo = x
        eGrupos.Obtenergrupos(entidadGrupos)
        ccargo = entidadGrupos.grupo

        'Busca oficina
        Dim cTabtOfi As New SIM.BL.cTabtofi
        cnomofi = cTabtOfi.NombreAgencia(ccodofi)

        txtOficina.Text = cnomofi
        txtEmpleado.Text = cnombre
        txtCargo.Text = ccargo
        txtCodUsu.Text = ccodemp
    End Sub

    Protected Sub btnImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim cActivoMov As New SIM.BL.cActivoM
        Dim cUsuario As String
        Dim Ds As New DataSet
        Dim lcexportar As String
        Dim ldfecha As Date
        Dim classActivo As New clsActivo

        ldfecha = Session("gdfecsis")
        cUsuario = txtCodUsu.Text.Trim

        Ds = classActivo.DataActivoTarjeta(ldfecha, cUsuario)
        'Ds = cActivoMov.BuscaActivosEmpleado(cUsuario)

        lcexportar = "PDF"

        If Ds.Tables(0).Rows.Count > 0 Then
            Me.Imprime("crTarjetaResponsabilidad.rpt", Ds, lcexportar)
        Else
            Response.Write("<script language='javascript'>alert('Consulta Vacia')</script>")
        End If
    End Sub

    Public Sub Imprime(ByVal reportes As String, ByVal dsbase As DataSet, ByVal pcexportar As String)
        Dim ccargo As String
        Dim cnomofi As String
        Dim cntarje As String
        Dim cnomusu As String
        Dim ccodusu As String
        Dim lncasos As Integer
        Dim lcexportar As String
        Dim tipo As String
        Dim lcNomofi As String = "FUNDEA"

        'evalua parametros a enviar a reporte para sus filtros
        ccargo = txtCargo.Text.Trim.ToUpper
        cnomofi = txtOficina.Text.Trim.ToUpper
        cntarje = txtCodOfi.Text.Trim & "-" & txtIdUsuario.Text.Trim
        cnomusu = txtEmpleado.Text.Trim.ToUpper
        ccodusu = Session("gccodusu")
        lcexportar = pcexportar.Trim
        'finaliza parametros de reportes

        Try
            If dsbase Is Nothing Then
                Return
            Else
                If dsbase.Tables(0).Rows.Count = 0 Then
                    Return
                End If
            End If
        Catch ex As Exception
            Return
        End Try

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Manda parametros
        ccargo = txtCargo.Text.Trim.ToUpper
        cnomofi = txtOficina.Text.Trim.ToUpper
        cntarje = txtCodOfi.Text.Trim & "-" & txtIdUsuario.Text.Trim
        cnomusu = txtEmpleado.Text.Trim.ToUpper
        ccodusu = Session("gccodusu")

        Dim a As String
        a = dsbase.Tables(0).TableName
        lncasos = dsbase.Tables(0).Rows.Count

        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("cusuario", ccodusu)
        crRpt.SetParameterValue("ntarjeta", cntarje)
        crRpt.SetParameterValue("cargo", ccargo)
        crRpt.SetParameterValue("oficina", cnomofi)
        crRpt.SetParameterValue("cnomusu", cnomusu)

        If lcexportar = "XLS2" Then
            'Me.ExportToExcel(dsbase.Tables(0))
        Else
            Select Case lcexportar
                Case "PDF"
                    tipo = "application/pdf"
                    reportes &= ".pdf"
                    rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                Case "WRD"
                    tipo = "application/msword"
                    reportes &= ".doc"
                    rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                Case "XLS"
                    tipo = "application/vnd.ms-excel"
                    reportes &= ".xls"
                    rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
            End Select

            Response.ContentType = tipo

            'Automaticamente se descarga el archivo
            Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

            Response.BinaryWrite(rptStream.ToArray())
            Response.Flush()
            Response.Close()
        End If
        dsbase.Tables(0).Clear()
        dsbase.Clear()
    End Sub
End Class
