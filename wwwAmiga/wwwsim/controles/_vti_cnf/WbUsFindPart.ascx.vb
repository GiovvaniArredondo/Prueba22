Public Class WbUsFindPart
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DgPartidas As System.Web.UI.WebControls.DataGrid
    Protected WithEvents RdBFind1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RdBFind2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Txtdescri As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents btnfind As System.Web.UI.HtmlControls.HtmlInputButton

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
    Private cClsPart As New SIM.BL.ClsBusCatal
    Private ds As New DataSet
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event CargarPartida(ByVal codigoCliente As String)

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RdBFind1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBFind1.CheckedChanged
        If Me.RdBFind1.Checked = True Then
            Me.RdBFind2.Checked = False
        End If
    End Sub

    Private Sub RdBFind2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBFind2.CheckedChanged
        If Me.RdBFind2.Checked = True Then
            Me.RdBFind1.Checked = False
        End If
    End Sub


    Private Sub DgPartidas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DgPartidas.SelectedIndexChanged
        ClienteSeleccionado = CType(Me.DgPartidas.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        RaiseEvent CargarPartida(ClienteSeleccionado)
    End Sub

    Private Sub btnfind_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.ServerClick
        If Me.RdBFind1.Checked = True Then
            ds = cClsPart.BuscaPartidaNo(Me.Txtdescri.Text.Trim)  'No de Partida
        Else
            ds = cClsPart.BuscaPartidaDes(Me.Txtdescri.Text.Trim) 'Descripcion
        End If

        Me.RdBFind1.Checked = False
        Me.RdBFind2.Checked = False
        Me.Txtdescri.Text = " "

        Me.DgPartidas.DataSource = ds
        Me.DgPartidas.DataBind()

    End Sub
End Class
