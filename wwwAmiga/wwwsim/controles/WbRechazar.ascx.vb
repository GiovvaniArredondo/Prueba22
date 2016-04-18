Public Class WbRechazar
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
        lnparametro6_R = "Where cCodTab  ='042' and cTipReg = '1' order by cdescri "
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
        Dim ecremcre As New cCremcre
        Dim lvalida As Boolean
        lvalida = ecremcre.ObtieneSolicitudPendiente(codigoCliente)
        If lvalida = False Then 'tiene solicitudes pendientes
            Response.Write("<script language='javascript'>alert('Cliente NO tiene Solicitud Pendiente ')</script>")
            Return
        End If
        Dim entidadcremcre As New cremcre
        entidadcremcre.ccodcta = codigoCliente
        ecremcre.ObtenerCremcre(entidadcremcre)
        Me.txtcodcli.Value = entidadcremcre.ccodcli


        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.txtcodcli.Value.Trim
        eClimide.ObtenerClimide(entidadClimide)
        Me.txtcnomcli.Text = entidadClimide.cnomcli.Trim

        Me.txtccodcta.Value = codigoCliente
        Me.Button1.Enabled = True
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Actualiza cCodrec con el codigo de la causa
        Dim ecremcre As New cCremcre
        Dim ldfecha As Date

        ldfecha = Session("gdfecsis")
        Dim i As Integer = 0
        Try
            i = ecremcre.ActualizaCodigoRechazo(Me.txtccodcta.Value.Trim, Me.ddlcausa.SelectedValue.Trim, Session("gccodusu"), ldfecha)
            Response.Write("<script language='javascript'>alert('Rechazado Grabado ')</script>")
            Me.Button1.Enabled = False
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Problemas al Grabar, Consulte con Administrador ')</script>")
        End Try
    End Sub
End Class
