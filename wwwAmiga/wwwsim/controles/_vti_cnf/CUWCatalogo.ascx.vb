Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class CUWCatalogo
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents dsCatalogo As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnImprimir As System.Web.UI.HtmlControls.HtmlInputButton

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
        ' If Not IsPostBack Then
        CargarDatos()
        'End If
    End Sub
    Private Sub CargarDatos()
        Dim entidadCtbmcta As New SIM.EL.ctbmcta
        Dim eCtbmcta As New SIM.BL.cCtbmcta
        Dim ds As New DataSet
        Dim ncanti As Integer


        ds = eCtbmcta.ObtenerDataSetPorID()

        ncanti = ds.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Me.dsCatalogo.Visible = False
            Exit Sub
        Else
            Me.dsCatalogo.Visible = True
        End If
        Me.dsCatalogo.DataSource = ds
        Me.dsCatalogo.DataBind()
        Me.dsCatalogo.Enabled = True
        ds.Tables.Clear()

    End Sub

    
    Private Sub btnImprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.ServerClick
        Dim entidadCtbmcta1 As New SIM.EL.ctbmcta
        Dim eCtbmcta1 As New SIM.BL.cCtbmcta
        Dim ds1 As New DataSet
        Dim ncanti1 As Integer


        ds1 = eCtbmcta1.ObtenerDataSetPorID()

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

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds1.Tables(0))
        crRpt.Refresh()

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
