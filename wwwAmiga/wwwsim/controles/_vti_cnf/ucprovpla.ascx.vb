Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web


Public Class ucprovpla
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents txtultpro As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtproact As System.Web.UI.WebControls.TextBox
    Protected WithEvents label_mensaje As System.Web.UI.WebControls.Label
    Protected WithEvents btnaplicar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents RangeValidator5 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents RangeValidator1 As System.Web.UI.WebControls.RangeValidator

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

    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub


    Sub cargar()
        Dim lccodofi As String
        Dim clsprovision As New cprovisiones
        Dim lista As New listaahompro2
        Dim ldfecha As Date
        Dim ldproact As Date
        Dim ldultpro As Date

        lccodofi = Session("gccodofi")
        ldfecha = #1/1/1900#
        ldproact = Session("gdfecsis")

        Dim mahompro As New cAhompro2
        Dim eahompro As New ahompro2
        lista = mahompro.ObtenerLista()
        ldultpro = Session("gdfecsis")
        'recorre para obtener el maximo
        For Each eahompro In lista
            If eahompro.dultpro > ldfecha Then
                ldfecha = eahompro.dultpro
            End If
        Next
        If ldfecha <> #1/1/1900# Then
            ldultpro = ldfecha
        End If
        If ldultpro >= ldproact Then
            Response.Write("<script language='javascript'>alert('La ultima provision es mayor que provision actual')</script>")
            Exit Sub

            '            ldproact = Date.Parse(ldultpro.ToOADate + 1)
        End If

        Me.txtultpro.Text = ldultpro
        Me.txtproact.Text = ldproact

    End Sub
    Sub cargarfechas()
        Dim ldultpro As Date
        Dim ldproact As Date
        Dim lccodofi As String
        Dim clsprovision As New cprovisiones
        lccodofi = Session("gccodofi")

        ldultpro = Date.Parse(Me.txtultpro.Text)
        ldproact = Date.Parse(Me.txtproact.Text)

        Me.txtultpro.Text = ldultpro
        Me.txtproact.Text = ldproact

        clsprovision.dultpro = ldultpro
        clsprovision.proact = ldproact
        clsprovision.gccodofi = lccodofi
        clsprovision.provision_certificados()

    End Sub

    Private Sub imprime_recibo()

        Dim ds1 As New DataSet
        Dim cls1 As New cAhomint
        Dim ldfecha As Date
        ldfecha = Date.Parse(Me.txtproact.Text)
        ds1 = cls1.ObtenerDataSetPorfecha(ldfecha)

        Try
            If ds1 Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If ds1.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("No hay datos")
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
            crRpt.Load(Server.MapPath("reportes") + "\crintpla.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
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

    End Sub


    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick

        Try
            cargarfechas()
            Response.Write("<script language='javascript'>alert('ok')</script>")
            imprime_recibo()

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Provisión no se pudo completar')</script>")

        End Try

    End Sub
End Class
