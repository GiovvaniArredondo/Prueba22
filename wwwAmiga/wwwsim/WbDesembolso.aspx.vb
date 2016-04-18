

Partial Class WbDesembolso
    Inherits System.Web.UI.Page


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.wucfindcligru1.Visible = True
            Me.WbDesemb1.Visible = False
            Me.WUsRefCli1.Visible = False

        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.wucfindcligru1.Visible = True
            Me.WbDesemb1.Visible = False
            Me.WUsRefCli1.Visible = False

        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.wucfindcligru1.Visible = False
            Me.WbDesemb1.Visible = True
            Me.WUsRefCli1.Visible = False

        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.wucfindcligru1.Visible = False
            Me.WbDesemb1.Visible = False
            Me.WUsRefCli1.Visible = True

        End If
        

    End Sub

    Private Sub wucfindcligru1_Seleccionado(ByVal codigoCliente As String) Handles wucfindcligru1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.WbDesemb1.CargarPorCliente(codigoCliente)

    End Sub

    Private Sub WUsRefCli1_Refinaciamiento(ByVal codigoCliente As String) Handles WUsRefCli1.Refinanciamiento
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.WbDesemb1.Refinaciamiento(codigoCliente)

    End Sub
End Class


