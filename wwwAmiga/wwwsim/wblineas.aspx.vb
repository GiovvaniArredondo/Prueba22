

Partial Class wblineas
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Ucbuslin2.Visible = True
            Me.Uclincre2.Visible = False
            Me.Ucgaslin2.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.ucbuslin2.Visible = True
            Me.uclincre2.Visible = False
            Me.ucgaslin2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.ucbuslin2.Visible = False
            Me.uclincre2.Visible = False
            Me.ucgaslin2.Visible = True

        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.ucbuslin2.Visible = False
            Me.uclincre2.Visible = True
            Me.ucgaslin2.Visible = False
        End If
    End Sub

    Private Sub ucbuslin_Seleccionado(ByVal codigoCliente As String) Handles ucbuslin2.Seleccionado

        If TabStrip1.SelectedIndex = 0 Then
            TabStrip1.SelectedIndex = 1
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            Ucgaslin2.CargarPorlinea(codigoCliente)

        End If
        If TabStrip1.SelectedIndex = 1 Then
            TabStrip1.SelectedIndex = 2
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            uclincre2.CargarPorlinea(codigoCliente)

        End If
    End Sub

End Class


