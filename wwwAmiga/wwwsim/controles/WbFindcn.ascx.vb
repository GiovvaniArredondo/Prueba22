Public Class WbFindcn
    Inherits System.Web.UI.UserControl

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
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
    Private ds As New System.Data.DataSet
    Private lbsim As New SIM.bl.ClsMantenimiento
    Private lbsim1 As New SIM.BL.class1

    Private Transacc As String
    Private clsCli As New SIM.BL.ClsFindCli
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Cargardatos()
            ViewState.Add("pagina", 1)
        End If
        Me._ClienteSeleccionado = Me.ViewState("ClienteSeleccionado")
    End Sub

    

#Region " Metodos de la Pagina "
    Private Sub Cargardatos()
        'lnparametro1_R = "ccodcli as Codigo,cnomcli,"
        'lnparametro4_R = "Climide"
        'lnparametro5_R = "S"


        'lnparametro6_R = " "


        'Transacc = "Select Climide.ccodcli As Codigo, CLIMIDE.cNomCli FROM CLIMIDE "


        'ds = lbsim.ResulSelect(Transacc)
        Dim ecremsol As New cCremsol
        ds = ecremsol.ObtenerDataSetCentros()

        Me.dgClientes.DataSource = ds.Tables(0)
        Me.dgClientes.DataBind()

        ds.Tables.Clear()

        '------------------------------------
        


    End Sub

#End Region


    Private Sub dgClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgClientes.SelectedIndexChanged
        ClienteSeleccionado = CType(Me.dgClientes.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        RaiseEvent Seleccionado(ClienteSeleccionado)

    End Sub

    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        Dim i As Integer
        ds = clsCli.BuscaCentros(Me.TxtNombre.Text.Trim)
        i = ds.Tables(0).Rows.Count()
        If i >= 1 Then
            Me.dgClientes.DataSource = ds.Tables(0)
            Me.dgClientes.DataBind()
        Else
            Response.Write("<script language='javascript'>alert('EL Grupo no Existe')</script>")
        End If
    End Sub

    Private Sub dgClientes_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgClientes.PageIndexChanged

        If Me.IsPostBack Then

            Me.dgClientes.CurrentPageIndex = 0

            Me.dgClientes.CurrentPageIndex = e.NewPageIndex

            Me.Cargardatos() 'este sería el procedimiento que se encarga de llenar tu datagrid.

        End If



    End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged
        Me.Button1_ServerClick(sender, e)
    End Sub
End Class



