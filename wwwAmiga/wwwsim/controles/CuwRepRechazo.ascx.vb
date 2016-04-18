Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class CuwRepRechazo
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.TxtDate1.Text = Session("gdfecsis")
            Me.TxtDate2.Text = Session("gdfecsis")
        End If
    End Sub


    Private Sub imprimir(ByVal ds As DataSet, ByVal reportes As String)


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(ds.Tables(0))
        Dim lcnomins As String = Session("gcnomins")

        crRpt.SetParameterValue("cNomins", lcnomins)
        crRpt.SetParameterValue("dfec1", Date.Parse(TxtDate1.Text))
        crRpt.SetParameterValue("dfec2", Date.Parse(TxtDate2.Text))


        Dim tipo As String = ""
        Dim lcexportar As String = "PDF"

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
        'Response.Flush()
        'Response.Close()
        Response.End()


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ds As New DataSet
        Dim eclimide As New cClimide
        ds = eclimide.ObtieneClientesRechazados(Date.Parse(TxtDate1.Text), Date.Parse(TxtDate2.Text))
        Me.imprimir(ds, "crRepRechazo.rpt")
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ds As New DataSet
        Dim ecremcre As New cCremcre
        ds = ecremcre.ObtieneCreditosRechazados(Date.Parse(TxtDate1.Text), Date.Parse(TxtDate2.Text))
        Me.imprimir(ds, "crRepRechazo2.rpt")
    End Sub
End Class
