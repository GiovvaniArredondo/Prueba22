

Partial Class pcambio
    Inherits System.Web.UI.Page

    Protected WithEvents WUCchangeplan1 As wucChangePlan
    Protected WithEvents CuwPlan1 As CuwPlan
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WUCFindCre1.Visible = True
            Me.WUCchangeplan1.Visible = False
            Me.CuwPlan1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WUCchangeplan1.Visible = False
            Me.WUCFindCre1.Visible = True
            Me.CuwPlan1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WUCchangeplan1.Visible = True
            Me.WUCFindCre1.Visible = False
            Me.CuwPlan1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.WUCchangeplan1.Visible = False
            Me.WUCFindCre1.Visible = False
            Me.CuwPlan1.Visible = True
        End If

    End Sub

    Private Sub WUCFindCre1_Seleccionado(ByVal codigoCliente As String) Handles WUCFindCre1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        WUCchangeplan1.CargarPorCliente(codigoCliente)
    End Sub

End Class


