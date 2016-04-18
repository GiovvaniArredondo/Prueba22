

Partial Class WbAdmRpt
    Inherits System.Web.UI.Page


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Usmodrep11.Visible = True
            Me.usgenrep11.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.usgenrep11.Visible = False
            Me.Usmodrep11.Visible = True
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.usgenrep11.Visible = True
            Me.Usmodrep11.Visible = False
        End If
    End Sub

End Class


