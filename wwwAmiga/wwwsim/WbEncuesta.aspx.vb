

Partial Class WbEncuesta
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            WbFind1.Visible = True
            Me.WbEncuestap1.Visible = False
            WbNBI1.Visible = False
            WbCBA1.visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            WbFind1.Visible = True
            Me.WbEncuestap1.Visible = False
            WbNBI1.Visible = False
            WbCBA1.visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            WbFind1.Visible = False
            Me.WbEncuestap1.Visible = True
            WbNBI1.Visible = False
            WbCBA1.visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            WbFind1.Visible = False
            Me.WbEncuestap1.Visible = False
            WbNBI1.Visible = True
            WbCBA1.visible = False
        End If
        If TabStrip1.SelectedIndex = 3 Then
            WbFind1.Visible = False
            Me.WbEncuestap1.Visible = False
            WbNBI1.Visible = False
            WbCBA1.visible = True
        End If

    End Sub

    Private Sub WbFind1_Seleccionado(ByVal codigoCliente As String) Handles WbFind1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        WbEncuestap1.CargarPorCliente(codigoCliente)
        WbNBI1.CargarPorCliente(codigoCliente)
        WbCBA1.CargarPorCliente(codigoCliente)

    End Sub

End Class


