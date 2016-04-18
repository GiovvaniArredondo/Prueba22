
Partial Class WfEstFin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.WbUsBalance1.Visible = True
            Me.WbUsVentas1.Visible = False
            Dim nventas As Double

        End If
        
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WbUsBalance1.Visible = True
            Me.WbUsVentas1.Visible = False
            TabStrip1.SelectedIndex = 0
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WbUsBalance1.Visible = False
            Me.WbUsVentas1.Visible = True
            TabStrip1.SelectedIndex = 1
        End If
    End Sub

End Class
