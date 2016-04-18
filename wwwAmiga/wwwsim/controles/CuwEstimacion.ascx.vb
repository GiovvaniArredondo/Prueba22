Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class controles_CuwEstimacion
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.TextBox1.Text = Session("gdfecsis")
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        ds = procesa()

        Me.imprimir(ds, "crEstimacion.rpt")
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
        ds = procesa()
        Me.imprimir(ds, "crEstimacion2.rpt")
    End Sub

    Private Function procesa() As DataSet
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        Dim ldfecha As Date
        ldfecha = Date.Parse(Me.TextBox1.Text)

        'Estimacion actuao
        ds = ecreditos.EstimacionCartera(ldfecha)

        'mes anterior
        Dim lcfecant As String
        lcfecant = ldfecha.ToString

        Dim lcmes As String = lcfecant.Substring(3, 2)
        Dim lcyear As String = lcfecant.Substring(6, 4)

        Dim lcmesant As String = ""
        Dim lcyearant As String = ""

        If lcmes = "01" Then
            lcmesant = "12"
            lcyearant = (Integer.Parse(lcyear) - 1).ToString
        Else
            Dim lnmes As Integer = 0
            lnmes = Integer.Parse(lcmes) - 1
            If lnmes < 10 Then
                lcmesant = "0" + lnmes.ToString
            Else
                lcmesant = lnmes.ToString
            End If

            lcyearant = lcyear
        End If


        Dim fila As DataRow
        Dim i As Integer = 0
        Dim ffondos As String = ""
        Dim lnvalor As Decimal = 0
        Dim lnporcentaje As Decimal = 0
        Dim lnsaldo As Decimal = 0
        Dim lnestiant As Decimal = 0

        For Each fila In ds.Tables(0).Rows
            ffondos = fila("ffondos")
            lnsaldo = fila("nsaldo")

            
            lnporcentaje = fila("nnumtab")
            fila("cflag") = "0"

            lnvalor = Math.Round(fila("nestimacion"), 2)
            fila("valor") = lnvalor
            fila("npor") = lnporcentaje

            If fila("ccalifica") = "A" Then
                fila("etiqueta") = "0 días"
            ElseIf fila("ccalifica") = "A1" Then
                fila("etiqueta") = "1-7 días"
            ElseIf fila("ccalifica") = "A2" Then
                fila("etiqueta") = "De 8-14 días"
            ElseIf fila("ccalifica") = "B" Then
                fila("etiqueta") = "De 15-30 días"
            ElseIf fila("ccalifica") = "C1" Then
                fila("etiqueta") = "De 31-90 días"
            ElseIf fila("ccalifica") = "C2" Then
                fila("etiqueta") = "De 91-120 días"
            ElseIf fila("ccalifica") = "D1" Then
                fila("etiqueta") = "121-150 días"
            ElseIf fila("ccalifica") = "D2" Then
                fila("etiqueta") = "151-180 días"
            ElseIf fila("ccalifica") = "E" Then
                fila("etiqueta") = "Mas de 180 días"
            End If

            'busca estimacion anterior
            lnestiant = ecreditos.Estimacionpor(lcmesant, lcyearant, fila("ccodofi"), fila("ffondos"), fila("ccalifica"))
            fila("nestiant") = lnestiant
            i += 1
        Next

        Return ds
    End Function

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Obtiene las partidas q se generaron
        Dim ds As New DataSet
        Dim ediario As New cDiario

        ds = ediario.ObtieneNumerodePartidas("ESTIMACION MENSUAL CUENTA INCOBRABLES", Date.Parse(Me.TextBox1.Text))

        Me.imprimir(ds, "crListadoPar.rpt")
    End Sub
End Class
