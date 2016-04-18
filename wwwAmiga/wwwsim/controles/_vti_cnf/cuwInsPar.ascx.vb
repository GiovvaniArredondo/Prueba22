Public Class cuwInsPar
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents txtdfecini As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtdfecfin As System.Web.UI.WebControls.TextBox
    Protected WithEvents dgVerifica As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
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

        ds = eCntaprm.ObtenerDataSetPorID()
        ncanti = ds.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If
        Me.txtdfecini.Text = ds.Tables(0).Rows(0)("dFecimes")
        Me.txtdfecfin.Text = ds.Tables(0).Rows(0)("dFecfmes")
        Me.Label4.Visible = False
        Me.Label4.Text = ""
    End Sub

    Private Sub ibtnprocesar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ibtnprocesar.ServerClick
        Me.Label4.Visible = False
        Me.Label4.Text = ""

        Dim classconta As New clsConta
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.dFecIni = Me.txtdfecini.Text
        Dim dsa As New DataSet
        Dim i As Integer
        dsa = classconta.Inspeccion()
        i = dsa.Tables(0).Rows.Count
        If i = 0 Then
            Me.Label4.Visible = True
            Me.Label4.Text = "No Existen Incosistencias"
            Exit Sub
        End If
        Me.dgVerifica.DataSource = dsa
        Me.dgVerifica.DataBind()
    End Sub
End Class
