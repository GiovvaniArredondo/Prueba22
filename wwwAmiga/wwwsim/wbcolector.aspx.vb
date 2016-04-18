

Partial Class wbcolector
    Inherits System.Web.UI.Page

    'Protected WithEvents CUWPlan1 As CuwPlan
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.wucfindcligru11.Visible = True
            Me.Uccolector11.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.Uccolector11.Visible = False
            Me.wucfindcligru11.Visible = True
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.Uccolector11.Visible = True
            Me.wucfindcligru11.Visible = False
        End If

    End Sub

    Private Sub wucfindcligru11_Seleccionado(ByVal codigoCliente As String) Handles wucfindcligru11.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Uccolector11.CargarPorCliente(codigoCliente)
    End Sub

End Class


