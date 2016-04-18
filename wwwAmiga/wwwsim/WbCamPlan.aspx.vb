

Partial Class WbCamPlan
    Inherits System.Web.UI.Page

    'Protected WithEvents CUWPlan1 As CuwPlan
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.wucfindcligru1.Visible = True
            Me.WucChangePlan1.Visible = False
            '       Me.CUWPlan1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WUCchangeplan1.Visible = False
            Me.wucfindcligru1.Visible = True
            '      Me.CUWPlan1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WUCchangeplan1.Visible = True
            Me.wucfindcligru1.Visible = False
            '     Me.CUWPlan1.Visible = False
        End If
        '        If TabStrip1.SelectedIndex = 2 Then
        '       Me.WUCchangeplan1.Visible = False
        '      Me.WUCFindCre1.Visible = False
        '    Me.CUWPlan1.Visible = True
        '     End If

    End Sub

    Private Sub wucfindcligru1_Seleccionado(ByVal codigoCliente As String) Handles wucfindcligru1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        WucChangePlan1.CargarPorCliente(codigoCliente)
    End Sub
End Class


