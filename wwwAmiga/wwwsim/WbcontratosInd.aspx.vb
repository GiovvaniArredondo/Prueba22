
Partial Class WbcontratosInd
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            wucfindcligru1.Visible = True
            Me.WbUContratos1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            wucfindcligru1.Visible = True
            Me.WbUContratos1.Visible = False

        End If
        If TabStrip1.SelectedIndex = 1 Then
            wucfindcligru1.Visible = False
            Me.WbUContratos1.Visible = True
        End If
    End Sub

    Private Sub WbFindtodos1_Seleccionado(ByVal codigoCliente As String) Handles wucfindcligru1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.WbUContratos1.CargarPorCliente(codigoCliente)
    End Sub
End Class
