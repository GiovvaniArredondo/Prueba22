
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class ucestctactb
    Inherits ucWBase


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim gdfecsis As Date
            gdfecsis = Session("gdfecsis") 'Carga la fecha de sistema de la Tabtvar
            Me.txtfecha1.Text = gdfecsis.ToShortDateString
            Me.txtfecha2.Text = gdfecsis.ToShortDateString
        End If

    End Sub

    Public Sub CargarCuenta(ByVal codigoCliente As String)
        'llama cuenta contable, se elige del catalogo
        Me.txtcodcta.Text = codigoCliente
    End Sub


    Private Sub btnprint_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.ServerClick

        Dim classconta As New clsConta
        Dim dsreporte As New DataSet
        Dim mcntamov As New cCntamov
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lccodcta As String
        Dim lnnivel As Integer
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lcnomser As String

        ldfecha1 = Date.Parse(Me.txtfecha1.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtfecha2.Text.Trim)
        classconta.dFecfin = Me.txtfecha2.Text
        lccodcta = Me.txtcodcta.Text.Trim
        lnnivel = lccodcta.Length
        lcnomser = Session("gcnomser").trim

        'dsbalance = classconta.GenBalance()
        classconta.calcula_saldos(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser)
        lnsalini = classconta.pnsalini
        lnsalfin = classconta.pnsalfin
        classconta.pcCodofi = "000"
        classconta.pcFuente = "00"
        dsreporte = mcntamov.movimientos_por_cuenta(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser)

        'obtiene saldos diarios
        Dim dr As DataRow
        Dim lnsalant As Double
        lnsalant = 0
        lnsalant = lnsalini
        For Each dr In dsreporte.Tables(0).Rows
            If Left(lccodcta, 1) = "4" Or Left(lccodcta, 1) = "8" Or Left(lccodcta, 1) = "3" Or Left(lccodcta, 1) = "2" Then
                lnsalant = (lnsalant + dr("nhaber")) - dr("ndebe")
            Else
                lnsalant = (lnsalant + dr("ndebe")) - dr("nhaber")
            End If
            dr("nsalfin") = lnsalant
        Next

        If dsreporte Is Nothing Then
            Return
        End If

        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\crestctactb.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsreporte.Tables(0))

        'crRpt.SetDataSource(DataPlain.Tables(0))
        ' crRpt.Refresh()
        crRpt.SetParameterValue("ldfecha1", ldfecha1)
        crRpt.SetParameterValue("ldfecha2", ldfecha2)
        crRpt.SetParameterValue("lnsalini", lnsalini)
        crRpt.SetParameterValue("lnsalfin", lnsalfin)

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim classconta As New clsConta
        Dim dsreporte As New DataSet
        Dim mcntamov As New cCntamov
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lccodcta As String
        Dim lnnivel As Integer
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lcnomser As String

        ldfecha1 = Date.Parse(Me.txtfecha1.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtfecha2.Text.Trim)
        classconta.dFecfin = Me.txtfecha2.Text
        lccodcta = Me.txtcodcta.Text.Trim
        lnnivel = lccodcta.Length
        lcnomser = Session("gcnomser").trim

        'dsbalance = classconta.GenBalance()
        classconta.pcCodofi = "000"
        classconta.pcFuente = "00"
        classconta.calcula_saldos(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser)
        lnsalini = classconta.pnsalini
        lnsalfin = classconta.pnsalfin
        dsreporte = mcntamov.movimientos_por_cuenta(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser)

        'obtiene saldos diarios
        Dim dr As DataRow
        Dim lnsalant As Double
        lnsalant = 0
        lnsalant = lnsalini
        For Each dr In dsreporte.Tables(0).Rows
            If Left(lccodcta, 1) = "4" Or Left(lccodcta, 1) = "8" Or Left(lccodcta, 1) = "2" Or Left(lccodcta, 1) = "3" Then
                lnsalant = (lnsalant + dr("nhaber")) - dr("ndebe")
            Else
                lnsalant = (lnsalant + dr("ndebe")) - dr("nhaber")
            End If
            dr("nsalfin") = lnsalant
        Next

        If dsreporte Is Nothing Then
            Return
        End If

        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\crestctactb.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsreporte.Tables(0))

        'crRpt.SetDataSource(DataPlain.Tables(0))
        ' crRpt.Refresh()
        crRpt.SetParameterValue("ldfecha1", ldfecha1)
        crRpt.SetParameterValue("ldfecha2", ldfecha2)
        crRpt.SetParameterValue("lnsalini", lnsalini)
        crRpt.SetParameterValue("lnsalfin", lnsalfin)

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    End Sub
End Class


