Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class cuwplanillas
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
   

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.txtdfecha.Text = Session("gdfecsis")
            lista()
        End If

    End Sub
    Public Sub lista()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab
        mListaTabttab = clstabttab.ObtenerLista("145", "1")

        Me.ddlexportar.DataTextField = "cdescri"
        Me.ddlexportar.DataValueField = "ccodigo"
        Me.ddlexportar.DataSource = mListaTabttab
        Me.ddlexportar.DataBind()
    End Sub
    Private Sub btngraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngraba.ServerClick
        imprimir("crplanilla.rpt")
    End Sub

    Private Sub btnCancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.ServerClick
        imprimir("crplanilla2.rpt")
    End Sub

    Sub imprimir(ByVal reportes As String)
        'Verifica si existe planilla con esa fecha
        'Verifica si existe tabla
        Dim lcnombre As String
        Dim lcdia As String
        Dim lcmes As String
        Dim lcaño As String
        Dim lnverifica As Integer
        Dim eempleados As New cEmpleados


        lcdia = Me.txtdfecha.Text.Trim.Substring(0, 2)
        lcmes = Me.txtdfecha.Text.Trim.Substring(3, 2)
        lcaño = Me.txtdfecha.Text.Trim.Substring(6, 4)
        lcnombre = "Emp" & lcdia & lcmes & lcaño

        lnverifica = eempleados.VerificaHistorico(lcnombre)
        If lnverifica = 0 Then
            Response.Write("<script language='javascript'>alert('Planilla No esta Guardada')</script>")
            Exit Sub
        End If
        '
        Dim ldfecha2 As Date
        Dim lcexportar As String
        Dim i As Integer
        Dim tipo As String

        Dim dsbase As New DataSet
        dsbase = eempleados.Planilla(lcnombre)
        lcexportar = Me.ddlexportar.SelectedValue.Trim
        ldfecha2 = Date.Parse(Me.txtdfecha.Text)
        lcexportar = lcexportar.Trim



        Try
            If dsbase Is Nothing Then
                '        Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsbase.Tables(0).Rows.Count = 0 Then
                    '           Me.AsignarMensaje("No se encontro información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            '  Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim fila1 As DataRow
        Dim j As Integer = 0
        Dim lccoddepto As String
        Dim lccod As String
        Dim conta As Integer = 0
        lccoddepto = dsbase.Tables(0).Rows(0)("cdepto")
        For Each fila1 In dsbase.Tables(0).Rows
            lccod = dsbase.Tables(0).Rows(j)("cdepto")
            If lccoddepto.Trim <> lccod.Trim Then
                conta = 0
            End If
            conta = conta + 1
            lccoddepto = dsbase.Tables(0).Rows(j)("cdepto")
            dsbase.Tables(0).Rows(j)("ID") = conta.ToString
            j += 1
        Next

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = "SOCIEDAD COOPERATIVA PADECOMS CREDITO DE R.L DE C.V"

        Dim a As String
        a = dsbase.Tables(0).TableName


        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("dfecha2", ldfecha2)
        crRpt.SetParameterValue("dfecha1", Session("gdfecsis"))
        crRpt.SetParameterValue("cNomOfi", lcNomofi)


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
        'Response.End()

        dsbase.Tables(0).Clear()
        dsbase.Clear()

    End Sub

    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        imprimir2("crplanilla3.rpt")
    End Sub

    Sub imprimir2(ByVal reportes As String)
        'Verifica si existe planilla con esa fecha
        'Verifica si existe tabla
        Dim lcnombre As String
        Dim lcdia As String
        Dim lcmes As String
        Dim lcaño As String
        Dim lnverifica As Integer
        Dim eempleados As New cEmpleados


        lcdia = Me.txtdfecha.Text.Trim.Substring(0, 2)
        lcmes = Me.txtdfecha.Text.Trim.Substring(3, 2)
        lcaño = Me.txtdfecha.Text.Trim.Substring(6, 4)
        lcnombre = "Emp" & lcdia & lcmes & lcaño

        lnverifica = eempleados.VerificaHistorico(lcnombre)
        If lnverifica = 0 Then
            Response.Write("<script language='javascript'>alert('Planilla No esta Guardada')</script>")
            Exit Sub
        End If
        '
        Dim ldfecha2 As Date
        Dim lcexportar As String
        Dim i As Integer
        Dim tipo As String

        Dim dsbase As New DataSet
        dsbase = eempleados.Planilla(lcnombre)
        lcexportar = Me.ddlexportar.SelectedValue.Trim
        ldfecha2 = Date.Parse(Me.txtdfecha.Text)
        lcexportar = lcexportar.Trim



        Try
            If dsbase Is Nothing Then
                '        Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsbase.Tables(0).Rows.Count = 0 Then
                    '           Me.AsignarMensaje("No se encontro información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            '  Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim fila1 As DataRow
        Dim j As Integer = 0
        Dim lccoddepto As String
        Dim lccod As String
        Dim conta As Integer = 0
        lccoddepto = dsbase.Tables(0).Rows(0)("cdepto")
        Dim lccuenta As String
        For Each fila1 In dsbase.Tables(0).Rows
            lccod = dsbase.Tables(0).Rows(j)("cdepto")
            lccuenta = dsbase.Tables(0).Rows(j)("ccuenta")
            If lccuenta.Trim = "" Then
                dsbase.Tables(0).Rows(j).Delete()
                dsbase.Tables(0).GetChanges(DataRowState.Deleted)
            Else
                If lccoddepto.Trim <> lccod.Trim Then
                    conta = 0
                End If
                conta = conta + 1
                lccoddepto = dsbase.Tables(0).Rows(j)("cdepto")
                dsbase.Tables(0).Rows(j)("ID") = conta.ToString
            End If

            j += 1
        Next
        dsbase.Tables(0).AcceptChanges()

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = "SOCIEDAD COOPERATIVA PADECOMS CREDITO DE R.L DE C.V"

        Dim a As String
        a = dsbase.Tables(0).TableName


        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("dfecha2", ldfecha2)
        crRpt.SetParameterValue("dfecha1", Session("gdfecsis"))
        crRpt.SetParameterValue("cNomOfi", lcNomofi)


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
        'Response.End()

        dsbase.Tables(0).Clear()
        dsbase.Clear()

    End Sub

End Class
