

Partial Class ucMensajePrueba
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mControl As New crefunc
        Dim LCCTACTB As String
        LCCTACTB = mControl.fxcuentacontable("001001011000000001", "0000100", "N", "IN", "C", "N", "C", "01", 23.9, 0, 0)
        If LCCTACTB <> "" Or LCCTACTB Is Nothing Then
            Me.AsignarMensaje(LCCTACTB + ". Por Favor contactar a Soporte Tecnico.", True, True)
        Else
            Me.AsignarMensaje("Proceso guardado satisfactoriamente", , True)

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mControl As New crefunc
        Dim LCCTACTB As String
        LCCTACTB = mControl.fxcuentacontable("001001011000000001", "0000100", "N", "IN", "C", "N", "C", "01", 23.9, 0, 0)
        If LCCTACTB <> "" Or LCCTACTB Is Nothing Then
            Response.Write("<script language='javascript'>alert('" & LCCTACTB & ". Por Favor contactar a Soporte Tecnico.')</script>")
        Else
            Response.Write("<script language='javascript'>alert('Proceso guardado satisfactoriamente.')</script>")
        End If
    End Sub

End Class


