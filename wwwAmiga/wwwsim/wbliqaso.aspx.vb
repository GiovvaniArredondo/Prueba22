

Partial Class wbliqaso
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.wbfind1.Visible = True
            Me.ucliquida1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.wbfind1.Visible = True
            Me.ucliquida1.Visible = False
        End If

        If TabStrip1.SelectedIndex = 1 Then
            Me.wbfind1.Visible = False
            Me.ucliquida1.Visible = True
        End If
    End Sub

    Private Sub ucbusaho1_Seleccionado(ByVal codigoCliente As String) Handles wbfind1.Seleccionado
        If TabStrip1.SelectedIndex = 0 Then
            TabStrip1.SelectedIndex = 1
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            ucliquida1.CargarDatosPorCuenta(codigoCliente)
        End If
    End Sub

End Class


