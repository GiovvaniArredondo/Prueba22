
Partial Class WbpruebaX
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.wubPruebax1.Carga_Inicia()
        End If
    End Sub

    Private Sub WbUCFindCred1_Seleccionado(ByVal codigoCliente As String) Handles WbUCFindCred1.Seleccionado
        wubPruebax1.CargarDatosPorCuenta(codigoCliente)
        Me.TabContainer1.ActiveTabIndex = 1
    End Sub

    
End Class
