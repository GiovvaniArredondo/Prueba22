Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class cuwDocCentros
    Inherits System.Web.UI.UserControl
    Dim ecentros As New ccentros
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.txtdfecha.Text = Session("gdfecsis")
            lista()
        End If

    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcCodsol.Text = codigoCliente.Trim

        Dim lcnomgru As String
        lcnomgru = ecentros.ObtenerNombre(codigoCliente.Trim)
        Me.txtcnomgru.Text = lcnomgru.Trim

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
        Dim ds As New DataSet
        Dim clase As New class1
        Dim ecremsol As New cCremsol
        ds = ecremsol.DataSetCentros(Me.txtcCodsol.Text.Trim)
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            imprimir(ds, "crhojares.rpt")

        End If
     End Sub

   
    Private Function procesoset() As DataSet
        Dim ds As New DataSet
        Dim dsgas As New DataSet

        Dim clase As New class1
        Dim ecremcre As New cCremcre
        Dim etabtzon As New cTabtzon
        Dim ldfecant As Date
        Dim lncomodin As Integer = 0
        ldfecant = ecremcre.PresGrAnt(Me.txtcCodsol.Text.Trim)

        ds = ecentros.DataSetDoc2(Me.txtcCodsol.Text.Trim)
        Dim fila As DataRow
        Dim fila1 As DataRow

        Dim i As Integer = 0

        Dim lccodcta As String
        Dim lccodact As String
        Dim lccodzon As String
        Dim lccodcli As String
        Dim ecredgas As New cCredgas
        Dim etabtciu As New cTabtciu
        For Each fila In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(i)("cCodcta")
            lccodact = ds.Tables(0).Rows(i)("cCodact")
            lccodzon = ds.Tables(0).Rows(i)("cCodzon")
            lccodcli = ds.Tables(0).Rows(i)("cCodcli")
            lncomodin = ecremcre.AntSocio(lccodcli, Me.txtcCodsol.Text.Trim, ldfecant)
            dsgas = ecredgas.ObtenerDataSetPorID2(lccodcta, "D")

            Dim lndescuento As Double = 0
            Dim lngasto As Double = 0
            Dim y As Integer = 0
            For Each fila1 In dsgas.Tables(0).Rows
                lngasto = dsgas.Tables(0).Rows(y)("nmongas")
                lndescuento = lndescuento + lngasto
                y += 1
            Next
            ds.Tables(0).Rows(i)("nDescuento") = lndescuento
            ds.Tables(0).Rows(i)("cActividad") = etabtciu.CIIU(lccodact)
            ds.Tables(0).Rows(i)("npresant") = ecremcre.PresAnt(lccodcta)
            If IsDBNull(lccodzon) Or lccodzon = Nothing Then
                ds.Tables(0).Rows(i)("cdepto") = ""
                ds.Tables(0).Rows(i)("cmuni") = ""
            Else
                ds.Tables(0).Rows(i)("cdepto") = etabtzon.Zona(lccodzon.Trim.Substring(0, 2))
                ds.Tables(0).Rows(i)("cmuni") = etabtzon.Zona(lccodzon.Trim.Substring(0, 4))
            End If
            ds.Tables(0).Rows(i)("cdepto") = etabtzon.Zona(lccodzon.Trim.Substring(0, 2))
            ds.Tables(0).Rows(i)("cmuni") = etabtzon.Zona(lccodzon.Trim.Substring(0, 4))

            If lncomodin = 0 Then
                ds.Tables(0).Rows(i)("nsocnue") = 1
                ds.Tables(0).Rows(i)("nsocant") = 0
                ds.Tables(0).Rows(i)("nsocret") = 0
            ElseIf lncomodin = 1 Then
                ds.Tables(0).Rows(i)("nsocnue") = 0
                ds.Tables(0).Rows(i)("nsocant") = 1
                ds.Tables(0).Rows(i)("nsocret") = 0
            Else
                ds.Tables(0).Rows(i)("nsocret") = 1
                ds.Tables(0).Rows(i)("nsocnue") = 0
                ds.Tables(0).Rows(i)("nsocant") = 0
            End If
            i += 1
        Next
        Return ds
    End Function


    Sub imprimir(ByVal ds As DataSet, ByVal reportes As String)
        '
        Dim ldfecha2 As Date
        Dim lcexportar As String
        Dim i As Integer
        Dim tipo As String

        Dim dsbase As New DataSet
        dsbase = ds
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


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = "FONDESOL"

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
        Dim lcNomofi As String = "FONDESOL"

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

    Private Sub Imprime_Recibo_Grupal()
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        Dim tipo As String
        Dim reportes As String = "crestcentro.rpt"
        Dim ldfecha As Date = Date.Parse(Me.txtdfecha.Text)
        ecreditos.pnporseg = Session("gnporseg")
        ecreditos.pnpordan = Session("gnsegdan")
        ecreditos.pnporres = Session("gnporres")
        ecreditos.pnportal = Session("gntalona")
        ecreditos.pncosind = Session("gncosind")
        'Dim mclass As New creditos
        ecreditos.pncomtra = Session("gncomtra")
        ecreditos.pnperbas = Session("gnperbas")
        ecreditos.pnsegvm = Session("gnSegVm")
        ecreditos.pnsegvm1 = Session("gnSegVm1")

        ds = ecreditos.CarteraCalculadaxCentro(ldfecha, Me.txtcCodsol.Text.Trim)
        Dim lcexportar As String = Me.ddlexportar.SelectedValue.Trim
        '-----------------------------------------'
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()

        crRpt.SetParameterValue("dfecha2", ldfecha)

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

        'reportes = "crpagos.rpt"

        Response.ContentType = tipo


        'Automaticamente se descarga el archivo
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
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
        'Response.End()
    End Sub
    Private Sub btnrecibo_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibo.ServerClick
        Me.Imprime_Recibo_Grupal()
    End Sub
End Class
