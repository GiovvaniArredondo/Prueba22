
Partial Class WbModCtas_Aho
    Inherits System.Web.UI.Page



    Protected Sub WbUCtasAhoMod1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles WbUCtasAhoMod1.Load
        If Not IsPostBack Then
            Me.WbUCtasAhoMod1.Cargar_Datos()
        End If
    End Sub
End Class
