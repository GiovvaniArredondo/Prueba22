

Partial Class wbregistro
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.ucbususu1.Visible = True
            Me.ucregistro1.Visible = False
            Me.uccreausu1.Visible = False
        End If
    End Sub

    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.ucbususu1.Visible = True
            Me.ucregistro1.Visible = False
            Me.uccreausu1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.ucbususu1.Visible = False
            Me.ucregistro1.Visible = True
            Me.uccreausu1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.ucbususu1.Visible = False
            Me.ucregistro1.Visible = False
            Me.uccreausu1.Visible = True
        End If
    End Sub

    Private Sub ucbususu_Seleccionado(ByVal codigoCliente As String) Handles ucbususu1.Seleccionado
        If TabStrip1.SelectedIndex = 0 Then
            TabStrip1.SelectedIndex = 1
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            'uccreausu1.CargarPorusu(codigoCliente)
            ucregistro1.CargarPorusu(codigoCliente)

        End If
        If TabStrip1.SelectedIndex = 1 Then
            TabStrip1.SelectedIndex = 2
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            uccreausu1.CargarPorusu(codigoCliente)
        End If
    End Sub

End Class


