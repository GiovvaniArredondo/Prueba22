

Partial Class wbreferencia
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim clsppal As New class1
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "INR", 2)
        End If

    End Sub

End Class


