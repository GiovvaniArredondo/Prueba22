
Partial Class WbDigitaliza
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WbUCFindCred1.Visible = True
            WbUCUploadFotos1.Visible = False
            'Session("gcstatus") = 8
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WbUCFindCred1.Visible = True
            WbUCUploadFotos1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            WbUCFindCred1.Visible = False
            Me.WbUCUploadFotos1.Visible = True
        End If

    End Sub

    Private Sub WbUCFindCred1_Seleccionado(ByVal codigoCliente As String) Handles WbUCFindCred1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        WbUCUploadFotos1.CargarPorCliente(codigoCliente)
    End Sub
End Class
