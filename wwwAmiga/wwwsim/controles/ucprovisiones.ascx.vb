

Partial Class ucprovisiones
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub

    Private Sub btnaportaciones_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaportaciones.ServerClick
        Response.Redirect("ucprovaporta.ascx")
    End Sub

    Private Sub btncertificados_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncertificados.ServerClick
        Response.Redirect("ucprovpla.asx")
        Response.Redirect("ucprovpla.ascx")

    End Sub
End Class


