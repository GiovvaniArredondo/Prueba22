Public Class ucbuslin
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtNombre As System.Web.UI.WebControls.TextBox
    Protected WithEvents dgClientes As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btnAdiciona As System.Web.UI.HtmlControls.HtmlInputButton

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region
    Private Transacc As String
    Private _URLCodigo As String
    Private _lineaSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)

    Public Property lineaSeleccionado() As String
        Get
            Return _lineaSeleccionado
        End Get
        Set(ByVal Value As String)
            _lineaSeleccionado = Value
            If ViewState("numlinea") Is Nothing Then
                ViewState.Add("numlinea", Value)
            Else
                ViewState("numlinea") = Value
            End If
        End Set
    End Property

    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            Me.Cargardatos()
        End If
        Me._lineaSeleccionado = Me.ViewState("numlinea")
    End Sub

    'carga elementos necesarios para la linea
    Private Sub Cargardatos()
        Dim mControl As New cCretlin
        Dim mLista As New listacretlin
        Dim mEntidad As New cretlin
        mLista = mControl.ObtenerLista()
        Me.dgClientes.DataSource = mLista
        Me.dgClientes.DataBind()
    End Sub

    Private Sub DtGriduser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Response.Redirect("wblineas.aspx?id=0")
    End Sub

    Private Sub dgClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgClientes.SelectedIndexChanged
        '        RaiseEvent Seleccionado(CType(Me.dgClientes.SelectedItem.DataItem.DataItem, DataRowView).Row.ItemArray(0).ToString())
        lineaSeleccionado = CType(Me.dgClientes.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        RaiseEvent Seleccionado(lineaSeleccionado)
    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub Button2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.ServerClick
        Dim mControl As New cCretlin
        Dim mLista As New listacretlin
        Dim mEntidad As New cretlin
        Dim linea As String
        linea = Me.TxtNombre.Text.Trim
        mLista = mControl.ObtenerListaPorLinea(linea)
        Me.dgClientes.DataSource = mLista
        Me.dgClientes.DataBind()
    End Sub

    Private Sub btnAdiciona_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdiciona.ServerClick
        lineaSeleccionado = "0000000"
        RaiseEvent Seleccionado(lineaSeleccionado)
    End Sub
End Class
