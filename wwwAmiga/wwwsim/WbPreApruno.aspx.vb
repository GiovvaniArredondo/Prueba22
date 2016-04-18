

Partial Class WbPreApruno
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim ngrav As Double
            Session.Add(ngrav, 0)

            Me.wucfindcligru2.Visible = True
            Me.CUWPreAprInd1.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias2.Visible = False
            Me.CuwCom1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.CUWPreAprInd1.Visible = False
            Me.wucfindcligru2.Visible = True
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias2.Visible = False
            Me.CuwCom1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.CUWPreAprInd1.Visible = True
            Me.wucfindcligru2.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias2.Visible = False
            Me.CuwCom1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.CUWPreAprInd1.Visible = False
            Me.wucfindcligru2.Visible = False
            Me.CuwPlan1.Visible = True
            Me.WUCGarantias2.Visible = False
            Me.CuwCom1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 3 Then
            Me.CUWPreAprInd1.Visible = False
            Me.wucfindcligru2.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias2.Visible = True
            Me.CuwCom1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 4 Then
            Me.CUWPreAprInd1.Visible = False
            Me.wucfindcligru2.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias2.Visible = False
            Me.CuwCom1.Visible = True
        End If

    End Sub

    Private Sub wucfindcligru1_Seleccionado(ByVal codigoCliente As String) Handles wucfindcligru2.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        CUWPreAprInd1.CargarPorCliente(codigoCliente)
        WUCGarantias2.CargarPorCliente(codigoCliente)
        CuwCom1.CargarPorCliente(codigoCliente)
        CuwPlan1.CargarPlan(codigoCliente)
    End Sub

End Class


