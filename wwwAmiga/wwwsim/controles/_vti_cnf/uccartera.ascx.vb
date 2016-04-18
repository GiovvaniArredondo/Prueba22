
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class uccartera
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents label_mensaje As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents txtfecfin As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents btnimprimir As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btncancela As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents Button5 As System.Web.UI.HtmlControls.HtmlInputButton

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
        If Not IsPostBack Then
            cargar()
        End If
    End Sub
    Sub cargar()
        Me.txtfecfin.Text = Session("gdfecsis")
    End Sub

    Private Sub btnimprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.ServerClick
        imprime()
    End Sub

    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub
    Private Sub imprime()
        Dim dsimprime As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        ldfecha2 = Date.Parse(Me.txtfecfin.Text)
        Dim clscartera As New ccreditos
        Dim ltodos As Boolean
        ltodos = True

        dsimprime = clscartera.ObtenerDataSetPorID()

        Try
            If dsimprime Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsimprime.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
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
            crRpt.Load(Server.MapPath("reportes") + "\crcartera.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsimprime.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
    End Sub

End Class
