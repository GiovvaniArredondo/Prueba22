

Partial Class WbAdParBan
    Inherits System.Web.UI.Page


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WbUsParBan1.Visible = True
            Me.WbUsCatal1.Visible = False
            Me.WbUsFindPartBan1.Visible = False
        End If
    End Sub
    Private Sub Tabstrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WbUsParBan1.Visible = True
            Me.WbUsCatal1.Visible = False
            Me.WbUsFindPartBan1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WbUsParBan1.Visible = False
            Me.WbUsCatal1.Visible = True
            Me.WbUsFindPartBan1.Visible = False
        End If

        If TabStrip1.SelectedIndex = 2 Then
            Me.WbUsParBan1.Visible = False
            Me.WbUsCatal1.Visible = False
            Me.WbUsFindPartBan1.Visible = True
        End If
    End Sub
    Private Sub WbUsCatal1_CargarCuenta(ByVal codigoCliente As String) Handles WbUsCatal1.CargarCuenta
        TabStrip1.SelectedIndex = 0
        Tabstrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.WbUsParBan1.CargarCuenta(codigoCliente)

    End Sub

    Private Sub WbUsFindPartBan1_CargarPartida(ByVal codigoCliente As String) Handles WbUsFindPartBan1.CargarPartida
        Dim clssconta As New clsConta
        Dim lccadena As String
        Dim lcmesvig As String
        Dim lcyears As String
        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig.Trim, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

        TabStrip1.SelectedIndex = 0
        Tabstrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.WbUsParBan1.CargarNoPartida(codigoCliente) ', Session("gcfondo"), lccadena


    End Sub
End Class
