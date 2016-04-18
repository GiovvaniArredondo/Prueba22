

Partial Class WUsFindFia
    Inherits ucWBase

#Region " Variables "
    Private clsCli As New SIM.BL.ClsFindCli
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event Codeudor(ByVal codigoCliente As String)
    Private codigoJs As String
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


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub

    Protected Sub dgclientes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgClientes.SelectedIndexChanged
        Dim asociado As String = dgClientes.SelectedRow.Cells(1).Text.ToString 'asociado
        RaiseEvent Codeudor(asociado)

    End Sub
    Protected Sub dgclientes_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dgclientes.PageIndexChanging
        If Me.IsPostBack Then
            Me.dgclientes.PageIndex = 0
            Me.dgclientes.PageIndex = e.NewPageIndex
            Me.Cargardatos() 'este sería el procedimiento que se encarga de llenar tu datagrid.
        End If

    End Sub
    Private Sub btnfind_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.ServerClick
        Me.dgclientes.PageIndex = 0
        Cargardatos()

    End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged
        Me.btnfind_ServerClick(sender, e)
    End Sub
    Private Sub Cargardatos()
        Dim i As Integer
        Dim ds As New DataSet

        ds = clsCli.BuscaCliente(Me.TxtNombre.Text.Trim, Session("gnNivel"), Session("gcCodOfi"))

        i = ds.Tables(0).Rows.Count()

        If i >= 1 Then
            dgclientes.Visible = True
            Me.dgclientes.DataSource = ds.Tables(0)
            Me.dgclientes.DataBind()
        Else
            dgclientes.Visible = False
            ' Response.Write("<script language='javascript'>alert('EL Cliente no Existe')</script>")
            codigoJs = "<script language='javascript'>alert('EL Cliente no Existe, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End If
    End Sub
End Class


