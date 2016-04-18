

Partial Class WbSuguno
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.wucfindcligru1.Visible = True
            Me.CUWSuguno1.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias1.Visible = False
            Me.CuwCom1.Visible = False
            Me.WUsRefCli1.Visible = False
            Dim ngrav As Double
            Session.Add(ngrav, 0)

        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.CUWSuguno1.Visible = False
            Me.wucfindcligru1.Visible = True
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias1.Visible = False
            Me.CuwCom1.Visible = False
            Me.WusRefCli1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.CUWSuguno1.Visible = True
            Me.wucfindcligru1.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias1.Visible = False
            Me.CuwCom1.Visible = False
            Me.WusRefCli1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.CUWSuguno1.Visible = False
            Me.wucfindcligru1.Visible = False
            Me.CuwPlan1.Visible = True
            Me.WUCGarantias1.Visible = False
            Me.CuwCom1.Visible = False
            Me.WusRefCli1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 3 Then
            Me.CUWSuguno1.Visible = False
            Me.wucfindcligru1.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias1.Visible = True
            Me.CuwCom1.Visible = False
            Me.WusRefCli1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 4 Then
            Me.CUWSuguno1.Visible = False
            Me.wucfindcligru1.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias1.Visible = False
            Me.CuwCom1.Visible = True
            Me.WusRefCli1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 5 Then
            Me.CUWSuguno1.Visible = False
            Me.wucfindcligru1.Visible = False
            Me.CuwPlan1.Visible = False
            Me.WUCGarantias1.Visible = False
            Me.CuwCom1.Visible = False
            Me.WusRefCli1.Visible = True
        End If

    End Sub

    Private Sub wucfindcligru1_Seleccionado(ByVal codigoCliente As String) Handles wucfindcligru1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        CUWSuguno1.CargarPorCliente(codigoCliente)
        WUCGarantias1.CargarPorCliente(codigoCliente)
        CuwCom1.CargarPorCliente(codigoCliente)
        CuwPlan1.CargarPlan(codigoCliente)
    End Sub
    Private Sub WUsRefCli1_Refinaciamiento(ByVal codigoCliente As String) Handles WusRefCli1.Refinanciamiento
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        CUWSuguno1.Refinaciamiento(codigoCliente)
        CuwCom1.CargarDatos()
    End Sub
End Class


