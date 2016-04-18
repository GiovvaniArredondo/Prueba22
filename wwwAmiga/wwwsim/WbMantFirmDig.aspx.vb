
Partial Class WbMantFirmDig
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.WbUCFirmDig1.Carga_inicial()
        End If
    End Sub
End Class
