

Partial Class wbJuridico
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim clsppal As New class1
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "IN", 115)
            Me.WbFind1.Visible = False
            Me.WbUJuridico1.Visible = True
            '   Me.wucSocioEco1.Visible = False
            Session.Add("codigocli", "")
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WbFind1.Visible = True
            WbUJuridico1.Visible = False
            '  wucSocioEco1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WbFind1.Visible = False
            WbUJuridico1.Visible = True
            ' wucSocioEco1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.WbFind1.Visible = False
            WbUJuridico1.Visible = False
            'wucSocioEco1.Visible = True
            'wucSocioEco1.CargaCliente()
            'wucSocioEco1.CargarPorCliente(Session("codigocli"))
        End If

    End Sub

    Private Sub WbFind1_Seleccionado(ByVal codigoCliente As String) Handles WbFind1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        WbUJuridico1.CargarPorCliente(codigoCliente)
        'wucSocioEco1.CargarPorCliente(codigoCliente)
    End Sub
End Class


