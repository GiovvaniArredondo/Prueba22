Public Class dgCreditos
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents dgCred As System.Web.UI.WebControls.DataGrid

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Public Event SeleccionarCuenta(ByVal codcta As String)

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub

    Public Sub CargarDatosPorCliente(ByVal codcli As String)
        Dim mControl As New cCremcre
        Dim mLista As New listacremcre
        mLista = mControl.ObtenerLista()
        Me.BindGrid(mLista)
    End Sub

    Public Sub CargarDatosPorCuenta(ByVal codcta As String)
        Dim mControl As New cCremcre
        Dim mLista As New listacremcre
        Dim mEntidad As New cremcre
        mEntidad.ccodcta = codcta
        mControl.ObtenerCremcre(mEntidad)
        mLista.Add(mEntidad)
        Me.BindGrid(mLista)
    End Sub

    Private Sub BindGrid(ByVal aLista As listacremcre)
        Me.dgCred.DataSource = aLista
        Me.dgCred.DataBind()
    End Sub

    Private Sub dgCred_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCred.ItemCommand
        If e.CommandName = "Select" Then
            RaiseEvent SeleccionarCuenta(e.Item.Cells(1).Text)
        End If
    End Sub

End Class
