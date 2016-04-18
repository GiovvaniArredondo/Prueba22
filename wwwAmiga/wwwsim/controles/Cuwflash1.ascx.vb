

Partial Class Cuwflash1
    Inherits ucWBase


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarMensaje()
        End If
    End Sub
    Private Sub CargarMensaje()
        Dim ecreditos As New ccreditos
        Me.Label1.Text = "NOTICIA DEL DIA: " & ecreditos.mensaje
    End Sub

End Class


