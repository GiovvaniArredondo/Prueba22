Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO
'Imports CreateExcelFile

'Imports Sql.Data
'Imports Sql.Data.MySqlClient


Public Class usmodrep
    Inherits System.Web.UI.UserControl
#Region "Variables"
    Private codigoJs As String
    Dim lnsolant As Integer = 0
    Dim lnsolper As Integer = 0
    Dim lnsolapr As Integer = 0
    Dim lnsolden As Integer = 0
    Dim lncrecol As Integer = 0
    Dim lnmoncol As Double = 0

    Dim lnnumana As Integer = 0
    Dim lntiepro As Integer = 3
    Dim TotalCreditosOtorgados As Decimal = 0
    Dim MontoOtorgado As Decimal = 0
    Dim Promedio As Decimal = 0
#End Region


#Region "Metodos"
    Private Sub Exportar_Txt(ByVal ds As DataSet)
        Dim lcnombre As String = "Cartera.txt"
        'Dim rowString(0 To ds.Tables(0).Rows.Count - 1) As String
        'Se comentario para incluir el encabezado
        Dim rowString(0 To ds.Tables(0).Rows.Count) As String

        Dim i As Integer = 0
        Dim colum As Integer
        Dim no_column As Integer = ds.Tables(0).Columns.Count



        For Each dr As DataRow In ds.Tables(0).Rows

            'Primero Coloca el encabezado de los campos
            If i = 0 Then
                For colum = 0 To no_column - 1
                    If colum = 0 Then
                        'rowString(i) = ds.Tables(0).Columns(colum).ColumnName()
                    ElseIf colum = no_column - 1 Then
                        rowString(i) += ds.Tables(0).Columns(colum).ColumnName()
                    Else
                        rowString(i) += ds.Tables(0).Columns(colum).ColumnName + "|"
                    End If
                    colum += 1
                Next
                i += 1
            End If

            'Recorriendo el Detalle
            For colum = 0 To no_column - 1
                If colum = 0 Then
                    'rowString(i) = dr.ItemArray.GetValue(colum).ToString()
                ElseIf colum = no_column - 1 Then
                    rowString(i) += dr.ItemArray.GetValue(colum).ToString()
                Else
                    rowString(i) += dr.ItemArray.GetValue(colum).ToString() + "|"
                End If
                colum += 1
            Next

            i += 1

        Next

        Dim FilePath As String = "c:\txt\" & lcnombre.Trim

        File.WriteAllLines(FilePath, rowString)

        Me.DownloadFile(FilePath, lcnombre.Trim)

    End Sub
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

    Dim Fecha_reporte As DateTime
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
        Dim eusuariogrupo As New cUsuarioGrupo
        Dim lngrupo As Integer
        Dim ds As New DataSet
        lngrupo = eusuariogrupo.RetornaGrupo(Session("gccodusu"))
        ds = eusuariogrupo.DataSetReportes(lngrupo)

        Dim fila As DataRow
        Dim i As Integer
        Dim lcopcion As String
        For Each fila In ds.Tables(0).Rows
            lcopcion = ds.Tables(0).Rows(i)("idopcion")

            Select Case lcopcion
                Case "001"
                    Me.rbtIngresos.Enabled = True
                Case "002"
                    Me.rbtDesem.Enabled = True
                Case "003"
                    Me.rbtCarteraVIg.Enabled = True
                Case "004"
                    'Me.rbtmora.Enabled = True
                    Me.rbtCart_mora.Enabled = True
                    RbtCart_moraGpo.Enabled = True
                Case "005"
                    rbtproyeccion.Enabled = True
                Case "006"
                    rbdvenci.Enabled = True
                Case "007"
                    rbtIngresos2.Enabled = True
                Case "008"
                    rbtnmora2.Enabled = True
                Case "009"
                    rbdingfon.Enabled = True
                Case "010"
                    rbtninforme1.Enabled = True
                Case "011"
                    rbtn50.Enabled = True
                Case "012"
                    rbtCartera1.Enabled = True
                Case "013"
                    rbtninfored.Enabled = True
                Case "014"
                    rbtIngresos1.Enabled = True
                Case "015"
                    rbcondesem.Enabled = True
                Case "016"
                    rbdreserva.Enabled = True
                Case "017"
                    rbdestrato.Enabled = True
                Case "018"
                    rbdgenero.Enabled = True
                Case "019"
                    rbdnopagos.Enabled = True
                Case "020"
                    rbdsaldosfue.Enabled = True
                Case "021"
                    rbtnrecumen.Enabled = True
                Case "022"
                    rbtncolomen.Enabled = True
                Case "023"
                    rbtnafecta.Enabled = True
                Case "024"
                    rbtntipo.Enabled = True
                Case "025"
                    rbtCartera2.Enabled = True
                Case "026"
                    rbtnmora3.Enabled = True
                Case "027"
                    rbtIngresos3.Enabled = True
                Case "028"
                    rbtnsector.Enabled = True
                Case "029"
                    rbtndestino.Enabled = True
                Case "030"
                    rbtnactivi.Enabled = True
                Case "031"
                    rbtntasa.Enabled = True
                Case "031"
                    rbtnparalelo.Enabled = True
                Case "032"
                    rbtnparalelo.Enabled = True
                Case "033"
                    rbdcancelados.Enabled = True
                Case "034"
                    rbtnrecuanu.Enabled = True
                Case "035"
                    rbtncoloanu.Enabled = True
                Case "036"
                    rbtnagenda.Enabled = True
                Case "037"
                    rbtnagenda2.Enabled = True
                Case "038"
                    rbtproyeccion1.Enabled = True
                Case "039"
                    rbtCartera3.Enabled = True
                Case "040"
                    rbtngarantia.Enabled = True
                Case "041"
                    rbtIngresos4.Enabled = True
                Case "042"
                    rbtnextorno.Enabled = True
                Case "043"
                    rbtnmuni.Enabled = True
                Case "044"
                    rbtnplazos.Enabled = True
                Case "045"
                    rbtncali.Enabled = True
                Case "048"
                    rbtnplazos.Enabled = True
                Case "049"
                    rbtncali.Enabled = True
                Case "050"
                    rbtestadistico.Enabled = True
                Case "051"
                    rbtnprorec.Enabled = True
                Case "052"
                    rbtndesercion.Enabled = True
                Case "053"
                    rbtnedad.Enabled = True
                Case "054"
                    rbtnsecuencia.Enabled = True
                Case "055"
                    rbtnprorec1.Enabled = True
                Case "056"
                    rbtCartera4.Enabled = True
                Case "057"
                    rbtnmonto.Enabled = True
                Case "058"
                    rbtnEjecutivo.Enabled = True
                Case "059"
                    rbtAjuste.Enabled = True
                Case "060"
                    rbttransunion.Enabled = True
                Case "061"
                    rbtAjuplan.Enabled = True
                Case "062"
                    rbtnIntereses.Enabled = True
                Case "063"
                    rbtncuoven.Enabled = True
                Case "064"
                    rdbcarana.Enabled = True
                Case "065"
                    rbtnfdlg.Enabled = True
                Case "066"
                    rbtcreditosplazo.Enabled = True
                Case "067"
                    rbtResumenxProducto.Enabled = True
                Case "068"
                    rbtPeriodicidad.Enabled = True
                Case "069"
                    rbtResumenDesembolso.Enabled = True
                Case "070"
                    rbtClasificacionCarteraXAgencia.Enabled = True
                Case "071"
                    rbtResumenDeIngresos.Enabled = True
                Case "072"
                    rbtCarteraSuspendida.Enabled = True
                Case "073"
                    rbtIngresosCondonados.Enabled = True
                Case "074"
                    rbtResumenCartera3.Enabled = True
                Case "075"
                    rbtOtrosIngresos.Enabled = True
                Case "076"
                    rbtnextorno0.Enabled = True
                Case "077"
                    rbtnagenda3.Enabled = True
                   
                Case "078"
                    rbtnsolicitud.Enabled = True
                Case "079"
                    rbtnaldea.Enabled = True
                Case "080"
                    rbtnInter.Enabled = True
                Case "081"
                    rbtIngresos5.Enabled = True
                Case "082"
                    rbtIngresos6.Enabled = True
                Case "083"
                    RdbDetalleGarantias.Enabled = True

            End Select

            i += 1
        Next

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

        Me.chqcajeros.Checked = True
        'Me.ddlcajeros.Enabled = True
        Me.ddlcajeros.Items(0).Selected = True
        Me.ddlexportar.SelectedValue = "PDF"

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
        Dim clsusuarios As New SIM.BL.cusuarios
        Dim mListausuarios As New listausuarios

        mListausuarios = clsusuarios.ObtenerListaporID2("CAJ")

        Me.ddlcajeros.DataTextField = "nombre"
        Me.ddlcajeros.DataValueField = "usuario"
        Me.ddlcajeros.DataSource = mListausuarios
        Me.ddlcajeros.DataBind()


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

        If Me.chqcajeros.Checked = True Then
            lccajeros = "Todos los cajeros"
        Else
            i = Me.ddlcajeros.SelectedIndex
            lccajeros = Me.ddlcajeros.Items(i).Text
            lccajeros = "Todos los cajeros"
        End If
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
        Dim lcNomofi As String = Session("GCNOMINS")

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
        'condicionar -----------------------------
        If Me.rbcondesem.Checked = True Then
            crRpt.SetParameterValue("CreditosOtorgados", TotalCreditosOtorgados)
            crRpt.SetParameterValue("TotalOtorgado", MontoOtorgado)
            crRpt.SetParameterValue("Promedio", Promedio)
        End If

        Dim lctitulo As String = ""
        If rbtnagenda.Checked = True Then
            lctitulo = "Nivel 1, Hasta " & Session("gnNivel1").ToString
        ElseIf rbtnagenda2.Checked = True Then
            lctitulo = "Nivel 2, Hasta " & Session("gnNivel2").ToString
        ElseIf rbtnagenda3.Checked = True Then
            lctitulo = "Nivel 3, Hasta " & Session("gnNivel3").ToString
        ElseIf rbtnsolicitud.Checked = True Then
            lctitulo = ""
        End If
        If rbtnagenda.Checked = True Or rbtnagenda2.Checked = True Or rbtnagenda3.Checked = True Or rbtnsolicitud.Checked = True Then
            crRpt.SetParameterValue("ctitulo", lctitulo)
        End If


        If Me.rbtninforme1.Checked = True Then
            crRpt.SetParameterValue("nsolant", lnsolant)
            crRpt.SetParameterValue("nsolper", lnsolper)
            crRpt.SetParameterValue("nsolapr", lnsolapr)
            crRpt.SetParameterValue("nsolden", lnsolden)
            crRpt.SetParameterValue("nnumana", lnnumana)
            crRpt.SetParameterValue("ncrecol", lncrecol)
            crRpt.SetParameterValue("nmoncol", lnmoncol)
        End If
        If Me.rbtCartera5.Checked = True Or Me.rbtAjuplan.Checked = True Or Me.rbtnIntereses.Checked = True Or rbtnaldea.Checked = True Or _
            Me.rbtmora.Checked = True Or Me.rbtproyeccion.Checked = True Or rbtnInter.Checked = True Or rbtncuoven.Checked = True Or _
            Me.rbdvenci.Checked = True Or Me.rbtDesem.Checked = True Or rbdreserva.Checked = True Or _
            Me.rbtIngresos.Checked = True Or Me.rbtIngresos5.Checked = True Or rbtIngresos6.Checked = True Or Me.rbtAjuste.Checked = True Or Me.rbtIngresos2.Checked = True Or Me.rbtnmora2.Checked = True Or _
            Me.rbtninforme1.Checked = True Or Me.rbtnafecta.Checked = True Or Me.rbtnactivi.Checked = True Or _
            Me.rbtndestino.Checked = True Or Me.rdbcarana.Checked = True Or Me.rbdestrato.Checked = True Or _
            Me.rbdgenero.Checked = True Or Me.rbtestadistico.Checked = True Or _
            Me.rbtntasa.Checked = True Or Me.rbtnparalelo.Checked = True Or Me.rbtn50.Checked = True Or _
            Me.rbtnsector.Checked = True Or Me.rbtnfdlg.Checked = True Or Me.rbtngarantia.Checked = True Or Me.rbtnedad.Checked = True Or _
            Me.rbtnsecuencia.Checked = True Or Me.rbtntipo.Checked = True Or Me.rbtnprorec.Checked = True Or _
            Me.rbtnextorno.Checked = True Or Me.rbtnrecumen.Checked = True Or Me.rbtnrecuanu.Checked = True Or _
            Me.rbtncolomen.Checked = True Or Me.rbtncoloanu.Checked = True Or Me.rbtIngresos1.Checked = True Or _
            Me.rbtproyeccion1.Checked = True Or Me.rbtnprorec1.Checked = True Or Me.rbtCartera1.Checked = True Or _
            Me.rbtCartera2.Checked = True Or Me.rbtCartera3.Checked = True Or _
            Me.rbtCartera4.Checked = True Or Me.rbtnmora3.Checked = True Or Me.rbtIngresos3.Checked = True Or Me.rbtIngresos4.Checked = True Or _
            Me.rbtnEjecutivo.Checked = True Or Me.rbtResumenCartera3.Checked = True Or Me.rbtnextorno0.Checked = True Or _
            rbtCarteraVIg.Checked = True Or rbtCart_mora.Checked = True Then

            crRpt.SetParameterValue("czona", lczona)
        End If

        If rbdestrato.Checked = True Or Me.rbtnEjecutivo.Checked = True Or rbdreserva.Checked = True _
            Or Me.rbtAjuplan.Checked = True Or Me.rbtnIntereses.Checked = True Or rbtn50.Checked = True Or Me.rbtCartera5.Checked = True Or _
            rbtCarteraVIg.Checked = True Then
            crRpt.SetParameterValue("cproductos", lcproductos)
        End If


        '-----------------------------------------
        If Me.rbtIngresos.Checked = True Or Me.rbtAjuste.Checked = True Or rbtIngresos5.Checked = True Or rbtIngresos6.Checked = True Or _
        Me.rbtIngresos2.Checked = True Or Me.rbtnextorno.Checked = True Or Me.rbtnextorno0.Checked = True Or Me.rbtnrecumen.Checked = True _
        Or Me.rbtnrecuanu.Checked = True Or Me.rbtncolomen.Checked = True Or Me.rbtncoloanu.Checked = True Or _
        Me.rbtIngresos1.Checked = True Or Me.rbtIngresos3.Checked = True Or Me.rbtIngresos4.Checked = True Or rbdingfon.Checked = True Then
            crRpt.SetParameterValue("ccajeros", lccajeros)
        End If

        If lcexportar = "XLS2" Then
            Me.ExportToExcel(dsbase.Tables(0))
        ElseIf lcexportar = "TXT" Then
            Exportar_Txt(dsbase)
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

        If Me.chqoficinas.Checked = True Then
            Me.ddloficinas.Enabled = False
        Else
            Me.ddloficinas.Enabled = True
        End If

    End Sub

    Private Sub chqanalistas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqanalistas.CheckedChanged

        If Me.chqanalistas.Checked = True Then
            Me.ddlanalistas.Enabled = False
        Else
            Me.ddlanalistas.Enabled = True
        End If

    End Sub

    Private Sub chqestrato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqestrato.CheckedChanged
        If Me.chqestrato.Checked = True Then
            Me.ddlestrato.Enabled = False
        Else
            Me.ddlestrato.Enabled = True
        End If

    End Sub

    Private Sub chqlineas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqlineas.CheckedChanged
        If Me.chqlineas.Checked = True Then
            Me.ddllineas.Enabled = False
        Else
            Me.ddllineas.Enabled = True
        End If
    End Sub

    'calculo de la reserva
    Private Sub rdbcarana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbtDesem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub imagenes()

    End Sub

    Private Sub chqcartera_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqcartera.CheckedChanged
        If Me.chqcartera.Checked = True Then
            Me.ddlcartera.Enabled = False
        Else
            Me.ddlcartera.Enabled = True
        End If
    End Sub

    Private Sub chqtipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqtipo.CheckedChanged
        If Me.chqtipo.Checked = True Then
            Me.ddltipo.Enabled = False
        Else
            Me.ddltipo.Enabled = True
        End If
    End Sub

    Private Sub ddltipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chqmuni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqmuni.CheckedChanged
        If Me.chqmuni.Checked = True Then
            Me.ddlmuni.Enabled = False
        Else
            Me.ddlmuni.Enabled = True
        End If
    End Sub

    Private Sub chqcajeros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqcajeros.CheckedChanged
        If Me.chqcajeros.Checked = True Then
            Me.ddlcajeros.Enabled = False
        Else
            Me.ddlcajeros.Enabled = True
        End If
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
        'Dim ldfecha As Date
        'Dim gdfecmor As Date
        'Dim gnmora As String
        'Dim dsbase2 As DataSet

        Dim dsbase1 As New DataSet
        Dim lmora As Boolean
        Dim cancela As String
        Dim lnmora As Integer = 0


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
        If Me.chqcajeros.Checked = True Then
            lccajeros = "*"
        Else
            lccajeros = Me.ddlcajeros.SelectedValue.Trim
        End If

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
        If Me.rbtIngresos.Checked = True Then      'Pagos 
            Dim dsbase As New DataSet
            dsbase = M1.DETALLE_CARTERA_Y_PAGOS(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona, "*")
            Me.Imprime("cringresoscre2.rpt", dsbase, lcexportar)
        ElseIf rbtIngresos5.Checked = True Then
            Dim dsbase As New DataSet
            dsbase = M1.DETALLE_CARTERA_Y_PAGOS_en_BANCOS(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona)
            Me.Imprime("cringresoscrebancos.rpt", dsbase, lcexportar)
        ElseIf rbtIngresos6.Checked = True Then
            Dim dsbase As New DataSet
            dsbase = M1.DETALLE_CARTERA_Y_PAGOS_AGENCIA(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona, "*")
            Me.Imprime("cringresoscre2.rpt", dsbase, lcexportar)
        ElseIf Me.rbtIngresos2.Checked = True Then 'Cancelaciones Automaticas
            dsbase1 = M1.DETALLE_CARTERA_Y_PAGOS(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, "*", lccajeros, lczona, "*")
            Me.Imprime("cringresoscre2.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtIngresos3.Checked = True Then 'Cancelaciones Automaticas
            dsbase1 = M1.CAJA(ldfecha1, ldfecha2, lcanalista, lcoficina, lclineas, lccajeros, lczona)
            Me.Imprime("cringresoscre4.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtIngresos4.Checked = True Then
            Dim dsbase As New DataSet
            dsbase = M1.DETALLE_CARTERA_Y_PAGOS_OTROS(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona)
            Me.Imprime("cringresoscre5.rpt", dsbase, lcexportar)

        ElseIf Me.rbtDesem.Checked = True Then     'Desembolsos
            Dim dsbase As New DataSet
            dsbase1 = M1.DETALLE_CARTERA_Y_PAGOS(ldfecha1, ldfecha2, "D", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona, "*")
            dsbase = ColocaNrocheque(dsbase1)
            Me.Imprime("crdesembolsos2.rpt", dsbase, lcexportar)

            'ElseIf Me.rbtCarteraGlobal.Checked = True Then 'detalle de cartera con ingresos
            '    lmora = False
            '    cancela = "0"
            '    dsbase1 = M1.CarteraCalculada(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)

            '    If ddlexportar.SelectedValue.Trim = "XLS" Then
            '        Me.Imprime("crcarteraXLS.rpt", dsbase1, lcexportar)
            '    Else
            '        Me.Imprime("crcartera.rpt", dsbase1, lcexportar)
            '    End If


        ElseIf Me.rbtCarteraVIg.Checked = True Then


            lnmora = 0

            dsbase1 = M1.Extraer_Cartera_SP(ldfecha2, 0, lcanalista, lcoficina, lclineas, lczona, lcproducto, lccartera, lctipo, lnmora)
            ''CESAR TORRES 02/04/2016


            'DsR.Columns.Remove("ccodcta")
            Dim dt As DataTable
            dt = dsbase1.Tables(0)
            ExportToExcel(dt)
            'ExportarDataTableAExcel(dt)
            
            'CreateExcelFile.CreateExcelDocument(DsR, "ReporteCartera.xlsx", Response)

            

        ElseIf Me.rbtmora.Checked = True Then    'cartera en mora
            lmora = True
            cancela = "0"
            M1.pltoda = CheckBox1.Checked
            M1.pnRango1 = Integer.Parse(txtrango1.Text)
            M1.pnRango2 = Integer.Parse(txtrango2.Text)

            dsbase1 = M1.CarteraCalculadaMora(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto)
            Me.Imprime("crcarmor2.rpt", dsbase1, lcexportar)


        ElseIf Me.rbtCart_mora.Checked = True Then

            lnmora = 1

            dsbase1 = M1.Extraer_Cartera_SP(ldfecha2, 0, lcanalista, lcoficina, lclineas, lczona, lcproducto, lccartera, lctipo, lnmora)

            Me.Imprime("crcarmor2.rpt", dsbase1, lcexportar)
            'Cartera mora grupal
        ElseIf Me.RbtCart_moraGpo.Checked = True Then

            lnmora = 1

            dsbase1 = M1.Extraer_Cartera_SP_MoraGpo(ldfecha2, 0, lcanalista, lcoficina, lclineas, lczona, lcproducto, lccartera, lctipo, lnmora)

            Dim rptcarteraMoraGpo As DataTable = dsbase1.Tables(0).Copy

            'variable de totales
            Dim toTMontoOtorgado As Object = rptcarteraMoraGpo.Compute("Sum(MontoOtorgado)", "")
            Dim totsaldoCapital As Object = rptcarteraMoraGpo.Compute("Sum(SaldoCapital)", "")
            Dim totsaldoInteres As Object = rptcarteraMoraGpo.Compute("Sum(SaldoInteres)", "")
            Dim totinteMorato As Object = rptcarteraMoraGpo.Compute("Sum(InteresMoratorio)", "")
            Dim totComision As Object = rptcarteraMoraGpo.Compute("Sum(Comision)", "")
            Dim totSeguros As Object = rptcarteraMoraGpo.Compute("Sum(Seguro)", "")
            Dim totCapitalVencidos As Object = rptcarteraMoraGpo.Compute("Sum(CapitalVencido)", "")

            Dim totpagar As Object = rptcarteraMoraGpo.Compute("Sum(APagar)", "")
            Dim totatraso As Object = rptcarteraMoraGpo.Compute("Sum(DiaAtraso)", "")
            Dim totCuota As Object = rptcarteraMoraGpo.Compute("Sum(TotalCuota)", "")
            Dim totnCicloas As Object = rptcarteraMoraGpo.Compute("sum(Ciclo)", "")
            Dim totgarantuias As Object = rptcarteraMoraGpo.Compute("sum(GarantiaLiquida)", "")

            Dim totales As Object = "Totales : "
            'Asigancion de fila al final de cada columna, con calculo
            Dim newCustomersRow As DataRow = rptcarteraMoraGpo.NewRow()
            'Agregados
            newCustomersRow("MontoOtorgado") = toTMontoOtorgado
            newCustomersRow("SaldoCapital") = totsaldoCapital
            newCustomersRow("SaldoInteres") = totsaldoInteres
            newCustomersRow("InteresMoratorio") = totinteMorato
            newCustomersRow("Comision") = totComision
            newCustomersRow("Seguro") = totSeguros
            newCustomersRow("CapitalVencido") = totCapitalVencidos
            newCustomersRow("APagar") = totpagar
            newCustomersRow("DiaAtraso") = totatraso
            newCustomersRow("TotalCuota") = totCuota
            newCustomersRow("Ciclo") = totnCicloas
            newCustomersRow("GarantiaLiquida") = totgarantuias

            newCustomersRow("Codigo Grupal") = totales
            rptcarteraMoraGpo.Rows.Add(newCustomersRow)

            ExportToExcel(rptcarteraMoraGpo)

        ElseIf Me.rbtnmora2.Checked = True Then 'mora estratificada
            lmora = True
            cancela = "0"
            M1.pltoda = CheckBox1.Checked
            M1.pnRango1 = Integer.Parse(txtrango1.Text)
            M1.pnRango2 = Integer.Parse(txtrango2.Text)

            dsbase1 = M1.CarteraCalculadaMora(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto)
            Me.Imprime("crcarmor3.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnmora3.Checked = True Then 'mora estratificada
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculada(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            Me.Imprime("crcartera3a.rpt", dsbase1, lcexportar)

        ElseIf Me.rbtproyeccion.Checked = True Then    'Proyeccion de Mora
            lmora = True
            cancela = "0"
            M1.pnopcion = 1
            M1.pncomtra = Session("gncomtra")
            M1.pnperbas = Session("gnperbas")
            M1.pnsegvm = Session("gnSegVm")
            M1.pnsegvm1 = Session("gnSegVm1")

            M1.pltoda = CheckBox1.Checked
            M1.pnRango1 = Integer.Parse(txtrango1.Text)
            M1.pnRango2 = Integer.Parse(txtrango2.Text)

            dsbase1 = M1.CarteraCalculadaMora(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto)
            Me.Imprime("crproyeccion.rpt", dsbase1, lcexportar)

        ElseIf Me.rbtestadistico.Checked = True Then    'sumarios
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenOficina(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crcarana.rpt", dsbase1, lcexportar)


        ElseIf Me.rdbcarana.Checked = True Then    'sumarios
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenAnalistas(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crcarusu.rpt", dsbase1, lcexportar)
        ElseIf Me.rbdreserva.Checked = True Then    'reserva

            'cancela = "0"
            'lmora = False
            'dsbase1 = M1.ResumenReserva(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            'Me.Imprime("crreserva.rpt", dsbase1, lcexportar)
            lmora = True
            cancela = "0"
            dsbase1 = M1.ReservaCartera(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto)
            If CheckBox4.Checked = True Then
                Me.Imprime("crReservaOfi.rpt", dsbase1, lcexportar)
            Else
                Me.Imprime("crReservaCar.rpt", dsbase1, lcexportar)
            End If


        ElseIf Me.rbdestrato.Checked = True Then
            lmora = True
            cancela = "0"
            dsbase1 = M1.EstratificacionCartera(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto)
            If CheckBox2.Checked = True Then
                Me.Imprime("crestratoAna.rpt", dsbase1, lcexportar)
            ElseIf CheckBox3.Checked = True Then
                Me.Imprime("crestratoOfi.rpt", dsbase1, lcexportar)
            Else
                Me.Imprime("crestrato.rpt", dsbase1, lcexportar)
            End If


            'nopagos
        ElseIf Me.rbdnopagos.Checked = True Then
            lmora = False
            cancela = "0"
            Dim mnopagos As New cAutopag
            dsbase1 = mnopagos.obtenerpagosfecha(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas)

            Me.Imprime("crnopagos.rpt", dsbase1, lcexportar)


            'reporte de creditos cancelados
        ElseIf Me.rbdcancelados.Checked = True Then
            lmora = False
            cancela = "1"
            dsbase1 = M1.CarteraCancelada(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crcancelados.rpt", dsbase1, lcexportar)

            'vencimiento entre dos fechas
        ElseIf Me.rbdvenci.Checked = True Then
            lmora = False
            cancela = "2"
            'dsbase1 = M1.CARTERA_ACTUALIZADA(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lczona)
            dsbase1 = M1.CarteraCalculada(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            Me.Imprime("crvencen.rpt", dsbase1, lcexportar)

            'saldos por fuente de fondos
        ElseIf Me.rbdsaldosfue.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenCarteraFondo(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crcarfon.rpt", dsbase1, lcexportar)

            'saldos por genero
        ElseIf Me.rbdgenero.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenGenero(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crcargen.rpt", dsbase1, lcexportar)

            'ingresos por fondo
        ElseIf Me.rbdingfon.Checked = True Then
            lmora = False
            cancela = "0"
            'dsbase1 = cls1.CARTERA_ACTUALIZADA_GENERO(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora)
            dsbase1 = M1.DETALLE_CARTERA_Y_PAGOS_FONDO(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros)

            Me.Imprime("cringfom.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnagenda.Checked = True Then
            cancela = "0"
            lmora = False
            Dim lnnivel As Integer
            lnnivel = 1
            dsbase1 = M1.Agenda(Session("gdfecsis"), ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lnnivel, 0, Session("gnnivel1"))
            Me.Imprime("cragenda.rpt", dsbase1, lcexportar)

        ElseIf Me.rbtnagenda2.Checked = True Then
            cancela = "0"
            lmora = False
            Dim lnnivel As Integer
            lnnivel = 2
            dsbase1 = M1.Agenda(Session("gdfecsis"), ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lnnivel, Session("gnnivel1"), Session("gnnivel2"))
            Me.Imprime("cragenda.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnagenda3.Checked = True Then
            cancela = "0"
            lmora = False
            Dim lnnivel As Integer
            lnnivel = 3
            dsbase1 = M1.Agenda(Session("gdfecsis"), ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lnnivel, Session("gnnivel2"), Session("gnnivel3"))
            Me.Imprime("cragenda.rpt", dsbase1, lcexportar)

        ElseIf Me.rbtnmuni.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenMunicipios(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crmunicipios.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnmonto.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenMontos(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crrangos.rpt", dsbase1, lcexportar)

        ElseIf Me.rbtnplazos.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenPlazos(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crplazos.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtncali.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenReserva(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crreserva.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtninforme1.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = Me.Informe(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona)
            Me.Imprime("crcolocacion.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnafecta.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = Me.Informe2(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona, lctipo)
            Me.Imprime("crafectada.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnactivi.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenActividades(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("cractividad.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtndestino.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenDestino(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crdestino.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtntasa.Checked = True Then
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculada1(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            Me.Imprime("crcartasa.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnparalelo.Checked = True Then
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculada1(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            Me.Imprime("crcarpara.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtn50.Checked = True Then
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculada50(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            Me.Imprime("crcartera.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtndesercion.Checked = True Then
            lmora = False
            cancela = "1"
            dsbase1 = M1.Decersion(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)

            Dim clsppal As New class1
            Dim fila As DataRow
            Dim i As Integer = 0
            Dim lccodcta As String
            Dim lncuota As Double
            clsppal.gnperbas = Session("gnperbas")
            clsppal.pnComtra = Session("gnComTra")

            For Each fila In dsbase1.Tables(0).Rows
                lccodcta = dsbase1.Tables(0).Rows(i)("ccodcta")
                'If ecremcre.dfecvig >= #7/11/2008# Then
                'clsppal.pnSegVm = Session("gnSegVm1")
                'Else
                clsppal.pnSegVm = Session("gnSegVm")
                'End If
                lncuota = clsppal.ValorCuota(lccodcta)
                dsbase1.Tables(0).Rows(i)("ncuota") = lncuota
                i += 1
            Next

            Me.Imprime("crdesercion.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnsector.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenSector(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crsector.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtngarantia.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenGarantia(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crgenero.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnedad.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenEdad(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("credad.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnsecuencia.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.Resumensecuencia(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crsecuencia.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtntipo.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenTipo(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crtipocre.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnprorec.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.Proyeccion_Cuotas(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crprocuotas.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnextorno.Checked = True Then
            dsbase1 = M1.DETALLE_CARTERA_Y_PAGOS_Extorno(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona)
            Me.Imprime("crextornos.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnextorno0.Checked = True Then
            dsbase1 = M1.DETALLE_CARTERA_Y_PAGOS_Extorno(ldfecha1, ldfecha2, "D", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona)
            Me.Imprime("crextornos0.rpt", dsbase1, lcexportar)

        ElseIf Me.rbtnrecumen.Checked = True Then
            dsbase1 = M1.Resumen_Mensual_Recuperaciones(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona)
            Me.Imprime("crresumenr.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnrecuanu.Checked = True Then
            dsbase1 = M1.Resumen_Anual_Recuperaciones(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona)
            Me.Imprime("crresumenA.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtncolomen.Checked = True Then
            dsbase1 = M1.Resumen_Mensual_Colocacion(ldfecha1, ldfecha2, "D", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona)
            Me.Imprime("crresumenc.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtncoloanu.Checked = True Then
            dsbase1 = M1.Resumen_Anual_Colocacion(ldfecha1, ldfecha2, "D", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona)
            Me.Imprime("crresumenc1.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtIngresos1.Checked = True Then      'Pagos 
            dsbase1 = M1.DETALLE_CARTERA_Y_PAGOS_EXCEDENTES(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona)
            Me.Imprime("cringresoscre3.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtproyeccion1.Checked = True Then
            lmora = True
            cancela = "0"
            M1.pnopcion = 1
            M1.pncomtra = Session("gncomtra")
            M1.pnperbas = Session("gnperbas")
            M1.pnsegvm = Session("gnSegVm")
            M1.pnsegvm1 = Session("gnSegVm1")

            M1.pltoda = CheckBox1.Checked
            M1.pnRango1 = Integer.Parse(txtrango1.Text)
            M1.pnRango2 = Integer.Parse(txtrango2.Text)

            dsbase1 = M1.CarteraCalculadaMora(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto)
            Me.Imprime("crproyeccionOb.rpt", dsbase1, lcexportar)

            '/****** Object:  Reporte Modificado[rbtnprorec1.Checked] Script Date: 06/29/2015 17:17:30 modificacion ******/
        ElseIf Me.rbtnprorec1.Checked = True Then
            Dim NcapMoraXCLi As Double

            cancela = "0"
            lmora = False
            M1.pncomtra = Session("gncomtra")
            M1.pnperbas = Session("gnperbas")
            M1.pnsegvm = Session("gnSegVm")
            M1.pnsegvm1 = Session("gnSegVm1")

            dsbase1 = M1.Proyeccion_Cuotas_porCredito551(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Dim newCustomersRow As DataRow = dsbase1.Tables(0).NewRow()

            dsbase1.Tables(0).Columns.Add("CapitalMoratorio")
            Dim ele As Integer
            For Each rowDs As DataRow In dsbase1.Tables(0).Rows
                NcapMoraXCLi = M1.ObtieneCpMoratorixCliente(rowDs("ccodcta"), ldfecha2)
                dsbase1.Tables(0).Rows(ele)("CapitalMoratorio") = NcapMoraXCLi
                ele += 1
            Next


            Me.Imprime("rptProyecDetall55.rpt", dsbase1, lcexportar)

            'Reporte Agregado 55.1 por grupos.. - 
            'Ageregado de reporte grupal en proyecccion  - 
        ElseIf Me.rbtnprorec551.Checked = True Then
            cancela = "0"
            lmora = False
            M1.pncomtra = Session("gncomtra")
            M1.pnperbas = Session("gnperbas")
            M1.pnsegvm = Session("gnSegVm")
            M1.pnsegvm1 = Session("gnSegVm1")

            dsbase1 = M1.Proyeccion_Cuotas_porCredito55_1(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("Reporteproyeccion55_1.rpt", dsbase1, lcexportar)
            '--Terminado - 

        ElseIf Me.rbtCartera1.Checked = True Then
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculada17(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, "S")
            Me.Imprime("crcarterase.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtCartera2.Checked = True Then
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculada17(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, "D")
            Me.Imprime("crcarteradc.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtCartera3.Checked = True Then
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculada18(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, "")
            Me.Imprime("crcarterarm.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtCartera4.Checked = True Then
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculada19(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, "")
            Me.Imprime("crcarteraga.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtninfored.Checked = True Then
            'Dim clsppal As New class1
            'Dim iflag As Integer
            'lmora = False
            'cancela = "0"
            'dsbase1 = M1.CarteraCalculadaINFORED(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela)
            'iflag = clsppal.InfoRed(dsbase1, ldfecha2)
            'If iflag = 1 Then
            '    Response.Write("<script language='javascript'>alert('Datos Generados con Exito')</script>")
            'End If
            lmora = False
            cancela = "0"
            'dsbase1 = M1.CarteraCalculadaTransunion(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            'ExportToExcel(dsbase1.Tables(0))
            dsbase1 = M1.CarteraCalculada(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            GeneraArchivo(dsbase1)
        ElseIf Me.rbtnEjecutivo.Checked = True Then 'detalle de cartera con ingresos
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculadaResumen(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            Me.Imprime("crejecutivo.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtAjuste.Checked = True Then
            Dim dsbase As New DataSet
            dsbase = M1.DETALLE_CARTERA_Y_PAGOS_AJUSTES(ldfecha1, ldfecha2, "C", lcoficina, lcanalista, lcestrato, lclineas, " ", lccajeros, lczona)
            Me.Imprime("cringresoscre2.rpt", dsbase, lcexportar)
        ElseIf Me.rbttransunion.Checked = True Then
            'lmora = False
            'cancela = "0"
            'dsbase1 = M1.CarteraCalculadaTransunion(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            'ExportToExcel(dsbase1.Tables(0))
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculada(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            GeneraArchivo(dsbase1)
        ElseIf Me.rbtAjuplan.Checked = True Then
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculadaTras(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            Me.Imprime("crcarteraAj.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnIntereses.Checked = True Then
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraCalculada(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            Me.Imprime("crcarteraInt.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtncuoven.Checked = True Then
            lmora = True
            cancela = "0"
            M1.pnopcion = 1
            M1.pncomtra = Session("gncomtra")
            M1.pnperbas = Session("gnperbas")
            M1.pnsegvm = Session("gnSegVm")
            M1.pnsegvm1 = Session("gnSegVm1")
            dsbase1 = M1.CarteraCalculadaCuotasaVencer(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto)
            Me.Imprime("crVenCuotas.rpt", dsbase1, lcexportar)
        ElseIf Me.rbcondesem.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.ConsolidadoCreditosOtorgados(lclineas, lcoficina, ldfecha1, ldfecha2, TotalCreditosOtorgados, MontoOtorgado, Promedio, lcanalista)
            ds.Tables.Add(tabla)
            Me.Imprime("crpConsCredOtorgados.rpt", ds, lcexportar)
        ElseIf Me.rbtnfdlg.Checked = True Then
            'lmora = False
            'cancela = "0"
            'dsbase1 = M1.ConsultaFDL(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            ''Directo a Excel
            'Me.ExportToExcel(dsbase1.Tables(0))
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenTipoCartera(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
            Me.Imprime("crsector.rpt", dsbase1, lcexportar)

        ElseIf Me.rbtcreditosplazo.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.CreditosPorPlazo(lclineas, lcoficina, lctipo, ldfecha2)
            ds.Tables.Add(tabla)
            Me.Imprime("crpCarteraPorPlazo.rpt", ds, lcexportar)
        ElseIf Me.rbtResumenxProducto.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.ResumenCarteraPorProducto(lclineas, lcoficina, lctipo, ldfecha2)
            ds.Tables.Add(tabla)
            Me.Imprime("crpResumen17.rpt", ds, lcexportar)
        ElseIf Me.rbtPeriodicidad.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.PeriodicidadCobro(lclineas, lcoficina, lctipo, ldfecha2)
            ds.Tables.Add(tabla)
            Me.Imprime("crpPeriodicidadCobro.rpt", ds, lcexportar)
        ElseIf Me.rbtResumenDesembolso.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.ResumenDesembolso(lclineas, lcoficina, lcproducto, lcanalista, ldfecha1, ldfecha2)
            ds.Tables.Add(tabla)
            Me.Imprime("crpDesembolsoConsolidado.rpt", ds, lcexportar)
        ElseIf Me.rbtClasificacionCarteraXAgencia.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.ConsolidadoCarteraDivididaPorAgencia(lclineas, lctipo, ldfecha2)
            ds.Tables.Add(tabla)
            Me.Imprime("crpCarteraDivididaPorAgencia.rpt", ds, lcexportar)
        ElseIf Me.rbtResumenDeIngresos.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.ResumenIngresos(lclineas, lcoficina, lcproducto, lcanalista, ldfecha1, ldfecha2)
            ds.Tables.Add(tabla)
            Me.Imprime("crpIngresosConsolidados.rpt", ds, lcexportar)
        ElseIf Me.rbtCarteraSuspendida.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.CarteraConInteresesSuspendidos(lclineas, lcoficina, lcproducto, ldfecha2)
            ds.Tables.Add(tabla)
            Me.Imprime("crpCarteraConSuspencionIntereses.rpt", ds, lcexportar)

        ElseIf Me.rbtIngresosCondonados.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.IngresosCondonados(lclineas, lcoficina, lcproducto, lcanalista, ldfecha1, ldfecha2)
            ds.Tables.Add(tabla)
            Me.Imprime("crpIngresosCondonados.rpt", ds, lcexportar)
        ElseIf Me.rbtResumenCartera3.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.ResumenDeCartera3(lclineas, lcoficina, lcanalista, lctipo, lczona, ldfecha2)
            ds.Tables.Add(tabla)
            Me.Imprime("crpResumenCartera3.rpt", ds, lcexportar)
        ElseIf Me.rbtOtrosIngresos.Checked = True Then
            Dim ds As New DataSet
            Dim tabla As New DataTable
            tabla = M1.OtrosIngresos(lcoficina, ldfecha1, ldfecha2)
            ds.Tables.Add(tabla)
            Me.Imprime("crpOtrosIngresos.rpt", ds, lcexportar)
            'ElseIf Me.rbtnprovision.Checked = True Then
            '    provisionMensual()
        ElseIf rbtnsolicitud.Checked = True Then
            cancela = "0"
            lmora = False
            Dim lnnivel As Integer
            lnnivel = 1
            'dsbase1 = M1.Solicitudes(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lccartera, Session("gdfecsis"))
            dsbase1 = M1.Solicitudes_Pendientes(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lccartera, Session("gdfecsis"))
            Me.Imprime("crsolicitudes.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnaldea.Checked = True Then
            cancela = "0"
            lmora = False
            dsbase1 = M1.ResumenAldeas(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona)
            Me.Imprime("crcomunidad.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtnInter.Checked = True Then
            lmora = True
            cancela = "0"
            M1.pnopcion = 1
            M1.pncomtra = Session("gncomtra")
            M1.pnperbas = Session("gnperbas")
            M1.pnsegvm = Session("gnSegVm")
            M1.pnsegvm1 = Session("gnSegVm1")
            M1.pdfecha = Session("gdfecsis")

            M1.pltoda = CheckBox1.Checked
            M1.pnRango1 = Integer.Parse(txtrango1.Text)
            M1.pnRango2 = Integer.Parse(txtrango2.Text)

            dsbase1 = M1.CarteraIntermediacion(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto)
            Me.Imprime("crintermediacion.rpt", dsbase1, lcexportar)
        ElseIf Me.rbtCartera5.Checked = True Then
            lmora = False
            cancela = "0"
            dsbase1 = M1.CarteraTrasladada(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, cancela, lcproducto)
            Me.Imprime("crcarteraTras.rpt", dsbase1, lcexportar)
            '-- =============================================
            '-- Author:         <FERNANDO ABREGO RDZ>
            '-- Create date: <2/26/2015>
            '-- Description:  <Comportamiento_Productos>
            '-- Eventos:        <ninguno>
            '-- Fuciones:      <Compartamiento_Productos,Buscar_oficinas,Consulta_Analista,Mora_Producto>
            '-- Procesos:      <ninguno>
            '-- =============================================
        ElseIf Me.Rb_ComisionesIndividual.Checked = True Then
            dsbase1 = M1.ComisionesIndividual(ldfecha1, ldfecha2, lcoficina, lcanalista)
            Dim dttbl As DataTable
            dttbl = dsbase1.Tables(0)
            ExportToExcel(dttbl)
        ElseIf Me.RdbComportamiento.Checked = True Then
            'variable mora manejar con valor true para que sea tomada encuenta
            lmora = True
            cancela = "0"
            M1.pltoda = CheckBox1.Checked
            'rengos que calculan la mora
            M1.pnRango1 = Integer.Parse(txtrango1.Text)
            M1.pnRango2 = Integer.Parse(txtrango2.Text)
            'DataSet almacena la funcion que busca los productos
            'Funciones de : Buscar Oficinas, consulta por analistas  y mora por producto
            Dim setProductos As New DataSet
            setProductos = M1.Productos_Search()
            dsbase1 = M1.Buscar_Oficinas(lcoficina)
            dsbase1 = M1.Consulta_analistaSuc(dsbase1, setProductos, ldfecha1, ldfecha2, lcanalista)
            dsbase1 = M1.MORA_POR_PRODUCTO(dsbase1, ldfecha1, ldfecha2)

            'Una vez formado el dataset con los datos  Pasamo a datatable para acomodarlo
            Dim TemdsBase1 As DataTable = dsbase1.Tables(0).Copy

            'removemos Columnas que no ocupamos
            TemdsBase1.Columns.Remove("Id_Sucursal")
            TemdsBase1.Columns.Remove("id_Asesor")
            TemdsBase1.Columns.Remove("idproducto")
            'Buscar capoital desembolsado

            Dim total_desce As Double 'captura el valor de cada fila
            Dim acumulador As Double 'captura el valor de total_desc
            Dim acumulador2 As Double 'mantiene el valor para recibir otro valor y almacenarlos

            'Recorrer las columna de capital desembolsado
            For Each rowsDa As DataRow In TemdsBase1.Rows
                total_desce = rowsDa("Capital_Desembolsado")
                acumulador = total_desce
                If acumulador > 0.0 Then

                    acumulador2 = acumulador2 + acumulador
                End If

            Next
            'revision de la variable
            acumulador2 = acumulador2
            'for Each para obtener el capital de la mora
            Dim total_mora As Double 'Almacena el valor de cada fila y al final obtiene el el capital
            Dim acumu_mora1 As Double 'almacena el valor de total_mora
            Dim acumu_2 As Double 'almacena y retiene valores para ser un sumado
            Dim TotFilas As Integer 'Obtiene el total de las fila de la columna
            Dim TotMora As Double 'no se utiliza
            For Each rowsDa As DataRow In TemdsBase1.Rows
                total_mora = rowsDa("mora")
                acumu_mora1 = total_mora
                If acumu_mora1 > 0.0 Then

                    acumu_2 = acumu_2 + acumu_mora1
                End If

            Next
            acumu_2 = acumu_2 ' solo muestra el ultimo valor obtenido quee s la suma de los valores de las filas
            '
            TotFilas = TemdsBase1.Rows.Count() 'Realiza un conteo del total de las filas
            total_mora = (acumu_2 / TotFilas) 'Obteiene el promedio de la cantidad entre el total de filas para obtener el capital

            'Dim total_capitalDes As Object = TemdsBase1.Compute("Sum(Capital_Desembolsado)", "")
            'Dim total_porcentaje_mora As Object = TemdsBase1.Compute("Avg(mora)", "")

            'Agregamos la fila a las columnas mencionadas entre (".....")
            Dim newCustomersRow As DataRow = TemdsBase1.NewRow()
            newCustomersRow("Capital_Desembolsado") = acumulador2
            newCustomersRow("mora") = total_mora
            TemdsBase1.Rows.Add(newCustomersRow)
            'le damos nombre personalizado a las columnas que vera el usuario
            TemdsBase1.Columns("Capital_Desembolsado").ColumnName = "Capital Desembolsado"
            TemdsBase1.Columns("mora").ColumnName = "Capital en Mora"
            'Funcion para Convertir el datatable de esta seccion y hacer un excel
            ExportToExcel(TemdsBase1)

            '''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''
        ElseIf Me.rbComisionesMensuales.Checked = True Then
            Dim Rpt_28 As New DataSet
            Rpt_28 = M1.Rpt_ComisionMensuales82(ldfecha1, ldfecha2, lcoficina, lcanalista, "*")
            Dim rpt_Comision_Mensuales As DataTable = Rpt_28.Tables(0).Copy
            rpt_Comision_Mensuales.Columns.Remove("COD_ANALISTA")
            rpt_Comision_Mensuales.Columns.Remove("CODI_OFICIN")
            'variable de totales
            Dim totCapCol As Object = rpt_Comision_Mensuales.Compute("Sum(CAP_COLOC_ANT)", "")
            Dim totCapColAtu As Object = rpt_Comision_Mensuales.Compute("Sum(CAP_COLOC_ACTU)", "")
            Dim totComCol As Object = rpt_Comision_Mensuales.Compute("Sum(COMIS_POR_COLO)", "")
            Dim totSalCap As Object = rpt_Comision_Mensuales.Compute("Sum(SALDO_CAPITA)", "")
            Dim totCapVen As Object = rpt_Comision_Mensuales.Compute("Sum(CAPITAL_VENCI)", "")

            Dim totCapRec As Object = rpt_Comision_Mensuales.Compute("Sum(CAPITAL_RECU)", "")
            Dim totComxRec As Object = rpt_Comision_Mensuales.Compute("Sum(COMIS_POR_RECU)", "")
            Dim totCom As Object = rpt_Comision_Mensuales.Compute("Sum(TOTA_COMI)", "")
            'Asigancion de fila al final de cada columna, con calculo
            Dim newCustomersRow As DataRow = rpt_Comision_Mensuales.NewRow()
            'Agregados
            newCustomersRow("CAP_COLOC_ANT") = totCapCol

            newCustomersRow("CAP_COLOC_ACTU") = totCapColAtu

            newCustomersRow("COMIS_POR_COLO") = totComCol

            newCustomersRow("SALDO_CAPITA") = totSalCap

            newCustomersRow("CAPITAL_VENCI") = totCapVen


            newCustomersRow("PORCE_MORA") = Decimal.Round(((totCapVen * 100) / totSalCap), 2)

            newCustomersRow("CAPITAL_RECU") = totCapRec

            newCustomersRow("COMIS_POR_RECU") = totComxRec

            newCustomersRow("TOTA_COMI") = totCom

            rpt_Comision_Mensuales.Rows.Add(newCustomersRow)

            'Asignacion de nombres personalizados a las columnas (No se pueden repetir)

            rpt_Comision_Mensuales.Columns("NOMBRE_USUARIO").ColumnName = "Asesor"
            rpt_Comision_Mensuales.Columns("NOMBRE_OFICINA").ColumnName = "Oficina"
            rpt_Comision_Mensuales.Columns("MES_ANTERIOR").ColumnName = "Mes Anterior"
            rpt_Comision_Mensuales.Columns("CAP_COLOC_ANT").ColumnName = "Capital colocado Anterior"
            rpt_Comision_Mensuales.Columns("MES_ACTUAL").ColumnName = "Mes Actual"
            rpt_Comision_Mensuales.Columns("CAP_COLOC_ACTU").ColumnName = "Capital colcado Actual"
            rpt_Comision_Mensuales.Columns("PORCEN_COMI").ColumnName = "Porcentaje Comision"
            rpt_Comision_Mensuales.Columns("COMIS_POR_COLO").ColumnName = "Comision por Colocacion"
            rpt_Comision_Mensuales.Columns("SALDO_CAPITA").ColumnName = "Saldo Capital"
            rpt_Comision_Mensuales.Columns("CAPITAL_VENCI").ColumnName = "Capital Vencido"
            rpt_Comision_Mensuales.Columns("PORCE_MORA").ColumnName = "Porcentaje de Mora"
            rpt_Comision_Mensuales.Columns("CAPITAL_RECU").ColumnName = "Capital Recuperado"
            rpt_Comision_Mensuales.Columns("PORCEN_COMIS").ColumnName = "Porcentaje de comision"
            rpt_Comision_Mensuales.Columns("COMIS_POR_RECU").ColumnName = "Comision por recuperacion"
            rpt_Comision_Mensuales.Columns("TOTA_COMI").ColumnName = "Total Comision"
            rpt_Comision_Mensuales.Columns("BONO_FIN_MES").ColumnName = "Bono colocacion Mensual"
            rpt_Comision_Mensuales.Columns("BONO_COBRANZA_SEMANAL").ColumnName = "Bono incremento semanal"
            rpt_Comision_Mensuales.Columns("RECUPERADO_SEMANA_PASADA").ColumnName = "Cobranza semana anterior"

            'Decision para formato PDF o Excel
            If ddlexportar.SelectedIndex = 0 Then
                dsbase1 = Rpt_28
                Me.Imprime("Rpt82Comisiones.rpt", dsbase1, lcexportar)
            ElseIf ddlexportar.SelectedIndex = 2 Then
                ExportToExcel(rpt_Comision_Mensuales)
            End If

        ElseIf Me.RdbDetGruPro.Checked = True Then

            Dim Rpt_88 As New DataSet
            Rpt_88 = M1.Rpt_DPGrupales88(ldfecha1, ldfecha2, lcoficina, lcanalista, "*")
            Dim Rpt_DPGrupales88_Table As DataTable = Rpt_88.Tables(0).Copy

            Dim totDesem As Object = Rpt_DPGrupales88_Table.Compute("Sum(importe)", "")
            Dim totSaldoC As Object = Rpt_DPGrupales88_Table.Compute("Sum(saldo)", "")
            Dim totCapMo As Object = Rpt_DPGrupales88_Table.Compute("Sum(capital_mora)", "")

            Dim newCustomersRow As DataRow = Rpt_DPGrupales88_Table.NewRow()
            'Agregados
            newCustomersRow("importe") = totDesem

            newCustomersRow("saldo") = totSaldoC

            newCustomersRow("capital_mora") = totCapMo

            Rpt_DPGrupales88_Table.Rows.Add(newCustomersRow)

            Rpt_DPGrupales88_Table.Columns("sucursal").ColumnName = "Sucursal"
            Rpt_DPGrupales88_Table.Columns("Grupo").ColumnName = "Oficina"
            Rpt_DPGrupales88_Table.Columns("cdeslin").ColumnName = "Tipo de Producto"
            Rpt_DPGrupales88_Table.Columns("Asesor").ColumnName = "Asesor"
            Rpt_DPGrupales88_Table.Columns("importe").ColumnName = "Capital Desembolsado"
            Rpt_DPGrupales88_Table.Columns("saldo").ColumnName = "Saldo Capital"
            Rpt_DPGrupales88_Table.Columns("capital_mora").ColumnName = "Capital en Mora"


            'Decision para formato PDF o Excel
            If ddlexportar.SelectedIndex = 0 Then
                dsbase1 = Rpt_88
                Me.Imprime("RptSeguimientoProductos.rpt", dsbase1, lcexportar)
            ElseIf ddlexportar.SelectedIndex = 2 Then
                ExportToExcel(Rpt_DPGrupales88_Table)
            End If
            '-- =============================================
            '-- Author:      <FERNANDO ABREGO RDZ>
            '-- Create date: <2/11/2015>
            '-- Description: <Reporte 84 LD>
            '-- Eventos:     <.....>
            '-- Fuciones:    <REPORTE MUESTRA MONTOS PAGADOS>
            '-- Procesos:    <.....>
            '-- Variables:   <RPT_DL>
            '-- =============================================
            'ElseIf Me.RdbLD.Checked = True Then
            '    'Envia parametro de fecha a la funcion

            '    M1.Rpt_DL(ldfecha2)
            '-----------------------------------------------------------
            '****Reporte de Anexo C ----
        ElseIf Me.RdbAnexoC.Checked = True Then
            Dim cargarAnexo As DataTable

            cargarAnexo = M1.cargarAnexoC()

            ExportToExcel(cargarAnexo)

        ElseIf Me.RdbDesembolso.Checked = True Then
            Dim datatable_recibe As DataTable
            datatable_recibe = M1.Rpt_Desembolsos(ldfecha1, ldfecha2)
            ExportToExcel(datatable_recibe)

            'Realizar cambio en el formato excel
            '-- =============================================
            '-- Author:      <FERNANDO ABREGO RDZ>
            '-- Create date: <26/03/2015>
            '-- Description: <Reporte 84 LD>
            '-- Eventos:     <.....>
            '-- Fuciones:    <REPORTE desembolsos inusuales>
            '-- Procesos:    <.....>
            '-- Variables:   <-....>
            '-- =============================================
        ElseIf Me.RdbDesembolso_inusuales.Checked = True Then
            Dim Almacenador_datatable_desembolso As DataTable = M1.Rpt_Dolares_Desembolso_inusuales(ldfecha1, ldfecha2)

            Dim i As Integer = 0

            For Each rows As DataRow In Almacenador_datatable_desembolso.Rows


                i += 1

            Next
            If i = 1 Then
                codigoJs = "<script language='javascript'>alert('Ningun monto supera el tipo de cambio a la fecha, " & _
                   "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            Else


                ExportToExcel(Almacenador_datatable_desembolso)
            End If



            'ExportToExcel(Almacenador_datatable_desembolso)

        ElseIf Me.RdbPagos_Cuotas_Inusuales.Checked = True Then

            Dim Almacenador_datatable_Pagos As DataTable = M1.Rpt_Pago_Cuotas_inusuales(ldfecha1, ldfecha2)


            Dim i As Integer = 0

            For Each rows As DataRow In Almacenador_datatable_Pagos.Rows
                i += 1
            Next
            If i = 1 Then
                codigoJs = "<script language='javascript'>alert('No hay pagos insuales a la fecha, " & _
                   "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            Else
                ExportToExcel(Almacenador_datatable_Pagos)
            End If


        ElseIf Me.RdbOperaciones_Insuales.Checked = True Then

            Dim Almacenador_datatable_Operaciones As DataTable = M1.RdbOperaciones_Insuales(ldfecha1, ldfecha2)
            Dim i As Integer = 0

            For Each rows As DataRow In Almacenador_datatable_Operaciones.Rows
                i += 1
            Next
            If i = 1 Then
                codigoJs = "<script language='javascript'>alert('No hay pagos insuales a la fecha, " & _
                   "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            Else
                ExportToExcel(Almacenador_datatable_Operaciones)
            End If

            '******Fernando Abrego reporte 88 Nuevo En vista 03- 07-2015 *******'
        ElseIf Me.RdbCuentaMaestra.Checked = True Then

            dsbase1 = M1.Rpt_CuentaMaestra(ldfecha1, ldfecha2)
            Dim Rpt_CuentaMaestra_table_89 As DataTable = dsbase1.Tables(0).Copy
            Dim TotMonto As Object = Rpt_CuentaMaestra_table_89.Compute("Sum(nmonto)", "")
            Dim newCustomersRow As DataRow = Rpt_CuentaMaestra_table_89.NewRow()
            'Agregados
            newCustomersRow("nmonto") = TotMonto

            Rpt_CuentaMaestra_table_89.Rows.Add(newCustomersRow)
            Rpt_CuentaMaestra_table_89.Columns("cnomcli").ColumnName = "Cliente"
            Rpt_CuentaMaestra_table_89.Columns("ccodcli").ColumnName = "Codigo Cliente"
            Rpt_CuentaMaestra_table_89.Columns("fecha").ColumnName = "Fecha"
            Rpt_CuentaMaestra_table_89.Columns("nmonto").ColumnName = "Monto"

            If ddlexportar.SelectedIndex = 0 Then
                Me.Imprime("RptCuentaMaestra.rpt", dsbase1, lcexportar)
            ElseIf ddlexportar.SelectedIndex = 2 Then
                ExportToExcel(Rpt_CuentaMaestra_table_89)
            End If

        ElseIf RdbGestores.Checked = True Then

            dsbase1 = M1.Rpt_GestoresMora(ldfecha2, lcoficina, lcanalista)

            Dim Rpt_GestoresMora_ As DataTable = dsbase1.Tables(0).Copy
            'Sumatorias
            Dim montoprestado As Object = Rpt_GestoresMora_.Compute("Sum(Monto_prestado)", "")
            Dim garantia_ As Object = Rpt_GestoresMora_.Compute("Sum(Garantia)", "")
            Dim saldoCapital As Object = Rpt_GestoresMora_.Compute("Sum(Saldo_capital)", "")
            Dim interesnormal As Object = Rpt_GestoresMora_.Compute("Sum(Interes_normal)", "")
            Dim interesmoratorio As Object = Rpt_GestoresMora_.Compute("Sum(Interes_moratorio)", "")
            Dim dias_atraso As Object = Rpt_GestoresMora_.Compute("Sum(Dias_atraso)", "")
            Dim Monto_cuota As Object = Rpt_GestoresMora_.Compute("Sum(Monto_Cuota)", "")
            Dim newCustomersRow As DataRow = Rpt_GestoresMora_.NewRow()
            ''Agregados
            newCustomersRow("Monto_prestado") = montoprestado
            newCustomersRow("Garantia") = garantia_
            newCustomersRow("Saldo_capital") = saldoCapital
            newCustomersRow("Interes_normal") = interesnormal
            newCustomersRow("Interes_moratorio") = interesmoratorio
            newCustomersRow("Dias_atraso") = dias_atraso
            newCustomersRow("Monto_Cuota") = Monto_cuota

            Rpt_GestoresMora_.Rows.Add(newCustomersRow)

            ExportToExcel(Rpt_GestoresMora_)
        ElseIf RdbAsigAnalistas.Checked = True Then

            dsbase1 = M1.ExecReporteAsigAnalistas(ldfecha2, lcoficina, lcanalista)
            'Modificar a table
            Dim ExecReporteAsigAnalistas_ As DataTable = dsbase1.Tables(0).Copy
            'Sumatorias
            Dim montoprestado As Object = ExecReporteAsigAnalistas_.Compute("Sum(Monto_prestado)", "")
            Dim garantia_ As Object = ExecReporteAsigAnalistas_.Compute("Sum(Garantia)", "")
            Dim saldoCapital As Object = ExecReporteAsigAnalistas_.Compute("Sum(Saldo_capital)", "")
            Dim interesnormal As Object = ExecReporteAsigAnalistas_.Compute("Sum(Interes_normal)", "")
            Dim interesmoratorio As Object = ExecReporteAsigAnalistas_.Compute("Sum(Interes_moratorio)", "")
            Dim dias_atraso As Object = ExecReporteAsigAnalistas_.Compute("Sum(Dias_atraso)", "")
            Dim Monto_cuota As Object = ExecReporteAsigAnalistas_.Compute("Sum(Monto_Cuota)", "")
            Dim newCustomersRow As DataRow = ExecReporteAsigAnalistas_.NewRow()
            ''Agregados
            newCustomersRow("Monto_prestado") = montoprestado
            newCustomersRow("Garantia") = garantia_
            newCustomersRow("Saldo_capital") = saldoCapital
            newCustomersRow("Interes_normal") = interesnormal
            newCustomersRow("Interes_moratorio") = interesmoratorio
            newCustomersRow("Dias_atraso") = dias_atraso
            newCustomersRow("Monto_Cuota") = Monto_cuota

            ExecReporteAsigAnalistas_.Rows.Add(newCustomersRow)
            ExportToExcel(ExecReporteAsigAnalistas_)
        ElseIf RdbConsultaAnalistasGestores.Checked = True Then
            'Obtenemos sucursal
            Dim lccodofi_ As String = Session("gcCodofi")
            dsbase1 = M1.consultaCodigoAnalistasGestores(lccodofi_)
            ExportToExcel(dsbase1.Tables(0))

        ElseIf RdbPrendarias.Checked = True Then
            dsbase1 = M1.consultaGarantiasPrendarias()
            ExportToExcel(dsbase1.Tables(0))

        ElseIf RdbDetalleGarantias.Checked = True Then
            dsbase1 = M1.ConsultaDetalleGarantias(ldfecha1, ldfecha2)
            ExportToExcel(dsbase1.Tables(0))
        End If

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
        If Me.chqproducto.Checked = True Then
            Me.ddlproducto.Enabled = False
        Else
            Me.ddlproducto.Enabled = True
        End If

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

            lcnombre = "8152_TRANSACCION_GENERICA_PAT" '"CE_reficom_cdro_" & lcdia & lcmes & lcaño & ".txt"
            

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
            Dim pccodcli As String = ""
            For Each dr In ds.Tables(0).Rows
                'Obtenemos los datos del dataset
                pccodcta = (dr("ccodcta") & Trim(dr("ffondos")))
                pcnudoci = (dr("cnudoci"))
                pccuota = CStr(Math.Round(dr("ncuotakp") + dr("nsalint") + dr("nsalintmor") + dr("ncapmora"), 2))
                pcsaldo = CStr(Math.Round(dr("nsalcap") + dr("nsalint") + dr("nsalintmor"), 2))
                pcnomcli = dr("cnomcli")
                pccodcli = dr("ccodcli")
                'pccodcta = clsppal.zeros(pccodcta.Trim, 25)
                'Escribimos la línea en el achivo de texto
                '                If pccodcta.Trim.Substring(3, 3) = "001" Then
                '                Else
                strStreamWriter.WriteLine("8152" & "|" & pccodcli & "|" & "0" & "|" & pccodcta.Trim & "|" & pcsaldo.Trim & _
                    "|3|0|0|0|0|0|0|0|0||")

                '               End If

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

    Private Sub rotorProbatorio()

    End Sub


    '-- =============================================
    '-- Author:      <FERNANDO ABREGO RDZ>
    '-- Create date: <2/11/2015>
    '-- Description: <Funcion para exportar datos del dataset--> datatable a excel >
    '-- Eventos:     <.....>
    '-- Fuciones:    <se utiliza el ExportarDataTableAExcel(tempDataset) para capturar el datatable>
    '-- Procesos:    <.....>
    '-- Variables:   <Muchas mencionas a continuacion >
    '-- =============================================

    Shared Function ExportarDataTableAExcel(ByVal Tabla As DataTable) As Boolean
        Try
            'Creamos las variables
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim filaTabla As System.Data.DataRow

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = Tabla.Columns.Count
            Dim NRow As Integer = Tabla.Rows.Count

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(3, i) = Tabla.Columns(i - 1).Caption
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                filaTabla = Tabla.Rows(Fila)
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 4, Col + 1) = filaTabla(Col)
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(3).Font.Bold = 1
            exHoja.Rows.Item(3).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

            ExportarDataTableAExcel = True
        Catch ex As Exception
            MsgBox(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador")
            ExportarDataTableAExcel = False
        End Try
    End Function

    '-- =============================================
    '-- Author:      <FERNANDO ABREGO RDZ>
    '-- Create date: <2/11/2015>
    '-- Description: <Funcion para exportar datos del dataset--> datatable A BLOC DE NOTAS >
    '-- Eventos:     <.....>
    '-- Fuciones:    <se utiliza para exportar a texto plano los datos de los clientes>
    '-- Procesos:    <.....>
    '-- Libreria:   <Imports system.IO>
    '-- =============================================
    Public Sub Generador_txt_Clientes(ByVal ds As DataSet)
        Dim strStreamW As Stream
        Dim strStreamWrite As StreamWriter
        Dim lcnombre As String
        'Try
        lcnombre = "Archivo_Consulta_Clientes.txt"
        'ruta por default
        Dim FilePath As String = "c:/txt/" & lcnombre

        'Se abre el archivo y si este no existe se crea
        strStreamW = File.OpenWrite(FilePath)
        strStreamWrite = New StreamWriter(strStreamW, _
        System.Text.Encoding.UTF8)

        'Se traen los datos que necesitamos para el archivo
        'TraerDatosArchivo retorna un dataset pero perfectamente
        'podria ser cualquier otro tipo de objeto
        Dim dr As DataRow
        Dim Nombre As String = ""
        Dim Cadena_nombres As String = ""

        For Each dr In ds.Tables(0).Rows
            'Obtenemos los datos del dataset
            Nombre = CStr(dr("Column1"))

            If Nombre <> "" Then
                Cadena_nombres += Nombre & ","
                'Cadena_nombres.TrimEnd(",")
                'Cadena_nombres = Mid(Cadena_nombres, 1, Len(Cadena_nombres) - 1)


            End If
            'separamos por comas entre los nombres

            'Escribimos la línea en el achivo de texto
        Next
        'Quitamos el ultimo caracter en este caso la  -- > ,
        Cadena_nombres = Mid(Cadena_nombres, 1, Len(Cadena_nombres) - 1)
        'escribimos en el archivo
        strStreamWrite.WriteLine(Cadena_nombres)
        ' cerramos la escritura o proceso
        strStreamWrite.Close()
        'llamamos a la funcion para visualizar la descargar en el navegado
        Me.DownloadFile(FilePath, lcnombre.Trim)


        'Catch ex As Exception
        strStreamWrite.Close()
        ''MsgBox(ex.Message)
        'End Try
    End Sub


    Protected Sub ddlexportar_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlexportar.SelectedIndexChanged

    End Sub

    
    Protected Sub rbtCarteraVIg_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtCarteraVIg.CheckedChanged

    End Sub

   
End Class
