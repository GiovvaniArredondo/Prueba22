Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class cuwLibDMay
    Inherits System.Web.UI.UserControl
#Region "Variables"
    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
    Private Transacc As String
    Private cls1 As New SIM.BL.ClsMantenimiento
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            CargarDatos()
        End If
    End Sub
    Private Sub CargarDatos()
        Dim entidadCntaprm As New SIM.EL.cntaprm
        Dim eCntaprm As New SIM.BL.cCntaprm
        Dim ds As New DataSet
        Dim ncanti As Integer

        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

        ds = eCntaprm.ObtenerDataSetPorID(Session("gcfondo"), lccadena)
        ncanti = ds.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If
        Me.txtdfecini.Text = ds.Tables(0).Rows(0)("dFecimes")
        Me.txtdfecfin.Text = ds.Tables(0).Rows(0)("dFecfmes")

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab1 As New listatabttab
        mListaTabttab1 = clstabttab.ObtenerLista("033", "1")
        'Fondos
        Me.cbxfondos.DataTextField = "cdescri"
        Me.cbxfondos.DataValueField = "ccodigo"
        Me.cbxfondos.DataSource = mListaTabttab1
        Me.cbxfondos.DataBind()

        Me.txtdesde.Text = ""
        Me.txthasta.Text = ""
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        lnparametro1_R = "cNomOfi , cCodOfi, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTOFI"
        lnparametro5_R = "S"
        lnparametro6_R = " "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If


        Me.CbxCodOFi.DataTextField = "cNomOfi"
        Me.CbxCodOFi.DataValueField = "cCodOfi"
        Me.CbxCodOFi.DataSource = ds.Tables("Resultado")
        Me.CbxCodOFi.DataBind()


        'Me.CbxCodOFi.DropDownWidth = 300
        ds.Tables("Resultado").Clear()

    End Sub


    Private Sub btnprocesar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocesar.ServerClick
        Dim dsLDMay As New DataSet
        Dim classconta As New clsConta
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.dFecIni = Me.txtdfecini.Text

        classconta.cDesde = Me.txtdesde.Text.Trim
        classconta.cHasta = Me.txthasta.text.trim

        dsLDMay = classconta.Librodiariomayor()
      
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\crLibro1.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsLDMay.Tables(0))
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
