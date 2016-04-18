

Partial Class WbAdchqs
    Inherits System.Web.UI.Page


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WbUsCAdChq1.Visible = True
            Me.WbUsCatal1.Visible = False
            Me.WbUsFindChq1.Visible = False
        End If
    End Sub

    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WbUsCAdChq1.Visible = True
            Me.WbUsCatal1.Visible = False
            Me.WbUsFindChq1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WbUsCAdChq1.Visible = False
            Me.WbUsCatal1.Visible = True
            Me.WbUsFindChq1.Visible = False
        End If

        If TabStrip1.SelectedIndex = 2 Then
            Me.WbUsCAdChq1.Visible = False
            Me.WbUsCatal1.Visible = False
            Me.WbUsFindChq1.Visible = True
        End If

    End Sub

    Private Sub WbUsCatal1_CargarCuenta(ByVal codigoCliente As String) Handles WbUsCatal1.CargarCuenta
        TabStrip1.SelectedIndex = 0
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.WbUsCAdChq1.CargarCuenta(codigoCliente)

    End Sub

    Private Sub WbUsFindChq1_CargarPartida(ByVal codigoCliente As String) Handles WbUsFindChq1.CargarPartida
        TabStrip1.SelectedIndex = 0
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.WbUsCAdChq1.CargarNoPartida(codigoCliente)
    End Sub
End Class


