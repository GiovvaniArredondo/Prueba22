

Partial Class WbBancos
    Inherits System.Web.UI.Page

    'Protected WithEvents CUWPlan1 As CuwPlan
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.cuwbancos1.Visible = True
        End If
    End Sub
End Class


