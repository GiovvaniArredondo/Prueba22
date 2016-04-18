Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web



Partial Class controles_Creditos_WbUCPagoRefG
    Inherits ucWBase


#Region "Variables"
    Private mcremcre As New cCremcre
    Private ecremsol As New cCremsol
    Private vdetalle As New DataSet
#End Region

#Region "Metodos"
    Public Sub CargarPorCliente(ByVal codigoCliente As String)

        Me.txtccodcli.Text = codigoCliente.Trim
        Dim lcnomgru As String
        lcnomgru = ecremsol.ObtenerNombre(codigoCliente.Trim)
        Me.txtcnomcli.Text = lcnomgru

        vdetalle = mcremcre.Extrae_Datos_Grupo_Solidario(Me.txtccodcli.Text.Trim)

        If vdetalle.Tables(0).Rows.Count > 0 Then
            btnImprime.Enabled = True
        End If

        Grid_Grupo.DataSource = vdetalle.Tables(0)
        Grid_Grupo.DataBind()

    End Sub


    Private Sub imprimir_Factura(ByVal reportes As String)
        Dim lnCantidad As Double = 0
        Dim lccanlet As String
        Dim lndecimal As Double
        Dim lcCantidad As String
        Dim lcIFE As String = ""
        Dim lcdecimal As String
        Dim lntamano As Integer
        Dim clsConvert As New ConversionLetras
        'Obtener Registro a Imprimir

        vdetalle = mcremcre.Extrae_Datos_Grupo_Solidario_Impresion(Me.txtccodcli.Text.Trim)


        For Each fila As DataRow In vdetalle.Tables(0).Rows

            lnCantidad = fila("ncapdes")
            lcCantidad = Format(Math.Round(lnCantidad, 2), "$###,###,###.00").ToString.Trim

            lccanlet = ConversionLetras.ConversionEnteros(lnCantidad)
            lndecimal = clsConvert.ExtraeDecimales(lnCantidad)

            'Convertira a 2 digitos los decimales
            lcdecimal = lndecimal.ToString.Trim
            lntamano = lcdecimal.Length
            For n = 1 To 2 - lntamano
                lcdecimal = "0" + lcdecimal
            Next n

            lccanlet = "******" + lccanlet.Trim & " PESOS " & lcdecimal.ToString & "/100 M.N." + "******"

            fila("cmonto") = lcCantidad
            fila("cletras") = lccanlet

            'Formateando IFE a 20 digitos
            lcIFE = fila("id_ife")

            lntamano = lcIFE.Length
            For n = 1 To 20 - lntamano
                lcIFE = lcIFE + "0"
            Next n

            fila("id_ife") = lcIFE
        Next
        ' Nombre de usuario
        Dim mUsuarios As New cusuarios
        Dim nomusu As String = ""
        nomusu = mUsuarios.NombreUsuario(Session("gccodusu"))



        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(vdetalle.Tables(0))
        crRpt.SetParameterValue("cnomusu", nomusu)
        

        reportes &= ".pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True

        Response.ContentType = "application/pdf"
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

        Response.BinaryWrite(rptStream.ToArray())
        Response.Flush()
        Response.Close()



    End Sub

#End Region

    Protected Sub btnImprime_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        imprimir_Factura("crFac_DesembG.rpt")
    End Sub
End Class
