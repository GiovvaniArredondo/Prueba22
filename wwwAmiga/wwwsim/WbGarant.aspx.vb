
Partial Class WbGarant
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then

            Dim clsppal As New class1
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "IN", 4)

            Me.WbFind1.Visible = True
            Me.WUsGarant1.Visible = False
            Me.WUsFindFia1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WbFind1.Visible = True
            Me.WUsGarant1.Visible = False
            Me.WUsFindFia1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WbFind1.Visible = False
            Me.WUsGarant1.Visible = True
            Me.WUsFindFia1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.WbFind1.Visible = False
            Me.WUsGarant1.Visible = False
            Me.WUsFindFia1.Visible = True
        End If

    End Sub
    Private Sub WbFind1_Seleccionado(ByVal codigoCliente As String) Handles WbFind1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.WUsGarant1.CargarPorCliente(codigoCliente)
    End Sub
    '
    Private Sub WUsFindFia1_Codeudor(ByVal codigoCliente As String) Handles WUsFindFia1.Codeudor
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.WUsGarant1.CargaFiador(codigoCliente)
    End Sub
End Class
