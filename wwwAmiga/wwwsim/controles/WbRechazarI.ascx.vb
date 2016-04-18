Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class WbRechazarI
    Inherits System.Web.UI.UserControl
    Private cls1 As New SIM.BL.ClsMantenimiento
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
            CargaCombos()
        End If


    End Sub

    Private Sub CargaCombos()
        'Variable de la clase Mantenimiento
        Dim lnparametro1_R As String
        Dim lnparametro2_R As String
        Dim lnparametro3_R As String
        Dim lnparametro4_R As String
        Dim lnparametro5_R As String
        Dim lnparametro6_R As String
        Dim Transacc As String


        Dim ds As New DataSet
        '*************causas de rechazo*****************
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab  ='156' and cTipReg = '1' order by ccodigo "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'Response.Write("<script language='javascript'>alert('No existen operaciones')</script>")
            Exit Sub
        End If

        Me.ddlcausa.DataTextField = "cDescri"
        Me.ddlcausa.DataValueField = "cCodigo"
        Me.ddlcausa.DataSource = ds.Tables("resultado")
        Me.ddlcausa.DataBind()

        ds.Tables("Resultado").Clear()

    End Sub

    Public Sub CargarDatosPorCuenta(ByVal codigoCliente As String)
        Me.txtcodcli.Value = codigoCliente
        
        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.txtcodcli.Value.Trim
        eClimide.ObtenerClimide(entidadClimide)
        Me.txtcnomcli.Text = entidadClimide.cnomcli.Trim


        Me.Button1.Enabled = True
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Verificar si tiene creditos vigente

        Dim ecremcre As New cCremcre
        Dim lvalida As Boolean
        lvalida = ecremcre.ObtieneCreditosCliente(txtcodcli.Value.Trim)
        If lvalida = True Then 'tiene solicitudes pendientes
            Response.Write("<script language='javascript'>alert('Cliente Tiene Solicitud o Credito, Verifique ')</script>")
            Me.Button1.Enabled = False
            Return
        Else
            Me.Button1.Enabled = True
        End If

        'Actualiza cCodrec con el codigo de la causa

        Dim eclimide As New cClimide
        Dim i As Integer = 0
        Try
            i = eclimide.ActualizaCodigoRechazo(Me.txtcodcli.Value.Trim, Me.ddlcausa.SelectedValue.Trim, Session("gccodusu"), Session("gdfecsis"))
            Response.Write("<script language='javascript'>alert('Rechazado Grabado ')</script>")
            Me.Button1.Enabled = False

            Dim ds As New DataSet
            Dim etabttab As New cTabttab

            ds = etabttab.ObtenerDataSetPorID("156", "1")
            Dim fila As DataRow
            Dim lccodigo As String
            Dim lccodrec As String = Me.ddlcausa.SelectedValue.Trim
            For Each fila In ds.Tables(0).Rows
                lccodigo = fila("ccodigo")
                If lccodigo.Trim = lccodrec.Trim Then
                    fila("cflag") = "X"
                Else
                    fila("cflag") = " "
                End If
            Next
            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If
            imprimir(ds, "crpRechazo.rpt")

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Problemas al Grabar, Consulte con Administrador ')</script>")
        End Try
    End Sub
    Public Sub imprimir(ByVal ds As DataSet, ByVal reporte As String)
        Dim lcnomofi As String = ""
        Dim etabtofi As New cTabtofi
        lcnomofi = etabtofi.NombreAgencia(Left(txtcodcli.Value.Trim, 3))


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        crRpt.Load(Server.MapPath("reportes") + "\" + reporte, OpenReportMethod.OpenReportByDefault)

        crRpt.SetDataSource(ds.Tables(0))
        crRpt.SetParameterValue("cnomcli", txtcnomcli.Text.Trim)
        crRpt.SetParameterValue("ccodcli", txtcodcli.Value.Trim)
        crRpt.SetParameterValue("dfecsis", Session("gdfecsis"))
        crRpt.SetParameterValue("cnomofi", lcnomofi.Trim)

        Dim reportes As String
        reportes = "crpRechazo.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
        '        Response.End()
        Response.CacheControl = "Private"

    End Sub

End Class
