Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web




Partial Class wfReporteIncorporacion
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        Dim mControl As New ccreditos
        Dim ds As New DataSet

        'Dim codiDepa, codiMuni, codiCant As String
        'codiDepa = IIf(Request.QueryString("d") Is Nothing, "", Request.QueryString("d"))
        'codiMuni = IIf(Request.QueryString("m") Is Nothing, "", Request.QueryString("m"))
        'codiCant = IIf(Request.QueryString("c") Is Nothing, "", Request.QueryString("c"))

        'If codiDepa = "" Or codiMuni = "" Or codiCant = "" Then
        '    Me.AsignarMensaje("No se puede generar el reporte sin elejir un Cantón", True)
        '    Return
        'End If

        Try
            ds = mControl.ObtenerDataSetPorCliente("001000000001")
            If ds Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If ds.Tables(0).Rows.Count = 0 Then
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
            crRpt.Load(Server.MapPath("reportes") + "\crCreditos.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()


        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        ' Limpia el buffer
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"

        ' Escribe el contenido del stream
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()

    End Sub

    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            Label_Mensaje.CssClass = "MensajeError"
        Else
            Label_Mensaje.CssClass = "MensajeInformativo"
        End If
        Label_Mensaje.Text = mensaje
    End Sub

End Class


