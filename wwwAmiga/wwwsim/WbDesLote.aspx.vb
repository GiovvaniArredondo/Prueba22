

Partial Class WbDesLote
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WFindCreGB2.Visible = True
            Me.wbdesembg2.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.wbdesembg2.Visible = False
            Me.WFindCreGB2.Visible = True
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.wbdesembg2.Visible = True
            Me.WFindCreGB2.Visible = False
        End If
    End Sub

    Private Sub WFindCreGB1_Seleccionado(ByVal codigoCliente As String) Handles WFindCreGB2.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        wbdesembg2.CargarPorCliente(codigoCliente)
    End Sub

   
End Class


