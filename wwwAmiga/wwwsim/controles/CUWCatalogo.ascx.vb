Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class CUWCatalogo
    Inherits System.Web.UI.UserControl
    Private _URLCodigo As String

    Private _ClienteSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)

    Public Property ClienteSeleccionado() As String
        Get
            Return _ClienteSeleccionado
        End Get
        Set(ByVal Value As String)
            _ClienteSeleccionado = Value
            If ViewState("ClienteSeleccionado") Is Nothing Then
                ViewState.Add("ClienteSeleccionado", Value)
            Else
                ViewState("ClienteSeleccionado") = Value
            End If
        End Set
    End Property

    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

    
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

        'If Not IsPostBack Then
        Me.CargarDatos()
        ViewState.Add("pagina", 1)
        'End If

        Me._ClienteSeleccionado = Me.ViewState("ClienteSeleccionado")
    End Sub
    Private Sub dscatalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dscatalogo.SelectedIndexChanged
        ClienteSeleccionado = CType(Me.dscatalogo.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        RaiseEvent Seleccionado(ClienteSeleccionado)
    End Sub
    Private Sub dscatalogo_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dscatalogo.PageIndexChanged
        If Me.IsPostBack Then
            Me.dscatalogo.CurrentPageIndex = 0
            Me.dscatalogo.CurrentPageIndex = e.NewPageIndex
            Me.CargarDatos() 'este sería el procedimiento que se encarga de llenar tu datagrid.
        End If
    End Sub
    Private Sub CargarDatos()
        Dim entidadCtbmcta As New SIM.EL.ctbmcta
        Dim eCtbmcta As New SIM.BL.cCtbmcta
        Dim ds As New DataSet
        Dim ncanti As Integer


        ds = eCtbmcta.ObtenerDataSetPorID(Session("gcfondo"))

        ncanti = ds.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Me.dscatalogo.Visible = False
            Exit Sub
        Else
            Me.dscatalogo.Visible = True
        End If
        Me.dscatalogo.DataSource = ds
        Me.dscatalogo.DataBind()
        Me.dscatalogo.Enabled = True



        ds.Tables.Clear()

    End Sub


    Private Sub btnImprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.ServerClick
        Dim entidadCtbmcta1 As New SIM.EL.ctbmcta
        Dim eCtbmcta1 As New SIM.BL.cCtbmcta
        Dim ds1 As New DataSet
        Dim ncanti1 As Integer


        ds1 = eCtbmcta1.ObtenerDataSetPorID(Session("gcfondo"))

        ncanti1 = ds1.Tables(0).Rows.Count()

        If ncanti1 = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        Else
        End If

        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\crCatalogo.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        Dim lcNomofi As String = "INTEGRAL"

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds1.Tables(0))
        crRpt.Refresh()
        crRpt.SetParameterValue("cnomofi", lcNomofi.Trim)
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<     

    End Sub
End Class
