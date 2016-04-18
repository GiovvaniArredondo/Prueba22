Partial Class wbclientesf
    Inherits System.Web.UI.Page
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Auditoria()
            Me.WbFind1.Visible = False
            Me.WbUCLientes1.Visible = True
            Session.Add("codigocli", "")
            Me.WbUCLientes1.Restri(False)
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WbFind1.Visible = True
            WbUCLientes1.Visible = False

        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WbFind1.Visible = False
            WbUCLientes1.Visible = True

        End If
        

    End Sub

    Private Sub WbFind1_Seleccionado(ByVal codigoCliente As String) Handles WbFind1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        WbUCLientes1.CargarPorCliente(codigoCliente)
    End Sub
   
    Private Sub Auditoria()
        'Auditoria'
        Dim ip As Net.Dns
        Dim nombre_Host As String = ip.GetHostName
        Dim este_Host As Net.IPHostEntry = ip.GetHostByName(nombre_Host)
        Dim direccion_Ip As String = este_Host.AddressList(0).ToString
        Dim entidadusuarios As New usuarios
        Dim milogin As New cLogin
        Dim eusuarios As New cusuarios
        entidadusuarios.cip = direccion_Ip
        entidadusuarios.dfecha = Today
        entidadusuarios.chora = TimeOfDay.ToString.Substring(11, 12)
        entidadusuarios.idUsuario = milogin.IdUsuario(Session("gcCodusu"))
        entidadusuarios.gdfecsis = Session("gdfecsis")
        entidadusuarios.ctrs = "IN"
        entidadusuarios.idopcion = 2
        Try
            eusuarios.RegistraAuditoria(entidadusuarios)
        Catch ex As Exception

        End Try
    End Sub
End Class
