Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class controles_Creditos_WUCPromocion
    Inherits ucWBase

#Region "Privadas"
    Private omcremcre As New cCremcre
    Private vdetalle As New DataSet
#End Region

#Region "Metodos"
    Private Function Genera_Promocion(ByVal cCodofi As String, ByVal ndias As Integer, _
                                    ByVal pdfecha As Date) As DataSet

        vdetalle = omcremcre.Cartera_Promociones(cCodofi, ndias, pdfecha)

        Return vdetalle

    End Function

    Public Sub Inicio()
        Me.CbxOficinas1.Recuperar()
    End Sub


    Public Sub Cargar_Datos()
        Buscar()
    End Sub


    Private Sub Buscar()

        vdetalle = Genera_Promocion(Me.CbxOficinas1.SelectedValue.Trim, 40, Session("gdfecsis"))

        If vdetalle.Tables(0).Rows.Count > 0 Then
            btnPrint.Visible = True
            btnPrint.Enabled = True
        End If

        GridPromocion.DataSource = vdetalle.Tables(0)
        GridPromocion.DataBind()


    End Sub


    Private Sub imprimir(ByVal reportes As String)

        vdetalle = omcremcre.Cartera_Promociones_Detalle(Me.CbxOficinas1.SelectedValue.Trim, 40, Session("gdfecsis"))



        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(vdetalle.Tables(0))

        crRpt.SetParameterValue("gcnominst", Session("gcNomIns"))


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


    Protected Sub btnCargar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Buscar()
    End Sub


    Protected Sub GridPromocion_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridPromocion.PageIndexChanging
        GridPromocion.PageIndex = e.NewPageIndex
        Call Buscar()
    End Sub

    Protected Sub GridPromocion_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridPromocion.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not GridPromocion.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = GridPromocion.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(GridPromocion.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = GridPromocion.PageIndex + 1
        End If
    End Sub

    Protected Sub GridNiveles_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPromocion.SelectedIndexChanged

    End Sub


    Protected Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        imprimir("RptPromocion.rpt")
    End Sub
End Class
