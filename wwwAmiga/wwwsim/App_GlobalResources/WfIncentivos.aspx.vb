

Partial Class WfIncentivos
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.ucIncentivos1.Visible = True
            Me.ucIncentivos_Par1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.ucIncentivos1.Visible = True
            Me.ucIncentivos_Par1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.ucIncentivos1.Visible = False
            Me.ucIncentivos_Par1.Visible = True

        End If
    End Sub



End Class


