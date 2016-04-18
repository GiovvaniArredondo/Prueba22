

Partial Class wbcertif
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.ucbuscer1.Visible = True
            Me.ucadiccer1.Visible = False
            Me.ucbenefi1.Visible = False
            Me.wbfind1.Visible = False
            Me.ucbusaho1.Visible = False
        End If
    End Sub

    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.ucbuscer1.Visible = True
            Me.ucadiccer1.Visible = False
            Me.ucbenefi1.Visible = False
            Me.wbfind1.Visible = False
            Me.ucbusaho1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.ucbuscer1.Visible = False
            Me.ucadiccer1.Visible = True
            Me.ucbenefi1.Visible = False
            Me.wbfind1.Visible = False
            Me.ucbusaho1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.ucbuscer1.Visible = False
            Me.ucadiccer1.Visible = False
            Me.ucbenefi1.Visible = True
            Me.wbfind1.Visible = False
            Me.ucbusaho1.Visible = False

        End If
        If TabStrip1.SelectedIndex = 3 Then
            Me.ucbuscer1.Visible = False
            Me.ucadiccer1.Visible = False
            Me.ucbenefi1.Visible = False
            Me.wbfind1.Visible = True
            Me.ucbusaho1.Visible = False
        End If

        If TabStrip1.SelectedIndex = 4 Then
            Me.ucbuscer1.Visible = False
            Me.ucadiccer1.Visible = False
            Me.ucbenefi1.Visible = False
            Me.wbfind1.Visible = False
            Me.ucbusaho1.Visible = True
        End If

    End Sub

    Private Sub ucbuscer1_Seleccionado(ByVal codigocertificado As String) Handles ucbuscer1.Seleccionado
        If TabStrip1.SelectedIndex = 0 Then
            TabStrip1.SelectedIndex = 1
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            ucadiccer1.CargarPorcertificado(codigocertificado)
        End If
        If TabStrip1.SelectedIndex = 1 Then
            TabStrip1.SelectedIndex = 2
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            ucbenefi1.CargarPorcertificado(codigocertificado)
            ucadiccer1.CargarPorcertificado(codigocertificado)

        End If
    End Sub

    Private Sub wbfind1_Seleccionado(ByVal codigocliente As String) Handles wbfind1.Seleccionado
        If TabStrip1.SelectedIndex = 3 Then
            TabStrip1.SelectedIndex = 1
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            Me.ucadiccer1.CargarPorCliente(codigocliente)
        End If
    End Sub

    Private Sub ucbusaho_Seleccionado(ByVal cuentaahorro As String) Handles ucbusaho1.Seleccionado
        If TabStrip1.SelectedIndex = 4 Then
            TabStrip1.SelectedIndex = 1
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            Me.ucadiccer1.CargarPorcuentaahorro(cuentaahorro)
        End If
    End Sub

End Class


