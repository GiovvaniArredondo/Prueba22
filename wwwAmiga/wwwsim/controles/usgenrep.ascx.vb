Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO

Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
'Imports Sql.Data
'Imports Sql.Data.MySqlClient


Public Class usgenrep
    Inherits System.Web.UI.UserControl

#Region "Variables"
    Dim lnsolant As Integer = 0
    Dim lnsolper As Integer = 0
    Dim lnsolapr As Integer = 0
    Dim lnsolden As Integer = 0
    Dim lncrecol As Integer = 0
    Dim lnmoncol As Double = 0
    Private codigoJs As String

    Dim lnnumana As Integer = 0
    Dim lntiepro As Integer = 3
    Dim TotalCreditosOtorgados As Decimal = 0
    Dim MontoOtorgado As Decimal = 0
    Dim Promedio As Decimal = 0
#End Region

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
            'Me.rbtIngresos.Checked = True
            Try
                Me.Listas()
                Me.Inicio()
                Me.permisos()
            Catch ex As Exception

            End Try
           
        End If

    End Sub
    Public Sub permisos()
        
        Dim lccodofi As String = Session("gcCodofi")
        If lccodofi = "001" Then
        Else
            Me.chqoficinas.Checked = False
            Me.chqoficinas.Enabled = False
            Me.ddloficinas.Enabled = True
        End If
    End Sub

    Public Sub Inicio()
        Dim gdfecsis As DateTime
        gdfecsis = Session("gdfecsis")

        Me.TxtDate1.Text = gdfecsis.ToShortDateString
        Me.TxtDate2.Text = gdfecsis.ToShortDateString
        Me.TxtDate3.Text = gdfecsis.ToShortDateString

        Me.chqoficinas.Checked = True
        'Me.ddloficinas.Enabled = False
        Me.ddloficinas.Items(0).Selected = True

        Me.chqanalistas.Checked = True
        'Me.ddlanalistas.Enabled = False
        Me.ddlanalistas.Items(0).Selected = True

        Me.chqestrato.Checked = True
        'Me.ddlestrato.Enabled = False
        Me.ddlestrato.Items(0).Selected = True

        Me.chqlineas.Checked = True
        'Me.ddllineas.Enabled = False
        Me.ddllineas.Items(0).Selected = True

        Me.chqcartera.Checked = True
        'Me.ddlcartera.Enabled = False
        Me.ddlcartera.Items(0).Selected = True

        Me.chqtipo.Checked = True
        'Me.ddltipo.Enabled = False
        Me.ddltipo.Items(0).Selected = True


        Me.chqmuni.Checked = True
        'Me.ddlmuni.Enabled = False
        Me.ddlmuni.Items(0).Selected = True

        'Me.chqcajeros.Checked = True
        'Me.ddlcajeros.Enabled = True
        'Me.ddlcajeros.Items(0).Selected = True

        txtrango1.Text = 30
        txtrango2.Text = 60
        txtrango3.Text = 90
        txtrango4.Text = 180

        Dim etabttab As New cTabttab
        Dim ds As New DataSet

        ds = etabttab.ObtenerDataSetPorIDx("023", "1")

        datagrid1.DataSource = ds.Tables(0)
        Me.datagrid1.DataBind()

        Me.datagrid1.Columns(0).Visible = False
        Me.datagrid1.Columns(3).Visible = False
        Me.datagrid1.Columns(4).Visible = False
    End Sub

    Public Sub Listas()
        '---------------------------
        'oficinas
        '---------------------------
        Dim clstabtofi As New cTabtofi
        Dim mtabtofi As New tabtofi
        Dim listaofi As New listatabtofi

        listaofi = clstabtofi.ObtenerListaporNivel2(Session("gnNivel"), Session("gcCodOfi"))
        Me.ddloficinas.DataTextField = "cnomofi"
        Me.ddloficinas.DataValueField = "ccodofi"
        Me.ddloficinas.DataSource = listaofi
        Me.ddloficinas.DataBind()

        '---------------------------
        'Analista
        '---------------------------
        Dim clsTabtusu As New SIM.BL.cTabtusu
        Dim mListaTabtUsu As New listatabtusu


        mListaTabtUsu = clsTabtusu.ObtenerLista("ANA", Session("gcCodofi"))

        Me.ddlanalistas.DataTextField = "cNomusu"
        Me.ddlanalistas.DataValueField = "cCodUsu"
        Me.ddlanalistas.DataSource = mListaTabtUsu
        Me.ddlanalistas.DataBind()

        '---------------------------
        'Estrato
        '---------------------------

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("108", "1")

        Me.ddlestrato.DataTextField = "cdescri"
        Me.ddlestrato.DataValueField = "ccodigo"
        Me.ddlestrato.DataSource = mListaTabttab
        Me.ddlestrato.DataBind()


        '---------------------------
        'lineas
        '---------------------------
        Dim clscretlin As New cCretlin
        Dim mcretlin As New tabtofi
        Dim listalineas As New listacretlin

        mListaTabttab = clstabttab.ObtenerLista("033", "1")

        listalineas = clscretlin.ObtenerLista
        Me.ddllineas.DataTextField = "cdescri"
        Me.ddllineas.DataValueField = "ccodigo"
        Me.ddllineas.DataSource = mListaTabttab 'listalineas
        Me.ddllineas.DataBind()

        '---------------------------
        'Condicion
        '---------------------------


        mListaTabttab = clstabttab.ObtenerLista("046", "1")

        Me.ddlcartera.DataTextField = "cdescri"
        Me.ddlcartera.DataValueField = "ccodigo"
        Me.ddlcartera.DataSource = mListaTabttab
        Me.ddlcartera.DataBind()

        '---------------------------
        'Tipo
        '---------------------------


        mListaTabttab = clstabttab.ObtenerLista("122", "1")

        Me.ddltipo.DataTextField = "cdescri"
        Me.ddltipo.DataValueField = "ccodigo"
        Me.ddltipo.DataSource = mListaTabttab
        Me.ddltipo.DataBind()
        '---------------------------
        'Exportar a
        '---------------------------


        mListaTabttab = clstabttab.ObtenerLista("145", "1")

        Me.ddlexportar.DataTextField = "cdescri"
        Me.ddlexportar.DataValueField = "ccodigo"
        Me.ddlexportar.DataSource = mListaTabttab
        Me.ddlexportar.DataBind()

        '-----------------------------
        ' Municipios
        '-----------------------------

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon
        mTabtZon = clsTabtZon.ObtenerLista("2")
        Me.ddlmuni.DataTextField = "cDesZon"
        Me.ddlmuni.DataValueField = "cCodzon"
        Me.ddlmuni.DataSource = mTabtZon
        Me.ddlmuni.DataBind()

        'CAJEROS'
        'Dim clsusuarios As New SIM.BL.cusuarios
        'Dim mListausuarios As New listausuarios

        'mListausuarios = clsusuarios.ObtenerListaporID2("CAJ")

        'Me.ddlcajeros.DataTextField = "nombre"
        'Me.ddlcajeros.DataValueField = "usuario"
        'Me.ddlcajeros.DataSource = mListausuarios
        'Me.ddlcajeros.DataBind()


        '---------------------------
        'Estrato
        '---------------------------



        mListaTabttab = clstabttab.ObtenerLista("125", "1")

        Me.ddlproducto.DataTextField = "cdescri"
        Me.ddlproducto.DataValueField = "ccodigo"
        Me.ddlproducto.DataSource = mListaTabttab
        Me.ddlproducto.DataBind()

        Me.chqproducto.Checked = True
    End Sub


    'procesar dataos 

    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub



    Public Sub Imprime(ByVal reportes As String, ByVal dsbase As DataSet, ByVal pcexportar As String)

        Dim ldfecha As Date
        Dim lncasos As Integer
        ldfecha = Date.Parse(Me.TxtDate2.Text)

        'evalua parametros a enviar a reporte para sus filtros
        Dim lcoficina As String
        Dim lcanalista As String
        Dim lcestrato As String
        Dim lczona As String
        Dim lccajeros As String
        Dim lclineas As String
        Dim lcproductos As String
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lcexportar As String
        Dim i As Integer
        Dim tipo As String
        Dim lctipo As String

        ldfecha1 = Date.Parse(Me.TxtDate1.Text)
        ldfecha2 = Date.Parse(Me.TxtDate2.Text)
        lcexportar = pcexportar.Trim

        If Me.chqoficinas.Checked = True Then
            lcoficina = "Todas las oficinas"
        Else
            i = Me.ddloficinas.SelectedIndex
            lcoficina = Me.ddloficinas.Items(i).Text
        End If

        If Me.chqanalistas.Checked = True Then
            'If Session("gnnivel") < 9 Then
            '    i = Me.ddlanalistas.SelectedIndex
            '    lcanalista = Me.ddlanalistas.Items(i).Text
            'Else
            lcanalista = "Todos los analistas"
            'End If

        Else
            i = Me.ddlanalistas.SelectedIndex
            lcanalista = Me.ddlanalistas.Items(i).Text
        End If


        If Me.chqlineas.Checked = True Then
            lclineas = "Todas las Fuentes de fondos"
        Else
            i = Me.ddllineas.SelectedIndex
            lclineas = Me.ddllineas.Items(i).Text
        End If
        If Me.chqmuni.Checked = True Then
            lczona = "Todos los Municipios"
        Else
            i = Me.ddlmuni.SelectedIndex
            lczona = Me.ddlmuni.Items(i).Text
        End If

        ' If Me.chqcajeros.Checked = True Then
        lccajeros = "Todos los cajeros"
        'Else
        'i = Me.ddlcajeros.SelectedIndex
        'lccajeros = Me.ddlcajeros.Items(i).Text
        'lccajeros = "Todos los cajeros"
        'End If
        'finaliza parametros de reportes

        If Me.chqproducto.Checked = True Then
            lcproductos = "Todos los productos"
        Else
            i = Me.ddlproducto.SelectedIndex
            lcproductos = Me.ddlproducto.Items(i).Text
        End If

        'Tipo de Cartera
        If Me.chqtipo.Checked = True Then
            lctipo = ""
        Else
            i = Me.ddltipo.SelectedIndex
            lctipo = Me.ddltipo.Items(i).Text
        End If

        If Me.chqcartera.Checked = True Then
            lcestrato = "Toda la Cartera " & lctipo
        Else
            i = Me.ddlcartera.SelectedIndex
            lcestrato = Me.ddlcartera.Items(i).Text.Trim & " " & lctipo
        End If


        Try
            If dsbase Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsbase.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("No se encontro información a ser desplegada")
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
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = "REFICOM-CDRO"

        Dim a As String
        a = dsbase.Tables(0).TableName
        lncasos = dsbase.Tables(0).Rows.Count

        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("oficina", lcoficina)
        crRpt.SetParameterValue("analista", lcanalista)
        crRpt.SetParameterValue("estrato", lcestrato)
        crRpt.SetParameterValue("linea", lclineas)
        crRpt.SetParameterValue("dfecha1", ldfecha1)
        crRpt.SetParameterValue("dfecha2", ldfecha2)
        crRpt.SetParameterValue("cNomOfi", lcNomofi)

        crRpt.SetParameterValue("czona", lczona)

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
            'Response.Flush()
            'Response.Close()
            Response.End()
            'Response.End()

        End If

        dsbase.Tables(0).Clear()
        dsbase.Clear()

    End Sub


    Private Sub chqoficinas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqoficinas.CheckedChanged
        'Dim lncuenta As Integer
        'Dim i As Integer
        'Dim lccodigo As String

        'If Me.chqoficinas.Checked = True Then
        '    Me.ddloficinas.Enabled = False
        'Else
        '    Me.ddloficinas.Enabled = True
        'End If

    End Sub

    Private Sub chqanalistas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqanalistas.CheckedChanged

        'If Me.chqanalistas.Checked = True Then
        '    Me.ddlanalistas.Enabled = False
        'Else
        '    Me.ddlanalistas.Enabled = True
        'End If

    End Sub

    Private Sub chqestrato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqestrato.CheckedChanged
        'If Me.chqestrato.Checked = True Then
        '    Me.ddlestrato.Enabled = False
        'Else
        '    Me.ddlestrato.Enabled = True
        'End If

    End Sub

    Private Sub chqlineas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqlineas.CheckedChanged
        'If Me.chqlineas.Checked = True Then
        '    Me.ddllineas.Enabled = False
        'Else
        '    Me.ddllineas.Enabled = True
        'End If
    End Sub

    'calculo de la reserva
    Private Sub rdbcarana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbtDesem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub imagenes()

    End Sub

    Private Sub chqcartera_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqcartera.CheckedChanged
        'If Me.chqcartera.Checked = True Then
        '    Me.ddlcartera.Enabled = False
        'Else
        '    Me.ddlcartera.Enabled = True
        'End If
    End Sub

    Private Sub chqtipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqtipo.CheckedChanged
        'If Me.chqtipo.Checked = True Then
        '    Me.ddltipo.Enabled = False
        'Else
        '    Me.ddltipo.Enabled = True
        'End If
    End Sub

    Private Sub ddltipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chqmuni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqmuni.CheckedChanged
        'If Me.chqmuni.Checked = True Then
        '    Me.ddlmuni.Enabled = False
        'Else
        '    Me.ddlmuni.Enabled = True
        'End If
    End Sub

  
    Private Function Informe(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Dim ecreditos As New ccreditos
        Dim eusuarios As New cusuarios


        lnsolant = ecreditos.CarteraEstadistica(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, "3", lccartera, lczona, "C", "N")
        lnsolper = ecreditos.CarteraEstadistica(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, "0", lccartera, lczona, "C", "N")
        lnsolapr = ecreditos.CarteraEstadistica(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, "0", lccartera, lczona, "E", "N")
        lnsolden = ecreditos.CarteraEstadistica(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, "4", lccartera, lczona, "C", "N")
        lncrecol = ecreditos.CarteraEstadistica(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, "5", lccartera, lczona, "F", "N")
        lnmoncol = ecreditos.CarteraEstadistica2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, "5", lccartera, lczona, "F", "N")

        lnnumana = eusuarios.ObtenerNAnalistas()
        Dim ds As New DataSet
        Dim fila As DataRow
        Dim ele As Integer
        Dim lccodana As String
        Dim lnprenue, lnprerec As Integer
        Dim lncolnue, lncolrec As Double
        ds = eusuarios.analistas()
        For Each fila In ds.Tables(0).Rows
            lccodana = ds.Tables(0).Rows(ele)("usuario")

            lnprenue = ecreditos.CarteraEstadisticaN(dfecha1, dfecha2, lcoficina, lccodana, lcestrato, lclineas, lmora, "5", lccartera, lczona, "F", "N")
            lnprerec = ecreditos.CarteraEstadisticaN(dfecha1, dfecha2, lcoficina, lccodana, lcestrato, lclineas, lmora, "5", lccartera, lczona, "F", "R")

            lncolnue = ecreditos.CarteraEstadisticaC(dfecha1, dfecha2, lcoficina, lccodana, lcestrato, lclineas, lmora, "5", lccartera, lczona, "F", "N")
            lncolrec = ecreditos.CarteraEstadisticaC(dfecha1, dfecha2, lcoficina, lccodana, lcestrato, lclineas, lmora, "5", lccartera, lczona, "F", "R")

            ds.Tables(0).Rows(ele)("nprenue") = lnprenue
            ds.Tables(0).Rows(ele)("nprerec") = lnprerec

            ds.Tables(0).Rows(ele)("ncolnue") = lncolnue
            ds.Tables(0).Rows(ele)("ncolrec") = lncolrec

            If (lnprenue + lnprerec) = 0 Then
                ds.Tables(0).Rows(ele).Delete()
                ds.Tables(0).GetChanges(DataRowState.Deleted)
            End If
            ele += 1
        Next
        ds.Tables(0).AcceptChanges()
        Return ds
    End Function
    Private Function Informe2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lctipo As String) As DataSet
        Dim ecreditos As New ccreditos
        Dim eusuarios As New cusuarios
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim fila, fila1 As DataRow
        Dim ele, ele1 As Integer
        Dim lccodana As String
        ecreditos.cartera = lccartera
        ecreditos.tipo = lctipo
        'Variable q reemplazaran
        Dim lncred As Integer
        Dim lncapdes As Double
        Dim lncappag As Double
        Dim lnsaldo, lnsaldot, lnpagteo, lnsalteo, lnsaldocon, lnsaldom, lnpar30sal As Double
        Dim lndias As Integer
        Dim lccodcta As String

        '-----------------------------
        ds = eusuarios.analistas()
        For Each fila In ds.Tables(0).Rows
            lccodana = ds.Tables(0).Rows(ele)("usuario")
            ds1 = ecreditos.CarteraCalculada2(dfecha1, dfecha2, lcoficina, lccodana, lcestrato, lclineas, lmora, cancela, lccartera, 0, 0)
            If ds1.Tables(0).Rows.Count = 0 Then
                lncred = 0
            Else
                lncred = ds1.Tables(0).Rows.Count
                ele1 = 0
                lnsaldot = 0
                lnsaldocon = 0
                lnsaldom = 0
                lnpar30sal = 0
                For Each fila1 In ds1.Tables(0).Rows
                    lncapdes = ds1.Tables(0).Rows(ele1)("nCapdes")
                    lncappag = ds1.Tables(0).Rows(ele1)("nCappag")
                    lnpagteo = ds1.Tables(0).Rows(ele1)("npagteo")
                    lccodcta = ds1.Tables(0).Rows(ele1)("ccodcta")
                    lnsaldo = lncapdes - lncappag
                    lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                    lndias = ecreditos.diasAtraso(lccodcta, lncappag, dfecha2)
                    'Sumatoria
                    If lnsaldo > lnsalteo Then 'saldo afectado y capital en mora
                        lnsaldocon = lnsaldocon + lnsaldo
                        lnsaldom = lnsaldom + (lnsaldo - lnsalteo)
                        If lndias > 30 Then
                            lnpar30sal = lnpar30sal + lnsaldo
                        End If
                    End If

                    lnsaldot = lnsaldot + lnsaldo
                    ele1 += 1
                Next
                ds.Tables(0).Rows(ele)("nsaldo") = lnsaldot
                ds.Tables(0).Rows(ele)("nsaldocon") = lnsaldocon
                ds.Tables(0).Rows(ele)("nsaldoM") = lnsaldom
                ds.Tables(0).Rows(ele)("nCred") = lncred
                ds.Tables(0).Rows(ele)("nPar30Sal") = lnpar30sal
            End If
            If lncred = 0 Then
                ds.Tables(0).Rows(ele).Delete()
                ds.Tables(0).GetChanges(DataRowState.Deleted)
            End If
            ele += 1
        Next
        ds.Tables(0).AcceptChanges()
        Return ds
    End Function

    Protected Sub btAplicar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btAplicar.Click

        'Valida Rangos
        If CheckBox1.Checked = True Then
            If Integer.Parse(txtrango1.Text) <= 1 Then
                '                Response.Write("<script language='javascript'>alert('Error en Rangos')</script>")
                codigoJs = "<script language='javascript'>alert('Error en Rangos, " & _
                                              "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            ElseIf Integer.Parse(txtrango1.Text) >= Integer.Parse(txtrango2.Text) Then
                'Response.Write("<script language='javascript'>alert('Error en Rangos')</script>")
                codigoJs = "<script language='javascript'>alert('Error en Rangos, " & _
                                              "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            ElseIf Integer.Parse(txtrango2.Text) >= Integer.Parse(txtrango3.Text) Then
                'Response.Write("<script language='javascript'>alert('Error en Rangos')</script>")
                codigoJs = "<script language='javascript'>alert('Error en Rangos, " & _
                                              "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            ElseIf Integer.Parse(txtrango3.Text) >= Integer.Parse(txtrango4.Text) Then
                'Response.Write("<script language='javascript'>alert('Error en Rangos')</script>")
                codigoJs = "<script language='javascript'>alert('Error en Rangos, " & _
                                              "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If

        End If
        Me.imagenes()
        'declara generalidades de dataset desconectados a ocupar
        Dim cls1 As New class1 'clsprincipal
        Dim clsreportes As New ClsAdRpt

        Dim gnperbas As Double
        gnperbas = Session("gnperbas")

        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lcoficina, lcanalista, lcestrato, lclineas, lccartera, lctipo, lczona, lccajeros, lcproducto As String
        Dim lcexportar As String
        Dim M1 As New ccreditos



        Dim cla As New cactualizamora
        Dim ldfecha As Date
        Dim gdfecmor As Date
        Dim gnmora As String
        Dim dsbase2 As DataSet

        Dim dsbase1 As New DataSet
        Dim lmora As Boolean
        Dim cancela As String



        ldfecha1 = Date.Parse(Me.TxtDate1.Text.Trim)
        ldfecha2 = Date.Parse(Me.TxtDate2.Text.Trim)

        Dim clspag As New clspagos
        'toma los parametros que enviara a dataset

        If Me.chqproducto.Checked = True Then
            lcproducto = "*"
        Else
            lcproducto = Me.ddlproducto.SelectedValue.Trim
        End If


        If Me.chqoficinas.Checked = True Then
            lcoficina = "*"
        Else
            lcoficina = Me.ddloficinas.SelectedValue.Trim
        End If


        If Me.chqanalistas.Checked = True Then
            'If Session("gnnivel") < 9 Then
            '    lcanalista = Me.ddlanalistas.SelectedValue.Trim
            'Else
            lcanalista = "*"
            'End If

        Else
            lcanalista = Me.ddlanalistas.SelectedValue.Trim
        End If

        If Me.chqestrato.Checked = True Then
            lcestrato = "*"
        Else
            lcestrato = Me.ddlestrato.SelectedValue.Trim
        End If

        If Me.chqlineas.Checked = True Then
            lclineas = "*"
        Else
            lclineas = Me.ddllineas.SelectedValue.Trim
        End If
        If Me.chqcartera.Checked = True Then
            lccartera = "*"
        Else
            lccartera = Me.ddlcartera.SelectedValue.Trim
        End If
        If Me.chqtipo.Checked = True Then
            lctipo = "*"
        Else
            lctipo = Me.ddltipo.SelectedValue.Trim
        End If
        If Me.chqmuni.Checked = True Then
            lczona = "*"
        Else
            lczona = Me.ddlmuni.SelectedValue.Trim
        End If
        '  If Me.chqcajeros.Checked = True Then
        lccajeros = "*"
        'Else
        'lccajeros = Me.ddlcajeros.SelectedValue.Trim
        'End If

        lcexportar = Me.ddlexportar.SelectedValue.Trim

        M1.pnporseg = Session("gnporseg")
        M1.pnpordan = Session("gnsegdan")
        M1.pnporres = Session("gnporres")
        M1.pnportal = Session("gntalona")
        M1.pncosind = Session("gncosind")
        M1.gnpergra = Session("gnpergra")
        cancela = "0"
        M1.cartera = lccartera
        M1.tipo = lctipo
        M1.pnopcion = 0
        'Dim mclass As New creditos
        M1.pncomtra = Session("gncomtra")
        M1.pnperbas = Session("gnperbas")
        M1.pnsegvm = Session("gnSegVm")
        M1.pnsegvm1 = Session("gnSegVm1")

        M1.pcproducto = lcproducto

        ' chequea los diferentes filtros
        Dim xy As Integer = 0
        Dim lccampo As String
        Dim lccampos As String = ""
        Dim lctipod As String
        Dim lctipos As String = ""

        Dim lopcion As Boolean
        Dim chkCptoAsig As CheckBox
        Dim i As Integer = 0
        For xy = 0 To Me.datagrid1.Items.Count - 1
            ' lopcion = Me.datagrid1.Items(xy).Cells(5).Text 'Me.datagrid1.Items(xy).Cells(3).Text
            chkCptoAsig = CType(Me.datagrid1.Items(xy).FindControl("CheckBox3"), CheckBox)
            lopcion = chkCptoAsig.Checked

            lccampo = Me.datagrid1.Items(xy).Cells(3).Text
            lctipod = Me.datagrid1.Items(xy).Cells(4).Text

            If lopcion = True Then
                lccampos = lccampos & lccampo.Trim & ","
                lctipos = lctipos & lctipod.Trim & ","
                i = i + 1
            End If

        Next

        If i <= 1 Then
            'Response.Write("<script language='javascript'>alert('Debe Elegir mas de un Campo')</script>")
            codigoJs = "<script language='javascript'>alert('Debe Elegir mas de un Campo, " & _
                                              "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        M1.pltoda = CheckBox1.Checked
        M1.plven = CheckBox5.Checked
        M1.pdfecha = Date.Parse(TxtDate2.Text)
        M1.pnRango1 = 1
        M1.pnRango2 = Integer.Parse(txtrango1.Text)
        M1.pnRango3 = Integer.Parse(txtrango2.Text)
        M1.pnRango4 = Integer.Parse(txtrango3.Text)
        M1.pnRango5 = Integer.Parse(txtrango4.Text)

        lmora = CheckBox4.Checked
        cancela = "0"
        dsbase1 = M1.GeneradordeReportes(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, _
                                         lcproducto, lccampos, lctipos)

        Me.ExportToExcel(dsbase1.Tables(0))
        'aExcel(dsbase1)
    End Sub

    Private Sub provisionMensual()
        Dim ldfecha2 As Date = Date.Parse(Me.TxtDate2.Text)
        Dim ds As New DataSet
        Dim ecremcre As New cCremcre
        ds = ecremcre.RecuperarProvision
        'Imprime
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crProvision.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()


        crRpt.SetParameterValue("dfecha", ldfecha2)


        Dim reportes As String
        reportes = "crProvision.pdf"

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
    Protected Sub chqproducto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chqproducto.CheckedChanged
        'If Me.chqproducto.Checked = True Then
        '    Me.ddlproducto.Enabled = False
        'Else
        '    Me.ddlproducto.Enabled = True
        'End If

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

    Private Sub GeneraArchivo(ByVal ds As DataSet)
        'Variables para abrir el archivo en modo de escritura
        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter
        Try
            Dim lcnombre As String
            Dim lcdia1 As String
            Dim lcdia As String
            Dim clsppal As New class1

            Dim lcmes1 As String
            Dim lcmes As String

            Dim lcaño As String

            lcdia1 = Date.Parse(Me.TxtDate2.Text).Day.ToString
            lcdia = IIf(lcdia1.Trim.Length = 1, ("0" & lcdia1), lcdia1)

            lcmes1 = Date.Parse(Me.TxtDate2.Text).Month.ToString
            lcmes = IIf(lcmes1.Trim.Length = 1, ("0" & lcmes1), lcmes1)

            lcaño = Date.Parse(Me.TxtDate2.Text).Year.ToString.Trim

            lcnombre = "CE_reficom_cdro_" & lcdia & lcmes & lcaño & ".txt"


            Dim FilePath As String = "c:/txt/" & lcnombre

            'Se abre el archivo y si este no existe se crea
            strStreamW = File.OpenWrite(FilePath)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.UTF8)

            'Se traen los datos que necesitamos para el archivo
            'TraerDatosArchivo retorna un dataset pero perfectamente
            'podria ser cualquier otro tipo de objeto


            Dim dr As DataRow
            Dim pccodcta As String = ""
            Dim pcnudoci As String = ""
            Dim pccuota As String = ""
            Dim pcsaldo As String = ""
            Dim pcnomcli As String = ""
            For Each dr In ds.Tables(0).Rows
                'Obtenemos los datos del dataset
                pccodcta = (dr("ccodcta"))
                pcnudoci = (dr("cnudoci"))
                pccuota = CStr(Math.Round(dr("ncuotakp") + dr("nsalint") + dr("nsalintmor"), 2))
                pcsaldo = CStr(Math.Round(dr("nsalcap") + dr("nsalint") + dr("nsalintmor"), 2))
                pcnomcli = dr("cnomcli")

                'pccodcta = clsppal.zeros(pccodcta.Trim, 25)
                'Escribimos la línea en el achivo de texto
                If pccodcta.Trim.Substring(3, 3) = "001" Then
                Else
                    strStreamWriter.WriteLine("121" & "|" & "1" & "|" & pcnudoci.Trim & "|" & pccodcta.Trim & "|" & pcsaldo.Trim & _
                        "|" & pccuota & "|" & pcnomcli.Trim)

                End If

            Next

            strStreamWriter.Close()

            'Dim FilePath As String = "c:/txt/" & lcnombre.Trim & ".txt"

            Me.DownloadFile(FilePath, lcnombre.Trim)
            'Response.Write("<script language='javascript'>alert('El archivo se generó con éxito')</script>")


        Catch ex As Exception
            strStreamWriter.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DownloadFile(ByVal filepath As String, ByVal name As String)
        Dim type As String = ""
        Response.AppendHeader("content-disposition", _
        "attachment; filename=" + name)
        
        Response.ContentType = "text/plain"
        
        Response.WriteFile(filepath)
        Response.End()

    End Sub
    Private Function ColocaNrocheque(ByVal ds As DataSet) As DataSet
        Dim fila As DataRow
        Dim ecntamov As New cCntamov
        For Each fila In ds.Tables(0).Rows
            fila("cnumrec") = ecntamov.ObtieneNroCheque(fila("ccodcta"), fila("dfecvig"))
        Next
        Return ds
    End Function
    Private Sub aExcel(ByVal datos As DataSet)
        'variable de tipo excel aplication
        Dim aplicacionExcel As Excel.Application
        Dim libroExcel As Excel.Workbook
        Dim hojaExcel As Excel.Worksheet
        Dim opc As Object

        'Dim entidadDetalle As New cliestudiosociodet
        'Dim objDetalle As New cCliestudiosociodet
        Dim ds As New DataSet
        Dim dsDetalleCorriente As New DataSet
        Dim dsDetalleNoCorriente As New DataSet
        'Dim objUtilidades As New UtilidadesFondesol
        Dim filas As Integer



        ds = datos

        filas = ds.Tables(0).Rows.Count



        Try
            aplicacionExcel = New Excel.Application
            opc = Type.Missing
            libroExcel = aplicacionExcel.Workbooks.Add(opc)
            hojaExcel = libroExcel.Worksheets(1)
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            aplicacionExcel.DisplayAlerts = False


            'SE COLOCAN LOS TITULOS

            Dim lopcion As Boolean
            Dim chkCptoAsig As CheckBox
            Dim lccampo As String
            Dim col As Integer = 1

            Dim lcfin As String = "A"
            Dim lccolstring1 As String = ""
            Dim lccolstring2 As String = ""
            Dim lccolmoneda1 As String = ""

            For xy = 0 To Me.datagrid1.Items.Count - 1
                ' lopcion = Me.datagrid1.Items(xy).Cells(5).Text 'Me.datagrid1.Items(xy).Cells(3).Text
                chkCptoAsig = CType(Me.datagrid1.Items(xy).FindControl("CheckBox3"), CheckBox)
                lopcion = chkCptoAsig.Checked
                If lopcion = True Then
                    lccampo = Me.datagrid1.Items(xy).Cells(1).Text
                    If col = 1 Then
                        hojaExcel.Range("A1").Value = lccampo
                        lcfin = "A"
                    ElseIf col = 2 Then
                        hojaExcel.Range("B1").Value = lccampo
                        lcfin = "B"
                    ElseIf col = 3 Then
                        hojaExcel.Range("C1").Value = lccampo
                        lcfin = "C"
                    ElseIf col = 4 Then
                        hojaExcel.Range("D1").Value = lccampo
                        lcfin = "D"
                    ElseIf col = 5 Then
                        hojaExcel.Range("E1").Value = lccampo
                        lcfin = "E"
                    ElseIf col = 6 Then
                        hojaExcel.Range("F1").Value = lccampo
                        lcfin = "F"
                    ElseIf col = 7 Then
                        hojaExcel.Range("G1").Value = lccampo
                        lcfin = "G"
                    ElseIf col = 8 Then
                        hojaExcel.Range("H1").Value = lccampo
                        lcfin = "H"
                    ElseIf col = 9 Then
                        hojaExcel.Range("I1").Value = lccampo
                        lcfin = "I"
                    ElseIf col = 10 Then
                        hojaExcel.Range("J1").Value = lccampo
                        lcfin = "J"
                    ElseIf col = 11 Then
                        hojaExcel.Range("K1").Value = lccampo
                        lcfin = "K"
                    ElseIf col = 12 Then
                        hojaExcel.Range("L1").Value = lccampo
                        lcfin = "L"
                    ElseIf col = 13 Then
                        hojaExcel.Range("M1").Value = lccampo
                        lcfin = "M"
                    ElseIf col = 14 Then
                        hojaExcel.Range("N1").Value = lccampo
                        lcfin = "N"
                    ElseIf col = 15 Then
                        hojaExcel.Range("O1").Value = lccampo
                        lcfin = "O"
                    ElseIf col = 16 Then
                        hojaExcel.Range("P1").Value = lccampo
                        lcfin = "P"
                    ElseIf col = 17 Then
                        hojaExcel.Range("Q1").Value = lccampo
                        lcfin = "Q"
                    ElseIf col = 18 Then
                        hojaExcel.Range("R1").Value = lccampo
                        lcfin = "R"
                    ElseIf col = 19 Then
                        hojaExcel.Range("S1").Value = lccampo
                        lcfin = "S"
                    ElseIf col = 20 Then
                        hojaExcel.Range("T1").Value = lccampo
                        lcfin = "T"
                    ElseIf col = 21 Then
                        hojaExcel.Range("U1").Value = lccampo
                        lcfin = "U"
                    ElseIf col = 22 Then
                        hojaExcel.Range("V1").Value = lccampo
                        lcfin = "V"
                    ElseIf col = 23 Then
                        hojaExcel.Range("W1").Value = lccampo
                        lcfin = "W"
                    ElseIf col = 24 Then
                        hojaExcel.Range("X1").Value = lccampo
                        lcfin = "X"
                    ElseIf col = 25 Then
                        hojaExcel.Range("Y1").Value = lccampo
                        lcfin = "Y"
                    ElseIf col = 26 Then
                        hojaExcel.Range("Z1").Value = lccampo
                        lcfin = "Z"
                    ElseIf col = 27 Then
                        hojaExcel.Range("AA1").Value = lccampo
                        lcfin = "AA"
                    ElseIf col = 28 Then
                        hojaExcel.Range("AB1").Value = lccampo
                        lcfin = "AB"
                    ElseIf col = 29 Then
                        hojaExcel.Range("AC1").Value = lccampo
                        lcfin = "AC"
                    ElseIf col = 30 Then
                        hojaExcel.Range("AD1").Value = lccampo
                        lcfin = "AD"
                    ElseIf col = 31 Then
                        hojaExcel.Range("AE1").Value = lccampo
                        lcfin = "AE"
                    ElseIf col = 32 Then
                        hojaExcel.Range("AF1").Value = lccampo
                        lcfin = "AF"
                    ElseIf col = 33 Then
                        hojaExcel.Range("AG1").Value = lccampo
                        lcfin = "AG"
                    End If
                    If Me.datagrid1.Items(xy).Cells(3).Text.Trim = "ccodcta" Then
                        lccolstring1 = lcfin
                    End If
                    If Me.datagrid1.Items(xy).Cells(3).Text.Trim = "coficina" Then
                        lccolstring2 = lcfin
                    End If


                    col += 1
                End If
            Next

            
            col = 1


            Dim columna As Integer = 2
            For i = 0 To filas - 1

                For xy = 0 To Me.datagrid1.Items.Count - 1
                    ' lopcion = Me.datagrid1.Items(xy).Cells(5).Text 'Me.datagrid1.Items(xy).Cells(3).Text
                    chkCptoAsig = CType(Me.datagrid1.Items(xy).FindControl("CheckBox3"), CheckBox)
                    lopcion = chkCptoAsig.Checked
                    lccampo = Me.datagrid1.Items(xy).Cells(3).Text.Trim
                    If lopcion = True Then
                        If col = 1 Then
                            hojaExcel.Range("A" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 2 Then
                            hojaExcel.Range("B" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 3 Then
                            hojaExcel.Range("C" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 4 Then
                            hojaExcel.Range("D" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 5 Then
                            hojaExcel.Range("E" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 6 Then
                            hojaExcel.Range("F" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 7 Then
                            hojaExcel.Range("G" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 8 Then
                            hojaExcel.Range("H" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 9 Then
                            hojaExcel.Range("I" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 10 Then
                            hojaExcel.Range("J" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 11 Then
                            hojaExcel.Range("K" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 12 Then
                            hojaExcel.Range("L" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 13 Then
                            hojaExcel.Range("M" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 14 Then
                            hojaExcel.Range("N" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 15 Then
                            hojaExcel.Range("O" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 16 Then
                            hojaExcel.Range("P" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 17 Then
                            hojaExcel.Range("Q" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 18 Then
                            hojaExcel.Range("R" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 19 Then
                            hojaExcel.Range("S" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 20 Then
                            hojaExcel.Range("T" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 21 Then
                            hojaExcel.Range("U" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 22 Then
                            hojaExcel.Range("V" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 23 Then
                            hojaExcel.Range("W" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 24 Then
                            hojaExcel.Range("X" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 25 Then
                            hojaExcel.Range("Y" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 26 Then
                            hojaExcel.Range("Z" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 27 Then
                            hojaExcel.Range("AA" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 28 Then
                            hojaExcel.Range("AB" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 29 Then
                            hojaExcel.Range("AC" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 30 Then
                            hojaExcel.Range("AD" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 31 Then
                            hojaExcel.Range("AE" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 32 Then
                            hojaExcel.Range("AF" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        ElseIf col = 33 Then
                            hojaExcel.Range("AG" + columna.ToString).Value = ds.Tables(0).Rows(i).Item(lccampo)
                        End If
                        col += 1
                    End If
                Next

                columna += 1


                col = 1

            Next

            'calcula total 
            'hojaExcel.Cells(lcfin, 4) = "=SUM(D" + inicioCorriente.ToString + ":D" + (finCorriente - 1).ToString + ")"


            
            
            ''APLICA FORMATOS


            Dim rango As Excel.Range

            rango = hojaExcel.Range("A1", lcfin + (filas + 6).ToString)


            rango.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            rango.Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            rango.Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            rango.Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            rango.Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            rango.Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous


            If lccolstring1.Trim <> "" Then
                rango = hojaExcel.Range(lccolstring1 & "1", lccolstring1 + (filas + 6).ToString)
                rango.NumberFormat = "000000000000000000"
            End If

            If lccolstring2.Trim <> "" Then
                rango = hojaExcel.Range(lccolstring2 & "1", lccolstring2 + (filas + 6).ToString)
                rango.NumberFormat = "000"
            End If

            rango = hojaExcel.Range("A1", lcfin + 1.ToString)
            rango.Interior.Color = RGB(200, 160, 35)

            col = 1
            Dim lctipod As String = ""
            For xy = 0 To Me.datagrid1.Items.Count - 1
                ' lopcion = Me.datagrid1.Items(xy).Cells(5).Text 'Me.datagrid1.Items(xy).Cells(3).Text
                chkCptoAsig = CType(Me.datagrid1.Items(xy).FindControl("CheckBox3"), CheckBox)
                lopcion = chkCptoAsig.Checked
                If lopcion = True Then
                    lctipod = Me.datagrid1.Items(xy).Cells(4).Text
                    If col = 1 Then
                        lcfin = "A"
                    ElseIf col = 2 Then
                        lcfin = "B"
                    ElseIf col = 3 Then
                        lcfin = "C"
                    ElseIf col = 4 Then
                        lcfin = "D"
                    ElseIf col = 5 Then
                        lcfin = "E"
                    ElseIf col = 6 Then
                        lcfin = "F"
                    ElseIf col = 7 Then
                        lcfin = "G"
                    ElseIf col = 8 Then
                        lcfin = "H"
                    ElseIf col = 9 Then
                        lcfin = "I"
                    ElseIf col = 10 Then
                        lcfin = "J"
                    ElseIf col = 11 Then
                        lcfin = "K"
                    ElseIf col = 12 Then
                        lcfin = "L"
                    ElseIf col = 13 Then
                        lcfin = "M"
                    ElseIf col = 14 Then
                        lcfin = "N"
                    ElseIf col = 15 Then
                        lcfin = "O"
                    ElseIf col = 16 Then
                        lcfin = "P"
                    ElseIf col = 17 Then
                        lcfin = "Q"
                    ElseIf col = 18 Then
                        lcfin = "R"
                    ElseIf col = 19 Then
                        lcfin = "S"
                    ElseIf col = 20 Then
                        lcfin = "T"
                    ElseIf col = 21 Then
                        lcfin = "U"
                    ElseIf col = 22 Then
                        lcfin = "V"
                    ElseIf col = 23 Then
                        lcfin = "W"
                    ElseIf col = 24 Then
                        lcfin = "X"
                    ElseIf col = 25 Then
                        lcfin = "Y"
                    ElseIf col = 26 Then
                        lcfin = "Z"
                    ElseIf col = 27 Then
                        lcfin = "AA"
                    ElseIf col = 28 Then
                        lcfin = "AB"
                    ElseIf col = 29 Then
                        lcfin = "AC"
                    ElseIf col = 30 Then
                        lcfin = "AD"
                    ElseIf col = 31 Then
                        lcfin = "AE"
                    ElseIf col = 32 Then
                        lcfin = "AF"
                    ElseIf col = 33 Then
                        lcfin = "AG"
                    End If

                    If lctipod.Trim = "D" Then
                        rango = hojaExcel.Range(lcfin + "2", lcfin + (filas + 6).ToString)
                        rango.NumberFormat = "#,##0.00"
                    End If
                    If lctipod.Trim = "F" Then
                        rango = hojaExcel.Range(lcfin + "2", lcfin + (filas + 6).ToString)
                        rango.NumberFormat = "dd/mm/yyyy"
                    End If
                    col += 1
                End If
            Next


            'rango = hojaExcel.Range("D9", "D" + (finNoCorriente + 6).ToString)
            'rango.NumberFormat = "#,##0.00"


            'rango = hojaExcel.Range("C9", "C" + (finNoCorriente + 6).ToString)
            'rango.ColumnWidth = 30


            hojaExcel.Range("A1").Select()

            aplicacionExcel.Sheets(1).Pictures.Insert("c:\txt\logo.jpg")
            'aplicacionExcel.ActiveSheet.Protect(password:="franeric$%", DrawingObjects:=True, _
            '                 Contents:=True, Scenarios:=True)


            Dim pathArchivo As String
            Dim nombreArchivo As String

            nombreArchivo = "Datos" + ".xlsx"

            pathArchivo = "c:\txt\" + nombreArchivo
            libroExcel.SaveAs(pathArchivo)
            hojaExcel = Nothing
            libroExcel.Close()
            libroExcel = Nothing
            aplicacionExcel.Quit()

            ObtieneArchivo(pathArchivo, nombreArchivo)

        Catch ex As Exception


        End Try

    End Sub
    Private Sub ObtieneArchivo(ByVal patharchivo As String, ByVal Nombre As String)
        Response.Clear()
        Response.Buffer = False
        Response.BufferOutput = False
        Response.ClearContent()
        Response.ClearHeaders()
        Response.ContentType = "application/ms-excel"
        Response.AddHeader("Content-Disposition", "attachment;filename=" + Nombre)
        Response.WriteFile(patharchivo)
        Response.Flush()
        Response.Close()
    End Sub

    Protected Sub CheckBox6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        ' chequea los diferentes filtros
        Dim xy As Integer = 0
        Dim lccampos As String = ""
        Dim lctipos As String = ""

        Dim chkCptoAsig As CheckBox
        For xy = 0 To Me.datagrid1.Items.Count - 1
            ' lopcion = Me.datagrid1.Items(xy).Cells(5).Text 'Me.datagrid1.Items(xy).Cells(3).Text
            chkCptoAsig = CType(Me.datagrid1.Items(xy).FindControl("CheckBox3"), CheckBox)
            chkCptoAsig.Checked = CheckBox6.Checked
        Next

    End Sub

    Protected Sub btnmine_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnmine.Click
        Me.imagenes()        'declara generalidades de dataset desconectados a ocupar
        Dim cls1 As New class1 'clsprincipal
        Dim clsreportes As New ClsAdRpt

        Dim gnperbas As Double
        gnperbas = Session("gnperbas")

        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lcoficina, lcanalista, lcestrato, lclineas, lccartera, lctipo, lczona, lccajeros, lcproducto As String
        Dim lcexportar As String
        Dim M1 As New ccreditos



        Dim cla As New cactualizamora
        Dim ldfecha As Date
        Dim gdfecmor As Date
        Dim gnmora As String
        Dim dsbase2 As DataSet

        Dim dsbase1 As New DataSet
        Dim lmora As Boolean
        Dim cancela As String



        ldfecha1 = Date.Parse(Me.TxtDate1.Text.Trim)
        ldfecha2 = Date.Parse(Me.TxtDate2.Text.Trim)

        Dim clspag As New clspagos
        'toma los parametros que enviara a dataset

        If Me.chqproducto.Checked = True Then
            lcproducto = "*"
        Else
            lcproducto = Me.ddlproducto.SelectedValue.Trim
        End If


        If Me.chqoficinas.Checked = True Then
            lcoficina = "*"
        Else
            lcoficina = Me.ddloficinas.SelectedValue.Trim
        End If


        If Me.chqanalistas.Checked = True Then
            'If Session("gnnivel") < 9 Then
            '    lcanalista = Me.ddlanalistas.SelectedValue.Trim
            'Else
            lcanalista = "*"
            'End If

        Else
            lcanalista = Me.ddlanalistas.SelectedValue.Trim
        End If

        If Me.chqestrato.Checked = True Then
            lcestrato = "*"
        Else
            lcestrato = Me.ddlestrato.SelectedValue.Trim
        End If

        If Me.chqlineas.Checked = True Then
            lclineas = "*"
        Else
            lclineas = Me.ddllineas.SelectedValue.Trim
        End If
        If Me.chqcartera.Checked = True Then
            lccartera = "*"
        Else
            lccartera = Me.ddlcartera.SelectedValue.Trim
        End If
        If Me.chqtipo.Checked = True Then
            lctipo = "*"
        Else
            lctipo = Me.ddltipo.SelectedValue.Trim
        End If
        If Me.chqmuni.Checked = True Then
            lczona = "*"
        Else
            lczona = Me.ddlmuni.SelectedValue.Trim
        End If
        lccajeros = "*"
        lcexportar = Me.ddlexportar.SelectedValue.Trim

        M1.pnporseg = Session("gnporseg")
        M1.pnpordan = Session("gnsegdan")
        M1.pnporres = Session("gnporres")
        M1.pnportal = Session("gntalona")
        M1.pncosind = Session("gncosind")
        M1.gnpergra = Session("gnpergra")
        cancela = "0"
        M1.cartera = lccartera
        M1.tipo = lctipo
        M1.pnopcion = 0
        'Dim mclass As New creditos
        M1.pncomtra = Session("gncomtra")
        M1.pnperbas = Session("gnperbas")
        M1.pnsegvm = Session("gnSegVm")
        M1.pnsegvm1 = Session("gnSegVm1")

        M1.pcproducto = lcproducto



        DevuelveMINE_Generado()


        ' chequea los diferentes filtros
        Dim xy As Integer = 0
        Dim lccampos As String = ""
        Dim lctipos As String = ""

        lmora = CheckBox4.Checked
        cancela = "0"
        dsbase1 = M1.GeneradordeReportesMINE(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)

        'Me.GeneraArchivoMINE(dsbase1)
        Me.ExportToExcel(dsbase1.Tables(0))
    End Sub
    Private Sub GeneraArchivoMINE(ByVal ds As DataSet)
        'Variables para abrir el archivo en modo de escritura

        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter
        Try
            Dim lcnombre As String
            Dim lcdia1 As String
            Dim lcdia As String
            Dim clsppal As New class1

            Dim lcmes1 As String
            Dim lcmes As String

            Dim lcaño As String

            lcdia1 = Date.Parse(Me.TxtDate2.Text).Day.ToString
            lcdia = IIf(lcdia1.Trim.Length = 1, ("0" & lcdia1), lcdia1)

            lcmes1 = Date.Parse(Me.TxtDate2.Text).Month.ToString
            lcmes = IIf(lcmes1.Trim.Length = 1, ("0" & lcmes1), lcmes1)

            lcaño = Date.Parse(Me.TxtDate2.Text).Year.ToString.Trim

            lcnombre = "MINE_" & lcdia & lcmes & lcaño & ".txt"


            Dim FilePath As String = "c:/txt/" & lcnombre

            'Se abre el archivo y si este no existe se crea
            strStreamW = File.OpenWrite(FilePath)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.UTF8)

            'Se traen los datos que necesitamos para el archivo
            'TraerDatosArchivo retorna un dataset pero perfectamente
            'podria ser cualquier otro tipo de objeto


            Dim dr As DataRow
           
            Dim pccadena As String
            Dim pNo, pRegion, pAgencia, pCredito, pCliente, pNombre, pCedula, Pdireccion As String
            Dim pActividad, pMonto, pSaldo, pCuota, pCapital_Mora, pIntereses_Corrientes, pIntereses_Moratorios As String
            Dim pCuotas_Mora, pGarantia, pTasa_Interes, pFecha_Otorgado, pFecha_Vence, pCiclo, pDias_Atraso, pMenosde1 As String
            Dim pMenosde2, pMenosde3, pMenosde4, pMenosde6, pMayor180 As String
            Dim pSexo, pMetodologia, pPrograma, pProducto, pSector, pEstado, pTipo_Cartera As String
            Dim pDestino, pMunicipio, pFecha_Nac, pDepartamento, pFondos, pAsesor_Otorgo, pAsesor_Administra As String
            Dim pPago_Capital, pPago_Interes, pPago_Mora, pTipoInteres As String
            For Each dr In ds.Tables(0).Rows
                'Obtenemos los datos del dataset
                pNo = dr("No")
                pRegion = dr("region")
                pAgencia = dr("agencia")
                pCredito = dr("credito")
                pCredito = pCredito.Replace("'", "")
                pCliente = dr("cliente")
                pCliente = pCliente.Replace("'", "")
                pNombre = dr("Nombre")
                pCedula = dr("Cedula")
                Pdireccion = dr("Direccion")
                pActividad = dr("actividad")
                pMonto = CStr(Math.Round(dr("monto"), 2))
                pSaldo = CStr(Math.Round(dr("Saldo"), 2))
                pCuota = CStr(Math.Round(dr("cuota"), 2))
                pCapital_Mora = CStr(Math.Round(dr("capital_mora"), 2))
                pIntereses_Corrientes = CStr(Math.Round(dr("Intereses_Corrientes"), 2))
                pIntereses_Moratorios = CStr(Math.Round(dr("Intereses_Moratorios"), 2))
                pCuotas_Mora = CStr(Math.Round(dr("cuotas_mora"), 2))
                pgarantia = dr("garantia")
                pTasa_Interes = CStr(Math.Round(dr("tasa_interes"), 2))
                pFecha_Otorgado = Left(dr("fecha_otorgado").ToString, 10)
                pFecha_Vence = Left(dr("fecha_vence").ToString, 10)
                pCiclo = CStr(dr("ciclo"))
                pDias_Atraso = CStr(dr("dias_atraso"))
                pMenosde1 = CStr(Math.Round(dr("menosde1"), 2))
                pMenosde2 = CStr(Math.Round(dr("menosde2"), 2))
                pMenosde3 = CStr(Math.Round(dr("menosde3"), 2))
                pMenosde4 = CStr(Math.Round(dr("menosde4"), 2))
                pMenosde6 = CStr(Math.Round(dr("menosde6"), 2))
                pMayor180 = CStr(Math.Round(dr("mayor180"), 2))
                pSexo = dr("sexo")
                pMetodologia = dr("metodologia")
                pPrograma = dr("programa")
                pProducto = dr("producto")
                pSector = dr("sector")
                pEstado = dr("estado")
                pTipo_Cartera = dr("tipo_cartera")
                pDestino = dr("destino")
                pMunicipio = dr("municipio")
                pFecha_Nac = Left(dr("fecha_nac").ToString, 10)
                pDepartamento = dr("departamento")
                pFondos = dr("fondos")
                pAsesor_Otorgo = dr("asesor_otorgo")
                pAsesor_Administra = dr("asesor_administra")

                pPago_Capital = CStr(Math.Round(dr("pago_capital"), 2))
                pPago_Interes = CStr(Math.Round(dr("pago_interes"), 2))
                pPago_Mora = CStr(Math.Round(dr("pago_mora"), 2))
                pTipoInteres = dr("TipoInteres")

                pccadena = pNo.Trim & "|" & pRegion.Trim & "|" & pAgencia & "|" & pCredito.Trim & "|" & pCliente.Trim & "|" & pNombre & "|" & pCedula & "|" & Pdireccion & "|" & _
                pActividad & "|" & pMonto & "|" & pSaldo & "|" & pCuota & "|" & pCapital_Mora & "|" & pIntereses_Corrientes & "|" & pIntereses_Moratorios & "|" & _
                pCuotas_Mora & "|" & pGarantia & "|" & pTasa_Interes & "|" & pFecha_Otorgado & "|" & pFecha_Vence & "|" & pCiclo & "|" & pDias_Atraso & "|" & pMenosde1 & "|" & _
                pMenosde2 & "|" & pMenosde3 & "|" & pMenosde4 & "|" & pMenosde6 & "|" & pMayor180 & "|" & pSexo & "|" & pMetodologia & "|" & pPrograma & "|" & _
                pProducto & "|" & pSector & "|" & pEstado & "|" & pTipo_Cartera & "|" & pDestino & "|" & pMunicipio & "|" & pFecha_Nac & "|" & _
                pDepartamento & "|" & pFondos & "|" & pAsesor_Otorgo & "|" & pAsesor_Administra & "|" & pPago_Capital & "|" & pPago_Interes & "|" & _
                pPago_Mora & "|" & pTipoInteres



                strStreamWriter.WriteLine(pccadena)



            Next

            strStreamWriter.Close()

            'Dim FilePath As String = "c:/txt/" & lcnombre.Trim & ".txt"

            Me.DownloadFile(FilePath, lcnombre.Trim)
            'Response.Write("<script language='javascript'>alert('El archivo se generó con éxito')</script>")


        Catch ex As Exception
            strStreamWriter.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DevuelveMINE_Generado()
        Dim lcnombre As String
        Dim lcdia1 As String
        Dim lcdia As String
        Dim clsppal As New class1

        Dim lcmes1 As String
        Dim lcmes As String

        Dim lcaño As String

        lcdia1 = Date.Parse(Me.TxtDate2.Text).Day.ToString
        lcdia = IIf(lcdia1.Trim.Length = 1, ("0" & lcdia1), lcdia1)

        lcmes1 = Date.Parse(Me.TxtDate2.Text).Month.ToString
        lcmes = IIf(lcmes1.Trim.Length = 1, ("0" & lcmes1), lcmes1)

        lcaño = Date.Parse(Me.TxtDate2.Text).Year.ToString.Trim

        lcnombre = "MINE_" & lcdia & lcmes & lcaño & ".txt"


        Dim FilePath As String = "c:/txt/" & lcnombre

        If Not File.Exists(FilePath) Then

        Else
            Me.DownloadFile(FilePath, lcnombre.Trim)
        End If



    End Sub
End Class
