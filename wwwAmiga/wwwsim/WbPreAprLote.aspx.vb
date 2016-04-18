

Partial Class WbPreAprLote
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim ngrav As Double
            Session.Add(ngrav, 0)

            Me.WFindCreGB2.Visible = True
            Me.CUWPreAprLote3.Visible = False
            Me.CuwPlanGB2.Visible = False
            CuwComg2.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.CUWPreAprLote3.Visible = False
            Me.WFindCreGB2.Visible = True
            Me.CuwPlanGB2.Visible = False
            CuwComg2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.CUWPreAprLote3.Visible = True
            Me.WFindCreGB2.Visible = False
            Me.CuwPlanGB2.Visible = False
            CuwComg2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.CUWPreAprLote3.Visible = False
            Me.WFindCreGB2.Visible = False
            Me.CuwPlanGB2.Visible = True
            CuwComg2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 3 Then
            Me.CUWPreAprLote3.Visible = False
            Me.WFindCreGB2.Visible = False
            Me.CuwPlanGB2.Visible = False
            CuwComg2.Visible = True
        End If


    End Sub

    Private Sub WFindCreGB1_Seleccionado(ByVal codigoCliente As String) Handles WFindCreGB2.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        CUWPreAprLote3.CargarPorCliente(codigoCliente)
        CuwComg2.CargarPorCliente(codigoCliente)
        'CuwPlanGB1.CargarPlan(codigoCliente)

    End Sub

End Class


