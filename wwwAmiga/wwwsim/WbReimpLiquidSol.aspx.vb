
Partial Class WbReimpLiquidSol
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WFindCreGB2.Visible = True
            Me.ucReCompDesembolso1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WFindCreGB2.Visible = True
            Me.ucReCompDesembolso1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WFindCreGB2.Visible = False
            Me.ucReCompDesembolso1.Visible = True
        End If

    End Sub

    Protected Sub WFindCreGB1_Reimpresion(ByVal codigoCliente As String) Handles WFindCreGB2.Seleccionado
        'Me.ucReCompDesembolso1.ActualizaBandera("3")
        'Me.ucReCompDesembolso1.CargaDatos(ccodcta, cnomcli, fecha)
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.ucReCompDesembolso1.CargarPorCliente(codigoCliente)
        'Me.ucReCompDesembolso1.Visible = True
    End Sub

End Class
