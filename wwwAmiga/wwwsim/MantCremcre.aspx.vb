

Partial Class MantCremcre
    Inherits System.Web.UI.Page
 
    Private mComponente As New cCremcre
 
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Page.IsPostBack Then
            Me.BarraNavegacion1.Navegacion = False
            Me.BarraNavegacion1.PermitirEditar = False
            Me.BarraNavegacion1.PermitirGuardar = False
            CargarDatos()
        End If
    End Sub
 
    Private Sub CargarDatos()
        Dim lCremcre As listaCremcre
        Dim sError As New String("")
        lCremcre = Me.mComponente.ObtenerLista()
        Me.dgLista.DataSource = lCremcre
        Me.dgLista.DataBind()
    End Sub
 
    Private Sub dgLista_ItemDataBound(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgLista.ItemDataBound
        If e.Item.ItemType = ListItemType.AlternatingItem Or _
           e.Item.ItemType = ListItemType.Item Then
            Dim a As LinkButton = CType(e.Item.FindControl("LinkButton1"), LinkButton)
            a.Attributes.Add("onclick", "if(!window.confirm('¿Esta seguro de Eliminar el Registro?')){return false;}")
        End If
    End Sub
 
    Private Sub dgLista_DeleteCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgLista.DeleteCommand
        If Me.mComponente.EliminarCremcre(CLng(CType(Me.dgLista.Items(e.Item.ItemIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) = 0 Then
            'Si se cometio un error
        Else
            Me.CargarDatos()
        End If
    End Sub
 
    Private Sub BarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraNavegacion1.Agregar
        Response.Redirect("DetaMantCremcre.aspx?id=0")
    End Sub
 
End Class


