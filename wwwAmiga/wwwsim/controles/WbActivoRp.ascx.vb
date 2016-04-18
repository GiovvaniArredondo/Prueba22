Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO

Public Class WbActivoRp
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

#Region " Variables "
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private clase As New SIM.bl.class1
    Private classActivo As New clsActivo
    Dim eactivof As New cActivoF

    Private pcCodCta As String
    'Private lNuevo As Boolean
    Private vCnn As Boolean
    Private Transacc As String
    Private ds As New DataSet
    Private ds_R As New DataSet
    Private lnindice_R As Integer
    Private lnindice_R1 As Integer
    Private lncodigo_R As String
    Private lnVal_R As String
    Private llBan_R As Boolean = False
    Private x As Integer
    Private y As Integer
    Private lnusu_R As String
    Private lnapl_R As String


    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String

    '--------------------------------  
    Private pcTipCre As String
    Private pcNrolin As String
    Private gcCodUsu As String = "FRAN"
    Private pnCiclo As Integer
    Private pcTipGar As String
    Private valor As Integer
    Private ValorS As String
#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

#Region " Metodos "
    Private Sub CargarDatos()

        'Origen de la Adquisicion
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1301'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.ddltipo.DataTextField = "cDescri"
        Me.ddltipo.DataValueField = "cCodigo"
        Me.ddltipo.DataSource = ds.Tables("Resultado")
        Me.ddltipo.DataBind()
        ds.Tables("Resultado").Clear()


        'Agregado Nuevo
        'Fuente de Fondos
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab
        Dim lcfondos As String
        lcfondos = Session("gcfondo")

        mListaTabttab = clstabttab.ObtenerListaPorIDxcodigo("033", "1", lcfondos)

        Me.ddlfondos.DataTextField = "cdescri"
        Me.ddlfondos.DataValueField = "ccodigo"
        Me.ddlfondos.DataSource = mListaTabttab
        Me.ddlfondos.DataBind()


        'Ubicacion Fisica
        'lnparametro1_R = "cDescri , cCodigo, "
        'lnparametro2_R = "S,S, "
        'lnparametro3_R = " "
        'lnparametro4_R = "TABTTAB"
        'lnparametro5_R = "S"
        'lnparametro6_R = "Where cCodTab + cTipReg ='1201'"
        'Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        'lnparametro4_R, lnparametro5_R, lnparametro6_R)
        'ds = cls1.ResulSelect(Transacc)
        'If ds.Tables("Resultado").Rows.Count <= 0 Then
        '    Exit Sub
        'End If
        'Me.DropDownList3.DataTextField = "cDescri"
        'Me.DropDownList3.DataValueField = "cCodigo"
        'Me.DropDownList3.DataSource = ds.Tables("Resultado")
        'Me.DropDownList3.DataBind()
        'ds.Tables("Resultado").Clear()

        'Activo Fijo
        'lnparametro1_R = "cDescri , cCodigo, "
        'lnparametro2_R = "S,S, "
        'lnparametro3_R = " "
        'lnparametro4_R = "TABTTAB"
        'lnparametro5_R = "S"
        'lnparametro6_R = "Where cCodTab + cTipReg ='1131'"
        'Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        'lnparametro4_R, lnparametro5_R, lnparametro6_R)
        'ds = cls1.ResulSelect(Transacc)
        'If ds.Tables("Resultado").Rows.Count <= 0 Then
        '    Exit Sub
        'End If
        'Me.Dropdownlist4.DataTextField = "cDescri"
        'Me.Dropdownlist4.DataValueField = "cCodigo"
        'Me.Dropdownlist4.DataSource = ds.Tables("Resultado")
        'Me.Dropdownlist4.DataBind()
        'ds.Tables("Resultado").Clear()

        'Clasificacion del activo Fijo
        'lnparametro1_R = "cDescri , ctipact, "
        'lnparametro2_R = "S,S, "
        'lnparametro3_R = " "
        'lnparametro4_R = "TABTACT"
        'lnparametro5_R = "S"
        'lnparametro6_R = "Where cCodact = '10'"
        'Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        'lnparametro4_R, lnparametro5_R, lnparametro6_R)
        'ds = cls1.ResulSelect(Transacc)
        'If ds.Tables("Resultado").Rows.Count <= 0 Then
        '    Exit Sub
        'End If
        'Me.Dropdownlist5.DataTextField = "cDescri"
        'Me.Dropdownlist5.DataValueField = "ctipact"
        'Me.Dropdownlist5.DataSource = ds.Tables("Resultado")
        'Me.Dropdownlist5.DataBind()
        'ds.Tables("Resultado").Clear()

        'Oficina
        lnparametro1_R = "cnomofi , cCodofi, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTOFI"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cdrive <> 'A'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.ddloficinas.DataTextField = "cnomofi"
        Me.ddloficinas.DataValueField = "cCodofi"
        Me.ddloficinas.DataSource = ds.Tables("Resultado")
        Me.ddloficinas.DataBind()
        ds.Tables("Resultado").Clear()


        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1451'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.ddlexportar.DataTextField = "cDescri"
        Me.ddlexportar.DataValueField = "cCodigo"
        Me.ddlexportar.DataSource = ds.Tables("Resultado")
        Me.ddlexportar.DataBind()
        ds.Tables("Resultado").Clear()

        '---- Carga Clasificación de Activos
        'Activo Fijo
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1291'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.ddlClasActivo.DataTextField = "cDescri"
        Me.ddlClasActivo.DataValueField = "cCodigo"
        Me.ddlClasActivo.DataSource = ds.Tables("Resultado")
        Me.ddlClasActivo.DataBind()
        ds.Tables("Resultado").Clear()

        Me.TxtDate2.Text = Session("gdfecsis")
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)

    End Sub
