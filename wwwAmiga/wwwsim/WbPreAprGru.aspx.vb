

Partial Class WbPreAprGru
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim ngrav As Double
            Session.Add(ngrav, 0)

            Me.WUCFindGru1.Visible = True
            Me.CUWPreAprInd1.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.CUWPreAprInd1.Visible = False
            Me.WUCFindGru1.Visible = True
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.CUWPreAprInd1.Visible = True
            Me.WUCFindGru1.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.CUWPreAprInd1.Visible = False
            Me.WUCFindGru1.Visible = False
            Me.CuwPlan1.Visible = True
            Me.WUCGarantias1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 3 Then
            Me.CUWPreAprInd1.Visible = False
            Me.WUCFindGru1.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias1.Visible = True
        End If

    End Sub

    Private Sub WUCFindGru1_Seleccionado(ByVal codigoCliente As String) Handles WUCFindGru1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        CUWPreAprInd1.CargarPorCliente(codigoCliente)
        WUCGarantias1.CargarPorCliente(codigoCliente)
    End Sub

End Class


