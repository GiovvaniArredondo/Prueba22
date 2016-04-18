

Partial Class wfLogin
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Login1.Visible = True
            Me.cuwClave1.Visible = False
        End If
       

    End Sub

    Private Sub login1_Seleccionado(ByVal codigoCliente As String) Handles Login1.Seleccionado
        Change()
    End Sub
    Private Sub cuwClave1_Seleccionado(ByVal codigoCliente As String) Handles cuwClave1.Seleccionado
        Entrar()
    End Sub


    Public Sub Change()
        Me.Login1.Visible = False
        Me.cuwClave1.Visible = True
    End Sub
    Public Sub Entrar()
        Me.Login1.Visible = True
        Me.cuwClave1.Visible = False
    End Sub

End Class


