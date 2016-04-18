Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class cuwlibretas
    Inherits ucWBase
    Private clsppal As New class1

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.cargardatos()
        End If
    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtccodcta.Text = codigoCliente
        'Nombre del Cliente
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos

        entidad3.ccodcta = codigoCliente.Trim
        ecreditos.Obtenercreditos(entidad3)
        Me.txtcflag.Text = entidad3.cnrolin
        Me.txtdfecvig.Text = entidad3.dfecvig
        Me.txtcnomcli.Text = entidad3.cnomcli.Trim

    End Sub
    Private Sub cargardatos()
        Dim ds As New DataSet
        Dim clsbancos As New SIM.BL.cTabtbco
        clsbancos.ObtenerDatasetporidtodos(ds, Session("gcCodofi"), "RE")
        Me.cmbbanco.DataTextField = "cnombco"
        Me.cmbbanco.DataValueField = "ccodbco"
        Me.cmbbanco.DataSource = ds.Tables(0)
        Me.cmbbanco.DataBind()

        Me.txtdfecini.Text = Session("gdfecsis")
        Me.txtdfecfin.Text = Session("gdfecsis")
    End Sub

    Private Sub btnaplicar2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar2.ServerClick
        Dim ds As New DataSet
        Dim lncuota As Double = 0
        Dim ecredppg As New cCredppg
        ds = ecredppg.plandepagosLibreta(Me.txtccodcta.Text.Trim, Date.Parse(Me.txtdfecini.Text.Trim), Date.Parse(Me.txtdfecfin.Text.Trim))

        If ds.Tables(0).Rows.Count = 0 Then
            Return
        End If

        Dim ele As Integer = 0
        Dim fila As DataRow
        Dim lccodcta As String
        Dim lcbanco As String
        Dim lccta As String
        Dim etabtbco As New cTabtbco

        lccodcta = ds.Tables(0).Rows(0)("ccodcta")

        clsppal.gnperbas = Session("gnperbas")
        clsppal.pnComtra = Session("gnComTra")
        If Date.Parse(Me.txtdfecvig.Text.Trim) >= #7/11/2008# Then
            clsppal.pnSegVm = Session("gnSegVm1")
        Else
            clsppal.pnSegVm = Session("gnSegVm")
        End If

        clsppal.cNrolin = Me.txtcflag.Text.Trim

        lncuota = clsppal.ValorCuota(lccodcta)
        lcbanco = Me.cmbbanco.SelectedItem.Text.Trim
        lccta = etabtbco.CuentadeBanco(Me.cmbbanco.SelectedValue.Trim)

        'Imprime
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crlibretas.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()


        crRpt.SetParameterValue("banco", lcbanco)
        crRpt.SetParameterValue("cuenta", lccta)
        crRpt.SetParameterValue("cuota", lncuota)


        Dim reportes As String
        reportes = "crlibretas.pdf"

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
End Class


