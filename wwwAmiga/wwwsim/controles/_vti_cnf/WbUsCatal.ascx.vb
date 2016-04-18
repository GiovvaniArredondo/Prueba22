Public Class WbUsCatal
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Rdbcuenta As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RdbDescrip As System.Web.UI.WebControls.RadioButton
    Protected WithEvents TxtDescri As System.Web.UI.WebControls.TextBox
    Protected WithEvents DgCatalogo As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.HtmlControls.HtmlInputButton

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
    Private cClsCat As New SIM.BL.ClsBusCatal
    Private ds As New DataSet
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event CargarCuenta(ByVal codigoCliente As String)

#End Region

#Region " Propiedades "

    Public Property ClienteSeleccionado() As String
        Get
            Return _ClienteSeleccionado
        End Get
        Set(ByVal Value As String)
            _ClienteSeleccionado = Value
            If ViewState("ClienteSeleccionado") Is Nothing Then
                ViewState.Add("ClienteSeleccionado", Value)
            Else
                ViewState("ClienteSeleccionado") = Value
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

#End Region

#Region "Metodos"
    Public Function Catalogo() As DataSet

        'cClsCat._cValor = Me.TxtDescri.Text.Trim
        ds = cClsCat.Catalogo()
        Me.DgCatalogo.DataSource = ds
        Me.DgCatalogo.DataBind()
        Me.Rdbcuenta.Checked = True
        'ds.Clear()
    End Function


#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            'Dim lId As String = Request.QueryString("id")
            'Me.txtcodcli.Value = lId
            Me.Catalogo()


        End If

    End Sub


    
    Private Sub Rdbcuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdbcuenta.CheckedChanged
        Me.RdbDescrip.Checked = False
    End Sub

    Private Sub RdbDescrip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbDescrip.CheckedChanged
        Me.Rdbcuenta.Checked = False
    End Sub

    Private Sub DgCatalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DgCatalogo.SelectedIndexChanged
        ClienteSeleccionado = CType(Me.DgCatalogo.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        RaiseEvent CargarCuenta(ClienteSeleccionado)
    End Sub

    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        cClsCat._cValor = Me.TxtDescri.Text.Trim


        If Me.RdbDescrip.Checked = True Then
            cClsCat._llBandera = True     'Descripcion
        Else
            cClsCat._llBandera = False    ' Cuenta  
        End If

        ds = cClsCat.BuscaCatalogo()

        Me.DgCatalogo.DataSource = ds
        Me.DgCatalogo.DataBind()

        ds.Clear()


        Me.TxtDescri.Text = " "

    End Sub
End Class
