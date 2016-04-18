

Partial Class WbLinAho
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.lineas_ahorro1.Cargar_Inicial()
        End If
    End Sub


    Private Sub WbUCfindlinAho_Seleccionado(ByVal codigoCliente As String) Handles WbUCfindlinAho1.Seleccionado
        Me.TabContainer1.ActiveTabIndex = 1
        lineas_ahorro1.CargarPorlinea(codigoCliente)
    End Sub
End Class


