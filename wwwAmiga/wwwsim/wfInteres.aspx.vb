

Partial Class wfInteres
    Inherits System.Web.UI.Page


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WUCFindCre1.Visible = True
            Me.CuwInteres1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WUCFindCre1.Visible = True
            Me.CuwInteres1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WUCFindCre1.Visible = False
            Me.CuwInteres1.Visible = True
        End If

    End Sub

    Private Sub WUCFindCre1_Seleccionado(ByVal codigoCliente As String) Handles WUCFindCre1.Seleccionado
        If TabStrip1.SelectedIndex = 0 Then
            TabStrip1.SelectedIndex = 1
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            Me.CuwInteres1.CargarDatosPorCuenta(codigoCliente)
        End If


    End Sub
End Class


