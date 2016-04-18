Partial Class Wbcamgrupo
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WUCFindCre1.Visible = True
            Me.Cuwcamcentro1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.Cuwcamcentro1.Visible = False
            Me.WUCFindCre1.Visible = True
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.Cuwcamcentro1.Visible = True
            Me.WUCFindCre1.Visible = False
        End If
    End Sub

    Private Sub WUCFindCre2_Seleccionado(ByVal codigoCliente As String) Handles WUCFindCre1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Cuwcamcentro1.CargarPorCliente(codigoCliente)
    End Sub

End Class


