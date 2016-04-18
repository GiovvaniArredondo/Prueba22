

Partial Class WbSolbcolote
    Inherits System.Web.UI.Page



    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            WbFindbc1.Visible = True
            Me.WbSollote1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            WbFindbc1.Visible = True
            Me.WbSollote1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            WbFindbc1.Visible = False
            Me.WbSollote1.Visible = True
        End If
    End Sub

    Private Sub WbFindbc1_Seleccionado(ByVal codigoCliente As String) Handles WbFindbc1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        WbSollote1.CargarPorCliente(codigoCliente)
    End Sub

End Class


