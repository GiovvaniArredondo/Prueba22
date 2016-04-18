Public Class dgKardex
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents dgDatos As System.Web.UI.WebControls.DataGrid

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
    End Sub

    Public Sub CargarDatosPorCuenta(ByVal codcta As String)
        Dim mControl As New cCredkar
        Dim mLista As New listacredkar
        mLista = mControl.ObtenerListaPorCuenta(codcta)
        Me.BindGrid(mLista)
    End Sub

    Private Sub BindGrid(ByVal aLista As listacredkar)
        Me.dgDatos.DataSource = aLista
        Me.dgDatos.DataBind()
    End Sub

End Class
