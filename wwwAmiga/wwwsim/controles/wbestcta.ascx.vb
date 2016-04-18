

Partial Class wbestcta
    Inherits ucWBase

    Private ccodcta As String

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        ccodcta = ViewState("ccodcta")
    End Sub

    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.DgCreditos1.Visible = True
            Me.DgHistorialCreditos1.Visible = False
            Me.DgKardex1.Visible = False
            Return
        End If
        If Me.ccodcta = "" And TabStrip1.SelectedIndex > 0 Then
            TabStrip1.SelectedIndex = 0
            Return
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.DgCreditos1.Visible = False
            Me.DgHistorialCreditos1.Visible = True
            Me.DgKardex1.Visible = False
            Me.DgHistorialCreditos1.CargarDatosPorCuenta(Me.ccodcta)
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.DgCreditos1.Visible = False
            Me.DgHistorialCreditos1.Visible = False
            Me.DgKardex1.Visible = True
            Me.DgKardex1.CargarDatosPorCuenta(Me.ccodcta)
        End If

    End Sub

    Private Sub btnBuscar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.ServerClick
        If Me.txtCodCta.Text <> "" Then
            Me.DgCreditos1.CargarDatosPorCuenta(Me.txtCodCta.Text)
            Return
        End If
        If Me.txtCodCli.Text <> "" Then
            Me.DgCreditos1.CargarDatosPorCliente(Me.txtCodCli.Text)
            Return
        End If
    End Sub

    Private Sub DgCreditos1_SeleccionarCuenta(ByVal codcta As String) Handles DgCreditos1.SeleccionarCuenta
        If ViewState("ccodcta") Is Nothing Then
            ViewState.Add("ccodcta", codcta)
        Else
            ViewState("ccodcta") = codcta
        End If
        '        Me.txtcliente.Text = viewstate("ccodcta")
    End Sub
End Class


