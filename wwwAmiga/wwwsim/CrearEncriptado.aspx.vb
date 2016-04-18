

Partial Class CrearEncriptado
    Inherits System.Web.UI.Page


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strClave As String
        strClave = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(clave.Text, "MD5")
        encriptado.InnerHtml = strClave
    End Sub
End Class


