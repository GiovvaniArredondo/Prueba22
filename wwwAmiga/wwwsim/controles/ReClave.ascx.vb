
Partial Class ReClave
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
    Sub validarContraseña()
        Dim miLogin As New cLogin
        Dim lcmensaje As String
        Dim sys As New System.Security.Cryptography.SHA1CryptoServiceProvider

        If miLogin.ValidarUsuario(Session("gcCodusu"), Convert.ToBase64String(sys.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Me.TextBox1.Text)))) Then
            'Verifica fecha de vencimiento de clave

            lcmensaje = "Clave validada"
        Else
            lcmensaje = "Clave invalida"
        End If

    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        validarContraseña()
    End Sub
End Class
