Partial Class WbFindActivoF
    Inherits ucWBase
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
    Private ds As New System.Data.DataSet
    Private lbsim As New SIM.BL.ClsMantenimiento
    Private lbsim1 As New SIM.BL.class1
    Private Transacc As String
    Private clsCli As New SIM.BL.ClsFindCli
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)
    Private eClimide As New SIM.BL.cClimide

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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me._ClienteSeleccionado = Me.ViewState("ClienteSeleccionado")
    End Sub

    Private Sub dgClientes_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgActivos.PageIndexChanged
        If Me.IsPostBack Then
            Me.dgActivos.CurrentPageIndex = 0
            Me.dgActivos.CurrentPageIndex = e.NewPageIndex
        End If
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim cvariable As String
        Dim cvalor As Integer
        Dim dfecha As Date
        Dim ds As New DataSet
        Dim clsfind As New cActivoF
        Dim i As Integer

        If Me.rdbbusqueda.SelectedIndex = 0 Then
            'Buscqueda por descripcion
            cvalor = 1
        ElseIf Me.rdbbusqueda.SelectedIndex = 1 Then
            'Buscqueda por numero de inventario
            cvalor = 2
        ElseIf Me.rdbbusqueda.SelectedIndex = 2 Then
            'Buscqueda por numero de factura
            cvalor = 3
        ElseIf Me.rdbbusqueda.SelectedIndex = 3 Then
            'Buscqueda por fecha
            cvalor = 4
            dfecha = CDate(TxtNombre.Text.Trim)
        End If

        cvariable = TxtNombre.Text.Trim.ToUpper
        ds = clsfind.BuscaInventario(cvariable, cvalor, dfecha)

        i = ds.Tables(0).Rows.Count

        If i = 0 Then
            Response.Write("<script language='javascript'>alert('Consulta Vacía')</script>")
            Me.dgActivos.DataSource = ds
            Me.dgActivos.DataBind()
        Else
            Me.dgActivos.DataSource = ds
            Me.dgActivos.DataBind()
        End If
    End Sub

    Private Sub dgClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgActivos.SelectedIndexChanged
        ClienteSeleccionado = CType(Me.dgActivos.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text.Trim
        RaiseEvent Seleccionado(ClienteSeleccionado)
    End Sub
End Class