#End Region

    Public Sub Imprime(ByVal reportes As String, ByVal dsbase As DataSet, ByVal pcexportar As String)
        Dim ldfecha As Date
        Dim lncasos As Integer
        ldfecha = Date.Parse(Me.TxtDate2.Text)

        'evalua parametros a enviar a reporte para sus filtros
        Dim lcoficina As String
        Dim lcfondo As String
        Dim lcestrato As String
        Dim ldfecha2 As Date
        Dim lcexportar As String
        Dim lndepre As String = ""
        Dim lcodact As String
        Dim i As Integer
        Dim tipo As String

        ldfecha2 = Date.Parse(Me.TxtDate2.Text)
        lcexportar = pcexportar.Trim

        If Me.chqoficinas.Checked = True Then
            lcoficina = "Todas las Oficinas"
        Else
            i = Me.ddloficinas.SelectedIndex
            lcoficina = Me.ddloficinas.Items(i).Text
        End If

        If chqdepcon.Checked = False Then
            If ddldepreciable.SelectedIndex = 0 Then
                lndepre = "Si Depreciable"
            ElseIf ddldepreciable.SelectedIndex = 1 Then
                lndepre = "No Depreciable"
            End If
        Else
            lndepre = "Todos los Activos"
        End If

        If Me.chqtipo.Checked = True Then
            lcestrato = "Todos Los Tipos"
        Else
            i = Me.ddltipo.SelectedIndex
            lcestrato = Me.ddltipo.Items(i).Text
        End If

        'Agregado 24/11/2011
        If Me.chqfondos.Checked = True Then
            lcfondo = "Todos los Fondos"
        Else
            i = Me.ddlfondos.SelectedIndex
            lcfondo = Me.ddlfondos.Items(i).Text
        End If

        If Me.chqclasactivo.Checked = True Then
            lcodact = "Todas las Clasificaciones"
        Else
            i = Me.ddlClasActivo.SelectedIndex
            lcodact = Me.ddlClasActivo.Items(i).Text
        End If

        'finaliza parametros de reportes

        Try
            If dsbase Is Nothing Then
                Return
            Else
                If dsbase.Tables(0).Rows.Count = 0 Then
                    Return
                End If
            End If
        Catch ex As Exception
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
        Dim lcNomofi As String = "FUNDEA"

        Dim a As String
        a = dsbase.Tables(0).TableName
        lncasos = dsbase.Tables(0).Rows.Count

        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("Oficina", lcoficina)
        crRpt.SetParameterValue("Tipo", lcestrato)
        crRpt.SetParameterValue("Fecha", ldfecha)
        crRpt.SetParameterValue("Fondo", lcfondo)
        crRpt.SetParameterValue("Depreciable", lndepre)
        crRpt.SetParameterValue("ClaseActivo", lcodact)

        '-----------------------------------------
        If lcexportar = "XLS2" Then
            Me.ExportToExcel(dsbase.Tables(0))
        Else
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

        End If
        dsbase.Tables(0).Clear()
        dsbase.Clear()
    End Sub

    Private Sub ExportToExcel(ByVal dt As DataTable)
        Dim sb As New StringBuilder()
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim dg As New GridView

        dg.AllowPaging = False
        dg.PagerSettings.Visible = False
        dg.AutoGenerateColumns = True
        dg.RowStyle.HorizontalAlign = HorizontalAlign.Left

        Dim Page As New Page()
        Dim form As New HtmlForm()


        dg.DataSource = dt 'esta es una funcion que ya lo debes tener hecha, te tiene que retornar un datatabla para llenar tu grilla
        dg.DataBind()

        Page.EnableEventValidation = False

        Page.DesignerInitialize()

        Page.Controls.Add(form)
        form.Controls.Add(dg)

        Page.RenderControl(htw)

        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"
        Response.AddHeader("Content-Disposition", "attachment;filename=Datos.xls")
        Response.Charset = "UTF-8"
        Response.ContentEncoding = Encoding.Default
        Response.Write(sb.ToString())
        Response.End()
    End Sub

    Protected Sub btnImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim lcexportar As String
        Dim ldfecha As Date
        Dim ccodofi As String
        Dim ffondos As String
        Dim ccodadq As String
        Dim ndepre As Integer
        Dim ccodact As String

        If chqoficinas.Checked = False Then
            ccodofi = ddloficinas.SelectedValue.Trim
        Else
            ccodofi = ""
        End If

        If chqfondos.Checked = False Then
            ffondos = ddlfondos.SelectedValue.Trim
        Else
            ffondos = ""
        End If

        If chqdepcon.Checked = True Then
            ndepre = 2
        Else
            If ddldepreciable.SelectedIndex = 0 Then
                ndepre = 1
            ElseIf ddldepreciable.SelectedIndex = 1 Then
                ndepre = 0
            End If
        End If

        If chqtipo.Checked = False Then
            ccodadq = ddltipo.SelectedValue.Trim
        Else
            ccodadq = ""
        End If

        If chqclasactivo.Checked = False Then
            ccodact = ddlClasActivo.SelectedValue.Trim
        Else
            ccodact = ""
        End If

        ldfecha = Date.Parse(Me.TxtDate2.Text.Trim)
        lcexportar = Me.ddlexportar.SelectedValue.Trim

        Dim ds As New DataSet

        ds = classActivo.DataActivo(ldfecha, ccodofi, ffondos, ndepre, ccodadq, ccodact)
        If ds.Tables(0).Rows.Count > 0 Then
            Me.Imprime("Activof.rpt", ds, lcexportar)
        Else
            Response.Write("<script language='javascript'>alert('Consulta Vacia')</script>")
        End If
    End Sub
End Class
