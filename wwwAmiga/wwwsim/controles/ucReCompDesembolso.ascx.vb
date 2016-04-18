Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class ucReCompDesembolso
    Inherits System.Web.UI.UserControl
    Dim clsbancos As New SIM.BL.cTabtbco
    Private clsConvert As New SIM.BL.ConversionLetras
    Private codigoJs As String

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


#Region "Metodos"
    Public Sub CargarPorCliente(ByVal codigoGrupo As String)
        Dim entidadcremsol As New cremsol
        Dim mcremsol As New cCremsol

        'Dim entidad3 As New SIM.EL.creditos
        'Dim ecreditos As New SIM.BL.ccreditos
        'entidad3.ccodcta = codigoGrupo

        'ecreditos.Obtenercreditos(entidad3)
        'If entidad3.cestado <> "F" Then
        '    Me.Button1.Enabled = False

        '    codigoJs = "<script language='javascript'>alert('Estado del Crédito Errado, " & _
        '               "Advertencia SIM.NET ')</script>"
        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        '    Return
        'Else
        '    Me.Button1.Enabled = True
        'End If


        entidadcremsol.cCodsol = codigoGrupo
        mcremsol.ObtenerCremsol(entidadcremsol)


        TextBoxCcodcta.Text = codigoGrupo
        TextBoxNombre.Text = entidadcremsol.cnomgru
        TextBoxFecha.Text = Session("gdfecsis")
        TextBoxCheque.Text = "0001"
    End Sub
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
        Else
            If TextBoxCcodcta.Text <> "" Then
                Select Case TextBoxBandera.Text
                    Case "1", "4"
                        Cargar_Gastos()
                    Case "2", "3"
                        Cargar_Gastos_Grupo_Banco()
                End Select
            End If
        End If

    End Sub

    Public Sub Imprime_G()
        Dim lncapita As Double = 0
        Dim pngastos As Double = 0
        'Imprime la Reversión >>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CrRptDesemG.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsDes As New DataSet

        Dim eKardex As New SIM.BL.ckardex
        Dim nCanti As Integer
        Dim ldfecha As Date = Session("gdfecsis")
        ViewState.Add("pncom1", 0.0)
        ViewState.Add("pncom2", 0.0)
        ViewState.Add("pncom3", 0.0)
        ViewState.Add("pncom4", 0.0)
        ViewState.Add("pncom5", 0.0)
        ViewState.Add("pncom6", 0.0)
        ViewState.Add("pncom7", 0.0)
        ViewState.Add("pndeuda", 0.0)
        ViewState.Add("pccreref", "")

        'Crear aqui el dataset
        Dim ecredppg As New cCredppg
        Dim lntotcuo As Decimal = 0
        lntotcuo = ecredppg.CuotaGrupal(TextBoxCcodcta.Text.Trim, ldfecha)

        dsDes = eKardex.ObtenerDataSetPorcuenta3(TextBoxCcodcta.Text.Trim, ldfecha, Me.TextBoxCheque.Text.Trim) 'Me.TxtDocumento.Text.Trim
        nCanti = dsDes.Tables(0).Rows.Count

        If nCanti <> 0 Then
            lncapita = dsDes.Tables(0).Rows(0)("ncapdes")
            For Each fila As DataRow In dsDes.Tables(0).Rows
                fila("nmoncuo") = lntotcuo
                pngastos = fila("ngastos")
            Next
        End If

        
        ViewState("pncom1") = pngastos

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsDes.Tables(0))
        crRpt.Refresh()
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        crRpt.SetParameterValue("lncom1", ViewState("pncom1"))
        crRpt.SetParameterValue("lncom2", ViewState("pncom2"))
        crRpt.SetParameterValue("lncom3", ViewState("pncom3"))
        crRpt.SetParameterValue("lncom4", ViewState("pncom4"))
        crRpt.SetParameterValue("lncom5", ViewState("pncom5"))
        crRpt.SetParameterValue("lncom6", ViewState("pncom6"))
        crRpt.SetParameterValue("lncom7", ViewState("pncom7"))
        crRpt.SetParameterValue("lndeuda", ViewState("pndeuda"))
        crRpt.SetParameterValue("lccreref", ViewState("pccreref"))
        crRpt.SetParameterValue("pncapita", lncapita)

        Dim reportes As String
        reportes = "CrRptDesem.pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.End()
        'Response.Close()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub

    Public Sub Imprime()

        'Imprime la Reversión >>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CrRptDesem.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsDes As New DataSet

        Dim eKardex As New SIM.BL.ckardex
        Dim nCanti As Integer
        Dim ldfecha As Date = Session("gdfecsis")
        ldfecha = Date.Parse(Me.TextBoxFecha.Text.Trim)
        'Crear aqui el dataset

        'Select Case TextBoxBandera.Text
        '    Case "1", "4"
        '        dsDes = eKardex.ObtenerDataSetPorcuenta2(Me.TextBoxCcodcta.Text.Trim, "EG", Me.TextBoxCheque.Text.Trim)
        '    Case "2", "3"
        dsDes = eKardex.ObtenerDataSetPorcuenta3(Me.TextBoxCcodcta.Text.Trim, ldfecha, Me.TextBoxCheque.Text.Trim)
        'End Select



        nCanti = dsDes.Tables(0).Rows.Count

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsDes.Tables(0))
        crRpt.Refresh()
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        crRpt.SetParameterValue("lncom1", ViewState("pncom1"))
        crRpt.SetParameterValue("lncom2", ViewState("pncom2"))
        crRpt.SetParameterValue("lncom3", ViewState("pncom3"))
        crRpt.SetParameterValue("lncom4", ViewState("pncom4"))
        crRpt.SetParameterValue("lncom5", ViewState("pncom5"))
        crRpt.SetParameterValue("lncom6", ViewState("pncom6"))
        crRpt.SetParameterValue("lndeuda", ViewState("pndeuda"))
        crRpt.SetParameterValue("lccreref", ViewState("pccreref"))
        Dim reportes As String
        reportes = "CrRptDesem.pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub

    Public Sub CargaDatos(ByVal ccodcta As String, ByVal cnomcli As String, ByVal dfecha As String)
        TextBoxCcodcta.Text = ccodcta
        TextBoxNombre.Text = cnomcli
        TextBoxFecha.Text = dfecha
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Imprime()
        Imprime_G()
    End Sub

    Private Sub Cargar_Gastos()
        Dim xy As Integer
        Dim xydata As New DataSet
        Dim clscredgas As New cCredgas
        Dim lctipgas As String
        Dim lngasto As Double
        ViewState("pncom1") = 0
        ViewState("pncom2") = 0
        ViewState("pncom3") = 0
        ViewState("pncom4") = 0
        ViewState("pncom5") = 0
        ViewState("pncom6") = 0
        xydata = clscredgas.ObtenerDataSetPorID2(Me.TextBoxCcodcta.Text.Trim, "D")
        xy = xydata.Tables(0).Rows.Count
        If xy = 0 Then

        Else
            xy = 0
            Dim Filaxy As DataRow
            For Each Filaxy In xydata.Tables(0).Rows
                lctipgas = xydata.Tables(0).Rows(xy)("ctipgas")
                lngasto = xydata.Tables(0).Rows(xy)("nmongas")
                If lctipgas = "01" And lngasto <> 0 Then
                    ViewState("pncom1") = ViewState("pncom1") + xydata.Tables(0).Rows(xy)("nmongas")
                ElseIf lctipgas = "03" And lngasto <> 0 Then
                    ViewState("pncom2") = ViewState("pncom2") + xydata.Tables(0).Rows(xy)("nmongas")
                ElseIf lctipgas = "04" And lngasto <> 0 Then
                    ViewState("pncom3") = ViewState("pncom3") + xydata.Tables(0).Rows(xy)("nmongas")
                ElseIf lctipgas = "PR" And lngasto <> 0 Then
                    ViewState("pncom4") = ViewState("pncom4") + xydata.Tables(0).Rows(xy)("nmongas")
                ElseIf (lctipgas = "HI" Or lctipgas = "08") And lngasto <> 0 Then
                    ViewState("pncom5") = ViewState("pncom5") + xydata.Tables(0).Rows(xy)("nmongas")
                ElseIf lctipgas = "02" And lngasto <> 0 Then
                    ViewState("pncom6") = ViewState("pncom6") + xydata.Tables(0).Rows(xy)("nmongas")
                End If
                xy += 1
            Next
        End If
        refina()
    End Sub

    Private Sub refina()
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dscancela As New DataSet
        Dim entidad_cancela As New SIM.EL.cancela
        Dim ecancela As New SIM.BL.cCancela
        dscancela = ecancela.ObtenerDataSetPorCuenta(Me.TextBoxCcodcta.Text.Trim)

        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim e As Double
        Dim deuda As Double
        Dim deuda1 As Double
        Dim fila As DataRow
        Dim nelem As Integer = 0
        Dim pcref1 As String
        Dim pcref As String
        If dscancela.Tables(0).Rows.Count = 0 Then
            viewstate("pndeuda") = 0
            viewstate("pccreref") = ""
        Else
            For Each fila In dscancela.Tables(0).Rows
                a = dscancela.Tables(0).Rows(nelem)("nsalcap")
                b = dscancela.Tables(0).Rows(nelem)("nsalint")
                c = dscancela.Tables(0).Rows(nelem)("nsalmor")
                d = dscancela.Tables(0).Rows(nelem)("nmanejo")
                e = dscancela.Tables(0).Rows(nelem)("nseguro")
                deuda1 = a + b + c + d + e
                deuda = deuda + deuda1
                pcref1 = dscancela.Tables(0).Rows(nelem)("ccodcta")
                pcref = pcref + IIf(nelem = 0, "", ", ") + pcref1
                nelem += 1
            Next
            viewstate("pndeuda") = deuda
            viewstate("pccreref") = pcref
        End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    End Sub
    Public Sub ActualizaBandera(ByVal producto As String)
        TextBoxBandera.Text = producto
    End Sub

    Private Sub Cargar_Gastos_Grupo_Banco()

        ViewState("pncom1") = 0
        ViewState("pncom2") = 0
        ViewState("pncom3") = 0
        ViewState("pncom4") = 0
        ViewState("pncom5") = 0
        ViewState("pncom6") = 0
        ViewState("pndeuda") = 0
        ViewState("pccreref") = ""
        

    End Sub
End Class