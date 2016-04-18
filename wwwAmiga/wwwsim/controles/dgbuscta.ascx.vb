

Partial Class dgbuscta
    Inherits ucWBase

    Public Event Seleccionarcliente(ByVal ccodcli As String)
    Dim _URLCodigo As String
    Public Property URLcodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub
    Public Sub CargarDatosPorCliente(ByVal codcli As String)
        Dim mControl As New cClimide
        Dim mLista As New listaclimide
        mLista = mControl.ObtenerListaPorCliente(codcli)
        Me.BindGrid(mLista)
    End Sub

    Public Sub CargarDatosPorCliente_nombre(ByVal nombre As String)
        Dim mControl As New cClimide
        Dim mLista As New listaclimide
        mLista = mControl.ObtenerListaPorCliente(nombre)
        Me.BindGrid(mLista)
    End Sub

    Private Sub BindGrid(ByVal aLista As listaclimide)
        Me.dgdatos.DataSource = aLista
        Me.dgdatos.DataBind()
    End Sub

    Private Sub dgdatos_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
        If e.CommandName = "Select" Then
            RaiseEvent Seleccionarcliente(e.Item.Cells(1).Text)
        End If
    End Sub

    Private Sub dgdatos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgdatos.SelectedIndexChanged

    End Sub
End Class


