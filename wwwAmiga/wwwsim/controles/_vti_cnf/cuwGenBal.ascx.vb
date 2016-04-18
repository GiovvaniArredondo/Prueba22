Public Class cuwGenBal
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents txtMesPro As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents txtdfecini As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents txtdfecfin As System.Web.UI.WebControls.TextBox
    Protected WithEvents ibtnprocesar As System.Web.UI.HtmlControls.HtmlInputButton

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
        CargarDatos()
        'Introducir aquí el código de usuario para inicializar la página
    End Sub
    Private Sub CargarDatos()
        Dim entidadCntaprm As New SIM.EL.cntaprm
        Dim eCntaprm As New SIM.BL.cCntaprm
        Dim ds As New DataSet
        Dim ncanti As Integer

        ds = eCntaprm.ObtenerDataSetPorID()
        ncanti = ds.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Me.ibtnprocesar.Disabled = True
            Exit Sub
        Else
            Me.ibtnprocesar.Disabled = False
        End If
        Me.txtMesPro.Text = ds.Tables(0).Rows(0)("cMesVig")
        Me.txtdfecini.Text = ds.Tables(0).Rows(0)("dFecimes")
        Me.txtdfecfin.Text = ds.Tables(0).Rows(0)("dFecfmes")
    End Sub

    
    Private Sub ibtnprocesar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ibtnprocesar.ServerClick
        Dim claseconta As New clsConta
        Dim entidadcntabal As New SIM.EL.cntabal
        Dim ecntabal As New SIM.BL.cCntabal
        'Eliminar Contenido de CNTABAL
        ecntabal.EliminarCntabal()
        'Agrega Contenido de Catalogo a CNTABAL

        claseconta.cCodofi = Session("gcCodOfi")
        claseconta.cCodUsu = Session("gcCodUsu")
        claseconta.dfecmes = Me.txtMesPro.Text.Trim
        claseconta.AgregarCNTABAL()

        'CalCular Saldos Para Cuentas de Detalle
        claseconta.dFecIni = CDate(Me.txtdfecini.Text.Trim)
        claseconta.dFecfin = CDate(Me.txtdfecfin.Text.Trim)
        claseconta.CtaDetalle()
        claseconta.CtaResumen()
        Response.Write("<script language='javascript'>alert('Proceso Correcto')</script>")

    End Sub
End Class
