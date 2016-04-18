
Partial Class WbDispersaGar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.WbUCDispersaGar2.limpieza()
        End If
    End Sub
End Class
