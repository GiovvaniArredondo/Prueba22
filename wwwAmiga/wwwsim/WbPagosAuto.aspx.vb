
Partial Class WbPagosAuto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.WbUCPagosAuto1.Inicio()
        End If
    End Sub
End Class
