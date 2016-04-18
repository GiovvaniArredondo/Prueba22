Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Web

Public Class Reportes
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents ibtnExcel As System.Web.UI.WebControls.ImageButton
    Protected WithEvents crvContenedor As CrystalDecisions.Web.CrystalReportViewer

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region
    'Dim crRpt As New ReportDocument
    Dim crDatos As New crPlan
    Private nombreReporte As String = "Reporte"

    Private _pDataSet As DataTable
    Public Property pDataSet() As DataTable
        Get
            Return _pDataSet
        End Get
        Set(ByVal Value As DataTable)
            _pDataSet = Value
        End Set
    End Property


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DsClass
        nombreReporte &= ".xls"
        'Es importante utilizar el System.Data.MissingSchemaAction.Ignore, 
        'para que nos evite errores y haga el merge correctamente
        ds.Merge(Me.pDataSet, False, System.Data.MissingSchemaAction.Ignore)
        crDatos.SetDataSource(ds)
        Me.crvContenedor.ReportSource = crDatos
    End Sub



    Private Sub ibtnExcel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnExcel.Click
        '  Dim dsreporte As New DataTable
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        ' Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        'Try
        'Cargar Definicion del Reporte
        'crRpt.Load(Server.MapPath("reportes") + "\crPlan.rpt", OpenReportMethod.OpenReportByDefault)
        'Catch ex As Exception
        '    Return
        '   End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        '  crRpt.SetDataSource(dsreporte)
        'crRpt.SetDataSource(DataPlain.Tables(0))
        ' crRpt.Refresh()

        'rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        'Response.Clear()
        'Response.Buffer = True
        ' Establece el tipo de documento
        'Response.ContentType = "application/vnd.ms-excel"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<   

        'Se crea el documento de lectura y escritura
        ' Dim rptStream As New System.IO.MemoryStream
        'se envia el reporte el stram y le indicamos el metodo de escritura o tipo de documento
        rptStream = CType(crDatos.ExportToStream(ExportFormatType.Excel), System.IO.MemoryStream)

        'Limpiamos la memoria
        Response.Clear()
        Response.Buffer = True

        'Le indicamos el tipo de documento que vamos a exportar
        Response.ContentType = "application/vnd.ms-excel"

        'Automaticamente se descarga el archivo
        Response.AddHeader("Content-Disposition", "attachment;filename=" + Me.nombreReporte)

        'Se escribe el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
    End Sub
End Class
