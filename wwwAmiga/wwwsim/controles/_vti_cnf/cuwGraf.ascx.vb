Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class cuwGraf
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents rbtnAntiguedad As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnGenero As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RbtnGeneroC As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnCliOfi As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnCarOfi As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnDesCre As System.Web.UI.WebControls.RadioButton
    Protected WithEvents btnProcesar As System.Web.UI.HtmlControls.HtmlInputButton

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
    Private clsreportes As New SIM.BL.ClsRepGraf
    Private dsG As New DataSet
#End Region

#Region "Metodos"
    Public Sub Imprimir(ByVal NomRep As String, ByVal ds_Rep As DataSet)
        
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("Reportes") + "\" & NomRep, OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        Dim ds1 As New DataSet
        Dim nCanti As Integer
        crRpt.SetDataSource(ds_Rep.Tables(0))

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
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub

    Private Sub btnProcesar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.ServerClick
        Dim lcNomRep As String
        dsG.Tables.Clear()
        If Me.rbtnAntiguedad.Checked = True Then
            dsG = Me.clsreportes.Antiguedad()
            lcNomRep = "CrGAntMor.rpt"
        ElseIf Me.rbtnGenero.Checked = True Then
            dsG = Me.clsreportes.PorGenero()
            lcNomRep = "CrGGenero.rpt"
        ElseIf Me.RbtnGeneroC.Checked = True Then
            dsG = Me.clsreportes.PorGenero()
            lcNomRep = "CrGGenCar.rpt"
        ElseIf Me.rbtnCliOfi.Checked = True Then
            dsG = Me.clsreportes.PorOficina()
            lcNomRep = "CrGOfi.rpt"
        ElseIf Me.rbtnCarOfi.Checked = True Then
            dsG = Me.clsreportes.PorOficina()
            lcNomRep = "crGSalOfi.rpt"
        ElseIf Me.rbtnDesCre.Checked = True Then
            dsG = Me.clsreportes.PorDestino()
            lcNomRep = "crGDes.rpt"
        End If

        If dsG.Tables(0).Rows.Count = 0 Then
            Response.Write("<script language='javascript'>alert('No Hay Datos')</script>")
        Else
            Me.Imprimir(lcNomRep, dsG)
        End If
    End Sub
End Class
